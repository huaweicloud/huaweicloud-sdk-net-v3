using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;
using Newtonsoft.Json.Linq;

namespace Examples.IoTDA.V5
{
    static class AsyncCommandManagement
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

            createAsyncCommand(iotdaClient);
            showAsyncDeviceCommand(iotdaClient);
        }

        private static void createAsyncCommand(IoTDAClient client)
        {
            CreateAsyncCommandRequest req = new CreateAsyncCommandRequest
            {
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0",
                DeviceId = "5eeb1fefbc61700402bc35f9_1211211",
                Body = new AsyncDeviceCommandRequest()
                {
                   SendStrategy = "immediately",
                   CommandName = "ON_OFF",
                   Paras = JObject.Parse("{\"value\":\"ON\"}")
                }
            };
            try
            {
                var resp = client.CreateAsyncCommand(req);
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

        private static void showAsyncDeviceCommand(IoTDAClient client)
        {
            ShowAsyncDeviceCommandRequest req = new ShowAsyncDeviceCommandRequest
            {
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0",
                DeviceId = "5eeb1fefbc61700402bc35f9_1211211",
                CommandId = "cvdcv",
            };
            try
            {
                var resp = client.ShowAsyncDeviceCommand(req);
                Console.WriteLine(resp.Result);
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