[English](./README.md) | 简体中文

# 华为云 .Net 软件开发工具包（.Net SDK）

欢迎使用华为云 .Net SDK。

华为云 .Net SDK让您无需关心请求细节即可快速使用云服务器、虚拟私有云等多个华为云服务。

这里将向您介绍如何获取并使用华为云 .Net SDK。

## 在线示例

[API Explorer](https://apiexplorer.developer.huaweicloud.com/apiexplorer/overview) 提供API检索及平台调试，支持全量快速检索、可视化调试、帮助文档查看、在线咨询。


## 现在开始

- 要使用华为云 .Net SDK，您需要拥有云账号以及该账号对应的Access Key（AK）和Secret Access Key（SK）。 请在华为云控制台“我的凭证-访问密钥”页面上创建和查看您的AKSK。更多信息请查看[访问密钥](https://support.huaweicloud.com/usermanual-ca/zh-cn_topic_0046606340.html).

- 华为云 .Net SDK适用于：
    - **.NET Framework 4.5** 及其以上版本
    - **.NET Standard 2.0** 及其以上版本
    - **C# 4.0** 及其以上版本

## 华为云 .NET SDK 获取和安装

您可以通过如下方式获取和安装SDK:

- 使用 .NET CLI 工具
```bash
dotnet add package HuaweiCloud.SDK.Core
dotnet add package HuaweiCloud.SDK.Ecs
```

- 使用 Package Manager
```bash
Install-Package HuaweiCloud.SDK.Core
Install-Package HuaweiCloud.SDK.Ecs
```

## 开始使用

1. 导入依赖模块:

    ```csharp
    using System;
    using HuaweiCloud.SDK.Core;
    using HuaweiCloud.SDK.Core.Auth;
    using HuaweiCloud.SDK.Vpc.V2;
    using HuaweiCloud.SDK.Vpc.V2.Model;
    ```

2. 配置客户端属性

    ```csharp
    # 使用默认配置
    var config = HttpConfig.GetDefaultConfig();

    # 配置Proxy（可选）
    config.ProxyHost = "http://proxy.huaweicloud.com";
    config.ProxyPort = 8080;
    config.ProxyUsername = "test";
    config.ProxyPassword = "test";
    
    # Https请求跳过服务器端SSL证书验证（可选）
    config.ignore_ssl_verification = True
    ```

3. 初始化认证信息

    ```csharp
    ICredential auth = new BasicCredentials(ak, sk, projectId, domainId);
    ```

	**说明:**

   	非全局服务仅需要提供project_id，domain_id无需提供。
    全局服务project_id必须为null，domain_id请按照实际情况填写。
    全局服务当前仅支持IAM。

    - `ak` 华为云账号Access Key。
    - `sk` 华为云账号Secret Access Key。
    - `project_id` 云服务所在项目 ID。
    - `domain_id` 华为云账号 ID。

4. 初始化客户端:

    ```csharp
    VpcClient vpcClient = VpcClient.NewBuilder().WithCredential(auth).WithEndPoint(endpoint).WithHttpConfig(config).WithLogging(LogLevel.Information).Build();
    ```

	**说明:**

    - `endpoint` 华为云各服务应用区域和各服务的终端节点，详情请查看[地区和终端节点](https://developer.huaweicloud.com/endpoint)。

5. 发送请求并查看响应.

	```csharp
	ListVpcsRequest req = new ListVpcsRequest
	{
		Limit = 1,
	};
	response = vpcClient.CreateVpc(req)
	```

6. 异常处理

    | 一级分类 | 一级分类说明 | 二级分类 | 二级分类说明 |
    | :---- | :---- | :---- | :---- |
    | ConnectionException | 连接类异常 | HostUnreachableException | 网络不可达、被拒绝 |
    | | | SslHandShakeException | SSL认证异常 |
    | RequestTimeoutException | 响应超时异常 | CallTimeoutException | 单次请求，服务器处理超时未返回 |
    | | | RetryOutageException | 在重试策略消耗完成已后，仍无有效的响应 |
    | ServiceResponseException | 服务器响应异常 | ServerResponseException | 服务端内部错误，Http响应码：[500,] |
    | | | ClientRequestException | 请求参数不合法，Http响应码：[400, 500) |

    ```csharp
    # 异常处理
    try
    {
        response = vpcClient.ListVpcs(new ListVpcsRequest());
        Console.WriteLine(response);
    }
    catch (ClientRequestException clientRequestException)
    {
        Console.WriteLine(clientRequestException.HttpStatusCode);
        Console.WriteLine(clientRequestException.ErrorCode);
        Console.WriteLine(clientRequestException.ErrorMsg);
        Console.WriteLine(clientRequestException.RequestId);
    }
    ```

7. 异步场景

    ```csharp
    # 初始化异步客户端
    VpcAsyncClient vpcClient = VpcAsyncClient.NewBuilder().WithCredential(auth).WithEndPoint(endpoint).WithLogging(LogLevel.Information).WithHttpConfig(config).Build();

    # 发送异步请求
    ListVpcsResponse listVpcsResponse = await vpcClient.ListVpcsAsync(new ListVpcsRequest());
    Console.WriteLine(JsonUtils.Serialize(listVpcsResponse.Vpcs));
    ```

8. 问题定位

    在某些场景下可能对业务发出的Http请求进行Debug，需要看到原始的Http请求和返回信息，SDK提供侦听器功能来获取原始的为加密的Http请求和返回信息。

    **注意：** 原始信息打印仅在debug阶段使用，请不要在生产系统中将原始的Http头和Body信息打印到日志，这些信息并未加密且其中包含敏感数据，例如所创建虚拟机的密码，IAM用户的密码等;
    当Body体为二进制内容,即Content-Type标识为二进制时 body为"***",详细内容不输出。

    ```csharp
    private void RequestHandler(HttpRequestMessage message, ILogger logger)
    {
        logger.LogDebug(message.ToString());
    }
   
    private void ResponseHandler(HttpResponseMessage message, ILogger logger)
    {
        logger.LogDebug(message.ToString());
    }
    
    VpcClient vpcClient = VpcClient.NewBuilder().WithCredential(auth).WithEndPoint(endpoint).WithLogging(LogLevel.Debug).WithHttpConfig(config).WithHttpHandler(new HttpHandler().AddRequestHandler(RequestHandler).AddResponseHandler(ResponseHandler)).Build();
    ```

	**说明:**

    HttpHandler支持如下方法AddRequestHandler、AddResponseHandler。

## 代码实例

使用如下代码将查询指定区域下的VPC列表，调用前请根据实际情况替换如下变量：`{your ak string}`、 `{your sk string}`、 `{your endpoint}` 以及 `{your project id}`。

```csharp
using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            const string endpoint = "{your endpoint string}";
            const string projectId = "{your projectID string}";

            ICredential auth = new BasicCredentials(ak, sk, projectId);
            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;

            VpcClient vpcClient = VpcClient.NewBuilder().WithCredential(auth).WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            ListVpcsRequest req = new ListVpcsRequest
            {
                Limit = 1,
            };

            try
            {
                ListVpcsResponse resp = vpcClient.ListVpcs(req);
                foreach (var vpc in resp.Vpcs)
                {
                    Console.WriteLine(vpc.Id);
                    Console.WriteLine(vpc.Name);
                }
            }
            catch (RequestTimeoutException requestTimeoutException)
            {
                Console.WriteLine(requestTimeoutException.ErrorMessage);
            }
            catch (ServiceResponseException clientRequestException)
            {
                Console.WriteLine(clientRequestException.HttpStatusCode);
                Console.WriteLine(clientRequestException.ErrorCode);
                Console.WriteLine(clientRequestException.ErrorMsg);
            }
            catch (ConnectionException connectionException)
            {
                Console.WriteLine(connectionException.ErrorMessage);
            }
        }
    }
}
```
