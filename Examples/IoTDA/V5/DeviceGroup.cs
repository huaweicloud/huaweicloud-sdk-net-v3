using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;
using Newtonsoft.Json;

namespace Examples.IoTDA.V5
{
    static class DeviceGroup
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

            QueryDeviceGroup(iotdaClient);
            QueryDeviceGroupList(iotdaClient);
            addDeviceGroup(iotdaClient);
            updateDeviceGroup(iotdaClient);
            deleteDeviceGroup(iotdaClient);
            manageDevicesInGroup(iotdaClient);
            queryDevicesInGroup(iotdaClient);
        }

        private static void QueryDeviceGroupList(IoTDAClient client)
        {
            ListDeviceGroupsRequest req = new ListDeviceGroupsRequest
            {
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ListDeviceGroups(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(resp.Page);
                foreach (var DeviceGroupResponseDTO in resp.DeviceGroups)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(DeviceGroupResponseDTO));
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
        
        
        private static void QueryDeviceGroup(IoTDAClient client)
        {
            ShowDeviceGroupRequest req = new ShowDeviceGroupRequest
            {
                GroupId = "3da1fb03-8863-42dc-8183-f690c0ebb20b",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ShowDeviceGroup(req);
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
        
        
        private static void addDeviceGroup(IoTDAClient client)
        {
            AddDeviceGroupRequest req = new AddDeviceGroupRequest
            {
                Body = new AddDeviceGroupDTO()
                {
                    Name = "GroupA2",
                    Description = "GroupA1"
                }
            };
            try
            {
                var resp = client.AddDeviceGroup(req);
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
        
        private static void updateDeviceGroup(IoTDAClient client)
        {
            UpdateDeviceGroupRequest req = new UpdateDeviceGroupRequest
            {
                GroupId= "ee1c4b7d-6243-4121-addd-a3ff2f8a675c",
                Body = new UpdateDeviceGroupDTO()
                {
                    Name = "1aaaa",
                    Description = "1bbbb"
                }
            };
            try
            {
                var resp = client.UpdateDeviceGroup(req);
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
        
        
        private static void deleteDeviceGroup(IoTDAClient client)
        {
            DeleteDeviceGroupRequest req = new DeleteDeviceGroupRequest
            {
                GroupId = "ee1c4b7d-6243-4121-addd-a3ff2f8a675c",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.DeleteDeviceGroup(req);
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
        
        private static void manageDevicesInGroup(IoTDAClient client)
        {
            CreateOrDeleteDeviceInGroupRequest req = new CreateOrDeleteDeviceInGroupRequest
            {
                GroupId = "ee1c4b7d-6243-4121-addd-a3ff2f8a675c",
                ActionId="addDevice",
                DeviceId="5e19ca2b16b09003ca4dbd98_test003",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.CreateOrDeleteDeviceInGroup(req);
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
        
        
        private static void queryDevicesInGroup(IoTDAClient client)
        {
            ShowDevicesInGroupRequest req = new ShowDevicesInGroupRequest
            {
                GroupId = "ee1c4b7d-6243-4121-addd-a3ff2f8a675c",
                Marker = "ffffffffffffffffffffffff",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.ShowDevicesInGroup(req);
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
        
        
    }
}