using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace HuaweiCloud.SDK.Vpc.V2
{
    public partial class VpcClient : Client
    {
        public static ClientBuilder<VpcClient> NewBuilder()
        {
            return new ClientBuilder<VpcClient>();
        }

        
        /// <summary>
        /// 接受对等连接请求
        ///
        /// 租户A名下的VPC申请和租户B的VPC建立对等连接，需要等待租户B接受该请求。此接口用于租户接受其他租户发起的对等连接请求。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AcceptVpcPeeringResponse AcceptVpcPeering(AcceptVpcPeeringRequest acceptVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(acceptVpcPeeringRequest.PeeringId, out var valueOfPeeringId)) urlParam.Add("peering_id", valueOfPeeringId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptVpcPeeringRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<AcceptVpcPeeringResponse>(response);
        }

        public SyncInvoker<AcceptVpcPeeringResponse> AcceptVpcPeeringInvoker(AcceptVpcPeeringRequest acceptVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(acceptVpcPeeringRequest.PeeringId, out var valueOfPeeringId)) urlParam.Add("peering_id", valueOfPeeringId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptVpcPeeringRequest);
            return new SyncInvoker<AcceptVpcPeeringResponse>(this, "PUT", request, JsonUtils.DeSerialize<AcceptVpcPeeringResponse>);
        }
        
        /// <summary>
        /// 子网关联路由表
        ///
        /// 路由表关联子网。子网关联路由表A后，再关联B，不需要先跟路由表A解关联再关联路由表B
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest associateRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRouteTableRequest.RoutetableId, out var valueOfRoutetableId)) urlParam.Add("routetable_id", valueOfRoutetableId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateRouteTableRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateRouteTableResponse>(response);
        }

        public SyncInvoker<AssociateRouteTableResponse> AssociateRouteTableInvoker(AssociateRouteTableRequest associateRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRouteTableRequest.RoutetableId, out var valueOfRoutetableId)) urlParam.Add("routetable_id", valueOfRoutetableId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateRouteTableRequest);
            return new SyncInvoker<AssociateRouteTableResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateRouteTableResponse>);
        }
        
        /// <summary>
        /// 批量创建安全组资源标签
        ///
        /// 为指定的安全组资源实例批量添加标签。
        /// 此接口为幂等接口：创建时如果请求体中存在重复key则报错。创建时，不允许设置重复key数据，如果数据库已存在该key，就覆盖value的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateSecurityGroupTagsResponse BatchCreateSecurityGroupTags(BatchCreateSecurityGroupTagsRequest batchCreateSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateSecurityGroupTagsRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSecurityGroupTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateSecurityGroupTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateSecurityGroupTagsResponse> BatchCreateSecurityGroupTagsInvoker(BatchCreateSecurityGroupTagsRequest batchCreateSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateSecurityGroupTagsRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSecurityGroupTagsRequest);
            return new SyncInvoker<BatchCreateSecurityGroupTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateSecurityGroupTagsResponse>);
        }
        
        /// <summary>
        /// 批量创建子网资源标签
        ///
        /// 为指定的子网资源实例批量添加标签。
        /// 此接口为幂等接口：创建时如果请求体中存在重复key则报错。创建时，不允许设置重复key数据，如果数据库已存在该key，就覆盖value的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateSubnetTagsResponse BatchCreateSubnetTags(BatchCreateSubnetTagsRequest batchCreateSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateSubnetTagsRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSubnetTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateSubnetTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateSubnetTagsResponse> BatchCreateSubnetTagsInvoker(BatchCreateSubnetTagsRequest batchCreateSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateSubnetTagsRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSubnetTagsRequest);
            return new SyncInvoker<BatchCreateSubnetTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateSubnetTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除安全组资源标签
        ///
        /// 为指定的安全组资源实例批量删除标签
        /// 此接口为幂等接口：删除时，如果删除的标签不存在，默认处理成功；删除时不对标签字符集范围做校验。删除时tags结构体不能缺失，key不能为空，或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteSecurityGroupTagsResponse BatchDeleteSecurityGroupTags(BatchDeleteSecurityGroupTagsRequest batchDeleteSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteSecurityGroupTagsRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSecurityGroupTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteSecurityGroupTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteSecurityGroupTagsResponse> BatchDeleteSecurityGroupTagsInvoker(BatchDeleteSecurityGroupTagsRequest batchDeleteSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteSecurityGroupTagsRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSecurityGroupTagsRequest);
            return new SyncInvoker<BatchDeleteSecurityGroupTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteSecurityGroupTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除子网资源标签
        ///
        /// 为指定的子网资源实例批量删除标签
        /// 此接口为幂等接口：删除时，如果删除的标签不存在，默认处理成功；删除时不对标签字符集范围做校验。删除时tags结构体不能缺失，key不能为空，或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteSubnetTagsResponse BatchDeleteSubnetTags(BatchDeleteSubnetTagsRequest batchDeleteSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteSubnetTagsRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSubnetTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteSubnetTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteSubnetTagsResponse> BatchDeleteSubnetTagsInvoker(BatchDeleteSubnetTagsRequest batchDeleteSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteSubnetTagsRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSubnetTagsRequest);
            return new SyncInvoker<BatchDeleteSubnetTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteSubnetTagsResponse>);
        }
        
        /// <summary>
        /// 创建流日志
        ///
        /// 创建流日志。
        /// 流日志功能可以记录虚拟私有云中的流量信息，帮助您检查和优化安全组和网络ACL防火墙控制规则、监控网络流量、进行网络攻击分析等。
        /// VPC流日志功能需要与云日志服务LTS结合使用，请先在云日志服务中创建日志组和日志主题，然后再创建VPC流日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFlowLogResponse CreateFlowLog(CreateFlowLogRequest createFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createFlowLogRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFlowLogResponse>(response);
        }

        public SyncInvoker<CreateFlowLogResponse> CreateFlowLogInvoker(CreateFlowLogRequest createFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createFlowLogRequest);
            return new SyncInvoker<CreateFlowLogResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFlowLogResponse>);
        }
        
        /// <summary>
        /// 创建端口
        ///
        /// 创建端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePortResponse CreatePort(CreatePortRequest createPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPortRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePortResponse>(response);
        }

        public SyncInvoker<CreatePortResponse> CreatePortInvoker(CreatePortRequest createPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPortRequest);
            return new SyncInvoker<CreatePortResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePortResponse>);
        }
        
        /// <summary>
        /// 创建路由表
        ///
        /// 创建路由表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest createRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRouteTableRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRouteTableResponse>(response);
        }

        public SyncInvoker<CreateRouteTableResponse> CreateRouteTableInvoker(CreateRouteTableRequest createRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRouteTableRequest);
            return new SyncInvoker<CreateRouteTableResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRouteTableResponse>);
        }
        
        /// <summary>
        /// 创建安全组
        ///
        /// 创建安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest createSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSecurityGroupResponse>(response);
        }

        public SyncInvoker<CreateSecurityGroupResponse> CreateSecurityGroupInvoker(CreateSecurityGroupRequest createSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupRequest);
            return new SyncInvoker<CreateSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 创建安全组规则
        ///
        /// 创建安全组规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSecurityGroupRuleResponse CreateSecurityGroupRule(CreateSecurityGroupRuleRequest createSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSecurityGroupRuleResponse>(response);
        }

        public SyncInvoker<CreateSecurityGroupRuleResponse> CreateSecurityGroupRuleInvoker(CreateSecurityGroupRuleRequest createSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupRuleRequest);
            return new SyncInvoker<CreateSecurityGroupRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 创建安全组资源标签
        ///
        /// 给指定安全组资源实例增加标签信息。
        /// 此接口为幂等接口：创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSecurityGroupTagResponse CreateSecurityGroupTag(CreateSecurityGroupTagRequest createSecurityGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSecurityGroupTagRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSecurityGroupTagResponse>(response);
        }

        public SyncInvoker<CreateSecurityGroupTagResponse> CreateSecurityGroupTagInvoker(CreateSecurityGroupTagRequest createSecurityGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSecurityGroupTagRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupTagRequest);
            return new SyncInvoker<CreateSecurityGroupTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSecurityGroupTagResponse>);
        }
        
        /// <summary>
        /// 创建子网
        ///
        /// 创建子网。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSubnetResponse CreateSubnet(CreateSubnetRequest createSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubnetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSubnetResponse>(response);
        }

        public SyncInvoker<CreateSubnetResponse> CreateSubnetInvoker(CreateSubnetRequest createSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubnetRequest);
            return new SyncInvoker<CreateSubnetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSubnetResponse>);
        }
        
        /// <summary>
        /// 创建子网资源标签
        ///
        /// 给指定子网资源实例增加标签信息。
        /// 此接口为幂等接口：创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSubnetTagResponse CreateSubnetTag(CreateSubnetTagRequest createSubnetTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSubnetTagRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubnetTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSubnetTagResponse>(response);
        }

        public SyncInvoker<CreateSubnetTagResponse> CreateSubnetTagInvoker(CreateSubnetTagRequest createSubnetTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSubnetTagRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubnetTagRequest);
            return new SyncInvoker<CreateSubnetTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSubnetTagResponse>);
        }
        
        /// <summary>
        /// 创建对等连接
        ///
        /// 创建对等连接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVpcPeeringResponse CreateVpcPeering(CreateVpcPeeringRequest createVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcPeeringRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateVpcPeeringResponse>(response);
        }

        public SyncInvoker<CreateVpcPeeringResponse> CreateVpcPeeringInvoker(CreateVpcPeeringRequest createVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcPeeringRequest);
            return new SyncInvoker<CreateVpcPeeringResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVpcPeeringResponse>);
        }
        
        /// <summary>
        /// 删除流日志
        ///
        /// 删除流日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteFlowLogResponse DeleteFlowLog(DeleteFlowLogRequest deleteFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFlowLogRequest.FlowlogId, out var valueOfFlowlogId)) urlParam.Add("flowlog_id", valueOfFlowlogId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs/{flowlog_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFlowLogRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteFlowLogResponse>(response);
        }

        public SyncInvoker<DeleteFlowLogResponse> DeleteFlowLogInvoker(DeleteFlowLogRequest deleteFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFlowLogRequest.FlowlogId, out var valueOfFlowlogId)) urlParam.Add("flowlog_id", valueOfFlowlogId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs/{flowlog_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFlowLogRequest);
            return new SyncInvoker<DeleteFlowLogResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFlowLogResponse>);
        }
        
        /// <summary>
        /// 删除端口
        ///
        /// 删除端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePortResponse DeletePort(DeletePortRequest deletePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePortRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePortRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePortResponse>(response);
        }

        public SyncInvoker<DeletePortResponse> DeletePortInvoker(DeletePortRequest deletePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePortRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePortRequest);
            return new SyncInvoker<DeletePortResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePortResponse>);
        }
        
        /// <summary>
        /// 删除路由表
        ///
        /// 删除路由表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest deleteRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRouteTableRequest.RoutetableId, out var valueOfRoutetableId)) urlParam.Add("routetable_id", valueOfRoutetableId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRouteTableRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRouteTableResponse>(response);
        }

        public SyncInvoker<DeleteRouteTableResponse> DeleteRouteTableInvoker(DeleteRouteTableRequest deleteRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRouteTableRequest.RoutetableId, out var valueOfRoutetableId)) urlParam.Add("routetable_id", valueOfRoutetableId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRouteTableRequest);
            return new SyncInvoker<DeleteRouteTableResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRouteTableResponse>);
        }
        
        /// <summary>
        /// 删除安全组
        ///
        /// 删除安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest deleteSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecurityGroupRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupResponse>(response);
        }

        public SyncInvoker<DeleteSecurityGroupResponse> DeleteSecurityGroupInvoker(DeleteSecurityGroupRequest deleteSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecurityGroupRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRequest);
            return new SyncInvoker<DeleteSecurityGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 删除安全组规则
        ///
        /// 删除安全组规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSecurityGroupRuleResponse DeleteSecurityGroupRule(DeleteSecurityGroupRuleRequest deleteSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecurityGroupRuleRequest.SecurityGroupRuleId, out var valueOfSecurityGroupRuleId)) urlParam.Add("security_group_rule_id", valueOfSecurityGroupRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupRuleResponse>(response);
        }

        public SyncInvoker<DeleteSecurityGroupRuleResponse> DeleteSecurityGroupRuleInvoker(DeleteSecurityGroupRuleRequest deleteSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecurityGroupRuleRequest.SecurityGroupRuleId, out var valueOfSecurityGroupRuleId)) urlParam.Add("security_group_rule_id", valueOfSecurityGroupRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRuleRequest);
            return new SyncInvoker<DeleteSecurityGroupRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 删除安全组资源标签
        ///
        /// 删除指定安全组资源实例的标签信息。
        /// 该接口为幂等接口：删除的key不存在报404，Key不能为空或者空字符串
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSecurityGroupTagResponse DeleteSecurityGroupTag(DeleteSecurityGroupTagRequest deleteSecurityGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecurityGroupTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            if (StringUtils.TryConvertToNonEmptyString(deleteSecurityGroupTagRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupTagResponse>(response);
        }

        public SyncInvoker<DeleteSecurityGroupTagResponse> DeleteSecurityGroupTagInvoker(DeleteSecurityGroupTagRequest deleteSecurityGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecurityGroupTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            if (StringUtils.TryConvertToNonEmptyString(deleteSecurityGroupTagRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupTagRequest);
            return new SyncInvoker<DeleteSecurityGroupTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecurityGroupTagResponse>);
        }
        
        /// <summary>
        /// 删除子网
        ///
        /// 删除子网
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest deleteSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSubnetRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubnetRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSubnetResponse>(response);
        }

        public SyncInvoker<DeleteSubnetResponse> DeleteSubnetInvoker(DeleteSubnetRequest deleteSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSubnetRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubnetRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetRequest);
            return new SyncInvoker<DeleteSubnetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSubnetResponse>);
        }
        
        /// <summary>
        /// 删除子网资源标签
        ///
        /// 删除指定子网资源实例的标签信息。
        /// 该接口为幂等接口：删除的key不存在报404，Key不能为空或者空字符串
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSubnetTagResponse DeleteSubnetTag(DeleteSubnetTagRequest deleteSubnetTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSubnetTagRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubnetTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSubnetTagResponse>(response);
        }

        public SyncInvoker<DeleteSubnetTagResponse> DeleteSubnetTagInvoker(DeleteSubnetTagRequest deleteSubnetTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSubnetTagRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubnetTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetTagRequest);
            return new SyncInvoker<DeleteSubnetTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSubnetTagResponse>);
        }
        
        /// <summary>
        /// 删除对等连接
        ///
        /// 删除对等连接。
        /// 可以在在本端或对端任何一端删除对等连接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVpcPeeringResponse DeleteVpcPeering(DeleteVpcPeeringRequest deleteVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteVpcPeeringRequest.PeeringId, out var valueOfPeeringId)) urlParam.Add("peering_id", valueOfPeeringId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcPeeringRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVpcPeeringResponse>(response);
        }

        public SyncInvoker<DeleteVpcPeeringResponse> DeleteVpcPeeringInvoker(DeleteVpcPeeringRequest deleteVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteVpcPeeringRequest.PeeringId, out var valueOfPeeringId)) urlParam.Add("peering_id", valueOfPeeringId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcPeeringRequest);
            return new SyncInvoker<DeleteVpcPeeringResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVpcPeeringResponse>);
        }
        
        /// <summary>
        /// 子网解关联路由表
        ///
        /// 子网解关联路由表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest disassociateRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateRouteTableRequest.RoutetableId, out var valueOfRoutetableId)) urlParam.Add("routetable_id", valueOfRoutetableId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateRouteTableRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisassociateRouteTableResponse>(response);
        }

        public SyncInvoker<DisassociateRouteTableResponse> DisassociateRouteTableInvoker(DisassociateRouteTableRequest disassociateRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateRouteTableRequest.RoutetableId, out var valueOfRoutetableId)) urlParam.Add("routetable_id", valueOfRoutetableId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateRouteTableRequest);
            return new SyncInvoker<DisassociateRouteTableResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateRouteTableResponse>);
        }
        
        /// <summary>
        /// 查询流日志列表
        ///
        /// 查询提交请求的租户的所有流日志列表，并根据过滤条件进行过滤
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFlowLogsResponse ListFlowLogs(ListFlowLogsRequest listFlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFlowLogsResponse>(response);
        }

        public SyncInvoker<ListFlowLogsResponse> ListFlowLogsInvoker(ListFlowLogsRequest listFlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowLogsRequest);
            return new SyncInvoker<ListFlowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlowLogsResponse>);
        }
        
        /// <summary>
        /// 查询端口列表
        ///
        /// 查询提交请求的租户的所有端口，单次查询最多返回2000条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPortsResponse ListPorts(ListPortsRequest listPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPortsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPortsResponse>(response);
        }

        public SyncInvoker<ListPortsResponse> ListPortsInvoker(ListPortsRequest listPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPortsRequest);
            return new SyncInvoker<ListPortsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPortsResponse>);
        }
        
        /// <summary>
        /// 查询路由表列表
        ///
        /// 查询提交请求的帐户的所有路由表列表，并根据过滤条件进行过滤
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRouteTablesResponse ListRouteTables(ListRouteTablesRequest listRouteTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRouteTablesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRouteTablesResponse>(response);
        }

        public SyncInvoker<ListRouteTablesResponse> ListRouteTablesInvoker(ListRouteTablesRequest listRouteTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRouteTablesRequest);
            return new SyncInvoker<ListRouteTablesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRouteTablesResponse>);
        }
        
        /// <summary>
        /// 查询安全组规则列表
        ///
        /// 查询安全组规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSecurityGroupRulesResponse ListSecurityGroupRules(ListSecurityGroupRulesRequest listSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSecurityGroupRulesResponse>(response);
        }

        public SyncInvoker<ListSecurityGroupRulesResponse> ListSecurityGroupRulesInvoker(ListSecurityGroupRulesRequest listSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupRulesRequest);
            return new SyncInvoker<ListSecurityGroupRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecurityGroupRulesResponse>);
        }
        
        /// <summary>
        /// 查询安全组项目标签
        ///
        /// 查询租户在指定区域和实例类型的所有标签集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSecurityGroupTagsResponse ListSecurityGroupTags(ListSecurityGroupTagsRequest listSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSecurityGroupTagsResponse>(response);
        }

        public SyncInvoker<ListSecurityGroupTagsResponse> ListSecurityGroupTagsInvoker(ListSecurityGroupTagsRequest listSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupTagsRequest);
            return new SyncInvoker<ListSecurityGroupTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecurityGroupTagsResponse>);
        }
        
        /// <summary>
        /// 查询安全组列表
        ///
        /// 查询安全组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSecurityGroupsResponse ListSecurityGroups(ListSecurityGroupsRequest listSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSecurityGroupsResponse>(response);
        }

        public SyncInvoker<ListSecurityGroupsResponse> ListSecurityGroupsInvoker(ListSecurityGroupsRequest listSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupsRequest);
            return new SyncInvoker<ListSecurityGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecurityGroupsResponse>);
        }
        
        /// <summary>
        /// 查询安全组资源实例
        ///
        /// 使用标签过滤实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSecurityGroupsByTagsResponse ListSecurityGroupsByTags(ListSecurityGroupsByTagsRequest listSecurityGroupsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSecurityGroupsByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSecurityGroupsByTagsResponse>(response);
        }

        public SyncInvoker<ListSecurityGroupsByTagsResponse> ListSecurityGroupsByTagsInvoker(ListSecurityGroupsByTagsRequest listSecurityGroupsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSecurityGroupsByTagsRequest);
            return new SyncInvoker<ListSecurityGroupsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSecurityGroupsByTagsResponse>);
        }
        
        /// <summary>
        /// 查询子网项目标签
        ///
        /// 查询租户在指定区域和实例类型的所有标签集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubnetTagsResponse ListSubnetTags(ListSubnetTagsRequest listSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSubnetTagsResponse>(response);
        }

        public SyncInvoker<ListSubnetTagsResponse> ListSubnetTagsInvoker(ListSubnetTagsRequest listSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetTagsRequest);
            return new SyncInvoker<ListSubnetTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubnetTagsResponse>);
        }
        
        /// <summary>
        /// 查询子网列表
        ///
        /// 查询子网列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubnetsResponse ListSubnets(ListSubnetsRequest listSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSubnetsResponse>(response);
        }

        public SyncInvoker<ListSubnetsResponse> ListSubnetsInvoker(ListSubnetsRequest listSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetsRequest);
            return new SyncInvoker<ListSubnetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubnetsResponse>);
        }
        
        /// <summary>
        /// 查询子网资源实例
        ///
        /// 使用标签过滤实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubnetsByTagsResponse ListSubnetsByTags(ListSubnetsByTagsRequest listSubnetsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSubnetsByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSubnetsByTagsResponse>(response);
        }

        public SyncInvoker<ListSubnetsByTagsResponse> ListSubnetsByTagsInvoker(ListSubnetsByTagsRequest listSubnetsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSubnetsByTagsRequest);
            return new SyncInvoker<ListSubnetsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSubnetsByTagsResponse>);
        }
        
        /// <summary>
        /// 查询对等连接列表
        ///
        /// 查询提交请求的租户的所有对等连接。根据过滤条件进行过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVpcPeeringsResponse ListVpcPeerings(ListVpcPeeringsRequest listVpcPeeringsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcPeeringsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVpcPeeringsResponse>(response);
        }

        public SyncInvoker<ListVpcPeeringsResponse> ListVpcPeeringsInvoker(ListVpcPeeringsRequest listVpcPeeringsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcPeeringsRequest);
            return new SyncInvoker<ListVpcPeeringsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVpcPeeringsResponse>);
        }
        
        /// <summary>
        /// 拒绝对等连接请求
        ///
        /// 租户A名下的VPC申请和租户B的VPC建立对等连接，需要等待租户B接受该请求。此接口用于租户拒绝其他租户发起的对等连接请求。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RejectVpcPeeringResponse RejectVpcPeering(RejectVpcPeeringRequest rejectVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rejectVpcPeeringRequest.PeeringId, out var valueOfPeeringId)) urlParam.Add("peering_id", valueOfPeeringId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}/reject", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rejectVpcPeeringRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<RejectVpcPeeringResponse>(response);
        }

        public SyncInvoker<RejectVpcPeeringResponse> RejectVpcPeeringInvoker(RejectVpcPeeringRequest rejectVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rejectVpcPeeringRequest.PeeringId, out var valueOfPeeringId)) urlParam.Add("peering_id", valueOfPeeringId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}/reject", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rejectVpcPeeringRequest);
            return new SyncInvoker<RejectVpcPeeringResponse>(this, "PUT", request, JsonUtils.DeSerialize<RejectVpcPeeringResponse>);
        }
        
        /// <summary>
        /// 查询流日志
        ///
        /// 查询流日志详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFlowLogResponse ShowFlowLog(ShowFlowLogRequest showFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFlowLogRequest.FlowlogId, out var valueOfFlowlogId)) urlParam.Add("flowlog_id", valueOfFlowlogId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs/{flowlog_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFlowLogResponse>(response);
        }

        public SyncInvoker<ShowFlowLogResponse> ShowFlowLogInvoker(ShowFlowLogRequest showFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFlowLogRequest.FlowlogId, out var valueOfFlowlogId)) urlParam.Add("flowlog_id", valueOfFlowlogId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs/{flowlog_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowLogRequest);
            return new SyncInvoker<ShowFlowLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlowLogResponse>);
        }
        
        /// <summary>
        /// 查询端口
        ///
        /// 查询单个端口详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPortResponse ShowPort(ShowPortRequest showPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPortRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPortRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPortResponse>(response);
        }

        public SyncInvoker<ShowPortResponse> ShowPortInvoker(ShowPortRequest showPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPortRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPortRequest);
            return new SyncInvoker<ShowPortResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPortResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询单租户在VPC服务下的网络资源配额，包括vpc配额、子网配额、安全组配额、安全组规则配额、弹性公网IP配额，vpn配额等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQuotaResponse ShowQuota(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }

        public SyncInvoker<ShowQuotaResponse> ShowQuotaInvoker(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            return new SyncInvoker<ShowQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotaResponse>);
        }
        
        /// <summary>
        /// 查询路由表
        ///
        /// 查询路由表详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRouteTableResponse ShowRouteTable(ShowRouteTableRequest showRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRouteTableRequest.RoutetableId, out var valueOfRoutetableId)) urlParam.Add("routetable_id", valueOfRoutetableId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRouteTableRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRouteTableResponse>(response);
        }

        public SyncInvoker<ShowRouteTableResponse> ShowRouteTableInvoker(ShowRouteTableRequest showRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRouteTableRequest.RoutetableId, out var valueOfRoutetableId)) urlParam.Add("routetable_id", valueOfRoutetableId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRouteTableRequest);
            return new SyncInvoker<ShowRouteTableResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRouteTableResponse>);
        }
        
        /// <summary>
        /// 查询安全组
        ///
        /// 查询单个安全组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecurityGroupResponse ShowSecurityGroup(ShowSecurityGroupRequest showSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecurityGroupRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecurityGroupResponse>(response);
        }

        public SyncInvoker<ShowSecurityGroupResponse> ShowSecurityGroupInvoker(ShowSecurityGroupRequest showSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecurityGroupRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRequest);
            return new SyncInvoker<ShowSecurityGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 查询安全组规则
        ///
        /// 查询单个安全组规则详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecurityGroupRuleResponse ShowSecurityGroupRule(ShowSecurityGroupRuleRequest showSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecurityGroupRuleRequest.SecurityGroupRuleId, out var valueOfSecurityGroupRuleId)) urlParam.Add("security_group_rule_id", valueOfSecurityGroupRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecurityGroupRuleResponse>(response);
        }

        public SyncInvoker<ShowSecurityGroupRuleResponse> ShowSecurityGroupRuleInvoker(ShowSecurityGroupRuleRequest showSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecurityGroupRuleRequest.SecurityGroupRuleId, out var valueOfSecurityGroupRuleId)) urlParam.Add("security_group_rule_id", valueOfSecurityGroupRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRuleRequest);
            return new SyncInvoker<ShowSecurityGroupRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 查询安全组资源标签
        ///
        /// 查询指定安全组实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecurityGroupTagsResponse ShowSecurityGroupTags(ShowSecurityGroupTagsRequest showSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecurityGroupTagsRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecurityGroupTagsResponse>(response);
        }

        public SyncInvoker<ShowSecurityGroupTagsResponse> ShowSecurityGroupTagsInvoker(ShowSecurityGroupTagsRequest showSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecurityGroupTagsRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupTagsRequest);
            return new SyncInvoker<ShowSecurityGroupTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecurityGroupTagsResponse>);
        }
        
        /// <summary>
        /// 查询子网
        ///
        /// 查询子网详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSubnetResponse ShowSubnet(ShowSubnetRequest showSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSubnetRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSubnetResponse>(response);
        }

        public SyncInvoker<ShowSubnetResponse> ShowSubnetInvoker(ShowSubnetRequest showSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSubnetRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetRequest);
            return new SyncInvoker<ShowSubnetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubnetResponse>);
        }
        
        /// <summary>
        /// 查询子网资源标签
        ///
        /// 查询指定子网实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSubnetTagsResponse ShowSubnetTags(ShowSubnetTagsRequest showSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSubnetTagsRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSubnetTagsResponse>(response);
        }

        public SyncInvoker<ShowSubnetTagsResponse> ShowSubnetTagsInvoker(ShowSubnetTagsRequest showSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSubnetTagsRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetTagsRequest);
            return new SyncInvoker<ShowSubnetTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubnetTagsResponse>);
        }
        
        /// <summary>
        /// 查询对等连接
        ///
        /// 查询对等连接详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVpcPeeringResponse ShowVpcPeering(ShowVpcPeeringRequest showVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVpcPeeringRequest.PeeringId, out var valueOfPeeringId)) urlParam.Add("peering_id", valueOfPeeringId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcPeeringRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVpcPeeringResponse>(response);
        }

        public SyncInvoker<ShowVpcPeeringResponse> ShowVpcPeeringInvoker(ShowVpcPeeringRequest showVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVpcPeeringRequest.PeeringId, out var valueOfPeeringId)) urlParam.Add("peering_id", valueOfPeeringId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcPeeringRequest);
            return new SyncInvoker<ShowVpcPeeringResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVpcPeeringResponse>);
        }
        
        /// <summary>
        /// 更新流日志
        ///
        /// 更新流日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFlowLogResponse UpdateFlowLog(UpdateFlowLogRequest updateFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFlowLogRequest.FlowlogId, out var valueOfFlowlogId)) urlParam.Add("flowlog_id", valueOfFlowlogId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs/{flowlog_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateFlowLogRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFlowLogResponse>(response);
        }

        public SyncInvoker<UpdateFlowLogResponse> UpdateFlowLogInvoker(UpdateFlowLogRequest updateFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFlowLogRequest.FlowlogId, out var valueOfFlowlogId)) urlParam.Add("flowlog_id", valueOfFlowlogId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs/{flowlog_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateFlowLogRequest);
            return new SyncInvoker<UpdateFlowLogResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFlowLogResponse>);
        }
        
        /// <summary>
        /// 更新端口
        ///
        /// 更新端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePortResponse UpdatePort(UpdatePortRequest updatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePortRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePortRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePortResponse>(response);
        }

        public SyncInvoker<UpdatePortResponse> UpdatePortInvoker(UpdatePortRequest updatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePortRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePortRequest);
            return new SyncInvoker<UpdatePortResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePortResponse>);
        }
        
        /// <summary>
        /// 更新路由表
        ///
        /// 更新路由表，包括可以更新路由表的名称，描述，以及新增、更新、删除路由条目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRouteTableResponse UpdateRouteTable(UpdateRouteTableRequest updateRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRouteTableRequest.RoutetableId, out var valueOfRoutetableId)) urlParam.Add("routetable_id", valueOfRoutetableId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRouteTableRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRouteTableResponse>(response);
        }

        public SyncInvoker<UpdateRouteTableResponse> UpdateRouteTableInvoker(UpdateRouteTableRequest updateRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRouteTableRequest.RoutetableId, out var valueOfRoutetableId)) urlParam.Add("routetable_id", valueOfRoutetableId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRouteTableRequest);
            return new SyncInvoker<UpdateRouteTableResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRouteTableResponse>);
        }
        
        /// <summary>
        /// 更新子网
        ///
        /// 更新子网。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSubnetResponse UpdateSubnet(UpdateSubnetRequest updateSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSubnetRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            if (StringUtils.TryConvertToNonEmptyString(updateSubnetRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSubnetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSubnetResponse>(response);
        }

        public SyncInvoker<UpdateSubnetResponse> UpdateSubnetInvoker(UpdateSubnetRequest updateSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSubnetRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            if (StringUtils.TryConvertToNonEmptyString(updateSubnetRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSubnetRequest);
            return new SyncInvoker<UpdateSubnetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSubnetResponse>);
        }
        
        /// <summary>
        /// 更新对等连接
        ///
        /// 更新对等连接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateVpcPeeringResponse UpdateVpcPeering(UpdateVpcPeeringRequest updateVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateVpcPeeringRequest.PeeringId, out var valueOfPeeringId)) urlParam.Add("peering_id", valueOfPeeringId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVpcPeeringRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVpcPeeringResponse>(response);
        }

        public SyncInvoker<UpdateVpcPeeringResponse> UpdateVpcPeeringInvoker(UpdateVpcPeeringRequest updateVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateVpcPeeringRequest.PeeringId, out var valueOfPeeringId)) urlParam.Add("peering_id", valueOfPeeringId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVpcPeeringRequest);
            return new SyncInvoker<UpdateVpcPeeringResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVpcPeeringResponse>);
        }
        
        /// <summary>
        /// 申请私有IP
        ///
        /// 申请私有IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePrivateipResponse CreatePrivateip(CreatePrivateipRequest createPrivateipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPrivateipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePrivateipResponse>(response);
        }

        public SyncInvoker<CreatePrivateipResponse> CreatePrivateipInvoker(CreatePrivateipRequest createPrivateipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPrivateipRequest);
            return new SyncInvoker<CreatePrivateipResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePrivateipResponse>);
        }
        
        /// <summary>
        /// 删除私有IP
        ///
        /// 删除私有IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePrivateipResponse DeletePrivateip(DeletePrivateipRequest deletePrivateipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePrivateipRequest.PrivateipId, out var valueOfPrivateipId)) urlParam.Add("privateip_id", valueOfPrivateipId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips/{privateip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateipRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePrivateipResponse>(response);
        }

        public SyncInvoker<DeletePrivateipResponse> DeletePrivateipInvoker(DeletePrivateipRequest deletePrivateipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePrivateipRequest.PrivateipId, out var valueOfPrivateipId)) urlParam.Add("privateip_id", valueOfPrivateipId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips/{privateip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateipRequest);
            return new SyncInvoker<DeletePrivateipResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePrivateipResponse>);
        }
        
        /// <summary>
        /// 查询私有IP列表
        ///
        /// 查询指定子网下的私有IP列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPrivateipsResponse ListPrivateips(ListPrivateipsRequest listPrivateipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPrivateipsRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets/{subnet_id}/privateips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateipsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPrivateipsResponse>(response);
        }

        public SyncInvoker<ListPrivateipsResponse> ListPrivateipsInvoker(ListPrivateipsRequest listPrivateipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPrivateipsRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets/{subnet_id}/privateips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateipsRequest);
            return new SyncInvoker<ListPrivateipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPrivateipsResponse>);
        }
        
        /// <summary>
        /// 查询网络IP使用情况
        ///
        /// 显示一个指定网络中的IPv4地址使用情况。
        /// 包括此网络中的IP总数以及已用IP总数，以及网络下每一个子网的IP地址总数和可用IP地址总数。
        /// 
        /// &gt; 须知
        /// 
        /// - 系统预留地址指的是子网的第1个以及最后4个地址，一般用于网关、DHCP等服务。
        /// - 这里以及下文描述的IP地址总数、已用IP地址总数不包含系统预留地址。
        /// - 在分配IP时，用户可以指定系统预留的IP地址。但是不论IP是如何分配的，只要是处于系统预留IP地址段的IP均不会被统计到已用IP地址数目和IP地址总数中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNetworkIpAvailabilitiesResponse ShowNetworkIpAvailabilities(ShowNetworkIpAvailabilitiesRequest showNetworkIpAvailabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNetworkIpAvailabilitiesRequest.NetworkId, out var valueOfNetworkId)) urlParam.Add("network_id", valueOfNetworkId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/network-ip-availabilities/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkIpAvailabilitiesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNetworkIpAvailabilitiesResponse>(response);
        }

        public SyncInvoker<ShowNetworkIpAvailabilitiesResponse> ShowNetworkIpAvailabilitiesInvoker(ShowNetworkIpAvailabilitiesRequest showNetworkIpAvailabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNetworkIpAvailabilitiesRequest.NetworkId, out var valueOfNetworkId)) urlParam.Add("network_id", valueOfNetworkId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/network-ip-availabilities/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkIpAvailabilitiesRequest);
            return new SyncInvoker<ShowNetworkIpAvailabilitiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNetworkIpAvailabilitiesResponse>);
        }
        
        /// <summary>
        /// 查询私有IP
        ///
        /// 指定ID查询私有IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPrivateipResponse ShowPrivateip(ShowPrivateipRequest showPrivateipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrivateipRequest.PrivateipId, out var valueOfPrivateipId)) urlParam.Add("privateip_id", valueOfPrivateipId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips/{privateip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateipRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateipResponse>(response);
        }

        public SyncInvoker<ShowPrivateipResponse> ShowPrivateipInvoker(ShowPrivateipRequest showPrivateipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPrivateipRequest.PrivateipId, out var valueOfPrivateipId)) urlParam.Add("privateip_id", valueOfPrivateipId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips/{privateip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateipRequest);
            return new SyncInvoker<ShowPrivateipResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateipResponse>);
        }
        
        /// <summary>
        /// 路由器添加接口
        ///
        /// 添加路由器接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronAddRouterInterfaceResponse NeutronAddRouterInterface(NeutronAddRouterInterfaceRequest neutronAddRouterInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronAddRouterInterfaceRequest.RouterId, out var valueOfRouterId)) urlParam.Add("router_id", valueOfRouterId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}/add_router_interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronAddRouterInterfaceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<NeutronAddRouterInterfaceResponse>(response);
        }

        public SyncInvoker<NeutronAddRouterInterfaceResponse> NeutronAddRouterInterfaceInvoker(NeutronAddRouterInterfaceRequest neutronAddRouterInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronAddRouterInterfaceRequest.RouterId, out var valueOfRouterId)) urlParam.Add("router_id", valueOfRouterId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}/add_router_interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronAddRouterInterfaceRequest);
            return new SyncInvoker<NeutronAddRouterInterfaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronAddRouterInterfaceResponse>);
        }
        
        /// <summary>
        /// 创建网络
        ///
        /// 创建网络
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronCreateNetworkResponse NeutronCreateNetwork(NeutronCreateNetworkRequest neutronCreateNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateNetworkRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateNetworkResponse>(response);
        }

        public SyncInvoker<NeutronCreateNetworkResponse> NeutronCreateNetworkInvoker(NeutronCreateNetworkRequest neutronCreateNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateNetworkRequest);
            return new SyncInvoker<NeutronCreateNetworkResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateNetworkResponse>);
        }
        
        /// <summary>
        /// 创建端口
        ///
        /// 创建端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronCreatePortResponse NeutronCreatePort(NeutronCreatePortRequest neutronCreatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreatePortRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreatePortResponse>(response);
        }

        public SyncInvoker<NeutronCreatePortResponse> NeutronCreatePortInvoker(NeutronCreatePortRequest neutronCreatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreatePortRequest);
            return new SyncInvoker<NeutronCreatePortResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreatePortResponse>);
        }
        
        /// <summary>
        /// 创建路由器
        ///
        /// 创建路由器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronCreateRouterResponse NeutronCreateRouter(NeutronCreateRouterRequest neutronCreateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateRouterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateRouterResponse>(response);
        }

        public SyncInvoker<NeutronCreateRouterResponse> NeutronCreateRouterInvoker(NeutronCreateRouterRequest neutronCreateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateRouterRequest);
            return new SyncInvoker<NeutronCreateRouterResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateRouterResponse>);
        }
        
        /// <summary>
        /// 创建安全组
        ///
        /// 创建安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronCreateSecurityGroupResponse NeutronCreateSecurityGroup(NeutronCreateSecurityGroupRequest neutronCreateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSecurityGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateSecurityGroupResponse>(response);
        }

        public SyncInvoker<NeutronCreateSecurityGroupResponse> NeutronCreateSecurityGroupInvoker(NeutronCreateSecurityGroupRequest neutronCreateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSecurityGroupRequest);
            return new SyncInvoker<NeutronCreateSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 创建安全组规则
        ///
        /// 创建安全组规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronCreateSecurityGroupRuleResponse NeutronCreateSecurityGroupRule(NeutronCreateSecurityGroupRuleRequest neutronCreateSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSecurityGroupRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateSecurityGroupRuleResponse>(response);
        }

        public SyncInvoker<NeutronCreateSecurityGroupRuleResponse> NeutronCreateSecurityGroupRuleInvoker(NeutronCreateSecurityGroupRuleRequest neutronCreateSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSecurityGroupRuleRequest);
            return new SyncInvoker<NeutronCreateSecurityGroupRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 创建子网
        ///
        /// 创建子网。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronCreateSubnetResponse NeutronCreateSubnet(NeutronCreateSubnetRequest neutronCreateSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSubnetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateSubnetResponse>(response);
        }

        public SyncInvoker<NeutronCreateSubnetResponse> NeutronCreateSubnetInvoker(NeutronCreateSubnetRequest neutronCreateSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSubnetRequest);
            return new SyncInvoker<NeutronCreateSubnetResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateSubnetResponse>);
        }
        
        /// <summary>
        /// 删除网络
        ///
        /// 删除网络
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronDeleteNetworkResponse NeutronDeleteNetwork(NeutronDeleteNetworkRequest neutronDeleteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteNetworkRequest.NetworkId, out var valueOfNetworkId)) urlParam.Add("network_id", valueOfNetworkId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteNetworkRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteNetworkResponse>(response);
        }

        public SyncInvoker<NeutronDeleteNetworkResponse> NeutronDeleteNetworkInvoker(NeutronDeleteNetworkRequest neutronDeleteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteNetworkRequest.NetworkId, out var valueOfNetworkId)) urlParam.Add("network_id", valueOfNetworkId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteNetworkRequest);
            return new SyncInvoker<NeutronDeleteNetworkResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteNetworkResponse>);
        }
        
        /// <summary>
        /// 删除端口
        ///
        /// 删除端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronDeletePortResponse NeutronDeletePort(NeutronDeletePortRequest neutronDeletePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeletePortRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeletePortRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeletePortResponse>(response);
        }

        public SyncInvoker<NeutronDeletePortResponse> NeutronDeletePortInvoker(NeutronDeletePortRequest neutronDeletePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeletePortRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeletePortRequest);
            return new SyncInvoker<NeutronDeletePortResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeletePortResponse>);
        }
        
        /// <summary>
        /// 删除路由器
        ///
        /// 删除路由器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronDeleteRouterResponse NeutronDeleteRouter(NeutronDeleteRouterRequest neutronDeleteRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteRouterRequest.RouterId, out var valueOfRouterId)) urlParam.Add("router_id", valueOfRouterId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteRouterRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteRouterResponse>(response);
        }

        public SyncInvoker<NeutronDeleteRouterResponse> NeutronDeleteRouterInvoker(NeutronDeleteRouterRequest neutronDeleteRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteRouterRequest.RouterId, out var valueOfRouterId)) urlParam.Add("router_id", valueOfRouterId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteRouterRequest);
            return new SyncInvoker<NeutronDeleteRouterResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteRouterResponse>);
        }
        
        /// <summary>
        /// 删除安全组
        ///
        /// 删除安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronDeleteSecurityGroupResponse NeutronDeleteSecurityGroup(NeutronDeleteSecurityGroupRequest neutronDeleteSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteSecurityGroupRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSecurityGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteSecurityGroupResponse>(response);
        }

        public SyncInvoker<NeutronDeleteSecurityGroupResponse> NeutronDeleteSecurityGroupInvoker(NeutronDeleteSecurityGroupRequest neutronDeleteSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteSecurityGroupRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSecurityGroupRequest);
            return new SyncInvoker<NeutronDeleteSecurityGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 删除安全组规则
        ///
        /// 删除安全组规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronDeleteSecurityGroupRuleResponse NeutronDeleteSecurityGroupRule(NeutronDeleteSecurityGroupRuleRequest neutronDeleteSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteSecurityGroupRuleRequest.SecurityGroupRuleId, out var valueOfSecurityGroupRuleId)) urlParam.Add("security_group_rule_id", valueOfSecurityGroupRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSecurityGroupRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteSecurityGroupRuleResponse>(response);
        }

        public SyncInvoker<NeutronDeleteSecurityGroupRuleResponse> NeutronDeleteSecurityGroupRuleInvoker(NeutronDeleteSecurityGroupRuleRequest neutronDeleteSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteSecurityGroupRuleRequest.SecurityGroupRuleId, out var valueOfSecurityGroupRuleId)) urlParam.Add("security_group_rule_id", valueOfSecurityGroupRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSecurityGroupRuleRequest);
            return new SyncInvoker<NeutronDeleteSecurityGroupRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 删除子网
        ///
        /// 删除子网
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronDeleteSubnetResponse NeutronDeleteSubnet(NeutronDeleteSubnetRequest neutronDeleteSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteSubnetRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSubnetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteSubnetResponse>(response);
        }

        public SyncInvoker<NeutronDeleteSubnetResponse> NeutronDeleteSubnetInvoker(NeutronDeleteSubnetRequest neutronDeleteSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteSubnetRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSubnetRequest);
            return new SyncInvoker<NeutronDeleteSubnetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteSubnetResponse>);
        }
        
        /// <summary>
        /// 查询网络列表
        ///
        /// 查询提交请求的租户的所有网络，单次查询最多返回2000条数据，超过2000后会返回分页标记。分页查询请参考分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronListNetworksResponse NeutronListNetworks(NeutronListNetworksRequest neutronListNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListNetworksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronListNetworksResponse>(response);
        }

        public SyncInvoker<NeutronListNetworksResponse> NeutronListNetworksInvoker(NeutronListNetworksRequest neutronListNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListNetworksRequest);
            return new SyncInvoker<NeutronListNetworksResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListNetworksResponse>);
        }
        
        /// <summary>
        /// 查询端口列表
        ///
        /// 查询提交请求的租户的所有端口，单次查询最多返回2000条数据，超过2000后会返回分页标记。分页查询请参考分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronListPortsResponse NeutronListPorts(NeutronListPortsRequest neutronListPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListPortsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronListPortsResponse>(response);
        }

        public SyncInvoker<NeutronListPortsResponse> NeutronListPortsInvoker(NeutronListPortsRequest neutronListPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListPortsRequest);
            return new SyncInvoker<NeutronListPortsResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListPortsResponse>);
        }
        
        /// <summary>
        /// 查询路由器列表
        ///
        /// 查询提交请求的租户有权限操作的所有路由器信息，单次查询最多返回2000条数据，超过2000后会返回分页标记。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronListRoutersResponse NeutronListRouters(NeutronListRoutersRequest neutronListRoutersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListRoutersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronListRoutersResponse>(response);
        }

        public SyncInvoker<NeutronListRoutersResponse> NeutronListRoutersInvoker(NeutronListRoutersRequest neutronListRoutersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListRoutersRequest);
            return new SyncInvoker<NeutronListRoutersResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListRoutersResponse>);
        }
        
        /// <summary>
        /// 查询安全组规则列表
        ///
        /// 查询提交请求的租户有权限查看的所有安全组规则。单次查询最多返回2000条数据，超过2000后会返回分页标记。分页查询请参考分页查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronListSecurityGroupRulesResponse NeutronListSecurityGroupRules(NeutronListSecurityGroupRulesRequest neutronListSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSecurityGroupRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronListSecurityGroupRulesResponse>(response);
        }

        public SyncInvoker<NeutronListSecurityGroupRulesResponse> NeutronListSecurityGroupRulesInvoker(NeutronListSecurityGroupRulesRequest neutronListSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSecurityGroupRulesRequest);
            return new SyncInvoker<NeutronListSecurityGroupRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListSecurityGroupRulesResponse>);
        }
        
        /// <summary>
        /// 查询安全组列表
        ///
        /// 查询提交请求租户的所有安全组，单次查询最多返回2000条数据，超过2000后会返回分页标记。分页查询请参考分页查询 。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronListSecurityGroupsResponse NeutronListSecurityGroups(NeutronListSecurityGroupsRequest neutronListSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSecurityGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronListSecurityGroupsResponse>(response);
        }

        public SyncInvoker<NeutronListSecurityGroupsResponse> NeutronListSecurityGroupsInvoker(NeutronListSecurityGroupsRequest neutronListSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSecurityGroupsRequest);
            return new SyncInvoker<NeutronListSecurityGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListSecurityGroupsResponse>);
        }
        
        /// <summary>
        /// 查询子网列表
        ///
        /// 查询提交请求租户的所有子网，单次查询最多返回2000条数据，超过2000后会返回分页标记。分页查询请参考分页查询 。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronListSubnetsResponse NeutronListSubnets(NeutronListSubnetsRequest neutronListSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSubnetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronListSubnetsResponse>(response);
        }

        public SyncInvoker<NeutronListSubnetsResponse> NeutronListSubnetsInvoker(NeutronListSubnetsRequest neutronListSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSubnetsRequest);
            return new SyncInvoker<NeutronListSubnetsResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListSubnetsResponse>);
        }
        
        /// <summary>
        /// 路由器删除接口
        ///
        /// 删除路由器接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronRemoveRouterInterfaceResponse NeutronRemoveRouterInterface(NeutronRemoveRouterInterfaceRequest neutronRemoveRouterInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronRemoveRouterInterfaceRequest.RouterId, out var valueOfRouterId)) urlParam.Add("router_id", valueOfRouterId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}/remove_router_interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronRemoveRouterInterfaceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<NeutronRemoveRouterInterfaceResponse>(response);
        }

        public SyncInvoker<NeutronRemoveRouterInterfaceResponse> NeutronRemoveRouterInterfaceInvoker(NeutronRemoveRouterInterfaceRequest neutronRemoveRouterInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronRemoveRouterInterfaceRequest.RouterId, out var valueOfRouterId)) urlParam.Add("router_id", valueOfRouterId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}/remove_router_interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronRemoveRouterInterfaceRequest);
            return new SyncInvoker<NeutronRemoveRouterInterfaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronRemoveRouterInterfaceResponse>);
        }
        
        /// <summary>
        /// 查询网络
        ///
        /// 查询指定的网络详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronShowNetworkResponse NeutronShowNetwork(NeutronShowNetworkRequest neutronShowNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowNetworkRequest.NetworkId, out var valueOfNetworkId)) urlParam.Add("network_id", valueOfNetworkId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowNetworkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowNetworkResponse>(response);
        }

        public SyncInvoker<NeutronShowNetworkResponse> NeutronShowNetworkInvoker(NeutronShowNetworkRequest neutronShowNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowNetworkRequest.NetworkId, out var valueOfNetworkId)) urlParam.Add("network_id", valueOfNetworkId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowNetworkRequest);
            return new SyncInvoker<NeutronShowNetworkResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowNetworkResponse>);
        }
        
        /// <summary>
        /// 查询端口
        ///
        /// 查询端口详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronShowPortResponse NeutronShowPort(NeutronShowPortRequest neutronShowPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowPortRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowPortRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowPortResponse>(response);
        }

        public SyncInvoker<NeutronShowPortResponse> NeutronShowPortInvoker(NeutronShowPortRequest neutronShowPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowPortRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowPortRequest);
            return new SyncInvoker<NeutronShowPortResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowPortResponse>);
        }
        
        /// <summary>
        /// 查询路由器
        ///
        /// 查询路由器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronShowRouterResponse NeutronShowRouter(NeutronShowRouterRequest neutronShowRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowRouterRequest.RouterId, out var valueOfRouterId)) urlParam.Add("router_id", valueOfRouterId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowRouterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowRouterResponse>(response);
        }

        public SyncInvoker<NeutronShowRouterResponse> NeutronShowRouterInvoker(NeutronShowRouterRequest neutronShowRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowRouterRequest.RouterId, out var valueOfRouterId)) urlParam.Add("router_id", valueOfRouterId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowRouterRequest);
            return new SyncInvoker<NeutronShowRouterResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowRouterResponse>);
        }
        
        /// <summary>
        /// 查询安全组
        ///
        /// 查询安全组详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronShowSecurityGroupResponse NeutronShowSecurityGroup(NeutronShowSecurityGroupRequest neutronShowSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowSecurityGroupRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSecurityGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowSecurityGroupResponse>(response);
        }

        public SyncInvoker<NeutronShowSecurityGroupResponse> NeutronShowSecurityGroupInvoker(NeutronShowSecurityGroupRequest neutronShowSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowSecurityGroupRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSecurityGroupRequest);
            return new SyncInvoker<NeutronShowSecurityGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 查询安全组规则
        ///
        /// 查询安全组规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronShowSecurityGroupRuleResponse NeutronShowSecurityGroupRule(NeutronShowSecurityGroupRuleRequest neutronShowSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowSecurityGroupRuleRequest.SecurityGroupRuleId, out var valueOfSecurityGroupRuleId)) urlParam.Add("security_group_rule_id", valueOfSecurityGroupRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSecurityGroupRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowSecurityGroupRuleResponse>(response);
        }

        public SyncInvoker<NeutronShowSecurityGroupRuleResponse> NeutronShowSecurityGroupRuleInvoker(NeutronShowSecurityGroupRuleRequest neutronShowSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowSecurityGroupRuleRequest.SecurityGroupRuleId, out var valueOfSecurityGroupRuleId)) urlParam.Add("security_group_rule_id", valueOfSecurityGroupRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSecurityGroupRuleRequest);
            return new SyncInvoker<NeutronShowSecurityGroupRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 查询子网
        ///
        /// 查询子网详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronShowSubnetResponse NeutronShowSubnet(NeutronShowSubnetRequest neutronShowSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowSubnetRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSubnetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowSubnetResponse>(response);
        }

        public SyncInvoker<NeutronShowSubnetResponse> NeutronShowSubnetInvoker(NeutronShowSubnetRequest neutronShowSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowSubnetRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSubnetRequest);
            return new SyncInvoker<NeutronShowSubnetResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowSubnetResponse>);
        }
        
        /// <summary>
        /// 更新网络
        ///
        /// 更新网络
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronUpdateNetworkResponse NeutronUpdateNetwork(NeutronUpdateNetworkRequest neutronUpdateNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateNetworkRequest.NetworkId, out var valueOfNetworkId)) urlParam.Add("network_id", valueOfNetworkId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateNetworkRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateNetworkResponse>(response);
        }

        public SyncInvoker<NeutronUpdateNetworkResponse> NeutronUpdateNetworkInvoker(NeutronUpdateNetworkRequest neutronUpdateNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateNetworkRequest.NetworkId, out var valueOfNetworkId)) urlParam.Add("network_id", valueOfNetworkId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateNetworkRequest);
            return new SyncInvoker<NeutronUpdateNetworkResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateNetworkResponse>);
        }
        
        /// <summary>
        /// 更新端口
        ///
        /// 更新端口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronUpdatePortResponse NeutronUpdatePort(NeutronUpdatePortRequest neutronUpdatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdatePortRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdatePortRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdatePortResponse>(response);
        }

        public SyncInvoker<NeutronUpdatePortResponse> NeutronUpdatePortInvoker(NeutronUpdatePortRequest neutronUpdatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdatePortRequest.PortId, out var valueOfPortId)) urlParam.Add("port_id", valueOfPortId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdatePortRequest);
            return new SyncInvoker<NeutronUpdatePortResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdatePortResponse>);
        }
        
        /// <summary>
        /// 更新路由器
        ///
        /// 更新路由器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronUpdateRouterResponse NeutronUpdateRouter(NeutronUpdateRouterRequest neutronUpdateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateRouterRequest.RouterId, out var valueOfRouterId)) urlParam.Add("router_id", valueOfRouterId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateRouterRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateRouterResponse>(response);
        }

        public SyncInvoker<NeutronUpdateRouterResponse> NeutronUpdateRouterInvoker(NeutronUpdateRouterRequest neutronUpdateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateRouterRequest.RouterId, out var valueOfRouterId)) urlParam.Add("router_id", valueOfRouterId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateRouterRequest);
            return new SyncInvoker<NeutronUpdateRouterResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateRouterResponse>);
        }
        
        /// <summary>
        /// 更新安全组
        ///
        /// 更新安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronUpdateSecurityGroupResponse NeutronUpdateSecurityGroup(NeutronUpdateSecurityGroupRequest neutronUpdateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateSecurityGroupRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateSecurityGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateSecurityGroupResponse>(response);
        }

        public SyncInvoker<NeutronUpdateSecurityGroupResponse> NeutronUpdateSecurityGroupInvoker(NeutronUpdateSecurityGroupRequest neutronUpdateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateSecurityGroupRequest.SecurityGroupId, out var valueOfSecurityGroupId)) urlParam.Add("security_group_id", valueOfSecurityGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateSecurityGroupRequest);
            return new SyncInvoker<NeutronUpdateSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 更新子网
        ///
        /// 更新子网
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronUpdateSubnetResponse NeutronUpdateSubnet(NeutronUpdateSubnetRequest neutronUpdateSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateSubnetRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateSubnetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateSubnetResponse>(response);
        }

        public SyncInvoker<NeutronUpdateSubnetResponse> NeutronUpdateSubnetInvoker(NeutronUpdateSubnetRequest neutronUpdateSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateSubnetRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateSubnetRequest);
            return new SyncInvoker<NeutronUpdateSubnetResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateSubnetResponse>);
        }
        
        /// <summary>
        /// 插入网络ACL规则
        ///
        /// 插入一条网络ACL规则到某一网络ACL策略中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronAddFirewallRuleResponse NeutronAddFirewallRule(NeutronAddFirewallRuleRequest neutronAddFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronAddFirewallRuleRequest.FirewallPolicyId, out var valueOfFirewallPolicyId)) urlParam.Add("firewall_policy_id", valueOfFirewallPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}/insert_rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronAddFirewallRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<NeutronAddFirewallRuleResponse>(response);
        }

        public SyncInvoker<NeutronAddFirewallRuleResponse> NeutronAddFirewallRuleInvoker(NeutronAddFirewallRuleRequest neutronAddFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronAddFirewallRuleRequest.FirewallPolicyId, out var valueOfFirewallPolicyId)) urlParam.Add("firewall_policy_id", valueOfFirewallPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}/insert_rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronAddFirewallRuleRequest);
            return new SyncInvoker<NeutronAddFirewallRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronAddFirewallRuleResponse>);
        }
        
        /// <summary>
        /// 创建网络ACL组
        ///
        /// 创建网络ACL组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronCreateFirewallGroupResponse NeutronCreateFirewallGroup(NeutronCreateFirewallGroupRequest neutronCreateFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateFirewallGroupResponse>(response);
        }

        public SyncInvoker<NeutronCreateFirewallGroupResponse> NeutronCreateFirewallGroupInvoker(NeutronCreateFirewallGroupRequest neutronCreateFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallGroupRequest);
            return new SyncInvoker<NeutronCreateFirewallGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateFirewallGroupResponse>);
        }
        
        /// <summary>
        /// 创建网络ACL策略
        ///
        /// 创建网络ACL策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronCreateFirewallPolicyResponse NeutronCreateFirewallPolicy(NeutronCreateFirewallPolicyRequest neutronCreateFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateFirewallPolicyResponse>(response);
        }

        public SyncInvoker<NeutronCreateFirewallPolicyResponse> NeutronCreateFirewallPolicyInvoker(NeutronCreateFirewallPolicyRequest neutronCreateFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallPolicyRequest);
            return new SyncInvoker<NeutronCreateFirewallPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateFirewallPolicyResponse>);
        }
        
        /// <summary>
        /// 创建网络ACL规则
        ///
        /// 创建网络ACL规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronCreateFirewallRuleResponse NeutronCreateFirewallRule(NeutronCreateFirewallRuleRequest neutronCreateFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateFirewallRuleResponse>(response);
        }

        public SyncInvoker<NeutronCreateFirewallRuleResponse> NeutronCreateFirewallRuleInvoker(NeutronCreateFirewallRuleRequest neutronCreateFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallRuleRequest);
            return new SyncInvoker<NeutronCreateFirewallRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateFirewallRuleResponse>);
        }
        
        /// <summary>
        /// 删除网络ACL组
        ///
        /// 删除网络ACL组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronDeleteFirewallGroupResponse NeutronDeleteFirewallGroup(NeutronDeleteFirewallGroupRequest neutronDeleteFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteFirewallGroupRequest.FirewallGroupId, out var valueOfFirewallGroupId)) urlParam.Add("firewall_group_id", valueOfFirewallGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFirewallGroupResponse>(response);
        }

        public SyncInvoker<NeutronDeleteFirewallGroupResponse> NeutronDeleteFirewallGroupInvoker(NeutronDeleteFirewallGroupRequest neutronDeleteFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteFirewallGroupRequest.FirewallGroupId, out var valueOfFirewallGroupId)) urlParam.Add("firewall_group_id", valueOfFirewallGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallGroupRequest);
            return new SyncInvoker<NeutronDeleteFirewallGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteFirewallGroupResponse>);
        }
        
        /// <summary>
        /// 删除网络ACL策略
        ///
        /// 删除网络ACL策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronDeleteFirewallPolicyResponse NeutronDeleteFirewallPolicy(NeutronDeleteFirewallPolicyRequest neutronDeleteFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteFirewallPolicyRequest.FirewallPolicyId, out var valueOfFirewallPolicyId)) urlParam.Add("firewall_policy_id", valueOfFirewallPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFirewallPolicyResponse>(response);
        }

        public SyncInvoker<NeutronDeleteFirewallPolicyResponse> NeutronDeleteFirewallPolicyInvoker(NeutronDeleteFirewallPolicyRequest neutronDeleteFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteFirewallPolicyRequest.FirewallPolicyId, out var valueOfFirewallPolicyId)) urlParam.Add("firewall_policy_id", valueOfFirewallPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallPolicyRequest);
            return new SyncInvoker<NeutronDeleteFirewallPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteFirewallPolicyResponse>);
        }
        
        /// <summary>
        /// 删除网络ACL规则
        ///
        /// 删除网络ACL规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronDeleteFirewallRuleResponse NeutronDeleteFirewallRule(NeutronDeleteFirewallRuleRequest neutronDeleteFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteFirewallRuleRequest.FirewallRuleId, out var valueOfFirewallRuleId)) urlParam.Add("firewall_rule_id", valueOfFirewallRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFirewallRuleResponse>(response);
        }

        public SyncInvoker<NeutronDeleteFirewallRuleResponse> NeutronDeleteFirewallRuleInvoker(NeutronDeleteFirewallRuleRequest neutronDeleteFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronDeleteFirewallRuleRequest.FirewallRuleId, out var valueOfFirewallRuleId)) urlParam.Add("firewall_rule_id", valueOfFirewallRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallRuleRequest);
            return new SyncInvoker<NeutronDeleteFirewallRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteFirewallRuleResponse>);
        }
        
        /// <summary>
        /// 查询所有网络ACL组
        ///
        /// 查询提交请求的租户有权限操作的所有网络ACL组信息。单次查询最多返回2000条数据，超过2000后会返回分页标记。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronListFirewallGroupsResponse NeutronListFirewallGroups(NeutronListFirewallGroupsRequest neutronListFirewallGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronListFirewallGroupsResponse>(response);
        }

        public SyncInvoker<NeutronListFirewallGroupsResponse> NeutronListFirewallGroupsInvoker(NeutronListFirewallGroupsRequest neutronListFirewallGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallGroupsRequest);
            return new SyncInvoker<NeutronListFirewallGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListFirewallGroupsResponse>);
        }
        
        /// <summary>
        /// 查询所有网络ACL策略
        ///
        /// 查询提交请求的租户有权限操作的所有网络ACL策略信息。单次查询最多返回2000条数据，超过2000后会返回分页标记。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronListFirewallPoliciesResponse NeutronListFirewallPolicies(NeutronListFirewallPoliciesRequest neutronListFirewallPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallPoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronListFirewallPoliciesResponse>(response);
        }

        public SyncInvoker<NeutronListFirewallPoliciesResponse> NeutronListFirewallPoliciesInvoker(NeutronListFirewallPoliciesRequest neutronListFirewallPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallPoliciesRequest);
            return new SyncInvoker<NeutronListFirewallPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListFirewallPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询所有网络ACL规则
        ///
        /// 查询提交请求的租户有权限操作的所有网络ACL规则信息。单次查询最多返回2000条数据，超过2000后会返回分页标记。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronListFirewallRulesResponse NeutronListFirewallRules(NeutronListFirewallRulesRequest neutronListFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronListFirewallRulesResponse>(response);
        }

        public SyncInvoker<NeutronListFirewallRulesResponse> NeutronListFirewallRulesInvoker(NeutronListFirewallRulesRequest neutronListFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallRulesRequest);
            return new SyncInvoker<NeutronListFirewallRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListFirewallRulesResponse>);
        }
        
        /// <summary>
        /// 移除网络ACL规则
        ///
        /// 从某一网络ACL策略中移除一条网络ACL规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronRemoveFirewallRuleResponse NeutronRemoveFirewallRule(NeutronRemoveFirewallRuleRequest neutronRemoveFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronRemoveFirewallRuleRequest.FirewallPolicyId, out var valueOfFirewallPolicyId)) urlParam.Add("firewall_policy_id", valueOfFirewallPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}/remove_rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronRemoveFirewallRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<NeutronRemoveFirewallRuleResponse>(response);
        }

        public SyncInvoker<NeutronRemoveFirewallRuleResponse> NeutronRemoveFirewallRuleInvoker(NeutronRemoveFirewallRuleRequest neutronRemoveFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronRemoveFirewallRuleRequest.FirewallPolicyId, out var valueOfFirewallPolicyId)) urlParam.Add("firewall_policy_id", valueOfFirewallPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}/remove_rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronRemoveFirewallRuleRequest);
            return new SyncInvoker<NeutronRemoveFirewallRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronRemoveFirewallRuleResponse>);
        }
        
        /// <summary>
        /// 查询特定网络ACL组详情
        ///
        /// 查询特定网络ACL组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronShowFirewallGroupResponse NeutronShowFirewallGroup(NeutronShowFirewallGroupRequest neutronShowFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowFirewallGroupRequest.FirewallGroupId, out var valueOfFirewallGroupId)) urlParam.Add("firewall_group_id", valueOfFirewallGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowFirewallGroupResponse>(response);
        }

        public SyncInvoker<NeutronShowFirewallGroupResponse> NeutronShowFirewallGroupInvoker(NeutronShowFirewallGroupRequest neutronShowFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowFirewallGroupRequest.FirewallGroupId, out var valueOfFirewallGroupId)) urlParam.Add("firewall_group_id", valueOfFirewallGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallGroupRequest);
            return new SyncInvoker<NeutronShowFirewallGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowFirewallGroupResponse>);
        }
        
        /// <summary>
        /// 查询特定网络ACL策略详情
        ///
        /// 查询特定网络ACL策略详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronShowFirewallPolicyResponse NeutronShowFirewallPolicy(NeutronShowFirewallPolicyRequest neutronShowFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowFirewallPolicyRequest.FirewallPolicyId, out var valueOfFirewallPolicyId)) urlParam.Add("firewall_policy_id", valueOfFirewallPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowFirewallPolicyResponse>(response);
        }

        public SyncInvoker<NeutronShowFirewallPolicyResponse> NeutronShowFirewallPolicyInvoker(NeutronShowFirewallPolicyRequest neutronShowFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowFirewallPolicyRequest.FirewallPolicyId, out var valueOfFirewallPolicyId)) urlParam.Add("firewall_policy_id", valueOfFirewallPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallPolicyRequest);
            return new SyncInvoker<NeutronShowFirewallPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowFirewallPolicyResponse>);
        }
        
        /// <summary>
        /// 查询特定网络ACL规则
        ///
        /// 查询特定网络ACL规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronShowFirewallRuleResponse NeutronShowFirewallRule(NeutronShowFirewallRuleRequest neutronShowFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowFirewallRuleRequest.FirewallRuleId, out var valueOfFirewallRuleId)) urlParam.Add("firewall_rule_id", valueOfFirewallRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowFirewallRuleResponse>(response);
        }

        public SyncInvoker<NeutronShowFirewallRuleResponse> NeutronShowFirewallRuleInvoker(NeutronShowFirewallRuleRequest neutronShowFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronShowFirewallRuleRequest.FirewallRuleId, out var valueOfFirewallRuleId)) urlParam.Add("firewall_rule_id", valueOfFirewallRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallRuleRequest);
            return new SyncInvoker<NeutronShowFirewallRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowFirewallRuleResponse>);
        }
        
        /// <summary>
        /// 更新网络ACL组
        ///
        /// 更新网络ACL组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronUpdateFirewallGroupResponse NeutronUpdateFirewallGroup(NeutronUpdateFirewallGroupRequest neutronUpdateFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateFirewallGroupRequest.FirewallGroupId, out var valueOfFirewallGroupId)) urlParam.Add("firewall_group_id", valueOfFirewallGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateFirewallGroupResponse>(response);
        }

        public SyncInvoker<NeutronUpdateFirewallGroupResponse> NeutronUpdateFirewallGroupInvoker(NeutronUpdateFirewallGroupRequest neutronUpdateFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateFirewallGroupRequest.FirewallGroupId, out var valueOfFirewallGroupId)) urlParam.Add("firewall_group_id", valueOfFirewallGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallGroupRequest);
            return new SyncInvoker<NeutronUpdateFirewallGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateFirewallGroupResponse>);
        }
        
        /// <summary>
        /// 更新网络ACL策略
        ///
        /// 更新网络ACL策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronUpdateFirewallPolicyResponse NeutronUpdateFirewallPolicy(NeutronUpdateFirewallPolicyRequest neutronUpdateFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateFirewallPolicyRequest.FirewallPolicyId, out var valueOfFirewallPolicyId)) urlParam.Add("firewall_policy_id", valueOfFirewallPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateFirewallPolicyResponse>(response);
        }

        public SyncInvoker<NeutronUpdateFirewallPolicyResponse> NeutronUpdateFirewallPolicyInvoker(NeutronUpdateFirewallPolicyRequest neutronUpdateFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateFirewallPolicyRequest.FirewallPolicyId, out var valueOfFirewallPolicyId)) urlParam.Add("firewall_policy_id", valueOfFirewallPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallPolicyRequest);
            return new SyncInvoker<NeutronUpdateFirewallPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateFirewallPolicyResponse>);
        }
        
        /// <summary>
        /// 更新网络ACL规则
        ///
        /// 更新网络ACL规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NeutronUpdateFirewallRuleResponse NeutronUpdateFirewallRule(NeutronUpdateFirewallRuleRequest neutronUpdateFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateFirewallRuleRequest.FirewallRuleId, out var valueOfFirewallRuleId)) urlParam.Add("firewall_rule_id", valueOfFirewallRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateFirewallRuleResponse>(response);
        }

        public SyncInvoker<NeutronUpdateFirewallRuleResponse> NeutronUpdateFirewallRuleInvoker(NeutronUpdateFirewallRuleRequest neutronUpdateFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(neutronUpdateFirewallRuleRequest.FirewallRuleId, out var valueOfFirewallRuleId)) urlParam.Add("firewall_rule_id", valueOfFirewallRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallRuleRequest);
            return new SyncInvoker<NeutronUpdateFirewallRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateFirewallRuleResponse>);
        }
        
        /// <summary>
        /// 查询API版本信息列表
        ///
        /// 返回当前API所有可用的版本（仅针对OpenStack原生接口）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApiVersionResponse ListApiVersion(ListApiVersionRequest listApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionResponse>(response);
        }

        public SyncInvoker<ListApiVersionResponse> ListApiVersionInvoker(ListApiVersionRequest listApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            return new SyncInvoker<ListApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionResponse>);
        }
        
        /// <summary>
        /// 批量创建VPC资源标签
        ///
        /// 为指定的VPC资源实例批量添加标签。
        /// 此接口为幂等接口：创建时如果请求体中存在重复key则报错。创建时，不允许设置重复key数据，如果数据库已存在该key，就覆盖value的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateVpcTagsResponse BatchCreateVpcTags(BatchCreateVpcTagsRequest batchCreateVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateVpcTagsRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateVpcTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateVpcTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateVpcTagsResponse> BatchCreateVpcTagsInvoker(BatchCreateVpcTagsRequest batchCreateVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateVpcTagsRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateVpcTagsRequest);
            return new SyncInvoker<BatchCreateVpcTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateVpcTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除VPC资源标签
        ///
        /// 为指定的VPC资源实例批量删除标签。
        /// 此接口为幂等接口：删除时，如果删除的标签不存在，默认处理成功；删除时不对标签字符集范围做校验。删除时tags结构体不能缺失，key不能为空，或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteVpcTagsResponse BatchDeleteVpcTags(BatchDeleteVpcTagsRequest batchDeleteVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteVpcTagsRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteVpcTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteVpcTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteVpcTagsResponse> BatchDeleteVpcTagsInvoker(BatchDeleteVpcTagsRequest batchDeleteVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteVpcTagsRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteVpcTagsRequest);
            return new SyncInvoker<BatchDeleteVpcTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteVpcTagsResponse>);
        }
        
        /// <summary>
        /// 创建VPC
        ///
        /// 创建虚拟私有云。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVpcResponse CreateVpc(CreateVpcRequest createVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateVpcResponse>(response);
        }

        public SyncInvoker<CreateVpcResponse> CreateVpcInvoker(CreateVpcRequest createVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcRequest);
            return new SyncInvoker<CreateVpcResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVpcResponse>);
        }
        
        /// <summary>
        /// 创建VPC资源标签
        ///
        /// 给指定VPC资源实例增加标签信息
        /// 此接口为幂等接口：创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVpcResourceTagResponse CreateVpcResourceTag(CreateVpcResourceTagRequest createVpcResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createVpcResourceTagRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcResourceTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateVpcResourceTagResponse>(response);
        }

        public SyncInvoker<CreateVpcResourceTagResponse> CreateVpcResourceTagInvoker(CreateVpcResourceTagRequest createVpcResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createVpcResourceTagRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcResourceTagRequest);
            return new SyncInvoker<CreateVpcResourceTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateVpcResourceTagResponse>);
        }
        
        /// <summary>
        /// 创建VPC路由
        ///
        /// 创建路由
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVpcRouteResponse CreateVpcRoute(CreateVpcRouteRequest createVpcRouteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcRouteRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateVpcRouteResponse>(response);
        }

        public SyncInvoker<CreateVpcRouteResponse> CreateVpcRouteInvoker(CreateVpcRouteRequest createVpcRouteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcRouteRequest);
            return new SyncInvoker<CreateVpcRouteResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVpcRouteResponse>);
        }
        
        /// <summary>
        /// 删除VPC
        ///
        /// 删除虚拟私有云。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVpcResponse DeleteVpc(DeleteVpcRequest deleteVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteVpcRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVpcResponse>(response);
        }

        public SyncInvoker<DeleteVpcResponse> DeleteVpcInvoker(DeleteVpcRequest deleteVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteVpcRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRequest);
            return new SyncInvoker<DeleteVpcResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVpcResponse>);
        }
        
        /// <summary>
        /// 删除VPC路由
        ///
        /// 删除路由
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVpcRouteResponse DeleteVpcRoute(DeleteVpcRouteRequest deleteVpcRouteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteVpcRouteRequest.RouteId, out var valueOfRouteId)) urlParam.Add("route_id", valueOfRouteId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes/{route_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRouteRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVpcRouteResponse>(response);
        }

        public SyncInvoker<DeleteVpcRouteResponse> DeleteVpcRouteInvoker(DeleteVpcRouteRequest deleteVpcRouteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteVpcRouteRequest.RouteId, out var valueOfRouteId)) urlParam.Add("route_id", valueOfRouteId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes/{route_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRouteRequest);
            return new SyncInvoker<DeleteVpcRouteResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVpcRouteResponse>);
        }
        
        /// <summary>
        /// 删除VPC资源标签
        ///
        /// 删除指定VPC资源实例的标签信息
        /// 该接口为幂等接口：删除的key不存在报404，Key不能为空或者空字符串
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVpcTagResponse DeleteVpcTag(DeleteVpcTagRequest deleteVpcTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteVpcTagRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            if (StringUtils.TryConvertToNonEmptyString(deleteVpcTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVpcTagResponse>(response);
        }

        public SyncInvoker<DeleteVpcTagResponse> DeleteVpcTagInvoker(DeleteVpcTagRequest deleteVpcTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteVpcTagRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            if (StringUtils.TryConvertToNonEmptyString(deleteVpcTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcTagRequest);
            return new SyncInvoker<DeleteVpcTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVpcTagResponse>);
        }
        
        /// <summary>
        /// 查询VPC路由列表
        ///
        /// 查询提交请求的租户的所有路由列表，并根据过滤条件进行过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVpcRoutesResponse ListVpcRoutes(ListVpcRoutesRequest listVpcRoutesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcRoutesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVpcRoutesResponse>(response);
        }

        public SyncInvoker<ListVpcRoutesResponse> ListVpcRoutesInvoker(ListVpcRoutesRequest listVpcRoutesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcRoutesRequest);
            return new SyncInvoker<ListVpcRoutesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVpcRoutesResponse>);
        }
        
        /// <summary>
        /// 查询VPC项目标签
        ///
        /// 查询租户在指定区域和实例类型的所有标签集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVpcTagsResponse ListVpcTags(ListVpcTagsRequest listVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVpcTagsResponse>(response);
        }

        public SyncInvoker<ListVpcTagsResponse> ListVpcTagsInvoker(ListVpcTagsRequest listVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcTagsRequest);
            return new SyncInvoker<ListVpcTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVpcTagsResponse>);
        }
        
        /// <summary>
        /// 查询VPC列表
        ///
        /// 查询虚拟私有云列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVpcsResponse ListVpcs(ListVpcsRequest listVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVpcsResponse>(response);
        }

        public SyncInvoker<ListVpcsResponse> ListVpcsInvoker(ListVpcsRequest listVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcsRequest);
            return new SyncInvoker<ListVpcsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVpcsResponse>);
        }
        
        /// <summary>
        /// 查询VPC资源实例
        ///
        /// 使用标签过滤实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVpcsByTagsResponse ListVpcsByTags(ListVpcsByTagsRequest listVpcsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listVpcsByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListVpcsByTagsResponse>(response);
        }

        public SyncInvoker<ListVpcsByTagsResponse> ListVpcsByTagsInvoker(ListVpcsByTagsRequest listVpcsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listVpcsByTagsRequest);
            return new SyncInvoker<ListVpcsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListVpcsByTagsResponse>);
        }
        
        /// <summary>
        /// 查询VPC
        ///
        /// 查询虚拟私有云。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVpcResponse ShowVpc(ShowVpcRequest showVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVpcRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVpcResponse>(response);
        }

        public SyncInvoker<ShowVpcResponse> ShowVpcInvoker(ShowVpcRequest showVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVpcRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRequest);
            return new SyncInvoker<ShowVpcResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVpcResponse>);
        }
        
        /// <summary>
        /// 查询VPC路由
        ///
        /// 查询路由详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVpcRouteResponse ShowVpcRoute(ShowVpcRouteRequest showVpcRouteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVpcRouteRequest.RouteId, out var valueOfRouteId)) urlParam.Add("route_id", valueOfRouteId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes/{route_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRouteRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVpcRouteResponse>(response);
        }

        public SyncInvoker<ShowVpcRouteResponse> ShowVpcRouteInvoker(ShowVpcRouteRequest showVpcRouteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVpcRouteRequest.RouteId, out var valueOfRouteId)) urlParam.Add("route_id", valueOfRouteId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes/{route_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRouteRequest);
            return new SyncInvoker<ShowVpcRouteResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVpcRouteResponse>);
        }
        
        /// <summary>
        /// 查询VPC资源标签
        ///
        /// 查询指定VPC实例的标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVpcTagsResponse ShowVpcTags(ShowVpcTagsRequest showVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVpcTagsRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVpcTagsResponse>(response);
        }

        public SyncInvoker<ShowVpcTagsResponse> ShowVpcTagsInvoker(ShowVpcTagsRequest showVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVpcTagsRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcTagsRequest);
            return new SyncInvoker<ShowVpcTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVpcTagsResponse>);
        }
        
        /// <summary>
        /// 更新VPC
        ///
        /// 更新虚拟私有云。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateVpcResponse UpdateVpc(UpdateVpcRequest updateVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateVpcRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVpcRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVpcResponse>(response);
        }

        public SyncInvoker<UpdateVpcResponse> UpdateVpcInvoker(UpdateVpcRequest updateVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateVpcRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVpcRequest);
            return new SyncInvoker<UpdateVpcResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVpcResponse>);
        }
        
    }
}