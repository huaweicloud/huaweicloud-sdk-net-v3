using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Bss.V2.Model;

namespace HuaweiCloud.SDK.Bss.V2
{
    public partial class BssAsyncClient : Client
    {
        public static ClientBuilder<BssAsyncClient> NewBuilder()
        {
            return new ClientBuilder<BssAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 设置包年/包月资源自动续费
        ///
        /// 为防止资源到期被删除，客户可为长期使用的包年/包月资源开通自动续费。
        /// 
        /// 客户在费用中心开通自动续费请参见[这里](https://support.huaweicloud.com/usermanual-billing/renewals_topic_20000003.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;-   首先要客户成功支付包年/包月资源订单，才能进行自动续费的开通。
        /// &gt;-   目前支持设置自动续费的包年/包月产品请参见[自动续费规则说明](https://support.huaweicloud.com/usermanual-billing/renewals_topic_20000002.html)。
        /// &gt;-   在调用本接口前，您可以调用“[查询客户包年/包月资源列表](https://support.huaweicloud.com/api-oce/api_order_00021.html)”接口获取资源ID、资源过期时间以及资源过期后扣费策略等信息。
        /// &gt;-   自动续费将于产品到期前7天的凌晨3:00开始扣款，请保持账户余额充足。若由于账户中余额不足等原因导致第一次未扣费成功，系统将每天凌晨3:00尝试进行一次扣款，直到扣款成功或保留产品资源的最后一天。
        /// &gt;-   续费周期与原资源的购买周期一致。
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
        /// 客户设置自动续费后，还可以执行取消自动续费的操作。关闭自动续费后，资源到期将不会被自动续费。
        /// 
        /// 客户在费用中心取消包年/包月资源自动续费请参见[这里](https://support.huaweicloud.com/usermanual-billing/renewals_topic_20000005.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;-   前提是已经调用“[设置包年/包月资源自动续费](https://support.huaweicloud.com/api-oce/api_order_00022.html)”接口设置自动续费或在调用“[续订包年/包月资源](https://support.huaweicloud.com/api-oce/api_order_00018.html)”接口时设置到期策略为自动续订。
        /// &gt;-   目前支持取消自动续费的包年/包月产品同支持自动续费的包年/包月产品。
        /// &gt;-   在调用本接口前，您可以调用“[查询客户包年/包月资源列表](https://support.huaweicloud.com/api-bpconsole/api_order_00021.html)”接口获取资源ID、资源过期时间以及资源过期后扣费策略等信息。
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
        /// 客户可以对待支付的订单进行取消操作。
        /// 
        /// 客户登录费用中心取消包年包月产品的待支付订单请单击[这里](https://support.huaweicloud.com/usermanual-billing/zh-cn_topic_0031465730.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;只有订单状态是“待支付”的时候，才能取消订单。
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
        /// 客户购买包年/包月资源后，支持客户退订包年/包月实例。退订资源实例包括资源续费部分和当前正在使用的部分，退订后资源将无法使用。
        /// 
        /// 客户在费用中心退订已购买的包年包月资源请参见[这里](https://support.huaweicloud.com/usermanual-billing/zh-cn_topic_0083138805.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;-   首先要成功支付包年/包月产品，产生一条开通成功的包年/包月资源，才能进行退订。
        /// &gt;-   调用接口后，如果某个主资源有对应的从资源，系统会将主资源和从资源一起退订，主资源的从资源信息可以通过调用[查询客户包年/包月资源列表](https://support.huaweicloud.com/api-oce/api_order_00021.html)接口获取。
        /// &gt;-   注意：如ECS主机挂载新购的云硬盘，但此硬盘不是该ECS主资源的从资源，主从资源信息必须以调用[查询客户包年/包月资源列表](https://support.huaweicloud.com/api-oce/api_order_00021.html)接口获取的信息为准。
        /// &gt;-   调用该接口后，您还可以调用“[查询退款订单的金额详情](查询退款订单的金额详情.md)”接口查询退订订单对应的金额来自哪些订单。
        /// &gt;-   该接口支持5天无理由全额退订，具体规则请参见“[退订规则说明](https://support.huaweicloud.com/usermanual-billing/unsubscription_topic_20000081.html)”。
        /// &gt;-   您正在退订使用中的资源，请仔细确认资源信息和退款信息。未放入回收站的资源退订后无法恢复，若您要保留资源，仅退订未使用的续费周期，请退订续费周期。
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
        /// 客户可以进行实名认证变更申请。
        /// 
        /// 个人客户登录帐号中心通过实名认证变更为企业帐号的方式及流程请参见[这里](https://support.huaweicloud.com/usermanual-account/zh-cn_topic_0103532632.html)。
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
        /// 客户注册时可检查客户的登录名称、手机号或者邮箱是否可以用于注册。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;针对校验手机号场景，目前仅支持校验手机号注册数量是否超过上限。
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
        /// 企业主账号向企业子账号拨款优惠券
        ///
        /// 企业主账号在自建平台向企业子账号拨款优惠券。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;-   仅支持华为发放的测试类、商务类、活动类代金券。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ClaimEnterpriseMultiAccountCouponResponse> ClaimEnterpriseMultiAccountCouponAsync(ClaimEnterpriseMultiAccountCouponRequest claimEnterpriseMultiAccountCouponRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/transfer-coupon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", claimEnterpriseMultiAccountCouponRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ClaimEnterpriseMultiAccountCouponResponse>(response);
        }

        public AsyncInvoker<ClaimEnterpriseMultiAccountCouponResponse> ClaimEnterpriseMultiAccountCouponAsyncInvoker(ClaimEnterpriseMultiAccountCouponRequest claimEnterpriseMultiAccountCouponRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/transfer-coupon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", claimEnterpriseMultiAccountCouponRequest);
            return new AsyncInvoker<ClaimEnterpriseMultiAccountCouponResponse>(this, "POST", request, JsonUtils.DeSerialize<ClaimEnterpriseMultiAccountCouponResponse>);
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
        /// 企业客户可以进行企业实名认证申请。
        /// 
        /// 客户登录帐号中心进行企业实名认证的方式及流程请参见[这里](https://support.huaweicloud.com/usermanual-account/zh-cn_topic_0077914253.html)。
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
        /// 发放优惠券
        ///
        /// 合作伙伴可以在拥有的代金券额度范围内为客户下发优惠券。
        /// 
        /// 伙伴登录合作伙伴中心为客户发放代金券请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/espp_050502.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;只能给代售子客户发放优惠券。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePartnerCouponsResponse> CreatePartnerCouponsAsync(CreatePartnerCouponsRequest createPartnerCouponsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/promotions/benefits/partner-coupons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPartnerCouponsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePartnerCouponsResponse>(response);
        }

