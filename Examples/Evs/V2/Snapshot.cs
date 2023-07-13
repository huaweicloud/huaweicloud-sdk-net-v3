using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Evs.V2.Model;
using HuaweiCloud.SDK.Evs.V2;

namespace Examples.Evs.V2
{
    public class Snapshot
    {
        static void Main1(string[] args)
        {
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            const string endpoint = "{your endpoint}";
            const string projectId = "{your project id}";

            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, projectId);
            var evsClient = EvsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            CreateSnapshot(evsClient);
            UpdateSnapshot(evsClient);
            DeleteSnapshot(evsClient);
            ShowSnapshot(evsClient);
            ListSnapshots(evsClient);
            RollbackSnapshot(evsClient);
        }

        private static void CreateSnapshot(EvsClient client)
        {
            CreateSnapshotRequest req = new CreateSnapshotRequest()
            {
                Body = new CreateSnapshotRequestBody()
                {
                    Snapshot = new CreateSnapshotOption()
                    {
                        VolumeId = "1bebb541-5601-450f-a87a-55f9a3c8327b",
                        Description = "test",
                        Name = "test",
                        Force = false
                    }
                }
            };

            try
            {
                CreateSnapshotResponse resp = client.CreateSnapshot(req);
                Console.WriteLine(resp.Snapshot);
                Console.WriteLine(resp.HttpStatusCode);
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

        private static void UpdateSnapshot(EvsClient client)
        {
            UpdateSnapshotRequest req = new UpdateSnapshotRequest()
            {
                SnapshotId = "fc5281ca-5a1b-4193-814f-514cb5d303e7",
                Body = new UpdateSnapshotRequestBody()
                {
                    Snapshot = new UpdateSnapshotOption()
                    {
                        Name = "test_update",
                        Description = "test_update"
                    }
                }
            };

            try
            {
                UpdateSnapshotResponse resp = client.UpdateSnapshot(req);
                Console.WriteLine(resp.Snapshot);
                Console.WriteLine(resp.HttpStatusCode);
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

        private static void DeleteSnapshot(EvsClient client)
        {
            DeleteSnapshotRequest req = new DeleteSnapshotRequest()
            {
                SnapshotId = "fc5281ca-5a1b-4193-814f-514cb5d303e7"
            };

            try
            {
                DeleteSnapshotResponse resp = client.DeleteSnapshot(req);
                Console.WriteLine(resp.HttpStatusCode);
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

        private static void ShowSnapshot(EvsClient client)
        {
            ShowSnapshotRequest req = new ShowSnapshotRequest()
            {
                SnapshotId = "fc5281ca-5a1b-4193-814f-514cb5d303e7"
            };

            try
            {
                ShowSnapshotResponse resp = client.ShowSnapshot(req);
                Console.WriteLine(resp.Snapshot);
                Console.WriteLine(resp.HttpStatusCode);
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

        private static void ListSnapshots(EvsClient client)
        {
            ListSnapshotsRequest req = new ListSnapshotsRequest()
            {
                ServiceType = "EVS",
                Limit = 2,
                Offset = 0,
                Name = "test"
            };

            try
            {
                ListSnapshotsResponse resp = client.ListSnapshots(req);
                Console.WriteLine(resp.Count);
                Console.WriteLine(resp.HttpStatusCode);
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

        private static void RollbackSnapshot(EvsClient client)
        {
            RollbackSnapshotRequest req = new RollbackSnapshotRequest()
            {
                SnapshotId = "fc5281ca-5a1b-4193-814f-514cb5d303e7",
                Body = new RollbackSnapshotRequestBody()
                {
                    Rollback = new RollbackSnapshotOption()
                    {
                        VolumeId = "1bebb541-5601-450f-a87a-55f9a3c8327b"
                    }
                }
            };

            try
            {
                RollbackSnapshotResponse resp = client.RollbackSnapshot(req);
                Console.WriteLine(resp.Rollback);
                Console.WriteLine(resp.HttpStatusCode);
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