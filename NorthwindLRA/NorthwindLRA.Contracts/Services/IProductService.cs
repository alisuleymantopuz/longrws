using NorthwindLRA.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLRA.Contracts.Services
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<ProductInfo> SearchProducts();
    }
}
