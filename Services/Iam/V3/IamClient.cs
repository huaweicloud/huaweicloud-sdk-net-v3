using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Iam.V3.Model;

namespace HuaweiCloud.SDK.Iam.V3
{
    public partial class IamClient : Client
    {
        public static ClientBuilder<IamClient> NewBuilder()
        {
            return new ClientBuilder<IamClient>("GlobalCredentials,BasicCredentials,IamCredentials");
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
        public AssociateAgencyWithAllProjectsPermissionResponse AssociateAgencyWithAllProjectsPermission(AssociateAgencyWithAllProjectsPermissionRequest associateAgencyWithAllProjectsPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id", associateAgencyWithAllProjectsPermissionRequest.AgencyId.ToString());
            urlParam.Add("domain_id", associateAgencyWithAllProjectsPermissionRequest.DomainId.ToString());
            urlParam.Add("role_id", associateAgencyWithAllProjectsPermissionRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithAllProjectsPermissionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithAllProjectsPermissionResponse>(response);
        }

        public SyncInvoker<AssociateAgencyWithAllProjectsPermissionResponse> AssociateAgencyWithAllProjectsPermissionInvoker(AssociateAgencyWithAllProjectsPermissionRequest associateAgencyWithAllProjectsPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id", associateAgencyWithAllProjectsPermissionRequest.AgencyId.ToString());
            urlParam.Add("domain_id", associateAgencyWithAllProjectsPermissionRequest.DomainId.ToString());
            urlParam.Add("role_id", associateAgencyWithAllProjectsPermissionRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithAllProjectsPermissionRequest);
            return new SyncInvoker<AssociateAgencyWithAllProjectsPermissionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AssociateAgencyWithAllProjectsPermissionResponse>);
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
        public AssociateAgencyWithDomainPermissionResponse AssociateAgencyWithDomainPermission(AssociateAgencyWithDomainPermissionRequest associateAgencyWithDomainPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", associateAgencyWithDomainPermissionRequest.DomainId.ToString());
            urlParam.Add("agency_id", associateAgencyWithDomainPermissionRequest.AgencyId.ToString());
            urlParam.Add("role_id", associateAgencyWithDomainPermissionRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithDomainPermissionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithDomainPermissionResponse>(response);
        }

        public SyncInvoker<AssociateAgencyWithDomainPermissionResponse> AssociateAgencyWithDomainPermissionInvoker(AssociateAgencyWithDomainPermissionRequest associateAgencyWithDomainPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", associateAgencyWithDomainPermissionRequest.DomainId.ToString());
            urlParam.Add("agency_id", associateAgencyWithDomainPermissionRequest.AgencyId.ToString());
            urlParam.Add("role_id", associateAgencyWithDomainPermissionRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithDomainPermissionRequest);
            return new SyncInvoker<AssociateAgencyWithDomainPermissionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AssociateAgencyWithDomainPermissionResponse>);
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
        public AssociateAgencyWithProjectPermissionResponse AssociateAgencyWithProjectPermission(AssociateAgencyWithProjectPermissionRequest associateAgencyWithProjectPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", associateAgencyWithProjectPermissionRequest.ProjectId.ToString());
            urlParam.Add("agency_id", associateAgencyWithProjectPermissionRequest.AgencyId.ToString());
            urlParam.Add("role_id", associateAgencyWithProjectPermissionRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithProjectPermissionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithProjectPermissionResponse>(response);
        }

        public SyncInvoker<AssociateAgencyWithProjectPermissionResponse> AssociateAgencyWithProjectPermissionInvoker(AssociateAgencyWithProjectPermissionRequest associateAgencyWithProjectPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", associateAgencyWithProjectPermissionRequest.ProjectId.ToString());
            urlParam.Add("agency_id", associateAgencyWithProjectPermissionRequest.AgencyId.ToString());
            urlParam.Add("role_id", associateAgencyWithProjectPermissionRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithProjectPermissionRequest);
            return new SyncInvoker<AssociateAgencyWithProjectPermissionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AssociateAgencyWithProjectPermissionResponse>);
        }
        
        /// <summary>
        /// application/json
        ///
        /// 该接口可以基于委托为企业项目授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateRoleToAgencyOnEnterpriseProjectResponse AssociateRoleToAgencyOnEnterpriseProject(AssociateRoleToAgencyOnEnterpriseProjectRequest associateRoleToAgencyOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/subjects/agency/scopes/enterprise-project/role-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateRoleToAgencyOnEnterpriseProjectRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<AssociateRoleToAgencyOnEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<AssociateRoleToAgencyOnEnterpriseProjectResponse> AssociateRoleToAgencyOnEnterpriseProjectInvoker(AssociateRoleToAgencyOnEnterpriseProjectRequest associateRoleToAgencyOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/subjects/agency/scopes/enterprise-project/role-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateRoleToAgencyOnEnterpriseProjectRequest);
            return new SyncInvoker<AssociateRoleToAgencyOnEnterpriseProjectResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AssociateRoleToAgencyOnEnterpriseProjectResponse>);
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
        public AssociateRoleToGroupOnEnterpriseProjectResponse AssociateRoleToGroupOnEnterpriseProject(AssociateRoleToGroupOnEnterpriseProjectRequest associateRoleToGroupOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", associateRoleToGroupOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("group_id", associateRoleToGroupOnEnterpriseProjectRequest.GroupId.ToString());
            urlParam.Add("role_id", associateRoleToGroupOnEnterpriseProjectRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRoleToGroupOnEnterpriseProjectRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<AssociateRoleToGroupOnEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<AssociateRoleToGroupOnEnterpriseProjectResponse> AssociateRoleToGroupOnEnterpriseProjectInvoker(AssociateRoleToGroupOnEnterpriseProjectRequest associateRoleToGroupOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", associateRoleToGroupOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("group_id", associateRoleToGroupOnEnterpriseProjectRequest.GroupId.ToString());
            urlParam.Add("role_id", associateRoleToGroupOnEnterpriseProjectRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRoleToGroupOnEnterpriseProjectRequest);
            return new SyncInvoker<AssociateRoleToGroupOnEnterpriseProjectResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AssociateRoleToGroupOnEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 基于用户为企业项目授权
        ///
        /// 基于用户为企业项目授权。
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateRoleToUserOnEnterpriseProjectResponse AssociateRoleToUserOnEnterpriseProject(AssociateRoleToUserOnEnterpriseProjectRequest associateRoleToUserOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", associateRoleToUserOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("user_id", associateRoleToUserOnEnterpriseProjectRequest.UserId.ToString());
            urlParam.Add("role_id", associateRoleToUserOnEnterpriseProjectRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRoleToUserOnEnterpriseProjectRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<AssociateRoleToUserOnEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<AssociateRoleToUserOnEnterpriseProjectResponse> AssociateRoleToUserOnEnterpriseProjectInvoker(AssociateRoleToUserOnEnterpriseProjectRequest associateRoleToUserOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", associateRoleToUserOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("user_id", associateRoleToUserOnEnterpriseProjectRequest.UserId.ToString());
            urlParam.Add("role_id", associateRoleToUserOnEnterpriseProjectRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRoleToUserOnEnterpriseProjectRequest);
            return new SyncInvoker<AssociateRoleToUserOnEnterpriseProjectResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<AssociateRoleToUserOnEnterpriseProjectResponse>);
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
        public CheckAllProjectsPermissionForAgencyResponse CheckAllProjectsPermissionForAgency(CheckAllProjectsPermissionForAgencyRequest checkAllProjectsPermissionForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id", checkAllProjectsPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("domain_id", checkAllProjectsPermissionForAgencyRequest.DomainId.ToString());
            urlParam.Add("role_id", checkAllProjectsPermissionForAgencyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkAllProjectsPermissionForAgencyRequest);
            var response = DoHttpRequestSync("HEAD", request);
            return JsonUtils.DeSerializeNull<CheckAllProjectsPermissionForAgencyResponse>(response);
        }

        public SyncInvoker<CheckAllProjectsPermissionForAgencyResponse> CheckAllProjectsPermissionForAgencyInvoker(CheckAllProjectsPermissionForAgencyRequest checkAllProjectsPermissionForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id", checkAllProjectsPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("domain_id", checkAllProjectsPermissionForAgencyRequest.DomainId.ToString());
            urlParam.Add("role_id", checkAllProjectsPermissionForAgencyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkAllProjectsPermissionForAgencyRequest);
            return new SyncInvoker<CheckAllProjectsPermissionForAgencyResponse>(this, "HEAD", request, JsonUtils.DeSerializeNull<CheckAllProjectsPermissionForAgencyResponse>);
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
        public CheckDomainPermissionForAgencyResponse CheckDomainPermissionForAgency(CheckDomainPermissionForAgencyRequest checkDomainPermissionForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", checkDomainPermissionForAgencyRequest.DomainId.ToString());
            urlParam.Add("agency_id", checkDomainPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id", checkDomainPermissionForAgencyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDomainPermissionForAgencyRequest);
            var response = DoHttpRequestSync("HEAD", request);
            return JsonUtils.DeSerializeNull<CheckDomainPermissionForAgencyResponse>(response);
        }

        public SyncInvoker<CheckDomainPermissionForAgencyResponse> CheckDomainPermissionForAgencyInvoker(CheckDomainPermissionForAgencyRequest checkDomainPermissionForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", checkDomainPermissionForAgencyRequest.DomainId.ToString());
            urlParam.Add("agency_id", checkDomainPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id", checkDomainPermissionForAgencyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDomainPermissionForAgencyRequest);
            return new SyncInvoker<CheckDomainPermissionForAgencyResponse>(this, "HEAD", request, JsonUtils.DeSerializeNull<CheckDomainPermissionForAgencyResponse>);
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
        public CheckProjectPermissionForAgencyResponse CheckProjectPermissionForAgency(CheckProjectPermissionForAgencyRequest checkProjectPermissionForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", checkProjectPermissionForAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id", checkProjectPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id", checkProjectPermissionForAgencyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkProjectPermissionForAgencyRequest);
            var response = DoHttpRequestSync("HEAD", request);
            return JsonUtils.DeSerializeNull<CheckProjectPermissionForAgencyResponse>(response);
        }

        public SyncInvoker<CheckProjectPermissionForAgencyResponse> CheckProjectPermissionForAgencyInvoker(CheckProjectPermissionForAgencyRequest checkProjectPermissionForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", checkProjectPermissionForAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id", checkProjectPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id", checkProjectPermissionForAgencyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkProjectPermissionForAgencyRequest);
            return new SyncInvoker<CheckProjectPermissionForAgencyResponse>(this, "HEAD", request, JsonUtils.DeSerializeNull<CheckProjectPermissionForAgencyResponse>);
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
        public CreateAgencyResponse CreateAgency(CreateAgencyRequest createAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAgencyResponse>(response);
        }

        public SyncInvoker<CreateAgencyResponse> CreateAgencyInvoker(CreateAgencyRequest createAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyRequest);
            return new SyncInvoker<CreateAgencyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAgencyResponse>);
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
        public CreateAgencyCustomPolicyResponse CreateAgencyCustomPolicy(CreateAgencyCustomPolicyRequest createAgencyCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyCustomPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAgencyCustomPolicyResponse>(response);
        }

        public SyncInvoker<CreateAgencyCustomPolicyResponse> CreateAgencyCustomPolicyInvoker(CreateAgencyCustomPolicyRequest createAgencyCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyCustomPolicyRequest);
            return new SyncInvoker<CreateAgencyCustomPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAgencyCustomPolicyResponse>);
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
        public CreateCloudServiceCustomPolicyResponse CreateCloudServiceCustomPolicy(CreateCloudServiceCustomPolicyRequest createCloudServiceCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCloudServiceCustomPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCloudServiceCustomPolicyResponse>(response);
        }

        public SyncInvoker<CreateCloudServiceCustomPolicyResponse> CreateCloudServiceCustomPolicyInvoker(CreateCloudServiceCustomPolicyRequest createCloudServiceCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCloudServiceCustomPolicyRequest);
            return new SyncInvoker<CreateCloudServiceCustomPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCloudServiceCustomPolicyResponse>);
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
        public CreateLoginTokenResponse CreateLoginToken(CreateLoginTokenRequest createLoginTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AUTH/securitytoken/logintokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLoginTokenRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLoginTokenResponse>(response);
        }

        public SyncInvoker<CreateLoginTokenResponse> CreateLoginTokenInvoker(CreateLoginTokenRequest createLoginTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AUTH/securitytoken/logintokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLoginTokenRequest);
            return new SyncInvoker<CreateLoginTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLoginTokenResponse>);
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
        public CreateMetadataResponse CreateMetadata(CreateMetadataRequest createMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", createMetadataRequest.IdpId.ToString());
            urlParam.Add("protocol_id", createMetadataRequest.ProtocolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMetadataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMetadataResponse>(response);
        }

        public SyncInvoker<CreateMetadataResponse> CreateMetadataInvoker(CreateMetadataRequest createMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", createMetadataRequest.IdpId.ToString());
            urlParam.Add("protocol_id", createMetadataRequest.ProtocolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMetadataRequest);
            return new SyncInvoker<CreateMetadataResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMetadataResponse>);
        }
        
        /// <summary>
        /// 创建OpenId Connect身份提供商配置
        ///
        /// 创建OpenId Connect身份提供商配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOpenIdConnectConfigResponse CreateOpenIdConnectConfig(CreateOpenIdConnectConfigRequest createOpenIdConnectConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", createOpenIdConnectConfigRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOpenIdConnectConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOpenIdConnectConfigResponse>(response);
        }

        public SyncInvoker<CreateOpenIdConnectConfigResponse> CreateOpenIdConnectConfigInvoker(CreateOpenIdConnectConfigRequest createOpenIdConnectConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", createOpenIdConnectConfigRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOpenIdConnectConfigRequest);
            return new SyncInvoker<CreateOpenIdConnectConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOpenIdConnectConfigResponse>);
        }
        
        /// <summary>
        /// 获取联邦认证token(OpenId Connect Id token方式)
        ///
        /// 获取联邦认证token(OpenId Connect Id token方式)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTokenWithIdTokenResponse CreateTokenWithIdToken(CreateTokenWithIdTokenRequest createTokenWithIdTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AUTH/id-token/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTokenWithIdTokenRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTokenWithIdTokenResponse>(response);
        }

        public SyncInvoker<CreateTokenWithIdTokenResponse> CreateTokenWithIdTokenInvoker(CreateTokenWithIdTokenRequest createTokenWithIdTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AUTH/id-token/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTokenWithIdTokenRequest);
            return new SyncInvoker<CreateTokenWithIdTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTokenWithIdTokenResponse>);
        }
        
        /// <summary>
        /// 获取联邦认证unscoped token(OpenId Connect Id token方式)
        ///
        /// 获取联邦认证token(OpenId Connect Id token方式)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateUnscopedTokenWithIdTokenResponse CreateUnscopedTokenWithIdToken(CreateUnscopedTokenWithIdTokenRequest createUnscopedTokenWithIdTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", createUnscopedTokenWithIdTokenRequest.IdpId.ToString());
            urlParam.Add("protocol_id", createUnscopedTokenWithIdTokenRequest.ProtocolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUnscopedTokenWithIdTokenRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateUnscopedTokenWithIdTokenResponse>(response);
        }

        public SyncInvoker<CreateUnscopedTokenWithIdTokenResponse> CreateUnscopedTokenWithIdTokenInvoker(CreateUnscopedTokenWithIdTokenRequest createUnscopedTokenWithIdTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", createUnscopedTokenWithIdTokenRequest.IdpId.ToString());
            urlParam.Add("protocol_id", createUnscopedTokenWithIdTokenRequest.ProtocolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/auth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUnscopedTokenWithIdTokenRequest);
            return new SyncInvoker<CreateUnscopedTokenWithIdTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUnscopedTokenWithIdTokenResponse>);
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
        public DeleteAgencyResponse DeleteAgency(DeleteAgencyRequest deleteAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id", deleteAgencyRequest.AgencyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgencyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAgencyResponse>(response);
        }

        public SyncInvoker<DeleteAgencyResponse> DeleteAgencyInvoker(DeleteAgencyRequest deleteAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id", deleteAgencyRequest.AgencyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgencyRequest);
            return new SyncInvoker<DeleteAgencyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAgencyResponse>);
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
        public DeleteCustomPolicyResponse DeleteCustomPolicy(DeleteCustomPolicyRequest deleteCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id", deleteCustomPolicyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCustomPolicyResponse>(response);
        }

        public SyncInvoker<DeleteCustomPolicyResponse> DeleteCustomPolicyInvoker(DeleteCustomPolicyRequest deleteCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id", deleteCustomPolicyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomPolicyRequest);
            return new SyncInvoker<DeleteCustomPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCustomPolicyResponse>);
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
        public DeleteDomainGroupInheritedRoleResponse DeleteDomainGroupInheritedRole(DeleteDomainGroupInheritedRoleRequest deleteDomainGroupInheritedRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteDomainGroupInheritedRoleRequest.DomainId.ToString());
            urlParam.Add("group_id", deleteDomainGroupInheritedRoleRequest.GroupId.ToString());
            urlParam.Add("role_id", deleteDomainGroupInheritedRoleRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainGroupInheritedRoleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainGroupInheritedRoleResponse>(response);
        }

        public SyncInvoker<DeleteDomainGroupInheritedRoleResponse> DeleteDomainGroupInheritedRoleInvoker(DeleteDomainGroupInheritedRoleRequest deleteDomainGroupInheritedRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteDomainGroupInheritedRoleRequest.DomainId.ToString());
            urlParam.Add("group_id", deleteDomainGroupInheritedRoleRequest.GroupId.ToString());
            urlParam.Add("role_id", deleteDomainGroupInheritedRoleRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainGroupInheritedRoleRequest);
            return new SyncInvoker<DeleteDomainGroupInheritedRoleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainGroupInheritedRoleResponse>);
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
        public KeystoneAddUserToGroupResponse KeystoneAddUserToGroup(KeystoneAddUserToGroupRequest keystoneAddUserToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", keystoneAddUserToGroupRequest.GroupId.ToString());
            urlParam.Add("user_id", keystoneAddUserToGroupRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAddUserToGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<KeystoneAddUserToGroupResponse>(response);
        }

        public SyncInvoker<KeystoneAddUserToGroupResponse> KeystoneAddUserToGroupInvoker(KeystoneAddUserToGroupRequest keystoneAddUserToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", keystoneAddUserToGroupRequest.GroupId.ToString());
            urlParam.Add("user_id", keystoneAddUserToGroupRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAddUserToGroupRequest);
            return new SyncInvoker<KeystoneAddUserToGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<KeystoneAddUserToGroupResponse>);
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
        public KeystoneAssociateGroupWithDomainPermissionResponse KeystoneAssociateGroupWithDomainPermission(KeystoneAssociateGroupWithDomainPermissionRequest keystoneAssociateGroupWithDomainPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneAssociateGroupWithDomainPermissionRequest.DomainId.ToString());
            urlParam.Add("group_id", keystoneAssociateGroupWithDomainPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id", keystoneAssociateGroupWithDomainPermissionRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAssociateGroupWithDomainPermissionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithDomainPermissionResponse>(response);
        }

        public SyncInvoker<KeystoneAssociateGroupWithDomainPermissionResponse> KeystoneAssociateGroupWithDomainPermissionInvoker(KeystoneAssociateGroupWithDomainPermissionRequest keystoneAssociateGroupWithDomainPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneAssociateGroupWithDomainPermissionRequest.DomainId.ToString());
            urlParam.Add("group_id", keystoneAssociateGroupWithDomainPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id", keystoneAssociateGroupWithDomainPermissionRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAssociateGroupWithDomainPermissionRequest);
            return new SyncInvoker<KeystoneAssociateGroupWithDomainPermissionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithDomainPermissionResponse>);
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
        public KeystoneAssociateGroupWithProjectPermissionResponse KeystoneAssociateGroupWithProjectPermission(KeystoneAssociateGroupWithProjectPermissionRequest keystoneAssociateGroupWithProjectPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", keystoneAssociateGroupWithProjectPermissionRequest.ProjectId.ToString());
            urlParam.Add("group_id", keystoneAssociateGroupWithProjectPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id", keystoneAssociateGroupWithProjectPermissionRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAssociateGroupWithProjectPermissionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithProjectPermissionResponse>(response);
        }

        public SyncInvoker<KeystoneAssociateGroupWithProjectPermissionResponse> KeystoneAssociateGroupWithProjectPermissionInvoker(KeystoneAssociateGroupWithProjectPermissionRequest keystoneAssociateGroupWithProjectPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", keystoneAssociateGroupWithProjectPermissionRequest.ProjectId.ToString());
            urlParam.Add("group_id", keystoneAssociateGroupWithProjectPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id", keystoneAssociateGroupWithProjectPermissionRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAssociateGroupWithProjectPermissionRequest);
            return new SyncInvoker<KeystoneAssociateGroupWithProjectPermissionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithProjectPermissionResponse>);
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
        public KeystoneCheckDomainPermissionForGroupResponse KeystoneCheckDomainPermissionForGroup(KeystoneCheckDomainPermissionForGroupRequest keystoneCheckDomainPermissionForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneCheckDomainPermissionForGroupRequest.DomainId.ToString());
            urlParam.Add("group_id", keystoneCheckDomainPermissionForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id", keystoneCheckDomainPermissionForGroupRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckDomainPermissionForGroupRequest);
            var response = DoHttpRequestSync("HEAD", request);
            return JsonUtils.DeSerializeNull<KeystoneCheckDomainPermissionForGroupResponse>(response);
        }

        public SyncInvoker<KeystoneCheckDomainPermissionForGroupResponse> KeystoneCheckDomainPermissionForGroupInvoker(KeystoneCheckDomainPermissionForGroupRequest keystoneCheckDomainPermissionForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneCheckDomainPermissionForGroupRequest.DomainId.ToString());
            urlParam.Add("group_id", keystoneCheckDomainPermissionForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id", keystoneCheckDomainPermissionForGroupRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckDomainPermissionForGroupRequest);
            return new SyncInvoker<KeystoneCheckDomainPermissionForGroupResponse>(this, "HEAD", request, JsonUtils.DeSerializeNull<KeystoneCheckDomainPermissionForGroupResponse>);
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
        public KeystoneCheckProjectPermissionForGroupResponse KeystoneCheckProjectPermissionForGroup(KeystoneCheckProjectPermissionForGroupRequest keystoneCheckProjectPermissionForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", keystoneCheckProjectPermissionForGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id", keystoneCheckProjectPermissionForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id", keystoneCheckProjectPermissionForGroupRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckProjectPermissionForGroupRequest);
            var response = DoHttpRequestSync("HEAD", request);
            return JsonUtils.DeSerializeNull<KeystoneCheckProjectPermissionForGroupResponse>(response);
        }

        public SyncInvoker<KeystoneCheckProjectPermissionForGroupResponse> KeystoneCheckProjectPermissionForGroupInvoker(KeystoneCheckProjectPermissionForGroupRequest keystoneCheckProjectPermissionForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", keystoneCheckProjectPermissionForGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id", keystoneCheckProjectPermissionForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id", keystoneCheckProjectPermissionForGroupRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckProjectPermissionForGroupRequest);
            return new SyncInvoker<KeystoneCheckProjectPermissionForGroupResponse>(this, "HEAD", request, JsonUtils.DeSerializeNull<KeystoneCheckProjectPermissionForGroupResponse>);
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
        public KeystoneCheckUserInGroupResponse KeystoneCheckUserInGroup(KeystoneCheckUserInGroupRequest keystoneCheckUserInGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", keystoneCheckUserInGroupRequest.GroupId.ToString());
            urlParam.Add("user_id", keystoneCheckUserInGroupRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckUserInGroupRequest);
            var response = DoHttpRequestSync("HEAD", request);
            return JsonUtils.DeSerializeNull<KeystoneCheckUserInGroupResponse>(response);
        }

        public SyncInvoker<KeystoneCheckUserInGroupResponse> KeystoneCheckUserInGroupInvoker(KeystoneCheckUserInGroupRequest keystoneCheckUserInGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", keystoneCheckUserInGroupRequest.GroupId.ToString());
            urlParam.Add("user_id", keystoneCheckUserInGroupRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckUserInGroupRequest);
            return new SyncInvoker<KeystoneCheckUserInGroupResponse>(this, "HEAD", request, JsonUtils.DeSerializeNull<KeystoneCheckUserInGroupResponse>);
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
        public KeystoneCheckroleForGroupResponse KeystoneCheckroleForGroup(KeystoneCheckroleForGroupRequest keystoneCheckroleForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneCheckroleForGroupRequest.DomainId.ToString());
            urlParam.Add("group_id", keystoneCheckroleForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id", keystoneCheckroleForGroupRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckroleForGroupRequest);
            var response = DoHttpRequestSync("HEAD", request);
            return JsonUtils.DeSerializeNull<KeystoneCheckroleForGroupResponse>(response);
        }

        public SyncInvoker<KeystoneCheckroleForGroupResponse> KeystoneCheckroleForGroupInvoker(KeystoneCheckroleForGroupRequest keystoneCheckroleForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneCheckroleForGroupRequest.DomainId.ToString());
            urlParam.Add("group_id", keystoneCheckroleForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id", keystoneCheckroleForGroupRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckroleForGroupRequest);
            return new SyncInvoker<KeystoneCheckroleForGroupResponse>(this, "HEAD", request, JsonUtils.DeSerializeNull<KeystoneCheckroleForGroupResponse>);
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
        public KeystoneCreateGroupResponse KeystoneCreateGroup(KeystoneCreateGroupRequest keystoneCreateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<KeystoneCreateGroupResponse>(response);
        }

        public SyncInvoker<KeystoneCreateGroupResponse> KeystoneCreateGroupInvoker(KeystoneCreateGroupRequest keystoneCreateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateGroupRequest);
            return new SyncInvoker<KeystoneCreateGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<KeystoneCreateGroupResponse>);
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
        public KeystoneCreateIdentityProviderResponse KeystoneCreateIdentityProvider(KeystoneCreateIdentityProviderRequest keystoneCreateIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneCreateIdentityProviderRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateIdentityProviderRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<KeystoneCreateIdentityProviderResponse>(response);
        }

        public SyncInvoker<KeystoneCreateIdentityProviderResponse> KeystoneCreateIdentityProviderInvoker(KeystoneCreateIdentityProviderRequest keystoneCreateIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneCreateIdentityProviderRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateIdentityProviderRequest);
            return new SyncInvoker<KeystoneCreateIdentityProviderResponse>(this, "PUT", request, JsonUtils.DeSerialize<KeystoneCreateIdentityProviderResponse>);
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
        public KeystoneCreateMappingResponse KeystoneCreateMapping(KeystoneCreateMappingRequest keystoneCreateMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneCreateMappingRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateMappingRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<KeystoneCreateMappingResponse>(response);
        }

        public SyncInvoker<KeystoneCreateMappingResponse> KeystoneCreateMappingInvoker(KeystoneCreateMappingRequest keystoneCreateMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneCreateMappingRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateMappingRequest);
            return new SyncInvoker<KeystoneCreateMappingResponse>(this, "PUT", request, JsonUtils.DeSerialize<KeystoneCreateMappingResponse>);
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
        public KeystoneCreateProjectResponse KeystoneCreateProject(KeystoneCreateProjectRequest keystoneCreateProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateProjectRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<KeystoneCreateProjectResponse>(response);
        }

        public SyncInvoker<KeystoneCreateProjectResponse> KeystoneCreateProjectInvoker(KeystoneCreateProjectRequest keystoneCreateProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateProjectRequest);
            return new SyncInvoker<KeystoneCreateProjectResponse>(this, "POST", request, JsonUtils.DeSerialize<KeystoneCreateProjectResponse>);
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
        public KeystoneCreateProtocolResponse KeystoneCreateProtocol(KeystoneCreateProtocolRequest keystoneCreateProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", keystoneCreateProtocolRequest.IdpId.ToString());
            urlParam.Add("protocol_id", keystoneCreateProtocolRequest.ProtocolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateProtocolRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<KeystoneCreateProtocolResponse>(response);
        }

        public SyncInvoker<KeystoneCreateProtocolResponse> KeystoneCreateProtocolInvoker(KeystoneCreateProtocolRequest keystoneCreateProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", keystoneCreateProtocolRequest.IdpId.ToString());
            urlParam.Add("protocol_id", keystoneCreateProtocolRequest.ProtocolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateProtocolRequest);
            return new SyncInvoker<KeystoneCreateProtocolResponse>(this, "PUT", request, JsonUtils.DeSerialize<KeystoneCreateProtocolResponse>);
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
        public KeystoneCreateScopedTokenResponse KeystoneCreateScopedToken(KeystoneCreateScopedTokenRequest keystoneCreateScopedTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateScopedTokenRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<KeystoneCreateScopedTokenResponse>(response);
        }

        public SyncInvoker<KeystoneCreateScopedTokenResponse> KeystoneCreateScopedTokenInvoker(KeystoneCreateScopedTokenRequest keystoneCreateScopedTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateScopedTokenRequest);
            return new SyncInvoker<KeystoneCreateScopedTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<KeystoneCreateScopedTokenResponse>);
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
        public KeystoneDeleteGroupResponse KeystoneDeleteGroup(KeystoneDeleteGroupRequest keystoneDeleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", keystoneDeleteGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteGroupResponse>(response);
        }

        public SyncInvoker<KeystoneDeleteGroupResponse> KeystoneDeleteGroupInvoker(KeystoneDeleteGroupRequest keystoneDeleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", keystoneDeleteGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteGroupRequest);
            return new SyncInvoker<KeystoneDeleteGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneDeleteGroupResponse>);
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
        public KeystoneDeleteIdentityProviderResponse KeystoneDeleteIdentityProvider(KeystoneDeleteIdentityProviderRequest keystoneDeleteIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneDeleteIdentityProviderRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteIdentityProviderRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteIdentityProviderResponse>(response);
        }

        public SyncInvoker<KeystoneDeleteIdentityProviderResponse> KeystoneDeleteIdentityProviderInvoker(KeystoneDeleteIdentityProviderRequest keystoneDeleteIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneDeleteIdentityProviderRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteIdentityProviderRequest);
            return new SyncInvoker<KeystoneDeleteIdentityProviderResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneDeleteIdentityProviderResponse>);
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
        public KeystoneDeleteMappingResponse KeystoneDeleteMapping(KeystoneDeleteMappingRequest keystoneDeleteMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneDeleteMappingRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteMappingRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteMappingResponse>(response);
        }

        public SyncInvoker<KeystoneDeleteMappingResponse> KeystoneDeleteMappingInvoker(KeystoneDeleteMappingRequest keystoneDeleteMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneDeleteMappingRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteMappingRequest);
            return new SyncInvoker<KeystoneDeleteMappingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneDeleteMappingResponse>);
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
        public KeystoneDeleteProtocolResponse KeystoneDeleteProtocol(KeystoneDeleteProtocolRequest keystoneDeleteProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", keystoneDeleteProtocolRequest.IdpId.ToString());
            urlParam.Add("protocol_id", keystoneDeleteProtocolRequest.ProtocolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteProtocolRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteProtocolResponse>(response);
        }

        public SyncInvoker<KeystoneDeleteProtocolResponse> KeystoneDeleteProtocolInvoker(KeystoneDeleteProtocolRequest keystoneDeleteProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", keystoneDeleteProtocolRequest.IdpId.ToString());
            urlParam.Add("protocol_id", keystoneDeleteProtocolRequest.ProtocolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteProtocolRequest);
            return new SyncInvoker<KeystoneDeleteProtocolResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneDeleteProtocolResponse>);
        }
        
        /// <summary>
        /// 查询用户组的所有项目权限列表
        ///
        /// 该接口可以用于管理员查询用户组所有项目服务权限列表。 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public KeystoneListAllProjectPermissionsForGroupResponse KeystoneListAllProjectPermissionsForGroup(KeystoneListAllProjectPermissionsForGroupRequest keystoneListAllProjectPermissionsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneListAllProjectPermissionsForGroupRequest.DomainId.ToString());
            urlParam.Add("group_id", keystoneListAllProjectPermissionsForGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAllProjectPermissionsForGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListAllProjectPermissionsForGroupResponse>(response);
        }

        public SyncInvoker<KeystoneListAllProjectPermissionsForGroupResponse> KeystoneListAllProjectPermissionsForGroupInvoker(KeystoneListAllProjectPermissionsForGroupRequest keystoneListAllProjectPermissionsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneListAllProjectPermissionsForGroupRequest.DomainId.ToString());
            urlParam.Add("group_id", keystoneListAllProjectPermissionsForGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAllProjectPermissionsForGroupRequest);
            return new SyncInvoker<KeystoneListAllProjectPermissionsForGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListAllProjectPermissionsForGroupResponse>);
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
        public KeystoneListAuthDomainsResponse KeystoneListAuthDomains(KeystoneListAuthDomainsRequest keystoneListAuthDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAuthDomainsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListAuthDomainsResponse>(response);
        }

        public SyncInvoker<KeystoneListAuthDomainsResponse> KeystoneListAuthDomainsInvoker(KeystoneListAuthDomainsRequest keystoneListAuthDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAuthDomainsRequest);
            return new SyncInvoker<KeystoneListAuthDomainsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListAuthDomainsResponse>);
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
        public KeystoneListAuthProjectsResponse KeystoneListAuthProjects(KeystoneListAuthProjectsRequest keystoneListAuthProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAuthProjectsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListAuthProjectsResponse>(response);
        }

        public SyncInvoker<KeystoneListAuthProjectsResponse> KeystoneListAuthProjectsInvoker(KeystoneListAuthProjectsRequest keystoneListAuthProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAuthProjectsRequest);
            return new SyncInvoker<KeystoneListAuthProjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListAuthProjectsResponse>);
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
        public KeystoneListDomainPermissionsForGroupResponse KeystoneListDomainPermissionsForGroup(KeystoneListDomainPermissionsForGroupRequest keystoneListDomainPermissionsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneListDomainPermissionsForGroupRequest.DomainId.ToString());
            urlParam.Add("group_id", keystoneListDomainPermissionsForGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListDomainPermissionsForGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListDomainPermissionsForGroupResponse>(response);
        }

        public SyncInvoker<KeystoneListDomainPermissionsForGroupResponse> KeystoneListDomainPermissionsForGroupInvoker(KeystoneListDomainPermissionsForGroupRequest keystoneListDomainPermissionsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneListDomainPermissionsForGroupRequest.DomainId.ToString());
            urlParam.Add("group_id", keystoneListDomainPermissionsForGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListDomainPermissionsForGroupRequest);
            return new SyncInvoker<KeystoneListDomainPermissionsForGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListDomainPermissionsForGroupResponse>);
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
        public KeystoneListEndpointsResponse KeystoneListEndpoints(KeystoneListEndpointsRequest keystoneListEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListEndpointsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListEndpointsResponse>(response);
        }

        public SyncInvoker<KeystoneListEndpointsResponse> KeystoneListEndpointsInvoker(KeystoneListEndpointsRequest keystoneListEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListEndpointsRequest);
            return new SyncInvoker<KeystoneListEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListEndpointsResponse>);
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
        public KeystoneListFederationDomainsResponse KeystoneListFederationDomains(KeystoneListFederationDomainsRequest keystoneListFederationDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListFederationDomainsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListFederationDomainsResponse>(response);
        }

        public SyncInvoker<KeystoneListFederationDomainsResponse> KeystoneListFederationDomainsInvoker(KeystoneListFederationDomainsRequest keystoneListFederationDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListFederationDomainsRequest);
            return new SyncInvoker<KeystoneListFederationDomainsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListFederationDomainsResponse>);
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
        public KeystoneListGroupsResponse KeystoneListGroups(KeystoneListGroupsRequest keystoneListGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListGroupsResponse>(response);
        }

        public SyncInvoker<KeystoneListGroupsResponse> KeystoneListGroupsInvoker(KeystoneListGroupsRequest keystoneListGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListGroupsRequest);
            return new SyncInvoker<KeystoneListGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListGroupsResponse>);
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
        public KeystoneListIdentityProvidersResponse KeystoneListIdentityProviders(KeystoneListIdentityProvidersRequest keystoneListIdentityProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListIdentityProvidersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListIdentityProvidersResponse>(response);
        }

