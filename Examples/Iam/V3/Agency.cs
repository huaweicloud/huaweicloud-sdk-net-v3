using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Iam.V3;
using HuaweiCloud.SDK.Iam.V3.Model;
using Newtonsoft.Json;

namespace Examples.Iam.V3
{
    public class AgencyDemo
    {
        static void Main1(string[] args)
        {
            // 华为云
            const string ak = "{your ak string}";
            const string sk = "{your sk string}";
            const string endpoint = "{your endpoint string}";
            const string domainId = "{your domainID string}";
            
            var config = HttpConfig.GetDefaultConfig();
            config.IgnoreSslVerification = true;
            var auth = new BasicCredentials(ak, sk, null, domainId);
            var iamDomainClient = IamClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .WithHttpConfig(config).Build();

            // 委托管理

            // 查询指定条件下的委托列表 GET /v3.0/OS-AGENCY/agencies
            ListAgencies(iamDomainClient);

            // 查询委托详情 GET /v3.0/OS-AGENCY/agencies/{agency_id}
            ShowAgency(iamDomainClient);

            // 创建委托 POST /v3.0/OS-AGENCY/agencies
            CreateAgency(iamDomainClient);

            // 修改委托 PUT /v3.0/OS-AGENCY/agencies/{agency_id}
            UpdateAgency(iamDomainClient);

            // 删除委托 DELETE /v3.0/OS-AGENCY/agencies/{agency_id}
            DeleteAgency(iamDomainClient);

            // 查询全局服务中的委托权限 GET /v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles
            ListDomainPermissionsForAgency(iamDomainClient);

            // 查询项目服务中的委托权限 GET /v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles
            ListProjectPermissionsForAgency(iamDomainClient);

            // 为委托授予全局服务权限 PUT /v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}
            AssociateAgencyWithDomainPermission(iamDomainClient);

            // 为委托授予项目服务权限 PUT /v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}
            AssociateAgencyWithProjectPermission(iamDomainClient);

            // 查询委托是否拥有全局服务权限 HEAD /v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}
            CheckDomainPermissionForAgency(iamDomainClient);

            // 查询委托是否拥有项目服务权限 HEAD /v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}
            CheckProjectPermissionForAgency(iamDomainClient);

            // 移除委托的全局服务权限  DELETE /v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}
            RemoveDomainPermissionFromAgency(iamDomainClient);

            // 移除委托的项目服务权限 DELETE /v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}
            RemoveProjectPermissionFromAgency(iamDomainClient);
        }


        private static void ListAgencies(IamClient iamClient)
        {
            var listAgenciesRequest = new ListAgenciesRequest()
            {
                TrustDomainId = "",
                Name = ""
            };
            try
            {
                var listAgenciesResponse = iamClient.ListAgencies(listAgenciesRequest);
                foreach (var agency in listAgenciesResponse.Agencies)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(agency));
                }
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

