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
        /// 流量镜像会话添加镜像源
        ///
        /// 流量镜像会话添加镜像源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddSourcesToTrafficMirrorSessionResponse> AddSourcesToTrafficMirrorSessionAsync(AddSourcesToTrafficMirrorSessionRequest addSourcesToTrafficMirrorSessionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id" , addSourcesToTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}/add-sources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSourcesToTrafficMirrorSessionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<AddSourcesToTrafficMirrorSessionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/batch-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateSubNetworkInterfaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateSubNetworkInterfaceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityGroupRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityGroupRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubNetworkInterfaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSubNetworkInterfaceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorFilterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTrafficMirrorFilterResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorFilterRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTrafficMirrorFilterRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrafficMirrorSessionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTrafficMirrorSessionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , deleteSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id" , deleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id" , deleteSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubNetworkInterfaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSubNetworkInterfaceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id" , deleteTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorFilterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTrafficMirrorFilterResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id" , deleteTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorFilterRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTrafficMirrorFilterRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id" , deleteTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrafficMirrorSessionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTrafficMirrorSessionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityGroupRulesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityGroupsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubNetworkInterfacesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSubNetworkInterfacesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorFilterRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTrafficMirrorFilterRulesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorFiltersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTrafficMirrorFiltersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrafficMirrorSessionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTrafficMirrorSessionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/migrate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateSubNetworkInterfaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<MigrateSubNetworkInterfaceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id" , removeSourcesFromTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}/remove-sources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeSourcesFromTrafficMirrorSessionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<RemoveSourcesFromTrafficMirrorSessionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , showSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSecurityGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id" , showSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSecurityGroupRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id" , showSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubNetworkInterfaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSubNetworkInterfaceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/count",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubNetworkInterfacesQuantityRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSubNetworkInterfacesQuantityResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id" , showTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorFilterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTrafficMirrorFilterResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id" , showTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorFilterRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTrafficMirrorFilterRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id" , showTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrafficMirrorSessionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTrafficMirrorSessionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , updateSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSecurityGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id" , updateSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubNetworkInterfaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSubNetworkInterfaceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_id" , updateTrafficMirrorFilterRequest.TrafficMirrorFilterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filters/{traffic_mirror_filter_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorFilterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTrafficMirrorFilterResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_filter_rule_id" , updateTrafficMirrorFilterRuleRequest.TrafficMirrorFilterRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-filter-rules/{traffic_mirror_filter_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorFilterRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTrafficMirrorFilterRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("traffic_mirror_session_id" , updateTrafficMirrorSessionRequest.TrafficMirrorSessionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/traffic-mirror-sessions/{traffic_mirror_session_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrafficMirrorSessionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTrafficMirrorSessionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id" , addFirewallRulesRequest.FirewallId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/insert-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFirewallRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<AddFirewallRulesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id" , associateSubnetFirewallRequest.FirewallId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/associate-subnets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateSubnetFirewallRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<AssociateSubnetFirewallResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateFirewallResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id" , deleteFirewallRequest.FirewallId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFirewallResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id" , disassociateSubnetFirewallRequest.FirewallId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/disassociate-subnets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateSubnetFirewallRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<DisassociateSubnetFirewallResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFirewallResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id" , removeFirewallRulesRequest.FirewallId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/remove-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeFirewallRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<RemoveFirewallRulesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id" , showFirewallRequest.FirewallId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFirewallRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFirewallResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id" , updateFirewallRequest.FirewallId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFirewallRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFirewallResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_id" , updateFirewallRulesRequest.FirewallId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/firewalls/{firewall_id}/update-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFirewallRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFirewallRulesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddressGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAddressGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id" , deleteAddressGroupRequest.AddressGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAddressGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id" , deleteIpAddressGroupForceRequest.AddressGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}/force",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpAddressGroupForceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteIpAddressGroupForceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAddressGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id" , showAddressGroupRequest.AddressGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddressGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAddressGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id" , updateAddressGroupRequest.AddressGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAddressGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , addVpcExtendCidrRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}/add-extend-cidr",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addVpcExtendCidrRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<AddVpcExtendCidrResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVpcRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVpcResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , deleteVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVpcsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , removeVpcExtendCidrRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}/remove-extend-cidr",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeVpcExtendCidrRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<RemoveVpcExtendCidrResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , showVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVpcResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , updateVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVpcRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVpcResponse>(response);
        }
        
    }
}