        public SyncInvoker<KeystoneListIdentityProvidersResponse> KeystoneListIdentityProvidersInvoker(KeystoneListIdentityProvidersRequest keystoneListIdentityProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListIdentityProvidersRequest);
            return new SyncInvoker<KeystoneListIdentityProvidersResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListIdentityProvidersResponse>);
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
        public KeystoneListMappingsResponse KeystoneListMappings(KeystoneListMappingsRequest keystoneListMappingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListMappingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListMappingsResponse>(response);
        }

        public SyncInvoker<KeystoneListMappingsResponse> KeystoneListMappingsInvoker(KeystoneListMappingsRequest keystoneListMappingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListMappingsRequest);
            return new SyncInvoker<KeystoneListMappingsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListMappingsResponse>);
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
        public KeystoneListPermissionsResponse KeystoneListPermissions(KeystoneListPermissionsRequest keystoneListPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListPermissionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListPermissionsResponse>(response);
        }

        public SyncInvoker<KeystoneListPermissionsResponse> KeystoneListPermissionsInvoker(KeystoneListPermissionsRequest keystoneListPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListPermissionsRequest);
            return new SyncInvoker<KeystoneListPermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListPermissionsResponse>);
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
        public KeystoneListProjectPermissionsForGroupResponse KeystoneListProjectPermissionsForGroup(KeystoneListProjectPermissionsForGroupRequest keystoneListProjectPermissionsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", keystoneListProjectPermissionsForGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id", keystoneListProjectPermissionsForGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectPermissionsForGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListProjectPermissionsForGroupResponse>(response);
        }

        public SyncInvoker<KeystoneListProjectPermissionsForGroupResponse> KeystoneListProjectPermissionsForGroupInvoker(KeystoneListProjectPermissionsForGroupRequest keystoneListProjectPermissionsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", keystoneListProjectPermissionsForGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id", keystoneListProjectPermissionsForGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectPermissionsForGroupRequest);
            return new SyncInvoker<KeystoneListProjectPermissionsForGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListProjectPermissionsForGroupResponse>);
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
        public KeystoneListProjectsResponse KeystoneListProjects(KeystoneListProjectsRequest keystoneListProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListProjectsResponse>(response);
        }

        public SyncInvoker<KeystoneListProjectsResponse> KeystoneListProjectsInvoker(KeystoneListProjectsRequest keystoneListProjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectsRequest);
            return new SyncInvoker<KeystoneListProjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListProjectsResponse>);
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
        public KeystoneListProjectsForUserResponse KeystoneListProjectsForUser(KeystoneListProjectsForUserRequest keystoneListProjectsForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", keystoneListProjectsForUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectsForUserRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListProjectsForUserResponse>(response);
        }

        public SyncInvoker<KeystoneListProjectsForUserResponse> KeystoneListProjectsForUserInvoker(KeystoneListProjectsForUserRequest keystoneListProjectsForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", keystoneListProjectsForUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectsForUserRequest);
            return new SyncInvoker<KeystoneListProjectsForUserResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListProjectsForUserResponse>);
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
        public KeystoneListProtocolsResponse KeystoneListProtocols(KeystoneListProtocolsRequest keystoneListProtocolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", keystoneListProtocolsRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProtocolsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListProtocolsResponse>(response);
        }

        public SyncInvoker<KeystoneListProtocolsResponse> KeystoneListProtocolsInvoker(KeystoneListProtocolsRequest keystoneListProtocolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", keystoneListProtocolsRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProtocolsRequest);
            return new SyncInvoker<KeystoneListProtocolsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListProtocolsResponse>);
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
        public KeystoneListRegionsResponse KeystoneListRegions(KeystoneListRegionsRequest keystoneListRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListRegionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListRegionsResponse>(response);
        }

        public SyncInvoker<KeystoneListRegionsResponse> KeystoneListRegionsInvoker(KeystoneListRegionsRequest keystoneListRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListRegionsRequest);
            return new SyncInvoker<KeystoneListRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListRegionsResponse>);
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
        public KeystoneListServicesResponse KeystoneListServices(KeystoneListServicesRequest keystoneListServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListServicesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListServicesResponse>(response);
        }

        public SyncInvoker<KeystoneListServicesResponse> KeystoneListServicesInvoker(KeystoneListServicesRequest keystoneListServicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListServicesRequest);
            return new SyncInvoker<KeystoneListServicesResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListServicesResponse>);
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
        public KeystoneListUsersForGroupByAdminResponse KeystoneListUsersForGroupByAdmin(KeystoneListUsersForGroupByAdminRequest keystoneListUsersForGroupByAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", keystoneListUsersForGroupByAdminRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListUsersForGroupByAdminRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListUsersForGroupByAdminResponse>(response);
        }

        public SyncInvoker<KeystoneListUsersForGroupByAdminResponse> KeystoneListUsersForGroupByAdminInvoker(KeystoneListUsersForGroupByAdminRequest keystoneListUsersForGroupByAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", keystoneListUsersForGroupByAdminRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListUsersForGroupByAdminRequest);
            return new SyncInvoker<KeystoneListUsersForGroupByAdminResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListUsersForGroupByAdminResponse>);
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
        public KeystoneListVersionsResponse KeystoneListVersions(KeystoneListVersionsRequest keystoneListVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListVersionsResponse>(response);
        }

        public SyncInvoker<KeystoneListVersionsResponse> KeystoneListVersionsInvoker(KeystoneListVersionsRequest keystoneListVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListVersionsRequest);
            return new SyncInvoker<KeystoneListVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListVersionsResponse>);
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
        public KeystoneRemoveDomainPermissionFromGroupResponse KeystoneRemoveDomainPermissionFromGroup(KeystoneRemoveDomainPermissionFromGroupRequest keystoneRemoveDomainPermissionFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneRemoveDomainPermissionFromGroupRequest.DomainId.ToString());
            urlParam.Add("group_id", keystoneRemoveDomainPermissionFromGroupRequest.GroupId.ToString());
            urlParam.Add("role_id", keystoneRemoveDomainPermissionFromGroupRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveDomainPermissionFromGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveDomainPermissionFromGroupResponse>(response);
        }

        public SyncInvoker<KeystoneRemoveDomainPermissionFromGroupResponse> KeystoneRemoveDomainPermissionFromGroupInvoker(KeystoneRemoveDomainPermissionFromGroupRequest keystoneRemoveDomainPermissionFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneRemoveDomainPermissionFromGroupRequest.DomainId.ToString());
            urlParam.Add("group_id", keystoneRemoveDomainPermissionFromGroupRequest.GroupId.ToString());
            urlParam.Add("role_id", keystoneRemoveDomainPermissionFromGroupRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveDomainPermissionFromGroupRequest);
            return new SyncInvoker<KeystoneRemoveDomainPermissionFromGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneRemoveDomainPermissionFromGroupResponse>);
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
        public KeystoneRemoveProjectPermissionFromGroupResponse KeystoneRemoveProjectPermissionFromGroup(KeystoneRemoveProjectPermissionFromGroupRequest keystoneRemoveProjectPermissionFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", keystoneRemoveProjectPermissionFromGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id", keystoneRemoveProjectPermissionFromGroupRequest.GroupId.ToString());
            urlParam.Add("role_id", keystoneRemoveProjectPermissionFromGroupRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveProjectPermissionFromGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveProjectPermissionFromGroupResponse>(response);
        }

        public SyncInvoker<KeystoneRemoveProjectPermissionFromGroupResponse> KeystoneRemoveProjectPermissionFromGroupInvoker(KeystoneRemoveProjectPermissionFromGroupRequest keystoneRemoveProjectPermissionFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", keystoneRemoveProjectPermissionFromGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id", keystoneRemoveProjectPermissionFromGroupRequest.GroupId.ToString());
            urlParam.Add("role_id", keystoneRemoveProjectPermissionFromGroupRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveProjectPermissionFromGroupRequest);
            return new SyncInvoker<KeystoneRemoveProjectPermissionFromGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneRemoveProjectPermissionFromGroupResponse>);
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
        public KeystoneRemoveUserFromGroupResponse KeystoneRemoveUserFromGroup(KeystoneRemoveUserFromGroupRequest keystoneRemoveUserFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", keystoneRemoveUserFromGroupRequest.GroupId.ToString());
            urlParam.Add("user_id", keystoneRemoveUserFromGroupRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveUserFromGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveUserFromGroupResponse>(response);
        }

        public SyncInvoker<KeystoneRemoveUserFromGroupResponse> KeystoneRemoveUserFromGroupInvoker(KeystoneRemoveUserFromGroupRequest keystoneRemoveUserFromGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", keystoneRemoveUserFromGroupRequest.GroupId.ToString());
            urlParam.Add("user_id", keystoneRemoveUserFromGroupRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveUserFromGroupRequest);
            return new SyncInvoker<KeystoneRemoveUserFromGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneRemoveUserFromGroupResponse>);
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
        public KeystoneShowCatalogResponse KeystoneShowCatalog(KeystoneShowCatalogRequest keystoneShowCatalogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/catalog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowCatalogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowCatalogResponse>(response);
        }

        public SyncInvoker<KeystoneShowCatalogResponse> KeystoneShowCatalogInvoker(KeystoneShowCatalogRequest keystoneShowCatalogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/catalog", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowCatalogRequest);
            return new SyncInvoker<KeystoneShowCatalogResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowCatalogResponse>);
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
        public KeystoneShowEndpointResponse KeystoneShowEndpoint(KeystoneShowEndpointRequest keystoneShowEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id", keystoneShowEndpointRequest.EndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowEndpointRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowEndpointResponse>(response);
        }

        public SyncInvoker<KeystoneShowEndpointResponse> KeystoneShowEndpointInvoker(KeystoneShowEndpointRequest keystoneShowEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id", keystoneShowEndpointRequest.EndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowEndpointRequest);
            return new SyncInvoker<KeystoneShowEndpointResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowEndpointResponse>);
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
        public KeystoneShowGroupResponse KeystoneShowGroup(KeystoneShowGroupRequest keystoneShowGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", keystoneShowGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowGroupResponse>(response);
        }

        public SyncInvoker<KeystoneShowGroupResponse> KeystoneShowGroupInvoker(KeystoneShowGroupRequest keystoneShowGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", keystoneShowGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowGroupRequest);
            return new SyncInvoker<KeystoneShowGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowGroupResponse>);
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
        public KeystoneShowIdentityProviderResponse KeystoneShowIdentityProvider(KeystoneShowIdentityProviderRequest keystoneShowIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneShowIdentityProviderRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowIdentityProviderRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowIdentityProviderResponse>(response);
        }

        public SyncInvoker<KeystoneShowIdentityProviderResponse> KeystoneShowIdentityProviderInvoker(KeystoneShowIdentityProviderRequest keystoneShowIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneShowIdentityProviderRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowIdentityProviderRequest);
            return new SyncInvoker<KeystoneShowIdentityProviderResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowIdentityProviderResponse>);
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
        public KeystoneShowMappingResponse KeystoneShowMapping(KeystoneShowMappingRequest keystoneShowMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneShowMappingRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowMappingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowMappingResponse>(response);
        }

        public SyncInvoker<KeystoneShowMappingResponse> KeystoneShowMappingInvoker(KeystoneShowMappingRequest keystoneShowMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneShowMappingRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowMappingRequest);
            return new SyncInvoker<KeystoneShowMappingResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowMappingResponse>);
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
        public KeystoneShowPermissionResponse KeystoneShowPermission(KeystoneShowPermissionRequest keystoneShowPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id", keystoneShowPermissionRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowPermissionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowPermissionResponse>(response);
        }

        public SyncInvoker<KeystoneShowPermissionResponse> KeystoneShowPermissionInvoker(KeystoneShowPermissionRequest keystoneShowPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id", keystoneShowPermissionRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowPermissionRequest);
            return new SyncInvoker<KeystoneShowPermissionResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowPermissionResponse>);
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
        public KeystoneShowProjectResponse KeystoneShowProject(KeystoneShowProjectRequest keystoneShowProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", keystoneShowProjectRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowProjectRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowProjectResponse>(response);
        }

        public SyncInvoker<KeystoneShowProjectResponse> KeystoneShowProjectInvoker(KeystoneShowProjectRequest keystoneShowProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", keystoneShowProjectRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowProjectRequest);
            return new SyncInvoker<KeystoneShowProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowProjectResponse>);
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
        public KeystoneShowProtocolResponse KeystoneShowProtocol(KeystoneShowProtocolRequest keystoneShowProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", keystoneShowProtocolRequest.IdpId.ToString());
            urlParam.Add("protocol_id", keystoneShowProtocolRequest.ProtocolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowProtocolRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowProtocolResponse>(response);
        }

        public SyncInvoker<KeystoneShowProtocolResponse> KeystoneShowProtocolInvoker(KeystoneShowProtocolRequest keystoneShowProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", keystoneShowProtocolRequest.IdpId.ToString());
            urlParam.Add("protocol_id", keystoneShowProtocolRequest.ProtocolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowProtocolRequest);
            return new SyncInvoker<KeystoneShowProtocolResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowProtocolResponse>);
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
        public KeystoneShowRegionResponse KeystoneShowRegion(KeystoneShowRegionRequest keystoneShowRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region_id", keystoneShowRegionRequest.RegionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/regions/{region_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowRegionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowRegionResponse>(response);
        }

        public SyncInvoker<KeystoneShowRegionResponse> KeystoneShowRegionInvoker(KeystoneShowRegionRequest keystoneShowRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("region_id", keystoneShowRegionRequest.RegionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/regions/{region_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowRegionRequest);
            return new SyncInvoker<KeystoneShowRegionResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowRegionResponse>);
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
        public KeystoneShowSecurityComplianceResponse KeystoneShowSecurityCompliance(KeystoneShowSecurityComplianceRequest keystoneShowSecurityComplianceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneShowSecurityComplianceRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowSecurityComplianceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowSecurityComplianceResponse>(response);
        }

        public SyncInvoker<KeystoneShowSecurityComplianceResponse> KeystoneShowSecurityComplianceInvoker(KeystoneShowSecurityComplianceRequest keystoneShowSecurityComplianceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneShowSecurityComplianceRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowSecurityComplianceRequest);
            return new SyncInvoker<KeystoneShowSecurityComplianceResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowSecurityComplianceResponse>);
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
        public KeystoneShowSecurityComplianceByOptionResponse KeystoneShowSecurityComplianceByOption(KeystoneShowSecurityComplianceByOptionRequest keystoneShowSecurityComplianceByOptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneShowSecurityComplianceByOptionRequest.DomainId.ToString());
            urlParam.Add("option", keystoneShowSecurityComplianceByOptionRequest.Option.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance/{option}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowSecurityComplianceByOptionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowSecurityComplianceByOptionResponse>(response);
        }

        public SyncInvoker<KeystoneShowSecurityComplianceByOptionResponse> KeystoneShowSecurityComplianceByOptionInvoker(KeystoneShowSecurityComplianceByOptionRequest keystoneShowSecurityComplianceByOptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", keystoneShowSecurityComplianceByOptionRequest.DomainId.ToString());
            urlParam.Add("option", keystoneShowSecurityComplianceByOptionRequest.Option.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance/{option}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowSecurityComplianceByOptionRequest);
            return new SyncInvoker<KeystoneShowSecurityComplianceByOptionResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowSecurityComplianceByOptionResponse>);
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
        public KeystoneShowServiceResponse KeystoneShowService(KeystoneShowServiceRequest keystoneShowServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("service_id", keystoneShowServiceRequest.ServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/services/{service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowServiceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowServiceResponse>(response);
        }

        public SyncInvoker<KeystoneShowServiceResponse> KeystoneShowServiceInvoker(KeystoneShowServiceRequest keystoneShowServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("service_id", keystoneShowServiceRequest.ServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/services/{service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowServiceRequest);
            return new SyncInvoker<KeystoneShowServiceResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowServiceResponse>);
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
        public KeystoneShowVersionResponse KeystoneShowVersion(KeystoneShowVersionRequest keystoneShowVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowVersionResponse>(response);
        }

        public SyncInvoker<KeystoneShowVersionResponse> KeystoneShowVersionInvoker(KeystoneShowVersionRequest keystoneShowVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowVersionRequest);
            return new SyncInvoker<KeystoneShowVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowVersionResponse>);
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
        public KeystoneUpdateGroupResponse KeystoneUpdateGroup(KeystoneUpdateGroupRequest keystoneUpdateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", keystoneUpdateGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateGroupRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<KeystoneUpdateGroupResponse>(response);
        }

        public SyncInvoker<KeystoneUpdateGroupResponse> KeystoneUpdateGroupInvoker(KeystoneUpdateGroupRequest keystoneUpdateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", keystoneUpdateGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateGroupRequest);
            return new SyncInvoker<KeystoneUpdateGroupResponse>(this, "PATCH", request, JsonUtils.DeSerialize<KeystoneUpdateGroupResponse>);
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
        public KeystoneUpdateIdentityProviderResponse KeystoneUpdateIdentityProvider(KeystoneUpdateIdentityProviderRequest keystoneUpdateIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneUpdateIdentityProviderRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateIdentityProviderRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<KeystoneUpdateIdentityProviderResponse>(response);
        }

        public SyncInvoker<KeystoneUpdateIdentityProviderResponse> KeystoneUpdateIdentityProviderInvoker(KeystoneUpdateIdentityProviderRequest keystoneUpdateIdentityProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneUpdateIdentityProviderRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateIdentityProviderRequest);
            return new SyncInvoker<KeystoneUpdateIdentityProviderResponse>(this, "PATCH", request, JsonUtils.DeSerialize<KeystoneUpdateIdentityProviderResponse>);
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
        public KeystoneUpdateMappingResponse KeystoneUpdateMapping(KeystoneUpdateMappingRequest keystoneUpdateMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneUpdateMappingRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateMappingRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<KeystoneUpdateMappingResponse>(response);
        }

        public SyncInvoker<KeystoneUpdateMappingResponse> KeystoneUpdateMappingInvoker(KeystoneUpdateMappingRequest keystoneUpdateMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", keystoneUpdateMappingRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateMappingRequest);
            return new SyncInvoker<KeystoneUpdateMappingResponse>(this, "PATCH", request, JsonUtils.DeSerialize<KeystoneUpdateMappingResponse>);
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
        public KeystoneUpdateProjectResponse KeystoneUpdateProject(KeystoneUpdateProjectRequest keystoneUpdateProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", keystoneUpdateProjectRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateProjectRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<KeystoneUpdateProjectResponse>(response);
        }

        public SyncInvoker<KeystoneUpdateProjectResponse> KeystoneUpdateProjectInvoker(KeystoneUpdateProjectRequest keystoneUpdateProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", keystoneUpdateProjectRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateProjectRequest);
            return new SyncInvoker<KeystoneUpdateProjectResponse>(this, "PATCH", request, JsonUtils.DeSerialize<KeystoneUpdateProjectResponse>);
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
        public KeystoneUpdateProtocolResponse KeystoneUpdateProtocol(KeystoneUpdateProtocolRequest keystoneUpdateProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", keystoneUpdateProtocolRequest.IdpId.ToString());
            urlParam.Add("protocol_id", keystoneUpdateProtocolRequest.ProtocolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateProtocolRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<KeystoneUpdateProtocolResponse>(response);
        }

        public SyncInvoker<KeystoneUpdateProtocolResponse> KeystoneUpdateProtocolInvoker(KeystoneUpdateProtocolRequest keystoneUpdateProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", keystoneUpdateProtocolRequest.IdpId.ToString());
            urlParam.Add("protocol_id", keystoneUpdateProtocolRequest.ProtocolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateProtocolRequest);
            return new SyncInvoker<KeystoneUpdateProtocolResponse>(this, "PATCH", request, JsonUtils.DeSerialize<KeystoneUpdateProtocolResponse>);
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
        public ListAgenciesResponse ListAgencies(ListAgenciesRequest listAgenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgenciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAgenciesResponse>(response);
        }

        public SyncInvoker<ListAgenciesResponse> ListAgenciesInvoker(ListAgenciesRequest listAgenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgenciesRequest);
            return new SyncInvoker<ListAgenciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAgenciesResponse>);
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
        public ListAllProjectsPermissionsForAgencyResponse ListAllProjectsPermissionsForAgency(ListAllProjectsPermissionsForAgencyRequest listAllProjectsPermissionsForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id", listAllProjectsPermissionsForAgencyRequest.AgencyId.ToString());
            urlParam.Add("domain_id", listAllProjectsPermissionsForAgencyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllProjectsPermissionsForAgencyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllProjectsPermissionsForAgencyResponse>(response);
        }

        public SyncInvoker<ListAllProjectsPermissionsForAgencyResponse> ListAllProjectsPermissionsForAgencyInvoker(ListAllProjectsPermissionsForAgencyRequest listAllProjectsPermissionsForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id", listAllProjectsPermissionsForAgencyRequest.AgencyId.ToString());
            urlParam.Add("domain_id", listAllProjectsPermissionsForAgencyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllProjectsPermissionsForAgencyRequest);
            return new SyncInvoker<ListAllProjectsPermissionsForAgencyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllProjectsPermissionsForAgencyResponse>);
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
        public ListCustomPoliciesResponse ListCustomPolicies(ListCustomPoliciesRequest listCustomPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomPoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCustomPoliciesResponse>(response);
        }

        public SyncInvoker<ListCustomPoliciesResponse> ListCustomPoliciesInvoker(ListCustomPoliciesRequest listCustomPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomPoliciesRequest);
            return new SyncInvoker<ListCustomPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCustomPoliciesResponse>);
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
        public ListDomainPermissionsForAgencyResponse ListDomainPermissionsForAgency(ListDomainPermissionsForAgencyRequest listDomainPermissionsForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listDomainPermissionsForAgencyRequest.DomainId.ToString());
            urlParam.Add("agency_id", listDomainPermissionsForAgencyRequest.AgencyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainPermissionsForAgencyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainPermissionsForAgencyResponse>(response);
        }

        public SyncInvoker<ListDomainPermissionsForAgencyResponse> ListDomainPermissionsForAgencyInvoker(ListDomainPermissionsForAgencyRequest listDomainPermissionsForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listDomainPermissionsForAgencyRequest.DomainId.ToString());
            urlParam.Add("agency_id", listDomainPermissionsForAgencyRequest.AgencyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainPermissionsForAgencyRequest);
            return new SyncInvoker<ListDomainPermissionsForAgencyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainPermissionsForAgencyResponse>);
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
        public ListEnterpriseProjectsForGroupResponse ListEnterpriseProjectsForGroup(ListEnterpriseProjectsForGroupRequest listEnterpriseProjectsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listEnterpriseProjectsForGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/groups/{group_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectsForGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEnterpriseProjectsForGroupResponse>(response);
        }

        public SyncInvoker<ListEnterpriseProjectsForGroupResponse> ListEnterpriseProjectsForGroupInvoker(ListEnterpriseProjectsForGroupRequest listEnterpriseProjectsForGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listEnterpriseProjectsForGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/groups/{group_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectsForGroupRequest);
            return new SyncInvoker<ListEnterpriseProjectsForGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnterpriseProjectsForGroupResponse>);
        }
        
        /// <summary>
        /// 查询用户关联的企业项目
        ///
        /// 该接口可用于查询用户所关联的企业项目。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnterpriseProjectsForUserResponse ListEnterpriseProjectsForUser(ListEnterpriseProjectsForUserRequest listEnterpriseProjectsForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", listEnterpriseProjectsForUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/users/{user_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectsForUserRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEnterpriseProjectsForUserResponse>(response);
        }

        public SyncInvoker<ListEnterpriseProjectsForUserResponse> ListEnterpriseProjectsForUserInvoker(ListEnterpriseProjectsForUserRequest listEnterpriseProjectsForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", listEnterpriseProjectsForUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/users/{user_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectsForUserRequest);
            return new SyncInvoker<ListEnterpriseProjectsForUserResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnterpriseProjectsForUserResponse>);
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
        public ListGroupsForEnterpriseProjectResponse ListGroupsForEnterpriseProject(ListGroupsForEnterpriseProjectRequest listGroupsForEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", listGroupsForEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsForEnterpriseProjectRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGroupsForEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<ListGroupsForEnterpriseProjectResponse> ListGroupsForEnterpriseProjectInvoker(ListGroupsForEnterpriseProjectRequest listGroupsForEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", listGroupsForEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsForEnterpriseProjectRequest);
            return new SyncInvoker<ListGroupsForEnterpriseProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupsForEnterpriseProjectResponse>);
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
        public ListProjectPermissionsForAgencyResponse ListProjectPermissionsForAgency(ListProjectPermissionsForAgencyRequest listProjectPermissionsForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectPermissionsForAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id", listProjectPermissionsForAgencyRequest.AgencyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectPermissionsForAgencyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectPermissionsForAgencyResponse>(response);
        }

        public SyncInvoker<ListProjectPermissionsForAgencyResponse> ListProjectPermissionsForAgencyInvoker(ListProjectPermissionsForAgencyRequest listProjectPermissionsForAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectPermissionsForAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id", listProjectPermissionsForAgencyRequest.AgencyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectPermissionsForAgencyRequest);
            return new SyncInvoker<ListProjectPermissionsForAgencyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectPermissionsForAgencyResponse>);
        }
        
        /// <summary>
        /// 查询企业项目已关联用户组的权限
        ///
        /// 该接口可用于查询企业项目已关联用户组的权限。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRolesForGroupOnEnterpriseProjectResponse ListRolesForGroupOnEnterpriseProject(ListRolesForGroupOnEnterpriseProjectRequest listRolesForGroupOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", listRolesForGroupOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("group_id", listRolesForGroupOnEnterpriseProjectRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRolesForGroupOnEnterpriseProjectRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRolesForGroupOnEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<ListRolesForGroupOnEnterpriseProjectResponse> ListRolesForGroupOnEnterpriseProjectInvoker(ListRolesForGroupOnEnterpriseProjectRequest listRolesForGroupOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", listRolesForGroupOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("group_id", listRolesForGroupOnEnterpriseProjectRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRolesForGroupOnEnterpriseProjectRequest);
            return new SyncInvoker<ListRolesForGroupOnEnterpriseProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRolesForGroupOnEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 查询企业项目直接关联用户的权限
        ///
        /// 该接口可用于查询企业项目直接关联用户的权限。
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRolesForUserOnEnterpriseProjectResponse ListRolesForUserOnEnterpriseProject(ListRolesForUserOnEnterpriseProjectRequest listRolesForUserOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", listRolesForUserOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("user_id", listRolesForUserOnEnterpriseProjectRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRolesForUserOnEnterpriseProjectRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRolesForUserOnEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<ListRolesForUserOnEnterpriseProjectResponse> ListRolesForUserOnEnterpriseProjectInvoker(ListRolesForUserOnEnterpriseProjectRequest listRolesForUserOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", listRolesForUserOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("user_id", listRolesForUserOnEnterpriseProjectRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRolesForUserOnEnterpriseProjectRequest);
            return new SyncInvoker<ListRolesForUserOnEnterpriseProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRolesForUserOnEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 查询企业项目直接关联用户
        ///
        /// 该接口可用于查询企业项目直接关联的用户。
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUsersForEnterpriseProjectResponse ListUsersForEnterpriseProject(ListUsersForEnterpriseProjectRequest listUsersForEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", listUsersForEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersForEnterpriseProjectRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUsersForEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<ListUsersForEnterpriseProjectResponse> ListUsersForEnterpriseProjectInvoker(ListUsersForEnterpriseProjectRequest listUsersForEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", listUsersForEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersForEnterpriseProjectRequest);
            return new SyncInvoker<ListUsersForEnterpriseProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersForEnterpriseProjectResponse>);
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
        public RemoveAllProjectsPermissionFromAgencyResponse RemoveAllProjectsPermissionFromAgency(RemoveAllProjectsPermissionFromAgencyRequest removeAllProjectsPermissionFromAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id", removeAllProjectsPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("domain_id", removeAllProjectsPermissionFromAgencyRequest.DomainId.ToString());
            urlParam.Add("role_id", removeAllProjectsPermissionFromAgencyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeAllProjectsPermissionFromAgencyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveAllProjectsPermissionFromAgencyResponse>(response);
        }

        public SyncInvoker<RemoveAllProjectsPermissionFromAgencyResponse> RemoveAllProjectsPermissionFromAgencyInvoker(RemoveAllProjectsPermissionFromAgencyRequest removeAllProjectsPermissionFromAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id", removeAllProjectsPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("domain_id", removeAllProjectsPermissionFromAgencyRequest.DomainId.ToString());
            urlParam.Add("role_id", removeAllProjectsPermissionFromAgencyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeAllProjectsPermissionFromAgencyRequest);
            return new SyncInvoker<RemoveAllProjectsPermissionFromAgencyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveAllProjectsPermissionFromAgencyResponse>);
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
        public RemoveDomainPermissionFromAgencyResponse RemoveDomainPermissionFromAgency(RemoveDomainPermissionFromAgencyRequest removeDomainPermissionFromAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", removeDomainPermissionFromAgencyRequest.DomainId.ToString());
            urlParam.Add("agency_id", removeDomainPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id", removeDomainPermissionFromAgencyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeDomainPermissionFromAgencyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveDomainPermissionFromAgencyResponse>(response);
        }

        public SyncInvoker<RemoveDomainPermissionFromAgencyResponse> RemoveDomainPermissionFromAgencyInvoker(RemoveDomainPermissionFromAgencyRequest removeDomainPermissionFromAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", removeDomainPermissionFromAgencyRequest.DomainId.ToString());
            urlParam.Add("agency_id", removeDomainPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id", removeDomainPermissionFromAgencyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeDomainPermissionFromAgencyRequest);
            return new SyncInvoker<RemoveDomainPermissionFromAgencyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveDomainPermissionFromAgencyResponse>);
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
        public RemoveProjectPermissionFromAgencyResponse RemoveProjectPermissionFromAgency(RemoveProjectPermissionFromAgencyRequest removeProjectPermissionFromAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", removeProjectPermissionFromAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id", removeProjectPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id", removeProjectPermissionFromAgencyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeProjectPermissionFromAgencyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveProjectPermissionFromAgencyResponse>(response);
        }

        public SyncInvoker<RemoveProjectPermissionFromAgencyResponse> RemoveProjectPermissionFromAgencyInvoker(RemoveProjectPermissionFromAgencyRequest removeProjectPermissionFromAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", removeProjectPermissionFromAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id", removeProjectPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id", removeProjectPermissionFromAgencyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeProjectPermissionFromAgencyRequest);
            return new SyncInvoker<RemoveProjectPermissionFromAgencyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveProjectPermissionFromAgencyResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 该接口可以删除企业项目委托上的授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RevokeRoleFromAgencyOnEnterpriseProjectResponse RevokeRoleFromAgencyOnEnterpriseProject(RevokeRoleFromAgencyOnEnterpriseProjectRequest revokeRoleFromAgencyOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/subjects/agency/scopes/enterprise-project/role-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromAgencyOnEnterpriseProjectRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<RevokeRoleFromAgencyOnEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<RevokeRoleFromAgencyOnEnterpriseProjectResponse> RevokeRoleFromAgencyOnEnterpriseProjectInvoker(RevokeRoleFromAgencyOnEnterpriseProjectRequest revokeRoleFromAgencyOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/subjects/agency/scopes/enterprise-project/role-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromAgencyOnEnterpriseProjectRequest);
            return new SyncInvoker<RevokeRoleFromAgencyOnEnterpriseProjectResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RevokeRoleFromAgencyOnEnterpriseProjectResponse>);
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
        public RevokeRoleFromGroupOnEnterpriseProjectResponse RevokeRoleFromGroupOnEnterpriseProject(RevokeRoleFromGroupOnEnterpriseProjectRequest revokeRoleFromGroupOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", revokeRoleFromGroupOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("group_id", revokeRoleFromGroupOnEnterpriseProjectRequest.GroupId.ToString());
            urlParam.Add("role_id", revokeRoleFromGroupOnEnterpriseProjectRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromGroupOnEnterpriseProjectRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<RevokeRoleFromGroupOnEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<RevokeRoleFromGroupOnEnterpriseProjectResponse> RevokeRoleFromGroupOnEnterpriseProjectInvoker(RevokeRoleFromGroupOnEnterpriseProjectRequest revokeRoleFromGroupOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", revokeRoleFromGroupOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("group_id", revokeRoleFromGroupOnEnterpriseProjectRequest.GroupId.ToString());
            urlParam.Add("role_id", revokeRoleFromGroupOnEnterpriseProjectRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromGroupOnEnterpriseProjectRequest);
            return new SyncInvoker<RevokeRoleFromGroupOnEnterpriseProjectResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RevokeRoleFromGroupOnEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 删除企业项目直接关联用户的权限
        ///
        /// 删除企业项目直接关联用户的权限。
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RevokeRoleFromUserOnEnterpriseProjectResponse RevokeRoleFromUserOnEnterpriseProject(RevokeRoleFromUserOnEnterpriseProjectRequest revokeRoleFromUserOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", revokeRoleFromUserOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("user_id", revokeRoleFromUserOnEnterpriseProjectRequest.UserId.ToString());
            urlParam.Add("role_id", revokeRoleFromUserOnEnterpriseProjectRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromUserOnEnterpriseProjectRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<RevokeRoleFromUserOnEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<RevokeRoleFromUserOnEnterpriseProjectResponse> RevokeRoleFromUserOnEnterpriseProjectInvoker(RevokeRoleFromUserOnEnterpriseProjectRequest revokeRoleFromUserOnEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", revokeRoleFromUserOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("user_id", revokeRoleFromUserOnEnterpriseProjectRequest.UserId.ToString());
            urlParam.Add("role_id", revokeRoleFromUserOnEnterpriseProjectRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromUserOnEnterpriseProjectRequest);
            return new SyncInvoker<RevokeRoleFromUserOnEnterpriseProjectResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RevokeRoleFromUserOnEnterpriseProjectResponse>);
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
        public ShowAgencyResponse ShowAgency(ShowAgencyRequest showAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id", showAgencyRequest.AgencyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAgencyResponse>(response);
        }

        public SyncInvoker<ShowAgencyResponse> ShowAgencyInvoker(ShowAgencyRequest showAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id", showAgencyRequest.AgencyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyRequest);
            return new SyncInvoker<ShowAgencyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAgencyResponse>);
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
        public ShowCustomPolicyResponse ShowCustomPolicy(ShowCustomPolicyRequest showCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id", showCustomPolicyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCustomPolicyResponse>(response);
        }

        public SyncInvoker<ShowCustomPolicyResponse> ShowCustomPolicyInvoker(ShowCustomPolicyRequest showCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id", showCustomPolicyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomPolicyRequest);
            return new SyncInvoker<ShowCustomPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCustomPolicyResponse>);
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
        public ShowDomainApiAclPolicyResponse ShowDomainApiAclPolicy(ShowDomainApiAclPolicyRequest showDomainApiAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainApiAclPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/api-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainApiAclPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainApiAclPolicyResponse>(response);
        }

        public SyncInvoker<ShowDomainApiAclPolicyResponse> ShowDomainApiAclPolicyInvoker(ShowDomainApiAclPolicyRequest showDomainApiAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainApiAclPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/api-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainApiAclPolicyRequest);
            return new SyncInvoker<ShowDomainApiAclPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainApiAclPolicyResponse>);
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
        public ShowDomainConsoleAclPolicyResponse ShowDomainConsoleAclPolicy(ShowDomainConsoleAclPolicyRequest showDomainConsoleAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainConsoleAclPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/console-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainConsoleAclPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainConsoleAclPolicyResponse>(response);
        }

        public SyncInvoker<ShowDomainConsoleAclPolicyResponse> ShowDomainConsoleAclPolicyInvoker(ShowDomainConsoleAclPolicyRequest showDomainConsoleAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainConsoleAclPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/console-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainConsoleAclPolicyRequest);
            return new SyncInvoker<ShowDomainConsoleAclPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainConsoleAclPolicyResponse>);
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
        public ShowDomainLoginPolicyResponse ShowDomainLoginPolicy(ShowDomainLoginPolicyRequest showDomainLoginPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainLoginPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLoginPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainLoginPolicyResponse>(response);
        }

        public SyncInvoker<ShowDomainLoginPolicyResponse> ShowDomainLoginPolicyInvoker(ShowDomainLoginPolicyRequest showDomainLoginPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainLoginPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLoginPolicyRequest);
            return new SyncInvoker<ShowDomainLoginPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainLoginPolicyResponse>);
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
        public ShowDomainPasswordPolicyResponse ShowDomainPasswordPolicy(ShowDomainPasswordPolicyRequest showDomainPasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainPasswordPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainPasswordPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainPasswordPolicyResponse>(response);
        }

        public SyncInvoker<ShowDomainPasswordPolicyResponse> ShowDomainPasswordPolicyInvoker(ShowDomainPasswordPolicyRequest showDomainPasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainPasswordPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainPasswordPolicyRequest);
            return new SyncInvoker<ShowDomainPasswordPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainPasswordPolicyResponse>);
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
        public ShowDomainProtectPolicyResponse ShowDomainProtectPolicy(ShowDomainProtectPolicyRequest showDomainProtectPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainProtectPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/protect-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainProtectPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainProtectPolicyResponse>(response);
        }

        public SyncInvoker<ShowDomainProtectPolicyResponse> ShowDomainProtectPolicyInvoker(ShowDomainProtectPolicyRequest showDomainProtectPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainProtectPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/protect-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainProtectPolicyRequest);
            return new SyncInvoker<ShowDomainProtectPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainProtectPolicyResponse>);
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
        public ShowDomainQuotaResponse ShowDomainQuota(ShowDomainQuotaRequest showDomainQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainQuotaRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-QUOTA/domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainQuotaResponse>(response);
        }

        public SyncInvoker<ShowDomainQuotaResponse> ShowDomainQuotaInvoker(ShowDomainQuotaRequest showDomainQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainQuotaRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-QUOTA/domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainQuotaRequest);
            return new SyncInvoker<ShowDomainQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainQuotaResponse>);
        }
        
        /// <summary>
        /// 查询指定账号中的授权记录
        ///
        /// 该接口用于查询指定账号中的授权记录。
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainRoleAssignmentsResponse ShowDomainRoleAssignments(ShowDomainRoleAssignmentsRequest showDomainRoleAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/role-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRoleAssignmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainRoleAssignmentsResponse>(response);
        }

        public SyncInvoker<ShowDomainRoleAssignmentsResponse> ShowDomainRoleAssignmentsInvoker(ShowDomainRoleAssignmentsRequest showDomainRoleAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/role-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRoleAssignmentsRequest);
            return new SyncInvoker<ShowDomainRoleAssignmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainRoleAssignmentsResponse>);
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
        public ShowMetadataResponse ShowMetadata(ShowMetadataRequest showMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", showMetadataRequest.IdpId.ToString());
            urlParam.Add("protocol_id", showMetadataRequest.ProtocolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetadataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMetadataResponse>(response);
        }

        public SyncInvoker<ShowMetadataResponse> ShowMetadataInvoker(ShowMetadataRequest showMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", showMetadataRequest.IdpId.ToString());
            urlParam.Add("protocol_id", showMetadataRequest.ProtocolId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetadataRequest);
            return new SyncInvoker<ShowMetadataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMetadataResponse>);
        }
        
        /// <summary>
        /// 查询OpenId Connect身份提供商配置
        ///
        /// 查询OpenId Connect身份提供商配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOpenIdConnectConfigResponse ShowOpenIdConnectConfig(ShowOpenIdConnectConfigRequest showOpenIdConnectConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", showOpenIdConnectConfigRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpenIdConnectConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOpenIdConnectConfigResponse>(response);
        }

        public SyncInvoker<ShowOpenIdConnectConfigResponse> ShowOpenIdConnectConfigInvoker(ShowOpenIdConnectConfigRequest showOpenIdConnectConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", showOpenIdConnectConfigRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpenIdConnectConfigRequest);
            return new SyncInvoker<ShowOpenIdConnectConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOpenIdConnectConfigResponse>);
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
        public ShowProjectDetailsAndStatusResponse ShowProjectDetailsAndStatus(ShowProjectDetailsAndStatusRequest showProjectDetailsAndStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showProjectDetailsAndStatusRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectDetailsAndStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectDetailsAndStatusResponse>(response);
        }

        public SyncInvoker<ShowProjectDetailsAndStatusResponse> ShowProjectDetailsAndStatusInvoker(ShowProjectDetailsAndStatusRequest showProjectDetailsAndStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showProjectDetailsAndStatusRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectDetailsAndStatusRequest);
            return new SyncInvoker<ShowProjectDetailsAndStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectDetailsAndStatusResponse>);
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
        public ShowProjectQuotaResponse ShowProjectQuota(ShowProjectQuotaRequest showProjectQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showProjectQuotaRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-QUOTA/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectQuotaResponse>(response);
        }

        public SyncInvoker<ShowProjectQuotaResponse> ShowProjectQuotaInvoker(ShowProjectQuotaRequest showProjectQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showProjectQuotaRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-QUOTA/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectQuotaRequest);
            return new SyncInvoker<ShowProjectQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectQuotaResponse>);
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
        public UpdateAgencyResponse UpdateAgency(UpdateAgencyRequest updateAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id", updateAgencyRequest.AgencyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAgencyResponse>(response);
        }

        public SyncInvoker<UpdateAgencyResponse> UpdateAgencyInvoker(UpdateAgencyRequest updateAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id", updateAgencyRequest.AgencyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyRequest);
            return new SyncInvoker<UpdateAgencyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAgencyResponse>);
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
        public UpdateAgencyCustomPolicyResponse UpdateAgencyCustomPolicy(UpdateAgencyCustomPolicyRequest updateAgencyCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id", updateAgencyCustomPolicyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyCustomPolicyRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateAgencyCustomPolicyResponse>(response);
        }

        public SyncInvoker<UpdateAgencyCustomPolicyResponse> UpdateAgencyCustomPolicyInvoker(UpdateAgencyCustomPolicyRequest updateAgencyCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id", updateAgencyCustomPolicyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyCustomPolicyRequest);
            return new SyncInvoker<UpdateAgencyCustomPolicyResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateAgencyCustomPolicyResponse>);
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
        public UpdateCloudServiceCustomPolicyResponse UpdateCloudServiceCustomPolicy(UpdateCloudServiceCustomPolicyRequest updateCloudServiceCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id", updateCloudServiceCustomPolicyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCloudServiceCustomPolicyRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateCloudServiceCustomPolicyResponse>(response);
        }

        public SyncInvoker<UpdateCloudServiceCustomPolicyResponse> UpdateCloudServiceCustomPolicyInvoker(UpdateCloudServiceCustomPolicyRequest updateCloudServiceCustomPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id", updateCloudServiceCustomPolicyRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCloudServiceCustomPolicyRequest);
            return new SyncInvoker<UpdateCloudServiceCustomPolicyResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateCloudServiceCustomPolicyResponse>);
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
        public UpdateDomainApiAclPolicyResponse UpdateDomainApiAclPolicy(UpdateDomainApiAclPolicyRequest updateDomainApiAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainApiAclPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/api-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainApiAclPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainApiAclPolicyResponse>(response);
        }

        public SyncInvoker<UpdateDomainApiAclPolicyResponse> UpdateDomainApiAclPolicyInvoker(UpdateDomainApiAclPolicyRequest updateDomainApiAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainApiAclPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/api-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainApiAclPolicyRequest);
            return new SyncInvoker<UpdateDomainApiAclPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainApiAclPolicyResponse>);
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
        public UpdateDomainConsoleAclPolicyResponse UpdateDomainConsoleAclPolicy(UpdateDomainConsoleAclPolicyRequest updateDomainConsoleAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainConsoleAclPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/console-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainConsoleAclPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainConsoleAclPolicyResponse>(response);
        }

        public SyncInvoker<UpdateDomainConsoleAclPolicyResponse> UpdateDomainConsoleAclPolicyInvoker(UpdateDomainConsoleAclPolicyRequest updateDomainConsoleAclPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainConsoleAclPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/console-acl-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainConsoleAclPolicyRequest);
            return new SyncInvoker<UpdateDomainConsoleAclPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainConsoleAclPolicyResponse>);
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
        public UpdateDomainGroupInheritRoleResponse UpdateDomainGroupInheritRole(UpdateDomainGroupInheritRoleRequest updateDomainGroupInheritRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainGroupInheritRoleRequest.DomainId.ToString());
            urlParam.Add("group_id", updateDomainGroupInheritRoleRequest.GroupId.ToString());
            urlParam.Add("role_id", updateDomainGroupInheritRoleRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainGroupInheritRoleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainGroupInheritRoleResponse>(response);
        }

        public SyncInvoker<UpdateDomainGroupInheritRoleResponse> UpdateDomainGroupInheritRoleInvoker(UpdateDomainGroupInheritRoleRequest updateDomainGroupInheritRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainGroupInheritRoleRequest.DomainId.ToString());
            urlParam.Add("group_id", updateDomainGroupInheritRoleRequest.GroupId.ToString());
            urlParam.Add("role_id", updateDomainGroupInheritRoleRequest.RoleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainGroupInheritRoleRequest);
            return new SyncInvoker<UpdateDomainGroupInheritRoleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainGroupInheritRoleResponse>);
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
        public UpdateDomainLoginPolicyResponse UpdateDomainLoginPolicy(UpdateDomainLoginPolicyRequest updateDomainLoginPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainLoginPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainLoginPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainLoginPolicyResponse>(response);
        }

        public SyncInvoker<UpdateDomainLoginPolicyResponse> UpdateDomainLoginPolicyInvoker(UpdateDomainLoginPolicyRequest updateDomainLoginPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainLoginPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainLoginPolicyRequest);
            return new SyncInvoker<UpdateDomainLoginPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainLoginPolicyResponse>);
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
        public UpdateDomainPasswordPolicyResponse UpdateDomainPasswordPolicy(UpdateDomainPasswordPolicyRequest updateDomainPasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainPasswordPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainPasswordPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainPasswordPolicyResponse>(response);
        }

        public SyncInvoker<UpdateDomainPasswordPolicyResponse> UpdateDomainPasswordPolicyInvoker(UpdateDomainPasswordPolicyRequest updateDomainPasswordPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainPasswordPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainPasswordPolicyRequest);
            return new SyncInvoker<UpdateDomainPasswordPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainPasswordPolicyResponse>);
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
        public UpdateDomainProtectPolicyResponse UpdateDomainProtectPolicy(UpdateDomainProtectPolicyRequest updateDomainProtectPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainProtectPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/protect-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainProtectPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainProtectPolicyResponse>(response);
        }

        public SyncInvoker<UpdateDomainProtectPolicyResponse> UpdateDomainProtectPolicyInvoker(UpdateDomainProtectPolicyRequest updateDomainProtectPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainProtectPolicyRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/protect-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainProtectPolicyRequest);
            return new SyncInvoker<UpdateDomainProtectPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainProtectPolicyResponse>);
        }
        
        /// <summary>
        /// 修改OpenId Connect身份提供商配置
        ///
        /// 修改OpenId Connect身份提供商配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateOpenIdConnectConfigResponse UpdateOpenIdConnectConfig(UpdateOpenIdConnectConfigRequest updateOpenIdConnectConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", updateOpenIdConnectConfigRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateOpenIdConnectConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateOpenIdConnectConfigResponse>(response);
        }

        public SyncInvoker<UpdateOpenIdConnectConfigResponse> UpdateOpenIdConnectConfigInvoker(UpdateOpenIdConnectConfigRequest updateOpenIdConnectConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id", updateOpenIdConnectConfigRequest.IdpId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateOpenIdConnectConfigRequest);
            return new SyncInvoker<UpdateOpenIdConnectConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateOpenIdConnectConfigResponse>);
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
        public UpdateProjectStatusResponse UpdateProjectStatus(UpdateProjectStatusRequest updateProjectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateProjectStatusRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProjectStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateProjectStatusResponse>(response);
        }

        public SyncInvoker<UpdateProjectStatusResponse> UpdateProjectStatusInvoker(UpdateProjectStatusRequest updateProjectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", updateProjectStatusRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProjectStatusRequest);
            return new SyncInvoker<UpdateProjectStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateProjectStatusResponse>);
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
        public CreatePermanentAccessKeyResponse CreatePermanentAccessKey(CreatePermanentAccessKeyRequest createPermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPermanentAccessKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePermanentAccessKeyResponse>(response);
        }

        public SyncInvoker<CreatePermanentAccessKeyResponse> CreatePermanentAccessKeyInvoker(CreatePermanentAccessKeyRequest createPermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPermanentAccessKeyRequest);
            return new SyncInvoker<CreatePermanentAccessKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePermanentAccessKeyResponse>);
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
        public CreateTemporaryAccessKeyByAgencyResponse CreateTemporaryAccessKeyByAgency(CreateTemporaryAccessKeyByAgencyRequest createTemporaryAccessKeyByAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByAgencyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTemporaryAccessKeyByAgencyResponse>(response);
        }

        public SyncInvoker<CreateTemporaryAccessKeyByAgencyResponse> CreateTemporaryAccessKeyByAgencyInvoker(CreateTemporaryAccessKeyByAgencyRequest createTemporaryAccessKeyByAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByAgencyRequest);
            return new SyncInvoker<CreateTemporaryAccessKeyByAgencyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemporaryAccessKeyByAgencyResponse>);
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
        public CreateTemporaryAccessKeyByTokenResponse CreateTemporaryAccessKeyByToken(CreateTemporaryAccessKeyByTokenRequest createTemporaryAccessKeyByTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByTokenRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTemporaryAccessKeyByTokenResponse>(response);
        }

        public SyncInvoker<CreateTemporaryAccessKeyByTokenResponse> CreateTemporaryAccessKeyByTokenInvoker(CreateTemporaryAccessKeyByTokenRequest createTemporaryAccessKeyByTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByTokenRequest);
            return new SyncInvoker<CreateTemporaryAccessKeyByTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemporaryAccessKeyByTokenResponse>);
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
        public DeletePermanentAccessKeyResponse DeletePermanentAccessKey(DeletePermanentAccessKeyRequest deletePermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key", deletePermanentAccessKeyRequest.AccessKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePermanentAccessKeyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePermanentAccessKeyResponse>(response);
        }

        public SyncInvoker<DeletePermanentAccessKeyResponse> DeletePermanentAccessKeyInvoker(DeletePermanentAccessKeyRequest deletePermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key", deletePermanentAccessKeyRequest.AccessKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePermanentAccessKeyRequest);
            return new SyncInvoker<DeletePermanentAccessKeyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePermanentAccessKeyResponse>);
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
        public ListPermanentAccessKeysResponse ListPermanentAccessKeys(ListPermanentAccessKeysRequest listPermanentAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermanentAccessKeysRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPermanentAccessKeysResponse>(response);
        }

        public SyncInvoker<ListPermanentAccessKeysResponse> ListPermanentAccessKeysInvoker(ListPermanentAccessKeysRequest listPermanentAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermanentAccessKeysRequest);
            return new SyncInvoker<ListPermanentAccessKeysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermanentAccessKeysResponse>);
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
        public ShowPermanentAccessKeyResponse ShowPermanentAccessKey(ShowPermanentAccessKeyRequest showPermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key", showPermanentAccessKeyRequest.AccessKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPermanentAccessKeyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPermanentAccessKeyResponse>(response);
        }

        public SyncInvoker<ShowPermanentAccessKeyResponse> ShowPermanentAccessKeyInvoker(ShowPermanentAccessKeyRequest showPermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key", showPermanentAccessKeyRequest.AccessKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPermanentAccessKeyRequest);
            return new SyncInvoker<ShowPermanentAccessKeyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPermanentAccessKeyResponse>);
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
        public UpdatePermanentAccessKeyResponse UpdatePermanentAccessKey(UpdatePermanentAccessKeyRequest updatePermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key", updatePermanentAccessKeyRequest.AccessKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePermanentAccessKeyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePermanentAccessKeyResponse>(response);
        }

        public SyncInvoker<UpdatePermanentAccessKeyResponse> UpdatePermanentAccessKeyInvoker(UpdatePermanentAccessKeyRequest updatePermanentAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key", updatePermanentAccessKeyRequest.AccessKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePermanentAccessKeyRequest);
            return new SyncInvoker<UpdatePermanentAccessKeyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePermanentAccessKeyResponse>);
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
        public CreateBindingDeviceResponse CreateBindingDevice(CreateBindingDeviceRequest createBindingDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/mfa-devices/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createBindingDeviceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<CreateBindingDeviceResponse>(response);
        }

        public SyncInvoker<CreateBindingDeviceResponse> CreateBindingDeviceInvoker(CreateBindingDeviceRequest createBindingDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/mfa-devices/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createBindingDeviceRequest);
            return new SyncInvoker<CreateBindingDeviceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CreateBindingDeviceResponse>);
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
        public CreateMfaDeviceResponse CreateMfaDevice(CreateMfaDeviceRequest createMfaDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMfaDeviceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMfaDeviceResponse>(response);
        }

        public SyncInvoker<CreateMfaDeviceResponse> CreateMfaDeviceInvoker(CreateMfaDeviceRequest createMfaDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMfaDeviceRequest);
            return new SyncInvoker<CreateMfaDeviceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMfaDeviceResponse>);
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
        public CreateUserResponse CreateUser(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateUserResponse>(response);
        }

        public SyncInvoker<CreateUserResponse> CreateUserInvoker(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createUserRequest);
            return new SyncInvoker<CreateUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUserResponse>);
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
        public DeleteBindingDeviceResponse DeleteBindingDevice(DeleteBindingDeviceRequest deleteBindingDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/mfa-devices/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteBindingDeviceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<DeleteBindingDeviceResponse>(response);
        }

        public SyncInvoker<DeleteBindingDeviceResponse> DeleteBindingDeviceInvoker(DeleteBindingDeviceRequest deleteBindingDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/mfa-devices/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteBindingDeviceRequest);
            return new SyncInvoker<DeleteBindingDeviceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<DeleteBindingDeviceResponse>);
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
        public DeleteMfaDeviceResponse DeleteMfaDevice(DeleteMfaDeviceRequest deleteMfaDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMfaDeviceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMfaDeviceResponse>(response);
        }

        public SyncInvoker<DeleteMfaDeviceResponse> DeleteMfaDeviceInvoker(DeleteMfaDeviceRequest deleteMfaDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMfaDeviceRequest);
            return new SyncInvoker<DeleteMfaDeviceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMfaDeviceResponse>);
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
        public KeystoneCreateUserResponse KeystoneCreateUser(KeystoneCreateUserRequest keystoneCreateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<KeystoneCreateUserResponse>(response);
        }

        public SyncInvoker<KeystoneCreateUserResponse> KeystoneCreateUserInvoker(KeystoneCreateUserRequest keystoneCreateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserRequest);
            return new SyncInvoker<KeystoneCreateUserResponse>(this, "POST", request, JsonUtils.DeSerialize<KeystoneCreateUserResponse>);
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
        public KeystoneDeleteUserResponse KeystoneDeleteUser(KeystoneDeleteUserRequest keystoneDeleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", keystoneDeleteUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteUserRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteUserResponse>(response);
        }

        public SyncInvoker<KeystoneDeleteUserResponse> KeystoneDeleteUserInvoker(KeystoneDeleteUserRequest keystoneDeleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", keystoneDeleteUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteUserRequest);
            return new SyncInvoker<KeystoneDeleteUserResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<KeystoneDeleteUserResponse>);
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
        public KeystoneListGroupsForUserResponse KeystoneListGroupsForUser(KeystoneListGroupsForUserRequest keystoneListGroupsForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", keystoneListGroupsForUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListGroupsForUserRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListGroupsForUserResponse>(response);
        }

        public SyncInvoker<KeystoneListGroupsForUserResponse> KeystoneListGroupsForUserInvoker(KeystoneListGroupsForUserRequest keystoneListGroupsForUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", keystoneListGroupsForUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListGroupsForUserRequest);
            return new SyncInvoker<KeystoneListGroupsForUserResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListGroupsForUserResponse>);
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
        public KeystoneListUsersResponse KeystoneListUsers(KeystoneListUsersRequest keystoneListUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneListUsersResponse>(response);
        }

        public SyncInvoker<KeystoneListUsersResponse> KeystoneListUsersInvoker(KeystoneListUsersRequest keystoneListUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListUsersRequest);
            return new SyncInvoker<KeystoneListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneListUsersResponse>);
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
        public KeystoneShowUserResponse KeystoneShowUser(KeystoneShowUserRequest keystoneShowUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", keystoneShowUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowUserRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneShowUserResponse>(response);
        }

        public SyncInvoker<KeystoneShowUserResponse> KeystoneShowUserInvoker(KeystoneShowUserRequest keystoneShowUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", keystoneShowUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowUserRequest);
            return new SyncInvoker<KeystoneShowUserResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneShowUserResponse>);
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
        public KeystoneUpdateUserByAdminResponse KeystoneUpdateUserByAdmin(KeystoneUpdateUserByAdminRequest keystoneUpdateUserByAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", keystoneUpdateUserByAdminRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserByAdminRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<KeystoneUpdateUserByAdminResponse>(response);
        }

        public SyncInvoker<KeystoneUpdateUserByAdminResponse> KeystoneUpdateUserByAdminInvoker(KeystoneUpdateUserByAdminRequest keystoneUpdateUserByAdminRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", keystoneUpdateUserByAdminRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserByAdminRequest);
            return new SyncInvoker<KeystoneUpdateUserByAdminResponse>(this, "PATCH", request, JsonUtils.DeSerialize<KeystoneUpdateUserByAdminResponse>);
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
        public KeystoneUpdateUserPasswordResponse KeystoneUpdateUserPassword(KeystoneUpdateUserPasswordRequest keystoneUpdateUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", keystoneUpdateUserPasswordRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<KeystoneUpdateUserPasswordResponse>(response);
        }

        public SyncInvoker<KeystoneUpdateUserPasswordResponse> KeystoneUpdateUserPasswordInvoker(KeystoneUpdateUserPasswordRequest keystoneUpdateUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", keystoneUpdateUserPasswordRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserPasswordRequest);
            return new SyncInvoker<KeystoneUpdateUserPasswordResponse>(this, "POST", request, JsonUtils.DeSerializeNull<KeystoneUpdateUserPasswordResponse>);
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
        public ListUserLoginProtectsResponse ListUserLoginProtects(ListUserLoginProtectsRequest listUserLoginProtectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/login-protects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserLoginProtectsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserLoginProtectsResponse>(response);
        }

        public SyncInvoker<ListUserLoginProtectsResponse> ListUserLoginProtectsInvoker(ListUserLoginProtectsRequest listUserLoginProtectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/login-protects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserLoginProtectsRequest);
            return new SyncInvoker<ListUserLoginProtectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserLoginProtectsResponse>);
        }
        
        /// <summary>
        /// 该接口可以用于获取MFA设备。
        ///
        /// 该接口可以用于[管理员](https://support.huaweicloud.com/usermanual-iam/iam_01_0001.html)查询IAM用户的MFA绑定信息列表。
        /// 
        /// 该接口可以使用全局区域的Endpoint和其他区域的Endpoint调用。IAM的Endpoint请参见：[地区和终端节点](https://developer.huaweicloud.com/endpoint?IAM)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserMfaDevicesResponse ListUserMfaDevices(ListUserMfaDevicesRequest listUserMfaDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserMfaDevicesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserMfaDevicesResponse>(response);
        }

        public SyncInvoker<ListUserMfaDevicesResponse> ListUserMfaDevicesInvoker(ListUserMfaDevicesRequest listUserMfaDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserMfaDevicesRequest);
            return new SyncInvoker<ListUserMfaDevicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserMfaDevicesResponse>);
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
        public ShowUserResponse ShowUser(ShowUserRequest showUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", showUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserResponse>(response);
        }

        public SyncInvoker<ShowUserResponse> ShowUserInvoker(ShowUserRequest showUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", showUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRequest);
            return new SyncInvoker<ShowUserResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserResponse>);
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
        public ShowUserLoginProtectResponse ShowUserLoginProtect(ShowUserLoginProtectRequest showUserLoginProtectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", showUserLoginProtectRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/login-protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserLoginProtectRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserLoginProtectResponse>(response);
        }

        public SyncInvoker<ShowUserLoginProtectResponse> ShowUserLoginProtectInvoker(ShowUserLoginProtectRequest showUserLoginProtectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", showUserLoginProtectRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/login-protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserLoginProtectRequest);
            return new SyncInvoker<ShowUserLoginProtectResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserLoginProtectResponse>);
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
        public ShowUserMfaDeviceResponse ShowUserMfaDevice(ShowUserMfaDeviceRequest showUserMfaDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", showUserMfaDeviceRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/users/{user_id}/virtual-mfa-device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserMfaDeviceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserMfaDeviceResponse>(response);
        }

        public SyncInvoker<ShowUserMfaDeviceResponse> ShowUserMfaDeviceInvoker(ShowUserMfaDeviceRequest showUserMfaDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", showUserMfaDeviceRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/users/{user_id}/virtual-mfa-device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserMfaDeviceRequest);
            return new SyncInvoker<ShowUserMfaDeviceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserMfaDeviceResponse>);
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
        public UpdateLoginProtectResponse UpdateLoginProtect(UpdateLoginProtectRequest updateLoginProtectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", updateLoginProtectRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/login-protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLoginProtectRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLoginProtectResponse>(response);
        }

        public SyncInvoker<UpdateLoginProtectResponse> UpdateLoginProtectInvoker(UpdateLoginProtectRequest updateLoginProtectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", updateLoginProtectRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/login-protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLoginProtectRequest);
            return new SyncInvoker<UpdateLoginProtectResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLoginProtectResponse>);
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
        public UpdateUserResponse UpdateUser(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", updateUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUserResponse>(response);
        }

        public SyncInvoker<UpdateUserResponse> UpdateUserInvoker(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", updateUserRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserRequest);
            return new SyncInvoker<UpdateUserResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUserResponse>);
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
        public UpdateUserInformationResponse UpdateUserInformation(UpdateUserInformationRequest updateUserInformationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", updateUserInformationRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserInformationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateUserInformationResponse>(response);
        }

        public SyncInvoker<UpdateUserInformationResponse> UpdateUserInformationInvoker(UpdateUserInformationRequest updateUserInformationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id", updateUserInformationRequest.UserId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserInformationRequest);
            return new SyncInvoker<UpdateUserInformationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateUserInformationResponse>);
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
        public KeystoneCreateAgencyTokenResponse KeystoneCreateAgencyToken(KeystoneCreateAgencyTokenRequest keystoneCreateAgencyTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateAgencyTokenRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<KeystoneCreateAgencyTokenResponse>(response);
        }

        public SyncInvoker<KeystoneCreateAgencyTokenResponse> KeystoneCreateAgencyTokenInvoker(KeystoneCreateAgencyTokenRequest keystoneCreateAgencyTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateAgencyTokenRequest);
            return new SyncInvoker<KeystoneCreateAgencyTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<KeystoneCreateAgencyTokenResponse>);
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
        public KeystoneCreateUserTokenByPasswordResponse KeystoneCreateUserTokenByPassword(KeystoneCreateUserTokenByPasswordRequest keystoneCreateUserTokenByPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserTokenByPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<KeystoneCreateUserTokenByPasswordResponse>(response);
        }

        public SyncInvoker<KeystoneCreateUserTokenByPasswordResponse> KeystoneCreateUserTokenByPasswordInvoker(KeystoneCreateUserTokenByPasswordRequest keystoneCreateUserTokenByPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserTokenByPasswordRequest);
            return new SyncInvoker<KeystoneCreateUserTokenByPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<KeystoneCreateUserTokenByPasswordResponse>);
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
        public KeystoneCreateUserTokenByPasswordAndMfaResponse KeystoneCreateUserTokenByPasswordAndMfa(KeystoneCreateUserTokenByPasswordAndMfaRequest keystoneCreateUserTokenByPasswordAndMfaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserTokenByPasswordAndMfaRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<KeystoneCreateUserTokenByPasswordAndMfaResponse>(response);
        }

        public SyncInvoker<KeystoneCreateUserTokenByPasswordAndMfaResponse> KeystoneCreateUserTokenByPasswordAndMfaInvoker(KeystoneCreateUserTokenByPasswordAndMfaRequest keystoneCreateUserTokenByPasswordAndMfaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserTokenByPasswordAndMfaRequest);
            return new SyncInvoker<KeystoneCreateUserTokenByPasswordAndMfaResponse>(this, "POST", request, JsonUtils.DeSerialize<KeystoneCreateUserTokenByPasswordAndMfaResponse>);
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
        public KeystoneValidateTokenResponse KeystoneValidateToken(KeystoneValidateTokenRequest keystoneValidateTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneValidateTokenRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<KeystoneValidateTokenResponse>(response);
        }

        public SyncInvoker<KeystoneValidateTokenResponse> KeystoneValidateTokenInvoker(KeystoneValidateTokenRequest keystoneValidateTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneValidateTokenRequest);
            return new SyncInvoker<KeystoneValidateTokenResponse>(this, "GET", request, JsonUtils.DeSerialize<KeystoneValidateTokenResponse>);
        }
        
    }
}