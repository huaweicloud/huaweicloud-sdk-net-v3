using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Vpc.V3.Model;

namespace HuaweiCloud.SDK.Vpc.V3
{
    public partial class VpcAsyncClient : Client
    {
        public static ClientBuilder<VpcAsyncClient> NewBuilder()
        {
            return new ClientBuilder<VpcAsyncClient>();
        }

        
        /// <summary>
        /// 端口插入安全组
        ///
        /// 端口插入安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddSecurityGroupsResponse> AddSecurityGroupsAsync(AddSecurityGroupsRequest addSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", addSecurityGroupsRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/ports/{port_id}/insert-security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSecurityGroupsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<AddSecurityGroupsResponse>(response);
        }

        public AsyncInvoker<AddSecurityGroupsResponse> AddSecurityGroupsAsyncInvoker(AddSecurityGroupsRequest addSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", addSecurityGroupsRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/ports/{port_id}/insert-security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSecurityGroupsRequest);
            return new AsyncInvoker<AddSecurityGroupsResponse>(this, "PUT", request, JsonUtils.DeSerialize<AddSecurityGroupsResponse>);
        }
        
        /// <summary>
        /// 流量镜像会话添加镜像源
        ///
        /// 流量镜像会话添加镜像源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddSourcesToTrafficMirrorSessionResponse> AddSourcesToTrafficMirrorSessionAsync(AddSourcesToTrafficMirrorSessionRequest addSourcesToTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", addSourcesToTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}/add-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSourcesToTrafficMirrorSessionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<AddSourcesToTrafficMirrorSessionResponse>(response);
        }

        public AsyncInvoker<AddSourcesToTrafficMirrorSessionResponse> AddSourcesToTrafficMirrorSessionAsyncInvoker(AddSourcesToTrafficMirrorSessionRequest addSourcesToTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", addSourcesToTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}/add-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSourcesToTrafficMirrorSessionRequest);
            return new AsyncInvoker<AddSourcesToTrafficMirrorSessionResponse>(this, "PUT", request, JsonUtils.DeSerialize<AddSourcesToTrafficMirrorSessionResponse>);
        }
        
        /// <summary>
        /// 批量创建安全组规则
        ///
        /// 在特定安全组下批量创建安全组规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateSecurityGroupRulesResponse> BatchCreateSecurityGroupRulesAsync(BatchCreateSecurityGroupRulesRequest batchCreateSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", batchCreateSecurityGroupRulesRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}/security-group-rules/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateSecurityGroupRulesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateSecurityGroupRulesResponse>(response);
        }

        public AsyncInvoker<BatchCreateSecurityGroupRulesResponse> BatchCreateSecurityGroupRulesAsyncInvoker(BatchCreateSecurityGroupRulesRequest batchCreateSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", batchCreateSecurityGroupRulesRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}/security-group-rules/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateSecurityGroupRulesRequest);
            return new AsyncInvoker<BatchCreateSecurityGroupRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateSecurityGroupRulesResponse>);
        }
        
        /// <summary>
        /// 批量创建辅助弹性网卡
        ///
        /// 批量创建辅助弹性网卡
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateSubNetworkInterfaceResponse> BatchCreateSubNetworkInterfaceAsync(BatchCreateSubNetworkInterfaceRequest batchCreateSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateSubNetworkInterfaceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateSubNetworkInterfaceResponse>(response);
        }

        public AsyncInvoker<BatchCreateSubNetworkInterfaceResponse> BatchCreateSubNetworkInterfaceAsyncInvoker(BatchCreateSubNetworkInterfaceRequest batchCreateSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateSubNetworkInterfaceRequest);
            return new AsyncInvoker<BatchCreateSubNetworkInterfaceResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateSubNetworkInterfaceResponse>);
        }
        
        /// <summary>
        /// 创建安全组
        ///
        /// 创建安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest createSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSecurityGroupResponse>(response);
        }

        public AsyncInvoker<CreateSecurityGroupResponse> CreateSecurityGroupAsyncInvoker(CreateSecurityGroupRequest createSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityGroupRequest);
            return new AsyncInvoker<CreateSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 创建安全组规则
        ///
        /// 创建安全组规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSecurityGroupRuleResponse> CreateSecurityGroupRuleAsync(CreateSecurityGroupRuleRequest createSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityGroupRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSecurityGroupRuleResponse>(response);
        }

        public AsyncInvoker<CreateSecurityGroupRuleResponse> CreateSecurityGroupRuleAsyncInvoker(CreateSecurityGroupRuleRequest createSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityGroupRuleRequest);
            return new AsyncInvoker<CreateSecurityGroupRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 创建辅助弹性网卡
        ///
        /// 创建辅助弹性网卡
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSubNetworkInterfaceResponse> CreateSubNetworkInterfaceAsync(CreateSubNetworkInterfaceRequest createSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubNetworkInterfaceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSubNetworkInterfaceResponse>(response);
        }

        public AsyncInvoker<CreateSubNetworkInterfaceResponse> CreateSubNetworkInterfaceAsyncInvoker(CreateSubNetworkInterfaceRequest createSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubNetworkInterfaceRequest);
            return new AsyncInvoker<CreateSubNetworkInterfaceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSubNetworkInterfaceResponse>);
        }
        
        /// <summary>
        /// 创建流量镜像筛选条件
        ///
        /// 创建流量镜像筛选条件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTrafficMirrorFilterResponse> CreateTrafficMirrorFilterAsync(CreateTrafficMirrorFilterRequest createTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorFilterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTrafficMirrorFilterResponse>(response);
        }

        public AsyncInvoker<CreateTrafficMirrorFilterResponse> CreateTrafficMirrorFilterAsyncInvoker(CreateTrafficMirrorFilterRequest createTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorFilterRequest);
            return new AsyncInvoker<CreateTrafficMirrorFilterResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrafficMirrorFilterResponse>);
        }
        
        /// <summary>
        /// 创建流量镜像筛选规则
        ///
        /// 创建流量镜像筛选规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTrafficMirrorFilterRuleResponse> CreateTrafficMirrorFilterRuleAsync(CreateTrafficMirrorFilterRuleRequest createTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorFilterRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTrafficMirrorFilterRuleResponse>(response);
        }

        public AsyncInvoker<CreateTrafficMirrorFilterRuleResponse> CreateTrafficMirrorFilterRuleAsyncInvoker(CreateTrafficMirrorFilterRuleRequest createTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorFilterRuleRequest);
            return new AsyncInvoker<CreateTrafficMirrorFilterRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrafficMirrorFilterRuleResponse>);
        }
        
        /// <summary>
        /// 创建流量镜像会话
        ///
        /// 创建流量镜像会话
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTrafficMirrorSessionResponse> CreateTrafficMirrorSessionAsync(CreateTrafficMirrorSessionRequest createTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorSessionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTrafficMirrorSessionResponse>(response);
        }

        public AsyncInvoker<CreateTrafficMirrorSessionResponse> CreateTrafficMirrorSessionAsyncInvoker(CreateTrafficMirrorSessionRequest createTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorSessionRequest);
            return new AsyncInvoker<CreateTrafficMirrorSessionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrafficMirrorSessionResponse>);
        }
        
        /// <summary>
        /// 删除安全组
        ///
        /// 删除安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest deleteSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", deleteSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupResponse>(response);
        }

        public AsyncInvoker<DeleteSecurityGroupResponse> DeleteSecurityGroupAsyncInvoker(DeleteSecurityGroupRequest deleteSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", deleteSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRequest);
            return new AsyncInvoker<DeleteSecurityGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 删除安全组规则
        ///
        /// 删除安全组规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSecurityGroupRuleResponse> DeleteSecurityGroupRuleAsync(DeleteSecurityGroupRuleRequest deleteSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", deleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupRuleResponse>(response);
        }

        public AsyncInvoker<DeleteSecurityGroupRuleResponse> DeleteSecurityGroupRuleAsyncInvoker(DeleteSecurityGroupRuleRequest deleteSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", deleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRuleRequest);
            return new AsyncInvoker<DeleteSecurityGroupRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 删除辅助弹性网卡
        ///
        /// 删除辅助弹性网卡
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSubNetworkInterfaceResponse> DeleteSubNetworkInterfaceAsync(DeleteSubNetworkInterfaceRequest deleteSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id", deleteSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubNetworkInterfaceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSubNetworkInterfaceResponse>(response);
        }

        public AsyncInvoker<DeleteSubNetworkInterfaceResponse> DeleteSubNetworkInterfaceAsyncInvoker(DeleteSubNetworkInterfaceRequest deleteSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id", deleteSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubNetworkInterfaceRequest);
            return new AsyncInvoker<DeleteSubNetworkInterfaceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSubNetworkInterfaceResponse>);
        }
        
        /// <summary>
        /// 删除流量镜像筛选条件
        ///
        /// 删除流量镜像筛选条件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTrafficMirrorFilterResponse> DeleteTrafficMirrorFilterAsync(DeleteTrafficMirrorFilterRequest deleteTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id", deleteTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorFilterRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTrafficMirrorFilterResponse>(response);
        }

        public AsyncInvoker<DeleteTrafficMirrorFilterResponse> DeleteTrafficMirrorFilterAsyncInvoker(DeleteTrafficMirrorFilterRequest deleteTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id", deleteTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorFilterRequest);
            return new AsyncInvoker<DeleteTrafficMirrorFilterResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTrafficMirrorFilterResponse>);
        }
        
        /// <summary>
        /// 删除流量镜像筛选规则
        ///
        /// 删除流量镜像筛选规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTrafficMirrorFilterRuleResponse> DeleteTrafficMirrorFilterRuleAsync(DeleteTrafficMirrorFilterRuleRequest deleteTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id", deleteTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorFilterRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTrafficMirrorFilterRuleResponse>(response);
        }

        public AsyncInvoker<DeleteTrafficMirrorFilterRuleResponse> DeleteTrafficMirrorFilterRuleAsyncInvoker(DeleteTrafficMirrorFilterRuleRequest deleteTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id", deleteTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorFilterRuleRequest);
            return new AsyncInvoker<DeleteTrafficMirrorFilterRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTrafficMirrorFilterRuleResponse>);
        }
        
        /// <summary>
        /// 删除流量镜像会话
        ///
        /// 删除流量镜像会话
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTrafficMirrorSessionResponse> DeleteTrafficMirrorSessionAsync(DeleteTrafficMirrorSessionRequest deleteTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", deleteTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorSessionRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTrafficMirrorSessionResponse>(response);
        }

        public AsyncInvoker<DeleteTrafficMirrorSessionResponse> DeleteTrafficMirrorSessionAsyncInvoker(DeleteTrafficMirrorSessionRequest deleteTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", deleteTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorSessionRequest);
            return new AsyncInvoker<DeleteTrafficMirrorSessionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTrafficMirrorSessionResponse>);
        }
        
        /// <summary>
        /// 查询安全组规则列表
        ///
        /// 查询安全组规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSecurityGroupRulesResponse> ListSecurityGroupRulesAsync(ListSecurityGroupRulesRequest listSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSecurityGroupRulesResponse>(response);
        }

        public AsyncInvoker<ListSecurityGroupRulesResponse> ListSecurityGroupRulesAsyncInvoker(ListSecurityGroupRulesRequest listSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupRulesRequest);
            return new AsyncInvoker<ListSecurityGroupRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecurityGroupRulesResponse>);
        }
        
        /// <summary>
        /// 查询安全组列表
        ///
        /// 查询某租户下的安全组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSecurityGroupsResponse> ListSecurityGroupsAsync(ListSecurityGroupsRequest listSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSecurityGroupsResponse>(response);
        }

        public AsyncInvoker<ListSecurityGroupsResponse> ListSecurityGroupsAsyncInvoker(ListSecurityGroupsRequest listSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupsRequest);
            return new AsyncInvoker<ListSecurityGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecurityGroupsResponse>);
        }
        
        /// <summary>
        /// 查询租户下辅助弹性网卡列表
        ///
        /// 查询辅助弹性网卡列表，单次查询最多返回2000条数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubNetworkInterfacesResponse> ListSubNetworkInterfacesAsync(ListSubNetworkInterfacesRequest listSubNetworkInterfacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubNetworkInterfacesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSubNetworkInterfacesResponse>(response);
        }

        public AsyncInvoker<ListSubNetworkInterfacesResponse> ListSubNetworkInterfacesAsyncInvoker(ListSubNetworkInterfacesRequest listSubNetworkInterfacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubNetworkInterfacesRequest);
            return new AsyncInvoker<ListSubNetworkInterfacesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubNetworkInterfacesResponse>);
        }
        
        /// <summary>
        /// 查询流量镜像筛选规则列表
        ///
        /// 查询流量镜像筛选规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTrafficMirrorFilterRulesResponse> ListTrafficMirrorFilterRulesAsync(ListTrafficMirrorFilterRulesRequest listTrafficMirrorFilterRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorFilterRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTrafficMirrorFilterRulesResponse>(response);
        }

        public AsyncInvoker<ListTrafficMirrorFilterRulesResponse> ListTrafficMirrorFilterRulesAsyncInvoker(ListTrafficMirrorFilterRulesRequest listTrafficMirrorFilterRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorFilterRulesRequest);
            return new AsyncInvoker<ListTrafficMirrorFilterRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrafficMirrorFilterRulesResponse>);
        }
        
        /// <summary>
        /// 查询流量镜像筛选条件列表
        ///
        /// 查询流量镜像筛选条件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTrafficMirrorFiltersResponse> ListTrafficMirrorFiltersAsync(ListTrafficMirrorFiltersRequest listTrafficMirrorFiltersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorFiltersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTrafficMirrorFiltersResponse>(response);
        }

        public AsyncInvoker<ListTrafficMirrorFiltersResponse> ListTrafficMirrorFiltersAsyncInvoker(ListTrafficMirrorFiltersRequest listTrafficMirrorFiltersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorFiltersRequest);
            return new AsyncInvoker<ListTrafficMirrorFiltersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrafficMirrorFiltersResponse>);
        }
        
        /// <summary>
        /// 查询流量镜像会话列表
        ///
        /// 查询流量镜像会话列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTrafficMirrorSessionsResponse> ListTrafficMirrorSessionsAsync(ListTrafficMirrorSessionsRequest listTrafficMirrorSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorSessionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTrafficMirrorSessionsResponse>(response);
        }

        public AsyncInvoker<ListTrafficMirrorSessionsResponse> ListTrafficMirrorSessionsAsyncInvoker(ListTrafficMirrorSessionsRequest listTrafficMirrorSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorSessionsRequest);
            return new AsyncInvoker<ListTrafficMirrorSessionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrafficMirrorSessionsResponse>);
        }
        
        /// <summary>
        /// 迁移辅助弹性网卡
        ///
        /// 批量迁移辅助弹性网卡
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<MigrateSubNetworkInterfaceResponse> MigrateSubNetworkInterfaceAsync(MigrateSubNetworkInterfaceRequest migrateSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateSubNetworkInterfaceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<MigrateSubNetworkInterfaceResponse>(response);
        }

        public AsyncInvoker<MigrateSubNetworkInterfaceResponse> MigrateSubNetworkInterfaceAsyncInvoker(MigrateSubNetworkInterfaceRequest migrateSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateSubNetworkInterfaceRequest);
            return new AsyncInvoker<MigrateSubNetworkInterfaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<MigrateSubNetworkInterfaceResponse>);
        }
        
        /// <summary>
        /// 端口移除安全组
        ///
        /// 端口移除安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveSecurityGroupsResponse> RemoveSecurityGroupsAsync(RemoveSecurityGroupsRequest removeSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", removeSecurityGroupsRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/ports/{port_id}/remove-security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeSecurityGroupsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<RemoveSecurityGroupsResponse>(response);
        }

        public AsyncInvoker<RemoveSecurityGroupsResponse> RemoveSecurityGroupsAsyncInvoker(RemoveSecurityGroupsRequest removeSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", removeSecurityGroupsRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/ports/{port_id}/remove-security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeSecurityGroupsRequest);
            return new AsyncInvoker<RemoveSecurityGroupsResponse>(this, "PUT", request, JsonUtils.DeSerialize<RemoveSecurityGroupsResponse>);
        }
        
        /// <summary>
        /// 流量镜像会话移除镜像源
        ///
        /// 流量镜像会话移除镜像源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveSourcesFromTrafficMirrorSessionResponse> RemoveSourcesFromTrafficMirrorSessionAsync(RemoveSourcesFromTrafficMirrorSessionRequest removeSourcesFromTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", removeSourcesFromTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}/remove-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeSourcesFromTrafficMirrorSessionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<RemoveSourcesFromTrafficMirrorSessionResponse>(response);
        }

        public AsyncInvoker<RemoveSourcesFromTrafficMirrorSessionResponse> RemoveSourcesFromTrafficMirrorSessionAsyncInvoker(RemoveSourcesFromTrafficMirrorSessionRequest removeSourcesFromTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", removeSourcesFromTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}/remove-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeSourcesFromTrafficMirrorSessionRequest);
            return new AsyncInvoker<RemoveSourcesFromTrafficMirrorSessionResponse>(this, "PUT", request, JsonUtils.DeSerialize<RemoveSourcesFromTrafficMirrorSessionResponse>);
        }
        
        /// <summary>
        /// 查询安全组
        ///
        /// 查询单个安全组详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSecurityGroupResponse> ShowSecurityGroupAsync(ShowSecurityGroupRequest showSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", showSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSecurityGroupResponse>(response);
        }

        public AsyncInvoker<ShowSecurityGroupResponse> ShowSecurityGroupAsyncInvoker(ShowSecurityGroupRequest showSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", showSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRequest);
            return new AsyncInvoker<ShowSecurityGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 查询安全组规则
        ///
        /// 查询单个安全组规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSecurityGroupRuleResponse> ShowSecurityGroupRuleAsync(ShowSecurityGroupRuleRequest showSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", showSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSecurityGroupRuleResponse>(response);
        }

        public AsyncInvoker<ShowSecurityGroupRuleResponse> ShowSecurityGroupRuleAsyncInvoker(ShowSecurityGroupRuleRequest showSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", showSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRuleRequest);
            return new AsyncInvoker<ShowSecurityGroupRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 查询租户下辅助弹性网卡
        ///
        /// 查询辅助弹性网卡详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSubNetworkInterfaceResponse> ShowSubNetworkInterfaceAsync(ShowSubNetworkInterfaceRequest showSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id", showSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubNetworkInterfaceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSubNetworkInterfaceResponse>(response);
        }

        public AsyncInvoker<ShowSubNetworkInterfaceResponse> ShowSubNetworkInterfaceAsyncInvoker(ShowSubNetworkInterfaceRequest showSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id", showSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubNetworkInterfaceRequest);
            return new AsyncInvoker<ShowSubNetworkInterfaceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubNetworkInterfaceResponse>);
        }
        
        /// <summary>
        /// 查询租户下辅助弹性网卡数目
        ///
        /// 查询辅助弹性网卡数目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSubNetworkInterfacesQuantityResponse> ShowSubNetworkInterfacesQuantityAsync(ShowSubNetworkInterfacesQuantityRequest showSubNetworkInterfacesQuantityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubNetworkInterfacesQuantityRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSubNetworkInterfacesQuantityResponse>(response);
        }

        public AsyncInvoker<ShowSubNetworkInterfacesQuantityResponse> ShowSubNetworkInterfacesQuantityAsyncInvoker(ShowSubNetworkInterfacesQuantityRequest showSubNetworkInterfacesQuantityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubNetworkInterfacesQuantityRequest);
            return new AsyncInvoker<ShowSubNetworkInterfacesQuantityResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubNetworkInterfacesQuantityResponse>);
        }
        
        /// <summary>
        /// 查询流量镜像筛选条件详情
        ///
        /// 查询流量镜像筛选条件详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrafficMirrorFilterResponse> ShowTrafficMirrorFilterAsync(ShowTrafficMirrorFilterRequest showTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id", showTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorFilterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrafficMirrorFilterResponse>(response);
        }

        public AsyncInvoker<ShowTrafficMirrorFilterResponse> ShowTrafficMirrorFilterAsyncInvoker(ShowTrafficMirrorFilterRequest showTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id", showTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorFilterRequest);
            return new AsyncInvoker<ShowTrafficMirrorFilterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrafficMirrorFilterResponse>);
        }
        
        /// <summary>
        /// 查询流量镜像筛选规则详情
        ///
        /// 查询流量镜像筛选规则详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrafficMirrorFilterRuleResponse> ShowTrafficMirrorFilterRuleAsync(ShowTrafficMirrorFilterRuleRequest showTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id", showTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorFilterRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrafficMirrorFilterRuleResponse>(response);
        }

        public AsyncInvoker<ShowTrafficMirrorFilterRuleResponse> ShowTrafficMirrorFilterRuleAsyncInvoker(ShowTrafficMirrorFilterRuleRequest showTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id", showTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorFilterRuleRequest);
            return new AsyncInvoker<ShowTrafficMirrorFilterRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrafficMirrorFilterRuleResponse>);
        }
        
        /// <summary>
        /// 查询流量镜像会话详情
        ///
        /// 查询流量镜像会话详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTrafficMirrorSessionResponse> ShowTrafficMirrorSessionAsync(ShowTrafficMirrorSessionRequest showTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", showTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorSessionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTrafficMirrorSessionResponse>(response);
        }

        public AsyncInvoker<ShowTrafficMirrorSessionResponse> ShowTrafficMirrorSessionAsyncInvoker(ShowTrafficMirrorSessionRequest showTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", showTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorSessionRequest);
            return new AsyncInvoker<ShowTrafficMirrorSessionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrafficMirrorSessionResponse>);
        }
        
        /// <summary>
        /// 更新安全组
        ///
        /// 更新安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSecurityGroupResponse> UpdateSecurityGroupAsync(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", updateSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSecurityGroupResponse>(response);
        }

        public AsyncInvoker<UpdateSecurityGroupResponse> UpdateSecurityGroupAsyncInvoker(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", updateSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            return new AsyncInvoker<UpdateSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 更新辅助弹性网卡
        ///
        /// 更新辅助弹性网卡
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSubNetworkInterfaceResponse> UpdateSubNetworkInterfaceAsync(UpdateSubNetworkInterfaceRequest updateSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id", updateSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubNetworkInterfaceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSubNetworkInterfaceResponse>(response);
        }

        public AsyncInvoker<UpdateSubNetworkInterfaceResponse> UpdateSubNetworkInterfaceAsyncInvoker(UpdateSubNetworkInterfaceRequest updateSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id", updateSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubNetworkInterfaceRequest);
            return new AsyncInvoker<UpdateSubNetworkInterfaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSubNetworkInterfaceResponse>);
        }
        
        /// <summary>
        /// 更新流量镜像筛选条件
        ///
        /// 更新流量镜像筛选条件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTrafficMirrorFilterResponse> UpdateTrafficMirrorFilterAsync(UpdateTrafficMirrorFilterRequest updateTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id", updateTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorFilterRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTrafficMirrorFilterResponse>(response);
        }

        public AsyncInvoker<UpdateTrafficMirrorFilterResponse> UpdateTrafficMirrorFilterAsyncInvoker(UpdateTrafficMirrorFilterRequest updateTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id", updateTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorFilterRequest);
            return new AsyncInvoker<UpdateTrafficMirrorFilterResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTrafficMirrorFilterResponse>);
        }
        
        /// <summary>
        /// 更新流量镜像筛选规则
        ///
        /// 更新流量镜像筛选规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTrafficMirrorFilterRuleResponse> UpdateTrafficMirrorFilterRuleAsync(UpdateTrafficMirrorFilterRuleRequest updateTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id", updateTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorFilterRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTrafficMirrorFilterRuleResponse>(response);
        }

        public AsyncInvoker<UpdateTrafficMirrorFilterRuleResponse> UpdateTrafficMirrorFilterRuleAsyncInvoker(UpdateTrafficMirrorFilterRuleRequest updateTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id", updateTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorFilterRuleRequest);
            return new AsyncInvoker<UpdateTrafficMirrorFilterRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTrafficMirrorFilterRuleResponse>);
        }
        
        /// <summary>
        /// 更新流量镜像会话
        ///
        /// 更新流量镜像会话
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTrafficMirrorSessionResponse> UpdateTrafficMirrorSessionAsync(UpdateTrafficMirrorSessionRequest updateTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", updateTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorSessionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTrafficMirrorSessionResponse>(response);
        }

        public AsyncInvoker<UpdateTrafficMirrorSessionResponse> UpdateTrafficMirrorSessionAsyncInvoker(UpdateTrafficMirrorSessionRequest updateTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", updateTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorSessionRequest);
            return new AsyncInvoker<UpdateTrafficMirrorSessionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTrafficMirrorSessionResponse>);
        }
        
        /// <summary>
        /// 网络ACL插入规则
        ///
        /// 网络ACL插入规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddFirewallRulesResponse> AddFirewallRulesAsync(AddFirewallRulesRequest addFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", addFirewallRulesRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/insert-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFirewallRulesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<AddFirewallRulesResponse>(response);
        }

        public AsyncInvoker<AddFirewallRulesResponse> AddFirewallRulesAsyncInvoker(AddFirewallRulesRequest addFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", addFirewallRulesRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/insert-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFirewallRulesRequest);
            return new AsyncInvoker<AddFirewallRulesResponse>(this, "PUT", request, JsonUtils.DeSerialize<AddFirewallRulesResponse>);
        }
        
        /// <summary>
        /// 网络ACL绑定子网
        ///
        /// 网络ACL绑定子网
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateSubnetFirewallResponse> AssociateSubnetFirewallAsync(AssociateSubnetFirewallRequest associateSubnetFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", associateSubnetFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/associate-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateSubnetFirewallRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<AssociateSubnetFirewallResponse>(response);
        }

        public AsyncInvoker<AssociateSubnetFirewallResponse> AssociateSubnetFirewallAsyncInvoker(AssociateSubnetFirewallRequest associateSubnetFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", associateSubnetFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/associate-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateSubnetFirewallRequest);
            return new AsyncInvoker<AssociateSubnetFirewallResponse>(this, "PUT", request, JsonUtils.DeSerialize<AssociateSubnetFirewallResponse>);
        }
        
        /// <summary>
        /// 批量添加ACL资源标签
        ///
        /// 为指定的IP地址组资源实例批量添加标签。
        /// 此接口为幂等接口：创建时如果请求体中存在重复key则报错。创建时，不允许设置重复key数据，如果数据库已存在该key，就覆盖value的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateFirewallTagsResponse> BatchCreateFirewallTagsAsync(BatchCreateFirewallTagsRequest batchCreateFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", batchCreateFirewallTagsRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateFirewallTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateFirewallTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateFirewallTagsResponse> BatchCreateFirewallTagsAsyncInvoker(BatchCreateFirewallTagsRequest batchCreateFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", batchCreateFirewallTagsRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateFirewallTagsRequest);
            return new AsyncInvoker<BatchCreateFirewallTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateFirewallTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除ACL资源标签
        ///
        /// 为指定的IP地址组资源实例批量删除标签。
        /// 此接口为幂等接口：删除时，如果删除的标签不存在，默认处理成功；删除时不对标签字符集范围做校验。删除时tags结构体不能缺失，key不能为空，或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteFirewallTagsResponse> BatchDeleteFirewallTagsAsync(BatchDeleteFirewallTagsRequest batchDeleteFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", batchDeleteFirewallTagsRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFirewallTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteFirewallTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteFirewallTagsResponse> BatchDeleteFirewallTagsAsyncInvoker(BatchDeleteFirewallTagsRequest batchDeleteFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", batchDeleteFirewallTagsRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFirewallTagsRequest);
            return new AsyncInvoker<BatchDeleteFirewallTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteFirewallTagsResponse>);
        }
        
        /// <summary>
        /// 查询ACL资源实例数量
        ///
        /// 使用标签过滤查询ACL实例数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountFirewallsByTagsResponse> CountFirewallsByTagsAsync(CountFirewallsByTagsRequest countFirewallsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countFirewallsByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountFirewallsByTagsResponse>(response);
        }

        public AsyncInvoker<CountFirewallsByTagsResponse> CountFirewallsByTagsAsyncInvoker(CountFirewallsByTagsRequest countFirewallsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countFirewallsByTagsRequest);
            return new AsyncInvoker<CountFirewallsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountFirewallsByTagsResponse>);
        }
        
        /// <summary>
        /// 创建网络ACL
        ///
        /// 创建网络ACL
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFirewallResponse> CreateFirewallAsync(CreateFirewallRequest createFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateFirewallResponse>(response);
        }

        public AsyncInvoker<CreateFirewallResponse> CreateFirewallAsyncInvoker(CreateFirewallRequest createFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallRequest);
            return new AsyncInvoker<CreateFirewallResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFirewallResponse>);
        }
        
        /// <summary>
        /// 添加ACL资源标签
        ///
        /// 给指定IP地址组资源实例增加标签信息
        /// 此接口为幂等接口：创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFirewallTagResponse> CreateFirewallTagAsync(CreateFirewallTagRequest createFirewallTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", createFirewallTagRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateFirewallTagResponse>(response);
        }

        public AsyncInvoker<CreateFirewallTagResponse> CreateFirewallTagAsyncInvoker(CreateFirewallTagRequest createFirewallTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", createFirewallTagRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallTagRequest);
            return new AsyncInvoker<CreateFirewallTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateFirewallTagResponse>);
        }
        
        /// <summary>
        /// 删除网络ACL
        ///
        /// 删除网络ACL
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFirewallResponse> DeleteFirewallAsync(DeleteFirewallRequest deleteFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", deleteFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteFirewallResponse>(response);
        }

        public AsyncInvoker<DeleteFirewallResponse> DeleteFirewallAsyncInvoker(DeleteFirewallRequest deleteFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", deleteFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallRequest);
            return new AsyncInvoker<DeleteFirewallResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFirewallResponse>);
        }
        
        /// <summary>
        /// 删除ACL资源标签
        ///
        /// 删除指定IP地址组资源实例的标签信息
        /// 该接口为幂等接口：删除的key不存在报404，key不能为空或者空字符串
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFirewallTagResponse> DeleteFirewallTagAsync(DeleteFirewallTagRequest deleteFirewallTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", deleteFirewallTagRequest.FirewallId.ToString());
            urlParam.Add("tag_key", deleteFirewallTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteFirewallTagResponse>(response);
        }

        public AsyncInvoker<DeleteFirewallTagResponse> DeleteFirewallTagAsyncInvoker(DeleteFirewallTagRequest deleteFirewallTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", deleteFirewallTagRequest.FirewallId.ToString());
            urlParam.Add("tag_key", deleteFirewallTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallTagRequest);
            return new AsyncInvoker<DeleteFirewallTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFirewallTagResponse>);
        }
        
        /// <summary>
        /// 网络ACL解绑子网
        ///
        /// 网络ACL解绑子网
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateSubnetFirewallResponse> DisassociateSubnetFirewallAsync(DisassociateSubnetFirewallRequest disassociateSubnetFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", disassociateSubnetFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/disassociate-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateSubnetFirewallRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<DisassociateSubnetFirewallResponse>(response);
        }

        public AsyncInvoker<DisassociateSubnetFirewallResponse> DisassociateSubnetFirewallAsyncInvoker(DisassociateSubnetFirewallRequest disassociateSubnetFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", disassociateSubnetFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/disassociate-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateSubnetFirewallRequest);
            return new AsyncInvoker<DisassociateSubnetFirewallResponse>(this, "PUT", request, JsonUtils.DeSerialize<DisassociateSubnetFirewallResponse>);
        }
        
        /// <summary>
        /// 查询网络ACL列表
        ///
        /// 查询网络ACL列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFirewallResponse> ListFirewallAsync(ListFirewallRequest listFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFirewallResponse>(response);
        }

        public AsyncInvoker<ListFirewallResponse> ListFirewallAsyncInvoker(ListFirewallRequest listFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallRequest);
            return new AsyncInvoker<ListFirewallResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFirewallResponse>);
        }
        
        /// <summary>
        /// 查询ACL项目标签
        ///
        /// 查询租户在指定Project中实例类型的所有资源标签集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFirewallTagsResponse> ListFirewallTagsAsync(ListFirewallTagsRequest listFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFirewallTagsResponse>(response);
        }

        public AsyncInvoker<ListFirewallTagsResponse> ListFirewallTagsAsyncInvoker(ListFirewallTagsRequest listFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallTagsRequest);
            return new AsyncInvoker<ListFirewallTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFirewallTagsResponse>);
        }
        
        /// <summary>
        /// 查询ACL资源实例列表
        ///
        /// 使用标签过滤查询ACL实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFirewallsByTagsResponse> ListFirewallsByTagsAsync(ListFirewallsByTagsRequest listFirewallsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallsByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListFirewallsByTagsResponse>(response);
        }

        public AsyncInvoker<ListFirewallsByTagsResponse> ListFirewallsByTagsAsyncInvoker(ListFirewallsByTagsRequest listFirewallsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallsByTagsRequest);
            return new AsyncInvoker<ListFirewallsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListFirewallsByTagsResponse>);
        }
        
        /// <summary>
        /// 网络ACL移除规则
        ///
        /// 网络ACL移除规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveFirewallRulesResponse> RemoveFirewallRulesAsync(RemoveFirewallRulesRequest removeFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", removeFirewallRulesRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/remove-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeFirewallRulesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<RemoveFirewallRulesResponse>(response);
        }

        public AsyncInvoker<RemoveFirewallRulesResponse> RemoveFirewallRulesAsyncInvoker(RemoveFirewallRulesRequest removeFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", removeFirewallRulesRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/remove-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeFirewallRulesRequest);
            return new AsyncInvoker<RemoveFirewallRulesResponse>(this, "PUT", request, JsonUtils.DeSerialize<RemoveFirewallRulesResponse>);
        }
        
        /// <summary>
        /// 查询网络ACL详情
        ///
        /// 查询网络ACL详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFirewallResponse> ShowFirewallAsync(ShowFirewallRequest showFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", showFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFirewallRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFirewallResponse>(response);
        }

        public AsyncInvoker<ShowFirewallResponse> ShowFirewallAsyncInvoker(ShowFirewallRequest showFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", showFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFirewallRequest);
            return new AsyncInvoker<ShowFirewallResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFirewallResponse>);
        }
        
        /// <summary>
        /// 查询ACL资源标签
        ///
        /// 查询指定ACL实例的标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFirewallTagsResponse> ShowFirewallTagsAsync(ShowFirewallTagsRequest showFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", showFirewallTagsRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFirewallTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFirewallTagsResponse>(response);
        }

        public AsyncInvoker<ShowFirewallTagsResponse> ShowFirewallTagsAsyncInvoker(ShowFirewallTagsRequest showFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", showFirewallTagsRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFirewallTagsRequest);
            return new AsyncInvoker<ShowFirewallTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFirewallTagsResponse>);
        }
        
        /// <summary>
        /// 更新网络ACL
        ///
        /// 更新网络ACL
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFirewallResponse> UpdateFirewallAsync(UpdateFirewallRequest updateFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", updateFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFirewallRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFirewallResponse>(response);
        }

        public AsyncInvoker<UpdateFirewallResponse> UpdateFirewallAsyncInvoker(UpdateFirewallRequest updateFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", updateFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFirewallRequest);
            return new AsyncInvoker<UpdateFirewallResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFirewallResponse>);
        }
        
        /// <summary>
        /// 网络ACL更新规则
        ///
        /// 网络ACL更新规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFirewallRulesResponse> UpdateFirewallRulesAsync(UpdateFirewallRulesRequest updateFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", updateFirewallRulesRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/update-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFirewallRulesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFirewallRulesResponse>(response);
        }

        public AsyncInvoker<UpdateFirewallRulesResponse> UpdateFirewallRulesAsyncInvoker(UpdateFirewallRulesRequest updateFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", updateFirewallRulesRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/update-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFirewallRulesRequest);
            return new AsyncInvoker<UpdateFirewallRulesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFirewallRulesResponse>);
        }
        
        /// <summary>
        /// 添加Clouddcn子网标签
        ///
        /// 添加Clouddcn子网的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddClouddcnSubnetsTagsResponse> AddClouddcnSubnetsTagsAsync(AddClouddcnSubnetsTagsRequest addClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addClouddcnSubnetsTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddClouddcnSubnetsTagsResponse>(response);
        }

        public AsyncInvoker<AddClouddcnSubnetsTagsResponse> AddClouddcnSubnetsTagsAsyncInvoker(AddClouddcnSubnetsTagsRequest addClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addClouddcnSubnetsTagsRequest);
            return new AsyncInvoker<AddClouddcnSubnetsTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddClouddcnSubnetsTagsResponse>);
        }
        
        /// <summary>
        /// 批量添加Clouddcn子网标签
        ///
        /// 批量添加Clouddcn子网的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateClouddcnSubnetsTagsResponse> BatchCreateClouddcnSubnetsTagsAsync(BatchCreateClouddcnSubnetsTagsRequest batchCreateClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateClouddcnSubnetsTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateClouddcnSubnetsTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateClouddcnSubnetsTagsResponse> BatchCreateClouddcnSubnetsTagsAsyncInvoker(BatchCreateClouddcnSubnetsTagsRequest batchCreateClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateClouddcnSubnetsTagsRequest);
            return new AsyncInvoker<BatchCreateClouddcnSubnetsTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateClouddcnSubnetsTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除Clouddcn子网标签
        ///
        /// 批量删除Clouddcn子网的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteClouddcnSubnetsTagsResponse> BatchDeleteClouddcnSubnetsTagsAsync(BatchDeleteClouddcnSubnetsTagsRequest batchDeleteClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteClouddcnSubnetsTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteClouddcnSubnetsTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteClouddcnSubnetsTagsResponse> BatchDeleteClouddcnSubnetsTagsAsyncInvoker(BatchDeleteClouddcnSubnetsTagsRequest batchDeleteClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteClouddcnSubnetsTagsRequest);
            return new AsyncInvoker<BatchDeleteClouddcnSubnetsTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteClouddcnSubnetsTagsResponse>);
        }
        
        /// <summary>
        /// 创建clouddcn子网
        ///
        /// 创建clouddcn子网。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateClouddcnSubnetResponse> CreateClouddcnSubnetAsync(CreateClouddcnSubnetRequest createClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClouddcnSubnetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateClouddcnSubnetResponse>(response);
        }

        public AsyncInvoker<CreateClouddcnSubnetResponse> CreateClouddcnSubnetAsyncInvoker(CreateClouddcnSubnetRequest createClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClouddcnSubnetRequest);
            return new AsyncInvoker<CreateClouddcnSubnetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateClouddcnSubnetResponse>);
        }
        
        /// <summary>
        /// 删除clouddcn子网
        ///
        /// 删除clouddcn子网
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteClouddcnSubnetResponse> DeleteClouddcnSubnetAsync(DeleteClouddcnSubnetRequest deleteClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("clouddcn_subnet_id", deleteClouddcnSubnetRequest.ClouddcnSubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets/{clouddcn_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClouddcnSubnetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteClouddcnSubnetResponse>(response);
        }

        public AsyncInvoker<DeleteClouddcnSubnetResponse> DeleteClouddcnSubnetAsyncInvoker(DeleteClouddcnSubnetRequest deleteClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("clouddcn_subnet_id", deleteClouddcnSubnetRequest.ClouddcnSubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets/{clouddcn_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClouddcnSubnetRequest);
            return new AsyncInvoker<DeleteClouddcnSubnetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteClouddcnSubnetResponse>);
        }
        
        /// <summary>
        /// 删除Clouddcn子网标签
        ///
        /// 删除Clouddcn子网的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteClouddcnSubnetsTagResponse> DeleteClouddcnSubnetsTagAsync(DeleteClouddcnSubnetsTagRequest deleteClouddcnSubnetsTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteClouddcnSubnetsTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteClouddcnSubnetsTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClouddcnSubnetsTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteClouddcnSubnetsTagResponse>(response);
        }

        public AsyncInvoker<DeleteClouddcnSubnetsTagResponse> DeleteClouddcnSubnetsTagAsyncInvoker(DeleteClouddcnSubnetsTagRequest deleteClouddcnSubnetsTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteClouddcnSubnetsTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteClouddcnSubnetsTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClouddcnSubnetsTagRequest);
            return new AsyncInvoker<DeleteClouddcnSubnetsTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteClouddcnSubnetsTagResponse>);
        }
        
        /// <summary>
        /// 查询clouddcn子网列表
        ///
        /// 查询clouddcn子网列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListClouddcnSubnetsResponse> ListClouddcnSubnetsAsync(ListClouddcnSubnetsRequest listClouddcnSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListClouddcnSubnetsResponse>(response);
        }

        public AsyncInvoker<ListClouddcnSubnetsResponse> ListClouddcnSubnetsAsyncInvoker(ListClouddcnSubnetsRequest listClouddcnSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsRequest);
            return new AsyncInvoker<ListClouddcnSubnetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClouddcnSubnetsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表数目
        ///
        /// 查询资源实例列表数目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListClouddcnSubnetsCountFilterTagsResponse> ListClouddcnSubnetsCountFilterTagsAsync(ListClouddcnSubnetsCountFilterTagsRequest listClouddcnSubnetsCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsCountFilterTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListClouddcnSubnetsCountFilterTagsResponse>(response);
        }

        public AsyncInvoker<ListClouddcnSubnetsCountFilterTagsResponse> ListClouddcnSubnetsCountFilterTagsAsyncInvoker(ListClouddcnSubnetsCountFilterTagsRequest listClouddcnSubnetsCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsCountFilterTagsRequest);
            return new AsyncInvoker<ListClouddcnSubnetsCountFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListClouddcnSubnetsCountFilterTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表
        ///
        /// 查询资源实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListClouddcnSubnetsFilterTagsResponse> ListClouddcnSubnetsFilterTagsAsync(ListClouddcnSubnetsFilterTagsRequest listClouddcnSubnetsFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsFilterTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListClouddcnSubnetsFilterTagsResponse>(response);
        }

        public AsyncInvoker<ListClouddcnSubnetsFilterTagsResponse> ListClouddcnSubnetsFilterTagsAsyncInvoker(ListClouddcnSubnetsFilterTagsRequest listClouddcnSubnetsFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsFilterTagsRequest);
            return new AsyncInvoker<ListClouddcnSubnetsFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListClouddcnSubnetsFilterTagsResponse>);
        }
        
        /// <summary>
        /// 查询Clouddcn子网项目标签
        ///
        /// 查询Clouddcn子网的项目标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListClouddcnSubnetsTagsResponse> ListClouddcnSubnetsTagsAsync(ListClouddcnSubnetsTagsRequest listClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListClouddcnSubnetsTagsResponse>(response);
        }

        public AsyncInvoker<ListClouddcnSubnetsTagsResponse> ListClouddcnSubnetsTagsAsyncInvoker(ListClouddcnSubnetsTagsRequest listClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsTagsRequest);
            return new AsyncInvoker<ListClouddcnSubnetsTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClouddcnSubnetsTagsResponse>);
        }
        
        /// <summary>
        /// 查询clouddcn子网
        ///
        /// 查询clouddcn子网详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClouddcnSubnetResponse> ShowClouddcnSubnetAsync(ShowClouddcnSubnetRequest showClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("clouddcn_subnet_id", showClouddcnSubnetRequest.ClouddcnSubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets/{clouddcn_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClouddcnSubnetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClouddcnSubnetResponse>(response);
        }

        public AsyncInvoker<ShowClouddcnSubnetResponse> ShowClouddcnSubnetAsyncInvoker(ShowClouddcnSubnetRequest showClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("clouddcn_subnet_id", showClouddcnSubnetRequest.ClouddcnSubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets/{clouddcn_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClouddcnSubnetRequest);
            return new AsyncInvoker<ShowClouddcnSubnetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClouddcnSubnetResponse>);
        }
        
        /// <summary>
        /// 查询Clouddcn子网标签
        ///
        /// 查询Clouddcn子网的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClouddcnSubnetsTagsResponse> ShowClouddcnSubnetsTagsAsync(ShowClouddcnSubnetsTagsRequest showClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClouddcnSubnetsTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClouddcnSubnetsTagsResponse>(response);
        }

        public AsyncInvoker<ShowClouddcnSubnetsTagsResponse> ShowClouddcnSubnetsTagsAsyncInvoker(ShowClouddcnSubnetsTagsRequest showClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClouddcnSubnetsTagsRequest);
            return new AsyncInvoker<ShowClouddcnSubnetsTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClouddcnSubnetsTagsResponse>);
        }
        
        /// <summary>
        /// 更新clouddcn子网
        ///
        /// 更新clouddcn子网。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateClouddcnSubnetResponse> UpdateClouddcnSubnetAsync(UpdateClouddcnSubnetRequest updateClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("clouddcn_subnet_id", updateClouddcnSubnetRequest.ClouddcnSubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets/{clouddcn_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClouddcnSubnetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateClouddcnSubnetResponse>(response);
        }

        public AsyncInvoker<UpdateClouddcnSubnetResponse> UpdateClouddcnSubnetAsyncInvoker(UpdateClouddcnSubnetRequest updateClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("clouddcn_subnet_id", updateClouddcnSubnetRequest.ClouddcnSubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets/{clouddcn_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClouddcnSubnetRequest);
            return new AsyncInvoker<UpdateClouddcnSubnetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateClouddcnSubnetResponse>);
        }
        
        /// <summary>
        /// 创建地址组
        ///
        /// 创建地址组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAddressGroupResponse> CreateAddressGroupAsync(CreateAddressGroupRequest createAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddressGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAddressGroupResponse>(response);
        }

        public AsyncInvoker<CreateAddressGroupResponse> CreateAddressGroupAsyncInvoker(CreateAddressGroupRequest createAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddressGroupRequest);
            return new AsyncInvoker<CreateAddressGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAddressGroupResponse>);
        }
        
        /// <summary>
        /// 删除地址组
        ///
        /// 删除地址组，非强制删除，删除前请确保未被其他资源引用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAddressGroupResponse> DeleteAddressGroupAsync(DeleteAddressGroupRequest deleteAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", deleteAddressGroupRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAddressGroupResponse>(response);
        }

        public AsyncInvoker<DeleteAddressGroupResponse> DeleteAddressGroupAsyncInvoker(DeleteAddressGroupRequest deleteAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", deleteAddressGroupRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressGroupRequest);
            return new AsyncInvoker<DeleteAddressGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAddressGroupResponse>);
        }
        
        /// <summary>
        /// 强制删除地址组
        ///
        /// 强制删除地址组，删除的地址组与安全组规则关联时，会删除地址组与关联的安全组规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteIpAddressGroupForceResponse> DeleteIpAddressGroupForceAsync(DeleteIpAddressGroupForceRequest deleteIpAddressGroupForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", deleteIpAddressGroupForceRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}/force", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpAddressGroupForceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteIpAddressGroupForceResponse>(response);
        }

        public AsyncInvoker<DeleteIpAddressGroupForceResponse> DeleteIpAddressGroupForceAsyncInvoker(DeleteIpAddressGroupForceRequest deleteIpAddressGroupForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", deleteIpAddressGroupForceRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}/force", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpAddressGroupForceRequest);
            return new AsyncInvoker<DeleteIpAddressGroupForceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteIpAddressGroupForceResponse>);
        }
        
        /// <summary>
        /// 查询地址组列表
        ///
        /// 查询地址组列表，根据过滤条件进行过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAddressGroupResponse> ListAddressGroupAsync(ListAddressGroupRequest listAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAddressGroupResponse>(response);
        }

        public AsyncInvoker<ListAddressGroupResponse> ListAddressGroupAsyncInvoker(ListAddressGroupRequest listAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressGroupRequest);
            return new AsyncInvoker<ListAddressGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddressGroupResponse>);
        }
        
        /// <summary>
        /// 查询地址组
        ///
        /// 查询地址组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAddressGroupResponse> ShowAddressGroupAsync(ShowAddressGroupRequest showAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", showAddressGroupRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddressGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAddressGroupResponse>(response);
        }

        public AsyncInvoker<ShowAddressGroupResponse> ShowAddressGroupAsyncInvoker(ShowAddressGroupRequest showAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", showAddressGroupRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddressGroupRequest);
            return new AsyncInvoker<ShowAddressGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAddressGroupResponse>);
        }
        
        /// <summary>
        /// 更新地址组
        ///
        /// 更新地址组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAddressGroupResponse> UpdateAddressGroupAsync(UpdateAddressGroupRequest updateAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", updateAddressGroupRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAddressGroupResponse>(response);
        }

        public AsyncInvoker<UpdateAddressGroupResponse> UpdateAddressGroupAsyncInvoker(UpdateAddressGroupRequest updateAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", updateAddressGroupRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressGroupRequest);
            return new AsyncInvoker<UpdateAddressGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAddressGroupResponse>);
        }
        
        /// <summary>
        /// 添加VPC扩展网段
        ///
        /// 添加VPC的扩展网段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddVpcExtendCidrResponse> AddVpcExtendCidrAsync(AddVpcExtendCidrRequest addVpcExtendCidrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", addVpcExtendCidrRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}/add-extend-cidr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addVpcExtendCidrRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<AddVpcExtendCidrResponse>(response);
        }

        public AsyncInvoker<AddVpcExtendCidrResponse> AddVpcExtendCidrAsyncInvoker(AddVpcExtendCidrRequest addVpcExtendCidrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", addVpcExtendCidrRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}/add-extend-cidr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addVpcExtendCidrRequest);
            return new AsyncInvoker<AddVpcExtendCidrResponse>(this, "PUT", request, JsonUtils.DeSerialize<AddVpcExtendCidrResponse>);
        }
        
        /// <summary>
        /// 创建VPC
        ///
        /// 创建虚拟私有云
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest createVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVpcRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateVpcResponse>(response);
        }

        public AsyncInvoker<CreateVpcResponse> CreateVpcAsyncInvoker(CreateVpcRequest createVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVpcRequest);
            return new AsyncInvoker<CreateVpcResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVpcResponse>);
        }
        
        /// <summary>
        /// 删除VPC
        ///
        /// 删除VPC
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest deleteVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", deleteVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVpcResponse>(response);
        }

        public AsyncInvoker<DeleteVpcResponse> DeleteVpcAsyncInvoker(DeleteVpcRequest deleteVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", deleteVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRequest);
            return new AsyncInvoker<DeleteVpcResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVpcResponse>);
        }
        
        /// <summary>
        /// 查询VPC列表
        ///
        /// 查询vpc列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVpcsResponse> ListVpcsAsync(ListVpcsRequest listVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListVpcsResponse>(response);
        }

        public AsyncInvoker<ListVpcsResponse> ListVpcsAsyncInvoker(ListVpcsRequest listVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcsRequest);
            return new AsyncInvoker<ListVpcsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVpcsResponse>);
        }
        
        /// <summary>
        /// 移除VPC扩展网段
        ///
        /// 移除VPC扩展网段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveVpcExtendCidrResponse> RemoveVpcExtendCidrAsync(RemoveVpcExtendCidrRequest removeVpcExtendCidrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", removeVpcExtendCidrRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}/remove-extend-cidr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeVpcExtendCidrRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<RemoveVpcExtendCidrResponse>(response);
        }

        public AsyncInvoker<RemoveVpcExtendCidrResponse> RemoveVpcExtendCidrAsyncInvoker(RemoveVpcExtendCidrRequest removeVpcExtendCidrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", removeVpcExtendCidrRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}/remove-extend-cidr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeVpcExtendCidrRequest);
            return new AsyncInvoker<RemoveVpcExtendCidrResponse>(this, "PUT", request, JsonUtils.DeSerialize<RemoveVpcExtendCidrResponse>);
        }
        
        /// <summary>
        /// 查询VPC详情
        ///
        /// 查询vpc详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVpcResponse> ShowVpcAsync(ShowVpcRequest showVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", showVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVpcResponse>(response);
        }

        public AsyncInvoker<ShowVpcResponse> ShowVpcAsyncInvoker(ShowVpcRequest showVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", showVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRequest);
            return new AsyncInvoker<ShowVpcResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVpcResponse>);
        }
        
        /// <summary>
        /// 更新VPC
        ///
        /// 更新vpc
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateVpcResponse> UpdateVpcAsync(UpdateVpcRequest updateVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", updateVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVpcRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVpcResponse>(response);
        }

        public AsyncInvoker<UpdateVpcResponse> UpdateVpcAsyncInvoker(UpdateVpcRequest updateVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", updateVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVpcRequest);
            return new AsyncInvoker<UpdateVpcResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVpcResponse>);
        }
        
    }
}