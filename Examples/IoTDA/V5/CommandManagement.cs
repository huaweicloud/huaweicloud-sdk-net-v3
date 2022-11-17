using System;
using System.Collections;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Examples.IoTDA.V5
{
    static class CommandManagement
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

            createCommand(iotdaClient);
        }

        private static void createCommand(IoTDAClient client)
        {
            CreateCommandRequest req = new CreateCommandRequest
            {
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0",
                DeviceId = "5eeb1fefbc61700402bc35f9_1211211",
                Body = new DeviceCommandRequest()
                {
                   ServiceId = "b1224afb-e9f0-4916-8220-b6bab568e888",
                   CommandName = "ON_OFF",
                   Paras = JObject.Parse("{\"value\":\"ON\"}")

                }
            };
            try
            {
                var resp = client.CreateCommand(req);
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