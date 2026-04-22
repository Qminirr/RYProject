using RY.Base;
using RY.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace RYProject
{
    public partial class G : GBase
    {
        [RYMethodDelegate("初始化设备", eMethodType.正常, "初始化设备")]
        public static eCode InitMachine()
        {
            _SetOutIO(eOut.测试OK, eSwitch.Off);
            _SetOutIO(eOut.测试NG, eSwitch.Off);
            //初始化各类传感器
            Thread.Sleep(3000);
            return eCode.OK;
        }

        [RYMethodDelegate("等待网络消息", eMethodType.正常, "等待网络消息")]
        public static eCode WaitClientMsg()
        {
            //TCPServerBase server = DeviceFactory.GetFirstOrDefaultDevice<TCPServerBase>();
            TCPServerBase server = DeviceFactory.GetDevice<TCPServerBase>("服务器");
            if (server==null)
            {
                UserLog.AddErrorMsg("服务器设备未获得");
                return eCode.NG;
            }
            if(server.HasMsg())
            {
                string client = "";
                string msg = server.FetchHeadMsg(ref client);
                if (string.IsNullOrEmpty(msg)) return eCode.Again;
                switch(msg.ToLower())
                {
                    case "start":
                        UserLog.AddRunMsg("收到消息：" + msg);
                        break;
                    default:
                        RunCommand(msg);
                        break;
                }
                server.Send(client, "已执行命令:" + msg);
            }
            return eCode.Again;
        }

        [RYMethodDelegate("读码器扫码", eMethodType.正常, "读码器扫码")]
        public static eCode ReadQRCode()
        {
            ReaderBase rb = DeviceFactory.GetDevice<ReaderBase>("读码器");
            if(rb==null)
            {
                UserLog.AddErrorMsg("无法取得扫码器设备");
                return eCode.NG;
            }
            if(!rb.ReadOne(3000))
            {
                UserLog.AddErrorMsg("读码器扫码超时");
                return eCode.NG;
            }
            if(rb.HasData())
            {
                UserLog.AddRunMsg("读取到的二维码：" + rb.DataString);
                return eCode.OK;
            }
            UserLog.AddErrorMsg("竟然没读到");
            return eCode.NG;
        }

        [RYMethodDelegate("移动到取料位置", eMethodType.正常, "移动到取料位置")]
        public static eCode MoveToFetchPos(int timeout)
        {
            if(!SC.FetchPos.Move(timeout))
            {
                UserLog.AddErrorMsg("移动到取料位置失败");
                return eCode.NG;
            }
            return eCode.OK;
        }
        [RYMethodDelegate("移动到测试位置", eMethodType.正常, "移动到测试位置")]
        public static eCode MoveToTestPos(int timeout)
        {
            if (!SC.TestPos.Move(timeout))
            {
                UserLog.AddErrorMsg("移动到测试位置失败");
                return eCode.NG;
            }
            return eCode.OK;
        }
        [RYMethodDelegate("移动到放料位置", eMethodType.正常, "移动到放料位置")]
        public static eCode MoveToPutPos(int timeout)
        {
            if (!SC.OutPos.Move(timeout))
            {
                UserLog.AddErrorMsg("移动到放料位置失败");
                return eCode.NG;
            }
            return eCode.OK;
        }

        [RYMethodDelegate("移动到NG位置", eMethodType.正常, "移动到NG位置")]
        public static eCode MoveToNGPos(int timeout)
        {
            if (!SC.NGPos.Move(timeout))
            {
                UserLog.AddErrorMsg("移动到NG位置失败");
                return eCode.NG;
            }
            return eCode.OK;
        }

        [RYMethodDelegate("夹爪取料", eMethodType.正常, "夹爪取料")]
        public static eCode HandHold()
        {
            if(IOCtrl.SetOutPin(eOut.夹爪放料.ToString(), eSwitch.Off)&&IOCtrl.SetOutPin(eOut.夹爪抓料.ToString(),eSwitch.On)) return eCode.OK;
            return eCode.NG;
        }



        [RYMethodDelegate("夹爪放料", eMethodType.正常, "夹爪放料")]
        public static eCode HandRelease()
        {
            if (IOCtrl.SetOutPin(eOut.夹爪放料.ToString(), eSwitch.On) && IOCtrl.SetOutPin(eOut.夹爪抓料.ToString(), eSwitch.Off)) return eCode.OK;
            return eCode.NG;
        }
        [RYMethodDelegate("夹爪移动到安全位置", eMethodType.正常, "夹爪移动到安全位置")]
        public static eCode HandSafePos(int timeout=10000)
        {
            if (!SC.HandSafePos.Move(timeout))
            {
                UserLog.AddErrorMsg("夹爪移动到安全位置失败");
                return eCode.NG;
            }
            return eCode.OK;
        }

        [RYMethodDelegate("测试产品", eMethodType.正常, "测试产品")]
        public static eCode TestProc()
        {
            _SetOutIO(eOut.测试OK, eSwitch.Off);
            _SetOutIO(eOut.测试NG, eSwitch.Off);
            Random rnd= new Random();
            int i = rnd.Next(100);
            bool testok = false;
            if(i%2==0)
            {
                testok = true;
            }
            WaitTimer.Sleep(2000);
            if(testok)
            {
                _SetOutIO(eOut.测试OK, eSwitch.On);
            }
            else
            {
                _SetOutIO(eOut.测试NG, eSwitch.On);
            }
            return eCode.OK;
        }


        #region 通用功能

        [RYMethodDelegate("【通用】等待IO", eMethodType.通用, "等待IO")]
        public static eCode WaitIO(eOut io,eSwitch sw)
        {
            if (IOCtrl.GetOutPin(io.ToString()) == sw) return eCode.OK;
            return eCode.Again;
        }

        [RYMethodDelegate("【通用】测试IO状态", eMethodType.通用, "测试IO状态")]
        public static eCode TestIO(eOut io,eSwitch sw)
        {
            if (IOCtrl.GetOutPin(io.ToString()) == sw) return eCode.OK;
            return eCode.NG;
        }

        [RYMethodDelegate("【通用】设置IO状态", eMethodType.通用, "设置IO状态")]
        public static eCode SetIO(eOut io, eSwitch sw)
        {
            if (IOCtrl.SetOutPin(io.ToString(),sw)) return eCode.OK;
            return eCode.NG;
        }

        #endregion
    }
}
