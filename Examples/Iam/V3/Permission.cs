using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Iam.V3;
using HuaweiCloud.SDK.Iam.V3.Model;
using Newtonsoft.Json;

namespace Examples.Iam.V3
{
    public class PermissionDemo
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

            // 权限管理

            // 查询权限列表 GET /v3/roles
            KeystoneListPermissions(iamDomainClient);

            // 查询权限详情 GET /v3/roles/{role_id}
            KeystoneShowPermission(iamDomainClient);

            // 查询全局服务中的用户组权限 GET /v3/domains/{domain_id}/groups/{group_id}/roles
            KeystoneListDomainPermissionsForGroup(iamDomainClient);

            // 查询项目服务中的用户组权限 GET /v3/projects/{project_id}/groups/{group_id}/roles
            KeystoneListProjectPermissionsForGroup(iamDomainClient);

            // 为用户组授予全局服务权限 PUT /v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}
            KeystoneAssociateGroupWithDomainPermission(iamDomainClient);

            // 为用户组授予项目服务权限 PUT /v3/projects/{project_id}/groups/{group_id}/roles/{role_id}
            KeystoneAssociateGroupWithProjectPermission(iamDomainClient);

            // 查询用户组是否拥有全局服务权限 HEAD /v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}
            KeystoneCheckDomainPermissionForGroup(iamDomainClient);

            // 查询用户组是否拥有项目服务权限 HEAD /v3/projects/{project_id}/groups/{group_id}/roles/{role_id}
            KeystoneCheckProjectPermissionForGroup(iamDomainClient);

            // 移除用户组的全局服务权限  DELETE /v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}
            KeystoneRemoveDomainPermissionFromGroup(iamDomainClient);

