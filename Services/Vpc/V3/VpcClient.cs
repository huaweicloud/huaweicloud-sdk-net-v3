using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Vpc.V3.Model;

namespace HuaweiCloud.SDK.Vpc.V3
{
    public partial class VpcClient : Client
    {
        public static ClientBuilder<VpcClient> NewBuilder()
        {
            return new ClientBuilder<VpcClient>();
        }

        
        /// <summary>
        /// 端口插入安全组
        ///
        /// 端口插入安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddSecurityGroupsResponse AddSecurityGroups(AddSecurityGroupsRequest addSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", addSecurityGroupsRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/ports/{port_id}/insert-security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSecurityGroupsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<AddSecurityGroupsResponse>(response);
        }

        public SyncInvoker<AddSecurityGroupsResponse> AddSecurityGroupsInvoker(AddSecurityGroupsRequest addSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", addSecurityGroupsRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/ports/{port_id}/insert-security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSecurityGroupsRequest);
            return new SyncInvoker<AddSecurityGroupsResponse>(this, "PUT", request, JsonUtils.DeSerialize<AddSecurityGroupsResponse>);
        }
        
        /// <summary>
        /// 流量镜像会话添加镜像源
        ///
        /// 流量镜像会话添加镜像源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddSourcesToTrafficMirrorSessionResponse AddSourcesToTrafficMirrorSession(AddSourcesToTrafficMirrorSessionRequest addSourcesToTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", addSourcesToTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}/add-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSourcesToTrafficMirrorSessionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<AddSourcesToTrafficMirrorSessionResponse>(response);
        }

        public SyncInvoker<AddSourcesToTrafficMirrorSessionResponse> AddSourcesToTrafficMirrorSessionInvoker(AddSourcesToTrafficMirrorSessionRequest addSourcesToTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", addSourcesToTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}/add-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSourcesToTrafficMirrorSessionRequest);
            return new SyncInvoker<AddSourcesToTrafficMirrorSessionResponse>(this, "PUT", request, JsonUtils.DeSerialize<AddSourcesToTrafficMirrorSessionResponse>);
        }
        
        /// <summary>
        /// 批量创建安全组规则
        ///
        /// 在特定安全组下批量创建安全组规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateSecurityGroupRulesResponse BatchCreateSecurityGroupRules(BatchCreateSecurityGroupRulesRequest batchCreateSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", batchCreateSecurityGroupRulesRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}/security-group-rules/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateSecurityGroupRulesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateSecurityGroupRulesResponse>(response);
        }

        public SyncInvoker<BatchCreateSecurityGroupRulesResponse> BatchCreateSecurityGroupRulesInvoker(BatchCreateSecurityGroupRulesRequest batchCreateSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", batchCreateSecurityGroupRulesRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}/security-group-rules/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateSecurityGroupRulesRequest);
            return new SyncInvoker<BatchCreateSecurityGroupRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateSecurityGroupRulesResponse>);
        }
        
        /// <summary>
        /// 批量创建辅助弹性网卡
        ///
        /// 批量创建辅助弹性网卡
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateSubNetworkInterfaceResponse BatchCreateSubNetworkInterface(BatchCreateSubNetworkInterfaceRequest batchCreateSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateSubNetworkInterfaceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateSubNetworkInterfaceResponse>(response);
        }

        public SyncInvoker<BatchCreateSubNetworkInterfaceResponse> BatchCreateSubNetworkInterfaceInvoker(BatchCreateSubNetworkInterfaceRequest batchCreateSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateSubNetworkInterfaceRequest);
            return new SyncInvoker<BatchCreateSubNetworkInterfaceResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateSubNetworkInterfaceResponse>);
        }
        
        /// <summary>
        /// 创建安全组
        ///
        /// 创建安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest createSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSecurityGroupResponse>(response);
        }

        public SyncInvoker<CreateSecurityGroupResponse> CreateSecurityGroupInvoker(CreateSecurityGroupRequest createSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityGroupRequest);
            return new SyncInvoker<CreateSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 创建安全组规则
        ///
        /// 创建安全组规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSecurityGroupRuleResponse CreateSecurityGroupRule(CreateSecurityGroupRuleRequest createSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityGroupRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSecurityGroupRuleResponse>(response);
        }

        public SyncInvoker<CreateSecurityGroupRuleResponse> CreateSecurityGroupRuleInvoker(CreateSecurityGroupRuleRequest createSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityGroupRuleRequest);
            return new SyncInvoker<CreateSecurityGroupRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 创建辅助弹性网卡
        ///
        /// 创建辅助弹性网卡
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSubNetworkInterfaceResponse CreateSubNetworkInterface(CreateSubNetworkInterfaceRequest createSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubNetworkInterfaceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSubNetworkInterfaceResponse>(response);
        }

        public SyncInvoker<CreateSubNetworkInterfaceResponse> CreateSubNetworkInterfaceInvoker(CreateSubNetworkInterfaceRequest createSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubNetworkInterfaceRequest);
            return new SyncInvoker<CreateSubNetworkInterfaceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSubNetworkInterfaceResponse>);
        }
        
        /// <summary>
        /// 创建流量镜像筛选条件
        ///
        /// 创建流量镜像筛选条件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTrafficMirrorFilterResponse CreateTrafficMirrorFilter(CreateTrafficMirrorFilterRequest createTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorFilterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTrafficMirrorFilterResponse>(response);
        }

        public SyncInvoker<CreateTrafficMirrorFilterResponse> CreateTrafficMirrorFilterInvoker(CreateTrafficMirrorFilterRequest createTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorFilterRequest);
            return new SyncInvoker<CreateTrafficMirrorFilterResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrafficMirrorFilterResponse>);
        }
        
        /// <summary>
        /// 创建流量镜像筛选规则
        ///
        /// 创建流量镜像筛选规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTrafficMirrorFilterRuleResponse CreateTrafficMirrorFilterRule(CreateTrafficMirrorFilterRuleRequest createTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorFilterRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTrafficMirrorFilterRuleResponse>(response);
        }

        public SyncInvoker<CreateTrafficMirrorFilterRuleResponse> CreateTrafficMirrorFilterRuleInvoker(CreateTrafficMirrorFilterRuleRequest createTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorFilterRuleRequest);
            return new SyncInvoker<CreateTrafficMirrorFilterRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrafficMirrorFilterRuleResponse>);
        }
        
        /// <summary>
        /// 创建流量镜像会话
        ///
        /// 创建流量镜像会话
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTrafficMirrorSessionResponse CreateTrafficMirrorSession(CreateTrafficMirrorSessionRequest createTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorSessionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTrafficMirrorSessionResponse>(response);
        }

        public SyncInvoker<CreateTrafficMirrorSessionResponse> CreateTrafficMirrorSessionInvoker(CreateTrafficMirrorSessionRequest createTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorSessionRequest);
            return new SyncInvoker<CreateTrafficMirrorSessionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrafficMirrorSessionResponse>);
        }
        
        /// <summary>
        /// 删除安全组
        ///
        /// 删除安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest deleteSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", deleteSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupResponse>(response);
        }

        public SyncInvoker<DeleteSecurityGroupResponse> DeleteSecurityGroupInvoker(DeleteSecurityGroupRequest deleteSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", deleteSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRequest);
            return new SyncInvoker<DeleteSecurityGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 删除安全组规则
        ///
        /// 删除安全组规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSecurityGroupRuleResponse DeleteSecurityGroupRule(DeleteSecurityGroupRuleRequest deleteSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", deleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupRuleResponse>(response);
        }

        public SyncInvoker<DeleteSecurityGroupRuleResponse> DeleteSecurityGroupRuleInvoker(DeleteSecurityGroupRuleRequest deleteSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", deleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRuleRequest);
            return new SyncInvoker<DeleteSecurityGroupRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 删除辅助弹性网卡
        ///
        /// 删除辅助弹性网卡
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSubNetworkInterfaceResponse DeleteSubNetworkInterface(DeleteSubNetworkInterfaceRequest deleteSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id", deleteSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubNetworkInterfaceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSubNetworkInterfaceResponse>(response);
        }

        public SyncInvoker<DeleteSubNetworkInterfaceResponse> DeleteSubNetworkInterfaceInvoker(DeleteSubNetworkInterfaceRequest deleteSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id", deleteSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubNetworkInterfaceRequest);
            return new SyncInvoker<DeleteSubNetworkInterfaceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSubNetworkInterfaceResponse>);
        }
        
        /// <summary>
        /// 删除流量镜像筛选条件
        ///
        /// 删除流量镜像筛选条件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTrafficMirrorFilterResponse DeleteTrafficMirrorFilter(DeleteTrafficMirrorFilterRequest deleteTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id", deleteTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorFilterRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTrafficMirrorFilterResponse>(response);
        }

        public SyncInvoker<DeleteTrafficMirrorFilterResponse> DeleteTrafficMirrorFilterInvoker(DeleteTrafficMirrorFilterRequest deleteTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id", deleteTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorFilterRequest);
            return new SyncInvoker<DeleteTrafficMirrorFilterResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTrafficMirrorFilterResponse>);
        }
        
        /// <summary>
        /// 删除流量镜像筛选规则
        ///
        /// 删除流量镜像筛选规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTrafficMirrorFilterRuleResponse DeleteTrafficMirrorFilterRule(DeleteTrafficMirrorFilterRuleRequest deleteTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id", deleteTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorFilterRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTrafficMirrorFilterRuleResponse>(response);
        }

        public SyncInvoker<DeleteTrafficMirrorFilterRuleResponse> DeleteTrafficMirrorFilterRuleInvoker(DeleteTrafficMirrorFilterRuleRequest deleteTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id", deleteTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorFilterRuleRequest);
            return new SyncInvoker<DeleteTrafficMirrorFilterRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTrafficMirrorFilterRuleResponse>);
        }
        
        /// <summary>
        /// 删除流量镜像会话
        ///
        /// 删除流量镜像会话
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTrafficMirrorSessionResponse DeleteTrafficMirrorSession(DeleteTrafficMirrorSessionRequest deleteTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", deleteTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorSessionRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTrafficMirrorSessionResponse>(response);
        }

        public SyncInvoker<DeleteTrafficMirrorSessionResponse> DeleteTrafficMirrorSessionInvoker(DeleteTrafficMirrorSessionRequest deleteTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", deleteTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorSessionRequest);
            return new SyncInvoker<DeleteTrafficMirrorSessionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTrafficMirrorSessionResponse>);
        }
        
        /// <summary>
        /// 查询安全组规则列表
        ///
        /// 查询安全组规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSecurityGroupRulesResponse ListSecurityGroupRules(ListSecurityGroupRulesRequest listSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSecurityGroupRulesResponse>(response);
        }

        public SyncInvoker<ListSecurityGroupRulesResponse> ListSecurityGroupRulesInvoker(ListSecurityGroupRulesRequest listSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupRulesRequest);
            return new SyncInvoker<ListSecurityGroupRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecurityGroupRulesResponse>);
        }
        
        /// <summary>
        /// 查询安全组列表
        ///
        /// 查询某租户下的安全组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSecurityGroupsResponse ListSecurityGroups(ListSecurityGroupsRequest listSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSecurityGroupsResponse>(response);
        }

        public SyncInvoker<ListSecurityGroupsResponse> ListSecurityGroupsInvoker(ListSecurityGroupsRequest listSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupsRequest);
            return new SyncInvoker<ListSecurityGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecurityGroupsResponse>);
        }
        
        /// <summary>
        /// 查询租户下辅助弹性网卡列表
        ///
        /// 查询辅助弹性网卡列表，单次查询最多返回2000条数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubNetworkInterfacesResponse ListSubNetworkInterfaces(ListSubNetworkInterfacesRequest listSubNetworkInterfacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubNetworkInterfacesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSubNetworkInterfacesResponse>(response);
        }

        public SyncInvoker<ListSubNetworkInterfacesResponse> ListSubNetworkInterfacesInvoker(ListSubNetworkInterfacesRequest listSubNetworkInterfacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubNetworkInterfacesRequest);
            return new SyncInvoker<ListSubNetworkInterfacesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubNetworkInterfacesResponse>);
        }
        
        /// <summary>
        /// 查询流量镜像筛选规则列表
        ///
        /// 查询流量镜像筛选规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTrafficMirrorFilterRulesResponse ListTrafficMirrorFilterRules(ListTrafficMirrorFilterRulesRequest listTrafficMirrorFilterRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorFilterRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTrafficMirrorFilterRulesResponse>(response);
        }

        public SyncInvoker<ListTrafficMirrorFilterRulesResponse> ListTrafficMirrorFilterRulesInvoker(ListTrafficMirrorFilterRulesRequest listTrafficMirrorFilterRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorFilterRulesRequest);
            return new SyncInvoker<ListTrafficMirrorFilterRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrafficMirrorFilterRulesResponse>);
        }
        
        /// <summary>
        /// 查询流量镜像筛选条件列表
        ///
        /// 查询流量镜像筛选条件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTrafficMirrorFiltersResponse ListTrafficMirrorFilters(ListTrafficMirrorFiltersRequest listTrafficMirrorFiltersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorFiltersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTrafficMirrorFiltersResponse>(response);
        }

        public SyncInvoker<ListTrafficMirrorFiltersResponse> ListTrafficMirrorFiltersInvoker(ListTrafficMirrorFiltersRequest listTrafficMirrorFiltersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorFiltersRequest);
            return new SyncInvoker<ListTrafficMirrorFiltersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrafficMirrorFiltersResponse>);
        }
        
        /// <summary>
        /// 查询流量镜像会话列表
        ///
        /// 查询流量镜像会话列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTrafficMirrorSessionsResponse ListTrafficMirrorSessions(ListTrafficMirrorSessionsRequest listTrafficMirrorSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorSessionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTrafficMirrorSessionsResponse>(response);
        }

        public SyncInvoker<ListTrafficMirrorSessionsResponse> ListTrafficMirrorSessionsInvoker(ListTrafficMirrorSessionsRequest listTrafficMirrorSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorSessionsRequest);
            return new SyncInvoker<ListTrafficMirrorSessionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrafficMirrorSessionsResponse>);
        }
        
        /// <summary>
        /// 迁移辅助弹性网卡
        ///
        /// 批量迁移辅助弹性网卡
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MigrateSubNetworkInterfaceResponse MigrateSubNetworkInterface(MigrateSubNetworkInterfaceRequest migrateSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateSubNetworkInterfaceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<MigrateSubNetworkInterfaceResponse>(response);
        }

        public SyncInvoker<MigrateSubNetworkInterfaceResponse> MigrateSubNetworkInterfaceInvoker(MigrateSubNetworkInterfaceRequest migrateSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateSubNetworkInterfaceRequest);
            return new SyncInvoker<MigrateSubNetworkInterfaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<MigrateSubNetworkInterfaceResponse>);
        }
        
        /// <summary>
        /// 端口移除安全组
        ///
        /// 端口移除安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveSecurityGroupsResponse RemoveSecurityGroups(RemoveSecurityGroupsRequest removeSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", removeSecurityGroupsRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/ports/{port_id}/remove-security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeSecurityGroupsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<RemoveSecurityGroupsResponse>(response);
        }

        public SyncInvoker<RemoveSecurityGroupsResponse> RemoveSecurityGroupsInvoker(RemoveSecurityGroupsRequest removeSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", removeSecurityGroupsRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/ports/{port_id}/remove-security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeSecurityGroupsRequest);
            return new SyncInvoker<RemoveSecurityGroupsResponse>(this, "PUT", request, JsonUtils.DeSerialize<RemoveSecurityGroupsResponse>);
        }
        
        /// <summary>
        /// 流量镜像会话移除镜像源
        ///
        /// 流量镜像会话移除镜像源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveSourcesFromTrafficMirrorSessionResponse RemoveSourcesFromTrafficMirrorSession(RemoveSourcesFromTrafficMirrorSessionRequest removeSourcesFromTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", removeSourcesFromTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}/remove-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeSourcesFromTrafficMirrorSessionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<RemoveSourcesFromTrafficMirrorSessionResponse>(response);
        }

        public SyncInvoker<RemoveSourcesFromTrafficMirrorSessionResponse> RemoveSourcesFromTrafficMirrorSessionInvoker(RemoveSourcesFromTrafficMirrorSessionRequest removeSourcesFromTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", removeSourcesFromTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}/remove-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeSourcesFromTrafficMirrorSessionRequest);
            return new SyncInvoker<RemoveSourcesFromTrafficMirrorSessionResponse>(this, "PUT", request, JsonUtils.DeSerialize<RemoveSourcesFromTrafficMirrorSessionResponse>);
        }
        
        /// <summary>
        /// 查询安全组
        ///
        /// 查询单个安全组详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecurityGroupResponse ShowSecurityGroup(ShowSecurityGroupRequest showSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", showSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecurityGroupResponse>(response);
        }

        public SyncInvoker<ShowSecurityGroupResponse> ShowSecurityGroupInvoker(ShowSecurityGroupRequest showSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", showSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRequest);
            return new SyncInvoker<ShowSecurityGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 查询安全组规则
        ///
        /// 查询单个安全组规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecurityGroupRuleResponse ShowSecurityGroupRule(ShowSecurityGroupRuleRequest showSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", showSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecurityGroupRuleResponse>(response);
        }

        public SyncInvoker<ShowSecurityGroupRuleResponse> ShowSecurityGroupRuleInvoker(ShowSecurityGroupRuleRequest showSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", showSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRuleRequest);
            return new SyncInvoker<ShowSecurityGroupRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 查询租户下辅助弹性网卡
        ///
        /// 查询辅助弹性网卡详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSubNetworkInterfaceResponse ShowSubNetworkInterface(ShowSubNetworkInterfaceRequest showSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id", showSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubNetworkInterfaceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSubNetworkInterfaceResponse>(response);
        }

        public SyncInvoker<ShowSubNetworkInterfaceResponse> ShowSubNetworkInterfaceInvoker(ShowSubNetworkInterfaceRequest showSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id", showSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubNetworkInterfaceRequest);
            return new SyncInvoker<ShowSubNetworkInterfaceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubNetworkInterfaceResponse>);
        }
        
        /// <summary>
        /// 查询租户下辅助弹性网卡数目
        ///
        /// 查询辅助弹性网卡数目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSubNetworkInterfacesQuantityResponse ShowSubNetworkInterfacesQuantity(ShowSubNetworkInterfacesQuantityRequest showSubNetworkInterfacesQuantityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubNetworkInterfacesQuantityRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSubNetworkInterfacesQuantityResponse>(response);
        }

        public SyncInvoker<ShowSubNetworkInterfacesQuantityResponse> ShowSubNetworkInterfacesQuantityInvoker(ShowSubNetworkInterfacesQuantityRequest showSubNetworkInterfacesQuantityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubNetworkInterfacesQuantityRequest);
            return new SyncInvoker<ShowSubNetworkInterfacesQuantityResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubNetworkInterfacesQuantityResponse>);
        }
        
        /// <summary>
        /// 查询流量镜像筛选条件详情
        ///
        /// 查询流量镜像筛选条件详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTrafficMirrorFilterResponse ShowTrafficMirrorFilter(ShowTrafficMirrorFilterRequest showTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id", showTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorFilterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTrafficMirrorFilterResponse>(response);
        }

        public SyncInvoker<ShowTrafficMirrorFilterResponse> ShowTrafficMirrorFilterInvoker(ShowTrafficMirrorFilterRequest showTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id", showTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorFilterRequest);
            return new SyncInvoker<ShowTrafficMirrorFilterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrafficMirrorFilterResponse>);
        }
        
        /// <summary>
        /// 查询流量镜像筛选规则详情
        ///
        /// 查询流量镜像筛选规则详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTrafficMirrorFilterRuleResponse ShowTrafficMirrorFilterRule(ShowTrafficMirrorFilterRuleRequest showTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id", showTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorFilterRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTrafficMirrorFilterRuleResponse>(response);
        }

        public SyncInvoker<ShowTrafficMirrorFilterRuleResponse> ShowTrafficMirrorFilterRuleInvoker(ShowTrafficMirrorFilterRuleRequest showTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id", showTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorFilterRuleRequest);
            return new SyncInvoker<ShowTrafficMirrorFilterRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrafficMirrorFilterRuleResponse>);
        }
        
        /// <summary>
        /// 查询流量镜像会话详情
        ///
        /// 查询流量镜像会话详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTrafficMirrorSessionResponse ShowTrafficMirrorSession(ShowTrafficMirrorSessionRequest showTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", showTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorSessionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTrafficMirrorSessionResponse>(response);
        }

        public SyncInvoker<ShowTrafficMirrorSessionResponse> ShowTrafficMirrorSessionInvoker(ShowTrafficMirrorSessionRequest showTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", showTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorSessionRequest);
            return new SyncInvoker<ShowTrafficMirrorSessionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrafficMirrorSessionResponse>);
        }
        
        /// <summary>
        /// 更新安全组
        ///
        /// 更新安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSecurityGroupResponse UpdateSecurityGroup(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", updateSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSecurityGroupResponse>(response);
        }

        public SyncInvoker<UpdateSecurityGroupResponse> UpdateSecurityGroupInvoker(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", updateSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            return new SyncInvoker<UpdateSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 更新辅助弹性网卡
        ///
        /// 更新辅助弹性网卡
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSubNetworkInterfaceResponse UpdateSubNetworkInterface(UpdateSubNetworkInterfaceRequest updateSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id", updateSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubNetworkInterfaceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSubNetworkInterfaceResponse>(response);
        }

        public SyncInvoker<UpdateSubNetworkInterfaceResponse> UpdateSubNetworkInterfaceInvoker(UpdateSubNetworkInterfaceRequest updateSubNetworkInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id", updateSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubNetworkInterfaceRequest);
            return new SyncInvoker<UpdateSubNetworkInterfaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSubNetworkInterfaceResponse>);
        }
        
        /// <summary>
        /// 更新流量镜像筛选条件
        ///
        /// 更新流量镜像筛选条件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTrafficMirrorFilterResponse UpdateTrafficMirrorFilter(UpdateTrafficMirrorFilterRequest updateTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id", updateTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorFilterRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTrafficMirrorFilterResponse>(response);
        }

        public SyncInvoker<UpdateTrafficMirrorFilterResponse> UpdateTrafficMirrorFilterInvoker(UpdateTrafficMirrorFilterRequest updateTrafficMirrorFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id", updateTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorFilterRequest);
            return new SyncInvoker<UpdateTrafficMirrorFilterResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTrafficMirrorFilterResponse>);
        }
        
        /// <summary>
        /// 更新流量镜像筛选规则
        ///
        /// 更新流量镜像筛选规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTrafficMirrorFilterRuleResponse UpdateTrafficMirrorFilterRule(UpdateTrafficMirrorFilterRuleRequest updateTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id", updateTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorFilterRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTrafficMirrorFilterRuleResponse>(response);
        }

        public SyncInvoker<UpdateTrafficMirrorFilterRuleResponse> UpdateTrafficMirrorFilterRuleInvoker(UpdateTrafficMirrorFilterRuleRequest updateTrafficMirrorFilterRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id", updateTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorFilterRuleRequest);
            return new SyncInvoker<UpdateTrafficMirrorFilterRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTrafficMirrorFilterRuleResponse>);
        }
        
        /// <summary>
        /// 更新流量镜像会话
        ///
        /// 更新流量镜像会话
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTrafficMirrorSessionResponse UpdateTrafficMirrorSession(UpdateTrafficMirrorSessionRequest updateTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", updateTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorSessionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTrafficMirrorSessionResponse>(response);
        }

        public SyncInvoker<UpdateTrafficMirrorSessionResponse> UpdateTrafficMirrorSessionInvoker(UpdateTrafficMirrorSessionRequest updateTrafficMirrorSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id", updateTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorSessionRequest);
            return new SyncInvoker<UpdateTrafficMirrorSessionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTrafficMirrorSessionResponse>);
        }
        
        /// <summary>
        /// 网络ACL插入规则
        ///
        /// 网络ACL插入规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddFirewallRulesResponse AddFirewallRules(AddFirewallRulesRequest addFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", addFirewallRulesRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/insert-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFirewallRulesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<AddFirewallRulesResponse>(response);
        }

        public SyncInvoker<AddFirewallRulesResponse> AddFirewallRulesInvoker(AddFirewallRulesRequest addFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", addFirewallRulesRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/insert-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFirewallRulesRequest);
            return new SyncInvoker<AddFirewallRulesResponse>(this, "PUT", request, JsonUtils.DeSerialize<AddFirewallRulesResponse>);
        }
        
        /// <summary>
        /// 网络ACL绑定子网
        ///
        /// 网络ACL绑定子网
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateSubnetFirewallResponse AssociateSubnetFirewall(AssociateSubnetFirewallRequest associateSubnetFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", associateSubnetFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/associate-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateSubnetFirewallRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<AssociateSubnetFirewallResponse>(response);
        }

        public SyncInvoker<AssociateSubnetFirewallResponse> AssociateSubnetFirewallInvoker(AssociateSubnetFirewallRequest associateSubnetFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", associateSubnetFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/associate-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateSubnetFirewallRequest);
            return new SyncInvoker<AssociateSubnetFirewallResponse>(this, "PUT", request, JsonUtils.DeSerialize<AssociateSubnetFirewallResponse>);
        }
        
        /// <summary>
        /// 批量添加ACL资源标签
        ///
        /// 为指定的IP地址组资源实例批量添加标签。
        /// 此接口为幂等接口：创建时如果请求体中存在重复key则报错。创建时，不允许设置重复key数据，如果数据库已存在该key，就覆盖value的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateFirewallTagsResponse BatchCreateFirewallTags(BatchCreateFirewallTagsRequest batchCreateFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", batchCreateFirewallTagsRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateFirewallTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateFirewallTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateFirewallTagsResponse> BatchCreateFirewallTagsInvoker(BatchCreateFirewallTagsRequest batchCreateFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", batchCreateFirewallTagsRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateFirewallTagsRequest);
            return new SyncInvoker<BatchCreateFirewallTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateFirewallTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除ACL资源标签
        ///
        /// 为指定的IP地址组资源实例批量删除标签。
        /// 此接口为幂等接口：删除时，如果删除的标签不存在，默认处理成功；删除时不对标签字符集范围做校验。删除时tags结构体不能缺失，key不能为空，或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteFirewallTagsResponse BatchDeleteFirewallTags(BatchDeleteFirewallTagsRequest batchDeleteFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", batchDeleteFirewallTagsRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFirewallTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteFirewallTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteFirewallTagsResponse> BatchDeleteFirewallTagsInvoker(BatchDeleteFirewallTagsRequest batchDeleteFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", batchDeleteFirewallTagsRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFirewallTagsRequest);
            return new SyncInvoker<BatchDeleteFirewallTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteFirewallTagsResponse>);
        }
        
        /// <summary>
        /// 查询ACL资源实例数量
        ///
        /// 使用标签过滤查询ACL实例数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountFirewallsByTagsResponse CountFirewallsByTags(CountFirewallsByTagsRequest countFirewallsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countFirewallsByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountFirewallsByTagsResponse>(response);
        }

        public SyncInvoker<CountFirewallsByTagsResponse> CountFirewallsByTagsInvoker(CountFirewallsByTagsRequest countFirewallsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countFirewallsByTagsRequest);
            return new SyncInvoker<CountFirewallsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountFirewallsByTagsResponse>);
        }
        
        /// <summary>
        /// 创建网络ACL
        ///
        /// 创建网络ACL
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFirewallResponse CreateFirewall(CreateFirewallRequest createFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFirewallResponse>(response);
        }

        public SyncInvoker<CreateFirewallResponse> CreateFirewallInvoker(CreateFirewallRequest createFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallRequest);
            return new SyncInvoker<CreateFirewallResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFirewallResponse>);
        }
        
        /// <summary>
        /// 添加ACL资源标签
        ///
        /// 给指定IP地址组资源实例增加标签信息
        /// 此接口为幂等接口：创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFirewallTagResponse CreateFirewallTag(CreateFirewallTagRequest createFirewallTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", createFirewallTagRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateFirewallTagResponse>(response);
        }

        public SyncInvoker<CreateFirewallTagResponse> CreateFirewallTagInvoker(CreateFirewallTagRequest createFirewallTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", createFirewallTagRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallTagRequest);
            return new SyncInvoker<CreateFirewallTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateFirewallTagResponse>);
        }
        
        /// <summary>
        /// 删除网络ACL
        ///
        /// 删除网络ACL
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteFirewallResponse DeleteFirewall(DeleteFirewallRequest deleteFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", deleteFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteFirewallResponse>(response);
        }

        public SyncInvoker<DeleteFirewallResponse> DeleteFirewallInvoker(DeleteFirewallRequest deleteFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", deleteFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallRequest);
            return new SyncInvoker<DeleteFirewallResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFirewallResponse>);
        }
        
        /// <summary>
        /// 删除ACL资源标签
        ///
        /// 删除指定IP地址组资源实例的标签信息
        /// 该接口为幂等接口：删除的key不存在报404，key不能为空或者空字符串
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteFirewallTagResponse DeleteFirewallTag(DeleteFirewallTagRequest deleteFirewallTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", deleteFirewallTagRequest.FirewallId.ToString());
            urlParam.Add("tag_key", deleteFirewallTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteFirewallTagResponse>(response);
        }

        public SyncInvoker<DeleteFirewallTagResponse> DeleteFirewallTagInvoker(DeleteFirewallTagRequest deleteFirewallTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", deleteFirewallTagRequest.FirewallId.ToString());
            urlParam.Add("tag_key", deleteFirewallTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallTagRequest);
            return new SyncInvoker<DeleteFirewallTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFirewallTagResponse>);
        }
        
        /// <summary>
        /// 网络ACL解绑子网
        ///
        /// 网络ACL解绑子网
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateSubnetFirewallResponse DisassociateSubnetFirewall(DisassociateSubnetFirewallRequest disassociateSubnetFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", disassociateSubnetFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/disassociate-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateSubnetFirewallRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<DisassociateSubnetFirewallResponse>(response);
        }

        public SyncInvoker<DisassociateSubnetFirewallResponse> DisassociateSubnetFirewallInvoker(DisassociateSubnetFirewallRequest disassociateSubnetFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", disassociateSubnetFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/disassociate-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateSubnetFirewallRequest);
            return new SyncInvoker<DisassociateSubnetFirewallResponse>(this, "PUT", request, JsonUtils.DeSerialize<DisassociateSubnetFirewallResponse>);
        }
        
        /// <summary>
        /// 查询网络ACL列表
        ///
        /// 查询网络ACL列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFirewallResponse ListFirewall(ListFirewallRequest listFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFirewallResponse>(response);
        }

        public SyncInvoker<ListFirewallResponse> ListFirewallInvoker(ListFirewallRequest listFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallRequest);
            return new SyncInvoker<ListFirewallResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFirewallResponse>);
        }
        
        /// <summary>
        /// 查询ACL项目标签
        ///
        /// 查询租户在指定Project中实例类型的所有资源标签集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFirewallTagsResponse ListFirewallTags(ListFirewallTagsRequest listFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFirewallTagsResponse>(response);
        }

        public SyncInvoker<ListFirewallTagsResponse> ListFirewallTagsInvoker(ListFirewallTagsRequest listFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallTagsRequest);
            return new SyncInvoker<ListFirewallTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFirewallTagsResponse>);
        }
        
        /// <summary>
        /// 查询ACL资源实例列表
        ///
        /// 使用标签过滤查询ACL实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFirewallsByTagsResponse ListFirewallsByTags(ListFirewallsByTagsRequest listFirewallsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallsByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListFirewallsByTagsResponse>(response);
        }

        public SyncInvoker<ListFirewallsByTagsResponse> ListFirewallsByTagsInvoker(ListFirewallsByTagsRequest listFirewallsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallsByTagsRequest);
            return new SyncInvoker<ListFirewallsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListFirewallsByTagsResponse>);
        }
        
        /// <summary>
        /// 网络ACL移除规则
        ///
        /// 网络ACL移除规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveFirewallRulesResponse RemoveFirewallRules(RemoveFirewallRulesRequest removeFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", removeFirewallRulesRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/remove-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeFirewallRulesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<RemoveFirewallRulesResponse>(response);
        }

        public SyncInvoker<RemoveFirewallRulesResponse> RemoveFirewallRulesInvoker(RemoveFirewallRulesRequest removeFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", removeFirewallRulesRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/remove-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeFirewallRulesRequest);
            return new SyncInvoker<RemoveFirewallRulesResponse>(this, "PUT", request, JsonUtils.DeSerialize<RemoveFirewallRulesResponse>);
        }
        
        /// <summary>
        /// 查询网络ACL详情
        ///
        /// 查询网络ACL详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFirewallResponse ShowFirewall(ShowFirewallRequest showFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", showFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFirewallRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFirewallResponse>(response);
        }

        public SyncInvoker<ShowFirewallResponse> ShowFirewallInvoker(ShowFirewallRequest showFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", showFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFirewallRequest);
            return new SyncInvoker<ShowFirewallResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFirewallResponse>);
        }
        
        /// <summary>
        /// 查询ACL资源标签
        ///
        /// 查询指定ACL实例的标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFirewallTagsResponse ShowFirewallTags(ShowFirewallTagsRequest showFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", showFirewallTagsRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFirewallTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFirewallTagsResponse>(response);
        }

        public SyncInvoker<ShowFirewallTagsResponse> ShowFirewallTagsInvoker(ShowFirewallTagsRequest showFirewallTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", showFirewallTagsRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/firewalls/{firewall_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFirewallTagsRequest);
            return new SyncInvoker<ShowFirewallTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFirewallTagsResponse>);
        }
        
        /// <summary>
        /// 更新网络ACL
        ///
        /// 更新网络ACL
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFirewallResponse UpdateFirewall(UpdateFirewallRequest updateFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", updateFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFirewallRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFirewallResponse>(response);
        }

        public SyncInvoker<UpdateFirewallResponse> UpdateFirewallInvoker(UpdateFirewallRequest updateFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", updateFirewallRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFirewallRequest);
            return new SyncInvoker<UpdateFirewallResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFirewallResponse>);
        }
        
        /// <summary>
        /// 网络ACL更新规则
        ///
        /// 网络ACL更新规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFirewallRulesResponse UpdateFirewallRules(UpdateFirewallRulesRequest updateFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", updateFirewallRulesRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/update-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFirewallRulesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFirewallRulesResponse>(response);
        }

        public SyncInvoker<UpdateFirewallRulesResponse> UpdateFirewallRulesInvoker(UpdateFirewallRulesRequest updateFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id", updateFirewallRulesRequest.FirewallId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/update-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFirewallRulesRequest);
            return new SyncInvoker<UpdateFirewallRulesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFirewallRulesResponse>);
        }
        
        /// <summary>
        /// 添加Clouddcn子网标签
        ///
        /// 添加Clouddcn子网的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddClouddcnSubnetsTagsResponse AddClouddcnSubnetsTags(AddClouddcnSubnetsTagsRequest addClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addClouddcnSubnetsTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddClouddcnSubnetsTagsResponse>(response);
        }

        public SyncInvoker<AddClouddcnSubnetsTagsResponse> AddClouddcnSubnetsTagsInvoker(AddClouddcnSubnetsTagsRequest addClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addClouddcnSubnetsTagsRequest);
            return new SyncInvoker<AddClouddcnSubnetsTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddClouddcnSubnetsTagsResponse>);
        }
        
        /// <summary>
        /// 批量添加Clouddcn子网标签
        ///
        /// 批量添加Clouddcn子网的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateClouddcnSubnetsTagsResponse BatchCreateClouddcnSubnetsTags(BatchCreateClouddcnSubnetsTagsRequest batchCreateClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateClouddcnSubnetsTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateClouddcnSubnetsTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateClouddcnSubnetsTagsResponse> BatchCreateClouddcnSubnetsTagsInvoker(BatchCreateClouddcnSubnetsTagsRequest batchCreateClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateClouddcnSubnetsTagsRequest);
            return new SyncInvoker<BatchCreateClouddcnSubnetsTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateClouddcnSubnetsTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除Clouddcn子网标签
        ///
        /// 批量删除Clouddcn子网的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteClouddcnSubnetsTagsResponse BatchDeleteClouddcnSubnetsTags(BatchDeleteClouddcnSubnetsTagsRequest batchDeleteClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteClouddcnSubnetsTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteClouddcnSubnetsTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteClouddcnSubnetsTagsResponse> BatchDeleteClouddcnSubnetsTagsInvoker(BatchDeleteClouddcnSubnetsTagsRequest batchDeleteClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteClouddcnSubnetsTagsRequest);
            return new SyncInvoker<BatchDeleteClouddcnSubnetsTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteClouddcnSubnetsTagsResponse>);
        }
        
        /// <summary>
        /// 创建clouddcn子网
        ///
        /// 创建clouddcn子网。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateClouddcnSubnetResponse CreateClouddcnSubnet(CreateClouddcnSubnetRequest createClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClouddcnSubnetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateClouddcnSubnetResponse>(response);
        }

        public SyncInvoker<CreateClouddcnSubnetResponse> CreateClouddcnSubnetInvoker(CreateClouddcnSubnetRequest createClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClouddcnSubnetRequest);
            return new SyncInvoker<CreateClouddcnSubnetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateClouddcnSubnetResponse>);
        }
        
        /// <summary>
        /// 删除clouddcn子网
        ///
        /// 删除clouddcn子网
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteClouddcnSubnetResponse DeleteClouddcnSubnet(DeleteClouddcnSubnetRequest deleteClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("clouddcn_subnet_id", deleteClouddcnSubnetRequest.ClouddcnSubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets/{clouddcn_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClouddcnSubnetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteClouddcnSubnetResponse>(response);
        }

        public SyncInvoker<DeleteClouddcnSubnetResponse> DeleteClouddcnSubnetInvoker(DeleteClouddcnSubnetRequest deleteClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("clouddcn_subnet_id", deleteClouddcnSubnetRequest.ClouddcnSubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets/{clouddcn_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClouddcnSubnetRequest);
            return new SyncInvoker<DeleteClouddcnSubnetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteClouddcnSubnetResponse>);
        }
        
        /// <summary>
        /// 删除Clouddcn子网标签
        ///
        /// 删除Clouddcn子网的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteClouddcnSubnetsTagResponse DeleteClouddcnSubnetsTag(DeleteClouddcnSubnetsTagRequest deleteClouddcnSubnetsTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteClouddcnSubnetsTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteClouddcnSubnetsTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClouddcnSubnetsTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteClouddcnSubnetsTagResponse>(response);
        }

        public SyncInvoker<DeleteClouddcnSubnetsTagResponse> DeleteClouddcnSubnetsTagInvoker(DeleteClouddcnSubnetsTagRequest deleteClouddcnSubnetsTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteClouddcnSubnetsTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteClouddcnSubnetsTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClouddcnSubnetsTagRequest);
            return new SyncInvoker<DeleteClouddcnSubnetsTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteClouddcnSubnetsTagResponse>);
        }
        
        /// <summary>
        /// 查询clouddcn子网列表
        ///
        /// 查询clouddcn子网列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListClouddcnSubnetsResponse ListClouddcnSubnets(ListClouddcnSubnetsRequest listClouddcnSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListClouddcnSubnetsResponse>(response);
        }

        public SyncInvoker<ListClouddcnSubnetsResponse> ListClouddcnSubnetsInvoker(ListClouddcnSubnetsRequest listClouddcnSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsRequest);
            return new SyncInvoker<ListClouddcnSubnetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClouddcnSubnetsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表数目
        ///
        /// 查询资源实例列表数目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListClouddcnSubnetsCountFilterTagsResponse ListClouddcnSubnetsCountFilterTags(ListClouddcnSubnetsCountFilterTagsRequest listClouddcnSubnetsCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsCountFilterTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListClouddcnSubnetsCountFilterTagsResponse>(response);
        }

        public SyncInvoker<ListClouddcnSubnetsCountFilterTagsResponse> ListClouddcnSubnetsCountFilterTagsInvoker(ListClouddcnSubnetsCountFilterTagsRequest listClouddcnSubnetsCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsCountFilterTagsRequest);
            return new SyncInvoker<ListClouddcnSubnetsCountFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListClouddcnSubnetsCountFilterTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表
        ///
        /// 查询资源实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListClouddcnSubnetsFilterTagsResponse ListClouddcnSubnetsFilterTags(ListClouddcnSubnetsFilterTagsRequest listClouddcnSubnetsFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsFilterTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListClouddcnSubnetsFilterTagsResponse>(response);
        }

        public SyncInvoker<ListClouddcnSubnetsFilterTagsResponse> ListClouddcnSubnetsFilterTagsInvoker(ListClouddcnSubnetsFilterTagsRequest listClouddcnSubnetsFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsFilterTagsRequest);
            return new SyncInvoker<ListClouddcnSubnetsFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListClouddcnSubnetsFilterTagsResponse>);
        }
        
        /// <summary>
        /// 查询Clouddcn子网项目标签
        ///
        /// 查询Clouddcn子网的项目标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListClouddcnSubnetsTagsResponse ListClouddcnSubnetsTags(ListClouddcnSubnetsTagsRequest listClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListClouddcnSubnetsTagsResponse>(response);
        }

        public SyncInvoker<ListClouddcnSubnetsTagsResponse> ListClouddcnSubnetsTagsInvoker(ListClouddcnSubnetsTagsRequest listClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClouddcnSubnetsTagsRequest);
            return new SyncInvoker<ListClouddcnSubnetsTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClouddcnSubnetsTagsResponse>);
        }
        
        /// <summary>
        /// 查询clouddcn子网
        ///
        /// 查询clouddcn子网详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClouddcnSubnetResponse ShowClouddcnSubnet(ShowClouddcnSubnetRequest showClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("clouddcn_subnet_id", showClouddcnSubnetRequest.ClouddcnSubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets/{clouddcn_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClouddcnSubnetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClouddcnSubnetResponse>(response);
        }

        public SyncInvoker<ShowClouddcnSubnetResponse> ShowClouddcnSubnetInvoker(ShowClouddcnSubnetRequest showClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("clouddcn_subnet_id", showClouddcnSubnetRequest.ClouddcnSubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets/{clouddcn_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClouddcnSubnetRequest);
            return new SyncInvoker<ShowClouddcnSubnetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClouddcnSubnetResponse>);
        }
        
        /// <summary>
        /// 查询Clouddcn子网标签
        ///
        /// 查询Clouddcn子网的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClouddcnSubnetsTagsResponse ShowClouddcnSubnetsTags(ShowClouddcnSubnetsTagsRequest showClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClouddcnSubnetsTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClouddcnSubnetsTagsResponse>(response);
        }

        public SyncInvoker<ShowClouddcnSubnetsTagsResponse> ShowClouddcnSubnetsTagsInvoker(ShowClouddcnSubnetsTagsRequest showClouddcnSubnetsTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showClouddcnSubnetsTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/clouddcn-subnets/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClouddcnSubnetsTagsRequest);
            return new SyncInvoker<ShowClouddcnSubnetsTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClouddcnSubnetsTagsResponse>);
        }
        
        /// <summary>
        /// 更新clouddcn子网
        ///
        /// 更新clouddcn子网。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateClouddcnSubnetResponse UpdateClouddcnSubnet(UpdateClouddcnSubnetRequest updateClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("clouddcn_subnet_id", updateClouddcnSubnetRequest.ClouddcnSubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets/{clouddcn_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClouddcnSubnetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateClouddcnSubnetResponse>(response);
        }

        public SyncInvoker<UpdateClouddcnSubnetResponse> UpdateClouddcnSubnetInvoker(UpdateClouddcnSubnetRequest updateClouddcnSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("clouddcn_subnet_id", updateClouddcnSubnetRequest.ClouddcnSubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/clouddcn-subnets/{clouddcn_subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClouddcnSubnetRequest);
            return new SyncInvoker<UpdateClouddcnSubnetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateClouddcnSubnetResponse>);
        }
        
        /// <summary>
        /// 创建地址组
        ///
        /// 创建地址组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAddressGroupResponse CreateAddressGroup(CreateAddressGroupRequest createAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddressGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAddressGroupResponse>(response);
        }

        public SyncInvoker<CreateAddressGroupResponse> CreateAddressGroupInvoker(CreateAddressGroupRequest createAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddressGroupRequest);
            return new SyncInvoker<CreateAddressGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAddressGroupResponse>);
        }
        
        /// <summary>
        /// 删除地址组
        ///
        /// 删除地址组，非强制删除，删除前请确保未被其他资源引用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAddressGroupResponse DeleteAddressGroup(DeleteAddressGroupRequest deleteAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", deleteAddressGroupRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAddressGroupResponse>(response);
        }

        public SyncInvoker<DeleteAddressGroupResponse> DeleteAddressGroupInvoker(DeleteAddressGroupRequest deleteAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", deleteAddressGroupRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressGroupRequest);
            return new SyncInvoker<DeleteAddressGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAddressGroupResponse>);
        }
        
        /// <summary>
        /// 强制删除地址组
        ///
        /// 强制删除地址组，删除的地址组与安全组规则关联时，会删除地址组与关联的安全组规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteIpAddressGroupForceResponse DeleteIpAddressGroupForce(DeleteIpAddressGroupForceRequest deleteIpAddressGroupForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", deleteIpAddressGroupForceRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}/force", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpAddressGroupForceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteIpAddressGroupForceResponse>(response);
        }

        public SyncInvoker<DeleteIpAddressGroupForceResponse> DeleteIpAddressGroupForceInvoker(DeleteIpAddressGroupForceRequest deleteIpAddressGroupForceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", deleteIpAddressGroupForceRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}/force", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpAddressGroupForceRequest);
            return new SyncInvoker<DeleteIpAddressGroupForceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteIpAddressGroupForceResponse>);
        }
        
        /// <summary>
        /// 查询地址组列表
        ///
        /// 查询地址组列表，根据过滤条件进行过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAddressGroupResponse ListAddressGroup(ListAddressGroupRequest listAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAddressGroupResponse>(response);
        }

        public SyncInvoker<ListAddressGroupResponse> ListAddressGroupInvoker(ListAddressGroupRequest listAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressGroupRequest);
            return new SyncInvoker<ListAddressGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddressGroupResponse>);
        }
        
        /// <summary>
        /// 查询地址组
        ///
        /// 查询地址组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAddressGroupResponse ShowAddressGroup(ShowAddressGroupRequest showAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", showAddressGroupRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddressGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAddressGroupResponse>(response);
        }

        public SyncInvoker<ShowAddressGroupResponse> ShowAddressGroupInvoker(ShowAddressGroupRequest showAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", showAddressGroupRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddressGroupRequest);
            return new SyncInvoker<ShowAddressGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAddressGroupResponse>);
        }
        
        /// <summary>
        /// 更新地址组
        ///
        /// 更新地址组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAddressGroupResponse UpdateAddressGroup(UpdateAddressGroupRequest updateAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", updateAddressGroupRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAddressGroupResponse>(response);
        }

        public SyncInvoker<UpdateAddressGroupResponse> UpdateAddressGroupInvoker(UpdateAddressGroupRequest updateAddressGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id", updateAddressGroupRequest.AddressGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressGroupRequest);
            return new SyncInvoker<UpdateAddressGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAddressGroupResponse>);
        }
        
        /// <summary>
        /// 添加VPC扩展网段
        ///
        /// 添加VPC的扩展网段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddVpcExtendCidrResponse AddVpcExtendCidr(AddVpcExtendCidrRequest addVpcExtendCidrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", addVpcExtendCidrRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}/add-extend-cidr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addVpcExtendCidrRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<AddVpcExtendCidrResponse>(response);
        }

        public SyncInvoker<AddVpcExtendCidrResponse> AddVpcExtendCidrInvoker(AddVpcExtendCidrRequest addVpcExtendCidrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", addVpcExtendCidrRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}/add-extend-cidr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addVpcExtendCidrRequest);
            return new SyncInvoker<AddVpcExtendCidrResponse>(this, "PUT", request, JsonUtils.DeSerialize<AddVpcExtendCidrResponse>);
        }
        
        /// <summary>
        /// 创建VPC
        ///
        /// 创建虚拟私有云
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVpcResponse CreateVpc(CreateVpcRequest createVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVpcRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateVpcResponse>(response);
        }

        public SyncInvoker<CreateVpcResponse> CreateVpcInvoker(CreateVpcRequest createVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVpcRequest);
            return new SyncInvoker<CreateVpcResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVpcResponse>);
        }
        
        /// <summary>
        /// 删除VPC
        ///
        /// 删除VPC
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVpcResponse DeleteVpc(DeleteVpcRequest deleteVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", deleteVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVpcResponse>(response);
        }

        public SyncInvoker<DeleteVpcResponse> DeleteVpcInvoker(DeleteVpcRequest deleteVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", deleteVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRequest);
            return new SyncInvoker<DeleteVpcResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVpcResponse>);
        }
        
        /// <summary>
        /// 查询VPC列表
        ///
        /// 查询vpc列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVpcsResponse ListVpcs(ListVpcsRequest listVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVpcsResponse>(response);
        }

        public SyncInvoker<ListVpcsResponse> ListVpcsInvoker(ListVpcsRequest listVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcsRequest);
            return new SyncInvoker<ListVpcsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVpcsResponse>);
        }
        
        /// <summary>
        /// 移除VPC扩展网段
        ///
        /// 移除VPC扩展网段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveVpcExtendCidrResponse RemoveVpcExtendCidr(RemoveVpcExtendCidrRequest removeVpcExtendCidrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", removeVpcExtendCidrRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}/remove-extend-cidr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeVpcExtendCidrRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<RemoveVpcExtendCidrResponse>(response);
        }

        public SyncInvoker<RemoveVpcExtendCidrResponse> RemoveVpcExtendCidrInvoker(RemoveVpcExtendCidrRequest removeVpcExtendCidrRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", removeVpcExtendCidrRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}/remove-extend-cidr", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeVpcExtendCidrRequest);
            return new SyncInvoker<RemoveVpcExtendCidrResponse>(this, "PUT", request, JsonUtils.DeSerialize<RemoveVpcExtendCidrResponse>);
        }
        
        /// <summary>
        /// 查询VPC详情
        ///
        /// 查询vpc详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVpcResponse ShowVpc(ShowVpcRequest showVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", showVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVpcResponse>(response);
        }

        public SyncInvoker<ShowVpcResponse> ShowVpcInvoker(ShowVpcRequest showVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", showVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRequest);
            return new SyncInvoker<ShowVpcResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVpcResponse>);
        }
        
        /// <summary>
        /// 更新VPC
        ///
        /// 更新vpc
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateVpcResponse UpdateVpc(UpdateVpcRequest updateVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", updateVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVpcRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVpcResponse>(response);
        }

        public SyncInvoker<UpdateVpcResponse> UpdateVpcInvoker(UpdateVpcRequest updateVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", updateVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVpcRequest);
            return new SyncInvoker<UpdateVpcResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVpcResponse>);
        }
        
    }
}