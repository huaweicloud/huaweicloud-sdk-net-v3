using System;
using System.Net.Http;
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
            return new ClientBuilder<IamAsyncClient>("GlobalCredentials,BasicCredentials,IamCredentials");
        }

        
        /// <summary>
        /// 为委托授予所有项目服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)为委托授予所有项目服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateAgencyWithAllProjectsPermissionResponse> AssociateAgencyWithAllProjectsPermissionAsync(AssociateAgencyWithAllProjectsPermissionRequest associateAgencyWithAllProjectsPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithAllProjectsPermissionRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithAllProjectsPermissionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithAllProjectsPermissionRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithAllProjectsPermissionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithAllProjectsPermissionResponse>(response);
        }

        public AsyncInvoker<AssociateAgencyWithAllProjectsPermissionResponse> AssociateAgencyWithAllProjectsPermissionAsyncInvoker(AssociateAgencyWithAllProjectsPermissionRequest associateAgencyWithAllProjectsPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithAllProjectsPermissionRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithAllProjectsPermissionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithAllProjectsPermissionRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithAllProjectsPermissionRequest);
            return new AsyncInvoker<AssociateAgencyWithAllProjectsPermissionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AssociateAgencyWithAllProjectsPermissionResponse>);
        }
        
        /// <summary>
        /// 为委托授予全局服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)为委托授予全局服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateAgencyWithDomainPermissionResponse> AssociateAgencyWithDomainPermissionAsync(AssociateAgencyWithDomainPermissionRequest associateAgencyWithDomainPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithDomainPermissionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithDomainPermissionRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithDomainPermissionRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithDomainPermissionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithDomainPermissionResponse>(response);
        }

        public AsyncInvoker<AssociateAgencyWithDomainPermissionResponse> AssociateAgencyWithDomainPermissionAsyncInvoker(AssociateAgencyWithDomainPermissionRequest associateAgencyWithDomainPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithDomainPermissionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithDomainPermissionRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithDomainPermissionRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithDomainPermissionRequest);
            return new AsyncInvoker<AssociateAgencyWithDomainPermissionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AssociateAgencyWithDomainPermissionResponse>);
        }
        
        /// <summary>
        /// 为委托授予项目服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)为委托授予项目服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateAgencyWithProjectPermissionResponse> AssociateAgencyWithProjectPermissionAsync(AssociateAgencyWithProjectPermissionRequest associateAgencyWithProjectPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithProjectPermissionRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithProjectPermissionRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithProjectPermissionRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithProjectPermissionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithProjectPermissionResponse>(response);
        }

        public AsyncInvoker<AssociateAgencyWithProjectPermissionResponse> AssociateAgencyWithProjectPermissionAsyncInvoker(AssociateAgencyWithProjectPermissionRequest associateAgencyWithProjectPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithProjectPermissionRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithProjectPermissionRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(associateAgencyWithProjectPermissionRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithProjectPermissionRequest);
            return new AsyncInvoker<AssociateAgencyWithProjectPermissionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AssociateAgencyWithProjectPermissionResponse>);
        }
        
        /// <summary>
        /// 基于委托为企业项目授权
        ///
        /// 该接口可以基于委托为企业项目授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateRoleToAgencyOnEnterpriseProjectResponse> AssociateRoleToAgencyOnEnterpriseProjectAsync(AssociateRoleToAgencyOnEnterpriseProjectRequest associateRoleToAgencyOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/subjects/agency/scopes/enterprise-project/role-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateRoleToAgencyOnEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<AssociateRoleToAgencyOnEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<AssociateRoleToAgencyOnEnterpriseProjectResponse> AssociateRoleToAgencyOnEnterpriseProjectAsyncInvoker(AssociateRoleToAgencyOnEnterpriseProjectRequest associateRoleToAgencyOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/subjects/agency/scopes/enterprise-project/role-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateRoleToAgencyOnEnterpriseProjectRequest);
            return new AsyncInvoker<AssociateRoleToAgencyOnEnterpriseProjectResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AssociateRoleToAgencyOnEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 基于用户组为企业项目授权
        ///
        /// 该接口用于基于用户组为企业项目授权。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateRoleToGroupOnEnterpriseProjectResponse> AssociateRoleToGroupOnEnterpriseProjectAsync(AssociateRoleToGroupOnEnterpriseProjectRequest associateRoleToGroupOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRoleToGroupOnEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            if (StringUtils.TryConvertToNonEmptyString(associateRoleToGroupOnEnterpriseProjectRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(associateRoleToGroupOnEnterpriseProjectRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRoleToGroupOnEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<AssociateRoleToGroupOnEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<AssociateRoleToGroupOnEnterpriseProjectResponse> AssociateRoleToGroupOnEnterpriseProjectAsyncInvoker(AssociateRoleToGroupOnEnterpriseProjectRequest associateRoleToGroupOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRoleToGroupOnEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            if (StringUtils.TryConvertToNonEmptyString(associateRoleToGroupOnEnterpriseProjectRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(associateRoleToGroupOnEnterpriseProjectRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRoleToGroupOnEnterpriseProjectRequest);
            return new AsyncInvoker<AssociateRoleToGroupOnEnterpriseProjectResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AssociateRoleToGroupOnEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 基于用户为企业项目授权
        ///
        /// 基于用户为企业项目授权。
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateRoleToUserOnEnterpriseProjectResponse> AssociateRoleToUserOnEnterpriseProjectAsync(AssociateRoleToUserOnEnterpriseProjectRequest associateRoleToUserOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRoleToUserOnEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            if (StringUtils.TryConvertToNonEmptyString(associateRoleToUserOnEnterpriseProjectRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(associateRoleToUserOnEnterpriseProjectRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRoleToUserOnEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<AssociateRoleToUserOnEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<AssociateRoleToUserOnEnterpriseProjectResponse> AssociateRoleToUserOnEnterpriseProjectAsyncInvoker(AssociateRoleToUserOnEnterpriseProjectRequest associateRoleToUserOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRoleToUserOnEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            if (StringUtils.TryConvertToNonEmptyString(associateRoleToUserOnEnterpriseProjectRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(associateRoleToUserOnEnterpriseProjectRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRoleToUserOnEnterpriseProjectRequest);
            return new AsyncInvoker<AssociateRoleToUserOnEnterpriseProjectResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AssociateRoleToUserOnEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 检查委托下是否具有所有项目服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)检查委托是否具有所有项目服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckAllProjectsPermissionForAgencyResponse> CheckAllProjectsPermissionForAgencyAsync(CheckAllProjectsPermissionForAgencyRequest checkAllProjectsPermissionForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkAllProjectsPermissionForAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(checkAllProjectsPermissionForAgencyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(checkAllProjectsPermissionForAgencyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkAllProjectsPermissionForAgencyRequest);
            var response = await DoHttpRequestAsync("HEAD", request);
            return JsonUtils.DeSerializeNull<CheckAllProjectsPermissionForAgencyResponse>(response);
        }

        public AsyncInvoker<CheckAllProjectsPermissionForAgencyResponse> CheckAllProjectsPermissionForAgencyAsyncInvoker(CheckAllProjectsPermissionForAgencyRequest checkAllProjectsPermissionForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkAllProjectsPermissionForAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(checkAllProjectsPermissionForAgencyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(checkAllProjectsPermissionForAgencyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkAllProjectsPermissionForAgencyRequest);
            return new AsyncInvoker<CheckAllProjectsPermissionForAgencyResponse>(this, "HEAD", request, JsonUtils.DeSerializeNull<CheckAllProjectsPermissionForAgencyResponse>);
        }
        
        /// <summary>
        /// 查询委托是否拥有全局服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询委托是否拥有全局服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckDomainPermissionForAgencyResponse> CheckDomainPermissionForAgencyAsync(CheckDomainPermissionForAgencyRequest checkDomainPermissionForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkDomainPermissionForAgencyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(checkDomainPermissionForAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(checkDomainPermissionForAgencyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDomainPermissionForAgencyRequest);
            var response = await DoHttpRequestAsync("HEAD", request);
            return JsonUtils.DeSerializeNull<CheckDomainPermissionForAgencyResponse>(response);
        }

        public AsyncInvoker<CheckDomainPermissionForAgencyResponse> CheckDomainPermissionForAgencyAsyncInvoker(CheckDomainPermissionForAgencyRequest checkDomainPermissionForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkDomainPermissionForAgencyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(checkDomainPermissionForAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(checkDomainPermissionForAgencyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDomainPermissionForAgencyRequest);
            return new AsyncInvoker<CheckDomainPermissionForAgencyResponse>(this, "HEAD", request, JsonUtils.DeSerializeNull<CheckDomainPermissionForAgencyResponse>);
        }
        
        /// <summary>
        /// 查询委托是否拥有项目服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询委托是否拥有项目服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckProjectPermissionForAgencyResponse> CheckProjectPermissionForAgencyAsync(CheckProjectPermissionForAgencyRequest checkProjectPermissionForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkProjectPermissionForAgencyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkProjectPermissionForAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(checkProjectPermissionForAgencyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkProjectPermissionForAgencyRequest);
            var response = await DoHttpRequestAsync("HEAD", request);
            return JsonUtils.DeSerializeNull<CheckProjectPermissionForAgencyResponse>(response);
        }

        public AsyncInvoker<CheckProjectPermissionForAgencyResponse> CheckProjectPermissionForAgencyAsyncInvoker(CheckProjectPermissionForAgencyRequest checkProjectPermissionForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkProjectPermissionForAgencyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkProjectPermissionForAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(checkProjectPermissionForAgencyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkProjectPermissionForAgencyRequest);
            return new AsyncInvoker<CheckProjectPermissionForAgencyResponse>(this, "HEAD", request, JsonUtils.DeSerializeNull<CheckProjectPermissionForAgencyResponse>);
        }
        
        /// <summary>
        /// 创建委托
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)创建委托。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAgencyResponse> CreateAgencyAsync(CreateAgencyRequest createAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAgencyResponse>(response);
        }

        public AsyncInvoker<CreateAgencyResponse> CreateAgencyAsyncInvoker(CreateAgencyRequest createAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyRequest);
            return new AsyncInvoker<CreateAgencyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAgencyResponse>);
        }
        
        /// <summary>
        /// 创建委托自定义策略
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)创建委托自定义策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAgencyCustomPolicyResponse> CreateAgencyCustomPolicyAsync(CreateAgencyCustomPolicyRequest createAgencyCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyCustomPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAgencyCustomPolicyResponse>(response);
        }

        public AsyncInvoker<CreateAgencyCustomPolicyResponse> CreateAgencyCustomPolicyAsyncInvoker(CreateAgencyCustomPolicyRequest createAgencyCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyCustomPolicyRequest);
            return new AsyncInvoker<CreateAgencyCustomPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAgencyCustomPolicyResponse>);
        }
        
        /// <summary>
        /// 绑定MFA设备
        ///
        /// 该接口可以用于绑定MFA设备。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBindingDeviceResponse> CreateBindingDeviceAsync(CreateBindingDeviceRequest createBindingDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/mfa-devices/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createBindingDeviceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<CreateBindingDeviceResponse>(response);
        }

        public AsyncInvoker<CreateBindingDeviceResponse> CreateBindingDeviceAsyncInvoker(CreateBindingDeviceRequest createBindingDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/mfa-devices/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createBindingDeviceRequest);
            return new AsyncInvoker<CreateBindingDeviceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CreateBindingDeviceResponse>);
        }
        
        /// <summary>
        /// 创建云服务自定义策略
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)创建云服务自定义策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCloudServiceCustomPolicyResponse> CreateCloudServiceCustomPolicyAsync(CreateCloudServiceCustomPolicyRequest createCloudServiceCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCloudServiceCustomPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCloudServiceCustomPolicyResponse>(response);
        }

        public AsyncInvoker<CreateCloudServiceCustomPolicyResponse> CreateCloudServiceCustomPolicyAsyncInvoker(CreateCloudServiceCustomPolicyRequest createCloudServiceCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCloudServiceCustomPolicyRequest);
            return new AsyncInvoker<CreateCloudServiceCustomPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCloudServiceCustomPolicyResponse>);
        }
        
        /// <summary>
        /// 获取自定义代理登录票据
        ///
        /// 该接口用于用于获取自定义代理登录票据logintoken。logintoken是系统颁发给自定义代理用户的登录票据，承载用户的身份、session等信息。调用自定义代理URL登录云服务控制台时，可以使用本接口获取的logintoken进行认证。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// &gt; - logintoken的有效期为10分钟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLoginTokenResponse> CreateLoginTokenAsync(CreateLoginTokenRequest createLoginTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AUTH/securitytoken/logintokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLoginTokenRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLoginTokenResponse>(response);
        }

        public AsyncInvoker<CreateLoginTokenResponse> CreateLoginTokenAsyncInvoker(CreateLoginTokenRequest createLoginTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AUTH/securitytoken/logintokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLoginTokenRequest);
            return new AsyncInvoker<CreateLoginTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLoginTokenResponse>);
        }
        
        /// <summary>
        /// 导入Metadata文件
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)导入Metadata文件。
        /// 
        /// 账号在使用联邦认证功能前，需要先将Metadata文件导入到IAM中。Metadata文件是SAML 2.0协议约定的接口文件，包含访问接口地址和证书信息，请找企业管理员获取企业IdP的Metadata文件。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMetadataResponse> CreateMetadataAsync(CreateMetadataRequest createMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMetadataRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            if (StringUtils.TryConvertToNonEmptyString(createMetadataRequest.ProtocolId, out var valueOfProtocolId)) urlParam.Add("protocol_id", valueOfProtocolId);
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMetadataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMetadataResponse>(response);
        }

        public AsyncInvoker<CreateMetadataResponse> CreateMetadataAsyncInvoker(CreateMetadataRequest createMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMetadataRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            if (StringUtils.TryConvertToNonEmptyString(createMetadataRequest.ProtocolId, out var valueOfProtocolId)) urlParam.Add("protocol_id", valueOfProtocolId);
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMetadataRequest);
            return new AsyncInvoker<CreateMetadataResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMetadataResponse>);
        }
        
        /// <summary>
        /// 创建MFA设备
        ///
        /// 该接口可以用于创建MFA设备。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMfaDeviceResponse> CreateMfaDeviceAsync(CreateMfaDeviceRequest createMfaDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMfaDeviceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMfaDeviceResponse>(response);
        }

        public AsyncInvoker<CreateMfaDeviceResponse> CreateMfaDeviceAsyncInvoker(CreateMfaDeviceRequest createMfaDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMfaDeviceRequest);
            return new AsyncInvoker<CreateMfaDeviceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMfaDeviceResponse>);
        }
        
        /// <summary>
        /// 创建OpenId Connect身份提供商配置
        ///
        /// 创建OpenId Connect身份提供商配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOpenIdConnectConfigResponse> CreateOpenIdConnectConfigAsync(CreateOpenIdConnectConfigRequest createOpenIdConnectConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOpenIdConnectConfigRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOpenIdConnectConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateOpenIdConnectConfigResponse>(response);
        }

        public AsyncInvoker<CreateOpenIdConnectConfigResponse> CreateOpenIdConnectConfigAsyncInvoker(CreateOpenIdConnectConfigRequest createOpenIdConnectConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOpenIdConnectConfigRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOpenIdConnectConfigRequest);
            return new AsyncInvoker<CreateOpenIdConnectConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOpenIdConnectConfigResponse>);
        }
        
        /// <summary>
        /// 获取联邦认证token(OpenId Connect Id token方式)
        ///
        /// 获取联邦认证token(OpenId Connect Id token方式)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTokenWithIdTokenResponse> CreateTokenWithIdTokenAsync(CreateTokenWithIdTokenRequest createTokenWithIdTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AUTH/id-token/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTokenWithIdTokenRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTokenWithIdTokenResponse>(response);
        }

        public AsyncInvoker<CreateTokenWithIdTokenResponse> CreateTokenWithIdTokenAsyncInvoker(CreateTokenWithIdTokenRequest createTokenWithIdTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AUTH/id-token/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTokenWithIdTokenRequest);
            return new AsyncInvoker<CreateTokenWithIdTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTokenWithIdTokenResponse>);
        }
        
        /// <summary>
        /// 获取联邦认证unscoped token(IdP initiated)
        ///
        /// 该接口可以用于通过IdP initiated的联邦认证方式获取unscoped token。
        /// 
        /// Unscoped token不能用来鉴权，若联邦用户需要使用token进行鉴权，请参考[获取联邦认证scoped token](https://support.huaweicloud.com/api-iam/iam_13_0604.html)获取scoped token。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// &gt; - 该接口支持在命令行侧调用，需要客户端使用IdP initiated的联邦认证方式获取SAMLResponse，并采用浏览器提交表单数据的方式，获取unscoped token。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateUnscopeTokenByIdpInitiatedResponse> CreateUnscopeTokenByIdpInitiatedAsync(CreateUnscopeTokenByIdpInitiatedRequest createUnscopeTokenByIdpInitiatedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", createUnscopeTokenByIdpInitiatedRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateUnscopeTokenByIdpInitiatedResponse>(response);
        }

        public AsyncInvoker<CreateUnscopeTokenByIdpInitiatedResponse> CreateUnscopeTokenByIdpInitiatedAsyncInvoker(CreateUnscopeTokenByIdpInitiatedRequest createUnscopeTokenByIdpInitiatedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/x-www-form-urlencoded", createUnscopeTokenByIdpInitiatedRequest);
            return new AsyncInvoker<CreateUnscopeTokenByIdpInitiatedResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUnscopeTokenByIdpInitiatedResponse>);
        }
        
        /// <summary>
        /// 获取联邦认证unscoped token(OpenId Connect Id token方式)
        ///
        /// 获取联邦认证token(OpenId Connect Id token方式)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateUnscopedTokenWithIdTokenResponse> CreateUnscopedTokenWithIdTokenAsync(CreateUnscopedTokenWithIdTokenRequest createUnscopedTokenWithIdTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUnscopedTokenWithIdTokenRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            if (StringUtils.TryConvertToNonEmptyString(createUnscopedTokenWithIdTokenRequest.ProtocolId, out var valueOfProtocolId)) urlParam.Add("protocol_id", valueOfProtocolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUnscopedTokenWithIdTokenRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateUnscopedTokenWithIdTokenResponse>(response);
        }

        public AsyncInvoker<CreateUnscopedTokenWithIdTokenResponse> CreateUnscopedTokenWithIdTokenAsyncInvoker(CreateUnscopedTokenWithIdTokenRequest createUnscopedTokenWithIdTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUnscopedTokenWithIdTokenRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            if (StringUtils.TryConvertToNonEmptyString(createUnscopedTokenWithIdTokenRequest.ProtocolId, out var valueOfProtocolId)) urlParam.Add("protocol_id", valueOfProtocolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUnscopedTokenWithIdTokenRequest);
            return new AsyncInvoker<CreateUnscopedTokenWithIdTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUnscopedTokenWithIdTokenResponse>);
        }
        
        /// <summary>
        /// 删除委托
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)删除委托。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAgencyResponse> DeleteAgencyAsync(DeleteAgencyRequest deleteAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgencyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAgencyResponse>(response);
        }

        public AsyncInvoker<DeleteAgencyResponse> DeleteAgencyAsyncInvoker(DeleteAgencyRequest deleteAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgencyRequest);
            return new AsyncInvoker<DeleteAgencyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAgencyResponse>);
        }
        
        /// <summary>
        /// 解绑MFA设备
        ///
        /// 该接口可以用于解绑MFA设备
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteBindingDeviceResponse> DeleteBindingDeviceAsync(DeleteBindingDeviceRequest deleteBindingDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/mfa-devices/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteBindingDeviceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<DeleteBindingDeviceResponse>(response);
        }

        public AsyncInvoker<DeleteBindingDeviceResponse> DeleteBindingDeviceAsyncInvoker(DeleteBindingDeviceRequest deleteBindingDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/mfa-devices/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteBindingDeviceRequest);
            return new AsyncInvoker<DeleteBindingDeviceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<DeleteBindingDeviceResponse>);
        }
        
        /// <summary>
        /// 删除自定义策略
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)删除自定义策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCustomPolicyResponse> DeleteCustomPolicyAsync(DeleteCustomPolicyRequest deleteCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCustomPolicyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomPolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCustomPolicyResponse>(response);
        }

        public AsyncInvoker<DeleteCustomPolicyResponse> DeleteCustomPolicyAsyncInvoker(DeleteCustomPolicyRequest deleteCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCustomPolicyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomPolicyRequest);
            return new AsyncInvoker<DeleteCustomPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCustomPolicyResponse>);
        }
        
        /// <summary>
        /// 移除用户组的所有项目服务权限
        ///
        /// 该接口可以用于移除用户组的所有项目服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainGroupInheritedRoleResponse> DeleteDomainGroupInheritedRoleAsync(DeleteDomainGroupInheritedRoleRequest deleteDomainGroupInheritedRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainGroupInheritedRoleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainGroupInheritedRoleRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainGroupInheritedRoleRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainGroupInheritedRoleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainGroupInheritedRoleResponse>(response);
        }

        public AsyncInvoker<DeleteDomainGroupInheritedRoleResponse> DeleteDomainGroupInheritedRoleAsyncInvoker(DeleteDomainGroupInheritedRoleRequest deleteDomainGroupInheritedRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainGroupInheritedRoleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainGroupInheritedRoleRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainGroupInheritedRoleRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainGroupInheritedRoleRequest);
            return new AsyncInvoker<DeleteDomainGroupInheritedRoleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainGroupInheritedRoleResponse>);
        }
        
        /// <summary>
        /// 删除MFA设备
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)删除MFA设备。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMfaDeviceResponse> DeleteMfaDeviceAsync(DeleteMfaDeviceRequest deleteMfaDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMfaDeviceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMfaDeviceResponse>(response);
        }

        public AsyncInvoker<DeleteMfaDeviceResponse> DeleteMfaDeviceAsyncInvoker(DeleteMfaDeviceRequest deleteMfaDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMfaDeviceRequest);
            return new AsyncInvoker<DeleteMfaDeviceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMfaDeviceResponse>);
        }
        
        /// <summary>
        /// 添加IAM用户到用户组
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)添加IAM用户到用户组。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneAddUserToGroupResponse> KeystoneAddUserToGroupAsync(KeystoneAddUserToGroupRequest keystoneAddUserToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneAddUserToGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneAddUserToGroupRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAddUserToGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<KeystoneAddUserToGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneAddUserToGroupResponse> KeystoneAddUserToGroupAsyncInvoker(KeystoneAddUserToGroupRequest keystoneAddUserToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneAddUserToGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneAddUserToGroupRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAddUserToGroupRequest);
            return new AsyncInvoker<KeystoneAddUserToGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<KeystoneAddUserToGroupResponse>);
        }
        
        /// <summary>
        /// 为用户组授予全局服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)为用户组授予全局服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneAssociateGroupWithDomainPermissionResponse> KeystoneAssociateGroupWithDomainPermissionAsync(KeystoneAssociateGroupWithDomainPermissionRequest keystoneAssociateGroupWithDomainPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneAssociateGroupWithDomainPermissionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneAssociateGroupWithDomainPermissionRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneAssociateGroupWithDomainPermissionRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAssociateGroupWithDomainPermissionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithDomainPermissionResponse>(response);
        }

        public AsyncInvoker<KeystoneAssociateGroupWithDomainPermissionResponse> KeystoneAssociateGroupWithDomainPermissionAsyncInvoker(KeystoneAssociateGroupWithDomainPermissionRequest keystoneAssociateGroupWithDomainPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneAssociateGroupWithDomainPermissionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneAssociateGroupWithDomainPermissionRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneAssociateGroupWithDomainPermissionRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAssociateGroupWithDomainPermissionRequest);
            return new AsyncInvoker<KeystoneAssociateGroupWithDomainPermissionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithDomainPermissionResponse>);
        }
        
        /// <summary>
        /// 为用户组授予项目服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)为用户组授予项目服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneAssociateGroupWithProjectPermissionResponse> KeystoneAssociateGroupWithProjectPermissionAsync(KeystoneAssociateGroupWithProjectPermissionRequest keystoneAssociateGroupWithProjectPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneAssociateGroupWithProjectPermissionRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneAssociateGroupWithProjectPermissionRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneAssociateGroupWithProjectPermissionRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAssociateGroupWithProjectPermissionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithProjectPermissionResponse>(response);
        }

        public AsyncInvoker<KeystoneAssociateGroupWithProjectPermissionResponse> KeystoneAssociateGroupWithProjectPermissionAsyncInvoker(KeystoneAssociateGroupWithProjectPermissionRequest keystoneAssociateGroupWithProjectPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneAssociateGroupWithProjectPermissionRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneAssociateGroupWithProjectPermissionRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneAssociateGroupWithProjectPermissionRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAssociateGroupWithProjectPermissionRequest);
            return new AsyncInvoker<KeystoneAssociateGroupWithProjectPermissionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithProjectPermissionResponse>);
        }
        
        /// <summary>
        /// 查询用户组是否拥有全局服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询用户组是否拥有全局服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneCheckDomainPermissionForGroupResponse> KeystoneCheckDomainPermissionForGroupAsync(KeystoneCheckDomainPermissionForGroupRequest keystoneCheckDomainPermissionForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckDomainPermissionForGroupRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckDomainPermissionForGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckDomainPermissionForGroupRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckDomainPermissionForGroupRequest);
            var response = await DoHttpRequestAsync("HEAD", request);
            return JsonUtils.DeSerializeNull<KeystoneCheckDomainPermissionForGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneCheckDomainPermissionForGroupResponse> KeystoneCheckDomainPermissionForGroupAsyncInvoker(KeystoneCheckDomainPermissionForGroupRequest keystoneCheckDomainPermissionForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckDomainPermissionForGroupRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckDomainPermissionForGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckDomainPermissionForGroupRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckDomainPermissionForGroupRequest);
            return new AsyncInvoker<KeystoneCheckDomainPermissionForGroupResponse>(this, "HEAD", request, JsonUtils.DeSerializeNull<KeystoneCheckDomainPermissionForGroupResponse>);
        }
        
        /// <summary>
        /// 查询用户组是否拥有项目服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询用户组是否拥有项目服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneCheckProjectPermissionForGroupResponse> KeystoneCheckProjectPermissionForGroupAsync(KeystoneCheckProjectPermissionForGroupRequest keystoneCheckProjectPermissionForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckProjectPermissionForGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckProjectPermissionForGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckProjectPermissionForGroupRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckProjectPermissionForGroupRequest);
            var response = await DoHttpRequestAsync("HEAD", request);
            return JsonUtils.DeSerializeNull<KeystoneCheckProjectPermissionForGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneCheckProjectPermissionForGroupResponse> KeystoneCheckProjectPermissionForGroupAsyncInvoker(KeystoneCheckProjectPermissionForGroupRequest keystoneCheckProjectPermissionForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckProjectPermissionForGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckProjectPermissionForGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckProjectPermissionForGroupRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckProjectPermissionForGroupRequest);
            return new AsyncInvoker<KeystoneCheckProjectPermissionForGroupResponse>(this, "HEAD", request, JsonUtils.DeSerializeNull<KeystoneCheckProjectPermissionForGroupResponse>);
        }
        
        /// <summary>
        /// 查询IAM用户是否在用户组中
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询IAM用户是否在用户组中。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneCheckUserInGroupResponse> KeystoneCheckUserInGroupAsync(KeystoneCheckUserInGroupRequest keystoneCheckUserInGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckUserInGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckUserInGroupRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckUserInGroupRequest);
            var response = await DoHttpRequestAsync("HEAD", request);
            return JsonUtils.DeSerializeNull<KeystoneCheckUserInGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneCheckUserInGroupResponse> KeystoneCheckUserInGroupAsyncInvoker(KeystoneCheckUserInGroupRequest keystoneCheckUserInGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckUserInGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckUserInGroupRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckUserInGroupRequest);
            return new AsyncInvoker<KeystoneCheckUserInGroupResponse>(this, "HEAD", request, JsonUtils.DeSerializeNull<KeystoneCheckUserInGroupResponse>);
        }
        
        /// <summary>
        /// 查询用户组是否拥有所有项目指定权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询用户组是否拥有所有项目指定权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneCheckroleForGroupResponse> KeystoneCheckroleForGroupAsync(KeystoneCheckroleForGroupRequest keystoneCheckroleForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckroleForGroupRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckroleForGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckroleForGroupRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckroleForGroupRequest);
            var response = await DoHttpRequestAsync("HEAD", request);
            return JsonUtils.DeSerializeNull<KeystoneCheckroleForGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneCheckroleForGroupResponse> KeystoneCheckroleForGroupAsyncInvoker(KeystoneCheckroleForGroupRequest keystoneCheckroleForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckroleForGroupRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckroleForGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCheckroleForGroupRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckroleForGroupRequest);
            return new AsyncInvoker<KeystoneCheckroleForGroupResponse>(this, "HEAD", request, JsonUtils.DeSerializeNull<KeystoneCheckroleForGroupResponse>);
        }
        
        /// <summary>
        /// 创建用户组
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)创建用户组。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneCreateGroupResponse> KeystoneCreateGroupAsync(KeystoneCreateGroupRequest keystoneCreateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<KeystoneCreateGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneCreateGroupResponse> KeystoneCreateGroupAsyncInvoker(KeystoneCreateGroupRequest keystoneCreateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateGroupRequest);
            return new AsyncInvoker<KeystoneCreateGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<KeystoneCreateGroupResponse>);
        }
        
        /// <summary>
        /// 注册身份提供商
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)注册身份提供商。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneCreateIdentityProviderResponse> KeystoneCreateIdentityProviderAsync(KeystoneCreateIdentityProviderRequest keystoneCreateIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneCreateIdentityProviderRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateIdentityProviderRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<KeystoneCreateIdentityProviderResponse>(response);
        }

        public AsyncInvoker<KeystoneCreateIdentityProviderResponse> KeystoneCreateIdentityProviderAsyncInvoker(KeystoneCreateIdentityProviderRequest keystoneCreateIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneCreateIdentityProviderRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateIdentityProviderRequest);
            return new AsyncInvoker<KeystoneCreateIdentityProviderResponse>(this, "PUT", request, JsonUtils.DeSerialize<KeystoneCreateIdentityProviderResponse>);
        }
        
        /// <summary>
        /// 注册映射
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)注册映射。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneCreateMappingResponse> KeystoneCreateMappingAsync(KeystoneCreateMappingRequest keystoneCreateMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneCreateMappingRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateMappingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<KeystoneCreateMappingResponse>(response);
        }

        public AsyncInvoker<KeystoneCreateMappingResponse> KeystoneCreateMappingAsyncInvoker(KeystoneCreateMappingRequest keystoneCreateMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneCreateMappingRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateMappingRequest);
            return new AsyncInvoker<KeystoneCreateMappingResponse>(this, "PUT", request, JsonUtils.DeSerialize<KeystoneCreateMappingResponse>);
        }
        
        /// <summary>
        /// 创建项目
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)创建项目。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneCreateProjectResponse> KeystoneCreateProjectAsync(KeystoneCreateProjectRequest keystoneCreateProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateProjectRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<KeystoneCreateProjectResponse>(response);
        }

        public AsyncInvoker<KeystoneCreateProjectResponse> KeystoneCreateProjectAsyncInvoker(KeystoneCreateProjectRequest keystoneCreateProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateProjectRequest);
            return new AsyncInvoker<KeystoneCreateProjectResponse>(this, "POST", request, JsonUtils.DeSerialize<KeystoneCreateProjectResponse>);
        }
        
        /// <summary>
        /// 注册协议
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)注册协议（将协议关联到某一身份提供商）。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneCreateProtocolResponse> KeystoneCreateProtocolAsync(KeystoneCreateProtocolRequest keystoneCreateProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneCreateProtocolRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCreateProtocolRequest.ProtocolId, out var valueOfProtocolId)) urlParam.Add("protocol_id", valueOfProtocolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateProtocolRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<KeystoneCreateProtocolResponse>(response);
        }

        public AsyncInvoker<KeystoneCreateProtocolResponse> KeystoneCreateProtocolAsyncInvoker(KeystoneCreateProtocolRequest keystoneCreateProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneCreateProtocolRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneCreateProtocolRequest.ProtocolId, out var valueOfProtocolId)) urlParam.Add("protocol_id", valueOfProtocolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateProtocolRequest);
            return new AsyncInvoker<KeystoneCreateProtocolResponse>(this, "PUT", request, JsonUtils.DeSerialize<KeystoneCreateProtocolResponse>);
        }
        
        /// <summary>
        /// 获取联邦认证scoped token
        ///
        /// 该接口可以用于通过联邦认证方式获取scoped token。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneCreateScopedTokenResponse> KeystoneCreateScopedTokenAsync(KeystoneCreateScopedTokenRequest keystoneCreateScopedTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateScopedTokenRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<KeystoneCreateScopedTokenResponse>(response);
        }

        public AsyncInvoker<KeystoneCreateScopedTokenResponse> KeystoneCreateScopedTokenAsyncInvoker(KeystoneCreateScopedTokenRequest keystoneCreateScopedTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateScopedTokenRequest);
            return new AsyncInvoker<KeystoneCreateScopedTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<KeystoneCreateScopedTokenResponse>);
        }
        
        /// <summary>
        /// 删除用户组
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)删除用户组。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneDeleteGroupResponse> KeystoneDeleteGroupAsync(KeystoneDeleteGroupRequest keystoneDeleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneDeleteGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneDeleteGroupResponse> KeystoneDeleteGroupAsyncInvoker(KeystoneDeleteGroupRequest keystoneDeleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneDeleteGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteGroupRequest);
            return new AsyncInvoker<KeystoneDeleteGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneDeleteGroupResponse>);
        }
        
        /// <summary>
        /// 删除身份提供商
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html) 删除身份提供商。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneDeleteIdentityProviderResponse> KeystoneDeleteIdentityProviderAsync(KeystoneDeleteIdentityProviderRequest keystoneDeleteIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneDeleteIdentityProviderRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteIdentityProviderRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteIdentityProviderResponse>(response);
        }

        public AsyncInvoker<KeystoneDeleteIdentityProviderResponse> KeystoneDeleteIdentityProviderAsyncInvoker(KeystoneDeleteIdentityProviderRequest keystoneDeleteIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneDeleteIdentityProviderRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteIdentityProviderRequest);
            return new AsyncInvoker<KeystoneDeleteIdentityProviderResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneDeleteIdentityProviderResponse>);
        }
        
        /// <summary>
        /// 删除映射
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)删除映射。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneDeleteMappingResponse> KeystoneDeleteMappingAsync(KeystoneDeleteMappingRequest keystoneDeleteMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneDeleteMappingRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteMappingRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteMappingResponse>(response);
        }

        public AsyncInvoker<KeystoneDeleteMappingResponse> KeystoneDeleteMappingAsyncInvoker(KeystoneDeleteMappingRequest keystoneDeleteMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneDeleteMappingRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteMappingRequest);
            return new AsyncInvoker<KeystoneDeleteMappingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneDeleteMappingResponse>);
        }
        
        /// <summary>
        /// 删除协议
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)删除协议。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneDeleteProtocolResponse> KeystoneDeleteProtocolAsync(KeystoneDeleteProtocolRequest keystoneDeleteProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneDeleteProtocolRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneDeleteProtocolRequest.ProtocolId, out var valueOfProtocolId)) urlParam.Add("protocol_id", valueOfProtocolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteProtocolRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteProtocolResponse>(response);
        }

        public AsyncInvoker<KeystoneDeleteProtocolResponse> KeystoneDeleteProtocolAsyncInvoker(KeystoneDeleteProtocolRequest keystoneDeleteProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneDeleteProtocolRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneDeleteProtocolRequest.ProtocolId, out var valueOfProtocolId)) urlParam.Add("protocol_id", valueOfProtocolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteProtocolRequest);
            return new AsyncInvoker<KeystoneDeleteProtocolResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneDeleteProtocolResponse>);
        }
        
        /// <summary>
        /// 查询用户组的所有项目权限列表
        ///
        /// 该接口可以用于管理员查询用户组所有项目服务权限列表。 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListAllProjectPermissionsForGroupResponse> KeystoneListAllProjectPermissionsForGroupAsync(KeystoneListAllProjectPermissionsForGroupRequest keystoneListAllProjectPermissionsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneListAllProjectPermissionsForGroupRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneListAllProjectPermissionsForGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAllProjectPermissionsForGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListAllProjectPermissionsForGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneListAllProjectPermissionsForGroupResponse> KeystoneListAllProjectPermissionsForGroupAsyncInvoker(KeystoneListAllProjectPermissionsForGroupRequest keystoneListAllProjectPermissionsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneListAllProjectPermissionsForGroupRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneListAllProjectPermissionsForGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAllProjectPermissionsForGroupRequest);
            return new AsyncInvoker<KeystoneListAllProjectPermissionsForGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListAllProjectPermissionsForGroupResponse>);
        }
        
        /// <summary>
        /// 查询IAM用户可以访问的账号详情
        ///
        /// 该接口可以用于查询IAM用户可以用访问的账号详情。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListAuthDomainsResponse> KeystoneListAuthDomainsAsync(KeystoneListAuthDomainsRequest keystoneListAuthDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAuthDomainsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListAuthDomainsResponse>(response);
        }

        public AsyncInvoker<KeystoneListAuthDomainsResponse> KeystoneListAuthDomainsAsyncInvoker(KeystoneListAuthDomainsRequest keystoneListAuthDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAuthDomainsRequest);
            return new AsyncInvoker<KeystoneListAuthDomainsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListAuthDomainsResponse>);
        }
        
        /// <summary>
        /// 查询IAM用户可以访问的项目列表
        ///
        /// 该接口可以用于查询IAM用户可以访问的项目列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListAuthProjectsResponse> KeystoneListAuthProjectsAsync(KeystoneListAuthProjectsRequest keystoneListAuthProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAuthProjectsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListAuthProjectsResponse>(response);
        }

        public AsyncInvoker<KeystoneListAuthProjectsResponse> KeystoneListAuthProjectsAsyncInvoker(KeystoneListAuthProjectsRequest keystoneListAuthProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAuthProjectsRequest);
            return new AsyncInvoker<KeystoneListAuthProjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListAuthProjectsResponse>);
        }
        
        /// <summary>
        /// 查询全局服务中的用户组权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询全局服务中的用户组权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListDomainPermissionsForGroupResponse> KeystoneListDomainPermissionsForGroupAsync(KeystoneListDomainPermissionsForGroupRequest keystoneListDomainPermissionsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneListDomainPermissionsForGroupRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneListDomainPermissionsForGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListDomainPermissionsForGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListDomainPermissionsForGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneListDomainPermissionsForGroupResponse> KeystoneListDomainPermissionsForGroupAsyncInvoker(KeystoneListDomainPermissionsForGroupRequest keystoneListDomainPermissionsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneListDomainPermissionsForGroupRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneListDomainPermissionsForGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListDomainPermissionsForGroupRequest);
            return new AsyncInvoker<KeystoneListDomainPermissionsForGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListDomainPermissionsForGroupResponse>);
        }
        
        /// <summary>
        /// 查询终端节点列表
        ///
        /// 该接口可以用于查询终端节点列表。终端节点用来提供服务访问入口。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListEndpointsResponse> KeystoneListEndpointsAsync(KeystoneListEndpointsRequest keystoneListEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListEndpointsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListEndpointsResponse>(response);
        }

        public AsyncInvoker<KeystoneListEndpointsResponse> KeystoneListEndpointsAsyncInvoker(KeystoneListEndpointsRequest keystoneListEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListEndpointsRequest);
            return new AsyncInvoker<KeystoneListEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListEndpointsResponse>);
        }
        
        /// <summary>
        /// 查询联邦用户可以访问的账号列表
        ///
        /// 该接口用于查询联邦用户可以访问的账号列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// &gt; - 推荐使用[查询IAM用户可以访问的账号详情](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;IAM&amp;api&#x3D;KeystoneQueryAccessibleDomainDetailsToUser)，该接口可以返回相同的响应格式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListFederationDomainsResponse> KeystoneListFederationDomainsAsync(KeystoneListFederationDomainsRequest keystoneListFederationDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListFederationDomainsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListFederationDomainsResponse>(response);
        }

        public AsyncInvoker<KeystoneListFederationDomainsResponse> KeystoneListFederationDomainsAsyncInvoker(KeystoneListFederationDomainsRequest keystoneListFederationDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListFederationDomainsRequest);
            return new AsyncInvoker<KeystoneListFederationDomainsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListFederationDomainsResponse>);
        }
        
        /// <summary>
        /// 查询联邦用户可以访问的项目列表
        ///
        /// 该接口可以用于查询联邦用户可以访问的项目列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// &gt; - 推荐使用[查询IAM用户可以访问的项目列表](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;IAM&amp;api&#x3D;KeystoneListAccessibleProjectsToUser)，该接口可以返回相同的响应格式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListFederationProjectsResponse> KeystoneListFederationProjectsAsync(KeystoneListFederationProjectsRequest keystoneListFederationProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListFederationProjectsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListFederationProjectsResponse>(response);
        }

        public AsyncInvoker<KeystoneListFederationProjectsResponse> KeystoneListFederationProjectsAsyncInvoker(KeystoneListFederationProjectsRequest keystoneListFederationProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListFederationProjectsRequest);
            return new AsyncInvoker<KeystoneListFederationProjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListFederationProjectsResponse>);
        }
        
        /// <summary>
        /// 查询用户组列表
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询用户组列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListGroupsResponse> KeystoneListGroupsAsync(KeystoneListGroupsRequest keystoneListGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListGroupsResponse>(response);
        }

        public AsyncInvoker<KeystoneListGroupsResponse> KeystoneListGroupsAsyncInvoker(KeystoneListGroupsRequest keystoneListGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListGroupsRequest);
            return new AsyncInvoker<KeystoneListGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListGroupsResponse>);
        }
        
        /// <summary>
        /// 查询身份提供商列表
        ///
        /// 该接口可以用于查询身份提供商列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListIdentityProvidersResponse> KeystoneListIdentityProvidersAsync(KeystoneListIdentityProvidersRequest keystoneListIdentityProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListIdentityProvidersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListIdentityProvidersResponse>(response);
        }

        public AsyncInvoker<KeystoneListIdentityProvidersResponse> KeystoneListIdentityProvidersAsyncInvoker(KeystoneListIdentityProvidersRequest keystoneListIdentityProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListIdentityProvidersRequest);
            return new AsyncInvoker<KeystoneListIdentityProvidersResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListIdentityProvidersResponse>);
        }
        
        /// <summary>
        /// 查询映射列表
        ///
        /// 该接口可以用于查询映射列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListMappingsResponse> KeystoneListMappingsAsync(KeystoneListMappingsRequest keystoneListMappingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListMappingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListMappingsResponse>(response);
        }

        public AsyncInvoker<KeystoneListMappingsResponse> KeystoneListMappingsAsyncInvoker(KeystoneListMappingsRequest keystoneListMappingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListMappingsRequest);
            return new AsyncInvoker<KeystoneListMappingsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListMappingsResponse>);
        }
        
        /// <summary>
        /// 查询权限列表
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询权限列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListPermissionsResponse> KeystoneListPermissionsAsync(KeystoneListPermissionsRequest keystoneListPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListPermissionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListPermissionsResponse>(response);
        }

        public AsyncInvoker<KeystoneListPermissionsResponse> KeystoneListPermissionsAsyncInvoker(KeystoneListPermissionsRequest keystoneListPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListPermissionsRequest);
            return new AsyncInvoker<KeystoneListPermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListPermissionsResponse>);
        }
        
        /// <summary>
        /// 查询项目服务中的用户组权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询项目服务中的用户组权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListProjectPermissionsForGroupResponse> KeystoneListProjectPermissionsForGroupAsync(KeystoneListProjectPermissionsForGroupRequest keystoneListProjectPermissionsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneListProjectPermissionsForGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneListProjectPermissionsForGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectPermissionsForGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListProjectPermissionsForGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneListProjectPermissionsForGroupResponse> KeystoneListProjectPermissionsForGroupAsyncInvoker(KeystoneListProjectPermissionsForGroupRequest keystoneListProjectPermissionsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneListProjectPermissionsForGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneListProjectPermissionsForGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectPermissionsForGroupRequest);
            return new AsyncInvoker<KeystoneListProjectPermissionsForGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListProjectPermissionsForGroupResponse>);
        }
        
        /// <summary>
        /// 查询指定条件下的项目列表
        ///
        /// 该接口可以用于查询指定条件下的项目列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListProjectsResponse> KeystoneListProjectsAsync(KeystoneListProjectsRequest keystoneListProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListProjectsResponse>(response);
        }

        public AsyncInvoker<KeystoneListProjectsResponse> KeystoneListProjectsAsyncInvoker(KeystoneListProjectsRequest keystoneListProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectsRequest);
            return new AsyncInvoker<KeystoneListProjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListProjectsResponse>);
        }
        
        /// <summary>
        /// 查询指定IAM用户的项目列表
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询指定IAM用户的项目列表，或IAM用户查询自己的项目列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListProjectsForUserResponse> KeystoneListProjectsForUserAsync(KeystoneListProjectsForUserRequest keystoneListProjectsForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneListProjectsForUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectsForUserRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListProjectsForUserResponse>(response);
        }

        public AsyncInvoker<KeystoneListProjectsForUserResponse> KeystoneListProjectsForUserAsyncInvoker(KeystoneListProjectsForUserRequest keystoneListProjectsForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneListProjectsForUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectsForUserRequest);
            return new AsyncInvoker<KeystoneListProjectsForUserResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListProjectsForUserResponse>);
        }
        
        /// <summary>
        /// 查询协议列表
        ///
        /// 该接口可以用于查询协议列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListProtocolsResponse> KeystoneListProtocolsAsync(KeystoneListProtocolsRequest keystoneListProtocolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneListProtocolsRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProtocolsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListProtocolsResponse>(response);
        }

        public AsyncInvoker<KeystoneListProtocolsResponse> KeystoneListProtocolsAsyncInvoker(KeystoneListProtocolsRequest keystoneListProtocolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneListProtocolsRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProtocolsRequest);
            return new AsyncInvoker<KeystoneListProtocolsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListProtocolsResponse>);
        }
        
        /// <summary>
        /// 查询区域列表
        ///
        /// 该接口可以用于查询区域列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListRegionsResponse> KeystoneListRegionsAsync(KeystoneListRegionsRequest keystoneListRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListRegionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListRegionsResponse>(response);
        }

        public AsyncInvoker<KeystoneListRegionsResponse> KeystoneListRegionsAsyncInvoker(KeystoneListRegionsRequest keystoneListRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListRegionsRequest);
            return new AsyncInvoker<KeystoneListRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListRegionsResponse>);
        }
        
        /// <summary>
        /// 查询服务列表
        ///
        /// 该接口可以用于查询服务列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListServicesResponse> KeystoneListServicesAsync(KeystoneListServicesRequest keystoneListServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListServicesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListServicesResponse>(response);
        }

        public AsyncInvoker<KeystoneListServicesResponse> KeystoneListServicesAsyncInvoker(KeystoneListServicesRequest keystoneListServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListServicesRequest);
            return new AsyncInvoker<KeystoneListServicesResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListServicesResponse>);
        }
        
        /// <summary>
        /// 查询版本信息列表
        ///
        /// 该接口用于查询Keystone API的版本信息。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListVersionsResponse> KeystoneListVersionsAsync(KeystoneListVersionsRequest keystoneListVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListVersionsResponse>(response);
        }

        public AsyncInvoker<KeystoneListVersionsResponse> KeystoneListVersionsAsyncInvoker(KeystoneListVersionsRequest keystoneListVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListVersionsRequest);
            return new AsyncInvoker<KeystoneListVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListVersionsResponse>);
        }
        
        /// <summary>
        /// 移除用户组的全局服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)移除用户组的全局服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneRemoveDomainPermissionFromGroupResponse> KeystoneRemoveDomainPermissionFromGroupAsync(KeystoneRemoveDomainPermissionFromGroupRequest keystoneRemoveDomainPermissionFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveDomainPermissionFromGroupRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveDomainPermissionFromGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveDomainPermissionFromGroupRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveDomainPermissionFromGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveDomainPermissionFromGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneRemoveDomainPermissionFromGroupResponse> KeystoneRemoveDomainPermissionFromGroupAsyncInvoker(KeystoneRemoveDomainPermissionFromGroupRequest keystoneRemoveDomainPermissionFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveDomainPermissionFromGroupRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveDomainPermissionFromGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveDomainPermissionFromGroupRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveDomainPermissionFromGroupRequest);
            return new AsyncInvoker<KeystoneRemoveDomainPermissionFromGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneRemoveDomainPermissionFromGroupResponse>);
        }
        
        /// <summary>
        /// 移除用户组的项目服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)移除用户组的项目服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneRemoveProjectPermissionFromGroupResponse> KeystoneRemoveProjectPermissionFromGroupAsync(KeystoneRemoveProjectPermissionFromGroupRequest keystoneRemoveProjectPermissionFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveProjectPermissionFromGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveProjectPermissionFromGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveProjectPermissionFromGroupRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveProjectPermissionFromGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveProjectPermissionFromGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneRemoveProjectPermissionFromGroupResponse> KeystoneRemoveProjectPermissionFromGroupAsyncInvoker(KeystoneRemoveProjectPermissionFromGroupRequest keystoneRemoveProjectPermissionFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveProjectPermissionFromGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveProjectPermissionFromGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveProjectPermissionFromGroupRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveProjectPermissionFromGroupRequest);
            return new AsyncInvoker<KeystoneRemoveProjectPermissionFromGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneRemoveProjectPermissionFromGroupResponse>);
        }
        
        /// <summary>
        /// 移除用户组中的IAM用户
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)移除用户组中的IAM用户。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneRemoveUserFromGroupResponse> KeystoneRemoveUserFromGroupAsync(KeystoneRemoveUserFromGroupRequest keystoneRemoveUserFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveUserFromGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveUserFromGroupRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveUserFromGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveUserFromGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneRemoveUserFromGroupResponse> KeystoneRemoveUserFromGroupAsyncInvoker(KeystoneRemoveUserFromGroupRequest keystoneRemoveUserFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveUserFromGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneRemoveUserFromGroupRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveUserFromGroupRequest);
            return new AsyncInvoker<KeystoneRemoveUserFromGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneRemoveUserFromGroupResponse>);
        }
        
        /// <summary>
        /// 查询服务目录
        ///
        /// 该接口可以用于查询请求头中X-Auth-Token对应的服务目录。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneShowCatalogResponse> KeystoneShowCatalogAsync(KeystoneShowCatalogRequest keystoneShowCatalogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/catalog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowCatalogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowCatalogResponse>(response);
        }

        public AsyncInvoker<KeystoneShowCatalogResponse> KeystoneShowCatalogAsyncInvoker(KeystoneShowCatalogRequest keystoneShowCatalogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/catalog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowCatalogRequest);
            return new AsyncInvoker<KeystoneShowCatalogResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowCatalogResponse>);
        }
        
        /// <summary>
        /// 查询终端节点详情
        ///
        /// 该接口可以用于查询终端节点详情。终端节点用来提供服务访问入口。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneShowEndpointResponse> KeystoneShowEndpointAsync(KeystoneShowEndpointRequest keystoneShowEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v3/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowEndpointRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowEndpointResponse>(response);
        }

        public AsyncInvoker<KeystoneShowEndpointResponse> KeystoneShowEndpointAsyncInvoker(KeystoneShowEndpointRequest keystoneShowEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v3/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowEndpointRequest);
            return new AsyncInvoker<KeystoneShowEndpointResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowEndpointResponse>);
        }
        
        /// <summary>
        /// 查询用户组详情
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询用户组详情。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneShowGroupResponse> KeystoneShowGroupAsync(KeystoneShowGroupRequest keystoneShowGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneShowGroupResponse> KeystoneShowGroupAsyncInvoker(KeystoneShowGroupRequest keystoneShowGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowGroupRequest);
            return new AsyncInvoker<KeystoneShowGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowGroupResponse>);
        }
        
        /// <summary>
        /// 查询身份提供商详情
        ///
        /// 该接口可以用于查询身份提供商详情。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneShowIdentityProviderResponse> KeystoneShowIdentityProviderAsync(KeystoneShowIdentityProviderRequest keystoneShowIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowIdentityProviderRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowIdentityProviderRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowIdentityProviderResponse>(response);
        }

        public AsyncInvoker<KeystoneShowIdentityProviderResponse> KeystoneShowIdentityProviderAsyncInvoker(KeystoneShowIdentityProviderRequest keystoneShowIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowIdentityProviderRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowIdentityProviderRequest);
            return new AsyncInvoker<KeystoneShowIdentityProviderResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowIdentityProviderResponse>);
        }
        
        /// <summary>
        /// 查询映射详情
        ///
        /// 该接口可以用于查询映射详情。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneShowMappingResponse> KeystoneShowMappingAsync(KeystoneShowMappingRequest keystoneShowMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowMappingRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowMappingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowMappingResponse>(response);
        }

        public AsyncInvoker<KeystoneShowMappingResponse> KeystoneShowMappingAsyncInvoker(KeystoneShowMappingRequest keystoneShowMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowMappingRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowMappingRequest);
            return new AsyncInvoker<KeystoneShowMappingResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowMappingResponse>);
        }
        
        /// <summary>
        /// 查询权限详情
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询权限详情。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneShowPermissionResponse> KeystoneShowPermissionAsync(KeystoneShowPermissionRequest keystoneShowPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowPermissionRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowPermissionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowPermissionResponse>(response);
        }

        public AsyncInvoker<KeystoneShowPermissionResponse> KeystoneShowPermissionAsyncInvoker(KeystoneShowPermissionRequest keystoneShowPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowPermissionRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowPermissionRequest);
            return new AsyncInvoker<KeystoneShowPermissionResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowPermissionResponse>);
        }
        
        /// <summary>
        /// 查询项目详情
        ///
        /// 该接口可以用于查询项目详情。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneShowProjectResponse> KeystoneShowProjectAsync(KeystoneShowProjectRequest keystoneShowProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowProjectRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowProjectRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowProjectResponse>(response);
        }

        public AsyncInvoker<KeystoneShowProjectResponse> KeystoneShowProjectAsyncInvoker(KeystoneShowProjectRequest keystoneShowProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowProjectRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowProjectRequest);
            return new AsyncInvoker<KeystoneShowProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowProjectResponse>);
        }
        
        /// <summary>
        /// 查询协议详情
        ///
        /// 该接口可以用于查询协议详情。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneShowProtocolResponse> KeystoneShowProtocolAsync(KeystoneShowProtocolRequest keystoneShowProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowProtocolRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowProtocolRequest.ProtocolId, out var valueOfProtocolId)) urlParam.Add("protocol_id", valueOfProtocolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowProtocolRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowProtocolResponse>(response);
        }

        public AsyncInvoker<KeystoneShowProtocolResponse> KeystoneShowProtocolAsyncInvoker(KeystoneShowProtocolRequest keystoneShowProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowProtocolRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowProtocolRequest.ProtocolId, out var valueOfProtocolId)) urlParam.Add("protocol_id", valueOfProtocolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowProtocolRequest);
            return new AsyncInvoker<KeystoneShowProtocolResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowProtocolResponse>);
        }
        
        /// <summary>
        /// 查询区域详情
        ///
        /// 该接口可以用于查询区域详情。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneShowRegionResponse> KeystoneShowRegionAsync(KeystoneShowRegionRequest keystoneShowRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowRegionRequest.RegionId, out var valueOfRegionId)) urlParam.Add("region_id", valueOfRegionId);
            var urlPath = HttpUtils.AddUrlPath("/v3/regions/{region_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowRegionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowRegionResponse>(response);
        }

        public AsyncInvoker<KeystoneShowRegionResponse> KeystoneShowRegionAsyncInvoker(KeystoneShowRegionRequest keystoneShowRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowRegionRequest.RegionId, out var valueOfRegionId)) urlParam.Add("region_id", valueOfRegionId);
            var urlPath = HttpUtils.AddUrlPath("/v3/regions/{region_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowRegionRequest);
            return new AsyncInvoker<KeystoneShowRegionResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowRegionResponse>);
        }
        
        /// <summary>
        /// 查询账号密码强度策略
        ///
        /// 该接口可以用于查询账号密码强度策略，查询结果包括密码强度策略的正则表达式及其描述。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneShowSecurityComplianceResponse> KeystoneShowSecurityComplianceAsync(KeystoneShowSecurityComplianceRequest keystoneShowSecurityComplianceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowSecurityComplianceRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowSecurityComplianceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowSecurityComplianceResponse>(response);
        }

        public AsyncInvoker<KeystoneShowSecurityComplianceResponse> KeystoneShowSecurityComplianceAsyncInvoker(KeystoneShowSecurityComplianceRequest keystoneShowSecurityComplianceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowSecurityComplianceRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowSecurityComplianceRequest);
            return new AsyncInvoker<KeystoneShowSecurityComplianceResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowSecurityComplianceResponse>);
        }
        
        /// <summary>
        /// 按条件查询账号密码强度策略
        ///
        /// 该接口可以用于按条件查询账号密码强度策略，查询结果包括密码强度策略的正则表达式及其描述。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneShowSecurityComplianceByOptionResponse> KeystoneShowSecurityComplianceByOptionAsync(KeystoneShowSecurityComplianceByOptionRequest keystoneShowSecurityComplianceByOptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowSecurityComplianceByOptionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowSecurityComplianceByOptionRequest.Option, out var valueOfOption)) urlParam.Add("option", valueOfOption);
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance/{option}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowSecurityComplianceByOptionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowSecurityComplianceByOptionResponse>(response);
        }

        public AsyncInvoker<KeystoneShowSecurityComplianceByOptionResponse> KeystoneShowSecurityComplianceByOptionAsyncInvoker(KeystoneShowSecurityComplianceByOptionRequest keystoneShowSecurityComplianceByOptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowSecurityComplianceByOptionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowSecurityComplianceByOptionRequest.Option, out var valueOfOption)) urlParam.Add("option", valueOfOption);
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance/{option}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowSecurityComplianceByOptionRequest);
            return new AsyncInvoker<KeystoneShowSecurityComplianceByOptionResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowSecurityComplianceByOptionResponse>);
        }
        
        /// <summary>
        /// 查询服务详情
        ///
        /// 该接口可以用于查询服务详情。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneShowServiceResponse> KeystoneShowServiceAsync(KeystoneShowServiceRequest keystoneShowServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowServiceRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/services/{service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowServiceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowServiceResponse>(response);
        }

        public AsyncInvoker<KeystoneShowServiceResponse> KeystoneShowServiceAsyncInvoker(KeystoneShowServiceRequest keystoneShowServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowServiceRequest.ServiceId, out var valueOfServiceId)) urlParam.Add("service_id", valueOfServiceId);
            var urlPath = HttpUtils.AddUrlPath("/v3/services/{service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowServiceRequest);
            return new AsyncInvoker<KeystoneShowServiceResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowServiceResponse>);
        }
        
        /// <summary>
        /// 查询版本信息
        ///
        /// 该接口用于查询Keystone API的3.0版本的信息。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneShowVersionResponse> KeystoneShowVersionAsync(KeystoneShowVersionRequest keystoneShowVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowVersionResponse>(response);
        }

        public AsyncInvoker<KeystoneShowVersionResponse> KeystoneShowVersionAsyncInvoker(KeystoneShowVersionRequest keystoneShowVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowVersionRequest);
            return new AsyncInvoker<KeystoneShowVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowVersionResponse>);
        }
        
        /// <summary>
        /// 更新用户组
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)更新用户组信息。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneUpdateGroupResponse> KeystoneUpdateGroupAsync(KeystoneUpdateGroupRequest keystoneUpdateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateGroupRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<KeystoneUpdateGroupResponse>(response);
        }

        public AsyncInvoker<KeystoneUpdateGroupResponse> KeystoneUpdateGroupAsyncInvoker(KeystoneUpdateGroupRequest keystoneUpdateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateGroupRequest);
            return new AsyncInvoker<KeystoneUpdateGroupResponse>(this, "PATCH", request, JsonUtils.DeSerialize<KeystoneUpdateGroupResponse>);
        }
        
        /// <summary>
        /// 更新身份提供商
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)更新身份提供商。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneUpdateIdentityProviderResponse> KeystoneUpdateIdentityProviderAsync(KeystoneUpdateIdentityProviderRequest keystoneUpdateIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateIdentityProviderRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateIdentityProviderRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<KeystoneUpdateIdentityProviderResponse>(response);
        }

        public AsyncInvoker<KeystoneUpdateIdentityProviderResponse> KeystoneUpdateIdentityProviderAsyncInvoker(KeystoneUpdateIdentityProviderRequest keystoneUpdateIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateIdentityProviderRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateIdentityProviderRequest);
            return new AsyncInvoker<KeystoneUpdateIdentityProviderResponse>(this, "PATCH", request, JsonUtils.DeSerialize<KeystoneUpdateIdentityProviderResponse>);
        }
        
        /// <summary>
        /// 更新映射
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)更新映射。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneUpdateMappingResponse> KeystoneUpdateMappingAsync(KeystoneUpdateMappingRequest keystoneUpdateMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateMappingRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateMappingRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<KeystoneUpdateMappingResponse>(response);
        }

        public AsyncInvoker<KeystoneUpdateMappingResponse> KeystoneUpdateMappingAsyncInvoker(KeystoneUpdateMappingRequest keystoneUpdateMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateMappingRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateMappingRequest);
            return new AsyncInvoker<KeystoneUpdateMappingResponse>(this, "PATCH", request, JsonUtils.DeSerialize<KeystoneUpdateMappingResponse>);
        }
        
        /// <summary>
        /// 修改项目信息
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)修改项目信息。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneUpdateProjectResponse> KeystoneUpdateProjectAsync(KeystoneUpdateProjectRequest keystoneUpdateProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateProjectRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateProjectRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<KeystoneUpdateProjectResponse>(response);
        }

        public AsyncInvoker<KeystoneUpdateProjectResponse> KeystoneUpdateProjectAsyncInvoker(KeystoneUpdateProjectRequest keystoneUpdateProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateProjectRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateProjectRequest);
            return new AsyncInvoker<KeystoneUpdateProjectResponse>(this, "PATCH", request, JsonUtils.DeSerialize<KeystoneUpdateProjectResponse>);
        }
        
        /// <summary>
        /// 更新协议
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)更新协议。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneUpdateProtocolResponse> KeystoneUpdateProtocolAsync(KeystoneUpdateProtocolRequest keystoneUpdateProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateProtocolRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateProtocolRequest.ProtocolId, out var valueOfProtocolId)) urlParam.Add("protocol_id", valueOfProtocolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateProtocolRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<KeystoneUpdateProtocolResponse>(response);
        }

        public AsyncInvoker<KeystoneUpdateProtocolResponse> KeystoneUpdateProtocolAsyncInvoker(KeystoneUpdateProtocolRequest keystoneUpdateProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateProtocolRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateProtocolRequest.ProtocolId, out var valueOfProtocolId)) urlParam.Add("protocol_id", valueOfProtocolId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateProtocolRequest);
            return new AsyncInvoker<KeystoneUpdateProtocolResponse>(this, "PATCH", request, JsonUtils.DeSerialize<KeystoneUpdateProtocolResponse>);
        }
        
        /// <summary>
        /// 查询指定条件下的委托列表
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询指定条件下的委托列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAgenciesResponse> ListAgenciesAsync(ListAgenciesRequest listAgenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgenciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAgenciesResponse>(response);
        }

        public AsyncInvoker<ListAgenciesResponse> ListAgenciesAsyncInvoker(ListAgenciesRequest listAgenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgenciesRequest);
            return new AsyncInvoker<ListAgenciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAgenciesResponse>);
        }
        
        /// <summary>
        /// 查询委托下的所有项目服务权限列表
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询委托所有项目服务权限列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllProjectsPermissionsForAgencyResponse> ListAllProjectsPermissionsForAgencyAsync(ListAllProjectsPermissionsForAgencyRequest listAllProjectsPermissionsForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAllProjectsPermissionsForAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(listAllProjectsPermissionsForAgencyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllProjectsPermissionsForAgencyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllProjectsPermissionsForAgencyResponse>(response);
        }

        public AsyncInvoker<ListAllProjectsPermissionsForAgencyResponse> ListAllProjectsPermissionsForAgencyAsyncInvoker(ListAllProjectsPermissionsForAgencyRequest listAllProjectsPermissionsForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAllProjectsPermissionsForAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(listAllProjectsPermissionsForAgencyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllProjectsPermissionsForAgencyRequest);
            return new AsyncInvoker<ListAllProjectsPermissionsForAgencyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllProjectsPermissionsForAgencyResponse>);
        }
        
        /// <summary>
        /// 查询自定义策略列表
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询自定义策略列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCustomPoliciesResponse> ListCustomPoliciesAsync(ListCustomPoliciesRequest listCustomPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomPoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCustomPoliciesResponse>(response);
        }

        public AsyncInvoker<ListCustomPoliciesResponse> ListCustomPoliciesAsyncInvoker(ListCustomPoliciesRequest listCustomPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomPoliciesRequest);
            return new AsyncInvoker<ListCustomPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCustomPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询全局服务中的委托权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询全局服务中的委托权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainPermissionsForAgencyResponse> ListDomainPermissionsForAgencyAsync(ListDomainPermissionsForAgencyRequest listDomainPermissionsForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainPermissionsForAgencyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(listDomainPermissionsForAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainPermissionsForAgencyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainPermissionsForAgencyResponse>(response);
        }

        public AsyncInvoker<ListDomainPermissionsForAgencyResponse> ListDomainPermissionsForAgencyAsyncInvoker(ListDomainPermissionsForAgencyRequest listDomainPermissionsForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainPermissionsForAgencyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(listDomainPermissionsForAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainPermissionsForAgencyRequest);
            return new AsyncInvoker<ListDomainPermissionsForAgencyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainPermissionsForAgencyResponse>);
        }
        
        /// <summary>
        /// 查询用户组关联的企业项目
        ///
        /// 该接口可用于查询用户组所关联的企业项目。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnterpriseProjectsForGroupResponse> ListEnterpriseProjectsForGroupAsync(ListEnterpriseProjectsForGroupRequest listEnterpriseProjectsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnterpriseProjectsForGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/groups/{group_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectsForGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEnterpriseProjectsForGroupResponse>(response);
        }

        public AsyncInvoker<ListEnterpriseProjectsForGroupResponse> ListEnterpriseProjectsForGroupAsyncInvoker(ListEnterpriseProjectsForGroupRequest listEnterpriseProjectsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnterpriseProjectsForGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/groups/{group_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectsForGroupRequest);
            return new AsyncInvoker<ListEnterpriseProjectsForGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnterpriseProjectsForGroupResponse>);
        }
        
        /// <summary>
        /// 查询用户直接关联的企业项目
        ///
        /// 该接口可用于查询用户所关联的企业项目。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnterpriseProjectsForUserResponse> ListEnterpriseProjectsForUserAsync(ListEnterpriseProjectsForUserRequest listEnterpriseProjectsForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnterpriseProjectsForUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/users/{user_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectsForUserRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEnterpriseProjectsForUserResponse>(response);
        }

        public AsyncInvoker<ListEnterpriseProjectsForUserResponse> ListEnterpriseProjectsForUserAsyncInvoker(ListEnterpriseProjectsForUserRequest listEnterpriseProjectsForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEnterpriseProjectsForUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/users/{user_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectsForUserRequest);
            return new AsyncInvoker<ListEnterpriseProjectsForUserResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnterpriseProjectsForUserResponse>);
        }
        
        /// <summary>
        /// 查询企业项目关联的用户组
        ///
        /// 该接口可用于查询企业项目关联的用户组。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupsForEnterpriseProjectResponse> ListGroupsForEnterpriseProjectAsync(ListGroupsForEnterpriseProjectRequest listGroupsForEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupsForEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsForEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGroupsForEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<ListGroupsForEnterpriseProjectResponse> ListGroupsForEnterpriseProjectAsyncInvoker(ListGroupsForEnterpriseProjectRequest listGroupsForEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupsForEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsForEnterpriseProjectRequest);
            return new AsyncInvoker<ListGroupsForEnterpriseProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupsForEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 查询项目服务中的委托权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询项目服务中的委托权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectPermissionsForAgencyResponse> ListProjectPermissionsForAgencyAsync(ListProjectPermissionsForAgencyRequest listProjectPermissionsForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectPermissionsForAgencyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listProjectPermissionsForAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectPermissionsForAgencyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectPermissionsForAgencyResponse>(response);
        }

        public AsyncInvoker<ListProjectPermissionsForAgencyResponse> ListProjectPermissionsForAgencyAsyncInvoker(ListProjectPermissionsForAgencyRequest listProjectPermissionsForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectPermissionsForAgencyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listProjectPermissionsForAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectPermissionsForAgencyRequest);
            return new AsyncInvoker<ListProjectPermissionsForAgencyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectPermissionsForAgencyResponse>);
        }
        
        /// <summary>
        /// 查询企业项目关联用户组的权限
        ///
        /// 该接口可用于查询企业项目已关联用户组的权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRolesForGroupOnEnterpriseProjectResponse> ListRolesForGroupOnEnterpriseProjectAsync(ListRolesForGroupOnEnterpriseProjectRequest listRolesForGroupOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRolesForGroupOnEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listRolesForGroupOnEnterpriseProjectRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRolesForGroupOnEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRolesForGroupOnEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<ListRolesForGroupOnEnterpriseProjectResponse> ListRolesForGroupOnEnterpriseProjectAsyncInvoker(ListRolesForGroupOnEnterpriseProjectRequest listRolesForGroupOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRolesForGroupOnEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listRolesForGroupOnEnterpriseProjectRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRolesForGroupOnEnterpriseProjectRequest);
            return new AsyncInvoker<ListRolesForGroupOnEnterpriseProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRolesForGroupOnEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 查询企业项目直接关联用户的权限
        ///
        /// 该接口可用于查询企业项目直接关联用户的权限。
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRolesForUserOnEnterpriseProjectResponse> ListRolesForUserOnEnterpriseProjectAsync(ListRolesForUserOnEnterpriseProjectRequest listRolesForUserOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRolesForUserOnEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listRolesForUserOnEnterpriseProjectRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRolesForUserOnEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRolesForUserOnEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<ListRolesForUserOnEnterpriseProjectResponse> ListRolesForUserOnEnterpriseProjectAsyncInvoker(ListRolesForUserOnEnterpriseProjectRequest listRolesForUserOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRolesForUserOnEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listRolesForUserOnEnterpriseProjectRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRolesForUserOnEnterpriseProjectRequest);
            return new AsyncInvoker<ListRolesForUserOnEnterpriseProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRolesForUserOnEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 查询企业项目直接关联用户
        ///
        /// 该接口可用于查询企业项目直接关联的用户。
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUsersForEnterpriseProjectResponse> ListUsersForEnterpriseProjectAsync(ListUsersForEnterpriseProjectRequest listUsersForEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUsersForEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersForEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUsersForEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<ListUsersForEnterpriseProjectResponse> ListUsersForEnterpriseProjectAsyncInvoker(ListUsersForEnterpriseProjectRequest listUsersForEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUsersForEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersForEnterpriseProjectRequest);
            return new AsyncInvoker<ListUsersForEnterpriseProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersForEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 移除委托下的所有项目服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)移除委托的所有项目服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveAllProjectsPermissionFromAgencyResponse> RemoveAllProjectsPermissionFromAgencyAsync(RemoveAllProjectsPermissionFromAgencyRequest removeAllProjectsPermissionFromAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeAllProjectsPermissionFromAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(removeAllProjectsPermissionFromAgencyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(removeAllProjectsPermissionFromAgencyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeAllProjectsPermissionFromAgencyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveAllProjectsPermissionFromAgencyResponse>(response);
        }

        public AsyncInvoker<RemoveAllProjectsPermissionFromAgencyResponse> RemoveAllProjectsPermissionFromAgencyAsyncInvoker(RemoveAllProjectsPermissionFromAgencyRequest removeAllProjectsPermissionFromAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeAllProjectsPermissionFromAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(removeAllProjectsPermissionFromAgencyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(removeAllProjectsPermissionFromAgencyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeAllProjectsPermissionFromAgencyRequest);
            return new AsyncInvoker<RemoveAllProjectsPermissionFromAgencyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveAllProjectsPermissionFromAgencyResponse>);
        }
        
        /// <summary>
        /// 移除委托的全局服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)移除委托的全局服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveDomainPermissionFromAgencyResponse> RemoveDomainPermissionFromAgencyAsync(RemoveDomainPermissionFromAgencyRequest removeDomainPermissionFromAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeDomainPermissionFromAgencyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(removeDomainPermissionFromAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(removeDomainPermissionFromAgencyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeDomainPermissionFromAgencyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveDomainPermissionFromAgencyResponse>(response);
        }

        public AsyncInvoker<RemoveDomainPermissionFromAgencyResponse> RemoveDomainPermissionFromAgencyAsyncInvoker(RemoveDomainPermissionFromAgencyRequest removeDomainPermissionFromAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeDomainPermissionFromAgencyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(removeDomainPermissionFromAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(removeDomainPermissionFromAgencyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeDomainPermissionFromAgencyRequest);
            return new AsyncInvoker<RemoveDomainPermissionFromAgencyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveDomainPermissionFromAgencyResponse>);
        }
        
        /// <summary>
        /// 移除委托的项目服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)移除委托的项目服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveProjectPermissionFromAgencyResponse> RemoveProjectPermissionFromAgencyAsync(RemoveProjectPermissionFromAgencyRequest removeProjectPermissionFromAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeProjectPermissionFromAgencyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(removeProjectPermissionFromAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(removeProjectPermissionFromAgencyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeProjectPermissionFromAgencyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveProjectPermissionFromAgencyResponse>(response);
        }

        public AsyncInvoker<RemoveProjectPermissionFromAgencyResponse> RemoveProjectPermissionFromAgencyAsyncInvoker(RemoveProjectPermissionFromAgencyRequest removeProjectPermissionFromAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeProjectPermissionFromAgencyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(removeProjectPermissionFromAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            if (StringUtils.TryConvertToNonEmptyString(removeProjectPermissionFromAgencyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeProjectPermissionFromAgencyRequest);
            return new AsyncInvoker<RemoveProjectPermissionFromAgencyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveProjectPermissionFromAgencyResponse>);
        }
        
        /// <summary>
        /// 删除企业项目关联委托的权限
        ///
        /// 该接口可以删除企业项目委托上的授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RevokeRoleFromAgencyOnEnterpriseProjectResponse> RevokeRoleFromAgencyOnEnterpriseProjectAsync(RevokeRoleFromAgencyOnEnterpriseProjectRequest revokeRoleFromAgencyOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/subjects/agency/scopes/enterprise-project/role-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromAgencyOnEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<RevokeRoleFromAgencyOnEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<RevokeRoleFromAgencyOnEnterpriseProjectResponse> RevokeRoleFromAgencyOnEnterpriseProjectAsyncInvoker(RevokeRoleFromAgencyOnEnterpriseProjectRequest revokeRoleFromAgencyOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/subjects/agency/scopes/enterprise-project/role-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromAgencyOnEnterpriseProjectRequest);
            return new AsyncInvoker<RevokeRoleFromAgencyOnEnterpriseProjectResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RevokeRoleFromAgencyOnEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 删除企业项目关联用户组的权限
        ///
        /// 该接口用于删除企业项目关联用户组的权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RevokeRoleFromGroupOnEnterpriseProjectResponse> RevokeRoleFromGroupOnEnterpriseProjectAsync(RevokeRoleFromGroupOnEnterpriseProjectRequest revokeRoleFromGroupOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(revokeRoleFromGroupOnEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            if (StringUtils.TryConvertToNonEmptyString(revokeRoleFromGroupOnEnterpriseProjectRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(revokeRoleFromGroupOnEnterpriseProjectRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromGroupOnEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<RevokeRoleFromGroupOnEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<RevokeRoleFromGroupOnEnterpriseProjectResponse> RevokeRoleFromGroupOnEnterpriseProjectAsyncInvoker(RevokeRoleFromGroupOnEnterpriseProjectRequest revokeRoleFromGroupOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(revokeRoleFromGroupOnEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            if (StringUtils.TryConvertToNonEmptyString(revokeRoleFromGroupOnEnterpriseProjectRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(revokeRoleFromGroupOnEnterpriseProjectRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromGroupOnEnterpriseProjectRequest);
            return new AsyncInvoker<RevokeRoleFromGroupOnEnterpriseProjectResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RevokeRoleFromGroupOnEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 删除企业项目直接关联用户的权限
        ///
        /// 删除企业项目直接关联用户的权限。
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RevokeRoleFromUserOnEnterpriseProjectResponse> RevokeRoleFromUserOnEnterpriseProjectAsync(RevokeRoleFromUserOnEnterpriseProjectRequest revokeRoleFromUserOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(revokeRoleFromUserOnEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            if (StringUtils.TryConvertToNonEmptyString(revokeRoleFromUserOnEnterpriseProjectRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(revokeRoleFromUserOnEnterpriseProjectRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromUserOnEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<RevokeRoleFromUserOnEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<RevokeRoleFromUserOnEnterpriseProjectResponse> RevokeRoleFromUserOnEnterpriseProjectAsyncInvoker(RevokeRoleFromUserOnEnterpriseProjectRequest revokeRoleFromUserOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(revokeRoleFromUserOnEnterpriseProjectRequest.EnterpriseProjectId, out var valueOfEnterpriseProjectId)) urlParam.Add("enterprise_project_id", valueOfEnterpriseProjectId);
            if (StringUtils.TryConvertToNonEmptyString(revokeRoleFromUserOnEnterpriseProjectRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(revokeRoleFromUserOnEnterpriseProjectRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromUserOnEnterpriseProjectRequest);
            return new AsyncInvoker<RevokeRoleFromUserOnEnterpriseProjectResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RevokeRoleFromUserOnEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 查询委托详情
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询委托详情。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAgencyResponse> ShowAgencyAsync(ShowAgencyRequest showAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAgencyResponse>(response);
        }

        public AsyncInvoker<ShowAgencyResponse> ShowAgencyAsyncInvoker(ShowAgencyRequest showAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyRequest);
            return new AsyncInvoker<ShowAgencyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAgencyResponse>);
        }
        
        /// <summary>
        /// 查询自定义策略详情
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询自定义策略详情。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCustomPolicyResponse> ShowCustomPolicyAsync(ShowCustomPolicyRequest showCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCustomPolicyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCustomPolicyResponse>(response);
        }

        public AsyncInvoker<ShowCustomPolicyResponse> ShowCustomPolicyAsyncInvoker(ShowCustomPolicyRequest showCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCustomPolicyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomPolicyRequest);
            return new AsyncInvoker<ShowCustomPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCustomPolicyResponse>);
        }
        
        /// <summary>
        /// 查询账号接口访问策略
        ///
        /// 该接口可以用于查询账号接口访问控制策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainApiAclPolicyResponse> ShowDomainApiAclPolicyAsync(ShowDomainApiAclPolicyRequest showDomainApiAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainApiAclPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/api-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainApiAclPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainApiAclPolicyResponse>(response);
        }

        public AsyncInvoker<ShowDomainApiAclPolicyResponse> ShowDomainApiAclPolicyAsyncInvoker(ShowDomainApiAclPolicyRequest showDomainApiAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainApiAclPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/api-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainApiAclPolicyRequest);
            return new AsyncInvoker<ShowDomainApiAclPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainApiAclPolicyResponse>);
        }
        
        /// <summary>
        /// 查询账号控制台访问策略
        ///
        /// 该接口可以用于查询账号控制台访问控制策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainConsoleAclPolicyResponse> ShowDomainConsoleAclPolicyAsync(ShowDomainConsoleAclPolicyRequest showDomainConsoleAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainConsoleAclPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/console-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainConsoleAclPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainConsoleAclPolicyResponse>(response);
        }

        public AsyncInvoker<ShowDomainConsoleAclPolicyResponse> ShowDomainConsoleAclPolicyAsyncInvoker(ShowDomainConsoleAclPolicyRequest showDomainConsoleAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainConsoleAclPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/console-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainConsoleAclPolicyRequest);
            return new AsyncInvoker<ShowDomainConsoleAclPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainConsoleAclPolicyResponse>);
        }
        
        /// <summary>
        /// 查询账号登录策略
        ///
        /// 该接口可以用于查询账号登录策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainLoginPolicyResponse> ShowDomainLoginPolicyAsync(ShowDomainLoginPolicyRequest showDomainLoginPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainLoginPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLoginPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainLoginPolicyResponse>(response);
        }

        public AsyncInvoker<ShowDomainLoginPolicyResponse> ShowDomainLoginPolicyAsyncInvoker(ShowDomainLoginPolicyRequest showDomainLoginPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainLoginPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLoginPolicyRequest);
            return new AsyncInvoker<ShowDomainLoginPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainLoginPolicyResponse>);
        }
        
        /// <summary>
        /// 查询账号密码策略
        ///
        /// 该接口可以用于查询账号密码策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainPasswordPolicyResponse> ShowDomainPasswordPolicyAsync(ShowDomainPasswordPolicyRequest showDomainPasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainPasswordPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainPasswordPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainPasswordPolicyResponse>(response);
        }

        public AsyncInvoker<ShowDomainPasswordPolicyResponse> ShowDomainPasswordPolicyAsyncInvoker(ShowDomainPasswordPolicyRequest showDomainPasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainPasswordPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainPasswordPolicyRequest);
            return new AsyncInvoker<ShowDomainPasswordPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainPasswordPolicyResponse>);
        }
        
        /// <summary>
        /// 查询账号操作保护策略
        ///
        /// 该接口可以用于查询账号操作保护策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainProtectPolicyResponse> ShowDomainProtectPolicyAsync(ShowDomainProtectPolicyRequest showDomainProtectPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainProtectPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/protect-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainProtectPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainProtectPolicyResponse>(response);
        }

        public AsyncInvoker<ShowDomainProtectPolicyResponse> ShowDomainProtectPolicyAsyncInvoker(ShowDomainProtectPolicyRequest showDomainProtectPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainProtectPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/protect-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainProtectPolicyRequest);
            return new AsyncInvoker<ShowDomainProtectPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainProtectPolicyResponse>);
        }
        
        /// <summary>
        /// 查询账号配额
        ///
        /// 该接口可以用于查询账号配额。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainQuotaResponse> ShowDomainQuotaAsync(ShowDomainQuotaRequest showDomainQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainQuotaRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-QUOTA/domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainQuotaResponse>(response);
        }

        public AsyncInvoker<ShowDomainQuotaResponse> ShowDomainQuotaAsyncInvoker(ShowDomainQuotaRequest showDomainQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainQuotaRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-QUOTA/domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainQuotaRequest);
            return new AsyncInvoker<ShowDomainQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainQuotaResponse>);
        }
        
        /// <summary>
        /// 查询指定账号中的授权记录
        ///
        /// 该接口用于查询指定账号中的授权记录。
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainRoleAssignmentsResponse> ShowDomainRoleAssignmentsAsync(ShowDomainRoleAssignmentsRequest showDomainRoleAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/role-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRoleAssignmentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainRoleAssignmentsResponse>(response);
        }

        public AsyncInvoker<ShowDomainRoleAssignmentsResponse> ShowDomainRoleAssignmentsAsyncInvoker(ShowDomainRoleAssignmentsRequest showDomainRoleAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/role-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRoleAssignmentsRequest);
            return new AsyncInvoker<ShowDomainRoleAssignmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainRoleAssignmentsResponse>);
        }
        
        /// <summary>
        /// 查询Metadata文件
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询身份提供商导入到IAM中的Metadata文件。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMetadataResponse> ShowMetadataAsync(ShowMetadataRequest showMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMetadataRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            if (StringUtils.TryConvertToNonEmptyString(showMetadataRequest.ProtocolId, out var valueOfProtocolId)) urlParam.Add("protocol_id", valueOfProtocolId);
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetadataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMetadataResponse>(response);
        }

        public AsyncInvoker<ShowMetadataResponse> ShowMetadataAsyncInvoker(ShowMetadataRequest showMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMetadataRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            if (StringUtils.TryConvertToNonEmptyString(showMetadataRequest.ProtocolId, out var valueOfProtocolId)) urlParam.Add("protocol_id", valueOfProtocolId);
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetadataRequest);
            return new AsyncInvoker<ShowMetadataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMetadataResponse>);
        }
        
        /// <summary>
        /// 查询OpenId Connect身份提供商配置
        ///
        /// 查询OpenId Connect身份提供商配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOpenIdConnectConfigResponse> ShowOpenIdConnectConfigAsync(ShowOpenIdConnectConfigRequest showOpenIdConnectConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOpenIdConnectConfigRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpenIdConnectConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOpenIdConnectConfigResponse>(response);
        }

        public AsyncInvoker<ShowOpenIdConnectConfigResponse> ShowOpenIdConnectConfigAsyncInvoker(ShowOpenIdConnectConfigRequest showOpenIdConnectConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOpenIdConnectConfigRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpenIdConnectConfigRequest);
            return new AsyncInvoker<ShowOpenIdConnectConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOpenIdConnectConfigResponse>);
        }
        
        /// <summary>
        /// 查询项目详情与状态
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询项目详情与状态。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectDetailsAndStatusResponse> ShowProjectDetailsAndStatusAsync(ShowProjectDetailsAndStatusRequest showProjectDetailsAndStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectDetailsAndStatusRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectDetailsAndStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectDetailsAndStatusResponse>(response);
        }

        public AsyncInvoker<ShowProjectDetailsAndStatusResponse> ShowProjectDetailsAndStatusAsyncInvoker(ShowProjectDetailsAndStatusRequest showProjectDetailsAndStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectDetailsAndStatusRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectDetailsAndStatusRequest);
            return new AsyncInvoker<ShowProjectDetailsAndStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectDetailsAndStatusResponse>);
        }
        
        /// <summary>
        /// 查询项目配额
        ///
        /// 该接口可以用于查询项目配额。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectQuotaResponse> ShowProjectQuotaAsync(ShowProjectQuotaRequest showProjectQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectQuotaRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-QUOTA/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectQuotaResponse>(response);
        }

        public AsyncInvoker<ShowProjectQuotaResponse> ShowProjectQuotaAsyncInvoker(ShowProjectQuotaRequest showProjectQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectQuotaRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-QUOTA/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectQuotaRequest);
            return new AsyncInvoker<ShowProjectQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectQuotaResponse>);
        }
        
        /// <summary>
        /// 修改委托
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)修改委托。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAgencyResponse> UpdateAgencyAsync(UpdateAgencyRequest updateAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAgencyResponse>(response);
        }

        public AsyncInvoker<UpdateAgencyResponse> UpdateAgencyAsyncInvoker(UpdateAgencyRequest updateAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAgencyRequest.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyRequest);
            return new AsyncInvoker<UpdateAgencyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAgencyResponse>);
        }
        
        /// <summary>
        /// 修改委托自定义策略
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)修改委托自定义策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAgencyCustomPolicyResponse> UpdateAgencyCustomPolicyAsync(UpdateAgencyCustomPolicyRequest updateAgencyCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAgencyCustomPolicyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyCustomPolicyRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateAgencyCustomPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateAgencyCustomPolicyResponse> UpdateAgencyCustomPolicyAsyncInvoker(UpdateAgencyCustomPolicyRequest updateAgencyCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAgencyCustomPolicyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyCustomPolicyRequest);
            return new AsyncInvoker<UpdateAgencyCustomPolicyResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateAgencyCustomPolicyResponse>);
        }
        
        /// <summary>
        /// 修改云服务自定义策略
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)修改云服务自定义策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCloudServiceCustomPolicyResponse> UpdateCloudServiceCustomPolicyAsync(UpdateCloudServiceCustomPolicyRequest updateCloudServiceCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCloudServiceCustomPolicyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCloudServiceCustomPolicyRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateCloudServiceCustomPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateCloudServiceCustomPolicyResponse> UpdateCloudServiceCustomPolicyAsyncInvoker(UpdateCloudServiceCustomPolicyRequest updateCloudServiceCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCloudServiceCustomPolicyRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCloudServiceCustomPolicyRequest);
            return new AsyncInvoker<UpdateCloudServiceCustomPolicyResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateCloudServiceCustomPolicyResponse>);
        }
        
        /// <summary>
        /// 修改账号接口访问策略
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)修改账号接口访问策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainApiAclPolicyResponse> UpdateDomainApiAclPolicyAsync(UpdateDomainApiAclPolicyRequest updateDomainApiAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainApiAclPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/api-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainApiAclPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainApiAclPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateDomainApiAclPolicyResponse> UpdateDomainApiAclPolicyAsyncInvoker(UpdateDomainApiAclPolicyRequest updateDomainApiAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainApiAclPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/api-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainApiAclPolicyRequest);
            return new AsyncInvoker<UpdateDomainApiAclPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainApiAclPolicyResponse>);
        }
        
        /// <summary>
        /// 修改账号控制台访问策略
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)修改账号控制台访问策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainConsoleAclPolicyResponse> UpdateDomainConsoleAclPolicyAsync(UpdateDomainConsoleAclPolicyRequest updateDomainConsoleAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainConsoleAclPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/console-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainConsoleAclPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainConsoleAclPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateDomainConsoleAclPolicyResponse> UpdateDomainConsoleAclPolicyAsyncInvoker(UpdateDomainConsoleAclPolicyRequest updateDomainConsoleAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainConsoleAclPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/console-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainConsoleAclPolicyRequest);
            return new AsyncInvoker<UpdateDomainConsoleAclPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainConsoleAclPolicyResponse>);
        }
        
        /// <summary>
        /// 为用户组授予所有项目服务权限
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)为用户组授予所有项目服务权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainGroupInheritRoleResponse> UpdateDomainGroupInheritRoleAsync(UpdateDomainGroupInheritRoleRequest updateDomainGroupInheritRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainGroupInheritRoleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(updateDomainGroupInheritRoleRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateDomainGroupInheritRoleRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainGroupInheritRoleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainGroupInheritRoleResponse>(response);
        }

        public AsyncInvoker<UpdateDomainGroupInheritRoleResponse> UpdateDomainGroupInheritRoleAsyncInvoker(UpdateDomainGroupInheritRoleRequest updateDomainGroupInheritRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainGroupInheritRoleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(updateDomainGroupInheritRoleRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateDomainGroupInheritRoleRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainGroupInheritRoleRequest);
            return new AsyncInvoker<UpdateDomainGroupInheritRoleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainGroupInheritRoleResponse>);
        }
        
        /// <summary>
        /// 修改账号登录策略
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)修改账号登录策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainLoginPolicyResponse> UpdateDomainLoginPolicyAsync(UpdateDomainLoginPolicyRequest updateDomainLoginPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainLoginPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainLoginPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainLoginPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateDomainLoginPolicyResponse> UpdateDomainLoginPolicyAsyncInvoker(UpdateDomainLoginPolicyRequest updateDomainLoginPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainLoginPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainLoginPolicyRequest);
            return new AsyncInvoker<UpdateDomainLoginPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainLoginPolicyResponse>);
        }
        
        /// <summary>
        /// 修改账号密码策略
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)修改账号密码策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainPasswordPolicyResponse> UpdateDomainPasswordPolicyAsync(UpdateDomainPasswordPolicyRequest updateDomainPasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainPasswordPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainPasswordPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainPasswordPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateDomainPasswordPolicyResponse> UpdateDomainPasswordPolicyAsyncInvoker(UpdateDomainPasswordPolicyRequest updateDomainPasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainPasswordPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainPasswordPolicyRequest);
            return new AsyncInvoker<UpdateDomainPasswordPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainPasswordPolicyResponse>);
        }
        
        /// <summary>
        /// 修改账号操作保护策略
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)修改账号操作保护策略。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainProtectPolicyResponse> UpdateDomainProtectPolicyAsync(UpdateDomainProtectPolicyRequest updateDomainProtectPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainProtectPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/protect-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainProtectPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainProtectPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateDomainProtectPolicyResponse> UpdateDomainProtectPolicyAsyncInvoker(UpdateDomainProtectPolicyRequest updateDomainProtectPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainProtectPolicyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/protect-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainProtectPolicyRequest);
            return new AsyncInvoker<UpdateDomainProtectPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainProtectPolicyResponse>);
        }
        
        /// <summary>
        /// 修改OpenId Connect身份提供商配置
        ///
        /// 修改OpenId Connect身份提供商配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateOpenIdConnectConfigResponse> UpdateOpenIdConnectConfigAsync(UpdateOpenIdConnectConfigRequest updateOpenIdConnectConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOpenIdConnectConfigRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateOpenIdConnectConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateOpenIdConnectConfigResponse>(response);
        }

        public AsyncInvoker<UpdateOpenIdConnectConfigResponse> UpdateOpenIdConnectConfigAsyncInvoker(UpdateOpenIdConnectConfigRequest updateOpenIdConnectConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOpenIdConnectConfigRequest.IdpId, out var valueOfIdpId)) urlParam.Add("idp_id", valueOfIdpId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateOpenIdConnectConfigRequest);
            return new AsyncInvoker<UpdateOpenIdConnectConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateOpenIdConnectConfigResponse>);
        }
        
        /// <summary>
        /// 设置项目状态
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)设置项目状态。项目状态包括：正常、冻结。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProjectStatusResponse> UpdateProjectStatusAsync(UpdateProjectStatusRequest updateProjectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectStatusRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProjectStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateProjectStatusResponse>(response);
        }

        public AsyncInvoker<UpdateProjectStatusResponse> UpdateProjectStatusAsyncInvoker(UpdateProjectStatusRequest updateProjectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectStatusRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProjectStatusRequest);
            return new AsyncInvoker<UpdateProjectStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateProjectStatusResponse>);
        }
        
        /// <summary>
        /// 创建永久访问密钥
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)给IAM用户创建永久访问密钥，或IAM用户给自己创建永久访问密钥。
        /// 
        /// 访问密钥（Access Key ID/Secret Access Key，简称AK/SK），是您通过开发工具（API、CLI、SDK）访问华为云时的身份凭证，不用于登录控制台。系统通过AK识别访问用户的身份，通过SK进行签名验证，通过加密签名验证可以确保请求的机密性、完整性和请求者身份的正确性。在控制台创建访问密钥的方式请参见：[访问密钥](https://support.huaweicloud.com/usermanual-ca/zh-cn_topic_0046606340.html) 。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePermanentAccessKeyResponse> CreatePermanentAccessKeyAsync(CreatePermanentAccessKeyRequest createPermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPermanentAccessKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePermanentAccessKeyResponse>(response);
        }

        public AsyncInvoker<CreatePermanentAccessKeyResponse> CreatePermanentAccessKeyAsyncInvoker(CreatePermanentAccessKeyRequest createPermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPermanentAccessKeyRequest);
            return new AsyncInvoker<CreatePermanentAccessKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePermanentAccessKeyResponse>);
        }
        
        /// <summary>
        /// 通过委托获取临时访问密钥
        ///
        /// 该接口可以用于通过委托来获取临时访问密钥（临时AK/SK）和securitytoken。
        /// 
        /// 临时AK/SK和securitytoken是系统颁发给IAM用户的临时访问令牌，有效期为15分钟至24小时，过期后需要重新获取。临时AK/SK和securitytoken遵循权限最小化原则。鉴权时，临时AK/SK和securitytoken必须同时使用，请求头中需要添加“x-security-token”字段，使用方法详情请参考：[API签名参考](https://support.huaweicloud.com/devg-apisign/api-sign-provide.html) 。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTemporaryAccessKeyByAgencyResponse> CreateTemporaryAccessKeyByAgencyAsync(CreateTemporaryAccessKeyByAgencyRequest createTemporaryAccessKeyByAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByAgencyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTemporaryAccessKeyByAgencyResponse>(response);
        }

        public AsyncInvoker<CreateTemporaryAccessKeyByAgencyResponse> CreateTemporaryAccessKeyByAgencyAsyncInvoker(CreateTemporaryAccessKeyByAgencyRequest createTemporaryAccessKeyByAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByAgencyRequest);
            return new AsyncInvoker<CreateTemporaryAccessKeyByAgencyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemporaryAccessKeyByAgencyResponse>);
        }
        
        /// <summary>
        /// 通过token获取临时访问密钥
        ///
        /// 该接口可以用于通过token来获取临时AK/SK和securitytoken。
        /// 
        /// 临时AK/SK和securitytoken是系统颁发给IAM用户的临时访问令牌，有效期为15分钟至24小时，过期后需要重新获取。临时AK/SK和securitytoken遵循权限最小化原则。鉴权时，临时AK/SK和securitytoken必须同时使用，请求头中需要添加“x-security-token”字段，使用方法详情请参考：[API签名参考](https://support.huaweicloud.com/devg-apisign/api-sign-provide.html)。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTemporaryAccessKeyByTokenResponse> CreateTemporaryAccessKeyByTokenAsync(CreateTemporaryAccessKeyByTokenRequest createTemporaryAccessKeyByTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByTokenRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTemporaryAccessKeyByTokenResponse>(response);
        }

        public AsyncInvoker<CreateTemporaryAccessKeyByTokenResponse> CreateTemporaryAccessKeyByTokenAsyncInvoker(CreateTemporaryAccessKeyByTokenRequest createTemporaryAccessKeyByTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByTokenRequest);
            return new AsyncInvoker<CreateTemporaryAccessKeyByTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemporaryAccessKeyByTokenResponse>);
        }
        
        /// <summary>
        /// 删除指定永久访问密钥
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)删除IAM用户的指定永久访问密钥，或IAM用户删除自己的指定永久访问密钥。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePermanentAccessKeyResponse> DeletePermanentAccessKeyAsync(DeletePermanentAccessKeyRequest deletePermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePermanentAccessKeyRequest.AccessKey, out var valueOfAccessKey)) urlParam.Add("access_key", valueOfAccessKey);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePermanentAccessKeyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePermanentAccessKeyResponse>(response);
        }

        public AsyncInvoker<DeletePermanentAccessKeyResponse> DeletePermanentAccessKeyAsyncInvoker(DeletePermanentAccessKeyRequest deletePermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePermanentAccessKeyRequest.AccessKey, out var valueOfAccessKey)) urlParam.Add("access_key", valueOfAccessKey);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePermanentAccessKeyRequest);
            return new AsyncInvoker<DeletePermanentAccessKeyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePermanentAccessKeyResponse>);
        }
        
        /// <summary>
        /// 查询所有永久访问密钥
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询IAM用户的所有永久访问密钥，或IAM用户查询自己的所有永久访问密钥。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPermanentAccessKeysResponse> ListPermanentAccessKeysAsync(ListPermanentAccessKeysRequest listPermanentAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermanentAccessKeysRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPermanentAccessKeysResponse>(response);
        }

        public AsyncInvoker<ListPermanentAccessKeysResponse> ListPermanentAccessKeysAsyncInvoker(ListPermanentAccessKeysRequest listPermanentAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermanentAccessKeysRequest);
            return new AsyncInvoker<ListPermanentAccessKeysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermanentAccessKeysResponse>);
        }
        
        /// <summary>
        /// 查询指定永久访问密钥
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询IAM用户的指定永久访问密钥，或IAM用户查询自己的指定永久访问密钥。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPermanentAccessKeyResponse> ShowPermanentAccessKeyAsync(ShowPermanentAccessKeyRequest showPermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPermanentAccessKeyRequest.AccessKey, out var valueOfAccessKey)) urlParam.Add("access_key", valueOfAccessKey);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPermanentAccessKeyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPermanentAccessKeyResponse>(response);
        }

        public AsyncInvoker<ShowPermanentAccessKeyResponse> ShowPermanentAccessKeyAsyncInvoker(ShowPermanentAccessKeyRequest showPermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPermanentAccessKeyRequest.AccessKey, out var valueOfAccessKey)) urlParam.Add("access_key", valueOfAccessKey);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPermanentAccessKeyRequest);
            return new AsyncInvoker<ShowPermanentAccessKeyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPermanentAccessKeyResponse>);
        }
        
        /// <summary>
        /// 修改指定永久访问密钥
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)修改IAM用户的指定永久访问密钥，或IAM用户修改自己的指定永久访问密钥。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePermanentAccessKeyResponse> UpdatePermanentAccessKeyAsync(UpdatePermanentAccessKeyRequest updatePermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePermanentAccessKeyRequest.AccessKey, out var valueOfAccessKey)) urlParam.Add("access_key", valueOfAccessKey);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePermanentAccessKeyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePermanentAccessKeyResponse>(response);
        }

        public AsyncInvoker<UpdatePermanentAccessKeyResponse> UpdatePermanentAccessKeyAsyncInvoker(UpdatePermanentAccessKeyRequest updatePermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePermanentAccessKeyRequest.AccessKey, out var valueOfAccessKey)) urlParam.Add("access_key", valueOfAccessKey);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePermanentAccessKeyRequest);
            return new AsyncInvoker<UpdatePermanentAccessKeyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePermanentAccessKeyResponse>);
        }
        
        /// <summary>
        /// 管理员创建IAM用户（推荐）
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)创建IAM用户。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateUserResponse>(response);
        }

        public AsyncInvoker<CreateUserResponse> CreateUserAsyncInvoker(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createUserRequest);
            return new AsyncInvoker<CreateUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUserResponse>);
        }
        
        /// <summary>
        /// 管理员创建IAM用户
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)创建IAM用户。IAM用户首次登录时需要修改密码。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneCreateUserResponse> KeystoneCreateUserAsync(KeystoneCreateUserRequest keystoneCreateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<KeystoneCreateUserResponse>(response);
        }

        public AsyncInvoker<KeystoneCreateUserResponse> KeystoneCreateUserAsyncInvoker(KeystoneCreateUserRequest keystoneCreateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserRequest);
            return new AsyncInvoker<KeystoneCreateUserResponse>(this, "POST", request, JsonUtils.DeSerialize<KeystoneCreateUserResponse>);
        }
        
        /// <summary>
        /// 管理员删除IAM用户
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)删除指定IAM用户。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneDeleteUserResponse> KeystoneDeleteUserAsync(KeystoneDeleteUserRequest keystoneDeleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneDeleteUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteUserRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteUserResponse>(response);
        }

        public AsyncInvoker<KeystoneDeleteUserResponse> KeystoneDeleteUserAsyncInvoker(KeystoneDeleteUserRequest keystoneDeleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneDeleteUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteUserRequest);
            return new AsyncInvoker<KeystoneDeleteUserResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneDeleteUserResponse>);
        }
        
        /// <summary>
        /// 查询IAM用户所属用户组
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询IAM用户所属用户组，或IAM用户查询自己所属用户组。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListGroupsForUserResponse> KeystoneListGroupsForUserAsync(KeystoneListGroupsForUserRequest keystoneListGroupsForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneListGroupsForUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListGroupsForUserRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListGroupsForUserResponse>(response);
        }

        public AsyncInvoker<KeystoneListGroupsForUserResponse> KeystoneListGroupsForUserAsyncInvoker(KeystoneListGroupsForUserRequest keystoneListGroupsForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneListGroupsForUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListGroupsForUserRequest);
            return new AsyncInvoker<KeystoneListGroupsForUserResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListGroupsForUserResponse>);
        }
        
        /// <summary>
        /// 管理员查询IAM用户列表
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询IAM用户列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListUsersResponse> KeystoneListUsersAsync(KeystoneListUsersRequest keystoneListUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListUsersResponse>(response);
        }

        public AsyncInvoker<KeystoneListUsersResponse> KeystoneListUsersAsyncInvoker(KeystoneListUsersRequest keystoneListUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListUsersRequest);
            return new AsyncInvoker<KeystoneListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListUsersResponse>);
        }
        
        /// <summary>
        /// 管理员查询用户组所包含的IAM用户
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询用户组中所包含的IAM用户。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneListUsersForGroupByAdminResponse> KeystoneListUsersForGroupByAdminAsync(KeystoneListUsersForGroupByAdminRequest keystoneListUsersForGroupByAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneListUsersForGroupByAdminRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListUsersForGroupByAdminRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListUsersForGroupByAdminResponse>(response);
        }

        public AsyncInvoker<KeystoneListUsersForGroupByAdminResponse> KeystoneListUsersForGroupByAdminAsyncInvoker(KeystoneListUsersForGroupByAdminRequest keystoneListUsersForGroupByAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneListUsersForGroupByAdminRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListUsersForGroupByAdminRequest);
            return new AsyncInvoker<KeystoneListUsersForGroupByAdminResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListUsersForGroupByAdminResponse>);
        }
        
        /// <summary>
        /// 查询IAM用户详情
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询IAM用户详情，或IAM用户查询自己的用户详情。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneShowUserResponse> KeystoneShowUserAsync(KeystoneShowUserRequest keystoneShowUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowUserRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowUserResponse>(response);
        }

        public AsyncInvoker<KeystoneShowUserResponse> KeystoneShowUserAsyncInvoker(KeystoneShowUserRequest keystoneShowUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneShowUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowUserRequest);
            return new AsyncInvoker<KeystoneShowUserResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowUserResponse>);
        }
        
        /// <summary>
        /// 管理员修改IAM用户信息
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)修改IAM用户信息。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneUpdateUserByAdminResponse> KeystoneUpdateUserByAdminAsync(KeystoneUpdateUserByAdminRequest keystoneUpdateUserByAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateUserByAdminRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserByAdminRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<KeystoneUpdateUserByAdminResponse>(response);
        }

        public AsyncInvoker<KeystoneUpdateUserByAdminResponse> KeystoneUpdateUserByAdminAsyncInvoker(KeystoneUpdateUserByAdminRequest keystoneUpdateUserByAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateUserByAdminRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserByAdminRequest);
            return new AsyncInvoker<KeystoneUpdateUserByAdminResponse>(this, "PATCH", request, JsonUtils.DeSerialize<KeystoneUpdateUserByAdminResponse>);
        }
        
        /// <summary>
        /// 修改IAM用户密码
        ///
        /// 该接口可以用于IAM用户修改自己的密码。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneUpdateUserPasswordResponse> KeystoneUpdateUserPasswordAsync(KeystoneUpdateUserPasswordRequest keystoneUpdateUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateUserPasswordRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserPasswordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<KeystoneUpdateUserPasswordResponse>(response);
        }

        public AsyncInvoker<KeystoneUpdateUserPasswordResponse> KeystoneUpdateUserPasswordAsyncInvoker(KeystoneUpdateUserPasswordRequest keystoneUpdateUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(keystoneUpdateUserPasswordRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserPasswordRequest);
            return new AsyncInvoker<KeystoneUpdateUserPasswordResponse>(this, "POST", request, JsonUtils.DeSerializeNull<KeystoneUpdateUserPasswordResponse>);
        }
        
        /// <summary>
        /// 查询IAM用户的登录保护状态信息列表
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询IAM用户的登录保护状态列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUserLoginProtectsResponse> ListUserLoginProtectsAsync(ListUserLoginProtectsRequest listUserLoginProtectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/login-protects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserLoginProtectsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUserLoginProtectsResponse>(response);
        }

        public AsyncInvoker<ListUserLoginProtectsResponse> ListUserLoginProtectsAsyncInvoker(ListUserLoginProtectsRequest listUserLoginProtectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/login-protects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserLoginProtectsRequest);
            return new AsyncInvoker<ListUserLoginProtectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserLoginProtectsResponse>);
        }
        
        /// <summary>
        /// 查询IAM用户的MFA绑定信息列表
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询IAM用户的MFA绑定信息列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUserMfaDevicesResponse> ListUserMfaDevicesAsync(ListUserMfaDevicesRequest listUserMfaDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserMfaDevicesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUserMfaDevicesResponse>(response);
        }

        public AsyncInvoker<ListUserMfaDevicesResponse> ListUserMfaDevicesAsyncInvoker(ListUserMfaDevicesRequest listUserMfaDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserMfaDevicesRequest);
            return new AsyncInvoker<ListUserMfaDevicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserMfaDevicesResponse>);
        }
        
        /// <summary>
        /// 查询IAM用户详情（推荐）
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询IAM用户详情，或IAM用户查询自己的详情。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserResponse> ShowUserAsync(ShowUserRequest showUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserResponse>(response);
        }

        public AsyncInvoker<ShowUserResponse> ShowUserAsyncInvoker(ShowUserRequest showUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRequest);
            return new AsyncInvoker<ShowUserResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserResponse>);
        }
        
        /// <summary>
        /// 查询指定IAM用户的登录保护状态信息
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询指定IAM用户的登录保护状态信息，或IAM用户查询自己的登录保护状态信息。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserLoginProtectResponse> ShowUserLoginProtectAsync(ShowUserLoginProtectRequest showUserLoginProtectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserLoginProtectRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/login-protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserLoginProtectRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserLoginProtectResponse>(response);
        }

        public AsyncInvoker<ShowUserLoginProtectResponse> ShowUserLoginProtectAsyncInvoker(ShowUserLoginProtectRequest showUserLoginProtectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserLoginProtectRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/login-protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserLoginProtectRequest);
            return new AsyncInvoker<ShowUserLoginProtectResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserLoginProtectResponse>);
        }
        
        /// <summary>
        /// 查询指定IAM用户的MFA绑定信息
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询指定IAM用户的MFA绑定信息，或IAM用户查询自己的MFA绑定信息。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserMfaDeviceResponse> ShowUserMfaDeviceAsync(ShowUserMfaDeviceRequest showUserMfaDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserMfaDeviceRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/users/{user_id}/virtual-mfa-device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserMfaDeviceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserMfaDeviceResponse>(response);
        }

        public AsyncInvoker<ShowUserMfaDeviceResponse> ShowUserMfaDeviceAsyncInvoker(ShowUserMfaDeviceRequest showUserMfaDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserMfaDeviceRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/users/{user_id}/virtual-mfa-device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserMfaDeviceRequest);
            return new AsyncInvoker<ShowUserMfaDeviceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserMfaDeviceResponse>);
        }
        
        /// <summary>
        /// 修改IAM用户登录保护状态信息
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)修改账号操作保护。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLoginProtectResponse> UpdateLoginProtectAsync(UpdateLoginProtectRequest updateLoginProtectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLoginProtectRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/login-protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLoginProtectRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLoginProtectResponse>(response);
        }

        public AsyncInvoker<UpdateLoginProtectResponse> UpdateLoginProtectAsyncInvoker(UpdateLoginProtectRequest updateLoginProtectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLoginProtectRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/login-protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLoginProtectRequest);
            return new AsyncInvoker<UpdateLoginProtectResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLoginProtectResponse>);
        }
        
        /// <summary>
        /// 管理员修改IAM用户信息（推荐）
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)修改IAM用户信息 。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUserResponse>(response);
        }

        public AsyncInvoker<UpdateUserResponse> UpdateUserAsyncInvoker(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserRequest);
            return new AsyncInvoker<UpdateUserResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUserResponse>);
        }
        
        /// <summary>
        /// 修改IAM用户信息（推荐）
        ///
        /// 该接口可以用于IAM用户修改自己的用户信息。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUserInformationResponse> UpdateUserInformationAsync(UpdateUserInformationRequest updateUserInformationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserInformationRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserInformationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateUserInformationResponse>(response);
        }

        public AsyncInvoker<UpdateUserInformationResponse> UpdateUserInformationAsyncInvoker(UpdateUserInformationRequest updateUserInformationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserInformationRequest.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserInformationRequest);
            return new AsyncInvoker<UpdateUserInformationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateUserInformationResponse>);
        }
        
        /// <summary>
        /// 获取委托Token
        ///
        /// 该接口可以用于获取委托方的token。
        /// 
        /// 例如：A账号希望B账号管理自己的某些资源，所以A账号创建了委托给B账号，则A账号为委托方，B账号为被委托方。那么B账号可以通过该接口获取委托token。B账号仅能使用该token管理A账号的委托资源，不能管理自己账号中的资源。如果B账号需要管理自己账号中的资源，则需要获取自己的用户token。
        /// 
        /// token是系统颁发给用户的访问令牌，承载用户的身份、权限等信息。调用IAM以及其他云服务的接口时，可以使用本接口获取的token进行鉴权。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。如果使用全局区域的Endpoint调用，该token可以在所有区域使用；如果使用非全局区域的Endpoint调用，则该token仅在该区域生效，不能跨区域使用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// &gt; - token的有效期为24小时，建议进行缓存，避免频繁调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneCreateAgencyTokenResponse> KeystoneCreateAgencyTokenAsync(KeystoneCreateAgencyTokenRequest keystoneCreateAgencyTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateAgencyTokenRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<KeystoneCreateAgencyTokenResponse>(response);
        }

        public AsyncInvoker<KeystoneCreateAgencyTokenResponse> KeystoneCreateAgencyTokenAsyncInvoker(KeystoneCreateAgencyTokenRequest keystoneCreateAgencyTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateAgencyTokenRequest);
            return new AsyncInvoker<KeystoneCreateAgencyTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<KeystoneCreateAgencyTokenResponse>);
        }
        
        /// <summary>
        /// 获取IAM用户Token（使用密码）
        ///
        /// 该接口可以用于通过用户名/密码的方式进行认证来获取IAM用户token。
        /// 
        /// token是系统颁发给IAM用户的访问令牌，承载用户的身份、权限等信息。调用IAM以及其他云服务的接口时，可以使用本接口获取的IAM用户token进行鉴权。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。如果使用全局区域的Endpoint调用，该token可以在所有区域使用；如果使用非全局区域的Endpoint调用，则该token仅在该区域生效，不能跨区域使用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// &gt; - token的有效期为24小时，建议进行缓存，避免频繁调用。
        /// &gt; - 通过Postman获取用户token示例请参见：[如何通过Postman获取用户token](https://support.huaweicloud.com/iam_faq/iam_01_034.html)。
        /// &gt; - 如果需要获取具有Security Administrator权限的token，请参见：[IAM 常见问题](https://support.huaweicloud.com/iam_faq/iam_01_0608.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneCreateUserTokenByPasswordResponse> KeystoneCreateUserTokenByPasswordAsync(KeystoneCreateUserTokenByPasswordRequest keystoneCreateUserTokenByPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserTokenByPasswordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<KeystoneCreateUserTokenByPasswordResponse>(response);
        }

        public AsyncInvoker<KeystoneCreateUserTokenByPasswordResponse> KeystoneCreateUserTokenByPasswordAsyncInvoker(KeystoneCreateUserTokenByPasswordRequest keystoneCreateUserTokenByPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserTokenByPasswordRequest);
            return new AsyncInvoker<KeystoneCreateUserTokenByPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<KeystoneCreateUserTokenByPasswordResponse>);
        }
        
        /// <summary>
        /// 获取IAM用户Token（使用密码+虚拟MFA）
        ///
        /// 该接口可以用于通过用户名/密码+虚拟MFA的方式进行认证，在IAM用户开启了的登录保护功能，并选择通过虚拟MFA验证时获取IAM用户token。
        /// 
        /// token是系统颁发给用户的访问令牌，承载用户的身份、权限等信息。调用IAM以及其他云服务的接口时，可以使用本接口获取的token进行鉴权。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。如果使用全局区域的Endpoint调用，该token可以在所有区域使用；如果使用非全局区域的Endpoint调用，则该token仅在该区域生效，不能跨区域使用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// &gt; - token的有效期为24小时，建议进行缓存，避免频繁调用。
        /// &gt; - 通过Postman获取用户token示例请参见：[如何通过Postman获取用户token](https://support.huaweicloud.com/iam_faq/iam_01_034.html)。
        /// &gt; - 如果需要获取具有Security Administrator权限的token，请参见：[IAM 常见问题](https://support.huaweicloud.com/iam_faq/iam_01_0608.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneCreateUserTokenByPasswordAndMfaResponse> KeystoneCreateUserTokenByPasswordAndMfaAsync(KeystoneCreateUserTokenByPasswordAndMfaRequest keystoneCreateUserTokenByPasswordAndMfaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserTokenByPasswordAndMfaRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<KeystoneCreateUserTokenByPasswordAndMfaResponse>(response);
        }

        public AsyncInvoker<KeystoneCreateUserTokenByPasswordAndMfaResponse> KeystoneCreateUserTokenByPasswordAndMfaAsyncInvoker(KeystoneCreateUserTokenByPasswordAndMfaRequest keystoneCreateUserTokenByPasswordAndMfaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserTokenByPasswordAndMfaRequest);
            return new AsyncInvoker<KeystoneCreateUserTokenByPasswordAndMfaResponse>(this, "POST", request, JsonUtils.DeSerialize<KeystoneCreateUserTokenByPasswordAndMfaResponse>);
        }
        
        /// <summary>
        /// 校验Token的有效性
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)校验本账号中IAM用户token的有效性，或IAM用户校验自己token的有效性。管理员仅能校验本账号中IAM用户token的有效性，不能校验其他账号中IAM用户token的有效性。如果被校验的token有效，则返回该token的详细信息。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<KeystoneValidateTokenResponse> KeystoneValidateTokenAsync(KeystoneValidateTokenRequest keystoneValidateTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneValidateTokenRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<KeystoneValidateTokenResponse>(response);
        }

        public AsyncInvoker<KeystoneValidateTokenResponse> KeystoneValidateTokenAsyncInvoker(KeystoneValidateTokenRequest keystoneValidateTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneValidateTokenRequest);
            return new AsyncInvoker<KeystoneValidateTokenResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneValidateTokenResponse>);
        }
        
    }
}