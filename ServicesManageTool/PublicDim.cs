using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;

namespace LNS.ServicesManageTool
{
    public class PublicDim
    {
        #region 静态属性
        public static String StartCatpion="启动";
        public static String StopCatpion = "停止";
        public static String SystemCatpion = "系统提示";
        public static String LNSEnvironmentVariable = "LNS_ROOT";
        public static String WaitString = "处理中，请稍等 …………";
        #endregion

        #region 静态方法
        public static bool StartService(string serviceName)
        {
            try
            {
                ServiceController service = new ServiceController(serviceName);
                if (service.Status == ServiceControllerStatus.Running)
                {
                    return true;
                }
                else
                {
                    TimeSpan timeout = TimeSpan.FromMilliseconds(1000 * 60);
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool StopService(string serviseName)
        {
            try
            {
                ServiceController service = new ServiceController(serviseName);
                if (service.Status == ServiceControllerStatus.Stopped)
                {
                    return true;
                }
                else
                {
                    TimeSpan timeout = TimeSpan.FromMilliseconds(1000 * 60);
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}
