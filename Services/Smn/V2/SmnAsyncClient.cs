using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Smn.V2.Model;

namespace HuaweiCloud.SDK.Smn.V2
{
    public partial class SmnAsyncClient : Client
    {
        public static ClientBuilder<SmnAsyncClient> NewBuilder()
        {
            return new ClientBuilder<SmnAsyncClient>();
        }

        
        /// <summary>
        /// 订阅
        ///
        /// 为指定Topic添加一个订阅者，如果订阅者的状态为未确认，则向订阅者发送一个确认的消息。待订阅者进行ConfirmSubscription确认后，该订阅者才能收到Topic发布的消息。单Topic默认可添加10000个订阅者，高并发场景下，可能会出现订阅者数量超过10000仍添加成功的情况，此为正常现象。接口是幂等的，如果添加已存在的订阅者，则返回成功，且status code为200，否则status code为201。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddSubscriptionResponse> AddSubscriptionAsync(AddSubscriptionRequest addSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addSubscriptionRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addSubscriptionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddSubscriptionResponse>(response);
        }

        public AsyncInvoker<AddSubscriptionResponse> AddSubscriptionAsyncInvoker(AddSubscriptionRequest addSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addSubscriptionRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addSubscriptionRequest);
            return new AsyncInvoker<AddSubscriptionResponse>(this, "POST", request, JsonUtils.DeSerialize<AddSubscriptionResponse>);
        }
        
        /// <summary>
        /// 导入订阅
        ///
        /// 为指定的Topic添加订阅者，订阅者信息来源为订阅用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddSubscriptionFromSubscriptionUserResponse> AddSubscriptionFromSubscriptionUserAsync(AddSubscriptionFromSubscriptionUserRequest addSubscriptionFromSubscriptionUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addSubscriptionFromSubscriptionUserRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions/from-subscription-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addSubscriptionFromSubscriptionUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddSubscriptionFromSubscriptionUserResponse>(response);
        }

        public AsyncInvoker<AddSubscriptionFromSubscriptionUserResponse> AddSubscriptionFromSubscriptionUserAsyncInvoker(AddSubscriptionFromSubscriptionUserRequest addSubscriptionFromSubscriptionUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addSubscriptionFromSubscriptionUserRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions/from-subscription-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addSubscriptionFromSubscriptionUserRequest);
            return new AsyncInvoker<AddSubscriptionFromSubscriptionUserResponse>(this, "POST", request, JsonUtils.DeSerialize<AddSubscriptionFromSubscriptionUserResponse>);
        }
        
        /// <summary>
        /// 批量添加删除资源标签
        ///
        /// 为指定实例批量添加或删除标签。一个资源上最多有10个标签。
        /// 此接口为幂等接口：创建时如果请求体中存在重复key则报错。
        /// 创建时，不允许重复key，如果数据库存在就覆盖。
        /// 删除时，如果删除的标签不存在，默认处理成功，删除时不对标签字符集范围做校验。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateOrDeleteResourceTagsResponse> BatchCreateOrDeleteResourceTagsAsync(BatchCreateOrDeleteResourceTagsRequest batchCreateOrDeleteResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateOrDeleteResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(batchCreateOrDeleteResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteResourceTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteResourceTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateOrDeleteResourceTagsResponse> BatchCreateOrDeleteResourceTagsAsyncInvoker(BatchCreateOrDeleteResourceTagsRequest batchCreateOrDeleteResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateOrDeleteResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(batchCreateOrDeleteResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteResourceTagsRequest);
            return new AsyncInvoker<BatchCreateOrDeleteResourceTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateOrDeleteResourceTagsResponse>);
        }
        
        /// <summary>
        /// 批量创建订阅过滤策略
        ///
        /// 创建订阅者的消息过滤策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateSubscriptionsFilterPolicesResponse> BatchCreateSubscriptionsFilterPolicesAsync(BatchCreateSubscriptionsFilterPolicesRequest batchCreateSubscriptionsFilterPolicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/filter_polices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSubscriptionsFilterPolicesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateSubscriptionsFilterPolicesResponse>(response);
        }

        public AsyncInvoker<BatchCreateSubscriptionsFilterPolicesResponse> BatchCreateSubscriptionsFilterPolicesAsyncInvoker(BatchCreateSubscriptionsFilterPolicesRequest batchCreateSubscriptionsFilterPolicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/filter_polices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSubscriptionsFilterPolicesRequest);
            return new AsyncInvoker<BatchCreateSubscriptionsFilterPolicesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateSubscriptionsFilterPolicesResponse>);
        }
        
        /// <summary>
        /// 批量删除订阅
        ///
        /// 批量删除订阅，每个订阅终端的删除结果在响应体中依次展示。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteSubscriptionsResponse> BatchDeleteSubscriptionsAsync(BatchDeleteSubscriptionsRequest batchDeleteSubscriptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSubscriptionsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteSubscriptionsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteSubscriptionsResponse> BatchDeleteSubscriptionsAsyncInvoker(BatchDeleteSubscriptionsRequest batchDeleteSubscriptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSubscriptionsRequest);
            return new AsyncInvoker<BatchDeleteSubscriptionsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteSubscriptionsResponse>);
        }
        
        /// <summary>
        /// 批量删除指定主题的订阅
        ///
        /// 批量删除指定主题的订阅，每个订阅终端的删除结果在响应体中依次展示。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteSubscriptionsByTopicResponse> BatchDeleteSubscriptionsByTopicAsync(BatchDeleteSubscriptionsByTopicRequest batchDeleteSubscriptionsByTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteSubscriptionsByTopicRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSubscriptionsByTopicRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteSubscriptionsByTopicResponse>(response);
        }

        public AsyncInvoker<BatchDeleteSubscriptionsByTopicResponse> BatchDeleteSubscriptionsByTopicAsyncInvoker(BatchDeleteSubscriptionsByTopicRequest batchDeleteSubscriptionsByTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteSubscriptionsByTopicRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSubscriptionsByTopicRequest);
            return new AsyncInvoker<BatchDeleteSubscriptionsByTopicResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteSubscriptionsByTopicResponse>);
        }
        
        /// <summary>
        /// 批量删除订阅过滤策略
        ///
        /// 删除订阅者的消息过滤策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteSubscriptionsFilterPolicesResponse> BatchDeleteSubscriptionsFilterPolicesAsync(BatchDeleteSubscriptionsFilterPolicesRequest batchDeleteSubscriptionsFilterPolicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/filter_polices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSubscriptionsFilterPolicesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteSubscriptionsFilterPolicesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteSubscriptionsFilterPolicesResponse> BatchDeleteSubscriptionsFilterPolicesAsyncInvoker(BatchDeleteSubscriptionsFilterPolicesRequest batchDeleteSubscriptionsFilterPolicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/filter_polices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSubscriptionsFilterPolicesRequest);
            return new AsyncInvoker<BatchDeleteSubscriptionsFilterPolicesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteSubscriptionsFilterPolicesResponse>);
        }
        
        /// <summary>
        /// 批量更新订阅过滤策略
        ///
        /// 更新订阅者的消息过滤策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateSubscriptionsFilterPolicesResponse> BatchUpdateSubscriptionsFilterPolicesAsync(BatchUpdateSubscriptionsFilterPolicesRequest batchUpdateSubscriptionsFilterPolicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/filter_polices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateSubscriptionsFilterPolicesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateSubscriptionsFilterPolicesResponse>(response);
        }

        public AsyncInvoker<BatchUpdateSubscriptionsFilterPolicesResponse> BatchUpdateSubscriptionsFilterPolicesAsyncInvoker(BatchUpdateSubscriptionsFilterPolicesRequest batchUpdateSubscriptionsFilterPolicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/filter_polices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateSubscriptionsFilterPolicesRequest);
            return new AsyncInvoker<BatchUpdateSubscriptionsFilterPolicesResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateSubscriptionsFilterPolicesResponse>);
        }
        
        /// <summary>
        /// 取消订阅
        ///
        /// 删除指定的订阅者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelSubscriptionResponse> CancelSubscriptionAsync(CancelSubscriptionRequest cancelSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelSubscriptionRequest.SubscriptionUrn, out var valueOfSubscriptionUrn)) urlParam.Add("subscription_urn", valueOfSubscriptionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/{subscription_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelSubscriptionRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<CancelSubscriptionResponse>(response);
        }

        public AsyncInvoker<CancelSubscriptionResponse> CancelSubscriptionAsyncInvoker(CancelSubscriptionRequest cancelSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelSubscriptionRequest.SubscriptionUrn, out var valueOfSubscriptionUrn)) urlParam.Add("subscription_urn", valueOfSubscriptionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/{subscription_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelSubscriptionRequest);
            return new AsyncInvoker<CancelSubscriptionResponse>(this, "DELETE", request, JsonUtils.DeSerialize<CancelSubscriptionResponse>);
        }
        
        /// <summary>
        /// 确认订阅
        ///
        /// 确认订阅主题消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ConfirmSubscriptionResponse> ConfirmSubscriptionAsync(ConfirmSubscriptionRequest confirmSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/rest/v2/notifications/subscription/confirm", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmSubscriptionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ConfirmSubscriptionResponse>(response);
        }

        public AsyncInvoker<ConfirmSubscriptionResponse> ConfirmSubscriptionAsyncInvoker(ConfirmSubscriptionRequest confirmSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/rest/v2/notifications/subscription/confirm", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmSubscriptionRequest);
            return new AsyncInvoker<ConfirmSubscriptionResponse>(this, "GET", request, JsonUtils.DeSerialize<ConfirmSubscriptionResponse>);
        }
        
        /// <summary>
        /// 绑定云日志
        ///
        /// 为指定Topic绑定一个云日志，用于记录主题消息发送状态等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLogtankResponse> CreateLogtankAsync(CreateLogtankRequest createLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createLogtankRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLogtankRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLogtankResponse>(response);
        }

        public AsyncInvoker<CreateLogtankResponse> CreateLogtankAsyncInvoker(CreateLogtankRequest createLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createLogtankRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLogtankRequest);
            return new AsyncInvoker<CreateLogtankResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLogtankResponse>);
        }
        
        /// <summary>
        /// 创建消息模板
        ///
        /// 创建一个模板，用户可以按照模板去发送消息，这样可以减少请求的数据量。
        /// 单用户默认可创建100个消息模板，高并发场景下，可能会出现消息模板数量超过100仍创建成功的情况，此为正常现象。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMessageTemplateResponse> CreateMessageTemplateAsync(CreateMessageTemplateRequest createMessageTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMessageTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMessageTemplateResponse>(response);
        }

        public AsyncInvoker<CreateMessageTemplateResponse> CreateMessageTemplateAsyncInvoker(CreateMessageTemplateRequest createMessageTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMessageTemplateRequest);
            return new AsyncInvoker<CreateMessageTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMessageTemplateResponse>);
        }
        
        /// <summary>
        /// 创建通知策略
        ///
        /// 创建通知策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNotifyPolicyResponse> CreateNotifyPolicyAsync(CreateNotifyPolicyRequest createNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNotifyPolicyRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotifyPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateNotifyPolicyResponse>(response);
        }

        public AsyncInvoker<CreateNotifyPolicyResponse> CreateNotifyPolicyAsyncInvoker(CreateNotifyPolicyRequest createNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNotifyPolicyRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotifyPolicyRequest);
            return new AsyncInvoker<CreateNotifyPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNotifyPolicyResponse>);
        }
        
        /// <summary>
        /// 添加资源标签
        ///
        /// 一个资源上最多有10个标签。此接口为幂等接口：创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateResourceTagResponse> CreateResourceTagAsync(CreateResourceTagRequest createResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createResourceTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResourceTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateResourceTagResponse>(response);
        }

        public AsyncInvoker<CreateResourceTagResponse> CreateResourceTagAsyncInvoker(CreateResourceTagRequest createResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createResourceTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResourceTagRequest);
            return new AsyncInvoker<CreateResourceTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateResourceTagResponse>);
        }
        
        /// <summary>
        /// 创建主题
        ///
        /// 创建Topic，单用户默认配额为3000。高并发场景下，可能会出现Topic数量超过3000仍创建成功的情况，此为正常现象。
        /// 接口是幂等的，接口调用返回成功时，若已存在同名的Topic，返回的status code为200，否则返回的status code为201
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTopicResponse> CreateTopicAsync(CreateTopicRequest createTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTopicRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTopicResponse>(response);
        }

        public AsyncInvoker<CreateTopicResponse> CreateTopicAsyncInvoker(CreateTopicRequest createTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTopicRequest);
            return new AsyncInvoker<CreateTopicResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTopicResponse>);
        }
        
        /// <summary>
        /// 解绑云日志
        ///
        /// 解绑指定Topic绑定的云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLogtankResponse> DeleteLogtankAsync(DeleteLogtankRequest deleteLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLogtankRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(deleteLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteLogtankResponse>(response);
        }

        public AsyncInvoker<DeleteLogtankResponse> DeleteLogtankAsyncInvoker(DeleteLogtankRequest deleteLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLogtankRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(deleteLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            return new AsyncInvoker<DeleteLogtankResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteLogtankResponse>);
        }
        
        /// <summary>
        /// 删除消息模板
        ///
        /// 删除消息模板。删除模板之前的消息请求都可以使用该模板发送，删除之后无法再使用该模板发送消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMessageTemplateResponse> DeleteMessageTemplateAsync(DeleteMessageTemplateRequest deleteMessageTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMessageTemplateRequest.MessageTemplateId, out var valueOfMessageTemplateId)) urlParam.Add("message_template_id", valueOfMessageTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMessageTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteMessageTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteMessageTemplateResponse> DeleteMessageTemplateAsyncInvoker(DeleteMessageTemplateRequest deleteMessageTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMessageTemplateRequest.MessageTemplateId, out var valueOfMessageTemplateId)) urlParam.Add("message_template_id", valueOfMessageTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMessageTemplateRequest);
            return new AsyncInvoker<DeleteMessageTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteMessageTemplateResponse>);
        }
        
        /// <summary>
        /// 删除通知策略
        ///
        /// 删除通知策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNotifyPolicyResponse> DeleteNotifyPolicyAsync(DeleteNotifyPolicyRequest deleteNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNotifyPolicyRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(deleteNotifyPolicyRequest.NotifyPolicyId, out var valueOfNotifyPolicyId)) urlParam.Add("notify_policy_id", valueOfNotifyPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy/{notify_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNotifyPolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteNotifyPolicyResponse>(response);
        }

        public AsyncInvoker<DeleteNotifyPolicyResponse> DeleteNotifyPolicyAsyncInvoker(DeleteNotifyPolicyRequest deleteNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNotifyPolicyRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(deleteNotifyPolicyRequest.NotifyPolicyId, out var valueOfNotifyPolicyId)) urlParam.Add("notify_policy_id", valueOfNotifyPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy/{notify_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNotifyPolicyRequest);
            return new AsyncInvoker<DeleteNotifyPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteNotifyPolicyResponse>);
        }
        
        /// <summary>
        /// 删除资源标签
        ///
        /// 幂等接口：删除时，不对标签做校验。删除的key不存在报404，key不能为空或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteResourceTagResponse> DeleteResourceTagAsync(DeleteResourceTagRequest deleteResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteResourceTagResponse>(response);
        }

        public AsyncInvoker<DeleteResourceTagResponse> DeleteResourceTagAsyncInvoker(DeleteResourceTagRequest deleteResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceTagRequest.Key, out var valueOfKey)) urlParam.Add("key", valueOfKey);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceTagRequest);
            return new AsyncInvoker<DeleteResourceTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteResourceTagResponse>);
        }
        
        /// <summary>
        /// 删除指定主题的订阅
        ///
        /// 删除指定主题的订阅
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSubscriptionsByTopicResponse> DeleteSubscriptionsByTopicAsync(DeleteSubscriptionsByTopicRequest deleteSubscriptionsByTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSubscriptionsByTopicRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubscriptionsByTopicRequest.SubscriptionUrn, out var valueOfSubscriptionUrn)) urlParam.Add("subscription_urn", valueOfSubscriptionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions/{subscription_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubscriptionsByTopicRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSubscriptionsByTopicResponse>(response);
        }

        public AsyncInvoker<DeleteSubscriptionsByTopicResponse> DeleteSubscriptionsByTopicAsyncInvoker(DeleteSubscriptionsByTopicRequest deleteSubscriptionsByTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSubscriptionsByTopicRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubscriptionsByTopicRequest.SubscriptionUrn, out var valueOfSubscriptionUrn)) urlParam.Add("subscription_urn", valueOfSubscriptionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions/{subscription_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubscriptionsByTopicRequest);
            return new AsyncInvoker<DeleteSubscriptionsByTopicResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSubscriptionsByTopicResponse>);
        }
        
        /// <summary>
        /// 删除主题
        ///
        /// 删除主题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest deleteTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTopicRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTopicResponse>(response);
        }

        public AsyncInvoker<DeleteTopicResponse> DeleteTopicAsyncInvoker(DeleteTopicRequest deleteTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTopicRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicRequest);
            return new AsyncInvoker<DeleteTopicResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTopicResponse>);
        }
        
        /// <summary>
        /// 删除指定名称的主题策略
        ///
        /// 删除指定名称的主题策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTopicAttributeByNameResponse> DeleteTopicAttributeByNameAsync(DeleteTopicAttributeByNameRequest deleteTopicAttributeByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTopicAttributeByNameRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(deleteTopicAttributeByNameRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributeByNameRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTopicAttributeByNameResponse>(response);
        }

        public AsyncInvoker<DeleteTopicAttributeByNameResponse> DeleteTopicAttributeByNameAsyncInvoker(DeleteTopicAttributeByNameRequest deleteTopicAttributeByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTopicAttributeByNameRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(deleteTopicAttributeByNameRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributeByNameRequest);
            return new AsyncInvoker<DeleteTopicAttributeByNameResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTopicAttributeByNameResponse>);
        }
        
        /// <summary>
        /// 删除所有主题策略
        ///
        /// 删除所有主题策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTopicAttributesResponse> DeleteTopicAttributesAsync(DeleteTopicAttributesRequest deleteTopicAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTopicAttributesRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTopicAttributesResponse>(response);
        }

        public AsyncInvoker<DeleteTopicAttributesResponse> DeleteTopicAttributesAsyncInvoker(DeleteTopicAttributesRequest deleteTopicAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTopicAttributesRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributesRequest);
            return new AsyncInvoker<DeleteTopicAttributesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTopicAttributesResponse>);
        }
        
        /// <summary>
        /// 下载证书
        ///
        /// 下载http消息校验证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadHttpCertResponse> DownloadHttpCertAsync(DownloadHttpCertRequest downloadHttpCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadHttpCertRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/smn/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadHttpCertRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerializeNull<DownloadHttpCertResponse>(response);
        }

        public AsyncInvoker<DownloadHttpCertResponse> DownloadHttpCertAsyncInvoker(DownloadHttpCertRequest downloadHttpCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadHttpCertRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/smn/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadHttpCertRequest);
            return new AsyncInvoker<DownloadHttpCertResponse>(this, "GET", request, JsonUtils.DeSerializeNull<DownloadHttpCertResponse>);
        }
        
        /// <summary>
        /// 查询授权云服务列表
        ///
        /// 查询授权云服务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCloudServiceResponse> ListCloudServiceAsync(ListCloudServiceRequest listCloudServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/notifications/cloud_service", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudServiceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCloudServiceResponse>(response);
        }

        public AsyncInvoker<ListCloudServiceResponse> ListCloudServiceAsyncInvoker(ListCloudServiceRequest listCloudServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/notifications/cloud_service", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudServiceRequest);
            return new AsyncInvoker<ListCloudServiceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudServiceResponse>);
        }
        
        /// <summary>
        /// 查询云日志
        ///
        /// 查询指定Topic绑定的云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLogtankResponse> ListLogtankAsync(ListLogtankRequest listLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLogtankRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtankRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLogtankResponse>(response);
        }

        public AsyncInvoker<ListLogtankResponse> ListLogtankAsyncInvoker(ListLogtankRequest listLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLogtankRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtankRequest);
            return new AsyncInvoker<ListLogtankResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogtankResponse>);
        }
        
        /// <summary>
        /// 查询消息模板详情
        ///
        /// 查询模板详情，包括模板内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMessageTemplateDetailsResponse> ListMessageTemplateDetailsAsync(ListMessageTemplateDetailsRequest listMessageTemplateDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMessageTemplateDetailsRequest.MessageTemplateId, out var valueOfMessageTemplateId)) urlParam.Add("message_template_id", valueOfMessageTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplateDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMessageTemplateDetailsResponse>(response);
        }

        public AsyncInvoker<ListMessageTemplateDetailsResponse> ListMessageTemplateDetailsAsyncInvoker(ListMessageTemplateDetailsRequest listMessageTemplateDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMessageTemplateDetailsRequest.MessageTemplateId, out var valueOfMessageTemplateId)) urlParam.Add("message_template_id", valueOfMessageTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplateDetailsRequest);
            return new AsyncInvoker<ListMessageTemplateDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMessageTemplateDetailsResponse>);
        }
        
        /// <summary>
        /// 查询消息模板列表
        ///
        /// 分页查询模板列表，模板列表按照创建时间进行升序排列。分页查询可以指定offset以及limit。如果不存在模板，则返回空列表。额外的查询参数分别有message_template_name和protocol。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMessageTemplatesResponse> ListMessageTemplatesAsync(ListMessageTemplatesRequest listMessageTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMessageTemplatesResponse>(response);
        }

        public AsyncInvoker<ListMessageTemplatesResponse> ListMessageTemplatesAsyncInvoker(ListMessageTemplatesRequest listMessageTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplatesRequest);
            return new AsyncInvoker<ListMessageTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMessageTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询租户在指定Region和实例类型的所有标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectTagsResponse> ListProjectTagsAsync(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }

        public AsyncInvoker<ListProjectTagsResponse> ListProjectTagsAsyncInvoker(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            return new AsyncInvoker<ListProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询协议列表
        ///
        /// 查询SMN支持的协议列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProtocolsResponse> ListProtocolsAsync(ListProtocolsRequest listProtocolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/notifications/protocols", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtocolsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProtocolsResponse>(response);
        }

        public AsyncInvoker<ListProtocolsResponse> ListProtocolsAsyncInvoker(ListProtocolsRequest listProtocolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/notifications/protocols", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtocolsRequest);
            return new AsyncInvoker<ListProtocolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProtocolsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例
        ///
        /// 使用标签过滤实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceInstancesResponse> ListResourceInstancesAsync(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceInstancesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }

        public AsyncInvoker<ListResourceInstancesResponse> ListResourceInstancesAsyncInvoker(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceInstancesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            return new AsyncInvoker<ListResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceInstancesResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询指定实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest listResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceTagsResponse>(response);
        }

        public AsyncInvoker<ListResourceTagsResponse> ListResourceTagsAsyncInvoker(ListResourceTagsRequest listResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            return new AsyncInvoker<ListResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceTagsResponse>);
        }
        
        /// <summary>
        /// 查询订阅者列表
        ///
        /// 分页返回请求者的所有的订阅列表，订阅列表按照订阅创建时间进行升序排列。分页查询可以指定offset以及limit。如果订阅者不存在，返回空列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest listSubscriptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSubscriptionsResponse>(response);
        }

        public AsyncInvoker<ListSubscriptionsResponse> ListSubscriptionsAsyncInvoker(ListSubscriptionsRequest listSubscriptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsRequest);
            return new AsyncInvoker<ListSubscriptionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubscriptionsResponse>);
        }
        
        /// <summary>
        /// 查询指定Topic的订阅者列表
        ///
        /// 分页获取特定Topic的订阅列表，订阅列表按照订阅创建时间进行升序排列。分页查询可以指定offset以及limit。如果指定Topic不存在订阅者，返回空列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicAsync(ListSubscriptionsByTopicRequest listSubscriptionsByTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubscriptionsByTopicRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsByTopicRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSubscriptionsByTopicResponse>(response);
        }

        public AsyncInvoker<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicAsyncInvoker(ListSubscriptionsByTopicRequest listSubscriptionsByTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubscriptionsByTopicRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsByTopicRequest);
            return new AsyncInvoker<ListSubscriptionsByTopicResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubscriptionsByTopicResponse>);
        }
        
        /// <summary>
        /// 查询主题策略
        ///
        /// 查询主题的策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTopicAttributesResponse> ListTopicAttributesAsync(ListTopicAttributesRequest listTopicAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTopicAttributesRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicAttributesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTopicAttributesResponse>(response);
        }

        public AsyncInvoker<ListTopicAttributesResponse> ListTopicAttributesAsyncInvoker(ListTopicAttributesRequest listTopicAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTopicAttributesRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicAttributesRequest);
            return new AsyncInvoker<ListTopicAttributesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopicAttributesResponse>);
        }
        
        /// <summary>
        /// 查询主题详情
        ///
        /// 查询Topic的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTopicDetailsResponse> ListTopicDetailsAsync(ListTopicDetailsRequest listTopicDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTopicDetailsRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTopicDetailsResponse>(response);
        }

        public AsyncInvoker<ListTopicDetailsResponse> ListTopicDetailsAsyncInvoker(ListTopicDetailsRequest listTopicDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTopicDetailsRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicDetailsRequest);
            return new AsyncInvoker<ListTopicDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopicDetailsResponse>);
        }
        
        /// <summary>
        /// 查询主题的发送详情
        ///
        /// 查询Topic的发送数据详情，最多支持查询31天内所有计量数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTopicMessageStatisticsResponse> ListTopicMessageStatisticsAsync(ListTopicMessageStatisticsRequest listTopicMessageStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTopicMessageStatisticsRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicMessageStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTopicMessageStatisticsResponse>(response);
        }

        public AsyncInvoker<ListTopicMessageStatisticsResponse> ListTopicMessageStatisticsAsyncInvoker(ListTopicMessageStatisticsRequest listTopicMessageStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTopicMessageStatisticsRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicMessageStatisticsRequest);
            return new AsyncInvoker<ListTopicMessageStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopicMessageStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询主题列表
        ///
        /// 分页查询Topic列表，Topic列表按照Topic创建时间进行降序排列。分页查询可以指定offset以及limit。如果不存在Topic，则返回空列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTopicsResponse> ListTopicsAsync(ListTopicsRequest listTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTopicsResponse>(response);
        }

        public AsyncInvoker<ListTopicsResponse> ListTopicsAsyncInvoker(ListTopicsRequest listTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicsRequest);
            return new AsyncInvoker<ListTopicsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopicsResponse>);
        }
        
        /// <summary>
        /// 查询SMN API V2版本信息
        ///
        /// 查询SMN API V2版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVersionResponse> ListVersionAsync(ListVersionRequest listVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListVersionResponse>(response);
        }

        public AsyncInvoker<ListVersionResponse> ListVersionAsyncInvoker(ListVersionRequest listVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionRequest);
            return new AsyncInvoker<ListVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVersionResponse>);
        }
        
        /// <summary>
        /// 查询SMN支持的API版本号信息
        ///
        /// 查询SMN开放API支持的版本号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest listVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListVersionsResponse>(response);
        }

        public AsyncInvoker<ListVersionsResponse> ListVersionsAsyncInvoker(ListVersionsRequest listVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            return new AsyncInvoker<ListVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVersionsResponse>);
        }
        
        /// <summary>
        /// 发布探测消息
        ///
        /// 基于主题发送http/https探测消息，探测当前http/https 终端是否可用，SMN出口是否能够正常访问该终端。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PublishHttpDetectResponse> PublishHttpDetectAsync(PublishHttpDetectRequest publishHttpDetectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishHttpDetectRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/detection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishHttpDetectRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<PublishHttpDetectResponse>(response);
        }

        public AsyncInvoker<PublishHttpDetectResponse> PublishHttpDetectAsyncInvoker(PublishHttpDetectRequest publishHttpDetectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishHttpDetectRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/detection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishHttpDetectRequest);
            return new AsyncInvoker<PublishHttpDetectResponse>(this, "POST", request, JsonUtils.DeSerialize<PublishHttpDetectResponse>);
        }
        
        /// <summary>
        /// 消息发布
        ///
        /// 将消息发送给Topic的所有订阅端点。当返回消息ID时，该消息已被保存并开始尝试将其推送给Topic的订阅者。为确保您的消息能够成功推送到各个订阅者，请确保您的消息内容符合当地法律法规要求。
        /// 三种消息发送方式
        /// 
        /// message
        /// 
        /// message_structure
        /// 
        /// message_template_name
        /// 
        /// 只需要设置其中一个，如果同时设置，生效的优先级为
        /// message_structure &gt; message_template_name &gt; message。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PublishMessageResponse> PublishMessageAsync(PublishMessageRequest publishMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishMessageRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishMessageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<PublishMessageResponse>(response);
        }

        public AsyncInvoker<PublishMessageResponse> PublishMessageAsyncInvoker(PublishMessageRequest publishMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishMessageRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishMessageRequest);
            return new AsyncInvoker<PublishMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<PublishMessageResponse>);
        }
        
        /// <summary>
        /// 获取http探测结果
        ///
        /// 根据http探测发送返回的task_id查询探测结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHttpDetectResultResponse> ShowHttpDetectResultAsync(ShowHttpDetectResultRequest showHttpDetectResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHttpDetectResultRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(showHttpDetectResultRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/detection/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpDetectResultRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHttpDetectResultResponse>(response);
        }

        public AsyncInvoker<ShowHttpDetectResultResponse> ShowHttpDetectResultAsyncInvoker(ShowHttpDetectResultRequest showHttpDetectResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHttpDetectResultRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(showHttpDetectResultRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/detection/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpDetectResultRequest);
            return new AsyncInvoker<ShowHttpDetectResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHttpDetectResultResponse>);
        }
        
        /// <summary>
        /// 查询通知策略
        ///
        /// 查询通知策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNotifyPolicyResponse> ShowNotifyPolicyAsync(ShowNotifyPolicyRequest showNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNotifyPolicyRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotifyPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNotifyPolicyResponse>(response);
        }

        public AsyncInvoker<ShowNotifyPolicyResponse> ShowNotifyPolicyAsyncInvoker(ShowNotifyPolicyRequest showNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNotifyPolicyRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotifyPolicyRequest);
            return new AsyncInvoker<ShowNotifyPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNotifyPolicyResponse>);
        }
        
        /// <summary>
        /// 取消订阅
        ///
        /// 取消订阅主题
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UnsubscribeSubscriptionResponse> UnsubscribeSubscriptionAsync(UnsubscribeSubscriptionRequest unsubscribeSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/rest/v2/notifications/subscription/unsubscribe", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unsubscribeSubscriptionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<UnsubscribeSubscriptionResponse>(response);
        }

        public AsyncInvoker<UnsubscribeSubscriptionResponse> UnsubscribeSubscriptionAsyncInvoker(UnsubscribeSubscriptionRequest unsubscribeSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/rest/v2/notifications/subscription/unsubscribe", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unsubscribeSubscriptionRequest);
            return new AsyncInvoker<UnsubscribeSubscriptionResponse>(this, "GET", request, JsonUtils.DeSerialize<UnsubscribeSubscriptionResponse>);
        }
        
        /// <summary>
        /// 更新云日志
        ///
        /// 更新指定Topic绑定的云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLogtankResponse> UpdateLogtankAsync(UpdateLogtankRequest updateLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLogtankRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogtankRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLogtankResponse>(response);
        }

        public AsyncInvoker<UpdateLogtankResponse> UpdateLogtankAsyncInvoker(UpdateLogtankRequest updateLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLogtankRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogtankRequest);
            return new AsyncInvoker<UpdateLogtankResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLogtankResponse>);
        }
        
        /// <summary>
        /// 更新消息模板
        ///
        /// 修改消息模板的内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMessageTemplateResponse> UpdateMessageTemplateAsync(UpdateMessageTemplateRequest updateMessageTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMessageTemplateRequest.MessageTemplateId, out var valueOfMessageTemplateId)) urlParam.Add("message_template_id", valueOfMessageTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMessageTemplateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMessageTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateMessageTemplateResponse> UpdateMessageTemplateAsyncInvoker(UpdateMessageTemplateRequest updateMessageTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMessageTemplateRequest.MessageTemplateId, out var valueOfMessageTemplateId)) urlParam.Add("message_template_id", valueOfMessageTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMessageTemplateRequest);
            return new AsyncInvoker<UpdateMessageTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMessageTemplateResponse>);
        }
        
        /// <summary>
        /// 修改通知策略
        ///
        /// 修改通知策略，该接口仅支持全量修改，不支持部分修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNotifyPolicyResponse> UpdateNotifyPolicyAsync(UpdateNotifyPolicyRequest updateNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNotifyPolicyRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateNotifyPolicyRequest.NotifyPolicyId, out var valueOfNotifyPolicyId)) urlParam.Add("notify_policy_id", valueOfNotifyPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy/{notify_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotifyPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNotifyPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateNotifyPolicyResponse> UpdateNotifyPolicyAsyncInvoker(UpdateNotifyPolicyRequest updateNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNotifyPolicyRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateNotifyPolicyRequest.NotifyPolicyId, out var valueOfNotifyPolicyId)) urlParam.Add("notify_policy_id", valueOfNotifyPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy/{notify_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotifyPolicyRequest);
            return new AsyncInvoker<UpdateNotifyPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNotifyPolicyResponse>);
        }
        
        /// <summary>
        /// 更新订阅者
        ///
        /// 更新订阅者备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest updateSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSubscriptionRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateSubscriptionRequest.SubscriptionUrn, out var valueOfSubscriptionUrn)) urlParam.Add("subscription_urn", valueOfSubscriptionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions/{subscription_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSubscriptionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSubscriptionResponse>(response);
        }

        public AsyncInvoker<UpdateSubscriptionResponse> UpdateSubscriptionAsyncInvoker(UpdateSubscriptionRequest updateSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSubscriptionRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateSubscriptionRequest.SubscriptionUrn, out var valueOfSubscriptionUrn)) urlParam.Add("subscription_urn", valueOfSubscriptionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions/{subscription_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSubscriptionRequest);
            return new AsyncInvoker<UpdateSubscriptionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSubscriptionResponse>);
        }
        
        /// <summary>
        /// 更新主题
        ///
        /// 更新显示名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTopicResponse> UpdateTopicAsync(UpdateTopicRequest updateTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTopicRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTopicResponse>(response);
        }

        public AsyncInvoker<UpdateTopicResponse> UpdateTopicAsyncInvoker(UpdateTopicRequest updateTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTopicRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicRequest);
            return new AsyncInvoker<UpdateTopicResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTopicResponse>);
        }
        
        /// <summary>
        /// 更新主题策略
        ///
        /// 更新主题的策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTopicAttributeResponse> UpdateTopicAttributeAsync(UpdateTopicAttributeRequest updateTopicAttributeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTopicAttributeRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateTopicAttributeRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicAttributeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTopicAttributeResponse>(response);
        }

        public AsyncInvoker<UpdateTopicAttributeResponse> UpdateTopicAttributeAsyncInvoker(UpdateTopicAttributeRequest updateTopicAttributeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTopicAttributeRequest.TopicUrn, out var valueOfTopicUrn)) urlParam.Add("topic_urn", valueOfTopicUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateTopicAttributeRequest.Name, out var valueOfName)) urlParam.Add("name", valueOfName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicAttributeRequest);
            return new AsyncInvoker<UpdateTopicAttributeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTopicAttributeResponse>);
        }
        
        /// <summary>
        /// 创建Application
        ///
        /// 创建平台应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest createApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateApplicationResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<CreateApplicationResponse> CreateApplicationAsyncInvoker(CreateApplicationRequest createApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationRequest);
            return new AsyncInvoker<CreateApplicationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateApplicationResponse>);
        }
        
        /// <summary>
        /// 删除Application
        ///
        /// 删除平台应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest deleteApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationRequest.ApplicationUrn, out var valueOfApplicationUrn)) urlParam.Add("application_urn", valueOfApplicationUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteApplicationResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<DeleteApplicationResponse> DeleteApplicationAsyncInvoker(DeleteApplicationRequest deleteApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationRequest.ApplicationUrn, out var valueOfApplicationUrn)) urlParam.Add("application_urn", valueOfApplicationUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            return new AsyncInvoker<DeleteApplicationResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteApplicationResponse>);
        }
        
        /// <summary>
        /// 查询Application属性
        ///
        /// 获取应用平台属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListApplicationAttributesResponse> ListApplicationAttributesAsync(ListApplicationAttributesRequest listApplicationAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationAttributesRequest.ApplicationUrn, out var valueOfApplicationUrn)) urlParam.Add("application_urn", valueOfApplicationUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAttributesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationAttributesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListApplicationAttributesResponse> ListApplicationAttributesAsyncInvoker(ListApplicationAttributesRequest listApplicationAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationAttributesRequest.ApplicationUrn, out var valueOfApplicationUrn)) urlParam.Add("application_urn", valueOfApplicationUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAttributesRequest);
            return new AsyncInvoker<ListApplicationAttributesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationAttributesResponse>);
        }
        
        /// <summary>
        /// 查询Application
        ///
        /// 查询应用平台列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest listApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationsResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListApplicationsResponse> ListApplicationsAsyncInvoker(ListApplicationsRequest listApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationsRequest);
            return new AsyncInvoker<ListApplicationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationsResponse>);
        }
        
        /// <summary>
        /// App消息发布
        ///
        /// 将消息直发给endpoint设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<PublishAppMessageResponse> PublishAppMessageAsync(PublishAppMessageRequest publishAppMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishAppMessageRequest.EndpointUrn, out var valueOfEndpointUrn)) urlParam.Add("endpoint_urn", valueOfEndpointUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishAppMessageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<PublishAppMessageResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<PublishAppMessageResponse> PublishAppMessageAsyncInvoker(PublishAppMessageRequest publishAppMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishAppMessageRequest.EndpointUrn, out var valueOfEndpointUrn)) urlParam.Add("endpoint_urn", valueOfEndpointUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishAppMessageRequest);
            return new AsyncInvoker<PublishAppMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<PublishAppMessageResponse>);
        }
        
        /// <summary>
        /// 更新Application
        ///
        /// 更新应用平台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest updateApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationRequest.ApplicationUrn, out var valueOfApplicationUrn)) urlParam.Add("application_urn", valueOfApplicationUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateApplicationResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<UpdateApplicationResponse> UpdateApplicationAsyncInvoker(UpdateApplicationRequest updateApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationRequest.ApplicationUrn, out var valueOfApplicationUrn)) urlParam.Add("application_urn", valueOfApplicationUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationRequest);
            return new AsyncInvoker<UpdateApplicationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateApplicationResponse>);
        }
        
        /// <summary>
        /// 创建Application endpoint
        ///
        /// 创建应用平台的endpoint终端。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<CreateApplicationEndpointResponse> CreateApplicationEndpointAsync(CreateApplicationEndpointRequest createApplicationEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createApplicationEndpointRequest.ApplicationUrn, out var valueOfApplicationUrn)) urlParam.Add("application_urn", valueOfApplicationUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationEndpointRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateApplicationEndpointResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<CreateApplicationEndpointResponse> CreateApplicationEndpointAsyncInvoker(CreateApplicationEndpointRequest createApplicationEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createApplicationEndpointRequest.ApplicationUrn, out var valueOfApplicationUrn)) urlParam.Add("application_urn", valueOfApplicationUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationEndpointRequest);
            return new AsyncInvoker<CreateApplicationEndpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateApplicationEndpointResponse>);
        }
        
        /// <summary>
        /// 删除Application endpoint
        ///
        /// 删除设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<DeleteApplicationEndpointResponse> DeleteApplicationEndpointAsync(DeleteApplicationEndpointRequest deleteApplicationEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationEndpointRequest.EndpointUrn, out var valueOfEndpointUrn)) urlParam.Add("endpoint_urn", valueOfEndpointUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationEndpointRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteApplicationEndpointResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<DeleteApplicationEndpointResponse> DeleteApplicationEndpointAsyncInvoker(DeleteApplicationEndpointRequest deleteApplicationEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationEndpointRequest.EndpointUrn, out var valueOfEndpointUrn)) urlParam.Add("endpoint_urn", valueOfEndpointUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationEndpointRequest);
            return new AsyncInvoker<DeleteApplicationEndpointResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteApplicationEndpointResponse>);
        }
        
        /// <summary>
        /// 查询Application的Endpoint属性
        ///
        /// 获取endpoint的属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListApplicationEndpointAttributesResponse> ListApplicationEndpointAttributesAsync(ListApplicationEndpointAttributesRequest listApplicationEndpointAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationEndpointAttributesRequest.EndpointUrn, out var valueOfEndpointUrn)) urlParam.Add("endpoint_urn", valueOfEndpointUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointAttributesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationEndpointAttributesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListApplicationEndpointAttributesResponse> ListApplicationEndpointAttributesAsyncInvoker(ListApplicationEndpointAttributesRequest listApplicationEndpointAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationEndpointAttributesRequest.EndpointUrn, out var valueOfEndpointUrn)) urlParam.Add("endpoint_urn", valueOfEndpointUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointAttributesRequest);
            return new AsyncInvoker<ListApplicationEndpointAttributesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationEndpointAttributesResponse>);
        }
        
        /// <summary>
        /// 查询Application的Endpoint列表
        ///
        /// 查询平台的endpoint列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListApplicationEndpointsResponse> ListApplicationEndpointsAsync(ListApplicationEndpointsRequest listApplicationEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationEndpointsRequest.ApplicationUrn, out var valueOfApplicationUrn)) urlParam.Add("application_urn", valueOfApplicationUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationEndpointsResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListApplicationEndpointsResponse> ListApplicationEndpointsAsyncInvoker(ListApplicationEndpointsRequest listApplicationEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listApplicationEndpointsRequest.ApplicationUrn, out var valueOfApplicationUrn)) urlParam.Add("application_urn", valueOfApplicationUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointsRequest);
            return new AsyncInvoker<ListApplicationEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationEndpointsResponse>);
        }
        
        /// <summary>
        /// 更新Application endpoint
        ///
        /// 更新设备属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<UpdateApplicationEndpointResponse> UpdateApplicationEndpointAsync(UpdateApplicationEndpointRequest updateApplicationEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationEndpointRequest.EndpointUrn, out var valueOfEndpointUrn)) urlParam.Add("endpoint_urn", valueOfEndpointUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationEndpointRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateApplicationEndpointResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<UpdateApplicationEndpointResponse> UpdateApplicationEndpointAsyncInvoker(UpdateApplicationEndpointRequest updateApplicationEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationEndpointRequest.EndpointUrn, out var valueOfEndpointUrn)) urlParam.Add("endpoint_urn", valueOfEndpointUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationEndpointRequest);
            return new AsyncInvoker<UpdateApplicationEndpointResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateApplicationEndpointResponse>);
        }
        
    }
}