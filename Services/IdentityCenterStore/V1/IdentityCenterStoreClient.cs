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
        /// 在指定的身份源中创建一个IAM身份中心用户组。
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
        /// 根据用户组ID，删除对应的IAM身份中心用户组。
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
        /// 根据用户组ID，查询IAM身份中心用户组的详情信息。
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
        /// 查询用户组ID
        ///
        /// 根据显示名或外部身份源ID，以精确匹配的方式查询用户组ID。显示名和外部身份源ID两种查询方式二选一，不支持同时传入。
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
        /// 查询指定身份源下的IAM身份中心用户组列表。
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
        /// 根据用户组ID，更新对应IAM身份中心用户组的属性。
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
        /// 将用户添加到用户组中，用户和用户组必须在同一身份源下。
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
        /// 根据关联关系ID解绑用户和用户组，也就是将用户移出用户组。
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
        /// 根据关联关系ID，查询此关联关系的详情信息。
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
        /// 根据用户ID和用户组ID，查询对应的关联关系ID。
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
        /// 查询用户是否为用户组成员
        ///
        /// 根据用户ID和用户组ID列表，查询用户是否为用户组的成员。
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
        /// 根据用户组ID，列出用户组中的用户。
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
        /// 根据用户ID，列出用户加入的用户组。
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
        /// 创建用户
        ///
        /// 在指定的身份源中创建一个IAM身份中心用户。
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
        /// 删除用户
        ///
        /// 根据用户ID，删除对应的IAM身份中心用户。
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
        /// 根据用户ID，查询对应IAM身份中心用户的详情信息。
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
        /// 查询用户ID
        ///
        /// 根据用户名或外部身份源ID，以精确匹配的方式查询用户ID。用户名和外部身份源ID两种查询方式二选一，不支持同时传入。
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
        /// 列出用户
        ///
        /// 查询指定身份源下的IAM身份中心用户列表。
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
        /// 更新用户
        ///
        /// 根据用户ID，更新对应IAM身份中心用户的属性。
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
        
    }
}