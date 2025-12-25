using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Iam.V5.Model;

namespace HuaweiCloud.SDK.Iam.V5
{
    public partial class IamClient : Client
    {
        public static ClientBuilder<IamClient> NewBuilder()
        {
            return new ClientBuilder<IamClient>("GlobalCredentials,BasicCredentials");
        }

        
        /// <summary>
        /// 获取此账号中IAM实体使用情况和IAM配额的摘要信息
        ///
        /// 该接口可以用于获取此账号中IAM实体使用情况和IAM配额的摘要信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetAccountSummaryV5Response GetAccountSummaryV5(GetAccountSummaryV5Request getAccountSummaryV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/account-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAccountSummaryV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetAccountSummaryV5Response>(response);
        }

        public SyncInvoker<GetAccountSummaryV5Response> GetAccountSummaryV5Invoker(GetAccountSummaryV5Request getAccountSummaryV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/account-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAccountSummaryV5Request);
            return new SyncInvoker<GetAccountSummaryV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetAccountSummaryV5Response>);
        }
        
        /// <summary>
        /// 获取账号非对称签名开关状态
        ///
        /// 该接口用于获取账号非对称签名开关的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetAsymmetricSignatureSwitchV5Response GetAsymmetricSignatureSwitchV5(GetAsymmetricSignatureSwitchV5Request getAsymmetricSignatureSwitchV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/asymmetric-signature-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAsymmetricSignatureSwitchV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetAsymmetricSignatureSwitchV5Response>(response);
        }

        public SyncInvoker<GetAsymmetricSignatureSwitchV5Response> GetAsymmetricSignatureSwitchV5Invoker(GetAsymmetricSignatureSwitchV5Request getAsymmetricSignatureSwitchV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/asymmetric-signature-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAsymmetricSignatureSwitchV5Request);
            return new SyncInvoker<GetAsymmetricSignatureSwitchV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetAsymmetricSignatureSwitchV5Response>);
        }
        
        /// <summary>
        /// 获取此账号的功能状态
        ///
        /// 该接口可以用于获取此账号的功能状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetFeatureStatusV5Response GetFeatureStatusV5(GetFeatureStatusV5Request getFeatureStatusV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getFeatureStatusV5Request.FeatureName, out var valueOfFeatureName)) urlParam.Add("feature_name", valueOfFeatureName);
            var urlPath = HttpUtils.AddUrlPath("/v5/features/{feature_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getFeatureStatusV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetFeatureStatusV5Response>(response);
        }

        public SyncInvoker<GetFeatureStatusV5Response> GetFeatureStatusV5Invoker(GetFeatureStatusV5Request getFeatureStatusV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getFeatureStatusV5Request.FeatureName, out var valueOfFeatureName)) urlParam.Add("feature_name", valueOfFeatureName);
            var urlPath = HttpUtils.AddUrlPath("/v5/features/{feature_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getFeatureStatusV5Request);
            return new SyncInvoker<GetFeatureStatusV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetFeatureStatusV5Response>);
        }
        
        /// <summary>
        /// 设置账号开启或关闭非对称签名
        ///
        /// 该接口用于设置账号开启或关闭非对称签名功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetAsymmetricSignatureSwitchV5Response SetAsymmetricSignatureSwitchV5(SetAsymmetricSignatureSwitchV5Request setAsymmetricSignatureSwitchV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/asymmetric-signature-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAsymmetricSignatureSwitchV5Request);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetAsymmetricSignatureSwitchV5Response>(response);
        }

        public SyncInvoker<SetAsymmetricSignatureSwitchV5Response> SetAsymmetricSignatureSwitchV5Invoker(SetAsymmetricSignatureSwitchV5Request setAsymmetricSignatureSwitchV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/asymmetric-signature-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setAsymmetricSignatureSwitchV5Request);
            return new SyncInvoker<SetAsymmetricSignatureSwitchV5Response>(this, "PUT", request, JsonUtils.DeSerializeNull<SetAsymmetricSignatureSwitchV5Response>);
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
        public CreateAgencyV5Response CreateAgencyV5(CreateAgencyV5Request createAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgencyV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAgencyV5Response>(response);
        }

        public SyncInvoker<CreateAgencyV5Response> CreateAgencyV5Invoker(CreateAgencyV5Request createAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgencyV5Request);
            return new SyncInvoker<CreateAgencyV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreateAgencyV5Response>);
        }
        
        /// <summary>
        /// 创建服务关联委托
        ///
        /// 该接口可以用于创建服务关联委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateServiceLinkedAgencyV5Response CreateServiceLinkedAgencyV5(CreateServiceLinkedAgencyV5Request createServiceLinkedAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/service-linked-agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServiceLinkedAgencyV5Request);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CreateServiceLinkedAgencyV5Response>(response);
        }

        public SyncInvoker<CreateServiceLinkedAgencyV5Response> CreateServiceLinkedAgencyV5Invoker(CreateServiceLinkedAgencyV5Request createServiceLinkedAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/service-linked-agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServiceLinkedAgencyV5Request);
            return new SyncInvoker<CreateServiceLinkedAgencyV5Response>(this, "PUT", request, JsonUtils.DeSerialize<CreateServiceLinkedAgencyV5Response>);
        }
        
        /// <summary>
        /// 删除信任委托
        ///
        /// 该接口可以用于删除信任委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAgencyV5Response DeleteAgencyV5(DeleteAgencyV5Request deleteAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgencyV5Request);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAgencyV5Response>(response);
        }

        public SyncInvoker<DeleteAgencyV5Response> DeleteAgencyV5Invoker(DeleteAgencyV5Request deleteAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgencyV5Request);
            return new SyncInvoker<DeleteAgencyV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAgencyV5Response>);
        }
        
        /// <summary>
        /// 删除服务关联委托
        ///
        /// 该接口可以用于服务关联委托删除自己。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteServiceLinkedAgencyV5Response DeleteServiceLinkedAgencyV5(DeleteServiceLinkedAgencyV5Request deleteServiceLinkedAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServiceLinkedAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/service-linked-agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceLinkedAgencyV5Request);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteServiceLinkedAgencyV5Response>(response);
        }

        public SyncInvoker<DeleteServiceLinkedAgencyV5Response> DeleteServiceLinkedAgencyV5Invoker(DeleteServiceLinkedAgencyV5Request deleteServiceLinkedAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServiceLinkedAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/service-linked-agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceLinkedAgencyV5Request);
            return new SyncInvoker<DeleteServiceLinkedAgencyV5Response>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteServiceLinkedAgencyV5Response>);
        }
        
        /// <summary>
        /// 查询委托或信任委托详情
        ///
        /// 该接口可以用于查询委托或信任委托详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetAgencyV5Response GetAgencyV5(GetAgencyV5Request getAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAgencyV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetAgencyV5Response>(response);
        }

        public SyncInvoker<GetAgencyV5Response> GetAgencyV5Invoker(GetAgencyV5Request getAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAgencyV5Request);
            return new SyncInvoker<GetAgencyV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetAgencyV5Response>);
        }
        
        /// <summary>
        /// 获取服务关联委托删除状态
        ///
        /// 该接口可以用于获取服务关联委托删除状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetServiceLinkedAgencyDeletionStatusV5Response GetServiceLinkedAgencyDeletionStatusV5(GetServiceLinkedAgencyDeletionStatusV5Request getServiceLinkedAgencyDeletionStatusV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getServiceLinkedAgencyDeletionStatusV5Request.DeletionTaskId, out var valueOfDeletionTaskId)) urlParam.Add("deletion_task_id", valueOfDeletionTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v5/service-linked-agencies/deletion-task/{deletion_task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getServiceLinkedAgencyDeletionStatusV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetServiceLinkedAgencyDeletionStatusV5Response>(response);
        }

        public SyncInvoker<GetServiceLinkedAgencyDeletionStatusV5Response> GetServiceLinkedAgencyDeletionStatusV5Invoker(GetServiceLinkedAgencyDeletionStatusV5Request getServiceLinkedAgencyDeletionStatusV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getServiceLinkedAgencyDeletionStatusV5Request.DeletionTaskId, out var valueOfDeletionTaskId)) urlParam.Add("deletion_task_id", valueOfDeletionTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v5/service-linked-agencies/deletion-task/{deletion_task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getServiceLinkedAgencyDeletionStatusV5Request);
            return new SyncInvoker<GetServiceLinkedAgencyDeletionStatusV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetServiceLinkedAgencyDeletionStatusV5Response>);
        }
        
        /// <summary>
        /// 查询指定条件下的委托及信任委托列表
        ///
        /// 该接口可以用于查询指定条件下的委托及信任委托列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAgenciesV5Response ListAgenciesV5(ListAgenciesV5Request listAgenciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgenciesV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAgenciesV5Response>(response);
        }

        public SyncInvoker<ListAgenciesV5Response> ListAgenciesV5Invoker(ListAgenciesV5Request listAgenciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgenciesV5Request);
            return new SyncInvoker<ListAgenciesV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListAgenciesV5Response>);
        }
        
        /// <summary>
        /// 修改信任委托
        ///
        /// 该接口可以用于修改信任委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAgencyV5Response UpdateAgencyV5(UpdateAgencyV5Request updateAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAgencyV5Request);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAgencyV5Response>(response);
        }

        public SyncInvoker<UpdateAgencyV5Response> UpdateAgencyV5Invoker(UpdateAgencyV5Request updateAgencyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAgencyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAgencyV5Request);
            return new SyncInvoker<UpdateAgencyV5Response>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAgencyV5Response>);
        }
        
        /// <summary>
        /// 修改信任委托信任策略
        ///
        /// 该接口可以用于修改信任委托信任策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTrustPolicyV5Response UpdateTrustPolicyV5(UpdateTrustPolicyV5Request updateTrustPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTrustPolicyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}/trust-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrustPolicyV5Request);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTrustPolicyV5Response>(response);
        }

        public SyncInvoker<UpdateTrustPolicyV5Response> UpdateTrustPolicyV5Invoker(UpdateTrustPolicyV5Request updateTrustPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTrustPolicyV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}/trust-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrustPolicyV5Request);
            return new SyncInvoker<UpdateTrustPolicyV5Response>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTrustPolicyV5Response>);
        }
        
        /// <summary>
        /// 查询指定服务授权概要
        ///
        /// 该接口可以用于查询指定云服务的授权概要。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetAuthorizationSchemaV5Response GetAuthorizationSchemaV5(GetAuthorizationSchemaV5Request getAuthorizationSchemaV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAuthorizationSchemaV5Request.ServiceCode, out var valueOfServiceCode)) urlParam.Add("service_code", valueOfServiceCode);
            var urlPath = HttpUtils.AddUrlPath("/v5/authorization-schemas/services/{service_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAuthorizationSchemaV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetAuthorizationSchemaV5Response>(response);
        }

        public SyncInvoker<GetAuthorizationSchemaV5Response> GetAuthorizationSchemaV5Invoker(GetAuthorizationSchemaV5Request getAuthorizationSchemaV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAuthorizationSchemaV5Request.ServiceCode, out var valueOfServiceCode)) urlParam.Add("service_code", valueOfServiceCode);
            var urlPath = HttpUtils.AddUrlPath("/v5/authorization-schemas/services/{service_code}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAuthorizationSchemaV5Request);
            return new SyncInvoker<GetAuthorizationSchemaV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetAuthorizationSchemaV5Response>);
        }
        
        /// <summary>
        /// 查询已注册云服务列表
        ///
        /// 该接口可以用于查询已注册云服务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRegisteredServicesForAuthSchemaV5Response ListRegisteredServicesForAuthSchemaV5(ListRegisteredServicesForAuthSchemaV5Request listRegisteredServicesForAuthSchemaV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/authorization-schemas/registered-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegisteredServicesForAuthSchemaV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRegisteredServicesForAuthSchemaV5Response>(response);
        }

        public SyncInvoker<ListRegisteredServicesForAuthSchemaV5Response> ListRegisteredServicesForAuthSchemaV5Invoker(ListRegisteredServicesForAuthSchemaV5Request listRegisteredServicesForAuthSchemaV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/authorization-schemas/registered-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegisteredServicesForAuthSchemaV5Request);
            return new SyncInvoker<ListRegisteredServicesForAuthSchemaV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListRegisteredServicesForAuthSchemaV5Response>);
        }
        
        /// <summary>
        /// 获取全部服务主体
        ///
        /// 该接口可以用于获取全部服务主体。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServicePrincipalsV5Response ListServicePrincipalsV5(ListServicePrincipalsV5Request listServicePrincipalsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/service-principals", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicePrincipalsV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServicePrincipalsV5Response>(response);
        }

        public SyncInvoker<ListServicePrincipalsV5Response> ListServicePrincipalsV5Invoker(ListServicePrincipalsV5Request listServicePrincipalsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/service-principals", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicePrincipalsV5Request);
            return new SyncInvoker<ListServicePrincipalsV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListServicePrincipalsV5Response>);
        }
        
        /// <summary>
        /// 添加IAM用户到用户组
        ///
        /// 该接口可以用于添加IAM用户到用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddUserToGroupV5Response AddUserToGroupV5(AddUserToGroupV5Request addUserToGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addUserToGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}/add-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addUserToGroupV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddUserToGroupV5Response>(response);
        }

        public SyncInvoker<AddUserToGroupV5Response> AddUserToGroupV5Invoker(AddUserToGroupV5Request addUserToGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addUserToGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}/add-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addUserToGroupV5Request);
            return new SyncInvoker<AddUserToGroupV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<AddUserToGroupV5Response>);
        }
        
        /// <summary>
        /// 创建用户组
        ///
        /// 该接口可以用于创建用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGroupV5Response CreateGroupV5(CreateGroupV5Request createGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupV5Response>(response);
        }

        public SyncInvoker<CreateGroupV5Response> CreateGroupV5Invoker(CreateGroupV5Request createGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupV5Request);
            return new SyncInvoker<CreateGroupV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupV5Response>);
        }
        
        /// <summary>
        /// 删除用户组
        ///
        /// 该接口可以用于删除用户组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGroupV5Response DeleteGroupV5(DeleteGroupV5Request deleteGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupV5Request);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupV5Response>(response);
        }

        public SyncInvoker<DeleteGroupV5Response> DeleteGroupV5Invoker(DeleteGroupV5Request deleteGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupV5Request);
            return new SyncInvoker<DeleteGroupV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupV5Response>);
        }
        
        /// <summary>
        /// 查询用户组列表
        ///
        /// 该接口可以用于查询用户组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupsV5Response ListGroupsV5(ListGroupsV5Request listGroupsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGroupsV5Response>(response);
        }

        public SyncInvoker<ListGroupsV5Response> ListGroupsV5Invoker(ListGroupsV5Request listGroupsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsV5Request);
            return new SyncInvoker<ListGroupsV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListGroupsV5Response>);
        }
        
        /// <summary>
        /// 移除用户组中的IAM用户
        ///
        /// 该接口可以用于移除用户组中的IAM用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveUserFromGroupV5Response RemoveUserFromGroupV5(RemoveUserFromGroupV5Request removeUserFromGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeUserFromGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}/remove-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeUserFromGroupV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RemoveUserFromGroupV5Response>(response);
        }

        public SyncInvoker<RemoveUserFromGroupV5Response> RemoveUserFromGroupV5Invoker(RemoveUserFromGroupV5Request removeUserFromGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeUserFromGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}/remove-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeUserFromGroupV5Request);
            return new SyncInvoker<RemoveUserFromGroupV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<RemoveUserFromGroupV5Response>);
        }
        
        /// <summary>
        /// 查询用户组相关属性
        ///
        /// 该接口可以用于查询用户组相关属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupSummaryResponse ShowGroupSummary(ShowGroupSummaryRequest showGroupSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/groups-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupSummaryResponse>(response);
        }

        public SyncInvoker<ShowGroupSummaryResponse> ShowGroupSummaryInvoker(ShowGroupSummaryRequest showGroupSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/groups-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupSummaryRequest);
            return new SyncInvoker<ShowGroupSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupSummaryResponse>);
        }
        
        /// <summary>
        /// 查询用户组详情
        ///
        /// 该接口可以用于查询用户组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupV5Response ShowGroupV5(ShowGroupV5Request showGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupV5Response>(response);
        }

        public SyncInvoker<ShowGroupV5Response> ShowGroupV5Invoker(ShowGroupV5Request showGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupV5Request);
            return new SyncInvoker<ShowGroupV5Response>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupV5Response>);
        }
        
        /// <summary>
        /// 修改用户组
        ///
        /// 该接口可以用于修改用户组信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGroupV5Response UpdateGroupV5(UpdateGroupV5Request updateGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupV5Request);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGroupV5Response>(response);
        }

        public SyncInvoker<UpdateGroupV5Response> UpdateGroupV5Invoker(UpdateGroupV5Request updateGroupV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupV5Request);
            return new SyncInvoker<UpdateGroupV5Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGroupV5Response>);
        }
        
        /// <summary>
        /// 创建MFA设备
        ///
        /// 该接口可以用于创建MFA设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVirtualMfaDeviceV5Response CreateVirtualMfaDeviceV5(CreateVirtualMfaDeviceV5Request createVirtualMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVirtualMfaDeviceV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateVirtualMfaDeviceV5Response>(response);
        }

        public SyncInvoker<CreateVirtualMfaDeviceV5Response> CreateVirtualMfaDeviceV5Invoker(CreateVirtualMfaDeviceV5Request createVirtualMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVirtualMfaDeviceV5Request);
            return new SyncInvoker<CreateVirtualMfaDeviceV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreateVirtualMfaDeviceV5Response>);
        }
        
        /// <summary>
        /// 删除MFA设备
        ///
        /// 该接口可以用于删除MFA设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVirtualMfaDeviceV5Response DeleteVirtualMfaDeviceV5(DeleteVirtualMfaDeviceV5Request deleteVirtualMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVirtualMfaDeviceV5Request);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVirtualMfaDeviceV5Response>(response);
        }

        public SyncInvoker<DeleteVirtualMfaDeviceV5Response> DeleteVirtualMfaDeviceV5Invoker(DeleteVirtualMfaDeviceV5Request deleteVirtualMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/virtual-mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVirtualMfaDeviceV5Request);
            return new SyncInvoker<DeleteVirtualMfaDeviceV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVirtualMfaDeviceV5Response>);
        }
        
        /// <summary>
        /// 禁用MFA设备
        ///
        /// 该接口可以用于禁用指定的MFA设备并删除其与对应IAM用户的关联。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableMfaDeviceV5Response DisableMfaDeviceV5(DisableMfaDeviceV5Request disableMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/mfa-devices/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableMfaDeviceV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisableMfaDeviceV5Response>(response);
        }

        public SyncInvoker<DisableMfaDeviceV5Response> DisableMfaDeviceV5Invoker(DisableMfaDeviceV5Request disableMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/mfa-devices/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableMfaDeviceV5Request);
            return new SyncInvoker<DisableMfaDeviceV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<DisableMfaDeviceV5Response>);
        }
        
        /// <summary>
        /// 启用MFA设备
        ///
        /// 该接口可以用于启用指定的MFA设备并将其与指定的IAM用户关联。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableMfaDeviceV5Response EnableMfaDeviceV5(EnableMfaDeviceV5Request enableMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/mfa-devices/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableMfaDeviceV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnableMfaDeviceV5Response>(response);
        }

        public SyncInvoker<EnableMfaDeviceV5Response> EnableMfaDeviceV5Invoker(EnableMfaDeviceV5Request enableMfaDeviceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/mfa-devices/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableMfaDeviceV5Request);
            return new SyncInvoker<EnableMfaDeviceV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<EnableMfaDeviceV5Response>);
        }
        
        /// <summary>
        /// 列举全部MFA设备
        ///
        /// 该接口可以用于列举全部MFA设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMfaDevicesV5Response ListMfaDevicesV5(ListMfaDevicesV5Request listMfaDevicesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMfaDevicesV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMfaDevicesV5Response>(response);
        }

        public SyncInvoker<ListMfaDevicesV5Response> ListMfaDevicesV5Invoker(ListMfaDevicesV5Request listMfaDevicesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/mfa-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMfaDevicesV5Request);
            return new SyncInvoker<ListMfaDevicesV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListMfaDevicesV5Response>);
        }
        
        /// <summary>
        /// 创建自定义身份策略
        ///
        /// 该接口可以用于创建一个默认版本为v1的新自定义身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePolicyV5Response CreatePolicyV5(CreatePolicyV5Request createPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyV5Response>(response);
        }

        public SyncInvoker<CreatePolicyV5Response> CreatePolicyV5Invoker(CreatePolicyV5Request createPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyV5Request);
            return new SyncInvoker<CreatePolicyV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyV5Response>);
        }
        
        /// <summary>
        /// 为指定身份策略创建一个新版本
        ///
        /// 该接口可以用于为指定身份策略创建一个新版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePolicyVersionV5Response CreatePolicyVersionV5(CreatePolicyVersionV5Request createPolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyVersionV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyVersionV5Response>(response);
        }

        public SyncInvoker<CreatePolicyVersionV5Response> CreatePolicyVersionV5Invoker(CreatePolicyVersionV5Request createPolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyVersionV5Request);
            return new SyncInvoker<CreatePolicyVersionV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyVersionV5Response>);
        }
        
        /// <summary>
        /// 删除自定义身份策略
        ///
        /// 该接口可以用于删除一个存在的自定义身份策略，必须确保该自定义身份策略没有附加在任何IAM用户、用户组、委托或信任委托上。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePolicyV5Response DeletePolicyV5(DeletePolicyV5Request deletePolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyV5Request);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyV5Response>(response);
        }

        public SyncInvoker<DeletePolicyV5Response> DeletePolicyV5Invoker(DeletePolicyV5Request deletePolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyV5Request);
            return new SyncInvoker<DeletePolicyV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyV5Response>);
        }
        
        /// <summary>
        /// 删除指定身份策略版本
        ///
        /// 该接口可以用于删除指定身份策略的指定版本。默认身份策略版本不能被删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePolicyVersionV5Response DeletePolicyVersionV5(DeletePolicyVersionV5Request deletePolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyVersionV5Request.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyVersionV5Request);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyVersionV5Response>(response);
        }

        public SyncInvoker<DeletePolicyVersionV5Response> DeletePolicyVersionV5Invoker(DeletePolicyVersionV5Request deletePolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyVersionV5Request.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyVersionV5Request);
            return new SyncInvoker<DeletePolicyVersionV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyVersionV5Response>);
        }
        
        /// <summary>
        /// 通过身份策略ID获取身份策略
        ///
        /// 该接口可以用于通过身份策略ID获取身份策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetPolicyV5Response GetPolicyV5(GetPolicyV5Request getPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getPolicyV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetPolicyV5Response>(response);
        }

        public SyncInvoker<GetPolicyV5Response> GetPolicyV5Invoker(GetPolicyV5Request getPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getPolicyV5Request);
            return new SyncInvoker<GetPolicyV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetPolicyV5Response>);
        }
        
        /// <summary>
        /// 查询指定身份策略版本
        ///
        /// 该接口可以用于查询指定身份策略的指定版本的相关信息，包括身份策略文档。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetPolicyVersionV5Response GetPolicyVersionV5(GetPolicyVersionV5Request getPolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getPolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(getPolicyVersionV5Request.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getPolicyVersionV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetPolicyVersionV5Response>(response);
        }

        public SyncInvoker<GetPolicyVersionV5Response> GetPolicyVersionV5Invoker(GetPolicyVersionV5Request getPolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getPolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(getPolicyVersionV5Request.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions/{version_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getPolicyVersionV5Request);
            return new SyncInvoker<GetPolicyVersionV5Response>(this, "GET", request, JsonUtils.DeSerialize<GetPolicyVersionV5Response>);
        }
        
        /// <summary>
        /// 查询所有身份策略
        ///
        /// 该接口可以用于查询所有身份策略，包含系统预置身份策略和自定义身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPoliciesV5Response ListPoliciesV5(ListPoliciesV5Request listPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPoliciesV5Response>(response);
        }

        public SyncInvoker<ListPoliciesV5Response> ListPoliciesV5Invoker(ListPoliciesV5Request listPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesV5Request);
            return new SyncInvoker<ListPoliciesV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListPoliciesV5Response>);
        }
        
        /// <summary>
        /// 查询指定身份策略的所有版本
        ///
        /// 该接口可以用于查询指定身份策略的所有版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyVersionsV5Response ListPolicyVersionsV5(ListPolicyVersionsV5Request listPolicyVersionsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyVersionsV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyVersionsV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyVersionsV5Response>(response);
        }

        public SyncInvoker<ListPolicyVersionsV5Response> ListPolicyVersionsV5Invoker(ListPolicyVersionsV5Request listPolicyVersionsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyVersionsV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyVersionsV5Request);
            return new SyncInvoker<ListPolicyVersionsV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyVersionsV5Response>);
        }
        
        /// <summary>
        /// 将指定身份策略版本设置为默认版本
        ///
        /// 该接口可以用于将指定身份策略的指定版本设置为默认版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetDefaultPolicyVersionV5Response SetDefaultPolicyVersionV5(SetDefaultPolicyVersionV5Request setDefaultPolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setDefaultPolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(setDefaultPolicyVersionV5Request.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions/{version_id}/set-default", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDefaultPolicyVersionV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetDefaultPolicyVersionV5Response>(response);
        }

        public SyncInvoker<SetDefaultPolicyVersionV5Response> SetDefaultPolicyVersionV5Invoker(SetDefaultPolicyVersionV5Request setDefaultPolicyVersionV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setDefaultPolicyVersionV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(setDefaultPolicyVersionV5Request.VersionId, out var valueOfVersionId)) urlParam.Add("version_id", valueOfVersionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/versions/{version_id}/set-default", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDefaultPolicyVersionV5Request);
            return new SyncInvoker<SetDefaultPolicyVersionV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<SetDefaultPolicyVersionV5Response>);
        }
        
        /// <summary>
        /// 为委托或信任委托附加身份策略
        ///
        /// 该接口可以用于为指定委托或信任委托附加指定身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachAgencyPolicyV5Response AttachAgencyPolicyV5(AttachAgencyPolicyV5Request attachAgencyPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachAgencyPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attach-agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachAgencyPolicyV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AttachAgencyPolicyV5Response>(response);
        }

        public SyncInvoker<AttachAgencyPolicyV5Response> AttachAgencyPolicyV5Invoker(AttachAgencyPolicyV5Request attachAgencyPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachAgencyPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attach-agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachAgencyPolicyV5Request);
            return new SyncInvoker<AttachAgencyPolicyV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<AttachAgencyPolicyV5Response>);
        }
        
        /// <summary>
        /// 为用户组附加身份策略
        ///
        /// 该接口可以用于为指定用户组附加指定身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachGroupPolicyV5Response AttachGroupPolicyV5(AttachGroupPolicyV5Request attachGroupPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachGroupPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attach-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachGroupPolicyV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AttachGroupPolicyV5Response>(response);
        }

        public SyncInvoker<AttachGroupPolicyV5Response> AttachGroupPolicyV5Invoker(AttachGroupPolicyV5Request attachGroupPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachGroupPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attach-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachGroupPolicyV5Request);
            return new SyncInvoker<AttachGroupPolicyV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<AttachGroupPolicyV5Response>);
        }
        
        /// <summary>
        /// 为IAM用户附加身份策略
        ///
        /// 该接口可以用于为指定IAM用户附加指定身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachUserPolicyV5Response AttachUserPolicyV5(AttachUserPolicyV5Request attachUserPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachUserPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attach-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachUserPolicyV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AttachUserPolicyV5Response>(response);
        }

        public SyncInvoker<AttachUserPolicyV5Response> AttachUserPolicyV5Invoker(AttachUserPolicyV5Request attachUserPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachUserPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attach-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachUserPolicyV5Request);
            return new SyncInvoker<AttachUserPolicyV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<AttachUserPolicyV5Response>);
        }
        
        /// <summary>
        /// 从委托或信任委托分离身份策略
        ///
        /// 该接口可以用于从指定委托或信任委托中分离指定身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetachAgencyPolicyV5Response DetachAgencyPolicyV5(DetachAgencyPolicyV5Request detachAgencyPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachAgencyPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/detach-agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachAgencyPolicyV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DetachAgencyPolicyV5Response>(response);
        }

        public SyncInvoker<DetachAgencyPolicyV5Response> DetachAgencyPolicyV5Invoker(DetachAgencyPolicyV5Request detachAgencyPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachAgencyPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/detach-agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachAgencyPolicyV5Request);
            return new SyncInvoker<DetachAgencyPolicyV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<DetachAgencyPolicyV5Response>);
        }
        
        /// <summary>
        /// 从用户组分离身份策略
        ///
        /// 该接口可以用于从指定用户组分离指定身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetachGroupPolicyV5Response DetachGroupPolicyV5(DetachGroupPolicyV5Request detachGroupPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachGroupPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/detach-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachGroupPolicyV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DetachGroupPolicyV5Response>(response);
        }

        public SyncInvoker<DetachGroupPolicyV5Response> DetachGroupPolicyV5Invoker(DetachGroupPolicyV5Request detachGroupPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachGroupPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/detach-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachGroupPolicyV5Request);
            return new SyncInvoker<DetachGroupPolicyV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<DetachGroupPolicyV5Response>);
        }
        
        /// <summary>
        /// 从IAM用户分离身份策略
        ///
        /// 该接口可以用于从指定的IAM用户分离指定身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetachUserPolicyV5Response DetachUserPolicyV5(DetachUserPolicyV5Request detachUserPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachUserPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/detach-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachUserPolicyV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DetachUserPolicyV5Response>(response);
        }

        public SyncInvoker<DetachUserPolicyV5Response> DetachUserPolicyV5Invoker(DetachUserPolicyV5Request detachUserPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(detachUserPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/detach-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachUserPolicyV5Request);
            return new SyncInvoker<DetachUserPolicyV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<DetachUserPolicyV5Response>);
        }
        
        /// <summary>
        /// 查询指定委托或信任委托附加的所有身份策略
        ///
        /// 该接口可用于查询指定委托或信任委托附加的所有身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAttachedAgencyPoliciesV5Response ListAttachedAgencyPoliciesV5(ListAttachedAgencyPoliciesV5Request listAttachedAgencyPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAttachedAgencyPoliciesV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}/attached-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttachedAgencyPoliciesV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAttachedAgencyPoliciesV5Response>(response);
        }

        public SyncInvoker<ListAttachedAgencyPoliciesV5Response> ListAttachedAgencyPoliciesV5Invoker(ListAttachedAgencyPoliciesV5Request listAttachedAgencyPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAttachedAgencyPoliciesV5Request.AgencyId, out var valueOfAgencyId)) urlParam.Add("agency_id", valueOfAgencyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/agencies/{agency_id}/attached-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttachedAgencyPoliciesV5Request);
            return new SyncInvoker<ListAttachedAgencyPoliciesV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListAttachedAgencyPoliciesV5Response>);
        }
        
        /// <summary>
        /// 查询指定用户组附加的所有身份策略
        ///
        /// 该接口可用于查询指定用户组附加的所有身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAttachedGroupPoliciesV5Response ListAttachedGroupPoliciesV5(ListAttachedGroupPoliciesV5Request listAttachedGroupPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAttachedGroupPoliciesV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}/attached-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttachedGroupPoliciesV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAttachedGroupPoliciesV5Response>(response);
        }

        public SyncInvoker<ListAttachedGroupPoliciesV5Response> ListAttachedGroupPoliciesV5Invoker(ListAttachedGroupPoliciesV5Request listAttachedGroupPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAttachedGroupPoliciesV5Request.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/groups/{group_id}/attached-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttachedGroupPoliciesV5Request);
            return new SyncInvoker<ListAttachedGroupPoliciesV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListAttachedGroupPoliciesV5Response>);
        }
        
        /// <summary>
        /// 查询指定IAM用户附加的所有身份策略
        ///
        /// 该接口可用于查询指定IAM用户附加的所有身份策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAttachedUserPoliciesV5Response ListAttachedUserPoliciesV5(ListAttachedUserPoliciesV5Request listAttachedUserPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAttachedUserPoliciesV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/attached-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttachedUserPoliciesV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAttachedUserPoliciesV5Response>(response);
        }

        public SyncInvoker<ListAttachedUserPoliciesV5Response> ListAttachedUserPoliciesV5Invoker(ListAttachedUserPoliciesV5Request listAttachedUserPoliciesV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAttachedUserPoliciesV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/attached-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttachedUserPoliciesV5Request);
            return new SyncInvoker<ListAttachedUserPoliciesV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListAttachedUserPoliciesV5Response>);
        }
        
        /// <summary>
        /// 查询指定身份策略附加的所有实体
        ///
        /// 该接口可用于查询指定身份策略附加的所有实体。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEntitiesForPolicyV5Response ListEntitiesForPolicyV5(ListEntitiesForPolicyV5Request listEntitiesForPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEntitiesForPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attached-entities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEntitiesForPolicyV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEntitiesForPolicyV5Response>(response);
        }

        public SyncInvoker<ListEntitiesForPolicyV5Response> ListEntitiesForPolicyV5Invoker(ListEntitiesForPolicyV5Request listEntitiesForPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEntitiesForPolicyV5Request.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/policies/{policy_id}/attached-entities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEntitiesForPolicyV5Request);
            return new SyncInvoker<ListEntitiesForPolicyV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListEntitiesForPolicyV5Response>);
        }
        
        /// <summary>
        /// 删除指定资源的部分标签
        ///
        /// 该接口可以用于删除指定资源的部分标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteResourceTagsV5Response DeleteResourceTagsV5(DeleteResourceTagsV5Request deleteResourceTagsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceTagsV5Request.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceTagsV5Request.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v5/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceTagsV5Request);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteResourceTagsV5Response>(response);
        }

        public SyncInvoker<DeleteResourceTagsV5Response> DeleteResourceTagsV5Invoker(DeleteResourceTagsV5Request deleteResourceTagsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceTagsV5Request.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceTagsV5Request.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v5/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceTagsV5Request);
            return new SyncInvoker<DeleteResourceTagsV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteResourceTagsV5Response>);
        }
        
        /// <summary>
        /// 获取指定资源的所有标签
        ///
        /// 该接口可以用于获取指定资源的所有标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceTagsV5Response ListResourceTagsV5(ListResourceTagsV5Request listResourceTagsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsV5Request.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsV5Request.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v5/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourceTagsV5Response>(response);
        }

        public SyncInvoker<ListResourceTagsV5Response> ListResourceTagsV5Invoker(ListResourceTagsV5Request listResourceTagsV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsV5Request.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsV5Request.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v5/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsV5Request);
            return new SyncInvoker<ListResourceTagsV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListResourceTagsV5Response>);
        }
        
        /// <summary>
        /// 为IAM资源打上标签
        ///
        /// 该接口可以用于为IAM资源打上标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public TagResourceV5Response TagResourceV5(TagResourceV5Request tagResourceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(tagResourceV5Request.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(tagResourceV5Request.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v5/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagResourceV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<TagResourceV5Response>(response);
        }

        public SyncInvoker<TagResourceV5Response> TagResourceV5Invoker(TagResourceV5Request tagResourceV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(tagResourceV5Request.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(tagResourceV5Request.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v5/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagResourceV5Request);
            return new SyncInvoker<TagResourceV5Response>(this, "POST", request, JsonUtils.DeSerialize<TagResourceV5Response>);
        }
        
        /// <summary>
        /// 查询账号登录策略
        ///
        /// 该接口可以用于查询账号登录策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLoginPolicyV5Response ShowLoginPolicyV5(ShowLoginPolicyV5Request showLoginPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoginPolicyV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLoginPolicyV5Response>(response);
        }

        public SyncInvoker<ShowLoginPolicyV5Response> ShowLoginPolicyV5Invoker(ShowLoginPolicyV5Request showLoginPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoginPolicyV5Request);
            return new SyncInvoker<ShowLoginPolicyV5Response>(this, "GET", request, JsonUtils.DeSerialize<ShowLoginPolicyV5Response>);
        }
        
        /// <summary>
        /// 查询账号密码策略
        ///
        /// 该接口可以用于查询账号密码策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPasswordPolicyV5Response ShowPasswordPolicyV5(ShowPasswordPolicyV5Request showPasswordPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPasswordPolicyV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPasswordPolicyV5Response>(response);
        }

        public SyncInvoker<ShowPasswordPolicyV5Response> ShowPasswordPolicyV5Invoker(ShowPasswordPolicyV5Request showPasswordPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPasswordPolicyV5Request);
            return new SyncInvoker<ShowPasswordPolicyV5Response>(this, "GET", request, JsonUtils.DeSerialize<ShowPasswordPolicyV5Response>);
        }
        
        /// <summary>
        /// 修改账号登录策略
        ///
        /// 该接口可以用于修改账号登录策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLoginPolicyV5Response UpdateLoginPolicyV5(UpdateLoginPolicyV5Request updateLoginPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLoginPolicyV5Request);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLoginPolicyV5Response>(response);
        }

        public SyncInvoker<UpdateLoginPolicyV5Response> UpdateLoginPolicyV5Invoker(UpdateLoginPolicyV5Request updateLoginPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/login-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLoginPolicyV5Request);
            return new SyncInvoker<UpdateLoginPolicyV5Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLoginPolicyV5Response>);
        }
        
        /// <summary>
        /// 修改账号密码策略
        ///
        /// 该接口可以用于修改账号密码策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePasswordPolicyV5Response UpdatePasswordPolicyV5(UpdatePasswordPolicyV5Request updatePasswordPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePasswordPolicyV5Request);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePasswordPolicyV5Response>(response);
        }

        public SyncInvoker<UpdatePasswordPolicyV5Response> UpdatePasswordPolicyV5Invoker(UpdatePasswordPolicyV5Request updatePasswordPolicyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/password-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePasswordPolicyV5Request);
            return new SyncInvoker<UpdatePasswordPolicyV5Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePasswordPolicyV5Response>);
        }
        
        /// <summary>
        /// 创建IAM用户
        ///
        /// 该接口可以用于创建IAM用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateUserV5Response CreateUserV5(CreateUserV5Request createUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateUserV5Response>(response);
        }

        public SyncInvoker<CreateUserV5Response> CreateUserV5Invoker(CreateUserV5Request createUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserV5Request);
            return new SyncInvoker<CreateUserV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreateUserV5Response>);
        }
        
        /// <summary>
        /// 删除IAM用户
        ///
        /// 该接口可以用于删除指定IAM用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteUserV5Response DeleteUserV5(DeleteUserV5Request deleteUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserV5Request);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserV5Response>(response);
        }

        public SyncInvoker<DeleteUserV5Response> DeleteUserV5Invoker(DeleteUserV5Request deleteUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserV5Request);
            return new SyncInvoker<DeleteUserV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserV5Response>);
        }
        
        /// <summary>
        /// 查询IAM用户列表
        ///
        /// 该接口可以用于查询IAM用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUsersV5Response ListUsersV5(ListUsersV5Request listUsersV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUsersV5Response>(response);
        }

        public SyncInvoker<ListUsersV5Response> ListUsersV5Invoker(ListUsersV5Request listUsersV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersV5Request);
            return new SyncInvoker<ListUsersV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListUsersV5Response>);
        }
        
        /// <summary>
        /// 查询IAM用户最后登录时间
        ///
        /// 该接口可以用于查询IAM用户的最后登录时间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserLastLoginV5Response ShowUserLastLoginV5(ShowUserLastLoginV5Request showUserLastLoginV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserLastLoginV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/last-login", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserLastLoginV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserLastLoginV5Response>(response);
        }

        public SyncInvoker<ShowUserLastLoginV5Response> ShowUserLastLoginV5Invoker(ShowUserLastLoginV5Request showUserLastLoginV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserLastLoginV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/last-login", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserLastLoginV5Request);
            return new SyncInvoker<ShowUserLastLoginV5Response>(this, "GET", request, JsonUtils.DeSerialize<ShowUserLastLoginV5Response>);
        }
        
        /// <summary>
        /// 查询IAM用户详情
        ///
        /// 该接口可以用于查询IAM用户详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserV5Response ShowUserV5(ShowUserV5Request showUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserV5Response>(response);
        }

        public SyncInvoker<ShowUserV5Response> ShowUserV5Invoker(ShowUserV5Request showUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserV5Request);
            return new SyncInvoker<ShowUserV5Response>(this, "GET", request, JsonUtils.DeSerialize<ShowUserV5Response>);
        }
        
        /// <summary>
        /// 修改IAM用户信息
        ///
        /// 该接口可以用于修改IAM用户信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateUserV5Response UpdateUserV5(UpdateUserV5Request updateUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserV5Request);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUserV5Response>(response);
        }

        public SyncInvoker<UpdateUserV5Response> UpdateUserV5Invoker(UpdateUserV5Request updateUserV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserV5Request);
            return new SyncInvoker<UpdateUserV5Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUserV5Response>);
        }
        
        /// <summary>
        /// 修改IAM用户密码
        ///
        /// 该接口可以用于IAM用户修改自己的密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangePasswordV5Response ChangePasswordV5(ChangePasswordV5Request changePasswordV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/caller-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changePasswordV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ChangePasswordV5Response>(response);
        }

        public SyncInvoker<ChangePasswordV5Response> ChangePasswordV5Invoker(ChangePasswordV5Request changePasswordV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/caller-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changePasswordV5Request);
            return new SyncInvoker<ChangePasswordV5Response>(this, "POST", request, JsonUtils.DeSerializeNull<ChangePasswordV5Response>);
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
        public CreateAccessKeyV5Response CreateAccessKeyV5(CreateAccessKeyV5Request createAccessKeyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAccessKeyV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessKeyV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAccessKeyV5Response>(response);
        }

        public SyncInvoker<CreateAccessKeyV5Response> CreateAccessKeyV5Invoker(CreateAccessKeyV5Request createAccessKeyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAccessKeyV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessKeyV5Request);
            return new SyncInvoker<CreateAccessKeyV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreateAccessKeyV5Response>);
        }
        
        /// <summary>
        /// 创建IAM用户登录信息
        ///
        /// 该接口可以用于创建指定IAM用户的登录信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLoginProfileV5Response CreateLoginProfileV5(CreateLoginProfileV5Request createLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLoginProfileV5Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLoginProfileV5Response>(response);
        }

        public SyncInvoker<CreateLoginProfileV5Response> CreateLoginProfileV5Invoker(CreateLoginProfileV5Request createLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLoginProfileV5Request);
            return new SyncInvoker<CreateLoginProfileV5Response>(this, "POST", request, JsonUtils.DeSerialize<CreateLoginProfileV5Response>);
        }
        
        /// <summary>
        /// 删除指定永久访问密钥
        ///
        /// 该接口可以用于删除IAM用户的指定永久访问密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAccessKeyV5Response DeleteAccessKeyV5(DeleteAccessKeyV5Request deleteAccessKeyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyV5Request.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccessKeyV5Request);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAccessKeyV5Response>(response);
        }

        public SyncInvoker<DeleteAccessKeyV5Response> DeleteAccessKeyV5Invoker(DeleteAccessKeyV5Request deleteAccessKeyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyV5Request.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccessKeyV5Request);
            return new SyncInvoker<DeleteAccessKeyV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAccessKeyV5Response>);
        }
        
        /// <summary>
        /// 删除IAM用户登录信息
        ///
        /// 该接口可以用于删除指定IAM用户的登录信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLoginProfileV5Response DeleteLoginProfileV5(DeleteLoginProfileV5Request deleteLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoginProfileV5Request);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLoginProfileV5Response>(response);
        }

        public SyncInvoker<DeleteLoginProfileV5Response> DeleteLoginProfileV5Invoker(DeleteLoginProfileV5Request deleteLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoginProfileV5Request);
            return new SyncInvoker<DeleteLoginProfileV5Response>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLoginProfileV5Response>);
        }
        
        /// <summary>
        /// 查询所有永久访问密钥
        ///
        /// 该接口可以用于查询IAM用户的所有永久访问密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccessKeysV5Response ListAccessKeysV5(ListAccessKeysV5Request listAccessKeysV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccessKeysV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessKeysV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccessKeysV5Response>(response);
        }

        public SyncInvoker<ListAccessKeysV5Response> ListAccessKeysV5Invoker(ListAccessKeysV5Request listAccessKeysV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAccessKeysV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessKeysV5Request);
            return new SyncInvoker<ListAccessKeysV5Response>(this, "GET", request, JsonUtils.DeSerialize<ListAccessKeysV5Response>);
        }
        
        /// <summary>
        /// 查询指定永久访问密钥最后使用时间
        ///
        /// 该接口可以用于查询IAM用户的指定永久访问密钥的最后使用时间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAccessKeyLastUsedV5Response ShowAccessKeyLastUsedV5(ShowAccessKeyLastUsedV5Request showAccessKeyLastUsedV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyLastUsedV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyLastUsedV5Request.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys/{access_key_id}/last-used", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessKeyLastUsedV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAccessKeyLastUsedV5Response>(response);
        }

        public SyncInvoker<ShowAccessKeyLastUsedV5Response> ShowAccessKeyLastUsedV5Invoker(ShowAccessKeyLastUsedV5Request showAccessKeyLastUsedV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyLastUsedV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyLastUsedV5Request.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys/{access_key_id}/last-used", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessKeyLastUsedV5Request);
            return new SyncInvoker<ShowAccessKeyLastUsedV5Response>(this, "GET", request, JsonUtils.DeSerialize<ShowAccessKeyLastUsedV5Response>);
        }
        
        /// <summary>
        /// 查询IAM用户登录信息
        ///
        /// 该接口可以用于查询指定IAM用户的登录信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLoginProfileV5Response ShowLoginProfileV5(ShowLoginProfileV5Request showLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoginProfileV5Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLoginProfileV5Response>(response);
        }

        public SyncInvoker<ShowLoginProfileV5Response> ShowLoginProfileV5Invoker(ShowLoginProfileV5Request showLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoginProfileV5Request);
            return new SyncInvoker<ShowLoginProfileV5Response>(this, "GET", request, JsonUtils.DeSerialize<ShowLoginProfileV5Response>);
        }
        
        /// <summary>
        /// 修改指定永久访问密钥
        ///
        /// 该接口可以用于修改IAM用户的指定永久访问密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAccessKeyV5Response UpdateAccessKeyV5(UpdateAccessKeyV5Request updateAccessKeyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAccessKeyV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(updateAccessKeyV5Request.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessKeyV5Request);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAccessKeyV5Response>(response);
        }

        public SyncInvoker<UpdateAccessKeyV5Response> UpdateAccessKeyV5Invoker(UpdateAccessKeyV5Request updateAccessKeyV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAccessKeyV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            if (StringUtils.TryConvertToNonEmptyString(updateAccessKeyV5Request.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAccessKeyV5Request);
            return new SyncInvoker<UpdateAccessKeyV5Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAccessKeyV5Response>);
        }
        
        /// <summary>
        /// 修改IAM用户登录信息
        ///
        /// 该接口可以用于修改指定IAM用户的登录信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLoginProfileV5Response UpdateLoginProfileV5(UpdateLoginProfileV5Request updateLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLoginProfileV5Request);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLoginProfileV5Response>(response);
        }

        public SyncInvoker<UpdateLoginProfileV5Response> UpdateLoginProfileV5Invoker(UpdateLoginProfileV5Request updateLoginProfileV5Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLoginProfileV5Request.UserId, out var valueOfUserId)) urlParam.Add("user_id", valueOfUserId);
            var urlPath = HttpUtils.AddUrlPath("/v5/users/{user_id}/login-profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLoginProfileV5Request);
            return new SyncInvoker<UpdateLoginProfileV5Response>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLoginProfileV5Response>);
        }
        
    }
}