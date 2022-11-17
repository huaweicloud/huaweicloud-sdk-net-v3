using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Ims.V2;
using HuaweiCloud.SDK.Ims.V2.Model;

namespace Examples.Ims.V2
{
    public class Schemas
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

            //GlanceShowImageSchemas(imsClient);
            GlanceListImageSchemas(imsClient);
            //GlanceShowImageMemberSchemas(imsClient);
            //GlanceListImageMemberSchemas(imsClient);

        }

        //private static void GlanceShowImageSchemas(ImsClient glanceV2Client)
        //{
        //    GlanceShowImageSchemasRequest getImageSchemasRequest = new GlanceShowImageSchemasRequest();
        //    
        //    try
        //    {
        //        GlanceShowImageSchemasResponse getImageSchemasResponse = glanceV2Client.GlanceShowImageSchemas(getImageSchemasRequest);
        //        Console.WriteLine(getImageSchemasResponse.GetHttpBody());
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

        private static void GlanceListImageSchemas(ImsClient glanceV2Client)
        {
            var imageListSchemasRequest = new ListImagesRequest();
            try
            {
                var imageListSchemasResponse = glanceV2Client.ListImages(imageListSchemasRequest);
                Console.WriteLine(imageListSchemasResponse.GetHttpBody());
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

        //private static void GlanceShowImageMemberSchemas(ImsClient glanceV2Client)
        //{
        //    GlanceShowImageMemberSchemasRequest memberSchemasRequest = new GlanceShowImageMemberSchemasRequest();
        //    
        //    try
        //    {
        //        GlanceShowImageMemberSchemasResponse memberSchemasResponse = glanceV2Client.GlanceShowImageMemberSchemas(memberSchemasRequest);
        //        Console.WriteLine(memberSchemasResponse.GetHttpBody());
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

        //private static void GlanceListImageMemberSchemas(ImsClient glanceV2Client)
        //{
        //    GlanceListImageMemberSchemasRequest memberListSchemasRequest = new GlanceListImageMemberSchemasRequest();
        //    try
        //    {
        //        GlanceListImageMemberSchemasResponse memberListSchemasResponse = glanceV2Client.GlanceListImageMemberSchemas(memberListSchemasRequest);
        //        Console.WriteLine(memberListSchemasResponse.GetHttpBody());
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