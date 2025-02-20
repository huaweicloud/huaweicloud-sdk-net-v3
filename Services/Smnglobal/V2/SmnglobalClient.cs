using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Smnglobal.V2.Model;

namespace HuaweiCloud.SDK.Smnglobal.V2
{
    public partial class SmnglobalClient : Client
    {
        public static ClientBuilder<SmnglobalClient> NewBuilder()
        {
            return new ClientBuilder<SmnglobalClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 添加订阅用户
        ///
        /// 添加订阅用户。如果订阅用户的状态为未确认，则会向订阅用户发送一条确认订阅消息。订阅用户点击订阅链接确认订阅后，则订阅用户的状态变更为已确认，同时会向订阅用户发送一条取消订阅消息，便于订阅用户随时可以取消订阅。订阅用户点击取消订阅链接后，则订阅用户的状态变更为已取消，同时会向订阅用户发送一条重新订阅消息，便于订阅用户可以重新订阅。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSubscriptionUserResponse CreateSubscriptionUser(CreateSubscriptionUserRequest createSubscriptionUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/subscription-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubscriptionUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSubscriptionUserResponse>(response);
        }

        public SyncInvoker<CreateSubscriptionUserResponse> CreateSubscriptionUserInvoker(CreateSubscriptionUserRequest createSubscriptionUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/subscription-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubscriptionUserRequest);
            return new SyncInvoker<CreateSubscriptionUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSubscriptionUserResponse>);
        }
        
        /// <summary>
        /// 删除订阅用户
        ///
        /// 删除订阅用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSubscriptionUserResponse DeleteSubscriptionUser(DeleteSubscriptionUserRequest deleteSubscriptionUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteSubscriptionUserRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/subscription-users/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubscriptionUserRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSubscriptionUserResponse>(response);
        }

        public SyncInvoker<DeleteSubscriptionUserResponse> DeleteSubscriptionUserInvoker(DeleteSubscriptionUserRequest deleteSubscriptionUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteSubscriptionUserRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/subscription-users/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubscriptionUserRequest);
            return new SyncInvoker<DeleteSubscriptionUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSubscriptionUserResponse>);
        }
        
        /// <summary>
        /// 查询订阅用户列表
        ///
        /// 查询订阅用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubscriptionUserResponse ListSubscriptionUser(ListSubscriptionUserRequest listSubscriptionUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/subscription-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionUserRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSubscriptionUserResponse>(response);
        }

        public SyncInvoker<ListSubscriptionUserResponse> ListSubscriptionUserInvoker(ListSubscriptionUserRequest listSubscriptionUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/subscription-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionUserRequest);
            return new SyncInvoker<ListSubscriptionUserResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubscriptionUserResponse>);
        }
        
        /// <summary>
        /// 更新订阅用户
        ///
        /// 更新订阅用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSubscriptionUserResponse UpdateSubscriptionUser(UpdateSubscriptionUserRequest updateSubscriptionUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateSubscriptionUserRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/subscription-users/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSubscriptionUserRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSubscriptionUserResponse>(response);
        }

        public SyncInvoker<UpdateSubscriptionUserResponse> UpdateSubscriptionUserInvoker(UpdateSubscriptionUserRequest updateSubscriptionUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateSubscriptionUserRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/subscription-users/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSubscriptionUserRequest);
            return new SyncInvoker<UpdateSubscriptionUserResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSubscriptionUserResponse>);
        }
        
    }
}