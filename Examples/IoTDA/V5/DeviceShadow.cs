using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.As.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;
using Newtonsoft.Json;

namespace Examples.IoTDA.V5
{
    static class DeviceShadow
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

            updateDeviceShadow(iotdaClient);
            getDeviceShadow(iotdaClient);
        }

        private static void updateDeviceShadow(IoTDAClient client)
        {
            UpdateDeviceShadowDesiredDataRequest req = new UpdateDeviceShadowDesiredDataRequest
            {
                DeviceId = "5e25d39a3b7c24fa3638804b_nb_0403_1",
                Body = new UpdateDesireds()
                {
                    Shadow = new List<UpdateDesired>()
                    {
                        new UpdateDesired()
                        {
                            Desired =JsonConvert.DeserializeObject("{\"temperature\": \"1\"}"),
                            ServiceId = "Temperature"
                        }
                    }
                }
            };
            try
            {
                var resp = client.UpdateDeviceShadowDesiredData(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(resp.DeviceId);
                foreach (var DeviceShadowData in resp.Shadow)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(DeviceShadowData));
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


        private static void getDeviceShadow(IoTDAClient client)
        {
            ShowDeviceShadowRequest req = new ShowDeviceShadowRequest
            {
                DeviceId = "5e25d39a3b7c24fa3638804b_nb_0403_1"
            };
            try
            {
                var resp = client.ShowDeviceShadow(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(resp.DeviceId);
                foreach (var DeviceShadowData in resp.Shadow)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(DeviceShadowData));
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