using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Smn.V2.Model;

namespace HuaweiCloud.SDK.Smn.V2
{
    public partial class SmnClient : Client
    {
        public static ClientBuilder<SmnClient> NewBuilder()
        {
            return new ClientBuilder<SmnClient>();
        }

        
        /// <summary>
        /// 订阅
        ///
        /// 为指定Topic添加一个订阅者，如果订阅者的状态为未确认，则向订阅者发送一个确认的消息。待订阅者进行ConfirmSubscription确认后，该订阅者才能收到Topic发布的消息。单Topic默认可添加10000个订阅者，高并发场景下，可能会出现订阅者数量超过10000仍添加成功的情况，此为正常现象。接口是幂等的，如果添加已存在的订阅者，则返回成功，且status code为200，否则status code为201。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddSubscriptionResponse AddSubscription(AddSubscriptionRequest addSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", addSubscriptionRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addSubscriptionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddSubscriptionResponse>(response);
        }

        public SyncInvoker<AddSubscriptionResponse> AddSubscriptionInvoker(AddSubscriptionRequest addSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", addSubscriptionRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addSubscriptionRequest);
            return new SyncInvoker<AddSubscriptionResponse>(this, "POST", request, JsonUtils.DeSerialize<AddSubscriptionResponse>);
        }
        
