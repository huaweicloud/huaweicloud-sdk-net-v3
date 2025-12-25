using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Iam.V5.Model;

namespace HuaweiCloud.SDK.Iam.V5
{
    public partial class IamAsyncClient : Client
    {
        public static ClientBuilder<IamAsyncClient> NewBuilder()
        {
            return new ClientBuilder<IamAsyncClient>("GlobalCredentials,BasicCredentials");
        }

        
        /// <summary>
        /// 获取此账号中IAM实体使用情况和IAM配额的摘要信息
        ///
        /// 该接口可以用于获取此账号中IAM实体使用情况和IAM配额的摘要信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetAccountSummaryV5Response> GetAccountSummaryV5Async(GetAccountSummaryV5Request getAccountSummaryV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/account-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAccountSummaryV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetAccountSummaryV5Response>(response);
        }

        public AsyncInvoker<GetAccountSummaryV5Response> GetAccountSummaryV5AsyncInvoker(GetAccountSummaryV5Request getAccountSummaryV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/account-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAccountSummaryV5Request);
            return new AsyncInvoker<GetAccountSummaryV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetAccountSummaryV5Response>);
        }
        
        /// <summary>
        /// 获取账号非对称签名开关状态
        ///
        /// 该接口用于获取账号非对称签名开关的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetAsymmetricSignatureSwitchV5Response> GetAsymmetricSignatureSwitchV5Async(GetAsymmetricSignatureSwitchV5Request getAsymmetricSignatureSwitchV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/asymmetric-signature-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAsymmetricSignatureSwitchV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetAsymmetricSignatureSwitchV5Response>(response);
        }

        public AsyncInvoker<GetAsymmetricSignatureSwitchV5Response> GetAsymmetricSignatureSwitchV5AsyncInvoker(GetAsymmetricSignatureSwitchV5Request getAsymmetricSignatureSwitchV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/asymmetric-signature-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAsymmetricSignatureSwitchV5Request);
            return new AsyncInvoker<GetAsymmetricSignatureSwitchV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetAsymmetricSignatureSwitchV5Response>);
        }
        
        /// <summary>
        /// 获取此账号的功能状态
        ///
        /// 该接口可以用于获取此账号的功能状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetFeatureStatusV5Response> GetFeatureStatusV5Async(GetFeatureStatusV5Request getFeatureStatusV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getFeatureStatusV5Request.FeatureName, out var valueOfFeatureName)) urlParam.Add("feature_name", valueOfFeatureName);
            var urlPath = HttpUtils.AddUrlPath("/v5/features/{feature_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getFeatureStatusV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetFeatureStatusV5Response>(response);
        }

        public AsyncInvoker<GetFeatureStatusV5Response> GetFeatureStatusV5AsyncInvoker(GetFeatureStatusV5Request getFeatureStatusV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getFeatureStatusV5Request.FeatureName, out var valueOfFeatureName)) urlParam.Add("feature_name", valueOfFeatureName);
            var urlPath = HttpUtils.AddUrlPath("/v5/features/{feature_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getFeatureStatusV5Request);
            return new AsyncInvoker<GetFeatureStatusV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetFeatureStatusV5Response>);
        }
        
        /// <summary>
        /// 设置账号开启或关闭非对称签名
        ///
        /// 该接口用于设置账号开启或关闭非对称签名功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetAsymmetricSignatureSwitchV5Response> SetAsymmetricSignatureSwitchV5Async(SetAsymmetricSignatureSwitchV5Request setAsymmetricSignatureSwitchV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/asymmetric-signature-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAsymmetricSignatureSwitchV5Request);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetAsymmetricSignatureSwitchV5Response>(response);
        }

        public AsyncInvoker<SetAsymmetricSignatureSwitchV5Response> SetAsymmetricSignatureSwitchV5AsyncInvoker(SetAsymmetricSignatureSwitchV5Request setAsymmetricSignatureSwitchV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/asymmetric-signature-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAsymmetricSignatureSwitchV5Request);
            return new AsyncInvoker<SetAsymmetricSignatureSwitchV5Response>(this, "PUT", request, JsonUtils.DeSerializeNull<SetAsymmetricSignatureSwitchV5Response>);
        }
        
        /// <summary>
        /// 创建信任委托
        ///
        /// 该接口可以用于创建信任委托。
        /// 
        /// &gt; 信任委托只能授予身份策略且仅兼容支持身份策略的云服务，详情见[[支持身份策略与信任委托的云服务列表](https://support.huaweicloud.com/productdesc-iam/iam_01_1224.html)](tag:hws)[[支持身份策略与信任委托的云服务列表](https://support.huaweicloud.com/intl/zh-cn/productdesc-iam/iam_01_1224.html)](tag:hws_hk)[[支持身份策略与信任委托的云服务列表](https://support.huaweicloud.com/eu/productdesc-iam/iam_01_1224.html)](tag:hws_eu)[《统一身份认证用户指南》的“支持身份策略与信任委托的云服务列表”章节](tag:fcs,fcs_vm,ctc,hws_test,g42,tm)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAgencyV5Response> CreateAgencyV5Async(CreateAgencyV5Request createAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgencyV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAgencyV5Response>(response);
        }

        public AsyncInvoker<CreateAgencyV5Response> CreateAgencyV5AsyncInvoker(CreateAgencyV5Request createAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgencyV5Request);
            return new AsyncInvoker<CreateAgencyV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreateAgencyV5Response>);
        }
        
        /// <summary>
        /// 创建服务关联委托
        ///
        /// 该接口可以用于创建服务关联委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateServiceLinkedAgencyV5Response> CreateServiceLinkedAgencyV5Async(CreateServiceLinkedAgencyV5Request createServiceLinkedAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/service-linked-agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServiceLinkedAgencyV5Request);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<CreateServiceLinkedAgencyV5Response>(response);
        }

        public AsyncInvoker<CreateServiceLinkedAgencyV5Response> CreateServiceLinkedAgencyV5AsyncInvoker(CreateServiceLinkedAgencyV5Request createServiceLinkedAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/service-linked-agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServiceLinkedAgencyV5Request);
            return new AsyncInvoker<CreateServiceLinkedAgencyV5Response>(this, "PUT", request, JsonUtils.DeSerialize<CreateServiceLinkedAgencyV5Response>);
        }
        
        /// <summary>
        /// 删除信任委托
        ///
        /// 该接口可以用于删除信任委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAgencyV5Response> DeleteAgencyV5Async(DeleteAgencyV5Request deleteAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgencyV5Request);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAgencyV5Response>(response);
        }

        public AsyncInvoker<DeleteAgencyV5Response> DeleteAgencyV5AsyncInvoker(DeleteAgencyV5Request deleteAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgencyV5Request);
            return new AsyncInvoker<DeleteAgencyV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAgencyV5Response>);
        }
        
        /// <summary>
        /// 删除服务关联委托
        ///
        /// 该接口可以用于服务关联委托删除自己。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteServiceLinkedAgencyV5Response> DeleteServiceLinkedAgencyV5Async(DeleteServiceLinkedAgencyV5Request deleteServiceLinkedAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServiceLinkedAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/service-linked-agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceLinkedAgencyV5Request);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteServiceLinkedAgencyV5Response>(response);
        }

        public AsyncInvoker<DeleteServiceLinkedAgencyV5Response> DeleteServiceLinkedAgencyV5AsyncInvoker(DeleteServiceLinkedAgencyV5Request deleteServiceLinkedAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServiceLinkedAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/service-linked-agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceLinkedAgencyV5Request);
            return new AsyncInvoker<DeleteServiceLinkedAgencyV5Response>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteServiceLinkedAgencyV5Response>);
        }
        
        /// <summary>
        /// 查询委托或信任委托详情
        ///
        /// 该接口可以用于查询委托或信任委托详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetAgencyV5Response> GetAgencyV5Async(GetAgencyV5Request getAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAgencyV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetAgencyV5Response>(response);
        }

        public AsyncInvoker<GetAgencyV5Response> GetAgencyV5AsyncInvoker(GetAgencyV5Request getAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAgencyV5Request);
            return new AsyncInvoker<GetAgencyV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetAgencyV5Response>);
        }
        
        /// <summary>
        /// 获取服务关联委托删除状态
        ///
        /// 该接口可以用于获取服务关联委托删除状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetServiceLinkedAgencyDeletionStatusV5Response> GetServiceLinkedAgencyDeletionStatusV5Async(GetServiceLinkedAgencyDeletionStatusV5Request getServiceLinkedAgencyDeletionStatusV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getServiceLinkedAgencyDeletionStatusV5Request.DeletionTaskId, out var valueOfDeletionTaskId)) urlParam.Add("deletion_task_id", valueOfDeletionTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v5/service-linked-agencies/deletion-task/{deletion_task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getServiceLinkedAgencyDeletionStatusV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetServiceLinkedAgencyDeletionStatusV5Response>(response);
        }

        public AsyncInvoker<GetServiceLinkedAgencyDeletionStatusV5Response> GetServiceLinkedAgencyDeletionStatusV5AsyncInvoker(GetServiceLinkedAgencyDeletionStatusV5Request getServiceLinkedAgencyDeletionStatusV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getServiceLinkedAgencyDeletionStatusV5Request.DeletionTaskId, out var valueOfDeletionTaskId)) urlParam.Add("deletion_task_id", valueOfDeletionTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v5/service-linked-agencies/deletion-task/{deletion_task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getServiceLinkedAgencyDeletionStatusV5Request);
            return new AsyncInvoker<GetServiceLinkedAgencyDeletionStatusV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetServiceLinkedAgencyDeletionStatusV5Response>);
        }
        
        /// <summary>
        /// 查询指定条件下的委托及信任委托列表
        ///
        /// 该接口可以用于查询指定条件下的委托及信任委托列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAgenciesV5Response> ListAgenciesV5Async(ListAgenciesV5Request listAgenciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgenciesV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAgenciesV5Response>(response);
        }

        public AsyncInvoker<ListAgenciesV5Response> ListAgenciesV5AsyncInvoker(ListAgenciesV5Request listAgenciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgenciesV5Request);
            return new AsyncInvoker<ListAgenciesV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListAgenciesV5Response>);
        }
        
        /// <summary>
        /// 修改信任委托
        ///
        /// 该接口可以用于修改信任委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAgencyV5Response> UpdateAgencyV5Async(UpdateAgencyV5Request updateAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAgencyV5Request);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAgencyV5Response>(response);
        }

        public AsyncInvoker<UpdateAgencyV5Response> UpdateAgencyV5AsyncInvoker(UpdateAgencyV5Request updateAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAgencyV5Request);
            return new AsyncInvoker<UpdateAgencyV5Response>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAgencyV5Response>);
        }
        
        /// <summary>
        /// 修改信任委托信任策略
        ///
        /// 该接口可以用于修改信任委托信任策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTrustPolicyV5Response> UpdateTrustPolicyV5Async(UpdateTrustPolicyV5Request updateTrustPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTrustPolicyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}/trust-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrustPolicyV5Request);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTrustPolicyV5Response>(response);
        }

        public AsyncInvoker<UpdateTrustPolicyV5Response> UpdateTrustPolicyV5AsyncInvoker(UpdateTrustPolicyV5Request updateTrustPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTrustPolicyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}/trust-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrustPolicyV5Request);
            return new AsyncInvoker<UpdateTrustPolicyV5Response>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTrustPolicyV5Response>);
        }
        
        /// <summary>
        /// 查询指定服务授权概要
        ///
        /// 该接口可以用于查询指定云服务的授权概要。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetAuthorizationSchemaV5Response> GetAuthorizationSchemaV5Async(GetAuthorizationSchemaV5Request getAuthorizationSchemaV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAuthorizationSchemaV5Request.ServiceCode, out var valueOfServiceCode)) urlParam.Add("service_code", valueOfServiceCode);
            var urlPath = HttpUtils.AddUrlPath("/v5/authorization-schemas/services/{service_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAuthorizationSchemaV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetAuthorizationSchemaV5Response>(response);
        }

        public AsyncInvoker<GetAuthorizationSchemaV5Response> GetAuthorizationSchemaV5AsyncInvoker(GetAuthorizationSchemaV5Request getAuthorizationSchemaV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAuthorizationSchemaV5Request.ServiceCode, out var valueOfServiceCode)) urlParam.Add("service_code", valueOfServiceCode);
            var urlPath = HttpUtils.AddUrlPath("/v5/authorization-schemas/services/{service_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAuthorizationSchemaV5Request);
            return new AsyncInvoker<GetAuthorizationSchemaV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetAuthorizationSchemaV5Response>);
        }
        
        /// <summary>
        /// 查询已注册云服务列表
        ///
        /// 该接口可以用于查询已注册云服务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRegisteredServicesForAuthSchemaV5Response> ListRegisteredServicesForAuthSchemaV5Async(ListRegisteredServicesForAuthSchemaV5Request listRegisteredServicesForAuthSchemaV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/authorization-schemas/registered-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegisteredServicesForAuthSchemaV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRegisteredServicesForAuthSchemaV5Response>(response);
        }

        public AsyncInvoker<ListRegisteredServicesForAuthSchemaV5Response> ListRegisteredServicesForAuthSchemaV5AsyncInvoker(ListRegisteredServicesForAuthSchemaV5Request listRegisteredServicesForAuthSchemaV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/authorization-schemas/registered-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegisteredServicesForAuthSchemaV5Request);
            return new AsyncInvoker<ListRegisteredServicesForAuthSchemaV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListRegisteredServicesForAuthSchemaV5Response>);
        }
        
        /// <summary>
        /// 获取全部服务主体
        ///
        /// 该接口可以用于获取全部服务主体。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServicePrincipalsV5Response> ListServicePrincipalsV5Async(ListServicePrincipalsV5Request listServicePrincipalsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/service-principals", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicePrincipalsV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServicePrincipalsV5Response>(response);
        }

        public AsyncInvoker<ListServicePrincipalsV5Response> ListServicePrincipalsV5AsyncInvoker(ListServicePrincipalsV5Request listServicePrincipalsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/service-principals", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicePrincipalsV5Request);
            return new AsyncInvoker<ListServicePrincipalsV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListServicePrincipalsV5Response>);
        }
        
        /// <summary>
        /// 添加IAM用户到用户组
        ///
        /// 该接口可以用于添加IAM用户到用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddUserToGroupV5Response> AddUserToGroupV5Async(AddUserToGroupV5Request addUserToGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addUserToGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}/add-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addUserToGroupV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddUserToGroupV5Response>(response);
        }

        public AsyncInvoker<AddUserToGroupV5Response> AddUserToGroupV5AsyncInvoker(AddUserToGroupV5Request addUserToGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addUserToGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}/add-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addUserToGroupV5Request);
            return new AsyncInvoker<AddUserToGroupV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<AddUserToGroupV5Response>);
        }
        
        /// <summary>
        /// 创建用户组
        ///
        /// 该接口可以用于创建用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGroupV5Response> CreateGroupV5Async(CreateGroupV5Request createGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupV5Response>(response);
        }

        public AsyncInvoker<CreateGroupV5Response> CreateGroupV5AsyncInvoker(CreateGroupV5Request createGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupV5Request);
            return new AsyncInvoker<CreateGroupV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupV5Response>);
        }
        
        /// <summary>
        /// 删除用户组
        ///
        /// 该接口可以用于删除用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGroupV5Response> DeleteGroupV5Async(DeleteGroupV5Request deleteGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupV5Request);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupV5Response>(response);
        }

        public AsyncInvoker<DeleteGroupV5Response> DeleteGroupV5AsyncInvoker(DeleteGroupV5Request deleteGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupV5Request);
            return new AsyncInvoker<DeleteGroupV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupV5Response>);
        }
        
        /// <summary>
        /// 查询用户组列表
        ///
        /// 该接口可以用于查询用户组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupsV5Response> ListGroupsV5Async(ListGroupsV5Request listGroupsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGroupsV5Response>(response);
        }

        public AsyncInvoker<ListGroupsV5Response> ListGroupsV5AsyncInvoker(ListGroupsV5Request listGroupsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsV5Request);
            return new AsyncInvoker<ListGroupsV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListGroupsV5Response>);
        }
        
        /// <summary>
        /// 移除用户组中的IAM用户
        ///
        /// 该接口可以用于移除用户组中的IAM用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveUserFromGroupV5Response> RemoveUserFromGroupV5Async(RemoveUserFromGroupV5Request removeUserFromGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeUserFromGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}/remove-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeUserFromGroupV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RemoveUserFromGroupV5Response>(response);
        }

        public AsyncInvoker<RemoveUserFromGroupV5Response> RemoveUserFromGroupV5AsyncInvoker(RemoveUserFromGroupV5Request removeUserFromGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeUserFromGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}/remove-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeUserFromGroupV5Request);
            return new AsyncInvoker<RemoveUserFromGroupV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<RemoveUserFromGroupV5Response>);
        }
        
        /// <summary>
        /// 查询用户组相关属性
        ///
        /// 该接口可以用于查询用户组相关属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupSummaryResponse> ShowGroupSummaryAsync(ShowGroupSummaryRequest showGroupSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/groups-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupSummaryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupSummaryResponse>(response);
        }

        public AsyncInvoker<ShowGroupSummaryResponse> ShowGroupSummaryAsyncInvoker(ShowGroupSummaryRequest showGroupSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/groups-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupSummaryRequest);
            return new AsyncInvoker<ShowGroupSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupSummaryResponse>);
        }
        
        /// <summary>
        /// 查询用户组详情
        ///
        /// 该接口可以用于查询用户组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupV5Response> ShowGroupV5Async(ShowGroupV5Request showGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupV5Response>(response);
        }

        public AsyncInvoker<ShowGroupV5Response> ShowGroupV5AsyncInvoker(ShowGroupV5Request showGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupV5Request);
            return new AsyncInvoker<ShowGroupV5Response>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupV5Response>);
        }
        
        /// <summary>
        /// 修改用户组
        ///
        /// 该接口可以用于修改用户组信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGroupV5Response> UpdateGroupV5Async(UpdateGroupV5Request updateGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupV5Request);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGroupV5Response>(response);
        }

        public AsyncInvoker<UpdateGroupV5Response> UpdateGroupV5AsyncInvoker(UpdateGroupV5Request updateGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupV5Request);
            return new AsyncInvoker<UpdateGroupV5Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGroupV5Response>);
        }
        
        /// <summary>
        /// 创建MFA设备
        ///
        /// 该接口可以用于创建MFA设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVirtualMfaDeviceV5Response> CreateVirtualMfaDeviceV5Async(CreateVirtualMfaDeviceV5Request createVirtualMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVirtualMfaDeviceV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateVirtualMfaDeviceV5Response>(response);
        }

        public AsyncInvoker<CreateVirtualMfaDeviceV5Response> CreateVirtualMfaDeviceV5AsyncInvoker(CreateVirtualMfaDeviceV5Request createVirtualMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVirtualMfaDeviceV5Request);
            return new AsyncInvoker<CreateVirtualMfaDeviceV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreateVirtualMfaDeviceV5Response>);
        }
        
        /// <summary>
        /// 删除MFA设备
        ///
        /// 该接口可以用于删除MFA设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVirtualMfaDeviceV5Response> DeleteVirtualMfaDeviceV5Async(DeleteVirtualMfaDeviceV5Request deleteVirtualMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVirtualMfaDeviceV5Request);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVirtualMfaDeviceV5Response>(response);
        }

        public AsyncInvoker<DeleteVirtualMfaDeviceV5Response> DeleteVirtualMfaDeviceV5AsyncInvoker(DeleteVirtualMfaDeviceV5Request deleteVirtualMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVirtualMfaDeviceV5Request);
            return new AsyncInvoker<DeleteVirtualMfaDeviceV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVirtualMfaDeviceV5Response>);
        }
        
        /// <summary>
        /// 禁用MFA设备
        ///
        /// 该接口可以用于禁用指定的MFA设备并删除其与对应IAM用户的关联。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableMfaDeviceV5Response> DisableMfaDeviceV5Async(DisableMfaDeviceV5Request disableMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/mfa-devices/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableMfaDeviceV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisableMfaDeviceV5Response>(response);
        }

        public AsyncInvoker<DisableMfaDeviceV5Response> DisableMfaDeviceV5AsyncInvoker(DisableMfaDeviceV5Request disableMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/mfa-devices/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableMfaDeviceV5Request);
            return new AsyncInvoker<DisableMfaDeviceV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<DisableMfaDeviceV5Response>);
        }
        
        /// <summary>
        /// 启用MFA设备
        ///
        /// 该接口可以用于启用指定的MFA设备并将其与指定的IAM用户关联。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableMfaDeviceV5Response> EnableMfaDeviceV5Async(EnableMfaDeviceV5Request enableMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/mfa-devices/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableMfaDeviceV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<EnableMfaDeviceV5Response>(response);
        }

        public AsyncInvoker<EnableMfaDeviceV5Response> EnableMfaDeviceV5AsyncInvoker(EnableMfaDeviceV5Request enableMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/mfa-devices/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableMfaDeviceV5Request);
            return new AsyncInvoker<EnableMfaDeviceV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<EnableMfaDeviceV5Response>);
        }
        
        /// <summary>
        /// 列举全部MFA设备
        ///
        /// 该接口可以用于列举全部MFA设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMfaDevicesV5Response> ListMfaDevicesV5Async(ListMfaDevicesV5Request listMfaDevicesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMfaDevicesV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMfaDevicesV5Response>(response);
        }

        public AsyncInvoker<ListMfaDevicesV5Response> ListMfaDevicesV5AsyncInvoker(ListMfaDevicesV5Request listMfaDevicesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMfaDevicesV5Request);
            return new AsyncInvoker<ListMfaDevicesV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListMfaDevicesV5Response>);
        }
        
        /// <summary>
        /// 创建自定义身份策略
        ///
        /// 该接口可以用于创建一个默认版本为v1的新自定义身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePolicyV5Response> CreatePolicyV5Async(CreatePolicyV5Request createPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyV5Response>(response);
        }

        public AsyncInvoker<CreatePolicyV5Response> CreatePolicyV5AsyncInvoker(CreatePolicyV5Request createPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyV5Request);
            return new AsyncInvoker<CreatePolicyV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyV5Response>);
        }
        
        /// <summary>
        /// 为指定身份策略创建一个新版本
        ///
        /// 该接口可以用于为指定身份策略创建一个新版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePolicyVersionV5Response> CreatePolicyVersionV5Async(CreatePolicyVersionV5Request createPolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyVersionV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyVersionV5Response>(response);
        }

        public AsyncInvoker<CreatePolicyVersionV5Response> CreatePolicyVersionV5AsyncInvoker(CreatePolicyVersionV5Request createPolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyVersionV5Request);
            return new AsyncInvoker<CreatePolicyVersionV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyVersionV5Response>);
        }
        
        /// <summary>
        /// 删除自定义身份策略
        ///
        /// 该接口可以用于删除一个存在的自定义身份策略，必须确保该自定义身份策略没有附加在任何IAM用户、用户组、委托或信任委托上。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePolicyV5Response> DeletePolicyV5Async(DeletePolicyV5Request deletePolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyV5Request);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyV5Response>(response);
        }

        public AsyncInvoker<DeletePolicyV5Response> DeletePolicyV5AsyncInvoker(DeletePolicyV5Request deletePolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyV5Request);
            return new AsyncInvoker<DeletePolicyV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyV5Response>);
        }
        
        /// <summary>
        /// 删除指定身份策略版本
        ///
        /// 该接口可以用于删除指定身份策略的指定版本。默认身份策略版本不能被删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePolicyVersionV5Response> DeletePolicyVersionV5Async(DeletePolicyVersionV5Request deletePolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyVersionV5Request.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyVersionV5Request);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyVersionV5Response>(response);
        }

        public AsyncInvoker<DeletePolicyVersionV5Response> DeletePolicyVersionV5AsyncInvoker(DeletePolicyVersionV5Request deletePolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyVersionV5Request.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyVersionV5Request);
            return new AsyncInvoker<DeletePolicyVersionV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyVersionV5Response>);
        }
        
        /// <summary>
        /// 通过身份策略ID获取身份策略
        ///
        /// 该接口可以用于通过身份策略ID获取身份策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetPolicyV5Response> GetPolicyV5Async(GetPolicyV5Request getPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getPolicyV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetPolicyV5Response>(response);
        }

        public AsyncInvoker<GetPolicyV5Response> GetPolicyV5AsyncInvoker(GetPolicyV5Request getPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getPolicyV5Request);
            return new AsyncInvoker<GetPolicyV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetPolicyV5Response>);
        }
        
        /// <summary>
        /// 查询指定身份策略版本
        ///
        /// 该接口可以用于查询指定身份策略的指定版本的相关信息，包括身份策略文档。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetPolicyVersionV5Response> GetPolicyVersionV5Async(GetPolicyVersionV5Request getPolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getPolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(getPolicyVersionV5Request.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getPolicyVersionV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetPolicyVersionV5Response>(response);
        }

        public AsyncInvoker<GetPolicyVersionV5Response> GetPolicyVersionV5AsyncInvoker(GetPolicyVersionV5Request getPolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getPolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(getPolicyVersionV5Request.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getPolicyVersionV5Request);
            return new AsyncInvoker<GetPolicyVersionV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetPolicyVersionV5Response>);
        }
        
        /// <summary>
        /// 查询所有身份策略
        ///
        /// 该接口可以用于查询所有身份策略，包含系统预置身份策略和自定义身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPoliciesV5Response> ListPoliciesV5Async(ListPoliciesV5Request listPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPoliciesV5Response>(response);
        }

        public AsyncInvoker<ListPoliciesV5Response> ListPoliciesV5AsyncInvoker(ListPoliciesV5Request listPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesV5Request);
            return new AsyncInvoker<ListPoliciesV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListPoliciesV5Response>);
        }
        
        /// <summary>
        /// 查询指定身份策略的所有版本
        ///
        /// 该接口可以用于查询指定身份策略的所有版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyVersionsV5Response> ListPolicyVersionsV5Async(ListPolicyVersionsV5Request listPolicyVersionsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyVersionsV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyVersionsV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyVersionsV5Response>(response);
        }

        public AsyncInvoker<ListPolicyVersionsV5Response> ListPolicyVersionsV5AsyncInvoker(ListPolicyVersionsV5Request listPolicyVersionsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyVersionsV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyVersionsV5Request);
            return new AsyncInvoker<ListPolicyVersionsV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyVersionsV5Response>);
        }
        
        /// <summary>
        /// 将指定身份策略版本设置为默认版本
        ///
        /// 该接口可以用于将指定身份策略的指定版本设置为默认版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetDefaultPolicyVersionV5Response> SetDefaultPolicyVersionV5Async(SetDefaultPolicyVersionV5Request setDefaultPolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setDefaultPolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(setDefaultPolicyVersionV5Request.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions/{version_id}/set-default", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDefaultPolicyVersionV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SetDefaultPolicyVersionV5Response>(response);
        }

        public AsyncInvoker<SetDefaultPolicyVersionV5Response> SetDefaultPolicyVersionV5AsyncInvoker(SetDefaultPolicyVersionV5Request setDefaultPolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setDefaultPolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(setDefaultPolicyVersionV5Request.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions/{version_id}/set-default", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDefaultPolicyVersionV5Request);
            return new AsyncInvoker<SetDefaultPolicyVersionV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<SetDefaultPolicyVersionV5Response>);
        }
        
        /// <summary>
        /// 为委托或信任委托附加身份策略
        ///
        /// 该接口可以用于为指定委托或信任委托附加指定身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachAgencyPolicyV5Response> AttachAgencyPolicyV5Async(AttachAgencyPolicyV5Request attachAgencyPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachAgencyPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attach-agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachAgencyPolicyV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AttachAgencyPolicyV5Response>(response);
        }

        public AsyncInvoker<AttachAgencyPolicyV5Response> AttachAgencyPolicyV5AsyncInvoker(AttachAgencyPolicyV5Request attachAgencyPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachAgencyPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attach-agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachAgencyPolicyV5Request);
            return new AsyncInvoker<AttachAgencyPolicyV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<AttachAgencyPolicyV5Response>);
        }
        
        /// <summary>
        /// 为用户组附加身份策略
        ///
        /// 该接口可以用于为指定用户组附加指定身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachGroupPolicyV5Response> AttachGroupPolicyV5Async(AttachGroupPolicyV5Request attachGroupPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachGroupPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attach-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachGroupPolicyV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AttachGroupPolicyV5Response>(response);
        }

        public AsyncInvoker<AttachGroupPolicyV5Response> AttachGroupPolicyV5AsyncInvoker(AttachGroupPolicyV5Request attachGroupPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachGroupPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attach-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachGroupPolicyV5Request);
            return new AsyncInvoker<AttachGroupPolicyV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<AttachGroupPolicyV5Response>);
        }
        
        /// <summary>
        /// 为IAM用户附加身份策略
        ///
        /// 该接口可以用于为指定IAM用户附加指定身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachUserPolicyV5Response> AttachUserPolicyV5Async(AttachUserPolicyV5Request attachUserPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachUserPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attach-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachUserPolicyV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AttachUserPolicyV5Response>(response);
        }

        public AsyncInvoker<AttachUserPolicyV5Response> AttachUserPolicyV5AsyncInvoker(AttachUserPolicyV5Request attachUserPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachUserPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attach-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachUserPolicyV5Request);
            return new AsyncInvoker<AttachUserPolicyV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<AttachUserPolicyV5Response>);
        }
        
        /// <summary>
        /// 从委托或信任委托分离身份策略
        ///
        /// 该接口可以用于从指定委托或信任委托中分离指定身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetachAgencyPolicyV5Response> DetachAgencyPolicyV5Async(DetachAgencyPolicyV5Request detachAgencyPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachAgencyPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/detach-agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachAgencyPolicyV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DetachAgencyPolicyV5Response>(response);
        }

        public AsyncInvoker<DetachAgencyPolicyV5Response> DetachAgencyPolicyV5AsyncInvoker(DetachAgencyPolicyV5Request detachAgencyPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachAgencyPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/detach-agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachAgencyPolicyV5Request);
            return new AsyncInvoker<DetachAgencyPolicyV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<DetachAgencyPolicyV5Response>);
        }
        
        /// <summary>
        /// 从用户组分离身份策略
        ///
        /// 该接口可以用于从指定用户组分离指定身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetachGroupPolicyV5Response> DetachGroupPolicyV5Async(DetachGroupPolicyV5Request detachGroupPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachGroupPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/detach-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachGroupPolicyV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DetachGroupPolicyV5Response>(response);
        }

        public AsyncInvoker<DetachGroupPolicyV5Response> DetachGroupPolicyV5AsyncInvoker(DetachGroupPolicyV5Request detachGroupPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachGroupPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/detach-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachGroupPolicyV5Request);
            return new AsyncInvoker<DetachGroupPolicyV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<DetachGroupPolicyV5Response>);
        }
        
        /// <summary>
        /// 从IAM用户分离身份策略
        ///
        /// 该接口可以用于从指定的IAM用户分离指定身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetachUserPolicyV5Response> DetachUserPolicyV5Async(DetachUserPolicyV5Request detachUserPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachUserPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/detach-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachUserPolicyV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DetachUserPolicyV5Response>(response);
        }

        public AsyncInvoker<DetachUserPolicyV5Response> DetachUserPolicyV5AsyncInvoker(DetachUserPolicyV5Request detachUserPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachUserPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/detach-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachUserPolicyV5Request);
            return new AsyncInvoker<DetachUserPolicyV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<DetachUserPolicyV5Response>);
        }
        
        /// <summary>
        /// 查询指定委托或信任委托附加的所有身份策略
        ///
        /// 该接口可用于查询指定委托或信任委托附加的所有身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAttachedAgencyPoliciesV5Response> ListAttachedAgencyPoliciesV5Async(ListAttachedAgencyPoliciesV5Request listAttachedAgencyPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAttachedAgencyPoliciesV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}/attached-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttachedAgencyPoliciesV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAttachedAgencyPoliciesV5Response>(response);
        }

        public AsyncInvoker<ListAttachedAgencyPoliciesV5Response> ListAttachedAgencyPoliciesV5AsyncInvoker(ListAttachedAgencyPoliciesV5Request listAttachedAgencyPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAttachedAgencyPoliciesV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}/attached-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttachedAgencyPoliciesV5Request);
            return new AsyncInvoker<ListAttachedAgencyPoliciesV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListAttachedAgencyPoliciesV5Response>);
        }
        
        /// <summary>
        /// 查询指定用户组附加的所有身份策略
        ///
        /// 该接口可用于查询指定用户组附加的所有身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAttachedGroupPoliciesV5Response> ListAttachedGroupPoliciesV5Async(ListAttachedGroupPoliciesV5Request listAttachedGroupPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAttachedGroupPoliciesV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}/attached-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttachedGroupPoliciesV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAttachedGroupPoliciesV5Response>(response);
        }

        public AsyncInvoker<ListAttachedGroupPoliciesV5Response> ListAttachedGroupPoliciesV5AsyncInvoker(ListAttachedGroupPoliciesV5Request listAttachedGroupPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAttachedGroupPoliciesV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}/attached-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttachedGroupPoliciesV5Request);
            return new AsyncInvoker<ListAttachedGroupPoliciesV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListAttachedGroupPoliciesV5Response>);
        }
        
        /// <summary>
        /// 查询指定IAM用户附加的所有身份策略
        ///
        /// 该接口可用于查询指定IAM用户附加的所有身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAttachedUserPoliciesV5Response> ListAttachedUserPoliciesV5Async(ListAttachedUserPoliciesV5Request listAttachedUserPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAttachedUserPoliciesV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/attached-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttachedUserPoliciesV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAttachedUserPoliciesV5Response>(response);
        }

        public AsyncInvoker<ListAttachedUserPoliciesV5Response> ListAttachedUserPoliciesV5AsyncInvoker(ListAttachedUserPoliciesV5Request listAttachedUserPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAttachedUserPoliciesV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/attached-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttachedUserPoliciesV5Request);
            return new AsyncInvoker<ListAttachedUserPoliciesV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListAttachedUserPoliciesV5Response>);
        }
        
        /// <summary>
        /// 查询指定身份策略附加的所有实体
        ///
        /// 该接口可用于查询指定身份策略附加的所有实体。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEntitiesForPolicyV5Response> ListEntitiesForPolicyV5Async(ListEntitiesForPolicyV5Request listEntitiesForPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEntitiesForPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attached-entities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEntitiesForPolicyV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEntitiesForPolicyV5Response>(response);
        }

        public AsyncInvoker<ListEntitiesForPolicyV5Response> ListEntitiesForPolicyV5AsyncInvoker(ListEntitiesForPolicyV5Request listEntitiesForPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEntitiesForPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attached-entities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEntitiesForPolicyV5Request);
            return new AsyncInvoker<ListEntitiesForPolicyV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListEntitiesForPolicyV5Response>);
        }
        
        /// <summary>
        /// 删除指定资源的部分标签
        ///
        /// 该接口可以用于删除指定资源的部分标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteResourceTagsV5Response> DeleteResourceTagsV5Async(DeleteResourceTagsV5Request deleteResourceTagsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceTagsV5Request.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceTagsV5Request.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v5/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceTagsV5Request);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteResourceTagsV5Response>(response);
        }

        public AsyncInvoker<DeleteResourceTagsV5Response> DeleteResourceTagsV5AsyncInvoker(DeleteResourceTagsV5Request deleteResourceTagsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceTagsV5Request.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceTagsV5Request.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v5/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceTagsV5Request);
            return new AsyncInvoker<DeleteResourceTagsV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteResourceTagsV5Response>);
        }
        
        /// <summary>
        /// 获取指定资源的所有标签
        ///
        /// 该接口可以用于获取指定资源的所有标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceTagsV5Response> ListResourceTagsV5Async(ListResourceTagsV5Request listResourceTagsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsV5Request.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsV5Request.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v5/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceTagsV5Response>(response);
        }

        public AsyncInvoker<ListResourceTagsV5Response> ListResourceTagsV5AsyncInvoker(ListResourceTagsV5Request listResourceTagsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsV5Request.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsV5Request.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v5/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsV5Request);
            return new AsyncInvoker<ListResourceTagsV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListResourceTagsV5Response>);
        }
        
        /// <summary>
        /// 为IAM资源打上标签
        ///
        /// 该接口可以用于为IAM资源打上标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<TagResourceV5Response> TagResourceV5Async(TagResourceV5Request tagResourceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(tagResourceV5Request.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(tagResourceV5Request.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v5/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagResourceV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<TagResourceV5Response>(response);
        }

        public AsyncInvoker<TagResourceV5Response> TagResourceV5AsyncInvoker(TagResourceV5Request tagResourceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(tagResourceV5Request.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(tagResourceV5Request.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v5/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagResourceV5Request);
            return new AsyncInvoker<TagResourceV5Response>(this, "POST", request, JsonUtils.DeSerialize<TagResourceV5Response>);
        }
        
        /// <summary>
        /// 查询账号登录策略
        ///
        /// 该接口可以用于查询账号登录策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLoginPolicyV5Response> ShowLoginPolicyV5Async(ShowLoginPolicyV5Request showLoginPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoginPolicyV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLoginPolicyV5Response>(response);
        }

        public AsyncInvoker<ShowLoginPolicyV5Response> ShowLoginPolicyV5AsyncInvoker(ShowLoginPolicyV5Request showLoginPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoginPolicyV5Request);
            return new AsyncInvoker<ShowLoginPolicyV5Response>(this, "GET", request, JsonUtils.DeSerialize<ShowLoginPolicyV5Response>);
        }
        
        /// <summary>
        /// 查询账号密码策略
        ///
        /// 该接口可以用于查询账号密码策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPasswordPolicyV5Response> ShowPasswordPolicyV5Async(ShowPasswordPolicyV5Request showPasswordPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPasswordPolicyV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPasswordPolicyV5Response>(response);
        }

        public AsyncInvoker<ShowPasswordPolicyV5Response> ShowPasswordPolicyV5AsyncInvoker(ShowPasswordPolicyV5Request showPasswordPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPasswordPolicyV5Request);
            return new AsyncInvoker<ShowPasswordPolicyV5Response>(this, "GET", request, JsonUtils.DeSerialize<ShowPasswordPolicyV5Response>);
        }
        
        /// <summary>
        /// 修改账号登录策略
        ///
        /// 该接口可以用于修改账号登录策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLoginPolicyV5Response> UpdateLoginPolicyV5Async(UpdateLoginPolicyV5Request updateLoginPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLoginPolicyV5Request);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLoginPolicyV5Response>(response);
        }

        public AsyncInvoker<UpdateLoginPolicyV5Response> UpdateLoginPolicyV5AsyncInvoker(UpdateLoginPolicyV5Request updateLoginPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLoginPolicyV5Request);
            return new AsyncInvoker<UpdateLoginPolicyV5Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLoginPolicyV5Response>);
        }
        
        /// <summary>
        /// 修改账号密码策略
        ///
        /// 该接口可以用于修改账号密码策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePasswordPolicyV5Response> UpdatePasswordPolicyV5Async(UpdatePasswordPolicyV5Request updatePasswordPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePasswordPolicyV5Request);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePasswordPolicyV5Response>(response);
        }

        public AsyncInvoker<UpdatePasswordPolicyV5Response> UpdatePasswordPolicyV5AsyncInvoker(UpdatePasswordPolicyV5Request updatePasswordPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePasswordPolicyV5Request);
            return new AsyncInvoker<UpdatePasswordPolicyV5Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePasswordPolicyV5Response>);
        }
        
        /// <summary>
        /// 创建IAM用户
        ///
        /// 该接口可以用于创建IAM用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateUserV5Response> CreateUserV5Async(CreateUserV5Request createUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateUserV5Response>(response);
        }

        public AsyncInvoker<CreateUserV5Response> CreateUserV5AsyncInvoker(CreateUserV5Request createUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserV5Request);
            return new AsyncInvoker<CreateUserV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreateUserV5Response>);
        }
        
        /// <summary>
        /// 删除IAM用户
        ///
        /// 该接口可以用于删除指定IAM用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteUserV5Response> DeleteUserV5Async(DeleteUserV5Request deleteUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserV5Request);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserV5Response>(response);
        }

        public AsyncInvoker<DeleteUserV5Response> DeleteUserV5AsyncInvoker(DeleteUserV5Request deleteUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserV5Request);
            return new AsyncInvoker<DeleteUserV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserV5Response>);
        }
        
        /// <summary>
        /// 查询IAM用户列表
        ///
        /// 该接口可以用于查询IAM用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUsersV5Response> ListUsersV5Async(ListUsersV5Request listUsersV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUsersV5Response>(response);
        }

        public AsyncInvoker<ListUsersV5Response> ListUsersV5AsyncInvoker(ListUsersV5Request listUsersV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersV5Request);
            return new AsyncInvoker<ListUsersV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListUsersV5Response>);
        }
        
        /// <summary>
        /// 查询IAM用户最后登录时间
        ///
        /// 该接口可以用于查询IAM用户的最后登录时间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserLastLoginV5Response> ShowUserLastLoginV5Async(ShowUserLastLoginV5Request showUserLastLoginV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserLastLoginV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/last-login", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserLastLoginV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserLastLoginV5Response>(response);
        }

        public AsyncInvoker<ShowUserLastLoginV5Response> ShowUserLastLoginV5AsyncInvoker(ShowUserLastLoginV5Request showUserLastLoginV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserLastLoginV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/last-login", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserLastLoginV5Request);
            return new AsyncInvoker<ShowUserLastLoginV5Response>(this, "GET", request, JsonUtils.DeSerialize<ShowUserLastLoginV5Response>);
        }
        
        /// <summary>
        /// 查询IAM用户详情
        ///
        /// 该接口可以用于查询IAM用户详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserV5Response> ShowUserV5Async(ShowUserV5Request showUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserV5Response>(response);
        }

        public AsyncInvoker<ShowUserV5Response> ShowUserV5AsyncInvoker(ShowUserV5Request showUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserV5Request);
            return new AsyncInvoker<ShowUserV5Response>(this, "GET", request, JsonUtils.DeSerialize<ShowUserV5Response>);
        }
        
        /// <summary>
        /// 修改IAM用户信息
        ///
        /// 该接口可以用于修改IAM用户信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUserV5Response> UpdateUserV5Async(UpdateUserV5Request updateUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserV5Request);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUserV5Response>(response);
        }

        public AsyncInvoker<UpdateUserV5Response> UpdateUserV5AsyncInvoker(UpdateUserV5Request updateUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserV5Request);
            return new AsyncInvoker<UpdateUserV5Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUserV5Response>);
        }
        
        /// <summary>
        /// 修改IAM用户密码
        ///
        /// 该接口可以用于IAM用户修改自己的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangePasswordV5Response> ChangePasswordV5Async(ChangePasswordV5Request changePasswordV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/caller-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changePasswordV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ChangePasswordV5Response>(response);
        }

        public AsyncInvoker<ChangePasswordV5Response> ChangePasswordV5AsyncInvoker(ChangePasswordV5Request changePasswordV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/caller-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changePasswordV5Request);
            return new AsyncInvoker<ChangePasswordV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<ChangePasswordV5Response>);
        }
        
        /// <summary>
        /// 创建永久访问密钥
        ///
        /// 该接口可以用于给IAM用户创建永久访问密钥。
        /// 
        /// 访问密钥（Access Key ID/Secret Access Key，简称AK/SK），是您通过开发工具（API、CLI、SDK）访问的身份凭证，不用于登录控制台。系统通过AK识别访问用户的身份，通过SK进行签名验证，通过加密签名验证可以确保请求的机密性、完整性和请求者身份的正确性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAccessKeyV5Response> CreateAccessKeyV5Async(CreateAccessKeyV5Request createAccessKeyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAccessKeyV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessKeyV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAccessKeyV5Response>(response);
        }

        public AsyncInvoker<CreateAccessKeyV5Response> CreateAccessKeyV5AsyncInvoker(CreateAccessKeyV5Request createAccessKeyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAccessKeyV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessKeyV5Request);
            return new AsyncInvoker<CreateAccessKeyV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreateAccessKeyV5Response>);
        }
        
        /// <summary>
        /// 创建IAM用户登录信息
        ///
        /// 该接口可以用于创建指定IAM用户的登录信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLoginProfileV5Response> CreateLoginProfileV5Async(CreateLoginProfileV5Request createLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLoginProfileV5Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLoginProfileV5Response>(response);
        }

        public AsyncInvoker<CreateLoginProfileV5Response> CreateLoginProfileV5AsyncInvoker(CreateLoginProfileV5Request createLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLoginProfileV5Request);
            return new AsyncInvoker<CreateLoginProfileV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreateLoginProfileV5Response>);
        }
        
        /// <summary>
        /// 删除指定永久访问密钥
        ///
        /// 该接口可以用于删除IAM用户的指定永久访问密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAccessKeyV5Response> DeleteAccessKeyV5Async(DeleteAccessKeyV5Request deleteAccessKeyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyV5Request.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccessKeyV5Request);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAccessKeyV5Response>(response);
        }

        public AsyncInvoker<DeleteAccessKeyV5Response> DeleteAccessKeyV5AsyncInvoker(DeleteAccessKeyV5Request deleteAccessKeyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyV5Request.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccessKeyV5Request);
            return new AsyncInvoker<DeleteAccessKeyV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAccessKeyV5Response>);
        }
        
        /// <summary>
        /// 删除IAM用户登录信息
        ///
        /// 该接口可以用于删除指定IAM用户的登录信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLoginProfileV5Response> DeleteLoginProfileV5Async(DeleteLoginProfileV5Request deleteLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoginProfileV5Request);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLoginProfileV5Response>(response);
        }

        public AsyncInvoker<DeleteLoginProfileV5Response> DeleteLoginProfileV5AsyncInvoker(DeleteLoginProfileV5Request deleteLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoginProfileV5Request);
            return new AsyncInvoker<DeleteLoginProfileV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLoginProfileV5Response>);
        }
        
        /// <summary>
        /// 查询所有永久访问密钥
        ///
        /// 该接口可以用于查询IAM用户的所有永久访问密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccessKeysV5Response> ListAccessKeysV5Async(ListAccessKeysV5Request listAccessKeysV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccessKeysV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessKeysV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccessKeysV5Response>(response);
        }

        public AsyncInvoker<ListAccessKeysV5Response> ListAccessKeysV5AsyncInvoker(ListAccessKeysV5Request listAccessKeysV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccessKeysV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessKeysV5Request);
            return new AsyncInvoker<ListAccessKeysV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListAccessKeysV5Response>);
        }
        
        /// <summary>
        /// 查询指定永久访问密钥最后使用时间
        ///
        /// 该接口可以用于查询IAM用户的指定永久访问密钥的最后使用时间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAccessKeyLastUsedV5Response> ShowAccessKeyLastUsedV5Async(ShowAccessKeyLastUsedV5Request showAccessKeyLastUsedV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyLastUsedV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyLastUsedV5Request.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys/{access_key_id}/last-used", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessKeyLastUsedV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAccessKeyLastUsedV5Response>(response);
        }

        public AsyncInvoker<ShowAccessKeyLastUsedV5Response> ShowAccessKeyLastUsedV5AsyncInvoker(ShowAccessKeyLastUsedV5Request showAccessKeyLastUsedV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyLastUsedV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyLastUsedV5Request.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys/{access_key_id}/last-used", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessKeyLastUsedV5Request);
            return new AsyncInvoker<ShowAccessKeyLastUsedV5Response>(this, "GET", request, JsonUtils.DeSerialize<ShowAccessKeyLastUsedV5Response>);
        }
        
        /// <summary>
        /// 查询IAM用户登录信息
        ///
        /// 该接口可以用于查询指定IAM用户的登录信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLoginProfileV5Response> ShowLoginProfileV5Async(ShowLoginProfileV5Request showLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoginProfileV5Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLoginProfileV5Response>(response);
        }

        public AsyncInvoker<ShowLoginProfileV5Response> ShowLoginProfileV5AsyncInvoker(ShowLoginProfileV5Request showLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoginProfileV5Request);
            return new AsyncInvoker<ShowLoginProfileV5Response>(this, "GET", request, JsonUtils.DeSerialize<ShowLoginProfileV5Response>);
        }
        
        /// <summary>
        /// 修改指定永久访问密钥
        ///
        /// 该接口可以用于修改IAM用户的指定永久访问密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAccessKeyV5Response> UpdateAccessKeyV5Async(UpdateAccessKeyV5Request updateAccessKeyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAccessKeyV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(updateAccessKeyV5Request.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessKeyV5Request);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAccessKeyV5Response>(response);
        }

        public AsyncInvoker<UpdateAccessKeyV5Response> UpdateAccessKeyV5AsyncInvoker(UpdateAccessKeyV5Request updateAccessKeyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAccessKeyV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(updateAccessKeyV5Request.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessKeyV5Request);
            return new AsyncInvoker<UpdateAccessKeyV5Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAccessKeyV5Response>);
        }
        
        /// <summary>
        /// 修改IAM用户登录信息
        ///
        /// 该接口可以用于修改指定IAM用户的登录信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLoginProfileV5Response> UpdateLoginProfileV5Async(UpdateLoginProfileV5Request updateLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLoginProfileV5Request);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLoginProfileV5Response>(response);
        }

        public AsyncInvoker<UpdateLoginProfileV5Response> UpdateLoginProfileV5AsyncInvoker(UpdateLoginProfileV5Request updateLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLoginProfileV5Request);
            return new AsyncInvoker<UpdateLoginProfileV5Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLoginProfileV5Response>);
        }
        
    }
}