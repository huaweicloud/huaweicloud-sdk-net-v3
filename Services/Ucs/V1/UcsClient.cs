using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ucs.V1.Model;

namespace HuaweiCloud.SDK.Ucs.V1
{
    public partial class UcsClient : Client
    {
        public static ClientBuilder<UcsClient> NewBuilder()
        {
            return new ClientBuilder<UcsClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 安装插件实例
        ///
        /// 安装插件实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAddonInstanceResponse CreateAddonInstance(CreateAddonInstanceRequest createAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddonInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAddonInstanceResponse>(response);
        }

        public SyncInvoker<CreateAddonInstanceResponse> CreateAddonInstanceInvoker(CreateAddonInstanceRequest createAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddonInstanceRequest);
            return new SyncInvoker<CreateAddonInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 创建舰队策略实例
        ///
        /// 创建舰队策略实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateClusterGroupPolicyInstanceResponse CreateClusterGroupPolicyInstance(CreateClusterGroupPolicyInstanceRequest createClusterGroupPolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterGroupPolicyInstanceRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/policyinstance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterGroupPolicyInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateClusterGroupPolicyInstanceResponse>(response);
        }

        public SyncInvoker<CreateClusterGroupPolicyInstanceResponse> CreateClusterGroupPolicyInstanceInvoker(CreateClusterGroupPolicyInstanceRequest createClusterGroupPolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterGroupPolicyInstanceRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/policyinstance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterGroupPolicyInstanceRequest);
            return new SyncInvoker<CreateClusterGroupPolicyInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateClusterGroupPolicyInstanceResponse>);
        }
        
        /// <summary>
        /// 创建配置集合
        ///
        /// 创建配置集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateConfigSetResponse CreateConfigSet(CreateConfigSetRequest createConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateConfigSetResponse>(response);
        }

        public SyncInvoker<CreateConfigSetResponse> CreateConfigSetInvoker(CreateConfigSetRequest createConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigSetRequest);
            return new SyncInvoker<CreateConfigSetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConfigSetResponse>);
        }
        
        /// <summary>
        /// 创建联邦网络连接并下载联邦kubeconfig
        ///
        /// 舰队开通联邦后，调用此接口，创建vpcep终端节点，连接到联邦apiserver，并下载联邦apiserver的kubeconfig
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFederationCertResponse CreateFederationCert(CreateFederationCertRequest createFederationCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFederationCertRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/cert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFederationCertRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFederationCertResponse>(response);
        }

        public SyncInvoker<CreateFederationCertResponse> CreateFederationCertInvoker(CreateFederationCertRequest createFederationCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFederationCertRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/cert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFederationCertRequest);
            return new SyncInvoker<CreateFederationCertResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFederationCertResponse>);
        }
        
        /// <summary>
        /// 创建联邦网络连接
        ///
        /// 舰队开通联邦后，创建vpcep终端节点连接到联邦apiserver
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFederationConnectionResponse CreateFederationConnection(CreateFederationConnectionRequest createFederationConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFederationConnectionRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFederationConnectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFederationConnectionResponse>(response);
        }

        public SyncInvoker<CreateFederationConnectionResponse> CreateFederationConnectionInvoker(CreateFederationConnectionRequest createFederationConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFederationConnectionRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFederationConnectionRequest);
            return new SyncInvoker<CreateFederationConnectionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFederationConnectionResponse>);
        }
        
        /// <summary>
        /// 创建联邦工作负载
        ///
        /// 创建联邦工作负载
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateProxyUnitedWorkloadResponse CreateProxyUnitedWorkload(CreateProxyUnitedWorkloadRequest createProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProxyUnitedWorkloadRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateProxyUnitedWorkloadResponse>(response);
        }

        public SyncInvoker<CreateProxyUnitedWorkloadResponse> CreateProxyUnitedWorkloadInvoker(CreateProxyUnitedWorkloadRequest createProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProxyUnitedWorkloadRequest);
            return new SyncInvoker<CreateProxyUnitedWorkloadResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateProxyUnitedWorkloadResponse>);
        }
        
        /// <summary>
        /// 创建域名解析记录集
        ///
        /// 创建域名解析记录集
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRecordSetResponse CreateRecordSet(CreateRecordSetRequest createRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/traffic/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetRequest);
            var response = DoHttpRequestSync("POST", request);
            var createRecordSetResponse = JsonUtils.DeSerializeNull<CreateRecordSetResponse>(response);
            createRecordSetResponse.Body = JsonUtils.DeSerializeList<RecordSet>(response);
            return createRecordSetResponse;
        }

        public SyncInvoker<CreateRecordSetResponse> CreateRecordSetInvoker(CreateRecordSetRequest createRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/traffic/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetRequest);
            return new SyncInvoker<CreateRecordSetResponse>(this, "POST", request, response =>
            {
                var createRecordSetResponse = JsonUtils.DeSerializeNull<CreateRecordSetResponse>(response);
                createRecordSetResponse.Body = JsonUtils.DeSerializeList<RecordSet>(response);
                return createRecordSetResponse;
            });
        }
        
        /// <summary>
        /// 创建仓库源
        ///
        /// 创建仓库源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRepoResponse CreateRepo(CreateRepoRequest createRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRepoResponse>(response);
        }

        public SyncInvoker<CreateRepoResponse> CreateRepoInvoker(CreateRepoRequest createRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoRequest);
            return new SyncInvoker<CreateRepoResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRepoResponse>);
        }
        
        /// <summary>
        /// 创建权限策略
        ///
        /// 创建权限策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRuleResponse CreateRule(CreateRuleRequest createRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", createRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRuleResponse>(response);
        }

        public SyncInvoker<CreateRuleResponse> CreateRuleInvoker(CreateRuleRequest createRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", createRuleRequest);
            return new SyncInvoker<CreateRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRuleResponse>);
        }
        
        /// <summary>
        /// 卸载插件实例
        ///
        /// 卸载插件实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAddonInstanceResponse DeleteAddonInstance(DeleteAddonInstanceRequest deleteAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddonInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAddonInstanceResponse>(response);
        }

        public SyncInvoker<DeleteAddonInstanceResponse> DeleteAddonInstanceInvoker(DeleteAddonInstanceRequest deleteAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddonInstanceRequest);
            return new SyncInvoker<DeleteAddonInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 删除容器舰队
        ///
        /// 容器舰队删除接口，只有在容器舰队为空时才可以删除该容器舰队，若需删除请先将集群移出容器舰队；传入的cluster ID必须符合k8s UUID的格式规则；同时需要用户有对应集群的操作权限，否则会鉴权失败
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteClusterGroupResponse DeleteClusterGroup(DeleteClusterGroupRequest deleteClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterGroupRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteClusterGroupResponse>(response);
        }

        public SyncInvoker<DeleteClusterGroupResponse> DeleteClusterGroupInvoker(DeleteClusterGroupRequest deleteClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterGroupRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterGroupRequest);
            return new SyncInvoker<DeleteClusterGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteClusterGroupResponse>);
        }
        
        /// <summary>
        /// 删除配置集合
        ///
        /// 仅删除配置集合，不删除仓库源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteConfigSetResponse DeleteConfigSet(DeleteConfigSetRequest deleteConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConfigSetRequest.Configsetid, out var valueOfConfigsetid)) urlParam.Add("configsetid", valueOfConfigsetid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/{configsetid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConfigSetResponse>(response);
        }

        public SyncInvoker<DeleteConfigSetResponse> DeleteConfigSetInvoker(DeleteConfigSetRequest deleteConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConfigSetRequest.Configsetid, out var valueOfConfigsetid)) urlParam.Add("configsetid", valueOfConfigsetid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/{configsetid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigSetRequest);
            return new SyncInvoker<DeleteConfigSetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteConfigSetResponse>);
        }
        
        /// <summary>
        /// 删除指定策略实例
        ///
        /// 删除指定策略实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePolicyInstanceResponse DeletePolicyInstance(DeletePolicyInstanceRequest deletePolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyInstanceRequest.Policyinstanceid, out var valueOfPolicyinstanceid)) urlParam.Add("policyinstanceid", valueOfPolicyinstanceid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances/{policyinstanceid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePolicyInstanceResponse>(response);
        }

        public SyncInvoker<DeletePolicyInstanceResponse> DeletePolicyInstanceInvoker(DeletePolicyInstanceRequest deletePolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyInstanceRequest.Policyinstanceid, out var valueOfPolicyinstanceid)) urlParam.Add("policyinstanceid", valueOfPolicyinstanceid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances/{policyinstanceid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyInstanceRequest);
            return new SyncInvoker<DeletePolicyInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePolicyInstanceResponse>);
        }
        
        /// <summary>
        /// 删除联邦工作负载
        ///
        /// 删除联邦工作负载
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteProxyUnitedWorkloadResponse DeleteProxyUnitedWorkload(DeleteProxyUnitedWorkloadRequest deleteProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProxyUnitedWorkloadRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteProxyUnitedWorkloadResponse>(response);
        }

        public SyncInvoker<DeleteProxyUnitedWorkloadResponse> DeleteProxyUnitedWorkloadInvoker(DeleteProxyUnitedWorkloadRequest deleteProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProxyUnitedWorkloadRequest);
            return new SyncInvoker<DeleteProxyUnitedWorkloadResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProxyUnitedWorkloadResponse>);
        }
        
        /// <summary>
        /// 删除仓库源
        ///
        /// 删除仓库源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRepoResponse DeleteRepo(DeleteRepoRequest deleteRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoRequest.Repoid, out var valueOfRepoid)) urlParam.Add("repoid", valueOfRepoid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos/{repoid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepoResponse>(response);
        }

        public SyncInvoker<DeleteRepoResponse> DeleteRepoInvoker(DeleteRepoRequest deleteRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoRequest.Repoid, out var valueOfRepoid)) urlParam.Add("repoid", valueOfRepoid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos/{repoid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoRequest);
            return new SyncInvoker<DeleteRepoResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRepoResponse>);
        }
        
        /// <summary>
        /// 删除权限策略
        ///
        /// 删除权限策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRuleResponse DeleteRule(DeleteRuleRequest deleteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleRequest.Ruleid, out var valueOfRuleid)) urlParam.Add("ruleid", valueOfRuleid);
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules/{ruleid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRuleResponse>(response);
        }

        public SyncInvoker<DeleteRuleResponse> DeleteRuleInvoker(DeleteRuleRequest deleteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleRequest.Ruleid, out var valueOfRuleid)) urlParam.Add("ruleid", valueOfRuleid);
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules/{ruleid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleRequest);
            return new SyncInvoker<DeleteRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRuleResponse>);
        }
        
        /// <summary>
        /// 舰队关闭策略中心
        ///
        /// 舰队关闭策略中心
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableClustergroupPolicyResponse DisableClustergroupPolicy(DisableClustergroupPolicyRequest disableClustergroupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableClustergroupPolicyRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableClustergroupPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DisableClustergroupPolicyResponse>(response);
        }

        public SyncInvoker<DisableClustergroupPolicyResponse> DisableClustergroupPolicyInvoker(DisableClustergroupPolicyRequest disableClustergroupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableClustergroupPolicyRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableClustergroupPolicyRequest);
            return new SyncInvoker<DisableClustergroupPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DisableClustergroupPolicyResponse>);
        }
        
        /// <summary>
        /// 关闭容器集群联邦
        ///
        /// 关闭容器舰队联邦
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableFederationResponse DisableFederation(DisableFederationRequest disableFederationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableFederationRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableFederationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DisableFederationResponse>(response);
        }

        public SyncInvoker<DisableFederationResponse> DisableFederationInvoker(DisableFederationRequest disableFederationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableFederationRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableFederationRequest);
            return new SyncInvoker<DisableFederationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DisableFederationResponse>);
        }
        
        /// <summary>
        /// 下载联邦kubeconfig
        ///
        /// 舰队开通联邦并且创建网络连接之后，可以使用此接口下载联邦的kubeconfig
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadFederationKubeconfigResponse DownloadFederationKubeconfig(DownloadFederationKubeconfigRequest downloadFederationKubeconfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadFederationKubeconfigRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/kubeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadFederationKubeconfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DownloadFederationKubeconfigResponse>(response);
        }

        public SyncInvoker<DownloadFederationKubeconfigResponse> DownloadFederationKubeconfigInvoker(DownloadFederationKubeconfigRequest downloadFederationKubeconfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadFederationKubeconfigRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/kubeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadFederationKubeconfigRequest);
            return new SyncInvoker<DownloadFederationKubeconfigResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadFederationKubeconfigResponse>);
        }
        
        /// <summary>
        /// 舰队启用策略中心
        ///
        /// 舰队启用策略中心
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableClustergroupPolicyResponse EnableClustergroupPolicy(EnableClustergroupPolicyRequest enableClustergroupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableClustergroupPolicyRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableClustergroupPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnableClustergroupPolicyResponse>(response);
        }

        public SyncInvoker<EnableClustergroupPolicyResponse> EnableClustergroupPolicyInvoker(EnableClustergroupPolicyRequest enableClustergroupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableClustergroupPolicyRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableClustergroupPolicyRequest);
            return new SyncInvoker<EnableClustergroupPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableClustergroupPolicyResponse>);
        }
        
        /// <summary>
        /// 启用容器舰队联邦
        ///
        /// 启用容器舰队联邦
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableFederationResponse EnableFederation(EnableFederationRequest enableFederationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableFederationRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableFederationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnableFederationResponse>(response);
        }

        public SyncInvoker<EnableFederationResponse> EnableFederationInvoker(EnableFederationRequest enableFederationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableFederationRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableFederationRequest);
            return new SyncInvoker<EnableFederationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableFederationResponse>);
        }
        
        /// <summary>
        /// 集群加入容器舰队
        ///
        /// 集群加入容器舰队
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public JoinGroupResponse JoinGroup(JoinGroupRequest joinGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(joinGroupRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/join", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", joinGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<JoinGroupResponse>(response);
        }

        public SyncInvoker<JoinGroupResponse> JoinGroupInvoker(JoinGroupRequest joinGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(joinGroupRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/join", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", joinGroupRequest);
            return new SyncInvoker<JoinGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<JoinGroupResponse>);
        }
        
        /// <summary>
        /// 集群移出容器舰队
        ///
        /// 集群退出容器舰队
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public LeaveGroupResponse LeaveGroup(LeaveGroupRequest leaveGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(leaveGroupRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/unjoin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", leaveGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<LeaveGroupResponse>(response);
        }

        public SyncInvoker<LeaveGroupResponse> LeaveGroupInvoker(LeaveGroupRequest leaveGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(leaveGroupRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/unjoin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", leaveGroupRequest);
            return new SyncInvoker<LeaveGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<LeaveGroupResponse>);
        }
        
        /// <summary>
        /// 获取插件实例列表
        ///
        /// 获取插件实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAddonInstancesResponse ListAddonInstances(ListAddonInstancesRequest listAddonInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAddonInstancesResponse>(response);
        }

        public SyncInvoker<ListAddonInstancesResponse> ListAddonInstancesInvoker(ListAddonInstancesRequest listAddonInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonInstancesRequest);
            return new SyncInvoker<ListAddonInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddonInstancesResponse>);
        }
        
        /// <summary>
        /// 获取插件模板列表
        ///
        /// 获取插件模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAddonTemplatesResponse ListAddonTemplates(ListAddonTemplatesRequest listAddonTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/addontemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAddonTemplatesResponse>(response);
        }

        public SyncInvoker<ListAddonTemplatesResponse> ListAddonTemplatesInvoker(ListAddonTemplatesRequest listAddonTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/addontemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonTemplatesRequest);
            return new SyncInvoker<ListAddonTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddonTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取容器舰队列表
        ///
        /// 获取所有容器舰队信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListClusterGroupResponse ListClusterGroup(ListClusterGroupRequest listClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListClusterGroupResponse>(response);
        }

        public SyncInvoker<ListClusterGroupResponse> ListClusterGroupInvoker(ListClusterGroupRequest listClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterGroupRequest);
            return new SyncInvoker<ListClusterGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClusterGroupResponse>);
        }
        
        /// <summary>
        /// 获取所有配置集合信息
        ///
        /// 获取所有配置集合信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConfigSetsResponse ListConfigSets(ListConfigSetsRequest listConfigSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigSetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConfigSetsResponse>(response);
        }

        public SyncInvoker<ListConfigSetsResponse> ListConfigSetsInvoker(ListConfigSetsRequest listConfigSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigSetsRequest);
            return new SyncInvoker<ListConfigSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigSetsResponse>);
        }
        
        /// <summary>
        /// 获取策略定义列表
        ///
        /// 获取策略定义列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyDefinitionsResponse ListPolicyDefinitions(ListPolicyDefinitionsRequest listPolicyDefinitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/policydefinitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyDefinitionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyDefinitionsResponse>(response);
        }

        public SyncInvoker<ListPolicyDefinitionsResponse> ListPolicyDefinitionsInvoker(ListPolicyDefinitionsRequest listPolicyDefinitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/policydefinitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyDefinitionsRequest);
            return new SyncInvoker<ListPolicyDefinitionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyDefinitionsResponse>);
        }
        
        /// <summary>
        /// 获取策略实例列表
        ///
        /// 获取策略实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyInstancesResponse ListPolicyInstances(ListPolicyInstancesRequest listPolicyInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyInstancesResponse>(response);
        }

        public SyncInvoker<ListPolicyInstancesResponse> ListPolicyInstancesInvoker(ListPolicyInstancesRequest listPolicyInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyInstancesRequest);
            return new SyncInvoker<ListPolicyInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyInstancesResponse>);
        }
        
        /// <summary>
        /// 获取策略实例任务列表
        ///
        /// 获取策略实例任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyJobsResponse ListPolicyJobs(ListPolicyJobsRequest listPolicyJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/policy/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyJobsResponse>(response);
        }

        public SyncInvoker<ListPolicyJobsResponse> ListPolicyJobsInvoker(ListPolicyJobsRequest listPolicyJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/policy/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyJobsRequest);
            return new SyncInvoker<ListPolicyJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyJobsResponse>);
        }
        
        /// <summary>
        /// 查询域名解析记录集列表
        ///
        /// 查询域名解析记录集列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecordSetsResponse ListRecordSets(ListRecordSetsRequest listRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/traffic/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRecordSetsResponse>(response);
        }

        public SyncInvoker<ListRecordSetsResponse> ListRecordSetsInvoker(ListRecordSetsRequest listRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/traffic/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsRequest);
            return new SyncInvoker<ListRecordSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordSetsResponse>);
        }
        
        /// <summary>
        /// 获取仓库源列表
        ///
        /// 获取仓库源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListReposResponse ListRepos(ListReposRequest listReposRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReposRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListReposResponse>(response);
        }

        public SyncInvoker<ListReposResponse> ListReposInvoker(ListReposRequest listReposRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReposRequest);
            return new SyncInvoker<ListReposResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReposResponse>);
        }
        
        /// <summary>
        /// 获取权限策略列表
        ///
        /// 获取权限策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRuleResponse ListRule(ListRuleRequest listRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRuleResponse>(response);
        }

        public SyncInvoker<ListRuleResponse> ListRuleInvoker(ListRuleRequest listRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleRequest);
            return new SyncInvoker<ListRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRuleResponse>);
        }
        
        /// <summary>
        /// 查询服务配置信息
        ///
        /// 获取各个类型集群的全局配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServerConfigsResponse ListServerConfigs(ListServerConfigsRequest listServerConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/serverconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServerConfigsResponse>(response);
        }

        public SyncInvoker<ListServerConfigsResponse> ListServerConfigsInvoker(ListServerConfigsRequest listServerConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/serverconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerConfigsRequest);
            return new SyncInvoker<ListServerConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerConfigsResponse>);
        }
        
        /// <summary>
        /// 注册容器舰队
        ///
        /// 容器舰队创建API，生成容器舰队时可以选择关联的集群
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RegisterClusterGroupResponse RegisterClusterGroup(RegisterClusterGroupRequest registerClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", registerClusterGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RegisterClusterGroupResponse>(response);
        }

        public SyncInvoker<RegisterClusterGroupResponse> RegisterClusterGroupInvoker(RegisterClusterGroupRequest registerClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", registerClusterGroupRequest);
            return new SyncInvoker<RegisterClusterGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterClusterGroupResponse>);
        }
        
        /// <summary>
        /// 获取插件实例
        ///
        /// 获取插件实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAddonInstanceResponse ShowAddonInstance(ShowAddonInstanceRequest showAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddonInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAddonInstanceResponse>(response);
        }

        public SyncInvoker<ShowAddonInstanceResponse> ShowAddonInstanceInvoker(ShowAddonInstanceRequest showAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddonInstanceRequest);
            return new SyncInvoker<ShowAddonInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 获取单个容器舰队
        ///
        /// 获取单个容器舰队
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClusterGroupResponse ShowClusterGroup(ShowClusterGroupRequest showClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterGroupRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterGroupResponse>(response);
        }

        public SyncInvoker<ShowClusterGroupResponse> ShowClusterGroupInvoker(ShowClusterGroupRequest showClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterGroupRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterGroupRequest);
            return new SyncInvoker<ShowClusterGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterGroupResponse>);
        }
        
        /// <summary>
        /// 获取配置集合详细信息
        ///
        /// 获取配置集合详细信息，包含仓库源信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConfigSetResponse ShowConfigSet(ShowConfigSetRequest showConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigSetRequest.Configsetid, out var valueOfConfigsetid)) urlParam.Add("configsetid", valueOfConfigsetid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/{configsetid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigSetResponse>(response);
        }

        public SyncInvoker<ShowConfigSetResponse> ShowConfigSetInvoker(ShowConfigSetRequest showConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigSetRequest.Configsetid, out var valueOfConfigsetid)) urlParam.Add("configsetid", valueOfConfigsetid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/{configsetid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigSetRequest);
            return new SyncInvoker<ShowConfigSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigSetResponse>);
        }
        
        /// <summary>
        /// 查询联邦开启进度
        ///
        /// 查询联邦开启进度
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFederationProgressResponse ShowFederationProgress(ShowFederationProgressRequest showFederationProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFederationProgressRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFederationProgressRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFederationProgressResponse>(response);
        }

        public SyncInvoker<ShowFederationProgressResponse> ShowFederationProgressInvoker(ShowFederationProgressRequest showFederationProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFederationProgressRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFederationProgressRequest);
            return new SyncInvoker<ShowFederationProgressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFederationProgressResponse>);
        }
        
        /// <summary>
        /// 统计某个用户所有配置集合的运行状态
        ///
        /// 统计某个用户所有配置集合的运行状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGitopsStatisticsResponse ShowGitopsStatistics(ShowGitopsStatisticsRequest showGitopsStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGitopsStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGitopsStatisticsResponse>(response);
        }

        public SyncInvoker<ShowGitopsStatisticsResponse> ShowGitopsStatisticsInvoker(ShowGitopsStatisticsRequest showGitopsStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGitopsStatisticsRequest);
            return new SyncInvoker<ShowGitopsStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGitopsStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取策略定义
        ///
        /// 获取策略定义
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPolicyDefinitionResponse ShowPolicyDefinition(ShowPolicyDefinitionRequest showPolicyDefinitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyDefinitionRequest.Policydefinitionid, out var valueOfPolicydefinitionid)) urlParam.Add("policydefinitionid", valueOfPolicydefinitionid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policydefinitions/{policydefinitionid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyDefinitionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyDefinitionResponse>(response);
        }

        public SyncInvoker<ShowPolicyDefinitionResponse> ShowPolicyDefinitionInvoker(ShowPolicyDefinitionRequest showPolicyDefinitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyDefinitionRequest.Policydefinitionid, out var valueOfPolicydefinitionid)) urlParam.Add("policydefinitionid", valueOfPolicydefinitionid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policydefinitions/{policydefinitionid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyDefinitionRequest);
            return new SyncInvoker<ShowPolicyDefinitionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyDefinitionResponse>);
        }
        
        /// <summary>
        /// 获取指定策略实例
        ///
        /// 获取指定策略实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPolicyInstanceResponse ShowPolicyInstance(ShowPolicyInstanceRequest showPolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyInstanceRequest.Policyinstanceid, out var valueOfPolicyinstanceid)) urlParam.Add("policyinstanceid", valueOfPolicyinstanceid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances/{policyinstanceid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyInstanceResponse>(response);
        }

        public SyncInvoker<ShowPolicyInstanceResponse> ShowPolicyInstanceInvoker(ShowPolicyInstanceRequest showPolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyInstanceRequest.Policyinstanceid, out var valueOfPolicyinstanceid)) urlParam.Add("policyinstanceid", valueOfPolicyinstanceid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances/{policyinstanceid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyInstanceRequest);
            return new SyncInvoker<ShowPolicyInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyInstanceResponse>);
        }
        
        /// <summary>
        /// 获取指定策略实例相关任务
        ///
        /// 获取指定策略实例相关任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPolicyJobResponse ShowPolicyJob(ShowPolicyJobRequest showPolicyJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyJobRequest.Jobid, out var valueOfJobid)) urlParam.Add("jobid", valueOfJobid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policy/jobs/{jobid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyJobResponse>(response);
        }

        public SyncInvoker<ShowPolicyJobResponse> ShowPolicyJobInvoker(ShowPolicyJobRequest showPolicyJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyJobRequest.Jobid, out var valueOfJobid)) urlParam.Add("jobid", valueOfJobid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policy/jobs/{jobid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyJobRequest);
            return new SyncInvoker<ShowPolicyJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyJobResponse>);
        }
        
        /// <summary>
        /// 查询联邦工作负载
        ///
        /// 查询联邦工作负载
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProxyUnitedWorkloadResponse ShowProxyUnitedWorkload(ShowProxyUnitedWorkloadRequest showProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProxyUnitedWorkloadRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProxyUnitedWorkloadResponse>(response);
        }

        public SyncInvoker<ShowProxyUnitedWorkloadResponse> ShowProxyUnitedWorkloadInvoker(ShowProxyUnitedWorkloadRequest showProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProxyUnitedWorkloadRequest);
            return new SyncInvoker<ShowProxyUnitedWorkloadResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProxyUnitedWorkloadResponse>);
        }
        
        /// <summary>
        /// 获取配额信息
        ///
        /// 获取UCS配额信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQuotaResponse ShowQuota(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showQuotaRequest.Domainid, out var valueOfDomainid)) urlParam.Add("domainid", valueOfDomainid);
            var urlPath = HttpUtils.AddUrlPath("/v1/maintenance/quota/{domainid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }

        public SyncInvoker<ShowQuotaResponse> ShowQuotaInvoker(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showQuotaRequest.Domainid, out var valueOfDomainid)) urlParam.Add("domainid", valueOfDomainid);
            var urlPath = HttpUtils.AddUrlPath("/v1/maintenance/quota/{domainid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            return new SyncInvoker<ShowQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotaResponse>);
        }
        
        /// <summary>
        /// 更新插件实例
        ///
        /// 更新插件实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAddonInstanceResponse UpdateAddonInstance(UpdateAddonInstanceRequest updateAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddonInstanceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAddonInstanceResponse>(response);
        }

        public SyncInvoker<UpdateAddonInstanceResponse> UpdateAddonInstanceInvoker(UpdateAddonInstanceRequest updateAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddonInstanceRequest);
            return new SyncInvoker<UpdateAddonInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 更新容器舰队描述信息
        ///
        /// 更新集群所属的容器舰队description信息；需要用户对相应容器舰队有更新权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateClusterGroupResponse UpdateClusterGroup(UpdateClusterGroupRequest updateClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/description", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateClusterGroupResponse>(response);
        }

        public SyncInvoker<UpdateClusterGroupResponse> UpdateClusterGroupInvoker(UpdateClusterGroupRequest updateClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/description", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupRequest);
            return new SyncInvoker<UpdateClusterGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateClusterGroupResponse>);
        }
        
        /// <summary>
        /// 向容器舰队中添加集群
        ///
        /// 向容器舰队中添加集群，同批次可以添加一个或多个集群，该接口无法清空或减少管理的集群。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateClusterGroupAssociatedClustersResponse UpdateClusterGroupAssociatedClusters(UpdateClusterGroupAssociatedClustersRequest updateClusterGroupAssociatedClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupAssociatedClustersRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/associatedclusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupAssociatedClustersRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateClusterGroupAssociatedClustersResponse>(response);
        }

        public SyncInvoker<UpdateClusterGroupAssociatedClustersResponse> UpdateClusterGroupAssociatedClustersInvoker(UpdateClusterGroupAssociatedClustersRequest updateClusterGroupAssociatedClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupAssociatedClustersRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/associatedclusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupAssociatedClustersRequest);
            return new SyncInvoker<UpdateClusterGroupAssociatedClustersResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateClusterGroupAssociatedClustersResponse>);
        }
        
        /// <summary>
        /// 更新容器舰队关联权限策略
        ///
        /// 更新容器舰队关联权限策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateClusterGroupAssociatedRulesResponse UpdateClusterGroupAssociatedRules(UpdateClusterGroupAssociatedRulesRequest updateClusterGroupAssociatedRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupAssociatedRulesRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/associatedrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupAssociatedRulesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateClusterGroupAssociatedRulesResponse>(response);
        }

        public SyncInvoker<UpdateClusterGroupAssociatedRulesResponse> UpdateClusterGroupAssociatedRulesInvoker(UpdateClusterGroupAssociatedRulesRequest updateClusterGroupAssociatedRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupAssociatedRulesRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/associatedrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupAssociatedRulesRequest);
            return new SyncInvoker<UpdateClusterGroupAssociatedRulesResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateClusterGroupAssociatedRulesResponse>);
        }
        
        /// <summary>
        /// 更新容器舰队的联邦对应的zone
        ///
        /// 更新容器舰队的集群联邦关联的zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateClusterGroupAssociatedZonesResponse UpdateClusterGroupAssociatedZones(UpdateClusterGroupAssociatedZonesRequest updateClusterGroupAssociatedZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupAssociatedZonesRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/associatedzones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupAssociatedZonesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateClusterGroupAssociatedZonesResponse>(response);
        }

        public SyncInvoker<UpdateClusterGroupAssociatedZonesResponse> UpdateClusterGroupAssociatedZonesInvoker(UpdateClusterGroupAssociatedZonesRequest updateClusterGroupAssociatedZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupAssociatedZonesRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/associatedzones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupAssociatedZonesRequest);
            return new SyncInvoker<UpdateClusterGroupAssociatedZonesResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateClusterGroupAssociatedZonesResponse>);
        }
        
        /// <summary>
        /// 更新配置集合信息
        ///
        /// 仅更新配置集合，不更新仓库源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateConfigSetResponse UpdateConfigSet(UpdateConfigSetRequest updateConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConfigSetRequest.Configsetid, out var valueOfConfigsetid)) urlParam.Add("configsetid", valueOfConfigsetid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/{configsetid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigSetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateConfigSetResponse>(response);
        }

        public SyncInvoker<UpdateConfigSetResponse> UpdateConfigSetInvoker(UpdateConfigSetRequest updateConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConfigSetRequest.Configsetid, out var valueOfConfigsetid)) urlParam.Add("configsetid", valueOfConfigsetid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/{configsetid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigSetRequest);
            return new SyncInvoker<UpdateConfigSetResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateConfigSetResponse>);
        }
        
        /// <summary>
        /// 更新策略定义
        ///
        /// 更新策略定义
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePolicyDefinationResponse UpdatePolicyDefination(UpdatePolicyDefinationRequest updatePolicyDefinationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyDefinationRequest.Policydefinitionid, out var valueOfPolicydefinitionid)) urlParam.Add("policydefinitionid", valueOfPolicydefinitionid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policydefinitions/{policydefinitionid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyDefinationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePolicyDefinationResponse>(response);
        }

        public SyncInvoker<UpdatePolicyDefinationResponse> UpdatePolicyDefinationInvoker(UpdatePolicyDefinationRequest updatePolicyDefinationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyDefinationRequest.Policydefinitionid, out var valueOfPolicydefinitionid)) urlParam.Add("policydefinitionid", valueOfPolicydefinitionid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policydefinitions/{policydefinitionid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyDefinationRequest);
            return new SyncInvoker<UpdatePolicyDefinationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePolicyDefinationResponse>);
        }
        
        /// <summary>
        /// 更新指定策略实例
        ///
        /// 更新指定策略实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePolicyInstanceResponse UpdatePolicyInstance(UpdatePolicyInstanceRequest updatePolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyInstanceRequest.Policyinstanceid, out var valueOfPolicyinstanceid)) urlParam.Add("policyinstanceid", valueOfPolicyinstanceid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances/{policyinstanceid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyInstanceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePolicyInstanceResponse>(response);
        }

        public SyncInvoker<UpdatePolicyInstanceResponse> UpdatePolicyInstanceInvoker(UpdatePolicyInstanceRequest updatePolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyInstanceRequest.Policyinstanceid, out var valueOfPolicyinstanceid)) urlParam.Add("policyinstanceid", valueOfPolicyinstanceid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances/{policyinstanceid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyInstanceRequest);
            return new SyncInvoker<UpdatePolicyInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePolicyInstanceResponse>);
        }
        
        /// <summary>
        /// 更新联邦工作负载
        ///
        /// 更新联邦工作负载
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProxyUnitedWorkloadResponse UpdateProxyUnitedWorkload(UpdateProxyUnitedWorkloadRequest updateProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProxyUnitedWorkloadRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateProxyUnitedWorkloadResponse>(response);
        }

        public SyncInvoker<UpdateProxyUnitedWorkloadResponse> UpdateProxyUnitedWorkloadInvoker(UpdateProxyUnitedWorkloadRequest updateProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProxyUnitedWorkloadRequest);
            return new SyncInvoker<UpdateProxyUnitedWorkloadResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateProxyUnitedWorkloadResponse>);
        }
        
        /// <summary>
        /// 更新仓库源信息
        ///
        /// 更新仓库源信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRepoResponse UpdateRepo(UpdateRepoRequest updateRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRequest.Repoid, out var valueOfRepoid)) urlParam.Add("repoid", valueOfRepoid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos/{repoid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRepoResponse>(response);
        }

        public SyncInvoker<UpdateRepoResponse> UpdateRepoInvoker(UpdateRepoRequest updateRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRequest.Repoid, out var valueOfRepoid)) urlParam.Add("repoid", valueOfRepoid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos/{repoid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRequest);
            return new SyncInvoker<UpdateRepoResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRepoResponse>);
        }
        
        /// <summary>
        /// 更新权限策略
        ///
        /// 更新权限策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRuleResponse UpdateRule(UpdateRuleRequest updateRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRuleRequest.Ruleid, out var valueOfRuleid)) urlParam.Add("ruleid", valueOfRuleid);
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules/{ruleid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRuleResponse>(response);
        }

        public SyncInvoker<UpdateRuleResponse> UpdateRuleInvoker(UpdateRuleRequest updateRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRuleRequest.Ruleid, out var valueOfRuleid)) urlParam.Add("ruleid", valueOfRuleid);
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules/{ruleid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleRequest);
            return new SyncInvoker<UpdateRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRuleResponse>);
        }
        
        /// <summary>
        /// 升级容器舰队联邦
        ///
        /// 容器舰队联邦版本升级
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeFederationResponse UpgradeFederation(UpgradeFederationRequest upgradeFederationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeFederationRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeFederationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpgradeFederationResponse>(response);
        }

        public SyncInvoker<UpgradeFederationResponse> UpgradeFederationInvoker(UpgradeFederationRequest upgradeFederationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeFederationRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeFederationRequest);
            return new SyncInvoker<UpgradeFederationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpgradeFederationResponse>);
        }
        
        /// <summary>
        /// 获取集群安装时所需的配置信息
        ///
        /// 获取集群安装时所需的配置信息，当前仅本地集群使用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateClusterConfResponse CreateClusterConf(CreateClusterConfRequest createClusterConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterConfRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/clusterconf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterConfRequest);
            var response = DoHttpRequestSync("POST", request);
            var createClusterConfResponse = JsonUtils.DeSerializeNull<CreateClusterConfResponse>(response);
            createClusterConfResponse.Body = JsonUtils.DeSerializeMap<string, Object>(response);
            return createClusterConfResponse;
        }

        public SyncInvoker<CreateClusterConfResponse> CreateClusterConfInvoker(CreateClusterConfRequest createClusterConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterConfRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/clusterconf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterConfRequest);
            return new SyncInvoker<CreateClusterConfResponse>(this, "POST", request, response =>
            {
                var createClusterConfResponse = JsonUtils.DeSerializeNull<CreateClusterConfResponse>(response);
                createClusterConfResponse.Body = JsonUtils.DeSerializeMap<string, Object>(response);
                return createClusterConfResponse;
            });
        }
        
        /// <summary>
        /// 获取集群kubeconfig
        ///
        /// 获取集群kubeconfig
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateClusterKubeconfigResponse CreateClusterKubeconfig(CreateClusterKubeconfigRequest createClusterKubeconfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterKubeconfigRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/kubeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterKubeconfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateClusterKubeconfigResponse>(response);
        }

        public SyncInvoker<CreateClusterKubeconfigResponse> CreateClusterKubeconfigInvoker(CreateClusterKubeconfigRequest createClusterKubeconfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterKubeconfigRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/kubeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterKubeconfigRequest);
            return new SyncInvoker<CreateClusterKubeconfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateClusterKubeconfigResponse>);
        }
        
        /// <summary>
        /// 创建集群建策略实例
        ///
        /// 创建集群建策略实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateClusterPolicyInstanceResponse CreateClusterPolicyInstance(CreateClusterPolicyInstanceRequest createClusterPolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterPolicyInstanceRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/policyinstance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterPolicyInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateClusterPolicyInstanceResponse>(response);
        }

        public SyncInvoker<CreateClusterPolicyInstanceResponse> CreateClusterPolicyInstanceInvoker(CreateClusterPolicyInstanceRequest createClusterPolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterPolicyInstanceRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/policyinstance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterPolicyInstanceRequest);
            return new SyncInvoker<CreateClusterPolicyInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateClusterPolicyInstanceResponse>);
        }
        
        /// <summary>
        /// 删除集群
        ///
        /// 用于集群解除注册；传入的cluster ID必须符合k8s UUID的格式规则；同时需要用户有对应集群的操作权限，否则会鉴权失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteClusterResponse DeleteCluster(DeleteClusterRequest deleteClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteClusterResponse>(response);
        }

        public SyncInvoker<DeleteClusterResponse> DeleteClusterInvoker(DeleteClusterRequest deleteClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterRequest);
            return new SyncInvoker<DeleteClusterResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteClusterResponse>);
        }
        
        /// <summary>
        /// 集群关闭策略中心
        ///
        /// 集群关闭策略中心
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableClusterPolicyResponse DisableClusterPolicy(DisableClusterPolicyRequest disableClusterPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableClusterPolicyRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableClusterPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DisableClusterPolicyResponse>(response);
        }

        public SyncInvoker<DisableClusterPolicyResponse> DisableClusterPolicyInvoker(DisableClusterPolicyRequest disableClusterPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableClusterPolicyRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableClusterPolicyRequest);
            return new SyncInvoker<DisableClusterPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DisableClusterPolicyResponse>);
        }
        
        /// <summary>
        /// 卸载集群gitops插件
        ///
        /// 卸载集群gitops插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableGitOpsResponse DisableGitOps(DisableGitOpsRequest disableGitOpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableGitOpsRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/gitops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableGitOpsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DisableGitOpsResponse>(response);
        }

        public SyncInvoker<DisableGitOpsResponse> DisableGitOpsInvoker(DisableGitOpsRequest disableGitOpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableGitOpsRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/gitops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableGitOpsRequest);
            return new SyncInvoker<DisableGitOpsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DisableGitOpsResponse>);
        }
        
        /// <summary>
        /// 集群启用策略中心
        ///
        /// 集群启用策略中心
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableClusterPolicyResponse EnableClusterPolicy(EnableClusterPolicyRequest enableClusterPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableClusterPolicyRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableClusterPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnableClusterPolicyResponse>(response);
        }

        public SyncInvoker<EnableClusterPolicyResponse> EnableClusterPolicyInvoker(EnableClusterPolicyRequest enableClusterPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableClusterPolicyRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableClusterPolicyRequest);
            return new SyncInvoker<EnableClusterPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableClusterPolicyResponse>);
        }
        
        /// <summary>
        /// 启用Gitops插件
        ///
        /// 启用Gitops插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableGitOpsResponse EnableGitOps(EnableGitOpsRequest enableGitOpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableGitOpsRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/gitops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableGitOpsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnableGitOpsResponse>(response);
        }

        public SyncInvoker<EnableGitOpsResponse> EnableGitOpsInvoker(EnableGitOpsRequest enableGitOpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableGitOpsRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/gitops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableGitOpsRequest);
            return new SyncInvoker<EnableGitOpsResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableGitOpsResponse>);
        }
        
        /// <summary>
        /// 获取租户的CCE集群列表
        ///
        /// 获取当前租户的CCE集群列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListManagedClustersResponse ListManagedClusters(ListManagedClustersRequest listManagedClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managedclusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedClustersRequest);
            var response = DoHttpRequestSync("GET", request);
            var listManagedClustersResponse = JsonUtils.DeSerializeNull<ListManagedClustersResponse>(response);
            listManagedClustersResponse.Body = JsonUtils.DeSerializeList<Cluster>(response);
            return listManagedClustersResponse;
        }

        public SyncInvoker<ListManagedClustersResponse> ListManagedClustersInvoker(ListManagedClustersRequest listManagedClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managedclusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedClustersRequest);
            return new SyncInvoker<ListManagedClustersResponse>(this, "GET", request, response =>
            {
                var listManagedClustersResponse = JsonUtils.DeSerializeNull<ListManagedClustersResponse>(response);
                listManagedClustersResponse.Body = JsonUtils.DeSerializeList<Cluster>(response);
                return listManagedClustersResponse;
            });
        }
        
        /// <summary>
        /// 查询支持接入UCS的集群版本列表
        ///
        /// 查询支持接入UCS的集群版本列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRegisteredClusterVersionsResponse ListRegisteredClusterVersions(ListRegisteredClusterVersionsRequest listRegisteredClusterVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/config/registeredclusterversions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegisteredClusterVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRegisteredClusterVersionsResponse>(response);
        }

        public SyncInvoker<ListRegisteredClusterVersionsResponse> ListRegisteredClusterVersionsInvoker(ListRegisteredClusterVersionsRequest listRegisteredClusterVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/config/registeredclusterversions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegisteredClusterVersionsRequest);
            return new SyncInvoker<ListRegisteredClusterVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRegisteredClusterVersionsResponse>);
        }
        
        /// <summary>
        /// 注册集群
        ///
        /// 集群注册接口。支持三方集群的注册和CCE导入集群的注册。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RegisterClusterResponse RegisterCluster(RegisterClusterRequest registerClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", registerClusterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RegisterClusterResponse>(response);
        }

        public SyncInvoker<RegisterClusterResponse> RegisterClusterInvoker(RegisterClusterRequest registerClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", registerClusterRequest);
            return new SyncInvoker<RegisterClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterClusterResponse>);
        }
        
        /// <summary>
        /// 激活集群
        ///
        /// 激活集群接口；传入的cluster ID必须符合k8s UUID的格式规则；同时需要用户有对应集群的更新权限，否则会鉴权失败
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RetryClusterActivationResponse RetryClusterActivation(RetryClusterActivationRequest retryClusterActivationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryClusterActivationRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/activation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryClusterActivationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<RetryClusterActivationResponse>(response);
        }

        public SyncInvoker<RetryClusterActivationResponse> RetryClusterActivationInvoker(RetryClusterActivationRequest retryClusterActivationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryClusterActivationRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/activation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryClusterActivationRequest);
            return new SyncInvoker<RetryClusterActivationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<RetryClusterActivationResponse>);
        }
        
        /// <summary>
        /// 获取单个集群
        ///
        /// 获取集群信息。传入的cluster ID必须符合k8s UUID的格式规则；同时需要用户有对应集群的获取权限，否则会鉴权失败
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClusterResponse ShowCluster(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterResponse>(response);
        }

        public SyncInvoker<ShowClusterResponse> ShowClusterInvoker(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            return new SyncInvoker<ShowClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterResponse>);
        }
        
        /// <summary>
        /// 获取集群接入信息
        ///
        /// 该API接口用于获取集群接入信息；传入的cluster ID必须符合k8s UUID的格式规则；同时需要用户有对应集群证书的获取权限，否则会鉴权失败；agent证书只可以下载一次。仅用于获取三方集群的集群接入信息，CCE集群不从该接口获取，如果传入CCE集群ID，返回码为400
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClusterAccessInfoResponse ShowClusterAccessInfo(ShowClusterAccessInfoRequest showClusterAccessInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterAccessInfoRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/accessinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterAccessInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            var showClusterAccessInfoResponse = JsonUtils.DeSerializeNull<ShowClusterAccessInfoResponse>(response);
            showClusterAccessInfoResponse.Body = JsonUtils.DeSerializeList<byte[]>(response);
            return showClusterAccessInfoResponse;
        }

        public SyncInvoker<ShowClusterAccessInfoResponse> ShowClusterAccessInfoInvoker(ShowClusterAccessInfoRequest showClusterAccessInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterAccessInfoRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/accessinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterAccessInfoRequest);
            return new SyncInvoker<ShowClusterAccessInfoResponse>(this, "GET", request, response =>
            {
                var showClusterAccessInfoResponse = JsonUtils.DeSerializeNull<ShowClusterAccessInfoResponse>(response);
                showClusterAccessInfoResponse.Body = JsonUtils.DeSerializeList<byte[]>(response);
                return showClusterAccessInfoResponse;
            });
        }
        
        /// <summary>
        /// 获取集群列表
        ///
        /// 获取集群信息列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClusterListResponse ShowClusterList(ShowClusterListRequest showClusterListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterListResponse>(response);
        }

        public SyncInvoker<ShowClusterListResponse> ShowClusterListInvoker(ShowClusterListRequest showClusterListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterListRequest);
            return new SyncInvoker<ShowClusterListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterListResponse>);
        }
        
        /// <summary>
        /// 获取gitops启用进展
        ///
        /// 获取gitops启用进展
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGitOpsStatusResponse ShowGitOpsStatus(ShowGitOpsStatusRequest showGitOpsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGitOpsStatusRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/gitops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGitOpsStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGitOpsStatusResponse>(response);
        }

        public SyncInvoker<ShowGitOpsStatusResponse> ShowGitOpsStatusInvoker(ShowGitOpsStatusRequest showGitOpsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGitOpsStatusRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/gitops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGitOpsStatusRequest);
            return new SyncInvoker<ShowGitOpsStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGitOpsStatusResponse>);
        }
        
        /// <summary>
        /// 更新集群
        ///
        /// 更新集群。当前仅允许更新附着集群和本地集群的国家/城市，允许更新多云集群的工作节点个数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateClusterResponse UpdateCluster(UpdateClusterRequest updateClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateClusterResponse>(response);
        }

        public SyncInvoker<UpdateClusterResponse> UpdateClusterInvoker(UpdateClusterRequest updateClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRequest);
            return new SyncInvoker<UpdateClusterResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateClusterResponse>);
        }
        
        /// <summary>
        /// 集群关联权限策略
        ///
        /// 集群关联权限策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateClusterRulesResponse UpdateClusterRules(UpdateClusterRulesRequest updateClusterRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterRulesRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/associatedrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRulesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateClusterRulesResponse>(response);
        }

        public SyncInvoker<UpdateClusterRulesResponse> UpdateClusterRulesInvoker(UpdateClusterRulesRequest updateClusterRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterRulesRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/associatedrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRulesRequest);
            return new SyncInvoker<UpdateClusterRulesResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateClusterRulesResponse>);
        }
        
    }
}