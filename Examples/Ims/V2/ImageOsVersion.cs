using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Ims.V2;
using HuaweiCloud.SDK.Ims.V2.Model;

namespace Examples.Ims.V2
{
    public class ImageOsVersion
    {
        static void Main1(string[] args)
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            const string endpoint = "{your endpoint string}";
            const string projectId = "{your projectID string}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var imsClient = ImsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            ListOsVersions(imsClient);
        }
        
        //query image os version list
        private static void ListOsVersions(ImsClient imsV1Client)
        {
            ListOsVersionsRequest osVersionListRequest = new ListOsVersionsRequest();
            
            try
            {
                var osVersionListResponse = imsV1Client.ListOsVersions(osVersionListRequest);
                Console.WriteLine(osVersionListResponse.Body);
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