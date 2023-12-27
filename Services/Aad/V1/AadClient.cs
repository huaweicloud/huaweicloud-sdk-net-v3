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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", executeUnblockIpRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeUnblockIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteUnblockIpResponse>(response);
        }

        public SyncInvoker<ExecuteUnblockIpResponse> ExecuteUnblockIpInvoker(ExecuteUnblockIpRequest executeUnblockIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", executeUnblockIpRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeUnblockIpRequest);
            return new SyncInvoker<ExecuteUnblockIpResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteUnblockIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listBlockIpsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/block-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBlockIpsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBlockIpsResponse>(response);
        }

        public SyncInvoker<ListBlockIpsResponse> ListBlockIpsInvoker(ListBlockIpsRequest listBlockIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listBlockIpsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/block-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBlockIpsRequest);
            return new SyncInvoker<ListBlockIpsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBlockIpsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listUnblockQuotaStatisticsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock-quota-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnblockQuotaStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUnblockQuotaStatisticsResponse>(response);
        }

        public SyncInvoker<ListUnblockQuotaStatisticsResponse> ListUnblockQuotaStatisticsInvoker(ListUnblockQuotaStatisticsRequest listUnblockQuotaStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listUnblockQuotaStatisticsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock-quota-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnblockQuotaStatisticsRequest);
            return new SyncInvoker<ListUnblockQuotaStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUnblockQuotaStatisticsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showBlockStatisticsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/block-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlockStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBlockStatisticsResponse>(response);
        }

        public SyncInvoker<ShowBlockStatisticsResponse> ShowBlockStatisticsInvoker(ShowBlockStatisticsRequest showBlockStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showBlockStatisticsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/block-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlockStatisticsRequest);
            return new SyncInvoker<ShowBlockStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBlockStatisticsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showUnblockRecordRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUnblockRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUnblockRecordResponse>(response);
        }

        public SyncInvoker<ShowUnblockRecordResponse> ShowUnblockRecordInvoker(ShowUnblockRecordRequest showUnblockRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showUnblockRecordRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/unblockservice/{domain_id}/unblock-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUnblockRecordRequest);
            return new SyncInvoker<ShowUnblockRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUnblockRecordResponse>);
        }
        
        /// <summary>
        /// 高防实例添加黑白名单
        ///
        /// 高防实例添加黑白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddBlackWhiteIpListResponse AddBlackWhiteIpList(AddBlackWhiteIpListRequest addBlackWhiteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/bwlist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addBlackWhiteIpListRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddBlackWhiteIpListResponse>(response);
        }

        public SyncInvoker<AddBlackWhiteIpListResponse> AddBlackWhiteIpListInvoker(AddBlackWhiteIpListRequest addBlackWhiteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/bwlist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addBlackWhiteIpListRequest);
            return new SyncInvoker<AddBlackWhiteIpListResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddBlackWhiteIpListResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", addPolicyBlackAndWhiteIpListRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/ip-list/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPolicyBlackAndWhiteIpListRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddPolicyBlackAndWhiteIpListResponse>(response);
        }

        public SyncInvoker<AddPolicyBlackAndWhiteIpListResponse> AddPolicyBlackAndWhiteIpListInvoker(AddPolicyBlackAndWhiteIpListRequest addPolicyBlackAndWhiteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", addPolicyBlackAndWhiteIpListRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/ip-list/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addPolicyBlackAndWhiteIpListRequest);
            return new SyncInvoker<AddPolicyBlackAndWhiteIpListResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddPolicyBlackAndWhiteIpListResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", associateIpToPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateIpToPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AssociateIpToPolicyResponse>(response);
        }

        public SyncInvoker<AssociateIpToPolicyResponse> AssociateIpToPolicyInvoker(AssociateIpToPolicyRequest associateIpToPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", associateIpToPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateIpToPolicyRequest);
            return new SyncInvoker<AssociateIpToPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AssociateIpToPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip", batchCreateInstanceIpRuleRequest.Ip.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateInstanceIpRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateInstanceIpRuleResponse>(response);
        }

        public SyncInvoker<BatchCreateInstanceIpRuleResponse> BatchCreateInstanceIpRuleInvoker(BatchCreateInstanceIpRuleRequest batchCreateInstanceIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip", batchCreateInstanceIpRuleRequest.Ip.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateInstanceIpRuleRequest);
            return new SyncInvoker<BatchCreateInstanceIpRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateInstanceIpRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip", batchDeleteInstanceIpRuleRequest.Ip.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceIpRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteInstanceIpRuleResponse>(response);
        }

        public SyncInvoker<BatchDeleteInstanceIpRuleResponse> BatchDeleteInstanceIpRuleInvoker(BatchDeleteInstanceIpRuleRequest batchDeleteInstanceIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip", batchDeleteInstanceIpRuleRequest.Ip.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceIpRuleRequest);
            return new SyncInvoker<BatchDeleteInstanceIpRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteInstanceIpRuleResponse>);
        }
        
        /// <summary>
        /// 创建防护域名
        ///
        /// 创建防护域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAadDomainResponse CreateAadDomain(CreateAadDomainRequest createAadDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAadDomainRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAadDomainResponse>(response);
        }

        public SyncInvoker<CreateAadDomainResponse> CreateAadDomainInvoker(CreateAadDomainRequest createAadDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAadDomainRequest);
            return new SyncInvoker<CreateAadDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAadDomainResponse>);
        }
        
        /// <summary>
        /// 上传/修改域名对应证书
        ///
        /// 上传/修改域名对应证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCertificateResponse CreateCertificate(CreateCertificateRequest createCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/domains/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCertificateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateCertificateResponse>(response);
        }

        public SyncInvoker<CreateCertificateResponse> CreateCertificateInvoker(CreateCertificateRequest createCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/domains/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCertificateRequest);
            return new SyncInvoker<CreateCertificateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateCertificateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyResponse>(response);
        }

        public SyncInvoker<CreatePolicyResponse> CreatePolicyInvoker(CreatePolicyRequest createPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyRequest);
            return new SyncInvoker<CreatePolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmConfigRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAlarmConfigResponse>(response);
        }

        public SyncInvoker<DeleteAlarmConfigResponse> DeleteAlarmConfigInvoker(DeleteAlarmConfigRequest deleteAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmConfigRequest);
            return new SyncInvoker<DeleteAlarmConfigResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAlarmConfigResponse>);
        }
        
        /// <summary>
        /// 高防实例删除黑白名单
        ///
        /// 高防实例删除黑白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBlackWhiteIpListResponse DeleteBlackWhiteIpList(DeleteBlackWhiteIpListRequest deleteBlackWhiteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/bwlist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBlackWhiteIpListRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBlackWhiteIpListResponse>(response);
        }

        public SyncInvoker<DeleteBlackWhiteIpListResponse> DeleteBlackWhiteIpListInvoker(DeleteBlackWhiteIpListRequest deleteBlackWhiteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/bwlist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBlackWhiteIpListRequest);
            return new SyncInvoker<DeleteBlackWhiteIpListResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBlackWhiteIpListResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", deletePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyResponse>(response);
        }

        public SyncInvoker<DeletePolicyResponse> DeletePolicyInvoker(DeletePolicyRequest deletePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", deletePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            return new SyncInvoker<DeletePolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", deletePolicyBlackAndWhiteIpListRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/ip-list/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyBlackAndWhiteIpListRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeletePolicyBlackAndWhiteIpListResponse>(response);
        }

        public SyncInvoker<DeletePolicyBlackAndWhiteIpListResponse> DeletePolicyBlackAndWhiteIpListInvoker(DeletePolicyBlackAndWhiteIpListRequest deletePolicyBlackAndWhiteIpListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", deletePolicyBlackAndWhiteIpListRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/ip-list/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyBlackAndWhiteIpListRequest);
            return new SyncInvoker<DeletePolicyBlackAndWhiteIpListResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeletePolicyBlackAndWhiteIpListResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", disassociateIpFromPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateIpFromPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisassociateIpFromPolicyResponse>(response);
        }

        public SyncInvoker<DisassociateIpFromPolicyResponse> DisassociateIpFromPolicyInvoker(DisassociateIpFromPolicyRequest disassociateIpFromPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", disassociateIpFromPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateIpFromPolicyRequest);
            return new SyncInvoker<DisassociateIpFromPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisassociateIpFromPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainResponse>(response);
        }

        public SyncInvoker<ListDomainResponse> ListDomainInvoker(ListDomainRequest listDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainRequest);
            return new SyncInvoker<ListDomainResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceResponse>(response);
        }

        public SyncInvoker<ListInstanceResponse> ListInstanceInvoker(ListInstanceRequest listInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRequest);
            return new SyncInvoker<ListInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listInstanceIdRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceIdResponse>(response);
        }

        public SyncInvoker<ListInstanceIdResponse> ListInstanceIdInvoker(ListInstanceIdRequest listInstanceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listInstanceIdRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceIdRequest);
            return new SyncInvoker<ListInstanceIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceIdResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip", listInstanceIpRuleRequest.Ip.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceIpRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceIpRuleResponse>(response);
        }

        public SyncInvoker<ListInstanceIpRuleResponse> ListInstanceIpRuleInvoker(ListInstanceIpRuleRequest listInstanceIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip", listInstanceIpRuleRequest.Ip.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceIpRuleRequest);
            return new SyncInvoker<ListInstanceIpRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceIpRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPackageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPackageResponse>(response);
        }

        public SyncInvoker<ListPackageResponse> ListPackageInvoker(ListPackageRequest listPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPackageRequest);
            return new SyncInvoker<ListPackageResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPackageResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPeakRequest.InstanceId.ToString());
            urlParam.Add("ip", listPeakRequest.Ip.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/ddos-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPeakRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPeakResponse>(response);
        }

        public SyncInvoker<ListPeakResponse> ListPeakInvoker(ListPeakRequest listPeakRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPeakRequest.InstanceId.ToString());
            urlParam.Add("ip", listPeakRequest.Ip.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/ddos-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPeakRequest);
            return new SyncInvoker<ListPeakResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPeakResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyResponse>(response);
        }

        public SyncInvoker<ListPolicyResponse> ListPolicyInvoker(ListPolicyRequest listPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyRequest);
            return new SyncInvoker<ListPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/protected-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedIpRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProtectedIpResponse>(response);
        }

        public SyncInvoker<ListProtectedIpResponse> ListProtectedIpInvoker(ListProtectedIpRequest listProtectedIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/protected-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedIpRequest);
            return new SyncInvoker<ListProtectedIpResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProtectedIpResponse>);
        }
        
        /// <summary>
        /// 查询高防回源IP段列表
        ///
        /// 查询高防回源IP段列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSourceIpsResponse ListSourceIps(ListSourceIpsRequest listSourceIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/source-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSourceIpsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSourceIpsResponse>(response);
        }

        public SyncInvoker<ListSourceIpsResponse> ListSourceIpsInvoker(ListSourceIpsRequest listSourceIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/source-ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSourceIpsRequest);
            return new SyncInvoker<ListSourceIpsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSourceIpsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id", listUnboundProtectedIpRequest.PackageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/unbound-protected-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnboundProtectedIpRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUnboundProtectedIpResponse>(response);
        }

        public SyncInvoker<ListUnboundProtectedIpResponse> ListUnboundProtectedIpInvoker(ListUnboundProtectedIpRequest listUnboundProtectedIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id", listUnboundProtectedIpRequest.PackageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/unbound-protected-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUnboundProtectedIpRequest);
            return new SyncInvoker<ListUnboundProtectedIpResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUnboundProtectedIpResponse>);
        }
        
        /// <summary>
        /// 修改域名WEB基础防护开关/CC防护开关
        ///
        /// 修改域名WEB基础防护开关/CC防护开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyDomainWebSwitchResponse ModifyDomainWebSwitch(ModifyDomainWebSwitchRequest modifyDomainWebSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/domains/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyDomainWebSwitchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ModifyDomainWebSwitchResponse>(response);
        }

        public SyncInvoker<ModifyDomainWebSwitchResponse> ModifyDomainWebSwitchInvoker(ModifyDomainWebSwitchRequest modifyDomainWebSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/aad/external/domains/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyDomainWebSwitchRequest);
            return new SyncInvoker<ModifyDomainWebSwitchResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ModifyDomainWebSwitchResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAlarmConfigResponse>(response);
        }

        public SyncInvoker<ShowAlarmConfigResponse> ShowAlarmConfigInvoker(ShowAlarmConfigRequest showAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlarmConfigRequest);
            return new SyncInvoker<ShowAlarmConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlarmConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", showPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyResponse>(response);
        }

        public SyncInvoker<ShowPolicyResponse> ShowPolicyInvoker(ShowPolicyRequest showPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", showPolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            return new SyncInvoker<ShowPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateAlarmConfigResponse>(response);
        }

        public SyncInvoker<UpdateAlarmConfigResponse> UpdateAlarmConfigInvoker(UpdateAlarmConfigRequest updateAlarmConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/alarm-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmConfigRequest);
            return new SyncInvoker<UpdateAlarmConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAlarmConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainResponse>(response);
        }

        public SyncInvoker<UpdateDomainResponse> UpdateDomainInvoker(UpdateDomainRequest updateDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/protected-domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainRequest);
            return new SyncInvoker<UpdateDomainResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip", updateInstanceIpRuleRequest.Ip.ToString());
            urlParam.Add("rule_id", updateInstanceIpRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceIpRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceIpRuleResponse>(response);
        }

        public SyncInvoker<UpdateInstanceIpRuleResponse> UpdateInstanceIpRuleInvoker(UpdateInstanceIpRuleRequest updateInstanceIpRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceIpRuleRequest.InstanceId.ToString());
            urlParam.Add("ip", updateInstanceIpRuleRequest.Ip.ToString());
            urlParam.Add("rule_id", updateInstanceIpRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/aad/instances/{instance_id}/{ip}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceIpRuleRequest);
            return new SyncInvoker<UpdateInstanceIpRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceIpRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id", updatePackageIpRequest.PackageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/protected-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePackageIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdatePackageIpResponse>(response);
        }

        public SyncInvoker<UpdatePackageIpResponse> UpdatePackageIpInvoker(UpdatePackageIpRequest updatePackageIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id", updatePackageIpRequest.PackageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/protected-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePackageIpRequest);
            return new SyncInvoker<UpdatePackageIpResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdatePackageIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id", updatePackageNameRequest.PackageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePackageNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePackageNameResponse>(response);
        }

        public SyncInvoker<UpdatePackageNameResponse> UpdatePackageNameInvoker(UpdatePackageNameRequest updatePackageNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("package_id", updatePackageNameRequest.PackageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/packages/{package_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePackageNameRequest);
            return new SyncInvoker<UpdatePackageNameResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePackageNameResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", updatePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePolicyResponse>(response);
        }

        public SyncInvoker<UpdatePolicyResponse> UpdatePolicyInvoker(UpdatePolicyRequest updatePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", updatePolicyRequest.PolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyRequest);
            return new SyncInvoker<UpdatePolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/protected-ips/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTagForProtectedIpRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTagForProtectedIpResponse>(response);
        }

        public SyncInvoker<UpdateTagForProtectedIpResponse> UpdateTagForProtectedIpInvoker(UpdateTagForProtectedIpRequest updateTagForProtectedIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cnad/protected-ips/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTagForProtectedIpRequest);
            return new SyncInvoker<UpdateTagForProtectedIpResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTagForProtectedIpResponse>);
        }
        
    }
}