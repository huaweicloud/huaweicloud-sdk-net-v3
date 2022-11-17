using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Dms.V2.Model;

namespace HuaweiCloud.SDK.Dms.V2
{
    public partial class DmsAsyncClient : Client
    {
        public static ClientBuilder<DmsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<DmsAsyncClient>();
        }

        
        /// <summary>
        /// 批量添加或删除队列标签
        ///
        /// 批量添加或删除队列标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateOrDeleteQueueTagResponse> BatchCreateOrDeleteQueueTagAsync(BatchCreateOrDeleteQueueTagRequest batchCreateOrDeleteQueueTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , batchCreateOrDeleteQueueTagRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queue/{queue_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteQueueTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteQueueTagResponse>(response);
        }
        
        /// <summary>
        /// 确认已消费指定消息
        ///
        /// 确认已经消费指定消息。
        /// 
        /// 在消费者消费消息期间，消息仍然停留在队列中，但消息从被消费开始的30秒内不能被该消费组再次消费，若在这30秒内没有被消费者确认消费，则DMS认为消息未消费成功，将可以被继续消费。
        /// 
        /// 如果消息被确认消费成功，消息将不能被该消费组再次消费，但是消息仍然保持在队列中，并且可以被其它消费组消费，消息在队列中的保留时间默认为72小时（除非队列被删除），72小时后会被删除。
        /// 
        /// 消息批量消费确认时，必须严格按照消息消费的顺序提交确认，DMS按顺序判定消息是否消费成功，如果某条消息未确认或消费失败，则不再继续检测，默认后续消息全部消费失败。建议当对某一条消息处理失败时，不再需要继续处理本批消息中的后续消息，直接对已正确处理的消息进行确认。
        /// 
        /// 确认消费失败后，可以再次重新消费和确认。当开启死信时，消息进行多次重复消费仍然失败后，DMS会将该条消息转存到死信队列中，有效期为72小时，用户可以根据需要对死信消息进行重新消费。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ConfirmConsumptionMessagesResponse> ConfirmConsumptionMessagesAsync(ConfirmConsumptionMessagesRequest confirmConsumptionMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , confirmConsumptionMessagesRequest.QueueId.ToString());
            urlParam.Add("consumer_group_id" , confirmConsumptionMessagesRequest.ConsumerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{consumer_group_id}/ack",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmConsumptionMessagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ConfirmConsumptionMessagesResponse>(response);
        }
        
        /// <summary>
        /// 确认已消费死信消息
        ///
        /// 确认已经消费指定的死信消息。
        /// 
        /// 在消费者消费死信消息期间，死信消息仍然停留在队列中，但死信消息从被消费开始的30秒内不能被该消费组再次消费，若在这30秒内没有被消费者确认消费，则DMS认为死信消息未消费成功，将可以被继续消费。
        /// 
        /// 如果死信消息被确认消费成功，该死信消息将不能被该消费组再次消费，死信消息的保留时间为72小时（除非消费组被删除），72小时后会被删除。
        /// 
        /// 消息批量消费确认时，必须严格按照消息消费的顺序提交确认，DMS按顺序判定消息是否消费成功，如果某条消息未确认或消费失败，则不再继续检测，默认后续消息全部消费失败。建议当对某一条消息处理失败时，不再需要继续处理本批消息中的后续消息，直接对已正确处理的消息进行确认。
        /// 
        /// 仅NORMAL队列和FIFO队列可以开启死信消息，因为只有NORMAL队列和FIFO队列可消费死信消息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ConfirmDeadLettersMessagesResponse> ConfirmDeadLettersMessagesAsync(ConfirmDeadLettersMessagesRequest confirmDeadLettersMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , confirmDeadLettersMessagesRequest.QueueId.ToString());
            urlParam.Add("consumer_group_id" , confirmDeadLettersMessagesRequest.ConsumerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{consumer_group_id}/deadletters/ack",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmDeadLettersMessagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ConfirmDeadLettersMessagesResponse>(response);
        }
        
        /// <summary>
        /// 消费死信消息
        ///
        /// 消费指定消费组产生的死信消息。可同时消费多条消息，每次消费的消息负载不超过512KB。
        /// 
        /// 仅NORMAL队列和FIFO队列可以开启死信消息，因为只有NORMAL队列和FIFO队列可消费死信消息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ConsumeDeadlettersMessageResponse> ConsumeDeadlettersMessageAsync(ConsumeDeadlettersMessageRequest consumeDeadlettersMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , consumeDeadlettersMessageRequest.QueueId.ToString());
            urlParam.Add("consumer_group_id" , consumeDeadlettersMessageRequest.ConsumerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{consumer_group_id}/deadletters",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", consumeDeadlettersMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ConsumeDeadlettersMessageResponse consumeDeadlettersMessageResponse = JsonUtils.DeSerializeNull<ConsumeDeadlettersMessageResponse>(response);
            consumeDeadlettersMessageResponse.Body = JsonUtils.DeSerializeList<ConsumeDeadlettersMessage>(response);
            return consumeDeadlettersMessageResponse;
        }
        
        /// <summary>
        /// 消费消息
        ///
        /// 消费指定队列中的消息。可同时消费多条消息，每次消费的消息负载不超过512KB。
        /// 
        /// 当队列中消息较少时，单次消费返回的消息数量可能会少于指定条数，但多次消费最终可获取全部消息，当队列为空时，返回为空。
        /// 
        /// 每个消费组只支持一种Label规则，如果第二次消费更换了Label规则，则消费失败。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ConsumeMessagesResponse> ConsumeMessagesAsync(ConsumeMessagesRequest consumeMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , consumeMessagesRequest.QueueId.ToString());
            urlParam.Add("consumer_group_id" , consumeMessagesRequest.ConsumerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{consumer_group_id}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", consumeMessagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ConsumeMessagesResponse consumeMessagesResponse = JsonUtils.DeSerializeNull<ConsumeMessagesResponse>(response);
            consumeMessagesResponse.Body = JsonUtils.DeSerializeList<ConsumeMessage>(response);
            return consumeMessagesResponse;
        }
        
        /// <summary>
        /// 创建消费组
        ///
        /// 创建消费组。
        /// 
        /// 可同时为指定队列创建多个消费组。
        /// 
        /// &gt; 创建消费组后系统内部完成初始化需要1-3秒，如果创建消费组后立即进行操作，可能会导致消费失败。建议3秒后再操作该队列。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupAsync(CreateConsumerGroupRequest createConsumerGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , createConsumerGroupRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConsumerGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateConsumerGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建队列
        ///
        /// 每个project_id默认只能创建30个队列。
        /// &gt; 创建队列时系统内部完成初始化需要1-3秒，如果创建队列后立即进行操作，可能会导致生产消息、消费消息、查询队列详情、创建消费组和删除队列等操作失败。建议3秒后再操作该队列。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest createQueueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createQueueRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateQueueResponse>(response);
        }
        
        /// <summary>
        /// 删除指定队列
        ///
        /// 删除指定的队列。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest deleteQueueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , deleteQueueRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQueueRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteQueueResponse>(response);
        }
        
        /// <summary>
        /// 删除指定消费组
        ///
        /// 删除指定消费组。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSpecifiedConsumerGroupResponse> DeleteSpecifiedConsumerGroupAsync(DeleteSpecifiedConsumerGroupRequest deleteSpecifiedConsumerGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , deleteSpecifiedConsumerGroupRequest.QueueId.ToString());
            urlParam.Add("group_id" , deleteSpecifiedConsumerGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSpecifiedConsumerGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSpecifiedConsumerGroupResponse>(response);
        }
        
        /// <summary>
        /// 查看指定队列的所有消费组
        ///
        /// 获取指定队列的所有消费组。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListConsumerGroupsResponse> ListConsumerGroupsAsync(ListConsumerGroupsRequest listConsumerGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , listConsumerGroupsRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumerGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListConsumerGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查看所有队列
        ///
        /// 查看所有队列。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest listQueuesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueuesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQueuesResponse>(response);
        }
        
        /// <summary>
        /// 向指定队列发送消息
        ///
        /// 向指定队列发送消息，可同时发送多条消息。
        /// 
        /// - 每次最多发送10条。
        /// - 每次发送的消息总负载不超过512KB。
        /// - Kafka队列的消息保存时间在创建队列时可以设置，可设置范围为1~72小时。其他队列的消息最大保存时长为72小时。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<SendMessagesResponse> SendMessagesAsync(SendMessagesRequest sendMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , sendMessagesRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendMessagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SendMessagesResponse>(response);
        }
        
        /// <summary>
        /// 查看指定队列
        ///
        /// 查看指定的队列。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQueueResponse> ShowQueueAsync(ShowQueueRequest showQueueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , showQueueRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQueueResponse>(response);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询项目标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQueueProjectTagsResponse> ShowQueueProjectTagsAsync(ShowQueueProjectTagsRequest showQueueProjectTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queue/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueProjectTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQueueProjectTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询队列标签
        ///
        /// 查询队列标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQueueTagsResponse> ShowQueueTagsAsync(ShowQueueTagsRequest showQueueTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , showQueueTagsRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queue/{queue_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQueueTagsResponse>(response);
        }
        
        /// <summary>
        /// 查看租户配额
        ///
        /// 查看当前项目的配额。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotasResponse> ShowQuotasAsync(ShowQuotasRequest showQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }
        
    }
}