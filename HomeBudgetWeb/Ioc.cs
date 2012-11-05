using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.Windsor;

namespace HomeBudget.Web
{
    public static class Ioc
    {
        public static WebAppContainer Container
        {
            get
            {
                IContainerAccessor containerAccessor = HttpContext.Current.ApplicationInstance as IContainerAccessor;
                if (containerAccessor != null)
                {
                    return (WebAppContainer)containerAccessor.Container;
                }
                throw new Exception("Unable to get container accessor.");
            }
        }
    }
}