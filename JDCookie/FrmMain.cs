using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JDCookie
{
    public partial class FrmMain : Form
    {
        public string LoginUrl = "https://home.m.jd.com/myJd/home.action";

        public FrmMain()
        {
            InitializeComponent();
            InitPhone();
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            await wb.EnsureCoreWebView2Async();
            wb.Source = new Uri(LoginUrl);
        }

        private void InitPhone()
        {
            lbPhone.Items.Clear();

            // 方法1 (修改添加手机号需要重新生成exe)
            // lbPhone.Items.Add("");

            // 方法2 (修改添加手机号只需编辑config.txt文件即可)
            string configDir = Path.Combine(Environment.CurrentDirectory, "config.txt");
            if (File.Exists(configDir))
            {
                var lines = File.ReadAllLines(configDir);
                foreach (string line in lines)
                {
                    lbPhone.Items.Add(line);
                }
            }
            

            if (lbPhone.Items.Count > 0)
                lbPhone.SelectedIndex = 0;

        }

        private async void GetCookie()
        {
            List<CoreWebView2Cookie> cookieList = await wb.CoreWebView2.CookieManager.GetCookiesAsync("https://home.m.jd.com/myJd/home.action");
            for (int i = 0; i < cookieList.Count; ++i)
            {
                CoreWebView2Cookie cookie = cookieList[i];
                if (cookie.Name == "pt_key")
                {
                    tbKey.Invoke(new Action(() =>
                    {
                        tbKey.Text = cookie.Value;
                        Clipboard.SetText(cookie.Value + "");
                    }));
                }

                if (cookie.Name == "pt_pin")
                {
                    tbPin.Invoke(new Action(() =>
                    {
                        tbPin.Text = cookie.Value;
                    }));
                }
            }
        }

        private void BtnGet_Click(object sender, EventArgs e)
        {
            tbKey.Text = "";
            tbPin.Text = "";
            GetCookie();
            lbTips.Visible = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            wb.CoreWebView2.CookieManager.DeleteAllCookies();
            wb.CoreWebView2.Reload();
        }

        private void BtnFill_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbPhone.Text))
            {
                Clipboard.SetText(lbPhone.Text + "");
                wb.CoreWebView2.ExecuteScriptAsync(
                "var phone = document.querySelector('input[placeholder=\"请输入手机号\"]');phone.dispatchEvent(new Event('focus'));phone.value = " 
                + lbPhone.Text +
                ";phone.dispatchEvent(new Event('input'));phone.dispatchEvent(new Event('blur'));var check = document.querySelector('input.policy_tip-checkbox');if(!check.checked);check.click();");
            }
        }
    }
}
