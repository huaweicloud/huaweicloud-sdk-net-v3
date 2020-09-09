using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Kafka.V2;
using HuaweiCloud.SDK.Kafka.V2.Model;

namespace Examples.Kafka.V2
{
    public class OtherInterface
    {
        private const string ak = "{your ak string}";
        private const string sk = "{your sk string}";
        private const string endpoint = "{your endpoint}";
        private const string projectId = "{your project id}";

        private const string az = "{az id}";
        private const string vpcId = "{your vpc id}";
        private const string subNetId = "{your sub net id}";
        private const string sgId = "{your security gate id}";
        private const string accessUser = "xxxxxxxx";
        private const string accessPasswd = "xxxxxxxx";
        private const string instanceId = "{instance id}";
        
        private static void OtherInterfaceMain(string[] args)
        {
            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var kafkaClient= KafkaClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            listAvailableZones(kafkaClient);
            listProducts(kafkaClient);
            showMaintainWindows(kafkaClient);
        }

        private static void listAvailableZones(KafkaClient client)
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

        private static void listProducts(KafkaClient client)
        {
            var req = new ListProductsRequest
            {
                Engine = ListProductsRequest.EngineEnum.KAFKA,
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

        private static void showMaintainWindows(KafkaClient client)
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