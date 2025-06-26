using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Rgc.V1.Model;

namespace HuaweiCloud.SDK.Rgc.V1
{
    public partial class RgcAsyncClient : Client
    {
        public static ClientBuilder<RgcAsyncClient> NewBuilder()
        {
            return new ClientBuilder<RgcAsyncClient>();
        }

        
        /// <summary>
        /// 关闭控制策略
        ///
        /// 关闭组织下的某个单元的某个控制策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableControlResponse> DisableControlAsync(DisableControlRequest disableControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableControlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisableControlResponse>(response);
        }

        public AsyncInvoker<DisableControlResponse> DisableControlAsyncInvoker(DisableControlRequest disableControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableControlRequest);
            return new AsyncInvoker<DisableControlResponse>(this, "POST", request, JsonUtils.DeSerialize<DisableControlResponse>);
        }
        
        /// <summary>
        /// 开启控制策略
        ///
        /// 给组织下的某个单元开启某个控制策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableControlResponse> EnableControlAsync(EnableControlRequest enableControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableControlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EnableControlResponse>(response);
        }

        public AsyncInvoker<EnableControlResponse> EnableControlAsyncInvoker(EnableControlRequest enableControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableControlRequest);
            return new AsyncInvoker<EnableControlResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableControlResponse>);
        }
        
        /// <summary>
        /// 列出注册OU下开启的控制策略
        ///
        /// 列出组织里某个注册OU开启的所有控制策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListControlsForOrganizationalUnitResponse> ListControlsForOrganizationalUnitAsync(ListControlsForOrganizationalUnitRequest listControlsForOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", listControlsForOrganizationalUnitRequest.ManagedOrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-organizational-units/{managed_organizational_unit_id}/controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlsForOrganizationalUnitRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListControlsForOrganizationalUnitResponse>(response);
        }

        public AsyncInvoker<ListControlsForOrganizationalUnitResponse> ListControlsForOrganizationalUnitAsyncInvoker(ListControlsForOrganizationalUnitRequest listControlsForOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", listControlsForOrganizationalUnitRequest.ManagedOrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-organizational-units/{managed_organizational_unit_id}/controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlsForOrganizationalUnitRequest);
            return new AsyncInvoker<ListControlsForOrganizationalUnitResponse>(this, "GET", request, JsonUtils.DeSerialize<ListControlsForOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 列出开启的控制策略
        ///
        /// 列出组织里开启的所有控制策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnabledControlsResponse> ListEnabledControlsAsync(ListEnabledControlsRequest listEnabledControlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/enabled-controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnabledControlsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEnabledControlsResponse>(response);
        }

        public AsyncInvoker<ListEnabledControlsResponse> ListEnabledControlsAsyncInvoker(ListEnabledControlsRequest listEnabledControlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/enabled-controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnabledControlsRequest);
            return new AsyncInvoker<ListEnabledControlsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnabledControlsResponse>);
        }
        
        /// <summary>
        /// 查询控制策略操作状态
        ///
        /// 根据操作ID查询返回指定ID的操作状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowControlOperateResponse> ShowControlOperateAsync(ShowControlOperateRequest showControlOperateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_control_status_id", showControlOperateRequest.OperationControlStatusId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/operation-control-status/{operation_control_status_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlOperateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowControlOperateResponse>(response);
        }

        public AsyncInvoker<ShowControlOperateResponse> ShowControlOperateAsyncInvoker(ShowControlOperateRequest showControlOperateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_control_status_id", showControlOperateRequest.OperationControlStatusId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/operation-control-status/{operation_control_status_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlOperateRequest);
            return new AsyncInvoker<ShowControlOperateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowControlOperateResponse>);
        }
        
        /// <summary>
        /// 创建账号
        ///
        /// 在组织里的某个注册OU下创建账号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest createAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAccountResponse>(response);
        }

        public AsyncInvoker<CreateAccountResponse> CreateAccountAsyncInvoker(CreateAccountRequest createAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccountRequest);
            return new AsyncInvoker<CreateAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccountResponse>);
        }
        
        /// <summary>
        /// 注册OU
        ///
        /// 将组织里的某个OU注册到RGC服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RegisterOrganizationalUnitResponse> RegisterOrganizationalUnitAsync(RegisterOrganizationalUnitRequest registerOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organizational_unit_id", registerOrganizationalUnitRequest.OrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/organizational-units/{organizational_unit_id}/register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerOrganizationalUnitRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RegisterOrganizationalUnitResponse>(response);
        }

        public AsyncInvoker<RegisterOrganizationalUnitResponse> RegisterOrganizationalUnitAsyncInvoker(RegisterOrganizationalUnitRequest registerOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organizational_unit_id", registerOrganizationalUnitRequest.OrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/organizational-units/{organizational_unit_id}/register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerOrganizationalUnitRequest);
            return new AsyncInvoker<RegisterOrganizationalUnitResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 查询纳管账号信息
        ///
        /// 查询组织里某个纳管账号信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowManagedAccountResponse> ShowManagedAccountAsync(ShowManagedAccountRequest showManagedAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", showManagedAccountRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedAccountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowManagedAccountResponse>(response);
        }

        public AsyncInvoker<ShowManagedAccountResponse> ShowManagedAccountAsyncInvoker(ShowManagedAccountRequest showManagedAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", showManagedAccountRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedAccountRequest);
            return new AsyncInvoker<ShowManagedAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowManagedAccountResponse>);
        }
        
        /// <summary>
        /// 查询注册过程信息
        ///
        /// 查询在RGC服务里注册/取消注册的过程信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOperationResponse> ShowOperationAsync(ShowOperationRequest showOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_id", showOperationRequest.OperationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/{operation_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOperationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOperationResponse>(response);
        }

        public AsyncInvoker<ShowOperationResponse> ShowOperationAsyncInvoker(ShowOperationRequest showOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_id", showOperationRequest.OperationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/{operation_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOperationRequest);
            return new AsyncInvoker<ShowOperationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOperationResponse>);
        }
        
    }
}