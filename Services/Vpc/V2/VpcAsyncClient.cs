using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace HuaweiCloud.SDK.Vpc.V2
{
    public partial class VpcAsyncClient : Client
    {
        public static ClientBuilder<VpcAsyncClient> NewBuilder()
        {
            return new ClientBuilder<VpcAsyncClient>();
        }

        
        /// <summary>
        /// 接受对等连接请求
        ///
        /// 租户A名下的VPC申请和租户B的VPC建立对等连接，需要等待租户B接受该请求。此接口用于租户接受其他租户发起的对等连接请求。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AcceptVpcPeeringResponse> AcceptVpcPeeringAsync(AcceptVpcPeeringRequest acceptVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id", acceptVpcPeeringRequest.PeeringId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptVpcPeeringRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<AcceptVpcPeeringResponse>(response);
        }

        public AsyncInvoker<AcceptVpcPeeringResponse> AcceptVpcPeeringAsyncInvoker(AcceptVpcPeeringRequest acceptVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id", acceptVpcPeeringRequest.PeeringId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptVpcPeeringRequest);
            return new AsyncInvoker<AcceptVpcPeeringResponse>(this, "PUT", request, JsonUtils.DeSerialize<AcceptVpcPeeringResponse>);
        }
        
        /// <summary>
        /// 子网关联路由表
        ///
        /// 路由表关联子网。子网关联路由表A后，再关联B，不需要先跟路由表A解关联再关联路由表B
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateRouteTableResponse> AssociateRouteTableAsync(AssociateRouteTableRequest associateRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id", associateRouteTableRequest.RoutetableId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateRouteTableRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateRouteTableResponse>(response);
        }

        public AsyncInvoker<AssociateRouteTableResponse> AssociateRouteTableAsyncInvoker(AssociateRouteTableRequest associateRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id", associateRouteTableRequest.RoutetableId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateRouteTableRequest);
            return new AsyncInvoker<AssociateRouteTableResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateRouteTableResponse>);
        }
        
        /// <summary>
        /// 批量创建安全组资源标签
        ///
        /// 为指定的安全组资源实例批量添加标签。
        /// 此接口为幂等接口：创建时如果请求体中存在重复key则报错。创建时，不允许设置重复key数据，如果数据库已存在该key，就覆盖value的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateSecurityGroupTagsResponse> BatchCreateSecurityGroupTagsAsync(BatchCreateSecurityGroupTagsRequest batchCreateSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", batchCreateSecurityGroupTagsRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSecurityGroupTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateSecurityGroupTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateSecurityGroupTagsResponse> BatchCreateSecurityGroupTagsAsyncInvoker(BatchCreateSecurityGroupTagsRequest batchCreateSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", batchCreateSecurityGroupTagsRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSecurityGroupTagsRequest);
            return new AsyncInvoker<BatchCreateSecurityGroupTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateSecurityGroupTagsResponse>);
        }
        
        /// <summary>
        /// 批量创建子网资源标签
        ///
        /// 为指定的子网资源实例批量添加标签。
        /// 此接口为幂等接口：创建时如果请求体中存在重复key则报错。创建时，不允许设置重复key数据，如果数据库已存在该key，就覆盖value的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateSubnetTagsResponse> BatchCreateSubnetTagsAsync(BatchCreateSubnetTagsRequest batchCreateSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", batchCreateSubnetTagsRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSubnetTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateSubnetTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateSubnetTagsResponse> BatchCreateSubnetTagsAsyncInvoker(BatchCreateSubnetTagsRequest batchCreateSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", batchCreateSubnetTagsRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSubnetTagsRequest);
            return new AsyncInvoker<BatchCreateSubnetTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateSubnetTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除安全组资源标签
        ///
        /// 为指定的安全组资源实例批量删除标签
        /// 此接口为幂等接口：删除时，如果删除的标签不存在，默认处理成功；删除时不对标签字符集范围做校验。删除时tags结构体不能缺失，key不能为空，或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteSecurityGroupTagsResponse> BatchDeleteSecurityGroupTagsAsync(BatchDeleteSecurityGroupTagsRequest batchDeleteSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", batchDeleteSecurityGroupTagsRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSecurityGroupTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteSecurityGroupTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteSecurityGroupTagsResponse> BatchDeleteSecurityGroupTagsAsyncInvoker(BatchDeleteSecurityGroupTagsRequest batchDeleteSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", batchDeleteSecurityGroupTagsRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSecurityGroupTagsRequest);
            return new AsyncInvoker<BatchDeleteSecurityGroupTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteSecurityGroupTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除子网资源标签
        ///
        /// 为指定的子网资源实例批量删除标签
        /// 此接口为幂等接口：删除时，如果删除的标签不存在，默认处理成功；删除时不对标签字符集范围做校验。删除时tags结构体不能缺失，key不能为空，或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteSubnetTagsResponse> BatchDeleteSubnetTagsAsync(BatchDeleteSubnetTagsRequest batchDeleteSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", batchDeleteSubnetTagsRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSubnetTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteSubnetTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteSubnetTagsResponse> BatchDeleteSubnetTagsAsyncInvoker(BatchDeleteSubnetTagsRequest batchDeleteSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", batchDeleteSubnetTagsRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSubnetTagsRequest);
            return new AsyncInvoker<BatchDeleteSubnetTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteSubnetTagsResponse>);
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
        public async Task<CreateFlowLogResponse> CreateFlowLogAsync(CreateFlowLogRequest createFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createFlowLogRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateFlowLogResponse>(response);
        }

        public AsyncInvoker<CreateFlowLogResponse> CreateFlowLogAsyncInvoker(CreateFlowLogRequest createFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createFlowLogRequest);
            return new AsyncInvoker<CreateFlowLogResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFlowLogResponse>);
        }
        
        /// <summary>
        /// 创建端口
        ///
        /// 创建端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePortResponse> CreatePortAsync(CreatePortRequest createPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPortRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePortResponse>(response);
        }

        public AsyncInvoker<CreatePortResponse> CreatePortAsyncInvoker(CreatePortRequest createPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPortRequest);
            return new AsyncInvoker<CreatePortResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePortResponse>);
        }
        
        /// <summary>
        /// 创建路由表
        ///
        /// 创建路由表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRouteTableResponse> CreateRouteTableAsync(CreateRouteTableRequest createRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRouteTableRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRouteTableResponse>(response);
        }

        public AsyncInvoker<CreateRouteTableResponse> CreateRouteTableAsyncInvoker(CreateRouteTableRequest createRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRouteTableRequest);
            return new AsyncInvoker<CreateRouteTableResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRouteTableResponse>);
        }
        
        /// <summary>
        /// 创建安全组
        ///
        /// 创建安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest createSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSecurityGroupResponse>(response);
        }

        public AsyncInvoker<CreateSecurityGroupResponse> CreateSecurityGroupAsyncInvoker(CreateSecurityGroupRequest createSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupRequest);
            return new AsyncInvoker<CreateSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 创建安全组规则
        ///
        /// 创建安全组规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSecurityGroupRuleResponse> CreateSecurityGroupRuleAsync(CreateSecurityGroupRuleRequest createSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSecurityGroupRuleResponse>(response);
        }

        public AsyncInvoker<CreateSecurityGroupRuleResponse> CreateSecurityGroupRuleAsyncInvoker(CreateSecurityGroupRuleRequest createSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupRuleRequest);
            return new AsyncInvoker<CreateSecurityGroupRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 创建安全组资源标签
        ///
        /// 给指定安全组资源实例增加标签信息。
        /// 此接口为幂等接口：创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSecurityGroupTagResponse> CreateSecurityGroupTagAsync(CreateSecurityGroupTagRequest createSecurityGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", createSecurityGroupTagRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSecurityGroupTagResponse>(response);
        }

        public AsyncInvoker<CreateSecurityGroupTagResponse> CreateSecurityGroupTagAsyncInvoker(CreateSecurityGroupTagRequest createSecurityGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", createSecurityGroupTagRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupTagRequest);
            return new AsyncInvoker<CreateSecurityGroupTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSecurityGroupTagResponse>);
        }
        
        /// <summary>
        /// 创建子网
        ///
        /// 创建子网。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSubnetResponse> CreateSubnetAsync(CreateSubnetRequest createSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubnetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSubnetResponse>(response);
        }

        public AsyncInvoker<CreateSubnetResponse> CreateSubnetAsyncInvoker(CreateSubnetRequest createSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubnetRequest);
            return new AsyncInvoker<CreateSubnetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSubnetResponse>);
        }
        
        /// <summary>
        /// 创建子网资源标签
        ///
        /// 给指定子网资源实例增加标签信息。
        /// 此接口为幂等接口：创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSubnetTagResponse> CreateSubnetTagAsync(CreateSubnetTagRequest createSubnetTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", createSubnetTagRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubnetTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSubnetTagResponse>(response);
        }

        public AsyncInvoker<CreateSubnetTagResponse> CreateSubnetTagAsyncInvoker(CreateSubnetTagRequest createSubnetTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", createSubnetTagRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubnetTagRequest);
            return new AsyncInvoker<CreateSubnetTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSubnetTagResponse>);
        }
        
        /// <summary>
        /// 创建对等连接
        ///
        /// 创建对等连接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVpcPeeringResponse> CreateVpcPeeringAsync(CreateVpcPeeringRequest createVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcPeeringRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateVpcPeeringResponse>(response);
        }

        public AsyncInvoker<CreateVpcPeeringResponse> CreateVpcPeeringAsyncInvoker(CreateVpcPeeringRequest createVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcPeeringRequest);
            return new AsyncInvoker<CreateVpcPeeringResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVpcPeeringResponse>);
        }
        
        /// <summary>
        /// 删除流日志
        ///
        /// 删除流日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFlowLogResponse> DeleteFlowLogAsync(DeleteFlowLogRequest deleteFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("flowlog_id", deleteFlowLogRequest.FlowlogId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs/{flowlog_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFlowLogRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteFlowLogResponse>(response);
        }

        public AsyncInvoker<DeleteFlowLogResponse> DeleteFlowLogAsyncInvoker(DeleteFlowLogRequest deleteFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("flowlog_id", deleteFlowLogRequest.FlowlogId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs/{flowlog_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFlowLogRequest);
            return new AsyncInvoker<DeleteFlowLogResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFlowLogResponse>);
        }
        
        /// <summary>
        /// 删除端口
        ///
        /// 删除端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePortResponse> DeletePortAsync(DeletePortRequest deletePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", deletePortRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePortRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePortResponse>(response);
        }

        public AsyncInvoker<DeletePortResponse> DeletePortAsyncInvoker(DeletePortRequest deletePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", deletePortRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePortRequest);
            return new AsyncInvoker<DeletePortResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePortResponse>);
        }
        
        /// <summary>
        /// 删除路由表
        ///
        /// 删除路由表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRouteTableResponse> DeleteRouteTableAsync(DeleteRouteTableRequest deleteRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id", deleteRouteTableRequest.RoutetableId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRouteTableRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRouteTableResponse>(response);
        }

        public AsyncInvoker<DeleteRouteTableResponse> DeleteRouteTableAsyncInvoker(DeleteRouteTableRequest deleteRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id", deleteRouteTableRequest.RoutetableId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRouteTableRequest);
            return new AsyncInvoker<DeleteRouteTableResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRouteTableResponse>);
        }
        
        /// <summary>
        /// 删除安全组
        ///
        /// 删除安全组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest deleteSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", deleteSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupResponse>(response);
        }

        public AsyncInvoker<DeleteSecurityGroupResponse> DeleteSecurityGroupAsyncInvoker(DeleteSecurityGroupRequest deleteSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", deleteSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRequest);
            return new AsyncInvoker<DeleteSecurityGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 删除安全组规则
        ///
        /// 删除安全组规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSecurityGroupRuleResponse> DeleteSecurityGroupRuleAsync(DeleteSecurityGroupRuleRequest deleteSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", deleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupRuleResponse>(response);
        }

        public AsyncInvoker<DeleteSecurityGroupRuleResponse> DeleteSecurityGroupRuleAsyncInvoker(DeleteSecurityGroupRuleRequest deleteSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", deleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRuleRequest);
            return new AsyncInvoker<DeleteSecurityGroupRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 删除安全组资源标签
        ///
        /// 删除指定安全组资源实例的标签信息。
        /// 该接口为幂等接口：删除的key不存在报404，Key不能为空或者空字符串
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSecurityGroupTagResponse> DeleteSecurityGroupTagAsync(DeleteSecurityGroupTagRequest deleteSecurityGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key", deleteSecurityGroupTagRequest.Key.ToString());
            urlParam.Add("security_group_id", deleteSecurityGroupTagRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupTagResponse>(response);
        }

        public AsyncInvoker<DeleteSecurityGroupTagResponse> DeleteSecurityGroupTagAsyncInvoker(DeleteSecurityGroupTagRequest deleteSecurityGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("key", deleteSecurityGroupTagRequest.Key.ToString());
            urlParam.Add("security_group_id", deleteSecurityGroupTagRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupTagRequest);
            return new AsyncInvoker<DeleteSecurityGroupTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecurityGroupTagResponse>);
        }
        
        /// <summary>
        /// 删除子网
        ///
        /// 删除子网
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSubnetResponse> DeleteSubnetAsync(DeleteSubnetRequest deleteSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", deleteSubnetRequest.VpcId.ToString());
            urlParam.Add("subnet_id", deleteSubnetRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSubnetResponse>(response);
        }

        public AsyncInvoker<DeleteSubnetResponse> DeleteSubnetAsyncInvoker(DeleteSubnetRequest deleteSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", deleteSubnetRequest.VpcId.ToString());
            urlParam.Add("subnet_id", deleteSubnetRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetRequest);
            return new AsyncInvoker<DeleteSubnetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSubnetResponse>);
        }
        
        /// <summary>
        /// 删除子网资源标签
        ///
        /// 删除指定子网资源实例的标签信息。
        /// 该接口为幂等接口：删除的key不存在报404，Key不能为空或者空字符串
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSubnetTagResponse> DeleteSubnetTagAsync(DeleteSubnetTagRequest deleteSubnetTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", deleteSubnetTagRequest.SubnetId.ToString());
            urlParam.Add("key", deleteSubnetTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSubnetTagResponse>(response);
        }

        public AsyncInvoker<DeleteSubnetTagResponse> DeleteSubnetTagAsyncInvoker(DeleteSubnetTagRequest deleteSubnetTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", deleteSubnetTagRequest.SubnetId.ToString());
            urlParam.Add("key", deleteSubnetTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetTagRequest);
            return new AsyncInvoker<DeleteSubnetTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSubnetTagResponse>);
        }
        
        /// <summary>
        /// 删除对等连接
        ///
        /// 删除对等连接。
        /// 可以在在本端或对端任何一端删除对等连接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVpcPeeringResponse> DeleteVpcPeeringAsync(DeleteVpcPeeringRequest deleteVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id", deleteVpcPeeringRequest.PeeringId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcPeeringRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVpcPeeringResponse>(response);
        }

        public AsyncInvoker<DeleteVpcPeeringResponse> DeleteVpcPeeringAsyncInvoker(DeleteVpcPeeringRequest deleteVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id", deleteVpcPeeringRequest.PeeringId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcPeeringRequest);
            return new AsyncInvoker<DeleteVpcPeeringResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVpcPeeringResponse>);
        }
        
        /// <summary>
        /// 子网解关联路由表
        ///
        /// 子网解关联路由表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateRouteTableResponse> DisassociateRouteTableAsync(DisassociateRouteTableRequest disassociateRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id", disassociateRouteTableRequest.RoutetableId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateRouteTableRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisassociateRouteTableResponse>(response);
        }

        public AsyncInvoker<DisassociateRouteTableResponse> DisassociateRouteTableAsyncInvoker(DisassociateRouteTableRequest disassociateRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id", disassociateRouteTableRequest.RoutetableId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateRouteTableRequest);
            return new AsyncInvoker<DisassociateRouteTableResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateRouteTableResponse>);
        }
        
        /// <summary>
        /// 查询流日志列表
        ///
        /// 查询提交请求的租户的所有流日志列表，并根据过滤条件进行过滤
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlowLogsResponse> ListFlowLogsAsync(ListFlowLogsRequest listFlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlowLogsResponse>(response);
        }

        public AsyncInvoker<ListFlowLogsResponse> ListFlowLogsAsyncInvoker(ListFlowLogsRequest listFlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowLogsRequest);
            return new AsyncInvoker<ListFlowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlowLogsResponse>);
        }
        
        /// <summary>
        /// 查询端口列表
        ///
        /// 查询提交请求的租户的所有端口，单次查询最多返回2000条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPortsResponse> ListPortsAsync(ListPortsRequest listPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPortsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPortsResponse>(response);
        }

        public AsyncInvoker<ListPortsResponse> ListPortsAsyncInvoker(ListPortsRequest listPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPortsRequest);
            return new AsyncInvoker<ListPortsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPortsResponse>);
        }
        
        /// <summary>
        /// 查询路由表列表
        ///
        /// 查询提交请求的帐户的所有路由表列表，并根据过滤条件进行过滤
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRouteTablesResponse> ListRouteTablesAsync(ListRouteTablesRequest listRouteTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRouteTablesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRouteTablesResponse>(response);
        }

        public AsyncInvoker<ListRouteTablesResponse> ListRouteTablesAsyncInvoker(ListRouteTablesRequest listRouteTablesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRouteTablesRequest);
            return new AsyncInvoker<ListRouteTablesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRouteTablesResponse>);
        }
        
        /// <summary>
        /// 查询安全组规则列表
        ///
        /// 查询安全组规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSecurityGroupRulesResponse> ListSecurityGroupRulesAsync(ListSecurityGroupRulesRequest listSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSecurityGroupRulesResponse>(response);
        }

        public AsyncInvoker<ListSecurityGroupRulesResponse> ListSecurityGroupRulesAsyncInvoker(ListSecurityGroupRulesRequest listSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupRulesRequest);
            return new AsyncInvoker<ListSecurityGroupRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecurityGroupRulesResponse>);
        }
        
        /// <summary>
        /// 查询安全组项目标签
        ///
        /// 查询租户在指定区域和实例类型的所有标签集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSecurityGroupTagsResponse> ListSecurityGroupTagsAsync(ListSecurityGroupTagsRequest listSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSecurityGroupTagsResponse>(response);
        }

        public AsyncInvoker<ListSecurityGroupTagsResponse> ListSecurityGroupTagsAsyncInvoker(ListSecurityGroupTagsRequest listSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupTagsRequest);
            return new AsyncInvoker<ListSecurityGroupTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecurityGroupTagsResponse>);
        }
        
        /// <summary>
        /// 查询安全组列表
        ///
        /// 查询安全组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSecurityGroupsResponse> ListSecurityGroupsAsync(ListSecurityGroupsRequest listSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSecurityGroupsResponse>(response);
        }

        public AsyncInvoker<ListSecurityGroupsResponse> ListSecurityGroupsAsyncInvoker(ListSecurityGroupsRequest listSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupsRequest);
            return new AsyncInvoker<ListSecurityGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecurityGroupsResponse>);
        }
        
        /// <summary>
        /// 查询安全组资源实例
        ///
        /// 使用标签过滤实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSecurityGroupsByTagsResponse> ListSecurityGroupsByTagsAsync(ListSecurityGroupsByTagsRequest listSecurityGroupsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSecurityGroupsByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListSecurityGroupsByTagsResponse>(response);
        }

        public AsyncInvoker<ListSecurityGroupsByTagsResponse> ListSecurityGroupsByTagsAsyncInvoker(ListSecurityGroupsByTagsRequest listSecurityGroupsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSecurityGroupsByTagsRequest);
            return new AsyncInvoker<ListSecurityGroupsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSecurityGroupsByTagsResponse>);
        }
        
        /// <summary>
        /// 查询子网项目标签
        ///
        /// 查询租户在指定区域和实例类型的所有标签集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubnetTagsResponse> ListSubnetTagsAsync(ListSubnetTagsRequest listSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSubnetTagsResponse>(response);
        }

        public AsyncInvoker<ListSubnetTagsResponse> ListSubnetTagsAsyncInvoker(ListSubnetTagsRequest listSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetTagsRequest);
            return new AsyncInvoker<ListSubnetTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubnetTagsResponse>);
        }
        
        /// <summary>
        /// 查询子网列表
        ///
        /// 查询子网列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubnetsResponse> ListSubnetsAsync(ListSubnetsRequest listSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSubnetsResponse>(response);
        }

        public AsyncInvoker<ListSubnetsResponse> ListSubnetsAsyncInvoker(ListSubnetsRequest listSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetsRequest);
            return new AsyncInvoker<ListSubnetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubnetsResponse>);
        }
        
        /// <summary>
        /// 查询子网资源实例
        ///
        /// 使用标签过滤实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubnetsByTagsResponse> ListSubnetsByTagsAsync(ListSubnetsByTagsRequest listSubnetsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSubnetsByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListSubnetsByTagsResponse>(response);
        }

        public AsyncInvoker<ListSubnetsByTagsResponse> ListSubnetsByTagsAsyncInvoker(ListSubnetsByTagsRequest listSubnetsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSubnetsByTagsRequest);
            return new AsyncInvoker<ListSubnetsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSubnetsByTagsResponse>);
        }
        
        /// <summary>
        /// 查询对等连接列表
        ///
        /// 查询提交请求的租户的所有对等连接。根据过滤条件进行过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVpcPeeringsResponse> ListVpcPeeringsAsync(ListVpcPeeringsRequest listVpcPeeringsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcPeeringsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListVpcPeeringsResponse>(response);
        }

        public AsyncInvoker<ListVpcPeeringsResponse> ListVpcPeeringsAsyncInvoker(ListVpcPeeringsRequest listVpcPeeringsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcPeeringsRequest);
            return new AsyncInvoker<ListVpcPeeringsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVpcPeeringsResponse>);
        }
        
        /// <summary>
        /// 拒绝对等连接请求
        ///
        /// 租户A名下的VPC申请和租户B的VPC建立对等连接，需要等待租户B接受该请求。此接口用于租户拒绝其他租户发起的对等连接请求。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RejectVpcPeeringResponse> RejectVpcPeeringAsync(RejectVpcPeeringRequest rejectVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id", rejectVpcPeeringRequest.PeeringId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}/reject", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rejectVpcPeeringRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<RejectVpcPeeringResponse>(response);
        }

        public AsyncInvoker<RejectVpcPeeringResponse> RejectVpcPeeringAsyncInvoker(RejectVpcPeeringRequest rejectVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id", rejectVpcPeeringRequest.PeeringId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}/reject", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rejectVpcPeeringRequest);
            return new AsyncInvoker<RejectVpcPeeringResponse>(this, "PUT", request, JsonUtils.DeSerialize<RejectVpcPeeringResponse>);
        }
        
        /// <summary>
        /// 查询流日志
        ///
        /// 查询流日志详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFlowLogResponse> ShowFlowLogAsync(ShowFlowLogRequest showFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("flowlog_id", showFlowLogRequest.FlowlogId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs/{flowlog_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowLogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFlowLogResponse>(response);
        }

        public AsyncInvoker<ShowFlowLogResponse> ShowFlowLogAsyncInvoker(ShowFlowLogRequest showFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("flowlog_id", showFlowLogRequest.FlowlogId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs/{flowlog_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowLogRequest);
            return new AsyncInvoker<ShowFlowLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlowLogResponse>);
        }
        
        /// <summary>
        /// 查询端口
        ///
        /// 查询单个端口详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPortResponse> ShowPortAsync(ShowPortRequest showPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", showPortRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPortRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPortResponse>(response);
        }

        public AsyncInvoker<ShowPortResponse> ShowPortAsyncInvoker(ShowPortRequest showPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", showPortRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPortRequest);
            return new AsyncInvoker<ShowPortResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPortResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询单租户在VPC服务下的网络资源配额，包括vpc配额、子网配额、安全组配额、安全组规则配额、弹性公网IP配额，vpn配额等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotaResponse> ShowQuotaAsync(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }

        public AsyncInvoker<ShowQuotaResponse> ShowQuotaAsyncInvoker(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            return new AsyncInvoker<ShowQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotaResponse>);
        }
        
        /// <summary>
        /// 查询路由表
        ///
        /// 查询路由表详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRouteTableResponse> ShowRouteTableAsync(ShowRouteTableRequest showRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id", showRouteTableRequest.RoutetableId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRouteTableRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRouteTableResponse>(response);
        }

        public AsyncInvoker<ShowRouteTableResponse> ShowRouteTableAsyncInvoker(ShowRouteTableRequest showRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id", showRouteTableRequest.RoutetableId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRouteTableRequest);
            return new AsyncInvoker<ShowRouteTableResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRouteTableResponse>);
        }
        
        /// <summary>
        /// 查询安全组
        ///
        /// 查询单个安全组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSecurityGroupResponse> ShowSecurityGroupAsync(ShowSecurityGroupRequest showSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", showSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSecurityGroupResponse>(response);
        }

        public AsyncInvoker<ShowSecurityGroupResponse> ShowSecurityGroupAsyncInvoker(ShowSecurityGroupRequest showSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", showSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRequest);
            return new AsyncInvoker<ShowSecurityGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 查询安全组规则
        ///
        /// 查询单个安全组规则详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSecurityGroupRuleResponse> ShowSecurityGroupRuleAsync(ShowSecurityGroupRuleRequest showSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", showSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSecurityGroupRuleResponse>(response);
        }

        public AsyncInvoker<ShowSecurityGroupRuleResponse> ShowSecurityGroupRuleAsyncInvoker(ShowSecurityGroupRuleRequest showSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", showSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRuleRequest);
            return new AsyncInvoker<ShowSecurityGroupRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 查询安全组资源标签
        ///
        /// 查询指定安全组实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSecurityGroupTagsResponse> ShowSecurityGroupTagsAsync(ShowSecurityGroupTagsRequest showSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", showSecurityGroupTagsRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSecurityGroupTagsResponse>(response);
        }

        public AsyncInvoker<ShowSecurityGroupTagsResponse> ShowSecurityGroupTagsAsyncInvoker(ShowSecurityGroupTagsRequest showSecurityGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", showSecurityGroupTagsRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/security-groups/{security_group_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupTagsRequest);
            return new AsyncInvoker<ShowSecurityGroupTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecurityGroupTagsResponse>);
        }
        
        /// <summary>
        /// 查询子网
        ///
        /// 查询子网详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSubnetResponse> ShowSubnetAsync(ShowSubnetRequest showSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", showSubnetRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSubnetResponse>(response);
        }

        public AsyncInvoker<ShowSubnetResponse> ShowSubnetAsyncInvoker(ShowSubnetRequest showSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", showSubnetRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetRequest);
            return new AsyncInvoker<ShowSubnetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubnetResponse>);
        }
        
        /// <summary>
        /// 查询子网资源标签
        ///
        /// 查询指定子网实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSubnetTagsResponse> ShowSubnetTagsAsync(ShowSubnetTagsRequest showSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", showSubnetTagsRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSubnetTagsResponse>(response);
        }

        public AsyncInvoker<ShowSubnetTagsResponse> ShowSubnetTagsAsyncInvoker(ShowSubnetTagsRequest showSubnetTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", showSubnetTagsRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetTagsRequest);
            return new AsyncInvoker<ShowSubnetTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubnetTagsResponse>);
        }
        
        /// <summary>
        /// 查询对等连接
        ///
        /// 查询对等连接详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVpcPeeringResponse> ShowVpcPeeringAsync(ShowVpcPeeringRequest showVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id", showVpcPeeringRequest.PeeringId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcPeeringRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVpcPeeringResponse>(response);
        }

        public AsyncInvoker<ShowVpcPeeringResponse> ShowVpcPeeringAsyncInvoker(ShowVpcPeeringRequest showVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id", showVpcPeeringRequest.PeeringId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcPeeringRequest);
            return new AsyncInvoker<ShowVpcPeeringResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVpcPeeringResponse>);
        }
        
        /// <summary>
        /// 更新流日志
        ///
        /// 更新流日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFlowLogResponse> UpdateFlowLogAsync(UpdateFlowLogRequest updateFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("flowlog_id", updateFlowLogRequest.FlowlogId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs/{flowlog_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateFlowLogRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFlowLogResponse>(response);
        }

        public AsyncInvoker<UpdateFlowLogResponse> UpdateFlowLogAsyncInvoker(UpdateFlowLogRequest updateFlowLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("flowlog_id", updateFlowLogRequest.FlowlogId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fl/flow_logs/{flowlog_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateFlowLogRequest);
            return new AsyncInvoker<UpdateFlowLogResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFlowLogResponse>);
        }
        
        /// <summary>
        /// 更新端口
        ///
        /// 更新端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePortResponse> UpdatePortAsync(UpdatePortRequest updatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", updatePortRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePortRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePortResponse>(response);
        }

        public AsyncInvoker<UpdatePortResponse> UpdatePortAsyncInvoker(UpdatePortRequest updatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", updatePortRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePortRequest);
            return new AsyncInvoker<UpdatePortResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePortResponse>);
        }
        
        /// <summary>
        /// 更新路由表
        ///
        /// 更新路由表，包括可以更新路由表的名称，描述，以及新增、更新、删除路由条目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRouteTableResponse> UpdateRouteTableAsync(UpdateRouteTableRequest updateRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id", updateRouteTableRequest.RoutetableId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRouteTableRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRouteTableResponse>(response);
        }

        public AsyncInvoker<UpdateRouteTableResponse> UpdateRouteTableAsyncInvoker(UpdateRouteTableRequest updateRouteTableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id", updateRouteTableRequest.RoutetableId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRouteTableRequest);
            return new AsyncInvoker<UpdateRouteTableResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRouteTableResponse>);
        }
        
        /// <summary>
        /// 更新子网
        ///
        /// 更新子网。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSubnetResponse> UpdateSubnetAsync(UpdateSubnetRequest updateSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", updateSubnetRequest.VpcId.ToString());
            urlParam.Add("subnet_id", updateSubnetRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSubnetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSubnetResponse>(response);
        }

        public AsyncInvoker<UpdateSubnetResponse> UpdateSubnetAsyncInvoker(UpdateSubnetRequest updateSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", updateSubnetRequest.VpcId.ToString());
            urlParam.Add("subnet_id", updateSubnetRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSubnetRequest);
            return new AsyncInvoker<UpdateSubnetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSubnetResponse>);
        }
        
        /// <summary>
        /// 更新对等连接
        ///
        /// 更新对等连接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateVpcPeeringResponse> UpdateVpcPeeringAsync(UpdateVpcPeeringRequest updateVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id", updateVpcPeeringRequest.PeeringId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVpcPeeringRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVpcPeeringResponse>(response);
        }

        public AsyncInvoker<UpdateVpcPeeringResponse> UpdateVpcPeeringAsyncInvoker(UpdateVpcPeeringRequest updateVpcPeeringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id", updateVpcPeeringRequest.PeeringId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVpcPeeringRequest);
            return new AsyncInvoker<UpdateVpcPeeringResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVpcPeeringResponse>);
        }
        
        /// <summary>
        /// 申请私有IP
        ///
        /// 申请私有IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePrivateipResponse> CreatePrivateipAsync(CreatePrivateipRequest createPrivateipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPrivateipRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePrivateipResponse>(response);
        }

        public AsyncInvoker<CreatePrivateipResponse> CreatePrivateipAsyncInvoker(CreatePrivateipRequest createPrivateipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPrivateipRequest);
            return new AsyncInvoker<CreatePrivateipResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePrivateipResponse>);
        }
        
        /// <summary>
        /// 删除私有IP
        ///
        /// 删除私有IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePrivateipResponse> DeletePrivateipAsync(DeletePrivateipRequest deletePrivateipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("privateip_id", deletePrivateipRequest.PrivateipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips/{privateip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateipRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePrivateipResponse>(response);
        }

        public AsyncInvoker<DeletePrivateipResponse> DeletePrivateipAsyncInvoker(DeletePrivateipRequest deletePrivateipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("privateip_id", deletePrivateipRequest.PrivateipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips/{privateip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateipRequest);
            return new AsyncInvoker<DeletePrivateipResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePrivateipResponse>);
        }
        
        /// <summary>
        /// 查询私有IP列表
        ///
        /// 查询指定子网下的私有IP列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPrivateipsResponse> ListPrivateipsAsync(ListPrivateipsRequest listPrivateipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", listPrivateipsRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets/{subnet_id}/privateips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateipsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPrivateipsResponse>(response);
        }

        public AsyncInvoker<ListPrivateipsResponse> ListPrivateipsAsyncInvoker(ListPrivateipsRequest listPrivateipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", listPrivateipsRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets/{subnet_id}/privateips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateipsRequest);
            return new AsyncInvoker<ListPrivateipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPrivateipsResponse>);
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
        public async Task<ShowNetworkIpAvailabilitiesResponse> ShowNetworkIpAvailabilitiesAsync(ShowNetworkIpAvailabilitiesRequest showNetworkIpAvailabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("network_id", showNetworkIpAvailabilitiesRequest.NetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/network-ip-availabilities/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkIpAvailabilitiesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNetworkIpAvailabilitiesResponse>(response);
        }

        public AsyncInvoker<ShowNetworkIpAvailabilitiesResponse> ShowNetworkIpAvailabilitiesAsyncInvoker(ShowNetworkIpAvailabilitiesRequest showNetworkIpAvailabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("network_id", showNetworkIpAvailabilitiesRequest.NetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/network-ip-availabilities/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkIpAvailabilitiesRequest);
            return new AsyncInvoker<ShowNetworkIpAvailabilitiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNetworkIpAvailabilitiesResponse>);
        }
        
        /// <summary>
        /// 查询私有IP
        ///
        /// 指定ID查询私有IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPrivateipResponse> ShowPrivateipAsync(ShowPrivateipRequest showPrivateipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("privateip_id", showPrivateipRequest.PrivateipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips/{privateip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateipRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivateipResponse>(response);
        }

        public AsyncInvoker<ShowPrivateipResponse> ShowPrivateipAsyncInvoker(ShowPrivateipRequest showPrivateipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("privateip_id", showPrivateipRequest.PrivateipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips/{privateip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateipRequest);
            return new AsyncInvoker<ShowPrivateipResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivateipResponse>);
        }
        
        /// <summary>
        /// 路由器添加接口
        ///
        /// 添加路由器接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronAddRouterInterfaceResponse> NeutronAddRouterInterfaceAsync(NeutronAddRouterInterfaceRequest neutronAddRouterInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("router_id", neutronAddRouterInterfaceRequest.RouterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}/add_router_interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronAddRouterInterfaceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<NeutronAddRouterInterfaceResponse>(response);
        }

        public AsyncInvoker<NeutronAddRouterInterfaceResponse> NeutronAddRouterInterfaceAsyncInvoker(NeutronAddRouterInterfaceRequest neutronAddRouterInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("router_id", neutronAddRouterInterfaceRequest.RouterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}/add_router_interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronAddRouterInterfaceRequest);
            return new AsyncInvoker<NeutronAddRouterInterfaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronAddRouterInterfaceResponse>);
        }
        
        /// <summary>
        /// 创建网络
        ///
        /// 创建网络
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronCreateNetworkResponse> NeutronCreateNetworkAsync(NeutronCreateNetworkRequest neutronCreateNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateNetworkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateNetworkResponse>(response);
        }

        public AsyncInvoker<NeutronCreateNetworkResponse> NeutronCreateNetworkAsyncInvoker(NeutronCreateNetworkRequest neutronCreateNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateNetworkRequest);
            return new AsyncInvoker<NeutronCreateNetworkResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateNetworkResponse>);
        }
        
        /// <summary>
        /// 创建端口
        ///
        /// 创建端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronCreatePortResponse> NeutronCreatePortAsync(NeutronCreatePortRequest neutronCreatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreatePortRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreatePortResponse>(response);
        }

        public AsyncInvoker<NeutronCreatePortResponse> NeutronCreatePortAsyncInvoker(NeutronCreatePortRequest neutronCreatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreatePortRequest);
            return new AsyncInvoker<NeutronCreatePortResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreatePortResponse>);
        }
        
        /// <summary>
        /// 创建路由器
        ///
        /// 创建路由器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronCreateRouterResponse> NeutronCreateRouterAsync(NeutronCreateRouterRequest neutronCreateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateRouterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateRouterResponse>(response);
        }

        public AsyncInvoker<NeutronCreateRouterResponse> NeutronCreateRouterAsyncInvoker(NeutronCreateRouterRequest neutronCreateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateRouterRequest);
            return new AsyncInvoker<NeutronCreateRouterResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateRouterResponse>);
        }
        
        /// <summary>
        /// 创建安全组
        ///
        /// 创建安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronCreateSecurityGroupResponse> NeutronCreateSecurityGroupAsync(NeutronCreateSecurityGroupRequest neutronCreateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSecurityGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateSecurityGroupResponse>(response);
        }

        public AsyncInvoker<NeutronCreateSecurityGroupResponse> NeutronCreateSecurityGroupAsyncInvoker(NeutronCreateSecurityGroupRequest neutronCreateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSecurityGroupRequest);
            return new AsyncInvoker<NeutronCreateSecurityGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 创建安全组规则
        ///
        /// 创建安全组规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronCreateSecurityGroupRuleResponse> NeutronCreateSecurityGroupRuleAsync(NeutronCreateSecurityGroupRuleRequest neutronCreateSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSecurityGroupRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateSecurityGroupRuleResponse>(response);
        }

        public AsyncInvoker<NeutronCreateSecurityGroupRuleResponse> NeutronCreateSecurityGroupRuleAsyncInvoker(NeutronCreateSecurityGroupRuleRequest neutronCreateSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSecurityGroupRuleRequest);
            return new AsyncInvoker<NeutronCreateSecurityGroupRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 创建子网
        ///
        /// 创建子网。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronCreateSubnetResponse> NeutronCreateSubnetAsync(NeutronCreateSubnetRequest neutronCreateSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSubnetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateSubnetResponse>(response);
        }

        public AsyncInvoker<NeutronCreateSubnetResponse> NeutronCreateSubnetAsyncInvoker(NeutronCreateSubnetRequest neutronCreateSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSubnetRequest);
            return new AsyncInvoker<NeutronCreateSubnetResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateSubnetResponse>);
        }
        
        /// <summary>
        /// 删除网络
        ///
        /// 删除网络
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronDeleteNetworkResponse> NeutronDeleteNetworkAsync(NeutronDeleteNetworkRequest neutronDeleteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("network_id", neutronDeleteNetworkRequest.NetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteNetworkRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteNetworkResponse>(response);
        }

        public AsyncInvoker<NeutronDeleteNetworkResponse> NeutronDeleteNetworkAsyncInvoker(NeutronDeleteNetworkRequest neutronDeleteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("network_id", neutronDeleteNetworkRequest.NetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteNetworkRequest);
            return new AsyncInvoker<NeutronDeleteNetworkResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteNetworkResponse>);
        }
        
        /// <summary>
        /// 删除端口
        ///
        /// 删除端口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronDeletePortResponse> NeutronDeletePortAsync(NeutronDeletePortRequest neutronDeletePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", neutronDeletePortRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeletePortRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeletePortResponse>(response);
        }

        public AsyncInvoker<NeutronDeletePortResponse> NeutronDeletePortAsyncInvoker(NeutronDeletePortRequest neutronDeletePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", neutronDeletePortRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeletePortRequest);
            return new AsyncInvoker<NeutronDeletePortResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeletePortResponse>);
        }
        
        /// <summary>
        /// 删除路由器
        ///
        /// 删除路由器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronDeleteRouterResponse> NeutronDeleteRouterAsync(NeutronDeleteRouterRequest neutronDeleteRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("router_id", neutronDeleteRouterRequest.RouterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteRouterRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteRouterResponse>(response);
        }

        public AsyncInvoker<NeutronDeleteRouterResponse> NeutronDeleteRouterAsyncInvoker(NeutronDeleteRouterRequest neutronDeleteRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("router_id", neutronDeleteRouterRequest.RouterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteRouterRequest);
            return new AsyncInvoker<NeutronDeleteRouterResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteRouterResponse>);
        }
        
        /// <summary>
        /// 删除安全组
        ///
        /// 删除安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronDeleteSecurityGroupResponse> NeutronDeleteSecurityGroupAsync(NeutronDeleteSecurityGroupRequest neutronDeleteSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", neutronDeleteSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSecurityGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteSecurityGroupResponse>(response);
        }

        public AsyncInvoker<NeutronDeleteSecurityGroupResponse> NeutronDeleteSecurityGroupAsyncInvoker(NeutronDeleteSecurityGroupRequest neutronDeleteSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", neutronDeleteSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSecurityGroupRequest);
            return new AsyncInvoker<NeutronDeleteSecurityGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 删除安全组规则
        ///
        /// 删除安全组规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronDeleteSecurityGroupRuleResponse> NeutronDeleteSecurityGroupRuleAsync(NeutronDeleteSecurityGroupRuleRequest neutronDeleteSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", neutronDeleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSecurityGroupRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteSecurityGroupRuleResponse>(response);
        }

        public AsyncInvoker<NeutronDeleteSecurityGroupRuleResponse> NeutronDeleteSecurityGroupRuleAsyncInvoker(NeutronDeleteSecurityGroupRuleRequest neutronDeleteSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", neutronDeleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSecurityGroupRuleRequest);
            return new AsyncInvoker<NeutronDeleteSecurityGroupRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 删除子网
        ///
        /// 删除子网
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronDeleteSubnetResponse> NeutronDeleteSubnetAsync(NeutronDeleteSubnetRequest neutronDeleteSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", neutronDeleteSubnetRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSubnetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteSubnetResponse>(response);
        }

        public AsyncInvoker<NeutronDeleteSubnetResponse> NeutronDeleteSubnetAsyncInvoker(NeutronDeleteSubnetRequest neutronDeleteSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", neutronDeleteSubnetRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSubnetRequest);
            return new AsyncInvoker<NeutronDeleteSubnetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteSubnetResponse>);
        }
        
        /// <summary>
        /// 查询网络列表
        ///
        /// 查询提交请求的租户的所有网络，单次查询最多返回2000条数据，超过2000后会返回分页标记。分页查询请参考分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronListNetworksResponse> NeutronListNetworksAsync(NeutronListNetworksRequest neutronListNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListNetworksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronListNetworksResponse>(response);
        }

        public AsyncInvoker<NeutronListNetworksResponse> NeutronListNetworksAsyncInvoker(NeutronListNetworksRequest neutronListNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListNetworksRequest);
            return new AsyncInvoker<NeutronListNetworksResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListNetworksResponse>);
        }
        
        /// <summary>
        /// 查询端口列表
        ///
        /// 查询提交请求的租户的所有端口，单次查询最多返回2000条数据，超过2000后会返回分页标记。分页查询请参考分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronListPortsResponse> NeutronListPortsAsync(NeutronListPortsRequest neutronListPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListPortsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronListPortsResponse>(response);
        }

        public AsyncInvoker<NeutronListPortsResponse> NeutronListPortsAsyncInvoker(NeutronListPortsRequest neutronListPortsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListPortsRequest);
            return new AsyncInvoker<NeutronListPortsResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListPortsResponse>);
        }
        
        /// <summary>
        /// 查询路由器列表
        ///
        /// 查询提交请求的租户有权限操作的所有路由器信息，单次查询最多返回2000条数据，超过2000后会返回分页标记。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronListRoutersResponse> NeutronListRoutersAsync(NeutronListRoutersRequest neutronListRoutersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListRoutersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronListRoutersResponse>(response);
        }

        public AsyncInvoker<NeutronListRoutersResponse> NeutronListRoutersAsyncInvoker(NeutronListRoutersRequest neutronListRoutersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListRoutersRequest);
            return new AsyncInvoker<NeutronListRoutersResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListRoutersResponse>);
        }
        
        /// <summary>
        /// 查询安全组规则列表
        ///
        /// 查询提交请求的租户有权限查看的所有安全组规则。单次查询最多返回2000条数据，超过2000后会返回分页标记。分页查询请参考分页查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronListSecurityGroupRulesResponse> NeutronListSecurityGroupRulesAsync(NeutronListSecurityGroupRulesRequest neutronListSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSecurityGroupRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronListSecurityGroupRulesResponse>(response);
        }

        public AsyncInvoker<NeutronListSecurityGroupRulesResponse> NeutronListSecurityGroupRulesAsyncInvoker(NeutronListSecurityGroupRulesRequest neutronListSecurityGroupRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSecurityGroupRulesRequest);
            return new AsyncInvoker<NeutronListSecurityGroupRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListSecurityGroupRulesResponse>);
        }
        
        /// <summary>
        /// 查询安全组列表
        ///
        /// 查询提交请求租户的所有安全组，单次查询最多返回2000条数据，超过2000后会返回分页标记。分页查询请参考分页查询 。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronListSecurityGroupsResponse> NeutronListSecurityGroupsAsync(NeutronListSecurityGroupsRequest neutronListSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSecurityGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronListSecurityGroupsResponse>(response);
        }

        public AsyncInvoker<NeutronListSecurityGroupsResponse> NeutronListSecurityGroupsAsyncInvoker(NeutronListSecurityGroupsRequest neutronListSecurityGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSecurityGroupsRequest);
            return new AsyncInvoker<NeutronListSecurityGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListSecurityGroupsResponse>);
        }
        
        /// <summary>
        /// 查询子网列表
        ///
        /// 查询提交请求租户的所有子网，单次查询最多返回2000条数据，超过2000后会返回分页标记。分页查询请参考分页查询 。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronListSubnetsResponse> NeutronListSubnetsAsync(NeutronListSubnetsRequest neutronListSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSubnetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronListSubnetsResponse>(response);
        }

        public AsyncInvoker<NeutronListSubnetsResponse> NeutronListSubnetsAsyncInvoker(NeutronListSubnetsRequest neutronListSubnetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSubnetsRequest);
            return new AsyncInvoker<NeutronListSubnetsResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListSubnetsResponse>);
        }
        
        /// <summary>
        /// 路由器删除接口
        ///
        /// 删除路由器接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronRemoveRouterInterfaceResponse> NeutronRemoveRouterInterfaceAsync(NeutronRemoveRouterInterfaceRequest neutronRemoveRouterInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("router_id", neutronRemoveRouterInterfaceRequest.RouterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}/remove_router_interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronRemoveRouterInterfaceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<NeutronRemoveRouterInterfaceResponse>(response);
        }

        public AsyncInvoker<NeutronRemoveRouterInterfaceResponse> NeutronRemoveRouterInterfaceAsyncInvoker(NeutronRemoveRouterInterfaceRequest neutronRemoveRouterInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("router_id", neutronRemoveRouterInterfaceRequest.RouterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}/remove_router_interface", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronRemoveRouterInterfaceRequest);
            return new AsyncInvoker<NeutronRemoveRouterInterfaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronRemoveRouterInterfaceResponse>);
        }
        
        /// <summary>
        /// 查询网络
        ///
        /// 查询指定的网络详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronShowNetworkResponse> NeutronShowNetworkAsync(NeutronShowNetworkRequest neutronShowNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("network_id", neutronShowNetworkRequest.NetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowNetworkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowNetworkResponse>(response);
        }

        public AsyncInvoker<NeutronShowNetworkResponse> NeutronShowNetworkAsyncInvoker(NeutronShowNetworkRequest neutronShowNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("network_id", neutronShowNetworkRequest.NetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowNetworkRequest);
            return new AsyncInvoker<NeutronShowNetworkResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowNetworkResponse>);
        }
        
        /// <summary>
        /// 查询端口
        ///
        /// 查询端口详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronShowPortResponse> NeutronShowPortAsync(NeutronShowPortRequest neutronShowPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", neutronShowPortRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowPortRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowPortResponse>(response);
        }

        public AsyncInvoker<NeutronShowPortResponse> NeutronShowPortAsyncInvoker(NeutronShowPortRequest neutronShowPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", neutronShowPortRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowPortRequest);
            return new AsyncInvoker<NeutronShowPortResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowPortResponse>);
        }
        
        /// <summary>
        /// 查询路由器
        ///
        /// 查询路由器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronShowRouterResponse> NeutronShowRouterAsync(NeutronShowRouterRequest neutronShowRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("router_id", neutronShowRouterRequest.RouterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowRouterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowRouterResponse>(response);
        }

        public AsyncInvoker<NeutronShowRouterResponse> NeutronShowRouterAsyncInvoker(NeutronShowRouterRequest neutronShowRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("router_id", neutronShowRouterRequest.RouterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowRouterRequest);
            return new AsyncInvoker<NeutronShowRouterResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowRouterResponse>);
        }
        
        /// <summary>
        /// 查询安全组
        ///
        /// 查询安全组详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronShowSecurityGroupResponse> NeutronShowSecurityGroupAsync(NeutronShowSecurityGroupRequest neutronShowSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", neutronShowSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSecurityGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowSecurityGroupResponse>(response);
        }

        public AsyncInvoker<NeutronShowSecurityGroupResponse> NeutronShowSecurityGroupAsyncInvoker(NeutronShowSecurityGroupRequest neutronShowSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", neutronShowSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSecurityGroupRequest);
            return new AsyncInvoker<NeutronShowSecurityGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 查询安全组规则
        ///
        /// 查询安全组规则详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronShowSecurityGroupRuleResponse> NeutronShowSecurityGroupRuleAsync(NeutronShowSecurityGroupRuleRequest neutronShowSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", neutronShowSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSecurityGroupRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowSecurityGroupRuleResponse>(response);
        }

        public AsyncInvoker<NeutronShowSecurityGroupRuleResponse> NeutronShowSecurityGroupRuleAsyncInvoker(NeutronShowSecurityGroupRuleRequest neutronShowSecurityGroupRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id", neutronShowSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules/{security_group_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSecurityGroupRuleRequest);
            return new AsyncInvoker<NeutronShowSecurityGroupRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowSecurityGroupRuleResponse>);
        }
        
        /// <summary>
        /// 查询子网
        ///
        /// 查询子网详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronShowSubnetResponse> NeutronShowSubnetAsync(NeutronShowSubnetRequest neutronShowSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", neutronShowSubnetRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSubnetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowSubnetResponse>(response);
        }

        public AsyncInvoker<NeutronShowSubnetResponse> NeutronShowSubnetAsyncInvoker(NeutronShowSubnetRequest neutronShowSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", neutronShowSubnetRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSubnetRequest);
            return new AsyncInvoker<NeutronShowSubnetResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowSubnetResponse>);
        }
        
        /// <summary>
        /// 更新网络
        ///
        /// 更新网络
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronUpdateNetworkResponse> NeutronUpdateNetworkAsync(NeutronUpdateNetworkRequest neutronUpdateNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("network_id", neutronUpdateNetworkRequest.NetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateNetworkRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateNetworkResponse>(response);
        }

        public AsyncInvoker<NeutronUpdateNetworkResponse> NeutronUpdateNetworkAsyncInvoker(NeutronUpdateNetworkRequest neutronUpdateNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("network_id", neutronUpdateNetworkRequest.NetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/networks/{network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateNetworkRequest);
            return new AsyncInvoker<NeutronUpdateNetworkResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateNetworkResponse>);
        }
        
        /// <summary>
        /// 更新端口
        ///
        /// 更新端口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronUpdatePortResponse> NeutronUpdatePortAsync(NeutronUpdatePortRequest neutronUpdatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", neutronUpdatePortRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdatePortRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdatePortResponse>(response);
        }

        public AsyncInvoker<NeutronUpdatePortResponse> NeutronUpdatePortAsyncInvoker(NeutronUpdatePortRequest neutronUpdatePortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id", neutronUpdatePortRequest.PortId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/ports/{port_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdatePortRequest);
            return new AsyncInvoker<NeutronUpdatePortResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdatePortResponse>);
        }
        
        /// <summary>
        /// 更新路由器
        ///
        /// 更新路由器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronUpdateRouterResponse> NeutronUpdateRouterAsync(NeutronUpdateRouterRequest neutronUpdateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("router_id", neutronUpdateRouterRequest.RouterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateRouterRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateRouterResponse>(response);
        }

        public AsyncInvoker<NeutronUpdateRouterResponse> NeutronUpdateRouterAsyncInvoker(NeutronUpdateRouterRequest neutronUpdateRouterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("router_id", neutronUpdateRouterRequest.RouterId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/routers/{router_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateRouterRequest);
            return new AsyncInvoker<NeutronUpdateRouterResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateRouterResponse>);
        }
        
        /// <summary>
        /// 更新安全组
        ///
        /// 更新安全组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronUpdateSecurityGroupResponse> NeutronUpdateSecurityGroupAsync(NeutronUpdateSecurityGroupRequest neutronUpdateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", neutronUpdateSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateSecurityGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateSecurityGroupResponse>(response);
        }

        public AsyncInvoker<NeutronUpdateSecurityGroupResponse> NeutronUpdateSecurityGroupAsyncInvoker(NeutronUpdateSecurityGroupRequest neutronUpdateSecurityGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id", neutronUpdateSecurityGroupRequest.SecurityGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateSecurityGroupRequest);
            return new AsyncInvoker<NeutronUpdateSecurityGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateSecurityGroupResponse>);
        }
        
        /// <summary>
        /// 更新子网
        ///
        /// 更新子网
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronUpdateSubnetResponse> NeutronUpdateSubnetAsync(NeutronUpdateSubnetRequest neutronUpdateSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", neutronUpdateSubnetRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateSubnetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateSubnetResponse>(response);
        }

        public AsyncInvoker<NeutronUpdateSubnetResponse> NeutronUpdateSubnetAsyncInvoker(NeutronUpdateSubnetRequest neutronUpdateSubnetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id", neutronUpdateSubnetRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/subnets/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateSubnetRequest);
            return new AsyncInvoker<NeutronUpdateSubnetResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateSubnetResponse>);
        }
        
        /// <summary>
        /// 插入网络ACL规则
        ///
        /// 插入一条网络ACL规则到某一网络ACL策略中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronAddFirewallRuleResponse> NeutronAddFirewallRuleAsync(NeutronAddFirewallRuleRequest neutronAddFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id", neutronAddFirewallRuleRequest.FirewallPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}/insert_rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronAddFirewallRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<NeutronAddFirewallRuleResponse>(response);
        }

        public AsyncInvoker<NeutronAddFirewallRuleResponse> NeutronAddFirewallRuleAsyncInvoker(NeutronAddFirewallRuleRequest neutronAddFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id", neutronAddFirewallRuleRequest.FirewallPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}/insert_rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronAddFirewallRuleRequest);
            return new AsyncInvoker<NeutronAddFirewallRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronAddFirewallRuleResponse>);
        }
        
        /// <summary>
        /// 创建网络ACL组
        ///
        /// 创建网络ACL组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronCreateFirewallGroupResponse> NeutronCreateFirewallGroupAsync(NeutronCreateFirewallGroupRequest neutronCreateFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateFirewallGroupResponse>(response);
        }

        public AsyncInvoker<NeutronCreateFirewallGroupResponse> NeutronCreateFirewallGroupAsyncInvoker(NeutronCreateFirewallGroupRequest neutronCreateFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallGroupRequest);
            return new AsyncInvoker<NeutronCreateFirewallGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateFirewallGroupResponse>);
        }
        
        /// <summary>
        /// 创建网络ACL策略
        ///
        /// 创建网络ACL策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronCreateFirewallPolicyResponse> NeutronCreateFirewallPolicyAsync(NeutronCreateFirewallPolicyRequest neutronCreateFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateFirewallPolicyResponse>(response);
        }

        public AsyncInvoker<NeutronCreateFirewallPolicyResponse> NeutronCreateFirewallPolicyAsyncInvoker(NeutronCreateFirewallPolicyRequest neutronCreateFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallPolicyRequest);
            return new AsyncInvoker<NeutronCreateFirewallPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateFirewallPolicyResponse>);
        }
        
        /// <summary>
        /// 创建网络ACL规则
        ///
        /// 创建网络ACL规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronCreateFirewallRuleResponse> NeutronCreateFirewallRuleAsync(NeutronCreateFirewallRuleRequest neutronCreateFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<NeutronCreateFirewallRuleResponse>(response);
        }

        public AsyncInvoker<NeutronCreateFirewallRuleResponse> NeutronCreateFirewallRuleAsyncInvoker(NeutronCreateFirewallRuleRequest neutronCreateFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallRuleRequest);
            return new AsyncInvoker<NeutronCreateFirewallRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<NeutronCreateFirewallRuleResponse>);
        }
        
        /// <summary>
        /// 删除网络ACL组
        ///
        /// 删除网络ACL组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronDeleteFirewallGroupResponse> NeutronDeleteFirewallGroupAsync(NeutronDeleteFirewallGroupRequest neutronDeleteFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_group_id", neutronDeleteFirewallGroupRequest.FirewallGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFirewallGroupResponse>(response);
        }

        public AsyncInvoker<NeutronDeleteFirewallGroupResponse> NeutronDeleteFirewallGroupAsyncInvoker(NeutronDeleteFirewallGroupRequest neutronDeleteFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_group_id", neutronDeleteFirewallGroupRequest.FirewallGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallGroupRequest);
            return new AsyncInvoker<NeutronDeleteFirewallGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteFirewallGroupResponse>);
        }
        
        /// <summary>
        /// 删除网络ACL策略
        ///
        /// 删除网络ACL策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronDeleteFirewallPolicyResponse> NeutronDeleteFirewallPolicyAsync(NeutronDeleteFirewallPolicyRequest neutronDeleteFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id", neutronDeleteFirewallPolicyRequest.FirewallPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallPolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFirewallPolicyResponse>(response);
        }

        public AsyncInvoker<NeutronDeleteFirewallPolicyResponse> NeutronDeleteFirewallPolicyAsyncInvoker(NeutronDeleteFirewallPolicyRequest neutronDeleteFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id", neutronDeleteFirewallPolicyRequest.FirewallPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallPolicyRequest);
            return new AsyncInvoker<NeutronDeleteFirewallPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteFirewallPolicyResponse>);
        }
        
        /// <summary>
        /// 删除网络ACL规则
        ///
        /// 删除网络ACL规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronDeleteFirewallRuleResponse> NeutronDeleteFirewallRuleAsync(NeutronDeleteFirewallRuleRequest neutronDeleteFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_rule_id", neutronDeleteFirewallRuleRequest.FirewallRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFirewallRuleResponse>(response);
        }

        public AsyncInvoker<NeutronDeleteFirewallRuleResponse> NeutronDeleteFirewallRuleAsyncInvoker(NeutronDeleteFirewallRuleRequest neutronDeleteFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_rule_id", neutronDeleteFirewallRuleRequest.FirewallRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallRuleRequest);
            return new AsyncInvoker<NeutronDeleteFirewallRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<NeutronDeleteFirewallRuleResponse>);
        }
        
        /// <summary>
        /// 查询所有网络ACL组
        ///
        /// 查询提交请求的租户有权限操作的所有网络ACL组信息。单次查询最多返回2000条数据，超过2000后会返回分页标记。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronListFirewallGroupsResponse> NeutronListFirewallGroupsAsync(NeutronListFirewallGroupsRequest neutronListFirewallGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronListFirewallGroupsResponse>(response);
        }

        public AsyncInvoker<NeutronListFirewallGroupsResponse> NeutronListFirewallGroupsAsyncInvoker(NeutronListFirewallGroupsRequest neutronListFirewallGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallGroupsRequest);
            return new AsyncInvoker<NeutronListFirewallGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListFirewallGroupsResponse>);
        }
        
        /// <summary>
        /// 查询所有网络ACL策略
        ///
        /// 查询提交请求的租户有权限操作的所有网络ACL策略信息。单次查询最多返回2000条数据，超过2000后会返回分页标记。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronListFirewallPoliciesResponse> NeutronListFirewallPoliciesAsync(NeutronListFirewallPoliciesRequest neutronListFirewallPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallPoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronListFirewallPoliciesResponse>(response);
        }

        public AsyncInvoker<NeutronListFirewallPoliciesResponse> NeutronListFirewallPoliciesAsyncInvoker(NeutronListFirewallPoliciesRequest neutronListFirewallPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallPoliciesRequest);
            return new AsyncInvoker<NeutronListFirewallPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListFirewallPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询所有网络ACL规则
        ///
        /// 查询提交请求的租户有权限操作的所有网络ACL规则信息。单次查询最多返回2000条数据，超过2000后会返回分页标记。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronListFirewallRulesResponse> NeutronListFirewallRulesAsync(NeutronListFirewallRulesRequest neutronListFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronListFirewallRulesResponse>(response);
        }

        public AsyncInvoker<NeutronListFirewallRulesResponse> NeutronListFirewallRulesAsyncInvoker(NeutronListFirewallRulesRequest neutronListFirewallRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallRulesRequest);
            return new AsyncInvoker<NeutronListFirewallRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronListFirewallRulesResponse>);
        }
        
        /// <summary>
        /// 移除网络ACL规则
        ///
        /// 从某一网络ACL策略中移除一条网络ACL规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronRemoveFirewallRuleResponse> NeutronRemoveFirewallRuleAsync(NeutronRemoveFirewallRuleRequest neutronRemoveFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id", neutronRemoveFirewallRuleRequest.FirewallPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}/remove_rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronRemoveFirewallRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<NeutronRemoveFirewallRuleResponse>(response);
        }

        public AsyncInvoker<NeutronRemoveFirewallRuleResponse> NeutronRemoveFirewallRuleAsyncInvoker(NeutronRemoveFirewallRuleRequest neutronRemoveFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id", neutronRemoveFirewallRuleRequest.FirewallPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}/remove_rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronRemoveFirewallRuleRequest);
            return new AsyncInvoker<NeutronRemoveFirewallRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronRemoveFirewallRuleResponse>);
        }
        
        /// <summary>
        /// 查询特定网络ACL组详情
        ///
        /// 查询特定网络ACL组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronShowFirewallGroupResponse> NeutronShowFirewallGroupAsync(NeutronShowFirewallGroupRequest neutronShowFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_group_id", neutronShowFirewallGroupRequest.FirewallGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowFirewallGroupResponse>(response);
        }

        public AsyncInvoker<NeutronShowFirewallGroupResponse> NeutronShowFirewallGroupAsyncInvoker(NeutronShowFirewallGroupRequest neutronShowFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_group_id", neutronShowFirewallGroupRequest.FirewallGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallGroupRequest);
            return new AsyncInvoker<NeutronShowFirewallGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowFirewallGroupResponse>);
        }
        
        /// <summary>
        /// 查询特定网络ACL策略详情
        ///
        /// 查询特定网络ACL策略详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronShowFirewallPolicyResponse> NeutronShowFirewallPolicyAsync(NeutronShowFirewallPolicyRequest neutronShowFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id", neutronShowFirewallPolicyRequest.FirewallPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowFirewallPolicyResponse>(response);
        }

        public AsyncInvoker<NeutronShowFirewallPolicyResponse> NeutronShowFirewallPolicyAsyncInvoker(NeutronShowFirewallPolicyRequest neutronShowFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id", neutronShowFirewallPolicyRequest.FirewallPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallPolicyRequest);
            return new AsyncInvoker<NeutronShowFirewallPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowFirewallPolicyResponse>);
        }
        
        /// <summary>
        /// 查询特定网络ACL规则
        ///
        /// 查询特定网络ACL规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronShowFirewallRuleResponse> NeutronShowFirewallRuleAsync(NeutronShowFirewallRuleRequest neutronShowFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_rule_id", neutronShowFirewallRuleRequest.FirewallRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<NeutronShowFirewallRuleResponse>(response);
        }

        public AsyncInvoker<NeutronShowFirewallRuleResponse> NeutronShowFirewallRuleAsyncInvoker(NeutronShowFirewallRuleRequest neutronShowFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_rule_id", neutronShowFirewallRuleRequest.FirewallRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallRuleRequest);
            return new AsyncInvoker<NeutronShowFirewallRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<NeutronShowFirewallRuleResponse>);
        }
        
        /// <summary>
        /// 更新网络ACL组
        ///
        /// 更新网络ACL组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronUpdateFirewallGroupResponse> NeutronUpdateFirewallGroupAsync(NeutronUpdateFirewallGroupRequest neutronUpdateFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_group_id", neutronUpdateFirewallGroupRequest.FirewallGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateFirewallGroupResponse>(response);
        }

        public AsyncInvoker<NeutronUpdateFirewallGroupResponse> NeutronUpdateFirewallGroupAsyncInvoker(NeutronUpdateFirewallGroupRequest neutronUpdateFirewallGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_group_id", neutronUpdateFirewallGroupRequest.FirewallGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallGroupRequest);
            return new AsyncInvoker<NeutronUpdateFirewallGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateFirewallGroupResponse>);
        }
        
        /// <summary>
        /// 更新网络ACL策略
        ///
        /// 更新网络ACL策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronUpdateFirewallPolicyResponse> NeutronUpdateFirewallPolicyAsync(NeutronUpdateFirewallPolicyRequest neutronUpdateFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id", neutronUpdateFirewallPolicyRequest.FirewallPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateFirewallPolicyResponse>(response);
        }

        public AsyncInvoker<NeutronUpdateFirewallPolicyResponse> NeutronUpdateFirewallPolicyAsyncInvoker(NeutronUpdateFirewallPolicyRequest neutronUpdateFirewallPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id", neutronUpdateFirewallPolicyRequest.FirewallPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallPolicyRequest);
            return new AsyncInvoker<NeutronUpdateFirewallPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateFirewallPolicyResponse>);
        }
        
        /// <summary>
        /// 更新网络ACL规则
        ///
        /// 更新网络ACL规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NeutronUpdateFirewallRuleResponse> NeutronUpdateFirewallRuleAsync(NeutronUpdateFirewallRuleRequest neutronUpdateFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_rule_id", neutronUpdateFirewallRuleRequest.FirewallRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<NeutronUpdateFirewallRuleResponse>(response);
        }

        public AsyncInvoker<NeutronUpdateFirewallRuleResponse> NeutronUpdateFirewallRuleAsyncInvoker(NeutronUpdateFirewallRuleRequest neutronUpdateFirewallRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_rule_id", neutronUpdateFirewallRuleRequest.FirewallRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallRuleRequest);
            return new AsyncInvoker<NeutronUpdateFirewallRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<NeutronUpdateFirewallRuleResponse>);
        }
        
        /// <summary>
        /// 查询API版本信息列表
        ///
        /// 返回当前API所有可用的版本（仅针对OpenStack原生接口）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApiVersionResponse> ListApiVersionAsync(ListApiVersionRequest listApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionResponse>(response);
        }

        public AsyncInvoker<ListApiVersionResponse> ListApiVersionAsyncInvoker(ListApiVersionRequest listApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionRequest);
            return new AsyncInvoker<ListApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionResponse>);
        }
        
        /// <summary>
        /// 批量创建VPC资源标签
        ///
        /// 为指定的VPC资源实例批量添加标签。
        /// 此接口为幂等接口：创建时如果请求体中存在重复key则报错。创建时，不允许设置重复key数据，如果数据库已存在该key，就覆盖value的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateVpcTagsResponse> BatchCreateVpcTagsAsync(BatchCreateVpcTagsRequest batchCreateVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", batchCreateVpcTagsRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateVpcTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateVpcTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateVpcTagsResponse> BatchCreateVpcTagsAsyncInvoker(BatchCreateVpcTagsRequest batchCreateVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", batchCreateVpcTagsRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateVpcTagsRequest);
            return new AsyncInvoker<BatchCreateVpcTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateVpcTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除VPC资源标签
        ///
        /// 为指定的VPC资源实例批量删除标签。
        /// 此接口为幂等接口：删除时，如果删除的标签不存在，默认处理成功；删除时不对标签字符集范围做校验。删除时tags结构体不能缺失，key不能为空，或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteVpcTagsResponse> BatchDeleteVpcTagsAsync(BatchDeleteVpcTagsRequest batchDeleteVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", batchDeleteVpcTagsRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteVpcTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteVpcTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteVpcTagsResponse> BatchDeleteVpcTagsAsyncInvoker(BatchDeleteVpcTagsRequest batchDeleteVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", batchDeleteVpcTagsRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteVpcTagsRequest);
            return new AsyncInvoker<BatchDeleteVpcTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteVpcTagsResponse>);
        }
        
        /// <summary>
        /// 创建VPC
        ///
        /// 创建虚拟私有云。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest createVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateVpcResponse>(response);
        }

        public AsyncInvoker<CreateVpcResponse> CreateVpcAsyncInvoker(CreateVpcRequest createVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcRequest);
            return new AsyncInvoker<CreateVpcResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVpcResponse>);
        }
        
        /// <summary>
        /// 创建VPC资源标签
        ///
        /// 给指定VPC资源实例增加标签信息
        /// 此接口为幂等接口：创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVpcResourceTagResponse> CreateVpcResourceTagAsync(CreateVpcResourceTagRequest createVpcResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", createVpcResourceTagRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcResourceTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateVpcResourceTagResponse>(response);
        }

        public AsyncInvoker<CreateVpcResourceTagResponse> CreateVpcResourceTagAsyncInvoker(CreateVpcResourceTagRequest createVpcResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", createVpcResourceTagRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcResourceTagRequest);
            return new AsyncInvoker<CreateVpcResourceTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateVpcResourceTagResponse>);
        }
        
        /// <summary>
        /// 创建VPC路由
        ///
        /// 创建路由
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVpcRouteResponse> CreateVpcRouteAsync(CreateVpcRouteRequest createVpcRouteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcRouteRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateVpcRouteResponse>(response);
        }

        public AsyncInvoker<CreateVpcRouteResponse> CreateVpcRouteAsyncInvoker(CreateVpcRouteRequest createVpcRouteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcRouteRequest);
            return new AsyncInvoker<CreateVpcRouteResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVpcRouteResponse>);
        }
        
        /// <summary>
        /// 删除VPC
        ///
        /// 删除虚拟私有云。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest deleteVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", deleteVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVpcResponse>(response);
        }

        public AsyncInvoker<DeleteVpcResponse> DeleteVpcAsyncInvoker(DeleteVpcRequest deleteVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", deleteVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRequest);
            return new AsyncInvoker<DeleteVpcResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVpcResponse>);
        }
        
        /// <summary>
        /// 删除VPC路由
        ///
        /// 删除路由
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVpcRouteResponse> DeleteVpcRouteAsync(DeleteVpcRouteRequest deleteVpcRouteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("route_id", deleteVpcRouteRequest.RouteId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes/{route_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRouteRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVpcRouteResponse>(response);
        }

        public AsyncInvoker<DeleteVpcRouteResponse> DeleteVpcRouteAsyncInvoker(DeleteVpcRouteRequest deleteVpcRouteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("route_id", deleteVpcRouteRequest.RouteId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes/{route_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRouteRequest);
            return new AsyncInvoker<DeleteVpcRouteResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVpcRouteResponse>);
        }
        
        /// <summary>
        /// 删除VPC资源标签
        ///
        /// 删除指定VPC资源实例的标签信息
        /// 该接口为幂等接口：删除的key不存在报404，Key不能为空或者空字符串
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVpcTagResponse> DeleteVpcTagAsync(DeleteVpcTagRequest deleteVpcTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", deleteVpcTagRequest.VpcId.ToString());
            urlParam.Add("key", deleteVpcTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVpcTagResponse>(response);
        }

        public AsyncInvoker<DeleteVpcTagResponse> DeleteVpcTagAsyncInvoker(DeleteVpcTagRequest deleteVpcTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", deleteVpcTagRequest.VpcId.ToString());
            urlParam.Add("key", deleteVpcTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcTagRequest);
            return new AsyncInvoker<DeleteVpcTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVpcTagResponse>);
        }
        
        /// <summary>
        /// 查询VPC路由列表
        ///
        /// 查询提交请求的租户的所有路由列表，并根据过滤条件进行过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVpcRoutesResponse> ListVpcRoutesAsync(ListVpcRoutesRequest listVpcRoutesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcRoutesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListVpcRoutesResponse>(response);
        }

        public AsyncInvoker<ListVpcRoutesResponse> ListVpcRoutesAsyncInvoker(ListVpcRoutesRequest listVpcRoutesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcRoutesRequest);
            return new AsyncInvoker<ListVpcRoutesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVpcRoutesResponse>);
        }
        
        /// <summary>
        /// 查询VPC项目标签
        ///
        /// 查询租户在指定区域和实例类型的所有标签集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVpcTagsResponse> ListVpcTagsAsync(ListVpcTagsRequest listVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListVpcTagsResponse>(response);
        }

        public AsyncInvoker<ListVpcTagsResponse> ListVpcTagsAsyncInvoker(ListVpcTagsRequest listVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcTagsRequest);
            return new AsyncInvoker<ListVpcTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVpcTagsResponse>);
        }
        
        /// <summary>
        /// 查询VPC列表
        ///
        /// 查询虚拟私有云列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVpcsResponse> ListVpcsAsync(ListVpcsRequest listVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListVpcsResponse>(response);
        }

        public AsyncInvoker<ListVpcsResponse> ListVpcsAsyncInvoker(ListVpcsRequest listVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcsRequest);
            return new AsyncInvoker<ListVpcsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVpcsResponse>);
        }
        
        /// <summary>
        /// 查询VPC资源实例
        ///
        /// 使用标签过滤实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVpcsByTagsResponse> ListVpcsByTagsAsync(ListVpcsByTagsRequest listVpcsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listVpcsByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListVpcsByTagsResponse>(response);
        }

        public AsyncInvoker<ListVpcsByTagsResponse> ListVpcsByTagsAsyncInvoker(ListVpcsByTagsRequest listVpcsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listVpcsByTagsRequest);
            return new AsyncInvoker<ListVpcsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListVpcsByTagsResponse>);
        }
        
        /// <summary>
        /// 查询VPC
        ///
        /// 查询虚拟私有云。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVpcResponse> ShowVpcAsync(ShowVpcRequest showVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", showVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVpcResponse>(response);
        }

        public AsyncInvoker<ShowVpcResponse> ShowVpcAsyncInvoker(ShowVpcRequest showVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", showVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRequest);
            return new AsyncInvoker<ShowVpcResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVpcResponse>);
        }
        
        /// <summary>
        /// 查询VPC路由
        ///
        /// 查询路由详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVpcRouteResponse> ShowVpcRouteAsync(ShowVpcRouteRequest showVpcRouteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("route_id", showVpcRouteRequest.RouteId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes/{route_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRouteRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVpcRouteResponse>(response);
        }

        public AsyncInvoker<ShowVpcRouteResponse> ShowVpcRouteAsyncInvoker(ShowVpcRouteRequest showVpcRouteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("route_id", showVpcRouteRequest.RouteId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes/{route_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRouteRequest);
            return new AsyncInvoker<ShowVpcRouteResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVpcRouteResponse>);
        }
        
        /// <summary>
        /// 查询VPC资源标签
        ///
        /// 查询指定VPC实例的标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVpcTagsResponse> ShowVpcTagsAsync(ShowVpcTagsRequest showVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", showVpcTagsRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVpcTagsResponse>(response);
        }

        public AsyncInvoker<ShowVpcTagsResponse> ShowVpcTagsAsyncInvoker(ShowVpcTagsRequest showVpcTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", showVpcTagsRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcTagsRequest);
            return new AsyncInvoker<ShowVpcTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVpcTagsResponse>);
        }
        
        /// <summary>
        /// 更新VPC
        ///
        /// 更新虚拟私有云。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateVpcResponse> UpdateVpcAsync(UpdateVpcRequest updateVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", updateVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVpcRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVpcResponse>(response);
        }

        public AsyncInvoker<UpdateVpcResponse> UpdateVpcAsyncInvoker(UpdateVpcRequest updateVpcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", updateVpcRequest.VpcId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVpcRequest);
            return new AsyncInvoker<UpdateVpcResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVpcResponse>);
        }
        
    }
}