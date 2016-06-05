using Autofac;
using NorthwindLRA.Contracts.Services;
using NorthwindLRA.IoC.HostInitialization;
using NorthwindLRA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLRA.Managed
{
    public class ProductServiceHostInitializer : ServiceHostInitializerBase<ProductService, IProductService>
    {
        public ProductServiceHostInitializer(ILifetimeScope lifetimeScope)
            : base(lifetimeScope)
        {

        }
    }
}
