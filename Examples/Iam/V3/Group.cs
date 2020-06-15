using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Iam.V3;
using HuaweiCloud.SDK.Iam.V3.Model;
using Newtonsoft.Json;

namespace Examples.Iam.V3
{
    public class GroupDemo
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

            // 用户组管理

            // 查询用户组列表 GET /v3/groups
            KeystoneListGroups(iamDomainClient);

            // 查询用户组详情 GET /v3/groups/{group_id}
            KeystoneShowGroup(iamDomainClient);

            // 创建用户组 POST /v3/groups
            KeystoneCreateGroup(iamDomainClient);

            // 更新用户组 PATCH /v3/groups/{group_id}
            KeystoneUpdateGroup(iamDomainClient);

            // 删除用户组 DELETE /v3/groups/{group_id}
            KeystoneDeleteGroup(iamDomainClient);

            // 查询IAM用户是否在用户组中 HEAD /v3/groups/{group_id}/users/{user_id}
            KeystoneCheckUserInGroup(iamDomainClient);

            // 添加IAM用户到用户组 PUT /v3/groups/{group_id}/users/{user_id}
            KeystoneAddUserToGroup(iamDomainClient);

            // 移除用户组中的IAM用户 DELETE /v3/groups/{group_id}/users/{user_id}
            KeystoneRemoveUserFromGroup(iamDomainClient);
        }

        private static void KeystoneListGroups(IamClient iamClient)
        {
            var keystoneListGroupsRequest = new KeystoneListGroupsRequest()
            {
                Name = ""
            };
            try
            {
                var keystoneListGroupsResponse = iamClient.KeystoneListGroups(keystoneListGroupsRequest);
                foreach (var group in keystoneListGroupsResponse.Groups)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(group));
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

        private static void KeystoneShowGroup(IamClient iamClient)
        {
            var keystoneShowGroupRequest = new KeystoneShowGroupRequest()
            {
                
                GroupId = ""
            };
            try
            {
                var keystoneShowGroupResponse =
                    iamClient.KeystoneShowGroup(keystoneShowGroupRequest);
                Console.WriteLine(JsonConvert.SerializeObject(keystoneShowGroupResponse.Group));
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

        private static void KeystoneCreateGroup(IamClient iamClient)
        {
            var keystoneCreateGroupRequest = new KeystoneCreateGroupRequest()
            {
                
                Body = new KeystoneCreateGroupRequestBody()
                {
                    Group = new KeystoneCreateGroupOption()
                    {
                        Description = "",
                        DomainId = "",
                        Name = ""
                    }
                }
            };
            try
            {
                var keystoneCreateGroupResponse = iamClient.KeystoneCreateGroup(keystoneCreateGroupRequest);
                Console.WriteLine(JsonConvert.SerializeObject(keystoneCreateGroupResponse.Group));
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

        private static void KeystoneUpdateGroup(IamClient iamClient)
        {
            var keystoneUpdateGroupRequest = new KeystoneUpdateGroupRequest()
            {
                
                GroupId = "",
                Body = new KeystoneUpdateGroupRequestBody()
                {
                    Group = new KeystoneUpdateGroupOption()
                    {
                        Description = "",
                        DomainId = "",
                        Name = ""
                    }
                }
            };
            try
            {
                var keystoneUpdateGroupResponse = iamClient.KeystoneUpdateGroup(keystoneUpdateGroupRequest);
                Console.WriteLine(JsonConvert.SerializeObject(keystoneUpdateGroupResponse.Group));
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

        private static void KeystoneDeleteGroup(IamClient iamClient)
        {
            var keystoneDeleteGroupRequest = new KeystoneDeleteGroupRequest()
            {
                GroupId = ""
            };
            try
            {
                var keystoneDeleteGroupResponse = iamClient.KeystoneDeleteGroup(keystoneDeleteGroupRequest);
                Console.WriteLine(keystoneDeleteGroupResponse.HttpStatusCode);
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

        private static void KeystoneCheckUserInGroup(IamClient iamClient)
        {
            var keystoneCheckUserInGroupRequest = new KeystoneCheckUserInGroupRequest()
            {
                
                GroupId = "",
                UserId = ""
            };
            try
            {
                var keystoneCheckUserInGroupResponse =
                    iamClient.KeystoneCheckUserInGroup(keystoneCheckUserInGroupRequest);
                Console.WriteLine(keystoneCheckUserInGroupResponse.HttpStatusCode);
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

        private static void KeystoneAddUserToGroup(IamClient iamClient)
        {
            var keystoneAddUserToGroupRequest = new KeystoneAddUserToGroupRequest()
            {
                
                UserId = "",
                GroupId = ""
            };
            try
            {
                var keystoneAddUserToGroupResponse = iamClient.KeystoneAddUserToGroup(keystoneAddUserToGroupRequest);
                Console.WriteLine(keystoneAddUserToGroupResponse.HttpStatusCode);
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

        private static void KeystoneRemoveUserFromGroup(IamClient iamClient)
        {
            var keystoneRemoveUserFromGroupRequest = new KeystoneRemoveUserFromGroupRequest()
            {
                
                UserId = "",
                GroupId = ""
            };
            try
            {
                var keystoneRemoveUserFromGroupResponse =
                    iamClient.KeystoneRemoveUserFromGroup(keystoneRemoveUserFromGroupRequest);
                Console.WriteLine(keystoneRemoveUserFromGroupResponse.HttpStatusCode);
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