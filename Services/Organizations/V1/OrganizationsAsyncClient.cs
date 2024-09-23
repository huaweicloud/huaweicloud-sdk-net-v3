using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Organizations.V1.Model;

namespace HuaweiCloud.SDK.Organizations.V1
{
    public partial class OrganizationsAsyncClient : Client
    {
        public static ClientBuilder<OrganizationsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<OrganizationsAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 关闭账号
        ///
        /// 关闭账号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CloseAccountResponse> CloseAccountAsync(CloseAccountRequest closeAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account_id", closeAccountRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/close", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CloseAccountResponse>(response);
        }

        public AsyncInvoker<CloseAccountResponse> CloseAccountAsyncInvoker(CloseAccountRequest closeAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account_id", closeAccountRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/close", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeAccountRequest);
            return new AsyncInvoker<CloseAccountResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CloseAccountResponse>);
        }
        
        /// <summary>
        /// 创建账号
        ///
        /// 创建一个账号，生成的账号将自动成为调用此接口的账号所属组织的成员。此操作只能由组织的管理账号调用。组织云服务将在新账号中创建所需的服务关联委托和账号访问委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest createAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAccountResponse>(response);
        }

        public AsyncInvoker<CreateAccountResponse> CreateAccountAsyncInvoker(CreateAccountRequest createAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccountRequest);
            return new AsyncInvoker<CreateAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccountResponse>);
        }
        
        /// <summary>
        /// 邀请账号加入组织
        ///
        /// 向另一个账号发送邀请，受邀账号将以成员账号加入您的组织。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<InviteAccountResponse> InviteAccountAsync(InviteAccountRequest inviteAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/invite", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<InviteAccountResponse>(response);
        }

        public AsyncInvoker<InviteAccountResponse> InviteAccountAsyncInvoker(InviteAccountRequest inviteAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/invite", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteAccountRequest);
            return new AsyncInvoker<InviteAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<InviteAccountResponse>);
        }
        
        /// <summary>
        /// 列出组织中的账号
        ///
        /// 列出组织中的账号。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。如果指定父级组织单元，则将获得作为父级直系子级的所有账号的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest listAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccountsResponse>(response);
        }

        public AsyncInvoker<ListAccountsResponse> ListAccountsAsyncInvoker(ListAccountsRequest listAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsRequest);
            return new AsyncInvoker<ListAccountsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountsResponse>);
        }
        
        /// <summary>
        /// 列出关闭账号的状态
        ///
        /// 列出组织中指定状态的账号关闭请求。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCloseAccountStatusesResponse> ListCloseAccountStatusesAsync(ListCloseAccountStatusesRequest listCloseAccountStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/close-account-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloseAccountStatusesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCloseAccountStatusesResponse>(response);
        }

        public AsyncInvoker<ListCloseAccountStatusesResponse> ListCloseAccountStatusesAsyncInvoker(ListCloseAccountStatusesRequest listCloseAccountStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/close-account-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloseAccountStatusesRequest);
            return new AsyncInvoker<ListCloseAccountStatusesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloseAccountStatusesResponse>);
        }
        
        /// <summary>
        /// 列出创建账号的状态
        ///
        /// 列出组织中指定状态的账号创建请求。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCreateAccountStatusesResponse> ListCreateAccountStatusesAsync(ListCreateAccountStatusesRequest listCreateAccountStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/create-account-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCreateAccountStatusesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCreateAccountStatusesResponse>(response);
        }

        public AsyncInvoker<ListCreateAccountStatusesResponse> ListCreateAccountStatusesAsyncInvoker(ListCreateAccountStatusesRequest listCreateAccountStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/create-account-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCreateAccountStatusesRequest);
            return new AsyncInvoker<ListCreateAccountStatusesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCreateAccountStatusesResponse>);
        }
        
        /// <summary>
        /// 移动账号
        ///
        /// 将账号从其当前源位置（根或组织单元）移动到指定的目标位置（根或组织单元）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<MoveAccountResponse> MoveAccountAsync(MoveAccountRequest moveAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account_id", moveAccountRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/move", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<MoveAccountResponse>(response);
        }

        public AsyncInvoker<MoveAccountResponse> MoveAccountAsyncInvoker(MoveAccountRequest moveAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account_id", moveAccountRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/move", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveAccountRequest);
            return new AsyncInvoker<MoveAccountResponse>(this, "POST", request, JsonUtils.DeSerializeNull<MoveAccountResponse>);
        }
        
        /// <summary>
        /// 移除指定的账号
        ///
        /// 从组织中移除指定的账号。移除的账号将成为一个独立账号，该账号不是任何组织的成员。此操作只能由组织的管理账号调用。只有当账号配置了作为独立账号运行所需的信息时，您才能从组织中移除账号。注意，要移除的账号不能是组织启用的任何服务的委托管理员账号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveAccountResponse> RemoveAccountAsync(RemoveAccountRequest removeAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account_id", removeAccountRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RemoveAccountResponse>(response);
        }

        public AsyncInvoker<RemoveAccountResponse> RemoveAccountAsyncInvoker(RemoveAccountRequest removeAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account_id", removeAccountRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeAccountRequest);
            return new AsyncInvoker<RemoveAccountResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RemoveAccountResponse>);
        }
        
        /// <summary>
        /// 查询账号信息
        ///
        /// 查询有关指定账号的信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAccountResponse> ShowAccountAsync(ShowAccountRequest showAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account_id", showAccountRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAccountResponse>(response);
        }

        public AsyncInvoker<ShowAccountResponse> ShowAccountAsyncInvoker(ShowAccountRequest showAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account_id", showAccountRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccountRequest);
            return new AsyncInvoker<ShowAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAccountResponse>);
        }
        
        /// <summary>
        /// 查询有关创建账号状态的信息
        ///
        /// 检索创建账号的异步请求的当前状态。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCreateAccountStatusResponse> ShowCreateAccountStatusAsync(ShowCreateAccountStatusRequest showCreateAccountStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("create_account_status_id", showCreateAccountStatusRequest.CreateAccountStatusId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/create-account-status/{create_account_status_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCreateAccountStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCreateAccountStatusResponse>(response);
        }

        public AsyncInvoker<ShowCreateAccountStatusResponse> ShowCreateAccountStatusAsyncInvoker(ShowCreateAccountStatusRequest showCreateAccountStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("create_account_status_id", showCreateAccountStatusRequest.CreateAccountStatusId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/create-account-status/{create_account_status_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCreateAccountStatusRequest);
            return new AsyncInvoker<ShowCreateAccountStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCreateAccountStatusResponse>);
        }
        
        /// <summary>
        /// 更新账号信息
        ///
        /// 更新指定的账号信息。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAccountResponse> UpdateAccountAsync(UpdateAccountRequest updateAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account_id", updateAccountRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccountRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateAccountResponse>(response);
        }

        public AsyncInvoker<UpdateAccountResponse> UpdateAccountAsyncInvoker(UpdateAccountRequest updateAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account_id", updateAccountRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccountRequest);
            return new AsyncInvoker<UpdateAccountResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateAccountResponse>);
        }
        
        /// <summary>
        /// 注销服务的委托管理员
        ///
        /// 删除指定成员账号作为指定服务的委托管理员。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeregisterDelegatedAdministratorResponse> DeregisterDelegatedAdministratorAsync(DeregisterDelegatedAdministratorRequest deregisterDelegatedAdministratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/delegated-administrators/deregister", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deregisterDelegatedAdministratorRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeregisterDelegatedAdministratorResponse>(response);
        }

        public AsyncInvoker<DeregisterDelegatedAdministratorResponse> DeregisterDelegatedAdministratorAsyncInvoker(DeregisterDelegatedAdministratorRequest deregisterDelegatedAdministratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/delegated-administrators/deregister", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deregisterDelegatedAdministratorRequest);
            return new AsyncInvoker<DeregisterDelegatedAdministratorResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeregisterDelegatedAdministratorResponse>);
        }
        
        /// <summary>
        /// 列出此组织中指定为委托管理员的账号
        ///
        /// 列出在此组织中指定为委派管理员的账号。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDelegatedAdministratorsResponse> ListDelegatedAdministratorsAsync(ListDelegatedAdministratorsRequest listDelegatedAdministratorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/delegated-administrators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDelegatedAdministratorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDelegatedAdministratorsResponse>(response);
        }

        public AsyncInvoker<ListDelegatedAdministratorsResponse> ListDelegatedAdministratorsAsyncInvoker(ListDelegatedAdministratorsRequest listDelegatedAdministratorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/delegated-administrators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDelegatedAdministratorsRequest);
            return new AsyncInvoker<ListDelegatedAdministratorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDelegatedAdministratorsResponse>);
        }
        
        /// <summary>
        /// 列出指定账号是其委托管理员的服务
        ///
        /// 列出指定账号是其委托管理员的服务。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDelegatedServicesResponse> ListDelegatedServicesAsync(ListDelegatedServicesRequest listDelegatedServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account_id", listDelegatedServicesRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/delegated-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDelegatedServicesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDelegatedServicesResponse>(response);
        }

        public AsyncInvoker<ListDelegatedServicesResponse> ListDelegatedServicesAsyncInvoker(ListDelegatedServicesRequest listDelegatedServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("account_id", listDelegatedServicesRequest.AccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/delegated-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDelegatedServicesRequest);
            return new AsyncInvoker<ListDelegatedServicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDelegatedServicesResponse>);
        }
        
        /// <summary>
        /// 注册作为服务委托管理员
        ///
        /// 指定成员账号能够管理指定服务的组织功能。此接口授予委托管理员对组织服务数据的只读访问权限。委托管理员账号中的IAM用户仍需要IAM权限才能访问和管理服务。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RegisterDelegatedAdministratorResponse> RegisterDelegatedAdministratorAsync(RegisterDelegatedAdministratorRequest registerDelegatedAdministratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/delegated-administrators/register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerDelegatedAdministratorRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RegisterDelegatedAdministratorResponse>(response);
        }

        public AsyncInvoker<RegisterDelegatedAdministratorResponse> RegisterDelegatedAdministratorAsyncInvoker(RegisterDelegatedAdministratorRequest registerDelegatedAdministratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/delegated-administrators/register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerDelegatedAdministratorRequest);
            return new AsyncInvoker<RegisterDelegatedAdministratorResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RegisterDelegatedAdministratorResponse>);
        }
        
        /// <summary>
        /// 接受邀请
        ///
        /// 向邀请的发起方发送应答，接受加入组织邀请。在您接受邀请后，此邀请信息将继续保留并出现在相关API的返回结果中，保留期限为30天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AcceptHandshakeResponse> AcceptHandshakeAsync(AcceptHandshakeRequest acceptHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("handshake_id", acceptHandshakeRequest.HandshakeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/received-handshakes/{handshake_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptHandshakeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AcceptHandshakeResponse>(response);
        }

        public AsyncInvoker<AcceptHandshakeResponse> AcceptHandshakeAsyncInvoker(AcceptHandshakeRequest acceptHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("handshake_id", acceptHandshakeRequest.HandshakeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/received-handshakes/{handshake_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptHandshakeRequest);
            return new AsyncInvoker<AcceptHandshakeResponse>(this, "POST", request, JsonUtils.DeSerialize<AcceptHandshakeResponse>);
        }
        
        /// <summary>
        /// 取消邀请
        ///
        /// 取消邀请，此时邀请状态将设置为已取消。此接口只能由发起邀请的账号调用。取消邀请后，此邀请信息将继续保留并出现在相关API的返回结果中，保留期限为30天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelHandshakeResponse> CancelHandshakeAsync(CancelHandshakeRequest cancelHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("handshake_id", cancelHandshakeRequest.HandshakeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/handshakes/{handshake_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelHandshakeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CancelHandshakeResponse>(response);
        }

        public AsyncInvoker<CancelHandshakeResponse> CancelHandshakeAsyncInvoker(CancelHandshakeRequest cancelHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("handshake_id", cancelHandshakeRequest.HandshakeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/handshakes/{handshake_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelHandshakeRequest);
            return new AsyncInvoker<CancelHandshakeResponse>(this, "POST", request, JsonUtils.DeSerialize<CancelHandshakeResponse>);
        }
        
        /// <summary>
        /// 拒绝邀请
        ///
        /// 拒绝邀请请求。受邀账号拒绝邀请，此时当前邀请状态将设置为拒绝，邀请停止。此接口只能由受邀账号调用。邀请发起者无法再次激活被拒绝的邀请，但可以重新发送新的邀请。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeclineHandshakeResponse> DeclineHandshakeAsync(DeclineHandshakeRequest declineHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("handshake_id", declineHandshakeRequest.HandshakeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/received-handshakes/{handshake_id}/decline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", declineHandshakeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeclineHandshakeResponse>(response);
        }

        public AsyncInvoker<DeclineHandshakeResponse> DeclineHandshakeAsyncInvoker(DeclineHandshakeRequest declineHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("handshake_id", declineHandshakeRequest.HandshakeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/received-handshakes/{handshake_id}/decline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", declineHandshakeRequest);
            return new AsyncInvoker<DeclineHandshakeResponse>(this, "POST", request, JsonUtils.DeSerialize<DeclineHandshakeResponse>);
        }
        
        /// <summary>
        /// 列出发送的邀请
        ///
        /// 列出所属组织发送的邀请。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHandshakesResponse> ListHandshakesAsync(ListHandshakesRequest listHandshakesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/handshakes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHandshakesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHandshakesResponse>(response);
        }

        public AsyncInvoker<ListHandshakesResponse> ListHandshakesAsyncInvoker(ListHandshakesRequest listHandshakesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/handshakes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHandshakesRequest);
            return new AsyncInvoker<ListHandshakesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHandshakesResponse>);
        }
        
        /// <summary>
        /// 列出收到的邀请
        ///
        /// 列出账号收到的所有邀请。此操作可以由任何账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListReceivedHandshakesResponse> ListReceivedHandshakesAsync(ListReceivedHandshakesRequest listReceivedHandshakesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/received-handshakes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReceivedHandshakesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListReceivedHandshakesResponse>(response);
        }

        public AsyncInvoker<ListReceivedHandshakesResponse> ListReceivedHandshakesAsyncInvoker(ListReceivedHandshakesRequest listReceivedHandshakesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/received-handshakes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReceivedHandshakesRequest);
            return new AsyncInvoker<ListReceivedHandshakesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReceivedHandshakesResponse>);
        }
        
        /// <summary>
        /// 查询邀请相关信息
        ///
        /// 查询组织中已有账号邀请的相关信息。此接口可以由组织中的任何账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHandshakeResponse> ShowHandshakeAsync(ShowHandshakeRequest showHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("handshake_id", showHandshakeRequest.HandshakeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/handshakes/{handshake_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHandshakeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHandshakeResponse>(response);
        }

        public AsyncInvoker<ShowHandshakeResponse> ShowHandshakeAsyncInvoker(ShowHandshakeRequest showHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("handshake_id", showHandshakeRequest.HandshakeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/handshakes/{handshake_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHandshakeRequest);
            return new AsyncInvoker<ShowHandshakeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHandshakeResponse>);
        }
        
        /// <summary>
        /// 列出组织中的根、组织单元和账号
        ///
        /// 列出组织中包含的所有根、组织单元和账号。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。您可以通过指定父ID和子ID参数来过滤实体。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEntitiesResponse> ListEntitiesAsync(ListEntitiesRequest listEntitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/entities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEntitiesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEntitiesResponse>(response);
        }

        public AsyncInvoker<ListEntitiesResponse> ListEntitiesAsyncInvoker(ListEntitiesRequest listEntitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/entities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEntitiesRequest);
            return new AsyncInvoker<ListEntitiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEntitiesResponse>);
        }
        
        /// <summary>
        /// 列出租户的组织配额
        ///
        /// 列出租户的组织配额。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQuotasResponse> ListQuotasAsync(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }

        public AsyncInvoker<ListQuotasResponse> ListQuotasAsyncInvoker(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            return new AsyncInvoker<ListQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotasResponse>);
        }
        
        /// <summary>
        /// 列出所有可以与组织服务集成的云服务
        ///
        /// 列出所有可以与组织服务集成的云服务。集成后云服务将成为组织的可信服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServicesResponse> ListServicesAsync(ListServicesRequest listServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServicesResponse>(response);
        }

        public AsyncInvoker<ListServicesResponse> ListServicesAsyncInvoker(ListServicesRequest listServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicesRequest);
            return new AsyncInvoker<ListServicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServicesResponse>);
        }
        
        /// <summary>
        /// 列出被添加到标签策略强制执行的资源类型
        ///
        /// 列出被添加到标签策略强制执行的资源类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagPolicyServicesResponse> ListTagPolicyServicesAsync(ListTagPolicyServicesRequest listTagPolicyServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/tag-policy-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagPolicyServicesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagPolicyServicesResponse>(response);
        }

        public AsyncInvoker<ListTagPolicyServicesResponse> ListTagPolicyServicesAsyncInvoker(ListTagPolicyServicesRequest listTagPolicyServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/tag-policy-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagPolicyServicesRequest);
            return new AsyncInvoker<ListTagPolicyServicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagPolicyServicesResponse>);
        }
        
        /// <summary>
        /// 查询有效的策略
        ///
        /// 查询指定策略类型和账号的有效策略信息。当前此接口不支持查询服务控制策略（service_control_policy）。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEffectivePoliciesResponse> ShowEffectivePoliciesAsync(ShowEffectivePoliciesRequest showEffectivePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/entities/effective-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEffectivePoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEffectivePoliciesResponse>(response);
        }

        public AsyncInvoker<ShowEffectivePoliciesResponse> ShowEffectivePoliciesAsyncInvoker(ShowEffectivePoliciesRequest showEffectivePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/entities/effective-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEffectivePoliciesRequest);
            return new AsyncInvoker<ShowEffectivePoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEffectivePoliciesResponse>);
        }
        
        /// <summary>
        /// 创建组织
        ///
        /// 创建组织。调用此接口的账号将自动成为新组织的管理账号，调用此接口的账号凭证必须是新组织管理账号的账号凭证。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOrganizationResponse> CreateOrganizationAsync(CreateOrganizationRequest createOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateOrganizationResponse>(response);
        }

        public AsyncInvoker<CreateOrganizationResponse> CreateOrganizationAsyncInvoker(CreateOrganizationRequest createOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationRequest);
            return new AsyncInvoker<CreateOrganizationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOrganizationResponse>);
        }
        
        /// <summary>
        /// 删除组织
        ///
        /// 删除组织。您必须使用管理账号才能删除组织，并且先移除组织中的所有账号、组织单元和策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteOrganizationResponse> DeleteOrganizationAsync(DeleteOrganizationRequest deleteOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOrganizationResponse>(response);
        }

        public AsyncInvoker<DeleteOrganizationResponse> DeleteOrganizationAsyncInvoker(DeleteOrganizationRequest deleteOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationRequest);
            return new AsyncInvoker<DeleteOrganizationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOrganizationResponse>);
        }
        
        /// <summary>
        /// 离开当前组织
        ///
        /// 此操作只能由组织的成员账号调用。只有当组织账号配置了作为独立账号运行所需的信息时，您才能作为成员账号离开组织。要离开的账号不能是组织启用的任何服务的委托管理员账号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<LeaveOrganizationResponse> LeaveOrganizationAsync(LeaveOrganizationRequest leaveOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/leave", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", leaveOrganizationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<LeaveOrganizationResponse>(response);
        }

        public AsyncInvoker<LeaveOrganizationResponse> LeaveOrganizationAsyncInvoker(LeaveOrganizationRequest leaveOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/leave", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", leaveOrganizationRequest);
            return new AsyncInvoker<LeaveOrganizationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<LeaveOrganizationResponse>);
        }
        
        /// <summary>
        /// 列出组织的根
        ///
        /// 列出当前组织的根。此接口只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRootsResponse> ListRootsAsync(ListRootsRequest listRootsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/roots", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRootsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRootsResponse>(response);
        }

        public AsyncInvoker<ListRootsResponse> ListRootsAsyncInvoker(ListRootsRequest listRootsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/roots", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRootsRequest);
            return new AsyncInvoker<ListRootsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRootsResponse>);
        }
        
        /// <summary>
        /// 查询所属组织信息
        ///
        /// 查询账号所属组织的信息。此操作可以由组织中的任何账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOrganizationResponse> ShowOrganizationAsync(ShowOrganizationRequest showOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationResponse>(response);
        }

        public AsyncInvoker<ShowOrganizationResponse> ShowOrganizationAsyncInvoker(ShowOrganizationRequest showOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationRequest);
            return new AsyncInvoker<ShowOrganizationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationResponse>);
        }
        
        /// <summary>
        /// 创建组织单元
        ///
        /// 在根或父组织单元中创建组织单元。组织单元是账号的容器，使您能够对账号进行分组管理，并根据业务要求应用策略。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOrganizationalUnitResponse> CreateOrganizationalUnitAsync(CreateOrganizationalUnitRequest createOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationalUnitRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateOrganizationalUnitResponse>(response);
        }

        public AsyncInvoker<CreateOrganizationalUnitResponse> CreateOrganizationalUnitAsyncInvoker(CreateOrganizationalUnitRequest createOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationalUnitRequest);
            return new AsyncInvoker<CreateOrganizationalUnitResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 删除组织单元
        ///
        /// 从根或其他组织单元中删除组织单元。前提是您必须先移除该组织单元中的所有成员账号或将成员账号移动至其他组织单元，必须删除该组织单元中的所有子组织单元。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteOrganizationalUnitResponse> DeleteOrganizationalUnitAsync(DeleteOrganizationalUnitRequest deleteOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organizational_unit_id", deleteOrganizationalUnitRequest.OrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units/{organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationalUnitRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOrganizationalUnitResponse>(response);
        }

        public AsyncInvoker<DeleteOrganizationalUnitResponse> DeleteOrganizationalUnitAsyncInvoker(DeleteOrganizationalUnitRequest deleteOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organizational_unit_id", deleteOrganizationalUnitRequest.OrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units/{organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationalUnitRequest);
            return new AsyncInvoker<DeleteOrganizationalUnitResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 列出组织单元
        ///
        /// 列出组织中的所有组织单元。如果指定父级组织单元，则将获得父级直系子级的组织单元列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOrganizationalUnitsResponse> ListOrganizationalUnitsAsync(ListOrganizationalUnitsRequest listOrganizationalUnitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationalUnitsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOrganizationalUnitsResponse>(response);
        }

        public AsyncInvoker<ListOrganizationalUnitsResponse> ListOrganizationalUnitsAsyncInvoker(ListOrganizationalUnitsRequest listOrganizationalUnitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationalUnitsRequest);
            return new AsyncInvoker<ListOrganizationalUnitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrganizationalUnitsResponse>);
        }
        
        /// <summary>
        /// 查询有关组织单元的信息
        ///
        /// 查询有关组织单元的信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOrganizationalUnitResponse> ShowOrganizationalUnitAsync(ShowOrganizationalUnitRequest showOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organizational_unit_id", showOrganizationalUnitRequest.OrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units/{organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationalUnitRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationalUnitResponse>(response);
        }

        public AsyncInvoker<ShowOrganizationalUnitResponse> ShowOrganizationalUnitAsyncInvoker(ShowOrganizationalUnitRequest showOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organizational_unit_id", showOrganizationalUnitRequest.OrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units/{organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationalUnitRequest);
            return new AsyncInvoker<ShowOrganizationalUnitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 更改组织单元名称
        ///
        /// 重命名指定的组织单元。重命名后组织单元ID不变，下属子组织单元和下属账号不变，组织单元绑定的策略不变。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateOrganizationalUnitResponse> UpdateOrganizationalUnitAsync(UpdateOrganizationalUnitRequest updateOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organizational_unit_id", updateOrganizationalUnitRequest.OrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units/{organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOrganizationalUnitRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateOrganizationalUnitResponse>(response);
        }

        public AsyncInvoker<UpdateOrganizationalUnitResponse> UpdateOrganizationalUnitAsyncInvoker(UpdateOrganizationalUnitRequest updateOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organizational_unit_id", updateOrganizationalUnitRequest.OrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units/{organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOrganizationalUnitRequest);
            return new AsyncInvoker<UpdateOrganizationalUnitResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 将策略跟实体绑定
        ///
        /// 绑定策略到根、组织单元或个人账号。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachPolicyResponse> AttachPolicyAsync(AttachPolicyRequest attachPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", attachPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}/attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AttachPolicyResponse>(response);
        }

        public AsyncInvoker<AttachPolicyResponse> AttachPolicyAsyncInvoker(AttachPolicyRequest attachPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", attachPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}/attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachPolicyRequest);
            return new AsyncInvoker<AttachPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AttachPolicyResponse>);
        }
        
        /// <summary>
        /// 创建策略
        ///
        /// 创建指定类型的策略。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest createPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyResponse>(response);
        }

        public AsyncInvoker<CreatePolicyResponse> CreatePolicyAsyncInvoker(CreatePolicyRequest createPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyRequest);
            return new AsyncInvoker<CreatePolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyResponse>);
        }
        
        /// <summary>
        /// 删除策略
        ///
        /// 从组织中删除指定的策略。在执行此操作之前，必须首先将策略跟所有组织单元、根和账号解绑。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest deletePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", deletePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyResponse>(response);
        }

        public AsyncInvoker<DeletePolicyResponse> DeletePolicyAsyncInvoker(DeletePolicyRequest deletePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", deletePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            return new AsyncInvoker<DeletePolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyResponse>);
        }
        
        /// <summary>
        /// 将策略跟实体解绑
        ///
        /// 从根、组织单元或账号解绑策略。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetachPolicyResponse> DetachPolicyAsync(DetachPolicyRequest detachPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", detachPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}/detach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DetachPolicyResponse>(response);
        }

        public AsyncInvoker<DetachPolicyResponse> DetachPolicyAsyncInvoker(DetachPolicyRequest detachPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", detachPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}/detach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachPolicyRequest);
            return new AsyncInvoker<DetachPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DetachPolicyResponse>);
        }
        
        /// <summary>
        /// 禁用根中的策略类型
        ///
        /// 禁用根中的策略类型。只有在根中启用了特定类型的策略，才能将该类型的策略绑定到根中的实体。执行此操作后，您不能再将指定类型的策略绑定到该根或该根中的任何组织单元或账号。这是在后台执行的异步请求。您可以使用ListRoots查看指定根的策略类型的状态。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisablePolicyTypeResponse> DisablePolicyTypeAsync(DisablePolicyTypeRequest disablePolicyTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disablePolicyTypeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisablePolicyTypeResponse>(response);
        }

        public AsyncInvoker<DisablePolicyTypeResponse> DisablePolicyTypeAsyncInvoker(DisablePolicyTypeRequest disablePolicyTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disablePolicyTypeRequest);
            return new AsyncInvoker<DisablePolicyTypeResponse>(this, "POST", request, JsonUtils.DeSerialize<DisablePolicyTypeResponse>);
        }
        
        /// <summary>
        /// 在根中启用策略类型
        ///
        /// 在根中启用策略类型。在根中启用策略类型后，您可以将该类型的策略绑定到根、或该根中的任何组织单元和账号。这是在后台执行的异步请求。您可以使用ListRoots查看指定根的策略类型的状态。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnablePolicyTypeResponse> EnablePolicyTypeAsync(EnablePolicyTypeRequest enablePolicyTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enablePolicyTypeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EnablePolicyTypeResponse>(response);
        }

        public AsyncInvoker<EnablePolicyTypeResponse> EnablePolicyTypeAsyncInvoker(EnablePolicyTypeRequest enablePolicyTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enablePolicyTypeRequest);
            return new AsyncInvoker<EnablePolicyTypeResponse>(this, "POST", request, JsonUtils.DeSerialize<EnablePolicyTypeResponse>);
        }
        
        /// <summary>
        /// 列出跟指定策略绑定的所有实体
        ///
        /// 列出跟指定策略绑定的所有根、组织单元和账号。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEntitiesForPolicyResponse> ListEntitiesForPolicyAsync(ListEntitiesForPolicyRequest listEntitiesForPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", listEntitiesForPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}/attached-entities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEntitiesForPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEntitiesForPolicyResponse>(response);
        }

        public AsyncInvoker<ListEntitiesForPolicyResponse> ListEntitiesForPolicyAsyncInvoker(ListEntitiesForPolicyRequest listEntitiesForPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", listEntitiesForPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}/attached-entities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEntitiesForPolicyRequest);
            return new AsyncInvoker<ListEntitiesForPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEntitiesForPolicyResponse>);
        }
        
        /// <summary>
        /// 列出策略
        ///
        /// 列出组织中的所有策略。如果指定了资源ID，例如组织单元ID或账号ID，则将获得该资源已绑定的策略列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest listPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPoliciesResponse>(response);
        }

        public AsyncInvoker<ListPoliciesResponse> ListPoliciesAsyncInvoker(ListPoliciesRequest listPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesRequest);
            return new AsyncInvoker<ListPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询策略相关信息
        ///
        /// 检索策略的相关信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPolicyResponse> ShowPolicyAsync(ShowPolicyRequest showPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", showPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyResponse>(response);
        }

        public AsyncInvoker<ShowPolicyResponse> ShowPolicyAsyncInvoker(ShowPolicyRequest showPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", showPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            return new AsyncInvoker<ShowPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyResponse>);
        }
        
        /// <summary>
        /// 更新策略
        ///
        /// 更新策略，可以更新策略的名称、描述或内容。如果不提供任何参数，则策略将保持不变。您不能更改策略的类型。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest updatePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", updatePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePolicyResponse>(response);
        }

        public AsyncInvoker<UpdatePolicyResponse> UpdatePolicyAsyncInvoker(UpdatePolicyRequest updatePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", updatePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyRequest);
            return new AsyncInvoker<UpdatePolicyResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePolicyResponse>);
        }
        
        /// <summary>
        /// 为指定资源类型添加标签
        ///
        /// 向指定的资源类型添加一个或多个标签。目前，您可以将标签附加到组织中的账号、组织单元、根和策略。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTagResourceResponse> CreateTagResourceAsync(CreateTagResourceRequest createTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagResourceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagResourceResponse>(response);
        }

        public AsyncInvoker<CreateTagResourceResponse> CreateTagResourceAsyncInvoker(CreateTagResourceRequest createTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagResourceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagResourceRequest);
            return new AsyncInvoker<CreateTagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagResourceResponse>);
        }
        
        /// <summary>
        /// 从指定资源类型中删除指定主键标签
        ///
        /// 从指定资源类型中删除具有指定主键的任何标签。您可以将标签绑定到组织中的账号、组织单元、根和策略。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTagResourceResponse> DeleteTagResourceAsync(DeleteTagResourceRequest deleteTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteTagResourceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteTagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteTagResourceResponse>(response);
        }

        public AsyncInvoker<DeleteTagResourceResponse> DeleteTagResourceAsyncInvoker(DeleteTagResourceRequest deleteTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteTagResourceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteTagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagResourceRequest);
            return new AsyncInvoker<DeleteTagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteTagResourceResponse>);
        }
        
        /// <summary>
        /// 根据资源类型及标签信息查询实例列表
        ///
        /// 根据资源类型及标签信息查询实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceInstancesResponse> ListResourceInstancesAsync(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstancesRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }

        public AsyncInvoker<ListResourceInstancesResponse> ListResourceInstancesAsyncInvoker(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstancesRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceInstancesRequest);
            return new AsyncInvoker<ListResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceInstancesResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest listResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceTagsResponse>(response);
        }

        public AsyncInvoker<ListResourceTagsResponse> ListResourceTagsAsyncInvoker(ListResourceTagsRequest listResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            return new AsyncInvoker<ListResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceTagsResponse>);
        }
        
        /// <summary>
        /// 列出绑定到指定资源类型的标签
        ///
        /// 列出绑定到指定资源类型的标签。您可以将标签附加到组织中的账号、组织单元、根和策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest listTagResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagResourcesRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listTagResourcesRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagResourcesResponse>(response);
        }

        public AsyncInvoker<ListTagResourcesResponse> ListTagResourcesAsyncInvoker(ListTagResourcesRequest listTagResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagResourcesRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listTagResourcesRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagResourcesRequest);
            return new AsyncInvoker<ListTagResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagResourcesResponse>);
        }
        
        /// <summary>
        /// 列出绑定到指定资源的标签
        ///
        /// 列出绑定到指定资源的标签。您可以将标签附加到组织中的账号、组织单元、根和策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest listTagsForResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", listTagsForResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/resources/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsForResourceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagsForResourceResponse>(response);
        }

        public AsyncInvoker<ListTagsForResourceResponse> ListTagsForResourceAsyncInvoker(ListTagsForResourceRequest listTagsForResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", listTagsForResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/resources/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsForResourceRequest);
            return new AsyncInvoker<ListTagsForResourceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsForResourceResponse>);
        }
        
        /// <summary>
        /// 根据资源类型及标签信息查询实例数量
        ///
        /// 根据资源类型及标签信息查询实例数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceInstancesCountResponse> ShowResourceInstancesCountAsync(ShowResourceInstancesCountRequest showResourceInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", showResourceInstancesCountRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceInstancesCountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowResourceInstancesCountResponse>(response);
        }

        public AsyncInvoker<ShowResourceInstancesCountResponse> ShowResourceInstancesCountAsyncInvoker(ShowResourceInstancesCountRequest showResourceInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", showResourceInstancesCountRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceInstancesCountRequest);
            return new AsyncInvoker<ShowResourceInstancesCountResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowResourceInstancesCountResponse>);
        }
        
        /// <summary>
        /// 为指定资源添加标签
        ///
        /// 向指定的资源添加一个或多个标签。目前，您可以将标签附加到组织中的账号、组织单元、根和策略。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<TagResourceResponse> TagResourceAsync(TagResourceRequest tagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", tagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/resources/{resource_id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<TagResourceResponse>(response);
        }

        public AsyncInvoker<TagResourceResponse> TagResourceAsyncInvoker(TagResourceRequest tagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", tagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/resources/{resource_id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagResourceRequest);
            return new AsyncInvoker<TagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<TagResourceResponse>);
        }
        
        /// <summary>
        /// 从指定资源中删除指定主键标签
        ///
        /// 从指定资源中删除具有指定主键的任何标签。您可以将标签绑定到组织中的账号、组织单元、根和策略。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest untagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", untagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/resources/{resource_id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UntagResourceResponse>(response);
        }

        public AsyncInvoker<UntagResourceResponse> UntagResourceAsyncInvoker(UntagResourceRequest untagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", untagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/resources/{resource_id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagResourceRequest);
            return new AsyncInvoker<UntagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UntagResourceResponse>);
        }
        
        /// <summary>
        /// 禁用受信任服务
        ///
        /// 禁用服务（由service_principal指定的服务）与组织的集成。禁用可信服务后，指定服务将不可以在组织中的新账号中创建服务关联委托。这意味着该服务无法代表您对组织中的任何新账号执行操作。在服务完成从组织中的清理之前，服务仍可以在旧账号中执行操作。此接口只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableTrustedServiceResponse> DisableTrustedServiceAsync(DisableTrustedServiceRequest disableTrustedServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/trusted-services/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableTrustedServiceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisableTrustedServiceResponse>(response);
        }

        public AsyncInvoker<DisableTrustedServiceResponse> DisableTrustedServiceAsyncInvoker(DisableTrustedServiceRequest disableTrustedServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/trusted-services/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableTrustedServiceRequest);
            return new AsyncInvoker<DisableTrustedServiceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableTrustedServiceResponse>);
        }
        
        /// <summary>
        /// 启用可信服务
        ///
        /// 启用服务（由service_principal指定的服务）与组织的集成。启用可信服务后，允许指定的可信服务对组织中的所有账号创建服务关联委托。这允许可信服务代表您在组织及其账号中执行操作。此接口只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableTrustedServiceResponse> EnableTrustedServiceAsync(EnableTrustedServiceRequest enableTrustedServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/trusted-services/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableTrustedServiceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<EnableTrustedServiceResponse>(response);
        }

        public AsyncInvoker<EnableTrustedServiceResponse> EnableTrustedServiceAsyncInvoker(EnableTrustedServiceRequest enableTrustedServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/trusted-services/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableTrustedServiceRequest);
            return new AsyncInvoker<EnableTrustedServiceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableTrustedServiceResponse>);
        }
        
        /// <summary>
        /// 列出组织的可信服务列表
        ///
        /// 返回启用与组织集成的可信服务列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTrustedServicesResponse> ListTrustedServicesAsync(ListTrustedServicesRequest listTrustedServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/trusted-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrustedServicesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTrustedServicesResponse>(response);
        }

        public AsyncInvoker<ListTrustedServicesResponse> ListTrustedServicesAsyncInvoker(ListTrustedServicesRequest listTrustedServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/trusted-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrustedServicesRequest);
            return new AsyncInvoker<ListTrustedServicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrustedServicesResponse>);
        }
        
    }
}