using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Dds.V3;
using HuaweiCloud.SDK.Dds.V3.Model;

namespace Examples.DDS.V3
{
    static class DdsV3 
    { 
        static void DdsMain(string[] args)
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            const string endpoint = "{your endpoint}";
            const string projectId = "{your project id}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var ddsClient = DdsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            // DatastoreVersions
            ListDatastoreVersion(ddsClient);

            // Flavors
            ListFlavor(ddsClient);
            
            // Instances
            CreateInstance(ddsClient);
            RestartInstance(ddsClient);
            ListInstance(ddsClient);
            EnlargeInstanceVolume(ddsClient);
            EnlargeShardingNode(ddsClient);
            ResizeInstance(ddsClient);
            DeleteInstance(ddsClient);
            
            // Backups
            CreateManualBackup(ddsClient);
            ListBackups(ddsClient);
            SetBackupPolicy(ddsClient);
            GetBackupPolicy(ddsClient);
            DeleteManualBackup(ddsClient);
            
            // Tags
            ListInstancesByTags(ddsClient);
            BatchCreateInstanceTags(ddsClient);
            ListInstanceTags(ddsClient);
            BatchDeleteInstanceTags(ddsClient);
            QueryProjectTags(ddsClient);
        }

    /***************************************DatastoreVersions Start**************************************************/
        /// <summary>
        /// 查询数据库版本信息
        /// </summary>
        public static void ListDatastoreVersion(DdsClient client)
        {
            ListDatastoreVersionsRequest req = new ListDatastoreVersionsRequest
            {
                DatastoreName = ListDatastoreVersionsRequest.DatastoreNameEnum.DDS_COMMUNITY
            };
            try
            {
                ListDatastoreVersionsResponse resp = client.ListDatastoreVersions(req);
                foreach (var version in resp.Versions)
                {
                    Console.WriteLine(version);
                }
                Console.WriteLine("List Datastore Success!");
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
        /****************************************DatastoreVersions End***************************************************/


        /********************************************Flavors Start*******************************************************/
        /// <summary>
        /// 查询所有实例规格信息
        /// </summary>
        public static void ListFlavor(DdsClient client)
        {
            ListFlavorsRequest req = new ListFlavorsRequest
            {
                Region = "cn-xianhz-1"
            };
            try
            {
                ListFlavorsResponse resp = client.ListFlavors(req);
                foreach (var flavor in resp.Flavors)
                {
                    Console.WriteLine(flavor.EngineName);
                    Console.WriteLine(flavor.Type);
                }
                Console.WriteLine("List Flavor Success!");
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
        /*********************************************Flavors End********************************************************/


        /*******************************************Instances Start******************************************************/
        /// <summary>
        /// 创建实例
        /// </summary>
        public static void CreateInstance(DdsClient client)
        {
            CreateInstanceRequest req = new CreateInstanceRequest
            {
                /*Body = new CreateInstanceRequestBody
                {
                    Name = "dds-test",
                    Datastore = new CreateInstanceDatastoreOption()
                    {
                        Type = "DDS-Community",
                        Version = "3.4",
                        StorageEngine = "wiredTiger"
                    },
                    Region = "cn-guangzhou-1",
                    AvailabilityZone = "az2pod1gz",
                    VpcId = "50e61d1e-ac98-4f92-9505-bb1bfb01c84b",
                    SubnetId = "f5cfcd56-63ac-4dab-ae66-f7eb4cdd03b6",
                    SecurityGroupId = "f64c9fe9-2dbc-47ea-81cc-bea1c29e2c62",
                    Password = "******",
                    Mode = "Sharding",
                    Flavor = new List<CreateInstanceFlavorOption>
                    {
                        new CreateInstanceFlavorOption()
                        {
                            Type = "mongos",
                            Num = 2,
                            SpecCode = "dds.mongodb.s6.medium.4.mongos"
                        },
                        new CreateInstanceFlavorOption()
                        {
                            Type = "shard",
                            Num = 2,
                            Storage = "ULTRAHIGH",
                            Size = 10,
                            SpecCode = "dds.mongodb.s6.medium.4.shard"
                        },
                        new CreateInstanceFlavorOption()
                        {
                            Type = "config",
                            Num = 1,
                            Storage = "ULTRAHIGH",
                            Size = 20,
                            SpecCode = "dds.mongodb.s6.large.2.config"
                        }
                    },
                    BackupStrategy = new CreateInstanceBackupStrategyOption()
                    {
                        StartTime = "08:15-09:15",
                        KeepDays = "8"
                    },
                    Storage = new CreateInstanceStorageOption()
                    {
                        Size = 2
                    },
                    SslOption = "1"
                }*/
                Body = new CreateInstanceRequestBody
                {
                    Name = "dds-test1",
                    Datastore = new CreateInstanceDatastoreOption()
                    {
                        Type = CreateInstanceDatastoreOption.TypeEnum.DDS_COMMUNITY,
                        Version = "3.4",
                        StorageEngine = CreateInstanceDatastoreOption.StorageEngineEnum.WIREDTIGER
                    },
                    Region = "cn-guangzhou-1",
                    AvailabilityZone = "az2pod1gz",
                    VpcId = "50e61d1e-ac98-4f92-9505-bb1bfb01c84b",
                    SubnetId = "f5cfcd56-63ac-4dab-ae66-f7eb4cdd03b6",
                    SecurityGroupId = "f64c9fe9-2dbc-47ea-81cc-bea1c29e2c62",
                    Password = "*******",
                    Mode = "Single",
                    Flavor = new List<CreateInstanceFlavorOption>
                    {
                        new CreateInstanceFlavorOption
                        {
                            Type = CreateInstanceFlavorOption.TypeEnum.SINGLE,
                            Num = 1,
                            Size = 10,
                            SpecCode = "dds.mongodb.s6.medium.4.single"
                        },
                    },
                    BackupStrategy = new CreateInstanceBackupStrategyOption()
                    {
                        StartTime = "08:15-09:15",
                        KeepDays = "8"
                    }
                }
            };
            try
            {
                CreateInstanceResponse resp = client.CreateInstance(req);
                Console.WriteLine(resp.Id);
                Console.WriteLine(resp.Name);
                // InstanceStatus means status in response body
                Console.WriteLine(resp.Status);
                Console.WriteLine("Create Instance Success!");
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

        /// <summary>
        /// 重启实例
        /// </summary>
        public static void RestartInstance(DdsClient client)
        {
            RestartInstanceRequest req = new RestartInstanceRequest
            {
                InstanceId = "95fafd4e2b864e48a5fa162b6bce4f75in02",
                Body = new RestartInstanceRequestBody()
                {
                    // TargetType = "shard",
                    TargetId = "95fafd4e2b864e48a5fa162b6bce4f75in02"
                }
            };
            try
            {
                RestartInstanceResponse resp = client.RestartInstance(req);
                Console.WriteLine(resp.JobId);
                Console.WriteLine("Restart Instance Success!");
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
        
        /// <summary>
        /// 删除实例
        /// </summary>
        public static void DeleteInstance(DdsClient client)
        {
            DeleteInstanceRequest req = new DeleteInstanceRequest
            {
                InstanceId = "95fafd4e2b864e48a5fa162b6bce4f75in02"
            };
            try
            {
                DeleteInstanceResponse resp = client.DeleteInstance(req);
                Console.WriteLine(resp.JobId);
                Console.WriteLine("Delete Instance Success!");
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

        /// <summary>
        /// 查询实例列表
        /// </summary>
        public static void ListInstance(DdsClient client)
        {
            ListInstancesRequest req = new ListInstancesRequest
            {
                Id = "04ada470884e4c2190face9a624c1608in10"
            };
            try
            {
                ListInstancesResponse resp = client.ListInstances(req);
                Console.WriteLine(resp.TotalCount);
                foreach (var instance in resp.Instances)
                {
                    Console.WriteLine(instance.Id);
                    Console.WriteLine(instance.Datastore.Version);
                    foreach (var group in instance.Groups)
                    {
                        Console.WriteLine(group.Id);
                        foreach (var node in group.Nodes)
                        {
                            Console.WriteLine(node.Id);
                        }
                    }
                }
                Console.WriteLine("List Instance Success!");
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

        /// <summary>
        /// 扩容实例存储容量
        /// </summary>
        public static void EnlargeInstanceVolume(DdsClient client)
        {
            var req = new ResizeInstanceVolumeRequest()
            {
                InstanceId = "95fafd4e2b864e48a5fa162b6bce4f75in02",
                Body = new ResizeInstanceVolumeRequestBody
                {
                    Volume = new ResizeInstanceVolumeOption()
                    {
                        Size = 20
                    }
                }
            };
            try
            {
                var resp= client.ResizeInstanceVolume(req);
                Console.WriteLine(resp.JobId);
                Console.WriteLine("Enlarge Instance Volume Success!");
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

        /// <summary>
        /// 扩容集群实例的节点数量
        /// </summary>
        public static void EnlargeShardingNode(DdsClient client)
        {
            var req = new AddShardingNodeRequest()
            {
                InstanceId = "a25de644d3b74b86b4b3010a68897e85in02",
                Body = new AddShardingNodeRequestBody()
                {
                    Type = AddShardingNodeRequestBody.TypeEnum.MONGOS,
                    SpecCode = "dds.mongodb.s6.medium.4.mongos",
                    Num = 2,
                    Volume = new AddShardingNodeVolumeOption()
                    {
                    Size = 20
                }
                }
            };
            try
            {
                var resp = client.AddShardingNode(req);
                Console.WriteLine(resp.JobId);
                Console.WriteLine("Enlarge Instance Success!");
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

        /// <summary>
        /// 变更实例规格
        /// </summary>
        public static void ResizeInstance(DdsClient client)
        {
            ResizeInstanceRequest req = new ResizeInstanceRequest
            {
                InstanceId = "95fafd4e2b864e48a5fa162b6bce4f75in02",
                Body = new ResizeInstanceRequestBody
                {
                    Resize = new ResizeInstanceOption()
                    {
                        TargetId = "95fafd4e2b864e48a5fa162b6bce4f75in02",
                        TargetSpecCode = "dds.mongodb.s6.large.2.single"
                    }
                }
            };
            try
            {
                ResizeInstanceResponse resp = client.ResizeInstance(req);
                Console.WriteLine(resp.JobId);
                Console.WriteLine("Resize Instance Success!");
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
        /*******************************************Instances End********************************************************/


        /********************************************Backups Start*******************************************************/
        /// <summary>
        /// 创建手动备份
        /// </summary>
        public static void CreateManualBackup(DdsClient client)
        {
            CreateManualBackupRequest req = new CreateManualBackupRequest
            {
                Body = new CreateManualBackupRequestBody
                {
                    Backup = new CreateManualBackupOption()
                    {
                        InstanceId = "fd1cac0eee0f4ad5a139a4dd6e994ea7in02",
                        Name = "dds-test1"
                    }
                }
            };
            try
            {
                CreateManualBackupResponse resp = client.CreateManualBackup(req);
                Console.WriteLine(resp.BackupId);
                Console.WriteLine("Do ManualBackup Success!");
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

        /// <summary>
        /// 删除手动备份
        /// </summary>
        public static void DeleteManualBackup(DdsClient client)
        {
            DeleteManualBackupRequest req = new DeleteManualBackupRequest
            {
                BackupId = "4677057d10f44ac9b722b78fdb75fc8bbr02"
            };
            try
            {
                DeleteManualBackupResponse resp = client.DeleteManualBackup(req);
                Console.WriteLine(resp.JobId);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine("Delete ManualBackup Success!");
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
        
        /// <summary>
        /// 查询备份列表
        /// </summary>
        public static void ListBackups(DdsClient client)
        {
            ListBackupsRequest req = new ListBackupsRequest
            {
                InstanceId = "fd1cac0eee0f4ad5a139a4dd6e994ea7in02",
                Limit = 1
            };
            try
            {
                ListBackupsResponse resp = client.ListBackups(req);
                Console.WriteLine(resp.TotalCount);
                foreach (var backup in resp.Backups)
                {
                    Console.WriteLine(backup.Id);
                    Console.WriteLine(backup.Datastore.Version);
                }
                
                Console.WriteLine("List Backups Success!");
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

        /// <summary>
        /// 查询自动备份策略
        /// </summary>
        public static void GetBackupPolicy(DdsClient client)
        {
            ShowBackupPolicyRequest req = new ShowBackupPolicyRequest
            {
                InstanceId = "fd1cac0eee0f4ad5a139a4dd6e994ea7in02"
            };
            try
            {
                ShowBackupPolicyResponse resp = client.ShowBackupPolicy(req);
                Console.WriteLine(resp.BackupPolicy);
                Console.WriteLine("Get Backup Policy Success!");
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
        
        /// <summary>
        /// 设置自动备份策略
        /// </summary>
        public static void SetBackupPolicy(DdsClient client)
        {
            SetBackupPolicyRequest req = new SetBackupPolicyRequest
            {
                InstanceId = "fd1cac0eee0f4ad5a139a4dd6e994ea7in02",
                Body = new SetBackupPolicyRequestBody
                {
                    BackupPolicy = new SetBackupPolicyOption()
                    {
                        KeepDays = 7,
                        StartTime = "08:15-09:15",
                        Period = "1,4,5,6,7"
                    }
                }
            };
            try
            {
                SetBackupPolicyResponse resp = client.SetBackupPolicy(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine("Set Backup Policy Success!");
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
        /*********************************************Backups End********************************************************/


        /**********************************************Tags Start********************************************************/
        /// <summary>
        /// 查询资源实例
        /// </summary>
        public static void ListInstancesByTags(DdsClient client)
        {
            ListInstancesByTagsRequest req = new ListInstancesByTagsRequest()
            {
                Body = new ListInstancesByTagsRequestBody
                {
                    Action = ListInstancesByTagsRequestBody.ActionEnum.FILTER,
                    Matches = new List<Match>
                    {
                        new Match
                        {
                            Key = Match.KeyEnum.INSTANCE_ID,
                            Value = "value1"
                        }
                    },
                    Tags = new List<ListInstancesTagOption>
                    {
                        new ListInstancesTagOption()
                        {
                            Key = "key",
                            Values = new List<string>()
                        }
                    }
                }
            };
            try
            {
                ListInstancesByTagsResponse resp = client.ListInstancesByTags(req);
                Console.WriteLine(resp.TotalCount);
                foreach (var instance in resp.Instances)
                {
                    Console.WriteLine(instance.InstanceId);
                    foreach (var tag in instance.Tags)
                    {
                        Console.WriteLine(tag.Key);
                        Console.WriteLine(tag.Value);
                    }
                }
                Console.WriteLine("Query Resource Instance Success!");
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
        
        /// <summary>
        /// 批量创建资源标签
        /// </summary>
        public static void BatchCreateInstanceTags(DdsClient client)
        {
            var req = new BatchCreateInstanceTagsRequest()
            {
                InstanceId = "fd1cac0eee0f4ad5a139a4dd6e994ea7in02",
                Body = new BatchCreateInstanceTagsRequestBody()
                {
                    Action = BatchCreateInstanceTagsRequestBody.ActionEnum.CREATE,
                    Tags = new List<BatchCreateInstanceTagsOption>
                    {
                        new BatchCreateInstanceTagsOption()
                        {
                            Key = "key1",
                            Value = "value1"
                        }
                    }
                }
            };
            try
            {
                var resp= client.BatchCreateInstanceTags(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine("Batch Resource Instance Success!");
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
        
        /// <summary>
        /// 批量删除资源标签
        /// </summary>
        public static void BatchDeleteInstanceTags(DdsClient client)
        {
            var req = new BatchDeleteInstanceTagsRequest()
            {
                InstanceId = "fd1cac0eee0f4ad5a139a4dd6e994ea7in02",
                Body = new BatchDeleteInstanceTagsRequestBody()
                {
                    Action = BatchDeleteInstanceTagsRequestBody.ActionEnum.DELETE,
                    Tags = new List<BatchDeleteInstanceTagsOption>
                    {
                        new BatchDeleteInstanceTagsOption()
                        {
                            Key = "key1",
                            Value = "value1"
                        }
                    }
                }
            };
            try
            {
                var resp= client.BatchDeleteInstanceTags(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine("Batch Resource Instance Success!");
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

        /// <summary>
        /// 查询资源标签
        /// </summary>
        public static void ListInstanceTags(DdsClient client)
        {
            ListInstanceTagsRequest req = new ListInstanceTagsRequest
            {
                InstanceId = "fd1cac0eee0f4ad5a139a4dd6e994ea7in02"
            };
            try
            {
                ListInstanceTagsResponse resp = client.ListInstanceTags(req);
                foreach (var tag in resp.Tags)
                {
                    Console.WriteLine(tag.Key);
                    Console.WriteLine(tag.Value);
                }
                Console.WriteLine("Query Resource Tags Success!");
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

        /// <summary>
        /// 查询项目标签
        /// </summary>
        public static void QueryProjectTags(DdsClient client)
        {
            ListProjectTagsRequest req = new ListProjectTagsRequest();
            try
            {
                ListProjectTagsResponse resp = client.ListProjectTags(req);
                foreach (var tag in resp.Tags)
                {
                    Console.WriteLine(tag.Key);
                    foreach (var value in tag.Values)
                    {
                        Console.WriteLine(value);
                    }
                }
                Console.WriteLine("Query Project Tags Success!");
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
        /***********************************************Tags End*********************************************************/
    }
}