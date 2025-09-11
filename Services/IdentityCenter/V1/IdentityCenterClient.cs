using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.IdentityCenter.V1.Model;

namespace HuaweiCloud.SDK.IdentityCenter.V1
{
    public partial class IdentityCenterClient : Client
    {
        public static ClientBuilder<IdentityCenterClient> NewBuilder()
        {
            return new ClientBuilder<IdentityCenterClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 创建账户分配
        ///
        /// 使用指定的权限集为指定账户分配对应主体的访问权限，主体可为IdentityCenter用户或IdentityCenter用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAccountAssignmentResponse CreateAccountAssignment(CreateAccountAssignmentRequest createAccountAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAccountAssignmentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccountAssignmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAccountAssignmentResponse>(response);
        }

        public SyncInvoker<CreateAccountAssignmentResponse> CreateAccountAssignmentInvoker(CreateAccountAssignmentRequest createAccountAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAccountAssignmentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccountAssignmentRequest);
            return new SyncInvoker<CreateAccountAssignmentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccountAssignmentResponse>);
        }
        
        /// <summary>
        /// 删除账号分配
        ///
        /// 使用指定的权限集从指定的账号删除主体的访问权限，主体可为IAM身份中心用户或用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAccountAssignmentResponse DeleteAccountAssignment(DeleteAccountAssignmentRequest deleteAccountAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAccountAssignmentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccountAssignmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteAccountAssignmentResponse>(response);
        }

        public SyncInvoker<DeleteAccountAssignmentResponse> DeleteAccountAssignmentInvoker(DeleteAccountAssignmentRequest deleteAccountAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAccountAssignmentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccountAssignmentRequest);
            return new SyncInvoker<DeleteAccountAssignmentResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteAccountAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询账户分配创建状态详情
        ///
        /// 根据请求ID，查询指定IAM Identity Center实例下的账户分配创建状态详情信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeAccountAssignmentCreationStatusResponse DescribeAccountAssignmentCreationStatus(DescribeAccountAssignmentCreationStatusRequest describeAccountAssignmentCreationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeAccountAssignmentCreationStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(describeAccountAssignmentCreationStatusRequest.RequestId, out var valueOfRequestId)) urlParam.Add("request_id", valueOfRequestId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/creation-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeAccountAssignmentCreationStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribeAccountAssignmentCreationStatusResponse>(response);
        }

        public SyncInvoker<DescribeAccountAssignmentCreationStatusResponse> DescribeAccountAssignmentCreationStatusInvoker(DescribeAccountAssignmentCreationStatusRequest describeAccountAssignmentCreationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeAccountAssignmentCreationStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(describeAccountAssignmentCreationStatusRequest.RequestId, out var valueOfRequestId)) urlParam.Add("request_id", valueOfRequestId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/creation-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeAccountAssignmentCreationStatusRequest);
            return new SyncInvoker<DescribeAccountAssignmentCreationStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeAccountAssignmentCreationStatusResponse>);
        }
        
        /// <summary>
        /// 查询账户分配删除状态详情
        ///
        /// 根据请求ID，查询指定IAM Identity Center实例下的账户分配删除状态详情信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeAccountAssignmentDeletionStatusResponse DescribeAccountAssignmentDeletionStatus(DescribeAccountAssignmentDeletionStatusRequest describeAccountAssignmentDeletionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeAccountAssignmentDeletionStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(describeAccountAssignmentDeletionStatusRequest.RequestId, out var valueOfRequestId)) urlParam.Add("request_id", valueOfRequestId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/deletion-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeAccountAssignmentDeletionStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribeAccountAssignmentDeletionStatusResponse>(response);
        }

        public SyncInvoker<DescribeAccountAssignmentDeletionStatusResponse> DescribeAccountAssignmentDeletionStatusInvoker(DescribeAccountAssignmentDeletionStatusRequest describeAccountAssignmentDeletionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeAccountAssignmentDeletionStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(describeAccountAssignmentDeletionStatusRequest.RequestId, out var valueOfRequestId)) urlParam.Add("request_id", valueOfRequestId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/deletion-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeAccountAssignmentDeletionStatusRequest);
            return new SyncInvoker<DescribeAccountAssignmentDeletionStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeAccountAssignmentDeletionStatusResponse>);
        }
        
        /// <summary>
        /// 解除与用户或组绑定的所有账号授权关联
        ///
        /// 解除与用户或组绑定的所有账号授权关联。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateProfileResponse DisassociateProfile(DisassociateProfileRequest disassociateProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateProfileRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/disassociate-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateProfileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisassociateProfileResponse>(response);
        }

        public SyncInvoker<DisassociateProfileResponse> DisassociateProfileInvoker(DisassociateProfileRequest disassociateProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateProfileRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/disassociate-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateProfileRequest);
            return new SyncInvoker<DisassociateProfileResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisassociateProfileResponse>);
        }
        
        /// <summary>
        /// 列出账户分配创建状态
        ///
        /// 查询指定IAM Identity Center实例下的账户分配的创建状态列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccountAssignmentCreationStatusResponse ListAccountAssignmentCreationStatus(ListAccountAssignmentCreationStatusRequest listAccountAssignmentCreationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccountAssignmentCreationStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/creation-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentCreationStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccountAssignmentCreationStatusResponse>(response);
        }

        public SyncInvoker<ListAccountAssignmentCreationStatusResponse> ListAccountAssignmentCreationStatusInvoker(ListAccountAssignmentCreationStatusRequest listAccountAssignmentCreationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccountAssignmentCreationStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/creation-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentCreationStatusRequest);
            return new SyncInvoker<ListAccountAssignmentCreationStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountAssignmentCreationStatusResponse>);
        }
        
        /// <summary>
        /// 列出账户分配删除状态
        ///
        /// 查询指定IAM Identity Center实例下的账户分配的删除状态列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccountAssignmentDeletionStatusResponse ListAccountAssignmentDeletionStatus(ListAccountAssignmentDeletionStatusRequest listAccountAssignmentDeletionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccountAssignmentDeletionStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/deletion-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentDeletionStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccountAssignmentDeletionStatusResponse>(response);
        }

        public SyncInvoker<ListAccountAssignmentDeletionStatusResponse> ListAccountAssignmentDeletionStatusInvoker(ListAccountAssignmentDeletionStatusRequest listAccountAssignmentDeletionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccountAssignmentDeletionStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/deletion-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentDeletionStatusRequest);
            return new SyncInvoker<ListAccountAssignmentDeletionStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountAssignmentDeletionStatusResponse>);
        }
        
        /// <summary>
        /// 列出账户和权限集关联的用户或用户组
        ///
        /// 列出与指定账户以及指定权限集关联的用户或用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccountAssignmentsResponse ListAccountAssignments(ListAccountAssignmentsRequest listAccountAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccountAssignmentsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccountAssignmentsResponse>(response);
        }

        public SyncInvoker<ListAccountAssignmentsResponse> ListAccountAssignmentsInvoker(ListAccountAssignmentsRequest listAccountAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccountAssignmentsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentsRequest);
            return new SyncInvoker<ListAccountAssignmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountAssignmentsResponse>);
        }
        
        /// <summary>
        /// 检索与用户或用户组关联的账号列表
        ///
        /// 检索与用户或用户组关联的账号列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccountAssignmentsForPrincipalResponse ListAccountAssignmentsForPrincipal(ListAccountAssignmentsForPrincipalRequest listAccountAssignmentsForPrincipalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccountAssignmentsForPrincipalRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments-for-principals", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentsForPrincipalRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccountAssignmentsForPrincipalResponse>(response);
        }

        public SyncInvoker<ListAccountAssignmentsForPrincipalResponse> ListAccountAssignmentsForPrincipalInvoker(ListAccountAssignmentsForPrincipalRequest listAccountAssignmentsForPrincipalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccountAssignmentsForPrincipalRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments-for-principals", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentsForPrincipalRequest);
            return new SyncInvoker<ListAccountAssignmentsForPrincipalResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountAssignmentsForPrincipalResponse>);
        }
        
        /// <summary>
        /// 创建应用程序实例
        ///
        /// 创建应用程序实例。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateApplicationInstanceResponse CreateApplicationInstance(CreateApplicationInstanceRequest createApplicationInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createApplicationInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createApplicationInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateApplicationInstanceResponse>(response);
        }

        public SyncInvoker<CreateApplicationInstanceResponse> CreateApplicationInstanceInvoker(CreateApplicationInstanceRequest createApplicationInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createApplicationInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createApplicationInstanceRequest);
            return new SyncInvoker<CreateApplicationInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateApplicationInstanceResponse>);
        }
        
        /// <summary>
        /// 删除应用程序实例
        ///
        /// 删除应用程序实例。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteApplicationInstanceResponse DeleteApplicationInstance(DeleteApplicationInstanceRequest deleteApplicationInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationInstanceRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteApplicationInstanceResponse>(response);
        }

        public SyncInvoker<DeleteApplicationInstanceResponse> DeleteApplicationInstanceInvoker(DeleteApplicationInstanceRequest deleteApplicationInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationInstanceRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationInstanceRequest);
            return new SyncInvoker<DeleteApplicationInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteApplicationInstanceResponse>);
        }
        
        /// <summary>
        /// 删除应用程序实例与用户或用户组关联关系
        ///
        /// 删除应用程序实例与用户或用户组关联关系。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteProfileResponse DeleteProfile(DeleteProfileRequest deleteProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProfileRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteProfileRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteProfileRequest.ProfileId, out var valueOfProfileId)) urlParam.Add("profile_id", valueOfProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/profiles/{profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProfileRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteProfileResponse>(response);
        }

        public SyncInvoker<DeleteProfileResponse> DeleteProfileInvoker(DeleteProfileRequest deleteProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProfileRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteProfileRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteProfileRequest.ProfileId, out var valueOfProfileId)) urlParam.Add("profile_id", valueOfProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/profiles/{profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProfileRequest);
            return new SyncInvoker<DeleteProfileResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProfileResponse>);
        }
        
        /// <summary>
        /// 查询应用程序详情
        ///
        /// 查询应用程序详情。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest describeApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeApplicationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(describeApplicationRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeApplicationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribeApplicationResponse>(response);
        }

        public SyncInvoker<DescribeApplicationResponse> DescribeApplicationInvoker(DescribeApplicationRequest describeApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeApplicationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(describeApplicationRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeApplicationRequest);
            return new SyncInvoker<DescribeApplicationResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeApplicationResponse>);
        }
        
        /// <summary>
        /// 查询应用程序提供者详情
        ///
        /// 查询应用程序提供者详情。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeApplicationProviderResponse DescribeApplicationProvider(DescribeApplicationProviderRequest describeApplicationProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeApplicationProviderRequest.ApplicationProviderId, out var valueOfApplicationProviderId)) urlParam.Add("application_provider_id", valueOfApplicationProviderId);
            var urlPath = HttpUtils.AddUrlPath("/v1/application-providers/{application_provider_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeApplicationProviderRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribeApplicationProviderResponse>(response);
        }

        public SyncInvoker<DescribeApplicationProviderResponse> DescribeApplicationProviderInvoker(DescribeApplicationProviderRequest describeApplicationProviderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeApplicationProviderRequest.ApplicationProviderId, out var valueOfApplicationProviderId)) urlParam.Add("application_provider_id", valueOfApplicationProviderId);
            var urlPath = HttpUtils.AddUrlPath("/v1/application-providers/{application_provider_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeApplicationProviderRequest);
            return new SyncInvoker<DescribeApplicationProviderResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeApplicationProviderResponse>);
        }
        
        /// <summary>
        /// 查询应用程序分配属性配置
        ///
        /// 查询应用程序分配属性配置，目的为用户或者用户组分配对应用程序的访问权限。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetApplicationAssignmentConfigurationResponse GetApplicationAssignmentConfiguration(GetApplicationAssignmentConfigurationRequest getApplicationAssignmentConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getApplicationAssignmentConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(getApplicationAssignmentConfigurationRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getApplicationAssignmentConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetApplicationAssignmentConfigurationResponse>(response);
        }

        public SyncInvoker<GetApplicationAssignmentConfigurationResponse> GetApplicationAssignmentConfigurationInvoker(GetApplicationAssignmentConfigurationRequest getApplicationAssignmentConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getApplicationAssignmentConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(getApplicationAssignmentConfigurationRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getApplicationAssignmentConfigurationRequest);
            return new SyncInvoker<GetApplicationAssignmentConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<GetApplicationAssignmentConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询应用程序实例详情
        ///
        /// 查询应用程序实例详情。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetApplicationInstanceResponse GetApplicationInstance(GetApplicationInstanceRequest getApplicationInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getApplicationInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(getApplicationInstanceRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getApplicationInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetApplicationInstanceResponse>(response);
        }

        public SyncInvoker<GetApplicationInstanceResponse> GetApplicationInstanceInvoker(GetApplicationInstanceRequest getApplicationInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getApplicationInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(getApplicationInstanceRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getApplicationInstanceRequest);
            return new SyncInvoker<GetApplicationInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<GetApplicationInstanceResponse>);
        }
        
        /// <summary>
        /// 上传应用程序实例元数据文件
        ///
        /// 上传应用程序实例元数据文件。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportApplicationInstanceServiceProviderMetadataResponse ImportApplicationInstanceServiceProviderMetadata(ImportApplicationInstanceServiceProviderMetadataRequest importApplicationInstanceServiceProviderMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(importApplicationInstanceServiceProviderMetadataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(importApplicationInstanceServiceProviderMetadataRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importApplicationInstanceServiceProviderMetadataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ImportApplicationInstanceServiceProviderMetadataResponse>(response);
        }

        public SyncInvoker<ImportApplicationInstanceServiceProviderMetadataResponse> ImportApplicationInstanceServiceProviderMetadataInvoker(ImportApplicationInstanceServiceProviderMetadataRequest importApplicationInstanceServiceProviderMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(importApplicationInstanceServiceProviderMetadataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(importApplicationInstanceServiceProviderMetadataRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importApplicationInstanceServiceProviderMetadataRequest);
            return new SyncInvoker<ImportApplicationInstanceServiceProviderMetadataResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ImportApplicationInstanceServiceProviderMetadataResponse>);
        }
        
        /// <summary>
        /// 列出应用程序实例
        ///
        /// 列出应用程序实例。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApplicationInstancesResponse ListApplicationInstances(ListApplicationInstancesRequest listApplicationInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationInstancesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationInstancesResponse>(response);
        }

        public SyncInvoker<ListApplicationInstancesResponse> ListApplicationInstancesInvoker(ListApplicationInstancesRequest listApplicationInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationInstancesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationInstancesRequest);
            return new SyncInvoker<ListApplicationInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationInstancesResponse>);
        }
        
        /// <summary>
        /// 列出应用程序提供者
        ///
        /// 查询应用程序提供者列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApplicationProvidersResponse ListApplicationProviders(ListApplicationProvidersRequest listApplicationProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/application-providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationProvidersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationProvidersResponse>(response);
        }

        public SyncInvoker<ListApplicationProvidersResponse> ListApplicationProvidersInvoker(ListApplicationProvidersRequest listApplicationProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/application-providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationProvidersRequest);
            return new SyncInvoker<ListApplicationProvidersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationProvidersResponse>);
        }
        
        /// <summary>
        /// 列出应用程序模板
        ///
        /// 查询应用程序模板列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApplicationTemplatesResponse ListApplicationTemplates(ListApplicationTemplatesRequest listApplicationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/application-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationTemplatesResponse>(response);
        }

        public SyncInvoker<ListApplicationTemplatesResponse> ListApplicationTemplatesInvoker(ListApplicationTemplatesRequest listApplicationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/application-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationTemplatesRequest);
            return new SyncInvoker<ListApplicationTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationTemplatesResponse>);
        }
        
        /// <summary>
        /// 列出应用程序
        ///
        /// 查询应用程序列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApplicationsResponse ListApplications(ListApplicationsRequest listApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationsResponse>(response);
        }

        public SyncInvoker<ListApplicationsResponse> ListApplicationsInvoker(ListApplicationsRequest listApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationsRequest);
            return new SyncInvoker<ListApplicationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationsResponse>);
        }
        
        /// <summary>
        /// 列出应用程序目录中的预置应用模板
        ///
        /// 列出应用程序目录中的预置应用模板。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCatalogApplicationsResponse ListCatalogApplications(ListCatalogApplicationsRequest listCatalogApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/catalog/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCatalogApplicationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCatalogApplicationsResponse>(response);
        }

        public SyncInvoker<ListCatalogApplicationsResponse> ListCatalogApplicationsInvoker(ListCatalogApplicationsRequest listCatalogApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/catalog/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCatalogApplicationsRequest);
            return new SyncInvoker<ListCatalogApplicationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCatalogApplicationsResponse>);
        }
        
        /// <summary>
        /// 列出应用程序实例与用户或用户组存在的关联关系
        ///
        /// 列出应用程序实例与用户或用户组存在的关联关系。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProfilesResponse ListProfiles(ListProfilesRequest listProfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProfilesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listProfilesRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProfilesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProfilesResponse>(response);
        }

        public SyncInvoker<ListProfilesResponse> ListProfilesInvoker(ListProfilesRequest listProfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProfilesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listProfilesRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProfilesRequest);
            return new SyncInvoker<ListProfilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProfilesResponse>);
        }
        
        /// <summary>
        /// 更新应用程序实例显示信息
        ///
        /// 更新应用程序实例显示信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateApplicationInstanceDisplayDataResponse UpdateApplicationInstanceDisplayData(UpdateApplicationInstanceDisplayDataRequest updateApplicationInstanceDisplayDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceDisplayDataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceDisplayDataRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/display-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceDisplayDataRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateApplicationInstanceDisplayDataResponse>(response);
        }

        public SyncInvoker<UpdateApplicationInstanceDisplayDataResponse> UpdateApplicationInstanceDisplayDataInvoker(UpdateApplicationInstanceDisplayDataRequest updateApplicationInstanceDisplayDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceDisplayDataRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceDisplayDataRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/display-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceDisplayDataRequest);
            return new SyncInvoker<UpdateApplicationInstanceDisplayDataResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateApplicationInstanceDisplayDataResponse>);
        }
        
        /// <summary>
        /// 更新应用程序属性配置
        ///
        /// 更新应用程序属性配置信息，更新应用程序中的属性映射、中继状态以及会话过期时间。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateApplicationInstanceResponseConfigurationResponse UpdateApplicationInstanceResponseConfiguration(UpdateApplicationInstanceResponseConfigurationRequest updateApplicationInstanceResponseConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceResponseConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceResponseConfigurationRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/response-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceResponseConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateApplicationInstanceResponseConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateApplicationInstanceResponseConfigurationResponse> UpdateApplicationInstanceResponseConfigurationInvoker(UpdateApplicationInstanceResponseConfigurationRequest updateApplicationInstanceResponseConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceResponseConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceResponseConfigurationRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/response-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceResponseConfigurationRequest);
            return new SyncInvoker<UpdateApplicationInstanceResponseConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateApplicationInstanceResponseConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新应用程序Schema属性映射配置
        ///
        /// 更新应用程序Schema属性映射配置，支持SAML断言中Subject属性映射以及Subject NameID格式。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateApplicationInstanceResponseSchemaConfigurationResponse UpdateApplicationInstanceResponseSchemaConfiguration(UpdateApplicationInstanceResponseSchemaConfigurationRequest updateApplicationInstanceResponseSchemaConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceResponseSchemaConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceResponseSchemaConfigurationRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/response-schema-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceResponseSchemaConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateApplicationInstanceResponseSchemaConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateApplicationInstanceResponseSchemaConfigurationResponse> UpdateApplicationInstanceResponseSchemaConfigurationInvoker(UpdateApplicationInstanceResponseSchemaConfigurationRequest updateApplicationInstanceResponseSchemaConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceResponseSchemaConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceResponseSchemaConfigurationRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/response-schema-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceResponseSchemaConfigurationRequest);
            return new SyncInvoker<UpdateApplicationInstanceResponseSchemaConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateApplicationInstanceResponseSchemaConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新应用程序实例证书配置
        ///
        /// 更新应用程序实例证书配置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateApplicationInstanceSecurityConfigurationResponse UpdateApplicationInstanceSecurityConfiguration(UpdateApplicationInstanceSecurityConfigurationRequest updateApplicationInstanceSecurityConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceSecurityConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceSecurityConfigurationRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/security-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceSecurityConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateApplicationInstanceSecurityConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateApplicationInstanceSecurityConfigurationResponse> UpdateApplicationInstanceSecurityConfigurationInvoker(UpdateApplicationInstanceSecurityConfigurationRequest updateApplicationInstanceSecurityConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceSecurityConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceSecurityConfigurationRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/security-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceSecurityConfigurationRequest);
            return new SyncInvoker<UpdateApplicationInstanceSecurityConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateApplicationInstanceSecurityConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新应用程序实例服务提供商配置
        ///
        /// 更新应用程序实例服务提供商配置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateApplicationInstanceServiceProviderConfigurationResponse UpdateApplicationInstanceServiceProviderConfiguration(UpdateApplicationInstanceServiceProviderConfigurationRequest updateApplicationInstanceServiceProviderConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceServiceProviderConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceServiceProviderConfigurationRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/service-provider-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceServiceProviderConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateApplicationInstanceServiceProviderConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateApplicationInstanceServiceProviderConfigurationResponse> UpdateApplicationInstanceServiceProviderConfigurationInvoker(UpdateApplicationInstanceServiceProviderConfigurationRequest updateApplicationInstanceServiceProviderConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceServiceProviderConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceServiceProviderConfigurationRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/service-provider-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceServiceProviderConfigurationRequest);
            return new SyncInvoker<UpdateApplicationInstanceServiceProviderConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateApplicationInstanceServiceProviderConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新应用程序实例状态
        ///
        /// 更新应用程序实例状态。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateApplicationInstanceStatusResponse UpdateApplicationInstanceStatus(UpdateApplicationInstanceStatusRequest updateApplicationInstanceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceStatusRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateApplicationInstanceStatusResponse>(response);
        }

        public SyncInvoker<UpdateApplicationInstanceStatusResponse> UpdateApplicationInstanceStatusInvoker(UpdateApplicationInstanceStatusRequest updateApplicationInstanceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceStatusRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceStatusRequest);
            return new SyncInvoker<UpdateApplicationInstanceStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateApplicationInstanceStatusResponse>);
        }
        
        /// <summary>
        /// 应用程序分配用户或用户组
        ///
        /// 应用程序分配用户或用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateApplicationAssignmentResponse CreateApplicationAssignment(CreateApplicationAssignmentRequest createApplicationAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createApplicationAssignmentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createApplicationAssignmentRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createApplicationAssignmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateApplicationAssignmentResponse>(response);
        }

        public SyncInvoker<CreateApplicationAssignmentResponse> CreateApplicationAssignmentInvoker(CreateApplicationAssignmentRequest createApplicationAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createApplicationAssignmentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createApplicationAssignmentRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createApplicationAssignmentRequest);
            return new SyncInvoker<CreateApplicationAssignmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateApplicationAssignmentResponse>);
        }
        
        /// <summary>
        /// 删除应用程序已分配用户或用户组
        ///
        /// 删除应用程序已分配用户或用户组。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteApplicationAssignmentResponse DeleteApplicationAssignment(DeleteApplicationAssignmentRequest deleteApplicationAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationAssignmentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationAssignmentRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationAssignmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteApplicationAssignmentResponse>(response);
        }

        public SyncInvoker<DeleteApplicationAssignmentResponse> DeleteApplicationAssignmentInvoker(DeleteApplicationAssignmentRequest deleteApplicationAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationAssignmentRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationAssignmentRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationAssignmentRequest);
            return new SyncInvoker<DeleteApplicationAssignmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteApplicationAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询应用程序已分配的用户或用户组列表
        ///
        /// 查询应用程序已分配的用户或用户组列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApplicationAssignmentsResponse ListApplicationAssignments(ListApplicationAssignmentsRequest listApplicationAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationAssignmentsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listApplicationAssignmentsRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAssignmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationAssignmentsResponse>(response);
        }

        public SyncInvoker<ListApplicationAssignmentsResponse> ListApplicationAssignmentsInvoker(ListApplicationAssignmentsRequest listApplicationAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationAssignmentsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listApplicationAssignmentsRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/applications/{application_instance_id}/assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAssignmentsRequest);
            return new SyncInvoker<ListApplicationAssignmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationAssignmentsResponse>);
        }
        
        /// <summary>
        /// 检索与用户或用户组关联的应用程序列表
        ///
        /// 检索与用户或用户组关联的应用程序列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApplicationAssignmentsForPrincipalResponse ListApplicationAssignmentsForPrincipal(ListApplicationAssignmentsForPrincipalRequest listApplicationAssignmentsForPrincipalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationAssignmentsForPrincipalRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-assignments-for-principals", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAssignmentsForPrincipalRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationAssignmentsForPrincipalResponse>(response);
        }

        public SyncInvoker<ListApplicationAssignmentsForPrincipalResponse> ListApplicationAssignmentsForPrincipalInvoker(ListApplicationAssignmentsForPrincipalRequest listApplicationAssignmentsForPrincipalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationAssignmentsForPrincipalRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-assignments-for-principals", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAssignmentsForPrincipalRequest);
            return new SyncInvoker<ListApplicationAssignmentsForPrincipalResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationAssignmentsForPrincipalResponse>);
        }
        
        /// <summary>
        /// 创建应用程序实例证书
        ///
        /// 创建应用程序实例证书。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateApplicationInstanceCertificateResponse CreateApplicationInstanceCertificate(CreateApplicationInstanceCertificateRequest createApplicationInstanceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createApplicationInstanceCertificateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createApplicationInstanceCertificateRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createApplicationInstanceCertificateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateApplicationInstanceCertificateResponse>(response);
        }

        public SyncInvoker<CreateApplicationInstanceCertificateResponse> CreateApplicationInstanceCertificateInvoker(CreateApplicationInstanceCertificateRequest createApplicationInstanceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createApplicationInstanceCertificateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createApplicationInstanceCertificateRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createApplicationInstanceCertificateRequest);
            return new SyncInvoker<CreateApplicationInstanceCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateApplicationInstanceCertificateResponse>);
        }
        
        /// <summary>
        /// 删除应用程序实例证书
        ///
        /// 删除应用程序实例证书。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteApplicationInstanceCertificateResponse DeleteApplicationInstanceCertificate(DeleteApplicationInstanceCertificateRequest deleteApplicationInstanceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationInstanceCertificateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationInstanceCertificateRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationInstanceCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationInstanceCertificateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteApplicationInstanceCertificateResponse>(response);
        }

        public SyncInvoker<DeleteApplicationInstanceCertificateResponse> DeleteApplicationInstanceCertificateInvoker(DeleteApplicationInstanceCertificateRequest deleteApplicationInstanceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationInstanceCertificateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationInstanceCertificateRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationInstanceCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationInstanceCertificateRequest);
            return new SyncInvoker<DeleteApplicationInstanceCertificateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteApplicationInstanceCertificateResponse>);
        }
        
        /// <summary>
        /// 列出应用程序实例证书
        ///
        /// 查询应用程序实例证书列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApplicationInstanceCertificatesResponse ListApplicationInstanceCertificates(ListApplicationInstanceCertificatesRequest listApplicationInstanceCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationInstanceCertificatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listApplicationInstanceCertificatesRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationInstanceCertificatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationInstanceCertificatesResponse>(response);
        }

        public SyncInvoker<ListApplicationInstanceCertificatesResponse> ListApplicationInstanceCertificatesInvoker(ListApplicationInstanceCertificatesRequest listApplicationInstanceCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationInstanceCertificatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listApplicationInstanceCertificatesRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationInstanceCertificatesRequest);
            return new SyncInvoker<ListApplicationInstanceCertificatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationInstanceCertificatesResponse>);
        }
        
        /// <summary>
        /// 激活应用程序实例证书
        ///
        /// 激活应用程序实例证书，实现证书轮转。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateApplicationInstanceActiveCertificateResponse UpdateApplicationInstanceActiveCertificate(UpdateApplicationInstanceActiveCertificateRequest updateApplicationInstanceActiveCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceActiveCertificateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceActiveCertificateRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceActiveCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceActiveCertificateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateApplicationInstanceActiveCertificateResponse>(response);
        }

        public SyncInvoker<UpdateApplicationInstanceActiveCertificateResponse> UpdateApplicationInstanceActiveCertificateInvoker(UpdateApplicationInstanceActiveCertificateRequest updateApplicationInstanceActiveCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceActiveCertificateRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceActiveCertificateRequest.ApplicationInstanceId, out var valueOfApplicationInstanceId)) urlParam.Add("application_instance_id", valueOfApplicationInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationInstanceActiveCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/application-instances/{application_instance_id}/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationInstanceActiveCertificateRequest);
            return new SyncInvoker<UpdateApplicationInstanceActiveCertificateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateApplicationInstanceActiveCertificateResponse>);
        }
        
        /// <summary>
        /// 查询实例配置信息
        ///
        /// 查询IAM身份中心实例配置信息，包括身份认证配置和会话管理配置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetSsoConfigurationResponse GetSsoConfiguration(GetSsoConfigurationRequest getSsoConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getSsoConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/sso-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getSsoConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetSsoConfigurationResponse>(response);
        }

        public SyncInvoker<GetSsoConfigurationResponse> GetSsoConfigurationInvoker(GetSsoConfigurationRequest getSsoConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getSsoConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/sso-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getSsoConfigurationRequest);
            return new SyncInvoker<GetSsoConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<GetSsoConfigurationResponse>);
        }
        
        /// <summary>
        /// 设置实例配置信息
        ///
        /// 设置IAM身份中心服务实例配置信息，包括身份认证配置和会话管理配置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSsoConfigurationResponse UpdateSsoConfiguration(UpdateSsoConfigurationRequest updateSsoConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSsoConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/sso-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSsoConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateSsoConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateSsoConfigurationResponse> UpdateSsoConfigurationInvoker(UpdateSsoConfigurationRequest updateSsoConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSsoConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/sso-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSsoConfigurationRequest);
            return new SyncInvoker<UpdateSsoConfigurationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateSsoConfigurationResponse>);
        }
        
        /// <summary>
        /// 自定义访问门户URL
        ///
        /// 自定义访问门户URL，默认情况下，您可以使用遵循以下格式的 URL访问门户：idcenter.huaweicloud.com/d-xxxxxxxxxx/portal，您可以按如下方式更改为自定义 URL：idcenter.huaweicloud.com/your_subdomain/portal。设置自定义访问门户URL是一次性操作，无法撤销。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAliasResponse CreateAlias(CreateAliasRequest createAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAliasRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAliasRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateAliasResponse>(response);
        }

        public SyncInvoker<CreateAliasResponse> CreateAliasInvoker(CreateAliasRequest createAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAliasRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/alias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAliasRequest);
            return new SyncInvoker<CreateAliasResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateAliasResponse>);
        }
        
        /// <summary>
        /// 删除服务实例
        ///
        /// 删除IAM Identity Center服务实例。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteIdentityCenterResponse DeleteIdentityCenter(DeleteIdentityCenterRequest deleteIdentityCenterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/service/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIdentityCenterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteIdentityCenterResponse>(response);
        }

        public SyncInvoker<DeleteIdentityCenterResponse> DeleteIdentityCenterInvoker(DeleteIdentityCenterRequest deleteIdentityCenterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/service/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIdentityCenterRequest);
            return new SyncInvoker<DeleteIdentityCenterResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteIdentityCenterResponse>);
        }
        
        /// <summary>
        /// 查询服务实例开通所在区域
        ///
        /// 查询IAM身份中心服务实例开通后，具体开通所在区域。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeRegisteredRegionsResponse DescribeRegisteredRegions(DescribeRegisteredRegionsRequest describeRegisteredRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/registered-regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeRegisteredRegionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribeRegisteredRegionsResponse>(response);
        }

        public SyncInvoker<DescribeRegisteredRegionsResponse> DescribeRegisteredRegionsInvoker(DescribeRegisteredRegionsRequest describeRegisteredRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/registered-regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeRegisteredRegionsRequest);
            return new SyncInvoker<DescribeRegisteredRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeRegisteredRegionsResponse>);
        }
        
        /// <summary>
        /// 查询高可用功能配置
        ///
        /// 查询高可用功能配置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetHaConfigurationResponse GetHaConfiguration(GetHaConfigurationRequest getHaConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getHaConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/disaster-recovery-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getHaConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetHaConfigurationResponse>(response);
        }

        public SyncInvoker<GetHaConfigurationResponse> GetHaConfigurationInvoker(GetHaConfigurationRequest getHaConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getHaConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/disaster-recovery-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getHaConfigurationRequest);
            return new SyncInvoker<GetHaConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<GetHaConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询服务实例状态
        ///
        /// 查询IAM Identity Center服务实例状态信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetIdentityCenterServiceStatusResponse GetIdentityCenterServiceStatus(GetIdentityCenterServiceStatusRequest getIdentityCenterServiceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-center-service/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getIdentityCenterServiceStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetIdentityCenterServiceStatusResponse>(response);
        }

        public SyncInvoker<GetIdentityCenterServiceStatusResponse> GetIdentityCenterServiceStatusInvoker(GetIdentityCenterServiceStatusRequest getIdentityCenterServiceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/identity-center-service/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getIdentityCenterServiceStatusRequest);
            return new SyncInvoker<GetIdentityCenterServiceStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<GetIdentityCenterServiceStatusResponse>);
        }
        
        /// <summary>
        /// 获取身份源配置
        ///
        /// 获取IAM身份中心服务实例中的身份源配置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIdentityStoreAssociationResponse ListIdentityStoreAssociation(ListIdentityStoreAssociationRequest listIdentityStoreAssociationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listIdentityStoreAssociationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/identity-store-associations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIdentityStoreAssociationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListIdentityStoreAssociationResponse>(response);
        }

        public SyncInvoker<ListIdentityStoreAssociationResponse> ListIdentityStoreAssociationInvoker(ListIdentityStoreAssociationRequest listIdentityStoreAssociationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listIdentityStoreAssociationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/identity-store-associations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIdentityStoreAssociationRequest);
            return new SyncInvoker<ListIdentityStoreAssociationResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIdentityStoreAssociationResponse>);
        }
        
        /// <summary>
        /// 列出实例
        ///
        /// 查询IAM身份中心的实例列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesResponse ListInstances(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }

        public SyncInvoker<ListInstancesResponse> ListInstancesInvoker(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            return new SyncInvoker<ListInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesResponse>);
        }
        
        /// <summary>
        /// 选择服务实例开通区域
        ///
        /// IAM身份中心服务实例开通前，需要选择服务实例具体开通在某一区域。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RegisterRegionResponse RegisterRegion(RegisterRegionRequest registerRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/register-regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerRegionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RegisterRegionResponse>(response);
        }

        public SyncInvoker<RegisterRegionResponse> RegisterRegionInvoker(RegisterRegionRequest registerRegionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/register-regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", registerRegionRequest);
            return new SyncInvoker<RegisterRegionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RegisterRegionResponse>);
        }
        
        /// <summary>
        /// 开通服务实例
        ///
        /// 开通IAM Identity Center服务实例。此操作只能由组织的管理账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartIdentityCenterResponse StartIdentityCenter(StartIdentityCenterRequest startIdentityCenterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/service/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startIdentityCenterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<StartIdentityCenterResponse>(response);
        }

        public SyncInvoker<StartIdentityCenterResponse> StartIdentityCenterInvoker(StartIdentityCenterRequest startIdentityCenterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/service/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startIdentityCenterRequest);
            return new SyncInvoker<StartIdentityCenterResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StartIdentityCenterResponse>);
        }
        
        /// <summary>
        /// 更新高可用功能配置
        ///
        /// 授权启用或者禁用高可用功能配置。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHaConfigurationResponse UpdateHaConfiguration(UpdateHaConfigurationRequest updateHaConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHaConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/disaster-recovery-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHaConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateHaConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateHaConfigurationResponse> UpdateHaConfigurationInvoker(UpdateHaConfigurationRequest updateHaConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHaConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/disaster-recovery-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHaConfigurationRequest);
            return new SyncInvoker<UpdateHaConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateHaConfigurationResponse>);
        }
        
        /// <summary>
        /// 启用指定实例的访问控制功能
        ///
        /// 启用指定实例的访问控制功能。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceAccessControlAttributeConfigurationResponse CreateInstanceAccessControlAttributeConfiguration(CreateInstanceAccessControlAttributeConfigurationRequest createInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceAccessControlAttributeConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceAccessControlAttributeConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateInstanceAccessControlAttributeConfigurationResponse>(response);
        }

        public SyncInvoker<CreateInstanceAccessControlAttributeConfigurationResponse> CreateInstanceAccessControlAttributeConfigurationInvoker(CreateInstanceAccessControlAttributeConfigurationRequest createInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceAccessControlAttributeConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceAccessControlAttributeConfigurationRequest);
            return new SyncInvoker<CreateInstanceAccessControlAttributeConfigurationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateInstanceAccessControlAttributeConfigurationResponse>);
        }
        
        /// <summary>
        /// 解除指定实例的访问控制属性配置
        ///
        /// 禁用指定IAM Identity Center实例的基于属性的访问控制（ABAC）功能，并删除已配置的所有属性映射。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceAccessControlAttributeConfigurationResponse DeleteInstanceAccessControlAttributeConfiguration(DeleteInstanceAccessControlAttributeConfigurationRequest deleteInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceAccessControlAttributeConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceAccessControlAttributeConfigurationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceAccessControlAttributeConfigurationResponse>(response);
        }

        public SyncInvoker<DeleteInstanceAccessControlAttributeConfigurationResponse> DeleteInstanceAccessControlAttributeConfigurationInvoker(DeleteInstanceAccessControlAttributeConfigurationRequest deleteInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceAccessControlAttributeConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceAccessControlAttributeConfigurationRequest);
            return new SyncInvoker<DeleteInstanceAccessControlAttributeConfigurationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceAccessControlAttributeConfigurationResponse>);
        }
        
        /// <summary>
        /// 获取指定实例的访问控制属性配置
        ///
        /// 返回已配置为与指定IAM Identity Center实例的基于属性的访问控制（ABAC）一起使用的IAM Identity Center身份存储属性列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeInstanceAccessControlAttributeConfigurationResponse DescribeInstanceAccessControlAttributeConfiguration(DescribeInstanceAccessControlAttributeConfigurationRequest describeInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeInstanceAccessControlAttributeConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeInstanceAccessControlAttributeConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribeInstanceAccessControlAttributeConfigurationResponse>(response);
        }

        public SyncInvoker<DescribeInstanceAccessControlAttributeConfigurationResponse> DescribeInstanceAccessControlAttributeConfigurationInvoker(DescribeInstanceAccessControlAttributeConfigurationRequest describeInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describeInstanceAccessControlAttributeConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeInstanceAccessControlAttributeConfigurationRequest);
            return new SyncInvoker<DescribeInstanceAccessControlAttributeConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeInstanceAccessControlAttributeConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新指定实例的访问控制属性配置
        ///
        /// 更新可与IAM Identity Center实例一起使用的IAM Identity Center身份存储属性，以进行基于属性的访问控制（ABAC）。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceAccessControlAttributeConfigurationResponse UpdateInstanceAccessControlAttributeConfiguration(UpdateInstanceAccessControlAttributeConfigurationRequest updateInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceAccessControlAttributeConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceAccessControlAttributeConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceAccessControlAttributeConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateInstanceAccessControlAttributeConfigurationResponse> UpdateInstanceAccessControlAttributeConfigurationInvoker(UpdateInstanceAccessControlAttributeConfigurationRequest updateInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceAccessControlAttributeConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceAccessControlAttributeConfigurationRequest);
            return new SyncInvoker<UpdateInstanceAccessControlAttributeConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceAccessControlAttributeConfigurationResponse>);
        }
        
        /// <summary>
        /// 查询MFA管理配置信息
        ///
        /// 查询MFA管理配置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetMfaDeviceManagementForIdentityStoreResponse GetMfaDeviceManagementForIdentityStore(GetMfaDeviceManagementForIdentityStoreRequest getMfaDeviceManagementForIdentityStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getMfaDeviceManagementForIdentityStoreRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/mfa-devices/management-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getMfaDeviceManagementForIdentityStoreRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetMfaDeviceManagementForIdentityStoreResponse>(response);
        }

        public SyncInvoker<GetMfaDeviceManagementForIdentityStoreResponse> GetMfaDeviceManagementForIdentityStoreInvoker(GetMfaDeviceManagementForIdentityStoreRequest getMfaDeviceManagementForIdentityStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getMfaDeviceManagementForIdentityStoreRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/mfa-devices/management-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getMfaDeviceManagementForIdentityStoreRequest);
            return new SyncInvoker<GetMfaDeviceManagementForIdentityStoreResponse>(this, "GET", request, JsonUtils.DeSerialize<GetMfaDeviceManagementForIdentityStoreResponse>);
        }
        
        /// <summary>
        /// 设置MFA管理设置信息
        ///
        /// 设置MFA管理设置信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PutMfaDeviceManagementForIdentityStoreResponse PutMfaDeviceManagementForIdentityStore(PutMfaDeviceManagementForIdentityStoreRequest putMfaDeviceManagementForIdentityStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(putMfaDeviceManagementForIdentityStoreRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/mfa-devices/management-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putMfaDeviceManagementForIdentityStoreRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<PutMfaDeviceManagementForIdentityStoreResponse>(response);
        }

        public SyncInvoker<PutMfaDeviceManagementForIdentityStoreResponse> PutMfaDeviceManagementForIdentityStoreInvoker(PutMfaDeviceManagementForIdentityStoreRequest putMfaDeviceManagementForIdentityStoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(putMfaDeviceManagementForIdentityStoreRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/mfa-devices/management-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putMfaDeviceManagementForIdentityStoreRequest);
            return new SyncInvoker<PutMfaDeviceManagementForIdentityStoreResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PutMfaDeviceManagementForIdentityStoreResponse>);
        }
        
        /// <summary>
        /// 添加系统身份策略
        ///
        /// 在指定的权限集中添加系统身份策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachManagedPolicyToPermissionSetResponse AttachManagedPolicyToPermissionSet(AttachManagedPolicyToPermissionSetRequest attachManagedPolicyToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachManagedPolicyToPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(attachManagedPolicyToPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/attach-managed-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachManagedPolicyToPermissionSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AttachManagedPolicyToPermissionSetResponse>(response);
        }

        public SyncInvoker<AttachManagedPolicyToPermissionSetResponse> AttachManagedPolicyToPermissionSetInvoker(AttachManagedPolicyToPermissionSetRequest attachManagedPolicyToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachManagedPolicyToPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(attachManagedPolicyToPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/attach-managed-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachManagedPolicyToPermissionSetRequest);
            return new SyncInvoker<AttachManagedPolicyToPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AttachManagedPolicyToPermissionSetResponse>);
        }
        
        /// <summary>
        /// 附加系统策略到权限集
        ///
        /// 将系统策略附加到权限集。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachManagedRoleToPermissionSetResponse AttachManagedRoleToPermissionSet(AttachManagedRoleToPermissionSetRequest attachManagedRoleToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachManagedRoleToPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(attachManagedRoleToPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/attach-managed-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachManagedRoleToPermissionSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AttachManagedRoleToPermissionSetResponse>(response);
        }

        public SyncInvoker<AttachManagedRoleToPermissionSetResponse> AttachManagedRoleToPermissionSetInvoker(AttachManagedRoleToPermissionSetRequest attachManagedRoleToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachManagedRoleToPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(attachManagedRoleToPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/attach-managed-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachManagedRoleToPermissionSetRequest);
            return new SyncInvoker<AttachManagedRoleToPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AttachManagedRoleToPermissionSetResponse>);
        }
        
        /// <summary>
        /// 创建权限集
        ///
        /// 在指定的IAM Identity Center实例中创建一个权限集。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePermissionSetResponse CreatePermissionSet(CreatePermissionSetRequest createPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPermissionSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePermissionSetResponse>(response);
        }

        public SyncInvoker<CreatePermissionSetResponse> CreatePermissionSetInvoker(CreatePermissionSetRequest createPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPermissionSetRequest);
            return new SyncInvoker<CreatePermissionSetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePermissionSetResponse>);
        }
        
        /// <summary>
        /// 删除指定权限集中的自定义身份策略
        ///
        /// 删除指定权限集中的自定义身份策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCustomPolicyFromPermissionSetResponse DeleteCustomPolicyFromPermissionSet(DeleteCustomPolicyFromPermissionSetRequest deleteCustomPolicyFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCustomPolicyFromPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteCustomPolicyFromPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomPolicyFromPermissionSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCustomPolicyFromPermissionSetResponse>(response);
        }

        public SyncInvoker<DeleteCustomPolicyFromPermissionSetResponse> DeleteCustomPolicyFromPermissionSetInvoker(DeleteCustomPolicyFromPermissionSetRequest deleteCustomPolicyFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCustomPolicyFromPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteCustomPolicyFromPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomPolicyFromPermissionSetRequest);
            return new SyncInvoker<DeleteCustomPolicyFromPermissionSetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCustomPolicyFromPermissionSetResponse>);
        }
        
        /// <summary>
        /// 删除指定权限集中的自定义策略
        ///
        /// 删除指定权限集中的自定义策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCustomRoleFromPermissionSetResponse DeleteCustomRoleFromPermissionSet(DeleteCustomRoleFromPermissionSetRequest deleteCustomRoleFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCustomRoleFromPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteCustomRoleFromPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomRoleFromPermissionSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCustomRoleFromPermissionSetResponse>(response);
        }

        public SyncInvoker<DeleteCustomRoleFromPermissionSetResponse> DeleteCustomRoleFromPermissionSetInvoker(DeleteCustomRoleFromPermissionSetRequest deleteCustomRoleFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCustomRoleFromPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteCustomRoleFromPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomRoleFromPermissionSetRequest);
            return new SyncInvoker<DeleteCustomRoleFromPermissionSetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCustomRoleFromPermissionSetResponse>);
        }
        
        /// <summary>
        /// 删除权限集
        ///
        /// 根据权限集ID，删除指定的权限集。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePermissionSetResponse DeletePermissionSet(DeletePermissionSetRequest deletePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deletePermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePermissionSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePermissionSetResponse>(response);
        }

        public SyncInvoker<DeletePermissionSetResponse> DeletePermissionSetInvoker(DeletePermissionSetRequest deletePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deletePermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePermissionSetRequest);
            return new SyncInvoker<DeletePermissionSetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePermissionSetResponse>);
        }
        
        /// <summary>
        /// 查询权限集详情
        ///
        /// 根据权限集ID，查询指定权限集的详情信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribePermissionSetResponse DescribePermissionSet(DescribePermissionSetRequest describePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describePermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(describePermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePermissionSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribePermissionSetResponse>(response);
        }

        public SyncInvoker<DescribePermissionSetResponse> DescribePermissionSetInvoker(DescribePermissionSetRequest describePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describePermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(describePermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePermissionSetRequest);
            return new SyncInvoker<DescribePermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribePermissionSetResponse>);
        }
        
        /// <summary>
        /// 查询权限集预分配状态详情
        ///
        /// 根据请求Id，查询权限集预分配状态的详情信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribePermissionSetProvisioningStatusResponse DescribePermissionSetProvisioningStatus(DescribePermissionSetProvisioningStatusRequest describePermissionSetProvisioningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describePermissionSetProvisioningStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(describePermissionSetProvisioningStatusRequest.RequestId, out var valueOfRequestId)) urlParam.Add("request_id", valueOfRequestId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioning-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePermissionSetProvisioningStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribePermissionSetProvisioningStatusResponse>(response);
        }

        public SyncInvoker<DescribePermissionSetProvisioningStatusResponse> DescribePermissionSetProvisioningStatusInvoker(DescribePermissionSetProvisioningStatusRequest describePermissionSetProvisioningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(describePermissionSetProvisioningStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(describePermissionSetProvisioningStatusRequest.RequestId, out var valueOfRequestId)) urlParam.Add("request_id", valueOfRequestId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioning-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePermissionSetProvisioningStatusRequest);
            return new SyncInvoker<DescribePermissionSetProvisioningStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribePermissionSetProvisioningStatusResponse>);
        }
        
        /// <summary>
        /// 从权限集分离系统身份策略
        ///
        /// 将附加的系统身份策略从指定的权限集中分离。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetachManagedPolicyFromPermissionSetResponse DetachManagedPolicyFromPermissionSet(DetachManagedPolicyFromPermissionSetRequest detachManagedPolicyFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachManagedPolicyFromPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(detachManagedPolicyFromPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/detach-managed-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachManagedPolicyFromPermissionSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DetachManagedPolicyFromPermissionSetResponse>(response);
        }

        public SyncInvoker<DetachManagedPolicyFromPermissionSetResponse> DetachManagedPolicyFromPermissionSetInvoker(DetachManagedPolicyFromPermissionSetRequest detachManagedPolicyFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachManagedPolicyFromPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(detachManagedPolicyFromPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/detach-managed-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachManagedPolicyFromPermissionSetRequest);
            return new SyncInvoker<DetachManagedPolicyFromPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DetachManagedPolicyFromPermissionSetResponse>);
        }
        
        /// <summary>
        /// 从权限集分离系统策略
        ///
        /// 将附加的系统策略从指定的权限集中分离。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetachManagedRoleFromPermissionSetResponse DetachManagedRoleFromPermissionSet(DetachManagedRoleFromPermissionSetRequest detachManagedRoleFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachManagedRoleFromPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(detachManagedRoleFromPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/detach-managed-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachManagedRoleFromPermissionSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DetachManagedRoleFromPermissionSetResponse>(response);
        }

        public SyncInvoker<DetachManagedRoleFromPermissionSetResponse> DetachManagedRoleFromPermissionSetInvoker(DetachManagedRoleFromPermissionSetRequest detachManagedRoleFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachManagedRoleFromPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(detachManagedRoleFromPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/detach-managed-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachManagedRoleFromPermissionSetRequest);
            return new SyncInvoker<DetachManagedRoleFromPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DetachManagedRoleFromPermissionSetResponse>);
        }
        
        /// <summary>
        /// 获取分配给权限集的自定义身份策略
        ///
        /// 获取分配给权限集的自定义身份策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetCustomPolicyForPermissionSetResponse GetCustomPolicyForPermissionSet(GetCustomPolicyForPermissionSetRequest getCustomPolicyForPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getCustomPolicyForPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(getCustomPolicyForPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCustomPolicyForPermissionSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetCustomPolicyForPermissionSetResponse>(response);
        }

        public SyncInvoker<GetCustomPolicyForPermissionSetResponse> GetCustomPolicyForPermissionSetInvoker(GetCustomPolicyForPermissionSetRequest getCustomPolicyForPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getCustomPolicyForPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(getCustomPolicyForPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCustomPolicyForPermissionSetRequest);
            return new SyncInvoker<GetCustomPolicyForPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<GetCustomPolicyForPermissionSetResponse>);
        }
        
        /// <summary>
        /// 获取分配给权限集的自定义策略
        ///
        /// 获取分配给权限集的自定义策略。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetCustomRoleForPermissionSetResponse GetCustomRoleForPermissionSet(GetCustomRoleForPermissionSetRequest getCustomRoleForPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getCustomRoleForPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(getCustomRoleForPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCustomRoleForPermissionSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetCustomRoleForPermissionSetResponse>(response);
        }

        public SyncInvoker<GetCustomRoleForPermissionSetResponse> GetCustomRoleForPermissionSetInvoker(GetCustomRoleForPermissionSetRequest getCustomRoleForPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getCustomRoleForPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(getCustomRoleForPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCustomRoleForPermissionSetRequest);
            return new SyncInvoker<GetCustomRoleForPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<GetCustomRoleForPermissionSetResponse>);
        }
        
        /// <summary>
        /// 查询权限集配额信息
        ///
        /// 查询权限集配额信息。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetPermissionSetSummaryResponse GetPermissionSetSummary(GetPermissionSetSummaryRequest getPermissionSetSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getPermissionSetSummaryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-set-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getPermissionSetSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetPermissionSetSummaryResponse>(response);
        }

        public SyncInvoker<GetPermissionSetSummaryResponse> GetPermissionSetSummaryInvoker(GetPermissionSetSummaryRequest getPermissionSetSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getPermissionSetSummaryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-set-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getPermissionSetSummaryRequest);
            return new SyncInvoker<GetPermissionSetSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<GetPermissionSetSummaryResponse>);
        }
        
        /// <summary>
        /// 列出权限集关联的账号
        ///
        /// 查询与指定权限集关联的账户列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccountsForProvisionedPermissionSetResponse ListAccountsForProvisionedPermissionSet(ListAccountsForProvisionedPermissionSetRequest listAccountsForProvisionedPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccountsForProvisionedPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listAccountsForProvisionedPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsForProvisionedPermissionSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccountsForProvisionedPermissionSetResponse>(response);
        }

        public SyncInvoker<ListAccountsForProvisionedPermissionSetResponse> ListAccountsForProvisionedPermissionSetInvoker(ListAccountsForProvisionedPermissionSetRequest listAccountsForProvisionedPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccountsForProvisionedPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listAccountsForProvisionedPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsForProvisionedPermissionSetRequest);
            return new SyncInvoker<ListAccountsForProvisionedPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountsForProvisionedPermissionSetResponse>);
        }
        
        /// <summary>
        /// 列出权限集中附加的系统身份策略
        ///
        /// 获取附加到指定权限集的系统身份策略列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListManagedPoliciesInPermissionSetResponse ListManagedPoliciesInPermissionSet(ListManagedPoliciesInPermissionSetRequest listManagedPoliciesInPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listManagedPoliciesInPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listManagedPoliciesInPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/managed-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedPoliciesInPermissionSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListManagedPoliciesInPermissionSetResponse>(response);
        }

        public SyncInvoker<ListManagedPoliciesInPermissionSetResponse> ListManagedPoliciesInPermissionSetInvoker(ListManagedPoliciesInPermissionSetRequest listManagedPoliciesInPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listManagedPoliciesInPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listManagedPoliciesInPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/managed-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedPoliciesInPermissionSetRequest);
            return new SyncInvoker<ListManagedPoliciesInPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListManagedPoliciesInPermissionSetResponse>);
        }
        
        /// <summary>
        /// 列出权限集中附加的系统策略
        ///
        /// 获取附加到指定权限集的系统策略列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListManagedRolesInPermissionSetResponse ListManagedRolesInPermissionSet(ListManagedRolesInPermissionSetRequest listManagedRolesInPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listManagedRolesInPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listManagedRolesInPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/managed-roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedRolesInPermissionSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListManagedRolesInPermissionSetResponse>(response);
        }

        public SyncInvoker<ListManagedRolesInPermissionSetResponse> ListManagedRolesInPermissionSetInvoker(ListManagedRolesInPermissionSetRequest listManagedRolesInPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listManagedRolesInPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listManagedRolesInPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/managed-roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedRolesInPermissionSetRequest);
            return new SyncInvoker<ListManagedRolesInPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListManagedRolesInPermissionSetResponse>);
        }
        
        /// <summary>
        /// 列出权限集预分配状态
        ///
        /// 查询指定实例中的权限集预分配状态列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPermissionSetProvisioningStatusResponse ListPermissionSetProvisioningStatus(ListPermissionSetProvisioningStatusRequest listPermissionSetProvisioningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPermissionSetProvisioningStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioning-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetProvisioningStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionSetProvisioningStatusResponse>(response);
        }

        public SyncInvoker<ListPermissionSetProvisioningStatusResponse> ListPermissionSetProvisioningStatusInvoker(ListPermissionSetProvisioningStatusRequest listPermissionSetProvisioningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPermissionSetProvisioningStatusRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioning-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetProvisioningStatusRequest);
            return new SyncInvoker<ListPermissionSetProvisioningStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionSetProvisioningStatusResponse>);
        }
        
        /// <summary>
        /// 列出权限集
        ///
        /// 查询指定实例下的权限集列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPermissionSetsResponse ListPermissionSets(ListPermissionSetsRequest listPermissionSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPermissionSetsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionSetsResponse>(response);
        }

        public SyncInvoker<ListPermissionSetsResponse> ListPermissionSetsInvoker(ListPermissionSetsRequest listPermissionSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPermissionSetsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetsRequest);
            return new SyncInvoker<ListPermissionSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionSetsResponse>);
        }
        
        /// <summary>
        /// 列出分配给账户的权限集
        ///
        /// 查询分配给指定账户的权限集列表。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPermissionSetsProvisionedToAccountResponse ListPermissionSetsProvisionedToAccount(ListPermissionSetsProvisionedToAccountRequest listPermissionSetsProvisionedToAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPermissionSetsProvisionedToAccountRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioned-to-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetsProvisionedToAccountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionSetsProvisionedToAccountResponse>(response);
        }

        public SyncInvoker<ListPermissionSetsProvisionedToAccountResponse> ListPermissionSetsProvisionedToAccountInvoker(ListPermissionSetsProvisionedToAccountRequest listPermissionSetsProvisionedToAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPermissionSetsProvisionedToAccountRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioned-to-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetsProvisionedToAccountRequest);
            return new SyncInvoker<ListPermissionSetsProvisionedToAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionSetsProvisionedToAccountResponse>);
        }
        
        /// <summary>
        /// 预分配权限集
        ///
        /// 将指定权限集预分配给指定账户。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ProvisionPermissionSetResponse ProvisionPermissionSet(ProvisionPermissionSetRequest provisionPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(provisionPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(provisionPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/provision", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", provisionPermissionSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ProvisionPermissionSetResponse>(response);
        }

        public SyncInvoker<ProvisionPermissionSetResponse> ProvisionPermissionSetInvoker(ProvisionPermissionSetRequest provisionPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(provisionPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(provisionPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/provision", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", provisionPermissionSetRequest);
            return new SyncInvoker<ProvisionPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerialize<ProvisionPermissionSetResponse>);
        }
        
        /// <summary>
        /// 将自定义身份策略附加到权限集
        ///
        /// 将自定义身份策略附加到权限集。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PutCustomPolicyToPermissionSetResponse PutCustomPolicyToPermissionSet(PutCustomPolicyToPermissionSetRequest putCustomPolicyToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(putCustomPolicyToPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(putCustomPolicyToPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putCustomPolicyToPermissionSetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<PutCustomPolicyToPermissionSetResponse>(response);
        }

        public SyncInvoker<PutCustomPolicyToPermissionSetResponse> PutCustomPolicyToPermissionSetInvoker(PutCustomPolicyToPermissionSetRequest putCustomPolicyToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(putCustomPolicyToPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(putCustomPolicyToPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putCustomPolicyToPermissionSetRequest);
            return new SyncInvoker<PutCustomPolicyToPermissionSetResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<PutCustomPolicyToPermissionSetResponse>);
        }
        
        /// <summary>
        /// 将自定义策略附加到权限集
        ///
        /// 将自定义策略附加到权限集。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PutCustomRoleToPermissionSetResponse PutCustomRoleToPermissionSet(PutCustomRoleToPermissionSetRequest putCustomRoleToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(putCustomRoleToPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(putCustomRoleToPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putCustomRoleToPermissionSetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<PutCustomRoleToPermissionSetResponse>(response);
        }

        public SyncInvoker<PutCustomRoleToPermissionSetResponse> PutCustomRoleToPermissionSetInvoker(PutCustomRoleToPermissionSetRequest putCustomRoleToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(putCustomRoleToPermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(putCustomRoleToPermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putCustomRoleToPermissionSetRequest);
            return new SyncInvoker<PutCustomRoleToPermissionSetResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<PutCustomRoleToPermissionSetResponse>);
        }
        
        /// <summary>
        /// 更新权限集
        ///
        /// 根据权限集ID，更新指定权限集的属性。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePermissionSetResponse UpdatePermissionSet(UpdatePermissionSetRequest updatePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updatePermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePermissionSetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePermissionSetResponse>(response);
        }

        public SyncInvoker<UpdatePermissionSetResponse> UpdatePermissionSetInvoker(UpdatePermissionSetRequest updatePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePermissionSetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updatePermissionSetRequest.PermissionSetId, out var valueOfPermissionSetId)) urlParam.Add("permission_set_id", valueOfPermissionSetId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePermissionSetRequest);
            return new SyncInvoker<UpdatePermissionSetResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePermissionSetResponse>);
        }
        
        /// <summary>
        /// 为指定资源添加标签
        ///
        /// 向指定的资源添加一个或多个标签。目前，您可以将标签附加到实例中的权限集。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTagResourceResponse CreateTagResource(CreateTagResourceRequest createTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createTagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagResourceResponse>(response);
        }

        public SyncInvoker<CreateTagResourceResponse> CreateTagResourceInvoker(CreateTagResourceRequest createTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createTagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagResourceRequest);
            return new SyncInvoker<CreateTagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagResourceResponse>);
        }
        
        /// <summary>
        /// 从指定资源中删除指定主键标签
        ///
        /// 从指定资源中删除具有指定主键的任何标签。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTagResourceResponse DeleteTagResource(DeleteTagResourceRequest deleteTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteTagResourceResponse>(response);
        }

        public SyncInvoker<DeleteTagResourceResponse> DeleteTagResourceInvoker(DeleteTagResourceRequest deleteTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagResourceRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagResourceRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagResourceRequest);
            return new SyncInvoker<DeleteTagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteTagResourceResponse>);
        }
        
        /// <summary>
        /// 列出绑定到指定资源的标签
        ///
        /// 列出绑定到指定资源的标签。您可以将标签附加到实例中的权限集。此操作只能由组织的管理账号或作为服务委托管理员的成员账号调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest listTagResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagResourcesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listTagResourcesRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTagResourcesResponse>(response);
        }

        public SyncInvoker<ListTagResourcesResponse> ListTagResourcesInvoker(ListTagResourcesRequest listTagResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagResourcesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listTagResourcesRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagResourcesRequest);
            return new SyncInvoker<ListTagResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagResourcesResponse>);
        }
        
    }
}