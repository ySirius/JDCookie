using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDCookie
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var dir = Path.Combine(Environment.CurrentDirectory, "runtimes\\win-x64\\native");
            if (!Directory.Exists(dir)) {
                Directory.CreateDirectory(dir);
            }
            ExtractResFile("JDCookie.WebView2Loader.dll", Environment.CurrentDirectory + "\\runtimes\\win-x64\\native\\WebView2Loader.dll");
            Application.Run(new FrmMain());
        }

        /// <summary>
        /// 从资源文件中抽取资源文件
        /// </summary>
        /// <param name="resFileName">资源文件名称（资源文件名称必须包含目录，目录间用“.”隔开,最外层是项目默认命名空间）</param>
        /// <param name="outputFile">输出文件</param>
        public static void ExtractResFile(string resFileName, string outputFile)
        {
            BufferedStream inStream = null;
            FileStream outStream = null;
            try
            {
                //从嵌入的资源中读取文件，是通过Assembly.GetExecutingAssembly()读取嵌入资源，通过Assembly对象的GetManifestResourceStream(resFileName)函数获取指定内嵌文件的流，然后读取数据输出到指定的文件中。
                Assembly asm = Assembly.GetExecutingAssembly();
                //GetManifestResourceStream()函数指定的内嵌文件名称，格式为“程序默认命名空间名.目录名.文件名”，如果多级目录，目录之间用点号“.”隔开。程序默认命名空间是程序级别的，跟调用的类文件命名空间不一样
                inStream = new BufferedStream(asm.GetManifestResourceStream(resFileName));
                outStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write);

                byte[] buffer = new byte[1024];
                int length;

                while ((length = inStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    outStream.Write(buffer, 0, length);
                }
                outStream.Flush();
            }
            finally
            {
                if (outStream != null)
                {
                    outStream.Close();
                }
                if (inStream != null)
                {
                    inStream.Close();
                }
            }
        }
    }
}
