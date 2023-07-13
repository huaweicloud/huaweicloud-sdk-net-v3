using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Kafka.V2;
using HuaweiCloud.SDK.Kafka.V2.Model;

namespace Examples.Kafka.V2
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
        private const string managerUser = "xxxxxxxx";
        private const string managerPasswd = "xxxxxxxx";
        private const string instanceId = "{instance id}";
        
        private static void LifeCycleMgtMain(string[] args)
        {
            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var kafkaClient = KafkaClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();
            
            //listInstance(kafkaClient);
            createInstance(kafkaClient);
            //batchRestartOrDeleteInstances(kafkaClient);
        }

        private static void listInstance(KafkaClient client)
        {
            var req = new ListInstancesRequest();
            try
            {
                var resp = client.ListInstances(req);
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

        private static void createInstance(KafkaClient client)
        {
            var req = new CreatePostPaidInstanceRequest
            {
                Body = new CreatePostPaidInstanceReq
                {
                    Name = "Csharp-sdk-create",
                    AvailableZones = new List<string> {az},
                    Engine = CreatePostPaidInstanceReq.EngineEnum.KAFKA,
                    EngineVersion = CreatePostPaidInstanceReq.EngineVersionEnum._1_1_0,
                    KafkaManagerUser = managerUser,
                    KafkaManagerPassword = managerPasswd,
                    ProductId = "00300-30308-0--0",
                    SecurityGroupId = sgId,
                    Specification = CreatePostPaidInstanceReq.SpecificationEnum._100MB,
                    StorageSpecCode = CreatePostPaidInstanceReq.StorageSpecCodeEnum.DMS_PHYSICAL_STORAGE_NORMAL,
                    StorageSpace = 300,
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

        private static void batchRestartOrDeleteInstances(KafkaClient client)
        {
            var req = new BatchRestartOrDeleteInstancesRequest
            {
                Body = new BatchRestartOrDeleteInstanceReq
                {
                    Action = BatchRestartOrDeleteInstanceReq.ActionEnum.DELETE,
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