﻿using System;
 using System.Collections.Generic;
 using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
 using HuaweiCloud.SDK.Ims.V2;
 using HuaweiCloud.SDK.Ims.V2.Model;

 namespace Examples.Ims.V2
{
    public class Image
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
            var imsClient = ImsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            CreateImageByInstance(imsClient);
            CreateImageByFile(imsClient);
            ExportImage(imsClient);
            CreateDataImage(imsClient);
            CreateWholeImage(imsClient);
            ImportImageQuick(imsClient);
            ListImages(imsClient);
            UpdateImage(imsClient);

            GlanceShowImage(imsClient);
            GlanceUpdateImage(imsClient);
            GlanceDeleteImage(imsClient);
            GlanceCreateImageMetadata(imsClient);
        }

        //create image by instance
        private static void CreateImageByInstance(ImsClient imsV2Client)
        {
            CreateImageRequest createImsInfoRequest = new CreateImageRequest()
            {
                Body = new CreateImageRequestBody()
                {
                    Name = "instanceCreateImage",
                    InstanceId = "1681268e-d52c-4116-b114-1fb090904368"
                }
            };
            try
            {
                var createIms = imsV2Client.CreateImage(createImsInfoRequest);
                Console.WriteLine(createIms.JobId);
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

        //file create image
        private static void CreateImageByFile(ImsClient imsV2Client)
        {
            CreateImageRequest createImsInfoRequest = new CreateImageRequest()
            {
                Body = new CreateImageRequestBody()
                {
                    Name = "FileCreateImage",
                    ImageUrl = "obs-494b:test.qcow2",
                    Type = CreateImageRequestBody.TypeEnum.ECS,
                    OsVersion = "CentOS 7.6 64bit",
                    MinDisk = 40
                }
            };
            try
            {
                var createIms = imsV2Client.CreateImage(createImsInfoRequest);
                Console.WriteLine(createIms.JobId);
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

        // export image
        private static void ExportImage(ImsClient imsV1Client)
        {
            ExportImageRequest exportImsRequest = new ExportImageRequest
            {
                ImageId = "d70af0f0-515d-41d7-9c9f-bc4e2b233ee6",
                Body = new ExportImageRequestBody()
                {
                    BucketUrl = "obs-494b:test.qcow2",
                    FileFormat = ExportImageRequestBody.FileFormatEnum.QCOW2
                }
            };
            try
            {
                var exportImsResponse = imsV1Client.ExportImage(exportImsRequest);
                Console.WriteLine(exportImsResponse.JobId);
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

        // create data image by file
        private static void CreateDataImage(ImsClient imsV1Client)
        {
            CreateDataImageRequest createDataImageReq = new CreateDataImageRequest
            {
                Body = new CreateDataImageRequestBody()
                {
                    Name = "dataImageTest",
                    ImageUrl = "obs-494b:test.qcow2",
                    MinDisk = 40,
                    OsType = CreateDataImageRequestBody.OsTypeEnum.LINUX
                }
            };
            try
            {
                var exportImsResponse = imsV1Client.CreateDataImage(createDataImageReq);
                Console.WriteLine(exportImsResponse.JobId);
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

        // create whole image
        private static void CreateWholeImage(ImsClient imsV1Client)
        {
            CreateWholeImageRequest createWholeImsRequest = new CreateWholeImageRequest
            {
                Body = new CreateWholeImageRequestBody()
                {
                    Name = "wholeImageByInstance",
                    InstanceId = "instance_id",
                    VaultId = "vault_id"
                }
            };
            try
            {
                var exportImsResponse = imsV1Client.CreateWholeImage(createWholeImsRequest);
                Console.WriteLine(exportImsResponse.JobId);
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

        //quick import image by file
        private static void ImportImageQuick(ImsClient imsV2Client)
        {
            var quickImportImsRequest = new ImportImageQuickRequest()
            {
                Body = new QuickImportImageByFileRequestBody()
                {
                    Name = "quickImport",
                    ImageUrl = "obs-494b:test.zvhd2",
                    OsVersion = "CentOS 7.4 64bit",
                    Type = QuickImportImageByFileRequestBody.TypeEnum.ECS,
                    MinDisk = 40
                }
            };
            try
            {
                var getImsListInfoResponse = imsV2Client.ImportImageQuick(quickImportImsRequest);
                Console.WriteLine(getImsListInfoResponse.JobId);
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

        //query images list
        private static void ListImages(ImsClient imsV2Client)
        {
            ListImagesRequest getImsListInfoRequest = new ListImagesRequest()
            {
                Name = "dataImageTest"
            };

            try
            {
                ListImagesResponse getImsListInfoResponse = imsV2Client.ListImages(getImsListInfoRequest);
                Console.WriteLine(getImsListInfoResponse.Images);
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

        //update image
        private static void UpdateImage(ImsClient imsV2Client)
        {
            UpdateImageRequest updateImsInfoRequest = new UpdateImageRequest()
            {
                ImageId = "d70af0f0-515d-41d7-9c9f-bc4e2b233ee6",
                Body = new List<UpdateImageRequestBody>()
                {
                    new UpdateImageRequestBody()
                    {
                        Op = UpdateImageRequestBody.OpEnum.REPLACE,
                        Path = "/name",
                        Value = "ims-test"
                    }
                }
            };
            try
            {
                var getImsListInfoResponse = imsV2Client.UpdateImage(updateImsInfoRequest);
                Console.WriteLine(getImsListInfoResponse.Id);
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

        //query images(openstack)
        private static void QueryImagesByGlance(ImsClient glanceV2Client)
        {
            var getImageListRequest = new ListImagesRequest()
            {
                Name = "Test"
            };

            try
            {
                var getImageList = glanceV2Client.ListImages(getImageListRequest);
                Console.WriteLine(getImageList.Images);
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

        //query image detail by id(openstack)
        private static void GlanceShowImage(ImsClient glanceV2Client)
        {
            var queryImageInfoRequest = new GlanceShowImageRequest()
            {
                ImageId = "951da790-3091-4320-886d-52edca1b5b2c"
            };

            try
            {
                var queryImageInfo = glanceV2Client.GlanceShowImage(queryImageInfoRequest);
                Console.WriteLine(queryImageInfo.GetHttpBody());
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

        //update image by id(openstack)
        private static void GlanceUpdateImage(ImsClient glanceV2Client)
        {
            var updateImageInfoRequest = new GlanceUpdateImageRequest()
            {
                ImageId = "951da790-3091-4320-886d-52edca1b5b2c",
                Body = new List<GlanceUpdateImageRequestBody>()
                {
                    new GlanceUpdateImageRequestBody()
                    {
                        Op = GlanceUpdateImageRequestBody.OpEnum.REPLACE,
                        Path = "/name",
                        Value = "test"
                    }
                }
            };

            try
            {
                var updateImageInfoResponse = glanceV2Client.GlanceUpdateImage(updateImageInfoRequest);
                Console.WriteLine(updateImageInfoResponse.GetHttpBody());
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

        //delete image by id(openstack)
        private static void GlanceDeleteImage(ImsClient glanceV2Client)
        {
            var deleteImageRequest = new GlanceDeleteImageRequest()
            {
                ImageId = "951da790-3091-4320-886d-52edca1b5b2c"
            };

            try
            {
                var updateImageInfoResponse = glanceV2Client.GlanceDeleteImage(deleteImageRequest);
                Console.WriteLine(updateImageInfoResponse.HttpStatusCode);
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

        //create image metadata(openstack)
        private static void GlanceCreateImageMetadata(ImsClient glanceV2Client)
        {
            var createImageMetadataRequest = new GlanceCreateImageMetadataRequest()
            {
                Body = new GlanceCreateImageMetadataRequestBody()
                {
                    Name = "test",
                    MinDisk = 40,
                    MinRam = 1024,
                    OsVersion = "Ubuntu 14.04 server 64bit",
                }
            };

            try
            {
                var createImageMetadataResponse = glanceV2Client.GlanceCreateImageMetadata(createImageMetadataRequest);
                Console.WriteLine(createImageMetadataResponse.GetHttpBody());
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