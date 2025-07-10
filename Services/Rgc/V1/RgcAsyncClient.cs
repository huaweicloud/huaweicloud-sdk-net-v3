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
        /// 检测八大场景治理成熟度
        ///
        /// 检测八大场景治理成熟度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBestPracticeDetectResponse> CreateBestPracticeDetectAsync(CreateBestPracticeDetectRequest createBestPracticeDetectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBestPracticeDetectRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateBestPracticeDetectResponse>(response);
        }

        public AsyncInvoker<CreateBestPracticeDetectResponse> CreateBestPracticeDetectAsyncInvoker(CreateBestPracticeDetectRequest createBestPracticeDetectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBestPracticeDetectRequest);
            return new AsyncInvoker<CreateBestPracticeDetectResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateBestPracticeDetectResponse>);
        }
        
        /// <summary>
        /// 查询最近一次成功的治理成熟度检测的详情
        ///
        /// 查询最近一次成功的治理成熟度检测的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBestPracticeDetailsResponse> ShowBestPracticeDetailsAsync(ShowBestPracticeDetailsRequest showBestPracticeDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/detection-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBestPracticeDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showBestPracticeDetailsResponse = JsonUtils.DeSerializeNull<ShowBestPracticeDetailsResponse>(response);
            showBestPracticeDetailsResponse.Body = JsonUtils.DeSerializeList<BestPracticeCheckItemDetail>(response);
            return showBestPracticeDetailsResponse;
        }

        public AsyncInvoker<ShowBestPracticeDetailsResponse> ShowBestPracticeDetailsAsyncInvoker(ShowBestPracticeDetailsRequest showBestPracticeDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/detection-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBestPracticeDetailsRequest);
            return new AsyncInvoker<ShowBestPracticeDetailsResponse>(this, "GET", request, response =>
            {
                var showBestPracticeDetailsResponse = JsonUtils.DeSerializeNull<ShowBestPracticeDetailsResponse>(response);
                showBestPracticeDetailsResponse.Body = JsonUtils.DeSerializeList<BestPracticeCheckItemDetail>(response);
                return showBestPracticeDetailsResponse;
            });
        }
        
        /// <summary>
        /// 查询最近一次成功的治理成熟度检测的总览
        ///
        /// 查询最近一次成功的治理成熟度检测的总览。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBestPracticeOverviewResponse> ShowBestPracticeOverviewAsync(ShowBestPracticeOverviewRequest showBestPracticeOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/detection-overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBestPracticeOverviewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBestPracticeOverviewResponse>(response);
        }

        public AsyncInvoker<ShowBestPracticeOverviewResponse> ShowBestPracticeOverviewAsyncInvoker(ShowBestPracticeOverviewRequest showBestPracticeOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/detection-overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBestPracticeOverviewRequest);
            return new AsyncInvoker<ShowBestPracticeOverviewResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBestPracticeOverviewResponse>);
        }
        
        /// <summary>
        /// 查询最近一次的治理成熟度检测的状态
        ///
        /// 查询最近一次的治理成熟度检测的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBestPracticeStatusResponse> ShowBestPracticeStatusAsync(ShowBestPracticeStatusRequest showBestPracticeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBestPracticeStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBestPracticeStatusResponse>(response);
        }

        public AsyncInvoker<ShowBestPracticeStatusResponse> ShowBestPracticeStatusAsyncInvoker(ShowBestPracticeStatusRequest showBestPracticeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBestPracticeStatusRequest);
            return new AsyncInvoker<ShowBestPracticeStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBestPracticeStatusResponse>);
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
        /// 查询纳管账号的Config规则合规性信息
        ///
        /// 查询纳管账号的Config规则合规性信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigRuleCompliancesResponse> ListConfigRuleCompliancesAsync(ListConfigRuleCompliancesRequest listConfigRuleCompliancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", listConfigRuleCompliancesRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/config-rule-compliances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigRuleCompliancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConfigRuleCompliancesResponse>(response);
        }

        public AsyncInvoker<ListConfigRuleCompliancesResponse> ListConfigRuleCompliancesAsyncInvoker(ListConfigRuleCompliancesRequest listConfigRuleCompliancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", listConfigRuleCompliancesRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/config-rule-compliances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigRuleCompliancesRequest);
            return new AsyncInvoker<ListConfigRuleCompliancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigRuleCompliancesResponse>);
        }
        
        /// <summary>
        /// 列出不合规信息
        ///
        /// 列出组织里所有不合规的资源信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListControlViolationsResponse> ListControlViolationsAsync(ListControlViolationsRequest listControlViolationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/control-violations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlViolationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListControlViolationsResponse>(response);
        }

        public AsyncInvoker<ListControlViolationsResponse> ListControlViolationsAsyncInvoker(ListControlViolationsRequest listControlViolationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/control-violations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlViolationsRequest);
            return new AsyncInvoker<ListControlViolationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListControlViolationsResponse>);
        }
        
        /// <summary>
        /// 列出控制策略
        ///
        /// 列出RGC服务里所有的预置控制策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListControlsResponse> ListControlsAsync(ListControlsRequest listControlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListControlsResponse>(response);
        }

        public AsyncInvoker<ListControlsResponse> ListControlsAsyncInvoker(ListControlsRequest listControlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlsRequest);
            return new AsyncInvoker<ListControlsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListControlsResponse>);
        }
        
        /// <summary>
        /// 列出纳管账号下开启的控制策略
        ///
        /// 列出组织里某个纳管账号开启的所有控制策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListControlsForAccountResponse> ListControlsForAccountAsync(ListControlsForAccountRequest listControlsForAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", listControlsForAccountRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlsForAccountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListControlsForAccountResponse>(response);
        }

        public AsyncInvoker<ListControlsForAccountResponse> ListControlsForAccountAsyncInvoker(ListControlsForAccountRequest listControlsForAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", listControlsForAccountRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlsForAccountRequest);
            return new AsyncInvoker<ListControlsForAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ListControlsForAccountResponse>);
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
        /// 列出漂移信息
        ///
        /// 列出Landing Zone的所有漂移详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDriftDetailsResponse> ListDriftDetailsAsync(ListDriftDetailsRequest listDriftDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/drift-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDriftDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDriftDetailsResponse>(response);
        }

        public AsyncInvoker<ListDriftDetailsResponse> ListDriftDetailsAsyncInvoker(ListDriftDetailsRequest listDriftDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/drift-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDriftDetailsRequest);
            return new AsyncInvoker<ListDriftDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDriftDetailsResponse>);
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
        /// 查询纳管账号的外部Config规则合规性信息
        ///
        /// 查询纳管账号的外部Config规则合规性信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListExternalConfigRuleCompliancesResponse> ListExternalConfigRuleCompliancesAsync(ListExternalConfigRuleCompliancesRequest listExternalConfigRuleCompliancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", listExternalConfigRuleCompliancesRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/external-config-rule-compliances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalConfigRuleCompliancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListExternalConfigRuleCompliancesResponse>(response);
        }

        public AsyncInvoker<ListExternalConfigRuleCompliancesResponse> ListExternalConfigRuleCompliancesAsyncInvoker(ListExternalConfigRuleCompliancesRequest listExternalConfigRuleCompliancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", listExternalConfigRuleCompliancesRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/external-config-rule-compliances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalConfigRuleCompliancesRequest);
            return new AsyncInvoker<ListExternalConfigRuleCompliancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListExternalConfigRuleCompliancesResponse>);
        }
        
        /// <summary>
        /// 查询纳管账号的合规状态
        ///
        /// 查询组织里某个纳管账号的资源合规状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowComplianceStatusForAccountResponse> ShowComplianceStatusForAccountAsync(ShowComplianceStatusForAccountRequest showComplianceStatusForAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", showComplianceStatusForAccountRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/compliance-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComplianceStatusForAccountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowComplianceStatusForAccountResponse>(response);
        }

        public AsyncInvoker<ShowComplianceStatusForAccountResponse> ShowComplianceStatusForAccountAsyncInvoker(ShowComplianceStatusForAccountRequest showComplianceStatusForAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", showComplianceStatusForAccountRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/compliance-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComplianceStatusForAccountRequest);
            return new AsyncInvoker<ShowComplianceStatusForAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowComplianceStatusForAccountResponse>);
        }
        
        /// <summary>
        /// 查询注册OU的合规状态
        ///
        /// 查询组织里某个注册OU下所有纳管账号的资源合规状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowComplianceStatusForOrganizationalUnitResponse> ShowComplianceStatusForOrganizationalUnitAsync(ShowComplianceStatusForOrganizationalUnitRequest showComplianceStatusForOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", showComplianceStatusForOrganizationalUnitRequest.ManagedOrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-organizational-units/{managed_organizational_unit_id}/compliance-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComplianceStatusForOrganizationalUnitRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowComplianceStatusForOrganizationalUnitResponse>(response);
        }

        public AsyncInvoker<ShowComplianceStatusForOrganizationalUnitResponse> ShowComplianceStatusForOrganizationalUnitAsyncInvoker(ShowComplianceStatusForOrganizationalUnitRequest showComplianceStatusForOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", showComplianceStatusForOrganizationalUnitRequest.ManagedOrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-organizational-units/{managed_organizational_unit_id}/compliance-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComplianceStatusForOrganizationalUnitRequest);
            return new AsyncInvoker<ShowComplianceStatusForOrganizationalUnitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowComplianceStatusForOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 查询控制策略详细信息
        ///
        /// 查询单个预置的控制策略详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowControlResponse> ShowControlAsync(ShowControlRequest showControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("control_id", showControlRequest.ControlId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls/{control_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowControlResponse>(response);
        }

        public AsyncInvoker<ShowControlResponse> ShowControlAsyncInvoker(ShowControlRequest showControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("control_id", showControlRequest.ControlId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls/{control_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlRequest);
            return new AsyncInvoker<ShowControlResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowControlResponse>);
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
        /// 查询注册账号开启的控制策略
        ///
        /// 查询组织里某个注册账号下开启的某个控制策略的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowControlsForAccountResponse> ShowControlsForAccountAsync(ShowControlsForAccountRequest showControlsForAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", showControlsForAccountRequest.ManagedAccountId.ToString());
            urlParam.Add("control_id", showControlsForAccountRequest.ControlId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/controls/{control_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlsForAccountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowControlsForAccountResponse>(response);
        }

        public AsyncInvoker<ShowControlsForAccountResponse> ShowControlsForAccountAsyncInvoker(ShowControlsForAccountRequest showControlsForAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", showControlsForAccountRequest.ManagedAccountId.ToString());
            urlParam.Add("control_id", showControlsForAccountRequest.ControlId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/controls/{control_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlsForAccountRequest);
            return new AsyncInvoker<ShowControlsForAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowControlsForAccountResponse>);
        }
        
        /// <summary>
        /// 查询注册OU开启的控制策略
        ///
        /// 查询组织里某个注册OU下开启的某个控制策略的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowControlsForOrganizationalUnitResponse> ShowControlsForOrganizationalUnitAsync(ShowControlsForOrganizationalUnitRequest showControlsForOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", showControlsForOrganizationalUnitRequest.ManagedOrganizationalUnitId.ToString());
            urlParam.Add("control_id", showControlsForOrganizationalUnitRequest.ControlId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-organizational-units/{managed_organizational_unit_id}/controls/{control_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlsForOrganizationalUnitRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowControlsForOrganizationalUnitResponse>(response);
        }

        public AsyncInvoker<ShowControlsForOrganizationalUnitResponse> ShowControlsForOrganizationalUnitAsyncInvoker(ShowControlsForOrganizationalUnitRequest showControlsForOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", showControlsForOrganizationalUnitRequest.ManagedOrganizationalUnitId.ToString());
            urlParam.Add("control_id", showControlsForOrganizationalUnitRequest.ControlId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-organizational-units/{managed_organizational_unit_id}/controls/{control_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlsForOrganizationalUnitRequest);
            return new AsyncInvoker<ShowControlsForOrganizationalUnitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowControlsForOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 设置Landing Zone前检查
        ///
        /// 在设置Landing Zone之前，检查当前区域是否可以设置Landing Zone。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckLaunchResponse> CheckLaunchAsync(CheckLaunchRequest checkLaunchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/pre-launch-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkLaunchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CheckLaunchResponse>(response);
        }

        public AsyncInvoker<CheckLaunchResponse> CheckLaunchAsyncInvoker(CheckLaunchRequest checkLaunchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/pre-launch-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkLaunchRequest);
            return new AsyncInvoker<CheckLaunchResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CheckLaunchResponse>);
        }
        
        /// <summary>
        /// 删除Landing Zone
        ///
        /// 删除Landing Zone。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLandingZoneResponse> DeleteLandingZoneAsync(DeleteLandingZoneRequest deleteLandingZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLandingZoneRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteLandingZoneResponse>(response);
        }

        public AsyncInvoker<DeleteLandingZoneResponse> DeleteLandingZoneAsyncInvoker(DeleteLandingZoneRequest deleteLandingZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLandingZoneRequest);
            return new AsyncInvoker<DeleteLandingZoneResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteLandingZoneResponse>);
        }
        
        /// <summary>
        /// 设置Landing Zone
        ///
        /// 在当前区域创建或者更新Landing Zone。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetupLandingZoneResponse> SetupLandingZoneAsync(SetupLandingZoneRequest setupLandingZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/setup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setupLandingZoneRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SetupLandingZoneResponse>(response);
        }

        public AsyncInvoker<SetupLandingZoneResponse> SetupLandingZoneAsyncInvoker(SetupLandingZoneRequest setupLandingZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/setup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setupLandingZoneRequest);
            return new AsyncInvoker<SetupLandingZoneResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetupLandingZoneResponse>);
        }
        
        /// <summary>
        /// 查询Landing Zone可更新状态
        ///
        /// 查询Landing Zone当前是否需要升级更新。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAvailableUpdatesResponse> ShowAvailableUpdatesAsync(ShowAvailableUpdatesRequest showAvailableUpdatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/available-updates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableUpdatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAvailableUpdatesResponse>(response);
        }

        public AsyncInvoker<ShowAvailableUpdatesResponse> ShowAvailableUpdatesAsyncInvoker(ShowAvailableUpdatesRequest showAvailableUpdatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/available-updates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableUpdatesRequest);
            return new AsyncInvoker<ShowAvailableUpdatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAvailableUpdatesResponse>);
        }
        
        /// <summary>
        /// 查询主区域
        ///
        /// 查询Landing Zone的主区域。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHomeRegionResponse> ShowHomeRegionAsync(ShowHomeRegionRequest showHomeRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/home-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHomeRegionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHomeRegionResponse>(response);
        }

        public AsyncInvoker<ShowHomeRegionResponse> ShowHomeRegionAsyncInvoker(ShowHomeRegionRequest showHomeRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/home-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHomeRegionRequest);
            return new AsyncInvoker<ShowHomeRegionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHomeRegionResponse>);
        }
        
        /// <summary>
        /// 查询Landing Zone的配置
        ///
        /// 查询当前客户的Landing Zone的所有配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLandingZoneConfigurationResponse> ShowLandingZoneConfigurationAsync(ShowLandingZoneConfigurationRequest showLandingZoneConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLandingZoneConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLandingZoneConfigurationResponse>(response);
        }

        public AsyncInvoker<ShowLandingZoneConfigurationResponse> ShowLandingZoneConfigurationAsyncInvoker(ShowLandingZoneConfigurationRequest showLandingZoneConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLandingZoneConfigurationRequest);
            return new AsyncInvoker<ShowLandingZoneConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLandingZoneConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询当前客户的Identity Center用户信息
        ///
        /// 查询当前客户的Identity Center用户信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLandingZoneIdentityCenterResponse> ShowLandingZoneIdentityCenterAsync(ShowLandingZoneIdentityCenterRequest showLandingZoneIdentityCenterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/identity-center", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLandingZoneIdentityCenterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLandingZoneIdentityCenterResponse>(response);
        }

        public AsyncInvoker<ShowLandingZoneIdentityCenterResponse> ShowLandingZoneIdentityCenterAsyncInvoker(ShowLandingZoneIdentityCenterRequest showLandingZoneIdentityCenterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/identity-center", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLandingZoneIdentityCenterRequest);
            return new AsyncInvoker<ShowLandingZoneIdentityCenterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLandingZoneIdentityCenterResponse>);
        }
        
        /// <summary>
        /// 查询Landing Zone设置状态
        ///
        /// 查询Landing Zone的设置状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLandingZoneStatusResponse> ShowLandingZoneStatusAsync(ShowLandingZoneStatusRequest showLandingZoneStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLandingZoneStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLandingZoneStatusResponse>(response);
        }

        public AsyncInvoker<ShowLandingZoneStatusResponse> ShowLandingZoneStatusAsyncInvoker(ShowLandingZoneStatusRequest showLandingZoneStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLandingZoneStatusRequest);
            return new AsyncInvoker<ShowLandingZoneStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLandingZoneStatusResponse>);
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
        /// 创建OU
        ///
        /// 通过RGC服务在组织下创建OU，创建后的OU在RGC中状态为已注册。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateManagedOrganizationalUnitResponse> CreateManagedOrganizationalUnitAsync(CreateManagedOrganizationalUnitRequest createManagedOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManagedOrganizationalUnitRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateManagedOrganizationalUnitResponse>(response);
        }

        public AsyncInvoker<CreateManagedOrganizationalUnitResponse> CreateManagedOrganizationalUnitAsyncInvoker(CreateManagedOrganizationalUnitRequest createManagedOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManagedOrganizationalUnitRequest);
            return new AsyncInvoker<CreateManagedOrganizationalUnitResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateManagedOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 删除注册OU
        ///
        /// 在组织里删除已注册OU。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteManagedOrganizationalUnitsResponse> DeleteManagedOrganizationalUnitsAsync(DeleteManagedOrganizationalUnitsRequest deleteManagedOrganizationalUnitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", deleteManagedOrganizationalUnitsRequest.ManagedOrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManagedOrganizationalUnitsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteManagedOrganizationalUnitsResponse>(response);
        }

        public AsyncInvoker<DeleteManagedOrganizationalUnitsResponse> DeleteManagedOrganizationalUnitsAsyncInvoker(DeleteManagedOrganizationalUnitsRequest deleteManagedOrganizationalUnitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", deleteManagedOrganizationalUnitsRequest.ManagedOrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManagedOrganizationalUnitsRequest);
            return new AsyncInvoker<DeleteManagedOrganizationalUnitsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteManagedOrganizationalUnitsResponse>);
        }
        
        /// <summary>
        /// 取消注册OU
        ///
        /// 将组织里的某个OU从RGC服务里取消注册。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeregisterOrganizationalUnitResponse> DeregisterOrganizationalUnitAsync(DeregisterOrganizationalUnitRequest deregisterOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", deregisterOrganizationalUnitRequest.ManagedOrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}/de-register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deregisterOrganizationalUnitRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeregisterOrganizationalUnitResponse>(response);
        }

        public AsyncInvoker<DeregisterOrganizationalUnitResponse> DeregisterOrganizationalUnitAsyncInvoker(DeregisterOrganizationalUnitRequest deregisterOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", deregisterOrganizationalUnitRequest.ManagedOrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}/de-register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deregisterOrganizationalUnitRequest);
            return new AsyncInvoker<DeregisterOrganizationalUnitResponse>(this, "POST", request, JsonUtils.DeSerialize<DeregisterOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 纳管账号
        ///
        /// 将组织里的某个账号纳管到RGC服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnrollAccountResponse> EnrollAccountAsync(EnrollAccountRequest enrollAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", enrollAccountRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/accounts/{managed_account_id}/enroll", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enrollAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EnrollAccountResponse>(response);
        }

        public AsyncInvoker<EnrollAccountResponse> EnrollAccountAsyncInvoker(EnrollAccountRequest enrollAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", enrollAccountRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/accounts/{managed_account_id}/enroll", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enrollAccountRequest);
            return new AsyncInvoker<EnrollAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<EnrollAccountResponse>);
        }
        
        /// <summary>
        /// 列举控制策略生效的纳管账号信息
        ///
        /// 列举控制策略生效的纳管账号信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListManagedAccountsResponse> ListManagedAccountsAsync(ListManagedAccountsRequest listManagedAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedAccountsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListManagedAccountsResponse>(response);
        }

        public AsyncInvoker<ListManagedAccountsResponse> ListManagedAccountsAsyncInvoker(ListManagedAccountsRequest listManagedAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedAccountsRequest);
            return new AsyncInvoker<ListManagedAccountsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListManagedAccountsResponse>);
        }
        
        /// <summary>
        /// 列出注册OU下的纳管账号信息
        ///
        /// 列出组织里某个注册OU下的所有纳管账号信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListManagedAccountsForParentResponse> ListManagedAccountsForParentAsync(ListManagedAccountsForParentRequest listManagedAccountsForParentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", listManagedAccountsForParentRequest.ManagedOrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}/managed-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedAccountsForParentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListManagedAccountsForParentResponse>(response);
        }

        public AsyncInvoker<ListManagedAccountsForParentResponse> ListManagedAccountsForParentAsyncInvoker(ListManagedAccountsForParentRequest listManagedAccountsForParentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", listManagedAccountsForParentRequest.ManagedOrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}/managed-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedAccountsForParentRequest);
            return new AsyncInvoker<ListManagedAccountsForParentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListManagedAccountsForParentResponse>);
        }
        
        /// <summary>
        /// 列举控制策略生效的注册OU信息
        ///
        /// 列举控制策略生效的注册OU信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListManagedOrganizationalUnitsResponse> ListManagedOrganizationalUnitsAsync(ListManagedOrganizationalUnitsRequest listManagedOrganizationalUnitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedOrganizationalUnitsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListManagedOrganizationalUnitsResponse>(response);
        }

        public AsyncInvoker<ListManagedOrganizationalUnitsResponse> ListManagedOrganizationalUnitsAsyncInvoker(ListManagedOrganizationalUnitsRequest listManagedOrganizationalUnitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedOrganizationalUnitsRequest);
            return new AsyncInvoker<ListManagedOrganizationalUnitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListManagedOrganizationalUnitsResponse>);
        }
        
        /// <summary>
        /// 查询已注册OU和纳管账号操作过程信息列表
        ///
        /// 查询在RGC服务里已注册OU和纳管账号操作的过程信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOperationResponse> ListOperationAsync(ListOperationRequest listOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOperationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOperationResponse>(response);
        }

        public AsyncInvoker<ListOperationResponse> ListOperationAsyncInvoker(ListOperationRequest listOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOperationRequest);
            return new AsyncInvoker<ListOperationResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOperationResponse>);
        }
        
        /// <summary>
        /// 重新注册OU
        ///
        /// 重新注册组织里的某个OU到RGC服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ReRegisterOrganizationalUnitResponse> ReRegisterOrganizationalUnitAsync(ReRegisterOrganizationalUnitRequest reRegisterOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organizational_unit_id", reRegisterOrganizationalUnitRequest.OrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/organizational-units/{organizational_unit_id}/re-register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reRegisterOrganizationalUnitRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ReRegisterOrganizationalUnitResponse>(response);
        }

        public AsyncInvoker<ReRegisterOrganizationalUnitResponse> ReRegisterOrganizationalUnitAsyncInvoker(ReRegisterOrganizationalUnitRequest reRegisterOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("organizational_unit_id", reRegisterOrganizationalUnitRequest.OrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/organizational-units/{organizational_unit_id}/re-register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reRegisterOrganizationalUnitRequest);
            return new AsyncInvoker<ReRegisterOrganizationalUnitResponse>(this, "POST", request, JsonUtils.DeSerialize<ReRegisterOrganizationalUnitResponse>);
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
        /// 查询纳管账号的模板信息
        ///
        /// 查询组织里某个纳管账号的模板信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowManagedAccountTemplateResponse> ShowManagedAccountTemplateAsync(ShowManagedAccountTemplateRequest showManagedAccountTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", showManagedAccountTemplateRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}/blueprint", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedAccountTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowManagedAccountTemplateResponse>(response);
        }

        public AsyncInvoker<ShowManagedAccountTemplateResponse> ShowManagedAccountTemplateAsyncInvoker(ShowManagedAccountTemplateRequest showManagedAccountTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", showManagedAccountTemplateRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}/blueprint", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedAccountTemplateRequest);
            return new AsyncInvoker<ShowManagedAccountTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowManagedAccountTemplateResponse>);
        }
        
        /// <summary>
        /// 列出核心纳管账号
        ///
        /// 列出组织里的所有核心纳管账号信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowManagedCoreAccountResponse> ShowManagedCoreAccountAsync(ShowManagedCoreAccountRequest showManagedCoreAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-core-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedCoreAccountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowManagedCoreAccountResponse>(response);
        }

        public AsyncInvoker<ShowManagedCoreAccountResponse> ShowManagedCoreAccountAsyncInvoker(ShowManagedCoreAccountRequest showManagedCoreAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-core-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedCoreAccountRequest);
            return new AsyncInvoker<ShowManagedCoreAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowManagedCoreAccountResponse>);
        }
        
        /// <summary>
        /// 查询已注册OU信息
        ///
        /// 查询在RGC服务里的注册OU信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowManagedOrganizationalUnitResponse> ShowManagedOrganizationalUnitAsync(ShowManagedOrganizationalUnitRequest showManagedOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", showManagedOrganizationalUnitRequest.ManagedOrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedOrganizationalUnitRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowManagedOrganizationalUnitResponse>(response);
        }

        public AsyncInvoker<ShowManagedOrganizationalUnitResponse> ShowManagedOrganizationalUnitAsyncInvoker(ShowManagedOrganizationalUnitRequest showManagedOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_organizational_unit_id", showManagedOrganizationalUnitRequest.ManagedOrganizationalUnitId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedOrganizationalUnitRequest);
            return new AsyncInvoker<ShowManagedOrganizationalUnitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowManagedOrganizationalUnitResponse>);
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
        
        /// <summary>
        /// 取消纳管账号
        ///
        /// 将组织里的某个账号从RGC服务里取消纳管。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UnEnrollAccountResponse> UnEnrollAccountAsync(UnEnrollAccountRequest unEnrollAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", unEnrollAccountRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}/un-enroll", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unEnrollAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UnEnrollAccountResponse>(response);
        }

        public AsyncInvoker<UnEnrollAccountResponse> UnEnrollAccountAsyncInvoker(UnEnrollAccountRequest unEnrollAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", unEnrollAccountRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}/un-enroll", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unEnrollAccountRequest);
            return new AsyncInvoker<UnEnrollAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<UnEnrollAccountResponse>);
        }
        
        /// <summary>
        /// 更新纳管账号
        ///
        /// 更新组织里某个已在RGC服务的纳管账号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateManagedAccountResponse> UpdateManagedAccountAsync(UpdateManagedAccountRequest updateManagedAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", updateManagedAccountRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateManagedAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateManagedAccountResponse>(response);
        }

        public AsyncInvoker<UpdateManagedAccountResponse> UpdateManagedAccountAsyncInvoker(UpdateManagedAccountRequest updateManagedAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("managed_account_id", updateManagedAccountRequest.ManagedAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateManagedAccountRequest);
            return new AsyncInvoker<UpdateManagedAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateManagedAccountResponse>);
        }
        
        /// <summary>
        /// 创建模板
        ///
        /// 创建RFS模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest createTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTemplateResponse>(response);
        }

        public AsyncInvoker<CreateTemplateResponse> CreateTemplateAsyncInvoker(CreateTemplateRequest createTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateRequest);
            return new AsyncInvoker<CreateTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemplateResponse>);
        }
        
        /// <summary>
        /// 删除模板
        ///
        /// 删除RFS模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest deleteTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_name", deleteTemplateRequest.TemplateName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/templates/{template_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteTemplateResponse> DeleteTemplateAsyncInvoker(DeleteTemplateRequest deleteTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_name", deleteTemplateRequest.TemplateName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/templates/{template_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            return new AsyncInvoker<DeleteTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTemplateResponse>);
        }
        
        /// <summary>
        /// 查询预置模板列表
        ///
        /// 查询预置模板列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPredefinedTemplatesResponse> ListPredefinedTemplatesAsync(ListPredefinedTemplatesRequest listPredefinedTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/predefined-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefinedTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPredefinedTemplatesResponse>(response);
        }

        public AsyncInvoker<ListPredefinedTemplatesResponse> ListPredefinedTemplatesAsyncInvoker(ListPredefinedTemplatesRequest listPredefinedTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/predefined-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefinedTemplatesRequest);
            return new AsyncInvoker<ListPredefinedTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPredefinedTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询模板的部署参数
        ///
        /// 查询模板的部署参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTemplateDeployParamsResponse> ShowTemplateDeployParamsAsync(ShowTemplateDeployParamsRequest showTemplateDeployParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_name", showTemplateDeployParamsRequest.TemplateName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/templates/{template_name}/deploy-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateDeployParamsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTemplateDeployParamsResponse>(response);
        }

        public AsyncInvoker<ShowTemplateDeployParamsResponse> ShowTemplateDeployParamsAsyncInvoker(ShowTemplateDeployParamsRequest showTemplateDeployParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_name", showTemplateDeployParamsRequest.TemplateName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/templates/{template_name}/deploy-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateDeployParamsRequest);
            return new AsyncInvoker<ShowTemplateDeployParamsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTemplateDeployParamsResponse>);
        }
        
    }
}