using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Iam.V3.Model;

namespace HuaweiCloud.SDK.Iam.V3
{
    public partial class IamAsyncClient : Client
    {
        public static ClientBuilder<IamAsyncClient> NewBuilder()
        {
            return new ClientBuilder<IamAsyncClient>();
        }

        
        /// <summary>
        /// 为委托授予全局服务权限
        /// </summary>
        public async Task<AssociateAgencyWithDomainPermissionResponse> AssociateAgencyWithDomainPermissionAsync(AssociateAgencyWithDomainPermissionRequest associateAgencyWithDomainPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , associateAgencyWithDomainPermissionRequest.AgencyId.ToString());
            urlParam.Add("role_id" , associateAgencyWithDomainPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, associateAgencyWithDomainPermissionRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithDomainPermissionResponse>(response);
        }
        
        /// <summary>
        /// 为委托授予项目服务权限
        /// </summary>
        public async Task<AssociateAgencyWithProjectPermissionResponse> AssociateAgencyWithProjectPermissionAsync(AssociateAgencyWithProjectPermissionRequest associateAgencyWithProjectPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , associateAgencyWithProjectPermissionRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , associateAgencyWithProjectPermissionRequest.AgencyId.ToString());
            urlParam.Add("role_id" , associateAgencyWithProjectPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, associateAgencyWithProjectPermissionRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithProjectPermissionResponse>(response);
        }
        
        /// <summary>
        /// 查询委托是否拥有全局服务权限
        /// </summary>
        public async Task<CheckDomainPermissionForAgencyResponse> CheckDomainPermissionForAgencyAsync(CheckDomainPermissionForAgencyRequest checkDomainPermissionForAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , checkDomainPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , checkDomainPermissionForAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, checkDomainPermissionForAgencyRequest);
            SdkResponse response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<CheckDomainPermissionForAgencyResponse>(response);
        }
        
