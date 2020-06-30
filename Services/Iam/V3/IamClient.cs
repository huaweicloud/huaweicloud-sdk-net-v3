using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Iam.V3.Model;

namespace HuaweiCloud.SDK.Iam.V3
{
    public partial class IamClient : Client
    {
        public static ClientBuilder<IamClient> NewBuilder()
        {
            return new ClientBuilder<IamClient>();
        }

        
        /// <summary>
        /// 为委托授予全局服务权限
        /// </summary>
        public AssociateAgencyWithDomainPermissionResponse AssociateAgencyWithDomainPermission(AssociateAgencyWithDomainPermissionRequest associateAgencyWithDomainPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , associateAgencyWithDomainPermissionRequest.AgencyId.ToString());
            urlParam.Add("role_id" , associateAgencyWithDomainPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, associateAgencyWithDomainPermissionRequest);
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithDomainPermissionResponse>(response);
        }
        
        /// <summary>
        /// 为委托授予项目服务权限
        /// </summary>
        public AssociateAgencyWithProjectPermissionResponse AssociateAgencyWithProjectPermission(AssociateAgencyWithProjectPermissionRequest associateAgencyWithProjectPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , associateAgencyWithProjectPermissionRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , associateAgencyWithProjectPermissionRequest.AgencyId.ToString());
            urlParam.Add("role_id" , associateAgencyWithProjectPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, associateAgencyWithProjectPermissionRequest);
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithProjectPermissionResponse>(response);
        }
        
        /// <summary>
        /// 查询委托是否拥有全局服务权限
        /// </summary>
        public CheckDomainPermissionForAgencyResponse CheckDomainPermissionForAgency(CheckDomainPermissionForAgencyRequest checkDomainPermissionForAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , checkDomainPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , checkDomainPermissionForAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, checkDomainPermissionForAgencyRequest);
            SdkResponse response = DoHttpRequestSync("HEAD",request);
            return JsonUtils.DeSerializeNull<CheckDomainPermissionForAgencyResponse>(response);
        }
        
        /// <summary>
        /// 查询委托是否拥有项目服务权限
        /// </summary>
        public CheckProjectPermissionForAgencyResponse CheckProjectPermissionForAgency(CheckProjectPermissionForAgencyRequest checkProjectPermissionForAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , checkProjectPermissionForAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , checkProjectPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , checkProjectPermissionForAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, checkProjectPermissionForAgencyRequest);
            SdkResponse response = DoHttpRequestSync("HEAD",request);
            return JsonUtils.DeSerializeNull<CheckProjectPermissionForAgencyResponse>(response);
        }
        
        /// <summary>
        /// 创建委托
        /// </summary>
        public CreateAgencyResponse CreateAgency(CreateAgencyRequest createAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAgencyResponse>(response);
        }
        
        /// <summary>
        /// 创建委托自定义策略
        /// </summary>
        public CreateAgencyCustomPolicyResponse CreateAgencyCustomPolicy(CreateAgencyCustomPolicyRequest createAgencyCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyCustomPolicyRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAgencyCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务自定义策略
        /// </summary>
        public CreateCloudServiceCustomPolicyResponse CreateCloudServiceCustomPolicy(CreateCloudServiceCustomPolicyRequest createCloudServiceCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCloudServiceCustomPolicyRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateCloudServiceCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 删除委托
        /// </summary>
        public DeleteAgencyResponse DeleteAgency(DeleteAgencyRequest deleteAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , deleteAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteAgencyRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAgencyResponse>(response);
        }
        
        /// <summary>
        /// 删除自定义策略
        /// </summary>
        public DeleteCustomPolicyResponse DeleteCustomPolicy(DeleteCustomPolicyRequest deleteCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , deleteCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteCustomPolicyRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 添加IAM用户到用户组
        /// </summary>
        public KeystoneAddUserToGroupResponse KeystoneAddUserToGroup(KeystoneAddUserToGroupRequest keystoneAddUserToGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneAddUserToGroupRequest.GroupId.ToString());
            urlParam.Add("user_id" , keystoneAddUserToGroupRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneAddUserToGroupRequest);
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAddUserToGroupResponse>(response);
        }
        
        /// <summary>
        /// 为用户组授予所有项目服务权限
        /// </summary>
        public KeystoneAssociateGroupWithAllProjectPermissionResponse KeystoneAssociateGroupWithAllProjectPermission(KeystoneAssociateGroupWithAllProjectPermissionRequest keystoneAssociateGroupWithAllProjectPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneAssociateGroupWithAllProjectPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneAssociateGroupWithAllProjectPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneAssociateGroupWithAllProjectPermissionRequest);
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithAllProjectPermissionResponse>(response);
        }
        
        /// <summary>
        /// 为用户组授予全局服务权限
        /// </summary>
        public KeystoneAssociateGroupWithDomainPermissionResponse KeystoneAssociateGroupWithDomainPermission(KeystoneAssociateGroupWithDomainPermissionRequest keystoneAssociateGroupWithDomainPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneAssociateGroupWithDomainPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneAssociateGroupWithDomainPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneAssociateGroupWithDomainPermissionRequest);
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithDomainPermissionResponse>(response);
        }
        
        /// <summary>
        /// 为用户组授予项目服务权限
        /// </summary>
        public KeystoneAssociateGroupWithProjectPermissionResponse KeystoneAssociateGroupWithProjectPermission(KeystoneAssociateGroupWithProjectPermissionRequest keystoneAssociateGroupWithProjectPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneAssociateGroupWithProjectPermissionRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneAssociateGroupWithProjectPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneAssociateGroupWithProjectPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneAssociateGroupWithProjectPermissionRequest);
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithProjectPermissionResponse>(response);
        }
        
        /// <summary>
        /// 查询用户组是否拥有全局服务权限
        /// </summary>
        public KeystoneCheckDomainPermissionForGroupResponse KeystoneCheckDomainPermissionForGroup(KeystoneCheckDomainPermissionForGroupRequest keystoneCheckDomainPermissionForGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneCheckDomainPermissionForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneCheckDomainPermissionForGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneCheckDomainPermissionForGroupRequest);
            SdkResponse response = DoHttpRequestSync("HEAD",request);
            return JsonUtils.DeSerializeNull<KeystoneCheckDomainPermissionForGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询用户组是否拥有项目服务权限
        /// </summary>
        public KeystoneCheckProjectPermissionForGroupResponse KeystoneCheckProjectPermissionForGroup(KeystoneCheckProjectPermissionForGroupRequest keystoneCheckProjectPermissionForGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneCheckProjectPermissionForGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneCheckProjectPermissionForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneCheckProjectPermissionForGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneCheckProjectPermissionForGroupRequest);
            SdkResponse response = DoHttpRequestSync("HEAD",request);
            return JsonUtils.DeSerializeNull<KeystoneCheckProjectPermissionForGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户是否在用户组中
        /// </summary>
        public KeystoneCheckUserInGroupResponse KeystoneCheckUserInGroup(KeystoneCheckUserInGroupRequest keystoneCheckUserInGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneCheckUserInGroupRequest.GroupId.ToString());
            urlParam.Add("user_id" , keystoneCheckUserInGroupRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneCheckUserInGroupRequest);
            SdkResponse response = DoHttpRequestSync("HEAD",request);
            return JsonUtils.DeSerializeNull<KeystoneCheckUserInGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建用户组
        /// </summary>
        public KeystoneCreateGroupResponse KeystoneCreateGroup(KeystoneCreateGroupRequest keystoneCreateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateGroupRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建项目
        /// </summary>
        public KeystoneCreateProjectResponse KeystoneCreateProject(KeystoneCreateProjectRequest keystoneCreateProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateProjectRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateProjectResponse>(response);
        }
        
        /// <summary>
        /// 删除用户组
        /// </summary>
        public KeystoneDeleteGroupResponse KeystoneDeleteGroup(KeystoneDeleteGroupRequest keystoneDeleteGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneDeleteGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneDeleteGroupRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户可以访问的账号详情
        /// </summary>
        public KeystoneListAuthDomainsResponse KeystoneListAuthDomains(KeystoneListAuthDomainsRequest keystoneListAuthDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListAuthDomainsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListAuthDomainsResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户可以访问的项目列表
        /// </summary>
        public KeystoneListAuthProjectsResponse KeystoneListAuthProjects(KeystoneListAuthProjectsRequest keystoneListAuthProjectsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListAuthProjectsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListAuthProjectsResponse>(response);
        }
        
        /// <summary>
        /// 查询全局服务中的用户组权限
        /// </summary>
        public KeystoneListDomainPermissionsForGroupResponse KeystoneListDomainPermissionsForGroup(KeystoneListDomainPermissionsForGroupRequest keystoneListDomainPermissionsForGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneListDomainPermissionsForGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListDomainPermissionsForGroupRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListDomainPermissionsForGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询终端节点列表
        /// </summary>
        public KeystoneListEndpointsResponse KeystoneListEndpoints(KeystoneListEndpointsRequest keystoneListEndpointsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/endpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListEndpointsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListEndpointsResponse>(response);
        }
        
        /// <summary>
        /// 查询用户组列表
        /// </summary>
        public KeystoneListGroupsResponse KeystoneListGroups(KeystoneListGroupsRequest keystoneListGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListGroupsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询权限列表
        /// </summary>
        public KeystoneListPermissionsResponse KeystoneListPermissions(KeystoneListPermissionsRequest keystoneListPermissionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListPermissionsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListPermissionsResponse>(response);
        }
        
        /// <summary>
        /// 查询项目服务中的用户组权限
        /// </summary>
        public KeystoneListProjectPermissionsForGroupResponse KeystoneListProjectPermissionsForGroup(KeystoneListProjectPermissionsForGroupRequest keystoneListProjectPermissionsForGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneListProjectPermissionsForGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneListProjectPermissionsForGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListProjectPermissionsForGroupRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListProjectPermissionsForGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询指定条件下的项目列表
        /// </summary>
        public KeystoneListProjectsResponse KeystoneListProjects(KeystoneListProjectsRequest keystoneListProjectsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListProjectsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListProjectsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定IAM用户的项目列表
        /// </summary>
        public KeystoneListProjectsForUserResponse KeystoneListProjectsForUser(KeystoneListProjectsForUserRequest keystoneListProjectsForUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneListProjectsForUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListProjectsForUserRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListProjectsForUserResponse>(response);
        }
        
        /// <summary>
        /// 查询区域列表
        /// </summary>
        public KeystoneListRegionsResponse KeystoneListRegions(KeystoneListRegionsRequest keystoneListRegionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/regions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListRegionsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListRegionsResponse>(response);
        }
        
        /// <summary>
        /// 查询服务列表
        /// </summary>
        public KeystoneListServicesResponse KeystoneListServices(KeystoneListServicesRequest keystoneListServicesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/services",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListServicesRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListServicesResponse>(response);
        }
        
        /// <summary>
        /// 管理员查询用户组所包含的IAM用户
        /// </summary>
        public KeystoneListUsersForGroupByAdminResponse KeystoneListUsersForGroupByAdmin(KeystoneListUsersForGroupByAdminRequest keystoneListUsersForGroupByAdminRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneListUsersForGroupByAdminRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListUsersForGroupByAdminRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListUsersForGroupByAdminResponse>(response);
        }
        
        /// <summary>
        /// 查询版本信息列表
        /// </summary>
        public KeystoneListVersionsResponse KeystoneListVersions(KeystoneListVersionsRequest keystoneListVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListVersionsRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerializeNull<KeystoneListVersionsResponse>(response);
        }
        
        /// <summary>
        /// 移除用户组的全局服务权限
        /// </summary>
        public KeystoneRemoveDomainPermissionFromGroupResponse KeystoneRemoveDomainPermissionFromGroup(KeystoneRemoveDomainPermissionFromGroupRequest keystoneRemoveDomainPermissionFromGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneRemoveDomainPermissionFromGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneRemoveDomainPermissionFromGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneRemoveDomainPermissionFromGroupRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveDomainPermissionFromGroupResponse>(response);
        }
        
        /// <summary>
        /// 移除用户组的项目服务权限
        /// </summary>
        public KeystoneRemoveProjectPermissionFromGroupResponse KeystoneRemoveProjectPermissionFromGroup(KeystoneRemoveProjectPermissionFromGroupRequest keystoneRemoveProjectPermissionFromGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneRemoveProjectPermissionFromGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneRemoveProjectPermissionFromGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneRemoveProjectPermissionFromGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneRemoveProjectPermissionFromGroupRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveProjectPermissionFromGroupResponse>(response);
        }
        
        /// <summary>
        /// 移除用户组中的IAM用户
        /// </summary>
        public KeystoneRemoveUserFromGroupResponse KeystoneRemoveUserFromGroup(KeystoneRemoveUserFromGroupRequest keystoneRemoveUserFromGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneRemoveUserFromGroupRequest.GroupId.ToString());
            urlParam.Add("user_id" , keystoneRemoveUserFromGroupRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneRemoveUserFromGroupRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveUserFromGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询服务目录
        /// </summary>
        public KeystoneShowCatalogResponse KeystoneShowCatalog(KeystoneShowCatalogRequest keystoneShowCatalogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/catalog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowCatalogRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowCatalogResponse>(response);
        }
        
        /// <summary>
        /// 查询终端节点详情
        /// </summary>
        public KeystoneShowEndpointResponse KeystoneShowEndpoint(KeystoneShowEndpointRequest keystoneShowEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id" , keystoneShowEndpointRequest.EndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/endpoints/{endpoint_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowEndpointRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowEndpointResponse>(response);
        }
        
        /// <summary>
        /// 查询用户组详情
        /// </summary>
        public KeystoneShowGroupResponse KeystoneShowGroup(KeystoneShowGroupRequest keystoneShowGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneShowGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowGroupRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询权限详情
        /// </summary>
        public KeystoneShowPermissionResponse KeystoneShowPermission(KeystoneShowPermissionRequest keystoneShowPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , keystoneShowPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowPermissionRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowPermissionResponse>(response);
        }
        
        /// <summary>
        /// 查询项目详情
        /// </summary>
        public KeystoneShowProjectResponse KeystoneShowProject(KeystoneShowProjectRequest keystoneShowProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneShowProjectRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowProjectRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowProjectResponse>(response);
        }
        
        /// <summary>
        /// 查询区域详情
        /// </summary>
        public KeystoneShowRegionResponse KeystoneShowRegion(KeystoneShowRegionRequest keystoneShowRegionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("region_id" , keystoneShowRegionRequest.RegionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/regions/{region_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowRegionRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowRegionResponse>(response);
        }
        
        /// <summary>
        /// 查询账号密码强度策略
        /// </summary>
        public KeystoneShowSecurityComplianceResponse KeystoneShowSecurityCompliance(KeystoneShowSecurityComplianceRequest keystoneShowSecurityComplianceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowSecurityComplianceRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowSecurityComplianceResponse>(response);
        }
        
        /// <summary>
        /// 按条件查询账号密码强度策略
        /// </summary>
        public KeystoneShowSecurityComplianceByOptionResponse KeystoneShowSecurityComplianceByOption(KeystoneShowSecurityComplianceByOptionRequest keystoneShowSecurityComplianceByOptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("option" , keystoneShowSecurityComplianceByOptionRequest.Option.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance/{option}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowSecurityComplianceByOptionRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowSecurityComplianceByOptionResponse>(response);
        }
        
        /// <summary>
        /// 查询服务详情
        /// </summary>
        public KeystoneShowServiceResponse KeystoneShowService(KeystoneShowServiceRequest keystoneShowServiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("service_id" , keystoneShowServiceRequest.ServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/services/{service_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowServiceRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowServiceResponse>(response);
        }
        
        /// <summary>
        /// 查询版本信息
        /// </summary>
        public KeystoneShowVersionResponse KeystoneShowVersion(KeystoneShowVersionRequest keystoneShowVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowVersionRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowVersionResponse>(response);
        }
        
        /// <summary>
        /// 更新用户组
        /// </summary>
        public KeystoneUpdateGroupResponse KeystoneUpdateGroup(KeystoneUpdateGroupRequest keystoneUpdateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneUpdateGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateGroupRequest);
            SdkResponse response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateGroupResponse>(response);
        }
        
        /// <summary>
        /// 修改项目信息
        /// </summary>
        public KeystoneUpdateProjectResponse KeystoneUpdateProject(KeystoneUpdateProjectRequest keystoneUpdateProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneUpdateProjectRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateProjectRequest);
            SdkResponse response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateProjectResponse>(response);
        }
        
        /// <summary>
        /// 查询指定条件下的委托列表
        /// </summary>
        public ListAgenciesResponse ListAgencies(ListAgenciesRequest listAgenciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listAgenciesRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAgenciesResponse>(response);
        }
        
        /// <summary>
        /// 查询自定义策略列表
        /// </summary>
        public ListCustomPoliciesResponse ListCustomPolicies(ListCustomPoliciesRequest listCustomPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listCustomPoliciesRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListCustomPoliciesResponse>(response);
        }
        
        /// <summary>
        /// 查询全局服务中的委托权限
        /// </summary>
        public ListDomainPermissionsForAgencyResponse ListDomainPermissionsForAgency(ListDomainPermissionsForAgencyRequest listDomainPermissionsForAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , listDomainPermissionsForAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listDomainPermissionsForAgencyRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDomainPermissionsForAgencyResponse>(response);
        }
        
        /// <summary>
        /// 查询项目服务中的委托权限
        /// </summary>
        public ListProjectPermissionsForAgencyResponse ListProjectPermissionsForAgency(ListProjectPermissionsForAgencyRequest listProjectPermissionsForAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listProjectPermissionsForAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , listProjectPermissionsForAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listProjectPermissionsForAgencyRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProjectPermissionsForAgencyResponse>(response);
        }
        
        /// <summary>
        /// 移除委托的全局服务权限
        /// </summary>
        public RemoveDomainPermissionFromAgencyResponse RemoveDomainPermissionFromAgency(RemoveDomainPermissionFromAgencyRequest removeDomainPermissionFromAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , removeDomainPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , removeDomainPermissionFromAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, removeDomainPermissionFromAgencyRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<RemoveDomainPermissionFromAgencyResponse>(response);
        }
        
        /// <summary>
        /// 移除委托的项目服务权限
        /// </summary>
        public RemoveProjectPermissionFromAgencyResponse RemoveProjectPermissionFromAgency(RemoveProjectPermissionFromAgencyRequest removeProjectPermissionFromAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , removeProjectPermissionFromAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , removeProjectPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , removeProjectPermissionFromAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, removeProjectPermissionFromAgencyRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<RemoveProjectPermissionFromAgencyResponse>(response);
        }
        
        /// <summary>
        /// 查询委托详情
        /// </summary>
        public ShowAgencyResponse ShowAgency(ShowAgencyRequest showAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , showAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showAgencyRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAgencyResponse>(response);
        }
        
        /// <summary>
        /// 查询自定义策略详情
        /// </summary>
        public ShowCustomPolicyResponse ShowCustomPolicy(ShowCustomPolicyRequest showCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , showCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showCustomPolicyRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询项目详情与状态
        /// </summary>
        public ShowProjectDetailsAndStatusResponse ShowProjectDetailsAndStatus(ShowProjectDetailsAndStatusRequest showProjectDetailsAndStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showProjectDetailsAndStatusRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showProjectDetailsAndStatusRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectDetailsAndStatusResponse>(response);
        }
        
        /// <summary>
        /// 修改委托
        /// </summary>
        public UpdateAgencyResponse UpdateAgency(UpdateAgencyRequest updateAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , updateAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyRequest);
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAgencyResponse>(response);
        }
        
        /// <summary>
        /// 修改委托自定义策略
        /// </summary>
        public UpdateAgencyCustomPolicyResponse UpdateAgencyCustomPolicy(UpdateAgencyCustomPolicyRequest updateAgencyCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , updateAgencyCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyCustomPolicyRequest);
            SdkResponse response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerialize<UpdateAgencyCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改云服务自定义策略
        /// </summary>
        public UpdateCloudServiceCustomPolicyResponse UpdateCloudServiceCustomPolicy(UpdateCloudServiceCustomPolicyRequest updateCloudServiceCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , updateCloudServiceCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCloudServiceCustomPolicyRequest);
            SdkResponse response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerialize<UpdateCloudServiceCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 设置项目状态
        /// </summary>
        public UpdateProjectStatusResponse UpdateProjectStatus(UpdateProjectStatusRequest updateProjectStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , updateProjectStatusRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProjectStatusRequest);
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateProjectStatusResponse>(response);
        }
        
        /// <summary>
        /// 创建永久访问密钥
        /// </summary>
        public CreatePermanentAccessKeyResponse CreatePermanentAccessKey(CreatePermanentAccessKeyRequest createPermanentAccessKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPermanentAccessKeyRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePermanentAccessKeyResponse>(response);
        }
        
        /// <summary>
        /// 通过委托获取临时访问密钥
        /// </summary>
        public CreateTemporaryAccessKeyByAgencyResponse CreateTemporaryAccessKeyByAgency(CreateTemporaryAccessKeyByAgencyRequest createTemporaryAccessKeyByAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByAgencyRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTemporaryAccessKeyByAgencyResponse>(response);
        }
        
        /// <summary>
        /// 通过token获取临时访问密钥
        /// </summary>
        public CreateTemporaryAccessKeyByTokenResponse CreateTemporaryAccessKeyByToken(CreateTemporaryAccessKeyByTokenRequest createTemporaryAccessKeyByTokenRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByTokenRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTemporaryAccessKeyByTokenResponse>(response);
        }
        
        /// <summary>
        /// 删除指定永久访问密钥
        /// </summary>
        public DeletePermanentAccessKeyResponse DeletePermanentAccessKey(DeletePermanentAccessKeyRequest deletePermanentAccessKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key" , deletePermanentAccessKeyRequest.AccessKey.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deletePermanentAccessKeyRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePermanentAccessKeyResponse>(response);
        }
        
        /// <summary>
        /// 查询所有永久访问密钥
        /// </summary>
        public ListPermanentAccessKeysResponse ListPermanentAccessKeys(ListPermanentAccessKeysRequest listPermanentAccessKeysRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listPermanentAccessKeysRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPermanentAccessKeysResponse>(response);
        }
        
        /// <summary>
        /// 查询指定永久访问密钥
        /// </summary>
        public ShowPermanentAccessKeyResponse ShowPermanentAccessKey(ShowPermanentAccessKeyRequest showPermanentAccessKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key" , showPermanentAccessKeyRequest.AccessKey.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showPermanentAccessKeyRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPermanentAccessKeyResponse>(response);
        }
        
        /// <summary>
        /// 修改指定永久访问密钥
        /// </summary>
        public UpdatePermanentAccessKeyResponse UpdatePermanentAccessKey(UpdatePermanentAccessKeyRequest updatePermanentAccessKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key" , updatePermanentAccessKeyRequest.AccessKey.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePermanentAccessKeyRequest);
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePermanentAccessKeyResponse>(response);
        }
        
        /// <summary>
        /// 管理员创建IAM用户（推荐）
        /// </summary>
        public CreateUserResponse CreateUser(CreateUserRequest createUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createUserRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateUserResponse>(response);
        }
        
        /// <summary>
        /// 管理员创建IAM用户
        /// </summary>
        public KeystoneCreateUserResponse KeystoneCreateUser(KeystoneCreateUserRequest keystoneCreateUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateUserResponse>(response);
        }
        
        /// <summary>
        /// 管理员删除IAM用户
        /// </summary>
        public KeystoneDeleteUserResponse KeystoneDeleteUser(KeystoneDeleteUserRequest keystoneDeleteUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneDeleteUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneDeleteUserRequest);
            SdkResponse response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteUserResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户所属用户组
        /// </summary>
        public KeystoneListGroupsForUserResponse KeystoneListGroupsForUser(KeystoneListGroupsForUserRequest keystoneListGroupsForUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneListGroupsForUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListGroupsForUserRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListGroupsForUserResponse>(response);
        }
        
        /// <summary>
        /// 管理员查询IAM用户列表
        /// </summary>
        public KeystoneListUsersResponse KeystoneListUsers(KeystoneListUsersRequest keystoneListUsersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListUsersRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListUsersResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户详情
        /// </summary>
        public KeystoneShowUserResponse KeystoneShowUser(KeystoneShowUserRequest keystoneShowUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneShowUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowUserRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowUserResponse>(response);
        }
        
        /// <summary>
        /// 管理员修改IAM用户信息
        /// </summary>
        public KeystoneUpdateUserByAdminResponse KeystoneUpdateUserByAdmin(KeystoneUpdateUserByAdminRequest keystoneUpdateUserByAdminRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneUpdateUserByAdminRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserByAdminRequest);
            SdkResponse response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateUserByAdminResponse>(response);
        }
        
        /// <summary>
        /// 修改IAM用户密码
        /// </summary>
        public KeystoneUpdateUserPasswordResponse KeystoneUpdateUserPassword(KeystoneUpdateUserPasswordRequest keystoneUpdateUserPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneUpdateUserPasswordRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserPasswordRequest);
            SdkResponse response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<KeystoneUpdateUserPasswordResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户详情（推荐）
        /// </summary>
        public ShowUserResponse ShowUser(ShowUserRequest showUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , showUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showUserRequest);
            SdkResponse response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowUserResponse>(response);
        }
        
        /// <summary>
        /// 管理员修改IAM用户信息（推荐）
        /// </summary>
        public UpdateUserResponse UpdateUser(UpdateUserRequest updateUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , updateUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserRequest);
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateUserResponse>(response);
        }
        
        /// <summary>
        /// 修改IAM用户信息（推荐）
        /// </summary>
        public UpdateUserInformationResponse UpdateUserInformation(UpdateUserInformationRequest updateUserInformationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , updateUserInformationRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserInformationRequest);
            SdkResponse response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateUserInformationResponse>(response);
        }
        
    }
}