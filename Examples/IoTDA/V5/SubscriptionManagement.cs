using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;
using Newtonsoft.Json;

namespace Examples.IoTDA.V5
{
    static class SubscriptionManagement
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
            var iotdaClient = IoTDAClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            findOneSubscription(iotdaClient);
            findSubscriptions(iotdaClient);
            createSubscription(iotdaClient);
            updateSubscription(iotdaClient);
            deleteOneSubscription(iotdaClient);
        }

        private static void findSubscriptions(IoTDAClient client)
        {
            ListSubscriptionsRequest req = new ListSubscriptionsRequest
            {
                Marker = "ffffffffffffffffffffffff"
            };
            try
            {
                var resp = client.ListSubscriptions(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(resp.Count);
                Console.WriteLine(resp.Marker);
                foreach (var Subscription in resp.Subscriptions)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(Subscription));
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
        
        
        private static void findOneSubscription(IoTDAClient client)
        {
            ShowSubscriptionRequest req = new ShowSubscriptionRequest
            {
                SubscriptionId = "a410be1c-9def-4aec-8301-a9c36b346ba2",
            };
            try
            {
                var resp = client.ShowSubscription(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(JsonConvert.SerializeObject(resp));
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
        
        
        private static void createSubscription(IoTDAClient client)
        {
            CreateSubscriptionRequest req = new CreateSubscriptionRequest
            {
               Body = new CreateSubReq()
               {
                   Callbackurl = "https://10.10.10.10:443/deviceActivate",
                   Channel = "http",
                   Subject = new Subject()
                   {
                       Event = "activate",
                       Resource = "device"
                   }
               }
            };
            try
            {
                var resp = client.CreateSubscription(req);
                Console.WriteLine(resp);
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
        
        private static void updateSubscription(IoTDAClient client)
        {
            UpdateSubscriptionRequest req = new UpdateSubscriptionRequest
            {
                SubscriptionId = "4c961c93-376c-4083-9c27-2e88b43b3c0d",
                Body = new UpdateSubReq()
                {
                    Callbackurl = "https://0.0.0.0:443/deviceActivate"
                }
            };
            try
            {
                var resp = client.UpdateSubscription(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(resp);
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
        
        
        private static void deleteOneSubscription(IoTDAClient client)
        {
            DeleteSubscriptionRequest req = new DeleteSubscriptionRequest
            {
                SubscriptionId = "4c961c93-376c-4083-9c27-2e88b43b3c0d"
            };
            try
            {
                var resp = client.DeleteSubscription(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(resp);
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