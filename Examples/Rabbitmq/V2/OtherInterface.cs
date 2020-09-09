using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Rabbitmq.V2;
using HuaweiCloud.SDK.Rabbitmq.V2.Model;

namespace Examples.Rabbitmq.V2
{
    public class OtherInterface
    {
        private const string ak = "{your ak string}";
        private const string sk = "{your sk string}";
        private const string endpoint = "{your endpoint}";
        private const string projectId = "{your project id}";
        
        private static void OtherInterfaceMain(string[] args)
        {
            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var rabbitmqClient = RabbitmqClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            // listAvailableZones(rabbitmqClient);
            // listProducts(rabbitmqClient);
            showMaintainWindows(rabbitmqClient);
        }

        private static void listAvailableZones(RabbitmqClient client)
        {
            var req = new ListAvailableZonesRequest();
            
            try
            {
                var resp = client.ListAvailableZones(req);
                Console.WriteLine(resp.GetHttpBody());
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

        private static void listProducts(RabbitmqClient client)
        {
            var req = new ListProductsRequest
            {
                Engine = ListProductsRequest.EngineEnum.RABBITMQ,
            };

            try
            {
                var resp = client.ListProducts(req);
                Console.WriteLine(resp.GetHttpBody());
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

        private static void showMaintainWindows(RabbitmqClient client)
        {
            var req = new ShowMaintainWindowsRequest();

            try
            {
                var resp = client.ShowMaintainWindows(req);
                Console.WriteLine(resp.GetHttpBody());
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