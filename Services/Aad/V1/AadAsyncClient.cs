using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Aad.V1.Model;

namespace HuaweiCloud.SDK.Aad.V1
{
    public partial class AadAsyncClient : Client
    {
        public static ClientBuilder<AadAsyncClient> NewBuilder()
        {
            return new ClientBuilder<AadAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 解封IP
        ///
        /// 解封IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteUnblockIpResponse> ExecuteUnblockIpAsync(ExecuteUnblockIpRequest executeUnblockIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeUnblockIpRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeUnblockIpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteUnblockIpResponse>(response);
        }

        public AsyncInvoker<ExecuteUnblockIpResponse> ExecuteUnblockIpAsyncInvoker(ExecuteUnblockIpRequest executeUnblockIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeUnblockIpRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeUnblockIpRequest);
            return new AsyncInvoker<ExecuteUnblockIpResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteUnblockIpResponse>);
        }
        
        /// <summary>
        /// 查询租户封堵列表
        ///
        /// 查询租户封堵列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBlockIpsResponse> ListBlockIpsAsync(ListBlockIpsRequest listBlockIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBlockIpsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/block-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBlockIpsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBlockIpsResponse>(response);
        }

        public AsyncInvoker<ListBlockIpsResponse> ListBlockIpsAsyncInvoker(ListBlockIpsRequest listBlockIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBlockIpsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/block-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBlockIpsRequest);
            return new AsyncInvoker<ListBlockIpsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBlockIpsResponse>);
        }
        
        /// <summary>
        /// 查询解封配额
        ///
        /// 查询解封配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUnblockQuotaStatisticsResponse> ListUnblockQuotaStatisticsAsync(ListUnblockQuotaStatisticsRequest listUnblockQuotaStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUnblockQuotaStatisticsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock-quota-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnblockQuotaStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUnblockQuotaStatisticsResponse>(response);
        }

        public AsyncInvoker<ListUnblockQuotaStatisticsResponse> ListUnblockQuotaStatisticsAsyncInvoker(ListUnblockQuotaStatisticsRequest listUnblockQuotaStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUnblockQuotaStatisticsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock-quota-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnblockQuotaStatisticsRequest);
            return new AsyncInvoker<ListUnblockQuotaStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUnblockQuotaStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询封堵统计数据
        ///
        /// 查询封堵统计数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBlockStatisticsResponse> ShowBlockStatisticsAsync(ShowBlockStatisticsRequest showBlockStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBlockStatisticsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/block-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlockStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBlockStatisticsResponse>(response);
        }

        public AsyncInvoker<ShowBlockStatisticsResponse> ShowBlockStatisticsAsyncInvoker(ShowBlockStatisticsRequest showBlockStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBlockStatisticsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/block-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlockStatisticsRequest);
            return new AsyncInvoker<ShowBlockStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBlockStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询租户解封记录
        ///
        /// 查询租户解封记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUnblockRecordResponse> ShowUnblockRecordAsync(ShowUnblockRecordRequest showUnblockRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUnblockRecordRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUnblockRecordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUnblockRecordResponse>(response);
        }

        public AsyncInvoker<ShowUnblockRecordResponse> ShowUnblockRecordAsyncInvoker(ShowUnblockRecordRequest showUnblockRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUnblockRecordRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUnblockRecordRequest);
            return new AsyncInvoker<ShowUnblockRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUnblockRecordResponse>);
        }
        
        /// <summary>
        /// 高防实例添加黑白名单
        ///
        /// 高防实例添加黑白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddBlackWhiteIpListResponse> AddBlackWhiteIpListAsync(AddBlackWhiteIpListRequest addBlackWhiteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/bwlist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addBlackWhiteIpListRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddBlackWhiteIpListResponse>(response);
        }

        public AsyncInvoker<AddBlackWhiteIpListResponse> AddBlackWhiteIpListAsyncInvoker(AddBlackWhiteIpListRequest addBlackWhiteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/bwlist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addBlackWhiteIpListRequest);
            return new AsyncInvoker<AddBlackWhiteIpListResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddBlackWhiteIpListResponse>);
        }
        
        /// <summary>
        /// 策略添加黑白名单
        ///
        /// 策略添加黑白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddPolicyBlackAndWhiteIpListResponse> AddPolicyBlackAndWhiteIpListAsync(AddPolicyBlackAndWhiteIpListRequest addPolicyBlackAndWhiteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addPolicyBlackAndWhiteIpListRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/ip-list/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPolicyBlackAndWhiteIpListRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddPolicyBlackAndWhiteIpListResponse>(response);
        }

        public AsyncInvoker<AddPolicyBlackAndWhiteIpListResponse> AddPolicyBlackAndWhiteIpListAsyncInvoker(AddPolicyBlackAndWhiteIpListRequest addPolicyBlackAndWhiteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addPolicyBlackAndWhiteIpListRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/ip-list/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPolicyBlackAndWhiteIpListRequest);
            return new AsyncInvoker<AddPolicyBlackAndWhiteIpListResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddPolicyBlackAndWhiteIpListResponse>);
        }
        
        /// <summary>
        /// 策略绑定防护对象
        ///
        /// 策略绑定防护对象
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateIpToPolicyResponse> AssociateIpToPolicyAsync(AssociateIpToPolicyRequest associateIpToPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateIpToPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateIpToPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AssociateIpToPolicyResponse>(response);
        }

        public AsyncInvoker<AssociateIpToPolicyResponse> AssociateIpToPolicyAsyncInvoker(AssociateIpToPolicyRequest associateIpToPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateIpToPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateIpToPolicyRequest);
            return new AsyncInvoker<AssociateIpToPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AssociateIpToPolicyResponse>);
        }
        
        /// <summary>
        /// 策略和实例绑定防护对象
        ///
        /// 策略和实例绑定防护对象
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateIpToPolicyAndPackageResponse> AssociateIpToPolicyAndPackageAsync(AssociateIpToPolicyAndPackageRequest associateIpToPolicyAndPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateIpToPolicyAndPackageRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/cnad/policies/{policy_id}/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateIpToPolicyAndPackageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AssociateIpToPolicyAndPackageResponse>(response);
        }

        public AsyncInvoker<AssociateIpToPolicyAndPackageResponse> AssociateIpToPolicyAndPackageAsyncInvoker(AssociateIpToPolicyAndPackageRequest associateIpToPolicyAndPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateIpToPolicyAndPackageRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/cnad/policies/{policy_id}/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateIpToPolicyAndPackageRequest);
            return new AsyncInvoker<AssociateIpToPolicyAndPackageResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AssociateIpToPolicyAndPackageResponse>);
        }
        
        /// <summary>
        /// 批量创建高防实例IP的转发规则
        ///
        /// 批量创建高防实例IP的转发规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateInstanceIpRuleResponse> BatchCreateInstanceIpRuleAsync(BatchCreateInstanceIpRuleRequest batchCreateInstanceIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateInstanceIpRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(batchCreateInstanceIpRuleRequest.Ip, out var valueOfIp)) urlParam.Add("ip", valueOfIp);
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateInstanceIpRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateInstanceIpRuleResponse>(response);
        }

        public AsyncInvoker<BatchCreateInstanceIpRuleResponse> BatchCreateInstanceIpRuleAsyncInvoker(BatchCreateInstanceIpRuleRequest batchCreateInstanceIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateInstanceIpRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(batchCreateInstanceIpRuleRequest.Ip, out var valueOfIp)) urlParam.Add("ip", valueOfIp);
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateInstanceIpRuleRequest);
            return new AsyncInvoker<BatchCreateInstanceIpRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateInstanceIpRuleResponse>);
        }
        
        /// <summary>
        /// 批量删除高防实例IP的转发规则
        ///
        /// 批量删除高防实例IP的转发规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteInstanceIpRuleResponse> BatchDeleteInstanceIpRuleAsync(BatchDeleteInstanceIpRuleRequest batchDeleteInstanceIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteInstanceIpRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteInstanceIpRuleRequest.Ip, out var valueOfIp)) urlParam.Add("ip", valueOfIp);
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceIpRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteInstanceIpRuleResponse>(response);
        }

        public AsyncInvoker<BatchDeleteInstanceIpRuleResponse> BatchDeleteInstanceIpRuleAsyncInvoker(BatchDeleteInstanceIpRuleRequest batchDeleteInstanceIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteInstanceIpRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteInstanceIpRuleRequest.Ip, out var valueOfIp)) urlParam.Add("ip", valueOfIp);
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceIpRuleRequest);
            return new AsyncInvoker<BatchDeleteInstanceIpRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteInstanceIpRuleResponse>);
        }
        
        /// <summary>
        /// 创建防护域名
        ///
        /// 创建防护域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAadDomainResponse> CreateAadDomainAsync(CreateAadDomainRequest createAadDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAadDomainRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAadDomainResponse>(response);
        }

        public AsyncInvoker<CreateAadDomainResponse> CreateAadDomainAsyncInvoker(CreateAadDomainRequest createAadDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAadDomainRequest);
            return new AsyncInvoker<CreateAadDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAadDomainResponse>);
        }
        
        /// <summary>
        /// 创建策略
        ///
        /// 创建策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest createPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyResponse>(response);
        }

        public AsyncInvoker<CreatePolicyResponse> CreatePolicyAsyncInvoker(CreatePolicyRequest createPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyRequest);
            return new AsyncInvoker<CreatePolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyResponse>);
        }
        
        /// <summary>
        /// 删除告警配置
        ///
        /// 删除告警配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAlarmConfigResponse> DeleteAlarmConfigAsync(DeleteAlarmConfigRequest deleteAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmConfigRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAlarmConfigResponse>(response);
        }

        public AsyncInvoker<DeleteAlarmConfigResponse> DeleteAlarmConfigAsyncInvoker(DeleteAlarmConfigRequest deleteAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmConfigRequest);
            return new AsyncInvoker<DeleteAlarmConfigResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAlarmConfigResponse>);
        }
        
        /// <summary>
        /// 高防实例删除黑白名单
        ///
        /// 高防实例删除黑白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteBlackWhiteIpListResponse> DeleteBlackWhiteIpListAsync(DeleteBlackWhiteIpListRequest deleteBlackWhiteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/bwlist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBlackWhiteIpListRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBlackWhiteIpListResponse>(response);
        }

        public AsyncInvoker<DeleteBlackWhiteIpListResponse> DeleteBlackWhiteIpListAsyncInvoker(DeleteBlackWhiteIpListRequest deleteBlackWhiteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/bwlist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBlackWhiteIpListRequest);
            return new AsyncInvoker<DeleteBlackWhiteIpListResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBlackWhiteIpListResponse>);
        }
        
        /// <summary>
        /// 删除策略
        ///
        /// 删除策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest deletePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyResponse>(response);
        }

        public AsyncInvoker<DeletePolicyResponse> DeletePolicyAsyncInvoker(DeletePolicyRequest deletePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            return new AsyncInvoker<DeletePolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyResponse>);
        }
        
        /// <summary>
        /// 策略删除黑白名单
        ///
        /// 策略删除黑白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePolicyBlackAndWhiteIpListResponse> DeletePolicyBlackAndWhiteIpListAsync(DeletePolicyBlackAndWhiteIpListRequest deletePolicyBlackAndWhiteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyBlackAndWhiteIpListRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/ip-list/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyBlackAndWhiteIpListRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeletePolicyBlackAndWhiteIpListResponse>(response);
        }

        public AsyncInvoker<DeletePolicyBlackAndWhiteIpListResponse> DeletePolicyBlackAndWhiteIpListAsyncInvoker(DeletePolicyBlackAndWhiteIpListRequest deletePolicyBlackAndWhiteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyBlackAndWhiteIpListRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/ip-list/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyBlackAndWhiteIpListRequest);
            return new AsyncInvoker<DeletePolicyBlackAndWhiteIpListResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeletePolicyBlackAndWhiteIpListResponse>);
        }
        
        /// <summary>
        /// 策略解绑防护对象
        ///
        /// 策略解绑防护对象
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateIpFromPolicyResponse> DisassociateIpFromPolicyAsync(DisassociateIpFromPolicyRequest disassociateIpFromPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateIpFromPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateIpFromPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisassociateIpFromPolicyResponse>(response);
        }

        public AsyncInvoker<DisassociateIpFromPolicyResponse> DisassociateIpFromPolicyAsyncInvoker(DisassociateIpFromPolicyRequest disassociateIpFromPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateIpFromPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateIpFromPolicyRequest);
            return new AsyncInvoker<DisassociateIpFromPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisassociateIpFromPolicyResponse>);
        }
        
        /// <summary>
        /// 策略和实例解绑防护对象
        ///
        /// 策略和实例解绑防护对象
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateIpFromPolicyAndPackageResponse> DisassociateIpFromPolicyAndPackageAsync(DisassociateIpFromPolicyAndPackageRequest disassociateIpFromPolicyAndPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateIpFromPolicyAndPackageRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/cnad/policies/{policy_id}/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateIpFromPolicyAndPackageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisassociateIpFromPolicyAndPackageResponse>(response);
        }

        public AsyncInvoker<DisassociateIpFromPolicyAndPackageResponse> DisassociateIpFromPolicyAndPackageAsyncInvoker(DisassociateIpFromPolicyAndPackageRequest disassociateIpFromPolicyAndPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateIpFromPolicyAndPackageRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v3/cnad/policies/{policy_id}/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateIpFromPolicyAndPackageRequest);
            return new AsyncInvoker<DisassociateIpFromPolicyAndPackageResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisassociateIpFromPolicyAndPackageResponse>);
        }
        
        /// <summary>
        /// 查询域名列表
        ///
        /// 查询域名列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainResponse> ListDomainAsync(ListDomainRequest listDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainResponse>(response);
        }

        public AsyncInvoker<ListDomainResponse> ListDomainAsyncInvoker(ListDomainRequest listDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainRequest);
            return new AsyncInvoker<ListDomainResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainResponse>);
        }
        
        /// <summary>
        /// 查询高防实例列表
        ///
        /// 查询高防实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceResponse> ListInstanceAsync(ListInstanceRequest listInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceResponse>(response);
        }

        public AsyncInvoker<ListInstanceResponse> ListInstanceAsyncInvoker(ListInstanceRequest listInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRequest);
            return new AsyncInvoker<ListInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceResponse>);
        }
        
        /// <summary>
        /// 查询域名关联的实例ID
        ///
        /// 查询域名关联的实例ID
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceIdResponse> ListInstanceIdAsync(ListInstanceIdRequest listInstanceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceIdRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceIdResponse>(response);
        }

        public AsyncInvoker<ListInstanceIdResponse> ListInstanceIdAsyncInvoker(ListInstanceIdRequest listInstanceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceIdRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceIdRequest);
            return new AsyncInvoker<ListInstanceIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceIdResponse>);
        }
        
        /// <summary>
        /// 查询高防实例IP的转发规则列表
        ///
        /// 查询高防实例IP的转发规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceIpRuleResponse> ListInstanceIpRuleAsync(ListInstanceIpRuleRequest listInstanceIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceIpRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceIpRuleRequest.Ip, out var valueOfIp)) urlParam.Add("ip", valueOfIp);
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceIpRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceIpRuleResponse>(response);
        }

        public AsyncInvoker<ListInstanceIpRuleResponse> ListInstanceIpRuleAsyncInvoker(ListInstanceIpRuleRequest listInstanceIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceIpRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceIpRuleRequest.Ip, out var valueOfIp)) urlParam.Add("ip", valueOfIp);
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceIpRuleRequest);
            return new AsyncInvoker<ListInstanceIpRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceIpRuleResponse>);
        }
        
        /// <summary>
        /// 查询实例列表
        ///
        /// 查询实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPackageResponse> ListPackageAsync(ListPackageRequest listPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPackageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPackageResponse>(response);
        }

        public AsyncInvoker<ListPackageResponse> ListPackageAsyncInvoker(ListPackageRequest listPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPackageRequest);
            return new AsyncInvoker<ListPackageResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPackageResponse>);
        }
        
        /// <summary>
        /// 查询流量峰值、攻击计数
        ///
        /// 查询流量峰值、攻击计数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPeakResponse> ListPeakAsync(ListPeakRequest listPeakRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPeakRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listPeakRequest.Ip, out var valueOfIp)) urlParam.Add("ip", valueOfIp);
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/ddos-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPeakRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPeakResponse>(response);
        }

        public AsyncInvoker<ListPeakResponse> ListPeakAsyncInvoker(ListPeakRequest listPeakRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPeakRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listPeakRequest.Ip, out var valueOfIp)) urlParam.Add("ip", valueOfIp);
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/ddos-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPeakRequest);
            return new AsyncInvoker<ListPeakResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPeakResponse>);
        }
        
        /// <summary>
        /// 查询策略列表
        ///
        /// 查询策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyResponse> ListPolicyAsync(ListPolicyRequest listPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyResponse>(response);
        }

        public AsyncInvoker<ListPolicyResponse> ListPolicyAsyncInvoker(ListPolicyRequest listPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyRequest);
            return new AsyncInvoker<ListPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyResponse>);
        }
        
        /// <summary>
        /// 查询防护对象列表
        ///
        /// 查询防护对象列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProtectedIpResponse> ListProtectedIpAsync(ListProtectedIpRequest listProtectedIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/protected-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedIpRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProtectedIpResponse>(response);
        }

        public AsyncInvoker<ListProtectedIpResponse> ListProtectedIpAsyncInvoker(ListProtectedIpRequest listProtectedIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/protected-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedIpRequest);
            return new AsyncInvoker<ListProtectedIpResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProtectedIpResponse>);
        }
        
        /// <summary>
        /// 查询高防回源IP段列表
        ///
        /// 查询高防回源IP段列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSourceIpsResponse> ListSourceIpsAsync(ListSourceIpsRequest listSourceIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/source-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSourceIpsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSourceIpsResponse>(response);
        }

        public AsyncInvoker<ListSourceIpsResponse> ListSourceIpsAsyncInvoker(ListSourceIpsRequest listSourceIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/source-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSourceIpsRequest);
            return new AsyncInvoker<ListSourceIpsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSourceIpsResponse>);
        }
        
        /// <summary>
        /// 查询可绑定的防护对象列表
        ///
        /// 查询可绑定的防护对象列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUnboundProtectedIpResponse> ListUnboundProtectedIpAsync(ListUnboundProtectedIpRequest listUnboundProtectedIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUnboundProtectedIpRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/unbound-protected-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnboundProtectedIpRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUnboundProtectedIpResponse>(response);
        }

        public AsyncInvoker<ListUnboundProtectedIpResponse> ListUnboundProtectedIpAsyncInvoker(ListUnboundProtectedIpRequest listUnboundProtectedIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUnboundProtectedIpRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/unbound-protected-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnboundProtectedIpRequest);
            return new AsyncInvoker<ListUnboundProtectedIpResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUnboundProtectedIpResponse>);
        }
        
        /// <summary>
        /// 修改域名WEB基础防护开关/CC防护开关
        ///
        /// 修改域名WEB基础防护开关/CC防护开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyDomainWebSwitchResponse> ModifyDomainWebSwitchAsync(ModifyDomainWebSwitchRequest modifyDomainWebSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/domains/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyDomainWebSwitchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ModifyDomainWebSwitchResponse>(response);
        }

        public AsyncInvoker<ModifyDomainWebSwitchResponse> ModifyDomainWebSwitchAsyncInvoker(ModifyDomainWebSwitchRequest modifyDomainWebSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/domains/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyDomainWebSwitchRequest);
            return new AsyncInvoker<ModifyDomainWebSwitchResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ModifyDomainWebSwitchResponse>);
        }
        
        /// <summary>
        /// 上传/修改域名对应证书
        ///
        /// 上传/修改域名对应证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetCertForDomainResponse> SetCertForDomainAsync(SetCertForDomainRequest setCertForDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/domains/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setCertForDomainRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SetCertForDomainResponse>(response);
        }

        public AsyncInvoker<SetCertForDomainResponse> SetCertForDomainAsyncInvoker(SetCertForDomainRequest setCertForDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/domains/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setCertForDomainRequest);
            return new AsyncInvoker<SetCertForDomainResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetCertForDomainResponse>);
        }
        
        /// <summary>
        /// 查询告警配置
        ///
        /// 查询告警配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAlarmConfigResponse> ShowAlarmConfigAsync(ShowAlarmConfigRequest showAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAlarmConfigResponse>(response);
        }

        public AsyncInvoker<ShowAlarmConfigResponse> ShowAlarmConfigAsyncInvoker(ShowAlarmConfigRequest showAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmConfigRequest);
            return new AsyncInvoker<ShowAlarmConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlarmConfigResponse>);
        }
        
        /// <summary>
        /// 查询日志配置
        ///
        /// 查询日志配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLtsConfigResponse> ShowLtsConfigAsync(ShowLtsConfigRequest showLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/config/lts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLtsConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLtsConfigResponse>(response);
        }

        public AsyncInvoker<ShowLtsConfigResponse> ShowLtsConfigAsyncInvoker(ShowLtsConfigRequest showLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/config/lts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLtsConfigRequest);
            return new AsyncInvoker<ShowLtsConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLtsConfigResponse>);
        }
        
        /// <summary>
        /// 查询策略详情
        ///
        /// 查询策略详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPolicyResponse> ShowPolicyAsync(ShowPolicyRequest showPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyResponse>(response);
        }

        public AsyncInvoker<ShowPolicyResponse> ShowPolicyAsyncInvoker(ShowPolicyRequest showPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            return new AsyncInvoker<ShowPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyResponse>);
        }
        
        /// <summary>
        /// 设置告警配置
        ///
        /// 设置告警配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAlarmConfigResponse> UpdateAlarmConfigAsync(UpdateAlarmConfigRequest updateAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateAlarmConfigResponse>(response);
        }

        public AsyncInvoker<UpdateAlarmConfigResponse> UpdateAlarmConfigAsyncInvoker(UpdateAlarmConfigRequest updateAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmConfigRequest);
            return new AsyncInvoker<UpdateAlarmConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAlarmConfigResponse>);
        }
        
        /// <summary>
        /// 更新域名信息
        ///
        /// 更新域名源站配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest updateDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainResponse>(response);
        }

        public AsyncInvoker<UpdateDomainResponse> UpdateDomainAsyncInvoker(UpdateDomainRequest updateDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainRequest);
            return new AsyncInvoker<UpdateDomainResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainResponse>);
        }
        
        /// <summary>
        /// 修改高防实例转发配置的源站IP
        ///
        /// 修改高防实例转发配置的源站IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceIpRuleResponse> UpdateInstanceIpRuleAsync(UpdateInstanceIpRuleRequest updateInstanceIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceIpRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceIpRuleRequest.Ip, out var valueOfIp)) urlParam.Add("ip", valueOfIp);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceIpRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceIpRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceIpRuleResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceIpRuleResponse> UpdateInstanceIpRuleAsyncInvoker(UpdateInstanceIpRuleRequest updateInstanceIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceIpRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceIpRuleRequest.Ip, out var valueOfIp)) urlParam.Add("ip", valueOfIp);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceIpRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceIpRuleRequest);
            return new AsyncInvoker<UpdateInstanceIpRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceIpRuleResponse>);
        }
        
        /// <summary>
        /// 设置日志配置
        ///
        /// 设置日志配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLtsConfigResponse> UpdateLtsConfigAsync(UpdateLtsConfigRequest updateLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/config/lts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLtsConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateLtsConfigResponse>(response);
        }

        public AsyncInvoker<UpdateLtsConfigResponse> UpdateLtsConfigAsyncInvoker(UpdateLtsConfigRequest updateLtsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/config/lts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLtsConfigRequest);
            return new AsyncInvoker<UpdateLtsConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateLtsConfigResponse>);
        }
        
        /// <summary>
        /// 更新实例绑定的全量防护对象
        ///
        /// 更新实例绑定的全量防护对象
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePackageIpResponse> UpdatePackageIpAsync(UpdatePackageIpRequest updatePackageIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePackageIpRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/protected-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePackageIpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdatePackageIpResponse>(response);
        }

        public AsyncInvoker<UpdatePackageIpResponse> UpdatePackageIpAsyncInvoker(UpdatePackageIpRequest updatePackageIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePackageIpRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/protected-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePackageIpRequest);
            return new AsyncInvoker<UpdatePackageIpResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdatePackageIpResponse>);
        }
        
        /// <summary>
        /// 更新实例名字
        ///
        /// 更新实例名字
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePackageNameResponse> UpdatePackageNameAsync(UpdatePackageNameRequest updatePackageNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePackageNameRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePackageNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePackageNameResponse>(response);
        }

        public AsyncInvoker<UpdatePackageNameResponse> UpdatePackageNameAsyncInvoker(UpdatePackageNameRequest updatePackageNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePackageNameRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePackageNameRequest);
            return new AsyncInvoker<UpdatePackageNameResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePackageNameResponse>);
        }
        
        /// <summary>
        /// 更新策略
        ///
        /// 更新策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest updatePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePolicyResponse>(response);
        }

        public AsyncInvoker<UpdatePolicyResponse> UpdatePolicyAsyncInvoker(UpdatePolicyRequest updatePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyRequest);
            return new AsyncInvoker<UpdatePolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePolicyResponse>);
        }
        
        /// <summary>
        /// 防护对象设置标签
        ///
        /// 防护对象设置标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTagForProtectedIpResponse> UpdateTagForProtectedIpAsync(UpdateTagForProtectedIpRequest updateTagForProtectedIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/protected-ips/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTagForProtectedIpRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTagForProtectedIpResponse>(response);
        }

        public AsyncInvoker<UpdateTagForProtectedIpResponse> UpdateTagForProtectedIpAsyncInvoker(UpdateTagForProtectedIpRequest updateTagForProtectedIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/protected-ips/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTagForProtectedIpRequest);
            return new AsyncInvoker<UpdateTagForProtectedIpResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTagForProtectedIpResponse>);
        }
        
    }
}