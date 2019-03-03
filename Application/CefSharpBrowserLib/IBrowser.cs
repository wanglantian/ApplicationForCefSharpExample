using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CefSharpBrowserLib
{
    /// <summary>
    /// 浏览器的接口
    /// 
    /// </summary>
    public interface IBrowser
    {
        //当前地址
        //string address;
        string Address { get; }

        //加载完成的事件
        Action LoadCompleted { get; set; }

        /// <summary>
        /// 导航
        /// </summary>
        /// <param name="decUrl">前往的地址</param>
        void Navigate(string decUrl);

        //在当前页面执行指定js 无返回值
        void ExcuteJS(string js);

        Task<JavascriptResponse> ExcuteJSWithRsp(string js);
    }
}
