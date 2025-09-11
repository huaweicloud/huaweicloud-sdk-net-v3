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
        /// 检测八大场景治理成熟度
        ///
        /// 检测八大场景治理成熟度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBestPracticeDetectResponse CreateBestPracticeDetect(CreateBestPracticeDetectRequest createBestPracticeDetectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBestPracticeDetectRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateBestPracticeDetectResponse>(response);
        }

        public SyncInvoker<CreateBestPracticeDetectResponse> CreateBestPracticeDetectInvoker(CreateBestPracticeDetectRequest createBestPracticeDetectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBestPracticeDetectRequest);
            return new SyncInvoker<CreateBestPracticeDetectResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateBestPracticeDetectResponse>);
        }
        
        /// <summary>
        /// 查询治理成熟度的账号详情
        ///
        /// 查询治理成熟度的账号详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBestPracticeAccountInfoResponse ShowBestPracticeAccountInfo(ShowBestPracticeAccountInfoRequest showBestPracticeAccountInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/account-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBestPracticeAccountInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBestPracticeAccountInfoResponse>(response);
        }

        public SyncInvoker<ShowBestPracticeAccountInfoResponse> ShowBestPracticeAccountInfoInvoker(ShowBestPracticeAccountInfoRequest showBestPracticeAccountInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/account-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBestPracticeAccountInfoRequest);
            return new SyncInvoker<ShowBestPracticeAccountInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBestPracticeAccountInfoResponse>);
        }
        
        /// <summary>
        /// 查询最近一次成功的治理成熟度检测的详情
        ///
        /// 查询最近一次成功的治理成熟度检测的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBestPracticeDetailsResponse ShowBestPracticeDetails(ShowBestPracticeDetailsRequest showBestPracticeDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/detection-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBestPracticeDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            var showBestPracticeDetailsResponse = JsonUtils.DeSerializeNull<ShowBestPracticeDetailsResponse>(response);
            showBestPracticeDetailsResponse.Body = JsonUtils.DeSerializeList<BestPracticeCheckItemDetail>(response);
            return showBestPracticeDetailsResponse;
        }

        public SyncInvoker<ShowBestPracticeDetailsResponse> ShowBestPracticeDetailsInvoker(ShowBestPracticeDetailsRequest showBestPracticeDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/detection-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBestPracticeDetailsRequest);
            return new SyncInvoker<ShowBestPracticeDetailsResponse>(this, "GET", request, response =>
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
        public ShowBestPracticeOverviewResponse ShowBestPracticeOverview(ShowBestPracticeOverviewRequest showBestPracticeOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/detection-overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBestPracticeOverviewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBestPracticeOverviewResponse>(response);
        }

        public SyncInvoker<ShowBestPracticeOverviewResponse> ShowBestPracticeOverviewInvoker(ShowBestPracticeOverviewRequest showBestPracticeOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/detection-overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBestPracticeOverviewRequest);
            return new SyncInvoker<ShowBestPracticeOverviewResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBestPracticeOverviewResponse>);
        }
        
        /// <summary>
        /// 查询最近一次的治理成熟度检测的状态
        ///
        /// 查询最近一次的治理成熟度检测的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBestPracticeStatusResponse ShowBestPracticeStatus(ShowBestPracticeStatusRequest showBestPracticeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBestPracticeStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBestPracticeStatusResponse>(response);
        }

        public SyncInvoker<ShowBestPracticeStatusResponse> ShowBestPracticeStatusInvoker(ShowBestPracticeStatusRequest showBestPracticeStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/best-practice/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBestPracticeStatusRequest);
            return new SyncInvoker<ShowBestPracticeStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBestPracticeStatusResponse>);
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
        /// 查询纳管账号的Config规则合规性信息
        ///
        /// 查询纳管账号的Config规则合规性信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConfigRuleCompliancesResponse ListConfigRuleCompliances(ListConfigRuleCompliancesRequest listConfigRuleCompliancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConfigRuleCompliancesRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/config-rule-compliances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigRuleCompliancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConfigRuleCompliancesResponse>(response);
        }

        public SyncInvoker<ListConfigRuleCompliancesResponse> ListConfigRuleCompliancesInvoker(ListConfigRuleCompliancesRequest listConfigRuleCompliancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConfigRuleCompliancesRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/config-rule-compliances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigRuleCompliancesRequest);
            return new SyncInvoker<ListConfigRuleCompliancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigRuleCompliancesResponse>);
        }
        
        /// <summary>
        /// 列出不合规信息
        ///
        /// 列出组织里所有不合规的资源信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListControlViolationsResponse ListControlViolations(ListControlViolationsRequest listControlViolationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/control-violations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlViolationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListControlViolationsResponse>(response);
        }

        public SyncInvoker<ListControlViolationsResponse> ListControlViolationsInvoker(ListControlViolationsRequest listControlViolationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/control-violations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlViolationsRequest);
            return new SyncInvoker<ListControlViolationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListControlViolationsResponse>);
        }
        
        /// <summary>
        /// 列出控制策略
        ///
        /// 列出RGC服务里所有的预置控制策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListControlsResponse ListControls(ListControlsRequest listControlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListControlsResponse>(response);
        }

        public SyncInvoker<ListControlsResponse> ListControlsInvoker(ListControlsRequest listControlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlsRequest);
            return new SyncInvoker<ListControlsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListControlsResponse>);
        }
        
        /// <summary>
        /// 列出纳管账号下开启的控制策略
        ///
        /// 列出组织里某个纳管账号开启的所有控制策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListControlsForAccountResponse ListControlsForAccount(ListControlsForAccountRequest listControlsForAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listControlsForAccountRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlsForAccountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListControlsForAccountResponse>(response);
        }

        public SyncInvoker<ListControlsForAccountResponse> ListControlsForAccountInvoker(ListControlsForAccountRequest listControlsForAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listControlsForAccountRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlsForAccountRequest);
            return new SyncInvoker<ListControlsForAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ListControlsForAccountResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listControlsForOrganizationalUnitRequest.ManagedOrganizationalUnitId, out var valueOfManagedOrganizationalUnitId)) urlParam.Add("managed_organizational_unit_id", valueOfManagedOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-organizational-units/{managed_organizational_unit_id}/controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlsForOrganizationalUnitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListControlsForOrganizationalUnitResponse>(response);
        }

        public SyncInvoker<ListControlsForOrganizationalUnitResponse> ListControlsForOrganizationalUnitInvoker(ListControlsForOrganizationalUnitRequest listControlsForOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listControlsForOrganizationalUnitRequest.ManagedOrganizationalUnitId, out var valueOfManagedOrganizationalUnitId)) urlParam.Add("managed_organizational_unit_id", valueOfManagedOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-organizational-units/{managed_organizational_unit_id}/controls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listControlsForOrganizationalUnitRequest);
            return new SyncInvoker<ListControlsForOrganizationalUnitResponse>(this, "GET", request, JsonUtils.DeSerialize<ListControlsForOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 列出漂移信息
        ///
        /// 列出Landing Zone的所有漂移详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDriftDetailsResponse ListDriftDetails(ListDriftDetailsRequest listDriftDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/drift-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDriftDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDriftDetailsResponse>(response);
        }

        public SyncInvoker<ListDriftDetailsResponse> ListDriftDetailsInvoker(ListDriftDetailsRequest listDriftDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/drift-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDriftDetailsRequest);
            return new SyncInvoker<ListDriftDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDriftDetailsResponse>);
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
        /// 查询纳管账号的外部Config规则合规性信息
        ///
        /// 查询纳管账号的外部Config规则合规性信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListExternalConfigRuleCompliancesResponse ListExternalConfigRuleCompliances(ListExternalConfigRuleCompliancesRequest listExternalConfigRuleCompliancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listExternalConfigRuleCompliancesRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/external-config-rule-compliances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalConfigRuleCompliancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListExternalConfigRuleCompliancesResponse>(response);
        }

        public SyncInvoker<ListExternalConfigRuleCompliancesResponse> ListExternalConfigRuleCompliancesInvoker(ListExternalConfigRuleCompliancesRequest listExternalConfigRuleCompliancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listExternalConfigRuleCompliancesRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/external-config-rule-compliances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalConfigRuleCompliancesRequest);
            return new SyncInvoker<ListExternalConfigRuleCompliancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListExternalConfigRuleCompliancesResponse>);
        }
        
        /// <summary>
        /// 查询纳管账号的合规状态
        ///
        /// 查询组织里某个纳管账号的资源合规状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowComplianceStatusForAccountResponse ShowComplianceStatusForAccount(ShowComplianceStatusForAccountRequest showComplianceStatusForAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showComplianceStatusForAccountRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/compliance-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComplianceStatusForAccountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowComplianceStatusForAccountResponse>(response);
        }

        public SyncInvoker<ShowComplianceStatusForAccountResponse> ShowComplianceStatusForAccountInvoker(ShowComplianceStatusForAccountRequest showComplianceStatusForAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showComplianceStatusForAccountRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/compliance-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComplianceStatusForAccountRequest);
            return new SyncInvoker<ShowComplianceStatusForAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowComplianceStatusForAccountResponse>);
        }
        
        /// <summary>
        /// 查询注册OU的合规状态
        ///
        /// 查询组织里某个注册OU下所有纳管账号的资源合规状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowComplianceStatusForOrganizationalUnitResponse ShowComplianceStatusForOrganizationalUnit(ShowComplianceStatusForOrganizationalUnitRequest showComplianceStatusForOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showComplianceStatusForOrganizationalUnitRequest.ManagedOrganizationalUnitId, out var valueOfManagedOrganizationalUnitId)) urlParam.Add("managed_organizational_unit_id", valueOfManagedOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-organizational-units/{managed_organizational_unit_id}/compliance-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComplianceStatusForOrganizationalUnitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowComplianceStatusForOrganizationalUnitResponse>(response);
        }

        public SyncInvoker<ShowComplianceStatusForOrganizationalUnitResponse> ShowComplianceStatusForOrganizationalUnitInvoker(ShowComplianceStatusForOrganizationalUnitRequest showComplianceStatusForOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showComplianceStatusForOrganizationalUnitRequest.ManagedOrganizationalUnitId, out var valueOfManagedOrganizationalUnitId)) urlParam.Add("managed_organizational_unit_id", valueOfManagedOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-organizational-units/{managed_organizational_unit_id}/compliance-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComplianceStatusForOrganizationalUnitRequest);
            return new SyncInvoker<ShowComplianceStatusForOrganizationalUnitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowComplianceStatusForOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 查询控制策略详细信息
        ///
        /// 查询单个预置的控制策略详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowControlResponse ShowControl(ShowControlRequest showControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showControlRequest.ControlId, out var valueOfControlId)) urlParam.Add("control_id", valueOfControlId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls/{control_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowControlResponse>(response);
        }

        public SyncInvoker<ShowControlResponse> ShowControlInvoker(ShowControlRequest showControlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showControlRequest.ControlId, out var valueOfControlId)) urlParam.Add("control_id", valueOfControlId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/controls/{control_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlRequest);
            return new SyncInvoker<ShowControlResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowControlResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showControlOperateRequest.OperationControlStatusId, out var valueOfOperationControlStatusId)) urlParam.Add("operation_control_status_id", valueOfOperationControlStatusId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/operation-control-status/{operation_control_status_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlOperateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowControlOperateResponse>(response);
        }

        public SyncInvoker<ShowControlOperateResponse> ShowControlOperateInvoker(ShowControlOperateRequest showControlOperateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showControlOperateRequest.OperationControlStatusId, out var valueOfOperationControlStatusId)) urlParam.Add("operation_control_status_id", valueOfOperationControlStatusId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/operation-control-status/{operation_control_status_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlOperateRequest);
            return new SyncInvoker<ShowControlOperateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowControlOperateResponse>);
        }
        
        /// <summary>
        /// 查询纳管账号开启的控制策略
        ///
        /// 查询组织里某个纳管账号下开启的某个控制策略的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowControlsForAccountResponse ShowControlsForAccount(ShowControlsForAccountRequest showControlsForAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showControlsForAccountRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            if (StringUtils.TryConvertToNonEmptyString(showControlsForAccountRequest.ControlId, out var valueOfControlId)) urlParam.Add("control_id", valueOfControlId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/controls/{control_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlsForAccountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowControlsForAccountResponse>(response);
        }

        public SyncInvoker<ShowControlsForAccountResponse> ShowControlsForAccountInvoker(ShowControlsForAccountRequest showControlsForAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showControlsForAccountRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            if (StringUtils.TryConvertToNonEmptyString(showControlsForAccountRequest.ControlId, out var valueOfControlId)) urlParam.Add("control_id", valueOfControlId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-accounts/{managed_account_id}/controls/{control_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlsForAccountRequest);
            return new SyncInvoker<ShowControlsForAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowControlsForAccountResponse>);
        }
        
        /// <summary>
        /// 查询注册OU开启的控制策略
        ///
        /// 查询组织里某个注册OU下开启的某个控制策略的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowControlsForOrganizationalUnitResponse ShowControlsForOrganizationalUnit(ShowControlsForOrganizationalUnitRequest showControlsForOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showControlsForOrganizationalUnitRequest.ManagedOrganizationalUnitId, out var valueOfManagedOrganizationalUnitId)) urlParam.Add("managed_organizational_unit_id", valueOfManagedOrganizationalUnitId);
            if (StringUtils.TryConvertToNonEmptyString(showControlsForOrganizationalUnitRequest.ControlId, out var valueOfControlId)) urlParam.Add("control_id", valueOfControlId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-organizational-units/{managed_organizational_unit_id}/controls/{control_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlsForOrganizationalUnitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowControlsForOrganizationalUnitResponse>(response);
        }

        public SyncInvoker<ShowControlsForOrganizationalUnitResponse> ShowControlsForOrganizationalUnitInvoker(ShowControlsForOrganizationalUnitRequest showControlsForOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showControlsForOrganizationalUnitRequest.ManagedOrganizationalUnitId, out var valueOfManagedOrganizationalUnitId)) urlParam.Add("managed_organizational_unit_id", valueOfManagedOrganizationalUnitId);
            if (StringUtils.TryConvertToNonEmptyString(showControlsForOrganizationalUnitRequest.ControlId, out var valueOfControlId)) urlParam.Add("control_id", valueOfControlId);
            var urlPath = HttpUtils.AddUrlPath("/v1/governance/managed-organizational-units/{managed_organizational_unit_id}/controls/{control_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showControlsForOrganizationalUnitRequest);
            return new SyncInvoker<ShowControlsForOrganizationalUnitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowControlsForOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 设置Landing Zone前检查
        ///
        /// 在设置Landing Zone之前，检查当前区域是否可以设置Landing Zone。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckLaunchResponse CheckLaunch(CheckLaunchRequest checkLaunchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/pre-launch-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkLaunchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CheckLaunchResponse>(response);
        }

        public SyncInvoker<CheckLaunchResponse> CheckLaunchInvoker(CheckLaunchRequest checkLaunchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/pre-launch-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkLaunchRequest);
            return new SyncInvoker<CheckLaunchResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CheckLaunchResponse>);
        }
        
        /// <summary>
        /// 删除Landing Zone
        ///
        /// 删除Landing Zone。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLandingZoneResponse DeleteLandingZone(DeleteLandingZoneRequest deleteLandingZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLandingZoneRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteLandingZoneResponse>(response);
        }

        public SyncInvoker<DeleteLandingZoneResponse> DeleteLandingZoneInvoker(DeleteLandingZoneRequest deleteLandingZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLandingZoneRequest);
            return new SyncInvoker<DeleteLandingZoneResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteLandingZoneResponse>);
        }
        
        /// <summary>
        /// 设置Landing Zone
        ///
        /// 在当前区域创建或者更新Landing Zone。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetupLandingZoneResponse SetupLandingZone(SetupLandingZoneRequest setupLandingZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/setup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setupLandingZoneRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetupLandingZoneResponse>(response);
        }

        public SyncInvoker<SetupLandingZoneResponse> SetupLandingZoneInvoker(SetupLandingZoneRequest setupLandingZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/setup", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setupLandingZoneRequest);
            return new SyncInvoker<SetupLandingZoneResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetupLandingZoneResponse>);
        }
        
        /// <summary>
        /// 查询Landing Zone可更新状态
        ///
        /// 查询Landing Zone当前是否需要升级更新。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAvailableUpdatesResponse ShowAvailableUpdates(ShowAvailableUpdatesRequest showAvailableUpdatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/available-updates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableUpdatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAvailableUpdatesResponse>(response);
        }

        public SyncInvoker<ShowAvailableUpdatesResponse> ShowAvailableUpdatesInvoker(ShowAvailableUpdatesRequest showAvailableUpdatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/available-updates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableUpdatesRequest);
            return new SyncInvoker<ShowAvailableUpdatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAvailableUpdatesResponse>);
        }
        
        /// <summary>
        /// 查询主区域
        ///
        /// 查询Landing Zone的主区域。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHomeRegionResponse ShowHomeRegion(ShowHomeRegionRequest showHomeRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/home-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHomeRegionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHomeRegionResponse>(response);
        }

        public SyncInvoker<ShowHomeRegionResponse> ShowHomeRegionInvoker(ShowHomeRegionRequest showHomeRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/home-region", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHomeRegionRequest);
            return new SyncInvoker<ShowHomeRegionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHomeRegionResponse>);
        }
        
        /// <summary>
        /// 查询Landing Zone的配置
        ///
        /// 查询当前客户的Landing Zone的所有配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLandingZoneConfigurationResponse ShowLandingZoneConfiguration(ShowLandingZoneConfigurationRequest showLandingZoneConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLandingZoneConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLandingZoneConfigurationResponse>(response);
        }

        public SyncInvoker<ShowLandingZoneConfigurationResponse> ShowLandingZoneConfigurationInvoker(ShowLandingZoneConfigurationRequest showLandingZoneConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLandingZoneConfigurationRequest);
            return new SyncInvoker<ShowLandingZoneConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLandingZoneConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询当前客户的Identity Center用户信息
        ///
        /// 查询当前客户的Identity Center用户信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLandingZoneIdentityCenterResponse ShowLandingZoneIdentityCenter(ShowLandingZoneIdentityCenterRequest showLandingZoneIdentityCenterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/identity-center", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLandingZoneIdentityCenterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLandingZoneIdentityCenterResponse>(response);
        }

        public SyncInvoker<ShowLandingZoneIdentityCenterResponse> ShowLandingZoneIdentityCenterInvoker(ShowLandingZoneIdentityCenterRequest showLandingZoneIdentityCenterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/identity-center", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLandingZoneIdentityCenterRequest);
            return new SyncInvoker<ShowLandingZoneIdentityCenterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLandingZoneIdentityCenterResponse>);
        }
        
        /// <summary>
        /// 查询Landing Zone设置状态
        ///
        /// 查询Landing Zone的设置状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLandingZoneStatusResponse ShowLandingZoneStatus(ShowLandingZoneStatusRequest showLandingZoneStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLandingZoneStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLandingZoneStatusResponse>(response);
        }

        public SyncInvoker<ShowLandingZoneStatusResponse> ShowLandingZoneStatusInvoker(ShowLandingZoneStatusRequest showLandingZoneStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/landing-zone/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLandingZoneStatusRequest);
            return new SyncInvoker<ShowLandingZoneStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLandingZoneStatusResponse>);
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
        /// 创建OU
        ///
        /// 通过RGC服务在组织下创建OU，创建后的OU在RGC中状态为已注册。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateManagedOrganizationalUnitResponse CreateManagedOrganizationalUnit(CreateManagedOrganizationalUnitRequest createManagedOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManagedOrganizationalUnitRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateManagedOrganizationalUnitResponse>(response);
        }

        public SyncInvoker<CreateManagedOrganizationalUnitResponse> CreateManagedOrganizationalUnitInvoker(CreateManagedOrganizationalUnitRequest createManagedOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManagedOrganizationalUnitRequest);
            return new SyncInvoker<CreateManagedOrganizationalUnitResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateManagedOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 删除注册OU
        ///
        /// 在组织里删除已注册OU。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteManagedOrganizationalUnitsResponse DeleteManagedOrganizationalUnits(DeleteManagedOrganizationalUnitsRequest deleteManagedOrganizationalUnitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteManagedOrganizationalUnitsRequest.ManagedOrganizationalUnitId, out var valueOfManagedOrganizationalUnitId)) urlParam.Add("managed_organizational_unit_id", valueOfManagedOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManagedOrganizationalUnitsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteManagedOrganizationalUnitsResponse>(response);
        }

        public SyncInvoker<DeleteManagedOrganizationalUnitsResponse> DeleteManagedOrganizationalUnitsInvoker(DeleteManagedOrganizationalUnitsRequest deleteManagedOrganizationalUnitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteManagedOrganizationalUnitsRequest.ManagedOrganizationalUnitId, out var valueOfManagedOrganizationalUnitId)) urlParam.Add("managed_organizational_unit_id", valueOfManagedOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteManagedOrganizationalUnitsRequest);
            return new SyncInvoker<DeleteManagedOrganizationalUnitsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteManagedOrganizationalUnitsResponse>);
        }
        
        /// <summary>
        /// 取消注册OU
        ///
        /// 将组织里的某个OU从RGC服务里取消注册。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeregisterOrganizationalUnitResponse DeregisterOrganizationalUnit(DeregisterOrganizationalUnitRequest deregisterOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deregisterOrganizationalUnitRequest.ManagedOrganizationalUnitId, out var valueOfManagedOrganizationalUnitId)) urlParam.Add("managed_organizational_unit_id", valueOfManagedOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}/de-register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deregisterOrganizationalUnitRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeregisterOrganizationalUnitResponse>(response);
        }

        public SyncInvoker<DeregisterOrganizationalUnitResponse> DeregisterOrganizationalUnitInvoker(DeregisterOrganizationalUnitRequest deregisterOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deregisterOrganizationalUnitRequest.ManagedOrganizationalUnitId, out var valueOfManagedOrganizationalUnitId)) urlParam.Add("managed_organizational_unit_id", valueOfManagedOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}/de-register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deregisterOrganizationalUnitRequest);
            return new SyncInvoker<DeregisterOrganizationalUnitResponse>(this, "POST", request, JsonUtils.DeSerialize<DeregisterOrganizationalUnitResponse>);
        }
        
        /// <summary>
        /// 纳管账号
        ///
        /// 将组织里的某个账号纳管到RGC服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnrollAccountResponse EnrollAccount(EnrollAccountRequest enrollAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enrollAccountRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/accounts/{managed_account_id}/enroll", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enrollAccountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnrollAccountResponse>(response);
        }

        public SyncInvoker<EnrollAccountResponse> EnrollAccountInvoker(EnrollAccountRequest enrollAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enrollAccountRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/accounts/{managed_account_id}/enroll", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enrollAccountRequest);
            return new SyncInvoker<EnrollAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<EnrollAccountResponse>);
        }
        
        /// <summary>
        /// 列举控制策略生效的纳管账号信息
        ///
        /// 列举控制策略生效的纳管账号信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListManagedAccountsResponse ListManagedAccounts(ListManagedAccountsRequest listManagedAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedAccountsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListManagedAccountsResponse>(response);
        }

        public SyncInvoker<ListManagedAccountsResponse> ListManagedAccountsInvoker(ListManagedAccountsRequest listManagedAccountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedAccountsRequest);
            return new SyncInvoker<ListManagedAccountsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListManagedAccountsResponse>);
        }
        
        /// <summary>
        /// 列出注册OU下的纳管账号信息
        ///
        /// 列出组织里某个注册OU下的所有纳管账号信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListManagedAccountsForParentResponse ListManagedAccountsForParent(ListManagedAccountsForParentRequest listManagedAccountsForParentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listManagedAccountsForParentRequest.ManagedOrganizationalUnitId, out var valueOfManagedOrganizationalUnitId)) urlParam.Add("managed_organizational_unit_id", valueOfManagedOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}/managed-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedAccountsForParentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListManagedAccountsForParentResponse>(response);
        }

        public SyncInvoker<ListManagedAccountsForParentResponse> ListManagedAccountsForParentInvoker(ListManagedAccountsForParentRequest listManagedAccountsForParentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listManagedAccountsForParentRequest.ManagedOrganizationalUnitId, out var valueOfManagedOrganizationalUnitId)) urlParam.Add("managed_organizational_unit_id", valueOfManagedOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}/managed-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedAccountsForParentRequest);
            return new SyncInvoker<ListManagedAccountsForParentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListManagedAccountsForParentResponse>);
        }
        
        /// <summary>
        /// 列举控制策略生效的注册OU信息
        ///
        /// 列举控制策略生效的注册OU信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListManagedOrganizationalUnitsResponse ListManagedOrganizationalUnits(ListManagedOrganizationalUnitsRequest listManagedOrganizationalUnitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedOrganizationalUnitsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListManagedOrganizationalUnitsResponse>(response);
        }

        public SyncInvoker<ListManagedOrganizationalUnitsResponse> ListManagedOrganizationalUnitsInvoker(ListManagedOrganizationalUnitsRequest listManagedOrganizationalUnitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedOrganizationalUnitsRequest);
            return new SyncInvoker<ListManagedOrganizationalUnitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListManagedOrganizationalUnitsResponse>);
        }
        
        /// <summary>
        /// 查询已注册OU和纳管账号操作过程信息列表
        ///
        /// 查询在RGC服务里已注册OU和纳管账号操作的过程信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOperationResponse ListOperation(ListOperationRequest listOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOperationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOperationResponse>(response);
        }

        public SyncInvoker<ListOperationResponse> ListOperationInvoker(ListOperationRequest listOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOperationRequest);
            return new SyncInvoker<ListOperationResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOperationResponse>);
        }
        
        /// <summary>
        /// 重新注册OU
        ///
        /// 重新注册组织里的某个OU到RGC服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ReRegisterOrganizationalUnitResponse ReRegisterOrganizationalUnit(ReRegisterOrganizationalUnitRequest reRegisterOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(reRegisterOrganizationalUnitRequest.OrganizationalUnitId, out var valueOfOrganizationalUnitId)) urlParam.Add("organizational_unit_id", valueOfOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/organizational-units/{organizational_unit_id}/re-register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reRegisterOrganizationalUnitRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ReRegisterOrganizationalUnitResponse>(response);
        }

        public SyncInvoker<ReRegisterOrganizationalUnitResponse> ReRegisterOrganizationalUnitInvoker(ReRegisterOrganizationalUnitRequest reRegisterOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(reRegisterOrganizationalUnitRequest.OrganizationalUnitId, out var valueOfOrganizationalUnitId)) urlParam.Add("organizational_unit_id", valueOfOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/organizational-units/{organizational_unit_id}/re-register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reRegisterOrganizationalUnitRequest);
            return new SyncInvoker<ReRegisterOrganizationalUnitResponse>(this, "POST", request, JsonUtils.DeSerialize<ReRegisterOrganizationalUnitResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(registerOrganizationalUnitRequest.OrganizationalUnitId, out var valueOfOrganizationalUnitId)) urlParam.Add("organizational_unit_id", valueOfOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/organizational-units/{organizational_unit_id}/register", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerOrganizationalUnitRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RegisterOrganizationalUnitResponse>(response);
        }

        public SyncInvoker<RegisterOrganizationalUnitResponse> RegisterOrganizationalUnitInvoker(RegisterOrganizationalUnitRequest registerOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(registerOrganizationalUnitRequest.OrganizationalUnitId, out var valueOfOrganizationalUnitId)) urlParam.Add("organizational_unit_id", valueOfOrganizationalUnitId);
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
            if (StringUtils.TryConvertToNonEmptyString(showManagedAccountRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedAccountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowManagedAccountResponse>(response);
        }

        public SyncInvoker<ShowManagedAccountResponse> ShowManagedAccountInvoker(ShowManagedAccountRequest showManagedAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showManagedAccountRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedAccountRequest);
            return new SyncInvoker<ShowManagedAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowManagedAccountResponse>);
        }
        
        /// <summary>
        /// 查询纳管账号的模板信息
        ///
        /// 查询组织里某个纳管账号的模板信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowManagedAccountTemplateResponse ShowManagedAccountTemplate(ShowManagedAccountTemplateRequest showManagedAccountTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showManagedAccountTemplateRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}/blueprint", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedAccountTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowManagedAccountTemplateResponse>(response);
        }

        public SyncInvoker<ShowManagedAccountTemplateResponse> ShowManagedAccountTemplateInvoker(ShowManagedAccountTemplateRequest showManagedAccountTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showManagedAccountTemplateRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}/blueprint", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedAccountTemplateRequest);
            return new SyncInvoker<ShowManagedAccountTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowManagedAccountTemplateResponse>);
        }
        
        /// <summary>
        /// 列出核心纳管账号
        ///
        /// 列出组织里的所有核心纳管账号信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowManagedCoreAccountResponse ShowManagedCoreAccount(ShowManagedCoreAccountRequest showManagedCoreAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-core-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedCoreAccountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowManagedCoreAccountResponse>(response);
        }

        public SyncInvoker<ShowManagedCoreAccountResponse> ShowManagedCoreAccountInvoker(ShowManagedCoreAccountRequest showManagedCoreAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-core-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedCoreAccountRequest);
            return new SyncInvoker<ShowManagedCoreAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowManagedCoreAccountResponse>);
        }
        
        /// <summary>
        /// 查询已注册OU信息
        ///
        /// 查询在RGC服务里的注册OU信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowManagedOrganizationalUnitResponse ShowManagedOrganizationalUnit(ShowManagedOrganizationalUnitRequest showManagedOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showManagedOrganizationalUnitRequest.ManagedOrganizationalUnitId, out var valueOfManagedOrganizationalUnitId)) urlParam.Add("managed_organizational_unit_id", valueOfManagedOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedOrganizationalUnitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowManagedOrganizationalUnitResponse>(response);
        }

        public SyncInvoker<ShowManagedOrganizationalUnitResponse> ShowManagedOrganizationalUnitInvoker(ShowManagedOrganizationalUnitRequest showManagedOrganizationalUnitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showManagedOrganizationalUnitRequest.ManagedOrganizationalUnitId, out var valueOfManagedOrganizationalUnitId)) urlParam.Add("managed_organizational_unit_id", valueOfManagedOrganizationalUnitId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-organizational-units/{managed_organizational_unit_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showManagedOrganizationalUnitRequest);
            return new SyncInvoker<ShowManagedOrganizationalUnitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowManagedOrganizationalUnitResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showOperationRequest.OperationId, out var valueOfOperationId)) urlParam.Add("operation_id", valueOfOperationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/{operation_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOperationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOperationResponse>(response);
        }

        public SyncInvoker<ShowOperationResponse> ShowOperationInvoker(ShowOperationRequest showOperationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOperationRequest.OperationId, out var valueOfOperationId)) urlParam.Add("operation_id", valueOfOperationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/{operation_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOperationRequest);
            return new SyncInvoker<ShowOperationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOperationResponse>);
        }
        
        /// <summary>
        /// 取消纳管账号
        ///
        /// 将组织里的某个账号从RGC服务里取消纳管。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnEnrollAccountResponse UnEnrollAccount(UnEnrollAccountRequest unEnrollAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unEnrollAccountRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}/un-enroll", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unEnrollAccountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UnEnrollAccountResponse>(response);
        }

        public SyncInvoker<UnEnrollAccountResponse> UnEnrollAccountInvoker(UnEnrollAccountRequest unEnrollAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unEnrollAccountRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}/un-enroll", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unEnrollAccountRequest);
            return new SyncInvoker<UnEnrollAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<UnEnrollAccountResponse>);
        }
        
        /// <summary>
        /// 更新纳管账号
        ///
        /// 更新组织里某个已在RGC服务的纳管账号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateManagedAccountResponse UpdateManagedAccount(UpdateManagedAccountRequest updateManagedAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateManagedAccountRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateManagedAccountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateManagedAccountResponse>(response);
        }

        public SyncInvoker<UpdateManagedAccountResponse> UpdateManagedAccountInvoker(UpdateManagedAccountRequest updateManagedAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateManagedAccountRequest.ManagedAccountId, out var valueOfManagedAccountId)) urlParam.Add("managed_account_id", valueOfManagedAccountId);
            var urlPath = HttpUtils.AddUrlPath("/v1/managed-organization/managed-accounts/{managed_account_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateManagedAccountRequest);
            return new SyncInvoker<UpdateManagedAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateManagedAccountResponse>);
        }
        
        /// <summary>
        /// 创建模板
        ///
        /// 创建RFS模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest createTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTemplateResponse>(response);
        }

        public SyncInvoker<CreateTemplateResponse> CreateTemplateInvoker(CreateTemplateRequest createTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateRequest);
            return new SyncInvoker<CreateTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemplateResponse>);
        }
        
        /// <summary>
        /// 删除模板
        ///
        /// 删除RFS模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest deleteTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTemplateRequest.TemplateName, out var valueOfTemplateName)) urlParam.Add("template_name", valueOfTemplateName);
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/templates/{template_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTemplateResponse>(response);
        }

        public SyncInvoker<DeleteTemplateResponse> DeleteTemplateInvoker(DeleteTemplateRequest deleteTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTemplateRequest.TemplateName, out var valueOfTemplateName)) urlParam.Add("template_name", valueOfTemplateName);
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/templates/{template_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            return new SyncInvoker<DeleteTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTemplateResponse>);
        }
        
        /// <summary>
        /// 查询预置模板列表
        ///
        /// 查询预置模板列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPredefinedTemplatesResponse ListPredefinedTemplates(ListPredefinedTemplatesRequest listPredefinedTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/predefined-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefinedTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPredefinedTemplatesResponse>(response);
        }

        public SyncInvoker<ListPredefinedTemplatesResponse> ListPredefinedTemplatesInvoker(ListPredefinedTemplatesRequest listPredefinedTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/predefined-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefinedTemplatesRequest);
            return new SyncInvoker<ListPredefinedTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPredefinedTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询模板的部署参数
        ///
        /// 查询模板的部署参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTemplateDeployParamsResponse ShowTemplateDeployParams(ShowTemplateDeployParamsRequest showTemplateDeployParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTemplateDeployParamsRequest.TemplateName, out var valueOfTemplateName)) urlParam.Add("template_name", valueOfTemplateName);
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/templates/{template_name}/deploy-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateDeployParamsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTemplateDeployParamsResponse>(response);
        }

        public SyncInvoker<ShowTemplateDeployParamsResponse> ShowTemplateDeployParamsInvoker(ShowTemplateDeployParamsRequest showTemplateDeployParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTemplateDeployParamsRequest.TemplateName, out var valueOfTemplateName)) urlParam.Add("template_name", valueOfTemplateName);
            var urlPath = HttpUtils.AddUrlPath("/v1/rgc/templates/{template_name}/deploy-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateDeployParamsRequest);
            return new SyncInvoker<ShowTemplateDeployParamsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTemplateDeployParamsResponse>);
        }
        
    }
}