using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Kps.V3;
using HuaweiCloud.SDK.Kps.V3.Model;

namespace Examples.Kps
{
    public class KpsManagenent
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

            var kpsClient = KpsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            ListKeypairs(kpsClient);
            CreateKeypair(kpsClient);
            ListKeypairDetail(kpsClient);
            DeleteKeypair(kpsClient);
        }

        private static ListKeypairsResponse ListKeypairs(KpsClient client)
        {
            var request = new ListKeypairsRequest();

            try
            {
                var resp = client.ListKeypairs(request);
                Console.WriteLine(resp.ToString());
                return resp;
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
            return null;
        }

        private static CreateKeypairResponse CreateKeypair(KpsClient client)
        {
            var request = new CreateKeypairRequest
            {
                Body = new CreateKeypairRequestBody()
                {
                    Keypair = new CreateKeypairAction
                    {
                        Name = "KpsTest"
                    }
                }
            };

            try
            {
                var resp = client.CreateKeypair(request);
                Console.WriteLine(resp.ToString());
                return resp;
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
            return null;
        }

        private static ListKeypairDetailResponse ListKeypairDetail(KpsClient client)
        {
            var request = new ListKeypairDetailRequest
            {
                KeypairName = "KpsTest"
            };

            try
            {
                var resp = client.ListKeypairDetail(request);
                Console.WriteLine(resp.ToString());
                return resp;
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
            return null;
        }
        
        private static DeleteKeypairResponse DeleteKeypair(KpsClient client)
        {
            var request = new DeleteKeypairRequest
            {
                KeypairName = "KpsTest"
            };

            try
            {
                var resp = client.DeleteKeypair(request);
                Console.WriteLine(resp.ToString());
                return resp;
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
            return null;
        }
    }
}