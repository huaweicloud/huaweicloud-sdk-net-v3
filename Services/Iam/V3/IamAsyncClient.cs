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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , associateAgencyWithAllProjectsPermissionRequest.AgencyId.ToString());
            urlParam.Add("domain_id" , associateAgencyWithAllProjectsPermissionRequest.DomainId.ToString());
            urlParam.Add("role_id" , associateAgencyWithAllProjectsPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithAllProjectsPermissionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithAllProjectsPermissionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , associateAgencyWithDomainPermissionRequest.DomainId.ToString());
            urlParam.Add("agency_id" , associateAgencyWithDomainPermissionRequest.AgencyId.ToString());
            urlParam.Add("role_id" , associateAgencyWithDomainPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithDomainPermissionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithDomainPermissionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , associateAgencyWithProjectPermissionRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , associateAgencyWithProjectPermissionRequest.AgencyId.ToString());
            urlParam.Add("role_id" , associateAgencyWithProjectPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAgencyWithProjectPermissionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithProjectPermissionResponse>(response);
        }
        
        /// <summary>
        /// application/json
        ///
        /// 该接口可以基于委托为企业项目授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateRoleToAgencyOnEnterpriseProjectResponse> AssociateRoleToAgencyOnEnterpriseProjectAsync(AssociateRoleToAgencyOnEnterpriseProjectRequest associateRoleToAgencyOnEnterpriseProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/subjects/agency/scopes/enterprise-project/role-assignments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateRoleToAgencyOnEnterpriseProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            AssociateRoleToAgencyOnEnterpriseProjectResponse associateRoleToAgencyOnEnterpriseProjectResponse = JsonUtils.DeSerializeNull<AssociateRoleToAgencyOnEnterpriseProjectResponse>(response);
            return associateRoleToAgencyOnEnterpriseProjectResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , associateRoleToGroupOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("group_id" , associateRoleToGroupOnEnterpriseProjectRequest.GroupId.ToString());
            urlParam.Add("role_id" , associateRoleToGroupOnEnterpriseProjectRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRoleToGroupOnEnterpriseProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<AssociateRoleToGroupOnEnterpriseProjectResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , associateRoleToUserOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("user_id" , associateRoleToUserOnEnterpriseProjectRequest.UserId.ToString());
            urlParam.Add("role_id" , associateRoleToUserOnEnterpriseProjectRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRoleToUserOnEnterpriseProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<AssociateRoleToUserOnEnterpriseProjectResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , checkAllProjectsPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("domain_id" , checkAllProjectsPermissionForAgencyRequest.DomainId.ToString());
            urlParam.Add("role_id" , checkAllProjectsPermissionForAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkAllProjectsPermissionForAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<CheckAllProjectsPermissionForAgencyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , checkDomainPermissionForAgencyRequest.DomainId.ToString());
            urlParam.Add("agency_id" , checkDomainPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , checkDomainPermissionForAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDomainPermissionForAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<CheckDomainPermissionForAgencyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , checkProjectPermissionForAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , checkProjectPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , checkProjectPermissionForAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkProjectPermissionForAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<CheckProjectPermissionForAgencyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAgencyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyCustomPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAgencyCustomPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCloudServiceCustomPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCloudServiceCustomPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AUTH/securitytoken/logintokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLoginTokenRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateLoginTokenResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id" , createMetadataRequest.IdpId.ToString());
            urlParam.Add("protocol_id" , createMetadataRequest.ProtocolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3-ext/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateMetadataResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id" , createOpenIdConnectConfigRequest.IdpId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOpenIdConnectConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateOpenIdConnectConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AUTH/id-token/tokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTokenWithIdTokenRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTokenWithIdTokenResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id" , createUnscopedTokenWithIdTokenRequest.IdpId.ToString());
            urlParam.Add("protocol_id" , createUnscopedTokenWithIdTokenRequest.ProtocolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/auth",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUnscopedTokenWithIdTokenRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateUnscopedTokenWithIdTokenResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , deleteAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAgencyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , deleteCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteCustomPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , deleteDomainGroupInheritedRoleRequest.DomainId.ToString());
            urlParam.Add("group_id" , deleteDomainGroupInheritedRoleRequest.GroupId.ToString());
            urlParam.Add("role_id" , deleteDomainGroupInheritedRoleRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainGroupInheritedRoleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDomainGroupInheritedRoleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneAddUserToGroupRequest.GroupId.ToString());
            urlParam.Add("user_id" , keystoneAddUserToGroupRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAddUserToGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAddUserToGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneAssociateGroupWithDomainPermissionRequest.DomainId.ToString());
            urlParam.Add("group_id" , keystoneAssociateGroupWithDomainPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneAssociateGroupWithDomainPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAssociateGroupWithDomainPermissionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithDomainPermissionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneAssociateGroupWithProjectPermissionRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneAssociateGroupWithProjectPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneAssociateGroupWithProjectPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneAssociateGroupWithProjectPermissionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithProjectPermissionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneCheckDomainPermissionForGroupRequest.DomainId.ToString());
            urlParam.Add("group_id" , keystoneCheckDomainPermissionForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneCheckDomainPermissionForGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckDomainPermissionForGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<KeystoneCheckDomainPermissionForGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneCheckProjectPermissionForGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneCheckProjectPermissionForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneCheckProjectPermissionForGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckProjectPermissionForGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<KeystoneCheckProjectPermissionForGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneCheckUserInGroupRequest.GroupId.ToString());
            urlParam.Add("user_id" , keystoneCheckUserInGroupRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckUserInGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<KeystoneCheckUserInGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneCheckroleForGroupRequest.DomainId.ToString());
            urlParam.Add("group_id" , keystoneCheckroleForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneCheckroleForGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneCheckroleForGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<KeystoneCheckroleForGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , keystoneCreateIdentityProviderRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateIdentityProviderRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<KeystoneCreateIdentityProviderResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , keystoneCreateMappingRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateMappingRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<KeystoneCreateMappingResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateProjectResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id" , keystoneCreateProtocolRequest.IdpId.ToString());
            urlParam.Add("protocol_id" , keystoneCreateProtocolRequest.ProtocolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateProtocolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<KeystoneCreateProtocolResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateScopedTokenRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateScopedTokenResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneDeleteGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , keystoneDeleteIdentityProviderRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteIdentityProviderRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteIdentityProviderResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , keystoneDeleteMappingRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteMappingRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteMappingResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id" , keystoneDeleteProtocolRequest.IdpId.ToString());
            urlParam.Add("protocol_id" , keystoneDeleteProtocolRequest.ProtocolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteProtocolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteProtocolResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneListAllProjectPermissionsForGroupRequest.DomainId.ToString());
            urlParam.Add("group_id" , keystoneListAllProjectPermissionsForGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAllProjectPermissionsForGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListAllProjectPermissionsForGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAuthDomainsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListAuthDomainsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListAuthProjectsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListAuthProjectsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneListDomainPermissionsForGroupRequest.DomainId.ToString());
            urlParam.Add("group_id" , keystoneListDomainPermissionsForGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListDomainPermissionsForGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListDomainPermissionsForGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/endpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListEndpointsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListEndpointsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListFederationDomainsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListFederationDomainsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListGroupsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListIdentityProvidersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListIdentityProvidersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListMappingsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListMappingsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListPermissionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListPermissionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneListProjectPermissionsForGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneListProjectPermissionsForGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectPermissionsForGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListProjectPermissionsForGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListProjectsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneListProjectsForUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProjectsForUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListProjectsForUserResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id" , keystoneListProtocolsRequest.IdpId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListProtocolsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListProtocolsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/regions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListRegionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListRegionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/services",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListServicesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListServicesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneListUsersForGroupByAdminRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListUsersForGroupByAdminRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListUsersForGroupByAdminResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListVersionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneRemoveDomainPermissionFromGroupRequest.DomainId.ToString());
            urlParam.Add("group_id" , keystoneRemoveDomainPermissionFromGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneRemoveDomainPermissionFromGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveDomainPermissionFromGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveDomainPermissionFromGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneRemoveProjectPermissionFromGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneRemoveProjectPermissionFromGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneRemoveProjectPermissionFromGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveProjectPermissionFromGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveProjectPermissionFromGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneRemoveUserFromGroupRequest.GroupId.ToString());
            urlParam.Add("user_id" , keystoneRemoveUserFromGroupRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneRemoveUserFromGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveUserFromGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/catalog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowCatalogRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowCatalogResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id" , keystoneShowEndpointRequest.EndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/endpoints/{endpoint_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowEndpointResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneShowGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , keystoneShowIdentityProviderRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowIdentityProviderRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowIdentityProviderResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , keystoneShowMappingRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowMappingRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowMappingResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , keystoneShowPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowPermissionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowPermissionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneShowProjectRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowProjectResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id" , keystoneShowProtocolRequest.IdpId.ToString());
            urlParam.Add("protocol_id" , keystoneShowProtocolRequest.ProtocolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowProtocolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowProtocolResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("region_id" , keystoneShowRegionRequest.RegionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/regions/{region_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowRegionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowRegionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneShowSecurityComplianceRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowSecurityComplianceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowSecurityComplianceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneShowSecurityComplianceByOptionRequest.DomainId.ToString());
            urlParam.Add("option" , keystoneShowSecurityComplianceByOptionRequest.Option.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance/{option}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowSecurityComplianceByOptionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowSecurityComplianceByOptionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("service_id" , keystoneShowServiceRequest.ServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/services/{service_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowServiceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowServiceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowVersionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneUpdateGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , keystoneUpdateIdentityProviderRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateIdentityProviderRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateIdentityProviderResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , keystoneUpdateMappingRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/mappings/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateMappingRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateMappingResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneUpdateProjectRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateProjectResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id" , keystoneUpdateProtocolRequest.IdpId.ToString());
            urlParam.Add("protocol_id" , keystoneUpdateProtocolRequest.ProtocolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateProtocolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateProtocolResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgenciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAgenciesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , listAllProjectsPermissionsForAgencyRequest.AgencyId.ToString());
            urlParam.Add("domain_id" , listAllProjectsPermissionsForAgencyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllProjectsPermissionsForAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAllProjectsPermissionsForAgencyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomPoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListCustomPoliciesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , listDomainPermissionsForAgencyRequest.DomainId.ToString());
            urlParam.Add("agency_id" , listDomainPermissionsForAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainPermissionsForAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDomainPermissionsForAgencyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , listEnterpriseProjectsForGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/groups/{group_id}/enterprise-projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectsForGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEnterpriseProjectsForGroupResponse>(response);
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
        public async Task<ListEnterpriseProjectsForUserResponse> ListEnterpriseProjectsForUserAsync(ListEnterpriseProjectsForUserRequest listEnterpriseProjectsForUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , listEnterpriseProjectsForUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/users/{user_id}/enterprise-projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectsForUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEnterpriseProjectsForUserResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , listGroupsForEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsForEnterpriseProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListGroupsForEnterpriseProjectResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listProjectPermissionsForAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , listProjectPermissionsForAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectPermissionsForAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectPermissionsForAgencyResponse>(response);
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
        public async Task<ListRolesForGroupOnEnterpriseProjectResponse> ListRolesForGroupOnEnterpriseProjectAsync(ListRolesForGroupOnEnterpriseProjectRequest listRolesForGroupOnEnterpriseProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , listRolesForGroupOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("group_id" , listRolesForGroupOnEnterpriseProjectRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRolesForGroupOnEnterpriseProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRolesForGroupOnEnterpriseProjectResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , listRolesForUserOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("user_id" , listRolesForUserOnEnterpriseProjectRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRolesForUserOnEnterpriseProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRolesForUserOnEnterpriseProjectResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , listUsersForEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersForEnterpriseProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListUsersForEnterpriseProjectResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , removeAllProjectsPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("domain_id" , removeAllProjectsPermissionFromAgencyRequest.DomainId.ToString());
            urlParam.Add("role_id" , removeAllProjectsPermissionFromAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeAllProjectsPermissionFromAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<RemoveAllProjectsPermissionFromAgencyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , removeDomainPermissionFromAgencyRequest.DomainId.ToString());
            urlParam.Add("agency_id" , removeDomainPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , removeDomainPermissionFromAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeDomainPermissionFromAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<RemoveDomainPermissionFromAgencyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , removeProjectPermissionFromAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , removeProjectPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , removeProjectPermissionFromAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeProjectPermissionFromAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<RemoveProjectPermissionFromAgencyResponse>(response);
        }
        
        /// <summary>
        /// 
        ///
        /// 该接口可以删除企业项目委托上的授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RevokeRoleFromAgencyOnEnterpriseProjectResponse> RevokeRoleFromAgencyOnEnterpriseProjectAsync(RevokeRoleFromAgencyOnEnterpriseProjectRequest revokeRoleFromAgencyOnEnterpriseProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/subjects/agency/scopes/enterprise-project/role-assignments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromAgencyOnEnterpriseProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            RevokeRoleFromAgencyOnEnterpriseProjectResponse revokeRoleFromAgencyOnEnterpriseProjectResponse = JsonUtils.DeSerializeNull<RevokeRoleFromAgencyOnEnterpriseProjectResponse>(response);
            return revokeRoleFromAgencyOnEnterpriseProjectResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , revokeRoleFromGroupOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("group_id" , revokeRoleFromGroupOnEnterpriseProjectRequest.GroupId.ToString());
            urlParam.Add("role_id" , revokeRoleFromGroupOnEnterpriseProjectRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromGroupOnEnterpriseProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<RevokeRoleFromGroupOnEnterpriseProjectResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , revokeRoleFromUserOnEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            urlParam.Add("user_id" , revokeRoleFromUserOnEnterpriseProjectRequest.UserId.ToString());
            urlParam.Add("role_id" , revokeRoleFromUserOnEnterpriseProjectRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/enterprise-projects/{enterprise_project_id}/users/{user_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", revokeRoleFromUserOnEnterpriseProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<RevokeRoleFromUserOnEnterpriseProjectResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , showAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAgencyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , showCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCustomPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainApiAclPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/api-acl-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainApiAclPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainApiAclPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainConsoleAclPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/console-acl-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainConsoleAclPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainConsoleAclPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainLoginPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/login-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLoginPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainLoginPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainPasswordPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/password-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainPasswordPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainPasswordPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainProtectPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/protect-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainProtectPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainProtectPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainQuotaRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-QUOTA/domains/{domain_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainQuotaResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-PERMISSION/role-assignments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRoleAssignmentsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainRoleAssignmentsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id" , showMetadataRequest.IdpId.ToString());
            urlParam.Add("protocol_id" , showMetadataRequest.ProtocolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3-ext/OS-FEDERATION/identity_providers/{idp_id}/protocols/{protocol_id}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMetadataResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id" , showOpenIdConnectConfigRequest.IdpId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpenIdConnectConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowOpenIdConnectConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showProjectDetailsAndStatusRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectDetailsAndStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectDetailsAndStatusResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showProjectQuotaRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-QUOTA/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectQuotaResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , updateAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAgencyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , updateAgencyCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyCustomPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<UpdateAgencyCustomPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , updateCloudServiceCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCloudServiceCustomPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<UpdateCloudServiceCustomPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainApiAclPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/api-acl-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainApiAclPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainApiAclPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainConsoleAclPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/console-acl-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainConsoleAclPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainConsoleAclPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainGroupInheritRoleRequest.DomainId.ToString());
            urlParam.Add("group_id" , updateDomainGroupInheritRoleRequest.GroupId.ToString());
            urlParam.Add("role_id" , updateDomainGroupInheritRoleRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainGroupInheritRoleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDomainGroupInheritRoleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainLoginPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/login-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainLoginPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainLoginPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainPasswordPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/password-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainPasswordPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainPasswordPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainProtectPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/protect-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainProtectPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainProtectPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("idp_id" , updateOpenIdConnectConfigRequest.IdpId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-FEDERATION/identity-providers/{idp_id}/openid-connect-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateOpenIdConnectConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateOpenIdConnectConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , updateProjectStatusRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProjectStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateProjectStatusResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPermanentAccessKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePermanentAccessKeyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTemporaryAccessKeyByAgencyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByTokenRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTemporaryAccessKeyByTokenResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key" , deletePermanentAccessKeyRequest.AccessKey.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePermanentAccessKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePermanentAccessKeyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermanentAccessKeysRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPermanentAccessKeysResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key" , showPermanentAccessKeyRequest.AccessKey.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPermanentAccessKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPermanentAccessKeyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key" , updatePermanentAccessKeyRequest.AccessKey.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePermanentAccessKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePermanentAccessKeyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/mfa-devices/bind",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createBindingDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<CreateBindingDeviceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMfaDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateMfaDeviceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateUserResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/mfa-devices/unbind",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteBindingDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<DeleteBindingDeviceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMfaDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMfaDeviceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateUserResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneDeleteUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneDeleteUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteUserResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneListGroupsForUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListGroupsForUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListGroupsForUserResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneListUsersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListUsersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneShowUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneShowUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowUserResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneUpdateUserByAdminRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserByAdminRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateUserByAdminResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneUpdateUserPasswordRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<KeystoneUpdateUserPasswordResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/login-protects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserLoginProtectsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListUserLoginProtectsResponse>(response);
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
        public async Task<ListUserMfaDevicesResponse> ListUserMfaDevicesAsync(ListUserMfaDevicesRequest listUserMfaDevicesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserMfaDevicesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListUserMfaDevicesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , showUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUserResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , showUserLoginProtectRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/login-protect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserLoginProtectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUserLoginProtectResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , showUserMfaDeviceRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/users/{user_id}/virtual-mfa-device",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserMfaDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUserMfaDeviceResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , updateLoginProtectRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/login-protect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLoginProtectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLoginProtectResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , updateUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateUserResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , updateUserInformationRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserInformationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateUserInformationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateAgencyTokenRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateAgencyTokenResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserTokenByPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateUserTokenByPasswordResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserTokenByPasswordAndMfaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateUserTokenByPasswordAndMfaResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/tokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", keystoneValidateTokenRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneValidateTokenResponse>(response);
        }
        
    }
}