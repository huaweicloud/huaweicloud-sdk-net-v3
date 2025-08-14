using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.IdentityCenter.V1.Model;

namespace HuaweiCloud.SDK.IdentityCenter.V1
{
    public partial class IdentityCenterAsyncClient : Client
    {
        public static ClientBuilder<IdentityCenterAsyncClient> NewBuilder()
        {
            return new ClientBuilder<IdentityCenterAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 创建账户分配
        ///
        /// 使用指定的权限集为指定账户分配对应主体的访问权限，主体可为IdentityCenter用户或IdentityCenter用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAccountAssignmentResponse> CreateAccountAssignmentAsync(CreateAccountAssignmentRequest createAccountAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createAccountAssignmentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccountAssignmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAccountAssignmentResponse>(response);
        }

        public AsyncInvoker<CreateAccountAssignmentResponse> CreateAccountAssignmentAsyncInvoker(CreateAccountAssignmentRequest createAccountAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createAccountAssignmentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccountAssignmentRequest);
            return new AsyncInvoker<CreateAccountAssignmentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccountAssignmentResponse>);
        }
        
        /// <summary>
        /// 删除账号分配
        ///
        /// 使用指定的权限集从指定的账号删除主体的访问权限，主体可为IAM身份中心用户或用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAccountAssignmentResponse> DeleteAccountAssignmentAsync(DeleteAccountAssignmentRequest deleteAccountAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAccountAssignmentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccountAssignmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteAccountAssignmentResponse>(response);
        }

        public AsyncInvoker<DeleteAccountAssignmentResponse> DeleteAccountAssignmentAsyncInvoker(DeleteAccountAssignmentRequest deleteAccountAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAccountAssignmentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccountAssignmentRequest);
            return new AsyncInvoker<DeleteAccountAssignmentResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteAccountAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询账户分配创建状态详情
        ///
        /// 根据请求ID，查询指定IAM Identity Center实例下的账户分配创建状态详情信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeAccountAssignmentCreationStatusResponse> DescribeAccountAssignmentCreationStatusAsync(DescribeAccountAssignmentCreationStatusRequest describeAccountAssignmentCreationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeAccountAssignmentCreationStatusRequest.InstanceId.ToString());
            urlParam.Add("request_id", describeAccountAssignmentCreationStatusRequest.RequestId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/creation-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeAccountAssignmentCreationStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribeAccountAssignmentCreationStatusResponse>(response);
        }

        public AsyncInvoker<DescribeAccountAssignmentCreationStatusResponse> DescribeAccountAssignmentCreationStatusAsyncInvoker(DescribeAccountAssignmentCreationStatusRequest describeAccountAssignmentCreationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeAccountAssignmentCreationStatusRequest.InstanceId.ToString());
            urlParam.Add("request_id", describeAccountAssignmentCreationStatusRequest.RequestId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/creation-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeAccountAssignmentCreationStatusRequest);
            return new AsyncInvoker<DescribeAccountAssignmentCreationStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeAccountAssignmentCreationStatusResponse>);
        }
        
        /// <summary>
        /// 查询账户分配删除状态详情
        ///
        /// 根据请求ID，查询指定IAM Identity Center实例下的账户分配删除状态详情信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeAccountAssignmentDeletionStatusResponse> DescribeAccountAssignmentDeletionStatusAsync(DescribeAccountAssignmentDeletionStatusRequest describeAccountAssignmentDeletionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeAccountAssignmentDeletionStatusRequest.InstanceId.ToString());
            urlParam.Add("request_id", describeAccountAssignmentDeletionStatusRequest.RequestId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/deletion-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeAccountAssignmentDeletionStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribeAccountAssignmentDeletionStatusResponse>(response);
        }

        public AsyncInvoker<DescribeAccountAssignmentDeletionStatusResponse> DescribeAccountAssignmentDeletionStatusAsyncInvoker(DescribeAccountAssignmentDeletionStatusRequest describeAccountAssignmentDeletionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeAccountAssignmentDeletionStatusRequest.InstanceId.ToString());
            urlParam.Add("request_id", describeAccountAssignmentDeletionStatusRequest.RequestId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/deletion-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeAccountAssignmentDeletionStatusRequest);
            return new AsyncInvoker<DescribeAccountAssignmentDeletionStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeAccountAssignmentDeletionStatusResponse>);
        }
        
        /// <summary>
        /// 解除与用户或组绑定的所有账号授权关联
        ///
        /// 解除与用户或组绑定的所有账号授权关联。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateProfileResponse> DisassociateProfileAsync(DisassociateProfileRequest disassociateProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", disassociateProfileRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/disassociate-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateProfileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisassociateProfileResponse>(response);
        }

        public AsyncInvoker<DisassociateProfileResponse> DisassociateProfileAsyncInvoker(DisassociateProfileRequest disassociateProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", disassociateProfileRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/disassociate-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateProfileRequest);
            return new AsyncInvoker<DisassociateProfileResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisassociateProfileResponse>);
        }
        
        /// <summary>
        /// 列出账户分配创建状态
        ///
        /// 查询指定IAM Identity Center实例下的账户分配的创建状态列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccountAssignmentCreationStatusResponse> ListAccountAssignmentCreationStatusAsync(ListAccountAssignmentCreationStatusRequest listAccountAssignmentCreationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountAssignmentCreationStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/creation-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentCreationStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccountAssignmentCreationStatusResponse>(response);
        }

        public AsyncInvoker<ListAccountAssignmentCreationStatusResponse> ListAccountAssignmentCreationStatusAsyncInvoker(ListAccountAssignmentCreationStatusRequest listAccountAssignmentCreationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountAssignmentCreationStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/creation-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentCreationStatusRequest);
            return new AsyncInvoker<ListAccountAssignmentCreationStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountAssignmentCreationStatusResponse>);
        }
        
        /// <summary>
        /// 列出账户分配删除状态
        ///
        /// 查询指定IAM Identity Center实例下的账户分配的删除状态列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccountAssignmentDeletionStatusResponse> ListAccountAssignmentDeletionStatusAsync(ListAccountAssignmentDeletionStatusRequest listAccountAssignmentDeletionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountAssignmentDeletionStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/deletion-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentDeletionStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccountAssignmentDeletionStatusResponse>(response);
        }

        public AsyncInvoker<ListAccountAssignmentDeletionStatusResponse> ListAccountAssignmentDeletionStatusAsyncInvoker(ListAccountAssignmentDeletionStatusRequest listAccountAssignmentDeletionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountAssignmentDeletionStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/deletion-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentDeletionStatusRequest);
            return new AsyncInvoker<ListAccountAssignmentDeletionStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountAssignmentDeletionStatusResponse>);
        }
        
        /// <summary>
        /// 列出账户和权限集关联的用户或用户组
        ///
        /// 列出与指定账户以及指定权限集关联的用户或用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccountAssignmentsResponse> ListAccountAssignmentsAsync(ListAccountAssignmentsRequest listAccountAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountAssignmentsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccountAssignmentsResponse>(response);
        }

        public AsyncInvoker<ListAccountAssignmentsResponse> ListAccountAssignmentsAsyncInvoker(ListAccountAssignmentsRequest listAccountAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountAssignmentsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentsRequest);
            return new AsyncInvoker<ListAccountAssignmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountAssignmentsResponse>);
        }
        
        /// <summary>
        /// 检索与用户或用户组关联的账号列表
        ///
        /// 检索与用户或用户组关联的账号列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccountAssignmentsForPrincipalResponse> ListAccountAssignmentsForPrincipalAsync(ListAccountAssignmentsForPrincipalRequest listAccountAssignmentsForPrincipalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountAssignmentsForPrincipalRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments-for-principals", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentsForPrincipalRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccountAssignmentsForPrincipalResponse>(response);
        }

        public AsyncInvoker<ListAccountAssignmentsForPrincipalResponse> ListAccountAssignmentsForPrincipalAsyncInvoker(ListAccountAssignmentsForPrincipalRequest listAccountAssignmentsForPrincipalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountAssignmentsForPrincipalRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments-for-principals", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentsForPrincipalRequest);
            return new AsyncInvoker<ListAccountAssignmentsForPrincipalResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountAssignmentsForPrincipalResponse>);
        }
        
        /// <summary>
        /// 创建应用程序实例
        ///
        /// 创建应用程序实例。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateApplicationInstanceResponse> CreateApplicationInstanceAsync(CreateApplicationInstanceRequest createApplicationInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createApplicationInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createApplicationInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateApplicationInstanceResponse>(response);
        }

        public AsyncInvoker<CreateApplicationInstanceResponse> CreateApplicationInstanceAsyncInvoker(CreateApplicationInstanceRequest createApplicationInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createApplicationInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createApplicationInstanceRequest);
            return new AsyncInvoker<CreateApplicationInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateApplicationInstanceResponse>);
        }
        
        /// <summary>
        /// 删除应用程序实例
        ///
        /// 删除应用程序实例。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteApplicationInstanceResponse> DeleteApplicationInstanceAsync(DeleteApplicationInstanceRequest deleteApplicationInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteApplicationInstanceRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", deleteApplicationInstanceRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteApplicationInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteApplicationInstanceResponse> DeleteApplicationInstanceAsyncInvoker(DeleteApplicationInstanceRequest deleteApplicationInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteApplicationInstanceRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", deleteApplicationInstanceRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationInstanceRequest);
            return new AsyncInvoker<DeleteApplicationInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteApplicationInstanceResponse>);
        }
        
        /// <summary>
        /// 删除应用程序实例与用户或用户组关联关系
        ///
        /// 删除应用程序实例与用户或用户组关联关系。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest deleteProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteProfileRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", deleteProfileRequest.ApplicationInstanceId.ToString());
            urlParam.Add("profile_id", deleteProfileRequest.ProfileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/profiles/{profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProfileRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteProfileResponse>(response);
        }

        public AsyncInvoker<DeleteProfileResponse> DeleteProfileAsyncInvoker(DeleteProfileRequest deleteProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteProfileRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", deleteProfileRequest.ApplicationInstanceId.ToString());
            urlParam.Add("profile_id", deleteProfileRequest.ProfileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/profiles/{profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProfileRequest);
            return new AsyncInvoker<DeleteProfileResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProfileResponse>);
        }
        
        /// <summary>
        /// 查询应用程序详情
        ///
        /// 查询应用程序详情。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeApplicationResponse> DescribeApplicationAsync(DescribeApplicationRequest describeApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeApplicationRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", describeApplicationRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeApplicationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribeApplicationResponse>(response);
        }

        public AsyncInvoker<DescribeApplicationResponse> DescribeApplicationAsyncInvoker(DescribeApplicationRequest describeApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeApplicationRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", describeApplicationRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeApplicationRequest);
            return new AsyncInvoker<DescribeApplicationResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeApplicationResponse>);
        }
        
        /// <summary>
        /// 查询应用程序提供者详情
        ///
        /// 查询应用程序提供者详情。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeApplicationProviderResponse> DescribeApplicationProviderAsync(DescribeApplicationProviderRequest describeApplicationProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_provider_id", describeApplicationProviderRequest.ApplicationProviderId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/application-providers/{application_provider_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeApplicationProviderRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribeApplicationProviderResponse>(response);
        }

        public AsyncInvoker<DescribeApplicationProviderResponse> DescribeApplicationProviderAsyncInvoker(DescribeApplicationProviderRequest describeApplicationProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_provider_id", describeApplicationProviderRequest.ApplicationProviderId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/application-providers/{application_provider_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeApplicationProviderRequest);
            return new AsyncInvoker<DescribeApplicationProviderResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeApplicationProviderResponse>);
        }
        
        /// <summary>
        /// 查询应用程序分配属性配置
        ///
        /// 查询应用程序分配属性配置，目的为用户或者用户组分配对应用程序的访问权限。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetApplicationAssignmentConfigurationResponse> GetApplicationAssignmentConfigurationAsync(GetApplicationAssignmentConfigurationRequest getApplicationAssignmentConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getApplicationAssignmentConfigurationRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", getApplicationAssignmentConfigurationRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getApplicationAssignmentConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetApplicationAssignmentConfigurationResponse>(response);
        }

        public AsyncInvoker<GetApplicationAssignmentConfigurationResponse> GetApplicationAssignmentConfigurationAsyncInvoker(GetApplicationAssignmentConfigurationRequest getApplicationAssignmentConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getApplicationAssignmentConfigurationRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", getApplicationAssignmentConfigurationRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getApplicationAssignmentConfigurationRequest);
            return new AsyncInvoker<GetApplicationAssignmentConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<GetApplicationAssignmentConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询应用程序实例详情
        ///
        /// 查询应用程序实例详情。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetApplicationInstanceResponse> GetApplicationInstanceAsync(GetApplicationInstanceRequest getApplicationInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getApplicationInstanceRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", getApplicationInstanceRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getApplicationInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetApplicationInstanceResponse>(response);
        }

        public AsyncInvoker<GetApplicationInstanceResponse> GetApplicationInstanceAsyncInvoker(GetApplicationInstanceRequest getApplicationInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getApplicationInstanceRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", getApplicationInstanceRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getApplicationInstanceRequest);
            return new AsyncInvoker<GetApplicationInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<GetApplicationInstanceResponse>);
        }
        
        /// <summary>
        /// 上传应用程序实例元数据文件
        ///
        /// 上传应用程序实例元数据文件。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ImportApplicationInstanceServiceProviderMetadataResponse> ImportApplicationInstanceServiceProviderMetadataAsync(ImportApplicationInstanceServiceProviderMetadataRequest importApplicationInstanceServiceProviderMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", importApplicationInstanceServiceProviderMetadataRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", importApplicationInstanceServiceProviderMetadataRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importApplicationInstanceServiceProviderMetadataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ImportApplicationInstanceServiceProviderMetadataResponse>(response);
        }

        public AsyncInvoker<ImportApplicationInstanceServiceProviderMetadataResponse> ImportApplicationInstanceServiceProviderMetadataAsyncInvoker(ImportApplicationInstanceServiceProviderMetadataRequest importApplicationInstanceServiceProviderMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", importApplicationInstanceServiceProviderMetadataRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", importApplicationInstanceServiceProviderMetadataRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importApplicationInstanceServiceProviderMetadataRequest);
            return new AsyncInvoker<ImportApplicationInstanceServiceProviderMetadataResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ImportApplicationInstanceServiceProviderMetadataResponse>);
        }
        
        /// <summary>
        /// 列出应用程序实例
        ///
        /// 列出应用程序实例。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApplicationInstancesResponse> ListApplicationInstancesAsync(ListApplicationInstancesRequest listApplicationInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listApplicationInstancesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationInstancesResponse>(response);
        }

        public AsyncInvoker<ListApplicationInstancesResponse> ListApplicationInstancesAsyncInvoker(ListApplicationInstancesRequest listApplicationInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listApplicationInstancesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationInstancesRequest);
            return new AsyncInvoker<ListApplicationInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationInstancesResponse>);
        }
        
        /// <summary>
        /// 列出应用程序提供者
        ///
        /// 查询应用程序提供者列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApplicationProvidersResponse> ListApplicationProvidersAsync(ListApplicationProvidersRequest listApplicationProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/application-providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationProvidersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationProvidersResponse>(response);
        }

        public AsyncInvoker<ListApplicationProvidersResponse> ListApplicationProvidersAsyncInvoker(ListApplicationProvidersRequest listApplicationProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/application-providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationProvidersRequest);
            return new AsyncInvoker<ListApplicationProvidersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationProvidersResponse>);
        }
        
        /// <summary>
        /// 列出应用程序模板
        ///
        /// 查询应用程序模板列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApplicationTemplatesResponse> ListApplicationTemplatesAsync(ListApplicationTemplatesRequest listApplicationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/application-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationTemplatesResponse>(response);
        }

        public AsyncInvoker<ListApplicationTemplatesResponse> ListApplicationTemplatesAsyncInvoker(ListApplicationTemplatesRequest listApplicationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/application-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationTemplatesRequest);
            return new AsyncInvoker<ListApplicationTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationTemplatesResponse>);
        }
        
        /// <summary>
        /// 列出应用程序
        ///
        /// 查询应用程序列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest listApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listApplicationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationsResponse>(response);
        }

        public AsyncInvoker<ListApplicationsResponse> ListApplicationsAsyncInvoker(ListApplicationsRequest listApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listApplicationsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationsRequest);
            return new AsyncInvoker<ListApplicationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationsResponse>);
        }
        
        /// <summary>
        /// 列出应用程序目录中的预置应用模板
        ///
        /// 列出应用程序目录中的预置应用模板。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCatalogApplicationsResponse> ListCatalogApplicationsAsync(ListCatalogApplicationsRequest listCatalogApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/catalog/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCatalogApplicationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCatalogApplicationsResponse>(response);
        }

        public AsyncInvoker<ListCatalogApplicationsResponse> ListCatalogApplicationsAsyncInvoker(ListCatalogApplicationsRequest listCatalogApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/catalog/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCatalogApplicationsRequest);
            return new AsyncInvoker<ListCatalogApplicationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCatalogApplicationsResponse>);
        }
        
        /// <summary>
        /// 列出应用程序实例与用户或用户组存在的关联关系
        ///
        /// 列出应用程序实例与用户或用户组存在的关联关系。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProfilesResponse> ListProfilesAsync(ListProfilesRequest listProfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listProfilesRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", listProfilesRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProfilesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProfilesResponse>(response);
        }

        public AsyncInvoker<ListProfilesResponse> ListProfilesAsyncInvoker(ListProfilesRequest listProfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listProfilesRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", listProfilesRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProfilesRequest);
            return new AsyncInvoker<ListProfilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProfilesResponse>);
        }
        
        /// <summary>
        /// 更新应用程序实例显示信息
        ///
        /// 更新应用程序实例显示信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateApplicationInstanceDisplayDataResponse> UpdateApplicationInstanceDisplayDataAsync(UpdateApplicationInstanceDisplayDataRequest updateApplicationInstanceDisplayDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateApplicationInstanceDisplayDataRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", updateApplicationInstanceDisplayDataRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/display-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceDisplayDataRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateApplicationInstanceDisplayDataResponse>(response);
        }

        public AsyncInvoker<UpdateApplicationInstanceDisplayDataResponse> UpdateApplicationInstanceDisplayDataAsyncInvoker(UpdateApplicationInstanceDisplayDataRequest updateApplicationInstanceDisplayDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateApplicationInstanceDisplayDataRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", updateApplicationInstanceDisplayDataRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/display-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceDisplayDataRequest);
            return new AsyncInvoker<UpdateApplicationInstanceDisplayDataResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateApplicationInstanceDisplayDataResponse>);
        }
        
        /// <summary>
        /// 更新应用程序属性配置
        ///
        /// 更新应用程序属性配置信息，更新应用程序中的属性映射、中继状态以及会话过期时间。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateApplicationInstanceResponseConfigurationResponse> UpdateApplicationInstanceResponseConfigurationAsync(UpdateApplicationInstanceResponseConfigurationRequest updateApplicationInstanceResponseConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateApplicationInstanceResponseConfigurationRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", updateApplicationInstanceResponseConfigurationRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/response-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceResponseConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateApplicationInstanceResponseConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateApplicationInstanceResponseConfigurationResponse> UpdateApplicationInstanceResponseConfigurationAsyncInvoker(UpdateApplicationInstanceResponseConfigurationRequest updateApplicationInstanceResponseConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateApplicationInstanceResponseConfigurationRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", updateApplicationInstanceResponseConfigurationRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/response-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceResponseConfigurationRequest);
            return new AsyncInvoker<UpdateApplicationInstanceResponseConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateApplicationInstanceResponseConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新应用程序Schema属性映射配置
        ///
        /// 更新应用程序Schema属性映射配置，支持SAML断言中Subject属性映射以及Subject NameID格式。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateApplicationInstanceResponseSchemaConfigurationResponse> UpdateApplicationInstanceResponseSchemaConfigurationAsync(UpdateApplicationInstanceResponseSchemaConfigurationRequest updateApplicationInstanceResponseSchemaConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateApplicationInstanceResponseSchemaConfigurationRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", updateApplicationInstanceResponseSchemaConfigurationRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/response-schema-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceResponseSchemaConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateApplicationInstanceResponseSchemaConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateApplicationInstanceResponseSchemaConfigurationResponse> UpdateApplicationInstanceResponseSchemaConfigurationAsyncInvoker(UpdateApplicationInstanceResponseSchemaConfigurationRequest updateApplicationInstanceResponseSchemaConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateApplicationInstanceResponseSchemaConfigurationRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", updateApplicationInstanceResponseSchemaConfigurationRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/response-schema-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceResponseSchemaConfigurationRequest);
            return new AsyncInvoker<UpdateApplicationInstanceResponseSchemaConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateApplicationInstanceResponseSchemaConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新应用程序实例证书配置
        ///
        /// 更新应用程序实例证书配置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateApplicationInstanceSecurityConfigurationResponse> UpdateApplicationInstanceSecurityConfigurationAsync(UpdateApplicationInstanceSecurityConfigurationRequest updateApplicationInstanceSecurityConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateApplicationInstanceSecurityConfigurationRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", updateApplicationInstanceSecurityConfigurationRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/security-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceSecurityConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateApplicationInstanceSecurityConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateApplicationInstanceSecurityConfigurationResponse> UpdateApplicationInstanceSecurityConfigurationAsyncInvoker(UpdateApplicationInstanceSecurityConfigurationRequest updateApplicationInstanceSecurityConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateApplicationInstanceSecurityConfigurationRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", updateApplicationInstanceSecurityConfigurationRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/security-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceSecurityConfigurationRequest);
            return new AsyncInvoker<UpdateApplicationInstanceSecurityConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateApplicationInstanceSecurityConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新应用程序实例服务提供商配置
        ///
        /// 更新应用程序实例服务提供商配置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateApplicationInstanceServiceProviderConfigurationResponse> UpdateApplicationInstanceServiceProviderConfigurationAsync(UpdateApplicationInstanceServiceProviderConfigurationRequest updateApplicationInstanceServiceProviderConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateApplicationInstanceServiceProviderConfigurationRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", updateApplicationInstanceServiceProviderConfigurationRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/service-provider-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceServiceProviderConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateApplicationInstanceServiceProviderConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateApplicationInstanceServiceProviderConfigurationResponse> UpdateApplicationInstanceServiceProviderConfigurationAsyncInvoker(UpdateApplicationInstanceServiceProviderConfigurationRequest updateApplicationInstanceServiceProviderConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateApplicationInstanceServiceProviderConfigurationRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", updateApplicationInstanceServiceProviderConfigurationRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/service-provider-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceServiceProviderConfigurationRequest);
            return new AsyncInvoker<UpdateApplicationInstanceServiceProviderConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateApplicationInstanceServiceProviderConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新应用程序实例状态
        ///
        /// 更新应用程序实例状态。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateApplicationInstanceStatusResponse> UpdateApplicationInstanceStatusAsync(UpdateApplicationInstanceStatusRequest updateApplicationInstanceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateApplicationInstanceStatusRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", updateApplicationInstanceStatusRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateApplicationInstanceStatusResponse>(response);
        }

        public AsyncInvoker<UpdateApplicationInstanceStatusResponse> UpdateApplicationInstanceStatusAsyncInvoker(UpdateApplicationInstanceStatusRequest updateApplicationInstanceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateApplicationInstanceStatusRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", updateApplicationInstanceStatusRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceStatusRequest);
            return new AsyncInvoker<UpdateApplicationInstanceStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateApplicationInstanceStatusResponse>);
        }
        
        /// <summary>
        /// 应用程序分配用户或用户组
        ///
        /// 应用程序分配用户或用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateApplicationAssignmentResponse> CreateApplicationAssignmentAsync(CreateApplicationAssignmentRequest createApplicationAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createApplicationAssignmentRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", createApplicationAssignmentRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createApplicationAssignmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateApplicationAssignmentResponse>(response);
        }

        public AsyncInvoker<CreateApplicationAssignmentResponse> CreateApplicationAssignmentAsyncInvoker(CreateApplicationAssignmentRequest createApplicationAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createApplicationAssignmentRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", createApplicationAssignmentRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createApplicationAssignmentRequest);
            return new AsyncInvoker<CreateApplicationAssignmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateApplicationAssignmentResponse>);
        }
        
        /// <summary>
        /// 删除应用程序已分配用户或用户组
        ///
        /// 删除应用程序已分配用户或用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteApplicationAssignmentResponse> DeleteApplicationAssignmentAsync(DeleteApplicationAssignmentRequest deleteApplicationAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteApplicationAssignmentRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", deleteApplicationAssignmentRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationAssignmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteApplicationAssignmentResponse>(response);
        }

        public AsyncInvoker<DeleteApplicationAssignmentResponse> DeleteApplicationAssignmentAsyncInvoker(DeleteApplicationAssignmentRequest deleteApplicationAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteApplicationAssignmentRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", deleteApplicationAssignmentRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationAssignmentRequest);
            return new AsyncInvoker<DeleteApplicationAssignmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteApplicationAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询应用程序已分配的用户或用户组列表
        ///
        /// 查询应用程序已分配的用户或用户组列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApplicationAssignmentsResponse> ListApplicationAssignmentsAsync(ListApplicationAssignmentsRequest listApplicationAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listApplicationAssignmentsRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", listApplicationAssignmentsRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAssignmentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationAssignmentsResponse>(response);
        }

        public AsyncInvoker<ListApplicationAssignmentsResponse> ListApplicationAssignmentsAsyncInvoker(ListApplicationAssignmentsRequest listApplicationAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listApplicationAssignmentsRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", listApplicationAssignmentsRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAssignmentsRequest);
            return new AsyncInvoker<ListApplicationAssignmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationAssignmentsResponse>);
        }
        
        /// <summary>
        /// 检索与用户或用户组关联的应用程序列表
        ///
        /// 检索与用户或用户组关联的应用程序列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApplicationAssignmentsForPrincipalResponse> ListApplicationAssignmentsForPrincipalAsync(ListApplicationAssignmentsForPrincipalRequest listApplicationAssignmentsForPrincipalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listApplicationAssignmentsForPrincipalRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-assignments-for-principals", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAssignmentsForPrincipalRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationAssignmentsForPrincipalResponse>(response);
        }

        public AsyncInvoker<ListApplicationAssignmentsForPrincipalResponse> ListApplicationAssignmentsForPrincipalAsyncInvoker(ListApplicationAssignmentsForPrincipalRequest listApplicationAssignmentsForPrincipalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listApplicationAssignmentsForPrincipalRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-assignments-for-principals", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAssignmentsForPrincipalRequest);
            return new AsyncInvoker<ListApplicationAssignmentsForPrincipalResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationAssignmentsForPrincipalResponse>);
        }
        
        /// <summary>
        /// 创建应用程序实例证书
        ///
        /// 创建应用程序实例证书。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateApplicationInstanceCertificateResponse> CreateApplicationInstanceCertificateAsync(CreateApplicationInstanceCertificateRequest createApplicationInstanceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createApplicationInstanceCertificateRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", createApplicationInstanceCertificateRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createApplicationInstanceCertificateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateApplicationInstanceCertificateResponse>(response);
        }

        public AsyncInvoker<CreateApplicationInstanceCertificateResponse> CreateApplicationInstanceCertificateAsyncInvoker(CreateApplicationInstanceCertificateRequest createApplicationInstanceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createApplicationInstanceCertificateRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", createApplicationInstanceCertificateRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createApplicationInstanceCertificateRequest);
            return new AsyncInvoker<CreateApplicationInstanceCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateApplicationInstanceCertificateResponse>);
        }
        
        /// <summary>
        /// 删除应用程序实例证书
        ///
        /// 删除应用程序实例证书。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteApplicationInstanceCertificateResponse> DeleteApplicationInstanceCertificateAsync(DeleteApplicationInstanceCertificateRequest deleteApplicationInstanceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteApplicationInstanceCertificateRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", deleteApplicationInstanceCertificateRequest.ApplicationInstanceId.ToString());
            urlParam.Add("certificate_id", deleteApplicationInstanceCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationInstanceCertificateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteApplicationInstanceCertificateResponse>(response);
        }

        public AsyncInvoker<DeleteApplicationInstanceCertificateResponse> DeleteApplicationInstanceCertificateAsyncInvoker(DeleteApplicationInstanceCertificateRequest deleteApplicationInstanceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteApplicationInstanceCertificateRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", deleteApplicationInstanceCertificateRequest.ApplicationInstanceId.ToString());
            urlParam.Add("certificate_id", deleteApplicationInstanceCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationInstanceCertificateRequest);
            return new AsyncInvoker<DeleteApplicationInstanceCertificateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteApplicationInstanceCertificateResponse>);
        }
        
        /// <summary>
        /// 列出应用程序实例证书
        ///
        /// 查询应用程序实例证书列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApplicationInstanceCertificatesResponse> ListApplicationInstanceCertificatesAsync(ListApplicationInstanceCertificatesRequest listApplicationInstanceCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listApplicationInstanceCertificatesRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", listApplicationInstanceCertificatesRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationInstanceCertificatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationInstanceCertificatesResponse>(response);
        }

        public AsyncInvoker<ListApplicationInstanceCertificatesResponse> ListApplicationInstanceCertificatesAsyncInvoker(ListApplicationInstanceCertificatesRequest listApplicationInstanceCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listApplicationInstanceCertificatesRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", listApplicationInstanceCertificatesRequest.ApplicationInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationInstanceCertificatesRequest);
            return new AsyncInvoker<ListApplicationInstanceCertificatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationInstanceCertificatesResponse>);
        }
        
        /// <summary>
        /// 激活应用程序实例证书
        ///
        /// 激活应用程序实例证书，实现证书轮转。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateApplicationInstanceActiveCertificateResponse> UpdateApplicationInstanceActiveCertificateAsync(UpdateApplicationInstanceActiveCertificateRequest updateApplicationInstanceActiveCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateApplicationInstanceActiveCertificateRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", updateApplicationInstanceActiveCertificateRequest.ApplicationInstanceId.ToString());
            urlParam.Add("certificate_id", updateApplicationInstanceActiveCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceActiveCertificateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateApplicationInstanceActiveCertificateResponse>(response);
        }

        public AsyncInvoker<UpdateApplicationInstanceActiveCertificateResponse> UpdateApplicationInstanceActiveCertificateAsyncInvoker(UpdateApplicationInstanceActiveCertificateRequest updateApplicationInstanceActiveCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateApplicationInstanceActiveCertificateRequest.InstanceId.ToString());
            urlParam.Add("application_instance_id", updateApplicationInstanceActiveCertificateRequest.ApplicationInstanceId.ToString());
            urlParam.Add("certificate_id", updateApplicationInstanceActiveCertificateRequest.CertificateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceActiveCertificateRequest);
            return new AsyncInvoker<UpdateApplicationInstanceActiveCertificateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateApplicationInstanceActiveCertificateResponse>);
        }
        
        /// <summary>
        /// 查询实例配置信息
        ///
        /// 查询IAM身份中心实例配置信息，包括身份认证配置和会话管理配置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetSsoConfigurationResponse> GetSsoConfigurationAsync(GetSsoConfigurationRequest getSsoConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getSsoConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/sso-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getSsoConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetSsoConfigurationResponse>(response);
        }

        public AsyncInvoker<GetSsoConfigurationResponse> GetSsoConfigurationAsyncInvoker(GetSsoConfigurationRequest getSsoConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getSsoConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/sso-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getSsoConfigurationRequest);
            return new AsyncInvoker<GetSsoConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<GetSsoConfigurationResponse>);
        }
        
        /// <summary>
        /// 设置实例配置信息
        ///
        /// 设置IAM身份中心服务实例配置信息，包括身份认证配置和会话管理配置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSsoConfigurationResponse> UpdateSsoConfigurationAsync(UpdateSsoConfigurationRequest updateSsoConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSsoConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/sso-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSsoConfigurationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateSsoConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateSsoConfigurationResponse> UpdateSsoConfigurationAsyncInvoker(UpdateSsoConfigurationRequest updateSsoConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateSsoConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/sso-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSsoConfigurationRequest);
            return new AsyncInvoker<UpdateSsoConfigurationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateSsoConfigurationResponse>);
        }
        
        /// <summary>
        /// 自定义访问门户URL
        ///
        /// 自定义访问门户URL，默认情况下，您可以使用遵循以下格式的 URL访问门户：idcenter.huaweicloud.com/d-xxxxxxxxxx/portal，您可以按如下方式更改为自定义 URL：idcenter.huaweicloud.com/your_subdomain/portal。设置自定义访问门户URL是一次性操作，无法撤销。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest createAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createAliasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAliasRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateAliasResponse>(response);
        }

        public AsyncInvoker<CreateAliasResponse> CreateAliasAsyncInvoker(CreateAliasRequest createAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createAliasRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAliasRequest);
            return new AsyncInvoker<CreateAliasResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateAliasResponse>);
        }
        
        /// <summary>
        /// 删除服务实例
        ///
        /// 删除IAM Identity Center服务实例。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteIdentityCenterResponse> DeleteIdentityCenterAsync(DeleteIdentityCenterRequest deleteIdentityCenterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/service/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIdentityCenterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteIdentityCenterResponse>(response);
        }

        public AsyncInvoker<DeleteIdentityCenterResponse> DeleteIdentityCenterAsyncInvoker(DeleteIdentityCenterRequest deleteIdentityCenterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/service/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIdentityCenterRequest);
            return new AsyncInvoker<DeleteIdentityCenterResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteIdentityCenterResponse>);
        }
        
        /// <summary>
        /// 查询服务实例开通所在区域
        ///
        /// 查询IAM身份中心服务实例开通后，具体开通所在区域。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeRegisteredRegionsResponse> DescribeRegisteredRegionsAsync(DescribeRegisteredRegionsRequest describeRegisteredRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/registered-regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeRegisteredRegionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribeRegisteredRegionsResponse>(response);
        }

        public AsyncInvoker<DescribeRegisteredRegionsResponse> DescribeRegisteredRegionsAsyncInvoker(DescribeRegisteredRegionsRequest describeRegisteredRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/registered-regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeRegisteredRegionsRequest);
            return new AsyncInvoker<DescribeRegisteredRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeRegisteredRegionsResponse>);
        }
        
        /// <summary>
        /// 查询高可用功能配置
        ///
        /// 查询高可用功能配置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetHaConfigurationResponse> GetHaConfigurationAsync(GetHaConfigurationRequest getHaConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getHaConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/disaster-recovery-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getHaConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetHaConfigurationResponse>(response);
        }

        public AsyncInvoker<GetHaConfigurationResponse> GetHaConfigurationAsyncInvoker(GetHaConfigurationRequest getHaConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getHaConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/disaster-recovery-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getHaConfigurationRequest);
            return new AsyncInvoker<GetHaConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<GetHaConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询服务实例状态
        ///
        /// 查询IAM Identity Center服务实例状态信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetIdentityCenterServiceStatusResponse> GetIdentityCenterServiceStatusAsync(GetIdentityCenterServiceStatusRequest getIdentityCenterServiceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-center-service/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getIdentityCenterServiceStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetIdentityCenterServiceStatusResponse>(response);
        }

        public AsyncInvoker<GetIdentityCenterServiceStatusResponse> GetIdentityCenterServiceStatusAsyncInvoker(GetIdentityCenterServiceStatusRequest getIdentityCenterServiceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-center-service/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getIdentityCenterServiceStatusRequest);
            return new AsyncInvoker<GetIdentityCenterServiceStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<GetIdentityCenterServiceStatusResponse>);
        }
        
        /// <summary>
        /// 获取身份源配置
        ///
        /// 获取IAM身份中心服务实例中的身份源配置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIdentityStoreAssociationResponse> ListIdentityStoreAssociationAsync(ListIdentityStoreAssociationRequest listIdentityStoreAssociationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listIdentityStoreAssociationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/identity-store-associations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIdentityStoreAssociationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListIdentityStoreAssociationResponse>(response);
        }

        public AsyncInvoker<ListIdentityStoreAssociationResponse> ListIdentityStoreAssociationAsyncInvoker(ListIdentityStoreAssociationRequest listIdentityStoreAssociationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listIdentityStoreAssociationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/identity-store-associations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIdentityStoreAssociationRequest);
            return new AsyncInvoker<ListIdentityStoreAssociationResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIdentityStoreAssociationResponse>);
        }
        
        /// <summary>
        /// 列出实例
        ///
        /// 查询IAM身份中心的实例列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }

        public AsyncInvoker<ListInstancesResponse> ListInstancesAsyncInvoker(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            return new AsyncInvoker<ListInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesResponse>);
        }
        
        /// <summary>
        /// 选择服务实例开通区域
        ///
        /// IAM身份中心服务实例开通前，需要选择服务实例具体开通在某一区域。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RegisterRegionResponse> RegisterRegionAsync(RegisterRegionRequest registerRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/register-regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerRegionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RegisterRegionResponse>(response);
        }

        public AsyncInvoker<RegisterRegionResponse> RegisterRegionAsyncInvoker(RegisterRegionRequest registerRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/register-regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerRegionRequest);
            return new AsyncInvoker<RegisterRegionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RegisterRegionResponse>);
        }
        
        /// <summary>
        /// 开通服务实例
        ///
        /// 开通IAM Identity Center服务实例。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartIdentityCenterResponse> StartIdentityCenterAsync(StartIdentityCenterRequest startIdentityCenterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/service/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startIdentityCenterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<StartIdentityCenterResponse>(response);
        }

        public AsyncInvoker<StartIdentityCenterResponse> StartIdentityCenterAsyncInvoker(StartIdentityCenterRequest startIdentityCenterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/service/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startIdentityCenterRequest);
            return new AsyncInvoker<StartIdentityCenterResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StartIdentityCenterResponse>);
        }
        
        /// <summary>
        /// 更新高可用功能配置
        ///
        /// 授权启用或者禁用高可用功能配置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHaConfigurationResponse> UpdateHaConfigurationAsync(UpdateHaConfigurationRequest updateHaConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateHaConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/disaster-recovery-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHaConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateHaConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateHaConfigurationResponse> UpdateHaConfigurationAsyncInvoker(UpdateHaConfigurationRequest updateHaConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateHaConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/disaster-recovery-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHaConfigurationRequest);
            return new AsyncInvoker<UpdateHaConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateHaConfigurationResponse>);
        }
        
        /// <summary>
        /// 启用指定实例的访问控制功能
        ///
        /// 启用指定实例的访问控制功能。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceAccessControlAttributeConfigurationResponse> CreateInstanceAccessControlAttributeConfigurationAsync(CreateInstanceAccessControlAttributeConfigurationRequest createInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceAccessControlAttributeConfigurationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateInstanceAccessControlAttributeConfigurationResponse>(response);
        }

        public AsyncInvoker<CreateInstanceAccessControlAttributeConfigurationResponse> CreateInstanceAccessControlAttributeConfigurationAsyncInvoker(CreateInstanceAccessControlAttributeConfigurationRequest createInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceAccessControlAttributeConfigurationRequest);
            return new AsyncInvoker<CreateInstanceAccessControlAttributeConfigurationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateInstanceAccessControlAttributeConfigurationResponse>);
        }
        
        /// <summary>
        /// 解除指定实例的访问控制属性配置
        ///
        /// 禁用指定IAM Identity Center实例的基于属性的访问控制（ABAC）功能，并删除已配置的所有属性映射。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceAccessControlAttributeConfigurationResponse> DeleteInstanceAccessControlAttributeConfigurationAsync(DeleteInstanceAccessControlAttributeConfigurationRequest deleteInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceAccessControlAttributeConfigurationRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceAccessControlAttributeConfigurationResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceAccessControlAttributeConfigurationResponse> DeleteInstanceAccessControlAttributeConfigurationAsyncInvoker(DeleteInstanceAccessControlAttributeConfigurationRequest deleteInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceAccessControlAttributeConfigurationRequest);
            return new AsyncInvoker<DeleteInstanceAccessControlAttributeConfigurationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceAccessControlAttributeConfigurationResponse>);
        }
        
        /// <summary>
        /// 获取指定实例的访问控制属性配置
        ///
        /// 返回已配置为与指定IAM Identity Center实例的基于属性的访问控制（ABAC）一起使用的IAM Identity Center身份存储属性列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribeInstanceAccessControlAttributeConfigurationResponse> DescribeInstanceAccessControlAttributeConfigurationAsync(DescribeInstanceAccessControlAttributeConfigurationRequest describeInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeInstanceAccessControlAttributeConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribeInstanceAccessControlAttributeConfigurationResponse>(response);
        }

        public AsyncInvoker<DescribeInstanceAccessControlAttributeConfigurationResponse> DescribeInstanceAccessControlAttributeConfigurationAsyncInvoker(DescribeInstanceAccessControlAttributeConfigurationRequest describeInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeInstanceAccessControlAttributeConfigurationRequest);
            return new AsyncInvoker<DescribeInstanceAccessControlAttributeConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeInstanceAccessControlAttributeConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新指定实例的访问控制属性配置
        ///
        /// 更新可与IAM Identity Center实例一起使用的IAM Identity Center身份存储属性，以进行基于属性的访问控制（ABAC）。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceAccessControlAttributeConfigurationResponse> UpdateInstanceAccessControlAttributeConfigurationAsync(UpdateInstanceAccessControlAttributeConfigurationRequest updateInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceAccessControlAttributeConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceAccessControlAttributeConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceAccessControlAttributeConfigurationResponse> UpdateInstanceAccessControlAttributeConfigurationAsyncInvoker(UpdateInstanceAccessControlAttributeConfigurationRequest updateInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceAccessControlAttributeConfigurationRequest);
            return new AsyncInvoker<UpdateInstanceAccessControlAttributeConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceAccessControlAttributeConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询MFA管理配置信息
        ///
        /// 查询MFA管理配置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetMfaDeviceManagementForIdentityStoreResponse> GetMfaDeviceManagementForIdentityStoreAsync(GetMfaDeviceManagementForIdentityStoreRequest getMfaDeviceManagementForIdentityStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getMfaDeviceManagementForIdentityStoreRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/mfa-devices/management-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getMfaDeviceManagementForIdentityStoreRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetMfaDeviceManagementForIdentityStoreResponse>(response);
        }

        public AsyncInvoker<GetMfaDeviceManagementForIdentityStoreResponse> GetMfaDeviceManagementForIdentityStoreAsyncInvoker(GetMfaDeviceManagementForIdentityStoreRequest getMfaDeviceManagementForIdentityStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getMfaDeviceManagementForIdentityStoreRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/mfa-devices/management-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getMfaDeviceManagementForIdentityStoreRequest);
            return new AsyncInvoker<GetMfaDeviceManagementForIdentityStoreResponse>(this, "GET", request, JsonUtils.DeSerialize<GetMfaDeviceManagementForIdentityStoreResponse>);
        }
        
        /// <summary>
        /// 设置MFA管理设置信息
        ///
        /// 设置MFA管理设置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PutMfaDeviceManagementForIdentityStoreResponse> PutMfaDeviceManagementForIdentityStoreAsync(PutMfaDeviceManagementForIdentityStoreRequest putMfaDeviceManagementForIdentityStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", putMfaDeviceManagementForIdentityStoreRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/mfa-devices/management-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putMfaDeviceManagementForIdentityStoreRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<PutMfaDeviceManagementForIdentityStoreResponse>(response);
        }

        public AsyncInvoker<PutMfaDeviceManagementForIdentityStoreResponse> PutMfaDeviceManagementForIdentityStoreAsyncInvoker(PutMfaDeviceManagementForIdentityStoreRequest putMfaDeviceManagementForIdentityStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", putMfaDeviceManagementForIdentityStoreRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/mfa-devices/management-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putMfaDeviceManagementForIdentityStoreRequest);
            return new AsyncInvoker<PutMfaDeviceManagementForIdentityStoreResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PutMfaDeviceManagementForIdentityStoreResponse>);
        }
        
        /// <summary>
        /// 添加系统身份策略
        ///
        /// 在指定的权限集中添加系统身份策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachManagedPolicyToPermissionSetResponse> AttachManagedPolicyToPermissionSetAsync(AttachManagedPolicyToPermissionSetRequest attachManagedPolicyToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachManagedPolicyToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", attachManagedPolicyToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/attach-managed-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachManagedPolicyToPermissionSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AttachManagedPolicyToPermissionSetResponse>(response);
        }

        public AsyncInvoker<AttachManagedPolicyToPermissionSetResponse> AttachManagedPolicyToPermissionSetAsyncInvoker(AttachManagedPolicyToPermissionSetRequest attachManagedPolicyToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachManagedPolicyToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", attachManagedPolicyToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/attach-managed-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachManagedPolicyToPermissionSetRequest);
            return new AsyncInvoker<AttachManagedPolicyToPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AttachManagedPolicyToPermissionSetResponse>);
        }
        
        /// <summary>
        /// 附加系统策略到权限集
        ///
        /// 将系统策略附加到权限集。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachManagedRoleToPermissionSetResponse> AttachManagedRoleToPermissionSetAsync(AttachManagedRoleToPermissionSetRequest attachManagedRoleToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachManagedRoleToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", attachManagedRoleToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/attach-managed-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachManagedRoleToPermissionSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AttachManagedRoleToPermissionSetResponse>(response);
        }

        public AsyncInvoker<AttachManagedRoleToPermissionSetResponse> AttachManagedRoleToPermissionSetAsyncInvoker(AttachManagedRoleToPermissionSetRequest attachManagedRoleToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachManagedRoleToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", attachManagedRoleToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/attach-managed-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachManagedRoleToPermissionSetRequest);
            return new AsyncInvoker<AttachManagedRoleToPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AttachManagedRoleToPermissionSetResponse>);
        }
        
        /// <summary>
        /// 创建权限集
        ///
        /// 在指定的IAM Identity Center实例中创建一个权限集。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePermissionSetResponse> CreatePermissionSetAsync(CreatePermissionSetRequest createPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createPermissionSetRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPermissionSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePermissionSetResponse>(response);
        }

        public AsyncInvoker<CreatePermissionSetResponse> CreatePermissionSetAsyncInvoker(CreatePermissionSetRequest createPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createPermissionSetRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPermissionSetRequest);
            return new AsyncInvoker<CreatePermissionSetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePermissionSetResponse>);
        }
        
        /// <summary>
        /// 删除指定权限集中的自定义身份策略
        ///
        /// 删除指定权限集中的自定义身份策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCustomPolicyFromPermissionSetResponse> DeleteCustomPolicyFromPermissionSetAsync(DeleteCustomPolicyFromPermissionSetRequest deleteCustomPolicyFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteCustomPolicyFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", deleteCustomPolicyFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomPolicyFromPermissionSetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCustomPolicyFromPermissionSetResponse>(response);
        }

        public AsyncInvoker<DeleteCustomPolicyFromPermissionSetResponse> DeleteCustomPolicyFromPermissionSetAsyncInvoker(DeleteCustomPolicyFromPermissionSetRequest deleteCustomPolicyFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteCustomPolicyFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", deleteCustomPolicyFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomPolicyFromPermissionSetRequest);
            return new AsyncInvoker<DeleteCustomPolicyFromPermissionSetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCustomPolicyFromPermissionSetResponse>);
        }
        
        /// <summary>
        /// 删除指定权限集中的自定义策略
        ///
        /// 删除指定权限集中的自定义策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCustomRoleFromPermissionSetResponse> DeleteCustomRoleFromPermissionSetAsync(DeleteCustomRoleFromPermissionSetRequest deleteCustomRoleFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteCustomRoleFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", deleteCustomRoleFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomRoleFromPermissionSetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCustomRoleFromPermissionSetResponse>(response);
        }

        public AsyncInvoker<DeleteCustomRoleFromPermissionSetResponse> DeleteCustomRoleFromPermissionSetAsyncInvoker(DeleteCustomRoleFromPermissionSetRequest deleteCustomRoleFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteCustomRoleFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", deleteCustomRoleFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomRoleFromPermissionSetRequest);
            return new AsyncInvoker<DeleteCustomRoleFromPermissionSetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCustomRoleFromPermissionSetResponse>);
        }
        
        /// <summary>
        /// 删除权限集
        ///
        /// 根据权限集ID，删除指定的权限集。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePermissionSetResponse> DeletePermissionSetAsync(DeletePermissionSetRequest deletePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deletePermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", deletePermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePermissionSetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePermissionSetResponse>(response);
        }

        public AsyncInvoker<DeletePermissionSetResponse> DeletePermissionSetAsyncInvoker(DeletePermissionSetRequest deletePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deletePermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", deletePermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePermissionSetRequest);
            return new AsyncInvoker<DeletePermissionSetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePermissionSetResponse>);
        }
        
        /// <summary>
        /// 查询权限集详情
        ///
        /// 根据权限集ID，查询指定权限集的详情信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribePermissionSetResponse> DescribePermissionSetAsync(DescribePermissionSetRequest describePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describePermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", describePermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePermissionSetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribePermissionSetResponse>(response);
        }

        public AsyncInvoker<DescribePermissionSetResponse> DescribePermissionSetAsyncInvoker(DescribePermissionSetRequest describePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describePermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", describePermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePermissionSetRequest);
            return new AsyncInvoker<DescribePermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribePermissionSetResponse>);
        }
        
        /// <summary>
        /// 查询权限集预分配状态详情
        ///
        /// 根据请求Id，查询权限集预分配状态的详情信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DescribePermissionSetProvisioningStatusResponse> DescribePermissionSetProvisioningStatusAsync(DescribePermissionSetProvisioningStatusRequest describePermissionSetProvisioningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describePermissionSetProvisioningStatusRequest.InstanceId.ToString());
            urlParam.Add("request_id", describePermissionSetProvisioningStatusRequest.RequestId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioning-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePermissionSetProvisioningStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DescribePermissionSetProvisioningStatusResponse>(response);
        }

        public AsyncInvoker<DescribePermissionSetProvisioningStatusResponse> DescribePermissionSetProvisioningStatusAsyncInvoker(DescribePermissionSetProvisioningStatusRequest describePermissionSetProvisioningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describePermissionSetProvisioningStatusRequest.InstanceId.ToString());
            urlParam.Add("request_id", describePermissionSetProvisioningStatusRequest.RequestId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioning-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePermissionSetProvisioningStatusRequest);
            return new AsyncInvoker<DescribePermissionSetProvisioningStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribePermissionSetProvisioningStatusResponse>);
        }
        
        /// <summary>
        /// 从权限集分离系统身份策略
        ///
        /// 将附加的系统身份策略从指定的权限集中分离。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetachManagedPolicyFromPermissionSetResponse> DetachManagedPolicyFromPermissionSetAsync(DetachManagedPolicyFromPermissionSetRequest detachManagedPolicyFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", detachManagedPolicyFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", detachManagedPolicyFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/detach-managed-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachManagedPolicyFromPermissionSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DetachManagedPolicyFromPermissionSetResponse>(response);
        }

        public AsyncInvoker<DetachManagedPolicyFromPermissionSetResponse> DetachManagedPolicyFromPermissionSetAsyncInvoker(DetachManagedPolicyFromPermissionSetRequest detachManagedPolicyFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", detachManagedPolicyFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", detachManagedPolicyFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/detach-managed-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachManagedPolicyFromPermissionSetRequest);
            return new AsyncInvoker<DetachManagedPolicyFromPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DetachManagedPolicyFromPermissionSetResponse>);
        }
        
        /// <summary>
        /// 从权限集分离系统策略
        ///
        /// 将附加的系统策略从指定的权限集中分离。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetachManagedRoleFromPermissionSetResponse> DetachManagedRoleFromPermissionSetAsync(DetachManagedRoleFromPermissionSetRequest detachManagedRoleFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", detachManagedRoleFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", detachManagedRoleFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/detach-managed-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachManagedRoleFromPermissionSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DetachManagedRoleFromPermissionSetResponse>(response);
        }

        public AsyncInvoker<DetachManagedRoleFromPermissionSetResponse> DetachManagedRoleFromPermissionSetAsyncInvoker(DetachManagedRoleFromPermissionSetRequest detachManagedRoleFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", detachManagedRoleFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", detachManagedRoleFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/detach-managed-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachManagedRoleFromPermissionSetRequest);
            return new AsyncInvoker<DetachManagedRoleFromPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DetachManagedRoleFromPermissionSetResponse>);
        }
        
        /// <summary>
        /// 获取分配给权限集的自定义身份策略
        ///
        /// 获取分配给权限集的自定义身份策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetCustomPolicyForPermissionSetResponse> GetCustomPolicyForPermissionSetAsync(GetCustomPolicyForPermissionSetRequest getCustomPolicyForPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getCustomPolicyForPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", getCustomPolicyForPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCustomPolicyForPermissionSetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetCustomPolicyForPermissionSetResponse>(response);
        }

        public AsyncInvoker<GetCustomPolicyForPermissionSetResponse> GetCustomPolicyForPermissionSetAsyncInvoker(GetCustomPolicyForPermissionSetRequest getCustomPolicyForPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getCustomPolicyForPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", getCustomPolicyForPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCustomPolicyForPermissionSetRequest);
            return new AsyncInvoker<GetCustomPolicyForPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<GetCustomPolicyForPermissionSetResponse>);
        }
        
        /// <summary>
        /// 获取分配给权限集的自定义策略
        ///
        /// 获取分配给权限集的自定义策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetCustomRoleForPermissionSetResponse> GetCustomRoleForPermissionSetAsync(GetCustomRoleForPermissionSetRequest getCustomRoleForPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getCustomRoleForPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", getCustomRoleForPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCustomRoleForPermissionSetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetCustomRoleForPermissionSetResponse>(response);
        }

        public AsyncInvoker<GetCustomRoleForPermissionSetResponse> GetCustomRoleForPermissionSetAsyncInvoker(GetCustomRoleForPermissionSetRequest getCustomRoleForPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getCustomRoleForPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", getCustomRoleForPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCustomRoleForPermissionSetRequest);
            return new AsyncInvoker<GetCustomRoleForPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<GetCustomRoleForPermissionSetResponse>);
        }
        
        /// <summary>
        /// 查询权限集配额信息
        ///
        /// 查询权限集配额信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetPermissionSetSummaryResponse> GetPermissionSetSummaryAsync(GetPermissionSetSummaryRequest getPermissionSetSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getPermissionSetSummaryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-set-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getPermissionSetSummaryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetPermissionSetSummaryResponse>(response);
        }

        public AsyncInvoker<GetPermissionSetSummaryResponse> GetPermissionSetSummaryAsyncInvoker(GetPermissionSetSummaryRequest getPermissionSetSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getPermissionSetSummaryRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-set-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getPermissionSetSummaryRequest);
            return new AsyncInvoker<GetPermissionSetSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<GetPermissionSetSummaryResponse>);
        }
        
        /// <summary>
        /// 列出权限集关联的账号
        ///
        /// 查询与指定权限集关联的账户列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccountsForProvisionedPermissionSetResponse> ListAccountsForProvisionedPermissionSetAsync(ListAccountsForProvisionedPermissionSetRequest listAccountsForProvisionedPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountsForProvisionedPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", listAccountsForProvisionedPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsForProvisionedPermissionSetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccountsForProvisionedPermissionSetResponse>(response);
        }

        public AsyncInvoker<ListAccountsForProvisionedPermissionSetResponse> ListAccountsForProvisionedPermissionSetAsyncInvoker(ListAccountsForProvisionedPermissionSetRequest listAccountsForProvisionedPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountsForProvisionedPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", listAccountsForProvisionedPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsForProvisionedPermissionSetRequest);
            return new AsyncInvoker<ListAccountsForProvisionedPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountsForProvisionedPermissionSetResponse>);
        }
        
        /// <summary>
        /// 列出权限集中附加的系统身份策略
        ///
        /// 获取附加到指定权限集的系统身份策略列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListManagedPoliciesInPermissionSetResponse> ListManagedPoliciesInPermissionSetAsync(ListManagedPoliciesInPermissionSetRequest listManagedPoliciesInPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listManagedPoliciesInPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", listManagedPoliciesInPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/managed-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedPoliciesInPermissionSetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListManagedPoliciesInPermissionSetResponse>(response);
        }

        public AsyncInvoker<ListManagedPoliciesInPermissionSetResponse> ListManagedPoliciesInPermissionSetAsyncInvoker(ListManagedPoliciesInPermissionSetRequest listManagedPoliciesInPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listManagedPoliciesInPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", listManagedPoliciesInPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/managed-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedPoliciesInPermissionSetRequest);
            return new AsyncInvoker<ListManagedPoliciesInPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListManagedPoliciesInPermissionSetResponse>);
        }
        
        /// <summary>
        /// 列出权限集中附加的系统策略
        ///
        /// 获取附加到指定权限集的系统策略列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListManagedRolesInPermissionSetResponse> ListManagedRolesInPermissionSetAsync(ListManagedRolesInPermissionSetRequest listManagedRolesInPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listManagedRolesInPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", listManagedRolesInPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/managed-roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedRolesInPermissionSetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListManagedRolesInPermissionSetResponse>(response);
        }

        public AsyncInvoker<ListManagedRolesInPermissionSetResponse> ListManagedRolesInPermissionSetAsyncInvoker(ListManagedRolesInPermissionSetRequest listManagedRolesInPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listManagedRolesInPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", listManagedRolesInPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/managed-roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedRolesInPermissionSetRequest);
            return new AsyncInvoker<ListManagedRolesInPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListManagedRolesInPermissionSetResponse>);
        }
        
        /// <summary>
        /// 列出权限集预分配状态
        ///
        /// 查询指定实例中的权限集预分配状态列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPermissionSetProvisioningStatusResponse> ListPermissionSetProvisioningStatusAsync(ListPermissionSetProvisioningStatusRequest listPermissionSetProvisioningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPermissionSetProvisioningStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioning-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetProvisioningStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionSetProvisioningStatusResponse>(response);
        }

        public AsyncInvoker<ListPermissionSetProvisioningStatusResponse> ListPermissionSetProvisioningStatusAsyncInvoker(ListPermissionSetProvisioningStatusRequest listPermissionSetProvisioningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPermissionSetProvisioningStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioning-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetProvisioningStatusRequest);
            return new AsyncInvoker<ListPermissionSetProvisioningStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionSetProvisioningStatusResponse>);
        }
        
        /// <summary>
        /// 列出权限集
        ///
        /// 查询指定实例下的权限集列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPermissionSetsResponse> ListPermissionSetsAsync(ListPermissionSetsRequest listPermissionSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPermissionSetsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionSetsResponse>(response);
        }

        public AsyncInvoker<ListPermissionSetsResponse> ListPermissionSetsAsyncInvoker(ListPermissionSetsRequest listPermissionSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPermissionSetsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetsRequest);
            return new AsyncInvoker<ListPermissionSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionSetsResponse>);
        }
        
        /// <summary>
        /// 列出分配给账户的权限集
        ///
        /// 查询分配给指定账户的权限集列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPermissionSetsProvisionedToAccountResponse> ListPermissionSetsProvisionedToAccountAsync(ListPermissionSetsProvisionedToAccountRequest listPermissionSetsProvisionedToAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPermissionSetsProvisionedToAccountRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioned-to-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetsProvisionedToAccountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionSetsProvisionedToAccountResponse>(response);
        }

        public AsyncInvoker<ListPermissionSetsProvisionedToAccountResponse> ListPermissionSetsProvisionedToAccountAsyncInvoker(ListPermissionSetsProvisionedToAccountRequest listPermissionSetsProvisionedToAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPermissionSetsProvisionedToAccountRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioned-to-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetsProvisionedToAccountRequest);
            return new AsyncInvoker<ListPermissionSetsProvisionedToAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionSetsProvisionedToAccountResponse>);
        }
        
        /// <summary>
        /// 预分配权限集
        ///
        /// 将指定权限集预分配给指定账户。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ProvisionPermissionSetResponse> ProvisionPermissionSetAsync(ProvisionPermissionSetRequest provisionPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", provisionPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", provisionPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/provision", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", provisionPermissionSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ProvisionPermissionSetResponse>(response);
        }

        public AsyncInvoker<ProvisionPermissionSetResponse> ProvisionPermissionSetAsyncInvoker(ProvisionPermissionSetRequest provisionPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", provisionPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", provisionPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/provision", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", provisionPermissionSetRequest);
            return new AsyncInvoker<ProvisionPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerialize<ProvisionPermissionSetResponse>);
        }
        
        /// <summary>
        /// 将自定义身份策略附加到权限集
        ///
        /// 将自定义身份策略附加到权限集。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PutCustomPolicyToPermissionSetResponse> PutCustomPolicyToPermissionSetAsync(PutCustomPolicyToPermissionSetRequest putCustomPolicyToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", putCustomPolicyToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", putCustomPolicyToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putCustomPolicyToPermissionSetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<PutCustomPolicyToPermissionSetResponse>(response);
        }

        public AsyncInvoker<PutCustomPolicyToPermissionSetResponse> PutCustomPolicyToPermissionSetAsyncInvoker(PutCustomPolicyToPermissionSetRequest putCustomPolicyToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", putCustomPolicyToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", putCustomPolicyToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putCustomPolicyToPermissionSetRequest);
            return new AsyncInvoker<PutCustomPolicyToPermissionSetResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<PutCustomPolicyToPermissionSetResponse>);
        }
        
        /// <summary>
        /// 将自定义策略附加到权限集
        ///
        /// 将自定义策略附加到权限集。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PutCustomRoleToPermissionSetResponse> PutCustomRoleToPermissionSetAsync(PutCustomRoleToPermissionSetRequest putCustomRoleToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", putCustomRoleToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", putCustomRoleToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putCustomRoleToPermissionSetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<PutCustomRoleToPermissionSetResponse>(response);
        }

        public AsyncInvoker<PutCustomRoleToPermissionSetResponse> PutCustomRoleToPermissionSetAsyncInvoker(PutCustomRoleToPermissionSetRequest putCustomRoleToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", putCustomRoleToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", putCustomRoleToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putCustomRoleToPermissionSetRequest);
            return new AsyncInvoker<PutCustomRoleToPermissionSetResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<PutCustomRoleToPermissionSetResponse>);
        }
        
        /// <summary>
        /// 更新权限集
        ///
        /// 根据权限集ID，更新指定权限集的属性。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePermissionSetResponse> UpdatePermissionSetAsync(UpdatePermissionSetRequest updatePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", updatePermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePermissionSetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePermissionSetResponse>(response);
        }

        public AsyncInvoker<UpdatePermissionSetResponse> UpdatePermissionSetAsyncInvoker(UpdatePermissionSetRequest updatePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", updatePermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePermissionSetRequest);
            return new AsyncInvoker<UpdatePermissionSetResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePermissionSetResponse>);
        }
        
        /// <summary>
        /// 为指定资源添加标签
        ///
        /// 向指定的资源添加一个或多个标签。目前，您可以将标签附加到实例中的权限集。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTagResourceResponse> CreateTagResourceAsync(CreateTagResourceRequest createTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagResourceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagResourceResponse>(response);
        }

        public AsyncInvoker<CreateTagResourceResponse> CreateTagResourceAsyncInvoker(CreateTagResourceRequest createTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagResourceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagResourceRequest);
            return new AsyncInvoker<CreateTagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagResourceResponse>);
        }
        
        /// <summary>
        /// 从指定资源中删除指定主键标签
        ///
        /// 从指定资源中删除具有指定主键的任何标签。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTagResourceResponse> DeleteTagResourceAsync(DeleteTagResourceRequest deleteTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteTagResourceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteTagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteTagResourceResponse>(response);
        }

        public AsyncInvoker<DeleteTagResourceResponse> DeleteTagResourceAsyncInvoker(DeleteTagResourceRequest deleteTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteTagResourceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteTagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagResourceRequest);
            return new AsyncInvoker<DeleteTagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteTagResourceResponse>);
        }
        
        /// <summary>
        /// 列出绑定到指定资源的标签
        ///
        /// 列出绑定到指定资源的标签。您可以将标签附加到实例中的权限集。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest listTagResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagResourcesRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listTagResourcesRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagResourcesResponse>(response);
        }

        public AsyncInvoker<ListTagResourcesResponse> ListTagResourcesAsyncInvoker(ListTagResourcesRequest listTagResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagResourcesRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listTagResourcesRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagResourcesRequest);
            return new AsyncInvoker<ListTagResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagResourcesResponse>);
        }
        
    }
}