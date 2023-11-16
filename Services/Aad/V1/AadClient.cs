using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Aad.V1.Model;

namespace HuaweiCloud.SDK.Aad.V1
{
    public partial class AadClient : Client
    {
        public static ClientBuilder<AadClient> NewBuilder()
        {
            return new ClientBuilder<AadClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 解封IP
        ///
        /// 解封IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteUnblockIpResponse ExecuteUnblockIp(ExecuteUnblockIpRequest executeUnblockIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , executeUnblockIpRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeUnblockIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ExecuteUnblockIpResponse>(response);
        }
        
        /// <summary>
        /// 查询租户封堵列表
        ///
        /// 查询租户封堵列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBlockIpsResponse ListBlockIps(ListBlockIpsRequest listBlockIpsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , listBlockIpsRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/block-list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBlockIpsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBlockIpsResponse>(response);
        }
        
        /// <summary>
        /// 查询解封配额
        ///
        /// 查询解封配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUnblockQuotaStatisticsResponse ListUnblockQuotaStatistics(ListUnblockQuotaStatisticsRequest listUnblockQuotaStatisticsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , listUnblockQuotaStatisticsRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock-quota-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnblockQuotaStatisticsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListUnblockQuotaStatisticsResponse>(response);
        }
        
        /// <summary>
        /// 查询封堵统计数据
        ///
        /// 查询封堵统计数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBlockStatisticsResponse ShowBlockStatistics(ShowBlockStatisticsRequest showBlockStatisticsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showBlockStatisticsRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/block-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlockStatisticsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBlockStatisticsResponse>(response);
        }
        
        /// <summary>
        /// 查询租户解封记录
        ///
        /// 查询租户解封记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUnblockRecordResponse ShowUnblockRecord(ShowUnblockRecordRequest showUnblockRecordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showUnblockRecordRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock-record",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUnblockRecordRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowUnblockRecordResponse>(response);
        }
        
        /// <summary>
        /// 策略添加黑白名单
        ///
        /// 策略添加黑白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddPolicyBlackAndWhiteIpListResponse AddPolicyBlackAndWhiteIpList(AddPolicyBlackAndWhiteIpListRequest addPolicyBlackAndWhiteIpListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , addPolicyBlackAndWhiteIpListRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/ip-list/add",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPolicyBlackAndWhiteIpListRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<AddPolicyBlackAndWhiteIpListResponse>(response);
        }
        
        /// <summary>
        /// 策略绑定防护对象
        ///
        /// 策略绑定防护对象
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateIpToPolicyResponse AssociateIpToPolicy(AssociateIpToPolicyRequest associateIpToPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , associateIpToPolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/bind",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateIpToPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<AssociateIpToPolicyResponse>(response);
        }
        
        /// <summary>
        /// 批量创建高防实例IP的转发规则
        ///
        /// 批量创建高防实例IP的转发规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateInstanceIpRuleResponse BatchCreateInstanceIpRule(BatchCreateInstanceIpRuleRequest batchCreateInstanceIpRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchCreateInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip" , batchCreateInstanceIpRuleRequest.Ip.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/batch-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateInstanceIpRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateInstanceIpRuleResponse>(response);
        }
        
        /// <summary>
        /// 批量删除高防实例IP的转发规则
        ///
        /// 批量删除高防实例IP的转发规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteInstanceIpRuleResponse BatchDeleteInstanceIpRule(BatchDeleteInstanceIpRuleRequest batchDeleteInstanceIpRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchDeleteInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip" , batchDeleteInstanceIpRuleRequest.Ip.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceIpRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteInstanceIpRuleResponse>(response);
        }
        
        /// <summary>
        /// 创建策略
        ///
        /// 创建策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePolicyResponse CreatePolicy(CreatePolicyRequest createPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePolicyResponse>(response);
        }
        
        /// <summary>
        /// 删除告警配置
        ///
        /// 删除告警配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAlarmConfigResponse DeleteAlarmConfig(DeleteAlarmConfigRequest deleteAlarmConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteAlarmConfigResponse>(response);
        }
        
        /// <summary>
        /// 删除策略
        ///
        /// 删除策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest deletePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , deletePolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePolicyResponse>(response);
        }
        
        /// <summary>
        /// 策略删除黑白名单
        ///
        /// 策略删除黑白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePolicyBlackAndWhiteIpListResponse DeletePolicyBlackAndWhiteIpList(DeletePolicyBlackAndWhiteIpListRequest deletePolicyBlackAndWhiteIpListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , deletePolicyBlackAndWhiteIpListRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/ip-list/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyBlackAndWhiteIpListRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DeletePolicyBlackAndWhiteIpListResponse>(response);
        }
        
        /// <summary>
        /// 策略解绑防护对象
        ///
        /// 策略解绑防护对象
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateIpFromPolicyResponse DisassociateIpFromPolicy(DisassociateIpFromPolicyRequest disassociateIpFromPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , disassociateIpFromPolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/unbind",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateIpFromPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DisassociateIpFromPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询域名列表
        ///
        /// 查询域名列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainResponse ListDomain(ListDomainRequest listDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDomainResponse>(response);
        }
        
        /// <summary>
        /// 查询高防实例列表
        ///
        /// 查询高防实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceResponse ListInstance(ListInstanceRequest listInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListInstanceResponse>(response);
        }
        
        /// <summary>
        /// 查询域名关联的实例ID
        ///
        /// 查询域名关联的实例ID
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceIdResponse ListInstanceId(ListInstanceIdRequest listInstanceIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , listInstanceIdRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains/{domain_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListInstanceIdResponse>(response);
        }
        
        /// <summary>
        /// 查询高防实例IP的转发规则列表
        ///
        /// 查询高防实例IP的转发规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceIpRuleResponse ListInstanceIpRule(ListInstanceIpRuleRequest listInstanceIpRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip" , listInstanceIpRuleRequest.Ip.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceIpRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListInstanceIpRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询防护包列表
        ///
        /// 查询防护包列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPackageResponse ListPackage(ListPackageRequest listPackageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPackageRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPackageResponse>(response);
        }
        
        /// <summary>
        /// 查询流量峰值、攻击计数
        ///
        /// 查询流量峰值、攻击计数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPeakResponse ListPeak(ListPeakRequest listPeakRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listPeakRequest.InstanceId.ToString());
            urlParam.Add("ip" , listPeakRequest.Ip.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/ddos-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPeakRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPeakResponse>(response);
        }
        
        /// <summary>
        /// 查询策略列表
        ///
        /// 查询策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyResponse ListPolicy(ListPolicyRequest listPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询防护对象列表
        ///
        /// 查询防护对象列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProtectedIpResponse ListProtectedIp(ListProtectedIpRequest listProtectedIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/protected-ips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProtectedIpResponse>(response);
        }
        
        /// <summary>
        /// 查询可绑定的防护对象列表
        ///
        /// 查询可绑定的防护对象列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUnboundProtectedIpResponse ListUnboundProtectedIp(ListUnboundProtectedIpRequest listUnboundProtectedIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id" , listUnboundProtectedIpRequest.PackageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/unbound-protected-ips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnboundProtectedIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListUnboundProtectedIpResponse>(response);
        }
        
        /// <summary>
        /// 查询告警配置
        ///
        /// 查询告警配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAlarmConfigResponse ShowAlarmConfig(ShowAlarmConfigRequest showAlarmConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAlarmConfigResponse>(response);
        }
        
        /// <summary>
        /// 查询策略详情
        ///
        /// 查询策略详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPolicyResponse ShowPolicy(ShowPolicyRequest showPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , showPolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPolicyResponse>(response);
        }
        
        /// <summary>
        /// 设置告警配置
        ///
        /// 设置告警配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAlarmConfigResponse UpdateAlarmConfig(UpdateAlarmConfigRequest updateAlarmConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateAlarmConfigResponse>(response);
        }
        
        /// <summary>
        /// 更新域名信息
        ///
        /// 更新域名源站配置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainResponse UpdateDomain(UpdateDomainRequest updateDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains/{domain_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDomainResponse>(response);
        }
        
        /// <summary>
        /// 修改高防实例转发配置的源站IP
        ///
        /// 修改高防实例转发配置的源站IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceIpRuleResponse UpdateInstanceIpRule(UpdateInstanceIpRuleRequest updateInstanceIpRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip" , updateInstanceIpRuleRequest.Ip.ToString());
            urlParam.Add("rule_id" , updateInstanceIpRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceIpRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceIpRuleResponse>(response);
        }
        
        /// <summary>
        /// 更新防护包绑定的全量防护对象
        ///
        /// 更新防护包绑定的全量防护对象
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePackageIpResponse UpdatePackageIp(UpdatePackageIpRequest updatePackageIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id" , updatePackageIpRequest.PackageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/protected-ips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePackageIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<UpdatePackageIpResponse>(response);
        }
        
        /// <summary>
        /// 更新防护包名字
        ///
        /// 更新防护包名字
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePackageNameResponse UpdatePackageName(UpdatePackageNameRequest updatePackageNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id" , updatePackageNameRequest.PackageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/name",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePackageNameRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdatePackageNameResponse>(response);
        }
        
        /// <summary>
        /// 更新策略
        ///
        /// 更新策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest updatePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , updatePolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdatePolicyResponse>(response);
        }
        
        /// <summary>
        /// 防护对象设置标签
        ///
        /// 防护对象设置标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTagForProtectedIpResponse UpdateTagForProtectedIp(UpdateTagForProtectedIpRequest updateTagForProtectedIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cnad/protected-ips/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTagForProtectedIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTagForProtectedIpResponse>(response);
        }
        
    }
}