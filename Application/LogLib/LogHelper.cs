using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.IO;
namespace LogLib
{
    /// <summary>
    /// 分两种日志：
    /// 1.一个错误日志  
    /// 2.一个信息提示日志
    /// </summary>
    public class LogHelper
    {
        static readonly string cofigFileName = "log4net.config";

        //硬编码配置
        static readonly string DefaultConfigStr =
        #region str
            @"<?xml version=""1.0"" encoding=""utf-8"" ?>
<configuration>
  <log4net>
    <logger name=""logerror"">
      <level value=""ERROR"" />
      <appender-ref ref=""ErrorAppender"" />
    </logger>
    <logger name=""loginfo"">
      <level value=""INFO"" />
      <appender-ref ref=""InfoAppender"" />
    </logger>
    <appender name=""ErrorAppender"" type=""log4net.Appender.RollingFileAppender"">
      <!--设置日志存储路径-->
      <param name=""File"" value=""Log//"" />
      <!--是否追加到文件-->
      <param name=""AppendToFile"" value=""true"" />
      <!--最多产生的日志文件数，超过则只保留最新的n个。设定值value=""－1""为不限文件数 好像只有size的时候生效-->
      <param name=""MaxSizeRollBackups"" value=""100"" />
      <!--<param name=""MaxFileSize"" value=""1024"" />-->
      <maximumFileSize value=""1024"" />
      <!--是否只写到一个文件中-->
      <param name=""StaticLogFileName"" value=""false"" />
      <!--这是按日期产生文件夹，并在文件名前也加上日期-->
      <param name=""DatePattern"" value=""yyyyMMdd/HH&quot;-Error.log&quot;"" />
      <!--按照何种方式产生多个日志文件(日期[Date], 文件大小[Size], 混合[Composite])-->
      <param name=""RollingStyle"" value=""Date"" />
      <layout type=""log4net.Layout.PatternLayout"">
        <param name=""ConversionPattern"" value=""%n异常时间：%d [%t] %n异常级别：%-5p %n异常位置：[%thread] (%file:%line) %n消息描述：%message%n异常：%exception%n%n "" />
      </layout>
    </appender>
    <appender name=""InfoAppender"" type=""log4net.Appender.RollingFileAppender"">
      <!--设置日志存储路径-->
      <param name=""File"" value=""Log//"" />
      <!--是否追加到文件-->
      <param name=""AppendToFile"" value=""true"" />
      <!--最多产生的日志文件数，超过则只保留最新的n个。设定值value=""－1""为不限文件数-->
      <param name=""MaxSizeRollBackups"" value=""100"" />
      <!--<param name=""MaxFileSize"" value=""1024"" />-->
      <maximumFileSize value=""1024"" />
      <!--是否只写到一个文件中-->
      <param name=""StaticLogFileName"" value=""false"" />
      <!--这是按日期产生文件夹，并在文件名前也加上日期-->
      <param name=""DatePattern"" value=""yyyyMMdd/HH&quot;-Info.log&quot;"" />
      <!--按照何种方式产生多个日志文件 日期 Date , 文件大小 Size , 混合 Composite-->
      <param name=""RollingStyle"" value=""Date"" />
      <layout type=""log4net.Layout.PatternLayout"">
        <param name=""ConversionPattern"" value=""%n日志时间：%d [%t](%file:%line) %n日志级别：%-5p %n消息描述：%c [%x] %n%m %n "" />
      </layout>
    </appender>
  </log4net>
</configuration>";
        #endregion

        static ILog errorLog = LogManager.GetLogger("logerror");

        static ILog infoLog = LogManager.GetLogger("loginfo");

        //我们需要一个默认配置，当配置文件时，我们使用默认配置
        static LogHelper()
        {
            string configFilePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, cofigFileName);
            //判断配置文件是否存在，如果不存在就创建写入
            if (!File.Exists(configFilePath))
                File.WriteAllText(configFilePath, DefaultConfigStr);
            //读取配置文件
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(configFilePath));
        }

        static public void ErrorLog(string msg)
        {
            if (errorLog.IsErrorEnabled)
            {
                errorLog.Error(msg);
            }
        }

        static public void ErrorLog(string msg,Exception ex)
        {
            if (errorLog.IsErrorEnabled)
            {
                errorLog.Error(msg,ex);
            }
        }

        static public void InfoLog(string msg)
        {
            if (infoLog.IsInfoEnabled)
                infoLog.Info(msg);
        }

    }
}
