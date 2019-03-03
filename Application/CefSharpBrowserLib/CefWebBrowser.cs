using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms;
/* CefSharp 必须得配置x86 或者x64从而添加引用
1、CefSharp 必须在程序起始时初始化 在程序退出时释放  如何将初始化和释放从主应用程序中分离出来

目的，写一个浏览器帮助类，用来导航至某个页面，或许我们可以通过接口来规范公开的方法
*/

namespace CefSharpBrowserLib
{
    public class CefWebBrowser : IBrowser
    {
        readonly string BlankPage = "about:blank";
        //CefSharp浏览器对象
        ChromiumWebBrowser browser;
        //页面加载完成事件
        Action pageLoaded;
        public CefWebBrowser(Control container)
        {
            browser = new ChromiumWebBrowser(BlankPage);
            browser.LoadingStateChanged += Browser_LoadingStateChanged;
            browser.Dock = DockStyle.Fill;
            container.Controls.Add(browser);
        }

        public CefWebBrowser(Control container,string decUrl)
        {
            
            browser = new ChromiumWebBrowser(decUrl);
            browser.LoadingStateChanged += Browser_LoadingStateChanged;
            browser.Dock = DockStyle.Fill;
            container.Controls.Add(browser);
        }

        public string Address
        {
            get
            {
                if (browser != null)
                    return browser.Address;
                return string.Empty;
            }
        }

        public Action LoadCompleted
        {
            get
            {
                return pageLoaded;
            }

            set
            {
                pageLoaded = value;
            }
        }

        /// <summary>
        /// 执行js无返回值
        /// </summary>
        /// <param name="js"></param>
        public void ExcuteJS(string js)
        {
            if (browser != null)
            {
                try
                {
                    if(!browser.GetBrowser().IsLoading)
                        browser.GetBrowser().FocusedFrame.ExecuteJavaScriptAsync(js);
                }
                catch
                {
                    throw;
                }
            }
            //throw new NotImplementedException();
        }

        public Task<JavascriptResponse> ExcuteJSWithRsp(string js)
        {
            Task<JavascriptResponse> task = null;
            if (browser != null)
            {
                try
                {
                    if (!browser.GetBrowser().IsLoading)
                        task = browser.GetBrowser().FocusedFrame.EvaluateScriptAsync(js);
                }
                catch
                {
                    throw;
                }
            }
            return task;
            //throw new NotImplementedException();
        }

        public void Navigate(string decUrl)
        {
            if (browser != null)
                browser.Load(decUrl);
            //throw new NotImplementedException();
        }

        private void Browser_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {
            if (e.CanReload)//当加载页面  由于完成、取消、因错误停止时
            {
                pageLoaded?.Invoke();
                try
                {

                }
                catch
                {

                }
            }
            //throw new NotImplementedException();
        }
    }
}