        public AsyncInvoker<CreatePartnerCouponsResponse> CreatePartnerCouponsAsyncInvoker(CreatePartnerCouponsRequest createPartnerCouponsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/promotions/benefits/partner-coupons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPartnerCouponsRequest);
            return new AsyncInvoker<CreatePartnerCouponsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePartnerCouponsResponse>);
        }
        
        /// <summary>
        /// 申请个人实名认证
        ///
        /// 个人客户可以进行个人实名认证申请。
        /// 
        /// 客户登录帐号中心进行个人实名认证的方式及流程请参见[这里](https://support.huaweicloud.com/usermanual-account/zh-cn_topic_0077914254.html)。
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
        /// 在伙伴销售平台创建客户时同步创建华为云账号，并将客户在伙伴销售平台上的账号与华为云账号进行映射。同时，创建的华为云账号与伙伴账号关联绑定。
        /// 
        /// 华为云总经销商（一级经销商）可以注册云经销商（二级经销商）的子客户。注册完成后，子客户可以自动和云经销商绑定。
        /// 
        /// &gt;![](public_sys-resources/icon-caution.gif) **注意：** 
        /// &gt;-   调用该接口为客户创建华为云账号后，如果想从合作伙伴销售平台跳转至华为云官网，还需要进行SAML认证，具体请参见“[Web UI方式](https://support.huaweicloud.com/api-bpconsole/jac_00001.html)”中的“SAML认证”。
        /// &gt;-   如果创建的时候不输入手机号，那么客户将无法收到华为云发出的任何提醒短信，需要客户自己登录到华为云平台补充手机号。
        /// &gt;-   调用“创建客户”接口时，华为云会同步创建华为云客户账号，将客户ID及账号名返回给伙伴平台，然后华为云异步完成客户与伙伴的关联。伙伴与客户的关联结果可通过“[查询客户列表](https://support.huaweicloud.com/api-bpconsole/mc_00021.html)”查询。
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
        /// 创建企业子账号
        ///
        /// 企业主账号在自建平台创建企业子账号。
        /// 
        /// 企业主账号创建企业子账号请参见[这里](https://support.huaweicloud.com/usermanual-em/zh-cn_topic_0104194162.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSubEnterpriseAccountResponse> CreateSubEnterpriseAccountAsync(CreateSubEnterpriseAccountRequest createSubEnterpriseAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/sub-customers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubEnterpriseAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSubEnterpriseAccountResponse>(response);
        }

        public AsyncInvoker<CreateSubEnterpriseAccountResponse> CreateSubEnterpriseAccountAsyncInvoker(CreateSubEnterpriseAccountRequest createSubEnterpriseAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/sub-customers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubEnterpriseAccountRequest);
            return new AsyncInvoker<CreateSubEnterpriseAccountResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSubEnterpriseAccountResponse>);
        }
        
        /// <summary>
        /// 查询城市信息
        ///
        /// 伙伴在伙伴销售平台上查询城市信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCitiesResponse> ListCitiesAsync(ListCitiesRequest listCitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/systems/configs/cities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCitiesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCitiesResponse>(response);
        }

        public AsyncInvoker<ListCitiesResponse> ListCitiesAsyncInvoker(ListCitiesRequest listCitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/systems/configs/cities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCitiesRequest);
            return new AsyncInvoker<ListCitiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCitiesResponse>);
        }
        
        /// <summary>
        /// 查询伙伴消费子客户列表
        ///
        /// 伙伴在伙伴销售平台可实时查询消费账期内的子客户列表，可以用于查询子客户的消费记录。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;若当前子客户与伙伴无关联关系，仍可查询账期内处于关联状态且有消费的子客户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConsumeSubCustomersResponse> ListConsumeSubCustomersAsync(ListConsumeSubCustomersRequest listConsumeSubCustomersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/subcustomer-bills/res-fee-records/sub-customers/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumeSubCustomersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListConsumeSubCustomersResponse>(response);
        }

        public AsyncInvoker<ListConsumeSubCustomersResponse> ListConsumeSubCustomersAsyncInvoker(ListConsumeSubCustomersRequest listConsumeSubCustomersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/subcustomer-bills/res-fee-records/sub-customers/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumeSubCustomersRequest);
            return new AsyncInvoker<ListConsumeSubCustomersResponse>(this, "POST", request, JsonUtils.DeSerialize<ListConsumeSubCustomersResponse>);
        }
        
        /// <summary>
        /// 查询度量单位进制
        ///
        /// 伙伴在伙伴销售平台上查询度量单位的进制转换信息，用于不同度量单位之间的转换。
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
        /// 查询区县信息
        ///
        /// 伙伴在伙伴销售平台上查询区县信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCountiesResponse> ListCountiesAsync(ListCountiesRequest listCountiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/systems/configs/counties", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCountiesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCountiesResponse>(response);
        }

        public AsyncInvoker<ListCountiesResponse> ListCountiesAsyncInvoker(ListCountiesRequest listCountiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/systems/configs/counties", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCountiesRequest);
            return new AsyncInvoker<ListCountiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCountiesResponse>);
        }
        
        /// <summary>
        /// 查询代金券额度的发放回收记录
        ///
        /// 华为云总经销商（一级经销商）可以查看给云经销商（二级经销商）发放或回收代金券额度的操作记录。
        /// 
        /// 一级经销商可以登录伙伴中心，进入“客户业务** **\\&gt; 代金券管理”，选择“代金券额度”页签，单击“操作记录”查看代金券额度的发放和回收记录。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;伙伴也可以单击代金券额度所在行的“操作记录”，查看该代金券额度对应的操作记录日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCouponQuotasRecordsResponse> ListCouponQuotasRecordsAsync(ListCouponQuotasRecordsRequest listCouponQuotasRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/coupon-quotas/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCouponQuotasRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCouponQuotasRecordsResponse>(response);
        }

        public AsyncInvoker<ListCouponQuotasRecordsResponse> ListCouponQuotasRecordsAsyncInvoker(ListCouponQuotasRecordsRequest listCouponQuotasRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/coupon-quotas/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCouponQuotasRecordsRequest);
            return new AsyncInvoker<ListCouponQuotasRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCouponQuotasRecordsResponse>);
        }
        
        /// <summary>
        /// 查询收支明细(客户)
        ///
        /// 功能描述：客户可以查询自身的收支明细情况(此接口不适用于伙伴的代售类、转售类客户。)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCustomerAccountChangeRecordsResponse> ListCustomerAccountChangeRecordsAsync(ListCustomerAccountChangeRecordsRequest listCustomerAccountChangeRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/customer-accounts/account-change-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerAccountChangeRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCustomerAccountChangeRecordsResponse>(response);
        }

        public AsyncInvoker<ListCustomerAccountChangeRecordsResponse> ListCustomerAccountChangeRecordsAsyncInvoker(ListCustomerAccountChangeRecordsRequest listCustomerAccountChangeRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/customer-accounts/account-change-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerAccountChangeRecordsRequest);
            return new AsyncInvoker<ListCustomerAccountChangeRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCustomerAccountChangeRecordsResponse>);
        }
        
        /// <summary>
        /// 查询流水账单
        ///
        /// 客户在自建平台查询自己的消费流水账单。
        /// 
        /// 客户登录费用中心查询自己的消费流水账单请参见[这里](https://support.huaweicloud.com/usermanual-billing/bills-topic_80000001.html#bills-topic_80000001__zh-cn_topic_0000001162496407_s716e04d5d0ba4e9d9a76a8bcbfbcfe73)的“**查看流水账单**”。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCustomerBillsFeeRecordsResponse> ListCustomerBillsFeeRecordsAsync(ListCustomerBillsFeeRecordsRequest listCustomerBillsFeeRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/customer-bills/fee-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerBillsFeeRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCustomerBillsFeeRecordsResponse>(response);
        }

        public AsyncInvoker<ListCustomerBillsFeeRecordsResponse> ListCustomerBillsFeeRecordsAsyncInvoker(ListCustomerBillsFeeRecordsRequest listCustomerBillsFeeRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/customer-bills/fee-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerBillsFeeRecordsRequest);
            return new AsyncInvoker<ListCustomerBillsFeeRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCustomerBillsFeeRecordsResponse>);
        }
        
        /// <summary>
        /// 查询月度成本
        ///
        /// 客户可以查询指定月份的月度摊销成本。当前仅支持查询近18个月的摊销成本。摊销成本计算规则请参见[成本摊销规则](https://support.huaweicloud.com/usermanual-cost/costcenter_000002_01.html)。
        /// 
        /// 客户可查询的数据范围同成本中心提供的[数据范围](https://support.huaweicloud.com/usermanual-cost/costcenter_0000004.html)一致。
        /// 
        /// 客户登录成本中心导出成本明细请参见[导出成本明细数据](https://support.huaweicloud.com/usermanual-cost/costcenter_000002_03.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;该接口仅面向已开通成本中心的客户开放。如何开启成本中心请参见[这里](https://support.huaweicloud.com/usermanual-cost/costcenter_000004.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCustomerBillsMonthlyBreakDownResponse> ListCustomerBillsMonthlyBreakDownAsync(ListCustomerBillsMonthlyBreakDownRequest listCustomerBillsMonthlyBreakDownRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/costs/cost-analysed-bills/monthly-breakdown", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerBillsMonthlyBreakDownRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCustomerBillsMonthlyBreakDownResponse>(response);
        }

        public AsyncInvoker<ListCustomerBillsMonthlyBreakDownResponse> ListCustomerBillsMonthlyBreakDownAsyncInvoker(ListCustomerBillsMonthlyBreakDownRequest listCustomerBillsMonthlyBreakDownRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/costs/cost-analysed-bills/monthly-breakdown", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomerBillsMonthlyBreakDownRequest);
            return new AsyncInvoker<ListCustomerBillsMonthlyBreakDownResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCustomerBillsMonthlyBreakDownResponse>);
        }
        
        /// <summary>
        /// 查询客户按需资源列表
        ///
        /// 合作伙伴可以查询关联的代售类客户已开通的按需资源。
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
        /// 客户购买包年/包月资源后，可以查看待审核、处理中、已取消、已完成和待支付等状态的订单。
        /// 
        /// 伙伴登录伙伴中心查看客户订单请单击[这里](https://support.huaweicloud.com/usermanual-bpconsole/zh-cn_topic_0076200001.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;如果想查询某条订单下的资源信息，在调用本接口获取订单ID后，请调用“[查询客户包年/包月资源列表](https://support.huaweicloud.com/api-oce/api_order_00021.html)”接口在请求参数输入订单号进行查询。
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
        /// 查询客户账户余额
        ///
        /// 合作伙伴可以查询关联的代售类客户的账户余额。
        /// 
        /// 伙伴登录伙伴中心查询客户余额请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/zh-cn_topic_0072435115.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;顾问销售类客户是客户在华为云充值，合作伙伴无法调用此接口查询其账户余额。代售类客户的账户由合作伙伴拨款，所以可以查询到。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCustomersBalancesDetailResponse> ListCustomersBalancesDetailAsync(ListCustomersBalancesDetailRequest listCustomersBalancesDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/customer-accounts/balances/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomersBalancesDetailRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListCustomersBalancesDetailResponse>(response);
        }

        public AsyncInvoker<ListCustomersBalancesDetailResponse> ListCustomersBalancesDetailAsyncInvoker(ListCustomersBalancesDetailRequest listCustomersBalancesDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/customer-accounts/balances/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomersBalancesDetailRequest);
            return new AsyncInvoker<ListCustomersBalancesDetailResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCustomersBalancesDetailResponse>);
        }
        
        /// <summary>
        /// 查询资源详单
        ///
        /// 客户在自建平台查询自己的资源详单，用于反映各类资源的消耗情况。
        /// 
        /// 客户登录费用中心查询资源详单请参见[这里](https://support.huaweicloud.com/usermanual-billing/bills_topic_100000063.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;由于资源消费呈现的是资源维度的8位小数原始消费金额，实际从账户扣费时按2位小数进行扣费（即扣到分），会存在精度差异，所以，不推荐消费汇总和资源消费直接对账。
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
        /// 客户在自建平台查询每个资源的消费明细数据。
        /// 
        /// 客户登录费用中心查询资源消费记录请参见[这里](https://support.huaweicloud.com/usermanual-billing/bills_topic_100000061.html)。
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
        /// 查询企业子账号可回收余额
        ///
        /// 企业主账号在自建平台查询企业子账号的可回收余额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnterpriseMultiAccountResponse> ListEnterpriseMultiAccountAsync(ListEnterpriseMultiAccountRequest listEnterpriseMultiAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/retrieve-amount", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseMultiAccountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEnterpriseMultiAccountResponse>(response);
        }

        public AsyncInvoker<ListEnterpriseMultiAccountResponse> ListEnterpriseMultiAccountAsyncInvoker(ListEnterpriseMultiAccountRequest listEnterpriseMultiAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/retrieve-amount", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseMultiAccountRequest);
            return new AsyncInvoker<ListEnterpriseMultiAccountResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnterpriseMultiAccountResponse>);
        }
        
        /// <summary>
        /// 查询企业组织结构
        ///
        /// 企业主账号在自建平台查询企业组织结构。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnterpriseOrganizationsResponse> ListEnterpriseOrganizationsAsync(ListEnterpriseOrganizationsRequest listEnterpriseOrganizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/enterprise-organizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseOrganizationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEnterpriseOrganizationsResponse>(response);
        }

        public AsyncInvoker<ListEnterpriseOrganizationsResponse> ListEnterpriseOrganizationsAsyncInvoker(ListEnterpriseOrganizationsRequest listEnterpriseOrganizationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/enterprise-organizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseOrganizationsRequest);
            return new AsyncInvoker<ListEnterpriseOrganizationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnterpriseOrganizationsResponse>);
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
        /// 客户在伙伴销售平台查询客户的资源包列表。
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
        /// 客户在伙伴销售平台根据资源项维度查询客户的资源包使用量。
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
        /// 查询产品的折扣和激励策略
        ///
        /// 伙伴在伙伴销售平台上查询产品的折扣和激励策略。
        /// 
        /// 伙伴登录合作伙伴中心查看产品的折扣和激励策略请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/dp_120400.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIncentiveDiscountPoliciesResponse> ListIncentiveDiscountPoliciesAsync(ListIncentiveDiscountPoliciesRequest listIncentiveDiscountPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/products/incentive-discount-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIncentiveDiscountPoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListIncentiveDiscountPoliciesResponse>(response);
        }

        public AsyncInvoker<ListIncentiveDiscountPoliciesResponse> ListIncentiveDiscountPoliciesAsyncInvoker(ListIncentiveDiscountPoliciesRequest listIncentiveDiscountPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/products/incentive-discount-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIncentiveDiscountPoliciesRequest);
            return new AsyncInvoker<ListIncentiveDiscountPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIncentiveDiscountPoliciesResponse>);
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
        /// 查询已发放的代金券额度
        ///
        /// 华为云总经销商（一级经销商）可以查看发放给云经销商（二级经销商）的代金券额度列表。
        /// 
        /// 一级经销商登录伙伴中心，进入“客户业务** **\\&gt; 代金券管理”，选择“已发放代金券额度”可查看代金券额度列表。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;调用该接口之前，需通过客户经理联系华为运营人员，为合作伙伴设置代金券发放额度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIssuedCouponQuotasResponse> ListIssuedCouponQuotasAsync(ListIssuedCouponQuotasRequest listIssuedCouponQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/issued-coupon-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssuedCouponQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListIssuedCouponQuotasResponse>(response);
        }

        public AsyncInvoker<ListIssuedCouponQuotasResponse> ListIssuedCouponQuotasAsyncInvoker(ListIssuedCouponQuotasRequest listIssuedCouponQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/issued-coupon-quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssuedCouponQuotasRequest);
            return new AsyncInvoker<ListIssuedCouponQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIssuedCouponQuotasResponse>);
        }
        
        /// <summary>
        /// 查询已发放的优惠券
        ///
        /// 合作伙伴可以查询已发放的优惠券列表。
        /// 
        /// 伙伴登录伙伴中心，进入“客户业务** **\\&gt; 代金券管理”，选择“已发放代金券”页签，即可查询已发放的代金券。
        /// 
        /// 伙伴登录伙伴中心，进入“客户业务 \\&gt; 现金券管理”，选择“已发放现金券”页签，即可查询已发放的现金券。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;-   只可查到失效时间在12个月内的代金/现金劵。
        /// &gt;-   在API只可以查询代售子客户已发放的代金/现金劵，在伙伴中心可以查询代售和顾问销售已发放的代金/现金劵，对比一致性时需要注意关联模式是否一致。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIssuedPartnerCouponsResponse> ListIssuedPartnerCouponsAsync(ListIssuedPartnerCouponsRequest listIssuedPartnerCouponsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/promotions/benefits/partner-coupons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssuedPartnerCouponsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListIssuedPartnerCouponsResponse>(response);
        }

        public AsyncInvoker<ListIssuedPartnerCouponsResponse> ListIssuedPartnerCouponsAsyncInvoker(ListIssuedPartnerCouponsRequest listIssuedPartnerCouponsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/promotions/benefits/partner-coupons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIssuedPartnerCouponsRequest);
            return new AsyncInvoker<ListIssuedPartnerCouponsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIssuedPartnerCouponsResponse>);
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
        /// 查询企业子账号可回收优惠券列表
        ///
        /// 企业主账号在自建平台查询企业子账号的可回收优惠券。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;-   仅支持华为发放的测试类、商务类、活动类代金券。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMultiAccountRetrieveCouponsResponse> ListMultiAccountRetrieveCouponsAsync(ListMultiAccountRetrieveCouponsRequest listMultiAccountRetrieveCouponsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/retrieve-coupons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMultiAccountRetrieveCouponsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMultiAccountRetrieveCouponsResponse>(response);
        }

        public AsyncInvoker<ListMultiAccountRetrieveCouponsResponse> ListMultiAccountRetrieveCouponsAsyncInvoker(ListMultiAccountRetrieveCouponsRequest listMultiAccountRetrieveCouponsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/retrieve-coupons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMultiAccountRetrieveCouponsRequest);
            return new AsyncInvoker<ListMultiAccountRetrieveCouponsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMultiAccountRetrieveCouponsResponse>);
        }
        
        /// <summary>
        /// 查询企业主账号可拨款优惠券列表
        ///
        /// 企业主账号在自建平台查询自己的可拨款优惠券列表。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;-   仅支持华为发放的测试类、商务类、活动类代金券。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMultiAccountTransferCouponsResponse> ListMultiAccountTransferCouponsAsync(ListMultiAccountTransferCouponsRequest listMultiAccountTransferCouponsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/transfer-coupons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMultiAccountTransferCouponsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMultiAccountTransferCouponsResponse>(response);
        }

        public AsyncInvoker<ListMultiAccountTransferCouponsResponse> ListMultiAccountTransferCouponsAsyncInvoker(ListMultiAccountTransferCouponsRequest listMultiAccountTransferCouponsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/transfer-coupons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMultiAccountTransferCouponsRequest);
            return new AsyncInvoker<ListMultiAccountTransferCouponsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMultiAccountTransferCouponsResponse>);
        }
        
        /// <summary>
        /// 查询按需产品价格
        ///
        /// 伙伴在销售平台按照条件查询按需产品的价格。
        /// 
        /// 如果购买该产品的租户享受折扣，可以在查询结果中返回折扣金额以及扣除折扣后的最后成交价。
        /// 
        /// 如果该租户享受多种折扣，系统会优先返回客户享受的商务折扣的折扣金额和最终成交价。
        /// 
        /// &gt;![](public_sys-resources/icon-caution.gif) **注意：** 
        /// &gt;华为云根据云服务类型、资源类型、云服务区和资源规格四个条件来查询产品，查询时请确认这4个查询条件均输入正确，否则该接口会返回无法找到产品的错误。
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
        /// 查询订单可用优惠券
        ///
        /// 客户在伙伴销售平台支付待支付订单时，查询可使用的优惠券列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOrderCouponsByOrderIdResponse> ListOrderCouponsByOrderIdAsync(ListOrderCouponsByOrderIdRequest listOrderCouponsByOrderIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/customer-orders/order-coupons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrderCouponsByOrderIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOrderCouponsByOrderIdResponse>(response);
        }

        public AsyncInvoker<ListOrderCouponsByOrderIdResponse> ListOrderCouponsByOrderIdAsyncInvoker(ListOrderCouponsByOrderIdRequest listOrderCouponsByOrderIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/orders/customer-orders/order-coupons", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOrderCouponsByOrderIdRequest);
            return new AsyncInvoker<ListOrderCouponsByOrderIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOrderCouponsByOrderIdResponse>);
        }
        
        /// <summary>
        /// 查询订单可用折扣
        ///
        /// 客户在伙伴销售平台支付待支付订单时，查询可使用的折扣信息。
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
        /// 查询收支明细
        ///
        /// 伙伴在伙伴销售平台上查询自身的收支明细情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPartnerAccountChangeRecordsResponse> ListPartnerAccountChangeRecordsAsync(ListPartnerAccountChangeRecordsRequest listPartnerAccountChangeRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/partner-accounts/account-change-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPartnerAccountChangeRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPartnerAccountChangeRecordsResponse>(response);
        }

        public AsyncInvoker<ListPartnerAccountChangeRecordsResponse> ListPartnerAccountChangeRecordsAsyncInvoker(ListPartnerAccountChangeRecordsRequest listPartnerAccountChangeRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/partner-accounts/account-change-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPartnerAccountChangeRecordsRequest);
            return new AsyncInvoker<ListPartnerAccountChangeRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPartnerAccountChangeRecordsResponse>);
        }
        
        /// <summary>
        /// 查询调账记录
        ///
        /// 伙伴在伙伴销售平台查询向客户及关联的云经销商（二级经销商）拨款或回收的调账记录。
        /// 
        /// 伙伴登录伙伴中心，在“拨款”或“回收”页面，单击“调账记录”，可以查看一级经销商为二级经销商调账的记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPartnerAdjustRecordsResponse> ListPartnerAdjustRecordsAsync(ListPartnerAdjustRecordsRequest listPartnerAdjustRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/accounts/partner-accounts/adjust-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPartnerAdjustRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPartnerAdjustRecordsResponse>(response);
        }

        public AsyncInvoker<ListPartnerAdjustRecordsResponse> ListPartnerAdjustRecordsAsyncInvoker(ListPartnerAdjustRecordsRequest listPartnerAdjustRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/accounts/partner-accounts/adjust-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPartnerAdjustRecordsRequest);
            return new AsyncInvoker<ListPartnerAdjustRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPartnerAdjustRecordsResponse>);
        }
        
        /// <summary>
        /// 查询云经销商账户余额
        ///
        /// 华为云总经销商（一级经销商）可以查询关联的云经销商（二级经销商）的账户余额；云经销商伙伴可以查询自己的账户余额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPartnerBalancesResponse> ListPartnerBalancesAsync(ListPartnerBalancesRequest listPartnerBalancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/partner-accounts/balances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPartnerBalancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPartnerBalancesResponse>(response);
        }

        public AsyncInvoker<ListPartnerBalancesResponse> ListPartnerBalancesAsyncInvoker(ListPartnerBalancesRequest listPartnerBalancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/partner-accounts/balances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPartnerBalancesRequest);
            return new AsyncInvoker<ListPartnerBalancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPartnerBalancesResponse>);
        }
        
        /// <summary>
        /// 查询优惠券的发放回收记录
        ///
        /// 合作伙伴可查看给客户发放和回收优惠券的操作记录。
        /// 
        /// 合作伙伴登录伙伴中心查看、导出代金券操作日志请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/zh-cn_topic_0072435103.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPartnerCouponsRecordResponse> ListPartnerCouponsRecordAsync(ListPartnerCouponsRecordRequest listPartnerCouponsRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/promotions/benefits/partner-coupons/records/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPartnerCouponsRecordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPartnerCouponsRecordResponse>(response);
        }

        public AsyncInvoker<ListPartnerCouponsRecordResponse> ListPartnerCouponsRecordAsyncInvoker(ListPartnerCouponsRecordRequest listPartnerCouponsRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/promotions/benefits/partner-coupons/records/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPartnerCouponsRecordRequest);
            return new AsyncInvoker<ListPartnerCouponsRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPartnerCouponsRecordResponse>);
        }
        
        /// <summary>
        /// 查询客户包年/包月资源列表
        ///
        /// 客户在伙伴销售平台查询某个或所有的包年/包月资源。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;成功调用本接口后，如果您需要对已生效状态的资源进行续订，您可以调用“[查询包年/包月产品价格](https://support.huaweicloud.com/api-bpconsole/bcloud_01002.html)”接口对查询到的包年/包月资源进行续订询价，然后再调用“[续订包年/包月资源](https://support.huaweicloud.com/api-bpconsole/api_order_00018.html)”接口进行续订。
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
        /// 查询省份信息
        ///
        /// 伙伴在伙伴销售平台上查询省份信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProvincesResponse> ListProvincesAsync(ListProvincesRequest listProvincesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/systems/configs/provinces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvincesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProvincesResponse>(response);
        }

        public AsyncInvoker<ListProvincesResponse> ListProvincesAsyncInvoker(ListProvincesRequest listProvincesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/systems/configs/provinces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvincesRequest);
            return new AsyncInvoker<ListProvincesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProvincesResponse>);
        }
        
        /// <summary>
        /// 查询优惠券额度
        ///
        /// 合作伙伴可以查看所拥有的优惠劵额度。
        /// 
        /// 伙伴登录合作伙伴中心查看所拥有的代金券额度请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/zh-cn_topic_0072435100.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQuotaCouponsResponse> ListQuotaCouponsAsync(ListQuotaCouponsRequest listQuotaCouponsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/coupon-quotas/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaCouponsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListQuotaCouponsResponse>(response);
        }

        public AsyncInvoker<ListQuotaCouponsResponse> ListQuotaCouponsAsyncInvoker(ListQuotaCouponsRequest listQuotaCouponsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/coupon-quotas/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaCouponsRequest);
            return new AsyncInvoker<ListQuotaCouponsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListQuotaCouponsResponse>);
        }
        
        /// <summary>
        /// 查询包年/包月产品价格
        ///
        /// 伙伴在销售平台按照条件查询包年/包月产品开通时候的价格。
        /// 
        /// 如果购买该产品的客户享受折扣，可以在查询结果中返回折扣金额以及扣除折扣后的最后成交价。
        /// 
        /// 如果该客户享受多种折扣，系统会返回每种折扣的批价结果。如果客户在下单的时候选择自动支付，则系统会优先应用商务折扣的批价结果。
        /// 
        /// &gt;![](public_sys-resources/icon-caution.gif) **注意：** 
        /// &gt;华为云根据云服务类型、资源类型、云服务区和资源规格四个条件来查询产品，查询时请确认这4个查询条件均输入正确，否则该接口会返回无法找到产品的错误。
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
        /// 查询95计费资源用量明细
        ///
        /// 客户在自建平台查询自己的资源使用量明细。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;当前仅支持查询CDN、OBS、IEC和VPC四种云服务类型的资源用量明细，仅针对95计费场景。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceUsageResponse> ListResourceUsageAsync(ListResourceUsageRequest listResourceUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/customer-bills/resources/usage/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceUsageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceUsageResponse>(response);
        }

        public AsyncInvoker<ListResourceUsageResponse> ListResourceUsageAsyncInvoker(ListResourceUsageRequest listResourceUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/customer-bills/resources/usage/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceUsageRequest);
            return new AsyncInvoker<ListResourceUsageResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceUsageResponse>);
        }
        
        /// <summary>
        /// 查询95计费资源用量汇总
        ///
        /// 客户在自建平台查询自己的资源使用量汇总。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;-   当前仅支持查询CDN、OBS、IEC和VPC四种云服务类型的资源用量汇总，仅针对95计费场景。
        /// &gt;-   使用量汇总列表只包含月汇总金额和资源ID，若要查询具体某个资源的用量明细，请调用[查询资源用量明细](https://support.huaweicloud.com/api-oce/zh-cn_topic_0000001190606757.html)接口获取。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceUsageSummaryResponse> ListResourceUsageSummaryAsync(ListResourceUsageSummaryRequest listResourceUsageSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/customer-bills/resources/usage/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceUsageSummaryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceUsageSummaryResponse>(response);
        }

        public AsyncInvoker<ListResourceUsageSummaryResponse> ListResourceUsageSummaryAsyncInvoker(ListResourceUsageSummaryRequest listResourceUsageSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/customer-bills/resources/usage/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceUsageSummaryRequest);
            return new AsyncInvoker<ListResourceUsageSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceUsageSummaryResponse>);
        }
        
        /// <summary>
        /// 根据云服务类型查询资源列表
        ///
        /// 伙伴在伙伴销售平台根据云服务类型查询关联的资源类型编码和名称，用于查询按需产品的价格或包年/包月产品的价格。
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
        /// 查询储值卡列表
        ///
        /// 客户可以查询已购买的储值卡列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStoredValueCardsResponse> ListStoredValueCardsAsync(ListStoredValueCardsRequest listStoredValueCardsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/promotions/benefits/stored-value-cards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoredValueCardsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStoredValueCardsResponse>(response);
        }

        public AsyncInvoker<ListStoredValueCardsResponse> ListStoredValueCardsAsyncInvoker(ListStoredValueCardsRequest listStoredValueCardsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/promotions/benefits/stored-value-cards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoredValueCardsRequest);
            return new AsyncInvoker<ListStoredValueCardsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStoredValueCardsResponse>);
        }
        
        /// <summary>
        /// 查询伙伴子客户消费记录
        ///
        /// 伙伴在伙伴销售平台可实时查询子客户的消费记录，了解客户的资源消耗情况。
        /// 
        /// 伙伴在伙伴中心查询客户消费明细请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/zh-cn_topic_0072435155.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;-   消费记录支持查询18个月内的记录。
        /// &gt;-   如果是客户经理主管来查询，只支持按照单个客户经理查询，必须输入客户经理ID。
        /// &gt;-   目前支持伙伴查询所有子客户（包含代售类和顾问销售类）的消费记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubCustomerBillDetailResponse> ListSubCustomerBillDetailAsync(ListSubCustomerBillDetailRequest listSubCustomerBillDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/subcustomer-bills/res-fee-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubCustomerBillDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSubCustomerBillDetailResponse>(response);
        }

        public AsyncInvoker<ListSubCustomerBillDetailResponse> ListSubCustomerBillDetailAsyncInvoker(ListSubCustomerBillDetailRequest listSubCustomerBillDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/subcustomer-bills/res-fee-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubCustomerBillDetailRequest);
            return new AsyncInvoker<ListSubCustomerBillDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubCustomerBillDetailResponse>);
        }
        
        /// <summary>
        /// 查询优惠券列表
        ///
        /// 伙伴可以查询自身的优惠券信息。
        /// 
        /// 伙伴登录伙伴中心查询已发放代金券列表请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/zh-cn_topic_0072435101.html)，查看已下发代金券的内容。
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
        /// 查询客户新客标签
        ///
        /// 伙伴通过该接口可以查询客户的新客标签。
        /// 
        /// &gt;![](public_sys-resources/icon-caution.gif) **注意：** 
        /// &gt;-   新客标签失效后，new\\_customer\\_tag会变成N，且有效期过期。
        /// &gt;-   客户如果没有实名认证，则新客标签为空。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubCustomerNewTagResponse> ListSubCustomerNewTagAsync(ListSubCustomerNewTagRequest listSubCustomerNewTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/new-customers-tags/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubCustomerNewTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListSubCustomerNewTagResponse>(response);
        }

        public AsyncInvoker<ListSubCustomerNewTagResponse> ListSubCustomerNewTagAsyncInvoker(ListSubCustomerNewTagRequest listSubCustomerNewTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/sub-customers/new-customers-tags/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubCustomerNewTagRequest);
            return new AsyncInvoker<ListSubCustomerNewTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSubCustomerNewTagResponse>);
        }
        
        /// <summary>
        /// 查询客户列表
        ///
        /// 伙伴可以查询合作伙伴的客户信息列表。
        /// 
        /// 伙伴登录合作伙伴中心查询客户信息列表请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/zh-cn_topic_0072435115.html)。
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
        /// 查询客户月度消费账单
        ///
        /// 合作伙伴可查询客户的消费汇总账单，消费按月汇总。
        /// 
        /// 伙伴在伙伴中心查询客户月度消费账单请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/zh-cn_topic_0072435154.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;消费汇总数据仅包含前一天24点前的数据。每天刷新一次，更新前一天的数据。
        /// &gt;该接口用于合作伙伴查询其代售类客户在华为的消费情况，如果输入某个客户ID，则是查询单个客户的，否则是查询该伙伴下所有使用伙伴拨款消费的客户的消费记录（包括退订记录）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubcustomerMonthlyBillsResponse> ListSubcustomerMonthlyBillsAsync(ListSubcustomerMonthlyBillsRequest listSubcustomerMonthlyBillsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/partner-bills/subcustomer-bills/monthly-sum", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubcustomerMonthlyBillsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSubcustomerMonthlyBillsResponse>(response);
        }

        public AsyncInvoker<ListSubcustomerMonthlyBillsResponse> ListSubcustomerMonthlyBillsAsyncInvoker(ListSubcustomerMonthlyBillsRequest listSubcustomerMonthlyBillsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/bills/partner-bills/subcustomer-bills/monthly-sum", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubcustomerMonthlyBillsRequest);
            return new AsyncInvoker<ListSubcustomerMonthlyBillsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubcustomerMonthlyBillsResponse>);
        }
        
        /// <summary>
        /// 查询使用量类型列表
        ///
        /// 伙伴在伙伴销售平台查询资源的使用量类型列表。
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
        /// 客户可以对待支付状态的包年/包月产品订单进行支付。
        /// 
        /// 客户登录费用中心支付包年包月产品的待支付订单请单击[这里](https://support.huaweicloud.com/usermanual-billing/zh-cn_topic_0031512547.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;-   API支持月度结算和余额支付两种支付方式，月度结算优先。
        /// &gt;-   余额支付包括现金账户和信用账户两种支付方式，如果两个账户都有余额，则优先现金账户支付。
        /// &gt;-   同时使用订单折扣和优惠券的互斥规则如下：
        /// &gt;    -   如果优惠券的限制属性上存在simultaneousUseWithEmpowerDiscount字段，并且值为0，则折扣和优惠券不能同时使用。
        /// &gt;    -   如果优惠券的限制属性上存在minConsumeDiscount字段，当折扣ID包含的所有订单项上的折扣率discount\\_ratio都小于minConsumeDiscount字段时，则折扣ID和优惠券不能同时使用。
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
        /// 回收云经销商的代金券额度
        ///
        /// 华为云总经销商（一级经销商）可以回收已发放给云经销商（二级经销商）的代金券额度。
        /// 
        /// 一级经销商在伙伴中心回收已发放给二级经销商的代金券额度请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/dp_120206.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ReclaimCouponQuotasResponse> ReclaimCouponQuotasAsync(ReclaimCouponQuotasRequest reclaimCouponQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/coupon-quotas/indirect-partner-reclaim", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reclaimCouponQuotasRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ReclaimCouponQuotasResponse>(response);
        }

        public AsyncInvoker<ReclaimCouponQuotasResponse> ReclaimCouponQuotasAsyncInvoker(ReclaimCouponQuotasRequest reclaimCouponQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/coupon-quotas/indirect-partner-reclaim", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reclaimCouponQuotasRequest);
            return new AsyncInvoker<ReclaimCouponQuotasResponse>(this, "POST", request, JsonUtils.DeSerialize<ReclaimCouponQuotasResponse>);
        }
        
        /// <summary>
        /// 企业主账号从企业子账号回收优惠券
        ///
        /// 企业主账号在自建平台回收给企业子账号的拨款优惠券。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;-   仅支持华为发放的测试类、商务类、活动类代金券。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ReclaimEnterpriseMultiAccountCouponResponse> ReclaimEnterpriseMultiAccountCouponAsync(ReclaimEnterpriseMultiAccountCouponRequest reclaimEnterpriseMultiAccountCouponRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/retrieve-coupon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reclaimEnterpriseMultiAccountCouponRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ReclaimEnterpriseMultiAccountCouponResponse>(response);
        }

        public AsyncInvoker<ReclaimEnterpriseMultiAccountCouponResponse> ReclaimEnterpriseMultiAccountCouponAsyncInvoker(ReclaimEnterpriseMultiAccountCouponRequest reclaimEnterpriseMultiAccountCouponRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/retrieve-coupon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reclaimEnterpriseMultiAccountCouponRequest);
            return new AsyncInvoker<ReclaimEnterpriseMultiAccountCouponResponse>(this, "POST", request, JsonUtils.DeSerialize<ReclaimEnterpriseMultiAccountCouponResponse>);
        }
        
        /// <summary>
        /// 回收云经销商账户拨款
        ///
        /// 华为云总经销商（一级经销商）可以回收云经销商（二级经销商）的账户余额。
        /// 
        /// 一级经销商在伙伴中心回收二级经销商账户拨款请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/dp_120205.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ReclaimIndirectPartnerAccountResponse> ReclaimIndirectPartnerAccountAsync(ReclaimIndirectPartnerAccountRequest reclaimIndirectPartnerAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/partner-accounts/indirect-partner-reclaim", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reclaimIndirectPartnerAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ReclaimIndirectPartnerAccountResponse>(response);
        }

        public AsyncInvoker<ReclaimIndirectPartnerAccountResponse> ReclaimIndirectPartnerAccountAsyncInvoker(ReclaimIndirectPartnerAccountRequest reclaimIndirectPartnerAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/partner-accounts/indirect-partner-reclaim", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reclaimIndirectPartnerAccountRequest);
            return new AsyncInvoker<ReclaimIndirectPartnerAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<ReclaimIndirectPartnerAccountResponse>);
        }
        
        /// <summary>
        /// 回收优惠券
        ///
        /// 对于合作伙伴已经下发给客户的优惠券，如遇发错或其他特殊情况，合作伙伴有回收的权利。优惠券回收后，客户将不再拥有该优惠券。
        /// 
        /// 伙伴登录合作伙伴中心回收为客户发放的代金券请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/espp_050503.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;只能回收代售类子客户的优惠券。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ReclaimPartnerCouponsResponse> ReclaimPartnerCouponsAsync(ReclaimPartnerCouponsRequest reclaimPartnerCouponsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/promotions/benefits/partner-coupons/reclaim", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reclaimPartnerCouponsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ReclaimPartnerCouponsResponse>(response);
        }

        public AsyncInvoker<ReclaimPartnerCouponsResponse> ReclaimPartnerCouponsAsyncInvoker(ReclaimPartnerCouponsRequest reclaimPartnerCouponsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/promotions/benefits/partner-coupons/reclaim", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reclaimPartnerCouponsRequest);
            return new AsyncInvoker<ReclaimPartnerCouponsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ReclaimPartnerCouponsResponse>);
        }
        
        /// <summary>
        /// 企业主账号从企业子账号回收拨款
        ///
        /// 企业主账号在自建平台回收给企业子账号的拨款。
        /// 
        /// 如果回收的是企业子账户的信用账户，可以回收所有额度；如果回收金额大于子账户信用余额的时候，可能会导致子账户欠费，请慎重选择。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ReclaimSubEnterpriseAmountResponse> ReclaimSubEnterpriseAmountAsync(ReclaimSubEnterpriseAmountRequest reclaimSubEnterpriseAmountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/retrieve-amount", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reclaimSubEnterpriseAmountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ReclaimSubEnterpriseAmountResponse>(response);
        }

        public AsyncInvoker<ReclaimSubEnterpriseAmountResponse> ReclaimSubEnterpriseAmountAsyncInvoker(ReclaimSubEnterpriseAmountRequest reclaimSubEnterpriseAmountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/retrieve-amount", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reclaimSubEnterpriseAmountRequest);
            return new AsyncInvoker<ReclaimSubEnterpriseAmountResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ReclaimSubEnterpriseAmountResponse>);
        }
        
        /// <summary>
        /// 回收客户账户余额
        ///
        /// 当客户不再使用华为云产品时，合作伙伴可以回收代售类客户账户余额。
        /// 
        /// 伙伴登录伙伴中心回收代售类客户账户余额请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/zh-cn_topic_0072435147.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ReclaimToPartnerAccountResponse> ReclaimToPartnerAccountAsync(ReclaimToPartnerAccountRequest reclaimToPartnerAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/partner-accounts/reclaim", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reclaimToPartnerAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ReclaimToPartnerAccountResponse>(response);
        }

        public AsyncInvoker<ReclaimToPartnerAccountResponse> ReclaimToPartnerAccountAsyncInvoker(ReclaimToPartnerAccountRequest reclaimToPartnerAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/partner-accounts/reclaim", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reclaimToPartnerAccountRequest);
            return new AsyncInvoker<ReclaimToPartnerAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<ReclaimToPartnerAccountResponse>);
        }
        
        /// <summary>
        /// 续订包年/包月资源
        ///
        /// 客户的包年/包月资源即将到期时，可进行包年/包月资源的续订。
        /// 
        /// 客户在费用中心执行续订操作请参见[这里](https://support.huaweicloud.com/usermanual-billing/renewals_topic_10000003.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;-   调用接口后，如果某个主资源有对应的从资源，系统会将主资源和从资源一起续订，主资源的从资源信息可以通过调用[查询客户包年/包月资源列表](https://support.huaweicloud.com/api-oce/api_order_00021.html)接口获取。
        /// &gt;-   注意：如ECS主机挂载新购的云硬盘，但此硬盘不是该ECS主资源的从资源，主从资源信息必须以调用[查询客户包年/包月资源列表](https://support.huaweicloud.com/api-oce/api_order_00021.html)接口获取的信息为准。
        /// &gt;-   本接口支持自动支付，支付时使用折扣或优惠券的说明，请参见[支付使用折扣或优惠券说明](https://support.huaweicloud.com/api-oce/appendix_00001.html)。
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
        /// 发送短信验证码
        ///
        /// 企业主账号在自建平台发送短信验证码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SendSmsVerificationCodeResponse> SendSmsVerificationCodeAsync(SendSmsVerificationCodeRequest sendSmsVerificationCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/sm-verification-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendSmsVerificationCodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SendSmsVerificationCodeResponse>(response);
        }

        public AsyncInvoker<SendSmsVerificationCodeResponse> SendSmsVerificationCodeAsyncInvoker(SendSmsVerificationCodeRequest sendSmsVerificationCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/sm-verification-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendSmsVerificationCodeRequest);
            return new AsyncInvoker<SendSmsVerificationCodeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SendSmsVerificationCodeResponse>);
        }
        
        /// <summary>
        /// 发送验证码
        ///
        /// 客户注册时，如果填写了手机号，可以向对应的手机发送注册验证码，校验信息的正确性。使用个人银行卡方式进行实名认证时，通过该接口向指定的手机发送验证码。
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
        /// 客户可以查询自身的账户余额。
        /// 
        /// 客户可以登录费用中心进入“[总览](https://account.huaweicloud.com/usercenter/#/userindex/allview)”页面，在“可用额度”区域可以查询自身的账户余额。
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
        /// 查询汇总账单
        ///
        /// 客户在自建平台查询自身的消费汇总账单，此账单按月汇总消费数据。
        /// 
        /// 客户登录费用中心查询自身的消费汇总账单请参见[这里](https://support.huaweicloud.com/usermanual-billing/bills-topic_80000101.html)的“查看汇总”。
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
        /// 客户可以在伙伴销售平台查看订单详情。
        /// 
        /// 客户登录费用中心查看订单详情请单击[这里](https://support.huaweicloud.com/usermanual-billing/order_topic_9000001.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;如果想查询某条订单下的资源信息，请调用“[查询客户包年/包月资源列表](https://support.huaweicloud.com/api-oce/api_order_00021.html)”接口在请求参数输入订单号进行查询。
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
        /// 查询企业主账号可拨款余额
        ///
        /// 企业主账号在自建平台查询自己的可拨款余额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMultiAccountTransferAmountResponse> ShowMultiAccountTransferAmountAsync(ShowMultiAccountTransferAmountRequest showMultiAccountTransferAmountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/transfer-amount", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMultiAccountTransferAmountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMultiAccountTransferAmountResponse>(response);
        }

        public AsyncInvoker<ShowMultiAccountTransferAmountResponse> ShowMultiAccountTransferAmountAsyncInvoker(ShowMultiAccountTransferAmountRequest showMultiAccountTransferAmountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/transfer-amount", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMultiAccountTransferAmountRequest);
            return new AsyncInvoker<ShowMultiAccountTransferAmountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMultiAccountTransferAmountResponse>);
        }
        
        /// <summary>
        /// 查询实名认证审核结果
        ///
        /// 如果实名认证申请或实名认证变更申请的响应中，显示需要人工审核，使用该接口查询审核结果。
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
        /// 客户在伙伴销售平台查询某次退订订单或者降配订单的退款金额来自哪些资源和对应订单。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;-   可以在调用完“[退订包年/包月资源](https://support.huaweicloud.com/api-oce/api_order_00019.html)”接口生成退订订单ID后，调用该接口查询退订订单对应的金额所属资源和订单。例如，调用“[退订包年/包月资源](https://support.huaweicloud.com/api-oce/api_order_00019.html)”接口退订资源及其已续费周期后，您可以调用本小节的接口查询到退订金额归属的原开通订单ID和原续费订单ID。
        /// &gt;-   2018年5月份之后退订的订单才能查询到归属的原订单ID。
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
        /// 向云经销商发放代金券额度
        ///
        /// 华为云总经销商（一级经销商）可以向云经销商（二级经销商）发放代金券额度。
        /// 
        /// 一级经销商在伙伴中心向二级经销商发放代金券额度请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/dp_120206.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCouponQuotasResponse> UpdateCouponQuotasAsync(UpdateCouponQuotasRequest updateCouponQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/coupon-quotas/indirect-partner-adjust", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCouponQuotasRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateCouponQuotasResponse>(response);
        }

        public AsyncInvoker<UpdateCouponQuotasResponse> UpdateCouponQuotasAsyncInvoker(UpdateCouponQuotasRequest updateCouponQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/partners/coupon-quotas/indirect-partner-adjust", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCouponQuotasRequest);
            return new AsyncInvoker<UpdateCouponQuotasResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateCouponQuotasResponse>);
        }
        
        /// <summary>
        /// 向客户账户拨款
        ///
        /// 合作伙伴可以为代售类客户账户拨款。
        /// 
        /// 伙伴登录伙伴中心为代售类客户账户拨款请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/zh-cn_topic_0072435147.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCustomerAccountAmountResponse> UpdateCustomerAccountAmountAsync(UpdateCustomerAccountAmountRequest updateCustomerAccountAmountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/partner-accounts/adjust-amount", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCustomerAccountAmountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateCustomerAccountAmountResponse>(response);
        }

        public AsyncInvoker<UpdateCustomerAccountAmountResponse> UpdateCustomerAccountAmountAsyncInvoker(UpdateCustomerAccountAmountRequest updateCustomerAccountAmountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/partner-accounts/adjust-amount", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCustomerAccountAmountRequest);
            return new AsyncInvoker<UpdateCustomerAccountAmountResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateCustomerAccountAmountResponse>);
        }
        
        /// <summary>
        /// 向云经销商账户拨款
        ///
        /// 华为云总经销商（一级经销商）可以向云经销商（二级经销商）账户拨款。
        /// 
        /// 一级经销商在伙伴中心向二级经销商拨款请参见[这里](https://support.huaweicloud.com/usermanual-bpconsole/dp_120205.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateIndirectPartnerAccountResponse> UpdateIndirectPartnerAccountAsync(UpdateIndirectPartnerAccountRequest updateIndirectPartnerAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/partner-accounts/indirect-partner-adjust", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIndirectPartnerAccountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateIndirectPartnerAccountResponse>(response);
        }

        public AsyncInvoker<UpdateIndirectPartnerAccountResponse> UpdateIndirectPartnerAccountAsyncInvoker(UpdateIndirectPartnerAccountRequest updateIndirectPartnerAccountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/accounts/partner-accounts/indirect-partner-adjust", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIndirectPartnerAccountRequest);
            return new AsyncInvoker<UpdateIndirectPartnerAccountResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateIndirectPartnerAccountResponse>);
        }
        
        /// <summary>
        /// 设置或取消包年/包月资源到期转按需
        ///
        /// 客户可以设置包年/包月资源到期后转为按需资源计费。包年/包月计费模式到期后，按需的计费模式即生效。
        /// 
        /// 客户在费用中心设置包年包月资源到期转按需请参见[这里](https://support.huaweicloud.com/usermanual-billing/renewals_topic_50000003.html)。
        /// 
        /// &gt;![](public_sys-resources/icon-note.gif) **说明：** 
        /// &gt;-   客户需要成功支付包年/包月资源订单后，才能设置资源的到期转按需。
        /// &gt;-   目前解决方案组合产品、按需套餐包不支持到期转按需。
        /// &gt;-   在调用本接口前，您可以调用“[查询客户包年/包月资源列表](https://support.huaweicloud.com/api-oce/api_order_00021.html)”接口获取资源ID、资源过期时间以及资源过期后的扣费策略等信息。
        /// &gt;-   设置包年/包月资源到期转按需后，包年/包月资源到期后将自动变成按需计费。
        /// &gt;-   取消包年/包月资源到期转按需的前提是已经调用“[设置或取消包年/包月资源到期转按需](https://support.huaweicloud.com/api-oce/api_order_00024.html)”接口设置包年/包月资源的到期转按需或在调用“[续订包年/包月资源](https://support.huaweicloud.com/api-oce/api_order_00018.html)”接口时设置到期策略为到期转按需。
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
        /// 企业主账号向企业子账号拨款
        ///
        /// 企业主账号在自建平台向企业子账号拨款。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSubEnterpriseAmountResponse> UpdateSubEnterpriseAmountAsync(UpdateSubEnterpriseAmountRequest updateSubEnterpriseAmountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/transfer-amount", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubEnterpriseAmountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateSubEnterpriseAmountResponse>(response);
        }

        public AsyncInvoker<UpdateSubEnterpriseAmountResponse> UpdateSubEnterpriseAmountAsyncInvoker(UpdateSubEnterpriseAmountRequest updateSubEnterpriseAmountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/enterprises/multi-accounts/transfer-amount", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubEnterpriseAmountRequest);
            return new AsyncInvoker<UpdateSubEnterpriseAmountResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateSubEnterpriseAmountResponse>);
        }
        
    }
}