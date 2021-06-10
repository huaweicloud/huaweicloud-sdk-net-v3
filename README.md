English | [简体中文](README_CN.md)

<p align="center">
<a href="https://www.huaweicloud.com/"><img width="450px" height="102px" src="https://console-static.huaweicloud.com/static/authui/20210202115135/public/custom/images/logo-en.svg"></a>
</p>

<h1 align="center">Huawei Cloud .Net Software Development Kit (.Net SDK)</h1>

The Huawei Cloud .Net SDK allows you to easily work with Huawei Cloud services such as Elastic Compute Service (ECS) and
Virtual Private Cloud(VPC) without the need to handle API related tasks.

This document introduces how to obtain and use Huawei Cloud .Net SDK.

## Requirements

- To use Huawei Cloud .Net SDK, you must have Huawei Cloud account as well as the Access Key and Secret key of the
  Huawei Cloud account. You can create an Access Key in the Huawei Cloud console. For more information,
  see [My Credentials](https://support.huaweicloud.com/en-us/usermanual-ca/en-us_topic_0046606340.html).

- To use Huawei Cloud .Net SDK to access the APIs of specific service, please make sure you do have activated the
  service in [Huawei Cloud console](https://console.huaweicloud.com/?locale=en-us) if needed.

- The .NET SDK requires：
    - **.NET Standard 2.0** or above
    - **C# 4.0** or above

## Install .Net SDK

Run the following commands to install .Net SDK:

You must install `HuaweiCloud.SDK.Core` library no matter which product development kit you need to use. Take using VPC
SDK for example, you need to install `HuaweiCloud.SDK.Core` library and `HuaweiCloud.SDK.Vpc` library:

- Use .NET CLI

``` bash
dotnet add package HuaweiCloud.SDK.Core
dotnet add package HuaweiCloud.SDK.Vpc
```

- Use Package Manager

``` bash
Install-Package HuaweiCloud.SDK.Core
Install-Package HuaweiCloud.SDK.Vpc
```

## Code example

- The following example shows how to query a list of VPC in a specific region, you need to substitute your
  real `{Service}Client` for `VpcClient` in actual use.
- Substitute the values for `{your ak string}`, `{your sk string}`, `{your endpoint string}` and `{your project id}`.

```csharp
using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;
using Microsoft.Extensions.Logging;

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

            Credentials auth = new BasicCredentials(ak, sk, projectId);
            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;

            VpcClient vpcClient = VpcClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config)
                .WithLogging(LogLevel.Information)
                .Build();

            var request = new ListVpcsRequest
            {
                Limit = 1
            };

            try
            {
                var response = vpcClient.ListVpcs(request);
                Console.WriteLine(JsonUtils.Serialize(response.Vpcs));
            }
            catch (RequestTimeoutException requestTimeoutException)
            {
                Console.WriteLine(requestTimeoutException.ErrorMessage);
            }
            catch (ServiceResponseException serviceResponseException)
            {
                Console.WriteLine(serviceResponseException.HttpStatusCode);
                Console.WriteLine(serviceResponseException.ErrorCode);
                Console.WriteLine(serviceResponseException.ErrorMsg);
            }
            catch (ConnectionException connectionException)
            {
                Console.WriteLine(connectionException.ErrorMessage);
            }
        }
    }
}
```

## Changelog

Detailed changes for each released version are documented in
the [CHANGELOG.md](https://github.com/huaweicloud/huaweicloud-sdk-net-v3/blob/master/CHANGELOG.md).

## User Manual [:top:](#huawei-cloud-net-software-development-kit-net-sdk)

* [1. Client Configuration](#1-client-configuration-top)
    * [1.1  Default Configuration](#11-default-configuration-top)
    * [1.2  Network Proxy](#12-network-proxy-top)
    * [1.3  Connection](#13-connection-top)
    * [1.4  SSL Certification](#14-ssl-certification-top)
* [2. Credentials Configuration](#2-credentials-configuration-top)
    * [2.1  Use Permanent AK&SK](#21-use-permanent-aksk-top)
    * [2.2  Use Temporary AK&SK](#22-use-temporary-aksk-top)
* [3. Client Initialization](#3-client-initialization-top)
    * [3.1  Initialize the client with specified Endpoint](#31-initialize-the-serviceclient-with-specified-endpoint-top)
    * [3.2  Initialize the client with specified Region (Recommended)](#32-initialize-the-serviceclient-with-specified-region-recommended-top)
* [4. Send Requests and Handle Responses](#4-send-requests-and-handle-responses-top)
    * [4.1  Exceptions](#41-exceptions-top)
* [5. Use Asynchronous Client](#5-use-asynchronous-client-top)
* [6. Troubleshooting](#6-troubleshooting-top)
    * [6.1 Access Log](#61-access-log-top)
    * [6.2 Original HTTP Listener](#62-original-http-listener-top)
* [7. FAQ](#7-faq-top)

### 1. Client Configuration [:top:](#user-manual-top)

#### 1.1 Default Configuration [:top:](#user-manual-top)

```csharp
// Use default configuration
var config = HttpConfig.GetDefaultConfig();
```

#### 1.2 Network Proxy [:top:](#user-manual-top)

Use network proxy if needed.

- Only HTTP proxy is supported if you have assigned proxy port when configuring proxy.

``` csharp
config.ProxyHost = "proxy.huaweicloud.com";
// assign proxy port
config.ProxyPort = 8080;
config.ProxyUsername = "test";
config.ProxyPassword = "test";
```

- Both HTTP and HTTPS proxy are supported if proxy port is unassigned when configuring proxy.

``` csharp
config.ProxyHost = "https://proxy.huaweicloud.com:8080";
config.ProxyUsername = "test";
config.ProxyPassword = "test";
```

#### 1.3 Connection [:top:](#user-manual-top)

``` csharp
config.Timeout = 120;
```

#### 1.4 SSL Certification [:top:](#user-manual-top)

``` csharp
// Skip ssl certifaction checking while using https protocal if needed
config.IgnoreSslVerification = true;
```

### 2. Credentials Configuration [:top:](#user-manual-top)

There are two types of Huawei Cloud services, `regional` services and `global` services.

Global services contain IAM, TMS, EPS.

For `regional` services' authentication, projectId is required to initialize BasicCredentials. For `global` services'
authentication, domainId is required to initialize GlobalCredentials.

**Parameter description**:

- `ak` is the access key ID for your account.
- `sk` is the secret access key for your account.
- `projectId` is the ID of your project depending on the region you want to operate.
- `domainId` is the account ID of Huawei Cloud.
- `securityToken` is the security token when using temporary AK/SK.

You could use permanent AK and SK **or** use temporary AK and SK and SecurityToken to complete credentials'
configuration.

#### 2.1 Use Permanent AK&SK [:top:](#user-manual-top)

``` csharp
// Regional services
Credentials basicCredentials = new BasicCredentials(ak, sk, projectId);

// Global services
Credentials globalCredentials = new GlobalCredentials(ak, sk, domainId);
```

**Notice**:

- projectId/domainId supports **automatic acquisition** in version `3.0.26-beta` or later, if you want to use this
  feature, you need to provide the ak and sk of your account and the id of the region, and then build your client
  instance with method `WithRegion()`, detailed example could refer
  to [3.2 Initialize the client with specified Region](#32-initialize-the-serviceclient-with-specified-region-recommended-top)
  .

#### 2.2 Use Temporary AK&SK [:top:](#user-manual-top)

It's required to obtain temporary access key, security key and security token first, which could be obtained through
permanent access key and security key or through an agency.

Obtaining a temporary access key token through permanent access key and security key, you could refer to
document: https://support.huaweicloud.com/en-us/api-iam/iam_04_0002.html . The API mentioned in the document above
corresponds to the method of `CreateTemporaryAccessKeyByToken` in IAM SDK.

Obtaining a temporary access key and security token through an agency, you could refer to
document: https://support.huaweicloud.com/en-us/api-iam/iam_04_0101.html . The API mentioned in the document above
corresponds to the method of `CreateTemporaryAccessKeyByAgency` in IAM SDK.

``` csharp
// Regional services
Credentials basicCredentials = new BasicCredentials(ak, sk, projectId).WithSecurityToken(securityToken);
    
// Global services
Credentials globalCredentials = new GlobalCredentials(ak, sk, domainId).WithSecurityToken(securityToken);
```

### 3. Client Initialization [:top:](#user-manual-top)

There are two ways to initialize the {Service}Client, you could choose one you preferred.

#### 3.1 Initialize the {Service}Client with specified Endpoint [:top:](#user-manual-top)

``` csharp
// Specify the endpoint, take the endpoint of VPC service in region of cn-north-4 for example
String endpoint = "https://vpc.cn-north-4.myhuaweicloud.com";

// Initialize the credentials, you should provide projectId or domainId in this way, take initializing BasicCredentials for example
Credentials basicCredentials = new BasicCredentials(ak, sk, projectId);

// Initialize specified {Service}Client instance, take initializing the regional service VPC's VpcClient for example
VpcClient vpcClient = VpcClient.NewBuilder()
    .WithCredential(basicCredentials)
    .WithEndPoint(endpoint)
    .WithHttpConfig(config)
    .Build();
```

**where:**

- `endpoint` is the service specific endpoints,
  see [Regions and Endpoints](https://developer.huaweicloud.com/intl/en-us/endpoint).

- When you meet some trouble in getting projectId using the specified region way, you could use this way instead.

#### 3.2 Initialize the {Service}Client with specified Region **(Recommended)** [:top:](#user-manual-top)

``` csharp
// Initialize the credentials, projectId or domainId could be unassigned in this situation, take initializing GlobalCredentials for example
Credentials globalCredentials = new GlobalCredentials(ak, sk);

// Initialize specified {Service}Client instance, take initializing the global service IAM's IamClient for example
IamClient iamClient = IamClient.NewBuilder()
    .WithCredential(globalCredentials)
    .WithRegion(IamRegion.CN_NORTH_4)
    .WithHttpConfig(config)
    .Build();
```

**Notice:**

- If you use {Service}Region to initialize {Service}Client, projectId/domainId supports automatic acquisition, you don't
  need to configure it when initializing Credentials.

- Multiple ProjectId situation is **not supported**.

- Supported region list: af-south-1, ap-southeast-1, ap-southeast-2, ap-southeast-3, cn-east-2, cn-east-3,
  cn-north-1, cn-north-4, cn-south-1, cn-southwest-2, ru-northwest-2. You may get exception such as `Unsupported regionId` if your region don't in the list above.

**Comparison of the two ways:**

| Initialization | Advantages | Disadvantage |
| :---- | :---- | :---- |
| Specified Endpoint | The API can be invoked successfully once it has been published in the environment. | You need to prepare projectId and endpoint yourself.
| Specified Region | No need for projectId and endpoint, it supports automatic acquisition if you configure it in the right way. | The supported services and regions are limited.

### 4. Send Requests and Handle Responses [:top:](#user-manual-top)

```csharp
// Send request and print response, take interface of ListVpcs for example
var request = new ListVpcsRequest
{
    Limit = 1,
};

var response = vpcClient.ListVpcs(request)
Console.WriteLine(JsonUtils.Serialize(response.Vpcs));
```

#### 4.1 Exceptions [:top:](#user-manual-top)

| Level 1 | Notice | Level 2 | Notice |
| :---- | :---- | :---- | :---- |
| ConnectionException | Connection error | HostUnreachableException | Host is not reachable |
| | | SslHandShakeException | SSL certification error |
| RequestTimeoutException | Request timeout | CallTimeoutException | timeout for single request |
| | | RetryOutageException | no response after retrying |
| ServiceResponseException | service response error | ServerResponseException | server inner error, http status code: [500,] |
| | | ClientRequestException | invalid request, http status code: [400, 500) |

```csharp
// Handle ClientRequestExceptions
try
{
    var request = new ListVpcsRequest
    {
        Limit = 1,
    };

    var response = vpcClient.ListVpcs(request);
    Console.WriteLine(JsonUtils.Serialize(response.Vpcs));
}
catch (ServiceResponseException serviceResponseException)
{
    Console.WriteLine(serviceResponseException.HttpStatusCode);
    Console.WriteLine(serviceResponseException.ErrorCode);
    Console.WriteLine(serviceResponseException.ErrorMsg);
    Console.WriteLine(serviceResponseException.RequestId);
}
```

### 5. Use Asynchronous Client [:top:](#user-manual-top)

```csharp
// Initialize asynchronous client instance, take VpcAsyncClient for example
var vpcClient = VpcAsyncClient.NewBuilder()
    .WithCredential(auth)
    .WithEndPoint(endpoint)
    .WithHttpConfig(config)
    .Build();

// send asynchronous request
var future = vpcClient.ListVpcsAsync(new ListVpcsRequest()
{
    Limit = 1
});

// get asynchronous response
var response = future.Result;
Console.WriteLine(JsonUtils.Serialize(response.Vpcs));
```

### 6. Troubleshooting [:top:](#user-manual-top)

SDK supports `Access` log and `Debug` log which could be configured manually.

#### 6.1 Access Log [:top:](#user-manual-top)

SDK supports print access log which could be enabled by manual configuration, the log could be output to the console.

For example:

``` csharp
var vpcClient = VpcClient.NewBuilder()
    .WithCredential(auth)
    .WithEndPoint(endpoint)
    // configure log level and request will be print on the console
    .WithLogging(LogLevel.Information)
    .WithHttpConfig(config)
    .Build();
```

After enabled log, the SDK will print the access log by default, every request will be recorded to the console like:

``` text
info: System.Net.Http.HttpClient.SdkHttpClient.LogicalHandler[100]
      Start processing HTTP request GET https://vpc.cn-north-1.myhuaweicloud.com/v1/076958154900d2492f8bc0197405c803/vpcs?limit=1
info: System.Net.Http.HttpClient.SdkHttpClient.ClientHandler[100]
      Sending HTTP request GET https://vpc.cn-north-1.myhuaweicloud.com/v1/076958154900d2492f8bc0197405c803/vpcs?limit=1
info: System.Net.Http.HttpClient.SdkHttpClient.ClientHandler[101]
      Received HTTP response after 517.5326ms - OK
info: System.Net.Http.HttpClient.SdkHttpClient.LogicalHandler[101]
      End processing HTTP request after 543.6428ms - OK
```

#### 6.2 Original HTTP Listener [:top:](#user-manual-top)

In some situation, you may need to debug your http requests, original http request and response information will be
needed. The SDK provides a listener function to obtain the original encrypted http request and response information.

> :warning:  Warning: The original http log information is used in debugging stage only, please do not print the original http header or body in the production environment. These log information is not encrypted and contains sensitive data such as the password of your ECS virtual machine, or the password of your IAM user account, etc. When the response body is binary content, the body will be printed as "***" without detailed information.

```csharp
private void RequestHandler(HttpRequestMessage message, ILogger logger)
{
    logger.LogDebug(message.ToString());
}

private void ResponseHandler(HttpResponseMessage message, ILogger logger)
{
    logger.LogDebug(message.ToString());
}

var vpcClient = VpcClient.NewBuilder()
    .WithCredential(auth)
    .WithEndPoint(endpoint)
    .WithLogging(LogLevel.Debug)
    .WithHttpConfig(config)
    .WithHttpHandler(new HttpHandler()
        .AddRequestHandler(RequestHandler)
        .AddResponseHandler(ResponseHandler))
    .Build();
```

**where:**

HttpHandler supports method `AddRequestHandler` and `AddResponseHandler`.

### 7. FAQ [:top:](#user-manual-top)

Use .Net Framework 4.7 to integrate .Net SDK, a dead lock occurs

**[Symptom]**: When using synchronized client to call an interface, and the program has been started, but where is no
error message or timeout occurs.

**[Cause]**: The inner implementation of sending requests in synchronized client of SDK is to use an asynchronous task,
and SDK will await this task. In such scenario, **deadlock** occurs between the context of the .Net Framework UI and the
asynchronous task context of the SDK. As a result, the asynchronous task of the SDK cannot be
activated. [Original article](https://blog.stephencleary.com/2012/07/dont-block-on-async-code.html)

**[Solution]**: **Switch the synchronous client to the asynchronous client**. If the UI events and API requests are both
asynchronous, there will be no deadlock.
