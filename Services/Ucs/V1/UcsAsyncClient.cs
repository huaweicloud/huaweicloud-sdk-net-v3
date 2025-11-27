using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ucs.V1.Model;

namespace HuaweiCloud.SDK.Ucs.V1
{
    public partial class UcsAsyncClient : Client
    {
        public static ClientBuilder<UcsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<UcsAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 安装插件实例
        ///
        /// 安装插件实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAddonInstanceResponse> CreateAddonInstanceAsync(CreateAddonInstanceRequest createAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddonInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAddonInstanceResponse>(response);
        }

        public AsyncInvoker<CreateAddonInstanceResponse> CreateAddonInstanceAsyncInvoker(CreateAddonInstanceRequest createAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddonInstanceRequest);
            return new AsyncInvoker<CreateAddonInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 创建舰队策略实例
        ///
        /// 创建舰队策略实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateClusterGroupPolicyInstanceResponse> CreateClusterGroupPolicyInstanceAsync(CreateClusterGroupPolicyInstanceRequest createClusterGroupPolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterGroupPolicyInstanceRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/policyinstance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterGroupPolicyInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateClusterGroupPolicyInstanceResponse>(response);
        }

        public AsyncInvoker<CreateClusterGroupPolicyInstanceResponse> CreateClusterGroupPolicyInstanceAsyncInvoker(CreateClusterGroupPolicyInstanceRequest createClusterGroupPolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterGroupPolicyInstanceRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/policyinstance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterGroupPolicyInstanceRequest);
            return new AsyncInvoker<CreateClusterGroupPolicyInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateClusterGroupPolicyInstanceResponse>);
        }
        
        /// <summary>
        /// 创建配置集合
        ///
        /// 创建配置集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateConfigSetResponse> CreateConfigSetAsync(CreateConfigSetRequest createConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateConfigSetResponse>(response);
        }

        public AsyncInvoker<CreateConfigSetResponse> CreateConfigSetAsyncInvoker(CreateConfigSetRequest createConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConfigSetRequest);
            return new AsyncInvoker<CreateConfigSetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConfigSetResponse>);
        }
        
        /// <summary>
        /// 创建联邦网络连接并下载联邦kubeconfig
        ///
        /// 舰队开通联邦后，调用此接口，创建vpcep终端节点，连接到联邦apiserver，并下载联邦apiserver的kubeconfig
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFederationCertResponse> CreateFederationCertAsync(CreateFederationCertRequest createFederationCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFederationCertRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/cert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFederationCertRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateFederationCertResponse>(response);
        }

        public AsyncInvoker<CreateFederationCertResponse> CreateFederationCertAsyncInvoker(CreateFederationCertRequest createFederationCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFederationCertRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/cert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFederationCertRequest);
            return new AsyncInvoker<CreateFederationCertResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFederationCertResponse>);
        }
        
        /// <summary>
        /// 创建联邦网络连接
        ///
        /// 舰队开通联邦后，创建vpcep终端节点连接到联邦apiserver
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFederationConnectionResponse> CreateFederationConnectionAsync(CreateFederationConnectionRequest createFederationConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFederationConnectionRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFederationConnectionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateFederationConnectionResponse>(response);
        }

        public AsyncInvoker<CreateFederationConnectionResponse> CreateFederationConnectionAsyncInvoker(CreateFederationConnectionRequest createFederationConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFederationConnectionRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFederationConnectionRequest);
            return new AsyncInvoker<CreateFederationConnectionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFederationConnectionResponse>);
        }
        
        /// <summary>
        /// 创建联邦工作负载
        ///
        /// 创建联邦工作负载
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateProxyUnitedWorkloadResponse> CreateProxyUnitedWorkloadAsync(CreateProxyUnitedWorkloadRequest createProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProxyUnitedWorkloadRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateProxyUnitedWorkloadResponse>(response);
        }

        public AsyncInvoker<CreateProxyUnitedWorkloadResponse> CreateProxyUnitedWorkloadAsyncInvoker(CreateProxyUnitedWorkloadRequest createProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProxyUnitedWorkloadRequest);
            return new AsyncInvoker<CreateProxyUnitedWorkloadResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateProxyUnitedWorkloadResponse>);
        }
        
        /// <summary>
        /// 创建域名解析记录集
        ///
        /// 创建域名解析记录集
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordSetResponse> CreateRecordSetAsync(CreateRecordSetRequest createRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/traffic/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var createRecordSetResponse = JsonUtils.DeSerializeNull<CreateRecordSetResponse>(response);
            createRecordSetResponse.Body = JsonUtils.DeSerializeList<RecordSet>(response);
            return createRecordSetResponse;
        }

        public AsyncInvoker<CreateRecordSetResponse> CreateRecordSetAsyncInvoker(CreateRecordSetRequest createRecordSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/traffic/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetRequest);
            return new AsyncInvoker<CreateRecordSetResponse>(this, "POST", request, response =>
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
        public async Task<CreateRepoResponse> CreateRepoAsync(CreateRepoRequest createRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRepoResponse>(response);
        }

        public AsyncInvoker<CreateRepoResponse> CreateRepoAsyncInvoker(CreateRepoRequest createRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoRequest);
            return new AsyncInvoker<CreateRepoResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRepoResponse>);
        }
        
        /// <summary>
        /// 创建权限策略
        ///
        /// 创建权限策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest createRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", createRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRuleResponse>(response);
        }

        public AsyncInvoker<CreateRuleResponse> CreateRuleAsyncInvoker(CreateRuleRequest createRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", createRuleRequest);
            return new AsyncInvoker<CreateRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRuleResponse>);
        }
        
        /// <summary>
        /// 卸载插件实例
        ///
        /// 卸载插件实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAddonInstanceResponse> DeleteAddonInstanceAsync(DeleteAddonInstanceRequest deleteAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddonInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAddonInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteAddonInstanceResponse> DeleteAddonInstanceAsyncInvoker(DeleteAddonInstanceRequest deleteAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddonInstanceRequest);
            return new AsyncInvoker<DeleteAddonInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 删除容器舰队
        ///
        /// 容器舰队删除接口，只有在容器舰队为空时才可以删除该容器舰队，若需删除请先将集群移出容器舰队；传入的cluster ID必须符合k8s UUID的格式规则；同时需要用户有对应集群的操作权限，否则会鉴权失败
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteClusterGroupResponse> DeleteClusterGroupAsync(DeleteClusterGroupRequest deleteClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterGroupRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteClusterGroupResponse>(response);
        }

        public AsyncInvoker<DeleteClusterGroupResponse> DeleteClusterGroupAsyncInvoker(DeleteClusterGroupRequest deleteClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterGroupRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterGroupRequest);
            return new AsyncInvoker<DeleteClusterGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteClusterGroupResponse>);
        }
        
        /// <summary>
        /// 删除配置集合
        ///
        /// 仅删除配置集合，不删除仓库源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteConfigSetResponse> DeleteConfigSetAsync(DeleteConfigSetRequest deleteConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConfigSetRequest.Configsetid, out var valueOfConfigsetid)) urlParam.Add("configsetid", valueOfConfigsetid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/{configsetid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigSetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConfigSetResponse>(response);
        }

        public AsyncInvoker<DeleteConfigSetResponse> DeleteConfigSetAsyncInvoker(DeleteConfigSetRequest deleteConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConfigSetRequest.Configsetid, out var valueOfConfigsetid)) urlParam.Add("configsetid", valueOfConfigsetid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/{configsetid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConfigSetRequest);
            return new AsyncInvoker<DeleteConfigSetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteConfigSetResponse>);
        }
        
        /// <summary>
        /// 删除指定策略实例
        ///
        /// 删除指定策略实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePolicyInstanceResponse> DeletePolicyInstanceAsync(DeletePolicyInstanceRequest deletePolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyInstanceRequest.Policyinstanceid, out var valueOfPolicyinstanceid)) urlParam.Add("policyinstanceid", valueOfPolicyinstanceid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances/{policyinstanceid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePolicyInstanceResponse>(response);
        }

        public AsyncInvoker<DeletePolicyInstanceResponse> DeletePolicyInstanceAsyncInvoker(DeletePolicyInstanceRequest deletePolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyInstanceRequest.Policyinstanceid, out var valueOfPolicyinstanceid)) urlParam.Add("policyinstanceid", valueOfPolicyinstanceid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances/{policyinstanceid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyInstanceRequest);
            return new AsyncInvoker<DeletePolicyInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePolicyInstanceResponse>);
        }
        
        /// <summary>
        /// 删除联邦工作负载
        ///
        /// 删除联邦工作负载
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteProxyUnitedWorkloadResponse> DeleteProxyUnitedWorkloadAsync(DeleteProxyUnitedWorkloadRequest deleteProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProxyUnitedWorkloadRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteProxyUnitedWorkloadResponse>(response);
        }

        public AsyncInvoker<DeleteProxyUnitedWorkloadResponse> DeleteProxyUnitedWorkloadAsyncInvoker(DeleteProxyUnitedWorkloadRequest deleteProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProxyUnitedWorkloadRequest);
            return new AsyncInvoker<DeleteProxyUnitedWorkloadResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProxyUnitedWorkloadResponse>);
        }
        
        /// <summary>
        /// 删除仓库源
        ///
        /// 删除仓库源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRepoResponse> DeleteRepoAsync(DeleteRepoRequest deleteRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoRequest.Repoid, out var valueOfRepoid)) urlParam.Add("repoid", valueOfRepoid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos/{repoid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepoResponse>(response);
        }

        public AsyncInvoker<DeleteRepoResponse> DeleteRepoAsyncInvoker(DeleteRepoRequest deleteRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoRequest.Repoid, out var valueOfRepoid)) urlParam.Add("repoid", valueOfRepoid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos/{repoid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoRequest);
            return new AsyncInvoker<DeleteRepoResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRepoResponse>);
        }
        
        /// <summary>
        /// 删除权限策略
        ///
        /// 删除权限策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest deleteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleRequest.Ruleid, out var valueOfRuleid)) urlParam.Add("ruleid", valueOfRuleid);
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules/{ruleid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRuleResponse>(response);
        }

        public AsyncInvoker<DeleteRuleResponse> DeleteRuleAsyncInvoker(DeleteRuleRequest deleteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleRequest.Ruleid, out var valueOfRuleid)) urlParam.Add("ruleid", valueOfRuleid);
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules/{ruleid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleRequest);
            return new AsyncInvoker<DeleteRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRuleResponse>);
        }
        
        /// <summary>
        /// 舰队关闭策略中心
        ///
        /// 舰队关闭策略中心
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableClustergroupPolicyResponse> DisableClustergroupPolicyAsync(DisableClustergroupPolicyRequest disableClustergroupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableClustergroupPolicyRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableClustergroupPolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DisableClustergroupPolicyResponse>(response);
        }

        public AsyncInvoker<DisableClustergroupPolicyResponse> DisableClustergroupPolicyAsyncInvoker(DisableClustergroupPolicyRequest disableClustergroupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableClustergroupPolicyRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableClustergroupPolicyRequest);
            return new AsyncInvoker<DisableClustergroupPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DisableClustergroupPolicyResponse>);
        }
        
        /// <summary>
        /// 关闭容器集群联邦
        ///
        /// 关闭容器舰队联邦
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableFederationResponse> DisableFederationAsync(DisableFederationRequest disableFederationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableFederationRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableFederationRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DisableFederationResponse>(response);
        }

        public AsyncInvoker<DisableFederationResponse> DisableFederationAsyncInvoker(DisableFederationRequest disableFederationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableFederationRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableFederationRequest);
            return new AsyncInvoker<DisableFederationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DisableFederationResponse>);
        }
        
        /// <summary>
        /// 下载联邦kubeconfig
        ///
        /// 舰队开通联邦并且创建网络连接之后，可以使用此接口下载联邦的kubeconfig
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadFederationKubeconfigResponse> DownloadFederationKubeconfigAsync(DownloadFederationKubeconfigRequest downloadFederationKubeconfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadFederationKubeconfigRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/kubeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadFederationKubeconfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DownloadFederationKubeconfigResponse>(response);
        }

        public AsyncInvoker<DownloadFederationKubeconfigResponse> DownloadFederationKubeconfigAsyncInvoker(DownloadFederationKubeconfigRequest downloadFederationKubeconfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadFederationKubeconfigRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/kubeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadFederationKubeconfigRequest);
            return new AsyncInvoker<DownloadFederationKubeconfigResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadFederationKubeconfigResponse>);
        }
        
        /// <summary>
        /// 舰队启用策略中心
        ///
        /// 舰队启用策略中心
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableClustergroupPolicyResponse> EnableClustergroupPolicyAsync(EnableClustergroupPolicyRequest enableClustergroupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableClustergroupPolicyRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableClustergroupPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EnableClustergroupPolicyResponse>(response);
        }

        public AsyncInvoker<EnableClustergroupPolicyResponse> EnableClustergroupPolicyAsyncInvoker(EnableClustergroupPolicyRequest enableClustergroupPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableClustergroupPolicyRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableClustergroupPolicyRequest);
            return new AsyncInvoker<EnableClustergroupPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableClustergroupPolicyResponse>);
        }
        
        /// <summary>
        /// 启用容器舰队联邦
        ///
        /// 启用容器舰队联邦
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableFederationResponse> EnableFederationAsync(EnableFederationRequest enableFederationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableFederationRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableFederationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<EnableFederationResponse>(response);
        }

        public AsyncInvoker<EnableFederationResponse> EnableFederationAsyncInvoker(EnableFederationRequest enableFederationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableFederationRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableFederationRequest);
            return new AsyncInvoker<EnableFederationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableFederationResponse>);
        }
        
        /// <summary>
        /// 集群加入容器舰队
        ///
        /// 集群加入容器舰队
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<JoinGroupResponse> JoinGroupAsync(JoinGroupRequest joinGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(joinGroupRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/join", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", joinGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<JoinGroupResponse>(response);
        }

        public AsyncInvoker<JoinGroupResponse> JoinGroupAsyncInvoker(JoinGroupRequest joinGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(joinGroupRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/join", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", joinGroupRequest);
            return new AsyncInvoker<JoinGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<JoinGroupResponse>);
        }
        
        /// <summary>
        /// 集群移出容器舰队
        ///
        /// 集群退出容器舰队
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<LeaveGroupResponse> LeaveGroupAsync(LeaveGroupRequest leaveGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(leaveGroupRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/unjoin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", leaveGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<LeaveGroupResponse>(response);
        }

        public AsyncInvoker<LeaveGroupResponse> LeaveGroupAsyncInvoker(LeaveGroupRequest leaveGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(leaveGroupRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/unjoin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", leaveGroupRequest);
            return new AsyncInvoker<LeaveGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<LeaveGroupResponse>);
        }
        
        /// <summary>
        /// 获取插件实例列表
        ///
        /// 获取插件实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAddonInstancesResponse> ListAddonInstancesAsync(ListAddonInstancesRequest listAddonInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAddonInstancesResponse>(response);
        }

        public AsyncInvoker<ListAddonInstancesResponse> ListAddonInstancesAsyncInvoker(ListAddonInstancesRequest listAddonInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/addons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonInstancesRequest);
            return new AsyncInvoker<ListAddonInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddonInstancesResponse>);
        }
        
        /// <summary>
        /// 获取插件模板列表
        ///
        /// 获取插件模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAddonTemplatesResponse> ListAddonTemplatesAsync(ListAddonTemplatesRequest listAddonTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/addontemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAddonTemplatesResponse>(response);
        }

        public AsyncInvoker<ListAddonTemplatesResponse> ListAddonTemplatesAsyncInvoker(ListAddonTemplatesRequest listAddonTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/addontemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonTemplatesRequest);
            return new AsyncInvoker<ListAddonTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddonTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取容器舰队列表
        ///
        /// 获取所有容器舰队信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListClusterGroupResponse> ListClusterGroupAsync(ListClusterGroupRequest listClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListClusterGroupResponse>(response);
        }

        public AsyncInvoker<ListClusterGroupResponse> ListClusterGroupAsyncInvoker(ListClusterGroupRequest listClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterGroupRequest);
            return new AsyncInvoker<ListClusterGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClusterGroupResponse>);
        }
        
        /// <summary>
        /// 获取所有配置集合信息
        ///
        /// 获取所有配置集合信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConfigSetsResponse> ListConfigSetsAsync(ListConfigSetsRequest listConfigSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigSetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConfigSetsResponse>(response);
        }

        public AsyncInvoker<ListConfigSetsResponse> ListConfigSetsAsyncInvoker(ListConfigSetsRequest listConfigSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigSetsRequest);
            return new AsyncInvoker<ListConfigSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigSetsResponse>);
        }
        
        /// <summary>
        /// 获取策略定义列表
        ///
        /// 获取策略定义列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyDefinitionsResponse> ListPolicyDefinitionsAsync(ListPolicyDefinitionsRequest listPolicyDefinitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/policydefinitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyDefinitionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyDefinitionsResponse>(response);
        }

        public AsyncInvoker<ListPolicyDefinitionsResponse> ListPolicyDefinitionsAsyncInvoker(ListPolicyDefinitionsRequest listPolicyDefinitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/policydefinitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyDefinitionsRequest);
            return new AsyncInvoker<ListPolicyDefinitionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyDefinitionsResponse>);
        }
        
        /// <summary>
        /// 获取策略实例列表
        ///
        /// 获取策略实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyInstancesResponse> ListPolicyInstancesAsync(ListPolicyInstancesRequest listPolicyInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyInstancesResponse>(response);
        }

        public AsyncInvoker<ListPolicyInstancesResponse> ListPolicyInstancesAsyncInvoker(ListPolicyInstancesRequest listPolicyInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyInstancesRequest);
            return new AsyncInvoker<ListPolicyInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyInstancesResponse>);
        }
        
        /// <summary>
        /// 获取策略实例任务列表
        ///
        /// 获取策略实例任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyJobsResponse> ListPolicyJobsAsync(ListPolicyJobsRequest listPolicyJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/policy/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyJobsResponse>(response);
        }

        public AsyncInvoker<ListPolicyJobsResponse> ListPolicyJobsAsyncInvoker(ListPolicyJobsRequest listPolicyJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/policy/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyJobsRequest);
            return new AsyncInvoker<ListPolicyJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyJobsResponse>);
        }
        
        /// <summary>
        /// 查询域名解析记录集列表
        ///
        /// 查询域名解析记录集列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordSetsResponse> ListRecordSetsAsync(ListRecordSetsRequest listRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/traffic/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecordSetsResponse>(response);
        }

        public AsyncInvoker<ListRecordSetsResponse> ListRecordSetsAsyncInvoker(ListRecordSetsRequest listRecordSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/traffic/recordsets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsRequest);
            return new AsyncInvoker<ListRecordSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordSetsResponse>);
        }
        
        /// <summary>
        /// 获取仓库源列表
        ///
        /// 获取仓库源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListReposResponse> ListReposAsync(ListReposRequest listReposRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReposRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListReposResponse>(response);
        }

        public AsyncInvoker<ListReposResponse> ListReposAsyncInvoker(ListReposRequest listReposRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReposRequest);
            return new AsyncInvoker<ListReposResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReposResponse>);
        }
        
        /// <summary>
        /// 获取权限策略列表
        ///
        /// 获取权限策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRuleResponse> ListRuleAsync(ListRuleRequest listRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRuleResponse>(response);
        }

        public AsyncInvoker<ListRuleResponse> ListRuleAsyncInvoker(ListRuleRequest listRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleRequest);
            return new AsyncInvoker<ListRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRuleResponse>);
        }
        
        /// <summary>
        /// 查询服务配置信息
        ///
        /// 获取各个类型集群的全局配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServerConfigsResponse> ListServerConfigsAsync(ListServerConfigsRequest listServerConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/serverconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServerConfigsResponse>(response);
        }

        public AsyncInvoker<ListServerConfigsResponse> ListServerConfigsAsyncInvoker(ListServerConfigsRequest listServerConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/serverconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerConfigsRequest);
            return new AsyncInvoker<ListServerConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerConfigsResponse>);
        }
        
        /// <summary>
        /// 注册容器舰队
        ///
        /// 容器舰队创建API，生成容器舰队时可以选择关联的集群
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RegisterClusterGroupResponse> RegisterClusterGroupAsync(RegisterClusterGroupRequest registerClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", registerClusterGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RegisterClusterGroupResponse>(response);
        }

        public AsyncInvoker<RegisterClusterGroupResponse> RegisterClusterGroupAsyncInvoker(RegisterClusterGroupRequest registerClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", registerClusterGroupRequest);
            return new AsyncInvoker<RegisterClusterGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterClusterGroupResponse>);
        }
        
        /// <summary>
        /// 获取插件实例
        ///
        /// 获取插件实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAddonInstanceResponse> ShowAddonInstanceAsync(ShowAddonInstanceRequest showAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddonInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAddonInstanceResponse>(response);
        }

        public AsyncInvoker<ShowAddonInstanceResponse> ShowAddonInstanceAsyncInvoker(ShowAddonInstanceRequest showAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddonInstanceRequest);
            return new AsyncInvoker<ShowAddonInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 获取单个容器舰队
        ///
        /// 获取单个容器舰队
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClusterGroupResponse> ShowClusterGroupAsync(ShowClusterGroupRequest showClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterGroupRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterGroupResponse>(response);
        }

        public AsyncInvoker<ShowClusterGroupResponse> ShowClusterGroupAsyncInvoker(ShowClusterGroupRequest showClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterGroupRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterGroupRequest);
            return new AsyncInvoker<ShowClusterGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterGroupResponse>);
        }
        
        /// <summary>
        /// 获取配置集合详细信息
        ///
        /// 获取配置集合详细信息，包含仓库源信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConfigSetResponse> ShowConfigSetAsync(ShowConfigSetRequest showConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigSetRequest.Configsetid, out var valueOfConfigsetid)) urlParam.Add("configsetid", valueOfConfigsetid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/{configsetid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigSetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConfigSetResponse>(response);
        }

        public AsyncInvoker<ShowConfigSetResponse> ShowConfigSetAsyncInvoker(ShowConfigSetRequest showConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConfigSetRequest.Configsetid, out var valueOfConfigsetid)) urlParam.Add("configsetid", valueOfConfigsetid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/{configsetid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConfigSetRequest);
            return new AsyncInvoker<ShowConfigSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConfigSetResponse>);
        }
        
        /// <summary>
        /// 查询联邦开启进度
        ///
        /// 查询联邦开启进度
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFederationProgressResponse> ShowFederationProgressAsync(ShowFederationProgressRequest showFederationProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFederationProgressRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFederationProgressRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFederationProgressResponse>(response);
        }

        public AsyncInvoker<ShowFederationProgressResponse> ShowFederationProgressAsyncInvoker(ShowFederationProgressRequest showFederationProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFederationProgressRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFederationProgressRequest);
            return new AsyncInvoker<ShowFederationProgressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFederationProgressResponse>);
        }
        
        /// <summary>
        /// 统计某个用户所有配置集合的运行状态
        ///
        /// 统计某个用户所有配置集合的运行状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGitopsStatisticsResponse> ShowGitopsStatisticsAsync(ShowGitopsStatisticsRequest showGitopsStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGitopsStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGitopsStatisticsResponse>(response);
        }

        public AsyncInvoker<ShowGitopsStatisticsResponse> ShowGitopsStatisticsAsyncInvoker(ShowGitopsStatisticsRequest showGitopsStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGitopsStatisticsRequest);
            return new AsyncInvoker<ShowGitopsStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGitopsStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取策略定义
        ///
        /// 获取策略定义
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPolicyDefinitionResponse> ShowPolicyDefinitionAsync(ShowPolicyDefinitionRequest showPolicyDefinitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyDefinitionRequest.Policydefinitionid, out var valueOfPolicydefinitionid)) urlParam.Add("policydefinitionid", valueOfPolicydefinitionid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policydefinitions/{policydefinitionid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyDefinitionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyDefinitionResponse>(response);
        }

        public AsyncInvoker<ShowPolicyDefinitionResponse> ShowPolicyDefinitionAsyncInvoker(ShowPolicyDefinitionRequest showPolicyDefinitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyDefinitionRequest.Policydefinitionid, out var valueOfPolicydefinitionid)) urlParam.Add("policydefinitionid", valueOfPolicydefinitionid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policydefinitions/{policydefinitionid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyDefinitionRequest);
            return new AsyncInvoker<ShowPolicyDefinitionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyDefinitionResponse>);
        }
        
        /// <summary>
        /// 获取指定策略实例
        ///
        /// 获取指定策略实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPolicyInstanceResponse> ShowPolicyInstanceAsync(ShowPolicyInstanceRequest showPolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyInstanceRequest.Policyinstanceid, out var valueOfPolicyinstanceid)) urlParam.Add("policyinstanceid", valueOfPolicyinstanceid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances/{policyinstanceid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyInstanceResponse>(response);
        }

        public AsyncInvoker<ShowPolicyInstanceResponse> ShowPolicyInstanceAsyncInvoker(ShowPolicyInstanceRequest showPolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyInstanceRequest.Policyinstanceid, out var valueOfPolicyinstanceid)) urlParam.Add("policyinstanceid", valueOfPolicyinstanceid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances/{policyinstanceid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyInstanceRequest);
            return new AsyncInvoker<ShowPolicyInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyInstanceResponse>);
        }
        
        /// <summary>
        /// 获取指定策略实例相关任务
        ///
        /// 获取指定策略实例相关任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPolicyJobResponse> ShowPolicyJobAsync(ShowPolicyJobRequest showPolicyJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyJobRequest.Jobid, out var valueOfJobid)) urlParam.Add("jobid", valueOfJobid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policy/jobs/{jobid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyJobResponse>(response);
        }

        public AsyncInvoker<ShowPolicyJobResponse> ShowPolicyJobAsyncInvoker(ShowPolicyJobRequest showPolicyJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyJobRequest.Jobid, out var valueOfJobid)) urlParam.Add("jobid", valueOfJobid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policy/jobs/{jobid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyJobRequest);
            return new AsyncInvoker<ShowPolicyJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyJobResponse>);
        }
        
        /// <summary>
        /// 查询联邦工作负载
        ///
        /// 查询联邦工作负载
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProxyUnitedWorkloadResponse> ShowProxyUnitedWorkloadAsync(ShowProxyUnitedWorkloadRequest showProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProxyUnitedWorkloadRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProxyUnitedWorkloadResponse>(response);
        }

        public AsyncInvoker<ShowProxyUnitedWorkloadResponse> ShowProxyUnitedWorkloadAsyncInvoker(ShowProxyUnitedWorkloadRequest showProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProxyUnitedWorkloadRequest);
            return new AsyncInvoker<ShowProxyUnitedWorkloadResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProxyUnitedWorkloadResponse>);
        }
        
        /// <summary>
        /// 获取配额信息
        ///
        /// 获取UCS配额信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotaResponse> ShowQuotaAsync(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showQuotaRequest.Domainid, out var valueOfDomainid)) urlParam.Add("domainid", valueOfDomainid);
            var urlPath = HttpUtils.AddUrlPath("/v1/maintenance/quota/{domainid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }

        public AsyncInvoker<ShowQuotaResponse> ShowQuotaAsyncInvoker(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showQuotaRequest.Domainid, out var valueOfDomainid)) urlParam.Add("domainid", valueOfDomainid);
            var urlPath = HttpUtils.AddUrlPath("/v1/maintenance/quota/{domainid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            return new AsyncInvoker<ShowQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotaResponse>);
        }
        
        /// <summary>
        /// 更新插件实例
        ///
        /// 更新插件实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAddonInstanceResponse> UpdateAddonInstanceAsync(UpdateAddonInstanceRequest updateAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddonInstanceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAddonInstanceResponse>(response);
        }

        public AsyncInvoker<UpdateAddonInstanceResponse> UpdateAddonInstanceAsyncInvoker(UpdateAddonInstanceRequest updateAddonInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAddonInstanceRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/addons/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddonInstanceRequest);
            return new AsyncInvoker<UpdateAddonInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAddonInstanceResponse>);
        }
        
        /// <summary>
        /// 更新容器舰队描述信息
        ///
        /// 更新集群所属的容器舰队description信息；需要用户对相应容器舰队有更新权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateClusterGroupResponse> UpdateClusterGroupAsync(UpdateClusterGroupRequest updateClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/description", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateClusterGroupResponse>(response);
        }

        public AsyncInvoker<UpdateClusterGroupResponse> UpdateClusterGroupAsyncInvoker(UpdateClusterGroupRequest updateClusterGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/description", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupRequest);
            return new AsyncInvoker<UpdateClusterGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateClusterGroupResponse>);
        }
        
        /// <summary>
        /// 向容器舰队中添加集群
        ///
        /// 向容器舰队中添加集群，同批次可以添加一个或多个集群，该接口无法清空或减少管理的集群。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateClusterGroupAssociatedClustersResponse> UpdateClusterGroupAssociatedClustersAsync(UpdateClusterGroupAssociatedClustersRequest updateClusterGroupAssociatedClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupAssociatedClustersRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/associatedclusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupAssociatedClustersRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateClusterGroupAssociatedClustersResponse>(response);
        }

        public AsyncInvoker<UpdateClusterGroupAssociatedClustersResponse> UpdateClusterGroupAssociatedClustersAsyncInvoker(UpdateClusterGroupAssociatedClustersRequest updateClusterGroupAssociatedClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupAssociatedClustersRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/associatedclusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupAssociatedClustersRequest);
            return new AsyncInvoker<UpdateClusterGroupAssociatedClustersResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateClusterGroupAssociatedClustersResponse>);
        }
        
        /// <summary>
        /// 更新容器舰队关联权限策略
        ///
        /// 更新容器舰队关联权限策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateClusterGroupAssociatedRulesResponse> UpdateClusterGroupAssociatedRulesAsync(UpdateClusterGroupAssociatedRulesRequest updateClusterGroupAssociatedRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupAssociatedRulesRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/associatedrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupAssociatedRulesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateClusterGroupAssociatedRulesResponse>(response);
        }

        public AsyncInvoker<UpdateClusterGroupAssociatedRulesResponse> UpdateClusterGroupAssociatedRulesAsyncInvoker(UpdateClusterGroupAssociatedRulesRequest updateClusterGroupAssociatedRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupAssociatedRulesRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/associatedrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupAssociatedRulesRequest);
            return new AsyncInvoker<UpdateClusterGroupAssociatedRulesResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateClusterGroupAssociatedRulesResponse>);
        }
        
        /// <summary>
        /// 更新容器舰队的联邦对应的zone
        ///
        /// 更新容器舰队的集群联邦关联的zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateClusterGroupAssociatedZonesResponse> UpdateClusterGroupAssociatedZonesAsync(UpdateClusterGroupAssociatedZonesRequest updateClusterGroupAssociatedZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupAssociatedZonesRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/associatedzones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupAssociatedZonesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateClusterGroupAssociatedZonesResponse>(response);
        }

        public AsyncInvoker<UpdateClusterGroupAssociatedZonesResponse> UpdateClusterGroupAssociatedZonesAsyncInvoker(UpdateClusterGroupAssociatedZonesRequest updateClusterGroupAssociatedZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterGroupAssociatedZonesRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/associatedzones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterGroupAssociatedZonesRequest);
            return new AsyncInvoker<UpdateClusterGroupAssociatedZonesResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateClusterGroupAssociatedZonesResponse>);
        }
        
        /// <summary>
        /// 更新配置集合信息
        ///
        /// 仅更新配置集合，不更新仓库源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateConfigSetResponse> UpdateConfigSetAsync(UpdateConfigSetRequest updateConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConfigSetRequest.Configsetid, out var valueOfConfigsetid)) urlParam.Add("configsetid", valueOfConfigsetid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/{configsetid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigSetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateConfigSetResponse>(response);
        }

        public AsyncInvoker<UpdateConfigSetResponse> UpdateConfigSetAsyncInvoker(UpdateConfigSetRequest updateConfigSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateConfigSetRequest.Configsetid, out var valueOfConfigsetid)) urlParam.Add("configsetid", valueOfConfigsetid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/{configsetid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConfigSetRequest);
            return new AsyncInvoker<UpdateConfigSetResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateConfigSetResponse>);
        }
        
        /// <summary>
        /// 更新策略定义
        ///
        /// 更新策略定义
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePolicyDefinationResponse> UpdatePolicyDefinationAsync(UpdatePolicyDefinationRequest updatePolicyDefinationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyDefinationRequest.Policydefinitionid, out var valueOfPolicydefinitionid)) urlParam.Add("policydefinitionid", valueOfPolicydefinitionid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policydefinitions/{policydefinitionid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyDefinationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePolicyDefinationResponse>(response);
        }

        public AsyncInvoker<UpdatePolicyDefinationResponse> UpdatePolicyDefinationAsyncInvoker(UpdatePolicyDefinationRequest updatePolicyDefinationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyDefinationRequest.Policydefinitionid, out var valueOfPolicydefinitionid)) urlParam.Add("policydefinitionid", valueOfPolicydefinitionid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policydefinitions/{policydefinitionid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyDefinationRequest);
            return new AsyncInvoker<UpdatePolicyDefinationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePolicyDefinationResponse>);
        }
        
        /// <summary>
        /// 更新指定策略实例
        ///
        /// 更新指定策略实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePolicyInstanceResponse> UpdatePolicyInstanceAsync(UpdatePolicyInstanceRequest updatePolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyInstanceRequest.Policyinstanceid, out var valueOfPolicyinstanceid)) urlParam.Add("policyinstanceid", valueOfPolicyinstanceid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances/{policyinstanceid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyInstanceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePolicyInstanceResponse>(response);
        }

        public AsyncInvoker<UpdatePolicyInstanceResponse> UpdatePolicyInstanceAsyncInvoker(UpdatePolicyInstanceRequest updatePolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyInstanceRequest.Policyinstanceid, out var valueOfPolicyinstanceid)) urlParam.Add("policyinstanceid", valueOfPolicyinstanceid);
            var urlPath = HttpUtils.AddUrlPath("/v1/policyinstances/{policyinstanceid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyInstanceRequest);
            return new AsyncInvoker<UpdatePolicyInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePolicyInstanceResponse>);
        }
        
        /// <summary>
        /// 更新联邦工作负载
        ///
        /// 更新联邦工作负载
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProxyUnitedWorkloadResponse> UpdateProxyUnitedWorkloadAsync(UpdateProxyUnitedWorkloadRequest updateProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProxyUnitedWorkloadRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateProxyUnitedWorkloadResponse>(response);
        }

        public AsyncInvoker<UpdateProxyUnitedWorkloadResponse> UpdateProxyUnitedWorkloadAsyncInvoker(UpdateProxyUnitedWorkloadRequest updateProxyUnitedWorkloadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProxyUnitedWorkloadRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/unitedworkload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProxyUnitedWorkloadRequest);
            return new AsyncInvoker<UpdateProxyUnitedWorkloadResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateProxyUnitedWorkloadResponse>);
        }
        
        /// <summary>
        /// 更新仓库源信息
        ///
        /// 更新仓库源信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRepoResponse> UpdateRepoAsync(UpdateRepoRequest updateRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRequest.Repoid, out var valueOfRepoid)) urlParam.Add("repoid", valueOfRepoid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos/{repoid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRepoResponse>(response);
        }

        public AsyncInvoker<UpdateRepoResponse> UpdateRepoAsyncInvoker(UpdateRepoRequest updateRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRequest.Repoid, out var valueOfRepoid)) urlParam.Add("repoid", valueOfRepoid);
            var urlPath = HttpUtils.AddUrlPath("/v1/configsets/repos/{repoid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRequest);
            return new AsyncInvoker<UpdateRepoResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRepoResponse>);
        }
        
        /// <summary>
        /// 更新权限策略
        ///
        /// 更新权限策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest updateRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRuleRequest.Ruleid, out var valueOfRuleid)) urlParam.Add("ruleid", valueOfRuleid);
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules/{ruleid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRuleResponse>(response);
        }

        public AsyncInvoker<UpdateRuleResponse> UpdateRuleAsyncInvoker(UpdateRuleRequest updateRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRuleRequest.Ruleid, out var valueOfRuleid)) urlParam.Add("ruleid", valueOfRuleid);
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/rules/{ruleid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleRequest);
            return new AsyncInvoker<UpdateRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRuleResponse>);
        }
        
        /// <summary>
        /// 升级容器舰队联邦
        ///
        /// 容器舰队联邦版本升级
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpgradeFederationResponse> UpgradeFederationAsync(UpgradeFederationRequest upgradeFederationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeFederationRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeFederationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpgradeFederationResponse>(response);
        }

        public AsyncInvoker<UpgradeFederationResponse> UpgradeFederationAsyncInvoker(UpgradeFederationRequest upgradeFederationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeFederationRequest.Clustergroupid, out var valueOfClustergroupid)) urlParam.Add("clustergroupid", valueOfClustergroupid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clustergroups/{clustergroupid}/federations/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeFederationRequest);
            return new AsyncInvoker<UpgradeFederationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpgradeFederationResponse>);
        }
        
        /// <summary>
        /// 获取集群安装时所需的配置信息
        ///
        /// 获取集群安装时所需的配置信息，当前仅本地集群使用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateClusterConfResponse> CreateClusterConfAsync(CreateClusterConfRequest createClusterConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterConfRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/clusterconf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterConfRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var createClusterConfResponse = JsonUtils.DeSerializeNull<CreateClusterConfResponse>(response);
            createClusterConfResponse.Body = JsonUtils.DeSerializeMap<string, Object>(response);
            return createClusterConfResponse;
        }

        public AsyncInvoker<CreateClusterConfResponse> CreateClusterConfAsyncInvoker(CreateClusterConfRequest createClusterConfRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterConfRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/clusterconf", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterConfRequest);
            return new AsyncInvoker<CreateClusterConfResponse>(this, "POST", request, response =>
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
        public async Task<CreateClusterKubeconfigResponse> CreateClusterKubeconfigAsync(CreateClusterKubeconfigRequest createClusterKubeconfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterKubeconfigRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/kubeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterKubeconfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateClusterKubeconfigResponse>(response);
        }

        public AsyncInvoker<CreateClusterKubeconfigResponse> CreateClusterKubeconfigAsyncInvoker(CreateClusterKubeconfigRequest createClusterKubeconfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterKubeconfigRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/kubeconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterKubeconfigRequest);
            return new AsyncInvoker<CreateClusterKubeconfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateClusterKubeconfigResponse>);
        }
        
        /// <summary>
        /// 创建集群建策略实例
        ///
        /// 创建集群建策略实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateClusterPolicyInstanceResponse> CreateClusterPolicyInstanceAsync(CreateClusterPolicyInstanceRequest createClusterPolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterPolicyInstanceRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/policyinstance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterPolicyInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateClusterPolicyInstanceResponse>(response);
        }

        public AsyncInvoker<CreateClusterPolicyInstanceResponse> CreateClusterPolicyInstanceAsyncInvoker(CreateClusterPolicyInstanceRequest createClusterPolicyInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createClusterPolicyInstanceRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/policyinstance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterPolicyInstanceRequest);
            return new AsyncInvoker<CreateClusterPolicyInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateClusterPolicyInstanceResponse>);
        }
        
        /// <summary>
        /// 删除集群
        ///
        /// 用于集群解除注册；传入的cluster ID必须符合k8s UUID的格式规则；同时需要用户有对应集群的操作权限，否则会鉴权失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest deleteClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteClusterResponse>(response);
        }

        public AsyncInvoker<DeleteClusterResponse> DeleteClusterAsyncInvoker(DeleteClusterRequest deleteClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterRequest);
            return new AsyncInvoker<DeleteClusterResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteClusterResponse>);
        }
        
        /// <summary>
        /// 集群关闭策略中心
        ///
        /// 集群关闭策略中心
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableClusterPolicyResponse> DisableClusterPolicyAsync(DisableClusterPolicyRequest disableClusterPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableClusterPolicyRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableClusterPolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DisableClusterPolicyResponse>(response);
        }

        public AsyncInvoker<DisableClusterPolicyResponse> DisableClusterPolicyAsyncInvoker(DisableClusterPolicyRequest disableClusterPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableClusterPolicyRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableClusterPolicyRequest);
            return new AsyncInvoker<DisableClusterPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DisableClusterPolicyResponse>);
        }
        
        /// <summary>
        /// 卸载集群gitops插件
        ///
        /// 卸载集群gitops插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableGitOpsResponse> DisableGitOpsAsync(DisableGitOpsRequest disableGitOpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableGitOpsRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/gitops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableGitOpsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DisableGitOpsResponse>(response);
        }

        public AsyncInvoker<DisableGitOpsResponse> DisableGitOpsAsyncInvoker(DisableGitOpsRequest disableGitOpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableGitOpsRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/gitops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableGitOpsRequest);
            return new AsyncInvoker<DisableGitOpsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DisableGitOpsResponse>);
        }
        
        /// <summary>
        /// 集群启用策略中心
        ///
        /// 集群启用策略中心
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableClusterPolicyResponse> EnableClusterPolicyAsync(EnableClusterPolicyRequest enableClusterPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableClusterPolicyRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableClusterPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EnableClusterPolicyResponse>(response);
        }

        public AsyncInvoker<EnableClusterPolicyResponse> EnableClusterPolicyAsyncInvoker(EnableClusterPolicyRequest enableClusterPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableClusterPolicyRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableClusterPolicyRequest);
            return new AsyncInvoker<EnableClusterPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableClusterPolicyResponse>);
        }
        
        /// <summary>
        /// 启用Gitops插件
        ///
        /// 启用Gitops插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableGitOpsResponse> EnableGitOpsAsync(EnableGitOpsRequest enableGitOpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableGitOpsRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/gitops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableGitOpsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EnableGitOpsResponse>(response);
        }

        public AsyncInvoker<EnableGitOpsResponse> EnableGitOpsAsyncInvoker(EnableGitOpsRequest enableGitOpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableGitOpsRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/gitops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableGitOpsRequest);
            return new AsyncInvoker<EnableGitOpsResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableGitOpsResponse>);
        }
        
        /// <summary>
        /// 获取租户的CCE集群列表
        ///
        /// 获取当前租户的CCE集群列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListManagedClustersResponse> ListManagedClustersAsync(ListManagedClustersRequest listManagedClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managedclusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedClustersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listManagedClustersResponse = JsonUtils.DeSerializeNull<ListManagedClustersResponse>(response);
            listManagedClustersResponse.Body = JsonUtils.DeSerializeList<Cluster>(response);
            return listManagedClustersResponse;
        }

        public AsyncInvoker<ListManagedClustersResponse> ListManagedClustersAsyncInvoker(ListManagedClustersRequest listManagedClustersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/managedclusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedClustersRequest);
            return new AsyncInvoker<ListManagedClustersResponse>(this, "GET", request, response =>
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
        public async Task<ListRegisteredClusterVersionsResponse> ListRegisteredClusterVersionsAsync(ListRegisteredClusterVersionsRequest listRegisteredClusterVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/config/registeredclusterversions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegisteredClusterVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRegisteredClusterVersionsResponse>(response);
        }

        public AsyncInvoker<ListRegisteredClusterVersionsResponse> ListRegisteredClusterVersionsAsyncInvoker(ListRegisteredClusterVersionsRequest listRegisteredClusterVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/config/registeredclusterversions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegisteredClusterVersionsRequest);
            return new AsyncInvoker<ListRegisteredClusterVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRegisteredClusterVersionsResponse>);
        }
        
        /// <summary>
        /// 注册集群
        ///
        /// 集群注册接口。支持三方集群的注册和CCE导入集群的注册。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RegisterClusterResponse> RegisterClusterAsync(RegisterClusterRequest registerClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", registerClusterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RegisterClusterResponse>(response);
        }

        public AsyncInvoker<RegisterClusterResponse> RegisterClusterAsyncInvoker(RegisterClusterRequest registerClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", registerClusterRequest);
            return new AsyncInvoker<RegisterClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterClusterResponse>);
        }
        
        /// <summary>
        /// 激活集群
        ///
        /// 激活集群接口；传入的cluster ID必须符合k8s UUID的格式规则；同时需要用户有对应集群的更新权限，否则会鉴权失败
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RetryClusterActivationResponse> RetryClusterActivationAsync(RetryClusterActivationRequest retryClusterActivationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryClusterActivationRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/activation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryClusterActivationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<RetryClusterActivationResponse>(response);
        }

        public AsyncInvoker<RetryClusterActivationResponse> RetryClusterActivationAsyncInvoker(RetryClusterActivationRequest retryClusterActivationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryClusterActivationRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/activation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryClusterActivationRequest);
            return new AsyncInvoker<RetryClusterActivationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<RetryClusterActivationResponse>);
        }
        
        /// <summary>
        /// 获取单个集群
        ///
        /// 获取集群信息。传入的cluster ID必须符合k8s UUID的格式规则；同时需要用户有对应集群的获取权限，否则会鉴权失败
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClusterResponse> ShowClusterAsync(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterResponse>(response);
        }

        public AsyncInvoker<ShowClusterResponse> ShowClusterAsyncInvoker(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            return new AsyncInvoker<ShowClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterResponse>);
        }
        
        /// <summary>
        /// 获取集群接入信息
        ///
        /// 该API接口用于获取集群接入信息；传入的cluster ID必须符合k8s UUID的格式规则；同时需要用户有对应集群证书的获取权限，否则会鉴权失败；agent证书只可以下载一次。仅用于获取三方集群的集群接入信息，CCE集群不从该接口获取，如果传入CCE集群ID，返回码为400
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClusterAccessInfoResponse> ShowClusterAccessInfoAsync(ShowClusterAccessInfoRequest showClusterAccessInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterAccessInfoRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/accessinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterAccessInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showClusterAccessInfoResponse = JsonUtils.DeSerializeNull<ShowClusterAccessInfoResponse>(response);
            showClusterAccessInfoResponse.Body = JsonUtils.DeSerializeList<byte[]>(response);
            return showClusterAccessInfoResponse;
        }

        public AsyncInvoker<ShowClusterAccessInfoResponse> ShowClusterAccessInfoAsyncInvoker(ShowClusterAccessInfoRequest showClusterAccessInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterAccessInfoRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/accessinfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterAccessInfoRequest);
            return new AsyncInvoker<ShowClusterAccessInfoResponse>(this, "GET", request, response =>
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
        public async Task<ShowClusterListResponse> ShowClusterListAsync(ShowClusterListRequest showClusterListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterListResponse>(response);
        }

        public AsyncInvoker<ShowClusterListResponse> ShowClusterListAsyncInvoker(ShowClusterListRequest showClusterListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterListRequest);
            return new AsyncInvoker<ShowClusterListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterListResponse>);
        }
        
        /// <summary>
        /// 获取gitops启用进展
        ///
        /// 获取gitops启用进展
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGitOpsStatusResponse> ShowGitOpsStatusAsync(ShowGitOpsStatusRequest showGitOpsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGitOpsStatusRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/gitops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGitOpsStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGitOpsStatusResponse>(response);
        }

        public AsyncInvoker<ShowGitOpsStatusResponse> ShowGitOpsStatusAsyncInvoker(ShowGitOpsStatusRequest showGitOpsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGitOpsStatusRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/gitops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGitOpsStatusRequest);
            return new AsyncInvoker<ShowGitOpsStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGitOpsStatusResponse>);
        }
        
        /// <summary>
        /// 更新集群
        ///
        /// 更新集群。当前仅允许更新附着集群和本地集群的国家/城市，允许更新多云集群的工作节点个数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest updateClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateClusterResponse>(response);
        }

        public AsyncInvoker<UpdateClusterResponse> UpdateClusterAsyncInvoker(UpdateClusterRequest updateClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRequest);
            return new AsyncInvoker<UpdateClusterResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateClusterResponse>);
        }
        
        /// <summary>
        /// 集群关联权限策略
        ///
        /// 集群关联权限策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateClusterRulesResponse> UpdateClusterRulesAsync(UpdateClusterRulesRequest updateClusterRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterRulesRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/associatedrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRulesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateClusterRulesResponse>(response);
        }

        public AsyncInvoker<UpdateClusterRulesResponse> UpdateClusterRulesAsyncInvoker(UpdateClusterRulesRequest updateClusterRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateClusterRulesRequest.Clusterid, out var valueOfClusterid)) urlParam.Add("clusterid", valueOfClusterid);
            var urlPath = HttpUtils.AddUrlPath("/v1/clusters/{clusterid}/associatedrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRulesRequest);
            return new AsyncInvoker<UpdateClusterRulesResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateClusterRulesResponse>);
        }
        
    }
}