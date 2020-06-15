using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Iam.V3;
using HuaweiCloud.SDK.Iam.V3.Model;
using Newtonsoft.Json;

namespace Examples.Iam.V3
{
    public class UserDemo
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

            // 用户管理

            // 管理员查询IAM用户列表  GET /v3/users
            KeystoneListUsers(iamDomainClient);

            // 查询IAM用户详情  GET /v3/users/{user_id}
            KeystoneShowUser(iamDomainClient);

            // 查询IAM用户所属用户组  GET /v3/users/{user_id}/groups
            KeystoneListGroupsForUser(iamDomainClient);

            // 管理员查询用户组所包含的IAM用户 GET /v3/groups/{group_id}/users
            KeystoneListUsersForGroupByAdmin(iamDomainClient);

            // 管理员创建IAM用户  POST /v3/users
            KeystoneCreateUser(iamDomainClient);

            // 修改IAM用户密码  POST /v3/users/{user_id}/password
            KeystoneUpdateUserPassword(iamDomainClient);

            // 管理员修改IAM用户信息  PATCH /v3/users/{user_id}
            KeystoneUpdateUserByAdmin(iamDomainClient);

            // 管理员删除IAM用户  DELETE /v3/users/{user_id}
            KeystoneDeleteUser(iamDomainClient);
        }

        private static void KeystoneListUsers(IamClient iamClient)
        {
            var keystoneListUsersRequest = new KeystoneListUsersRequest()
            {
                Enabled = true,
                Name = "",
                PasswordExpiresAt = ""
            };
            try
            {
                var keystoneListUsersResponse = iamClient.KeystoneListUsers(keystoneListUsersRequest);
                foreach (var user in keystoneListUsersResponse.Users)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(user));
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

        private static void KeystoneShowUser(IamClient iamClient)
        {
            var keystoneShowUserRequest = new KeystoneShowUserRequest()
            {
                
                UserId = ""
            };
            try
            {
                var keystoneShowUserResponse =
                    iamClient.KeystoneShowUser(keystoneShowUserRequest);
                Console.WriteLine(JsonConvert.SerializeObject(keystoneShowUserResponse.User));
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

        private static void KeystoneListGroupsForUser(IamClient iamClient)
        {
            var keystoneListGroupsForUserRequest = new KeystoneListGroupsForUserRequest()
            {
                
                UserId = ""
            };
            try
            {
                var keystoneListGroupsForUserResponse =
                    iamClient.KeystoneListGroupsForUser(keystoneListGroupsForUserRequest);
                foreach (var group in keystoneListGroupsForUserResponse.Groups)
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

        private static void KeystoneListUsersForGroupByAdmin(IamClient iamClient)
        {
            var keystoneListUsersForGroupByAdminRequest = new KeystoneListUsersForGroupByAdminRequest()
            {
                
                GroupId = ""
            };
            try
            {
                var keystoneListUsersForGroupByAdminResponse =
                    iamClient.KeystoneListUsersForGroupByAdmin(keystoneListUsersForGroupByAdminRequest);
                foreach (var user in keystoneListUsersForGroupByAdminResponse.Users)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(user));
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


        private static void KeystoneCreateUser(IamClient iamClient)
        {
            var keystoneCreateUserRequest = new KeystoneCreateUserRequest()
            {
                
                Body = new KeystoneCreateUserRequestBody()
                {
                    User = new KeystoneCreateUserOption()
                    {
                        Name = "",
                        DomainId = "",
                        Enabled = true,
                        Password = "",
                        Description = ""
                    }
                }
            };
            try
            {
                var keystoneCreateUserResponse = iamClient.KeystoneCreateUser(keystoneCreateUserRequest);
                Console.WriteLine(JsonConvert.SerializeObject(keystoneCreateUserResponse.User));
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

        private static void KeystoneUpdateUserPassword(IamClient iamClient)
        {
            var keystoneUpdateUserPasswordRequest = new KeystoneUpdateUserPasswordRequest()
            {
                
                UserId = "",
                Body = new KeystoneUpdateUserPasswordRequestBody()
                {
                    User = new KeystoneUpdatePasswordOption()
                    {
                        OriginalPassword = "",
                        Password = ""
                    }
                }
            };
            try
            {
                var keystoneUpdateUserPasswordResponse =
                    iamClient.KeystoneUpdateUserPassword(keystoneUpdateUserPasswordRequest);
                Console.WriteLine(keystoneUpdateUserPasswordResponse.HttpStatusCode);
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


        private static void KeystoneUpdateUserByAdmin(IamClient iamClient)
        {
            var keystoneUpdateUserInformationByAdminRequest = new KeystoneUpdateUserByAdminRequest()
            {
                
                UserId = "",
                Body = new KeystoneUpdateUserByAdminRequestBody()
                {
                    User = new KeystoneUpdateUserOption()
                    {
                        Name = "",
                        DomainId = "",
                        Enabled = true,
                        Password = "",
                        Description = "",
                        PwdStatus = false
                    }
                }
            };
            try
            {
                var keystoneUpdateUserInformationByAdminResponse =
                    iamClient.KeystoneUpdateUserByAdmin(keystoneUpdateUserInformationByAdminRequest);
                Console.WriteLine(JsonConvert.SerializeObject(keystoneUpdateUserInformationByAdminResponse.User));
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

        private static void KeystoneDeleteUser(IamClient iamClient)
        {
            var keystoneDeleteUserRequest = new KeystoneDeleteUserRequest()
            {
                
                UserId = ""
            };
            try
            {
                var keystoneDeleteUserResponse = iamClient.KeystoneDeleteUser(keystoneDeleteUserRequest);
                Console.WriteLine(keystoneDeleteUserResponse.HttpStatusCode);
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