        /// <summary>
        /// 查询委托是否拥有项目服务权限
        /// </summary>
        public async Task<CheckProjectPermissionForAgencyResponse> CheckProjectPermissionForAgencyAsync(CheckProjectPermissionForAgencyRequest checkProjectPermissionForAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , checkProjectPermissionForAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , checkProjectPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , checkProjectPermissionForAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, checkProjectPermissionForAgencyRequest);
            SdkResponse response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<CheckProjectPermissionForAgencyResponse>(response);
        }
        
        /// <summary>
        /// 创建委托
        /// </summary>
        public async Task<CreateAgencyResponse> CreateAgencyAsync(CreateAgencyRequest createAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAgencyResponse>(response);
        }
        
        /// <summary>
        /// 创建委托自定义策略
        /// </summary>
        public async Task<CreateAgencyCustomPolicyResponse> CreateAgencyCustomPolicyAsync(CreateAgencyCustomPolicyRequest createAgencyCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyCustomPolicyRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAgencyCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务自定义策略
        /// </summary>
        public async Task<CreateCloudServiceCustomPolicyResponse> CreateCloudServiceCustomPolicyAsync(CreateCloudServiceCustomPolicyRequest createCloudServiceCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCloudServiceCustomPolicyRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCloudServiceCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 删除委托
        /// </summary>
        public async Task<DeleteAgencyResponse> DeleteAgencyAsync(DeleteAgencyRequest deleteAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , deleteAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteAgencyRequest);
            SdkResponse response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAgencyResponse>(response);
        }
        
        /// <summary>
        /// 删除自定义策略
        /// </summary>
        public async Task<DeleteCustomPolicyResponse> DeleteCustomPolicyAsync(DeleteCustomPolicyRequest deleteCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , deleteCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteCustomPolicyRequest);
            SdkResponse response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 添加IAM用户到用户组
        /// </summary>
        public async Task<KeystoneAddUserToGroupResponse> KeystoneAddUserToGroupAsync(KeystoneAddUserToGroupRequest keystoneAddUserToGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneAddUserToGroupRequest.GroupId.ToString());
            urlParam.Add("user_id" , keystoneAddUserToGroupRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneAddUserToGroupRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAddUserToGroupResponse>(response);
        }
        
        /// <summary>
        /// 为用户组授予所有项目服务权限
        /// </summary>
        public async Task<KeystoneAssociateGroupWithAllProjectPermissionResponse> KeystoneAssociateGroupWithAllProjectPermissionAsync(KeystoneAssociateGroupWithAllProjectPermissionRequest keystoneAssociateGroupWithAllProjectPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneAssociateGroupWithAllProjectPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneAssociateGroupWithAllProjectPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneAssociateGroupWithAllProjectPermissionRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithAllProjectPermissionResponse>(response);
        }
        
        /// <summary>
        /// 为用户组授予全局服务权限
        /// </summary>
        public async Task<KeystoneAssociateGroupWithDomainPermissionResponse> KeystoneAssociateGroupWithDomainPermissionAsync(KeystoneAssociateGroupWithDomainPermissionRequest keystoneAssociateGroupWithDomainPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneAssociateGroupWithDomainPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneAssociateGroupWithDomainPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneAssociateGroupWithDomainPermissionRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithDomainPermissionResponse>(response);
        }
        
        /// <summary>
        /// 为用户组授予项目服务权限
        /// </summary>
        public async Task<KeystoneAssociateGroupWithProjectPermissionResponse> KeystoneAssociateGroupWithProjectPermissionAsync(KeystoneAssociateGroupWithProjectPermissionRequest keystoneAssociateGroupWithProjectPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneAssociateGroupWithProjectPermissionRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneAssociateGroupWithProjectPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneAssociateGroupWithProjectPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneAssociateGroupWithProjectPermissionRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithProjectPermissionResponse>(response);
        }
        
        /// <summary>
        /// 查询用户组是否拥有全局服务权限
        /// </summary>
        public async Task<KeystoneCheckDomainPermissionForGroupResponse> KeystoneCheckDomainPermissionForGroupAsync(KeystoneCheckDomainPermissionForGroupRequest keystoneCheckDomainPermissionForGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneCheckDomainPermissionForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneCheckDomainPermissionForGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneCheckDomainPermissionForGroupRequest);
            SdkResponse response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<KeystoneCheckDomainPermissionForGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询用户组是否拥有项目服务权限
        /// </summary>
        public async Task<KeystoneCheckProjectPermissionForGroupResponse> KeystoneCheckProjectPermissionForGroupAsync(KeystoneCheckProjectPermissionForGroupRequest keystoneCheckProjectPermissionForGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneCheckProjectPermissionForGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneCheckProjectPermissionForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneCheckProjectPermissionForGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneCheckProjectPermissionForGroupRequest);
            SdkResponse response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<KeystoneCheckProjectPermissionForGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户是否在用户组中
        /// </summary>
        public async Task<KeystoneCheckUserInGroupResponse> KeystoneCheckUserInGroupAsync(KeystoneCheckUserInGroupRequest keystoneCheckUserInGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneCheckUserInGroupRequest.GroupId.ToString());
            urlParam.Add("user_id" , keystoneCheckUserInGroupRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneCheckUserInGroupRequest);
            SdkResponse response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<KeystoneCheckUserInGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建用户组
        /// </summary>
        public async Task<KeystoneCreateGroupResponse> KeystoneCreateGroupAsync(KeystoneCreateGroupRequest keystoneCreateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateGroupRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建项目
        /// </summary>
        public async Task<KeystoneCreateProjectResponse> KeystoneCreateProjectAsync(KeystoneCreateProjectRequest keystoneCreateProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateProjectRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateProjectResponse>(response);
        }
        
        /// <summary>
        /// 删除用户组
        /// </summary>
        public async Task<KeystoneDeleteGroupResponse> KeystoneDeleteGroupAsync(KeystoneDeleteGroupRequest keystoneDeleteGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneDeleteGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneDeleteGroupRequest);
            SdkResponse response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户可以访问的账号详情
        /// </summary>
        public async Task<KeystoneListAuthDomainsResponse> KeystoneListAuthDomainsAsync(KeystoneListAuthDomainsRequest keystoneListAuthDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListAuthDomainsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListAuthDomainsResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户可以访问的项目列表
        /// </summary>
        public async Task<KeystoneListAuthProjectsResponse> KeystoneListAuthProjectsAsync(KeystoneListAuthProjectsRequest keystoneListAuthProjectsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListAuthProjectsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListAuthProjectsResponse>(response);
        }
        
        /// <summary>
        /// 查询全局服务中的用户组权限
        /// </summary>
        public async Task<KeystoneListDomainPermissionsForGroupResponse> KeystoneListDomainPermissionsForGroupAsync(KeystoneListDomainPermissionsForGroupRequest keystoneListDomainPermissionsForGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneListDomainPermissionsForGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListDomainPermissionsForGroupRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListDomainPermissionsForGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询终端节点列表
        /// </summary>
        public async Task<KeystoneListEndpointsResponse> KeystoneListEndpointsAsync(KeystoneListEndpointsRequest keystoneListEndpointsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/endpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListEndpointsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListEndpointsResponse>(response);
        }
        
        /// <summary>
        /// 查询用户组列表
        /// </summary>
        public async Task<KeystoneListGroupsResponse> KeystoneListGroupsAsync(KeystoneListGroupsRequest keystoneListGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListGroupsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询权限列表
        /// </summary>
        public async Task<KeystoneListPermissionsResponse> KeystoneListPermissionsAsync(KeystoneListPermissionsRequest keystoneListPermissionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListPermissionsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListPermissionsResponse>(response);
        }
        
        /// <summary>
        /// 查询项目服务中的用户组权限
        /// </summary>
        public async Task<KeystoneListProjectPermissionsForGroupResponse> KeystoneListProjectPermissionsForGroupAsync(KeystoneListProjectPermissionsForGroupRequest keystoneListProjectPermissionsForGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneListProjectPermissionsForGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneListProjectPermissionsForGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListProjectPermissionsForGroupRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListProjectPermissionsForGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询指定条件下的项目列表
        /// </summary>
        public async Task<KeystoneListProjectsResponse> KeystoneListProjectsAsync(KeystoneListProjectsRequest keystoneListProjectsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListProjectsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListProjectsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定IAM用户的项目列表
        /// </summary>
        public async Task<KeystoneListProjectsForUserResponse> KeystoneListProjectsForUserAsync(KeystoneListProjectsForUserRequest keystoneListProjectsForUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneListProjectsForUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListProjectsForUserRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListProjectsForUserResponse>(response);
        }
        
        /// <summary>
        /// 查询区域列表
        /// </summary>
        public async Task<KeystoneListRegionsResponse> KeystoneListRegionsAsync(KeystoneListRegionsRequest keystoneListRegionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/regions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListRegionsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListRegionsResponse>(response);
        }
        
        /// <summary>
        /// 查询服务列表
        /// </summary>
        public async Task<KeystoneListServicesResponse> KeystoneListServicesAsync(KeystoneListServicesRequest keystoneListServicesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/services",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListServicesRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListServicesResponse>(response);
        }
        
        /// <summary>
        /// 管理员查询用户组所包含的IAM用户
        /// </summary>
        public async Task<KeystoneListUsersForGroupByAdminResponse> KeystoneListUsersForGroupByAdminAsync(KeystoneListUsersForGroupByAdminRequest keystoneListUsersForGroupByAdminRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneListUsersForGroupByAdminRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListUsersForGroupByAdminRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListUsersForGroupByAdminResponse>(response);
        }
        
        /// <summary>
        /// 查询版本信息列表
        /// </summary>
        public async Task<KeystoneListVersionsResponse> KeystoneListVersionsAsync(KeystoneListVersionsRequest keystoneListVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListVersionsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerializeNull<KeystoneListVersionsResponse>(response);
        }
        
        /// <summary>
        /// 移除用户组的全局服务权限
        /// </summary>
        public async Task<KeystoneRemoveDomainPermissionFromGroupResponse> KeystoneRemoveDomainPermissionFromGroupAsync(KeystoneRemoveDomainPermissionFromGroupRequest keystoneRemoveDomainPermissionFromGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneRemoveDomainPermissionFromGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneRemoveDomainPermissionFromGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneRemoveDomainPermissionFromGroupRequest);
            SdkResponse response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveDomainPermissionFromGroupResponse>(response);
        }
        
        /// <summary>
        /// 移除用户组的项目服务权限
        /// </summary>
        public async Task<KeystoneRemoveProjectPermissionFromGroupResponse> KeystoneRemoveProjectPermissionFromGroupAsync(KeystoneRemoveProjectPermissionFromGroupRequest keystoneRemoveProjectPermissionFromGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneRemoveProjectPermissionFromGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneRemoveProjectPermissionFromGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneRemoveProjectPermissionFromGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneRemoveProjectPermissionFromGroupRequest);
            SdkResponse response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveProjectPermissionFromGroupResponse>(response);
        }
        
        /// <summary>
        /// 移除用户组中的IAM用户
        /// </summary>
        public async Task<KeystoneRemoveUserFromGroupResponse> KeystoneRemoveUserFromGroupAsync(KeystoneRemoveUserFromGroupRequest keystoneRemoveUserFromGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneRemoveUserFromGroupRequest.GroupId.ToString());
            urlParam.Add("user_id" , keystoneRemoveUserFromGroupRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneRemoveUserFromGroupRequest);
            SdkResponse response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveUserFromGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询服务目录
        /// </summary>
        public async Task<KeystoneShowCatalogResponse> KeystoneShowCatalogAsync(KeystoneShowCatalogRequest keystoneShowCatalogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/catalog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowCatalogRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowCatalogResponse>(response);
        }
        
        /// <summary>
        /// 查询终端节点详情
        /// </summary>
        public async Task<KeystoneShowEndpointResponse> KeystoneShowEndpointAsync(KeystoneShowEndpointRequest keystoneShowEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id" , keystoneShowEndpointRequest.EndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/endpoints/{endpoint_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowEndpointRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowEndpointResponse>(response);
        }
        
        /// <summary>
        /// 查询用户组详情
        /// </summary>
        public async Task<KeystoneShowGroupResponse> KeystoneShowGroupAsync(KeystoneShowGroupRequest keystoneShowGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneShowGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowGroupRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询权限详情
        /// </summary>
        public async Task<KeystoneShowPermissionResponse> KeystoneShowPermissionAsync(KeystoneShowPermissionRequest keystoneShowPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , keystoneShowPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowPermissionRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowPermissionResponse>(response);
        }
        
        /// <summary>
        /// 查询项目详情
        /// </summary>
        public async Task<KeystoneShowProjectResponse> KeystoneShowProjectAsync(KeystoneShowProjectRequest keystoneShowProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneShowProjectRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowProjectRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowProjectResponse>(response);
        }
        
        /// <summary>
        /// 查询区域详情
        /// </summary>
        public async Task<KeystoneShowRegionResponse> KeystoneShowRegionAsync(KeystoneShowRegionRequest keystoneShowRegionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("region_id" , keystoneShowRegionRequest.RegionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/regions/{region_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowRegionRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowRegionResponse>(response);
        }
        
        /// <summary>
        /// 查询账号密码强度策略
        /// </summary>
        public async Task<KeystoneShowSecurityComplianceResponse> KeystoneShowSecurityComplianceAsync(KeystoneShowSecurityComplianceRequest keystoneShowSecurityComplianceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowSecurityComplianceRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowSecurityComplianceResponse>(response);
        }
        
        /// <summary>
        /// 按条件查询账号密码强度策略
        /// </summary>
        public async Task<KeystoneShowSecurityComplianceByOptionResponse> KeystoneShowSecurityComplianceByOptionAsync(KeystoneShowSecurityComplianceByOptionRequest keystoneShowSecurityComplianceByOptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("option" , keystoneShowSecurityComplianceByOptionRequest.Option.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance/{option}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowSecurityComplianceByOptionRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowSecurityComplianceByOptionResponse>(response);
        }
        
        /// <summary>
        /// 查询服务详情
        /// </summary>
        public async Task<KeystoneShowServiceResponse> KeystoneShowServiceAsync(KeystoneShowServiceRequest keystoneShowServiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("service_id" , keystoneShowServiceRequest.ServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/services/{service_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowServiceRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowServiceResponse>(response);
        }
        
        /// <summary>
        /// 查询版本信息
        /// </summary>
        public async Task<KeystoneShowVersionResponse> KeystoneShowVersionAsync(KeystoneShowVersionRequest keystoneShowVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowVersionRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowVersionResponse>(response);
        }
        
        /// <summary>
        /// 更新用户组
        /// </summary>
        public async Task<KeystoneUpdateGroupResponse> KeystoneUpdateGroupAsync(KeystoneUpdateGroupRequest keystoneUpdateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneUpdateGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateGroupRequest);
            SdkResponse response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateGroupResponse>(response);
        }
        
        /// <summary>
        /// 修改项目信息
        /// </summary>
        public async Task<KeystoneUpdateProjectResponse> KeystoneUpdateProjectAsync(KeystoneUpdateProjectRequest keystoneUpdateProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneUpdateProjectRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateProjectRequest);
            SdkResponse response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateProjectResponse>(response);
        }
        
        /// <summary>
        /// 查询指定条件下的委托列表
        /// </summary>
        public async Task<ListAgenciesResponse> ListAgenciesAsync(ListAgenciesRequest listAgenciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listAgenciesRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAgenciesResponse>(response);
        }
        
        /// <summary>
        /// 查询自定义策略列表
        /// </summary>
        public async Task<ListCustomPoliciesResponse> ListCustomPoliciesAsync(ListCustomPoliciesRequest listCustomPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listCustomPoliciesRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListCustomPoliciesResponse>(response);
        }
        
        /// <summary>
        /// 查询全局服务中的委托权限
        /// </summary>
        public async Task<ListDomainPermissionsForAgencyResponse> ListDomainPermissionsForAgencyAsync(ListDomainPermissionsForAgencyRequest listDomainPermissionsForAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , listDomainPermissionsForAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listDomainPermissionsForAgencyRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDomainPermissionsForAgencyResponse>(response);
        }
        
        /// <summary>
        /// 查询项目服务中的委托权限
        /// </summary>
        public async Task<ListProjectPermissionsForAgencyResponse> ListProjectPermissionsForAgencyAsync(ListProjectPermissionsForAgencyRequest listProjectPermissionsForAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listProjectPermissionsForAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , listProjectPermissionsForAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listProjectPermissionsForAgencyRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectPermissionsForAgencyResponse>(response);
        }
        
        /// <summary>
        /// 移除委托的全局服务权限
        /// </summary>
        public async Task<RemoveDomainPermissionFromAgencyResponse> RemoveDomainPermissionFromAgencyAsync(RemoveDomainPermissionFromAgencyRequest removeDomainPermissionFromAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , removeDomainPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , removeDomainPermissionFromAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, removeDomainPermissionFromAgencyRequest);
            SdkResponse response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<RemoveDomainPermissionFromAgencyResponse>(response);
        }
        
        /// <summary>
        /// 移除委托的项目服务权限
        /// </summary>
        public async Task<RemoveProjectPermissionFromAgencyResponse> RemoveProjectPermissionFromAgencyAsync(RemoveProjectPermissionFromAgencyRequest removeProjectPermissionFromAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , removeProjectPermissionFromAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , removeProjectPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , removeProjectPermissionFromAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, removeProjectPermissionFromAgencyRequest);
            SdkResponse response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<RemoveProjectPermissionFromAgencyResponse>(response);
        }
        
        /// <summary>
        /// 查询委托详情
        /// </summary>
        public async Task<ShowAgencyResponse> ShowAgencyAsync(ShowAgencyRequest showAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , showAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showAgencyRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAgencyResponse>(response);
        }
        
        /// <summary>
        /// 查询自定义策略详情
        /// </summary>
        public async Task<ShowCustomPolicyResponse> ShowCustomPolicyAsync(ShowCustomPolicyRequest showCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , showCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showCustomPolicyRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询项目详情与状态
        /// </summary>
        public async Task<ShowProjectDetailsAndStatusResponse> ShowProjectDetailsAndStatusAsync(ShowProjectDetailsAndStatusRequest showProjectDetailsAndStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showProjectDetailsAndStatusRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showProjectDetailsAndStatusRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectDetailsAndStatusResponse>(response);
        }
        
        /// <summary>
        /// 修改委托
        /// </summary>
        public async Task<UpdateAgencyResponse> UpdateAgencyAsync(UpdateAgencyRequest updateAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , updateAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAgencyResponse>(response);
        }
        
        /// <summary>
        /// 修改委托自定义策略
        /// </summary>
        public async Task<UpdateAgencyCustomPolicyResponse> UpdateAgencyCustomPolicyAsync(UpdateAgencyCustomPolicyRequest updateAgencyCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , updateAgencyCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyCustomPolicyRequest);
            SdkResponse response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<UpdateAgencyCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改云服务自定义策略
        /// </summary>
        public async Task<UpdateCloudServiceCustomPolicyResponse> UpdateCloudServiceCustomPolicyAsync(UpdateCloudServiceCustomPolicyRequest updateCloudServiceCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , updateCloudServiceCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCloudServiceCustomPolicyRequest);
            SdkResponse response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<UpdateCloudServiceCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 设置项目状态
        /// </summary>
        public async Task<UpdateProjectStatusResponse> UpdateProjectStatusAsync(UpdateProjectStatusRequest updateProjectStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , updateProjectStatusRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProjectStatusRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateProjectStatusResponse>(response);
        }
        
        /// <summary>
        /// 创建永久访问密钥
        /// </summary>
        public async Task<CreatePermanentAccessKeyResponse> CreatePermanentAccessKeyAsync(CreatePermanentAccessKeyRequest createPermanentAccessKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPermanentAccessKeyRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePermanentAccessKeyResponse>(response);
        }
        
        /// <summary>
        /// 通过委托获取临时访问密钥
        /// </summary>
        public async Task<CreateTemporaryAccessKeyByAgencyResponse> CreateTemporaryAccessKeyByAgencyAsync(CreateTemporaryAccessKeyByAgencyRequest createTemporaryAccessKeyByAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByAgencyRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTemporaryAccessKeyByAgencyResponse>(response);
        }
        
        /// <summary>
        /// 通过token获取临时访问密钥
        /// </summary>
        public async Task<CreateTemporaryAccessKeyByTokenResponse> CreateTemporaryAccessKeyByTokenAsync(CreateTemporaryAccessKeyByTokenRequest createTemporaryAccessKeyByTokenRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByTokenRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTemporaryAccessKeyByTokenResponse>(response);
        }
        
        /// <summary>
        /// 删除指定永久访问密钥
        /// </summary>
        public async Task<DeletePermanentAccessKeyResponse> DeletePermanentAccessKeyAsync(DeletePermanentAccessKeyRequest deletePermanentAccessKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key" , deletePermanentAccessKeyRequest.AccessKey.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deletePermanentAccessKeyRequest);
            SdkResponse response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePermanentAccessKeyResponse>(response);
        }
        
        /// <summary>
        /// 查询所有永久访问密钥
        /// </summary>
        public async Task<ListPermanentAccessKeysResponse> ListPermanentAccessKeysAsync(ListPermanentAccessKeysRequest listPermanentAccessKeysRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listPermanentAccessKeysRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPermanentAccessKeysResponse>(response);
        }
        
        /// <summary>
        /// 查询指定永久访问密钥
        /// </summary>
        public async Task<ShowPermanentAccessKeyResponse> ShowPermanentAccessKeyAsync(ShowPermanentAccessKeyRequest showPermanentAccessKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key" , showPermanentAccessKeyRequest.AccessKey.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showPermanentAccessKeyRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPermanentAccessKeyResponse>(response);
        }
        
        /// <summary>
        /// 修改指定永久访问密钥
        /// </summary>
        public async Task<UpdatePermanentAccessKeyResponse> UpdatePermanentAccessKeyAsync(UpdatePermanentAccessKeyRequest updatePermanentAccessKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key" , updatePermanentAccessKeyRequest.AccessKey.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePermanentAccessKeyRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePermanentAccessKeyResponse>(response);
        }
        
        /// <summary>
        /// 管理员创建IAM用户（推荐）
        /// </summary>
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest createUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createUserRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateUserResponse>(response);
        }
        
        /// <summary>
        /// 管理员创建IAM用户
        /// </summary>
        public async Task<KeystoneCreateUserResponse> KeystoneCreateUserAsync(KeystoneCreateUserRequest keystoneCreateUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateUserResponse>(response);
        }
        
        /// <summary>
        /// 管理员删除IAM用户
        /// </summary>
        public async Task<KeystoneDeleteUserResponse> KeystoneDeleteUserAsync(KeystoneDeleteUserRequest keystoneDeleteUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneDeleteUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneDeleteUserRequest);
            SdkResponse response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteUserResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户所属用户组
        /// </summary>
        public async Task<KeystoneListGroupsForUserResponse> KeystoneListGroupsForUserAsync(KeystoneListGroupsForUserRequest keystoneListGroupsForUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneListGroupsForUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListGroupsForUserRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListGroupsForUserResponse>(response);
        }
        
        /// <summary>
        /// 管理员查询IAM用户列表
        /// </summary>
        public async Task<KeystoneListUsersResponse> KeystoneListUsersAsync(KeystoneListUsersRequest keystoneListUsersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListUsersRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListUsersResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户详情
        /// </summary>
        public async Task<KeystoneShowUserResponse> KeystoneShowUserAsync(KeystoneShowUserRequest keystoneShowUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneShowUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowUserRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowUserResponse>(response);
        }
        
        /// <summary>
        /// 管理员修改IAM用户信息
        /// </summary>
        public async Task<KeystoneUpdateUserByAdminResponse> KeystoneUpdateUserByAdminAsync(KeystoneUpdateUserByAdminRequest keystoneUpdateUserByAdminRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneUpdateUserByAdminRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserByAdminRequest);
            SdkResponse response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateUserByAdminResponse>(response);
        }
        
        /// <summary>
        /// 修改IAM用户密码
        /// </summary>
        public async Task<KeystoneUpdateUserPasswordResponse> KeystoneUpdateUserPasswordAsync(KeystoneUpdateUserPasswordRequest keystoneUpdateUserPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneUpdateUserPasswordRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserPasswordRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<KeystoneUpdateUserPasswordResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户详情（推荐）
        /// </summary>
        public async Task<ShowUserResponse> ShowUserAsync(ShowUserRequest showUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , showUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showUserRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUserResponse>(response);
        }
        
        /// <summary>
        /// 管理员修改IAM用户信息（推荐）
        /// </summary>
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest updateUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , updateUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateUserResponse>(response);
        }
        
        /// <summary>
        /// 修改IAM用户信息（推荐）
        /// </summary>
        public async Task<UpdateUserInformationResponse> UpdateUserInformationAsync(UpdateUserInformationRequest updateUserInformationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , updateUserInformationRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserInformationRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateUserInformationResponse>(response);
        }
        
    }
}