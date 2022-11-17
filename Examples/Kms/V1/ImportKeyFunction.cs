using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Kms.V1;
using HuaweiCloud.SDK.Kms.V1.Model;

namespace Examples.Kms.V1
{
    public class ImportKeyFunction
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

            var kmsClient = KmsClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            var keyId = GetKeyByStatus.GetKeyByKeyStatus(kmsClient, "5");

            GetParametersForImport(kmsClient, keyId);
            ImportKeyMaterial(kmsClient, keyId);
            DeleteKeyMaterial(kmsClient, keyId);

        }

        private static CreateParametersForImportResponse GetParametersForImport(KmsClient kmsClient, string keyId)
        {
            try
            {
                var req = new CreateParametersForImportRequest
                {
                    VersionId = "v1.0",
                    Body = new GetParametersForImportRequestBody
                    {
                        KeyId = keyId,
                        WrappingAlgorithm = GetParametersForImportRequestBody.WrappingAlgorithmEnum.RSAES_OAEP_SHA_1
                    }
                };
                var resp = kmsClient.CreateParametersForImport(req);
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
        
        private static void ImportKeyMaterial(KmsClient kmsClient, string keyId)
        {
            var importToken = "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";
            var encryptedKeyMaterial = "C6aqYsmfRjLGGkCxE9Wzm9rqc2yuOJZI4um5jSYHLebEzNyvXfX0Uk8Jkw5806S2IaW+n2gv6+K6hVqKDAzol5P8ycZRv/zvpvzgRjgbNMoFZz7xodsOXAHR+o5qZoeszoSYbLwWUt64/DSg68KxrgSYRO2H/03ROx+yCYKypJmsBlHWAg6AnnQQoxn6Ez5kDqTJKBNfMah8JibwcGU9+BuTr2WfWslqEa5LoMjc9HKPpTR1qh97e92VeGZ7JJ6ofODskNzJwj1jg1GTaBUqp6rBQmXaITmphcQt0/4aoxEqlgrgYLHX/Sxo3xwpRqZMFR7c4hFqM4lzSi1C21uxyQ==";
            try
            {
                var req = new ImportKeyMaterialRequest
                {
                    VersionId = "v1.0",
                    Body = new ImportKeyMaterialRequestBody
                    {
                        KeyId = keyId,
                        ImportToken = importToken,
                        EncryptedKeyMaterial = encryptedKeyMaterial
                    }
                };
                var resp = kmsClient.ImportKeyMaterial(req);
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
        
        private static void DeleteKeyMaterial(KmsClient kmsClient, string keyId)
        {
            try
            {
                var req = new DeleteImportedKeyMaterialRequest
                {
                    VersionId = "v1.0",
                    Body = new OperateKeyRequestBody
                    {
                        KeyId = keyId
                    }
                };
                var resp = kmsClient.DeleteImportedKeyMaterial(req);
                Console.WriteLine(resp.GetHttpStatusCode());
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