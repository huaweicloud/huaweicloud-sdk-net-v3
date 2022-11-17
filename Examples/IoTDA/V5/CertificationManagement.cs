using System;
using System.Collections;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;
using Newtonsoft.Json;

namespace Examples.IoTDA.V5
{
    static class CertificationManagement
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
            var iotdaClient = IoTDAClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            getCertificates(iotdaClient);
            deleteCertificate(iotdaClient);
            addCertificate(iotdaClient);
            verifyCertificate(iotdaClient);
        }

        private static void getCertificates(IoTDAClient client)
        {
            ListCertificatesRequest req = new ListCertificatesRequest
            {
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0",
            };
            try
            {
                var resp = client.ListCertificates(req);
                foreach (var Certificate in resp.Certificates)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(Certificate));
                }
                Console.WriteLine(resp.Page);
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
        
        
        private static void deleteCertificate(IoTDAClient client)
        {
            DeleteCertificateRequest req = new DeleteCertificateRequest
            {
                CertificateId = "9dc7eed5-00e7-4ef1-a1cc-9fb43ad1d767",
                InstanceId = "1a7ffc5c-d89c-44dd-8265-b1653d951ce0"
            };
            try
            {
                var resp = client.DeleteCertificate(req);
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
        
        
        private static void addCertificate(IoTDAClient client)
        {
            AddCertificateRequest req = new AddCertificateRequest
            {
                Body = new CreateCertificateDTO()
                {
                    Content="-----BEGIN CERTIFICATE-----MIID2TCCAsGgAwIBAgIJAOEDEgVdVMn9MA0GCSqGSIb3DQEBCwUAMIGCMQswCQYDVQQGEwJDTjERMA8GA1UECAwIR3VhbmRvbmcxETAPBgNVBAcMCFNoZW56aGVuMQ8wDQYDVQQKDAZIdWF3ZWkxDDAKBgNVBAsMA2lvdDESMBAGA1UEAwwJMTIzNDU2Nzg5MRowGAYJKoZIhvcNAQkBFgtkamthQHFxLmNvbTAeFw0xOTEyMTkxMzE1MjZaFw0yMjEwMDgxMzE1MjZaMIGCMQswCQYDVQQGEwJDTjERMA8GA1UECAwIR3VhbmRvbmcxETAPBgNVBAcMCFNoZW56aGVuMQ8wDQYDVQQKDAZIdWF3ZWkxDDAKBgNVBAsMA2lvdDESMBAGA1UEAwwJMTIzNDU2Nzg5MRowGAYJKoZIhvcNAQkBFgtkamthQHFxLmNvbTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBAM72QUzoadvLfxGjt3UFoZ4MJbblqnRbouO4KpOVHBXyS2yQVl4CWWMhLh4pp2efNUSqKuXHjY3r68PquyNnYk8zO59zVc7JHvjGkBvo7DgPRAhEKPLJIpRzkmlCBbxwTNCjc3FovGb/sHHNlpGncCKUzMfPGNZuBiuemskuEXL/eMHxDPbXYWn4Wq0wt+28PKUL5jybY7nsXSNnmAPFTO0CAmq0meUukubT/jHDCQ78ihQ/iqw1RNq88aCqRleoHiGg5nWkjL+05GXqUrqVVnZNL+YqcXzuVMs5XgyhNM2AsuH2g3D8ZuF6Dj9qY1n/v/Cp/DGpxP3A74SlplnFD/0CAwEAAaNQME4wHQYDVR0OBBYEFAVPWVtpTdO6KQnmVrrNlMguWNR7MB8GA1UdIwQYMBaAFAVPWVtpTdO6KQnmVrrNlMguWNR7MAwGA1UdEwQFMAMBAf8wDQYJKoZIhvcNAQELBQADggEBAE40ViqK+UaEn++Xq6f4Cmeg3JqYHu47v9RIAASNihYRBQ/r3RE7Af3GqjIO5nMJJuCMzdcoAU8N9KwkgXD+GLR9fYLEoEmq5CrhgaGDsCi85vCsmWhj5z8r5TG207xpmvH2KT447dnG+chMBE594ma85dCv+0mCDrqNToElipgT8+rYAYVClnIt3kbsTg1vSRNHadd+TpgRVxJZBF0fHcCAyc/2f3UJgPYNWShIetHM6BdI3fZ4H+eeHPjagm5kzmffli1cUv2/N+1hKUvcI4uFCqEwZRFtp90RyIbxUfQwi+CsXVnwV+BZS5qD9bTcfxZMXhuVRwO/5xWYMYPN1uY=-----END CERTIFICATE-----"
                },
            };
            try
            {
                var resp = client.AddCertificate(req);
                Console.WriteLine(resp.HttpStatusCode);
                Console.WriteLine(resp);
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
        
        
          private static void verifyCertificate(IoTDAClient client)
        {
            CheckCertificateRequest req = new CheckCertificateRequest
            {
                Body = new VerifyCertificateDTO()
                {
                    VerifyContent= "-----BEGIN CERTIFICATE-----MIID2TCCAsGgAwIBAgIJAOEDEgVdVMn9MA0GCSqGSIb3DQEBCwUAMIGCMQswCQYDVQQGEwJDTjERMA8GA1UECAwIR3VhbmRvbmcxETAPBgNVBAcMCFNoZW56aGVuMQ8wDQYDVQQKDAZIdWF3ZWkxDDAKBgNVBAsMA2lvdDESMBAGA1UEAwwJMTIzNDU2Nzg5MRowGAYJKoZIhvcNAQkBFgtkamthQHFxLmNvbTAeFw0xOTEyMTkxMzE1MjZaFw0yMjEwMDgxMzE1MjZaMIGCMQswCQYDVQQGEwJDTjERMA8GA1UECAwIR3VhbmRvbmcxETAPBgNVBAcMCFNoZW56aGVuMQ8wDQYDVQQKDAZIdWF3ZWkxDDAKBgNVBAsMA2lvdDESMBAGA1UEAwwJMTIzNDU2Nzg5MRowGAYJKoZIhvcNAQkBFgtkamthQHFxLmNvbTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBAM72QUzoadvLfxGjt3UFoZ4MJbblqnRbouO4KpOVHBXyS2yQVl4CWWMhLh4pp2efNUSqKuXHjY3r68PquyNnYk8zO59zVc7JHvjGkBvo7DgPRAhEKPLJIpRzkmlCBbxwTNCjc3FovGb/sHHNlpGncCKUzMfPGNZuBiuemskuEXL/eMHxDPbXYWn4Wq0wt+28PKUL5jybY7nsXSNnmAPFTO0CAmq0meUukubT/jHDCQ78ihQ/iqw1RNq88aCqRleoHiGg5nWkjL+05GXqUrqVVnZNL+YqcXzuVMs5XgyhNM2AsuH2g3D8ZuF6Dj9qY1n/v/Cp/DGpxP3A74SlplnFD/0CAwEAAaNQME4wHQYDVR0OBBYEFAVPWVtpTdO6KQnmVrrNlMguWNR7MB8GA1UdIwQYMBaAFAVPWVtpTdO6KQnmVrrNlMguWNR7MAwGA1UdEwQFMAMBAf8wDQYJKoZIhvcNAQELBQADggEBAE40ViqK+UaEn++Xq6f4Cmeg3JqYHu47v9RIAASNihYRBQ/r3RE7Af3GqjIO5nMJJuCMzdcoAU8N9KwkgXD+GLR9fYLEoEmq5CrhgaGDsCi85vCsmWhj5z8r5TG207xpmvH2KT447dnG+chMBE594ma85dCv+0mCDrqNToElipgT8+rYAYVClnIt3kbsTg1vSRNHadd+TpgRVxJZBF0fHcCAyc/2f3UJgPYNWShIetHM6BdI3fZ4H+eeHPjagm5kzmffli1cUv2/N+1hKUvcI4uFCqEwZRFtp90RyIbxUfQwi+CsXVnwV+BZS5qD9bTcfxZMXhuVRwO/5xWYMYPN1uY=-----END CERTIFICATE-----"
                },
                ActionId = "verify",
                CertificateId = "9dc7eed5-00e7-4ef1-a1cc-9fb43ad1d767"
            };
            try
            {
                var resp = client.CheckCertificate(req);
                Console.WriteLine(resp);
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