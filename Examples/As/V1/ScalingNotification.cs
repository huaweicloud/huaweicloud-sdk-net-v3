using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.As.V1;
using HuaweiCloud.SDK.As.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace Examples.As.V1
{
    public class ScalingNotification
    {
        private static void Main1(string[] args)
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            const string endpoint = "{your endpoint}";
            const string projectId = "{your project id}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var asClient = AsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            //scaling group test
            CreateScalingNotification(asClient);
            ListScalingNotifications(asClient);
            DeleteScalingNotification(asClient);
        }

        // scalingNotification
        // createScalingNotification
        private static void CreateScalingNotification(AsClient asClient)
        {
            var createScalingNotificationRequest = new CreateScalingNotificationRequest
            {
                ScalingGroupId = "2a8a1a58-077e-462e-ad50-d2283ebe607f",
                Body = new CreateNotificationRequestBody
                {
                    TopicUrn = "urn:smn:br-iaas-odin1:0605767fb000d5762ffcc00b78d8b511:DONOTDEL-AS-TOPIC01",
                    TopicScene = new List<string>
                    {
                        "SCALING_UP"
                    }
                }
            };
            try
            {
                var createScalingNotificationResponse =
                    asClient.CreateScalingNotification(createScalingNotificationRequest);
                Console.WriteLine(createScalingNotificationResponse.GetHttpBody());
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

        // ListScalingNotifications
        private static void ListScalingNotifications(AsClient asClient)
        {
            var listScalingNotificationsRequest = new ListScalingNotificationsRequest
            {
                ScalingGroupId = "2a8a1a58-077e-462e-ad50-d2283ebe607f"
            };
            try
            {
                var listScalingNotificationsResponse =
                    asClient.ListScalingNotifications(listScalingNotificationsRequest);
                Console.WriteLine(listScalingNotificationsResponse.Topics);
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

        // DeleteScalingNotification
        private static void DeleteScalingNotification(AsClient asClient)
        {
            var deleteScalingNotificationRequest = new DeleteScalingNotificationRequest
            {
                ScalingGroupId = "2a8a1a58-077e-462e-ad50-d2283ebe607f",
                TopicUrn = "urn:smn:br-iaas-odin1:0605767fb000d5762ffcc00b78d8b511:DONOTDEL-AS-TOPIC01"
            };
            try
            {
                var deleteScalingNotificationResponse =
                    asClient.DeleteScalingNotification(deleteScalingNotificationRequest);
                Console.WriteLine(deleteScalingNotificationResponse.HttpStatusCode);
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