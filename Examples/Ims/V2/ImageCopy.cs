using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Ims.V2;
using HuaweiCloud.SDK.Ims.V2.Model;

namespace Examples.Ims.V2
{
    public class ImageCopy
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

            CopyImageInRegion(imsClient);
            CopyImageCrossRegion(imsClient);
        }

        //copy image in region
        private static void CopyImageInRegion(ImsClient imsV1Client)
        {
            CopyImageInRegionRequest imageRegionCopyRequest = new CopyImageInRegionRequest()
            {
                ImageId = "0f5075af-13b1-44f7-9d9b-4f9490a87719",
                Body = new CopyImageInRegionRequestBody()
                {
                    Name = "copy-test",
                    Description = "copy in region"
                }
            };
            try
            {
                var copyResponse = imsV1Client.CopyImageInRegion(imageRegionCopyRequest);
                Console.WriteLine(copyResponse.JobId);
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

        //cross copy image
        private static void CopyImageCrossRegion(ImsClient imsV1Client)
        {
            CopyImageCrossRegionRequest crossRegionCopyRequest = new CopyImageCrossRegionRequest()
            {
                ImageId = "0f5075af-13b1-44f7-9d9b-4f9490a87719",
                Body = new CopyImageCrossRegionRequestBody()
                {
                    Name = "copy-image",
                    Region = "cn-north-1",
                    ProjectName = "cn-north-1",
                    AgencyName = "ims-admin"
                }
            };
            try
            {
                var crossRegionCopyResponse = imsV1Client.CopyImageCrossRegion(crossRegionCopyRequest);
                Console.WriteLine(crossRegionCopyResponse.JobId);
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