        private static void ShowAgency(IamClient iamClient)
        {
            var showAgencyRequest = new ShowAgencyRequest()
            {
                AgencyId = ""
            };
            try
            {
                var showAgencyResponse = iamClient.ShowAgency(showAgencyRequest);
                Console.WriteLine(JsonConvert.SerializeObject(showAgencyResponse.Agency));
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

        private static void CreateAgency(IamClient iamClient)
        {
            var createAgencyRequest = new CreateAgencyRequest()
            {
                Body = new CreateAgencyRequestBody()
                {
                    Agency = new CreateAgencyOption()
                    {
                        Name = "",
                        Description = "",
                        TrustDomainId = "",
                        TrustDomainName = "",
                        Duration = CreateAgencyOption.DurationEnum.ONEDAY ,
                        DomainId = ""
                    }
                }
            };
            try
            {
                var createAgencyResponse = iamClient.CreateAgency(createAgencyRequest);
                Console.WriteLine(JsonConvert.SerializeObject(createAgencyResponse.Agency));
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

        private static void UpdateAgency(IamClient iamClient)
        {
            var updateAgencyRequest = new UpdateAgencyRequest()
            {
                AgencyId = "",
                Body = new UpdateAgencyRequestBody()
                {
                    Agency = new UpdateAgencyOption()
                    {
                        Description = "",
                        Duration = UpdateAgencyOption.DurationEnum.ONEDAY,
                        TrustDomainId = "",
                        TrustDomainName = ""
                    }
                }
            };
            try
            {
                var updateAgencyResponse = iamClient.UpdateAgency(updateAgencyRequest);
                Console.WriteLine(JsonConvert.SerializeObject(updateAgencyResponse.Agency));
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

        private static void DeleteAgency(IamClient iamV3Client)
        {
            var deleteAgencyRequest = new DeleteAgencyRequest()
            {
                AgencyId = ""
            };
            try
            {
                var deleteAgencyResponse = iamV3Client.DeleteAgency(deleteAgencyRequest);
                Console.WriteLine(JsonConvert.SerializeObject(deleteAgencyResponse.HttpStatusCode));
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

        private static void ListDomainPermissionsForAgency(IamClient iamClient)
        {
            var listPermissionsForAgencyOnDomainRequest = new ListDomainPermissionsForAgencyRequest()
            {
                AgencyId = ""
            };
            try
            {
                var listPermissionsForAgencyOnDomainResponse =
                    iamClient.ListDomainPermissionsForAgency(listPermissionsForAgencyOnDomainRequest);
                foreach (var role in listPermissionsForAgencyOnDomainResponse.Roles)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(role));
                }
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

        private static void ListProjectPermissionsForAgency(IamClient iamClient)
        {
            var listPermissionsForAgencyOnProjectRequest = new ListProjectPermissionsForAgencyRequest()
            {
                ProjectId = "",
                AgencyId = ""
            };
            try
            {
                var listPermissionsForAgencyOnProjectResponse =
                    iamClient.ListProjectPermissionsForAgency(listPermissionsForAgencyOnProjectRequest);
                foreach (var role in listPermissionsForAgencyOnProjectResponse.Roles)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(role));
                }
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

        private static void AssociateAgencyWithDomainPermission(IamClient iamV3Client)
        {
            var grantPermissionToAgencyOnDomainRequest = new AssociateAgencyWithDomainPermissionRequest()
            {
                AgencyId = "",
                RoleId = ""
            };
            try
            {
                var grantPermissionToAgencyOnDomainResponse =
                    iamV3Client.AssociateAgencyWithDomainPermission(grantPermissionToAgencyOnDomainRequest);
                Console.WriteLine(JsonConvert.SerializeObject(grantPermissionToAgencyOnDomainResponse.HttpStatusCode));
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

        private static void AssociateAgencyWithProjectPermission(IamClient iamClient)
        {
            var grantPermissionToAgencyOnProjectRequest = new AssociateAgencyWithProjectPermissionRequest()
            {
                ProjectId = "",
                AgencyId = "",
                RoleId = ""
            };
            try
            {
                var grantPermissionToAgencyOnProjectResponse =
                    iamClient.AssociateAgencyWithProjectPermission(grantPermissionToAgencyOnProjectRequest);
                Console.WriteLine(JsonConvert.SerializeObject(grantPermissionToAgencyOnProjectResponse.HttpStatusCode));
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

        private static void CheckDomainPermissionForAgency(IamClient iamV3Client)
        {
            var checkPermissionForAgencyOnDomainRequest = new CheckDomainPermissionForAgencyRequest()
            {
                AgencyId = "",
                RoleId = ""
            };
            try
            {
                var checkPermissionForAgencyOnDomainResponse =
                    iamV3Client.CheckDomainPermissionForAgency(checkPermissionForAgencyOnDomainRequest);
                Console.WriteLine(JsonConvert.SerializeObject(checkPermissionForAgencyOnDomainResponse.HttpStatusCode));
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

        private static void CheckProjectPermissionForAgency(IamClient iamV3Client)
        {
            var checkPermissionForAgencyOnProjectRequest = new CheckProjectPermissionForAgencyRequest()
            {
                ProjectId = "",
                AgencyId = "",
                RoleId = ""
            };
            try
            {
                var checkPermissionForAgencyOnProjectResponse =
                    iamV3Client.CheckProjectPermissionForAgency(checkPermissionForAgencyOnProjectRequest);
                Console.WriteLine(JsonConvert.SerializeObject(checkPermissionForAgencyOnProjectResponse.HttpStatusCode));
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

        private static void RemoveDomainPermissionFromAgency(IamClient iamClient)
        {
            var removePermissionFromAgencyOnDomainRequest = new RemoveDomainPermissionFromAgencyRequest()
            {
                AgencyId = "",
                RoleId = ""
            };
            try
            {
                var removePermissionFromAgencyOnDomainResponse =
                    iamClient.RemoveDomainPermissionFromAgency(removePermissionFromAgencyOnDomainRequest);
                Console.WriteLine(JsonConvert.SerializeObject(removePermissionFromAgencyOnDomainResponse.HttpStatusCode));
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

        private static void RemoveProjectPermissionFromAgency(IamClient iamClient)
        {
            var removePermissionFromAgencyOnProjectRequest = new RemoveProjectPermissionFromAgencyRequest()
            {
                ProjectId = "",
                AgencyId = "",
                RoleId = ""
            };
            try
            {
                var removePermissionFromAgencyOnProjectResponse =
                    iamClient.RemoveProjectPermissionFromAgency(removePermissionFromAgencyOnProjectRequest);
                Console.WriteLine(JsonConvert.SerializeObject(removePermissionFromAgencyOnProjectResponse.HttpStatusCode));
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