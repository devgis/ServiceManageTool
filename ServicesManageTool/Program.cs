using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LNS.ServicesManageTool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Threading.Mutex mutex = new System.Threading.Mutex(false, "ServicesManageToolShouldOnlyRunOnce6702f686-577f-467a-a9d0-574b599fe082");
            bool Running = !mutex.WaitOne(0, false);
            if (!Running)
                Application.Run(new Main());
            else
            {
                MessageBox.Show("程序已经启动!",
                PublicDim.SystemCatpion, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
