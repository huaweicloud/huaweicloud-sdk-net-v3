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
        /// 在指定的身份源中创建一个IAM身份中心用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createGroupRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupResponse>(response);
        }

        public AsyncInvoker<CreateGroupResponse> CreateGroupAsyncInvoker(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createGroupRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupRequest);
            return new AsyncInvoker<CreateGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupResponse>);
        }
        
        /// <summary>
        /// 删除用户组
        ///
        /// 根据用户组ID，删除对应的IAM身份中心用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteGroupRequest.IdentityStoreId.ToString());
            urlParam.Add("group_id", deleteGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupResponse>(response);
        }

        public AsyncInvoker<DeleteGroupResponse> DeleteGroupAsyncInvoker(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteGroupRequest.IdentityStoreId.ToString());
            urlParam.Add("group_id", deleteGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            return new AsyncInvoker<DeleteGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupResponse>);
        }
        
        /// <summary>
        /// 查询用户组详情
        ///
        /// 根据用户组ID，查询IAM身份中心用户组的详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeGroupResponse> DescribeGroupAsync(DescribeGroupRequest describeGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeGroupRequest.IdentityStoreId.ToString());
            urlParam.Add("group_id", describeGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribeGroupResponse>(response);
        }

        public AsyncInvoker<DescribeGroupResponse> DescribeGroupAsyncInvoker(DescribeGroupRequest describeGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeGroupRequest.IdentityStoreId.ToString());
            urlParam.Add("group_id", describeGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupRequest);
            return new AsyncInvoker<DescribeGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeGroupResponse>);
        }
        
        /// <summary>
        /// 查询用户组ID
        ///
        /// 根据显示名或外部身份源ID，以精确匹配的方式查询用户组ID。显示名和外部身份源ID两种查询方式二选一，不支持同时传入。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetGroupIdResponse> GetGroupIdAsync(GetGroupIdRequest getGroupIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getGroupIdRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/retrieve-group-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getGroupIdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<GetGroupIdResponse>(response);
        }

        public AsyncInvoker<GetGroupIdResponse> GetGroupIdAsyncInvoker(GetGroupIdRequest getGroupIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getGroupIdRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/retrieve-group-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getGroupIdRequest);
            return new AsyncInvoker<GetGroupIdResponse>(this, "POST", request, JsonUtils.DeSerialize<GetGroupIdResponse>);
        }
        
        /// <summary>
        /// 列出用户组
        ///
        /// 查询指定身份源下的IAM身份中心用户组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest listGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listGroupsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGroupsResponse>(response);
        }

        public AsyncInvoker<ListGroupsResponse> ListGroupsAsyncInvoker(ListGroupsRequest listGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listGroupsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsRequest);
            return new AsyncInvoker<ListGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupsResponse>);
        }
        
        /// <summary>
        /// 更新用户组
        ///
        /// 根据用户组ID，更新对应IAM身份中心用户组的属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest updateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updateGroupRequest.IdentityStoreId.ToString());
            urlParam.Add("group_id", updateGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateGroupResponse>(response);
        }

        public AsyncInvoker<UpdateGroupResponse> UpdateGroupAsyncInvoker(UpdateGroupRequest updateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updateGroupRequest.IdentityStoreId.ToString());
            urlParam.Add("group_id", updateGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupRequest);
            return new AsyncInvoker<UpdateGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateGroupResponse>);
        }
        
        /// <summary>
        /// 绑定用户和组
        ///
        /// 将用户添加到用户组中，用户和用户组必须在同一身份源下。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGroupMembershipResponse> CreateGroupMembershipAsync(CreateGroupMembershipRequest createGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createGroupMembershipRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupMembershipRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupMembershipResponse>(response);
        }

        public AsyncInvoker<CreateGroupMembershipResponse> CreateGroupMembershipAsyncInvoker(CreateGroupMembershipRequest createGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createGroupMembershipRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupMembershipRequest);
            return new AsyncInvoker<CreateGroupMembershipResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupMembershipResponse>);
        }
        
        /// <summary>
        /// 解绑用户和组
        ///
        /// 根据关联关系ID解绑用户和用户组，也就是将用户移出用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGroupMembershipResponse> DeleteGroupMembershipAsync(DeleteGroupMembershipRequest deleteGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteGroupMembershipRequest.IdentityStoreId.ToString());
            urlParam.Add("membership_id", deleteGroupMembershipRequest.MembershipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/{membership_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupMembershipRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupMembershipResponse>(response);
        }

        public AsyncInvoker<DeleteGroupMembershipResponse> DeleteGroupMembershipAsyncInvoker(DeleteGroupMembershipRequest deleteGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteGroupMembershipRequest.IdentityStoreId.ToString());
            urlParam.Add("membership_id", deleteGroupMembershipRequest.MembershipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/{membership_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupMembershipRequest);
            return new AsyncInvoker<DeleteGroupMembershipResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupMembershipResponse>);
        }
        
        /// <summary>
        /// 查询绑定关系详情
        ///
        /// 根据关联关系ID，查询此关联关系的详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeGroupMembershipResponse> DescribeGroupMembershipAsync(DescribeGroupMembershipRequest describeGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeGroupMembershipRequest.IdentityStoreId.ToString());
            urlParam.Add("membership_id", describeGroupMembershipRequest.MembershipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/{membership_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupMembershipRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribeGroupMembershipResponse>(response);
        }

        public AsyncInvoker<DescribeGroupMembershipResponse> DescribeGroupMembershipAsyncInvoker(DescribeGroupMembershipRequest describeGroupMembershipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeGroupMembershipRequest.IdentityStoreId.ToString());
            urlParam.Add("membership_id", describeGroupMembershipRequest.MembershipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/{membership_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeGroupMembershipRequest);
            return new AsyncInvoker<DescribeGroupMembershipResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeGroupMembershipResponse>);
        }
        
        /// <summary>
        /// 查询绑定关系ID
        ///
        /// 根据用户ID和用户组ID，查询对应的关联关系ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetGroupMembershipIdResponse> GetGroupMembershipIdAsync(GetGroupMembershipIdRequest getGroupMembershipIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getGroupMembershipIdRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/retrieve-group-membership-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getGroupMembershipIdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<GetGroupMembershipIdResponse>(response);
        }

        public AsyncInvoker<GetGroupMembershipIdResponse> GetGroupMembershipIdAsyncInvoker(GetGroupMembershipIdRequest getGroupMembershipIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getGroupMembershipIdRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships/retrieve-group-membership-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getGroupMembershipIdRequest);
            return new AsyncInvoker<GetGroupMembershipIdResponse>(this, "POST", request, JsonUtils.DeSerialize<GetGroupMembershipIdResponse>);
        }
        
        /// <summary>
        /// 查询用户是否为用户组成员
        ///
        /// 根据用户ID和用户组ID列表，查询用户是否为用户组的成员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<IsMemberInGroupsResponse> IsMemberInGroupsAsync(IsMemberInGroupsRequest isMemberInGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", isMemberInGroupsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/is-member-in-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", isMemberInGroupsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<IsMemberInGroupsResponse>(response);
        }

        public AsyncInvoker<IsMemberInGroupsResponse> IsMemberInGroupsAsyncInvoker(IsMemberInGroupsRequest isMemberInGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", isMemberInGroupsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/is-member-in-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", isMemberInGroupsRequest);
            return new AsyncInvoker<IsMemberInGroupsResponse>(this, "POST", request, JsonUtils.DeSerialize<IsMemberInGroupsResponse>);
        }
        
        /// <summary>
        /// 列出组中的用户
        ///
        /// 根据用户组ID，列出用户组中的用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupMembershipsResponse> ListGroupMembershipsAsync(ListGroupMembershipsRequest listGroupMembershipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listGroupMembershipsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembershipsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGroupMembershipsResponse>(response);
        }

        public AsyncInvoker<ListGroupMembershipsResponse> ListGroupMembershipsAsyncInvoker(ListGroupMembershipsRequest listGroupMembershipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listGroupMembershipsRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembershipsRequest);
            return new AsyncInvoker<ListGroupMembershipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupMembershipsResponse>);
        }
        
        /// <summary>
        /// 列出用户加入的组
        ///
        /// 根据用户ID，列出用户加入的用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupMembershipsForMemberResponse> ListGroupMembershipsForMemberAsync(ListGroupMembershipsForMemberRequest listGroupMembershipsForMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listGroupMembershipsForMemberRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships-for-member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembershipsForMemberRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGroupMembershipsForMemberResponse>(response);
        }

        public AsyncInvoker<ListGroupMembershipsForMemberResponse> ListGroupMembershipsForMemberAsyncInvoker(ListGroupMembershipsForMemberRequest listGroupMembershipsForMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listGroupMembershipsForMemberRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/group-memberships-for-member", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembershipsForMemberRequest);
            return new AsyncInvoker<ListGroupMembershipsForMemberResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupMembershipsForMemberResponse>);
        }
        
        /// <summary>
        /// 创建用户
        ///
        /// 在指定的身份源中创建一个IAM身份中心用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createUserRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateUserResponse>(response);
        }

        public AsyncInvoker<CreateUserResponse> CreateUserAsyncInvoker(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", createUserRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRequest);
            return new AsyncInvoker<CreateUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUserResponse>);
        }
        
        /// <summary>
        /// 删除用户
        ///
        /// 根据用户ID，删除对应的IAM身份中心用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", deleteUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserResponse>(response);
        }

        public AsyncInvoker<DeleteUserResponse> DeleteUserAsyncInvoker(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", deleteUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", deleteUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            return new AsyncInvoker<DeleteUserResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserResponse>);
        }
        
        /// <summary>
        /// 查询用户详情
        ///
        /// 根据用户ID，查询对应IAM身份中心用户的详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest describeUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", describeUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeUserRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribeUserResponse>(response);
        }

        public AsyncInvoker<DescribeUserResponse> DescribeUserAsyncInvoker(DescribeUserRequest describeUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", describeUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", describeUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeUserRequest);
            return new AsyncInvoker<DescribeUserResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeUserResponse>);
        }
        
        /// <summary>
        /// 查询用户ID
        ///
        /// 根据用户名或外部身份源ID，以精确匹配的方式查询用户ID。用户名和外部身份源ID两种查询方式二选一，不支持同时传入。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetUserIdResponse> GetUserIdAsync(GetUserIdRequest getUserIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getUserIdRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/retrieve-user-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getUserIdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<GetUserIdResponse>(response);
        }

        public AsyncInvoker<GetUserIdResponse> GetUserIdAsyncInvoker(GetUserIdRequest getUserIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", getUserIdRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/retrieve-user-id", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getUserIdRequest);
            return new AsyncInvoker<GetUserIdResponse>(this, "POST", request, JsonUtils.DeSerialize<GetUserIdResponse>);
        }
        
        /// <summary>
        /// 列出用户
        ///
        /// 查询指定身份源下的IAM身份中心用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listUsersRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUsersResponse>(response);
        }

        public AsyncInvoker<ListUsersResponse> ListUsersAsyncInvoker(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", listUsersRequest.IdentityStoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            return new AsyncInvoker<ListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersResponse>);
        }
        
        /// <summary>
        /// 更新用户
        ///
        /// 根据用户ID，更新对应IAM身份中心用户的属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updateUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", updateUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateUserResponse>(response);
        }

        public AsyncInvoker<UpdateUserResponse> UpdateUserAsyncInvoker(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("identity_store_id", updateUserRequest.IdentityStoreId.ToString());
            urlParam.Add("user_id", updateUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-stores/{identity_store_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            return new AsyncInvoker<UpdateUserResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateUserResponse>);
        }
        
    }
}