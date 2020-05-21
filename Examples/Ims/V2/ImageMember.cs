using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Ims.V2;
using HuaweiCloud.SDK.Ims.V2.Model;

namespace Examples.Ims.V2
{
    public class ImageMember
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

            BatchAddMembers(imsClient);
            BatchUpdateImageMembers(imsClient);
            //GlanceAddImageMember(imsClient);
            //GlanceUpdateImageMember(imsClient);
            //GlanceListImageMembers(imsClient);
            //GlanceShowImageMember(imsClient);
            //GlanceDeleteImageMember(imsClient);
        }

        //batch add members
        private static void BatchAddMembers(ImsClient imsV1Client)
        {
            BatchAddMembersRequest addMemberListRequest = new BatchAddMembersRequest()
            {
                Body = new BatchAddMembersRequestBody()
                {
                    Images = new List<string> {"951da790-3091-4320-886d-52edca1b5b2c"},
                    Projects = new List<string> {"05137577cf00d5eb2f04c005eee8ab03"}
                }
            };

            try
            {
                var addMemberListResponse = imsV1Client.BatchAddMembers(addMemberListRequest);
                Console.WriteLine(addMemberListResponse.JobId);
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

        //batch update member status
        private static void BatchUpdateImageMembers(ImsClient imsV1Client)
        {
            BatchUpdateMembersRequest updateImageMemberListStatusRequest = new BatchUpdateMembersRequest()
            {
                Body = new BatchUpdateMembersRequestBody()
                {
                    ProjectId = "edc89b490d7d4392898e19b2deb34797",
                    Status = BatchUpdateMembersRequestBody.StatusEnum.ACCEPTED,
                    Images = new List<string> {"d164b5df-1bc3-4c3f-893e-3e471fd16e64"}
                }
            };

            try
            {
                var updateImageMemberListStatusResponse = imsV1Client.BatchUpdateMembers(updateImageMemberListStatusRequest);
                Console.WriteLine(updateImageMemberListStatusResponse.JobId);
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


        //batch delete members
        private static void BatchDeleteImageMembers(ImsClient imsV1Client)
        {
            BatchDeleteMembersRequest deleteImageMemberListRequest = new BatchDeleteMembersRequest()
            {
                Body = new BatchAddMembersRequestBody()
                {
                    Images = new List<string> {"d164b5df-1bc3-4c3f-893e-3e471fd16e64"},
                    Projects = new List<string>{"9c61004714024f9586705d090530f9fa"}
                }
            };

            try
            {
                var deleteImageMemberListResponse = imsV1Client.BatchDeleteMembers(deleteImageMemberListRequest);
                Console.WriteLine(deleteImageMemberListResponse.JobId);
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

        //add member for image(openstack)
        //private static void GlanceAddImageMember(ImsClient glanceV2Client)
        //{
        //    GlanceAddImageMemberRequest addImageMemberRequest = new GlanceAddImageMemberRequest()
        //    {
        //        ImageId = "8786ff87-19dc-4be4-87bc-35d40ed56e99",
        //        Body = new GlanceAddImageMemberRequestBody()
        //        {
        //            Member = "0605767f5c00d5762ff8c0051ea1a2e0"
        //        }
        //    };
        //
        //    try
        //    {
        //        var addImageMemberResponse = glanceV2Client.GlanceAddImageMember(addImageMemberRequest);
        //        Console.WriteLine(addImageMemberResponse.GetHttpBody());
        //    }
        //    catch (RequestTimeoutException requestTimeoutException)
        //    {
        //        Console.WriteLine(requestTimeoutException.ErrorMessage);
        //    }
        //    catch (ServiceResponseException clientRequestException)
        //    {
        //        Console.WriteLine(clientRequestException.HttpStatusCode);
        //        Console.WriteLine(clientRequestException.ErrorCode);
        //        Console.WriteLine(clientRequestException.ErrorMsg);
        //    }
        //    catch (ConnectionException connectionException)
        //    {
        //        Console.WriteLine(connectionException.ErrorMessage);
        //    }
        //}

        ////update member status(openstack)
        //private static void GlanceUpdateImageMember(ImsClient glanceV2Client)
        //{
        //    GlanceUpdateImageMemberRequest updateImageMemberStatusRequest = new GlanceUpdateImageMemberRequest()
        //    {
        //        ImageId = "8786ff87-19dc-4be4-87bc-35d40ed56e99",
        //        MemberId = "0605767de280d5762fe5c0126e4db47c",
        //        Body = new GlanceUpdateImageMemberRequestBody()
        //        {
        //            Status = "accepted"
        //        }
        //    };
        //
        //    try
        //    {
        //        var updateImageMemberStatusResponse = glanceV2Client.GlanceUpdateImageMember(updateImageMemberStatusRequest);
        //        Console.WriteLine(updateImageMemberStatusResponse.GetHttpBody());
        //    }
        //    catch (RequestTimeoutException requestTimeoutException)
        //    {
        //        Console.WriteLine(requestTimeoutException.ErrorMessage);
        //    }
        //    catch (ServiceResponseException clientRequestException)
        //    {
        //        Console.WriteLine(clientRequestException.HttpStatusCode);
        //        Console.WriteLine(clientRequestException.ErrorCode);
        //        Console.WriteLine(clientRequestException.ErrorMsg);
        //    }
        //    catch (ConnectionException connectionException)
        //    {
        //        Console.WriteLine(connectionException.ErrorMessage);
        //    }
        //}

        ////get image's members(openstack)
        //private static void GlanceListImageMembers(ImsClient glanceV2Client)
        //{
        //    GlanceListImageMembersRequest membersListRequest = new GlanceListImageMembersRequest()
        //    {
        //        ImageId = "8786ff87-19dc-4be4-87bc-35d40ed56e99"
        //    };
        //    try
        //    {
        //        var membersListResponse = glanceV2Client.GlanceListImageMembers(membersListRequest);
        //        Console.WriteLine(membersListResponse.GetHttpBody());
        //    }
        //    catch (RequestTimeoutException requestTimeoutException)
        //    {
        //        Console.WriteLine(requestTimeoutException.ErrorMessage);
        //    }
        //    catch (ServiceResponseException clientRequestException)
        //    {
        //        Console.WriteLine(clientRequestException.HttpStatusCode);
        //        Console.WriteLine(clientRequestException.ErrorCode);
        //        Console.WriteLine(clientRequestException.ErrorMsg);
        //    }
        //    catch (ConnectionException connectionException)
        //    {
        //        Console.WriteLine(connectionException.ErrorMessage);
        //    }
        //}

        ////get member info(openstack)
        //private static void GlanceShowImageMember(ImsClient glanceV2Client)
        //{
        //    GlanceShowImageMemberRequest memberInfoRequest = new GlanceShowImageMemberRequest()
        //    {
        //        ImageId = "8786ff87-19dc-4be4-87bc-35d40ed56e99"
        //    };
        //
        //    try
        //    {
        //        var memberInfoResponse = glanceV2Client.GlanceShowImageMember(memberInfoRequest);
        //        Console.WriteLine(memberInfoResponse.GetHttpBody());
        //    }
        //    catch (RequestTimeoutException requestTimeoutException)
        //    {
        //        Console.WriteLine(requestTimeoutException.ErrorMessage);
        //    }
        //    catch (ServiceResponseException clientRequestException)
        //    {
        //        Console.WriteLine(clientRequestException.HttpStatusCode);
        //        Console.WriteLine(clientRequestException.ErrorCode);
        //        Console.WriteLine(clientRequestException.ErrorMsg);
        //    }
        //    catch (ConnectionException connectionException)
        //    {
        //        Console.WriteLine(connectionException.ErrorMessage);
        //    }
        //}

        ////delete member(openstack)
        //private static void GlanceDeleteImageMember(ImsClient glanceV2Client)
        //{
        //    GlanceDeleteImageMemberRequest deleteImageMemberRequest = new GlanceDeleteImageMemberRequest()
        //    {
        //        ImageId = "8786ff87-19dc-4be4-87bc-35d40ed56e99",
        //        MemberId = "0605767de280d5762fe5c0126e4db47c"
        //    };
        //
        //    try
        //    {
        //        var deleteImageMemberResponse = glanceV2Client.GlanceDeleteImageMember(deleteImageMemberRequest);
        //        Console.WriteLine(deleteImageMemberResponse.HttpStatusCode);
        //    }
        //    catch (RequestTimeoutException requestTimeoutException)
        //    {
        //        Console.WriteLine(requestTimeoutException.ErrorMessage);
        //    }
        //    catch (ServiceResponseException clientRequestException)
        //    {
        //        Console.WriteLine(clientRequestException.HttpStatusCode);
        //        Console.WriteLine(clientRequestException.ErrorCode);
        //        Console.WriteLine(clientRequestException.ErrorMsg);
        //    }
        //    catch (ConnectionException connectionException)
        //    {
        //        Console.WriteLine(connectionException.ErrorMessage);
        //    }
        //}
    }
}