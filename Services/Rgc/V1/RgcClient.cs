using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Rgc.V1.Model;

namespace HuaweiCloud.SDK.Rgc.V1
{
    public partial class RgcClient : Client
    {
        public static ClientBuilder<RgcClient> NewBuilder()
        {
            return new ClientBuilder<RgcClient>();
        }

        
        /// <summary>
        /// 关闭控制策略
        ///
        /// 关闭组织下的某个单元的某个控制策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableControlResponse DisableControl(DisableControlRequest disableControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableControlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisableControlResponse>(response);
        }

        public SyncInvoker<DisableControlResponse> DisableControlInvoker(DisableControlRequest disableControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableControlRequest);
            return new SyncInvoker<DisableControlResponse>(this, "POST", request, JsonUtils.DeSerialize<DisableControlResponse>);
        }
        
        /// <summary>
        /// 开启控制策略
        ///
        /// 给组织下的某个单元开启某个控制策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableControlResponse EnableControl(EnableControlRequest enableControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableControlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnableControlResponse>(response);
        }

        public SyncInvoker<EnableControlResponse> EnableControlInvoker(EnableControlRequest enableControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableControlRequest);
            return new SyncInvoker<EnableControlResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableControlResponse>);
        }
        
        /// <summary>
        /// 列出注册OU下开启的控制策略
        ///
        /// 列出组织里某个注册OU开启的所有控制策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListControlsForOrganizationalUnitResponse ListControlsForOrganizationalUnit(ListControlsForOrganizationalUnitRequest listControlsForOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", listControlsForOrganizationalUnitRequest.ManagedOrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-organizational-units/{managed_organizational_unit_id}/controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlsForOrganizationalUnitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListControlsForOrganizationalUnitResponse>(response);
        }

        public SyncInvoker<ListControlsForOrganizationalUnitResponse> ListControlsForOrganizationalUnitInvoker(ListControlsForOrganizationalUnitRequest listControlsForOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", listControlsForOrganizationalUnitRequest.ManagedOrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-organizational-units/{managed_organizational_unit_id}/controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlsForOrganizationalUnitRequest);
            return new SyncInvoker<ListControlsForOrganizationalUnitResponse>(this, "GET", request, JsonUtils.DeSerialize<ListControlsForOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 列出开启的控制策略
        ///
        /// 列出组织里开启的所有控制策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnabledControlsResponse ListEnabledControls(ListEnabledControlsRequest listEnabledControlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/enabled-controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnabledControlsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEnabledControlsResponse>(response);
        }

        public SyncInvoker<ListEnabledControlsResponse> ListEnabledControlsInvoker(ListEnabledControlsRequest listEnabledControlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/enabled-controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnabledControlsRequest);
            return new SyncInvoker<ListEnabledControlsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnabledControlsResponse>);
        }
        
        /// <summary>
        /// 查询控制策略操作状态
        ///
        /// 根据操作ID查询返回指定ID的操作状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowControlOperateResponse ShowControlOperate(ShowControlOperateRequest showControlOperateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_control_status_id", showControlOperateRequest.OperationControlStatusId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/operation-control-status/{operation_control_status_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlOperateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowControlOperateResponse>(response);
        }

        public SyncInvoker<ShowControlOperateResponse> ShowControlOperateInvoker(ShowControlOperateRequest showControlOperateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_control_status_id", showControlOperateRequest.OperationControlStatusId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/operation-control-status/{operation_control_status_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlOperateRequest);
            return new SyncInvoker<ShowControlOperateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowControlOperateResponse>);
        }
        
        /// <summary>
        /// 创建账号
        ///
        /// 在组织里的某个注册OU下创建账号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAccountResponse CreateAccount(CreateAccountRequest createAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAccountResponse>(response);
        }

        public SyncInvoker<CreateAccountResponse> CreateAccountInvoker(CreateAccountRequest createAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccountRequest);
            return new SyncInvoker<CreateAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccountResponse>);
        }
        
        /// <summary>
        /// 注册OU
        ///
        /// 将组织里的某个OU注册到RGC服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RegisterOrganizationalUnitResponse RegisterOrganizationalUnit(RegisterOrganizationalUnitRequest registerOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organizational_unit_id", registerOrganizationalUnitRequest.OrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/organizational-units/{organizational_unit_id}/register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerOrganizationalUnitRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RegisterOrganizationalUnitResponse>(response);
        }

        public SyncInvoker<RegisterOrganizationalUnitResponse> RegisterOrganizationalUnitInvoker(RegisterOrganizationalUnitRequest registerOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organizational_unit_id", registerOrganizationalUnitRequest.OrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/organizational-units/{organizational_unit_id}/register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerOrganizationalUnitRequest);
            return new SyncInvoker<RegisterOrganizationalUnitResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 查询纳管账号信息
        ///
        /// 查询组织里某个纳管账号信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowManagedAccountResponse ShowManagedAccount(ShowManagedAccountRequest showManagedAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", showManagedAccountRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedAccountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowManagedAccountResponse>(response);
        }

        public SyncInvoker<ShowManagedAccountResponse> ShowManagedAccountInvoker(ShowManagedAccountRequest showManagedAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", showManagedAccountRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedAccountRequest);
            return new SyncInvoker<ShowManagedAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowManagedAccountResponse>);
        }
        
        /// <summary>
        /// 查询注册过程信息
        ///
        /// 查询在RGC服务里注册/取消注册的过程信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOperationResponse ShowOperation(ShowOperationRequest showOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_id", showOperationRequest.OperationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/{operation_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOperationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOperationResponse>(response);
        }

        public SyncInvoker<ShowOperationResponse> ShowOperationInvoker(ShowOperationRequest showOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_id", showOperationRequest.OperationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/{operation_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOperationRequest);
            return new SyncInvoker<ShowOperationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOperationResponse>);
        }
        
    }
}