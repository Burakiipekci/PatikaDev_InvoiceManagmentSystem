using AutoMapper;
using InvoiceManagmentSystem.Business.Abstract;
using InvoiceManagmentSystem.Core.Entity.Concrete;
using InvoiceManagmentSystem.Core.Utilities.Results;
using InvoiceManagmentSystem.Core.Utilities.Security.Hashing;
using InvoiceManagmentSystem.Core.Utilities.Security.JWT;
using InvoiceManagmentSystem.Entity.Concrete;
using InvoiceManagmentSystem.Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        IMapper _mapper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper, IMapper mapper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _mapper = mapper;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var result = _mapper.Map<User>(userForRegisterDto);
                _userService.Add(result);
            return new SuccessDataResult<User>(result, "User registered");
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>("User not Found");
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>("Password Error");
            }

            return new SuccessDataResult<User>(userToCheck, "Success Login");
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult("User Already Exist");
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "AccesTokenCreated");
        }
    }
}
