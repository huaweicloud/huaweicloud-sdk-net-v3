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
        /// 批量创建辅助弹性网卡
        /// </summary>
        public BatchCreateSubNetworkInterfaceResponse BatchCreateSubNetworkInterface(BatchCreateSubNetworkInterfaceRequest batchCreateSubNetworkInterfaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/batch-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateSubNetworkInterfaceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateSubNetworkInterfaceResponse>(response);
        }
        
        /// <summary>
        /// 创建安全组
        /// </summary>
        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest createSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建安全组规则
        /// </summary>
        public CreateSecurityGroupRuleResponse CreateSecurityGroupRule(CreateSecurityGroupRuleRequest createSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityGroupRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityGroupRuleResponse>(response);
        }
        
        /// <summary>
        /// 创建辅助弹性网卡
        /// </summary>
        public CreateSubNetworkInterfaceResponse CreateSubNetworkInterface(CreateSubNetworkInterfaceRequest createSubNetworkInterfaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubNetworkInterfaceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSubNetworkInterfaceResponse>(response);
        }
        
        /// <summary>
        /// 删除安全组
        /// </summary>
        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest deleteSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , deleteSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRequest);
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
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupRuleResponse>(response);
        }
        
        /// <summary>
        /// 删除辅助弹性网卡
        /// </summary>
        public DeleteSubNetworkInterfaceResponse DeleteSubNetworkInterface(DeleteSubNetworkInterfaceRequest deleteSubNetworkInterfaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id" , deleteSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubNetworkInterfaceRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSubNetworkInterfaceResponse>(response);
        }
        
        /// <summary>
        /// 查询安全组规则列表
        /// </summary>
        public ListSecurityGroupRulesResponse ListSecurityGroupRules(ListSecurityGroupRulesRequest listSecurityGroupRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityGroupRulesResponse>(response);
        }
        
        /// <summary>
        /// 查询安全组列表
        /// </summary>
        public ListSecurityGroupsResponse ListSecurityGroups(ListSecurityGroupsRequest listSecurityGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询租户下辅助弹性网卡列表
        /// </summary>
        public ListSubNetworkInterfacesResponse ListSubNetworkInterfaces(ListSubNetworkInterfacesRequest listSubNetworkInterfacesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubNetworkInterfacesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSubNetworkInterfacesResponse>(response);
        }
        
        /// <summary>
        /// 迁移辅助弹性网卡
        /// </summary>
        public MigrateSubNetworkInterfaceResponse MigrateSubNetworkInterface(MigrateSubNetworkInterfaceRequest migrateSubNetworkInterfaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/migrate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateSubNetworkInterfaceRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<MigrateSubNetworkInterfaceResponse>(response);
        }
        
        /// <summary>
        /// 查询安全组
        /// </summary>
        public ShowSecurityGroupResponse ShowSecurityGroup(ShowSecurityGroupRequest showSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , showSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRequest);
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
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSecurityGroupRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询租户下辅助弹性网卡
        /// </summary>
        public ShowSubNetworkInterfaceResponse ShowSubNetworkInterface(ShowSubNetworkInterfaceRequest showSubNetworkInterfaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id" , showSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubNetworkInterfaceRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSubNetworkInterfaceResponse>(response);
        }
        
        /// <summary>
        /// 查询租户下辅助弹性网卡数目
        /// </summary>
        public ShowSubNetworkInterfacesQuantityResponse ShowSubNetworkInterfacesQuantity(ShowSubNetworkInterfacesQuantityRequest showSubNetworkInterfacesQuantityRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/count",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubNetworkInterfacesQuantityRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSubNetworkInterfacesQuantityResponse>(response);
        }
        
        /// <summary>
        /// 更新安全组
        /// </summary>
        public UpdateSecurityGroupResponse UpdateSecurityGroup(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , updateSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSecurityGroupResponse>(response);
        }
        
        /// <summary>
        /// 更新辅助弹性网卡
        /// </summary>
        public UpdateSubNetworkInterfaceResponse UpdateSubNetworkInterface(UpdateSubNetworkInterfaceRequest updateSubNetworkInterfaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id" , updateSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubNetworkInterfaceRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSubNetworkInterfaceResponse>(response);
        }
        
        /// <summary>
        /// 创建地址组
        /// </summary>
        public CreateAddressGroupResponse CreateAddressGroup(CreateAddressGroupRequest createAddressGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address_groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddressGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAddressGroupResponse>(response);
        }
        
        /// <summary>
        /// 删除地址组
        /// </summary>
        public DeleteAddressGroupResponse DeleteAddressGroup(DeleteAddressGroupRequest deleteAddressGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id" , deleteAddressGroupRequest.AddressGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address_groups/{address_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAddressGroupResponse>(response);
        }
        
        /// <summary>
        /// 强制删除地址组
        /// </summary>
        public DeleteIpAddressGroupForceResponse DeleteIpAddressGroupForce(DeleteIpAddressGroupForceRequest deleteIpAddressGroupForceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id" , deleteIpAddressGroupForceRequest.AddressGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address_groups/{address_group_id}/force",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpAddressGroupForceRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteIpAddressGroupForceResponse>(response);
        }
        
        /// <summary>
        /// 查询地址组列表
        /// </summary>
        public ListAddressGroupResponse ListAddressGroup(ListAddressGroupRequest listAddressGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address_groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAddressGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询地址组
        /// </summary>
        public ShowAddressGroupResponse ShowAddressGroup(ShowAddressGroupRequest showAddressGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id" , showAddressGroupRequest.AddressGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address_groups/{address_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddressGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAddressGroupResponse>(response);
        }
        
        /// <summary>
        /// 更新地址组
        /// </summary>
        public UpdateAddressGroupResponse UpdateAddressGroup(UpdateAddressGroupRequest updateAddressGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id" , updateAddressGroupRequest.AddressGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address_groups/{address_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAddressGroupResponse>(response);
        }
        
        /// <summary>
        /// 添加VPC扩展网段
        /// </summary>
        public AddVpcExtendCidrResponse AddVpcExtendCidr(AddVpcExtendCidrRequest addVpcExtendCidrRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , addVpcExtendCidrRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}/add-extend-cidr",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addVpcExtendCidrRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<AddVpcExtendCidrResponse>(response);
        }
        
        /// <summary>
        /// 创建VPC
        /// </summary>
        public CreateVpcResponse CreateVpc(CreateVpcRequest createVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVpcRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVpcResponse>(response);
        }
        
        /// <summary>
        /// 删除VPC
        /// </summary>
        public DeleteVpcResponse DeleteVpc(DeleteVpcRequest deleteVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , deleteVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcResponse>(response);
        }
        
        /// <summary>
        /// 查询VPC列表
        /// </summary>
        public ListVpcsResponse ListVpcs(ListVpcsRequest listVpcsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVpcsResponse>(response);
        }
        
        /// <summary>
        /// 移除VPC扩展网段
        /// </summary>
        public RemoveVpcExtendCidrResponse RemoveVpcExtendCidr(RemoveVpcExtendCidrRequest removeVpcExtendCidrRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , removeVpcExtendCidrRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}/remove-extend-cidr",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeVpcExtendCidrRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<RemoveVpcExtendCidrResponse>(response);
        }
        
        /// <summary>
        /// 查询VPC详情
        /// </summary>
        public ShowVpcResponse ShowVpc(ShowVpcRequest showVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , showVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVpcResponse>(response);
        }
        
        /// <summary>
        /// 更新VPC
        /// </summary>
        public UpdateVpcResponse UpdateVpc(UpdateVpcRequest updateVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , updateVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVpcRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVpcResponse>(response);
        }
        
    }
}