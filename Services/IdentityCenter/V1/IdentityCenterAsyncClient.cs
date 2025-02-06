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
        /// 创建账号分配
        ///
        /// 使用指定的权限集为指定账号分配对应主体的访问权限，主体可为IAM身份中心用户或用户组。
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
        /// 使用指定的权限集从指定的账号删除主体的访问权限，主体可为IAM身份中心用户或用户组。
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
        /// 查询账号分配创建状态详情
        ///
        /// 根据请求ID，查询指定IAM身份中心实例下的账号分配创建状态详情信息。
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
        /// 查询账号分配删除状态详情
        ///
        /// 根据请求ID，查询指定IAM身份中心实例下的账号分配删除状态详情信息。
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
        /// 列出账号分配创建状态
        ///
        /// 查询指定IAM身份中心实例下的账号分配的创建状态列表。
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
        /// 列出账号分配删除状态
        ///
        /// 查询指定IAM身份中心实例下的账号分配的删除状态列表。
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
        /// 列出账号和权限集关联的用户或用户组
        ///
        /// 列出与指定账号以及指定权限集关联的用户或用户组。
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
        /// 列出实例
        ///
        /// 查询IAM身份中心的实例列表。
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
        /// 启用指定实例的访问控制功能
        ///
        /// 启用指定实例的访问控制功能。
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
        /// 禁用指定IAM身份中心实例的基于属性的访问控制（ABAC）功能，并删除已配置的所有属性映射。
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
        /// 返回已配置为与指定IAM身份中心实例的基于属性的访问控制（ABAC）一起使用的IAM身份中心身份源属性列表。
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
        /// 更新可与IAM身份中心实例一起使用的IAM身份中心身份源属性，以进行基于属性的访问控制（ABAC）。
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
        /// 添加系统身份策略
        ///
        /// 在指定的权限集中添加系统身份策略。
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
        /// 创建权限集
        ///
        /// 在指定的IAM身份中心实例中创建一个权限集。
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
        /// 删除自定义身份策略
        ///
        /// 删除指定权限集中的自定义身份策略。
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
        /// 删除指定权限集中的自定义策略
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
        /// 根据权限集ID，删除指定的权限集。
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
        /// 根据权限集ID，查询指定权限集的详情信息。
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
        /// 根据请求ID，查询权限集预分配状态的详情信息。
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
        /// 删除系统身份策略
        ///
        /// 删除指定权限集中的系统身份策略。
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
        /// 查询自定义身份策略详情
        ///
        /// 查询指定权限集中的自定义身份策略详情。
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
        /// 获取分配给权限集的自定义策略
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
        /// 列出权限集关联的账号
        ///
        /// 查询与指定权限集关联的账号列表。
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
        /// 列出系统身份策略
        ///
        /// 获取添加到指定权限集中的系统身份策略列表。
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
        /// 列出权限集预分配状态
        ///
        /// 查询指定实例中的权限集预分配状态列表。
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
        /// 查询指定实例下的权限集列表。
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
        /// 列出分配给账号的权限集
        ///
        /// 查询分配给指定账号的权限集列表。
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
        /// 将指定权限集预分配给指定账号。
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
        /// 添加自定义身份策略
        ///
        /// 在指定的权限集中添加自定义身份策略。
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
        /// 将自定义策略附加到权限集
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
        /// 根据权限集ID，更新指定权限集的属性。
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
        /// 给指定的资源添加一个或多个标签。当前支持为权限集添加标签。
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
        /// 删除指定资源的指定标签
        ///
        /// 从指定资源中删除指定的标签。
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
        /// 列出绑定到指定资源的标签。当前支持为权限集添加标签。
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
        
        /// <summary>
        /// 添加系统策略
        ///
        /// 在指定的权限集中添加系统策略。
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
        /// 删除系统策略
        ///
        /// 删除指定权限集中的系统策略。
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
        /// 列出系统策略
        ///
        /// 获取添加到指定权限集中的系统策略列表。
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
        
    }
}