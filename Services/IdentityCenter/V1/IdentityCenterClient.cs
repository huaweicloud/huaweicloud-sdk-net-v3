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
        /// 创建账号分配
        ///
        /// 使用指定的权限集为指定账号分配对应主体的访问权限，主体可为IAM身份中心用户或用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAccountAssignmentResponse CreateAccountAssignment(CreateAccountAssignmentRequest createAccountAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createAccountAssignmentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccountAssignmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAccountAssignmentResponse>(response);
        }

        public SyncInvoker<CreateAccountAssignmentResponse> CreateAccountAssignmentInvoker(CreateAccountAssignmentRequest createAccountAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createAccountAssignmentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccountAssignmentRequest);
            return new SyncInvoker<CreateAccountAssignmentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccountAssignmentResponse>);
        }
        
        /// <summary>
        /// 删除账号分配
        ///
        /// 使用指定的权限集从指定的账号删除主体的访问权限，主体可为IAM身份中心用户或用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAccountAssignmentResponse DeleteAccountAssignment(DeleteAccountAssignmentRequest deleteAccountAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAccountAssignmentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccountAssignmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteAccountAssignmentResponse>(response);
        }

        public SyncInvoker<DeleteAccountAssignmentResponse> DeleteAccountAssignmentInvoker(DeleteAccountAssignmentRequest deleteAccountAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteAccountAssignmentRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccountAssignmentRequest);
            return new SyncInvoker<DeleteAccountAssignmentResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteAccountAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询账号分配创建状态详情
        ///
        /// 根据请求ID，查询指定IAM身份中心实例下的账号分配创建状态详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeAccountAssignmentCreationStatusResponse DescribeAccountAssignmentCreationStatus(DescribeAccountAssignmentCreationStatusRequest describeAccountAssignmentCreationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeAccountAssignmentCreationStatusRequest.InstanceId.ToString());
            urlParam.Add("request_id", describeAccountAssignmentCreationStatusRequest.RequestId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/creation-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeAccountAssignmentCreationStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribeAccountAssignmentCreationStatusResponse>(response);
        }

        public SyncInvoker<DescribeAccountAssignmentCreationStatusResponse> DescribeAccountAssignmentCreationStatusInvoker(DescribeAccountAssignmentCreationStatusRequest describeAccountAssignmentCreationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeAccountAssignmentCreationStatusRequest.InstanceId.ToString());
            urlParam.Add("request_id", describeAccountAssignmentCreationStatusRequest.RequestId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/creation-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeAccountAssignmentCreationStatusRequest);
            return new SyncInvoker<DescribeAccountAssignmentCreationStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeAccountAssignmentCreationStatusResponse>);
        }
        
        /// <summary>
        /// 查询账号分配删除状态详情
        ///
        /// 根据请求ID，查询指定IAM身份中心实例下的账号分配删除状态详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeAccountAssignmentDeletionStatusResponse DescribeAccountAssignmentDeletionStatus(DescribeAccountAssignmentDeletionStatusRequest describeAccountAssignmentDeletionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeAccountAssignmentDeletionStatusRequest.InstanceId.ToString());
            urlParam.Add("request_id", describeAccountAssignmentDeletionStatusRequest.RequestId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/deletion-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeAccountAssignmentDeletionStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribeAccountAssignmentDeletionStatusResponse>(response);
        }

        public SyncInvoker<DescribeAccountAssignmentDeletionStatusResponse> DescribeAccountAssignmentDeletionStatusInvoker(DescribeAccountAssignmentDeletionStatusRequest describeAccountAssignmentDeletionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeAccountAssignmentDeletionStatusRequest.InstanceId.ToString());
            urlParam.Add("request_id", describeAccountAssignmentDeletionStatusRequest.RequestId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/deletion-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeAccountAssignmentDeletionStatusRequest);
            return new SyncInvoker<DescribeAccountAssignmentDeletionStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeAccountAssignmentDeletionStatusResponse>);
        }
        
        /// <summary>
        /// 列出账号分配创建状态
        ///
        /// 查询指定IAM身份中心实例下的账号分配的创建状态列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccountAssignmentCreationStatusResponse ListAccountAssignmentCreationStatus(ListAccountAssignmentCreationStatusRequest listAccountAssignmentCreationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountAssignmentCreationStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/creation-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentCreationStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccountAssignmentCreationStatusResponse>(response);
        }

        public SyncInvoker<ListAccountAssignmentCreationStatusResponse> ListAccountAssignmentCreationStatusInvoker(ListAccountAssignmentCreationStatusRequest listAccountAssignmentCreationStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountAssignmentCreationStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/creation-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentCreationStatusRequest);
            return new SyncInvoker<ListAccountAssignmentCreationStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountAssignmentCreationStatusResponse>);
        }
        
        /// <summary>
        /// 列出账号分配删除状态
        ///
        /// 查询指定IAM身份中心实例下的账号分配的删除状态列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccountAssignmentDeletionStatusResponse ListAccountAssignmentDeletionStatus(ListAccountAssignmentDeletionStatusRequest listAccountAssignmentDeletionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountAssignmentDeletionStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/deletion-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentDeletionStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccountAssignmentDeletionStatusResponse>(response);
        }

        public SyncInvoker<ListAccountAssignmentDeletionStatusResponse> ListAccountAssignmentDeletionStatusInvoker(ListAccountAssignmentDeletionStatusRequest listAccountAssignmentDeletionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountAssignmentDeletionStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments/deletion-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentDeletionStatusRequest);
            return new SyncInvoker<ListAccountAssignmentDeletionStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountAssignmentDeletionStatusResponse>);
        }
        
        /// <summary>
        /// 列出账号和权限集关联的用户或用户组
        ///
        /// 列出与指定账号以及指定权限集关联的用户或用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccountAssignmentsResponse ListAccountAssignments(ListAccountAssignmentsRequest listAccountAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountAssignmentsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccountAssignmentsResponse>(response);
        }

        public SyncInvoker<ListAccountAssignmentsResponse> ListAccountAssignmentsInvoker(ListAccountAssignmentsRequest listAccountAssignmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountAssignmentsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/account-assignments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountAssignmentsRequest);
            return new SyncInvoker<ListAccountAssignmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountAssignmentsResponse>);
        }
        
        /// <summary>
        /// 列出实例
        ///
        /// 查询IAM身份中心的实例列表。
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
        /// 启用指定实例的访问控制功能
        ///
        /// 启用指定实例的访问控制功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceAccessControlAttributeConfigurationResponse CreateInstanceAccessControlAttributeConfiguration(CreateInstanceAccessControlAttributeConfigurationRequest createInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceAccessControlAttributeConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateInstanceAccessControlAttributeConfigurationResponse>(response);
        }

        public SyncInvoker<CreateInstanceAccessControlAttributeConfigurationResponse> CreateInstanceAccessControlAttributeConfigurationInvoker(CreateInstanceAccessControlAttributeConfigurationRequest createInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceAccessControlAttributeConfigurationRequest);
            return new SyncInvoker<CreateInstanceAccessControlAttributeConfigurationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateInstanceAccessControlAttributeConfigurationResponse>);
        }
        
        /// <summary>
        /// 解除指定实例的访问控制属性配置
        ///
        /// 禁用指定IAM身份中心实例的基于属性的访问控制（ABAC）功能，并删除已配置的所有属性映射。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceAccessControlAttributeConfigurationResponse DeleteInstanceAccessControlAttributeConfiguration(DeleteInstanceAccessControlAttributeConfigurationRequest deleteInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceAccessControlAttributeConfigurationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceAccessControlAttributeConfigurationResponse>(response);
        }

        public SyncInvoker<DeleteInstanceAccessControlAttributeConfigurationResponse> DeleteInstanceAccessControlAttributeConfigurationInvoker(DeleteInstanceAccessControlAttributeConfigurationRequest deleteInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceAccessControlAttributeConfigurationRequest);
            return new SyncInvoker<DeleteInstanceAccessControlAttributeConfigurationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceAccessControlAttributeConfigurationResponse>);
        }
        
        /// <summary>
        /// 获取指定实例的访问控制属性配置
        ///
        /// 返回已配置为与指定IAM身份中心实例的基于属性的访问控制（ABAC）一起使用的IAM身份中心身份源属性列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeInstanceAccessControlAttributeConfigurationResponse DescribeInstanceAccessControlAttributeConfiguration(DescribeInstanceAccessControlAttributeConfigurationRequest describeInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeInstanceAccessControlAttributeConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribeInstanceAccessControlAttributeConfigurationResponse>(response);
        }

        public SyncInvoker<DescribeInstanceAccessControlAttributeConfigurationResponse> DescribeInstanceAccessControlAttributeConfigurationInvoker(DescribeInstanceAccessControlAttributeConfigurationRequest describeInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describeInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeInstanceAccessControlAttributeConfigurationRequest);
            return new SyncInvoker<DescribeInstanceAccessControlAttributeConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribeInstanceAccessControlAttributeConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新指定实例的访问控制属性配置
        ///
        /// 更新可与IAM身份中心实例一起使用的IAM身份中心身份源属性，以进行基于属性的访问控制（ABAC）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceAccessControlAttributeConfigurationResponse UpdateInstanceAccessControlAttributeConfiguration(UpdateInstanceAccessControlAttributeConfigurationRequest updateInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceAccessControlAttributeConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceAccessControlAttributeConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateInstanceAccessControlAttributeConfigurationResponse> UpdateInstanceAccessControlAttributeConfigurationInvoker(UpdateInstanceAccessControlAttributeConfigurationRequest updateInstanceAccessControlAttributeConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceAccessControlAttributeConfigurationRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/access-control-attribute-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceAccessControlAttributeConfigurationRequest);
            return new SyncInvoker<UpdateInstanceAccessControlAttributeConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceAccessControlAttributeConfigurationResponse>);
        }
        
        /// <summary>
        /// 添加系统身份策略
        ///
        /// 在指定的权限集中添加系统身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachManagedPolicyToPermissionSetResponse AttachManagedPolicyToPermissionSet(AttachManagedPolicyToPermissionSetRequest attachManagedPolicyToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachManagedPolicyToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", attachManagedPolicyToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/attach-managed-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachManagedPolicyToPermissionSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AttachManagedPolicyToPermissionSetResponse>(response);
        }

        public SyncInvoker<AttachManagedPolicyToPermissionSetResponse> AttachManagedPolicyToPermissionSetInvoker(AttachManagedPolicyToPermissionSetRequest attachManagedPolicyToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachManagedPolicyToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", attachManagedPolicyToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/attach-managed-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachManagedPolicyToPermissionSetRequest);
            return new SyncInvoker<AttachManagedPolicyToPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AttachManagedPolicyToPermissionSetResponse>);
        }
        
        /// <summary>
        /// 创建权限集
        ///
        /// 在指定的IAM身份中心实例中创建一个权限集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePermissionSetResponse CreatePermissionSet(CreatePermissionSetRequest createPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createPermissionSetRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPermissionSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePermissionSetResponse>(response);
        }

        public SyncInvoker<CreatePermissionSetResponse> CreatePermissionSetInvoker(CreatePermissionSetRequest createPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createPermissionSetRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPermissionSetRequest);
            return new SyncInvoker<CreatePermissionSetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePermissionSetResponse>);
        }
        
        /// <summary>
        /// 删除自定义身份策略
        ///
        /// 删除指定权限集中的自定义身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCustomPolicyFromPermissionSetResponse DeleteCustomPolicyFromPermissionSet(DeleteCustomPolicyFromPermissionSetRequest deleteCustomPolicyFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteCustomPolicyFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", deleteCustomPolicyFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomPolicyFromPermissionSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCustomPolicyFromPermissionSetResponse>(response);
        }

        public SyncInvoker<DeleteCustomPolicyFromPermissionSetResponse> DeleteCustomPolicyFromPermissionSetInvoker(DeleteCustomPolicyFromPermissionSetRequest deleteCustomPolicyFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteCustomPolicyFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", deleteCustomPolicyFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomPolicyFromPermissionSetRequest);
            return new SyncInvoker<DeleteCustomPolicyFromPermissionSetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCustomPolicyFromPermissionSetResponse>);
        }
        
        /// <summary>
        /// 删除指定权限集中的自定义策略
        ///
        /// 删除指定权限集中的自定义策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCustomRoleFromPermissionSetResponse DeleteCustomRoleFromPermissionSet(DeleteCustomRoleFromPermissionSetRequest deleteCustomRoleFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteCustomRoleFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", deleteCustomRoleFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomRoleFromPermissionSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCustomRoleFromPermissionSetResponse>(response);
        }

        public SyncInvoker<DeleteCustomRoleFromPermissionSetResponse> DeleteCustomRoleFromPermissionSetInvoker(DeleteCustomRoleFromPermissionSetRequest deleteCustomRoleFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteCustomRoleFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", deleteCustomRoleFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomRoleFromPermissionSetRequest);
            return new SyncInvoker<DeleteCustomRoleFromPermissionSetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCustomRoleFromPermissionSetResponse>);
        }
        
        /// <summary>
        /// 删除权限集
        ///
        /// 根据权限集ID，删除指定的权限集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePermissionSetResponse DeletePermissionSet(DeletePermissionSetRequest deletePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deletePermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", deletePermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePermissionSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePermissionSetResponse>(response);
        }

        public SyncInvoker<DeletePermissionSetResponse> DeletePermissionSetInvoker(DeletePermissionSetRequest deletePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deletePermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", deletePermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePermissionSetRequest);
            return new SyncInvoker<DeletePermissionSetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePermissionSetResponse>);
        }
        
        /// <summary>
        /// 查询权限集详情
        ///
        /// 根据权限集ID，查询指定权限集的详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribePermissionSetResponse DescribePermissionSet(DescribePermissionSetRequest describePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describePermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", describePermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePermissionSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribePermissionSetResponse>(response);
        }

        public SyncInvoker<DescribePermissionSetResponse> DescribePermissionSetInvoker(DescribePermissionSetRequest describePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describePermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", describePermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePermissionSetRequest);
            return new SyncInvoker<DescribePermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribePermissionSetResponse>);
        }
        
        /// <summary>
        /// 查询权限集预分配状态详情
        ///
        /// 根据请求ID，查询权限集预分配状态的详情信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribePermissionSetProvisioningStatusResponse DescribePermissionSetProvisioningStatus(DescribePermissionSetProvisioningStatusRequest describePermissionSetProvisioningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describePermissionSetProvisioningStatusRequest.InstanceId.ToString());
            urlParam.Add("request_id", describePermissionSetProvisioningStatusRequest.RequestId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioning-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePermissionSetProvisioningStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DescribePermissionSetProvisioningStatusResponse>(response);
        }

        public SyncInvoker<DescribePermissionSetProvisioningStatusResponse> DescribePermissionSetProvisioningStatusInvoker(DescribePermissionSetProvisioningStatusRequest describePermissionSetProvisioningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", describePermissionSetProvisioningStatusRequest.InstanceId.ToString());
            urlParam.Add("request_id", describePermissionSetProvisioningStatusRequest.RequestId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioning-status/{request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", describePermissionSetProvisioningStatusRequest);
            return new SyncInvoker<DescribePermissionSetProvisioningStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<DescribePermissionSetProvisioningStatusResponse>);
        }
        
        /// <summary>
        /// 删除系统身份策略
        ///
        /// 删除指定权限集中的系统身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetachManagedPolicyFromPermissionSetResponse DetachManagedPolicyFromPermissionSet(DetachManagedPolicyFromPermissionSetRequest detachManagedPolicyFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", detachManagedPolicyFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", detachManagedPolicyFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/detach-managed-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachManagedPolicyFromPermissionSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DetachManagedPolicyFromPermissionSetResponse>(response);
        }

        public SyncInvoker<DetachManagedPolicyFromPermissionSetResponse> DetachManagedPolicyFromPermissionSetInvoker(DetachManagedPolicyFromPermissionSetRequest detachManagedPolicyFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", detachManagedPolicyFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", detachManagedPolicyFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/detach-managed-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachManagedPolicyFromPermissionSetRequest);
            return new SyncInvoker<DetachManagedPolicyFromPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DetachManagedPolicyFromPermissionSetResponse>);
        }
        
        /// <summary>
        /// 查询自定义身份策略详情
        ///
        /// 查询指定权限集中的自定义身份策略详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetCustomPolicyForPermissionSetResponse GetCustomPolicyForPermissionSet(GetCustomPolicyForPermissionSetRequest getCustomPolicyForPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getCustomPolicyForPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", getCustomPolicyForPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCustomPolicyForPermissionSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetCustomPolicyForPermissionSetResponse>(response);
        }

        public SyncInvoker<GetCustomPolicyForPermissionSetResponse> GetCustomPolicyForPermissionSetInvoker(GetCustomPolicyForPermissionSetRequest getCustomPolicyForPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getCustomPolicyForPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", getCustomPolicyForPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCustomPolicyForPermissionSetRequest);
            return new SyncInvoker<GetCustomPolicyForPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<GetCustomPolicyForPermissionSetResponse>);
        }
        
        /// <summary>
        /// 获取分配给权限集的自定义策略
        ///
        /// 获取分配给权限集的自定义策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetCustomRoleForPermissionSetResponse GetCustomRoleForPermissionSet(GetCustomRoleForPermissionSetRequest getCustomRoleForPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getCustomRoleForPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", getCustomRoleForPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCustomRoleForPermissionSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetCustomRoleForPermissionSetResponse>(response);
        }

        public SyncInvoker<GetCustomRoleForPermissionSetResponse> GetCustomRoleForPermissionSetInvoker(GetCustomRoleForPermissionSetRequest getCustomRoleForPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", getCustomRoleForPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", getCustomRoleForPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getCustomRoleForPermissionSetRequest);
            return new SyncInvoker<GetCustomRoleForPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<GetCustomRoleForPermissionSetResponse>);
        }
        
        /// <summary>
        /// 列出权限集关联的账号
        ///
        /// 查询与指定权限集关联的账号列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccountsForProvisionedPermissionSetResponse ListAccountsForProvisionedPermissionSet(ListAccountsForProvisionedPermissionSetRequest listAccountsForProvisionedPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountsForProvisionedPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", listAccountsForProvisionedPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsForProvisionedPermissionSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccountsForProvisionedPermissionSetResponse>(response);
        }

        public SyncInvoker<ListAccountsForProvisionedPermissionSetResponse> ListAccountsForProvisionedPermissionSetInvoker(ListAccountsForProvisionedPermissionSetRequest listAccountsForProvisionedPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listAccountsForProvisionedPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", listAccountsForProvisionedPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccountsForProvisionedPermissionSetRequest);
            return new SyncInvoker<ListAccountsForProvisionedPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccountsForProvisionedPermissionSetResponse>);
        }
        
        /// <summary>
        /// 列出系统身份策略
        ///
        /// 获取添加到指定权限集中的系统身份策略列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListManagedPoliciesInPermissionSetResponse ListManagedPoliciesInPermissionSet(ListManagedPoliciesInPermissionSetRequest listManagedPoliciesInPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listManagedPoliciesInPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", listManagedPoliciesInPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/managed-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedPoliciesInPermissionSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListManagedPoliciesInPermissionSetResponse>(response);
        }

        public SyncInvoker<ListManagedPoliciesInPermissionSetResponse> ListManagedPoliciesInPermissionSetInvoker(ListManagedPoliciesInPermissionSetRequest listManagedPoliciesInPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listManagedPoliciesInPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", listManagedPoliciesInPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/managed-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedPoliciesInPermissionSetRequest);
            return new SyncInvoker<ListManagedPoliciesInPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListManagedPoliciesInPermissionSetResponse>);
        }
        
        /// <summary>
        /// 列出权限集预分配状态
        ///
        /// 查询指定实例中的权限集预分配状态列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPermissionSetProvisioningStatusResponse ListPermissionSetProvisioningStatus(ListPermissionSetProvisioningStatusRequest listPermissionSetProvisioningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPermissionSetProvisioningStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioning-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetProvisioningStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionSetProvisioningStatusResponse>(response);
        }

        public SyncInvoker<ListPermissionSetProvisioningStatusResponse> ListPermissionSetProvisioningStatusInvoker(ListPermissionSetProvisioningStatusRequest listPermissionSetProvisioningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPermissionSetProvisioningStatusRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioning-statuses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetProvisioningStatusRequest);
            return new SyncInvoker<ListPermissionSetProvisioningStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionSetProvisioningStatusResponse>);
        }
        
        /// <summary>
        /// 列出权限集
        ///
        /// 查询指定实例下的权限集列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPermissionSetsResponse ListPermissionSets(ListPermissionSetsRequest listPermissionSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPermissionSetsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionSetsResponse>(response);
        }

        public SyncInvoker<ListPermissionSetsResponse> ListPermissionSetsInvoker(ListPermissionSetsRequest listPermissionSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPermissionSetsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetsRequest);
            return new SyncInvoker<ListPermissionSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionSetsResponse>);
        }
        
        /// <summary>
        /// 列出分配给账号的权限集
        ///
        /// 查询分配给指定账号的权限集列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPermissionSetsProvisionedToAccountResponse ListPermissionSetsProvisionedToAccount(ListPermissionSetsProvisionedToAccountRequest listPermissionSetsProvisionedToAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPermissionSetsProvisionedToAccountRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioned-to-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetsProvisionedToAccountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionSetsProvisionedToAccountResponse>(response);
        }

        public SyncInvoker<ListPermissionSetsProvisionedToAccountResponse> ListPermissionSetsProvisionedToAccountInvoker(ListPermissionSetsProvisionedToAccountRequest listPermissionSetsProvisionedToAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPermissionSetsProvisionedToAccountRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/provisioned-to-accounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionSetsProvisionedToAccountRequest);
            return new SyncInvoker<ListPermissionSetsProvisionedToAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionSetsProvisionedToAccountResponse>);
        }
        
        /// <summary>
        /// 预分配权限集
        ///
        /// 将指定权限集预分配给指定账号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ProvisionPermissionSetResponse ProvisionPermissionSet(ProvisionPermissionSetRequest provisionPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", provisionPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", provisionPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/provision", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", provisionPermissionSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ProvisionPermissionSetResponse>(response);
        }

        public SyncInvoker<ProvisionPermissionSetResponse> ProvisionPermissionSetInvoker(ProvisionPermissionSetRequest provisionPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", provisionPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", provisionPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/provision", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", provisionPermissionSetRequest);
            return new SyncInvoker<ProvisionPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerialize<ProvisionPermissionSetResponse>);
        }
        
        /// <summary>
        /// 添加自定义身份策略
        ///
        /// 在指定的权限集中添加自定义身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PutCustomPolicyToPermissionSetResponse PutCustomPolicyToPermissionSet(PutCustomPolicyToPermissionSetRequest putCustomPolicyToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", putCustomPolicyToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", putCustomPolicyToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putCustomPolicyToPermissionSetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<PutCustomPolicyToPermissionSetResponse>(response);
        }

        public SyncInvoker<PutCustomPolicyToPermissionSetResponse> PutCustomPolicyToPermissionSetInvoker(PutCustomPolicyToPermissionSetRequest putCustomPolicyToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", putCustomPolicyToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", putCustomPolicyToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putCustomPolicyToPermissionSetRequest);
            return new SyncInvoker<PutCustomPolicyToPermissionSetResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<PutCustomPolicyToPermissionSetResponse>);
        }
        
        /// <summary>
        /// 将自定义策略附加到权限集
        ///
        /// 将自定义策略附加到权限集
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PutCustomRoleToPermissionSetResponse PutCustomRoleToPermissionSet(PutCustomRoleToPermissionSetRequest putCustomRoleToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", putCustomRoleToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", putCustomRoleToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putCustomRoleToPermissionSetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<PutCustomRoleToPermissionSetResponse>(response);
        }

        public SyncInvoker<PutCustomRoleToPermissionSetResponse> PutCustomRoleToPermissionSetInvoker(PutCustomRoleToPermissionSetRequest putCustomRoleToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", putCustomRoleToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", putCustomRoleToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/custom-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", putCustomRoleToPermissionSetRequest);
            return new SyncInvoker<PutCustomRoleToPermissionSetResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<PutCustomRoleToPermissionSetResponse>);
        }
        
        /// <summary>
        /// 更新权限集
        ///
        /// 根据权限集ID，更新指定权限集的属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePermissionSetResponse UpdatePermissionSet(UpdatePermissionSetRequest updatePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", updatePermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePermissionSetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePermissionSetResponse>(response);
        }

        public SyncInvoker<UpdatePermissionSetResponse> UpdatePermissionSetInvoker(UpdatePermissionSetRequest updatePermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", updatePermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePermissionSetRequest);
            return new SyncInvoker<UpdatePermissionSetResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePermissionSetResponse>);
        }
        
        /// <summary>
        /// 为指定资源添加标签
        ///
        /// 给指定的资源添加一个或多个标签。当前支持为权限集添加标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTagResourceResponse CreateTagResource(CreateTagResourceRequest createTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagResourceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagResourceResponse>(response);
        }

        public SyncInvoker<CreateTagResourceResponse> CreateTagResourceInvoker(CreateTagResourceRequest createTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagResourceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagResourceRequest);
            return new SyncInvoker<CreateTagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagResourceResponse>);
        }
        
        /// <summary>
        /// 删除指定资源的指定标签
        ///
        /// 从指定资源中删除指定的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTagResourceResponse DeleteTagResource(DeleteTagResourceRequest deleteTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteTagResourceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteTagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteTagResourceResponse>(response);
        }

        public SyncInvoker<DeleteTagResourceResponse> DeleteTagResourceInvoker(DeleteTagResourceRequest deleteTagResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteTagResourceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteTagResourceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagResourceRequest);
            return new SyncInvoker<DeleteTagResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteTagResourceResponse>);
        }
        
        /// <summary>
        /// 列出绑定到指定资源的标签
        ///
        /// 列出绑定到指定资源的标签。当前支持为权限集添加标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest listTagResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagResourcesRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listTagResourcesRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTagResourcesResponse>(response);
        }

        public SyncInvoker<ListTagResourcesResponse> ListTagResourcesInvoker(ListTagResourcesRequest listTagResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagResourcesRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listTagResourcesRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagResourcesRequest);
            return new SyncInvoker<ListTagResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagResourcesResponse>);
        }
        
        /// <summary>
        /// 添加系统策略
        ///
        /// 在指定的权限集中添加系统策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachManagedRoleToPermissionSetResponse AttachManagedRoleToPermissionSet(AttachManagedRoleToPermissionSetRequest attachManagedRoleToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachManagedRoleToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", attachManagedRoleToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/attach-managed-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachManagedRoleToPermissionSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AttachManagedRoleToPermissionSetResponse>(response);
        }

        public SyncInvoker<AttachManagedRoleToPermissionSetResponse> AttachManagedRoleToPermissionSetInvoker(AttachManagedRoleToPermissionSetRequest attachManagedRoleToPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", attachManagedRoleToPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", attachManagedRoleToPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/attach-managed-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachManagedRoleToPermissionSetRequest);
            return new SyncInvoker<AttachManagedRoleToPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AttachManagedRoleToPermissionSetResponse>);
        }
        
        /// <summary>
        /// 删除系统策略
        ///
        /// 删除指定权限集中的系统策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetachManagedRoleFromPermissionSetResponse DetachManagedRoleFromPermissionSet(DetachManagedRoleFromPermissionSetRequest detachManagedRoleFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", detachManagedRoleFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", detachManagedRoleFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/detach-managed-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachManagedRoleFromPermissionSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DetachManagedRoleFromPermissionSetResponse>(response);
        }

        public SyncInvoker<DetachManagedRoleFromPermissionSetResponse> DetachManagedRoleFromPermissionSetInvoker(DetachManagedRoleFromPermissionSetRequest detachManagedRoleFromPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", detachManagedRoleFromPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", detachManagedRoleFromPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/detach-managed-role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachManagedRoleFromPermissionSetRequest);
            return new SyncInvoker<DetachManagedRoleFromPermissionSetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DetachManagedRoleFromPermissionSetResponse>);
        }
        
        /// <summary>
        /// 列出系统策略
        ///
        /// 获取添加到指定权限集中的系统策略列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListManagedRolesInPermissionSetResponse ListManagedRolesInPermissionSet(ListManagedRolesInPermissionSetRequest listManagedRolesInPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listManagedRolesInPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", listManagedRolesInPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/managed-roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedRolesInPermissionSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListManagedRolesInPermissionSetResponse>(response);
        }

        public SyncInvoker<ListManagedRolesInPermissionSetResponse> ListManagedRolesInPermissionSetInvoker(ListManagedRolesInPermissionSetRequest listManagedRolesInPermissionSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listManagedRolesInPermissionSetRequest.InstanceId.ToString());
            urlParam.Add("permission_set_id", listManagedRolesInPermissionSetRequest.PermissionSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/instances/{instance_id}/permission-sets/{permission_set_id}/managed-roles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManagedRolesInPermissionSetRequest);
            return new SyncInvoker<ListManagedRolesInPermissionSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListManagedRolesInPermissionSetResponse>);
        }
        
    }
}