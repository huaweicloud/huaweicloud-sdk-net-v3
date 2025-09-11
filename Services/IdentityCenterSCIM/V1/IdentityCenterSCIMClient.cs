using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.IdentityCenterSCIM.V1.Model;

namespace HuaweiCloud.SDK.IdentityCenterSCIM.V1
{
    public partial class IdentityCenterSCIMClient : Client
    {
        public static ClientBuilder<IdentityCenterSCIMClient> NewBuilder()
        {
            return new ClientBuilder<IdentityCenterSCIMClient>("IdentityCenterSCIMCredentials");
        }

        
        /// <summary>
        /// 创建用户组
        ///
        /// 使用SCIM协议，同步用户组到IAM身份中心。
        /// 约束条件
        /// IAM身份中心对此API操作具有以下约束。
        /// - displayName、schemas为必填项
        /// - 在单个请求中最多可以添加100个成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGroupResponse CreateGroup(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupResponse>(response);
        }

        public SyncInvoker<CreateGroupResponse> CreateGroupInvoker(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupRequest);
            return new SyncInvoker<CreateGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupResponse>);
        }
        
        /// <summary>
        /// 删除用户组
        ///
        /// 删除现有用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupResponse>(response);
        }

        public SyncInvoker<DeleteGroupResponse> DeleteGroupInvoker(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            return new SyncInvoker<DeleteGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupResponse>);
        }
        
        /// <summary>
        /// 查询用户组详情
        ///
        /// 查询现有用户组的详情信息。
        /// 暂不支持
        /// IAM身份中心暂不支持此API操作的以下方面。
        /// - 查询用户组详情接口和列出用户组接口返回空成员列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetGroupResponse GetGroup(GetGroupRequest getGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getGroupRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(getGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetGroupResponse>(response);
        }

        public SyncInvoker<GetGroupResponse> GetGroupInvoker(GetGroupRequest getGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getGroupRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(getGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getGroupRequest);
            return new SyncInvoker<GetGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<GetGroupResponse>);
        }
        
        /// <summary>
        /// 列出用户组
        ///
        /// 对现有用户组列表执行筛选查询，最多只能返回50个结果。
        /// 暂不支持
        /// IAM身份中心暂不支持此API操作的以下方面。
        /// - 查询用户组详情接口和列出用户组接口返回空成员列表
        /// 
        /// 约束条件
        /// IAM身份中心对此API操作具有以下约束。
        /// - 目前，列出用户组接口最多只能返回50个结果
        /// - 支持的筛选器组合：(displayName)、(id)。请注意，使用id作为单个过滤器虽然有效，但应避免使用，因为已经有一个查询用户组详情接口可用
        /// - 过滤器中支持的比较运算符：eq
        /// - 必须按如下方式指定筛选器：&lt;filterAttribute&gt; eq \&quot;&lt;filterValue&gt;\&quot;
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupsResponse ListGroups(ListGroupsRequest listGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupsRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGroupsResponse>(response);
        }

        public SyncInvoker<ListGroupsResponse> ListGroupsInvoker(ListGroupsRequest listGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupsRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsRequest);
            return new SyncInvoker<ListGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupsResponse>);
        }
        
        /// <summary>
        /// 部分更新用户组
        ///
        /// 修改现有用户组的部分属性，和管理用户组中的用户。
        /// 约束条件
        /// IAM身份中心对此API操作具有以下约束。
        /// - 请求中只允许使用displayName、 members和externalId属性
        /// - 单个请求中最多允许100个成员更改
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PatchGroupResponse PatchGroup(PatchGroupRequest patchGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(patchGroupRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(patchGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", patchGroupRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<PatchGroupResponse>(response);
        }

        public SyncInvoker<PatchGroupResponse> PatchGroupInvoker(PatchGroupRequest patchGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(patchGroupRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(patchGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", patchGroupRequest);
            return new SyncInvoker<PatchGroupResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<PatchGroupResponse>);
        }
        
        /// <summary>
        /// 查询服务提供商配置
        ///
        /// 查询IAM身份中心的SCIM相关配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ServiceProviderConfigResponse ServiceProviderConfig(ServiceProviderConfigRequest serviceProviderConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(serviceProviderConfigRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/ServiceProviderConfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", serviceProviderConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ServiceProviderConfigResponse>(response);
        }

        public SyncInvoker<ServiceProviderConfigResponse> ServiceProviderConfigInvoker(ServiceProviderConfigRequest serviceProviderConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(serviceProviderConfigRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/ServiceProviderConfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", serviceProviderConfigRequest);
            return new SyncInvoker<ServiceProviderConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ServiceProviderConfigResponse>);
        }
        
        /// <summary>
        /// 创建用户
        ///
        /// 使用SCIM协议，同步用户到IAM身份中心。
        /// 暂不支持
        /// IAM身份中心暂不支持此API操作的以下方面。
        /// - ims、photos、x509Certificates、entitlements和password属性
        /// - manager的displayName子属性
        /// - emails、addresses和phoneNumbers的display子属性
        /// 
        /// 约束条件
        /// IAM身份中心对此API操作具有以下约束。
        /// - 必须填写userName、displayName、schemas属性，name属性中的familyName、givenName子属性，emails属性中的value、primary、type子属性
        /// - addresses可以包含字母、重音字符、符号、数字、标点符号、空格（正常和不换行）
        /// - 我们不支持多值属性中的多个值（例如emails,addresses,phoneNumbers）。只允许单个值
        /// - emails属性值必须标记为primary
        /// - 不能指定groups字段
        /// - userName字段可以包含字母、数字和部分符号_+&#x3D;,.@-
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateUserResponse CreateUser(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUserRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateUserResponse>(response);
        }

        public SyncInvoker<CreateUserResponse> CreateUserInvoker(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUserRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRequest);
            return new SyncInvoker<CreateUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUserResponse>);
        }
        
        /// <summary>
        /// 删除用户
        ///
        /// 删除现有用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteUserResponse DeleteUser(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserResponse>(response);
        }

        public SyncInvoker<DeleteUserResponse> DeleteUserInvoker(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            return new SyncInvoker<DeleteUserResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserResponse>);
        }
        
        /// <summary>
        /// 查询用户详情
        ///
        /// 查询现有用户的详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetUserResponse GetUser(GetUserRequest getUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getUserRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(getUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getUserRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetUserResponse>(response);
        }

        public SyncInvoker<GetUserResponse> GetUserInvoker(GetUserRequest getUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getUserRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(getUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getUserRequest);
            return new SyncInvoker<GetUserResponse>(this, "GET", request, JsonUtils.DeSerialize<GetUserResponse>);
        }
        
        /// <summary>
        /// 列出用户
        ///
        /// 对现有用户列表执行筛选查询，最多只能返回50个结果。
        /// 暂不支持
        /// IAM身份中心不支持此API操作的以下方面。
        /// - startIndex,attributes,excludedAttributes（虽在SCIM协议中列出）
        /// 
        /// 约束条件
        /// IAM身份中心对此API操作具有以下约束。
        /// - 目前，列出用户接口最多只能返回50个结果
        /// - 支持的筛选器组合：(userName)、(id)。请注意，使用id作为单个过滤器虽然有效，但应避免使用，因为已经有一个查询用户详情接口可用
        /// - 过滤器中支持的比较运算符：eq
        /// - 必须按如下方式指定筛选器：&lt;filterAttribute&gt; eq \&quot;&lt;filterValue&gt;\&quot;
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUsersResponse ListUsers(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUsersRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUsersResponse>(response);
        }

        public SyncInvoker<ListUsersResponse> ListUsersInvoker(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUsersRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            return new SyncInvoker<ListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersResponse>);
        }
        
        /// <summary>
        /// 部分更新用户
        ///
        /// 修改现有用户的部分属性。
        /// 暂不支持
        /// IAM身份中心暂不支持此API操作的以下方面。
        /// - 对userName或active属性执行多个PATCH操作
        /// - ims、photos、x509Certificates、entitlements和password属性
        /// - manager的displayName子属性
        /// - emails、addresses和phoneNumbers的display子属性
        /// 
        /// 约束条件
        /// IAM身份中心对此API操作具有以下约束。
        /// - 支持的操作是add、replace和remove
        /// - 必须指定操作
        /// - remove操作需要指定属性路径
        /// - add和replace操作需要指定属性的值
        /// - 仅允许修改userName、active、externalId、displayName、nickName、profileUrl、title、userType、preferredLanguage、locale、timezone、name、enterprise、emails、addresses和phoneNumbers属性
        /// - 过滤器中仅支持eq运算符
        /// - userName或active属性不支持remove操作
        /// - 我们不支持多值属性中的多个值（例如emails,addresses,phoneNumbers）。这些属性中的每一个都只允许有一个值
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PatchUserResponse PatchUser(PatchUserRequest patchUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(patchUserRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(patchUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", patchUserRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<PatchUserResponse>(response);
        }

        public SyncInvoker<PatchUserResponse> PatchUserInvoker(PatchUserRequest patchUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(patchUserRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(patchUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", patchUserRequest);
            return new SyncInvoker<PatchUserResponse>(this, "PATCH", request, JsonUtils.DeSerialize<PatchUserResponse>);
        }
        
        /// <summary>
        /// 更新用户
        ///
        /// 更新现有用户。
        /// 暂不支持
        /// IAM身份中心暂不支持此API操作的以下方面。
        /// - ims、photos、x509Certificates、entitlements和password属性
        /// - manager的displayName子属性
        /// - emails、addresses和phoneNumbers的display子属性
        /// 
        /// 约束条件
        /// IAM身份中心对此API操作具有以下约束。
        /// - 必须填写userName、displayName、schemas属性，name属性中的familyName、givenName子属性，emails属性中的value、primary、type子属性
        /// - addresses可以包含字母、重音字符、符号、数字、标点符号、空格（正常和不换行）
        /// - 我们不支持多值属性中的多个值（例如emails,addresses,phoneNumbers）
        /// - emails属性值必须标记为primary
        /// - 不能指定groups属性
        /// - userName字段可以包含字母、数字和部分符号_+&#x3D;,.@-
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PutUserResponse PutUser(PutUserRequest putUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(putUserRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(putUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putUserRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<PutUserResponse>(response);
        }

        public SyncInvoker<PutUserResponse> PutUserInvoker(PutUserRequest putUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(putUserRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(putUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/{tenant_id}/scim/v2/Users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putUserRequest);
            return new SyncInvoker<PutUserResponse>(this, "PUT", request, JsonUtils.DeSerialize<PutUserResponse>);
        }
        
    }
}