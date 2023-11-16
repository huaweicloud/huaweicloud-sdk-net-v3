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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , executeUnblockIpRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeUnblockIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ExecuteUnblockIpResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , listBlockIpsRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/block-list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBlockIpsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBlockIpsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , listUnblockQuotaStatisticsRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock-quota-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnblockQuotaStatisticsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListUnblockQuotaStatisticsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showBlockStatisticsRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/block-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlockStatisticsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBlockStatisticsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showUnblockRecordRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock-record",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUnblockRecordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUnblockRecordResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , addPolicyBlackAndWhiteIpListRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/ip-list/add",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPolicyBlackAndWhiteIpListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<AddPolicyBlackAndWhiteIpListResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , associateIpToPolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/bind",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateIpToPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<AssociateIpToPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchCreateInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip" , batchCreateInstanceIpRuleRequest.Ip.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/batch-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateInstanceIpRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateInstanceIpRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchDeleteInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip" , batchDeleteInstanceIpRuleRequest.Ip.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceIpRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteInstanceIpRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteAlarmConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , deletePolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , deletePolicyBlackAndWhiteIpListRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/ip-list/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyBlackAndWhiteIpListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DeletePolicyBlackAndWhiteIpListResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , disassociateIpFromPolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/unbind",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateIpFromPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DisassociateIpFromPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDomainResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstanceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , listInstanceIdRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains/{domain_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceIdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstanceIdResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip" , listInstanceIpRuleRequest.Ip.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceIpRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstanceIpRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询防护包列表
        ///
        /// 查询防护包列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPackageResponse> ListPackageAsync(ListPackageRequest listPackageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPackageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPackageResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listPeakRequest.InstanceId.ToString());
            urlParam.Add("ip" , listPeakRequest.Ip.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/ddos-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPeakRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPeakResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/protected-ips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProtectedIpResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id" , listUnboundProtectedIpRequest.PackageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/unbound-protected-ips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnboundProtectedIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListUnboundProtectedIpResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAlarmConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , showPolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateAlarmConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains/{domain_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDomainResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip" , updateInstanceIpRuleRequest.Ip.ToString());
            urlParam.Add("rule_id" , updateInstanceIpRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceIpRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceIpRuleResponse>(response);
        }
        
        /// <summary>
        /// 更新防护包绑定的全量防护对象
        ///
        /// 更新防护包绑定的全量防护对象
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePackageIpResponse> UpdatePackageIpAsync(UpdatePackageIpRequest updatePackageIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id" , updatePackageIpRequest.PackageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/protected-ips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePackageIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<UpdatePackageIpResponse>(response);
        }
        
        /// <summary>
        /// 更新防护包名字
        ///
        /// 更新防护包名字
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePackageNameResponse> UpdatePackageNameAsync(UpdatePackageNameRequest updatePackageNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id" , updatePackageNameRequest.PackageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/name",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePackageNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdatePackageNameResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , updatePolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdatePolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/protected-ips/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTagForProtectedIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTagForProtectedIpResponse>(response);
        }
        
    }
}