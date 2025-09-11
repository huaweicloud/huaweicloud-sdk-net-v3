using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.IdentityCenterStore.V1.Model;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1
{
    public partial class IdentityCenterStoreAsyncClient : Client
    {
        public static ClientBuilder<IdentityCenterStoreAsyncClient> NewBuilder()
        {
            return new ClientBuilder<IdentityCenterStoreAsyncClient>();
        }

        
        /// <summary>
        /// 创建用户组
        ///
        /// 在指定的身份源中创建一个IAM身份中心用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupResponse>(response);
        }

        public AsyncInvoker<CreateGroupResponse> CreateGroupAsyncInvoker(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupRequest);
            return new AsyncInvoker<CreateGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupResponse>);
        }
        
        /// <summary>
        /// 删除用户组
        ///
        /// 根据用户组ID，删除对应的IAM身份中心用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupResponse>(response);
        }

        public AsyncInvoker<DeleteGroupResponse> DeleteGroupAsyncInvoker(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            return new AsyncInvoker<DeleteGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupResponse>);
        }
        
        /// <summary>
        /// 查询用户组详情
        ///
        /// 根据用户组ID，查询IAM身份中心用户组的详情信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeGroupResponse> DescribeGroupAsync(DescribeGroupRequest describeGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeGroupRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(describeGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribeGroupResponse>(response);
        }

        public AsyncInvoker<DescribeGroupResponse> DescribeGroupAsyncInvoker(DescribeGroupRequest describeGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeGroupRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(describeGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupRequest);
            return new AsyncInvoker<DescribeGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeGroupResponse>);
        }
        
        /// <summary>
        /// 批量查询指定用户组详情
        ///
        /// 批量查询指定用户组详情。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeGroupsResponse> DescribeGroupsAsync(DescribeGroupsRequest describeGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeGroupsRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DescribeGroupsResponse>(response);
        }

        public AsyncInvoker<DescribeGroupsResponse> DescribeGroupsAsyncInvoker(DescribeGroupsRequest describeGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeGroupsRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupsRequest);
            return new AsyncInvoker<DescribeGroupsResponse>(this, "POST", request, JsonUtils.DeSerialize<DescribeGroupsResponse>);
        }
        
        /// <summary>
        /// 查询用户组ID
        ///
        /// 根据显示名或外部身份源ID，以精确匹配的方式查询用户组ID。显示名和外部身份源ID两种查询方式二选一，不支持同时传入。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetGroupIdResponse> GetGroupIdAsync(GetGroupIdRequest getGroupIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getGroupIdRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/retrieve-group-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getGroupIdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<GetGroupIdResponse>(response);
        }

        public AsyncInvoker<GetGroupIdResponse> GetGroupIdAsyncInvoker(GetGroupIdRequest getGroupIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getGroupIdRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/retrieve-group-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getGroupIdRequest);
            return new AsyncInvoker<GetGroupIdResponse>(this, "POST", request, JsonUtils.DeSerialize<GetGroupIdResponse>);
        }
        
        /// <summary>
        /// 列出用户组
        ///
        /// 查询指定身份源下的IAM身份中心用户组列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest listGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupsRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGroupsResponse>(response);
        }

        public AsyncInvoker<ListGroupsResponse> ListGroupsAsyncInvoker(ListGroupsRequest listGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupsRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsRequest);
            return new AsyncInvoker<ListGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupsResponse>);
        }
        
        /// <summary>
        /// 更新用户组
        ///
        /// 根据用户组ID，更新对应IAM身份中心用户组的属性。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest updateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(updateGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateGroupResponse>(response);
        }

        public AsyncInvoker<UpdateGroupResponse> UpdateGroupAsyncInvoker(UpdateGroupRequest updateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(updateGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupRequest);
            return new AsyncInvoker<UpdateGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateGroupResponse>);
        }
        
        /// <summary>
        /// 绑定用户和组
        ///
        /// 将用户添加到用户组中，用户和用户组必须在同一身份源下。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGroupMembershipResponse> CreateGroupMembershipAsync(CreateGroupMembershipRequest createGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupMembershipRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupMembershipRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupMembershipResponse>(response);
        }

        public AsyncInvoker<CreateGroupMembershipResponse> CreateGroupMembershipAsyncInvoker(CreateGroupMembershipRequest createGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupMembershipRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupMembershipRequest);
            return new AsyncInvoker<CreateGroupMembershipResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupMembershipResponse>);
        }
        
        /// <summary>
        /// 解绑用户和组
        ///
        /// 根据关联关系ID解绑用户和用户组，也就是将用户移出用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGroupMembershipResponse> DeleteGroupMembershipAsync(DeleteGroupMembershipRequest deleteGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMembershipRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMembershipRequest.MembershipId, out var valueOfMembershipId)) urlParam.Add("membership_id", valueOfMembershipId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/{membership_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupMembershipRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupMembershipResponse>(response);
        }

        public AsyncInvoker<DeleteGroupMembershipResponse> DeleteGroupMembershipAsyncInvoker(DeleteGroupMembershipRequest deleteGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMembershipRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMembershipRequest.MembershipId, out var valueOfMembershipId)) urlParam.Add("membership_id", valueOfMembershipId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/{membership_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupMembershipRequest);
            return new AsyncInvoker<DeleteGroupMembershipResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupMembershipResponse>);
        }
        
        /// <summary>
        /// 查询绑定关系详情
        ///
        /// 根据关联关系ID，查询此关联关系的详情信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeGroupMembershipResponse> DescribeGroupMembershipAsync(DescribeGroupMembershipRequest describeGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeGroupMembershipRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(describeGroupMembershipRequest.MembershipId, out var valueOfMembershipId)) urlParam.Add("membership_id", valueOfMembershipId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/{membership_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupMembershipRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribeGroupMembershipResponse>(response);
        }

        public AsyncInvoker<DescribeGroupMembershipResponse> DescribeGroupMembershipAsyncInvoker(DescribeGroupMembershipRequest describeGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeGroupMembershipRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(describeGroupMembershipRequest.MembershipId, out var valueOfMembershipId)) urlParam.Add("membership_id", valueOfMembershipId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/{membership_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupMembershipRequest);
            return new AsyncInvoker<DescribeGroupMembershipResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeGroupMembershipResponse>);
        }
        
        /// <summary>
        /// 查询绑定关系ID
        ///
        /// 根据用户ID和用户组ID，查询对应的关联关系ID。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetGroupMembershipIdResponse> GetGroupMembershipIdAsync(GetGroupMembershipIdRequest getGroupMembershipIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getGroupMembershipIdRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/retrieve-group-membership-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getGroupMembershipIdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<GetGroupMembershipIdResponse>(response);
        }

        public AsyncInvoker<GetGroupMembershipIdResponse> GetGroupMembershipIdAsyncInvoker(GetGroupMembershipIdRequest getGroupMembershipIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getGroupMembershipIdRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/retrieve-group-membership-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getGroupMembershipIdRequest);
            return new AsyncInvoker<GetGroupMembershipIdResponse>(this, "POST", request, JsonUtils.DeSerialize<GetGroupMembershipIdResponse>);
        }
        
        /// <summary>
        /// 查询用户是否是用户组成员
        ///
        /// 根据用户ID和用户组ID列表，查询用户是否为用户组的成员。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<IsMemberInGroupsResponse> IsMemberInGroupsAsync(IsMemberInGroupsRequest isMemberInGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(isMemberInGroupsRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/is-member-in-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", isMemberInGroupsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<IsMemberInGroupsResponse>(response);
        }

        public AsyncInvoker<IsMemberInGroupsResponse> IsMemberInGroupsAsyncInvoker(IsMemberInGroupsRequest isMemberInGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(isMemberInGroupsRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/is-member-in-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", isMemberInGroupsRequest);
            return new AsyncInvoker<IsMemberInGroupsResponse>(this, "POST", request, JsonUtils.DeSerialize<IsMemberInGroupsResponse>);
        }
        
        /// <summary>
        /// 列出组中的用户
        ///
        /// 根据用户组ID，列出用户组中的用户。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupMembershipsResponse> ListGroupMembershipsAsync(ListGroupMembershipsRequest listGroupMembershipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMembershipsRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembershipsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGroupMembershipsResponse>(response);
        }

        public AsyncInvoker<ListGroupMembershipsResponse> ListGroupMembershipsAsyncInvoker(ListGroupMembershipsRequest listGroupMembershipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMembershipsRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembershipsRequest);
            return new AsyncInvoker<ListGroupMembershipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupMembershipsResponse>);
        }
        
        /// <summary>
        /// 列出用户加入的组
        ///
        /// 根据用户ID，列出用户加入的用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupMembershipsForMemberResponse> ListGroupMembershipsForMemberAsync(ListGroupMembershipsForMemberRequest listGroupMembershipsForMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMembershipsForMemberRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships-for-member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembershipsForMemberRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGroupMembershipsForMemberResponse>(response);
        }

        public AsyncInvoker<ListGroupMembershipsForMemberResponse> ListGroupMembershipsForMemberAsyncInvoker(ListGroupMembershipsForMemberRequest listGroupMembershipsForMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMembershipsForMemberRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships-for-member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembershipsForMemberRequest);
            return new AsyncInvoker<ListGroupMembershipsForMemberResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupMembershipsForMemberResponse>);
        }
        
        /// <summary>
        /// 创建外部身份提供商配置
        ///
        /// 创建外部身份提供商配置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateExternalIdPConfigurationForDirectoryResponse> CreateExternalIdPConfigurationForDirectoryAsync(CreateExternalIdPConfigurationForDirectoryRequest createExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createExternalIdPConfigurationForDirectoryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExternalIdPConfigurationForDirectoryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateExternalIdPConfigurationForDirectoryResponse>(response);
        }

        public AsyncInvoker<CreateExternalIdPConfigurationForDirectoryResponse> CreateExternalIdPConfigurationForDirectoryAsyncInvoker(CreateExternalIdPConfigurationForDirectoryRequest createExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createExternalIdPConfigurationForDirectoryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExternalIdPConfigurationForDirectoryRequest);
            return new AsyncInvoker<CreateExternalIdPConfigurationForDirectoryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateExternalIdPConfigurationForDirectoryResponse>);
        }
        
        /// <summary>
        /// 删除外部身份提供商证书
        ///
        /// 删除外部身份提供商证书。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteExternalIdPCertificateResponse> DeleteExternalIdPCertificateAsync(DeleteExternalIdPCertificateRequest deleteExternalIdPCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteExternalIdPCertificateRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteExternalIdPCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            if (StringUtils.TryConvertToNonEmptyString(deleteExternalIdPCertificateRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/certificate/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExternalIdPCertificateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteExternalIdPCertificateResponse>(response);
        }

        public AsyncInvoker<DeleteExternalIdPCertificateResponse> DeleteExternalIdPCertificateAsyncInvoker(DeleteExternalIdPCertificateRequest deleteExternalIdPCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteExternalIdPCertificateRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteExternalIdPCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            if (StringUtils.TryConvertToNonEmptyString(deleteExternalIdPCertificateRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/certificate/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExternalIdPCertificateRequest);
            return new AsyncInvoker<DeleteExternalIdPCertificateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteExternalIdPCertificateResponse>);
        }
        
        /// <summary>
        /// 删除外部身份提供商配置
        ///
        /// 删除外部身份提供商配置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteExternalIdPConfigurationForDirectoryResponse> DeleteExternalIdPConfigurationForDirectoryAsync(DeleteExternalIdPConfigurationForDirectoryRequest deleteExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteExternalIdPConfigurationForDirectoryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteExternalIdPConfigurationForDirectoryRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExternalIdPConfigurationForDirectoryRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteExternalIdPConfigurationForDirectoryResponse>(response);
        }

        public AsyncInvoker<DeleteExternalIdPConfigurationForDirectoryResponse> DeleteExternalIdPConfigurationForDirectoryAsyncInvoker(DeleteExternalIdPConfigurationForDirectoryRequest deleteExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteExternalIdPConfigurationForDirectoryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteExternalIdPConfigurationForDirectoryRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExternalIdPConfigurationForDirectoryRequest);
            return new AsyncInvoker<DeleteExternalIdPConfigurationForDirectoryResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteExternalIdPConfigurationForDirectoryResponse>);
        }
        
        /// <summary>
        /// 停用外部身份提供商
        ///
        /// 停用外部身份提供商。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableExternalIdPConfigurationForDirectoryResponse> DisableExternalIdPConfigurationForDirectoryAsync(DisableExternalIdPConfigurationForDirectoryRequest disableExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableExternalIdPConfigurationForDirectoryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(disableExternalIdPConfigurationForDirectoryRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableExternalIdPConfigurationForDirectoryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisableExternalIdPConfigurationForDirectoryResponse>(response);
        }

        public AsyncInvoker<DisableExternalIdPConfigurationForDirectoryResponse> DisableExternalIdPConfigurationForDirectoryAsyncInvoker(DisableExternalIdPConfigurationForDirectoryRequest disableExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableExternalIdPConfigurationForDirectoryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(disableExternalIdPConfigurationForDirectoryRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableExternalIdPConfigurationForDirectoryRequest);
            return new AsyncInvoker<DisableExternalIdPConfigurationForDirectoryResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableExternalIdPConfigurationForDirectoryResponse>);
        }
        
        /// <summary>
        /// 启用外部身份提供商
        ///
        /// 启用外部身份提供商。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableExternalIdPConfigurationForDirectoryResponse> EnableExternalIdPConfigurationForDirectoryAsync(EnableExternalIdPConfigurationForDirectoryRequest enableExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableExternalIdPConfigurationForDirectoryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(enableExternalIdPConfigurationForDirectoryRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableExternalIdPConfigurationForDirectoryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<EnableExternalIdPConfigurationForDirectoryResponse>(response);
        }

        public AsyncInvoker<EnableExternalIdPConfigurationForDirectoryResponse> EnableExternalIdPConfigurationForDirectoryAsyncInvoker(EnableExternalIdPConfigurationForDirectoryRequest enableExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableExternalIdPConfigurationForDirectoryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(enableExternalIdPConfigurationForDirectoryRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableExternalIdPConfigurationForDirectoryRequest);
            return new AsyncInvoker<EnableExternalIdPConfigurationForDirectoryResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableExternalIdPConfigurationForDirectoryResponse>);
        }
        
        /// <summary>
        /// 导入外部身份提供商证书
        ///
        /// 导入外部身份提供商证书。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ImportExternalIdPCertificateResponse> ImportExternalIdPCertificateAsync(ImportExternalIdPCertificateRequest importExternalIdPCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(importExternalIdPCertificateRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(importExternalIdPCertificateRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importExternalIdPCertificateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ImportExternalIdPCertificateResponse>(response);
        }

        public AsyncInvoker<ImportExternalIdPCertificateResponse> ImportExternalIdPCertificateAsyncInvoker(ImportExternalIdPCertificateRequest importExternalIdPCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(importExternalIdPCertificateRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(importExternalIdPCertificateRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importExternalIdPCertificateRequest);
            return new AsyncInvoker<ImportExternalIdPCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportExternalIdPCertificateResponse>);
        }
        
        /// <summary>
        /// 列出外部身份提供商证书
        ///
        /// 查询外部身份提供商证书列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListExternalIdPCertificatesResponse> ListExternalIdPCertificatesAsync(ListExternalIdPCertificatesRequest listExternalIdPCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listExternalIdPCertificatesRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(listExternalIdPCertificatesRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalIdPCertificatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListExternalIdPCertificatesResponse>(response);
        }

        public AsyncInvoker<ListExternalIdPCertificatesResponse> ListExternalIdPCertificatesAsyncInvoker(ListExternalIdPCertificatesRequest listExternalIdPCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listExternalIdPCertificatesRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(listExternalIdPCertificatesRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}/certificate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalIdPCertificatesRequest);
            return new AsyncInvoker<ListExternalIdPCertificatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListExternalIdPCertificatesResponse>);
        }
        
        /// <summary>
        /// 查询外部身份提供商配置
        ///
        /// 查询外部身份提供商配置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListExternalIdPConfigurationsForDirectoryResponse> ListExternalIdPConfigurationsForDirectoryAsync(ListExternalIdPConfigurationsForDirectoryRequest listExternalIdPConfigurationsForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listExternalIdPConfigurationsForDirectoryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalIdPConfigurationsForDirectoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListExternalIdPConfigurationsForDirectoryResponse>(response);
        }

        public AsyncInvoker<ListExternalIdPConfigurationsForDirectoryResponse> ListExternalIdPConfigurationsForDirectoryAsyncInvoker(ListExternalIdPConfigurationsForDirectoryRequest listExternalIdPConfigurationsForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listExternalIdPConfigurationsForDirectoryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExternalIdPConfigurationsForDirectoryRequest);
            return new AsyncInvoker<ListExternalIdPConfigurationsForDirectoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListExternalIdPConfigurationsForDirectoryResponse>);
        }
        
        /// <summary>
        /// 更新外部身份提供商配置
        ///
        /// 更新外部身份提供商配置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateExternalIdPConfigurationForDirectoryResponse> UpdateExternalIdPConfigurationForDirectoryAsync(UpdateExternalIdPConfigurationForDirectoryRequest updateExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateExternalIdPConfigurationForDirectoryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(updateExternalIdPConfigurationForDirectoryRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateExternalIdPConfigurationForDirectoryRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateExternalIdPConfigurationForDirectoryResponse>(response);
        }

        public AsyncInvoker<UpdateExternalIdPConfigurationForDirectoryResponse> UpdateExternalIdPConfigurationForDirectoryAsyncInvoker(UpdateExternalIdPConfigurationForDirectoryRequest updateExternalIdPConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateExternalIdPConfigurationForDirectoryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(updateExternalIdPConfigurationForDirectoryRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/external-idp/{idp_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateExternalIdPConfigurationForDirectoryRequest);
            return new AsyncInvoker<UpdateExternalIdPConfigurationForDirectoryResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateExternalIdPConfigurationForDirectoryResponse>);
        }
        
        /// <summary>
        /// 查询自定义密码策略
        ///
        /// 查询自定义密码策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribePasswordPolicyResponse> DescribePasswordPolicyAsync(DescribePasswordPolicyRequest describePasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describePasswordPolicyRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePasswordPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribePasswordPolicyResponse>(response);
        }

        public AsyncInvoker<DescribePasswordPolicyResponse> DescribePasswordPolicyAsyncInvoker(DescribePasswordPolicyRequest describePasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describePasswordPolicyRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePasswordPolicyRequest);
            return new AsyncInvoker<DescribePasswordPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribePasswordPolicyResponse>);
        }
        
        /// <summary>
        /// 更新自定义密码策略
        ///
        /// 更新自定义密码策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePasswordPolicyResponse> UpdatePasswordPolicyAsync(UpdatePasswordPolicyRequest updatePasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePasswordPolicyRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePasswordPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePasswordPolicyResponse>(response);
        }

        public AsyncInvoker<UpdatePasswordPolicyResponse> UpdatePasswordPolicyAsyncInvoker(UpdatePasswordPolicyRequest updatePasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePasswordPolicyRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePasswordPolicyRequest);
            return new AsyncInvoker<UpdatePasswordPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePasswordPolicyResponse>);
        }
        
        /// <summary>
        /// 创建服务提供商证书
        ///
        /// 创建服务提供商SAML协议签名证书。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSpCertificateResponse> CreateSpCertificateAsync(CreateSpCertificateRequest createSpCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSpCertificateRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSpCertificateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSpCertificateResponse>(response);
        }

        public AsyncInvoker<CreateSpCertificateResponse> CreateSpCertificateAsyncInvoker(CreateSpCertificateRequest createSpCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSpCertificateRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSpCertificateRequest);
            return new AsyncInvoker<CreateSpCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSpCertificateResponse>);
        }
        
        /// <summary>
        /// 删除服务提供商证书
        ///
        /// 删除服务提供商SAML协议签名证书。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSpCertificateResponse> DeleteSpCertificateAsync(DeleteSpCertificateRequest deleteSpCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSpCertificateRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSpCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSpCertificateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSpCertificateResponse>(response);
        }

        public AsyncInvoker<DeleteSpCertificateResponse> DeleteSpCertificateAsyncInvoker(DeleteSpCertificateRequest deleteSpCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSpCertificateRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSpCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSpCertificateRequest);
            return new AsyncInvoker<DeleteSpCertificateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSpCertificateResponse>);
        }
        
        /// <summary>
        /// 查询服务提供商配置
        ///
        /// 查询服务提供商配置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetSpConfigurationForDirectoryResponse> GetSpConfigurationForDirectoryAsync(GetSpConfigurationForDirectoryRequest getSpConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getSpConfigurationForDirectoryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/sp-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getSpConfigurationForDirectoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetSpConfigurationForDirectoryResponse>(response);
        }

        public AsyncInvoker<GetSpConfigurationForDirectoryResponse> GetSpConfigurationForDirectoryAsyncInvoker(GetSpConfigurationForDirectoryRequest getSpConfigurationForDirectoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getSpConfigurationForDirectoryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/sp-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getSpConfigurationForDirectoryRequest);
            return new AsyncInvoker<GetSpConfigurationForDirectoryResponse>(this, "GET", request, JsonUtils.DeSerialize<GetSpConfigurationForDirectoryResponse>);
        }
        
        /// <summary>
        /// 列出服务提供商证书
        ///
        /// 查询服务提供商SAML协议签名证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSpCertificatesResponse> ListSpCertificatesAsync(ListSpCertificatesRequest listSpCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSpCertificatesRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpCertificatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listSpCertificatesResponse = JsonUtils.DeSerializeNull<ListSpCertificatesResponse>(response);
            listSpCertificatesResponse.Body = JsonUtils.DeSerializeList<SpCertificateDto>(response);
            return listSpCertificatesResponse;
        }

        public AsyncInvoker<ListSpCertificatesResponse> ListSpCertificatesAsyncInvoker(ListSpCertificatesRequest listSpCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSpCertificatesRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpCertificatesRequest);
            return new AsyncInvoker<ListSpCertificatesResponse>(this, "GET", request, response =>
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
        public async Task<UpdateSpActiveCertificateResponse> UpdateSpActiveCertificateAsync(UpdateSpActiveCertificateRequest updateSpActiveCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSpActiveCertificateRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(updateSpActiveCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates/{certificate_id}/active", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSpActiveCertificateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateSpActiveCertificateResponse>(response);
        }

        public AsyncInvoker<UpdateSpActiveCertificateResponse> UpdateSpActiveCertificateAsyncInvoker(UpdateSpActiveCertificateRequest updateSpActiveCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSpActiveCertificateRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(updateSpActiveCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/saml-certificates/{certificate_id}/active", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSpActiveCertificateRequest);
            return new AsyncInvoker<UpdateSpActiveCertificateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateSpActiveCertificateResponse>);
        }
        
        /// <summary>
        /// 查询身份源配额信息
        ///
        /// 查询身份源配额信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetIdentityStoreSummaryResponse> GetIdentityStoreSummaryAsync(GetIdentityStoreSummaryRequest getIdentityStoreSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getIdentityStoreSummaryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/identity-store-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getIdentityStoreSummaryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetIdentityStoreSummaryResponse>(response);
        }

        public AsyncInvoker<GetIdentityStoreSummaryResponse> GetIdentityStoreSummaryAsyncInvoker(GetIdentityStoreSummaryRequest getIdentityStoreSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getIdentityStoreSummaryRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/identity-store-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getIdentityStoreSummaryRequest);
            return new AsyncInvoker<GetIdentityStoreSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<GetIdentityStoreSummaryResponse>);
        }
        
        /// <summary>
        /// 创建访问令牌
        ///
        /// 创建访问令牌。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBearerTokenResponse> CreateBearerTokenAsync(CreateBearerTokenRequest createBearerTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createBearerTokenRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(createBearerTokenRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}/bearer-token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBearerTokenRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateBearerTokenResponse>(response);
        }

        public AsyncInvoker<CreateBearerTokenResponse> CreateBearerTokenAsyncInvoker(CreateBearerTokenRequest createBearerTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createBearerTokenRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(createBearerTokenRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}/bearer-token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBearerTokenRequest);
            return new AsyncInvoker<CreateBearerTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBearerTokenResponse>);
        }
        
        /// <summary>
        /// 启用自动预置
        ///
        /// 启用自动预置，开启SCIM协议自动同步功能。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateProvisioningTenantResponse> CreateProvisioningTenantAsync(CreateProvisioningTenantRequest createProvisioningTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProvisioningTenantRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/provision-tenant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProvisioningTenantRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateProvisioningTenantResponse>(response);
        }

        public AsyncInvoker<CreateProvisioningTenantResponse> CreateProvisioningTenantAsyncInvoker(CreateProvisioningTenantRequest createProvisioningTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProvisioningTenantRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/provision-tenant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProvisioningTenantRequest);
            return new AsyncInvoker<CreateProvisioningTenantResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProvisioningTenantResponse>);
        }
        
        /// <summary>
        /// 删除访问令牌
        ///
        /// 删除访问令牌。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteBearerTokenResponse> DeleteBearerTokenAsync(DeleteBearerTokenRequest deleteBearerTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBearerTokenRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteBearerTokenRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(deleteBearerTokenRequest.TokenId, out var valueOfTokenId)) urlParam.Add("token_id", valueOfTokenId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}/bearer-token/{token_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBearerTokenRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBearerTokenResponse>(response);
        }

        public AsyncInvoker<DeleteBearerTokenResponse> DeleteBearerTokenAsyncInvoker(DeleteBearerTokenRequest deleteBearerTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBearerTokenRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteBearerTokenRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(deleteBearerTokenRequest.TokenId, out var valueOfTokenId)) urlParam.Add("token_id", valueOfTokenId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}/bearer-token/{token_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBearerTokenRequest);
            return new AsyncInvoker<DeleteBearerTokenResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBearerTokenResponse>);
        }
        
        /// <summary>
        /// 删除自动预置
        ///
        /// 删除自动预置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteProvisioningTenantResponse> DeleteProvisioningTenantAsync(DeleteProvisioningTenantRequest deleteProvisioningTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProvisioningTenantRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteProvisioningTenantRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProvisioningTenantRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteProvisioningTenantResponse>(response);
        }

        public AsyncInvoker<DeleteProvisioningTenantResponse> DeleteProvisioningTenantAsyncInvoker(DeleteProvisioningTenantRequest deleteProvisioningTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProvisioningTenantRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteProvisioningTenantRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProvisioningTenantRequest);
            return new AsyncInvoker<DeleteProvisioningTenantResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProvisioningTenantResponse>);
        }
        
        /// <summary>
        /// 列出访问令牌
        ///
        /// 查询访问令牌列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBearerTokensResponse> ListBearerTokensAsync(ListBearerTokensRequest listBearerTokensRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBearerTokensRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(listBearerTokensRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}/bearer-token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBearerTokensRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBearerTokensResponse>(response);
        }

        public AsyncInvoker<ListBearerTokensResponse> ListBearerTokensAsyncInvoker(ListBearerTokensRequest listBearerTokensRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBearerTokensRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(listBearerTokensRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/tenant/{tenant_id}/bearer-token", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBearerTokensRequest);
            return new AsyncInvoker<ListBearerTokensResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBearerTokensResponse>);
        }
        
        /// <summary>
        /// 查询自动预置信息
        ///
        /// 查询是否开启自动预置，返回具体SCIM自动预配配置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProvisioningTenantsResponse> ListProvisioningTenantsAsync(ListProvisioningTenantsRequest listProvisioningTenantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProvisioningTenantsRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/provision-tenant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvisioningTenantsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProvisioningTenantsResponse>(response);
        }

        public AsyncInvoker<ListProvisioningTenantsResponse> ListProvisioningTenantsAsyncInvoker(ListProvisioningTenantsRequest listProvisioningTenantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProvisioningTenantsRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/provision-tenant", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvisioningTenantsRequest);
            return new AsyncInvoker<ListProvisioningTenantsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProvisioningTenantsResponse>);
        }
        
        /// <summary>
        /// 批量删除用户登录会话
        ///
        /// 批量删除用户登录会话。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteSessionsResponse> BatchDeleteSessionsAsync(BatchDeleteSessionsRequest batchDeleteSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteSessionsRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteSessionsRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/sessions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteSessionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteSessionsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteSessionsResponse> BatchDeleteSessionsAsyncInvoker(BatchDeleteSessionsRequest batchDeleteSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteSessionsRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteSessionsRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/sessions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteSessionsRequest);
            return new AsyncInvoker<BatchDeleteSessionsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteSessionsResponse>);
        }
        
        /// <summary>
        /// 列出用户MFA设备
        ///
        /// 查询指定用户的MFA设备列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchListMfaDevicesForUserResponse> BatchListMfaDevicesForUserAsync(BatchListMfaDevicesForUserRequest batchListMfaDevicesForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchListMfaDevicesForUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/retrieve-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListMfaDevicesForUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchListMfaDevicesForUserResponse>(response);
        }

        public AsyncInvoker<BatchListMfaDevicesForUserResponse> BatchListMfaDevicesForUserAsyncInvoker(BatchListMfaDevicesForUserRequest batchListMfaDevicesForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchListMfaDevicesForUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/retrieve-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListMfaDevicesForUserRequest);
            return new AsyncInvoker<BatchListMfaDevicesForUserResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListMfaDevicesForUserResponse>);
        }
        
        /// <summary>
        /// 创建用户
        ///
        /// 在指定的身份源中创建一个IAM身份中心用户。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateUserResponse>(response);
        }

        public AsyncInvoker<CreateUserResponse> CreateUserAsyncInvoker(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRequest);
            return new AsyncInvoker<CreateUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUserResponse>);
        }
        
        /// <summary>
        /// 删除用户MFA设备
        ///
        /// 删除用户绑定的MFA设备。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMfaDeviceForUserResponse> DeleteMfaDeviceForUserAsync(DeleteMfaDeviceForUserRequest deleteMfaDeviceForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMfaDeviceForUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMfaDeviceForUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMfaDeviceForUserRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/mfa-devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMfaDeviceForUserRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMfaDeviceForUserResponse>(response);
        }

        public AsyncInvoker<DeleteMfaDeviceForUserResponse> DeleteMfaDeviceForUserAsyncInvoker(DeleteMfaDeviceForUserRequest deleteMfaDeviceForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMfaDeviceForUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMfaDeviceForUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMfaDeviceForUserRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/mfa-devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMfaDeviceForUserRequest);
            return new AsyncInvoker<DeleteMfaDeviceForUserResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMfaDeviceForUserResponse>);
        }
        
        /// <summary>
        /// 删除用户
        ///
        /// 根据用户ID，删除对应的IAM身份中心用户。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserResponse>(response);
        }

        public AsyncInvoker<DeleteUserResponse> DeleteUserAsyncInvoker(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            return new AsyncInvoker<DeleteUserResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserResponse>);
        }
        
        /// <summary>
        /// 查询用户详情
        ///
        /// 根据用户ID，查询对应IAM身份中心用户的详情信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest describeUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(describeUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeUserRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribeUserResponse>(response);
        }

        public AsyncInvoker<DescribeUserResponse> DescribeUserAsyncInvoker(DescribeUserRequest describeUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(describeUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeUserRequest);
            return new AsyncInvoker<DescribeUserResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeUserResponse>);
        }
        
        /// <summary>
        /// 批量查询指定用户详情
        ///
        /// 批量查询指定用户详情。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeUsersResponse> DescribeUsersAsync(DescribeUsersRequest describeUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeUsersRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeUsersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DescribeUsersResponse>(response);
        }

        public AsyncInvoker<DescribeUsersResponse> DescribeUsersAsyncInvoker(DescribeUsersRequest describeUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeUsersRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeUsersRequest);
            return new AsyncInvoker<DescribeUsersResponse>(this, "POST", request, JsonUtils.DeSerialize<DescribeUsersResponse>);
        }
        
        /// <summary>
        /// 禁用用户
        ///
        /// 禁用IAM身份中心的用户。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableUserResponse> DisableUserAsync(DisableUserRequest disableUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(disableUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisableUserResponse>(response);
        }

        public AsyncInvoker<DisableUserResponse> DisableUserAsyncInvoker(DisableUserRequest disableUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(disableUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableUserRequest);
            return new AsyncInvoker<DisableUserResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableUserResponse>);
        }
        
        /// <summary>
        /// 启用用户
        ///
        /// 启用IAM身份中心的用户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableUserResponse> EnableUserAsync(EnableUserRequest enableUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(enableUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<EnableUserResponse>(response);
        }

        public AsyncInvoker<EnableUserResponse> EnableUserAsyncInvoker(EnableUserRequest enableUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(enableUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableUserRequest);
            return new AsyncInvoker<EnableUserResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableUserResponse>);
        }
        
        /// <summary>
        /// 查询用户ID
        ///
        /// 根据用户名或外部身份源ID，以精确匹配的方式查询用户ID。用户名和外部身份源ID两种查询方式二选一，不支持同时传入。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetUserIdResponse> GetUserIdAsync(GetUserIdRequest getUserIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getUserIdRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/retrieve-user-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getUserIdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<GetUserIdResponse>(response);
        }

        public AsyncInvoker<GetUserIdResponse> GetUserIdAsyncInvoker(GetUserIdRequest getUserIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getUserIdRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/retrieve-user-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getUserIdRequest);
            return new AsyncInvoker<GetUserIdResponse>(this, "POST", request, JsonUtils.DeSerialize<GetUserIdResponse>);
        }
        
        /// <summary>
        /// 列出用户登录会话
        ///
        /// 查询指定用户的登录会话信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest listSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSessionsRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(listSessionsRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSessionsResponse>(response);
        }

        public AsyncInvoker<ListSessionsResponse> ListSessionsAsyncInvoker(ListSessionsRequest listSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSessionsRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(listSessionsRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionsRequest);
            return new AsyncInvoker<ListSessionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSessionsResponse>);
        }
        
        /// <summary>
        /// 列出用户
        ///
        /// 查询指定身份源下的IAM身份中心用户列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUsersRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUsersResponse>(response);
        }

        public AsyncInvoker<ListUsersResponse> ListUsersAsyncInvoker(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUsersRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            return new AsyncInvoker<ListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersResponse>);
        }
        
        /// <summary>
        /// 注册MFA设备
        ///
        /// 为用户发起注册MFA设备，返回一个MFA注册地址。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RegisterMfaDeviceForUserResponse> RegisterMfaDeviceForUserAsync(RegisterMfaDeviceForUserRequest registerMfaDeviceForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(registerMfaDeviceForUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(registerMfaDeviceForUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/mfa-devices/register-mfa-device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerMfaDeviceForUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RegisterMfaDeviceForUserResponse>(response);
        }

        public AsyncInvoker<RegisterMfaDeviceForUserResponse> RegisterMfaDeviceForUserAsyncInvoker(RegisterMfaDeviceForUserRequest registerMfaDeviceForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(registerMfaDeviceForUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(registerMfaDeviceForUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/mfa-devices/register-mfa-device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerMfaDeviceForUserRequest);
            return new AsyncInvoker<RegisterMfaDeviceForUserResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterMfaDeviceForUserResponse>);
        }
        
        /// <summary>
        /// 通过电子邮件发送密码重置链接或生成用户的一次性密码
        ///
        /// 通过电子邮件发送密码重置链接或生成用户的一次性密码。。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetPwdModeResponse> ResetPwdModeAsync(ResetPwdModeRequest resetPwdModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetPwdModeRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(resetPwdModeRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/reset-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdModeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResetPwdModeResponse>(response);
        }

        public AsyncInvoker<ResetPwdModeResponse> ResetPwdModeAsyncInvoker(ResetPwdModeRequest resetPwdModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetPwdModeRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(resetPwdModeRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/reset-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPwdModeRequest);
            return new AsyncInvoker<ResetPwdModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetPwdModeResponse>);
        }
        
        /// <summary>
        /// 更新MFA设备显示名称
        ///
        /// 更新MFA设备显示名称。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMfaDeviceForUserResponse> UpdateMfaDeviceForUserAsync(UpdateMfaDeviceForUserRequest updateMfaDeviceForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMfaDeviceForUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(updateMfaDeviceForUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(updateMfaDeviceForUserRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/mfa-devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMfaDeviceForUserRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateMfaDeviceForUserResponse>(response);
        }

        public AsyncInvoker<UpdateMfaDeviceForUserResponse> UpdateMfaDeviceForUserAsyncInvoker(UpdateMfaDeviceForUserRequest updateMfaDeviceForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMfaDeviceForUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(updateMfaDeviceForUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(updateMfaDeviceForUserRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/mfa-devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMfaDeviceForUserRequest);
            return new AsyncInvoker<UpdateMfaDeviceForUserResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateMfaDeviceForUserResponse>);
        }
        
        /// <summary>
        /// 更新用户
        ///
        /// 根据用户ID，更新对应IAM身份中心用户的属性。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(updateUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateUserResponse>(response);
        }

        public AsyncInvoker<UpdateUserResponse> UpdateUserAsyncInvoker(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(updateUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            return new AsyncInvoker<UpdateUserResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateUserResponse>);
        }
        
        /// <summary>
        /// 验证用户邮箱
        ///
        /// 验证用户邮箱。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<VerifyEmailResponse> VerifyEmailAsync(VerifyEmailRequest verifyEmailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(verifyEmailRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(verifyEmailRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/verify-email", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", verifyEmailRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<VerifyEmailResponse>(response);
        }

        public AsyncInvoker<VerifyEmailResponse> VerifyEmailAsyncInvoker(VerifyEmailRequest verifyEmailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(verifyEmailRequest.IdentityStoreId, out var valueOfIdentityStoreId)) urlParam.Add("identity_store_id", valueOfIdentityStoreId);
            if (StringUtils.TryConvertToNonEmptyString(verifyEmailRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}/verify-email", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", verifyEmailRequest);
            return new AsyncInvoker<VerifyEmailResponse>(this, "POST", request, JsonUtils.DeSerializeNull<VerifyEmailResponse>);
        }
        
    }
}