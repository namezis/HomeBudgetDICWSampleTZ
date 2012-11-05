using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.Windsor;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using System.Configuration;

namespace HomeBudget.Web
{
    public class WebAppContainer : WindsorContainer
    {
        public WebAppContainer()
        {

            // Connection strings
            string sHomeBudgetDataAccess = ConfigurationManager.AppSettings["HomeBudgetDataAccess"];
            if (sHomeBudgetDataAccess == null)
            {
                throw new ArgumentNullException("HomeBudgetDataAccess");
            }

            // Data Access classess
            Register(Classes.FromAssemblyNamed(sHomeBudgetDataAccess)
                .BasedOn(typeof(Domain.Repositories.AccountRepository))
                .WithServiceBase()
            );

            Register(Classes.FromAssemblyNamed(sHomeBudgetDataAccess)
                .BasedOn(typeof(Domain.Repositories.ReceiptRepository))
                .WithServiceBase()
            );

            // Domain Logic classess
            Register(Classes.FromAssemblyNamed("HomeBudgetDomain")
                .BasedOn(typeof(Domain.Services.AccountService))
            );

            Register(Classes.FromAssemblyNamed("HomeBudgetDomain")
                .BasedOn(typeof(Domain.Services.ReceiptService))
            );
        }
    }
}