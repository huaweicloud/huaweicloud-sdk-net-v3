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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , addSubscriptionRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addSubscriptionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddSubscriptionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , batchCreateOrDeleteResourceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , batchCreateOrDeleteResourceTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteResourceTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteResourceTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subscription_urn" , cancelSubscriptionRequest.SubscriptionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/{subscription_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelSubscriptionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<CancelSubscriptionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMessageTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateMessageTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , createResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , createResourceTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResourceTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateResourceTagResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTopicResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id" , deleteMessageTemplateRequest.MessageTemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMessageTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteMessageTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , deleteResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , deleteResourceTagRequest.ResourceId.ToString());
            urlParam.Add("key" , deleteResourceTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteResourceTagResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , deleteTopicRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteTopicResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , deleteTopicAttributeByNameRequest.TopicUrn.ToString());
            urlParam.Add("name" , deleteTopicAttributeByNameRequest.Name.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributeByNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteTopicAttributeByNameResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , deleteTopicAttributesRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteTopicAttributesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id" , listMessageTemplateDetailsRequest.MessageTemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplateDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMessageTemplateDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMessageTemplatesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listProjectTagsRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listResourceInstancesRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listResourceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , listResourceTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListResourceTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSubscriptionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , listSubscriptionsByTopicRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsByTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSubscriptionsByTopicResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , listTopicAttributesRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicAttributesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTopicAttributesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , listTopicDetailsRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTopicDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTopicsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version" , listVersionRequest.ApiVersion.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVersionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVersionsResponse>(response);
        }
        
        /// <summary>
        /// 消息发布
        ///
        /// 将消息发送给Topic的所有订阅端点。当返回消息ID时，该消息已被保存并开始尝试将其推送给Topic的订阅者。三种消息发送方式
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , publishMessageRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/publish",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<PublishMessageResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id" , updateMessageTemplateRequest.MessageTemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMessageTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateMessageTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , updateTopicRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTopicResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , updateTopicAttributeRequest.TopicUrn.ToString());
            urlParam.Add("name" , updateTopicAttributeRequest.Name.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicAttributeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTopicAttributeResponse>(response);
        }
        
        /// <summary>
        /// 创建Application
        ///
        /// 创建平台应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest createApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateApplicationResponse>(response);
        }
        
        /// <summary>
        /// 删除Application
        ///
        /// 删除平台应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest deleteApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , deleteApplicationRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteApplicationResponse>(response);
        }
        
        /// <summary>
        /// 查询Application属性
        ///
        /// 获取应用平台属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApplicationAttributesResponse> ListApplicationAttributesAsync(ListApplicationAttributesRequest listApplicationAttributesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , listApplicationAttributesRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAttributesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationAttributesResponse>(response);
        }
        
        /// <summary>
        /// 查询Application
        ///
        /// 查询应用平台列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest listApplicationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationsResponse>(response);
        }
        
        /// <summary>
        /// App消息发布
        ///
        /// 将消息直发给endpoint设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PublishAppMessageResponse> PublishAppMessageAsync(PublishAppMessageRequest publishAppMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , publishAppMessageRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}/publish",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishAppMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<PublishAppMessageResponse>(response);
        }
        
        /// <summary>
        /// 更新Application
        ///
        /// 更新应用平台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest updateApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , updateApplicationRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateApplicationResponse>(response);
        }
        
        /// <summary>
        /// 创建Application endpoint
        ///
        /// 创建应用平台的endpoint终端。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateApplicationEndpointResponse> CreateApplicationEndpointAsync(CreateApplicationEndpointRequest createApplicationEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , createApplicationEndpointRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateApplicationEndpointResponse>(response);
        }
        
        /// <summary>
        /// 删除Application endpoint
        ///
        /// 删除设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteApplicationEndpointResponse> DeleteApplicationEndpointAsync(DeleteApplicationEndpointRequest deleteApplicationEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , deleteApplicationEndpointRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteApplicationEndpointResponse>(response);
        }
        
        /// <summary>
        /// 查询Application的Endpoint属性
        ///
        /// 获取endpoint的属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApplicationEndpointAttributesResponse> ListApplicationEndpointAttributesAsync(ListApplicationEndpointAttributesRequest listApplicationEndpointAttributesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , listApplicationEndpointAttributesRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointAttributesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationEndpointAttributesResponse>(response);
        }
        
        /// <summary>
        /// 查询Application的Endpoint列表
        ///
        /// 查询平台的endpoint列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApplicationEndpointsResponse> ListApplicationEndpointsAsync(ListApplicationEndpointsRequest listApplicationEndpointsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , listApplicationEndpointsRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationEndpointsResponse>(response);
        }
        
        /// <summary>
        /// 更新Application endpoint
        ///
        /// 更新设备属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateApplicationEndpointResponse> UpdateApplicationEndpointAsync(UpdateApplicationEndpointRequest updateApplicationEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , updateApplicationEndpointRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateApplicationEndpointResponse>(response);
        }
        
    }
}