English | [简体中文](README_CN.md)

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

You must install `HuaweiCloud.SDK.Core` library no matter which product development kit you need to use. Take using VPC SDK for example, you need to install `HuaweiCloud.SDK.Core` library and `HuaweiCloud.SDK.Vpc` library:

- Use .NET CLI
    ``` bash
    dotnet add package HuaweiCloud.SDK.Core
    dotnet add package HuaweiCloud.SDK.Vpc
    ```

- Use Package Manager
    ```bash
    Install-Package HuaweiCloud.SDK.Core
    Install-Package HuaweiCloud.SDK.Vpc
    ```

## Use .Net SDK

1. Import the required modules as follows:

    ```csharp
    using System;
    using HuaweiCloud.SDK.Core;
    using HuaweiCloud.SDK.Core.Auth;
    # import specified service, take Vpc for example
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

3. Initialize the credentials

    **Notice:**
    There are two types of HUAWEI CLOUD services, regional services and global services. 
    Global services currently only support IAM, TMS, EPS.

    For Regional services' authentication, projectId is required. 
    For global services' authentication, domainId is required. 

    - `ak` is the access key ID for your account.
    - `sk` is the secret access key for your account.
    - `projectId` is the ID of your project depending on your region which you want to operate.
    - `domainId` is the account ID of HUAWEI CLOUD.
    - `securityToken` is the security token when using temporary AK/SK.

    3.1 Use permanent AK/SK
    
    ``` csharp
    # Regional Services
    ICredential auth = new BasicCredentials(ak, sk, projectId);
   
    # Global Services
    ICredential auth = new GlobalCredentials(ak, sk, domainId);
    ```
    
    3.2 Use temporary AK/SK
    
    It's preferred to obtain temporary access key, security key and security token first, which could be obtained through permanent access key and security key or through an agency.
    
    Obtaining a temporary access key token through permanent access key and security key, you could refer to document: https://support.huaweicloud.com/en-us/api-iam/iam_04_0002.html . The API mentioned in the document above corresponds to the method of createTemporaryAccessKeyByToken in IAM SDK.
    
    Obtaining a temporary access key and security token through an agency, you could refer to document: https://support.huaweicloud.com/en-us/api-iam/iam_04_0101.html . The API mentioned in the document above corresponds to the method of createTemporaryAccessKeyByAgency in IAM SDK.
    
    ``` csharp
    # Regional Services
    ICredential auth = new BasicCredentials(ak, sk, projectId).WithSecurityToken(securityToken);
   
    # Global Services
    ICredential auth = new GlobalCredentials(ak, sk, domainId).WithSecurityToken(securityToken);
    ```

4. Initialize the `ServiceClient` instance:

    ```csharp
    # Initialize specified {Service}Client instance, take VpcClient for example
    VpcClient vpcClient = VpcClient.NewBuilder().WithCredential(auth).WithEndPoint(endpoint).WithHttpConfig(config).Build();
    ```

	**where:**

    - `endpoint` is the service specific endpoints, see [Regions and Endpoints](https://developer.huaweicloud.com/intl/en-us/endpoint)

5. Call a request and print response.

	```csharp
    # Send request and print response, take interface of ListVpcs for example
    ListVpcsRequest req = new ListVpcsRequest
    {
        Limit = 1,
    };
	response = vpcClient.ListVpcs(req)
	```

6. Exceptions

    | Level 1 | Notice | Level 2 | Notice |
    | :---- | :---- | :---- | :---- |
    | ConnectionException | Connection error | HostUnreachableException | Host is not reachable |
    | | | SslHandShakeException | SSL certification error |
    | RequestTimeoutException | Request timeout | CallTimeoutException | timeout for single request |
    | | | RetryOutageException | no response after retrying |
    | ServiceResponseException | service response error | ServerResponseException | server inner error, http status code: [500,] |
    | | | ClientRequestException | invalid request, http status code: [400, 500) |
    
    ```csharp
    # Handle ClientRequestExceptions
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

7. Asynchronous Requests

    ```csharp
    # Initialize asynchronous client instance, take VpcAsyncClient for example
    VpcAsyncClient vpcClient = VpcAsyncClient.NewBuilder().WithCredential(auth).WithEndPoint(endpoint).WithLogging(LogLevel.Information).WithHttpConfig(config).Build();

    # send asynchronous request
    ListVpcsResponse listVpcsResponse = await vpcClient.ListVpcsAsync(new ListVpcsRequest());
    Console.WriteLine(JsonUtils.Serialize(listVpcsResponse.Vpcs));
    ```

8. Troubleshooting

    In some situation, you may need to debug your http requests, original http request and response information will be needed. The SDK provides a listener function to obtain the original encrypted http request and response information.

    **Warning:** The original http log can only be used in troubleshooting scenarios, please do not print the original http header or body in the production environment. The log content is not encrypted and may contain sensitive information such as the password of your ECS or the password of your IAM user account, etc. When the response body is binary content, the body will be printed as "***" without detailed information.

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

	**where:**

    HttpHandler supports AddRequestHandler and AddResponseHandler.


## Code example

- The following example shows how to query a list of VPC in a specific region, you need to substitute your real `{Service}Client` for `VpcClient` in actual use.
- Substitute the values for `{your ak string}`, `{your sk string}`, `{your endpoint string}` and `{your project id}`.

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
