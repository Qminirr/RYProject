using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel; // WCF核心命名空间
namespace RYSimpleWCF
{

    // 必须添加[ServiceContract]特性，解决“不具备ServiceContractAttribute特性”错误
    [ServiceContract(Namespace = "http://localhost:8080/RYWcfService")]
    public interface IRYSimpleWcfService
    {
        // WCF中用[OperationContract]替代[WebMethod]，标记可公开调用的方法
        [OperationContract]
        DateTime GetTime();

        [OperationContract]
        int Add(int a,int b);
    }
    public class RYWcfService : IRYSimpleWcfService
    {
        public DateTime GetTime()
        {
            return DateTime.Now;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
