using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Evs.V2.Model;
using HuaweiCloud.SDK.Evs.V2;

namespace Examples.Evs.V2
{
    public class Volume
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

            ShowVolume(evsClient);
            CreateVolume(evsClient);
            ResizeVolume(evsClient);
            ListVolumesDetails(evsClient);
            UpdateVolume(evsClient);
            DeleteVolume(evsClient);
            CinderListVolumeTypes(evsClient);
            CinderExportToImage(evsClient);
            CinderListQuotas(evsClient);
            CinderListAvailabilityZones(evsClient);
        }

        private static void ShowVolume(EvsClient client)
        {
            ShowVolumeRequest req = new ShowVolumeRequest()
            {
                VolumeId = "8da11134-0614-40e2-8792-3437c66cc90d"
            };

            try
            {
                ShowVolumeResponse resp = client.ShowVolume(req);
                Console.WriteLine(resp.Volume);
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

        private static void ListVolumesDetails(EvsClient client)
        {
            ListVolumesDetailsRequest req = new ListVolumesDetailsRequest()
            {
                AvailabilityZone = "br-iaas-odin1a",
                ServiceType = "EVS",
                Limit = 2,
                Offset = 0,
                Name = "test"
            };

            try
            {
                var resp = client.ListVolumesDetails(req);
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

        private static void UpdateVolume(EvsClient client)
        {
            UpdateVolumeRequest req = new UpdateVolumeRequest()
            {
                VolumeId = "3c759440-0552-4a5f-9c40-782ace254314",
                Body = new UpdateVolumeRequestBody
                {
                    Volume = new UpdateVolumeOption()
                    {
                        Name = "update",
                        Description = "update"
                    }
                }
            };

            try
            {
                UpdateVolumeResponse resp = client.UpdateVolume(req);
                Console.WriteLine(resp.Id);
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

        private static void DeleteVolume(EvsClient client)
        {
            DeleteVolumeRequest req = new DeleteVolumeRequest()
            {
                VolumeId = "0f17c246-914b-496b-953c-aeaab1fc205c"
            };

            try
            {
                DeleteVolumeResponse resp = client.DeleteVolume(req);
                Console.WriteLine(resp.JobId);
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

        private static void CinderListVolumeTypes(EvsClient client)
        {
            CinderListVolumeTypesRequest req = new CinderListVolumeTypesRequest()
            {
            };

            try
            {
                CinderListVolumeTypesResponse resp = client.CinderListVolumeTypes(req);
                Console.WriteLine(resp.VolumeTypes);
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

        private static void CinderExportToImage(EvsClient client)
        {
            CinderExportToImageRequest req = new CinderExportToImageRequest()
            {
                VolumeId = "1bebb541-5601-450f-a87a-55f9a3c8327b",
                Body = new CinderExportToImageRequestBody
                {
                    OsVolumeUploadImage = new CinderExportToImageOption
                    {
                        DiskFormat = CinderExportToImageOption.DiskFormatEnum.VHD,
                        Force = false,
                        ImageName = "test",
                        OsType = CinderExportToImageOption.OsTypeEnum.LINUX,
                        ContainerFormat = CinderExportToImageOption.ContainerFormatEnum.BARE
                    }
                }
            };

            try
            {
                CinderExportToImageResponse resp = client.CinderExportToImage(req);
                Console.WriteLine(resp.OsVolumeUploadImage);
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

        private static void CinderListQuotas(EvsClient client)
        {
            CinderListQuotasRequest req = new CinderListQuotasRequest()
            {
                TargetProjectId = "0605767c2e80d5762fd0c0146a10aaf2",
                Usage = CinderListQuotasRequest.UsageEnum.TRUE
            };

            try
            {
                CinderListQuotasResponse resp = client.CinderListQuotas(req);
                Console.WriteLine(resp.QuotaSet);
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

        private static void CinderListAvailabilityZones(EvsClient client)
        {
            CinderListAvailabilityZonesRequest req = new CinderListAvailabilityZonesRequest()
            {
            };

            try
            {
                CinderListAvailabilityZonesResponse resp = client.CinderListAvailabilityZones(req);
                Console.WriteLine(resp.AvailabilityZoneInfo);
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

        private static void CreateVolume(EvsClient client)
        {
            CreateVolumeRequest req = new CreateVolumeRequest()
            {
                Body = new CreateVolumeRequestBody
                {
                    Volume = new CreateVolumeOption()
                    {
                        AvailabilityZone = "br-iaas-odin1a",
                        Count = 1,
                        Size = 40,
                        VolumeType = CreateVolumeOption.VolumeTypeEnum.SATA,
                        Description = "csharp",
                        Name = "test"
                    }
                }
            };

            try
            {
                CreateVolumeResponse resp = client.CreateVolume(req);
                Console.WriteLine(resp.JobId);
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

        private static void ResizeVolume(EvsClient client)
        {
            var req = new ResizeVolumeRequest()
            {
                VolumeId = "3c759440-0552-4a5f-9c40-782ace254314",
                Body = new ResizeVolumeRequestBody()
                {
                    OsExtend = new OsExtend()
                    {
                        NewSize = 50
                    }
                }
            };

            try
            {
                var resp = client.ResizeVolume(req);
                Console.WriteLine(resp.JobId);
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