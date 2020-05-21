English | [简体中文](./README_ZH.md)

# HuaweiCloud .Net Software Development Kit (.Net SDK)

The HuaweiCloud .Net SDK allows you to easily work with Huawei Cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud(VPC) without the need to handle API related tasks.

This document introduces how to obtain and use HuaweiCloud .Net SDK.

## Getting Started

- To use HuaweiCloud .Net SDK, you must have Huawei Cloud account as well as the Access Key and Secret key of the HuaweiCloud account.

	The accessKey is required when initializing `ServiceClient`. You can create an Access Key in the Huawei Cloud console. For more information, see [My Credentials](https://support.huaweicloud.com/en-us/usermanual-ca/en-us_topic_0046606340.html).

- The .NET SDK requires：
    - **.NET Framework 4.5** or above
    - **.NET Standard 2.0** or above
    - **C# 4.0** or above

## Install .Net SDK

Run the following command to install .Net SDK:

- Use .NET CLI
```bash
dotnet add package HuaweiCloud.SDK.Core
dotnet add package HuaweiCloud.SDK.Ecs
```

- Use Package Manager
```bash
Install-Package HuaweiCloud.SDK.Core
Install-Package HuaweiCloud.SDK.Ecs
```

## Use .Net SDK

1. Import the required modules as follows:

    ```csharp
    using System;
    using HuaweiCloud.SDK.Core;
    using HuaweiCloud.SDK.Core.Auth;
    using HuaweiCloud.SDK.Vpc.V2;
    using HuaweiCloud.SDK.Vpc.V2.Model;
    ```

2. Config `ServiceClient` Configurations

    ```csharp
    # Using the default configuration
    var config = HttpConfig.GetDefaultConfig();

    # Set Proxy if needed
    config.ProxyHost = "http://proxy.huaweicloud.com";
    config.ProxyPort = 8080;
    config.ProxyUsername = "test";
    config.ProxyPassword = "test";
    
    # Skip ssl certifaction checking while using https protocal if needed
    config.ignore_ssl_verification = True
    ```

3. Initialize the `ServiceClient` instance:

    ```csharp
    ICredential auth = new BasicCredentials(ak, sk, projectId);
    VpcClient vpcClient = VpcClient.NewBuilder().WithCredential(auth).WithEndPoint(endpoint).WithHttpConfig(config).Build();
    ```

	where:

	- `ak` is the access key ID of your account.
	- `sk` is the secret access key of your account.
	- `region-id` is the ID of the region.
    - `endpoint` is the service specific endpoints, see [Regions and Endpoints](https://developer.huaweicloud.com/intl/en-us/endpoint)

4. Call a request and print response.

	```csharp
    ListVpcsRequest req = new ListVpcsRequest
    {
        Limit = 1,
    };
	response = vpcClient.CreateVpc(req)
	```

## Code example

The following example shows how to query a list of VPC in a specific region. Substitute the values for `{your ak string}`, `{your sk string}`, `{your endpoint}` and `{your project id}`.

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
