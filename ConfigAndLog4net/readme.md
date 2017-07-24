# Config及Log4Net範例 #
## NuGet ##
1. log4net
2. Newtonsoft
## log4net ##
在[AssemblyInfo.cs]在最後加上程式
``` csharp
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
```
在[App.config]加上設定, 指明使用Config\log4net.config
``` xml
<configuration>
...
  <appSettings>
    <add key="log4net.Config" value="Config\log4net.config" />
    <add key="log4net.Config.Watch" value="True"/>
  </appSettings>
</configuration
```
新增[Config\log4net.config], 設定[複製到輸出目錄]為"有更新時才複製"
``` xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <configSections>
    <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
  </configSections>
  <log4net>
    <appender name="ConsoleAppender" type="log4net.Appender.ConsoleAppender" >
      <layout type="log4net.Layout.PatternLayout">
        <conversionPattern value="%date [%thread] %-5level %logger [%ndc] - %message%newline" />
      </layout>
    </appender>
    <appender name="RollingLogFileAppender" type="log4net.Appender.RollingFileAppender">
      <file value="./Logs/log4net.log" />
      <appendToFile value="true" />
      <rollingStyle value="Composite" />
      <datePattern value="yyyyMMdd" />
      <maxSizeRollBackups value="10" />
      <maximumFileSize value="1MB" />
      <layout type="log4net.Layout.PatternLayout">
        <conversionPattern value="%date [%thread] %-5level %logger [%property{NDC}] - %message%newline" />
      </layout>
    </appender>
    <root>
      <level value="DEBUG" />
      <appender-ref ref="ConsoleAppender" />
      <appender-ref ref="RollingLogFileAppender" />
    </root>
  </log4net>
</configuration>
```
在[Program.cs]加入程式
``` csharp
class Program
{
    private static readonly ILog logger = LogManager.GetLogger(typeof(Program));
    static void Main(string[] args)
    {
        logger.Debug("Hello, Log4net");
    }
}
```
執行程式, 測試結束
## Config ##
在專案下新增目錄[Configuration], 新增一個類別[ConfigData]
加入程式
``` csharp
class ConfigData
{
    public string field;
}
```
新增[Config\configData.json], 設定[複製到輸出目錄]為"有更新時才複製"
``` json
{
  "field" : "ConfigData.field"
}
```
修改[App.config], 加上
``` xml
<appSettings>
  ...
  <add key="configData" value="Config\configData.json"/>
</appSettings>
```
修改[Program.cs]
``` csharp
class Program
{
    private static readonly ILog logger = LogManager.GetLogger(typeof(Program));
    internal static readonly Configuration.ConfigData configData;
    static Program()
    {
        string configDataPath = ConfigurationManager.AppSettings["configData"];
        configData = JsonConvert.DeserializeObject<Configuration.ConfigData>(File.ReadAllText(configDataPath));
    }
    static void Main(string[] args)
    {
        logger.Debug("Hello, Log4net");
        logger.Info(configData.field);
    }
}
```
要加入參考[System.Configration]
執行程式, 測試結束
## ConnectionString ##
修改[App.config]
``` xml
<configuration>
    ...
    <connectionStrings configSource="Config\connections.config"/>
    ...
</configuration>
```
新增[Config\connections.config], 設定[複製到輸出目錄]為"有更新時才複製"
``` xml
<connectionStrings>
  <add name="DB" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PeterDB;Integrated Security=True;" />
</connectionStrings>
```
修改[Program.cs]
``` csharp
class Program
{
    private static readonly ILog logger = LogManager.GetLogger(typeof(Program));
    internal static readonly Configuration.ConfigData configData;
    internal static readonly string connectionString;
    static Program()
    {
        string configDataPath = ConfigurationManager.AppSettings["configData"];
        configData = JsonConvert.DeserializeObject<Configuration.ConfigData>(File.ReadAllText(configDataPath));
        connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
    }
    static void Main(string[] args)
    {
        logger.Debug("Hello, Log4net");
        logger.Info(configData.field);
        logger.Info(connectionString);
    }
}
```
執行程式, 測試結束