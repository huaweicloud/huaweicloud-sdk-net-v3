using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.As.V1;
using HuaweiCloud.SDK.As.V1.Model;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;

namespace Examples.As.V1
{
    public class ScalingConfig
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

            //scaling config test
            ShowScalingConfiguration(asClient);
            ListScalingConfigs(asClient);
            CreateScalingConfig(asClient);
            DeleteScalingConfig(asClient);
            BatchDeleteScalingConfig(asClient);
        }

        // Scaling Configuration
        // ShowScalingConfig
        private static void ShowScalingConfiguration(AsClient asClient)
        {
            var showScalingConfigRequest = new ShowScalingConfigRequest
            {
                ScalingConfigurationId = "fee60fed-b04c-4ce1-9e6d-796999f76e28"
            };
            try
            {
                var showScalingConfigResponse = asClient.ShowScalingConfig(showScalingConfigRequest);
                Console.WriteLine(showScalingConfigResponse.ScalingConfiguration);
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

        // ListScalingConfigs
        private static void ListScalingConfigs(AsClient asClient)
        {
            var listScalingConfigsRequest = new ListScalingConfigsRequest
            {
                ScalingConfigurationName = "as-config-kdrw"
            };
            try
            {
                var listScalingConfigsResponse = asClient.ListScalingConfigs(listScalingConfigsRequest);
                Console.WriteLine(listScalingConfigsResponse.ScalingConfigurations);
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

        // createScalingConfig
        private static void CreateScalingConfig(AsClient asClient)
        {
            var createScalingConfigRequest = new CreateScalingConfigRequest
            {
                Body = new CreateScalingConfigRequestBody
                {
                    ScalingConfigurationName = "test_config",
                    InstanceConfig = new InstanceConfig
                    {
                        FlavorRef = "s2.xlarge.2",
                        ImageRef = "84663868-483c-4067-af7e-9d801e4a42f3",
                        Disk = new List<Disk>
                        {
                            new Disk
                            {
                                Size = 40,
                                VolumeType = Disk.VolumeTypeEnum.SATA,
                                DiskType = Disk.DiskTypeEnum.SYS
                            }
                        },
                        KeyName = "KeyPair-lgj-no-delete"
                    }
                }
            };
            try
            {
                var createScalingConfigResponse = asClient.CreateScalingConfig(createScalingConfigRequest);
                Console.WriteLine(createScalingConfigResponse.ScalingConfigurationId);
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

        //DeleteScalingConfig
        private static void DeleteScalingConfig(AsClient asClient)
        {
            var deleteScalingConfigRequest = new DeleteScalingConfigRequest
            {
                ScalingConfigurationId = "fee60fed-b04c-4ce1-9e6d-796999f76e28"
            };
            try
            {
                var deleteScalingConfigResponse = asClient.DeleteScalingConfig(deleteScalingConfigRequest);
                Console.WriteLine(deleteScalingConfigResponse.HttpStatusCode);
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

        // BatchDeleteScalingConfig
        private static void BatchDeleteScalingConfig(AsClient asClient)
        {
            var batchDeleteScalingConfigRequest = new BatchDeleteScalingConfigsRequest
            {
                Body = new BatchDeleteScalingConfigsRequestBody
                {
                    ScalingConfigurationId = new List<string>
                    {
                        "085b99d1-c923-41ea-9d7e-35b3bdf1e583"
                    }
                }
            };
            try
            {
                var batchDeleteScalingConfigsResponse =
                    asClient.BatchDeleteScalingConfigs(batchDeleteScalingConfigRequest);
                Console.WriteLine(batchDeleteScalingConfigsResponse.HttpStatusCode);
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