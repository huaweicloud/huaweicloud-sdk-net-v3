using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.IdentityCenterStore.V1.Model;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1
{
    public partial class IdentityCenterStoreClient : Client
    {
        public static ClientBuilder<IdentityCenterStoreClient> NewBuilder()
        {
            return new ClientBuilder<IdentityCenterStoreClient>();
        }

        
        /// <summary>
        /// 创建用户组
        ///
        /// 在指定的身份源中创建一个IAM身份中心用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGroupResponse CreateGroup(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createGroupRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupResponse>(response);
        }

        public SyncInvoker<CreateGroupResponse> CreateGroupInvoker(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createGroupRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupRequest);
            return new SyncInvoker<CreateGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupResponse>);
        }
        
        /// <summary>
        /// 删除用户组
        ///
        /// 根据用户组ID，删除对应的IAM身份中心用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteGroupRequest.IdentityStoreId.ToString());
            urlParam.Add("group_id", deleteGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupResponse>(response);
        }

        public SyncInvoker<DeleteGroupResponse> DeleteGroupInvoker(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteGroupRequest.IdentityStoreId.ToString());
            urlParam.Add("group_id", deleteGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            return new SyncInvoker<DeleteGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupResponse>);
        }
        
        /// <summary>
        /// 查询用户组详情
        ///
        /// 根据用户组ID，查询IAM身份中心用户组的详情信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeGroupResponse DescribeGroup(DescribeGroupRequest describeGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeGroupRequest.IdentityStoreId.ToString());
            urlParam.Add("group_id", describeGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribeGroupResponse>(response);
        }

        public SyncInvoker<DescribeGroupResponse> DescribeGroupInvoker(DescribeGroupRequest describeGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeGroupRequest.IdentityStoreId.ToString());
            urlParam.Add("group_id", describeGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupRequest);
            return new SyncInvoker<DescribeGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeGroupResponse>);
        }
        
        /// <summary>
        /// 批量查询指定用户组详情
        ///
        /// 批量查询指定用户组详情。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeGroupsResponse DescribeGroups(DescribeGroupsRequest describeGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeGroupsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DescribeGroupsResponse>(response);
        }

        public SyncInvoker<DescribeGroupsResponse> DescribeGroupsInvoker(DescribeGroupsRequest describeGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeGroupsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupsRequest);
            return new SyncInvoker<DescribeGroupsResponse>(this, "POST", request, JsonUtils.DeSerialize<DescribeGroupsResponse>);
        }
        
        /// <summary>
        /// 查询用户组ID
        ///
        /// 根据显示名或外部身份源ID，以精确匹配的方式查询用户组ID。显示名和外部身份源ID两种查询方式二选一，不支持同时传入。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetGroupIdResponse GetGroupId(GetGroupIdRequest getGroupIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getGroupIdRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/retrieve-group-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getGroupIdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<GetGroupIdResponse>(response);
        }

        public SyncInvoker<GetGroupIdResponse> GetGroupIdInvoker(GetGroupIdRequest getGroupIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getGroupIdRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/retrieve-group-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getGroupIdRequest);
            return new SyncInvoker<GetGroupIdResponse>(this, "POST", request, JsonUtils.DeSerialize<GetGroupIdResponse>);
        }
        
        /// <summary>
        /// 列出用户组
        ///
        /// 查询指定身份源下的IAM身份中心用户组列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupsResponse ListGroups(ListGroupsRequest listGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listGroupsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGroupsResponse>(response);
        }

        public SyncInvoker<ListGroupsResponse> ListGroupsInvoker(ListGroupsRequest listGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listGroupsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsRequest);
            return new SyncInvoker<ListGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupsResponse>);
        }
        
        /// <summary>
        /// 更新用户组
        ///
        /// 根据用户组ID，更新对应IAM身份中心用户组的属性。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGroupResponse UpdateGroup(UpdateGroupRequest updateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updateGroupRequest.IdentityStoreId.ToString());
            urlParam.Add("group_id", updateGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateGroupResponse>(response);
        }

        public SyncInvoker<UpdateGroupResponse> UpdateGroupInvoker(UpdateGroupRequest updateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updateGroupRequest.IdentityStoreId.ToString());
            urlParam.Add("group_id", updateGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupRequest);
            return new SyncInvoker<UpdateGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateGroupResponse>);
        }
        
        /// <summary>
        /// 绑定用户和组
        ///
        /// 将用户添加到用户组中，用户和用户组必须在同一身份源下。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGroupMembershipResponse CreateGroupMembership(CreateGroupMembershipRequest createGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createGroupMembershipRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupMembershipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupMembershipResponse>(response);
        }

        public SyncInvoker<CreateGroupMembershipResponse> CreateGroupMembershipInvoker(CreateGroupMembershipRequest createGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createGroupMembershipRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupMembershipRequest);
            return new SyncInvoker<CreateGroupMembershipResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupMembershipResponse>);
        }
        
        /// <summary>
        /// 解绑用户和组
        ///
        /// 根据关联关系ID解绑用户和用户组，也就是将用户移出用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGroupMembershipResponse DeleteGroupMembership(DeleteGroupMembershipRequest deleteGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteGroupMembershipRequest.IdentityStoreId.ToString());
            urlParam.Add("membership_id", deleteGroupMembershipRequest.MembershipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/{membership_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupMembershipRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupMembershipResponse>(response);
        }

        public SyncInvoker<DeleteGroupMembershipResponse> DeleteGroupMembershipInvoker(DeleteGroupMembershipRequest deleteGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteGroupMembershipRequest.IdentityStoreId.ToString());
            urlParam.Add("membership_id", deleteGroupMembershipRequest.MembershipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/{membership_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupMembershipRequest);
            return new SyncInvoker<DeleteGroupMembershipResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupMembershipResponse>);
        }
        
        /// <summary>
        /// 查询绑定关系详情
        ///
        /// 根据关联关系ID，查询此关联关系的详情信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeGroupMembershipResponse DescribeGroupMembership(DescribeGroupMembershipRequest describeGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeGroupMembershipRequest.IdentityStoreId.ToString());
            urlParam.Add("membership_id", describeGroupMembershipRequest.MembershipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/{membership_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupMembershipRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribeGroupMembershipResponse>(response);
        }

        public SyncInvoker<DescribeGroupMembershipResponse> DescribeGroupMembershipInvoker(DescribeGroupMembershipRequest describeGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeGroupMembershipRequest.IdentityStoreId.ToString());
            urlParam.Add("membership_id", describeGroupMembershipRequest.MembershipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/{membership_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupMembershipRequest);
            return new SyncInvoker<DescribeGroupMembershipResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeGroupMembershipResponse>);
        }
        
        /// <summary>
        /// 查询绑定关系ID
        ///
        /// 根据用户ID和用户组ID，查询对应的关联关系ID。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetGroupMembershipIdResponse GetGroupMembershipId(GetGroupMembershipIdRequest getGroupMembershipIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getGroupMembershipIdRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/retrieve-group-membership-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getGroupMembershipIdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<GetGroupMembershipIdResponse>(response);
        }

        public SyncInvoker<GetGroupMembershipIdResponse> GetGroupMembershipIdInvoker(GetGroupMembershipIdRequest getGroupMembershipIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getGroupMembershipIdRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/retrieve-group-membership-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getGroupMembershipIdRequest);
            return new SyncInvoker<GetGroupMembershipIdResponse>(this, "POST", request, JsonUtils.DeSerialize<GetGroupMembershipIdResponse>);
        }
        
        /// <summary>
        /// 查询用户是否是用户组成员
        ///
        /// 根据用户ID和用户组ID列表，查询用户是否为用户组的成员。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public IsMemberInGroupsResponse IsMemberInGroups(IsMemberInGroupsRequest isMemberInGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", isMemberInGroupsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/is-member-in-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", isMemberInGroupsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<IsMemberInGroupsResponse>(response);
        }

        public SyncInvoker<IsMemberInGroupsResponse> IsMemberInGroupsInvoker(IsMemberInGroupsRequest isMemberInGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", isMemberInGroupsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/is-member-in-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", isMemberInGroupsRequest);
            return new SyncInvoker<IsMemberInGroupsResponse>(this, "POST", request, JsonUtils.DeSerialize<IsMemberInGroupsResponse>);
        }
        
        /// <summary>
        /// 列出组中的用户
        ///
        /// 根据用户组ID，列出用户组中的用户。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupMembershipsResponse ListGroupMemberships(ListGroupMembershipsRequest listGroupMembershipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listGroupMembershipsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembershipsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGroupMembershipsResponse>(response);
        }

        public SyncInvoker<ListGroupMembershipsResponse> ListGroupMembershipsInvoker(ListGroupMembershipsRequest listGroupMembershipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listGroupMembershipsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembershipsRequest);
            return new SyncInvoker<ListGroupMembershipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupMembershipsResponse>);
        }
        
        /// <summary>
        /// 列出用户加入的组
        ///
        /// 根据用户ID，列出用户加入的用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupMembershipsForMemberResponse ListGroupMembershipsForMember(ListGroupMembershipsForMemberRequest listGroupMembershipsForMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listGroupMembershipsForMemberRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships-for-member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembershipsForMemberRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGroupMembershipsForMemberResponse>(response);
        }

        public SyncInvoker<ListGroupMembershipsForMemberResponse> ListGroupMembershipsForMemberInvoker(ListGroupMembershipsForMemberRequest listGroupMembershipsForMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listGroupMembershipsForMemberRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships-for-member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembershipsForMemberRequest);
            return new SyncInvoker<ListGroupMembershipsForMemberResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupMembershipsForMemberResponse>);
        }
        
        /// <summary>
        /// 创建外部身份提供商配置
        ///
        /// 创建外部身份提供商配置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateExternalIdPConfigurationForDirectoryResponse CreateExternalIdPConfigurationForDirectory(CreateExternalIdPConfigurationForDirectoryRequest createExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createExternalIdPConfigurationForDirectoryRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExternalIdPConfigurationForDirectoryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateExternalIdPConfigurationForDirectoryResponse>(response);
        }

        public SyncInvoker<CreateExternalIdPConfigurationForDirectoryResponse> CreateExternalIdPConfigurationForDirectoryInvoker(CreateExternalIdPConfigurationForDirectoryRequest createExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createExternalIdPConfigurationForDirectoryRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExternalIdPConfigurationForDirectoryRequest);
            return new SyncInvoker<CreateExternalIdPConfigurationForDirectoryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateExternalIdPConfigurationForDirectoryResponse>);
        }
        
        /// <summary>
        /// 删除外部身份提供商证书
        ///
        /// 删除外部身份提供商证书。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteExternalIdPCertificateResponse DeleteExternalIdPCertificate(DeleteExternalIdPCertificateRequest deleteExternalIdPCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteExternalIdPCertificateRequest.IdentityStoreId.ToString());
            urlParam.Add("certificate_id", deleteExternalIdPCertificateRequest.CertificateId.ToString());
            urlParam.Add("idp_id", deleteExternalIdPCertificateRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/certificate/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExternalIdPCertificateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteExternalIdPCertificateResponse>(response);
        }

        public SyncInvoker<DeleteExternalIdPCertificateResponse> DeleteExternalIdPCertificateInvoker(DeleteExternalIdPCertificateRequest deleteExternalIdPCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteExternalIdPCertificateRequest.IdentityStoreId.ToString());
            urlParam.Add("certificate_id", deleteExternalIdPCertificateRequest.CertificateId.ToString());
            urlParam.Add("idp_id", deleteExternalIdPCertificateRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/certificate/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExternalIdPCertificateRequest);
            return new SyncInvoker<DeleteExternalIdPCertificateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteExternalIdPCertificateResponse>);
        }
        
        /// <summary>
        /// 删除外部身份提供商配置
        ///
        /// 删除外部身份提供商配置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteExternalIdPConfigurationForDirectoryResponse DeleteExternalIdPConfigurationForDirectory(DeleteExternalIdPConfigurationForDirectoryRequest deleteExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteExternalIdPConfigurationForDirectoryRequest.IdentityStoreId.ToString());
            urlParam.Add("idp_id", deleteExternalIdPConfigurationForDirectoryRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExternalIdPConfigurationForDirectoryRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteExternalIdPConfigurationForDirectoryResponse>(response);
        }

        public SyncInvoker<DeleteExternalIdPConfigurationForDirectoryResponse> DeleteExternalIdPConfigurationForDirectoryInvoker(DeleteExternalIdPConfigurationForDirectoryRequest deleteExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteExternalIdPConfigurationForDirectoryRequest.IdentityStoreId.ToString());
            urlParam.Add("idp_id", deleteExternalIdPConfigurationForDirectoryRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExternalIdPConfigurationForDirectoryRequest);
            return new SyncInvoker<DeleteExternalIdPConfigurationForDirectoryResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteExternalIdPConfigurationForDirectoryResponse>);
        }
        
        /// <summary>
        /// 停用外部身份提供商
        ///
        /// 停用外部身份提供商。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableExternalIdPConfigurationForDirectoryResponse DisableExternalIdPConfigurationForDirectory(DisableExternalIdPConfigurationForDirectoryRequest disableExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", disableExternalIdPConfigurationForDirectoryRequest.IdentityStoreId.ToString());
            urlParam.Add("idp_id", disableExternalIdPConfigurationForDirectoryRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableExternalIdPConfigurationForDirectoryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisableExternalIdPConfigurationForDirectoryResponse>(response);
        }

        public SyncInvoker<DisableExternalIdPConfigurationForDirectoryResponse> DisableExternalIdPConfigurationForDirectoryInvoker(DisableExternalIdPConfigurationForDirectoryRequest disableExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", disableExternalIdPConfigurationForDirectoryRequest.IdentityStoreId.ToString());
            urlParam.Add("idp_id", disableExternalIdPConfigurationForDirectoryRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableExternalIdPConfigurationForDirectoryRequest);
            return new SyncInvoker<DisableExternalIdPConfigurationForDirectoryResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableExternalIdPConfigurationForDirectoryResponse>);
        }
        
        /// <summary>
        /// 启用外部身份提供商
        ///
        /// 启用外部身份提供商。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableExternalIdPConfigurationForDirectoryResponse EnableExternalIdPConfigurationForDirectory(EnableExternalIdPConfigurationForDirectoryRequest enableExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", enableExternalIdPConfigurationForDirectoryRequest.IdentityStoreId.ToString());
            urlParam.Add("idp_id", enableExternalIdPConfigurationForDirectoryRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableExternalIdPConfigurationForDirectoryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnableExternalIdPConfigurationForDirectoryResponse>(response);
        }

        public SyncInvoker<EnableExternalIdPConfigurationForDirectoryResponse> EnableExternalIdPConfigurationForDirectoryInvoker(EnableExternalIdPConfigurationForDirectoryRequest enableExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", enableExternalIdPConfigurationForDirectoryRequest.IdentityStoreId.ToString());
            urlParam.Add("idp_id", enableExternalIdPConfigurationForDirectoryRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableExternalIdPConfigurationForDirectoryRequest);
            return new SyncInvoker<EnableExternalIdPConfigurationForDirectoryResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableExternalIdPConfigurationForDirectoryResponse>);
        }
        
        /// <summary>
        /// 导入外部身份提供商证书
        ///
        /// 导入外部身份提供商证书。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportExternalIdPCertificateResponse ImportExternalIdPCertificate(ImportExternalIdPCertificateRequest importExternalIdPCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", importExternalIdPCertificateRequest.IdentityStoreId.ToString());
            urlParam.Add("idp_id", importExternalIdPCertificateRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importExternalIdPCertificateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ImportExternalIdPCertificateResponse>(response);
        }

        public SyncInvoker<ImportExternalIdPCertificateResponse> ImportExternalIdPCertificateInvoker(ImportExternalIdPCertificateRequest importExternalIdPCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", importExternalIdPCertificateRequest.IdentityStoreId.ToString());
            urlParam.Add("idp_id", importExternalIdPCertificateRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importExternalIdPCertificateRequest);
            return new SyncInvoker<ImportExternalIdPCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportExternalIdPCertificateResponse>);
        }
        
        /// <summary>
        /// 列出外部身份提供商证书
        ///
        /// 查询外部身份提供商证书列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListExternalIdPCertificatesResponse ListExternalIdPCertificates(ListExternalIdPCertificatesRequest listExternalIdPCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listExternalIdPCertificatesRequest.IdentityStoreId.ToString());
            urlParam.Add("idp_id", listExternalIdPCertificatesRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalIdPCertificatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListExternalIdPCertificatesResponse>(response);
        }

        public SyncInvoker<ListExternalIdPCertificatesResponse> ListExternalIdPCertificatesInvoker(ListExternalIdPCertificatesRequest listExternalIdPCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listExternalIdPCertificatesRequest.IdentityStoreId.ToString());
            urlParam.Add("idp_id", listExternalIdPCertificatesRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalIdPCertificatesRequest);
            return new SyncInvoker<ListExternalIdPCertificatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListExternalIdPCertificatesResponse>);
        }
        
        /// <summary>
        /// 查询外部身份提供商配置
        ///
        /// 查询外部身份提供商配置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListExternalIdPConfigurationsForDirectoryResponse ListExternalIdPConfigurationsForDirectory(ListExternalIdPConfigurationsForDirectoryRequest listExternalIdPConfigurationsForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listExternalIdPConfigurationsForDirectoryRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalIdPConfigurationsForDirectoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListExternalIdPConfigurationsForDirectoryResponse>(response);
        }

        public SyncInvoker<ListExternalIdPConfigurationsForDirectoryResponse> ListExternalIdPConfigurationsForDirectoryInvoker(ListExternalIdPConfigurationsForDirectoryRequest listExternalIdPConfigurationsForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listExternalIdPConfigurationsForDirectoryRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalIdPConfigurationsForDirectoryRequest);
            return new SyncInvoker<ListExternalIdPConfigurationsForDirectoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListExternalIdPConfigurationsForDirectoryResponse>);
        }
        
        /// <summary>
        /// 更新外部身份提供商配置
        ///
        /// 更新外部身份提供商配置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateExternalIdPConfigurationForDirectoryResponse UpdateExternalIdPConfigurationForDirectory(UpdateExternalIdPConfigurationForDirectoryRequest updateExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updateExternalIdPConfigurationForDirectoryRequest.IdentityStoreId.ToString());
            urlParam.Add("idp_id", updateExternalIdPConfigurationForDirectoryRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateExternalIdPConfigurationForDirectoryRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateExternalIdPConfigurationForDirectoryResponse>(response);
        }

        public SyncInvoker<UpdateExternalIdPConfigurationForDirectoryResponse> UpdateExternalIdPConfigurationForDirectoryInvoker(UpdateExternalIdPConfigurationForDirectoryRequest updateExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updateExternalIdPConfigurationForDirectoryRequest.IdentityStoreId.ToString());
            urlParam.Add("idp_id", updateExternalIdPConfigurationForDirectoryRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateExternalIdPConfigurationForDirectoryRequest);
            return new SyncInvoker<UpdateExternalIdPConfigurationForDirectoryResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateExternalIdPConfigurationForDirectoryResponse>);
        }
        
        /// <summary>
        /// 查询自定义密码策略
        ///
        /// 查询自定义密码策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribePasswordPolicyResponse DescribePasswordPolicy(DescribePasswordPolicyRequest describePasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describePasswordPolicyRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePasswordPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribePasswordPolicyResponse>(response);
        }

        public SyncInvoker<DescribePasswordPolicyResponse> DescribePasswordPolicyInvoker(DescribePasswordPolicyRequest describePasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describePasswordPolicyRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePasswordPolicyRequest);
            return new SyncInvoker<DescribePasswordPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribePasswordPolicyResponse>);
        }
        
        /// <summary>
        /// 更新自定义密码策略
        ///
        /// 更新自定义密码策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePasswordPolicyResponse UpdatePasswordPolicy(UpdatePasswordPolicyRequest updatePasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updatePasswordPolicyRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePasswordPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePasswordPolicyResponse>(response);
        }

        public SyncInvoker<UpdatePasswordPolicyResponse> UpdatePasswordPolicyInvoker(UpdatePasswordPolicyRequest updatePasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updatePasswordPolicyRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePasswordPolicyRequest);
            return new SyncInvoker<UpdatePasswordPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePasswordPolicyResponse>);
        }
        
        /// <summary>
        /// 创建服务提供商证书
        ///
        /// 创建服务提供商SAML协议签名证书。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSpCertificateResponse CreateSpCertificate(CreateSpCertificateRequest createSpCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createSpCertificateRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSpCertificateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSpCertificateResponse>(response);
        }

        public SyncInvoker<CreateSpCertificateResponse> CreateSpCertificateInvoker(CreateSpCertificateRequest createSpCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createSpCertificateRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSpCertificateRequest);
            return new SyncInvoker<CreateSpCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSpCertificateResponse>);
        }
        
        /// <summary>
        /// 删除服务提供商证书
        ///
        /// 删除服务提供商SAML协议签名证书。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSpCertificateResponse DeleteSpCertificate(DeleteSpCertificateRequest deleteSpCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteSpCertificateRequest.IdentityStoreId.ToString());
            urlParam.Add("certificate_id", deleteSpCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSpCertificateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSpCertificateResponse>(response);
        }

        public SyncInvoker<DeleteSpCertificateResponse> DeleteSpCertificateInvoker(DeleteSpCertificateRequest deleteSpCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteSpCertificateRequest.IdentityStoreId.ToString());
            urlParam.Add("certificate_id", deleteSpCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSpCertificateRequest);
            return new SyncInvoker<DeleteSpCertificateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSpCertificateResponse>);
        }
        
        /// <summary>
        /// 查询服务提供商配置
        ///
        /// 查询服务提供商配置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetSpConfigurationForDirectoryResponse GetSpConfigurationForDirectory(GetSpConfigurationForDirectoryRequest getSpConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getSpConfigurationForDirectoryRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/sp-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getSpConfigurationForDirectoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetSpConfigurationForDirectoryResponse>(response);
        }

        public SyncInvoker<GetSpConfigurationForDirectoryResponse> GetSpConfigurationForDirectoryInvoker(GetSpConfigurationForDirectoryRequest getSpConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getSpConfigurationForDirectoryRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/sp-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getSpConfigurationForDirectoryRequest);
            return new SyncInvoker<GetSpConfigurationForDirectoryResponse>(this, "GET", request, JsonUtils.DeSerialize<GetSpConfigurationForDirectoryResponse>);
        }
        
        /// <summary>
        /// 列出服务提供商证书
        ///
        /// 查询服务提供商SAML协议签名证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSpCertificatesResponse ListSpCertificates(ListSpCertificatesRequest listSpCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listSpCertificatesRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpCertificatesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listSpCertificatesResponse = JsonUtils.DeSerializeNull<ListSpCertificatesResponse>(response);
            listSpCertificatesResponse.Body = JsonUtils.DeSerializeList<SpCertificateDto>(response);
            return listSpCertificatesResponse;
        }

        public SyncInvoker<ListSpCertificatesResponse> ListSpCertificatesInvoker(ListSpCertificatesRequest listSpCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listSpCertificatesRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpCertificatesRequest);
            return new SyncInvoker<ListSpCertificatesResponse>(this, "GET", request, response =>
            {
                var listSpCertificatesResponse = JsonUtils.DeSerializeNull<ListSpCertificatesResponse>(response);
                listSpCertificatesResponse.Body = JsonUtils.DeSerializeList<SpCertificateDto>(response);
                return listSpCertificatesResponse;
            });
        }
        
        /// <summary>
        /// 激活服务提供商证书
        ///
        /// 激活服务提供商SAML协议签名证书。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSpActiveCertificateResponse UpdateSpActiveCertificate(UpdateSpActiveCertificateRequest updateSpActiveCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updateSpActiveCertificateRequest.IdentityStoreId.ToString());
            urlParam.Add("certificate_id", updateSpActiveCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates/{certificate_id}/active", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSpActiveCertificateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateSpActiveCertificateResponse>(response);
        }

        public SyncInvoker<UpdateSpActiveCertificateResponse> UpdateSpActiveCertificateInvoker(UpdateSpActiveCertificateRequest updateSpActiveCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updateSpActiveCertificateRequest.IdentityStoreId.ToString());
            urlParam.Add("certificate_id", updateSpActiveCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates/{certificate_id}/active", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSpActiveCertificateRequest);
            return new SyncInvoker<UpdateSpActiveCertificateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateSpActiveCertificateResponse>);
        }
        
        /// <summary>
        /// 查询身份源配额信息
        ///
        /// 查询身份源配额信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetIdentityStoreSummaryResponse GetIdentityStoreSummary(GetIdentityStoreSummaryRequest getIdentityStoreSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getIdentityStoreSummaryRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/identity-store-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getIdentityStoreSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetIdentityStoreSummaryResponse>(response);
        }

        public SyncInvoker<GetIdentityStoreSummaryResponse> GetIdentityStoreSummaryInvoker(GetIdentityStoreSummaryRequest getIdentityStoreSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getIdentityStoreSummaryRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/identity-store-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getIdentityStoreSummaryRequest);
            return new SyncInvoker<GetIdentityStoreSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<GetIdentityStoreSummaryResponse>);
        }
        
        /// <summary>
        /// 创建访问令牌
        ///
        /// 创建访问令牌。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBearerTokenResponse CreateBearerToken(CreateBearerTokenRequest createBearerTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createBearerTokenRequest.IdentityStoreId.ToString());
            urlParam.Add("tenant_id", createBearerTokenRequest.TenantId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}/bearer-token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBearerTokenRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateBearerTokenResponse>(response);
        }

        public SyncInvoker<CreateBearerTokenResponse> CreateBearerTokenInvoker(CreateBearerTokenRequest createBearerTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createBearerTokenRequest.IdentityStoreId.ToString());
            urlParam.Add("tenant_id", createBearerTokenRequest.TenantId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}/bearer-token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBearerTokenRequest);
            return new SyncInvoker<CreateBearerTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBearerTokenResponse>);
        }
        
        /// <summary>
        /// 启用自动预置
        ///
        /// 启用自动预置，开启SCIM协议自动同步功能。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateProvisioningTenantResponse CreateProvisioningTenant(CreateProvisioningTenantRequest createProvisioningTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createProvisioningTenantRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/provision-tenant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProvisioningTenantRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateProvisioningTenantResponse>(response);
        }

        public SyncInvoker<CreateProvisioningTenantResponse> CreateProvisioningTenantInvoker(CreateProvisioningTenantRequest createProvisioningTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createProvisioningTenantRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/provision-tenant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProvisioningTenantRequest);
            return new SyncInvoker<CreateProvisioningTenantResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProvisioningTenantResponse>);
        }
        
        /// <summary>
        /// 删除访问令牌
        ///
        /// 删除访问令牌。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBearerTokenResponse DeleteBearerToken(DeleteBearerTokenRequest deleteBearerTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteBearerTokenRequest.IdentityStoreId.ToString());
            urlParam.Add("tenant_id", deleteBearerTokenRequest.TenantId.ToString());
            urlParam.Add("token_id", deleteBearerTokenRequest.TokenId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}/bearer-token/{token_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBearerTokenRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBearerTokenResponse>(response);
        }

        public SyncInvoker<DeleteBearerTokenResponse> DeleteBearerTokenInvoker(DeleteBearerTokenRequest deleteBearerTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteBearerTokenRequest.IdentityStoreId.ToString());
            urlParam.Add("tenant_id", deleteBearerTokenRequest.TenantId.ToString());
            urlParam.Add("token_id", deleteBearerTokenRequest.TokenId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}/bearer-token/{token_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBearerTokenRequest);
            return new SyncInvoker<DeleteBearerTokenResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBearerTokenResponse>);
        }
        
        /// <summary>
        /// 删除自动预置
        ///
        /// 删除自动预置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteProvisioningTenantResponse DeleteProvisioningTenant(DeleteProvisioningTenantRequest deleteProvisioningTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteProvisioningTenantRequest.IdentityStoreId.ToString());
            urlParam.Add("tenant_id", deleteProvisioningTenantRequest.TenantId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProvisioningTenantRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteProvisioningTenantResponse>(response);
        }

        public SyncInvoker<DeleteProvisioningTenantResponse> DeleteProvisioningTenantInvoker(DeleteProvisioningTenantRequest deleteProvisioningTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteProvisioningTenantRequest.IdentityStoreId.ToString());
            urlParam.Add("tenant_id", deleteProvisioningTenantRequest.TenantId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProvisioningTenantRequest);
            return new SyncInvoker<DeleteProvisioningTenantResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProvisioningTenantResponse>);
        }
        
        /// <summary>
        /// 列出访问令牌
        ///
        /// 查询访问令牌列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBearerTokensResponse ListBearerTokens(ListBearerTokensRequest listBearerTokensRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listBearerTokensRequest.IdentityStoreId.ToString());
            urlParam.Add("tenant_id", listBearerTokensRequest.TenantId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}/bearer-token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBearerTokensRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBearerTokensResponse>(response);
        }

        public SyncInvoker<ListBearerTokensResponse> ListBearerTokensInvoker(ListBearerTokensRequest listBearerTokensRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listBearerTokensRequest.IdentityStoreId.ToString());
            urlParam.Add("tenant_id", listBearerTokensRequest.TenantId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}/bearer-token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBearerTokensRequest);
            return new SyncInvoker<ListBearerTokensResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBearerTokensResponse>);
        }
        
        /// <summary>
        /// 查询自动预置信息
        ///
        /// 查询是否开启自动预置，返回具体SCIM自动预配配置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProvisioningTenantsResponse ListProvisioningTenants(ListProvisioningTenantsRequest listProvisioningTenantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listProvisioningTenantsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/provision-tenant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvisioningTenantsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProvisioningTenantsResponse>(response);
        }

        public SyncInvoker<ListProvisioningTenantsResponse> ListProvisioningTenantsInvoker(ListProvisioningTenantsRequest listProvisioningTenantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listProvisioningTenantsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/provision-tenant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvisioningTenantsRequest);
            return new SyncInvoker<ListProvisioningTenantsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProvisioningTenantsResponse>);
        }
        
        /// <summary>
        /// 批量删除用户登录会话
        ///
        /// 批量删除用户登录会话。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteSessionsResponse BatchDeleteSessions(BatchDeleteSessionsRequest batchDeleteSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", batchDeleteSessionsRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", batchDeleteSessionsRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/sessions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteSessionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteSessionsResponse>(response);
        }

        public SyncInvoker<BatchDeleteSessionsResponse> BatchDeleteSessionsInvoker(BatchDeleteSessionsRequest batchDeleteSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", batchDeleteSessionsRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", batchDeleteSessionsRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/sessions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteSessionsRequest);
            return new SyncInvoker<BatchDeleteSessionsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteSessionsResponse>);
        }
        
        /// <summary>
        /// 列出用户MFA设备
        ///
        /// 查询指定用户的MFA设备列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchListMfaDevicesForUserResponse BatchListMfaDevicesForUser(BatchListMfaDevicesForUserRequest batchListMfaDevicesForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", batchListMfaDevicesForUserRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/retrieve-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListMfaDevicesForUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchListMfaDevicesForUserResponse>(response);
        }

        public SyncInvoker<BatchListMfaDevicesForUserResponse> BatchListMfaDevicesForUserInvoker(BatchListMfaDevicesForUserRequest batchListMfaDevicesForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", batchListMfaDevicesForUserRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/retrieve-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListMfaDevicesForUserRequest);
            return new SyncInvoker<BatchListMfaDevicesForUserResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListMfaDevicesForUserResponse>);
        }
        
        /// <summary>
        /// 创建用户
        ///
        /// 在指定的身份源中创建一个IAM身份中心用户。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateUserResponse CreateUser(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createUserRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateUserResponse>(response);
        }

        public SyncInvoker<CreateUserResponse> CreateUserInvoker(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createUserRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRequest);
            return new SyncInvoker<CreateUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUserResponse>);
        }
        
        /// <summary>
        /// 删除用户MFA设备
        ///
        /// 删除用户绑定的MFA设备。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMfaDeviceForUserResponse DeleteMfaDeviceForUser(DeleteMfaDeviceForUserRequest deleteMfaDeviceForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteMfaDeviceForUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", deleteMfaDeviceForUserRequest.UserId.ToString());
            urlParam.Add("device_id", deleteMfaDeviceForUserRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/mfa-devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMfaDeviceForUserRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMfaDeviceForUserResponse>(response);
        }

        public SyncInvoker<DeleteMfaDeviceForUserResponse> DeleteMfaDeviceForUserInvoker(DeleteMfaDeviceForUserRequest deleteMfaDeviceForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteMfaDeviceForUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", deleteMfaDeviceForUserRequest.UserId.ToString());
            urlParam.Add("device_id", deleteMfaDeviceForUserRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/mfa-devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMfaDeviceForUserRequest);
            return new SyncInvoker<DeleteMfaDeviceForUserResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMfaDeviceForUserResponse>);
        }
        
        /// <summary>
        /// 删除用户
        ///
        /// 根据用户ID，删除对应的IAM身份中心用户。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteUserResponse DeleteUser(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", deleteUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserResponse>(response);
        }

        public SyncInvoker<DeleteUserResponse> DeleteUserInvoker(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", deleteUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            return new SyncInvoker<DeleteUserResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserResponse>);
        }
        
        /// <summary>
        /// 查询用户详情
        ///
        /// 根据用户ID，查询对应IAM身份中心用户的详情信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeUserResponse DescribeUser(DescribeUserRequest describeUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", describeUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeUserRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribeUserResponse>(response);
        }

        public SyncInvoker<DescribeUserResponse> DescribeUserInvoker(DescribeUserRequest describeUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", describeUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeUserRequest);
            return new SyncInvoker<DescribeUserResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeUserResponse>);
        }
        
        /// <summary>
        /// 批量查询指定用户详情
        ///
        /// 批量查询指定用户详情。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeUsersResponse DescribeUsers(DescribeUsersRequest describeUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeUsersRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeUsersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DescribeUsersResponse>(response);
        }

        public SyncInvoker<DescribeUsersResponse> DescribeUsersInvoker(DescribeUsersRequest describeUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeUsersRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeUsersRequest);
            return new SyncInvoker<DescribeUsersResponse>(this, "POST", request, JsonUtils.DeSerialize<DescribeUsersResponse>);
        }
        
        /// <summary>
        /// 禁用用户
        ///
        /// 禁用IAM身份中心的用户。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableUserResponse DisableUser(DisableUserRequest disableUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", disableUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", disableUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisableUserResponse>(response);
        }

        public SyncInvoker<DisableUserResponse> DisableUserInvoker(DisableUserRequest disableUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", disableUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", disableUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableUserRequest);
            return new SyncInvoker<DisableUserResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableUserResponse>);
        }
        
        /// <summary>
        /// 启用用户
        ///
        /// 启用IAM身份中心的用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableUserResponse EnableUser(EnableUserRequest enableUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", enableUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", enableUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnableUserResponse>(response);
        }

        public SyncInvoker<EnableUserResponse> EnableUserInvoker(EnableUserRequest enableUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", enableUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", enableUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableUserRequest);
            return new SyncInvoker<EnableUserResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableUserResponse>);
        }
        
        /// <summary>
        /// 查询用户ID
        ///
        /// 根据用户名或外部身份源ID，以精确匹配的方式查询用户ID。用户名和外部身份源ID两种查询方式二选一，不支持同时传入。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetUserIdResponse GetUserId(GetUserIdRequest getUserIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getUserIdRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/retrieve-user-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getUserIdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<GetUserIdResponse>(response);
        }

        public SyncInvoker<GetUserIdResponse> GetUserIdInvoker(GetUserIdRequest getUserIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getUserIdRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/retrieve-user-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getUserIdRequest);
            return new SyncInvoker<GetUserIdResponse>(this, "POST", request, JsonUtils.DeSerialize<GetUserIdResponse>);
        }
        
        /// <summary>
        /// 列出用户登录会话
        ///
        /// 查询指定用户的登录会话信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSessionsResponse ListSessions(ListSessionsRequest listSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listSessionsRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", listSessionsRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSessionsResponse>(response);
        }

        public SyncInvoker<ListSessionsResponse> ListSessionsInvoker(ListSessionsRequest listSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listSessionsRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", listSessionsRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionsRequest);
            return new SyncInvoker<ListSessionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSessionsResponse>);
        }
        
        /// <summary>
        /// 列出用户
        ///
        /// 查询指定身份源下的IAM身份中心用户列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUsersResponse ListUsers(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listUsersRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUsersResponse>(response);
        }

        public SyncInvoker<ListUsersResponse> ListUsersInvoker(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listUsersRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            return new SyncInvoker<ListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersResponse>);
        }
        
        /// <summary>
        /// 注册MFA设备
        ///
        /// 为用户发起注册MFA设备，返回一个MFA注册地址。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RegisterMfaDeviceForUserResponse RegisterMfaDeviceForUser(RegisterMfaDeviceForUserRequest registerMfaDeviceForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", registerMfaDeviceForUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", registerMfaDeviceForUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/mfa-devices/register-mfa-device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerMfaDeviceForUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RegisterMfaDeviceForUserResponse>(response);
        }

        public SyncInvoker<RegisterMfaDeviceForUserResponse> RegisterMfaDeviceForUserInvoker(RegisterMfaDeviceForUserRequest registerMfaDeviceForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", registerMfaDeviceForUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", registerMfaDeviceForUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/mfa-devices/register-mfa-device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerMfaDeviceForUserRequest);
            return new SyncInvoker<RegisterMfaDeviceForUserResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterMfaDeviceForUserResponse>);
        }
        
        /// <summary>
        /// 通过电子邮件发送密码重置链接或生成用户的一次性密码
        ///
        /// 通过电子邮件发送密码重置链接或生成用户的一次性密码。。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetPwdModeResponse ResetPwdMode(ResetPwdModeRequest resetPwdModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", resetPwdModeRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", resetPwdModeRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/reset-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdModeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResetPwdModeResponse>(response);
        }

        public SyncInvoker<ResetPwdModeResponse> ResetPwdModeInvoker(ResetPwdModeRequest resetPwdModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", resetPwdModeRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", resetPwdModeRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/reset-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdModeRequest);
            return new SyncInvoker<ResetPwdModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetPwdModeResponse>);
        }
        
        /// <summary>
        /// 更新MFA设备显示名称
        ///
        /// 更新MFA设备显示名称。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMfaDeviceForUserResponse UpdateMfaDeviceForUser(UpdateMfaDeviceForUserRequest updateMfaDeviceForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updateMfaDeviceForUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", updateMfaDeviceForUserRequest.UserId.ToString());
            urlParam.Add("device_id", updateMfaDeviceForUserRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/mfa-devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMfaDeviceForUserRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateMfaDeviceForUserResponse>(response);
        }

        public SyncInvoker<UpdateMfaDeviceForUserResponse> UpdateMfaDeviceForUserInvoker(UpdateMfaDeviceForUserRequest updateMfaDeviceForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updateMfaDeviceForUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", updateMfaDeviceForUserRequest.UserId.ToString());
            urlParam.Add("device_id", updateMfaDeviceForUserRequest.DeviceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/mfa-devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMfaDeviceForUserRequest);
            return new SyncInvoker<UpdateMfaDeviceForUserResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateMfaDeviceForUserResponse>);
        }
        
        /// <summary>
        /// 更新用户
        ///
        /// 根据用户ID，更新对应IAM身份中心用户的属性。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateUserResponse UpdateUser(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updateUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", updateUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateUserResponse>(response);
        }

        public SyncInvoker<UpdateUserResponse> UpdateUserInvoker(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updateUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", updateUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            return new SyncInvoker<UpdateUserResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateUserResponse>);
        }
        
        /// <summary>
        /// 验证用户邮箱
        ///
        /// 验证用户邮箱。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public VerifyEmailResponse VerifyEmail(VerifyEmailRequest verifyEmailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", verifyEmailRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", verifyEmailRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/verify-email", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", verifyEmailRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<VerifyEmailResponse>(response);
        }

        public SyncInvoker<VerifyEmailResponse> VerifyEmailInvoker(VerifyEmailRequest verifyEmailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", verifyEmailRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", verifyEmailRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/verify-email", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", verifyEmailRequest);
            return new SyncInvoker<VerifyEmailResponse>(this, "POST", request, JsonUtils.DeSerializeNull<VerifyEmailResponse>);
        }
        
    }
}