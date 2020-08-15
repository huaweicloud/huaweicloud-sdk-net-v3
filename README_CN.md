[English](./README.md) | 简体中文

# 华为云 .Net 软件开发工具包（.Net SDK）

欢迎使用华为云 .Net SDK。

华为云 .Net SDK让您无需关心请求细节即可快速使用云服务器、虚拟私有云等多个华为云服务。

这里将向您介绍如何获取并使用华为云 .Net SDK。

## 在线示例

[API Explorer](https://apiexplorer.developer.huaweicloud.com/apiexplorer/overview) 提供API检索及平台调试，支持全量快速检索、可视化调试、帮助文档查看、在线咨询。


## 现在开始

- 要使用华为云 .Net SDK，您需要拥有云账号以及该账号对应的Access Key（AK）和Secret Access Key（SK）。 请在华为云控制台“我的凭证-访问密钥”页面上创建和查看您的 AK/SK 。更多信息请查看[访问密钥](https://support.huaweicloud.com/usermanual-ca/zh-cn_topic_0046606340.html).

- 华为云 .Net SDK适用于：
    - **.NET Framework 4.5** 及其以上版本
    - **.NET Standard 2.0** 及其以上版本
    - **C# 4.0** 及其以上版本

## 华为云 .NET SDK 获取和安装

您可以通过如下方式获取和安装SDK。

无论您要使用哪个产品/服务的开发工具包，都必须安装`HuaweiCloud.SDK.Core`。以使用虚拟私有云VPC SDK为例，您需要安装`HuaweiCloud.SDK.Core` 和 `HuaweiCloud.SDK.Vpc`：

- 使用 .NET CLI 工具
    ```bash
    dotnet add package HuaweiCloud.SDK.Core
    dotnet add package HuaweiCloud.SDK.Vpc
    ```

- 使用 Package Manager
    ```bash
    Install-Package HuaweiCloud.SDK.Core
    Install-Package HuaweiCloud.SDK.Vpc
    ```

## 开始使用

1. 导入依赖模块:

    ```csharp
    using System;
    using HuaweiCloud.SDK.Core;
    using HuaweiCloud.SDK.Core.Auth;
    # 导入指定云服务的 {Service}，此处以 Vpc 为例
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

    **说明**：
    华为云服务存在两种部署方式，Region级服务和Global级服务。Global级服务当前仅支持IAM, TMS, EPS。
    
    Region级服务仅需要提供 projectId。Global级服务需要提供domainId。

    - `ak` 华为云账号 Access Key 。
    - `sk` 华为云账号 Secret Access Key 。
    - `projectId` 云服务所在项目 ID ，根据你想操作的项目所属区域选择对应的项目 ID 。
    - `domainId` 华为云账号ID 。
    - `securityToken` 采用临时AK/SK认证场景下的安全票据。

    3.1 使用永久AK/SK
    
    ``` csharp
    // Region级服务
    ICredential auth = new BasicCredentials(ak, sk, projectId);
   
    // Global级服务
    ICredential auth = new GlobalCredentials(ak, sk, domainId);
    ```
    
    3.2 使用临时AK/SK
    
    首选需要获得临时AK、SK和SecurityToken，获取可以从永久AK/SK获得，或者通过委托授权首选获得。
    
    通过永久AK/SK获得可以参考文档：https://support.huaweicloud.com/api-iam/iam_04_0002.html, 对应IAM SDK 中的createTemporaryAccessKeyByToken方法。
    
    通过委托授权获得可以参考文档：https://support.huaweicloud.com/api-iam/iam_04_0101.html, 对应IAM SDK 中的createTemporaryAccessKeyByAgency方法。
    
    ``` csharp
    // Region级服务
    ICredential auth = new BasicCredentials(ak, sk, projectId).WithSecurityToken(securityToken);
       
    // Global级服务
    ICredential auth = new GlobalCredentials(ak, sk, domainId).WithSecurityToken(securityToken);
    ```

4. 初始化客户端:

    ```csharp
    # 初始化指定云服务的客户端 {Service}Client，以初始化 VpcClient 为例
    VpcClient vpcClient = VpcClient.NewBuilder().WithCredential(auth).WithEndPoint(endpoint).WithHttpConfig(config).WithLogging(LogLevel.Information).Build();
    ```

	**说明:**

    - `endpoint` 华为云各服务应用区域和各服务的终端节点，详情请查看[地区和终端节点](https://developer.huaweicloud.com/endpoint)。

5. 发送请求并查看响应.

	```csharp
    // 初始化请求，以调用接口 ListVpcs 为例
	ListVpcsRequest req = new ListVpcsRequest
	{
		Limit = 1,
	};
	response = vpcClient.ListVpcs(req)
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
    # 初始化异步客户端，以初始化 VpcAsyncClient 为例
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

- 使用如下代码同步查询特定 Region 下的 VPC 清单，实际使用中请将 `VpcClient` 替换为您使用的产品/服务相应的 `{Service}Client`。
- 调用前请根据实际情况替换如下变量： `{your ak string}`、`{your sk string}`、`{your endpoint string}` 以及 `{your project id}`。

    ``` csharp
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
