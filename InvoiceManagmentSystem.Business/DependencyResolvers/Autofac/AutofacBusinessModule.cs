using Autofac;
using Autofac.Extras.DynamicProxy;
using InvoiceManagmentSystem.Business.Abstract;
using InvoiceManagmentSystem.Business.Concrete;
using InvoiceManagmentSystem.Core.DTO;
using InvoiceManagmentSystem.Core.Utilities.Interceptor;
using InvoiceManagmentSystem.Core.Utilities.Security.JWT;
using InvoiceManagmentSystem.DataAccess.Abstract;
using InvoiceManagmentSystem.DataAccess.Concrete.EntityFramework;
using InvoiceManagmentSystem.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace InvoiceManagmentSystem.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            
            
            
            
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            builder.RegisterType<InvoiceManagementSystemDbContext>();




            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new Castle.DynamicProxy.ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                });
        
        }
    }
    }

