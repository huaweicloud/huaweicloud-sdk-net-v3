using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Bssintl.V2.Model;

namespace HuaweiCloud.SDK.Bssintl.V2
{
    public partial class BssintlAsyncClient : Client
    {
        public static ClientBuilder<BssintlAsyncClient> NewBuilder()
        {
            return new ClientBuilder<BssintlAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 设置包年/包月资源自动续费
        ///
        /// 功能描述：为防止资源到期被删除，客户可为长期使用的包年/包月资源开通自动续费。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AutoRenewalResourcesResponse> AutoRenewalResourcesAsync(AutoRenewalResourcesRequest autoRenewalResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", autoRenewalResourcesRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/subscriptions/resources/autorenew/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", autoRenewalResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AutoRenewalResourcesResponse>(response);
        }

        public AsyncInvoker<AutoRenewalResourcesResponse> AutoRenewalResourcesAsyncInvoker(AutoRenewalResourcesRequest autoRenewalResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", autoRenewalResourcesRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/subscriptions/resources/autorenew/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", autoRenewalResourcesRequest);
            return new AsyncInvoker<AutoRenewalResourcesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AutoRenewalResourcesResponse>);
        }
        
        /// <summary>
        /// 取消包年/包月资源自动续费
        ///
        /// 功能描述：取消包年/包月资源自动续费
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelAutoRenewalResourcesResponse> CancelAutoRenewalResourcesAsync(CancelAutoRenewalResourcesRequest cancelAutoRenewalResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", cancelAutoRenewalResourcesRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/subscriptions/resources/autorenew/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAutoRenewalResourcesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<CancelAutoRenewalResourcesResponse>(response);
        }

        public AsyncInvoker<CancelAutoRenewalResourcesResponse> CancelAutoRenewalResourcesAsyncInvoker(CancelAutoRenewalResourcesRequest cancelAutoRenewalResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", cancelAutoRenewalResourcesRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/subscriptions/resources/autorenew/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAutoRenewalResourcesRequest);
            return new AsyncInvoker<CancelAutoRenewalResourcesResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelAutoRenewalResourcesResponse>);
        }
        
        /// <summary>
        /// 取消待支付订单
        ///
        /// 功能描述：客户可以对待支付的订单进行取消操作
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelCustomerOrderResponse> CancelCustomerOrderAsync(CancelCustomerOrderRequest cancelCustomerOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/customer-orders/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelCustomerOrderRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<CancelCustomerOrderResponse>(response);
        }

        public AsyncInvoker<CancelCustomerOrderResponse> CancelCustomerOrderAsyncInvoker(CancelCustomerOrderRequest cancelCustomerOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/customer-orders/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelCustomerOrderRequest);
            return new AsyncInvoker<CancelCustomerOrderResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CancelCustomerOrderResponse>);
        }
        
        /// <summary>
        /// 退订包年/包月资源
        ///
        /// 功能描述：客户购买包年/包月资源后，支持客户退订包年/包月实例。退订资源实例包括资源续费部分和当前正在使用的部分，退订后资源将无法使用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelResourcesSubscriptionResponse> CancelResourcesSubscriptionAsync(CancelResourcesSubscriptionRequest cancelResourcesSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/subscriptions/resources/unsubscribe", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelResourcesSubscriptionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CancelResourcesSubscriptionResponse>(response);
        }

        public AsyncInvoker<CancelResourcesSubscriptionResponse> CancelResourcesSubscriptionAsyncInvoker(CancelResourcesSubscriptionRequest cancelResourcesSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/subscriptions/resources/unsubscribe", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelResourcesSubscriptionRequest);
            return new AsyncInvoker<CancelResourcesSubscriptionResponse>(this, "POST", request, JsonUtils.DeSerialize<CancelResourcesSubscriptionResponse>);
        }
        
        /// <summary>
        /// 申请实名认证变更
        ///
        /// 功能描述：客户可以进行实名认证变更申请。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeEnterpriseRealnameAuthenticationResponse> ChangeEnterpriseRealnameAuthenticationAsync(ChangeEnterpriseRealnameAuthenticationRequest changeEnterpriseRealnameAuthenticationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/customers/realname-auths/enterprise", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEnterpriseRealnameAuthenticationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ChangeEnterpriseRealnameAuthenticationResponse>(response);
        }

        public AsyncInvoker<ChangeEnterpriseRealnameAuthenticationResponse> ChangeEnterpriseRealnameAuthenticationAsyncInvoker(ChangeEnterpriseRealnameAuthenticationRequest changeEnterpriseRealnameAuthenticationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/customers/realname-auths/enterprise", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEnterpriseRealnameAuthenticationRequest);
            return new AsyncInvoker<ChangeEnterpriseRealnameAuthenticationResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeEnterpriseRealnameAuthenticationResponse>);
        }
        
        /// <summary>
        /// 校验客户注册信息
        ///
        /// 功能描述：客户注册时可检查客户的登录名称、手机号或者邮箱是否可以用于注册。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckUserIdentityResponse> CheckUserIdentityAsync(CheckUserIdentityRequest checkUserIdentityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/users/check-identity", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkUserIdentityRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CheckUserIdentityResponse>(response);
        }

        public AsyncInvoker<CheckUserIdentityResponse> CheckUserIdentityAsyncInvoker(CheckUserIdentityRequest checkUserIdentityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/users/check-identity", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkUserIdentityRequest);
            return new AsyncInvoker<CheckUserIdentityResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckUserIdentityResponse>);
        }
        
        /// <summary>
        /// 开通客户企业项目权限
        ///
        /// 客户在自建平台开通客户企业项目权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEnterpriseProjectAuthResponse> CreateEnterpriseProjectAuthAsync(CreateEnterpriseProjectAuthRequest createEnterpriseProjectAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/enterprise-projects/authority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnterpriseProjectAuthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateEnterpriseProjectAuthResponse>(response);
        }

        public AsyncInvoker<CreateEnterpriseProjectAuthResponse> CreateEnterpriseProjectAuthAsyncInvoker(CreateEnterpriseProjectAuthRequest createEnterpriseProjectAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/enterprise-projects/authority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnterpriseProjectAuthRequest);
            return new AsyncInvoker<CreateEnterpriseProjectAuthResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateEnterpriseProjectAuthResponse>);
        }
        
        /// <summary>
        /// 申请企业实名认证
        ///
        /// 功能描述：企业客户可以进行企业实名认证申请。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEnterpriseRealnameAuthenticationResponse> CreateEnterpriseRealnameAuthenticationAsync(CreateEnterpriseRealnameAuthenticationRequest createEnterpriseRealnameAuthenticationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/customers/realname-auths/enterprise", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnterpriseRealnameAuthenticationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateEnterpriseRealnameAuthenticationResponse>(response);
        }

        public AsyncInvoker<CreateEnterpriseRealnameAuthenticationResponse> CreateEnterpriseRealnameAuthenticationAsyncInvoker(CreateEnterpriseRealnameAuthenticationRequest createEnterpriseRealnameAuthenticationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/customers/realname-auths/enterprise", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnterpriseRealnameAuthenticationRequest);
            return new AsyncInvoker<CreateEnterpriseRealnameAuthenticationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEnterpriseRealnameAuthenticationResponse>);
        }
        
        /// <summary>
        /// 申请个人实名认证
        ///
        /// 功能描述：个人客户可以进行个人实名认证申请。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePersonalRealnameAuthResponse> CreatePersonalRealnameAuthAsync(CreatePersonalRealnameAuthRequest createPersonalRealnameAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/customers/realname-auths/individual", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPersonalRealnameAuthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePersonalRealnameAuthResponse>(response);
        }

        public AsyncInvoker<CreatePersonalRealnameAuthResponse> CreatePersonalRealnameAuthAsyncInvoker(CreatePersonalRealnameAuthRequest createPersonalRealnameAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/customers/realname-auths/individual", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPersonalRealnameAuthRequest);
            return new AsyncInvoker<CreatePersonalRealnameAuthResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePersonalRealnameAuthResponse>);
        }
        
        /// <summary>
        /// 创建客户
        ///
        /// 功能描述：在伙伴销售平台创建客户时同步创建华为云账号，并将客户在伙伴销售平台上的账号与华为云账号进行映射。同时，创建的华为云账号与伙伴账号关联绑定。华为云伙伴能力中心（一级经销商）可以注册云经销商伙伴（二级经销商）的子客户。注册完成后，子客户可以自动和云经销商伙伴绑定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSubCustomerResponse> CreateSubCustomerAsync(CreateSubCustomerRequest createSubCustomerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubCustomerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSubCustomerResponse>(response);
        }

        public AsyncInvoker<CreateSubCustomerResponse> CreateSubCustomerAsyncInvoker(CreateSubCustomerRequest createSubCustomerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubCustomerRequest);
            return new AsyncInvoker<CreateSubCustomerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSubCustomerResponse>);
        }
        
        /// <summary>
        /// 冻结客户账号
        ///
        /// 功能描述：冻结伙伴子客户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<FreezeSubCustomersResponse> FreezeSubCustomersAsync(FreezeSubCustomersRequest freezeSubCustomersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/freeze", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", freezeSubCustomersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<FreezeSubCustomersResponse>(response);
        }

        public AsyncInvoker<FreezeSubCustomersResponse> FreezeSubCustomersAsyncInvoker(FreezeSubCustomersRequest freezeSubCustomersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/freeze", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", freezeSubCustomersRequest);
            return new AsyncInvoker<FreezeSubCustomersResponse>(this, "POST", request, JsonUtils.DeSerialize<FreezeSubCustomersResponse>);
        }
        
        /// <summary>
        /// 查询度量单位进制
        ///
        /// 功能描述：伙伴在伙伴销售平台上查询使用量单位的进制转换信息，用于不同度量单位之间的转换。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConversionsResponse> ListConversionsAsync(ListConversionsRequest listConversionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bases/conversions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConversionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConversionsResponse>(response);
        }

        public AsyncInvoker<ListConversionsResponse> ListConversionsAsyncInvoker(ListConversionsRequest listConversionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bases/conversions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConversionsRequest);
            return new AsyncInvoker<ListConversionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConversionsResponse>);
        }
        
        /// <summary>
        /// 查询成本数据
        ///
        /// 客户在自建平台查询成本分析数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCostsResponse> ListCostsAsync(ListCostsRequest listCostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/costs/cost-analysed-bills/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCostsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListCostsResponse>(response);
        }

        public AsyncInvoker<ListCostsResponse> ListCostsAsyncInvoker(ListCostsRequest listCostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/costs/cost-analysed-bills/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCostsRequest);
            return new AsyncInvoker<ListCostsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCostsResponse>);
        }
        
        /// <summary>
        /// 查询客户按需资源列表
        ///
        /// 功能描述：客户在伙伴销售平台查询已开通的按需资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCustomerOnDemandResourcesResponse> ListCustomerOnDemandResourcesAsync(ListCustomerOnDemandResourcesRequest listCustomerOnDemandResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/on-demand-resources/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerOnDemandResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListCustomerOnDemandResourcesResponse>(response);
        }

        public AsyncInvoker<ListCustomerOnDemandResourcesResponse> ListCustomerOnDemandResourcesAsyncInvoker(ListCustomerOnDemandResourcesRequest listCustomerOnDemandResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/on-demand-resources/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerOnDemandResourcesRequest);
            return new AsyncInvoker<ListCustomerOnDemandResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCustomerOnDemandResourcesResponse>);
        }
        
        /// <summary>
        /// 查询订单列表
        ///
        /// 功能描述：客户购买包年包月资源后，可以查看待审核、处理中、已取消、已完成和待支付等状态的订单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCustomerOrdersResponse> ListCustomerOrdersAsync(ListCustomerOrdersRequest listCustomerOrdersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/customer-orders", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerOrdersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCustomerOrdersResponse>(response);
        }

        public AsyncInvoker<ListCustomerOrdersResponse> ListCustomerOrdersAsyncInvoker(ListCustomerOrdersRequest listCustomerOrdersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/customer-orders", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerOrdersRequest);
            return new AsyncInvoker<ListCustomerOrdersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCustomerOrdersResponse>);
        }
        
        /// <summary>
        /// 查询资源详单
        ///
        /// 功能描述：客户在客户自建平台查询自己的资源详单，用于反映各类资源的消耗情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCustomerselfResourceRecordDetailsResponse> ListCustomerselfResourceRecordDetailsAsync(ListCustomerselfResourceRecordDetailsRequest listCustomerselfResourceRecordDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/customer-bills/res-records/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerselfResourceRecordDetailsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListCustomerselfResourceRecordDetailsResponse>(response);
        }

        public AsyncInvoker<ListCustomerselfResourceRecordDetailsResponse> ListCustomerselfResourceRecordDetailsAsyncInvoker(ListCustomerselfResourceRecordDetailsRequest listCustomerselfResourceRecordDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/customer-bills/res-records/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerselfResourceRecordDetailsRequest);
            return new AsyncInvoker<ListCustomerselfResourceRecordDetailsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCustomerselfResourceRecordDetailsResponse>);
        }
        
        /// <summary>
        /// 查询资源消费记录
        ///
        /// 功能描述：客户在客户自建平台查询每个资源的消费明细数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCustomerselfResourceRecordsResponse> ListCustomerselfResourceRecordsAsync(ListCustomerselfResourceRecordsRequest listCustomerselfResourceRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/customer-bills/res-fee-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerselfResourceRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCustomerselfResourceRecordsResponse>(response);
        }

        public AsyncInvoker<ListCustomerselfResourceRecordsResponse> ListCustomerselfResourceRecordsAsyncInvoker(ListCustomerselfResourceRecordsRequest listCustomerselfResourceRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/customer-bills/res-fee-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerselfResourceRecordsRequest);
            return new AsyncInvoker<ListCustomerselfResourceRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCustomerselfResourceRecordsResponse>);
        }
        
        /// <summary>
        /// 查询企业子账号列表
        ///
        /// 企业主账号在自建平台查询企业子账号信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnterpriseSubCustomersResponse> ListEnterpriseSubCustomersAsync(ListEnterpriseSubCustomersRequest listEnterpriseSubCustomersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/sub-customers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseSubCustomersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEnterpriseSubCustomersResponse>(response);
        }

        public AsyncInvoker<ListEnterpriseSubCustomersResponse> ListEnterpriseSubCustomersAsyncInvoker(ListEnterpriseSubCustomersRequest listEnterpriseSubCustomersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/sub-customers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseSubCustomersRequest);
            return new AsyncInvoker<ListEnterpriseSubCustomersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnterpriseSubCustomersResponse>);
        }
        
        /// <summary>
        /// 查询资源包列表
        ///
        /// 功能描述：客户在自建平台查询资源包列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFreeResourceInfosResponse> ListFreeResourceInfosAsync(ListFreeResourceInfosRequest listFreeResourceInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/payments/free-resources/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFreeResourceInfosRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListFreeResourceInfosResponse>(response);
        }

        public AsyncInvoker<ListFreeResourceInfosResponse> ListFreeResourceInfosAsyncInvoker(ListFreeResourceInfosRequest listFreeResourceInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/payments/free-resources/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFreeResourceInfosRequest);
            return new AsyncInvoker<ListFreeResourceInfosResponse>(this, "POST", request, JsonUtils.DeSerialize<ListFreeResourceInfosResponse>);
        }
        
        /// <summary>
        /// 查询资源包使用量
        ///
        /// 功能描述：客户在自建平台根据资源项维度查询资源包使用量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFreeResourceUsagesResponse> ListFreeResourceUsagesAsync(ListFreeResourceUsagesRequest listFreeResourceUsagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/payments/free-resources/usages/details/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFreeResourceUsagesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListFreeResourceUsagesResponse>(response);
        }

        public AsyncInvoker<ListFreeResourceUsagesResponse> ListFreeResourceUsagesAsyncInvoker(ListFreeResourceUsagesRequest listFreeResourceUsagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/payments/free-resources/usages/details/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFreeResourceUsagesRequest);
            return new AsyncInvoker<ListFreeResourceUsagesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListFreeResourceUsagesResponse>);
        }
        
        /// <summary>
        /// 查询资源包使用明细
        ///
        /// 客户在自建平台查询资源包使用明细。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFreeResourcesUsageRecordsResponse> ListFreeResourcesUsageRecordsAsync(ListFreeResourcesUsageRecordsRequest listFreeResourcesUsageRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/customer-bills/free-resources-usage-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFreeResourcesUsageRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFreeResourcesUsageRecordsResponse>(response);
        }

        public AsyncInvoker<ListFreeResourcesUsageRecordsResponse> ListFreeResourcesUsageRecordsAsyncInvoker(ListFreeResourcesUsageRecordsRequest listFreeResourcesUsageRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/customer-bills/free-resources-usage-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFreeResourcesUsageRecordsRequest);
            return new AsyncInvoker<ListFreeResourcesUsageRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFreeResourcesUsageRecordsResponse>);
        }
        
        /// <summary>
        /// 查询云经销商列表
        ///
        /// 华为云总经销商（一级经销商）可以查询云经销商（二级经销商）列表。
        /// 
        /// 一级经销商在伙伴中心查询二级经销商列表的方式请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/dp_120210.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIndirectPartnersResponse> ListIndirectPartnersAsync(ListIndirectPartnersRequest listIndirectPartnersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/indirect-partners/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIndirectPartnersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListIndirectPartnersResponse>(response);
        }

        public AsyncInvoker<ListIndirectPartnersResponse> ListIndirectPartnersAsyncInvoker(ListIndirectPartnersRequest listIndirectPartnersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/indirect-partners/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIndirectPartnersRequest);
            return new AsyncInvoker<ListIndirectPartnersResponse>(this, "POST", request, JsonUtils.DeSerialize<ListIndirectPartnersResponse>);
        }
        
        /// <summary>
        /// 查询发票列表
        ///
        /// 功能描述：查询发票列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInvoicesResponse> ListInvoicesAsync(ListInvoicesRequest listInvoicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{domain_id}/payments/intl-invoices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInvoicesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInvoicesResponse>(response);
        }

        public AsyncInvoker<ListInvoicesResponse> ListInvoicesAsyncInvoker(ListInvoicesRequest listInvoicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{domain_id}/payments/intl-invoices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInvoicesRequest);
            return new AsyncInvoker<ListInvoicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInvoicesResponse>);
        }
        
        /// <summary>
        /// 查询度量单位列表
        ///
        /// 功能描述：查询资源使用量，包年包月资源的时长及金额的度量单位及名称，度量单位类型等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMeasureUnitsResponse> ListMeasureUnitsAsync(ListMeasureUnitsRequest listMeasureUnitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bases/measurements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMeasureUnitsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMeasureUnitsResponse>(response);
        }

        public AsyncInvoker<ListMeasureUnitsResponse> ListMeasureUnitsAsyncInvoker(ListMeasureUnitsRequest listMeasureUnitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bases/measurements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMeasureUnitsRequest);
            return new AsyncInvoker<ListMeasureUnitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMeasureUnitsResponse>);
        }
        
        /// <summary>
        /// 查询按需产品价格
        ///
        /// 功能描述：按需资源询价
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOnDemandResourceRatingsResponse> ListOnDemandResourceRatingsAsync(ListOnDemandResourceRatingsRequest listOnDemandResourceRatingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/ratings/on-demand-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOnDemandResourceRatingsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListOnDemandResourceRatingsResponse>(response);
        }

        public AsyncInvoker<ListOnDemandResourceRatingsResponse> ListOnDemandResourceRatingsAsyncInvoker(ListOnDemandResourceRatingsRequest listOnDemandResourceRatingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/ratings/on-demand-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOnDemandResourceRatingsRequest);
            return new AsyncInvoker<ListOnDemandResourceRatingsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListOnDemandResourceRatingsResponse>);
        }
        
        /// <summary>
        /// 查询订单可用折扣
        ///
        /// 功能描述：功能介绍客户在伙伴销售平台支付待支付订单时，查询可使用的折扣。只返回商务合同折扣和伙伴授权折扣客户在客户自建平台查看订单可用的优惠券列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOrderDiscountsResponse> ListOrderDiscountsAsync(ListOrderDiscountsRequest listOrderDiscountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/customer-orders/order-discounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrderDiscountsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOrderDiscountsResponse>(response);
        }

        public AsyncInvoker<ListOrderDiscountsResponse> ListOrderDiscountsAsyncInvoker(ListOrderDiscountsRequest listOrderDiscountsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/customer-orders/order-discounts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrderDiscountsRequest);
            return new AsyncInvoker<ListOrderDiscountsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrderDiscountsResponse>);
        }
        
        /// <summary>
        /// 查询客户包年/包月资源列表
        ///
        /// 功能描述：客户在客户自建平台查询某个或所有的包年/包月资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPayPerUseCustomerResourcesResponse> ListPayPerUseCustomerResourcesAsync(ListPayPerUseCustomerResourcesRequest listPayPerUseCustomerResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/suscriptions/resources/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPayPerUseCustomerResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListPayPerUseCustomerResourcesResponse>(response);
        }

        public AsyncInvoker<ListPayPerUseCustomerResourcesResponse> ListPayPerUseCustomerResourcesAsyncInvoker(ListPayPerUseCustomerResourcesRequest listPayPerUseCustomerResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/suscriptions/resources/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPayPerUseCustomerResourcesRequest);
            return new AsyncInvoker<ListPayPerUseCustomerResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPayPerUseCustomerResourcesResponse>);
        }
        
        /// <summary>
        /// 查询伙伴月度消费账单
        ///
        /// 功能描述：伙伴可以查询伙伴月度消费账单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPostpaidBillSumResponse> ListPostpaidBillSumAsync(ListPostpaidBillSumRequest listPostpaidBillSumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/partner-bills/postpaid-bill-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostpaidBillSumRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPostpaidBillSumResponse>(response);
        }

        public AsyncInvoker<ListPostpaidBillSumResponse> ListPostpaidBillSumAsyncInvoker(ListPostpaidBillSumRequest listPostpaidBillSumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/partner-bills/postpaid-bill-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPostpaidBillSumRequest);
            return new AsyncInvoker<ListPostpaidBillSumResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPostpaidBillSumResponse>);
        }
        
        /// <summary>
        /// 查询包年/包月产品价格
        ///
        /// 功能描述：客户在自建平台按照条件查询包年/包月产品开通时候的价格
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRateOnPeriodDetailResponse> ListRateOnPeriodDetailAsync(ListRateOnPeriodDetailRequest listRateOnPeriodDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/ratings/period-resources/subscribe-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRateOnPeriodDetailRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListRateOnPeriodDetailResponse>(response);
        }

        public AsyncInvoker<ListRateOnPeriodDetailResponse> ListRateOnPeriodDetailAsyncInvoker(ListRateOnPeriodDetailRequest listRateOnPeriodDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/ratings/period-resources/subscribe-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRateOnPeriodDetailRequest);
            return new AsyncInvoker<ListRateOnPeriodDetailResponse>(this, "POST", request, JsonUtils.DeSerialize<ListRateOnPeriodDetailResponse>);
        }
        
        /// <summary>
        /// 查询待续订包年包月资源的续订金额
        ///
        /// 功能描述：客户在自建平台按照条件查询待续订包年/包月资源续订时候的续订金额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRenewRateOnPeriodResponse> ListRenewRateOnPeriodAsync(ListRenewRateOnPeriodRequest listRenewRateOnPeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/ratings/period-resources/renew-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRenewRateOnPeriodRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListRenewRateOnPeriodResponse>(response);
        }

        public AsyncInvoker<ListRenewRateOnPeriodResponse> ListRenewRateOnPeriodAsyncInvoker(ListRenewRateOnPeriodRequest listRenewRateOnPeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/ratings/period-resources/renew-rate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRenewRateOnPeriodRequest);
            return new AsyncInvoker<ListRenewRateOnPeriodResponse>(this, "POST", request, JsonUtils.DeSerialize<ListRenewRateOnPeriodResponse>);
        }
        
        /// <summary>
        /// 查询资源类型列表
        ///
        /// 伙伴在伙伴销售平台查询资源类型的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceTypesResponse> ListResourceTypesAsync(ListResourceTypesRequest listResourceTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/products/resource-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTypesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceTypesResponse>(response);
        }

        public AsyncInvoker<ListResourceTypesResponse> ListResourceTypesAsyncInvoker(ListResourceTypesRequest listResourceTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/products/resource-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTypesRequest);
            return new AsyncInvoker<ListResourceTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceTypesResponse>);
        }
        
        /// <summary>
        /// 根据云服务类型查询资源列表
        ///
        /// 功能描述：伙伴在伙伴销售平台根据云服务类型查询关联的资源类型编码和名称，用于查询按需产品的价格或包年/包月产品的价格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceResourcesResponse> ListServiceResourcesAsync(ListServiceResourcesRequest listServiceResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/products/service-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServiceResourcesResponse>(response);
        }

        public AsyncInvoker<ListServiceResourcesResponse> ListServiceResourcesAsyncInvoker(ListServiceResourcesRequest listServiceResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/products/service-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceResourcesRequest);
            return new AsyncInvoker<ListServiceResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceResourcesResponse>);
        }
        
        /// <summary>
        /// 查询云服务类型列表
        ///
        /// 伙伴在伙伴销售平台查询云服务类型的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceTypesResponse> ListServiceTypesAsync(ListServiceTypesRequest listServiceTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/products/service-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceTypesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServiceTypesResponse>(response);
        }

        public AsyncInvoker<ListServiceTypesResponse> ListServiceTypesAsyncInvoker(ListServiceTypesRequest listServiceTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/products/service-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceTypesRequest);
            return new AsyncInvoker<ListServiceTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceTypesResponse>);
        }
        
        /// <summary>
        /// 批量查询客户预算
        ///
        /// 功能描述：批量查询客户预算
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubCustomerBudgetResponse> ListSubCustomerBudgetAsync(ListSubCustomerBudgetRequest listSubCustomerBudgetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/budget/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubCustomerBudgetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListSubCustomerBudgetResponse>(response);
        }

        public AsyncInvoker<ListSubCustomerBudgetResponse> ListSubCustomerBudgetAsyncInvoker(ListSubCustomerBudgetRequest listSubCustomerBudgetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/budget/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubCustomerBudgetRequest);
            return new AsyncInvoker<ListSubCustomerBudgetResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSubCustomerBudgetResponse>);
        }
        
        /// <summary>
        /// 查询客户预算调整记录
        ///
        /// 功能描述：查询客户预算调整记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubCustomerBudgetRecordsResponse> ListSubCustomerBudgetRecordsAsync(ListSubCustomerBudgetRecordsRequest listSubCustomerBudgetRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/budget/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubCustomerBudgetRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSubCustomerBudgetRecordsResponse>(response);
        }

        public AsyncInvoker<ListSubCustomerBudgetRecordsResponse> ListSubCustomerBudgetRecordsAsyncInvoker(ListSubCustomerBudgetRecordsRequest listSubCustomerBudgetRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/budget/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubCustomerBudgetRecordsRequest);
            return new AsyncInvoker<ListSubCustomerBudgetRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubCustomerBudgetRecordsResponse>);
        }
        
        /// <summary>
        /// 查询优惠券列表
        ///
        /// 功能描述：伙伴/客户可以查询自身的优惠券信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubCustomerCouponsResponse> ListSubCustomerCouponsAsync(ListSubCustomerCouponsRequest listSubCustomerCouponsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/promotions/benefits/coupons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubCustomerCouponsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSubCustomerCouponsResponse>(response);
        }

        public AsyncInvoker<ListSubCustomerCouponsResponse> ListSubCustomerCouponsAsyncInvoker(ListSubCustomerCouponsRequest listSubCustomerCouponsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/promotions/benefits/coupons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubCustomerCouponsRequest);
            return new AsyncInvoker<ListSubCustomerCouponsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubCustomerCouponsResponse>);
        }
        
        /// <summary>
        /// 查询客户列表
        ///
        /// 功能描述：伙伴可以查询合作伙伴的客户信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubCustomersResponse> ListSubCustomersAsync(ListSubCustomersRequest listSubCustomersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubCustomersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListSubCustomersResponse>(response);
        }

        public AsyncInvoker<ListSubCustomersResponse> ListSubCustomersAsyncInvoker(ListSubCustomersRequest listSubCustomersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubCustomersRequest);
            return new AsyncInvoker<ListSubCustomersResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSubCustomersResponse>);
        }
        
        /// <summary>
        /// 查询使用量类型列表
        ///
        /// 功能描述：伙伴在伙伴销售平台查询资源的使用量类型列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUsageTypesResponse> ListUsageTypesAsync(ListUsageTypesRequest listUsageTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/products/usage-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsageTypesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUsageTypesResponse>(response);
        }

        public AsyncInvoker<ListUsageTypesResponse> ListUsageTypesAsyncInvoker(ListUsageTypesRequest listUsageTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/products/usage-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsageTypesRequest);
            return new AsyncInvoker<ListUsageTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsageTypesResponse>);
        }
        
        /// <summary>
        /// 支付包年/包月产品订单
        ///
        /// 客户可以对待支付状态的包年/包月产品订单进行支付
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PayOrdersResponse> PayOrdersAsync(PayOrdersRequest payOrdersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/orders/customer-orders/pay", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", payOrdersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<PayOrdersResponse>(response);
        }

        public AsyncInvoker<PayOrdersResponse> PayOrdersAsyncInvoker(PayOrdersRequest payOrdersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/orders/customer-orders/pay", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", payOrdersRequest);
            return new AsyncInvoker<PayOrdersResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PayOrdersResponse>);
        }
        
        /// <summary>
        /// 续订包年/包月资源
        ///
        /// 功能描述：客户的包年包/月资源即将到期时，可进行包年/包月资源的续订
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RenewalResourcesResponse> RenewalResourcesAsync(RenewalResourcesRequest renewalResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/subscriptions/resources/renew", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", renewalResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RenewalResourcesResponse>(response);
        }

        public AsyncInvoker<RenewalResourcesResponse> RenewalResourcesAsyncInvoker(RenewalResourcesRequest renewalResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/subscriptions/resources/renew", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", renewalResourcesRequest);
            return new AsyncInvoker<RenewalResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<RenewalResourcesResponse>);
        }
        
        /// <summary>
        /// 发送验证码
        ///
        /// 功能描述：客户注册时，如果填写了邮箱，可以向对应的邮箱发送注册验证码，校验信息的正确性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SendVerificationMessageCodeResponse> SendVerificationMessageCodeAsync(SendVerificationMessageCodeRequest sendVerificationMessageCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bases/verificationcode/send", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendVerificationMessageCodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SendVerificationMessageCodeResponse>(response);
        }

        public AsyncInvoker<SendVerificationMessageCodeResponse> SendVerificationMessageCodeAsyncInvoker(SendVerificationMessageCodeRequest sendVerificationMessageCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bases/verificationcode/send", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendVerificationMessageCodeRequest);
            return new AsyncInvoker<SendVerificationMessageCodeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SendVerificationMessageCodeResponse>);
        }
        
        /// <summary>
        /// 设置包年/包月资源自动续费扣款日和续费后资源统一到期日
        ///
        /// 功能描述：客户的包年/包月资源可进行设置自动续费扣款日和续费后统一到期日
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetResourcesRenewConfigResponse> SetResourcesRenewConfigAsync(SetResourcesRenewConfigRequest setResourcesRenewConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/subscriptions/resources/renew/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setResourcesRenewConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SetResourcesRenewConfigResponse>(response);
        }

        public AsyncInvoker<SetResourcesRenewConfigResponse> SetResourcesRenewConfigAsyncInvoker(SetResourcesRenewConfigRequest setResourcesRenewConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/subscriptions/resources/renew/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setResourcesRenewConfigRequest);
            return new AsyncInvoker<SetResourcesRenewConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<SetResourcesRenewConfigResponse>);
        }
        
        /// <summary>
        /// 查询账户余额
        ///
        /// 功能描述：客户可以查询自身的账户余额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCustomerAccountBalancesResponse> ShowCustomerAccountBalancesAsync(ShowCustomerAccountBalancesRequest showCustomerAccountBalancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/customer-accounts/balances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomerAccountBalancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCustomerAccountBalancesResponse>(response);
        }

        public AsyncInvoker<ShowCustomerAccountBalancesResponse> ShowCustomerAccountBalancesAsyncInvoker(ShowCustomerAccountBalancesRequest showCustomerAccountBalancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/customer-accounts/balances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomerAccountBalancesRequest);
            return new AsyncInvoker<ShowCustomerAccountBalancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCustomerAccountBalancesResponse>);
        }
        
        /// <summary>
        /// 查询消费配额
        ///
        /// 功能描述：客户可以查询自身的消费配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCustomerExpenditureQuotaResponse> ShowCustomerExpenditureQuotaAsync(ShowCustomerExpenditureQuotaRequest showCustomerExpenditureQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/customer-accounts/expenditure-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomerExpenditureQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCustomerExpenditureQuotaResponse>(response);
        }

        public AsyncInvoker<ShowCustomerExpenditureQuotaResponse> ShowCustomerExpenditureQuotaAsyncInvoker(ShowCustomerExpenditureQuotaRequest showCustomerExpenditureQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/customer-accounts/expenditure-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomerExpenditureQuotaRequest);
            return new AsyncInvoker<ShowCustomerExpenditureQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCustomerExpenditureQuotaResponse>);
        }
        
        /// <summary>
        /// 查询汇总账单
        ///
        /// 客户在自建平台查询自身的消费汇总账单，此账单按月汇总消费数据。
        /// 
        /// 客户登录费用中心查询自身的消费汇总账单请参见[这里](https://support.huaweicloud.com/intl/zh-cn/usermanual-billing/bills-topic_0000108.html)的“查看汇总”。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCustomerMonthlySumResponse> ShowCustomerMonthlySumAsync(ShowCustomerMonthlySumRequest showCustomerMonthlySumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/customer-bills/monthly-sum", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomerMonthlySumRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCustomerMonthlySumResponse>(response);
        }

        public AsyncInvoker<ShowCustomerMonthlySumResponse> ShowCustomerMonthlySumAsyncInvoker(ShowCustomerMonthlySumRequest showCustomerMonthlySumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/customer-bills/monthly-sum", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomerMonthlySumRequest);
            return new AsyncInvoker<ShowCustomerMonthlySumResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCustomerMonthlySumResponse>);
        }
        
        /// <summary>
        /// 查询订单详情
        ///
        /// 功能描述：客户可以查看订单详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCustomerOrderDetailsResponse> ShowCustomerOrderDetailsAsync(ShowCustomerOrderDetailsRequest showCustomerOrderDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("order_id", showCustomerOrderDetailsRequest.OrderId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/customer-orders/details/{order_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomerOrderDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCustomerOrderDetailsResponse>(response);
        }

        public AsyncInvoker<ShowCustomerOrderDetailsResponse> ShowCustomerOrderDetailsAsyncInvoker(ShowCustomerOrderDetailsRequest showCustomerOrderDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("order_id", showCustomerOrderDetailsRequest.OrderId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/customer-orders/details/{order_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCustomerOrderDetailsRequest);
            return new AsyncInvoker<ShowCustomerOrderDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCustomerOrderDetailsResponse>);
        }
        
        /// <summary>
        /// 查询消费配额
        ///
        /// 功能描述：合作伙伴可以查询消费配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPartnerConsumptionQuotaResponse> ShowPartnerConsumptionQuotaAsync(ShowPartnerConsumptionQuotaRequest showPartnerConsumptionQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/credit/consumption-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartnerConsumptionQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPartnerConsumptionQuotaResponse>(response);
        }

        public AsyncInvoker<ShowPartnerConsumptionQuotaResponse> ShowPartnerConsumptionQuotaAsyncInvoker(ShowPartnerConsumptionQuotaRequest showPartnerConsumptionQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/credit/consumption-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartnerConsumptionQuotaRequest);
            return new AsyncInvoker<ShowPartnerConsumptionQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPartnerConsumptionQuotaResponse>);
        }
        
        /// <summary>
        /// 查询实名认证审核结果
        ///
        /// 功能描述：如果实名认证申请或实名认证变更申请的响应中，显示需要人工审核，使用该接口查询审核结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRealnameAuthenticationReviewResultResponse> ShowRealnameAuthenticationReviewResultAsync(ShowRealnameAuthenticationReviewResultRequest showRealnameAuthenticationReviewResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/customers/realname-auths/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRealnameAuthenticationReviewResultRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRealnameAuthenticationReviewResultResponse>(response);
        }

        public AsyncInvoker<ShowRealnameAuthenticationReviewResultResponse> ShowRealnameAuthenticationReviewResultAsyncInvoker(ShowRealnameAuthenticationReviewResultRequest showRealnameAuthenticationReviewResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/customers/realname-auths/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRealnameAuthenticationReviewResultRequest);
            return new AsyncInvoker<ShowRealnameAuthenticationReviewResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRealnameAuthenticationReviewResultResponse>);
        }
        
        /// <summary>
        /// 查询退款订单的金额详情
        ///
        /// 功能描述：客户在伙伴销售平台查询某次退订订单或者降配订单的退款金额来自哪些资源和对应订单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRefundOrderDetailsResponse> ShowRefundOrderDetailsAsync(ShowRefundOrderDetailsRequest showRefundOrderDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/customer-orders/refund-orders", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRefundOrderDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRefundOrderDetailsResponse>(response);
        }

        public AsyncInvoker<ShowRefundOrderDetailsResponse> ShowRefundOrderDetailsAsyncInvoker(ShowRefundOrderDetailsRequest showRefundOrderDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/customer-orders/refund-orders", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRefundOrderDetailsRequest);
            return new AsyncInvoker<ShowRefundOrderDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRefundOrderDetailsResponse>);
        }
        
        /// <summary>
        /// 查询客户预算
        ///
        /// 功能描述：查询客户预算
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSubCustomerBudgetResponse> ShowSubCustomerBudgetAsync(ShowSubCustomerBudgetRequest showSubCustomerBudgetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/budget", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubCustomerBudgetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSubCustomerBudgetResponse>(response);
        }

        public AsyncInvoker<ShowSubCustomerBudgetResponse> ShowSubCustomerBudgetAsyncInvoker(ShowSubCustomerBudgetRequest showSubCustomerBudgetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/budget", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubCustomerBudgetRequest);
            return new AsyncInvoker<ShowSubCustomerBudgetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubCustomerBudgetResponse>);
        }
        
        /// <summary>
        /// 解冻客户账号
        ///
        /// 功能描述：解冻伙伴子客户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UnfreezeSubCustomersResponse> UnfreezeSubCustomersAsync(UnfreezeSubCustomersRequest unfreezeSubCustomersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/unfreeze", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unfreezeSubCustomersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UnfreezeSubCustomersResponse>(response);
        }

        public AsyncInvoker<UnfreezeSubCustomersResponse> UnfreezeSubCustomersAsyncInvoker(UnfreezeSubCustomersRequest unfreezeSubCustomersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/unfreeze", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unfreezeSubCustomersRequest);
            return new AsyncInvoker<UnfreezeSubCustomersResponse>(this, "POST", request, JsonUtils.DeSerialize<UnfreezeSubCustomersResponse>);
        }
        
        /// <summary>
        /// 设置或者取消包年/包月资源到期转按需
        ///
        /// 功能描述：客户可以设置包年/包月资源到期后转为按需资源计费。包年/包月计费模式到期后，按需的计费模式即生效
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePeriodToOnDemandResponse> UpdatePeriodToOnDemandAsync(UpdatePeriodToOnDemandRequest updatePeriodToOnDemandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/subscriptions/resources/to-on-demand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePeriodToOnDemandRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdatePeriodToOnDemandResponse>(response);
        }

        public AsyncInvoker<UpdatePeriodToOnDemandResponse> UpdatePeriodToOnDemandAsyncInvoker(UpdatePeriodToOnDemandRequest updatePeriodToOnDemandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/subscriptions/resources/to-on-demand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePeriodToOnDemandRequest);
            return new AsyncInvoker<UpdatePeriodToOnDemandResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdatePeriodToOnDemandResponse>);
        }
        
        /// <summary>
        /// 设置客户预算
        ///
        /// 功能描述：设置客户预算
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSubCustomerBudgetResponse> UpdateSubCustomerBudgetAsync(UpdateSubCustomerBudgetRequest updateSubCustomerBudgetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/budget", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubCustomerBudgetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateSubCustomerBudgetResponse>(response);
        }

        public AsyncInvoker<UpdateSubCustomerBudgetResponse> UpdateSubCustomerBudgetAsyncInvoker(UpdateSubCustomerBudgetRequest updateSubCustomerBudgetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/budget", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubCustomerBudgetRequest);
            return new AsyncInvoker<UpdateSubCustomerBudgetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateSubCustomerBudgetResponse>);
        }
        
    }
}