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

3. 初始化客户端:

    ```csharp
    ICredential auth = new BasicCredentials(ak, sk, projectId);
    VpcClient vpcClient = VpcClient.NewBuilder().WithCredential(auth).WithEndPoint(endpoint).WithHttpConfig(config).Build();
    ```

	说明:
	- `ak` 华为云账号 Access Key.
	- `sk` 华为云账号 Secret Access Key.
	- `region-id` 云服务所在区域 ID.
    - `endpoint` 华为云各服务应用区域和各服务的终端节点，详情请查看[地区和终端节点](https://developer.huaweicloud.com/endpoint)。

4. 发送请求并查看响应.

	```csharp
	ListVpcsRequest req = new ListVpcsRequest
	{
		Limit = 1,
	};
	response = vpcClient.CreateVpc(req)
	```

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
