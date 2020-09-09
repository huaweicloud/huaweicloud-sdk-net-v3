using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Rabbitmq.V2;
using HuaweiCloud.SDK.Rabbitmq.V2.Model;

namespace Examples.Rabbitmq.V2
{
    public class LifeCycleMgt
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

        private static void LifeCycleMgtMain(string[] args)
        {
            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var rabbitmqClient = RabbitmqClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            // listInstance(rabbitmqClient);
            // createPostPaidInstance(rabbitmqClient);
            batchRestartOrDeleteInstances(rabbitmqClient);
        }
        
        
        private static void listInstance(RabbitmqClient client)
        {
            var req = new ListInstancesDetailsRequest
            {
                Engine = ListInstancesDetailsRequest.EngineEnum.RABBITMQ,
            };
            try
            {
                var resp = client.ListInstancesDetails(req);
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

        private static void createPostPaidInstance(RabbitmqClient client)
        {
            var req = new CreatePostPaidInstanceRequest
            {
                Body = new CreateInstanceReq
                {
                    Name = "Csharp-sdk-create",
                    AvailableZones = new List<string> {az},
                    Engine = CreateInstanceReq.EngineEnum.RABBITMQ,
                    EngineVersion = CreateInstanceReq.EngineVersionEnum._3_7_17,
                    ProductId = "00300-30109-0--0",
                    SecurityGroupId = sgId,
                    StorageSpace = 100,
                    SubnetId = subNetId,
                    VpcId = vpcId,
                    SslEnable = true,
                    AccessUser = accessUser,
                    Password = accessPasswd,
                }
            };
            try
            {
                var resp = client.CreatePostPaidInstance(req);
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
        
        private static void batchRestartOrDeleteInstances(RabbitmqClient client)
        {
            var req = new BatchRestartOrDeleteInstancesRequest
            {
                Body = new BatchRestartOrDeleteInstanceReq
                {
                    Action = BatchRestartOrDeleteInstanceReq.ActionEnum.RESTART,
                    Instances = new List<string>(){instanceId},
                }
            };
            try
            {
                var resp = client.BatchRestartOrDeleteInstances(req);
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