using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;
using Newtonsoft.Json;

namespace Examples.IoTDA.V5
{
    static class DeviceManagement
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

            queryDevice(iotdaClient);
            queryDevices(iotdaClient);
            addDevice(iotdaClient);
            updateDevice(iotdaClient);
            deleteDevice(iotdaClient);
            resetDeviceSecret(iotdaClient);
        }

        private static void queryDevices(IoTDAClient client)
        {
            ListDevicesRequest req = new ListDevicesRequest
            {
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ListDevices(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(resp.Page);
                foreach (var SimplifyDevice in resp.Devices)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(SimplifyDevice));
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
        
        
        private static void queryDevice(IoTDAClient client)
        {
            ShowDeviceRequest req = new ShowDeviceRequest
            {
                DeviceId = "5e25d39a3b7c24fa3638804b_1211211",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ShowDevice(req);
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
        
        
        private static void addDevice(IoTDAClient client)
        {
            AddDeviceRequest req = new AddDeviceRequest
            {
                Body = new AddDevice()
                {
                    NodeId = "1211211",
                    ProductId = "5e25d39a3b7c24fa3638804b"
                }
            };
            try
            {
                var resp = client.AddDevice(req);
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
        
        private static void updateDevice(IoTDAClient client)
        {
            UpdateDeviceRequest req = new UpdateDeviceRequest
            {
                DeviceId = "5e25d39a3b7c24fa3638804b_1211211",
                Body = new UpdateDevice()
                {
                    DeviceName= "test",
                    Description= "dfsdfgfgvfdfddfvdf",
                    AuthInfo = new AuthInfoWithoutSecret()
                    {
                        SecureAccess = true,
                        Timeout = 0
                    }
                    
                }
            };
            try
            {
                var resp = client.UpdateDevice(req);
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
        
        
        private static void deleteDevice(IoTDAClient client)
        {
            DeleteDeviceRequest req = new DeleteDeviceRequest
            {
                DeviceId = "5e25d39a3b7c24fa3638804b_1211211",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.DeleteDevice(req);
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
        
        private static void resetDeviceSecret(IoTDAClient client)
        {
            ResetDeviceSecretRequest req = new ResetDeviceSecretRequest
            {
                Body = new ResetDeviceSecret()
                {
                    Secret = "12345678910"
                },
                ActionId="resetSecret",
                DeviceId="5e25d39a3b7c24fa3638804b_1211211",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ResetDeviceSecret(req);
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

        private static void freezeDevice(IoTDAClient client)
        {
            FreezeDeviceRequest req = new FreezeDeviceRequest
            {
                DeviceId="5e25d39a3b7c24fa3638804b_1211211",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.FreezeDevice(req);
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
        
        private static void unfreezeDevice(IoTDAClient client)
        {
            UnfreezeDeviceRequest req = new UnfreezeDeviceRequest
            {
                DeviceId="5e25d39a3b7c24fa3638804b_1211211",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.UnfreezeDevice(req);
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