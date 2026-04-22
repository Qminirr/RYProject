using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace RYSimpleWCF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceHost wcfServiceHost = null;

            try
            {
                // 1. 实例化 ServiceHost
                // 参数1：服务实现类的类型（UserService）
                // 参数2：服务基地址（自定义端口，避免冲突，格式：协议://IP:端口/服务名称）
                string serviceBaseUrl = "http://localhost:8080/RYWcfService";
                wcfServiceHost = new ServiceHost(typeof(RYWcfService), new Uri(serviceBaseUrl));

                // 2. 配置绑定方式（BasicHttpBinding：简单易用，兼容SOAP 1.1，支持跨平台调用）
                BasicHttpBinding httpBinding = new BasicHttpBinding();
                // 可选配置：设置最大消息大小（避免传输大对象时报错）
                httpBinding.MaxReceivedMessageSize = 1024 * 1024 * 5; // 5MB
                // 可选配置：设置超时时间
                httpBinding.OpenTimeout = TimeSpan.FromSeconds(30);
                httpBinding.CloseTimeout = TimeSpan.FromSeconds(30);
                httpBinding.SendTimeout = TimeSpan.FromSeconds(60);
                httpBinding.ReceiveTimeout = TimeSpan.FromSeconds(60);

                // 3. 添加服务终结点（WCF核心：ABC三要素 - 契约(Contract)、绑定(Binding)、地址(Address)）
                // 参数1：服务契约接口类型（IUserService）
                // 参数2：绑定实例（httpBinding）
                // 参数3：终结点相对地址（可留空，直接使用基地址）
                wcfServiceHost.AddServiceEndpoint(typeof(IRYSimpleWcfService), httpBinding, "");

                // 4. 启用元数据交换（关键：允许客户端通过地址发现服务、添加服务引用）
                ServiceMetadataBehavior metadataBehavior = new ServiceMetadataBehavior();
                metadataBehavior.HttpGetEnabled = true; // 允许HTTP协议获取元数据
                metadataBehavior.HttpGetUrl = new Uri(serviceBaseUrl); // 元数据访问地址（与服务基地址一致）
                wcfServiceHost.Description.Behaviors.Add(metadataBehavior);

                // 5. 启动 ServiceHost（启动WCF服务，开始监听客户端请求）
                wcfServiceHost.Open();

                // 输出服务状态信息
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("======================================");
                Console.WriteLine("WCF服务启动成功！");
                Console.WriteLine($"服务基地址：{serviceBaseUrl}");
                Console.WriteLine($"元数据地址：{serviceBaseUrl}?wsdl");
                Console.WriteLine("服务状态：" + wcfServiceHost.State);
                Console.WriteLine("======================================");
                Console.ResetColor();
                Console.WriteLine("按任意键停止服务...");

                // 阻塞线程，等待用户输入（避免程序直接退出）
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("======================================");
                Console.WriteLine("WCF服务启动/运行失败！");
                Console.WriteLine("错误信息：" + ex.Message);
                Console.WriteLine("======================================");
                Console.ResetColor();
                Console.WriteLine("按任意键退出...");
                Console.ReadKey();
            }
            finally
            {
                // 6. 停止 ServiceHost，释放资源（优雅关闭）
                if (wcfServiceHost != null)
                {
                    // 判断服务状态：仅当服务处于打开/正在打开状态时，执行关闭操作
                    if (wcfServiceHost.State == CommunicationState.Opened ||
                        wcfServiceHost.State == CommunicationState.Opening)
                    {
                        wcfServiceHost.Close(); // 优雅关闭：等待正在处理的请求完成后释放资源
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("WCF服务已优雅关闭！");
                        Console.ResetColor();
                    }
                    else if (wcfServiceHost.State == CommunicationState.Faulted)
                    {
                        wcfServiceHost.Abort(); // 强制终止：服务异常时，立即释放资源
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("WCF服务已强制终止！");
                        Console.ResetColor();
                    }
                    wcfServiceHost = null;
                }
            }
        }
    }
}
