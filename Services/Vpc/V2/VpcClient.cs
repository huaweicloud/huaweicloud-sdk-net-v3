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
        /// </summary>
        public AcceptVpcPeeringResponse AcceptVpcPeering(AcceptVpcPeeringRequest acceptVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , acceptVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}/accept",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, acceptVpcPeeringRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<AcceptVpcPeeringResponse>(response);
        }
        
        /// <summary>
        /// 创建端口
        /// </summary>
        public CreatePortResponse CreatePort(CreatePortRequest createPortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPortRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePortResponse>(response);
        }
        
        /// <summary>
        /// 创建安全组
        /// </summary>
        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest createSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建安全组规则
        /// </summary>
        public CreateSecurityGroupRuleResponse CreateSecurityGroupRule(CreateSecurityGroupRuleRequest createSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityGroupRuleResponse>(response);
        }
        
        /// <summary>
        /// 创建子网
        /// </summary>
        public CreateSubnetResponse CreateSubnet(CreateSubnetRequest createSubnetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubnetRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSubnetResponse>(response);
        }
        
        /// <summary>
        /// 创建对等连接
        /// </summary>
        public CreateVpcPeeringResponse CreateVpcPeering(CreateVpcPeeringRequest createVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcPeeringRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVpcPeeringResponse>(response);
        }
        
        /// <summary>
        /// 删除端口
        /// </summary>
        public DeletePortResponse DeletePort(DeletePortRequest deletePortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id" , deletePortRequest.PortId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deletePortRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePortResponse>(response);
        }
        
        /// <summary>
        /// 删除安全组
        /// </summary>
        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest deleteSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , deleteSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupResponse>(response);
        }
        
        /// <summary>
        /// 删除安全组规则
        /// </summary>
        public DeleteSecurityGroupRuleResponse DeleteSecurityGroupRule(DeleteSecurityGroupRuleRequest deleteSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id" , deleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteSecurityGroupRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupRuleResponse>(response);
        }
        
        /// <summary>
        /// 删除子网
        /// </summary>
        public DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest deleteSubnetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , deleteSubnetRequest.VpcId.ToString());
            urlParam.Add("subnet_id" , deleteSubnetRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}/subnets/{subnet_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteSubnetRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSubnetResponse>(response);
        }
        
        /// <summary>
        /// 删除对等连接
        /// </summary>
        public DeleteVpcPeeringResponse DeleteVpcPeering(DeleteVpcPeeringRequest deleteVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , deleteVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteVpcPeeringRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcPeeringResponse>(response);
        }
        
        /// <summary>
        /// 查询端口列表
        /// </summary>
        public ListPortsResponse ListPorts(ListPortsRequest listPortsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listPortsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPortsResponse>(response);
        }
        
        /// <summary>
        /// 查询安全组规则列表
        /// </summary>
        public ListSecurityGroupRulesResponse ListSecurityGroupRules(ListSecurityGroupRulesRequest listSecurityGroupRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listSecurityGroupRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityGroupRulesResponse>(response);
        }
        
        /// <summary>
        /// 查询安全组列表
        /// </summary>
        public ListSecurityGroupsResponse ListSecurityGroups(ListSecurityGroupsRequest listSecurityGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listSecurityGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询子网列表
        /// </summary>
        public ListSubnetsResponse ListSubnets(ListSubnetsRequest listSubnetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listSubnetsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSubnetsResponse>(response);
        }
        
        /// <summary>
        /// 查询对等连接列表
        /// </summary>
        public ListVpcPeeringsResponse ListVpcPeerings(ListVpcPeeringsRequest listVpcPeeringsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listVpcPeeringsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVpcPeeringsResponse>(response);
        }
        
        /// <summary>
        /// 拒绝对等连接请求
        /// </summary>
        public RejectVpcPeeringResponse RejectVpcPeering(RejectVpcPeeringRequest rejectVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , rejectVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}/reject",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, rejectVpcPeeringRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<RejectVpcPeeringResponse>(response);
        }
        
        /// <summary>
        /// 查询端口
        /// </summary>
        public ShowPortResponse ShowPort(ShowPortRequest showPortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id" , showPortRequest.PortId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showPortRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPortResponse>(response);
        }
        
        /// <summary>
        /// 查询配额
        /// </summary>
        public ShowQuotaResponse ShowQuota(ShowQuotaRequest showQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询安全组
        /// </summary>
        public ShowSecurityGroupResponse ShowSecurityGroup(ShowSecurityGroupRequest showSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , showSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSecurityGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询安全组规则
        /// </summary>
        public ShowSecurityGroupRuleResponse ShowSecurityGroupRule(ShowSecurityGroupRuleRequest showSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id" , showSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showSecurityGroupRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSecurityGroupRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询子网
        /// </summary>
        public ShowSubnetResponse ShowSubnet(ShowSubnetRequest showSubnetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , showSubnetRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets/{subnet_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showSubnetRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSubnetResponse>(response);
        }
        
        /// <summary>
        /// 查询对等连接
        /// </summary>
        public ShowVpcPeeringResponse ShowVpcPeering(ShowVpcPeeringRequest showVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , showVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showVpcPeeringRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVpcPeeringResponse>(response);
        }
        
        /// <summary>
        /// 更新端口
        /// </summary>
        public UpdatePortResponse UpdatePort(UpdatePortRequest updatePortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id" , updatePortRequest.PortId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePortRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePortResponse>(response);
        }
        
        /// <summary>
        /// 更新子网
        /// </summary>
        public UpdateSubnetResponse UpdateSubnet(UpdateSubnetRequest updateSubnetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , updateSubnetRequest.VpcId.ToString());
            urlParam.Add("subnet_id" , updateSubnetRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}/subnets/{subnet_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSubnetRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSubnetResponse>(response);
        }
        
        /// <summary>
        /// 更新对等连接
        /// </summary>
        public UpdateVpcPeeringResponse UpdateVpcPeering(UpdateVpcPeeringRequest updateVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , updateVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVpcPeeringRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVpcPeeringResponse>(response);
        }
        
        /// <summary>
        /// 申请私有IP
        /// </summary>
        public CreatePrivateipResponse CreatePrivateip(CreatePrivateipRequest createPrivateipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPrivateipRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePrivateipResponse>(response);
        }
        
        /// <summary>
        /// 删除私有IP
        /// </summary>
        public DeletePrivateipResponse DeletePrivateip(DeletePrivateipRequest deletePrivateipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("privateip_id" , deletePrivateipRequest.PrivateipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips/{privateip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deletePrivateipRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePrivateipResponse>(response);
        }
        
        /// <summary>
        /// 查询私有IP列表
        /// </summary>
        public ListPrivateipsResponse ListPrivateips(ListPrivateipsRequest listPrivateipsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , listPrivateipsRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets/{subnet_id}/privateips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listPrivateipsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPrivateipsResponse>(response);
        }
        
        /// <summary>
        /// 查询网络IP使用情况
        /// </summary>
        public ShowNetworkIpAvailabilitiesResponse ShowNetworkIpAvailabilities(ShowNetworkIpAvailabilitiesRequest showNetworkIpAvailabilitiesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("network_id" , showNetworkIpAvailabilitiesRequest.NetworkId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/network-ip-availabilities/{network_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showNetworkIpAvailabilitiesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowNetworkIpAvailabilitiesResponse>(response);
        }
        
        /// <summary>
        /// 查询私有IP
        /// </summary>
        public ShowPrivateipResponse ShowPrivateip(ShowPrivateipRequest showPrivateipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("privateip_id" , showPrivateipRequest.PrivateipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips/{privateip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showPrivateipRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPrivateipResponse>(response);
        }
        
        /// <summary>
        /// 创建VPC
        /// </summary>
        public CreateVpcResponse CreateVpc(CreateVpcRequest createVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVpcResponse>(response);
        }
        
        /// <summary>
        /// 创建VPC路由
        /// </summary>
        public CreateVpcRouteResponse CreateVpcRoute(CreateVpcRouteRequest createVpcRouteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcRouteRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVpcRouteResponse>(response);
        }
        
        /// <summary>
        /// 删除VPC
        /// </summary>
        public DeleteVpcResponse DeleteVpc(DeleteVpcRequest deleteVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , deleteVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteVpcRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcResponse>(response);
        }
        
        /// <summary>
        /// 删除VPC路由
        /// </summary>
        public DeleteVpcRouteResponse DeleteVpcRoute(DeleteVpcRouteRequest deleteVpcRouteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("route_id" , deleteVpcRouteRequest.RouteId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes/{route_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteVpcRouteRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcRouteResponse>(response);
        }
        
        /// <summary>
        /// 查询VPC路由列表
        /// </summary>
        public ListVpcRoutesResponse ListVpcRoutes(ListVpcRoutesRequest listVpcRoutesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listVpcRoutesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVpcRoutesResponse>(response);
        }
        
        /// <summary>
        /// 查询VPC列表
        /// </summary>
        public ListVpcsResponse ListVpcs(ListVpcsRequest listVpcsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listVpcsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVpcsResponse>(response);
        }
        
        /// <summary>
        /// 查询VPC
        /// </summary>
        public ShowVpcResponse ShowVpc(ShowVpcRequest showVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , showVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showVpcRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVpcResponse>(response);
        }
        
        /// <summary>
        /// 查询VPC路由
        /// </summary>
        public ShowVpcRouteResponse ShowVpcRoute(ShowVpcRouteRequest showVpcRouteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("route_id" , showVpcRouteRequest.RouteId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes/{route_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showVpcRouteRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVpcRouteResponse>(response);
        }
        
        /// <summary>
        /// 更新VPC
        /// </summary>
        public UpdateVpcResponse UpdateVpc(UpdateVpcRequest updateVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , updateVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVpcRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVpcResponse>(response);
        }
        
    }
}