        /// <summary>
        /// 导入订阅
        ///
        /// 为指定的Topic添加订阅者，订阅者信息来源为订阅用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddSubscriptionFromSubscriptionUserResponse AddSubscriptionFromSubscriptionUser(AddSubscriptionFromSubscriptionUserRequest addSubscriptionFromSubscriptionUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", addSubscriptionFromSubscriptionUserRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions/from-subscription-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addSubscriptionFromSubscriptionUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddSubscriptionFromSubscriptionUserResponse>(response);
        }

        public SyncInvoker<AddSubscriptionFromSubscriptionUserResponse> AddSubscriptionFromSubscriptionUserInvoker(AddSubscriptionFromSubscriptionUserRequest addSubscriptionFromSubscriptionUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", addSubscriptionFromSubscriptionUserRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions/from-subscription-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addSubscriptionFromSubscriptionUserRequest);
            return new SyncInvoker<AddSubscriptionFromSubscriptionUserResponse>(this, "POST", request, JsonUtils.DeSerialize<AddSubscriptionFromSubscriptionUserResponse>);
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
        public BatchCreateOrDeleteResourceTagsResponse BatchCreateOrDeleteResourceTags(BatchCreateOrDeleteResourceTagsRequest batchCreateOrDeleteResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchCreateOrDeleteResourceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchCreateOrDeleteResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteResourceTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteResourceTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateOrDeleteResourceTagsResponse> BatchCreateOrDeleteResourceTagsInvoker(BatchCreateOrDeleteResourceTagsRequest batchCreateOrDeleteResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchCreateOrDeleteResourceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchCreateOrDeleteResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteResourceTagsRequest);
            return new SyncInvoker<BatchCreateOrDeleteResourceTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateOrDeleteResourceTagsResponse>);
        }
        
        /// <summary>
        /// 批量创建订阅过滤策略
        ///
        /// 创建订阅者的消息过滤策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateSubscriptionsFilterPolicesResponse BatchCreateSubscriptionsFilterPolices(BatchCreateSubscriptionsFilterPolicesRequest batchCreateSubscriptionsFilterPolicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/filter_polices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSubscriptionsFilterPolicesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateSubscriptionsFilterPolicesResponse>(response);
        }

        public SyncInvoker<BatchCreateSubscriptionsFilterPolicesResponse> BatchCreateSubscriptionsFilterPolicesInvoker(BatchCreateSubscriptionsFilterPolicesRequest batchCreateSubscriptionsFilterPolicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/filter_polices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSubscriptionsFilterPolicesRequest);
            return new SyncInvoker<BatchCreateSubscriptionsFilterPolicesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateSubscriptionsFilterPolicesResponse>);
        }
        
        /// <summary>
        /// 批量删除订阅过滤策略
        ///
        /// 删除订阅者的消息过滤策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteSubscriptionsFilterPolicesResponse BatchDeleteSubscriptionsFilterPolices(BatchDeleteSubscriptionsFilterPolicesRequest batchDeleteSubscriptionsFilterPolicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/filter_polices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSubscriptionsFilterPolicesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteSubscriptionsFilterPolicesResponse>(response);
        }

        public SyncInvoker<BatchDeleteSubscriptionsFilterPolicesResponse> BatchDeleteSubscriptionsFilterPolicesInvoker(BatchDeleteSubscriptionsFilterPolicesRequest batchDeleteSubscriptionsFilterPolicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/filter_polices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSubscriptionsFilterPolicesRequest);
            return new SyncInvoker<BatchDeleteSubscriptionsFilterPolicesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteSubscriptionsFilterPolicesResponse>);
        }
        
        /// <summary>
        /// 批量更新订阅过滤策略
        ///
        /// 更新订阅者的消息过滤策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateSubscriptionsFilterPolicesResponse BatchUpdateSubscriptionsFilterPolices(BatchUpdateSubscriptionsFilterPolicesRequest batchUpdateSubscriptionsFilterPolicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/filter_polices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateSubscriptionsFilterPolicesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateSubscriptionsFilterPolicesResponse>(response);
        }

        public SyncInvoker<BatchUpdateSubscriptionsFilterPolicesResponse> BatchUpdateSubscriptionsFilterPolicesInvoker(BatchUpdateSubscriptionsFilterPolicesRequest batchUpdateSubscriptionsFilterPolicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/filter_polices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateSubscriptionsFilterPolicesRequest);
            return new SyncInvoker<BatchUpdateSubscriptionsFilterPolicesResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateSubscriptionsFilterPolicesResponse>);
        }
        
        /// <summary>
        /// 取消订阅
        ///
        /// 删除指定的订阅者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelSubscriptionResponse CancelSubscription(CancelSubscriptionRequest cancelSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subscription_urn", cancelSubscriptionRequest.SubscriptionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/{subscription_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelSubscriptionRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<CancelSubscriptionResponse>(response);
        }

        public SyncInvoker<CancelSubscriptionResponse> CancelSubscriptionInvoker(CancelSubscriptionRequest cancelSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("subscription_urn", cancelSubscriptionRequest.SubscriptionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/{subscription_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelSubscriptionRequest);
            return new SyncInvoker<CancelSubscriptionResponse>(this, "DELETE", request, JsonUtils.DeSerialize<CancelSubscriptionResponse>);
        }
        
        /// <summary>
        /// 绑定云日志
        ///
        /// 为指定Topic绑定一个云日志，用于记录主题消息发送状态等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLogtankResponse CreateLogtank(CreateLogtankRequest createLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", createLogtankRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLogtankRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLogtankResponse>(response);
        }

        public SyncInvoker<CreateLogtankResponse> CreateLogtankInvoker(CreateLogtankRequest createLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", createLogtankRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLogtankRequest);
            return new SyncInvoker<CreateLogtankResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLogtankResponse>);
        }
        
        /// <summary>
        /// 创建消息模板
        ///
        /// 创建一个模板，用户可以按照模板去发送消息，这样可以减少请求的数据量。
        /// 单用户默认可创建100个消息模板，高并发场景下，可能会出现消息模板数量超过100仍创建成功的情况，此为正常现象。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMessageTemplateResponse CreateMessageTemplate(CreateMessageTemplateRequest createMessageTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMessageTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMessageTemplateResponse>(response);
        }

        public SyncInvoker<CreateMessageTemplateResponse> CreateMessageTemplateInvoker(CreateMessageTemplateRequest createMessageTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMessageTemplateRequest);
            return new SyncInvoker<CreateMessageTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMessageTemplateResponse>);
        }
        
        /// <summary>
        /// 创建通知策略
        ///
        /// 创建通知策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateNotifyPolicyResponse CreateNotifyPolicy(CreateNotifyPolicyRequest createNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", createNotifyPolicyRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotifyPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateNotifyPolicyResponse>(response);
        }

        public SyncInvoker<CreateNotifyPolicyResponse> CreateNotifyPolicyInvoker(CreateNotifyPolicyRequest createNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", createNotifyPolicyRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotifyPolicyRequest);
            return new SyncInvoker<CreateNotifyPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNotifyPolicyResponse>);
        }
        
        /// <summary>
        /// 添加资源标签
        ///
        /// 一个资源上最多有10个标签。此接口为幂等接口：创建时，如果创建的标签已经存在（key相同），则覆盖。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateResourceTagResponse CreateResourceTag(CreateResourceTagRequest createResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResourceTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateResourceTagResponse>(response);
        }

        public SyncInvoker<CreateResourceTagResponse> CreateResourceTagInvoker(CreateResourceTagRequest createResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResourceTagRequest);
            return new SyncInvoker<CreateResourceTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateResourceTagResponse>);
        }
        
        /// <summary>
        /// 创建主题
        ///
        /// 创建Topic，单用户默认配额为3000。高并发场景下，可能会出现Topic数量超过3000仍创建成功的情况，此为正常现象。
        /// 接口是幂等的，接口调用返回成功时，若已存在同名的Topic，返回的status code为200，否则返回的status code为201
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTopicResponse CreateTopic(CreateTopicRequest createTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTopicRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTopicResponse>(response);
        }

        public SyncInvoker<CreateTopicResponse> CreateTopicInvoker(CreateTopicRequest createTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTopicRequest);
            return new SyncInvoker<CreateTopicResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTopicResponse>);
        }
        
        /// <summary>
        /// 解绑云日志
        ///
        /// 解绑指定Topic绑定的云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLogtankResponse DeleteLogtank(DeleteLogtankRequest deleteLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", deleteLogtankRequest.TopicUrn.ToString());
            urlParam.Add("logtank_id", deleteLogtankRequest.LogtankId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteLogtankResponse>(response);
        }

        public SyncInvoker<DeleteLogtankResponse> DeleteLogtankInvoker(DeleteLogtankRequest deleteLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", deleteLogtankRequest.TopicUrn.ToString());
            urlParam.Add("logtank_id", deleteLogtankRequest.LogtankId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            return new SyncInvoker<DeleteLogtankResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteLogtankResponse>);
        }
        
        /// <summary>
        /// 删除消息模板
        ///
        /// 删除消息模板。删除模板之前的消息请求都可以使用该模板发送，删除之后无法再使用该模板发送消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMessageTemplateResponse DeleteMessageTemplate(DeleteMessageTemplateRequest deleteMessageTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id", deleteMessageTemplateRequest.MessageTemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMessageTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteMessageTemplateResponse>(response);
        }

        public SyncInvoker<DeleteMessageTemplateResponse> DeleteMessageTemplateInvoker(DeleteMessageTemplateRequest deleteMessageTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id", deleteMessageTemplateRequest.MessageTemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMessageTemplateRequest);
            return new SyncInvoker<DeleteMessageTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteMessageTemplateResponse>);
        }
        
        /// <summary>
        /// 删除通知策略
        ///
        /// 删除通知策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteNotifyPolicyResponse DeleteNotifyPolicy(DeleteNotifyPolicyRequest deleteNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", deleteNotifyPolicyRequest.TopicUrn.ToString());
            urlParam.Add("notify_policy_id", deleteNotifyPolicyRequest.NotifyPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy/{notify_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNotifyPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteNotifyPolicyResponse>(response);
        }

        public SyncInvoker<DeleteNotifyPolicyResponse> DeleteNotifyPolicyInvoker(DeleteNotifyPolicyRequest deleteNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", deleteNotifyPolicyRequest.TopicUrn.ToString());
            urlParam.Add("notify_policy_id", deleteNotifyPolicyRequest.NotifyPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy/{notify_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNotifyPolicyRequest);
            return new SyncInvoker<DeleteNotifyPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteNotifyPolicyResponse>);
        }
        
        /// <summary>
        /// 删除资源标签
        ///
        /// 幂等接口：删除时，不对标签做校验。删除的key不存在报404，key不能为空或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteResourceTagResponse DeleteResourceTag(DeleteResourceTagRequest deleteResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteResourceTagRequest.ResourceId.ToString());
            urlParam.Add("key", deleteResourceTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteResourceTagResponse>(response);
        }

        public SyncInvoker<DeleteResourceTagResponse> DeleteResourceTagInvoker(DeleteResourceTagRequest deleteResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteResourceTagRequest.ResourceId.ToString());
            urlParam.Add("key", deleteResourceTagRequest.Key.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceTagRequest);
            return new SyncInvoker<DeleteResourceTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteResourceTagResponse>);
        }
        
        /// <summary>
        /// 删除主题
        ///
        /// 删除主题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTopicResponse DeleteTopic(DeleteTopicRequest deleteTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", deleteTopicRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTopicResponse>(response);
        }

        public SyncInvoker<DeleteTopicResponse> DeleteTopicInvoker(DeleteTopicRequest deleteTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", deleteTopicRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicRequest);
            return new SyncInvoker<DeleteTopicResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTopicResponse>);
        }
        
        /// <summary>
        /// 删除指定名称的主题策略
        ///
        /// 删除指定名称的主题策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTopicAttributeByNameResponse DeleteTopicAttributeByName(DeleteTopicAttributeByNameRequest deleteTopicAttributeByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", deleteTopicAttributeByNameRequest.TopicUrn.ToString());
            urlParam.Add("name", deleteTopicAttributeByNameRequest.Name.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributeByNameRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTopicAttributeByNameResponse>(response);
        }

        public SyncInvoker<DeleteTopicAttributeByNameResponse> DeleteTopicAttributeByNameInvoker(DeleteTopicAttributeByNameRequest deleteTopicAttributeByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", deleteTopicAttributeByNameRequest.TopicUrn.ToString());
            urlParam.Add("name", deleteTopicAttributeByNameRequest.Name.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributeByNameRequest);
            return new SyncInvoker<DeleteTopicAttributeByNameResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTopicAttributeByNameResponse>);
        }
        
        /// <summary>
        /// 删除所有主题策略
        ///
        /// 删除所有主题策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTopicAttributesResponse DeleteTopicAttributes(DeleteTopicAttributesRequest deleteTopicAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", deleteTopicAttributesRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTopicAttributesResponse>(response);
        }

        public SyncInvoker<DeleteTopicAttributesResponse> DeleteTopicAttributesInvoker(DeleteTopicAttributesRequest deleteTopicAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", deleteTopicAttributesRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributesRequest);
            return new SyncInvoker<DeleteTopicAttributesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTopicAttributesResponse>);
        }
        
        /// <summary>
        /// 查询云日志
        ///
        /// 查询指定Topic绑定的云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLogtankResponse ListLogtank(ListLogtankRequest listLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", listLogtankRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtankRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLogtankResponse>(response);
        }

        public SyncInvoker<ListLogtankResponse> ListLogtankInvoker(ListLogtankRequest listLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", listLogtankRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtankRequest);
            return new SyncInvoker<ListLogtankResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogtankResponse>);
        }
        
        /// <summary>
        /// 查询消息模板详情
        ///
        /// 查询模板详情，包括模板内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMessageTemplateDetailsResponse ListMessageTemplateDetails(ListMessageTemplateDetailsRequest listMessageTemplateDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id", listMessageTemplateDetailsRequest.MessageTemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplateDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMessageTemplateDetailsResponse>(response);
        }

        public SyncInvoker<ListMessageTemplateDetailsResponse> ListMessageTemplateDetailsInvoker(ListMessageTemplateDetailsRequest listMessageTemplateDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id", listMessageTemplateDetailsRequest.MessageTemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplateDetailsRequest);
            return new SyncInvoker<ListMessageTemplateDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMessageTemplateDetailsResponse>);
        }
        
        /// <summary>
        /// 查询消息模板列表
        ///
        /// 分页查询模板列表，模板列表按照创建时间进行升序排列。分页查询可以指定offset以及limit。如果不存在模板，则返回空列表。额外的查询参数分别有message_template_name和protocol。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMessageTemplatesResponse ListMessageTemplates(ListMessageTemplatesRequest listMessageTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMessageTemplatesResponse>(response);
        }

        public SyncInvoker<ListMessageTemplatesResponse> ListMessageTemplatesInvoker(ListMessageTemplatesRequest listMessageTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplatesRequest);
            return new SyncInvoker<ListMessageTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMessageTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询租户在指定Region和实例类型的所有标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectTagsResponse ListProjectTags(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listProjectTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }

        public SyncInvoker<ListProjectTagsResponse> ListProjectTagsInvoker(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listProjectTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            return new SyncInvoker<ListProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例
        ///
        /// 使用标签过滤实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceInstancesResponse ListResourceInstances(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstancesRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }

        public SyncInvoker<ListResourceInstancesResponse> ListResourceInstancesInvoker(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstancesRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            return new SyncInvoker<ListResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceInstancesResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询指定实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest listResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourceTagsResponse>(response);
        }

        public SyncInvoker<ListResourceTagsResponse> ListResourceTagsInvoker(ListResourceTagsRequest listResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            return new SyncInvoker<ListResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceTagsResponse>);
        }
        
        /// <summary>
        /// 查询订阅者列表
        ///
        /// 分页返回请求者的所有的订阅列表，订阅列表按照订阅创建时间进行升序排列。分页查询可以指定offset以及limit。如果订阅者不存在，返回空列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest listSubscriptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSubscriptionsResponse>(response);
        }

        public SyncInvoker<ListSubscriptionsResponse> ListSubscriptionsInvoker(ListSubscriptionsRequest listSubscriptionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsRequest);
            return new SyncInvoker<ListSubscriptionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubscriptionsResponse>);
        }
        
        /// <summary>
        /// 查询指定Topic的订阅者列表
        ///
        /// 分页获取特定Topic的订阅列表，订阅列表按照订阅创建时间进行升序排列。分页查询可以指定offset以及limit。如果指定Topic不存在订阅者，返回空列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest listSubscriptionsByTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", listSubscriptionsByTopicRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsByTopicRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSubscriptionsByTopicResponse>(response);
        }

        public SyncInvoker<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicInvoker(ListSubscriptionsByTopicRequest listSubscriptionsByTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", listSubscriptionsByTopicRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsByTopicRequest);
            return new SyncInvoker<ListSubscriptionsByTopicResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubscriptionsByTopicResponse>);
        }
        
        /// <summary>
        /// 查询主题策略
        ///
        /// 查询主题的策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTopicAttributesResponse ListTopicAttributes(ListTopicAttributesRequest listTopicAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", listTopicAttributesRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicAttributesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTopicAttributesResponse>(response);
        }

        public SyncInvoker<ListTopicAttributesResponse> ListTopicAttributesInvoker(ListTopicAttributesRequest listTopicAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", listTopicAttributesRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicAttributesRequest);
            return new SyncInvoker<ListTopicAttributesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopicAttributesResponse>);
        }
        
        /// <summary>
        /// 查询主题详情
        ///
        /// 查询Topic的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTopicDetailsResponse ListTopicDetails(ListTopicDetailsRequest listTopicDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", listTopicDetailsRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTopicDetailsResponse>(response);
        }

        public SyncInvoker<ListTopicDetailsResponse> ListTopicDetailsInvoker(ListTopicDetailsRequest listTopicDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", listTopicDetailsRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicDetailsRequest);
            return new SyncInvoker<ListTopicDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopicDetailsResponse>);
        }
        
        /// <summary>
        /// 查询主题列表
        ///
        /// 分页查询Topic列表，Topic列表按照Topic创建时间进行降序排列。分页查询可以指定offset以及limit。如果不存在Topic，则返回空列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTopicsResponse ListTopics(ListTopicsRequest listTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTopicsResponse>(response);
        }

        public SyncInvoker<ListTopicsResponse> ListTopicsInvoker(ListTopicsRequest listTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicsRequest);
            return new SyncInvoker<ListTopicsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopicsResponse>);
        }
        
        /// <summary>
        /// 查询SMN API V2版本信息
        ///
        /// 查询SMN API V2版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVersionResponse ListVersion(ListVersionRequest listVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVersionResponse>(response);
        }

        public SyncInvoker<ListVersionResponse> ListVersionInvoker(ListVersionRequest listVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionRequest);
            return new SyncInvoker<ListVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVersionResponse>);
        }
        
        /// <summary>
        /// 查询SMN支持的API版本号信息
        ///
        /// 查询SMN开放API支持的版本号。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVersionsResponse ListVersions(ListVersionsRequest listVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVersionsResponse>(response);
        }

        public SyncInvoker<ListVersionsResponse> ListVersionsInvoker(ListVersionsRequest listVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            return new SyncInvoker<ListVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVersionsResponse>);
        }
        
        /// <summary>
        /// 发布探测消息
        ///
        /// 基于主题发送http/https探测消息，探测当前http/https 终端是否可用，SMN出口是否能够正常访问该终端。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PublishHttpDetectResponse PublishHttpDetect(PublishHttpDetectRequest publishHttpDetectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", publishHttpDetectRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/detection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishHttpDetectRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<PublishHttpDetectResponse>(response);
        }

        public SyncInvoker<PublishHttpDetectResponse> PublishHttpDetectInvoker(PublishHttpDetectRequest publishHttpDetectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", publishHttpDetectRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/detection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishHttpDetectRequest);
            return new SyncInvoker<PublishHttpDetectResponse>(this, "POST", request, JsonUtils.DeSerialize<PublishHttpDetectResponse>);
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
        public PublishMessageResponse PublishMessage(PublishMessageRequest publishMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", publishMessageRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishMessageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<PublishMessageResponse>(response);
        }

        public SyncInvoker<PublishMessageResponse> PublishMessageInvoker(PublishMessageRequest publishMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", publishMessageRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishMessageRequest);
            return new SyncInvoker<PublishMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<PublishMessageResponse>);
        }
        
        /// <summary>
        /// 获取http探测结果
        ///
        /// 根据http探测发送返回的task_id查询探测结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHttpDetectResultResponse ShowHttpDetectResult(ShowHttpDetectResultRequest showHttpDetectResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", showHttpDetectResultRequest.TopicUrn.ToString());
            urlParam.Add("task_id", showHttpDetectResultRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/detection/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpDetectResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHttpDetectResultResponse>(response);
        }

        public SyncInvoker<ShowHttpDetectResultResponse> ShowHttpDetectResultInvoker(ShowHttpDetectResultRequest showHttpDetectResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", showHttpDetectResultRequest.TopicUrn.ToString());
            urlParam.Add("task_id", showHttpDetectResultRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/detection/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpDetectResultRequest);
            return new SyncInvoker<ShowHttpDetectResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHttpDetectResultResponse>);
        }
        
        /// <summary>
        /// 查询通知策略
        ///
        /// 查询通知策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNotifyPolicyResponse ShowNotifyPolicy(ShowNotifyPolicyRequest showNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", showNotifyPolicyRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotifyPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNotifyPolicyResponse>(response);
        }

        public SyncInvoker<ShowNotifyPolicyResponse> ShowNotifyPolicyInvoker(ShowNotifyPolicyRequest showNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", showNotifyPolicyRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotifyPolicyRequest);
            return new SyncInvoker<ShowNotifyPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNotifyPolicyResponse>);
        }
        
        /// <summary>
        /// 更新云日志
        ///
        /// 更新指定Topic绑定的云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLogtankResponse UpdateLogtank(UpdateLogtankRequest updateLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", updateLogtankRequest.TopicUrn.ToString());
            urlParam.Add("logtank_id", updateLogtankRequest.LogtankId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogtankRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLogtankResponse>(response);
        }

        public SyncInvoker<UpdateLogtankResponse> UpdateLogtankInvoker(UpdateLogtankRequest updateLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", updateLogtankRequest.TopicUrn.ToString());
            urlParam.Add("logtank_id", updateLogtankRequest.LogtankId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogtankRequest);
            return new SyncInvoker<UpdateLogtankResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLogtankResponse>);
        }
        
        /// <summary>
        /// 更新消息模板
        ///
        /// 修改消息模板的内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMessageTemplateResponse UpdateMessageTemplate(UpdateMessageTemplateRequest updateMessageTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id", updateMessageTemplateRequest.MessageTemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMessageTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMessageTemplateResponse>(response);
        }

        public SyncInvoker<UpdateMessageTemplateResponse> UpdateMessageTemplateInvoker(UpdateMessageTemplateRequest updateMessageTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id", updateMessageTemplateRequest.MessageTemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMessageTemplateRequest);
            return new SyncInvoker<UpdateMessageTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMessageTemplateResponse>);
        }
        
        /// <summary>
        /// 修改通知策略
        ///
        /// 修改通知策略，该接口仅支持全量修改，不支持部分修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNotifyPolicyResponse UpdateNotifyPolicy(UpdateNotifyPolicyRequest updateNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", updateNotifyPolicyRequest.TopicUrn.ToString());
            urlParam.Add("notify_policy_id", updateNotifyPolicyRequest.NotifyPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy/{notify_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotifyPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNotifyPolicyResponse>(response);
        }

        public SyncInvoker<UpdateNotifyPolicyResponse> UpdateNotifyPolicyInvoker(UpdateNotifyPolicyRequest updateNotifyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", updateNotifyPolicyRequest.TopicUrn.ToString());
            urlParam.Add("notify_policy_id", updateNotifyPolicyRequest.NotifyPolicyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/notify-policy/{notify_policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotifyPolicyRequest);
            return new SyncInvoker<UpdateNotifyPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNotifyPolicyResponse>);
        }
        
        /// <summary>
        /// 更新订阅者
        ///
        /// 更新订阅者备注。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest updateSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", updateSubscriptionRequest.TopicUrn.ToString());
            urlParam.Add("subscription_urn", updateSubscriptionRequest.SubscriptionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions/{subscription_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSubscriptionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSubscriptionResponse>(response);
        }

        public SyncInvoker<UpdateSubscriptionResponse> UpdateSubscriptionInvoker(UpdateSubscriptionRequest updateSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", updateSubscriptionRequest.TopicUrn.ToString());
            urlParam.Add("subscription_urn", updateSubscriptionRequest.SubscriptionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions/{subscription_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSubscriptionRequest);
            return new SyncInvoker<UpdateSubscriptionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSubscriptionResponse>);
        }
        
        /// <summary>
        /// 更新主题
        ///
        /// 更新显示名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTopicResponse UpdateTopic(UpdateTopicRequest updateTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", updateTopicRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTopicResponse>(response);
        }

        public SyncInvoker<UpdateTopicResponse> UpdateTopicInvoker(UpdateTopicRequest updateTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", updateTopicRequest.TopicUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicRequest);
            return new SyncInvoker<UpdateTopicResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTopicResponse>);
        }
        
        /// <summary>
        /// 更新主题策略
        ///
        /// 更新主题的策略信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTopicAttributeResponse UpdateTopicAttribute(UpdateTopicAttributeRequest updateTopicAttributeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", updateTopicAttributeRequest.TopicUrn.ToString());
            urlParam.Add("name", updateTopicAttributeRequest.Name.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicAttributeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTopicAttributeResponse>(response);
        }

        public SyncInvoker<UpdateTopicAttributeResponse> UpdateTopicAttributeInvoker(UpdateTopicAttributeRequest updateTopicAttributeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn", updateTopicAttributeRequest.TopicUrn.ToString());
            urlParam.Add("name", updateTopicAttributeRequest.Name.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicAttributeRequest);
            return new SyncInvoker<UpdateTopicAttributeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTopicAttributeResponse>);
        }
        
        /// <summary>
        /// 创建Application
        ///
        /// 创建平台应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public CreateApplicationResponse CreateApplication(CreateApplicationRequest createApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateApplicationResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<CreateApplicationResponse> CreateApplicationInvoker(CreateApplicationRequest createApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationRequest);
            return new SyncInvoker<CreateApplicationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateApplicationResponse>);
        }
        
        /// <summary>
        /// 删除Application
        ///
        /// 删除平台应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest deleteApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn", deleteApplicationRequest.ApplicationUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteApplicationResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<DeleteApplicationResponse> DeleteApplicationInvoker(DeleteApplicationRequest deleteApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn", deleteApplicationRequest.ApplicationUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            return new SyncInvoker<DeleteApplicationResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteApplicationResponse>);
        }
        
        /// <summary>
        /// 查询Application属性
        ///
        /// 获取应用平台属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListApplicationAttributesResponse ListApplicationAttributes(ListApplicationAttributesRequest listApplicationAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn", listApplicationAttributesRequest.ApplicationUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAttributesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationAttributesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListApplicationAttributesResponse> ListApplicationAttributesInvoker(ListApplicationAttributesRequest listApplicationAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn", listApplicationAttributesRequest.ApplicationUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAttributesRequest);
            return new SyncInvoker<ListApplicationAttributesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationAttributesResponse>);
        }
        
        /// <summary>
        /// 查询Application
        ///
        /// 查询应用平台列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListApplicationsResponse ListApplications(ListApplicationsRequest listApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationsResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListApplicationsResponse> ListApplicationsInvoker(ListApplicationsRequest listApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationsRequest);
            return new SyncInvoker<ListApplicationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationsResponse>);
        }
        
        /// <summary>
        /// App消息发布
        ///
        /// 将消息直发给endpoint设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public PublishAppMessageResponse PublishAppMessage(PublishAppMessageRequest publishAppMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn", publishAppMessageRequest.EndpointUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishAppMessageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<PublishAppMessageResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<PublishAppMessageResponse> PublishAppMessageInvoker(PublishAppMessageRequest publishAppMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn", publishAppMessageRequest.EndpointUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishAppMessageRequest);
            return new SyncInvoker<PublishAppMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<PublishAppMessageResponse>);
        }
        
        /// <summary>
        /// 更新Application
        ///
        /// 更新应用平台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest updateApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn", updateApplicationRequest.ApplicationUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateApplicationResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<UpdateApplicationResponse> UpdateApplicationInvoker(UpdateApplicationRequest updateApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn", updateApplicationRequest.ApplicationUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationRequest);
            return new SyncInvoker<UpdateApplicationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateApplicationResponse>);
        }
        
        /// <summary>
        /// 创建Application endpoint
        ///
        /// 创建应用平台的endpoint终端。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public CreateApplicationEndpointResponse CreateApplicationEndpoint(CreateApplicationEndpointRequest createApplicationEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn", createApplicationEndpointRequest.ApplicationUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationEndpointRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateApplicationEndpointResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<CreateApplicationEndpointResponse> CreateApplicationEndpointInvoker(CreateApplicationEndpointRequest createApplicationEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn", createApplicationEndpointRequest.ApplicationUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationEndpointRequest);
            return new SyncInvoker<CreateApplicationEndpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateApplicationEndpointResponse>);
        }
        
        /// <summary>
        /// 删除Application endpoint
        ///
        /// 删除设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public DeleteApplicationEndpointResponse DeleteApplicationEndpoint(DeleteApplicationEndpointRequest deleteApplicationEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn", deleteApplicationEndpointRequest.EndpointUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationEndpointRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteApplicationEndpointResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<DeleteApplicationEndpointResponse> DeleteApplicationEndpointInvoker(DeleteApplicationEndpointRequest deleteApplicationEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn", deleteApplicationEndpointRequest.EndpointUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationEndpointRequest);
            return new SyncInvoker<DeleteApplicationEndpointResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteApplicationEndpointResponse>);
        }
        
        /// <summary>
        /// 查询Application的Endpoint属性
        ///
        /// 获取endpoint的属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListApplicationEndpointAttributesResponse ListApplicationEndpointAttributes(ListApplicationEndpointAttributesRequest listApplicationEndpointAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn", listApplicationEndpointAttributesRequest.EndpointUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointAttributesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationEndpointAttributesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListApplicationEndpointAttributesResponse> ListApplicationEndpointAttributesInvoker(ListApplicationEndpointAttributesRequest listApplicationEndpointAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn", listApplicationEndpointAttributesRequest.EndpointUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointAttributesRequest);
            return new SyncInvoker<ListApplicationEndpointAttributesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationEndpointAttributesResponse>);
        }
        
        /// <summary>
        /// 查询Application的Endpoint列表
        ///
        /// 查询平台的endpoint列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ListApplicationEndpointsResponse ListApplicationEndpoints(ListApplicationEndpointsRequest listApplicationEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn", listApplicationEndpointsRequest.ApplicationUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApplicationEndpointsResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ListApplicationEndpointsResponse> ListApplicationEndpointsInvoker(ListApplicationEndpointsRequest listApplicationEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn", listApplicationEndpointsRequest.ApplicationUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointsRequest);
            return new SyncInvoker<ListApplicationEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApplicationEndpointsResponse>);
        }
        
        /// <summary>
        /// 更新Application endpoint
        ///
        /// 更新设备属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public UpdateApplicationEndpointResponse UpdateApplicationEndpoint(UpdateApplicationEndpointRequest updateApplicationEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn", updateApplicationEndpointRequest.EndpointUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationEndpointRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateApplicationEndpointResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<UpdateApplicationEndpointResponse> UpdateApplicationEndpointInvoker(UpdateApplicationEndpointRequest updateApplicationEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn", updateApplicationEndpointRequest.EndpointUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationEndpointRequest);
            return new SyncInvoker<UpdateApplicationEndpointResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateApplicationEndpointResponse>);
        }
        
    }
}