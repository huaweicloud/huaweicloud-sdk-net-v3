using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Dcs.V2;
using HuaweiCloud.SDK.Dcs.V2.Model;

namespace Examples.Dcs.V2
{
    public class LifeCyleMgt
    {
        private static void MainDcs(string[] args)
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            const string endpoint = "{your endpoint}";
            const string projectId = "{your project id}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var dcsClient = DcsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            // lifecycle hook test
            // CreateDcsInstance(dcsClient);
            // listFlavors(dcsClient);
            // stopMigrationTask(dcsClient);
            // createMigrationTask(dcsClient);
            // stopMigrationTask(dcsClient);
            // deleteMigrationTask(dcsClient);
            // createReplication(dcsClient);
            // deleteReplication(dcsClient);
            listMigrationTask(dcsClient);
        }

        private static void listMigrationTask(DcsClient dcsClient)
        {
            var listMigrationTaskRequest = new ListMigrationTaskRequest()
            {
                Offset = 10,
                Limit = 10
            };
            try
            {
                // Console.WriteLine(createMigrationTaskRequest.ToString());
                var response = dcsClient.ListMigrationTask(listMigrationTaskRequest);
                Console.WriteLine(response.GetHttpBody());
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
        private static void deleteReplication(DcsClient dcsClient)
        {
            try
            {
                var deleteReplicationReq = new DeleteReplicationRequest()
                {
                    NodeId = "ff80808172977c00017297d6bd2a01bc",
                    GroupId = "97579592-6399-4d61-974b-d8b59efc0ca2",
                    InstanceId = "975a54a5-ff73-499c-96bb-b217d69210f0"
                };
                // Console.WriteLine(createMigrationTaskRequest.ToString());
                var response = dcsClient.DeleteReplication(deleteReplicationReq);
                Console.WriteLine(response.GetHttpBody());
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

        private static void createReplication(DcsClient dcsClient)
        {
            try
            {
                var createReplicationBody = new AddReplicationBody()
                {
                    AzCode = "cn-north-7b"
                };
                var createReplicationReq = new CreateReplicationRequest()
                {
                    Body = createReplicationBody,
                    GroupId = "97579592-6399-4d61-974b-d8b59efc0ca2",
                    InstanceId = "975a54a5-ff73-499c-96bb-b217d69210f0"
                };
                // Console.WriteLine(createMigrationTaskRequest.ToString());
                var response = dcsClient.CreateReplication(createReplicationReq);

                Console.WriteLine(response.GetHttpBody());
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

        private static void deleteMigrationTask(DcsClient dcsClient)
        {
            List<String> taskIdList = new List<string>();
            taskIdList.Add("ff808081729848e501729e2cb7d803cc");
            taskIdList.Add("ff808081729848e501729e2ae3f803be");
            var deleteMigrateTaskReq = new DeleteMigrateTaskRequest()
            {
                TaskIdList = taskIdList
            };
            var deleteMigrationTaskReq = new DeleteMigrationTaskRequest()
            {
                Body = deleteMigrateTaskReq
            };
            try
            {
                // Console.WriteLine(createMigrationTaskRequest.ToString());
                var response = dcsClient.DeleteMigrationTask(deleteMigrationTaskReq);

                Console.WriteLine(response.GetHttpBody());
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

        private static void createMigrationTask(DcsClient dcsClient)
        {
            var targetInstance = new TargetInstanceBody()
            {
                Id = "2a233d1c-8e84-4c28-b0ba-894603408a9d"
            };
            var files = new Files()
            {
                FileName = "appendonly02.zip"
            };
            List<Files> fileList = new List<Files>();
            fileList.Add(files);
            var backupFiles = new BackupFilesBody()
            {
                BucketName = "obs-dcs-migration",
                Files = fileList
            };
            var createMigrationBody = new CreateMigrationTaskBody()
            {
                TaskName = "dcs-migration-test",
                MigrationMethod = CreateMigrationTaskBody.MigrationMethodEnum.FULL_AMOUNT_MIGRATION,
                MigrationType = CreateMigrationTaskBody.MigrationTypeEnum.BACKUPFILE_IMPORT,
                TargetInstance = targetInstance,
                BackupFiles = backupFiles
            };
            var createMigrationTaskRequest = new CreateMigrationTaskRequest()
            {
                Body = createMigrationBody
            };
            try
            {
                // Console.WriteLine(createMigrationTaskRequest.ToString());
                var response = dcsClient.CreateMigrationTask(createMigrationTaskRequest);

                Console.WriteLine(response.GetHttpBody());
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

        private static void CreateDcsInstance(DcsClient dcsClient)
        {
            List<String> azCodes = new List<string>();
            azCodes.Add("cn-north-7b");
            List<int?> backupAt = new List<int?>();
            backupAt.Add(1);
            backupAt.Add(2);
            backupAt.Add(3);
            backupAt.Add(4);
            backupAt.Add(5);
            backupAt.Add(6);
            backupAt.Add(7);
            var backupPlan = new BackupPlan()
            {
                BackupAt = backupAt,
                BeginAt = "16:00-17:00",
                PeriodType = "weekly"
            };
            var backupPolicy = new BackupPolicy()
            {
                BackupType = "auto",
                PeriodicalBackupPlan = backupPlan,
                SaveDays = 7
            };
            var createDcsInstanceRequest = new CreateDCSInstanceRequest()
            {
                Body = new CreateInstanceBody()
                {
                    Capacity  = 2,
                    Name = "dcs_create_instance_test",
                    Engine = "Redis",
                    EngineVersion = "4.0",
                    NoPasswordAccess = true,
                    VpcId = "5e37b3be-950a-48e1-b498-65b63d336481",
                    SubnetId = "a4112635-3ec0-471c-95c3-5cf49b9533af",
                    SpecCode = "redis.ha.au1.large.2",
                    AzCodes = azCodes,
                    InstanceBackupPolicy = backupPolicy
                }
            };
            try
            {
                var response = dcsClient.CreateDCSInstance(createDcsInstanceRequest);
                Console.WriteLine(response.GetHttpBody());
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

        private static void listFlavors(DcsClient dcsClient)
        {
            var listFlavorsRequest = new ListFlavorsRequest()
            {
                CacheMode = "single",
                Capacity = "2",
                CpuType = ListFlavorsRequest.CpuTypeEnum.AARCH64,
                Engine = "Redis",
                EngineVersion = "4.0"
            };
            try
            {
                var response = dcsClient.ListFlavors(listFlavorsRequest);
                Console.WriteLine(response.GetHttpBody());
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

        private static void stopMigrationTask(DcsClient dcsClient)
        {
            var stopMigrationTaskRequest = new StopMigrationTaskRequest()
            {
                TaskId = "ff808081729848e501729e2cb7d803cc"
            };
            try
            {
                var response = dcsClient.StopMigrationTask(stopMigrationTaskRequest);
                Console.WriteLine(response.GetHttpBody());
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