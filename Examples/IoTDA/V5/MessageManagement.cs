using System;
using System.Collections;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;
using Newtonsoft.Json;

namespace Examples.IoTDA.V5
{
    static class MessageManagement
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

            createMessage(iotdaClient);
            listDeviceMessages(iotdaClient);
            showDeviceMessage(iotdaClient);
        }

        private static void createMessage(IoTDAClient client)
        {
           CreateMessageRequest req = new CreateMessageRequest
            {
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0",
                DeviceId = "",
                Body = new DeviceMessageRequest(){
                     MessageId = "",
                     Name = "",
                     Message = "",
                     Topic = ""
                }
            };
            try
            {
                var resp = client.CreateMessage(req);
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

       private static void listDeviceMessages(IoTDAClient client)
        {
           ListDeviceMessagesRequest req = new ListDeviceMessagesRequest
            {
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0",
                DeviceId = ""
            };
            try
            {
                var resp = client.ListDeviceMessages(req);
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

       private static void showDeviceMessage(IoTDAClient client)
        {
           ShowDeviceMessageRequest req = new ShowDeviceMessageRequest
            {
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0",
                DeviceId = "",
                MessageId = ""
            };
            try
            {
                var resp = client.ShowDeviceMessage(req);
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