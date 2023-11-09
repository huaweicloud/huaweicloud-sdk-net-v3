English | [简体中文](README_CN.md)

<p align="center">
<a href="https://www.huaweicloud.com/"><img width="450px" height="102px" src="https://console-static.huaweicloud.com/static/authui/20210202115135/public/custom/images/logo-en.svg"></a>
</p>

<h1 align="center">Huawei Cloud .Net Software Development Kit (.Net SDK)</h1>

The Huawei Cloud .Net SDK allows you to easily work with Huawei Cloud services such as Elastic Compute Service (ECS) and
Virtual Private Cloud(VPC) without the need to handle API related tasks.

This document introduces how to obtain and use Huawei Cloud .Net SDK.

## Requirements

- To use Huawei Cloud .Net SDK, you must have Huawei Cloud account as well as the Access Key (AK) and Secret key (SK) of the
  Huawei Cloud account. You can create an Access Key in the Huawei Cloud console. For more information,
  see [My Credentials](https://support.huaweicloud.com/en-us/usermanual-ca/en-us_topic_0046606340.html).

- To use Huawei Cloud .Net SDK to access the APIs of specific service, please make sure you do have activated the
  service in [Huawei Cloud console](https://console.huaweicloud.com/?locale=en-us) if needed.

- The .NET SDK requires：
  - **.NET and .NET Core 2.0** or above
  - **.NET Framework 4.6.2** or above

For more version maintenance information, please refer to **Lifecycle FAQ** - [.NET Core](https://learn.microsoft.com/en-us/lifecycle/faq/dotnet-core), [.NET Framework](https://learn.microsoft.com/en-us/lifecycle/faq/dotnet-framework)

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
- Hard-coding ak and sk for authentication into the code has a great security risk. It is recommended to store the ciphertext in the profile or environment variables and decrypt it when used to ensure security.
- In this example, ak and sk are stored in environment variables. Please configure the environment variables `HUAWEICLOUD_SDK_AK` and `HUAWEICLOUD_SDK_SK` before running this example.

**Simplified Demo**

```csharp
using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace ListVpcsSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure authentication
        	// Authentication can be configured through environment variables and other methods. Please refer to Chapter 2.3 Authentication Management
            var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
            var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
            var auth = new BasicCredentials(ak, sk);

            // Create a service client
            var client = VpcClient.NewBuilder()
                .WithCredential(auth)
                .WithRegion(VpcRegion.ValueOf("cn-north-4"))
                .Build();

            // Create a request
            var request = new ListVpcsRequest();
            try
            {
                // Send the request and get the response
                var response = client.ListVpcs(request);
                Console.WriteLine(response.HttpStatusCode);
            }
            catch (RequestTimeoutException requestTimeoutException)
            {
                Console.WriteLine(requestTimeoutException.ErrorMessage);
            }
            catch (ServiceResponseException clientRequestException)
            {
                Console.WriteLine(clientRequestException.HttpStatusCode);
                Console.WriteLine(clientRequestException.RequestId);
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

**Detailed Demo**

```csharp
using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;
using Microsoft.Extensions.Logging;

namespace ListVpcsSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure authentication
        	// Authentication can be configured through environment variables and other methods. Please refer to Chapter 2.3 Authentication Management
            // If projectId is not filled in, the SDK will automatically call the IAM service to query the project id corresponding to the region.
            var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
            var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
            var projectId = "{your projectId string}";
            var auth = new BasicCredentials(ak, sk, projectId: projectId)
                // Configure the SDK built-in IAM service endpoint, default is https://iam.myhuaweicloud.com
                .WithIamEndpoint("https://iam.cn-north-4.myhuaweicloud.com");

            // Use default configuration
            var httpConfig = HttpConfig.GetDefaultConfig()
                // Configure whether to ignore the SSL certificate verification, default is false
                .WithIgnoreSslVerification(true)
                // Configure timeout as needed, default timeout is 120 seconds
                .WithTimeout(120)
                // Configure proxy as needed
                // Replace the proxy host and port in the example according to the actual situation
                .WithProxyHost("proxy.huaweicloud.com")
                .WithProxyPort(8080)
                // Configure the username and password if the proxy requires authentication
                .WithIgnoreProxyUsername(Environment.GetEnvironmentVariable("PROXY_USERNAME"))
                .WithIgnoreProxyPassword(Environment.GetEnvironmentVariable("PROXY_PASSWORD"));

            // Configure HTTP handler to print the original request and response, do not use it in a production environment
            var httpHandler = new HttpHandler()
                .AddRequestHandler((requestMessage, logger) => logger.LogDebug(requestMessage.ToString()))
                .AddResponseHandler((responseMessage, logger) => logger.LogDebug(responseMessage.ToString()));

            // Create a service client
            var client = VpcClient.NewBuilder()
                // Configure authentication
                .WithCredential(auth)
                // Configure region, it will throw a ArgumentNullException if the region does not exist
                .WithRegion(VpcRegion.ValueOf("cn-north-4"))
                // Configure log level
                .WithLogging(LogLevel.Debug)
                // Configure HTTP handler
                .WithHttpHandler(httpHandler)
                // Configure HTTP
                .WithHttpConfig(httpConfig)
                .Build();

            // Create a request
            var request = new ListVpcsRequest();
            // Configure the number of records on each page
            request.Limit = 1;
            try
            {
                // Send the request and get the response
                var response = client.ListVpcs(request);
                foreach (var vpc in response.Vpcs)
                {
                    Console.WriteLine(vpc.Name);
                    Console.WriteLine(vpc.Description);
                }
            }
            catch (RequestTimeoutException requestTimeoutException)
            {
                Console.WriteLine(requestTimeoutException.ErrorMessage);
            }
            catch (ServiceResponseException clientRequestException)
            {
                Console.WriteLine(clientRequestException.HttpStatusCode);
                Console.WriteLine(clientRequestException.RequestId);
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

## Online Debugging

[API Explorer](https://apiexplorer.developer.intl.huaweicloud.com/apiexplorer/overview) provides api retrieval and online debugging, supports full fast retrieval, visual debugging, help document viewing, and online consultation.

## Changelog

Detailed changes for each released version are documented in
the [CHANGELOG.md](https://github.com/huaweicloud/huaweicloud-sdk-net-v3/blob/master/CHANGELOG.md).

## User Manual [:top:](#huawei-cloud-net-software-development-kit-net-sdk)

* [1. Client Configuration](#1-client-configuration-top)
    * [1.1 Default Configuration](#11-default-configuration-top)
    * [1.2 Network Proxy](#12-network-proxy-top)
    * [1.3 Timeout Configuration](#13-timeout-configuration-top)
    * [1.4 SSL Certification](#14-ssl-certification-top)
* [2. Credentials Configuration](#2-credentials-configuration-top)
    * [2.1 Use Permanent AK&SK](#21-use-permanent-aksk-top)
    * [2.2 Use Temporary AK&SK](#22-use-temporary-aksk-top)
    * [2.3 Authentication Management](#23-authentication-management-top)
        * [2.3.1 Environment Variables](#231-environment-variables-top)
        * [2.3.2 Profile](#232-profile-top)
        * [2.3.3 Provider Chain](#233-provider-chain-top)
* [3. Client Initialization](#3-client-initialization-top)
    * [3.1 Initialize the client with specified Endpoint](#31-initialize-the-serviceclient-with-specified-endpoint-top)
    * [3.2 Initialize the client with specified Region (Recommended)](#32-initialize-the-serviceclient-with-specified-region-recommended-top)
    * [3.3 Custom Configuration](#33-custom-configuration-top)
        * [3.3.1 IAM endpoint configuration](#331-iam-endpoint-configuration-top)
        * [3.3.2 Region configuration](#332-region-configuration-top)
* [4. Send Requests and Handle Responses](#4-send-requests-and-handle-responses-top)
    * [4.1 Exceptions](#41-exceptions-top)
* [5. Use Asynchronous Client](#5-use-asynchronous-client-top)
* [6. Troubleshooting](#6-troubleshooting-top)
    * [6.1 Access Log](#61-access-log-top)
    * [6.2 Original HTTP Listener](#62-original-http-listener-top)
* [7. Upload Files](#7-upload-files-top)
* [8. FAQ](#8-faq-top)

### 1. Client Configuration [:top:](#user-manual-top)

#### 1.1 Default Configuration [:top:](#user-manual-top)

```csharp
// Use default configuration
var httpConfig = HttpConfig.GetDefaultConfig();

var client = VpcClient.NewBuilder()
    .WithHttpConfig(httpConfig)
    .Build();
```

#### 1.2 Network Proxy [:top:](#user-manual-top)

Use network proxy if needed.

- Only HTTP proxy is supported if you have assigned proxy port when configuring proxy.

``` csharp
var httpConfig = HttpConfig.GetDefaultConfig()
    // Replace the proxy host and port in the example according to the actual situation
    .WithProxyHost("proxy.huaweicloud.com")
    .WithProxyPort(8080)
    // Configure the username and password if the proxy requires authentication
    .WithIgnoreProxyUsername(Environment.GetEnvironmentVariable("PROXY_USERNAME"))
    .WithIgnoreProxyPassword(Environment.GetEnvironmentVariable("PROXY_PASSWORD"));

var client = VpcClient.NewBuilder()
    .WithHttpConfig(httpConfig)
    .Build();
```

- Both HTTP and HTTPS proxy are supported if proxy port is unassigned when configuring proxy.

``` csharp
var httpConfig = HttpConfig.GetDefaultConfig()
    .WithProxyHost("https://proxy.huaweicloud.com:8080")
    // Configure the username and password if the proxy requires authentication
    .WithIgnoreProxyUsername(Environment.GetEnvironmentVariable("PROXY_USERNAME"))
    .WithIgnoreProxyPassword(Environment.GetEnvironmentVariable("PROXY_PASSWORD"));

var client = VpcClient.NewBuilder()
    .WithHttpConfig(httpConfig)
    .Build();
```

#### 1.3 Timeout Configuration [:top:](#user-manual-top)

``` csharp
// The default timeout is 120 seconds, which can be adjusted as needed
var httpConfig = HttpConfig.GetDefaultConfig().WithTimeout(120);

var client = VpcClient.NewBuilder()
    .WithHttpConfig(httpConfig)
    .Build();
```

#### 1.4 SSL Certification [:top:](#user-manual-top)

``` csharp
// Skip SSL certifaction checking while using https protocal if needed
var httpConfig = HttpConfig.GetDefaultConfig().WithIgnoreSslVerification(true);

var client = VpcClient.NewBuilder()
    .WithHttpConfig(httpConfig)
    .Build();
```

### 2. Credentials Configuration [:top:](#user-manual-top)

There are two types of Huawei Cloud services, `regional` services and `global` services.

Global services contain IAM, TMS, EPS.

For `regional` services' authentication, projectId is required to initialize BasicCredentials. 

For `global` services' authentication, domainId is required to initialize GlobalCredentials.

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
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
var projectId = "{your projectId string}";

Credentials basicCredentials = new BasicCredentials(ak, sk, projectId);

// Global services
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
var domainId = "{your domainId string}";

Credentials globalCredentials = new GlobalCredentials(ak, sk, domainId);
```

**Notice**:

- projectId/domainId supports **automatic acquisition** in version `3.0.26-beta` or later, if you want to use this
  feature, you need to provide the ak and sk of your account and the id of the region, and then build your client
  instance with method `WithRegion()`, detailed example could refer
  to [3.2 Initialize the client with specified Region](#32-initialize-the-serviceclient-with-specified-region-recommended-top)
  .

#### 2.2 Use Temporary AK&SK [:top:](#user-manual-top)

It's required to obtain temporary AK&SK and security token first, which could be obtained through
permanent AK&SK or through an agency.

- Obtaining a temporary access key and security token through token, you could refer to
document: https://support.huaweicloud.com/en-us/api-iam/iam_04_0002.html . The API mentioned in the document above
corresponds to the method of `CreateTemporaryAccessKeyByToken` in IAM SDK.

- Obtaining a temporary access key and security token through an agency, you could refer to
document: https://support.huaweicloud.com/en-us/api-iam/iam_04_0101.html . The API mentioned in the document above
corresponds to the method of `CreateTemporaryAccessKeyByAgency` in IAM SDK.

``` csharp
// Regional services
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
var securityToken = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SECURITY_TOKEN");
var projectId = "{your projectId string}";

Credentials basicCredentials = new BasicCredentials(ak, sk, projectId).WithSecurityToken(securityToken);
    
// Global services
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
var securityToken = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SECURITY_TOKEN");
var domainId = "{your domainId string}";

Credentials globalCredentials = new GlobalCredentials(ak, sk, domainId).WithSecurityToken(securityToken);
```

#### 2.3 Authentication Management [:top:](#user-manual-top)

Getting Authentication from providers is supported since `v3.1.62`

**Regional services** use `XxxCredentialProvider.GetBasic()`

**Global services** use `XxxCredentialProvider.GetGlobal()`

##### 2.3.1 Environment Variables [:top:](#user-manual-top)

**AK/SK Auth**

| Environment Variables  |  Notice |
| ------------ | ------------ |
| HUAWEICLOUD_SDK_AK  | Required，AccessKey  |
| HUAWEICLOUD_SDK_SK  |  Required，SecretKey |
| HUAWEICLOUD_SDK_SECURITY_TOKEN  | Optional, this parameter needs to be specified when using temporary ak/sk  |
| HUAWEICLOUD_SDK_PROJECT_ID  | Optional, used for regional services, required in multi-ProjectId scenarios  |
| HUAWEICLOUD_SDK_DOMAIN_ID  | Optional, used for global services  |

Configure environment variables:

```
// Linux
export HUAWEICLOUD_SDK_AK=YOUR_AK
export HUAWEICLOUD_SDK_SK=YOUR_SK

// Windows
set HUAWEICLOUD_SDK_AK=YOUR_AK
set HUAWEICLOUD_SDK_SK=YOUR_SK
```

Get the credentials from configured environment variables:

```java
using HuaweiCloud.SDK.Core.Auth;

// basic
var basicProvider = EnvCredentialProvider.GetBasic();
var basicCredentials = basicProvider.GetCredentials();

// global
var globalProvider = EnvCredentialProvider.GetGlobal();
var globalCredentials = globalProvider.GetCredentials();
```

##### 2.3.2 Profile [:top:](#user-manual-top)

The profile will be read from the user's home directory by default, linux`~/.huaweicloud/credentials`,windows`C:\Users\USER_NAME\.huaweicloud\credentials`, the path to the profile can be modified by configuring the environment variable `HUAWEICLOUD_SDK_CREDENTIALS_FILE`

**AK/SK Auth**

| Configuration Parameters  |  Notice |
| ------------ | ------------ |
| ak  | Required，AccessKey  |
| sk  |  Required，SecretKey |
| security_token  | Optional, this parameter needs to be specified when using temporary ak/sk  |
| project_id  | Optional, used for regional services, required in multi-ProjectId scenarios  |
| domain_id  | Optional, used for global services  |
| iam_endpoint  | optional, endpoint for authentication, default is `https://iam.myhuaweicloud.com` |

The content of the profile is as follows:

```ini
[basic]
ak = your_ak
sk = your_sk

[global]
ak = your_ak
sk = your_sk
```

Get the credentials from profile:

```csharp
using HuaweiCloud.SDK.Core.Auth;

// basic
var basicProvider = ProfileCredentialProvider.GetBasic();
var basicCredentials = basicProvider.GetCredentials();

// global
var globalProvider = ProfileCredentialProvider.GetGlobal();
var globalCredentials = globalProvider.GetCredentials();
```

##### 2.3.3 Provider Chain [:top:](#user-manual-top)

When creating a service client without credentials, try to load authentication in the order **Environment Variables -> Profile**

Get authentication from provider chain:

```csharp
using HuaweiCloud.SDK.Core.Auth;

// basic
var basicChain = CredentialProviderChain.GetBasic();
var basicCredentials = basicChain.GetCredentials();

// global
var globalChain = CredentialProviderChain.GetGlobal();
var globalCredentials = globalChain.GetCredentials();
```

Custom credentials provider chain is supported:

```csharp
using HuaweiCloud.SDK.Core.Auth;

var providers = new ICredentialProvider[]
{
    ProfileCredentialProvider.GetBasic(),
    EnvCredentialProvider.GetBasic()
};
var chain = new CredentialProviderChain(providers);
var credentials = chain.GetCredentials();
```

### 3. Client Initialization [:top:](#user-manual-top)

There are two ways to initialize the {Service}Client, you could choose one you preferred.

#### 3.1 Initialize the {Service}Client with specified Endpoint [:top:](#user-manual-top)

``` csharp
// Specify the endpoint, take the endpoint of VPC service in region of cn-north-4 for example
String endpoint = "https://vpc.cn-north-4.myhuaweicloud.com";

// Initialize the credentials, you should provide projectId or domainId in this way, take initializing BasicCredentials for example
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
var projectId = "{your projectId string}";
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
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
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

#### 3.3 Custom Configuration [:top:](#user-manual-top)

**Notice:** Supported since v3.1.62

##### 3.3.1 IAM endpoint configuration [:top:](#user-manual-top)

Automatically acquiring projectId/domainId will invoke the [KeystoneListProjects](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product=IAM&api=KeystoneListProjects) /[KeystoneListAuthDomains](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product=IAM&api=KeystoneListAuthDomains) interface of IAM service. The default iam enpoint is `https://iam.myhuaweicloud.com`, **European station users need to specify the endpoint as https://iam.eu-west-101.myhuaweicloud.com**, you can modify the endpoint in the following two ways:

###### 3.3.1.1 Global scope [:top:](#user-manual-top)

This configuration takes effect globally, specified by environment variable `HUAWEICLOUD_SDK_IAM_ENDPOINT`

```
//linux
export HUAWEICLOUD_SDK_IAM_ENDPOINT=https://iam.cn-north-4.myhuaweicloud.com

//windows
set HUAWEICLOUD_SDK_IAM_ENDPOINT=https://iam.cn-north-4.myhuaweicloud.com
```

###### 3.3.1.2 Credentials scope [:top:](#user-manual-top)

This configuration is only valid for a credential, and it will override the global configuration

```csharp
using System;
using HuaweiCloud.SDK.Core.Auth;

var iamEndpoint = "https://iam.cn-north-4.myhuaweicloud.com";
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
var credentials = new BasicCredentials(ak, sk).WithIamEndpoint(iamEndpoint);
```

##### 3.3.2 Region configuration [:top:](#user-manual-top)

###### 3.3.2.1 Environment variable [:top:](#user-manual-top)

Specified by environment variable, a region can correspond to multiple endpoints.

If the main endpoint cannot be connected, it will automatically switch to the backup endpoint.

The format is `HUAWEICLOUD_SDK_REGION_{SERVICE_NAME}_{REGION_ID}={endpoint1},{endpoint2}`, separate multiple endpoints with commas.

Notice: the name of environment variable is UPPER-CASE, replacing hyphens with underscores.

```
// linux
export HUAWEICLOUD_SDK_REGION_ECS_CN_NORTH_9=https://ecs.cn-north-9.myhuaweicloud.com,https://ecs.cn-north-9.myhuaweicloud.cn

// windows
set HUAWEICLOUD_SDK_REGION_ECS_CN_NORTH_9=https://ecs.cn-north-9.myhuaweicloud.com,https://ecs.cn-north-9.myhuaweicloud.cn
```

###### 3.3.2.2 Profile [:top:](#user-manual-top)

The profile will be read from the user's home directory by default, linux`~/.huaweicloud/regions.yaml`,windows`C:\Users\USER_NAME\.huaweicloud\regions.yaml`,the default file may not exist, but if the file exists and the content format is incorrect, an exception will be thrown for parsing errors.

The path to the profile can be modified by configuring the environment variable `HUAWEICLOUD_SDK_REGIONS_FILE`, like `HUAWEICLOUD_SDK_REGIONS_FILE=/tmp/my_regions.yml`

A region can correspond to multiple endpoints, if the main endpoint cannot be connected, it will automatically switch to the backup endpoint.

The file content format is as follows:

```yaml
# Serivce name is case-insensitive
ECS:
  - id: 'cn-north-9'
    endpoints:
      - 'https://ecs.cn-north-9.myhuaweicloud.com'
      - 'https://ecs.cn-north-9.myhuaweicloud.cn'
```

###### 3.3.2.3 Region supply chain [:top:](#user-manual-top)

The default order is **environment variables -> profile -> region defined in SDK**, if the region is not found in the above ways, an exception will be thrown.

```csharp
using HuaweiCloud.SDK.Ecs.V2;

var region = EcsRegion.ValueOf("cn-north-9");
```

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
var vpcAsyncClient = VpcAsyncClient.NewBuilder()
    .WithCredential(auth)
    .WithEndPoint(endpoint)
    .WithHttpConfig(config)
    .Build();


var request = new ListVpcsRequest();

// Send the request asynchronously and get the response
var response = await vpcAsyncClient.ListVpcsAsync(request);
Console.WriteLine(JsonUtils.Serialize(response));
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

var client = VpcClient.NewBuilder()
    .WithLogging(LogLevel.Debug)
    .WithHttpHandler(new HttpHandler()
        .AddRequestHandler(RequestHandler)
        .AddResponseHandler(ResponseHandler))
    .Build();
```

**where:**

HttpHandler supports method `AddRequestHandler` and `AddResponseHandler`.

### 7. Upload Files [:top:](#user-manual-top)

Take the interface `UploadBatchTaskFile` of the service `IoT Device Access` as an example:

```csharp
using System;
using System.IO;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;

namespace UploadBatchTaskFileDemo
{
    class Program
    {

        static void UploadBatchTaskFile(IoTDAClient client)
        {
            var file = File.OpenRead("/tmp/template.xlsx");
            var filePart = new FormDataFilePart(file, "template.xlsx");

            var body = new UploadBatchTaskFileRequestBody()
            {
                File = filePart
            };

            var req = new UploadBatchTaskFileRequest
            {
                Body = body
            };

            var resp = client.UploadBatchTaskFile(req);
            var respStatusCode = resp.HttpStatusCode;
            Console.WriteLine(respStatusCode);
        }

        static void Main(string[] args)
        {
            var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
            var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
            var projectId = "{your project id}";
            var endpoint = "{your endpoint string}";

            var auth = new BasicCredentials(ak, sk, projectId);

            var client = IoTDAClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .Build();

            UploadBatchTaskFile(client);
        }
    }
}
```

### 8. FAQ [:top:](#user-manual-top)

1 Using .NET Framework 4.7 to integrate .NET SDK, an exception throws - ProtocolViolationException: Cannot send a content-body with this verb-type

**[Cause]**: .NET Framework does not support generating GET requests with content-body.

**[Solution]**: Configuration parameter `IgnoreBodyForGetRequest` makes GET request without content-body, as follows:

```c#
var httpConfig = HttpConfig.GetDefaultConfig();
httpConfig.IgnoreBodyForGetRequest = true;

var client = VpcClient.NewBuilder()
    .WithCredential(auth)
    .WithHttpConfig(httpConfig)
    .WithRegion(VpcRegion.ValueOf("cn-north-4"))
    .Build();
```

2 Use .NET Framework 4.7 to integrate .NET SDK, a dead lock occurs

**[Symptom]**: When using synchronized client to call an interface, and the program has been started, but where is no
error message or timeout occurs.

**[Cause]**: The inner implementation of sending requests in synchronized client of SDK is to use an asynchronous task,
and SDK will await this task. In such scenario, **deadlock** occurs between the context of the .NET Framework UI and the
asynchronous task context of the SDK. As a result, the asynchronous task of the SDK cannot be
activated. [Original article](https://blog.stephencleary.com/2012/07/dont-block-on-async-code.html)

**[Solution]**: **Switch the synchronous client to the asynchronous client**. If the UI events and API requests are both
asynchronous, there will be no deadlock. The following are examples of MVC and WPF solutions:

MVC

```c#
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly VpcAsyncClient _vpcAsyncClient = InitAsyncClient();

        private static VpcAsyncClient InitAsyncClient()
        {
            var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
            var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
            var auth = new BasicCredentials(ak, sk);
			
            // Use asynchronous client
            var client = VpcAsyncClient.NewBuilder()
                    .WithCredential(auth)
                    .WithRegion(VpcRegion.ValueOf("cn-north-4"))
                    .Build();
            return client;
        }

        private async Task<ListVpcsResponse> ListVpcsAsync()
        {
            var req = new ListVpcsRequest();
            
            // Send the request asynchronously, using await will not block the thread
            var resp = await _vpcAsyncClient.ListVpcsAsync(req);
            Console.WriteLine(resp.GetHttpStatusCode());
            return resp;
        }

        public ActionResult Index()
        {
            return View();
        }
        
        // Replace synchronous methods with asynchronous methods
        public async Task<ActionResult> About()
        {
            var resp = await ListVpcsAsync();
            var respString = JsonUtils.Serialize(resp);

            ViewBag.Message = respString;
            return View();
        }
    }
}
```

WPF

```c#
using System;
using System.Threading.Tasks;
using System.Windows;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {

        private readonly VpcAsyncClient _asyncClient = InitAsyncClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        private static VpcAsyncClient InitAsyncClient()
        {
            var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
            var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
            var auth = new BasicCredentials(ak, sk);

            // Use asynchronous client
            var client = VpcAsyncClient.NewBuilder()
                .WithCredential(auth)
                .WithRegion(VpcRegion.ValueOf("cn-north-4"))
                .Build();

            return client;
        }

        private async Task<ListVpcsResponse> ListVpcs()
        {
            var req = new ListVpcsRequest();

            // Send the request asynchronously, using await will not block the thread
            var resp = await _asyncClient.ListVpcsAsync(req);
            Console.WriteLine(resp.GetHttpStatusCode());
            return resp;
        }

        // Replace synchronous methods with asynchronous methods
        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var resp = await ListVpcs();
            var respString = JsonUtils.Serialize(resp);
            MessageBox.Show(respString);
        }
    }
}
```