            // 移除用户组的项目服务权限  DELETE /v3/projects/{project_id}/groups/{group_id}/roles/{role_id}
            KeystoneRemoveProjectPermissionFromGroup(iamDomainClient);
        }

        private static void KeystoneListPermissions(IamClient iamClient)
        {
            var keystoneListPermissionsRequest = new KeystoneListPermissionsRequest()
            {
                Name = ""
            };
            try
            {
                var keystoneListPermissionsResponse = iamClient.KeystoneListPermissions(keystoneListPermissionsRequest);
                foreach (var role in keystoneListPermissionsResponse.Roles)
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

        private static void KeystoneShowPermission(IamClient iamClient)
        {
            var keystoneShowPermissionRequest = new KeystoneShowPermissionRequest()
            {
                
                RoleId = ""
            };
            try
            {
                var keystoneShowPermissionResponse =
                    iamClient.KeystoneShowPermission(keystoneShowPermissionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(keystoneShowPermissionResponse.Role));
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

        private static void KeystoneListDomainPermissionsForGroup(IamClient iamClient)
        {
            var keystoneListDomainPermissionsForGroupRequest = new KeystoneListDomainPermissionsForGroupRequest()
            {
                GroupId = ""
            };
            try
            {
                var keystoneListDomainPermissionsForGroupResponse =
                    iamClient.KeystoneListDomainPermissionsForGroup(keystoneListDomainPermissionsForGroupRequest);
                foreach (var role in keystoneListDomainPermissionsForGroupResponse.Roles)
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

        private static void KeystoneListProjectPermissionsForGroup(IamClient iamClient)
        {
            var keystoneListProjectPermissionsForGroupRequest = new KeystoneListProjectPermissionsForGroupRequest()
            {
                
                ProjectId = "",
                GroupId = ""
            };
            try
            {
                var keystoneListProjectPermissionsForGroupResponse =
                    iamClient.KeystoneListProjectPermissionsForGroup(keystoneListProjectPermissionsForGroupRequest);
                foreach (var role in keystoneListProjectPermissionsForGroupResponse.Roles)
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

        private static void KeystoneAssociateGroupWithDomainPermission(IamClient iamClient)
        {
            var keystoneGrantPermissionToGroupOnDomainRequest = new KeystoneAssociateGroupWithDomainPermissionRequest()
            {
                GroupId = "",
                RoleId = "",
            };
            try
            {
                var keystoneGrantPermissionToGroupOnDomainResponse =
                    iamClient.KeystoneAssociateGroupWithDomainPermission(keystoneGrantPermissionToGroupOnDomainRequest);
                Console.WriteLine(
                    JsonConvert.SerializeObject(keystoneGrantPermissionToGroupOnDomainResponse.HttpStatusCode));
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

        private static void KeystoneAssociateGroupWithProjectPermission(IamClient iamClient)
        {
            var keystoneGrantPermissionToGroupOnProjectRequest = new KeystoneAssociateGroupWithProjectPermissionRequest()
            {
                
                ProjectId = "",
                GroupId = "",
                RoleId = "",
            };
            try
            {
                var keystoneGrantPermissionToGroupOnProjectResponse =
                    iamClient.KeystoneAssociateGroupWithProjectPermission(keystoneGrantPermissionToGroupOnProjectRequest);
                Console.WriteLine(
                    JsonConvert.SerializeObject(keystoneGrantPermissionToGroupOnProjectResponse.HttpStatusCode));
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

        private static void KeystoneCheckDomainPermissionForGroup(IamClient iamClient)
        {
            var keystoneCheckPermissionForGroupOnDomainRequest =
                new KeystoneCheckDomainPermissionForGroupRequest()
                {
                    GroupId = "",
                    RoleId = ""
                };
            try
            {
                var keystoneCheckPermissionForGroupOnDomainResponse =
                    iamClient.KeystoneCheckDomainPermissionForGroup(keystoneCheckPermissionForGroupOnDomainRequest);
                Console.WriteLine(
                    JsonConvert.SerializeObject(keystoneCheckPermissionForGroupOnDomainResponse.HttpStatusCode));
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

        private static void KeystoneCheckProjectPermissionForGroup(IamClient iamClient)
        {
            var keystoneCheckPermissionForGroupOnProjectRequest =
                new KeystoneCheckProjectPermissionForGroupRequest()
                {
                    
                    ProjectId = "",
                    GroupId = "",
                    RoleId = ""
                };
            try
            {
                var keystoneCheckPermissionForGroupOnProjectResponse =
                    iamClient.KeystoneCheckProjectPermissionForGroup(keystoneCheckPermissionForGroupOnProjectRequest);
                Console.WriteLine(
                    JsonConvert.SerializeObject(keystoneCheckPermissionForGroupOnProjectResponse.HttpStatusCode));
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

        private static void KeystoneRemoveDomainPermissionFromGroup(IamClient iamClient)
        {
            var keystoneRemovePermissionFromGroupOnDomainRequest =
                new KeystoneRemoveDomainPermissionFromGroupRequest()
                {
                    GroupId = "",
                    RoleId = ""
                };
            try
            {
                var keystoneRemovePermissionFromGroupOnDomainResponse =
                    iamClient.KeystoneRemoveDomainPermissionFromGroup(
                        keystoneRemovePermissionFromGroupOnDomainRequest);
                Console.WriteLine(
                    JsonConvert.SerializeObject(keystoneRemovePermissionFromGroupOnDomainResponse.HttpStatusCode));
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

        private static void KeystoneRemoveProjectPermissionFromGroup(IamClient iamClient)
        {
            var keystoneRemovePermissionFromGroupOnProjectRequest =
                new KeystoneRemoveProjectPermissionFromGroupRequest()
                {
                    
                    ProjectId = "",
                    GroupId = "",
                    RoleId = ""
                };
            try
            {
                var keystoneRemovePermissionFromGroupOnProjectResponse =
                    iamClient.KeystoneRemoveProjectPermissionFromGroup(
                        keystoneRemovePermissionFromGroupOnProjectRequest);
                Console.WriteLine(
                    JsonConvert.SerializeObject(keystoneRemovePermissionFromGroupOnProjectResponse.HttpStatusCode));
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