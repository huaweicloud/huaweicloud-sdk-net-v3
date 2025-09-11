using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Organizations.V1.Model;

namespace HuaweiCloud.SDK.Organizations.V1
{
    public partial class OrganizationsClient : Client
    {
        public static ClientBuilder<OrganizationsClient> NewBuilder()
        {
            return new ClientBuilder<OrganizationsClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 关闭账号
        ///
        /// 关闭账号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CloseAccountResponse CloseAccount(CloseAccountRequest closeAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(closeAccountRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/close", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeAccountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CloseAccountResponse>(response);
        }

        public SyncInvoker<CloseAccountResponse> CloseAccountInvoker(CloseAccountRequest closeAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(closeAccountRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/close", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeAccountRequest);
            return new SyncInvoker<CloseAccountResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CloseAccountResponse>);
        }
        
        /// <summary>
        /// 创建账号
        ///
        /// 创建一个账号，生成的账号将自动成为调用此接口的账号所属组织的成员。此操作只能由组织的管理账号调用。组织云服务将在新账号中创建所需的服务关联委托和账号访问委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAccountResponse CreateAccount(CreateAccountRequest createAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAccountResponse>(response);
        }

        public SyncInvoker<CreateAccountResponse> CreateAccountInvoker(CreateAccountRequest createAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccountRequest);
            return new SyncInvoker<CreateAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccountResponse>);
        }
        
        /// <summary>
        /// 创建帐号
        ///
        /// 创建一个帐号，不携带手机号邮箱联系方式，生成的帐号将自动成为调用此接口的帐号所属组织的成员。此操作只能由组织的管理帐号调用。组织云服务将在新帐号中创建所需的服务关联委托和帐号访问委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateResourceAccountResponse CreateResourceAccount(CreateResourceAccountRequest createResourceAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/organizations/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceAccountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateResourceAccountResponse>(response);
        }

        public SyncInvoker<CreateResourceAccountResponse> CreateResourceAccountInvoker(CreateResourceAccountRequest createResourceAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/organizations/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceAccountRequest);
            return new SyncInvoker<CreateResourceAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResourceAccountResponse>);
        }
        
        /// <summary>
        /// 邀请账号加入组织
        ///
        /// 向另一个账号发送邀请，受邀账号将以成员账号加入您的组织。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public InviteAccountResponse InviteAccount(InviteAccountRequest inviteAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/invite", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteAccountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<InviteAccountResponse>(response);
        }

        public SyncInvoker<InviteAccountResponse> InviteAccountInvoker(InviteAccountRequest inviteAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/invite", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", inviteAccountRequest);
            return new SyncInvoker<InviteAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<InviteAccountResponse>);
        }
        
        /// <summary>
        /// 列出组织中的账号
        ///
        /// 列出组织中的账号。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。如果指定父级组织单元，则将获得作为父级直系子级的所有账号的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccountsResponse ListAccounts(ListAccountsRequest listAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccountsResponse>(response);
        }

        public SyncInvoker<ListAccountsResponse> ListAccountsInvoker(ListAccountsRequest listAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsRequest);
            return new SyncInvoker<ListAccountsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountsResponse>);
        }
        
        /// <summary>
        /// 列出关闭账号的状态
        ///
        /// 列出组织中指定状态的账号关闭请求。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCloseAccountStatusesResponse ListCloseAccountStatuses(ListCloseAccountStatusesRequest listCloseAccountStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/close-account-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloseAccountStatusesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCloseAccountStatusesResponse>(response);
        }

        public SyncInvoker<ListCloseAccountStatusesResponse> ListCloseAccountStatusesInvoker(ListCloseAccountStatusesRequest listCloseAccountStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/close-account-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloseAccountStatusesRequest);
            return new SyncInvoker<ListCloseAccountStatusesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloseAccountStatusesResponse>);
        }
        
        /// <summary>
        /// 列出创建账号的状态
        ///
        /// 列出组织中指定状态的账号创建请求。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCreateAccountStatusesResponse ListCreateAccountStatuses(ListCreateAccountStatusesRequest listCreateAccountStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/create-account-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCreateAccountStatusesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCreateAccountStatusesResponse>(response);
        }

        public SyncInvoker<ListCreateAccountStatusesResponse> ListCreateAccountStatusesInvoker(ListCreateAccountStatusesRequest listCreateAccountStatusesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/create-account-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCreateAccountStatusesRequest);
            return new SyncInvoker<ListCreateAccountStatusesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCreateAccountStatusesResponse>);
        }
        
        /// <summary>
        /// 移动账号
        ///
        /// 将账号从其当前源位置（根或组织单元）移动到指定的目标位置（根或组织单元）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MoveAccountResponse MoveAccount(MoveAccountRequest moveAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(moveAccountRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/move", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveAccountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<MoveAccountResponse>(response);
        }

        public SyncInvoker<MoveAccountResponse> MoveAccountInvoker(MoveAccountRequest moveAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(moveAccountRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/move", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", moveAccountRequest);
            return new SyncInvoker<MoveAccountResponse>(this, "POST", request, JsonUtils.DeSerializeNull<MoveAccountResponse>);
        }
        
        /// <summary>
        /// 移除指定的账号
        ///
        /// 从组织中移除指定的账号。移除的账号将成为一个独立账号，该账号不是任何组织的成员。此操作只能由组织的管理账号调用。只有当账号配置了作为独立账号运行所需的信息时，您才能从组织中移除账号。注意，要移除的账号不能是组织启用的任何服务的委托管理员账号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveAccountResponse RemoveAccount(RemoveAccountRequest removeAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeAccountRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeAccountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RemoveAccountResponse>(response);
        }

        public SyncInvoker<RemoveAccountResponse> RemoveAccountInvoker(RemoveAccountRequest removeAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeAccountRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/remove", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeAccountRequest);
            return new SyncInvoker<RemoveAccountResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RemoveAccountResponse>);
        }
        
        /// <summary>
        /// 查询账号信息
        ///
        /// 查询有关指定账号的信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAccountResponse ShowAccount(ShowAccountRequest showAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccountRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAccountResponse>(response);
        }

        public SyncInvoker<ShowAccountResponse> ShowAccountInvoker(ShowAccountRequest showAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccountRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccountRequest);
            return new SyncInvoker<ShowAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAccountResponse>);
        }
        
        /// <summary>
        /// 查询有关创建账号状态的信息
        ///
        /// 检索创建账号的异步请求的当前状态。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCreateAccountStatusResponse ShowCreateAccountStatus(ShowCreateAccountStatusRequest showCreateAccountStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCreateAccountStatusRequest.CreateAccountStatusId, out var valueOfCreateAccountStatusId)) urlParam.Add("create_account_status_id", valueOfCreateAccountStatusId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/create-account-status/{create_account_status_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCreateAccountStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCreateAccountStatusResponse>(response);
        }

        public SyncInvoker<ShowCreateAccountStatusResponse> ShowCreateAccountStatusInvoker(ShowCreateAccountStatusRequest showCreateAccountStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCreateAccountStatusRequest.CreateAccountStatusId, out var valueOfCreateAccountStatusId)) urlParam.Add("create_account_status_id", valueOfCreateAccountStatusId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/create-account-status/{create_account_status_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCreateAccountStatusRequest);
            return new SyncInvoker<ShowCreateAccountStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCreateAccountStatusResponse>);
        }
        
        /// <summary>
        /// 更新账号信息
        ///
        /// 更新指定的账号信息。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAccountResponse UpdateAccount(UpdateAccountRequest updateAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAccountRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccountRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateAccountResponse>(response);
        }

        public SyncInvoker<UpdateAccountResponse> UpdateAccountInvoker(UpdateAccountRequest updateAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAccountRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccountRequest);
            return new SyncInvoker<UpdateAccountResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateAccountResponse>);
        }
        
        /// <summary>
        /// 注销服务的委托管理员
        ///
        /// 删除指定成员账号作为指定服务的委托管理员。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeregisterDelegatedAdministratorResponse DeregisterDelegatedAdministrator(DeregisterDelegatedAdministratorRequest deregisterDelegatedAdministratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/delegated-administrators/deregister", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deregisterDelegatedAdministratorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeregisterDelegatedAdministratorResponse>(response);
        }

        public SyncInvoker<DeregisterDelegatedAdministratorResponse> DeregisterDelegatedAdministratorInvoker(DeregisterDelegatedAdministratorRequest deregisterDelegatedAdministratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/delegated-administrators/deregister", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deregisterDelegatedAdministratorRequest);
            return new SyncInvoker<DeregisterDelegatedAdministratorResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeregisterDelegatedAdministratorResponse>);
        }
        
        /// <summary>
        /// 列出此组织中指定为委托管理员的账号
        ///
        /// 列出在此组织中指定为委派管理员的账号。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDelegatedAdministratorsResponse ListDelegatedAdministrators(ListDelegatedAdministratorsRequest listDelegatedAdministratorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/delegated-administrators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDelegatedAdministratorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDelegatedAdministratorsResponse>(response);
        }

        public SyncInvoker<ListDelegatedAdministratorsResponse> ListDelegatedAdministratorsInvoker(ListDelegatedAdministratorsRequest listDelegatedAdministratorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/delegated-administrators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDelegatedAdministratorsRequest);
            return new SyncInvoker<ListDelegatedAdministratorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDelegatedAdministratorsResponse>);
        }
        
        /// <summary>
        /// 列出指定账号是其委托管理员的服务
        ///
        /// 列出指定账号是其委托管理员的服务。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDelegatedServicesResponse ListDelegatedServices(ListDelegatedServicesRequest listDelegatedServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDelegatedServicesRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/delegated-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDelegatedServicesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDelegatedServicesResponse>(response);
        }

        public SyncInvoker<ListDelegatedServicesResponse> ListDelegatedServicesInvoker(ListDelegatedServicesRequest listDelegatedServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDelegatedServicesRequest.AccountId, out var valueOfAccountId)) urlParam.Add("account_id", valueOfAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/accounts/{account_id}/delegated-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDelegatedServicesRequest);
            return new SyncInvoker<ListDelegatedServicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDelegatedServicesResponse>);
        }
        
        /// <summary>
        /// 注册作为服务委托管理员
        ///
        /// 指定成员账号能够管理指定服务的组织功能。此接口授予委托管理员对组织服务数据的只读访问权限。委托管理员账号中的IAM用户仍需要IAM权限才能访问和管理服务。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RegisterDelegatedAdministratorResponse RegisterDelegatedAdministrator(RegisterDelegatedAdministratorRequest registerDelegatedAdministratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/delegated-administrators/register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerDelegatedAdministratorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RegisterDelegatedAdministratorResponse>(response);
        }

        public SyncInvoker<RegisterDelegatedAdministratorResponse> RegisterDelegatedAdministratorInvoker(RegisterDelegatedAdministratorRequest registerDelegatedAdministratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/delegated-administrators/register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerDelegatedAdministratorRequest);
            return new SyncInvoker<RegisterDelegatedAdministratorResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RegisterDelegatedAdministratorResponse>);
        }
        
        /// <summary>
        /// 接受邀请
        ///
        /// 向邀请的发起方发送应答，接受加入组织邀请。在您接受邀请后，此邀请信息将继续保留并出现在相关API的返回结果中，保留期限为30天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AcceptHandshakeResponse AcceptHandshake(AcceptHandshakeRequest acceptHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(acceptHandshakeRequest.HandshakeId, out var valueOfHandshakeId)) urlParam.Add("handshake_id", valueOfHandshakeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/received-handshakes/{handshake_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptHandshakeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AcceptHandshakeResponse>(response);
        }

        public SyncInvoker<AcceptHandshakeResponse> AcceptHandshakeInvoker(AcceptHandshakeRequest acceptHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(acceptHandshakeRequest.HandshakeId, out var valueOfHandshakeId)) urlParam.Add("handshake_id", valueOfHandshakeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/received-handshakes/{handshake_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptHandshakeRequest);
            return new SyncInvoker<AcceptHandshakeResponse>(this, "POST", request, JsonUtils.DeSerialize<AcceptHandshakeResponse>);
        }
        
        /// <summary>
        /// 取消邀请
        ///
        /// 取消邀请，此时邀请状态将设置为已取消。此接口只能由发起邀请的账号调用。取消邀请后，此邀请信息将继续保留并出现在相关API的返回结果中，保留期限为30天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelHandshakeResponse CancelHandshake(CancelHandshakeRequest cancelHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelHandshakeRequest.HandshakeId, out var valueOfHandshakeId)) urlParam.Add("handshake_id", valueOfHandshakeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/handshakes/{handshake_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelHandshakeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CancelHandshakeResponse>(response);
        }

        public SyncInvoker<CancelHandshakeResponse> CancelHandshakeInvoker(CancelHandshakeRequest cancelHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelHandshakeRequest.HandshakeId, out var valueOfHandshakeId)) urlParam.Add("handshake_id", valueOfHandshakeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/handshakes/{handshake_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelHandshakeRequest);
            return new SyncInvoker<CancelHandshakeResponse>(this, "POST", request, JsonUtils.DeSerialize<CancelHandshakeResponse>);
        }
        
        /// <summary>
        /// 拒绝邀请
        ///
        /// 拒绝邀请请求。受邀账号拒绝邀请，此时当前邀请状态将设置为拒绝，邀请停止。此接口只能由受邀账号调用。邀请发起者无法再次激活被拒绝的邀请，但可以重新发送新的邀请。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeclineHandshakeResponse DeclineHandshake(DeclineHandshakeRequest declineHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(declineHandshakeRequest.HandshakeId, out var valueOfHandshakeId)) urlParam.Add("handshake_id", valueOfHandshakeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/received-handshakes/{handshake_id}/decline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", declineHandshakeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeclineHandshakeResponse>(response);
        }

        public SyncInvoker<DeclineHandshakeResponse> DeclineHandshakeInvoker(DeclineHandshakeRequest declineHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(declineHandshakeRequest.HandshakeId, out var valueOfHandshakeId)) urlParam.Add("handshake_id", valueOfHandshakeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/received-handshakes/{handshake_id}/decline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", declineHandshakeRequest);
            return new SyncInvoker<DeclineHandshakeResponse>(this, "POST", request, JsonUtils.DeSerialize<DeclineHandshakeResponse>);
        }
        
        /// <summary>
        /// 列出发送的邀请
        ///
        /// 列出所属组织发送的邀请。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHandshakesResponse ListHandshakes(ListHandshakesRequest listHandshakesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/handshakes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHandshakesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHandshakesResponse>(response);
        }

        public SyncInvoker<ListHandshakesResponse> ListHandshakesInvoker(ListHandshakesRequest listHandshakesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/handshakes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHandshakesRequest);
            return new SyncInvoker<ListHandshakesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHandshakesResponse>);
        }
        
        /// <summary>
        /// 列出收到的邀请
        ///
        /// 列出账号收到的所有邀请。此操作可以由任何账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListReceivedHandshakesResponse ListReceivedHandshakes(ListReceivedHandshakesRequest listReceivedHandshakesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/received-handshakes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReceivedHandshakesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListReceivedHandshakesResponse>(response);
        }

        public SyncInvoker<ListReceivedHandshakesResponse> ListReceivedHandshakesInvoker(ListReceivedHandshakesRequest listReceivedHandshakesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/received-handshakes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReceivedHandshakesRequest);
            return new SyncInvoker<ListReceivedHandshakesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReceivedHandshakesResponse>);
        }
        
        /// <summary>
        /// 查询邀请相关信息
        ///
        /// 查询组织中已有账号邀请的相关信息。此接口可以由组织中的任何账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHandshakeResponse ShowHandshake(ShowHandshakeRequest showHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHandshakeRequest.HandshakeId, out var valueOfHandshakeId)) urlParam.Add("handshake_id", valueOfHandshakeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/handshakes/{handshake_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHandshakeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHandshakeResponse>(response);
        }

        public SyncInvoker<ShowHandshakeResponse> ShowHandshakeInvoker(ShowHandshakeRequest showHandshakeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHandshakeRequest.HandshakeId, out var valueOfHandshakeId)) urlParam.Add("handshake_id", valueOfHandshakeId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/handshakes/{handshake_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHandshakeRequest);
            return new SyncInvoker<ShowHandshakeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHandshakeResponse>);
        }
        
        /// <summary>
        /// 列出组织中的根、组织单元和账号
        ///
        /// 列出组织中包含的所有根、组织单元和账号。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。您可以通过指定父ID和子ID参数来过滤实体。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEntitiesResponse ListEntities(ListEntitiesRequest listEntitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/entities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEntitiesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEntitiesResponse>(response);
        }

        public SyncInvoker<ListEntitiesResponse> ListEntitiesInvoker(ListEntitiesRequest listEntitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/entities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEntitiesRequest);
            return new SyncInvoker<ListEntitiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEntitiesResponse>);
        }
        
        /// <summary>
        /// 列出租户的组织配额
        ///
        /// 列出租户的组织配额。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQuotasResponse ListQuotas(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }

        public SyncInvoker<ListQuotasResponse> ListQuotasInvoker(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            return new SyncInvoker<ListQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotasResponse>);
        }
        
        /// <summary>
        /// 列出所有可以与组织服务集成的云服务
        ///
        /// 列出所有可以与组织服务集成的云服务。集成后云服务将成为组织的可信服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServicesResponse ListServices(ListServicesRequest listServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServicesResponse>(response);
        }

        public SyncInvoker<ListServicesResponse> ListServicesInvoker(ListServicesRequest listServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicesRequest);
            return new SyncInvoker<ListServicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServicesResponse>);
        }
        
        /// <summary>
        /// 列出被添加到标签策略强制执行的资源类型
        ///
        /// 列出被添加到标签策略强制执行的资源类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagPolicyServicesResponse ListTagPolicyServices(ListTagPolicyServicesRequest listTagPolicyServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/tag-policy-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagPolicyServicesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTagPolicyServicesResponse>(response);
        }

        public SyncInvoker<ListTagPolicyServicesResponse> ListTagPolicyServicesInvoker(ListTagPolicyServicesRequest listTagPolicyServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/tag-policy-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagPolicyServicesRequest);
            return new SyncInvoker<ListTagPolicyServicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagPolicyServicesResponse>);
        }
        
        /// <summary>
        /// 查询有效的策略
        ///
        /// 查询指定策略类型和账号的有效策略信息。当前此接口不支持查询服务控制策略（service_control_policy）。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEffectivePoliciesResponse ShowEffectivePolicies(ShowEffectivePoliciesRequest showEffectivePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/entities/effective-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEffectivePoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEffectivePoliciesResponse>(response);
        }

        public SyncInvoker<ShowEffectivePoliciesResponse> ShowEffectivePoliciesInvoker(ShowEffectivePoliciesRequest showEffectivePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/entities/effective-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEffectivePoliciesRequest);
            return new SyncInvoker<ShowEffectivePoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEffectivePoliciesResponse>);
        }
        
        /// <summary>
        /// 创建组织
        ///
        /// 创建组织。调用此接口的账号将自动成为新组织的管理账号，调用此接口的账号凭证必须是新组织管理账号的账号凭证。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOrganizationResponse CreateOrganization(CreateOrganizationRequest createOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOrganizationResponse>(response);
        }

        public SyncInvoker<CreateOrganizationResponse> CreateOrganizationInvoker(CreateOrganizationRequest createOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationRequest);
            return new SyncInvoker<CreateOrganizationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOrganizationResponse>);
        }
        
        /// <summary>
        /// 删除组织
        ///
        /// 删除组织。您必须使用管理账号才能删除组织，并且先移除组织中的所有账号、组织单元和策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteOrganizationResponse DeleteOrganization(DeleteOrganizationRequest deleteOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOrganizationResponse>(response);
        }

        public SyncInvoker<DeleteOrganizationResponse> DeleteOrganizationInvoker(DeleteOrganizationRequest deleteOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationRequest);
            return new SyncInvoker<DeleteOrganizationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOrganizationResponse>);
        }
        
        /// <summary>
        /// 离开当前组织
        ///
        /// 此操作只能由组织的成员账号调用。只有当组织账号配置了作为独立账号运行所需的信息时，您才能作为成员账号离开组织。要离开的账号不能是组织启用的任何服务的委托管理员账号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public LeaveOrganizationResponse LeaveOrganization(LeaveOrganizationRequest leaveOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/leave", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", leaveOrganizationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<LeaveOrganizationResponse>(response);
        }

        public SyncInvoker<LeaveOrganizationResponse> LeaveOrganizationInvoker(LeaveOrganizationRequest leaveOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/leave", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", leaveOrganizationRequest);
            return new SyncInvoker<LeaveOrganizationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<LeaveOrganizationResponse>);
        }
        
        /// <summary>
        /// 列出组织的根
        ///
        /// 列出当前组织的根。此接口只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRootsResponse ListRoots(ListRootsRequest listRootsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/roots", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRootsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRootsResponse>(response);
        }

        public SyncInvoker<ListRootsResponse> ListRootsInvoker(ListRootsRequest listRootsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/roots", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRootsRequest);
            return new SyncInvoker<ListRootsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRootsResponse>);
        }
        
        /// <summary>
        /// 查询所属组织信息
        ///
        /// 查询账号所属组织的信息。此操作可以由组织中的任何账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOrganizationResponse ShowOrganization(ShowOrganizationRequest showOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationResponse>(response);
        }

        public SyncInvoker<ShowOrganizationResponse> ShowOrganizationInvoker(ShowOrganizationRequest showOrganizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationRequest);
            return new SyncInvoker<ShowOrganizationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationResponse>);
        }
        
        /// <summary>
        /// 创建组织单元
        ///
        /// 在根或父组织单元中创建组织单元。组织单元是账号的容器，使您能够对账号进行分组管理，并根据业务要求应用策略。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOrganizationalUnitResponse CreateOrganizationalUnit(CreateOrganizationalUnitRequest createOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationalUnitRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOrganizationalUnitResponse>(response);
        }

        public SyncInvoker<CreateOrganizationalUnitResponse> CreateOrganizationalUnitInvoker(CreateOrganizationalUnitRequest createOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrganizationalUnitRequest);
            return new SyncInvoker<CreateOrganizationalUnitResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 删除组织单元
        ///
        /// 从根或其他组织单元中删除组织单元。前提是您必须先移除该组织单元中的所有成员账号或将成员账号移动至其他组织单元，必须删除该组织单元中的所有子组织单元。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteOrganizationalUnitResponse DeleteOrganizationalUnit(DeleteOrganizationalUnitRequest deleteOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationalUnitRequest.OrganizationalUnitId, out var valueOfOrganizationalUnitId)) urlParam.Add("organizational_unit_id", valueOfOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units/{organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationalUnitRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOrganizationalUnitResponse>(response);
        }

        public SyncInvoker<DeleteOrganizationalUnitResponse> DeleteOrganizationalUnitInvoker(DeleteOrganizationalUnitRequest deleteOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOrganizationalUnitRequest.OrganizationalUnitId, out var valueOfOrganizationalUnitId)) urlParam.Add("organizational_unit_id", valueOfOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units/{organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOrganizationalUnitRequest);
            return new SyncInvoker<DeleteOrganizationalUnitResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 列出组织单元
        ///
        /// 列出组织中的所有组织单元。如果指定父级组织单元，则将获得父级直系子级的组织单元列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOrganizationalUnitsResponse ListOrganizationalUnits(ListOrganizationalUnitsRequest listOrganizationalUnitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationalUnitsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOrganizationalUnitsResponse>(response);
        }

        public SyncInvoker<ListOrganizationalUnitsResponse> ListOrganizationalUnitsInvoker(ListOrganizationalUnitsRequest listOrganizationalUnitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrganizationalUnitsRequest);
            return new SyncInvoker<ListOrganizationalUnitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrganizationalUnitsResponse>);
        }
        
        /// <summary>
        /// 查询有关组织单元的信息
        ///
        /// 查询有关组织单元的信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOrganizationalUnitResponse ShowOrganizationalUnit(ShowOrganizationalUnitRequest showOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationalUnitRequest.OrganizationalUnitId, out var valueOfOrganizationalUnitId)) urlParam.Add("organizational_unit_id", valueOfOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units/{organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationalUnitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationalUnitResponse>(response);
        }

        public SyncInvoker<ShowOrganizationalUnitResponse> ShowOrganizationalUnitInvoker(ShowOrganizationalUnitRequest showOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOrganizationalUnitRequest.OrganizationalUnitId, out var valueOfOrganizationalUnitId)) urlParam.Add("organizational_unit_id", valueOfOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units/{organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationalUnitRequest);
            return new SyncInvoker<ShowOrganizationalUnitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 更改组织单元名称
        ///
        /// 重命名指定的组织单元。重命名后组织单元ID不变，下属子组织单元和下属账号不变，组织单元绑定的策略不变。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateOrganizationalUnitResponse UpdateOrganizationalUnit(UpdateOrganizationalUnitRequest updateOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationalUnitRequest.OrganizationalUnitId, out var valueOfOrganizationalUnitId)) urlParam.Add("organizational_unit_id", valueOfOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units/{organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOrganizationalUnitRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateOrganizationalUnitResponse>(response);
        }

        public SyncInvoker<UpdateOrganizationalUnitResponse> UpdateOrganizationalUnitInvoker(UpdateOrganizationalUnitRequest updateOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOrganizationalUnitRequest.OrganizationalUnitId, out var valueOfOrganizationalUnitId)) urlParam.Add("organizational_unit_id", valueOfOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/organizational-units/{organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOrganizationalUnitRequest);
            return new SyncInvoker<UpdateOrganizationalUnitResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 将策略跟实体绑定
        ///
        /// 绑定策略到根、组织单元或个人账号。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachPolicyResponse AttachPolicy(AttachPolicyRequest attachPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}/attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AttachPolicyResponse>(response);
        }

        public SyncInvoker<AttachPolicyResponse> AttachPolicyInvoker(AttachPolicyRequest attachPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}/attach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachPolicyRequest);
            return new SyncInvoker<AttachPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AttachPolicyResponse>);
        }
        
        /// <summary>
        /// 创建策略
        ///
        /// 创建指定类型的策略。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePolicyResponse CreatePolicy(CreatePolicyRequest createPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyResponse>(response);
        }

        public SyncInvoker<CreatePolicyResponse> CreatePolicyInvoker(CreatePolicyRequest createPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyRequest);
            return new SyncInvoker<CreatePolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyResponse>);
        }
        
        /// <summary>
        /// 删除策略
        ///
        /// 从组织中删除指定的策略。在执行此操作之前，必须首先将策略跟所有组织单元、根和账号解绑。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest deletePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyResponse>(response);
        }

        public SyncInvoker<DeletePolicyResponse> DeletePolicyInvoker(DeletePolicyRequest deletePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            return new SyncInvoker<DeletePolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyResponse>);
        }
        
        /// <summary>
        /// 将策略跟实体解绑
        ///
        /// 从根、组织单元或账号解绑策略。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetachPolicyResponse DetachPolicy(DetachPolicyRequest detachPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}/detach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DetachPolicyResponse>(response);
        }

        public SyncInvoker<DetachPolicyResponse> DetachPolicyInvoker(DetachPolicyRequest detachPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}/detach", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachPolicyRequest);
            return new SyncInvoker<DetachPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DetachPolicyResponse>);
        }
        
        /// <summary>
        /// 禁用根中的策略类型
        ///
        /// 禁用根中的策略类型。只有在根中启用了特定类型的策略，才能将该类型的策略绑定到根中的实体。执行此操作后，您不能再将指定类型的策略绑定到该根或该根中的任何组织单元或账号。这是在后台执行的异步请求。您可以使用ListRoots查看指定根的策略类型的状态。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisablePolicyTypeResponse DisablePolicyType(DisablePolicyTypeRequest disablePolicyTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disablePolicyTypeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisablePolicyTypeResponse>(response);
        }

        public SyncInvoker<DisablePolicyTypeResponse> DisablePolicyTypeInvoker(DisablePolicyTypeRequest disablePolicyTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disablePolicyTypeRequest);
            return new SyncInvoker<DisablePolicyTypeResponse>(this, "POST", request, JsonUtils.DeSerialize<DisablePolicyTypeResponse>);
        }
        
        /// <summary>
        /// 在根中启用策略类型
        ///
        /// 在根中启用策略类型。在根中启用策略类型后，您可以将该类型的策略绑定到根、或该根中的任何组织单元和账号。这是在后台执行的异步请求。您可以使用ListRoots查看指定根的策略类型的状态。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnablePolicyTypeResponse EnablePolicyType(EnablePolicyTypeRequest enablePolicyTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enablePolicyTypeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnablePolicyTypeResponse>(response);
        }

        public SyncInvoker<EnablePolicyTypeResponse> EnablePolicyTypeInvoker(EnablePolicyTypeRequest enablePolicyTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enablePolicyTypeRequest);
            return new SyncInvoker<EnablePolicyTypeResponse>(this, "POST", request, JsonUtils.DeSerialize<EnablePolicyTypeResponse>);
        }
        
        /// <summary>
        /// 列出跟指定策略绑定的所有实体
        ///
        /// 列出跟指定策略绑定的所有根、组织单元和账号。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEntitiesForPolicyResponse ListEntitiesForPolicy(ListEntitiesForPolicyRequest listEntitiesForPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEntitiesForPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}/attached-entities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEntitiesForPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEntitiesForPolicyResponse>(response);
        }

        public SyncInvoker<ListEntitiesForPolicyResponse> ListEntitiesForPolicyInvoker(ListEntitiesForPolicyRequest listEntitiesForPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEntitiesForPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}/attached-entities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEntitiesForPolicyRequest);
            return new SyncInvoker<ListEntitiesForPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEntitiesForPolicyResponse>);
        }
        
        /// <summary>
        /// 列出策略
        ///
        /// 列出组织中的所有策略。如果指定了资源ID，例如组织单元ID或账号ID，则将获得该资源已绑定的策略列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPoliciesResponse ListPolicies(ListPoliciesRequest listPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPoliciesResponse>(response);
        }

        public SyncInvoker<ListPoliciesResponse> ListPoliciesInvoker(ListPoliciesRequest listPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesRequest);
            return new SyncInvoker<ListPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询策略相关信息
        ///
        /// 检索策略的相关信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPolicyResponse ShowPolicy(ShowPolicyRequest showPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyResponse>(response);
        }

        public SyncInvoker<ShowPolicyResponse> ShowPolicyInvoker(ShowPolicyRequest showPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            return new SyncInvoker<ShowPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyResponse>);
        }
        
        /// <summary>
        /// 更新策略
        ///
        /// 更新策略，可以更新策略的名称、描述或内容。如果不提供任何参数，则策略将保持不变。您不能更改策略的类型。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest updatePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePolicyResponse>(response);
        }

        public SyncInvoker<UpdatePolicyResponse> UpdatePolicyInvoker(UpdatePolicyRequest updatePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyRequest);
            return new SyncInvoker<UpdatePolicyResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePolicyResponse>);
        }
        
        /// <summary>
        /// 为指定资源类型添加标签
        ///
        /// 向指定的资源类型添加一个或多个标签。目前，您可以将标签附加到组织中的账号、组织单元、根和策略。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTagResourceResponse CreateTagResource(CreateTagResourceRequest createTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createTagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagResourceResponse>(response);
        }

        public SyncInvoker<CreateTagResourceResponse> CreateTagResourceInvoker(CreateTagResourceRequest createTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createTagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagResourceRequest);
            return new SyncInvoker<CreateTagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagResourceResponse>);
        }
        
        /// <summary>
        /// 从指定资源类型中删除指定主键标签
        ///
        /// 从指定资源类型中删除具有指定主键的任何标签。您可以将标签绑定到组织中的账号、组织单元、根和策略。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTagResourceResponse DeleteTagResource(DeleteTagResourceRequest deleteTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteTagResourceResponse>(response);
        }

        public SyncInvoker<DeleteTagResourceResponse> DeleteTagResourceInvoker(DeleteTagResourceRequest deleteTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagResourceRequest);
            return new SyncInvoker<DeleteTagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteTagResourceResponse>);
        }
        
        /// <summary>
        /// 根据资源类型及标签信息查询实例列表
        ///
        /// 根据资源类型及标签信息查询实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceInstancesResponse ListResourceInstances(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceInstancesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }

        public SyncInvoker<ListResourceInstancesResponse> ListResourceInstancesInvoker(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceInstancesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceInstancesRequest);
            return new SyncInvoker<ListResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceInstancesResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest listResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourceTagsResponse>(response);
        }

        public SyncInvoker<ListResourceTagsResponse> ListResourceTagsInvoker(ListResourceTagsRequest listResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            return new SyncInvoker<ListResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceTagsResponse>);
        }
        
        /// <summary>
        /// 列出绑定到指定资源类型的标签
        ///
        /// 列出绑定到指定资源类型的标签。您可以将标签附加到组织中的账号、组织单元、根和策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest listTagResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagResourcesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listTagResourcesRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTagResourcesResponse>(response);
        }

        public SyncInvoker<ListTagResourcesResponse> ListTagResourcesInvoker(ListTagResourcesRequest listTagResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagResourcesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listTagResourcesRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagResourcesRequest);
            return new SyncInvoker<ListTagResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagResourcesResponse>);
        }
        
        /// <summary>
        /// 列出绑定到指定资源的标签
        ///
        /// 列出绑定到指定资源的标签。您可以将标签附加到组织中的账号、组织单元、根和策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest listTagsForResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsForResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/resources/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsForResourceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTagsForResourceResponse>(response);
        }

        public SyncInvoker<ListTagsForResourceResponse> ListTagsForResourceInvoker(ListTagsForResourceRequest listTagsForResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsForResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/resources/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsForResourceRequest);
            return new SyncInvoker<ListTagsForResourceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsForResourceResponse>);
        }
        
        /// <summary>
        /// 根据资源类型及标签信息查询实例数量
        ///
        /// 根据资源类型及标签信息查询实例数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceInstancesCountResponse ShowResourceInstancesCount(ShowResourceInstancesCountRequest showResourceInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceInstancesCountRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceInstancesCountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowResourceInstancesCountResponse>(response);
        }

        public SyncInvoker<ShowResourceInstancesCountResponse> ShowResourceInstancesCountInvoker(ShowResourceInstancesCountRequest showResourceInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceInstancesCountRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceInstancesCountRequest);
            return new SyncInvoker<ShowResourceInstancesCountResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowResourceInstancesCountResponse>);
        }
        
        /// <summary>
        /// 为指定资源添加标签
        ///
        /// 向指定的资源添加一个或多个标签。目前，您可以将标签附加到组织中的账号、组织单元、根和策略。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public TagResourceResponse TagResource(TagResourceRequest tagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(tagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/resources/{resource_id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<TagResourceResponse>(response);
        }

        public SyncInvoker<TagResourceResponse> TagResourceInvoker(TagResourceRequest tagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(tagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/resources/{resource_id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagResourceRequest);
            return new SyncInvoker<TagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<TagResourceResponse>);
        }
        
        /// <summary>
        /// 从指定资源中删除指定主键标签
        ///
        /// 从指定资源中删除具有指定主键的任何标签。您可以将标签绑定到组织中的账号、组织单元、根和策略。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UntagResourceResponse UntagResource(UntagResourceRequest untagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(untagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/resources/{resource_id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UntagResourceResponse>(response);
        }

        public SyncInvoker<UntagResourceResponse> UntagResourceInvoker(UntagResourceRequest untagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(untagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/resources/{resource_id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagResourceRequest);
            return new SyncInvoker<UntagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UntagResourceResponse>);
        }
        
        /// <summary>
        /// 禁用受信任服务
        ///
        /// 禁用服务（由service_principal指定的服务）与组织的集成。禁用可信服务后，指定服务将不可以在组织中的新账号中创建服务关联委托。这意味着该服务无法代表您对组织中的任何新账号执行操作。在服务完成从组织中的清理之前，服务仍可以在旧账号中执行操作。此接口只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableTrustedServiceResponse DisableTrustedService(DisableTrustedServiceRequest disableTrustedServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/trusted-services/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableTrustedServiceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisableTrustedServiceResponse>(response);
        }

        public SyncInvoker<DisableTrustedServiceResponse> DisableTrustedServiceInvoker(DisableTrustedServiceRequest disableTrustedServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/trusted-services/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableTrustedServiceRequest);
            return new SyncInvoker<DisableTrustedServiceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableTrustedServiceResponse>);
        }
        
        /// <summary>
        /// 启用可信服务
        ///
        /// 启用服务（由service_principal指定的服务）与组织的集成。启用可信服务后，允许指定的可信服务对组织中的所有账号创建服务关联委托。这允许可信服务代表您在组织及其账号中执行操作。此接口只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableTrustedServiceResponse EnableTrustedService(EnableTrustedServiceRequest enableTrustedServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/trusted-services/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableTrustedServiceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnableTrustedServiceResponse>(response);
        }

        public SyncInvoker<EnableTrustedServiceResponse> EnableTrustedServiceInvoker(EnableTrustedServiceRequest enableTrustedServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/trusted-services/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableTrustedServiceRequest);
            return new SyncInvoker<EnableTrustedServiceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableTrustedServiceResponse>);
        }
        
        /// <summary>
        /// 列出组织的可信服务列表
        ///
        /// 返回启用与组织集成的可信服务列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTrustedServicesResponse ListTrustedServices(ListTrustedServicesRequest listTrustedServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/trusted-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrustedServicesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTrustedServicesResponse>(response);
        }

        public SyncInvoker<ListTrustedServicesResponse> ListTrustedServicesInvoker(ListTrustedServicesRequest listTrustedServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organizations/trusted-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrustedServicesRequest);
            return new SyncInvoker<ListTrustedServicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrustedServicesResponse>);
        }
        
    }
}