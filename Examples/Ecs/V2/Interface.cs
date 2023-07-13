using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Ecs.V2;
using HuaweiCloud.SDK.Ecs.V2.Model;

namespace Examples.Ecs.V2
{
    public class Interface
    {
        static void Main1(string[] args)
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            //for example endpoint = "https://ecs.XXXXXX.myhuaweicloud.com"
            const string endpoint = "{your endpoint string}";
            const string projectId = "{your projectID string}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var ecsClient = EcsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            ListServerInterfaces(ecsClient);
        }

        private static void ListServerInterfaces(EcsClient client)
        {
            var req = new ListServerInterfacesRequest
            {
                ServerId = "5d78e6e5-1d8f-444c-a9e4-81d3b78e80f5"
            };

            try
            {
                var resp = client.ListServerInterfaces(req);
                var respStatusCode = resp.HttpStatusCode;
                var attachments = resp.InterfaceAttachments;
                Console.WriteLine(respStatusCode);
                foreach (var attachment in attachments)
                {
                    Console.WriteLine(attachment.PortId);
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