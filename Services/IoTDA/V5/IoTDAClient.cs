using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.IoTDA.V5.Model;

namespace HuaweiCloud.SDK.IoTDA.V5
{
    public partial class IoTDAClient : Client
    {
        public static ClientBuilder<IoTDAClient> NewBuilder()
        {
            return new ClientBuilder<IoTDAClient>().WithDerivedAuthServiceName("iotdm");
        }

        
        /// <summary>
        /// 生成接入凭证
        ///
        /// 接入凭证是用于客户端使用AMQP等协议与平台建链的一个认证凭据。只保留一条记录，如果重复调用只会重置接入凭证，使得之前的失效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAccessCodeResponse CreateAccessCode(CreateAccessCodeRequest createAccessCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/auth/accesscode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessCodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAccessCodeResponse>(response);
        }

        public SyncInvoker<CreateAccessCodeResponse> CreateAccessCodeInvoker(CreateAccessCodeRequest createAccessCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/auth/accesscode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessCodeRequest);
            return new SyncInvoker<CreateAccessCodeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccessCodeResponse>);
        }
        
        /// <summary>
        /// 创建AMQP队列
        ///
        /// 应用服务器可调用此接口在物联网平台创建一个AMQP队列。每个租户只能创建100个队列，若超过规格，则创建失败，若队列名称与已有的队列名称相同，则创建失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddQueueResponse AddQueue(AddQueueRequest addQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addQueueRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddQueueResponse>(response);
        }

        public SyncInvoker<AddQueueResponse> AddQueueInvoker(AddQueueRequest addQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addQueueRequest);
            return new SyncInvoker<AddQueueResponse>(this, "POST", request, JsonUtils.DeSerialize<AddQueueResponse>);
        }
        
        /// <summary>
        /// 查询AMQP列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中的AMQP队列信息列表。可通过队列名称作模糊查询，支持分页。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchShowQueueResponse BatchShowQueue(BatchShowQueueRequest batchShowQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowQueueRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<BatchShowQueueResponse>(response);
        }

        public SyncInvoker<BatchShowQueueResponse> BatchShowQueueInvoker(BatchShowQueueRequest batchShowQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowQueueRequest);
            return new SyncInvoker<BatchShowQueueResponse>(this, "GET", request, JsonUtils.DeSerialize<BatchShowQueueResponse>);
        }
        
        /// <summary>
        /// 删除AMQP队列
        ///
        /// 应用服务器可调用此接口在物联网平台上删除指定AMQP队列。若当前队列正在使用，则会删除失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteQueueResponse DeleteQueue(DeleteQueueRequest deleteQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteQueueRequest.QueueId, out var valueOfQueueId)) urlParam.Add("queue_id", valueOfQueueId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues/{queue_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQueueRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteQueueResponse>(response);
        }

        public SyncInvoker<DeleteQueueResponse> DeleteQueueInvoker(DeleteQueueRequest deleteQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteQueueRequest.QueueId, out var valueOfQueueId)) urlParam.Add("queue_id", valueOfQueueId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues/{queue_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQueueRequest);
            return new SyncInvoker<DeleteQueueResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteQueueResponse>);
        }
        
        /// <summary>
        /// 查询单个AMQP队列
        ///
        /// 应用服务器可调用此接口查询物联网平台中指定队列的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQueueResponse ShowQueue(ShowQueueRequest showQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showQueueRequest.QueueId, out var valueOfQueueId)) urlParam.Add("queue_id", valueOfQueueId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues/{queue_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQueueResponse>(response);
        }

        public SyncInvoker<ShowQueueResponse> ShowQueueInvoker(ShowQueueRequest showQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showQueueRequest.QueueId, out var valueOfQueueId)) urlParam.Add("queue_id", valueOfQueueId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/amqp-queues/{queue_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueRequest);
            return new SyncInvoker<ShowQueueResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQueueResponse>);
        }
        
        /// <summary>
        /// 创建资源空间
        ///
        /// 资源空间对应的是物联网平台原有的应用，在物联网平台的含义与应用一致，只是变更了名称。应用服务器可以调用此接口创建资源空间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddApplicationResponse AddApplication(AddApplicationRequest addApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addApplicationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddApplicationResponse>(response);
        }

        public SyncInvoker<AddApplicationResponse> AddApplicationInvoker(AddApplicationRequest addApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addApplicationRequest);
            return new SyncInvoker<AddApplicationResponse>(this, "POST", request, JsonUtils.DeSerialize<AddApplicationResponse>);
        }
        
        /// <summary>
        /// 删除资源空间
        ///
        /// 删除指定资源空间。删除资源空间属于高危操作，删除资源空间后，该空间下的产品、设备等资源将不可用，请谨慎操作！
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest deleteApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteApplicationResponse>(response);
        }

        public SyncInvoker<DeleteApplicationResponse> DeleteApplicationInvoker(DeleteApplicationRequest deleteApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteApplicationRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            return new SyncInvoker<DeleteApplicationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteApplicationResponse>);
        }
        
        /// <summary>
        /// 查询资源空间
        ///
        /// 资源空间对应的是物联网平台原有的应用，在物联网平台的含义与应用一致，只是变更了名称。应用服务器可以调用此接口查询指定资源空间详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowApplicationResponse ShowApplication(ShowApplicationRequest showApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApplicationRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowApplicationResponse>(response);
        }

        public SyncInvoker<ShowApplicationResponse> ShowApplicationInvoker(ShowApplicationRequest showApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApplicationRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicationRequest);
            return new SyncInvoker<ShowApplicationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApplicationResponse>);
        }
        
        /// <summary>
        /// 查询资源空间列表
        ///
        /// 资源空间对应的是物联网平台原有的应用，在物联网平台的含义与应用一致，只是变更了名称。应用服务器可以调用此接口查询资源空间列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowApplicationsResponse ShowApplications(ShowApplicationsRequest showApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowApplicationsResponse>(response);
        }

        public SyncInvoker<ShowApplicationsResponse> ShowApplicationsInvoker(ShowApplicationsRequest showApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApplicationsRequest);
            return new SyncInvoker<ShowApplicationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApplicationsResponse>);
        }
        
        /// <summary>
        /// 更新资源空间
        ///
        /// 应用服务器可以调用此接口更新资源空间的名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest updateApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateApplicationResponse>(response);
        }

        public SyncInvoker<UpdateApplicationResponse> UpdateApplicationInvoker(UpdateApplicationRequest updateApplicationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateApplicationRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateApplicationRequest);
            return new SyncInvoker<UpdateApplicationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateApplicationResponse>);
        }
        
        /// <summary>
        /// 统计设备下的历史命令总数
        ///
        /// 统计设备下的历史命令总数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountAsyncHistoryCommandsResponse CountAsyncHistoryCommands(CountAsyncHistoryCommandsRequest countAsyncHistoryCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countAsyncHistoryCommandsRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands-history/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countAsyncHistoryCommandsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountAsyncHistoryCommandsResponse>(response);
        }

        public SyncInvoker<CountAsyncHistoryCommandsResponse> CountAsyncHistoryCommandsInvoker(CountAsyncHistoryCommandsRequest countAsyncHistoryCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countAsyncHistoryCommandsRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands-history/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countAsyncHistoryCommandsRequest);
            return new SyncInvoker<CountAsyncHistoryCommandsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountAsyncHistoryCommandsResponse>);
        }
        
        /// <summary>
        /// 下发异步设备命令
        ///
        /// 设备的产品模型中定义了物联网平台可向设备下发的命令，应用服务器可调用此接口向指定设备下发异步命令，以实现对设备的控制。平台负责将命令发送给设备，并将设备执行命令结果异步通知应用服务器。 命令执行结果支持灵活的数据流转，应用服务器通过调用物联网平台的创建规则触发条件（Resource:device.command.status，Event:update）、创建规则动作并激活规则后，当命令状态变更时，物联网平台会根据规则将结果发送到规则指定的服务器，如用户自定义的HTTP服务器，AMQP服务器，以及华为云的其他储存服务器等, 详情参考[[设备命令状态变更通知](https://support.huaweicloud.com/api-iothub/iot_06_v5_01212.html)](tag:hws)[[设备命令状态变更通知](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_01212.html)](tag:hws_hk)。
        /// 注意：
        /// - 此接口适用于NB设备异步命令下发，暂不支持其他协议类型设备命令下发。
        /// - 此接口仅支持单个设备异步命令下发，如需多个设备异步命令下发，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAsyncCommandResponse CreateAsyncCommand(CreateAsyncCommandRequest createAsyncCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAsyncCommandRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAsyncCommandRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAsyncCommandResponse>(response);
        }

        public SyncInvoker<CreateAsyncCommandResponse> CreateAsyncCommandInvoker(CreateAsyncCommandRequest createAsyncCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAsyncCommandRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAsyncCommandRequest);
            return new SyncInvoker<CreateAsyncCommandResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAsyncCommandResponse>);
        }
        
        /// <summary>
        /// 查询设备下队列中的命令
        ///
        /// 查询设备下队列中的命令（处理中的命令），包含PENDING、SENT、DELIVERED三种状态，注意：DELIVERED状态的命令经过系统设定的一段时间（具体以系统配置为准）仍然没有更新，就会从队列中移除，变为历史命令。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAsyncCommandsResponse ListAsyncCommands(ListAsyncCommandsRequest listAsyncCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAsyncCommandsRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncCommandsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAsyncCommandsResponse>(response);
        }

        public SyncInvoker<ListAsyncCommandsResponse> ListAsyncCommandsInvoker(ListAsyncCommandsRequest listAsyncCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAsyncCommandsRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncCommandsRequest);
            return new SyncInvoker<ListAsyncCommandsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAsyncCommandsResponse>);
        }
        
        /// <summary>
        /// 查询设备下的历史命令
        ///
        /// 查询设备下发的历史异步命令，包含EXPIRED、SUCCESSFUL、FAILED、TIMEOUT、DELIVERED五种状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAsyncHistoryCommandsResponse ListAsyncHistoryCommands(ListAsyncHistoryCommandsRequest listAsyncHistoryCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAsyncHistoryCommandsRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncHistoryCommandsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAsyncHistoryCommandsResponse>(response);
        }

        public SyncInvoker<ListAsyncHistoryCommandsResponse> ListAsyncHistoryCommandsInvoker(ListAsyncHistoryCommandsRequest listAsyncHistoryCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAsyncHistoryCommandsRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncHistoryCommandsRequest);
            return new SyncInvoker<ListAsyncHistoryCommandsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAsyncHistoryCommandsResponse>);
        }
        
        /// <summary>
        /// 查询指定id的命令
        ///
        /// 物联网平台可查询指定id的命令。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAsyncDeviceCommandResponse ShowAsyncDeviceCommand(ShowAsyncDeviceCommandRequest showAsyncDeviceCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAsyncDeviceCommandRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            if (StringUtils.TryConvertToNonEmptyString(showAsyncDeviceCommandRequest.CommandId, out var valueOfCommandId)) urlParam.Add("command_id", valueOfCommandId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands/{command_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAsyncDeviceCommandRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAsyncDeviceCommandResponse>(response);
        }

        public SyncInvoker<ShowAsyncDeviceCommandResponse> ShowAsyncDeviceCommandInvoker(ShowAsyncDeviceCommandRequest showAsyncDeviceCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAsyncDeviceCommandRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            if (StringUtils.TryConvertToNonEmptyString(showAsyncDeviceCommandRequest.CommandId, out var valueOfCommandId)) urlParam.Add("command_id", valueOfCommandId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/async-commands/{command_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAsyncDeviceCommandRequest);
            return new SyncInvoker<ShowAsyncDeviceCommandResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAsyncDeviceCommandResponse>);
        }
        
        /// <summary>
        /// 新建数据流转积压策略
        ///
        /// 应用服务器可调用此接口在物联网平台创建数据流转积压策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRoutingBacklogPolicyResponse CreateRoutingBacklogPolicy(CreateRoutingBacklogPolicyRequest createRoutingBacklogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/backlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRoutingBacklogPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRoutingBacklogPolicyResponse>(response);
        }

        public SyncInvoker<CreateRoutingBacklogPolicyResponse> CreateRoutingBacklogPolicyInvoker(CreateRoutingBacklogPolicyRequest createRoutingBacklogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/backlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRoutingBacklogPolicyRequest);
            return new SyncInvoker<CreateRoutingBacklogPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRoutingBacklogPolicyResponse>);
        }
        
        /// <summary>
        /// 删除数据流转积压策略
        ///
        /// 应用服务器可调用此接口在物联网平台删除指定数据流转积压策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRoutingBacklogPolicyResponse DeleteRoutingBacklogPolicy(DeleteRoutingBacklogPolicyRequest deleteRoutingBacklogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRoutingBacklogPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/backlog-policy/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRoutingBacklogPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRoutingBacklogPolicyResponse>(response);
        }

        public SyncInvoker<DeleteRoutingBacklogPolicyResponse> DeleteRoutingBacklogPolicyInvoker(DeleteRoutingBacklogPolicyRequest deleteRoutingBacklogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRoutingBacklogPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/backlog-policy/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRoutingBacklogPolicyRequest);
            return new SyncInvoker<DeleteRoutingBacklogPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRoutingBacklogPolicyResponse>);
        }
        
        /// <summary>
        /// 查询数据流转积压策略列表
        ///
        /// 应用服务器可调用此接口查询在物联网平台设置的数据流转积压策略列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRoutingBacklogPolicyResponse ListRoutingBacklogPolicy(ListRoutingBacklogPolicyRequest listRoutingBacklogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/backlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRoutingBacklogPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRoutingBacklogPolicyResponse>(response);
        }

        public SyncInvoker<ListRoutingBacklogPolicyResponse> ListRoutingBacklogPolicyInvoker(ListRoutingBacklogPolicyRequest listRoutingBacklogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/backlog-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRoutingBacklogPolicyRequest);
            return new SyncInvoker<ListRoutingBacklogPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRoutingBacklogPolicyResponse>);
        }
        
        /// <summary>
        /// 查询数据流转积压策略
        ///
        /// 应用服务器可调用此接口在物联网平台查询指定数据流转积压策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRoutingBacklogPolicyResponse ShowRoutingBacklogPolicy(ShowRoutingBacklogPolicyRequest showRoutingBacklogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRoutingBacklogPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/backlog-policy/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoutingBacklogPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRoutingBacklogPolicyResponse>(response);
        }

        public SyncInvoker<ShowRoutingBacklogPolicyResponse> ShowRoutingBacklogPolicyInvoker(ShowRoutingBacklogPolicyRequest showRoutingBacklogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRoutingBacklogPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/backlog-policy/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoutingBacklogPolicyRequest);
            return new SyncInvoker<ShowRoutingBacklogPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRoutingBacklogPolicyResponse>);
        }
        
        /// <summary>
        /// 修改数据流转积压策略
        ///
        /// 应用服务器可调用此接口在物联网平台修改指定数据流转积压策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRoutingBacklogPolicyResponse UpdateRoutingBacklogPolicy(UpdateRoutingBacklogPolicyRequest updateRoutingBacklogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRoutingBacklogPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/backlog-policy/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRoutingBacklogPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRoutingBacklogPolicyResponse>(response);
        }

        public SyncInvoker<UpdateRoutingBacklogPolicyResponse> UpdateRoutingBacklogPolicyInvoker(UpdateRoutingBacklogPolicyRequest updateRoutingBacklogPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRoutingBacklogPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/backlog-policy/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRoutingBacklogPolicyRequest);
            return new SyncInvoker<UpdateRoutingBacklogPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRoutingBacklogPolicyResponse>);
        }
        
        /// <summary>
        /// 创建批量任务
        ///
        /// 应用服务器可调用此接口为创建批量处理任务，对多个设备进行批量操作。当前支持批量软固件升级、批量创建设备、批量删除设备、批量冻结设备、批量解冻设备、批量创建命令、批量创建消息任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBatchTaskResponse CreateBatchTask(CreateBatchTaskRequest createBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBatchTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateBatchTaskResponse>(response);
        }

        public SyncInvoker<CreateBatchTaskResponse> CreateBatchTaskInvoker(CreateBatchTaskRequest createBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBatchTaskRequest);
            return new SyncInvoker<CreateBatchTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBatchTaskResponse>);
        }
        
        /// <summary>
        /// 删除批量任务
        ///
        /// 应用服务器可调用此接口删除物联网平台中已经完成（状态为成功，失败，部分成功，已停止）的批量任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBatchTaskResponse DeleteBatchTask(DeleteBatchTaskRequest deleteBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBatchTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBatchTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBatchTaskResponse>(response);
        }

        public SyncInvoker<DeleteBatchTaskResponse> DeleteBatchTaskInvoker(DeleteBatchTaskRequest deleteBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBatchTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBatchTaskRequest);
            return new SyncInvoker<DeleteBatchTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBatchTaskResponse>);
        }
        
        /// <summary>
        /// 查询批量任务列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中批量任务列表，每一个任务又包括具体的任务内容、任务状态、任务完成情况统计等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBatchTasksResponse ListBatchTasks(ListBatchTasksRequest listBatchTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBatchTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBatchTasksResponse>(response);
        }

        public SyncInvoker<ListBatchTasksResponse> ListBatchTasksInvoker(ListBatchTasksRequest listBatchTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBatchTasksRequest);
            return new SyncInvoker<ListBatchTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBatchTasksResponse>);
        }
        
        /// <summary>
        /// 重试批量任务
        ///
        /// 应用服务器可调用此接口重试批量任务，目前只支持task_type为firmwareUpgrade，softwareUpgrade。如果task_id对应任务已经成功、停止、正在停止、等待中或初始化中，则不可以调用该接口。如果请求Body为{}，则调用该接口后会重新执行所有状态为失败、失败待重试和已停止的子任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RetryBatchTaskResponse RetryBatchTask(RetryBatchTaskRequest retryBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryBatchTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryBatchTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RetryBatchTaskResponse>(response);
        }

        public SyncInvoker<RetryBatchTaskResponse> RetryBatchTaskInvoker(RetryBatchTaskRequest retryBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryBatchTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryBatchTaskRequest);
            return new SyncInvoker<RetryBatchTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<RetryBatchTaskResponse>);
        }
        
        /// <summary>
        /// 查询批量任务
        ///
        /// 应用服务器可调用此接口查询物联网平台中指定批量任务的信息，包括任务内容、任务状态、任务完成情况统计以及子任务列表等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBatchTaskResponse ShowBatchTask(ShowBatchTaskRequest showBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBatchTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBatchTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBatchTaskResponse>(response);
        }

        public SyncInvoker<ShowBatchTaskResponse> ShowBatchTaskInvoker(ShowBatchTaskRequest showBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBatchTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBatchTaskRequest);
            return new SyncInvoker<ShowBatchTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBatchTaskResponse>);
        }
        
        /// <summary>
        /// 停止批量任务
        ///
        /// 应用服务器可调用此接口停止批量任务，目前只支持task_type为firmwareUpgrade，softwareUpgrade。如果task_id对应任务已经完成（成功、失败、部分成功，已经停止）或正在停止中，则不可以调用该接口。如果请求Body为{}，则调用该接口后会停止所有正在执行中、等待中和失败待重试状态的子任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopBatchTaskResponse StopBatchTask(StopBatchTaskRequest stopBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopBatchTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBatchTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopBatchTaskResponse>(response);
        }

        public SyncInvoker<StopBatchTaskResponse> StopBatchTaskInvoker(StopBatchTaskRequest stopBatchTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopBatchTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtasks/{task_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBatchTaskRequest);
            return new SyncInvoker<StopBatchTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<StopBatchTaskResponse>);
        }
        
        /// <summary>
        /// 删除批量任务文件
        ///
        /// 应用服务器可调用此接口删除批量任务文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBatchTaskFileResponse DeleteBatchTaskFile(DeleteBatchTaskFileRequest deleteBatchTaskFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBatchTaskFileRequest.FileId, out var valueOfFileId)) urlParam.Add("file_id", valueOfFileId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files/{file_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBatchTaskFileRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBatchTaskFileResponse>(response);
        }

        public SyncInvoker<DeleteBatchTaskFileResponse> DeleteBatchTaskFileInvoker(DeleteBatchTaskFileRequest deleteBatchTaskFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBatchTaskFileRequest.FileId, out var valueOfFileId)) urlParam.Add("file_id", valueOfFileId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files/{file_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBatchTaskFileRequest);
            return new SyncInvoker<DeleteBatchTaskFileResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBatchTaskFileResponse>);
        }
        
        /// <summary>
        /// 查询批量任务文件列表
        ///
        /// 应用服务器可调用此接口查询批量任务文件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBatchTaskFilesResponse ListBatchTaskFiles(ListBatchTaskFilesRequest listBatchTaskFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBatchTaskFilesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBatchTaskFilesResponse>(response);
        }

        public SyncInvoker<ListBatchTaskFilesResponse> ListBatchTaskFilesInvoker(ListBatchTaskFilesRequest listBatchTaskFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBatchTaskFilesRequest);
            return new SyncInvoker<ListBatchTaskFilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBatchTaskFilesResponse>);
        }
        
        /// <summary>
        /// 上传批量任务文件
        ///
        /// 应用服务器可调用此接口上传批量任务文件，用于创建批量任务。当前支持批量创建设备任务、批量删除设备任务、批量冻结设备任务、批量解冻设备任务的文件上传。
        /// - [批量注册设备模板](https://developer.obs.cn-north-4.myhuaweicloud.com/template/BatchCreateDevices_Template.xlsx)
        /// 
        /// 
        /// - [批量删除设备模板](https://developer.obs.cn-north-4.myhuaweicloud.com/template/BatchDeleteDevices_Template.xlsx)
        /// 
        /// 
        /// - [批量冻结设备模板](https://developer.obs.cn-north-4.myhuaweicloud.com/template/BatchFreezeDevices_Template.xlsx)
        /// 
        /// 
        /// - [批量解冻设备模板](https://developer.obs.cn-north-4.myhuaweicloud.com/template/BatchUnfreezeDevices_Template.xlsx)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadBatchTaskFileResponse UploadBatchTaskFile(UploadBatchTaskFileRequest uploadBatchTaskFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadBatchTaskFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadBatchTaskFileResponse>(response);
        }

        public SyncInvoker<UploadBatchTaskFileResponse> UploadBatchTaskFileInvoker(UploadBatchTaskFileRequest uploadBatchTaskFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/batchtask-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadBatchTaskFileRequest);
            return new SyncInvoker<UploadBatchTaskFileResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadBatchTaskFileResponse>);
        }
        
        /// <summary>
        /// 创建网桥
        ///
        /// 应用服务器可调用此接口在物联网平台创建一个网桥，仅在创建后的网桥才可以接入物联网平台。
        /// - 一个实例最多支持20个网桥。
        /// - 仅**标准版实例、企业版实例**支持该接口调用，基础版不支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddBridgeResponse AddBridge(AddBridgeRequest addBridgeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/bridges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addBridgeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddBridgeResponse>(response);
        }

        public SyncInvoker<AddBridgeResponse> AddBridgeInvoker(AddBridgeRequest addBridgeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/bridges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addBridgeRequest);
            return new SyncInvoker<AddBridgeResponse>(this, "POST", request, JsonUtils.DeSerialize<AddBridgeResponse>);
        }
        
        /// <summary>
        /// 删除网桥
        ///
        /// 应用服务器可调用此接口在物联网平台上删除指定网桥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBridgeResponse DeleteBridge(DeleteBridgeRequest deleteBridgeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBridgeRequest.BridgeId, out var valueOfBridgeId)) urlParam.Add("bridge_id", valueOfBridgeId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/bridges/{bridge_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBridgeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBridgeResponse>(response);
        }

        public SyncInvoker<DeleteBridgeResponse> DeleteBridgeInvoker(DeleteBridgeRequest deleteBridgeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBridgeRequest.BridgeId, out var valueOfBridgeId)) urlParam.Add("bridge_id", valueOfBridgeId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/bridges/{bridge_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBridgeRequest);
            return new SyncInvoker<DeleteBridgeResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBridgeResponse>);
        }
        
        /// <summary>
        /// 查询网桥列表
        ///
        /// 应用服务器可调用此接口在物联网平台查询网桥列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBridgesResponse ListBridges(ListBridgesRequest listBridgesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/bridges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBridgesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBridgesResponse>(response);
        }

        public SyncInvoker<ListBridgesResponse> ListBridgesInvoker(ListBridgesRequest listBridgesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/bridges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBridgesRequest);
            return new SyncInvoker<ListBridgesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBridgesResponse>);
        }
        
        /// <summary>
        /// 重置网桥密钥
        ///
        /// 应用服务器可调用此接口在物联网平台上重置网桥密钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetBridgeSecretResponse ResetBridgeSecret(ResetBridgeSecretRequest resetBridgeSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetBridgeSecretRequest.BridgeId, out var valueOfBridgeId)) urlParam.Add("bridge_id", valueOfBridgeId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/bridges/{bridge_id}/reset-secret", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetBridgeSecretRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResetBridgeSecretResponse>(response);
        }

        public SyncInvoker<ResetBridgeSecretResponse> ResetBridgeSecretInvoker(ResetBridgeSecretRequest resetBridgeSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetBridgeSecretRequest.BridgeId, out var valueOfBridgeId)) urlParam.Add("bridge_id", valueOfBridgeId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/bridges/{bridge_id}/reset-secret", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetBridgeSecretRequest);
            return new SyncInvoker<ResetBridgeSecretResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetBridgeSecretResponse>);
        }
        
        /// <summary>
        /// 下发广播消息
        ///
        /// 应用服务器可调用此接口向订阅了指定Topic的所有在线设备发布广播消息。应用将广播消息下发给平台后，平台会先返回应用响应结果，再将消息广播给设备。
        /// 注意：
        /// - 此接口只适用于使用MQTT协议接入的设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BroadcastMessageResponse BroadcastMessage(BroadcastMessageRequest broadcastMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/broadcast-messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", broadcastMessageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BroadcastMessageResponse>(response);
        }

        public SyncInvoker<BroadcastMessageResponse> BroadcastMessageInvoker(BroadcastMessageRequest broadcastMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/broadcast-messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", broadcastMessageRequest);
            return new SyncInvoker<BroadcastMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<BroadcastMessageResponse>);
        }
        
        /// <summary>
        /// 上传设备CA证书
        ///
        /// 应用服务器可调用此接口在物联网平台上传设备CA证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddCertificateResponse AddCertificate(AddCertificateRequest addCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCertificateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddCertificateResponse>(response);
        }

        public SyncInvoker<AddCertificateResponse> AddCertificateInvoker(AddCertificateRequest addCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addCertificateRequest);
            return new SyncInvoker<AddCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<AddCertificateResponse>);
        }
        
        /// <summary>
        /// 验证设备CA证书
        ///
        /// 应用服务器可调用此接口在物联网平台验证设备的CA证书，目的是为了验证用户持有设备CA证书的私钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckCertificateResponse CheckCertificate(CheckCertificateRequest checkCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkCertificateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CheckCertificateResponse>(response);
        }

        public SyncInvoker<CheckCertificateResponse> CheckCertificateInvoker(CheckCertificateRequest checkCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkCertificateRequest);
            return new SyncInvoker<CheckCertificateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CheckCertificateResponse>);
        }
        
        /// <summary>
        /// 删除设备CA证书
        ///
        /// 应用服务器可调用此接口在物联网平台删除设备CA证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest deleteCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
        }

        public SyncInvoker<DeleteCertificateResponse> DeleteCertificateInvoker(DeleteCertificateRequest deleteCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            return new SyncInvoker<DeleteCertificateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCertificateResponse>);
        }
        
        /// <summary>
        /// 获取设备CA证书列表
        ///
        /// 应用服务器可调用此接口在物联网平台获取设备CA证书列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCertificatesResponse ListCertificates(ListCertificatesRequest listCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCertificatesResponse>(response);
        }

        public SyncInvoker<ListCertificatesResponse> ListCertificatesInvoker(ListCertificatesRequest listCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            return new SyncInvoker<ListCertificatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCertificatesResponse>);
        }
        
        /// <summary>
        /// 更新CA证书
        ///
        /// 应用服务器可调用此接口在物联网平台上更新CA证书。仅标准版实例、企业版实例支持该接口调用，基础版不支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCertificateResponse UpdateCertificate(UpdateCertificateRequest updateCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCertificateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCertificateResponse>(response);
        }

        public SyncInvoker<UpdateCertificateResponse> UpdateCertificateInvoker(UpdateCertificateRequest updateCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCertificateRequest);
            return new SyncInvoker<UpdateCertificateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCertificateResponse>);
        }
        
        /// <summary>
        /// 下发设备命令
        ///
        /// 设备的产品模型中定义了物联网平台可向设备下发的命令，应用服务器可调用此接口向指定设备下发命令，以实现对设备的同步控制。平台负责将命令以同步方式发送给设备，并将设备执行命令结果同步返回, 如果设备没有响应，平台会返回给应用服务器超时，平台超时时间是20秒。如果命令下发需要超过20秒，建议采用[[消息下发](https://support.huaweicloud.com/api-iothub/iot_06_v5_0059.html)](tag:hws)[[消息下发](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0059.html)](tag:hws_hk)。
        /// 注意：
        /// - 此接口适用于MQTT设备同步命令下发，暂不支持NB-IoT设备命令下发。
        /// - 此接口仅支持单个设备同步命令下发，如需多个设备同步命令下发，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCommandResponse CreateCommand(CreateCommandRequest createCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCommandRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommandRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCommandResponse>(response);
        }

        public SyncInvoker<CreateCommandResponse> CreateCommandInvoker(CreateCommandRequest createCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCommandRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommandRequest);
            return new SyncInvoker<CreateCommandResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCommandResponse>);
        }
        
        /// <summary>
        /// 创建设备鉴权模板
        ///
        /// 应用服务器可调用此接口在物联网平台创建一个设备鉴权模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDeviceAuthenticationTemplateResponse CreateDeviceAuthenticationTemplate(CreateDeviceAuthenticationTemplateRequest createDeviceAuthenticationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authentication-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeviceAuthenticationTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDeviceAuthenticationTemplateResponse>(response);
        }

        public SyncInvoker<CreateDeviceAuthenticationTemplateResponse> CreateDeviceAuthenticationTemplateInvoker(CreateDeviceAuthenticationTemplateRequest createDeviceAuthenticationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authentication-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeviceAuthenticationTemplateRequest);
            return new SyncInvoker<CreateDeviceAuthenticationTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDeviceAuthenticationTemplateResponse>);
        }
        
        /// <summary>
        /// 删除设备鉴权模板
        ///
        /// 应用服务器可调用此接口在物联网平台上删除指定设备鉴权模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDeviceAuthenticationTemplateResponse DeleteDeviceAuthenticationTemplate(DeleteDeviceAuthenticationTemplateRequest deleteDeviceAuthenticationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceAuthenticationTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authentication-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceAuthenticationTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDeviceAuthenticationTemplateResponse>(response);
        }

        public SyncInvoker<DeleteDeviceAuthenticationTemplateResponse> DeleteDeviceAuthenticationTemplateInvoker(DeleteDeviceAuthenticationTemplateRequest deleteDeviceAuthenticationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceAuthenticationTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authentication-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceAuthenticationTemplateRequest);
            return new SyncInvoker<DeleteDeviceAuthenticationTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDeviceAuthenticationTemplateResponse>);
        }
        
        /// <summary>
        /// 查询设备鉴权模板列表
        ///
        /// 应用服务器可调用此接口在物联网平台查询设备鉴权模板列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDeviceAuthenticationTemplatesResponse ListDeviceAuthenticationTemplates(ListDeviceAuthenticationTemplatesRequest listDeviceAuthenticationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authentication-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceAuthenticationTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDeviceAuthenticationTemplatesResponse>(response);
        }

        public SyncInvoker<ListDeviceAuthenticationTemplatesResponse> ListDeviceAuthenticationTemplatesInvoker(ListDeviceAuthenticationTemplatesRequest listDeviceAuthenticationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authentication-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceAuthenticationTemplatesRequest);
            return new SyncInvoker<ListDeviceAuthenticationTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDeviceAuthenticationTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询设备鉴权模板详情
        ///
        /// 应用服务器可调用此接口在物联网平台查询指定设备鉴权模板ID的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeviceAuthenticationTemplateResponse ShowDeviceAuthenticationTemplate(ShowDeviceAuthenticationTemplateRequest showDeviceAuthenticationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceAuthenticationTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authentication-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceAuthenticationTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceAuthenticationTemplateResponse>(response);
        }

        public SyncInvoker<ShowDeviceAuthenticationTemplateResponse> ShowDeviceAuthenticationTemplateInvoker(ShowDeviceAuthenticationTemplateRequest showDeviceAuthenticationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceAuthenticationTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authentication-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceAuthenticationTemplateRequest);
            return new SyncInvoker<ShowDeviceAuthenticationTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceAuthenticationTemplateResponse>);
        }
        
        /// <summary>
        /// 修改设备鉴权模板
        ///
        /// 应用服务器可调用此接口在物联网平台上修改指定设备鉴权模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDeviceAuthenticationTemplateResponse UpdateDeviceAuthenticationTemplate(UpdateDeviceAuthenticationTemplateRequest updateDeviceAuthenticationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceAuthenticationTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authentication-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceAuthenticationTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeviceAuthenticationTemplateResponse>(response);
        }

        public SyncInvoker<UpdateDeviceAuthenticationTemplateResponse> UpdateDeviceAuthenticationTemplateInvoker(UpdateDeviceAuthenticationTemplateRequest updateDeviceAuthenticationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceAuthenticationTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authentication-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceAuthenticationTemplateRequest);
            return new SyncInvoker<UpdateDeviceAuthenticationTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeviceAuthenticationTemplateResponse>);
        }
        
        /// <summary>
        /// 创建自定义鉴权
        ///
        /// 应用服务器可调用此接口在物联网平台创建一个自定义鉴权。自定义鉴权是指用户可以通过函数服务自定义实现鉴权逻辑，以对接入平台的设备进行身份认证。
        /// - 单个实例最大可配置10个自定义鉴权
        /// - 仅标准版实例、企业版实例支持该接口调用，基础版不支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDeviceAuthorizerResponse CreateDeviceAuthorizer(CreateDeviceAuthorizerRequest createDeviceAuthorizerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authorizers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeviceAuthorizerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDeviceAuthorizerResponse>(response);
        }

        public SyncInvoker<CreateDeviceAuthorizerResponse> CreateDeviceAuthorizerInvoker(CreateDeviceAuthorizerRequest createDeviceAuthorizerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authorizers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeviceAuthorizerRequest);
            return new SyncInvoker<CreateDeviceAuthorizerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDeviceAuthorizerResponse>);
        }
        
        /// <summary>
        /// 删除自定义鉴权
        ///
        /// 应用服务器可调用此接口在物联网平台上删除指定自定义鉴权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDeviceAuthorizerResponse DeleteDeviceAuthorizer(DeleteDeviceAuthorizerRequest deleteDeviceAuthorizerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceAuthorizerRequest.AuthorizerId, out var valueOfAuthorizerId)) urlParam.Add("authorizer_id", valueOfAuthorizerId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authorizers/{authorizer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceAuthorizerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDeviceAuthorizerResponse>(response);
        }

        public SyncInvoker<DeleteDeviceAuthorizerResponse> DeleteDeviceAuthorizerInvoker(DeleteDeviceAuthorizerRequest deleteDeviceAuthorizerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceAuthorizerRequest.AuthorizerId, out var valueOfAuthorizerId)) urlParam.Add("authorizer_id", valueOfAuthorizerId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authorizers/{authorizer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceAuthorizerRequest);
            return new SyncInvoker<DeleteDeviceAuthorizerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDeviceAuthorizerResponse>);
        }
        
        /// <summary>
        /// 查询自定义鉴权列表
        ///
        /// 应用服务器可调用此接口在物联网平台查询自定义鉴权列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDeviceAuthorizersResponse ListDeviceAuthorizers(ListDeviceAuthorizersRequest listDeviceAuthorizersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authorizers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceAuthorizersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDeviceAuthorizersResponse>(response);
        }

        public SyncInvoker<ListDeviceAuthorizersResponse> ListDeviceAuthorizersInvoker(ListDeviceAuthorizersRequest listDeviceAuthorizersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authorizers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceAuthorizersRequest);
            return new SyncInvoker<ListDeviceAuthorizersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDeviceAuthorizersResponse>);
        }
        
        /// <summary>
        /// 查询自定义鉴权详情
        ///
        /// 应用服务器可调用此接口在物联网平台查询指定自定义鉴权ID的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeviceAuthorizerResponse ShowDeviceAuthorizer(ShowDeviceAuthorizerRequest showDeviceAuthorizerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceAuthorizerRequest.AuthorizerId, out var valueOfAuthorizerId)) urlParam.Add("authorizer_id", valueOfAuthorizerId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authorizers/{authorizer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceAuthorizerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceAuthorizerResponse>(response);
        }

        public SyncInvoker<ShowDeviceAuthorizerResponse> ShowDeviceAuthorizerInvoker(ShowDeviceAuthorizerRequest showDeviceAuthorizerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceAuthorizerRequest.AuthorizerId, out var valueOfAuthorizerId)) urlParam.Add("authorizer_id", valueOfAuthorizerId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authorizers/{authorizer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceAuthorizerRequest);
            return new SyncInvoker<ShowDeviceAuthorizerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceAuthorizerResponse>);
        }
        
        /// <summary>
        /// 更新指定id的自定义鉴权
        ///
        /// 应用服务器可调用此接口在物联网平台更新指定id的自定义鉴权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDeviceAuthorizerResponse UpdateDeviceAuthorizer(UpdateDeviceAuthorizerRequest updateDeviceAuthorizerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceAuthorizerRequest.AuthorizerId, out var valueOfAuthorizerId)) urlParam.Add("authorizer_id", valueOfAuthorizerId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authorizers/{authorizer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceAuthorizerRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeviceAuthorizerResponse>(response);
        }

        public SyncInvoker<UpdateDeviceAuthorizerResponse> UpdateDeviceAuthorizerInvoker(UpdateDeviceAuthorizerRequest updateDeviceAuthorizerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceAuthorizerRequest.AuthorizerId, out var valueOfAuthorizerId)) urlParam.Add("authorizer_id", valueOfAuthorizerId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-authorizers/{authorizer_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceAuthorizerRequest);
            return new SyncInvoker<UpdateDeviceAuthorizerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeviceAuthorizerResponse>);
        }
        
        /// <summary>
        /// 删除设备证书
        ///
        /// 应用服务器可调用此接口在物联网平台删除一个设备证书。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDeviceCertificateResponse DeleteDeviceCertificate(DeleteDeviceCertificateRequest deleteDeviceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceCertificateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDeviceCertificateResponse>(response);
        }

        public SyncInvoker<DeleteDeviceCertificateResponse> DeleteDeviceCertificateInvoker(DeleteDeviceCertificateRequest deleteDeviceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceCertificateRequest);
            return new SyncInvoker<DeleteDeviceCertificateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDeviceCertificateResponse>);
        }
        
        /// <summary>
        /// 查询使用指定设备证书的设备列表
        ///
        /// 应用服务器可调用此接口在物联网平台查询使用指定设备证书的设备列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDeviceByDeviceCertificateResponse ListDeviceByDeviceCertificate(ListDeviceByDeviceCertificateRequest listDeviceByDeviceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDeviceByDeviceCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-certificates/{certificate_id}/list-device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceByDeviceCertificateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListDeviceByDeviceCertificateResponse>(response);
        }

        public SyncInvoker<ListDeviceByDeviceCertificateResponse> ListDeviceByDeviceCertificateInvoker(ListDeviceByDeviceCertificateRequest listDeviceByDeviceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDeviceByDeviceCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-certificates/{certificate_id}/list-device", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceByDeviceCertificateRequest);
            return new SyncInvoker<ListDeviceByDeviceCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<ListDeviceByDeviceCertificateResponse>);
        }
        
        /// <summary>
        /// 查询设备证书列表
        ///
        /// 应用服务器可调用此接口在物联网平台查询设备证书列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDeviceCertificateResponse ListDeviceCertificate(ListDeviceCertificateRequest listDeviceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceCertificateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDeviceCertificateResponse>(response);
        }

        public SyncInvoker<ListDeviceCertificateResponse> ListDeviceCertificateInvoker(ListDeviceCertificateRequest listDeviceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceCertificateRequest);
            return new SyncInvoker<ListDeviceCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDeviceCertificateResponse>);
        }
        
        /// <summary>
        /// 查询设备证书
        ///
        /// 应用服务器可调用此接口在物联网平台更新一个设备证书状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeviceCertificateResponse ShowDeviceCertificate(ShowDeviceCertificateRequest showDeviceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceCertificateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceCertificateResponse>(response);
        }

        public SyncInvoker<ShowDeviceCertificateResponse> ShowDeviceCertificateInvoker(ShowDeviceCertificateRequest showDeviceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceCertificateRequest);
            return new SyncInvoker<ShowDeviceCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceCertificateResponse>);
        }
        
        /// <summary>
        /// 更新设备证书
        ///
        /// 应用服务器可调用此接口在物联网平台更新一个设备证书状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDeviceCertificateResponse UpdateDeviceCertificate(UpdateDeviceCertificateRequest updateDeviceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceCertificateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeviceCertificateResponse>(response);
        }

        public SyncInvoker<UpdateDeviceCertificateResponse> UpdateDeviceCertificateInvoker(UpdateDeviceCertificateRequest updateDeviceCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceCertificateRequest.CertificateId, out var valueOfCertificateId)) urlParam.Add("certificate_id", valueOfCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-certificates/{certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceCertificateRequest);
            return new SyncInvoker<UpdateDeviceCertificateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeviceCertificateResponse>);
        }
        
        /// <summary>
        /// 添加设备组
        ///
        /// 应用服务器可调用此接口新建设备组，一个华为云账号下最多可有1,000个设备组，包括父设备组和子设备组。设备组的最大层级关系不超过5层，即群组形成的关系树最大深度不超过5。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDeviceGroupResponse AddDeviceGroup(AddDeviceGroupRequest addDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDeviceGroupResponse>(response);
        }

        public SyncInvoker<AddDeviceGroupResponse> AddDeviceGroupInvoker(AddDeviceGroupRequest addDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceGroupRequest);
            return new SyncInvoker<AddDeviceGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDeviceGroupResponse>);
        }
        
        /// <summary>
        /// 管理设备组中的设备
        ///
        /// 应用服务器可调用此接口管理设备组中的设备。单个设备组内最多添加20,000个设备，一个设备最多可以被添加到10个设备组中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOrDeleteDeviceInGroupResponse CreateOrDeleteDeviceInGroup(CreateOrDeleteDeviceInGroupRequest createOrDeleteDeviceInGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrDeleteDeviceInGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrDeleteDeviceInGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateOrDeleteDeviceInGroupResponse>(response);
        }

        public SyncInvoker<CreateOrDeleteDeviceInGroupResponse> CreateOrDeleteDeviceInGroupInvoker(CreateOrDeleteDeviceInGroupRequest createOrDeleteDeviceInGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createOrDeleteDeviceInGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrDeleteDeviceInGroupRequest);
            return new SyncInvoker<CreateOrDeleteDeviceInGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateOrDeleteDeviceInGroupResponse>);
        }
        
        /// <summary>
        /// 删除设备组
        ///
        /// 应用服务器可调用此接口删除指定设备组，如果该设备组存在子设备组或者该设备组中存在设备，必须先删除子设备组并将设备从该设备组移除，才能删除该设备组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDeviceGroupResponse DeleteDeviceGroup(DeleteDeviceGroupRequest deleteDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDeviceGroupResponse>(response);
        }

        public SyncInvoker<DeleteDeviceGroupResponse> DeleteDeviceGroupInvoker(DeleteDeviceGroupRequest deleteDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceGroupRequest);
            return new SyncInvoker<DeleteDeviceGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDeviceGroupResponse>);
        }
        
        /// <summary>
        /// 查询设备组列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中的设备组信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDeviceGroupsResponse ListDeviceGroups(ListDeviceGroupsRequest listDeviceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDeviceGroupsResponse>(response);
        }

        public SyncInvoker<ListDeviceGroupsResponse> ListDeviceGroupsInvoker(ListDeviceGroupsRequest listDeviceGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceGroupsRequest);
            return new SyncInvoker<ListDeviceGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDeviceGroupsResponse>);
        }
        
        /// <summary>
        /// 查询设备组
        ///
        /// 应用服务器可调用此接口查询指定设备组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeviceGroupResponse ShowDeviceGroup(ShowDeviceGroupRequest showDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceGroupResponse>(response);
        }

        public SyncInvoker<ShowDeviceGroupResponse> ShowDeviceGroupInvoker(ShowDeviceGroupRequest showDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceGroupRequest);
            return new SyncInvoker<ShowDeviceGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceGroupResponse>);
        }
        
        /// <summary>
        /// 查询设备组设备列表
        ///
        /// 应用服务器可调用此接口查询指定设备组下的设备列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDevicesInGroupResponse ShowDevicesInGroup(ShowDevicesInGroupRequest showDevicesInGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDevicesInGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}/devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDevicesInGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDevicesInGroupResponse>(response);
        }

        public SyncInvoker<ShowDevicesInGroupResponse> ShowDevicesInGroupInvoker(ShowDevicesInGroupRequest showDevicesInGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDevicesInGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}/devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDevicesInGroupRequest);
            return new SyncInvoker<ShowDevicesInGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDevicesInGroupResponse>);
        }
        
        /// <summary>
        /// 修改设备组
        ///
        /// 应用服务器可调用此接口修改物联网平台中指定设备组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDeviceGroupResponse UpdateDeviceGroup(UpdateDeviceGroupRequest updateDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeviceGroupResponse>(response);
        }

        public SyncInvoker<UpdateDeviceGroupResponse> UpdateDeviceGroupInvoker(UpdateDeviceGroupRequest updateDeviceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-group/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceGroupRequest);
            return new SyncInvoker<UpdateDeviceGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeviceGroupResponse>);
        }
        
        /// <summary>
        /// 创建设备
        ///
        /// 应用服务器可调用此接口在物联网平台创建一个设备，仅在创建后设备才可以接入物联网平台。
        /// 
        /// - 该接口支持使用gateway_id参数指定在父设备下创建一个子设备，并且支持多级子设备，当前最大支持二级子设备。
        /// - 该接口同时还支持对设备进行初始配置，接口会读取创建设备请求参数product_id对应的产品详情，如果产品的属性有定义默认值，则会将该属性默认值写入该设备的设备影子中。
        /// - 用户还可以使用创建设备请求参数shadow字段为设备指定初始配置，指定后将会根据service_id和desired设置的属性值与产品中对应属性的默认值比对，如果不同，则将以shadow字段中设置的属性值为准写入到设备影子中。
        /// - 该接口仅支持创建单个设备，如需批量注册设备，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDeviceResponse AddDevice(AddDeviceRequest addDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDeviceResponse>(response);
        }

        public SyncInvoker<AddDeviceResponse> AddDeviceInvoker(AddDeviceRequest addDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeviceRequest);
            return new SyncInvoker<AddDeviceResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDeviceResponse>);
        }
        
        /// <summary>
        /// 修改设备网关
        ///
        /// 应用服务器可调用此接口在物联网平台修改子设备网关。
        /// - 只允许子设备修改网关。
        /// - 目标网关必须和当前设备在同一个资源空间。
        /// - 网关id不能和当前子设备网关id相同。
        /// - 设备如果有下级子设备，则不允许切换网关。
        /// - 支持多级子设备，当前最大支持二级子设备。
        /// - 该接口仅支持创建单个设备切换网关，如需批量切换设备网关，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeGatewayResponse ChangeGateway(ChangeGatewayRequest changeGatewayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeGatewayRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/change-gateway", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeGatewayRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ChangeGatewayResponse>(response);
        }

        public SyncInvoker<ChangeGatewayResponse> ChangeGatewayInvoker(ChangeGatewayRequest changeGatewayRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeGatewayRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/change-gateway", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeGatewayRequest);
            return new SyncInvoker<ChangeGatewayResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ChangeGatewayResponse>);
        }
        
        /// <summary>
        /// 删除设备
        ///
        /// 应用服务器可调用此接口在物联网平台上删除指定设备。若设备下连接了非直连设备，则必须把设备下的非直连设备都删除后，才能删除该设备。该接口仅支持删除单个设备，如需批量删除设备，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest deleteDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDeviceResponse>(response);
        }

        public SyncInvoker<DeleteDeviceResponse> DeleteDeviceInvoker(DeleteDeviceRequest deleteDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceRequest);
            return new SyncInvoker<DeleteDeviceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDeviceResponse>);
        }
        
        /// <summary>
        /// 冻结设备
        ///
        /// 应用服务器可调用此接口冻结设备，设备冻结后不能再连接上线，可以通过解冻设备接口解除设备冻结。注意，当前仅支持冻结与平台直连的设备。该接口仅支持冻结单个设备，如需批量冻结设备，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public FreezeDeviceResponse FreezeDevice(FreezeDeviceRequest freezeDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(freezeDeviceRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/freeze", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", freezeDeviceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<FreezeDeviceResponse>(response);
        }

        public SyncInvoker<FreezeDeviceResponse> FreezeDeviceInvoker(FreezeDeviceRequest freezeDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(freezeDeviceRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/freeze", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", freezeDeviceRequest);
            return new SyncInvoker<FreezeDeviceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<FreezeDeviceResponse>);
        }
        
        /// <summary>
        /// 查询指定设备加入的设备组列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中的某个设备加入的设备组信息列表。仅标准版实例、企业版实例支持该接口调用，基础版不支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDeviceGroupsByDeviceResponse ListDeviceGroupsByDevice(ListDeviceGroupsByDeviceRequest listDeviceGroupsByDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDeviceGroupsByDeviceRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/list-device-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceGroupsByDeviceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListDeviceGroupsByDeviceResponse>(response);
        }

        public SyncInvoker<ListDeviceGroupsByDeviceResponse> ListDeviceGroupsByDeviceInvoker(ListDeviceGroupsByDeviceRequest listDeviceGroupsByDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDeviceGroupsByDeviceRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/list-device-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceGroupsByDeviceRequest);
            return new SyncInvoker<ListDeviceGroupsByDeviceResponse>(this, "POST", request, JsonUtils.DeSerialize<ListDeviceGroupsByDeviceResponse>);
        }
        
        /// <summary>
        /// 查询设备列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中的设备信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDevicesResponse ListDevices(ListDevicesRequest listDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevicesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDevicesResponse>(response);
        }

        public SyncInvoker<ListDevicesResponse> ListDevicesInvoker(ListDevicesRequest listDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevicesRequest);
            return new SyncInvoker<ListDevicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDevicesResponse>);
        }
        
        /// <summary>
        /// 重置设备密钥
        ///
        /// 应用服务器可调用此接口重置设备密钥，携带指定密钥时平台将设备密钥重置为指定的密钥，不携带密钥时平台将自动生成一个新的随机密钥返回。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetDeviceSecretResponse ResetDeviceSecret(ResetDeviceSecretRequest resetDeviceSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetDeviceSecretRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDeviceSecretRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResetDeviceSecretResponse>(response);
        }

        public SyncInvoker<ResetDeviceSecretResponse> ResetDeviceSecretInvoker(ResetDeviceSecretRequest resetDeviceSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetDeviceSecretRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetDeviceSecretRequest);
            return new SyncInvoker<ResetDeviceSecretResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetDeviceSecretResponse>);
        }
        
        /// <summary>
        /// 重置设备指纹
        ///
        /// 应用服务器可调用此接口重置设备指纹。携带指定设备指纹时将之重置为指定值；不携带时将之置空，后续设备第一次接入时，该设备指纹的值将设置为第一次接入时的证书指纹。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetFingerprintResponse ResetFingerprint(ResetFingerprintRequest resetFingerprintRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetFingerprintRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/reset-fingerprint", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetFingerprintRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResetFingerprintResponse>(response);
        }

        public SyncInvoker<ResetFingerprintResponse> ResetFingerprintInvoker(ResetFingerprintRequest resetFingerprintRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetFingerprintRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/reset-fingerprint", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetFingerprintRequest);
            return new SyncInvoker<ResetFingerprintResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetFingerprintResponse>);
        }
        
        /// <summary>
        /// 灵活搜索设备列表
        ///
        /// #### 接口说明
        /// 
        /// 应用服务器使用SQL语句调用该接口，灵活的搜索所需要的设备资源列表
        /// 
        /// #### 限制
        /// 
        /// - 仅**标准版实例、企业版实例**支持该接口调用，基础版不支持。
        /// - 单账号调用该接口的 TPS 限制最大为1/S(每秒1次请求数)
        /// 
        /// #### 类SQL语法使用说明
        /// 
        /// 类SQL语句有select、from、where(可选)、order by(可选)、limit子句(可选)组成，长度限制为400个字符。子句里的内容大小写敏感，SQL语句的关键字大小写不敏感。
        /// 
        /// 示例：
        /// 
        /// &#x60;&#x60;&#x60;
        /// select * from device where device_id &#x3D; &#39;as********&#39; limit 0,5
        /// &#x60;&#x60;&#x60;
        /// 
        /// ##### SELECT子句
        /// 
        /// &#x60;&#x60;&#x60;
        /// select [field]/[count(*)/count(1)] from device
        /// &#x60;&#x60;&#x60;
        /// 
        /// 其中field为需要获取的字段，请参考响应参数字段名称，也可填*，获取所有字段。
        /// 
        /// 如果需要统计搜索的设备个数，请填count(*)或者count(1).
        /// 
        /// ##### FROM子句
        /// 
        /// &#x60;&#x60;&#x60;
        /// from device
        /// &#x60;&#x60;&#x60;
        /// 
        /// from后为要查询的资源名，当前支持\&quot;device\&quot;
        /// 
        /// ##### WHERE子句(可选)
        /// 
        /// &#x60;&#x60;&#x60;
        /// WHERE [condition1] AND [condition2]
        /// &#x60;&#x60;&#x60;
        /// 
        /// 最多支持5个condition，不支持嵌套；支持的检索字段请参见下面的**搜索条件字段说明**和**支持的运算符**章节
        /// 
        /// 连接词支持AND、OR，优先级参考标准SQL语法，默认AND优先级高于OR。
        /// 
        /// ##### LIMIT子句(可选)
        /// 
        /// &#x60;&#x60;&#x60;
        /// limit [offset,] rows
        /// &#x60;&#x60;&#x60;
        /// 
        /// offset标识搜索的偏移量，rows标识返回搜索结果的最大行数，例如：
        /// 
        /// - limit n ;示例(select * from device limit 10)
        /// 
        ///   最大返回n条结果数据
        ///   
        /// - limit m,n; 示例(select * from device limit 20,10) 
        ///   搜索偏移量为m，最大返回n条结果数据
        /// 
        /// ###### 限制
        /// 
        ///  offset 最大 500， rows最大50，如果不填写limit子句，默认为limit 10
        /// 
        /// ##### ORDER BY子句(可选)
        /// 
        /// 用于实现自定义排序，当前支持自定义排序的字段为：\&quot;marker\&quot;。
        /// 
        /// &#x60;&#x60;&#x60;
        /// order by marker [asc]/[desc]
        /// &#x60;&#x60;&#x60;
        /// 
        /// 子句不填写时默认逻辑为随机排序
        /// 
        /// #### 搜索条件字段说明
        /// 
        /// | 字段名      | 类型   | 说明             | 取值范围                                                     |
        /// | :- -- -- -- -- - | :- -- -- | :- -- -- -- -- -- -- -- | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |
        /// | app_id      | string | 资源空间ID       | 长度不超过36，只允许字母、数字、下划线（_）、连接符（-）的组合。 |
        /// | device_id   | string | 设备ID           | 长度不超过128，只允许字母、数字、下划线（_）、连接符（-）的组合。 |
        /// | gateway_id  | string | 网关ID           | 长度不超过128，只允许字母、数字、下划线（_）、连接符（-）的组合。 |
        /// | product_id  | string | 设备关联的产品ID | 长度不超过36，只允许字母、数字、下划线（_）、连接符（-）的组合。 |
        /// | device_name | string | 设备名称         | 长度不超过256，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-等字符的组合符。 |
        /// | node_id     | string | 设备标识码       | 长度不超过64，只允许字母、数字、下划线（_）、连接符（-）的组合 |
        /// | status      | string | 设备的状态       | ONLINE(在线)、OFFLINE(离线)、ABNORMAL(异常)、INACTIVE(未激活)、FROZEN(冻结) |
        /// | node_type   | string | 设备节点类型     | GATEWAY(直连设备或网关)、ENDPOINT(非直连设备)                |
        /// | tag_key     | string | 标签键           | 长度不超过64，只允许中文、字母、数字、以及_.-等字符的组合。  |
        /// | tag_value   | string | 标签值           | 长度不超过128，只允许中文、字母、数字、以及_.-等字符的组合。 |
        /// | sw_version  | string | 软件版本         | 长度不超过64，只允许字母、数字、下划线（_）、连接符（-）、英文点(.)的组合。 |
        /// | fw_version  | string | 固件版本         | 长度不超过64，只允许字母、数字、下划线（_）、连接符（-）、英文点(.)的组合。 |
        /// | group_id    | string | 群组Id           | 长度不超过36，十六进制字符串和连接符（-）的组合              |
        /// | create_time | string | 设备注册时间     | 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;，如：2015-06-06T12:10:10.000Z |
        /// | marker      | string | 结果记录ID       | 长度为24的十六进制字符串，如ffffffffffffffffffffffff         |
        /// 
        /// #### 支持的运算符
        /// 
        /// | 运算符  | 支持的字段                               |
        /// | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - |
        /// | &#x3D;       | 所有                                     |
        /// | !&#x3D;      | 所有                                     |
        /// | &gt;       | create_time、marker                      |
        /// | &lt;       | create_time、marker                      |
        /// | like    | device_name、node_id、tag_key、tag_value |
        /// | in      | 除tag_key、tag_value以外字段             |
        /// | not  in | 除tag_key、tag_value以外字段             |
        /// 
        /// #### SQL 限制
        /// 
        /// - like: 只支持前缀匹配，不支持后缀匹配或者通配符匹配。前缀匹配不得少于4个字符，且不能包含任何特殊字符(只允许中文、字母、数字、下划线（_）、连接符（-）). 前缀后必须跟上\&quot;%\&quot;结尾。
        /// - 不支持除了count(*)/count(1)以外的其他任何函数。
        /// - 不支持其他SQL用法，如嵌套SQL、union、join、别名(Alias)等用法
        /// - SQL长度限制为400个字符，单个请求条件最大支持5个。
        /// - 不支持\&quot;null\&quot;和空字符串等条件值匹配
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchDevicesResponse SearchDevices(SearchDevicesRequest searchDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/search/query-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDevicesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchDevicesResponse>(response);
        }

        public SyncInvoker<SearchDevicesResponse> SearchDevicesInvoker(SearchDevicesRequest searchDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/search/query-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDevicesRequest);
            return new SyncInvoker<SearchDevicesResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchDevicesResponse>);
        }
        
        /// <summary>
        /// 查询设备
        ///
        /// 应用服务器可调用此接口查询物联网平台中指定设备的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeviceResponse ShowDevice(ShowDeviceRequest showDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceResponse>(response);
        }

        public SyncInvoker<ShowDeviceResponse> ShowDeviceInvoker(ShowDeviceRequest showDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceRequest);
            return new SyncInvoker<ShowDeviceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceResponse>);
        }
        
        /// <summary>
        /// 解冻设备
        ///
        /// 应用服务器可调用此接口解冻设备，解除冻结后，设备可以连接上线。该接口仅支持解冻单个设备，如需批量解冻设备，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnfreezeDeviceResponse UnfreezeDevice(UnfreezeDeviceRequest unfreezeDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unfreezeDeviceRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/unfreeze", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unfreezeDeviceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UnfreezeDeviceResponse>(response);
        }

        public SyncInvoker<UnfreezeDeviceResponse> UnfreezeDeviceInvoker(UnfreezeDeviceRequest unfreezeDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unfreezeDeviceRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/unfreeze", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unfreezeDeviceRequest);
            return new SyncInvoker<UnfreezeDeviceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UnfreezeDeviceResponse>);
        }
        
        /// <summary>
        /// 修改设备
        ///
        /// 应用服务器可调用此接口修改物联网平台中指定设备的基本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDeviceResponse UpdateDevice(UpdateDeviceRequest updateDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeviceResponse>(response);
        }

        public SyncInvoker<UpdateDeviceResponse> UpdateDeviceInvoker(UpdateDeviceRequest updateDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceRequest);
            return new SyncInvoker<UpdateDeviceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeviceResponse>);
        }
        
        /// <summary>
        /// 创建设备代理
        ///
        /// 应用服务器可调用此接口在物联网平台创建一个动态设备代理规则，用于子设备自主选择网关设备上线和上报消息，即代理组下的任意网关下的子设备均可以通过代理组里其他设备上线([[网关更新子设备状态](https://support.huaweicloud.com/api-iothub/iot_06_v5_3022.html)](tag:hws) [[网关更新子设备状态](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_3022.html)](tag:hws_hk))然后进行数据上报([[网关批量设备属性上报](https://support.huaweicloud.com/api-iothub/iot_06_v5_3006.html)](tag:hws) [[网关更新子设备状态](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_3006.html)](tag:hws_hk))。
        /// - 单实例最多可以配置10个设备代理
        /// - 单账号调用该接口的 TPS 限制最大为1/S(每秒1次请求数)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDeviceProxyResponse CreateDeviceProxy(CreateDeviceProxyRequest createDeviceProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-proxies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeviceProxyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDeviceProxyResponse>(response);
        }

        public SyncInvoker<CreateDeviceProxyResponse> CreateDeviceProxyInvoker(CreateDeviceProxyRequest createDeviceProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-proxies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeviceProxyRequest);
            return new SyncInvoker<CreateDeviceProxyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDeviceProxyResponse>);
        }
        
        /// <summary>
        /// 删除设备代理
        ///
        /// 应用服务器可调用此接口在物联网平台上删除指定设备代理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDeviceProxyResponse DeleteDeviceProxy(DeleteDeviceProxyRequest deleteDeviceProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceProxyRequest.ProxyId, out var valueOfProxyId)) urlParam.Add("proxy_id", valueOfProxyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-proxies/{proxy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceProxyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDeviceProxyResponse>(response);
        }

        public SyncInvoker<DeleteDeviceProxyResponse> DeleteDeviceProxyInvoker(DeleteDeviceProxyRequest deleteDeviceProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceProxyRequest.ProxyId, out var valueOfProxyId)) urlParam.Add("proxy_id", valueOfProxyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-proxies/{proxy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceProxyRequest);
            return new SyncInvoker<DeleteDeviceProxyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDeviceProxyResponse>);
        }
        
        /// <summary>
        /// 查询设备代理列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中的设备代理列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDeviceProxiesResponse ListDeviceProxies(ListDeviceProxiesRequest listDeviceProxiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-proxies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceProxiesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDeviceProxiesResponse>(response);
        }

        public SyncInvoker<ListDeviceProxiesResponse> ListDeviceProxiesInvoker(ListDeviceProxiesRequest listDeviceProxiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-proxies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceProxiesRequest);
            return new SyncInvoker<ListDeviceProxiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDeviceProxiesResponse>);
        }
        
        /// <summary>
        /// 查询设备代理详情
        ///
        /// 应用服务器可调用此接口查询物联网平台中指定设备代理的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeviceProxyResponse ShowDeviceProxy(ShowDeviceProxyRequest showDeviceProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceProxyRequest.ProxyId, out var valueOfProxyId)) urlParam.Add("proxy_id", valueOfProxyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-proxies/{proxy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceProxyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceProxyResponse>(response);
        }

        public SyncInvoker<ShowDeviceProxyResponse> ShowDeviceProxyInvoker(ShowDeviceProxyRequest showDeviceProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceProxyRequest.ProxyId, out var valueOfProxyId)) urlParam.Add("proxy_id", valueOfProxyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-proxies/{proxy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceProxyRequest);
            return new SyncInvoker<ShowDeviceProxyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceProxyResponse>);
        }
        
        /// <summary>
        /// 修改设备代理
        ///
        /// 应用服务器可调用此接口修改物联网平台中指定设备代理的基本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDeviceProxyResponse UpdateDeviceProxy(UpdateDeviceProxyRequest updateDeviceProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceProxyRequest.ProxyId, out var valueOfProxyId)) urlParam.Add("proxy_id", valueOfProxyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-proxies/{proxy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceProxyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeviceProxyResponse>(response);
        }

        public SyncInvoker<UpdateDeviceProxyResponse> UpdateDeviceProxyInvoker(UpdateDeviceProxyRequest updateDeviceProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceProxyRequest.ProxyId, out var valueOfProxyId)) urlParam.Add("proxy_id", valueOfProxyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-proxies/{proxy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceProxyRequest);
            return new SyncInvoker<UpdateDeviceProxyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeviceProxyResponse>);
        }
        
        /// <summary>
        /// 删除设备影子数据
        ///
        /// 应用服务器可调用此接口删除指定设备的设备影子信息，包括对设备的期望属性信息（desired区）和设备最新上报的属性信息（reported区）中的所有数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDeviceShadowResponse DeleteDeviceShadow(DeleteDeviceShadowRequest deleteDeviceShadowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceShadowRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceShadowRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDeviceShadowResponse>(response);
        }

        public SyncInvoker<DeleteDeviceShadowResponse> DeleteDeviceShadowInvoker(DeleteDeviceShadowRequest deleteDeviceShadowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceShadowRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceShadowRequest);
            return new SyncInvoker<DeleteDeviceShadowResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDeviceShadowResponse>);
        }
        
        /// <summary>
        /// 查询设备影子数据
        ///
        /// 应用服务器可调用此接口查询指定设备的设备影子信息，包括对设备的期望属性信息（desired区）和设备最新上报的属性信息（reported区）。
        /// 
        /// 设备影子介绍：
        /// 设备影子是一个用于存储和检索设备当前状态信息的JSON文档。
        /// - 每个设备有且只有一个设备影子，由设备ID唯一标识
        /// - 设备影子用于存储设备上报的(状态)属性和应用程序期望的设备(状态)属性
        /// - 无论该设备是否在线，都可以通过该影子获取和设置设备的属性
        /// - 设备上线或者设备上报属性时，如果desired区和reported区存在差异，则将差异部分下发给设备，配置的预期属性需在产品模型中定义且method具有可写属性“W”才可下发
        /// 
        /// 限制：
        /// 设备影子JSON文档中的key不允许特殊字符：点(.)、dollar符号($)、空char(十六进制的ASCII码为00)。如果包含了以上特殊字符则无法正常刷新影子文档。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeviceShadowResponse ShowDeviceShadow(ShowDeviceShadowRequest showDeviceShadowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceShadowRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceShadowRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceShadowResponse>(response);
        }

        public SyncInvoker<ShowDeviceShadowResponse> ShowDeviceShadowInvoker(ShowDeviceShadowRequest showDeviceShadowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceShadowRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceShadowRequest);
            return new SyncInvoker<ShowDeviceShadowResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceShadowResponse>);
        }
        
        /// <summary>
        /// 配置设备影子预期数据
        ///
        /// 应用服务器可调用此接口配置设备影子的预期属性（desired区），当设备上线或者设备上报属性时把属性下发给设备。
        /// 
        /// 设备影子介绍：
        /// 设备影子是一个用于存储和检索设备当前状态信息的JSON文档。
        /// - 每个设备有且只有一个设备影子，由设备ID唯一标识
        /// - 设备影子用于存储设备上报的(状态)属性和应用程序期望的设备(状态)属性
        /// - 无论该设备是否在线，都可以通过该影子获取和设置设备的属性
        /// - 设备上线或者设备上报属性时，如果desired区和reported区存在差异，则将差异部分下发给设备，配置的预期属性需在产品模型中定义且method具有可写属性“W”才可下发
        /// - 该接口仅支持配置单个设备的设备影子的预期数据，如需多个设备的设备影子配置，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// 限制：
        /// 设备影子JSON文档中的key不允许特殊字符：点(.)、dollar符号($)、空char(十六进制的ASCII码为00)。如果包含了以上特殊字符则无法正常刷新影子文档。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDeviceShadowDesiredDataResponse UpdateDeviceShadowDesiredData(UpdateDeviceShadowDesiredDataRequest updateDeviceShadowDesiredDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceShadowDesiredDataRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceShadowDesiredDataRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDeviceShadowDesiredDataResponse>(response);
        }

        public SyncInvoker<UpdateDeviceShadowDesiredDataResponse> UpdateDeviceShadowDesiredDataInvoker(UpdateDeviceShadowDesiredDataRequest updateDeviceShadowDesiredDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDeviceShadowDesiredDataRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/shadow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDeviceShadowDesiredDataRequest);
            return new SyncInvoker<UpdateDeviceShadowDesiredDataResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDeviceShadowDesiredDataResponse>);
        }
        
        /// <summary>
        /// 添加域配置
        ///
        /// 应用服务器可调用此接口在物联网平台上添加域配置，域配置配额上限为：1个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDomainConfigurationResponse CreateDomainConfiguration(CreateDomainConfigurationRequest createDomainConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/domain-configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainConfigurationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDomainConfigurationResponse>(response);
        }

        public SyncInvoker<CreateDomainConfigurationResponse> CreateDomainConfigurationInvoker(CreateDomainConfigurationRequest createDomainConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/domain-configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainConfigurationRequest);
            return new SyncInvoker<CreateDomainConfigurationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDomainConfigurationResponse>);
        }
        
        /// <summary>
        /// 删除域配置
        ///
        /// 应用服务器可调用此接口在物联网平台删除域配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainConfigurationResponse DeleteDomainConfiguration(DeleteDomainConfigurationRequest deleteDomainConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainConfigurationRequest.ConfigurationId, out var valueOfConfigurationId)) urlParam.Add("configuration_id", valueOfConfigurationId);
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/domain-configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainConfigurationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainConfigurationResponse>(response);
        }

        public SyncInvoker<DeleteDomainConfigurationResponse> DeleteDomainConfigurationInvoker(DeleteDomainConfigurationRequest deleteDomainConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainConfigurationRequest.ConfigurationId, out var valueOfConfigurationId)) urlParam.Add("configuration_id", valueOfConfigurationId);
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/domain-configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainConfigurationRequest);
            return new SyncInvoker<DeleteDomainConfigurationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainConfigurationResponse>);
        }
        
        /// <summary>
        /// 获取域配置列表
        ///
        /// 应用服务器可调用此接口在物联网平台获取域配置列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainConfigurationsResponse ListDomainConfigurations(ListDomainConfigurationsRequest listDomainConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/domain-configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainConfigurationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainConfigurationsResponse>(response);
        }

        public SyncInvoker<ListDomainConfigurationsResponse> ListDomainConfigurationsInvoker(ListDomainConfigurationsRequest listDomainConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/domain-configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainConfigurationsRequest);
            return new SyncInvoker<ListDomainConfigurationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainConfigurationsResponse>);
        }
        
        /// <summary>
        /// 查询域配置
        ///
        /// 应用服务器可调用此接口在物联网平台查询域配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainConfigurationResponse ShowDomainConfiguration(ShowDomainConfigurationRequest showDomainConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainConfigurationRequest.ConfigurationId, out var valueOfConfigurationId)) urlParam.Add("configuration_id", valueOfConfigurationId);
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/domain-configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainConfigurationResponse>(response);
        }

        public SyncInvoker<ShowDomainConfigurationResponse> ShowDomainConfigurationInvoker(ShowDomainConfigurationRequest showDomainConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainConfigurationRequest.ConfigurationId, out var valueOfConfigurationId)) urlParam.Add("configuration_id", valueOfConfigurationId);
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/domain-configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainConfigurationRequest);
            return new SyncInvoker<ShowDomainConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新域配置
        ///
        /// 应用服务器可调用此接口在物联网平台上更新域配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainConfigurationResponse UpdateDomainConfiguration(UpdateDomainConfigurationRequest updateDomainConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainConfigurationRequest.ConfigurationId, out var valueOfConfigurationId)) urlParam.Add("configuration_id", valueOfConfigurationId);
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/domain-configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateDomainConfigurationResponse> UpdateDomainConfigurationInvoker(UpdateDomainConfigurationRequest updateDomainConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainConfigurationRequest.ConfigurationId, out var valueOfConfigurationId)) urlParam.Add("configuration_id", valueOfConfigurationId);
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/domain-configurations/{configuration_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainConfigurationRequest);
            return new SyncInvoker<UpdateDomainConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainConfigurationResponse>);
        }
        
        /// <summary>
        /// 新建数据流转流控策略
        ///
        /// 应用服务器可调用此接口在物联网平台创建数据流转流控策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRoutingFlowControlPolicyResponse CreateRoutingFlowControlPolicy(CreateRoutingFlowControlPolicyRequest createRoutingFlowControlPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/flowcontrol-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRoutingFlowControlPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRoutingFlowControlPolicyResponse>(response);
        }

        public SyncInvoker<CreateRoutingFlowControlPolicyResponse> CreateRoutingFlowControlPolicyInvoker(CreateRoutingFlowControlPolicyRequest createRoutingFlowControlPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/flowcontrol-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRoutingFlowControlPolicyRequest);
            return new SyncInvoker<CreateRoutingFlowControlPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRoutingFlowControlPolicyResponse>);
        }
        
        /// <summary>
        /// 删除数据流转流控策略
        ///
        /// 应用服务器可调用此接口在物联网平台删除指定数据流转流控策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRoutingFlowControlPolicyResponse DeleteRoutingFlowControlPolicy(DeleteRoutingFlowControlPolicyRequest deleteRoutingFlowControlPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRoutingFlowControlPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/flowcontrol-policy/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRoutingFlowControlPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRoutingFlowControlPolicyResponse>(response);
        }

        public SyncInvoker<DeleteRoutingFlowControlPolicyResponse> DeleteRoutingFlowControlPolicyInvoker(DeleteRoutingFlowControlPolicyRequest deleteRoutingFlowControlPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRoutingFlowControlPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/flowcontrol-policy/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRoutingFlowControlPolicyRequest);
            return new SyncInvoker<DeleteRoutingFlowControlPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRoutingFlowControlPolicyResponse>);
        }
        
        /// <summary>
        /// 查询数据流转流控策略列表
        ///
        /// 应用服务器可调用此接口查询在物联网平台设置的数据流转流控策略列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRoutingFlowControlPolicyResponse ListRoutingFlowControlPolicy(ListRoutingFlowControlPolicyRequest listRoutingFlowControlPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/flowcontrol-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRoutingFlowControlPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRoutingFlowControlPolicyResponse>(response);
        }

        public SyncInvoker<ListRoutingFlowControlPolicyResponse> ListRoutingFlowControlPolicyInvoker(ListRoutingFlowControlPolicyRequest listRoutingFlowControlPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/flowcontrol-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRoutingFlowControlPolicyRequest);
            return new SyncInvoker<ListRoutingFlowControlPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRoutingFlowControlPolicyResponse>);
        }
        
        /// <summary>
        /// 查询数据流转流控策略
        ///
        /// 应用服务器可调用此接口在物联网平台查询指定数据流转流控策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRoutingFlowControlPolicyResponse ShowRoutingFlowControlPolicy(ShowRoutingFlowControlPolicyRequest showRoutingFlowControlPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRoutingFlowControlPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/flowcontrol-policy/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoutingFlowControlPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRoutingFlowControlPolicyResponse>(response);
        }

        public SyncInvoker<ShowRoutingFlowControlPolicyResponse> ShowRoutingFlowControlPolicyInvoker(ShowRoutingFlowControlPolicyRequest showRoutingFlowControlPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRoutingFlowControlPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/flowcontrol-policy/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoutingFlowControlPolicyRequest);
            return new SyncInvoker<ShowRoutingFlowControlPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRoutingFlowControlPolicyResponse>);
        }
        
        /// <summary>
        /// 修改数据流转流控策略
        ///
        /// 应用服务器可调用此接口在物联网平台修改指定数据流转流控策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRoutingFlowControlPolicyResponse UpdateRoutingFlowControlPolicy(UpdateRoutingFlowControlPolicyRequest updateRoutingFlowControlPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRoutingFlowControlPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/flowcontrol-policy/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRoutingFlowControlPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRoutingFlowControlPolicyResponse>(response);
        }

        public SyncInvoker<UpdateRoutingFlowControlPolicyResponse> UpdateRoutingFlowControlPolicyInvoker(UpdateRoutingFlowControlPolicyRequest updateRoutingFlowControlPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRoutingFlowControlPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/flowcontrol-policy/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRoutingFlowControlPolicyRequest);
            return new SyncInvoker<UpdateRoutingFlowControlPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRoutingFlowControlPolicyResponse>);
        }
        
        /// <summary>
        /// 创建编解码函数
        ///
        /// 提供创建编解码函数的功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddFunctionsResponse AddFunctions(AddFunctionsRequest addFunctionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/product-functions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFunctionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddFunctionsResponse>(response);
        }

        public SyncInvoker<AddFunctionsResponse> AddFunctionsInvoker(AddFunctionsRequest addFunctionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/product-functions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFunctionsRequest);
            return new SyncInvoker<AddFunctionsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddFunctionsResponse>);
        }
        
        /// <summary>
        /// 删除编解码函数
        ///
        /// 提供删除编解码函数的功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteFunctionsResponse DeleteFunctions(DeleteFunctionsRequest deleteFunctionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFunctionsRequest.FunctionId, out var valueOfFunctionId)) urlParam.Add("function_id", valueOfFunctionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/product-functions/{function_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteFunctionsResponse>(response);
        }

        public SyncInvoker<DeleteFunctionsResponse> DeleteFunctionsInvoker(DeleteFunctionsRequest deleteFunctionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFunctionsRequest.FunctionId, out var valueOfFunctionId)) urlParam.Add("function_id", valueOfFunctionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/product-functions/{function_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionsRequest);
            return new SyncInvoker<DeleteFunctionsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFunctionsResponse>);
        }
        
        /// <summary>
        /// 查询编解码函数
        ///
        /// 提供查询编解码函数的功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFunctionsResponse ListFunctions(ListFunctionsRequest listFunctionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/product-functions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFunctionsResponse>(response);
        }

        public SyncInvoker<ListFunctionsResponse> ListFunctionsInvoker(ListFunctionsRequest listFunctionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/product-functions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionsRequest);
            return new SyncInvoker<ListFunctionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionsResponse>);
        }
        
        /// <summary>
        /// 创建鸿蒙软总线
        ///
        /// 应用服务器可调用此接口新建鸿蒙软总线。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddHarmonySoftBusResponse AddHarmonySoftBus(AddHarmonySoftBusRequest addHarmonySoftBusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/harmony-soft-bus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addHarmonySoftBusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddHarmonySoftBusResponse>(response);
        }

        public SyncInvoker<AddHarmonySoftBusResponse> AddHarmonySoftBusInvoker(AddHarmonySoftBusRequest addHarmonySoftBusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/harmony-soft-bus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addHarmonySoftBusRequest);
            return new SyncInvoker<AddHarmonySoftBusResponse>(this, "POST", request, JsonUtils.DeSerialize<AddHarmonySoftBusResponse>);
        }
        
        /// <summary>
        /// 同步鸿蒙软总线信息
        ///
        /// 应用服务器可调用此接口向组内设备同步鸿蒙软总线信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSyncHarmonySoftBusResponse CreateSyncHarmonySoftBus(CreateSyncHarmonySoftBusRequest createSyncHarmonySoftBusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSyncHarmonySoftBusRequest.BusId, out var valueOfBusId)) urlParam.Add("bus_id", valueOfBusId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/harmony-soft-bus/{bus_id}/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSyncHarmonySoftBusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSyncHarmonySoftBusResponse>(response);
        }

        public SyncInvoker<CreateSyncHarmonySoftBusResponse> CreateSyncHarmonySoftBusInvoker(CreateSyncHarmonySoftBusRequest createSyncHarmonySoftBusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSyncHarmonySoftBusRequest.BusId, out var valueOfBusId)) urlParam.Add("bus_id", valueOfBusId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/harmony-soft-bus/{bus_id}/sync", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSyncHarmonySoftBusRequest);
            return new SyncInvoker<CreateSyncHarmonySoftBusResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSyncHarmonySoftBusResponse>);
        }
        
        /// <summary>
        /// 删除鸿蒙软总线
        ///
        /// 应用服务器可调用此接口删除指定鸿蒙软总线。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteHarmonySoftBusResponse DeleteHarmonySoftBus(DeleteHarmonySoftBusRequest deleteHarmonySoftBusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHarmonySoftBusRequest.BusId, out var valueOfBusId)) urlParam.Add("bus_id", valueOfBusId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/harmony-soft-bus/{bus_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHarmonySoftBusRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteHarmonySoftBusResponse>(response);
        }

        public SyncInvoker<DeleteHarmonySoftBusResponse> DeleteHarmonySoftBusInvoker(DeleteHarmonySoftBusRequest deleteHarmonySoftBusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHarmonySoftBusRequest.BusId, out var valueOfBusId)) urlParam.Add("bus_id", valueOfBusId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/harmony-soft-bus/{bus_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHarmonySoftBusRequest);
            return new SyncInvoker<DeleteHarmonySoftBusResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteHarmonySoftBusResponse>);
        }
        
        /// <summary>
        /// 查询鸿蒙软总线列表
        ///
        /// 应用服务器可调用此接口查询鸿蒙软总线列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHarmonySoftBusResponse ListHarmonySoftBus(ListHarmonySoftBusRequest listHarmonySoftBusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/harmony-soft-bus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHarmonySoftBusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHarmonySoftBusResponse>(response);
        }

        public SyncInvoker<ListHarmonySoftBusResponse> ListHarmonySoftBusInvoker(ListHarmonySoftBusRequest listHarmonySoftBusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/harmony-soft-bus", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHarmonySoftBusRequest);
            return new SyncInvoker<ListHarmonySoftBusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHarmonySoftBusResponse>);
        }
        
        /// <summary>
        /// 重置鸿蒙软总线秘钥
        ///
        /// 应用服务器可调用此接口重置鸿蒙软总线秘钥, 重置后状态变为未同步需要用户调用同步接口想组内设备同步最新秘钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetHarmonySoftBusKeyResponse ResetHarmonySoftBusKey(ResetHarmonySoftBusKeyRequest resetHarmonySoftBusKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetHarmonySoftBusKeyRequest.BusId, out var valueOfBusId)) urlParam.Add("bus_id", valueOfBusId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/harmony-soft-bus/{bus_id}/reset-bus-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetHarmonySoftBusKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetHarmonySoftBusKeyResponse>(response);
        }

        public SyncInvoker<ResetHarmonySoftBusKeyResponse> ResetHarmonySoftBusKeyInvoker(ResetHarmonySoftBusKeyRequest resetHarmonySoftBusKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetHarmonySoftBusKeyRequest.BusId, out var valueOfBusId)) urlParam.Add("bus_id", valueOfBusId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/harmony-soft-bus/{bus_id}/reset-bus-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetHarmonySoftBusKeyRequest);
            return new SyncInvoker<ResetHarmonySoftBusKeyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetHarmonySoftBusKeyResponse>);
        }
        
        /// <summary>
        /// 查询鸿蒙软总线
        ///
        /// 应用服务器可调用此接口查询指定ID的鸿蒙软总线。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHarmonySoftBusResponse ShowHarmonySoftBus(ShowHarmonySoftBusRequest showHarmonySoftBusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHarmonySoftBusRequest.BusId, out var valueOfBusId)) urlParam.Add("bus_id", valueOfBusId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/harmony-soft-bus/{bus_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHarmonySoftBusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHarmonySoftBusResponse>(response);
        }

        public SyncInvoker<ShowHarmonySoftBusResponse> ShowHarmonySoftBusInvoker(ShowHarmonySoftBusRequest showHarmonySoftBusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHarmonySoftBusRequest.BusId, out var valueOfBusId)) urlParam.Add("bus_id", valueOfBusId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/harmony-soft-bus/{bus_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHarmonySoftBusRequest);
            return new SyncInvoker<ShowHarmonySoftBusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHarmonySoftBusResponse>);
        }
        
        /// <summary>
        /// 下发设备消息
        ///
        /// 物联网平台可向设备下发消息，应用服务器可调用此接口向指定设备下发消息，以实现对设备的控制。应用将消息下发给平台后，平台返回应用响应结果，平台再将消息发送给设备。平台返回应用响应结果不一定是设备接收结果，建议用户应用通过订阅[[设备消息状态变更通知](https://support.huaweicloud.com/api-iothub/iot_06_v5_01203.html)](tag:hws)[[设备消息状态变更通知](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_01203.html)](tag:hws_hk)，订阅后平台会将设备接收结果推送给订阅的应用。
        /// 注意：
        /// - 此接口适用于MQTT设备消息下发，暂不支持其他协议接入的设备消息下发。
        /// - 此接口仅支持单个设备消息下发，如需多个设备消息下发，请参见 [[创建批量任务](https://support.huaweicloud.com/api-iothub/iot_06_v5_0045.html)](tag:hws)[[创建批量任务](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0045.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMessageResponse CreateMessage(CreateMessageRequest createMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMessageRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMessageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMessageResponse>(response);
        }

        public SyncInvoker<CreateMessageResponse> CreateMessageInvoker(CreateMessageRequest createMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMessageRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMessageRequest);
            return new SyncInvoker<CreateMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMessageResponse>);
        }
        
        /// <summary>
        /// 删除指定消息id的消息
        ///
        /// 应用服务器可调用此接口删除平台下发给设备的指定消息id的消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDeviceMessageResponse DeleteDeviceMessage(DeleteDeviceMessageRequest deleteDeviceMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceMessageRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceMessageRequest.MessageId, out var valueOfMessageId)) urlParam.Add("message_id", valueOfMessageId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages/{message_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceMessageRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDeviceMessageResponse>(response);
        }

        public SyncInvoker<DeleteDeviceMessageResponse> DeleteDeviceMessageInvoker(DeleteDeviceMessageRequest deleteDeviceMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceMessageRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceMessageRequest.MessageId, out var valueOfMessageId)) urlParam.Add("message_id", valueOfMessageId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages/{message_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceMessageRequest);
            return new SyncInvoker<DeleteDeviceMessageResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDeviceMessageResponse>);
        }
        
        /// <summary>
        /// 查询设备消息
        ///
        /// 应用服务器可调用此接口查询平台下发给设备的消息，平台为每个设备默认最多保存20条消息，超过20条后， 后续的消息会替换下发最早的消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDeviceMessagesResponse ListDeviceMessages(ListDeviceMessagesRequest listDeviceMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDeviceMessagesRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceMessagesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDeviceMessagesResponse>(response);
        }

        public SyncInvoker<ListDeviceMessagesResponse> ListDeviceMessagesInvoker(ListDeviceMessagesRequest listDeviceMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDeviceMessagesRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceMessagesRequest);
            return new SyncInvoker<ListDeviceMessagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDeviceMessagesResponse>);
        }
        
        /// <summary>
        /// 查询指定消息id的消息
        ///
        /// 应用服务器可调用此接口查询平台下发给设备的指定消息id的消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeviceMessageResponse ShowDeviceMessage(ShowDeviceMessageRequest showDeviceMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceMessageRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            if (StringUtils.TryConvertToNonEmptyString(showDeviceMessageRequest.MessageId, out var valueOfMessageId)) urlParam.Add("message_id", valueOfMessageId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages/{message_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceMessageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceMessageResponse>(response);
        }

        public SyncInvoker<ShowDeviceMessageResponse> ShowDeviceMessageInvoker(ShowDeviceMessageRequest showDeviceMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceMessageRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            if (StringUtils.TryConvertToNonEmptyString(showDeviceMessageRequest.MessageId, out var valueOfMessageId)) urlParam.Add("message_id", valueOfMessageId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/messages/{message_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceMessageRequest);
            return new SyncInvoker<ShowDeviceMessageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceMessageResponse>);
        }
        
        /// <summary>
        /// 创建OTA模块
        ///
        /// 用户可调用此接口创建产品的OTA模块,同一产品下最多自定义10个OTA模块。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOtaModuleResponse CreateOtaModule(CreateOtaModuleRequest createOtaModuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/modules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOtaModuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOtaModuleResponse>(response);
        }

        public SyncInvoker<CreateOtaModuleResponse> CreateOtaModuleInvoker(CreateOtaModuleRequest createOtaModuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/modules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOtaModuleRequest);
            return new SyncInvoker<CreateOtaModuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOtaModuleResponse>);
        }
        
        /// <summary>
        /// 删除OTA模块
        ///
        /// 用户可调用此接口删除产品对应的OTA模块
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteOtaModuleResponse DeleteOtaModule(DeleteOtaModuleRequest deleteOtaModuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOtaModuleRequest.ModuleId, out var valueOfModuleId)) urlParam.Add("module_id", valueOfModuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/modules/{module_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOtaModuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOtaModuleResponse>(response);
        }

        public SyncInvoker<DeleteOtaModuleResponse> DeleteOtaModuleInvoker(DeleteOtaModuleRequest deleteOtaModuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOtaModuleRequest.ModuleId, out var valueOfModuleId)) urlParam.Add("module_id", valueOfModuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/modules/{module_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOtaModuleRequest);
            return new SyncInvoker<DeleteOtaModuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOtaModuleResponse>);
        }
        
        /// <summary>
        /// 查询OTA模块列表
        ///
        /// 用户可调用此接口查询指定产品的OTA模块列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOtaModulesResponse ListOtaModules(ListOtaModulesRequest listOtaModulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/modules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOtaModulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOtaModulesResponse>(response);
        }

        public SyncInvoker<ListOtaModulesResponse> ListOtaModulesInvoker(ListOtaModulesRequest listOtaModulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/modules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOtaModulesRequest);
            return new SyncInvoker<ListOtaModulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOtaModulesResponse>);
        }
        
        /// <summary>
        /// 查询OTA模块详情
        ///
        /// 用户可调用此接口查询OTA模块详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOtaModuleResponse ShowOtaModule(ShowOtaModuleRequest showOtaModuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOtaModuleRequest.ModuleId, out var valueOfModuleId)) urlParam.Add("module_id", valueOfModuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/modules/{module_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOtaModuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOtaModuleResponse>(response);
        }

        public SyncInvoker<ShowOtaModuleResponse> ShowOtaModuleInvoker(ShowOtaModuleRequest showOtaModuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOtaModuleRequest.ModuleId, out var valueOfModuleId)) urlParam.Add("module_id", valueOfModuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/modules/{module_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOtaModuleRequest);
            return new SyncInvoker<ShowOtaModuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOtaModuleResponse>);
        }
        
        /// <summary>
        /// 修改OTA模块
        ///
        /// 用户可调用此接口修改对应的OTA模块的别名和描述。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateOtaModuleResponse UpdateOtaModule(UpdateOtaModuleRequest updateOtaModuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOtaModuleRequest.ModuleId, out var valueOfModuleId)) urlParam.Add("module_id", valueOfModuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/modules/{module_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateOtaModuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateOtaModuleResponse>(response);
        }

        public SyncInvoker<UpdateOtaModuleResponse> UpdateOtaModuleInvoker(UpdateOtaModuleRequest updateOtaModuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateOtaModuleRequest.ModuleId, out var valueOfModuleId)) urlParam.Add("module_id", valueOfModuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/modules/{module_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateOtaModuleRequest);
            return new SyncInvoker<UpdateOtaModuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateOtaModuleResponse>);
        }
        
        /// <summary>
        /// 创建OTA升级包
        ///
        /// 用户可调用此接口创建升级包关联OBS对象
        /// 使用前提：使用该API需要您授权设备接入服务(IoTDA)的实例访问对象存储服务(OBS)以及 密钥管理服务(KMS Administrator)的权限。在“[[统一身份认证服务（IAM）](https://console.huaweicloud.com/iam)](tag:hws)[[统一身份认证服务（IAM）](https://console-intl.huaweicloud.com/iam)](tag:hws_hk) - 委托”中将委托名称为iotda_admin_trust的委托授权KMS Administrator和OBS OperateAccess
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOtaPackageResponse CreateOtaPackage(CreateOtaPackageRequest createOtaPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOtaPackageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOtaPackageResponse>(response);
        }

        public SyncInvoker<CreateOtaPackageResponse> CreateOtaPackageInvoker(CreateOtaPackageRequest createOtaPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOtaPackageRequest);
            return new SyncInvoker<CreateOtaPackageResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOtaPackageResponse>);
        }
        
        /// <summary>
        /// 删除OTA升级包
        ///
        /// 用户可调用此接口删除关联OBS对象的升级包信息，不会删除OBS上对象
        /// 使用前提：使用该API需要您授权设备接入服务(IoTDA)的实例访问对象存储服务(OBS)以及 密钥管理服务(KMS Administrator)的权限。在“[[统一身份认证服务（IAM）](https://console.huaweicloud.com/iam)](tag:hws)[[统一身份认证服务（IAM）](https://console-intl.huaweicloud.com/iam)](tag:hws_hk) - 委托”中将委托名称为iotda_admin_trust的委托授权KMS Administrator和OBS OperateAccess
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteOtaPackageResponse DeleteOtaPackage(DeleteOtaPackageRequest deleteOtaPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOtaPackageRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages/{package_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOtaPackageRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteOtaPackageResponse>(response);
        }

        public SyncInvoker<DeleteOtaPackageResponse> DeleteOtaPackageInvoker(DeleteOtaPackageRequest deleteOtaPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteOtaPackageRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages/{package_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOtaPackageRequest);
            return new SyncInvoker<DeleteOtaPackageResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteOtaPackageResponse>);
        }
        
        /// <summary>
        /// 查询OTA升级包列表
        ///
        /// 用户可调用此接口查询关联OBS对象的升级包列表
        /// 使用前提：使用该API需要您授权设备接入服务(IoTDA)的实例访问对象存储服务(OBS)以及 密钥管理服务(KMS Administrator)的权限。在“[[统一身份认证服务（IAM）](https://console.huaweicloud.com/iam)](tag:hws)[[统一身份认证服务（IAM）](https://console-intl.huaweicloud.com/iam)](tag:hws_hk) - 委托”中将委托名称为iotda_admin_trust的委托授权KMS Administrator和OBS OperateAccess
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOtaPackageInfoResponse ListOtaPackageInfo(ListOtaPackageInfoRequest listOtaPackageInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOtaPackageInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOtaPackageInfoResponse>(response);
        }

        public SyncInvoker<ListOtaPackageInfoResponse> ListOtaPackageInfoInvoker(ListOtaPackageInfoRequest listOtaPackageInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOtaPackageInfoRequest);
            return new SyncInvoker<ListOtaPackageInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOtaPackageInfoResponse>);
        }
        
        /// <summary>
        /// 获取OTA升级包详情
        ///
        /// 用户可调用此接口查询关联OBS对象的升级包详情
        /// 使用前提：使用该API需要您授权设备接入服务(IoTDA)的实例访问对象存储服务(OBS)以及 密钥管理服务(KMS Administrator)的权限。在“[[统一身份认证服务（IAM）](https://console.huaweicloud.com/iam)](tag:hws)[[统一身份认证服务（IAM）](https://console-intl.huaweicloud.com/iam)](tag:hws_hk) - 委托”中将委托名称为iotda_admin_trust的委托授权KMS Administrator和OBS OperateAccess
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOtaPackageResponse ShowOtaPackage(ShowOtaPackageRequest showOtaPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOtaPackageRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages/{package_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOtaPackageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOtaPackageResponse>(response);
        }

        public SyncInvoker<ShowOtaPackageResponse> ShowOtaPackageInvoker(ShowOtaPackageRequest showOtaPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showOtaPackageRequest.PackageId, out var valueOfPackageId)) urlParam.Add("package_id", valueOfPackageId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/ota-upgrades/packages/{package_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOtaPackageRequest);
            return new SyncInvoker<ShowOtaPackageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOtaPackageResponse>);
        }
        
        /// <summary>
        /// 绑定设备策略
        ///
        /// 应用服务器可调用此接口在物联网平台上为批量设备绑定目标策略，目前支持绑定目标类型为：设备、产品，当目标类型为产品时，该产品下所有设备都会生效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BindDevicePolicyResponse BindDevicePolicy(BindDevicePolicyRequest bindDevicePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindDevicePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies/{policy_id}/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", bindDevicePolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BindDevicePolicyResponse>(response);
        }

        public SyncInvoker<BindDevicePolicyResponse> BindDevicePolicyInvoker(BindDevicePolicyRequest bindDevicePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(bindDevicePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies/{policy_id}/bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", bindDevicePolicyRequest);
            return new SyncInvoker<BindDevicePolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<BindDevicePolicyResponse>);
        }
        
        /// <summary>
        /// 创建设备策略
        ///
        /// 应用服务器可调用此接口在物联网平台创建一个策略，该策略需要绑定到设备和产品下才能生效。
        /// - 一个实例最多能创建50个设备策略。
        /// - 仅**标准版实例、企业版实例**支持该接口调用，基础版不支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDevicePolicyResponse CreateDevicePolicy(CreateDevicePolicyRequest createDevicePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDevicePolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDevicePolicyResponse>(response);
        }

        public SyncInvoker<CreateDevicePolicyResponse> CreateDevicePolicyInvoker(CreateDevicePolicyRequest createDevicePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDevicePolicyRequest);
            return new SyncInvoker<CreateDevicePolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDevicePolicyResponse>);
        }
        
        /// <summary>
        /// 删除设备策略
        ///
        /// 应用服务器可调用此接口在物联网平台上删除指定策略，注意：删除策略同时会解绑该策略下所有绑定对象。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDevicePolicyResponse DeleteDevicePolicy(DeleteDevicePolicyRequest deleteDevicePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDevicePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDevicePolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDevicePolicyResponse>(response);
        }

        public SyncInvoker<DeleteDevicePolicyResponse> DeleteDevicePolicyInvoker(DeleteDevicePolicyRequest deleteDevicePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDevicePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDevicePolicyRequest);
            return new SyncInvoker<DeleteDevicePolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDevicePolicyResponse>);
        }
        
        /// <summary>
        /// 查询设备策略列表
        ///
        /// 应用服务器可调用此接口在物联网平台查询策略列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDevicePoliciesResponse ListDevicePolicies(ListDevicePoliciesRequest listDevicePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevicePoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDevicePoliciesResponse>(response);
        }

        public SyncInvoker<ListDevicePoliciesResponse> ListDevicePoliciesInvoker(ListDevicePoliciesRequest listDevicePoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDevicePoliciesRequest);
            return new SyncInvoker<ListDevicePoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDevicePoliciesResponse>);
        }
        
        /// <summary>
        /// 查询设备策略详情
        ///
        /// 应用服务器可调用此接口在物联网平台查询指定策略ID的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDevicePolicyResponse ShowDevicePolicy(ShowDevicePolicyRequest showDevicePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDevicePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDevicePolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDevicePolicyResponse>(response);
        }

        public SyncInvoker<ShowDevicePolicyResponse> ShowDevicePolicyInvoker(ShowDevicePolicyRequest showDevicePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDevicePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDevicePolicyRequest);
            return new SyncInvoker<ShowDevicePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDevicePolicyResponse>);
        }
        
        /// <summary>
        /// 查询设备策略绑定的目标列表
        ///
        /// 应用服务器可调用此接口在物联网平台上查询指定策略ID下绑定的目标列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTargetsInDevicePolicyResponse ShowTargetsInDevicePolicy(ShowTargetsInDevicePolicyRequest showTargetsInDevicePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTargetsInDevicePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies/{policy_id}/list-targets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTargetsInDevicePolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowTargetsInDevicePolicyResponse>(response);
        }

        public SyncInvoker<ShowTargetsInDevicePolicyResponse> ShowTargetsInDevicePolicyInvoker(ShowTargetsInDevicePolicyRequest showTargetsInDevicePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTargetsInDevicePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies/{policy_id}/list-targets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTargetsInDevicePolicyRequest);
            return new SyncInvoker<ShowTargetsInDevicePolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowTargetsInDevicePolicyResponse>);
        }
        
        /// <summary>
        /// 解绑设备策略
        ///
        /// 应用服务器可调用此接口在物联网平台上解除指定策略下绑定的目标对象。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnbindDevicePolicyResponse UnbindDevicePolicy(UnbindDevicePolicyRequest unbindDevicePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unbindDevicePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies/{policy_id}/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unbindDevicePolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UnbindDevicePolicyResponse>(response);
        }

        public SyncInvoker<UnbindDevicePolicyResponse> UnbindDevicePolicyInvoker(UnbindDevicePolicyRequest unbindDevicePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unbindDevicePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies/{policy_id}/unbind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unbindDevicePolicyRequest);
            return new SyncInvoker<UnbindDevicePolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<UnbindDevicePolicyResponse>);
        }
        
        /// <summary>
        /// 更新设备策略信息
        ///
        /// 应用服务器可调用此接口在物联网平台更新策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDevicePolicyResponse UpdateDevicePolicy(UpdateDevicePolicyRequest updateDevicePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDevicePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDevicePolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDevicePolicyResponse>(response);
        }

        public SyncInvoker<UpdateDevicePolicyResponse> UpdateDevicePolicyInvoker(UpdateDevicePolicyRequest updateDevicePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDevicePolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/device-policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDevicePolicyRequest);
            return new SyncInvoker<UpdateDevicePolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDevicePolicyResponse>);
        }
        
        /// <summary>
        /// 创建产品
        ///
        /// 应用服务器可调用此接口创建产品。此接口仅创建了产品，没有创建和安装插件，如果需要对数据进行编解码，还需要在平台开发和安装插件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateProductResponse CreateProduct(CreateProductRequest createProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createProductRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateProductResponse>(response);
        }

        public SyncInvoker<CreateProductResponse> CreateProductInvoker(CreateProductRequest createProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createProductRequest);
            return new SyncInvoker<CreateProductResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProductResponse>);
        }
        
        /// <summary>
        /// 删除产品
        ///
        /// 应用服务器可调用此接口删除已导入物联网平台的指定产品模型。此接口仅删除了产品，未删除关联的插件，在产品下存在设备时，该产品不允许删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteProductResponse DeleteProduct(DeleteProductRequest deleteProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProductRequest.ProductId, out var valueOfProductId)) urlParam.Add("product_id", valueOfProductId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProductRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteProductResponse>(response);
        }

        public SyncInvoker<DeleteProductResponse> DeleteProductInvoker(DeleteProductRequest deleteProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProductRequest.ProductId, out var valueOfProductId)) urlParam.Add("product_id", valueOfProductId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProductRequest);
            return new SyncInvoker<DeleteProductResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProductResponse>);
        }
        
        /// <summary>
        /// 查询产品列表
        ///
        /// 应用服务器可调用此接口查询已导入物联网平台的产品模型信息列表，了解产品模型的概要信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProductsResponse ListProducts(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProductsResponse>(response);
        }

        public SyncInvoker<ListProductsResponse> ListProductsInvoker(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            return new SyncInvoker<ListProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProductsResponse>);
        }
        
        /// <summary>
        /// 查询产品
        ///
        /// 应用服务器可调用此接口查询已导入物联网平台的指定产品模型详细信息，包括产品模型的服务、属性、命令等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProductResponse ShowProduct(ShowProductRequest showProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProductRequest.ProductId, out var valueOfProductId)) urlParam.Add("product_id", valueOfProductId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProductRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProductResponse>(response);
        }

        public SyncInvoker<ShowProductResponse> ShowProductInvoker(ShowProductRequest showProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProductRequest.ProductId, out var valueOfProductId)) urlParam.Add("product_id", valueOfProductId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProductRequest);
            return new SyncInvoker<ShowProductResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProductResponse>);
        }
        
        /// <summary>
        /// 修改产品
        ///
        /// 应用服务器可调用此接口修改已导入物联网平台的指定产品模型，包括产品模型的服务、属性、命令等。此接口仅修改了产品，未修改和安装插件，如果修改了产品中的service定义，且在平台中有对应的插件，请修改并重新安装插件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProductResponse UpdateProduct(UpdateProductRequest updateProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProductRequest.ProductId, out var valueOfProductId)) urlParam.Add("product_id", valueOfProductId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProductRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProductResponse>(response);
        }

        public SyncInvoker<UpdateProductResponse> UpdateProductInvoker(UpdateProductRequest updateProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProductRequest.ProductId, out var valueOfProductId)) urlParam.Add("product_id", valueOfProductId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProductRequest);
            return new SyncInvoker<UpdateProductResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProductResponse>);
        }
        
        /// <summary>
        /// 查询设备属性
        ///
        /// 设备的产品模型中定义了物联网平台可向设备下发的属性，应用服务器可调用此接口向设备发送指令用以查询设备的实时属性, 并由设备将属性查询的结果同步返回给应用服务器。
        /// 注意：此接口适用于MQTT设备，暂不支持NB-IoT设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPropertiesResponse ListProperties(ListPropertiesRequest listPropertiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPropertiesRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/properties", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPropertiesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPropertiesResponse>(response);
        }

        public SyncInvoker<ListPropertiesResponse> ListPropertiesInvoker(ListPropertiesRequest listPropertiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPropertiesRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/properties", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPropertiesRequest);
            return new SyncInvoker<ListPropertiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPropertiesResponse>);
        }
        
        /// <summary>
        /// 修改设备属性
        ///
        /// 设备的产品模型中定义了物联网平台可向设备下发的属性，应用服务器可调用此接口向指定设备下发属性。平台负责将属性以同步方式发送给设备，并将设备执行属性结果同步返回。
        /// 注意：此接口适用于MQTT设备，暂不支持NB-IoT设备。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePropertiesResponse UpdateProperties(UpdatePropertiesRequest updatePropertiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePropertiesRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/properties", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePropertiesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePropertiesResponse>(response);
        }

        public SyncInvoker<UpdatePropertiesResponse> UpdatePropertiesInvoker(UpdatePropertiesRequest updatePropertiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePropertiesRequest.DeviceId, out var valueOfDeviceId)) urlParam.Add("device_id", valueOfDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/devices/{device_id}/properties", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePropertiesRequest);
            return new SyncInvoker<UpdatePropertiesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePropertiesResponse>);
        }
        
        /// <summary>
        /// 创建预调配模板
        ///
        /// 应用服务器可调用此接口在物联网平台创建一个预调配模板。用户的设备未在平台注册时，可以通过预调配模板在设备首次接入物联网平台时将设备信息自动注册到物联网平台。
        /// - 该预调配模板至少需要绑定到一个设备CA证书下才能生效。
        /// - 一个实例最多可有10个预调配模板。
        /// - 仅标准版实例、企业版实例支持该接口调用，基础版不支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateProvisioningTemplateResponse CreateProvisioningTemplate(CreateProvisioningTemplateRequest createProvisioningTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/provisioning-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProvisioningTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateProvisioningTemplateResponse>(response);
        }

        public SyncInvoker<CreateProvisioningTemplateResponse> CreateProvisioningTemplateInvoker(CreateProvisioningTemplateRequest createProvisioningTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/provisioning-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProvisioningTemplateRequest);
            return new SyncInvoker<CreateProvisioningTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProvisioningTemplateResponse>);
        }
        
        /// <summary>
        /// 删除预调配模板
        ///
        /// 应用服务器可调用此接口在物联网平台上删除指定预调配模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteProvisioningTemplateResponse DeleteProvisioningTemplate(DeleteProvisioningTemplateRequest deleteProvisioningTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProvisioningTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/provisioning-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProvisioningTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteProvisioningTemplateResponse>(response);
        }

        public SyncInvoker<DeleteProvisioningTemplateResponse> DeleteProvisioningTemplateInvoker(DeleteProvisioningTemplateRequest deleteProvisioningTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProvisioningTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/provisioning-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProvisioningTemplateRequest);
            return new SyncInvoker<DeleteProvisioningTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProvisioningTemplateResponse>);
        }
        
        /// <summary>
        /// 查询预调配模板列表
        ///
        /// 应用服务器可调用此接口在物联网平台查询预调配模板列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProvisioningTemplatesResponse ListProvisioningTemplates(ListProvisioningTemplatesRequest listProvisioningTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/provisioning-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvisioningTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProvisioningTemplatesResponse>(response);
        }

        public SyncInvoker<ListProvisioningTemplatesResponse> ListProvisioningTemplatesInvoker(ListProvisioningTemplatesRequest listProvisioningTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/provisioning-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvisioningTemplatesRequest);
            return new SyncInvoker<ListProvisioningTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProvisioningTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询预调配模板详情
        ///
        /// 应用服务器可调用此接口在物联网平台查询指定预调配模板ID的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProvisioningTemplateResponse ShowProvisioningTemplate(ShowProvisioningTemplateRequest showProvisioningTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProvisioningTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/provisioning-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProvisioningTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProvisioningTemplateResponse>(response);
        }

        public SyncInvoker<ShowProvisioningTemplateResponse> ShowProvisioningTemplateInvoker(ShowProvisioningTemplateRequest showProvisioningTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProvisioningTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/provisioning-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProvisioningTemplateRequest);
            return new SyncInvoker<ShowProvisioningTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProvisioningTemplateResponse>);
        }
        
        /// <summary>
        /// 更新指定id的预调配模板信息
        ///
        /// 应用服务器可调用此接口在物联网平台更新指定id的预调配模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProvisioningTemplateResponse UpdateProvisioningTemplate(UpdateProvisioningTemplateRequest updateProvisioningTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProvisioningTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/provisioning-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProvisioningTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProvisioningTemplateResponse>(response);
        }

        public SyncInvoker<UpdateProvisioningTemplateResponse> UpdateProvisioningTemplateInvoker(UpdateProvisioningTemplateRequest updateProvisioningTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProvisioningTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/provisioning-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProvisioningTemplateRequest);
            return new SyncInvoker<UpdateProvisioningTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProvisioningTemplateResponse>);
        }
        
        /// <summary>
        /// 创建规则触发条件
        ///
        /// 应用服务器可调用此接口在物联网平台创建一条规则触发条件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRoutingRuleResponse CreateRoutingRule(CreateRoutingRuleRequest createRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRoutingRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRoutingRuleResponse>(response);
        }

        public SyncInvoker<CreateRoutingRuleResponse> CreateRoutingRuleInvoker(CreateRoutingRuleRequest createRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRoutingRuleRequest);
            return new SyncInvoker<CreateRoutingRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRoutingRuleResponse>);
        }
        
        /// <summary>
        /// 创建规则动作
        ///
        /// 应用服务器可调用此接口在物联网平台创建一条规则动作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRuleActionResponse CreateRuleAction(CreateRuleActionRequest createRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRuleActionResponse>(response);
        }

        public SyncInvoker<CreateRuleActionResponse> CreateRuleActionInvoker(CreateRuleActionRequest createRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleActionRequest);
            return new SyncInvoker<CreateRuleActionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRuleActionResponse>);
        }
        
        /// <summary>
        /// 删除规则触发条件
        ///
        /// 应用服务器可调用此接口删除物联网平台中的指定规则条件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRoutingRuleResponse DeleteRoutingRule(DeleteRoutingRuleRequest deleteRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRoutingRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRoutingRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRoutingRuleResponse>(response);
        }

        public SyncInvoker<DeleteRoutingRuleResponse> DeleteRoutingRuleInvoker(DeleteRoutingRuleRequest deleteRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRoutingRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRoutingRuleRequest);
            return new SyncInvoker<DeleteRoutingRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRoutingRuleResponse>);
        }
        
        /// <summary>
        /// 删除规则动作
        ///
        /// 应用服务器可调用此接口删除物联网平台中的指定规则动作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRuleActionResponse DeleteRuleAction(DeleteRuleActionRequest deleteRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleActionRequest.ActionId, out var valueOfActionId)) urlParam.Add("action_id", valueOfActionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleActionRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRuleActionResponse>(response);
        }

        public SyncInvoker<DeleteRuleActionResponse> DeleteRuleActionInvoker(DeleteRuleActionRequest deleteRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleActionRequest.ActionId, out var valueOfActionId)) urlParam.Add("action_id", valueOfActionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleActionRequest);
            return new SyncInvoker<DeleteRuleActionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRuleActionResponse>);
        }
        
        /// <summary>
        /// 查询规则条件列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中设置的规则条件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRoutingRulesResponse ListRoutingRules(ListRoutingRulesRequest listRoutingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRoutingRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRoutingRulesResponse>(response);
        }

        public SyncInvoker<ListRoutingRulesResponse> ListRoutingRulesInvoker(ListRoutingRulesRequest listRoutingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRoutingRulesRequest);
            return new SyncInvoker<ListRoutingRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRoutingRulesResponse>);
        }
        
        /// <summary>
        /// 查询规则动作列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中设置的规则动作列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRuleActionsResponse ListRuleActions(ListRuleActionsRequest listRuleActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleActionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRuleActionsResponse>(response);
        }

        public SyncInvoker<ListRuleActionsResponse> ListRuleActionsInvoker(ListRuleActionsRequest listRuleActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleActionsRequest);
            return new SyncInvoker<ListRuleActionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRuleActionsResponse>);
        }
        
        /// <summary>
        /// 查询规则条件
        ///
        /// 应用服务器可调用此接口查询物联网平台中指定规则条件的配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRoutingRuleResponse ShowRoutingRule(ShowRoutingRuleRequest showRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRoutingRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoutingRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRoutingRuleResponse>(response);
        }

        public SyncInvoker<ShowRoutingRuleResponse> ShowRoutingRuleInvoker(ShowRoutingRuleRequest showRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRoutingRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRoutingRuleRequest);
            return new SyncInvoker<ShowRoutingRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRoutingRuleResponse>);
        }
        
        /// <summary>
        /// 查询规则动作
        ///
        /// 应用服务器可调用此接口查询物联网平台中指定规则动作的配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRuleActionResponse ShowRuleAction(ShowRuleActionRequest showRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRuleActionRequest.ActionId, out var valueOfActionId)) urlParam.Add("action_id", valueOfActionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleActionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRuleActionResponse>(response);
        }

        public SyncInvoker<ShowRuleActionResponse> ShowRuleActionInvoker(ShowRuleActionRequest showRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRuleActionRequest.ActionId, out var valueOfActionId)) urlParam.Add("action_id", valueOfActionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleActionRequest);
            return new SyncInvoker<ShowRuleActionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRuleActionResponse>);
        }
        
        /// <summary>
        /// 修改规则触发条件
        ///
        /// 应用服务器可调用此接口修改物联网平台中指定规则条件的配置参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRoutingRuleResponse UpdateRoutingRule(UpdateRoutingRuleRequest updateRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRoutingRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRoutingRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRoutingRuleResponse>(response);
        }

        public SyncInvoker<UpdateRoutingRuleResponse> UpdateRoutingRuleInvoker(UpdateRoutingRuleRequest updateRoutingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRoutingRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRoutingRuleRequest);
            return new SyncInvoker<UpdateRoutingRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRoutingRuleResponse>);
        }
        
        /// <summary>
        /// 修改规则动作
        ///
        /// 应用服务器可调用此接口修改物联网平台中指定规则动作的配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRuleActionResponse UpdateRuleAction(UpdateRuleActionRequest updateRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRuleActionRequest.ActionId, out var valueOfActionId)) urlParam.Add("action_id", valueOfActionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleActionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRuleActionResponse>(response);
        }

        public SyncInvoker<UpdateRuleActionResponse> UpdateRuleActionInvoker(UpdateRuleActionRequest updateRuleActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRuleActionRequest.ActionId, out var valueOfActionId)) urlParam.Add("action_id", valueOfActionId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/routing-rule/actions/{action_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleActionRequest);
            return new SyncInvoker<UpdateRuleActionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRuleActionResponse>);
        }
        
        /// <summary>
        /// 修改规则状态
        ///
        /// 应用服务器可调用此接口修改物联网平台中指定规则的状态，激活或者去激活规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeRuleStatusResponse ChangeRuleStatus(ChangeRuleStatusRequest changeRuleStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeRuleStatusRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeRuleStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ChangeRuleStatusResponse>(response);
        }

        public SyncInvoker<ChangeRuleStatusResponse> ChangeRuleStatusInvoker(ChangeRuleStatusRequest changeRuleStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeRuleStatusRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeRuleStatusRequest);
            return new SyncInvoker<ChangeRuleStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeRuleStatusResponse>);
        }
        
        /// <summary>
        /// 创建规则
        ///
        /// 应用服务器可调用此接口在物联网平台创建一条规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRuleResponse CreateRule(CreateRuleRequest createRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRuleResponse>(response);
        }

        public SyncInvoker<CreateRuleResponse> CreateRuleInvoker(CreateRuleRequest createRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleRequest);
            return new SyncInvoker<CreateRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRuleResponse>);
        }
        
        /// <summary>
        /// 删除规则
        ///
        /// 应用服务器可调用此接口删除物联网平台中的指定规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRuleResponse DeleteRule(DeleteRuleRequest deleteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRuleResponse>(response);
        }

        public SyncInvoker<DeleteRuleResponse> DeleteRuleInvoker(DeleteRuleRequest deleteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleRequest);
            return new SyncInvoker<DeleteRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRuleResponse>);
        }
        
        /// <summary>
        /// 查询规则列表
        ///
        /// 应用服务器可调用此接口查询物联网平台中设置的规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRulesResponse ListRules(ListRulesRequest listRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRulesResponse>(response);
        }

        public SyncInvoker<ListRulesResponse> ListRulesInvoker(ListRulesRequest listRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRulesRequest);
            return new SyncInvoker<ListRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRulesResponse>);
        }
        
        /// <summary>
        /// 查询规则
        ///
        /// 应用服务器可调用此接口查询物联网平台中指定规则的配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRuleResponse ShowRule(ShowRuleRequest showRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRuleResponse>(response);
        }

        public SyncInvoker<ShowRuleResponse> ShowRuleInvoker(ShowRuleRequest showRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleRequest);
            return new SyncInvoker<ShowRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRuleResponse>);
        }
        
        /// <summary>
        /// 修改规则
        ///
        /// 应用服务器可调用此接口修改物联网平台中指定规则的配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRuleResponse UpdateRule(UpdateRuleRequest updateRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRuleResponse>(response);
        }

        public SyncInvoker<UpdateRuleResponse> UpdateRuleInvoker(UpdateRuleRequest updateRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleRequest);
            return new SyncInvoker<UpdateRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRuleResponse>);
        }
        
        /// <summary>
        /// 创建或更新安全态势感知配置
        ///
        /// #### 接口说明
        /// 应用服务器调用该接口创建安全态势感知配置。
        /// #### 限制
        /// #### 目前支持的安全配置项有：
        /// 
        /// | 配置名              | 默认告警级别 |   默认安全级别   | 设备维度 | 平台检测/设备上报 | 配置结构体   | 说明        |
        /// | :- -- -- -- -- -- -- -- -- - | :- -- -- -- -- -- | :- -- -- -- -- -- -- -- | :- -- -- -- | :- -- -- -- -- -- -- -- - | :- -- -- -- -- -- -- -- -- | :- -- -- -- -- --|
        /// | DEVICE_MEMORY_CHECK | CRITICAL  | ADVANCE_SECURITY | 是       | 设备上报          | [{\&quot;key\&quot;:\&quot;memory_threshold\&quot;,\&quot;value\&quot;:80},{\&quot;key\&quot;:\&quot;report_period\&quot;,\&quot;value\&quot;:1}] | 设备内存泄漏检测，report_period：上报周期单位(小时) 取值范围[1, 24]；memory_threshold内存检测阈值百分比，取值范围：[1, 100] |
        /// | DEVICE_PORT_CHECK   | CRITICAL     | ADVANCE_SECURITY | 是       | 设备上报          | [{\&quot;key\&quot;:\&quot;safety_ports\&quot;,\&quot;value\&quot;:[80,8080]},{\&quot;key\&quot;:\&quot;report_period\&quot;,\&quot;value\&quot;:1}] | 设备异常端口检测，report_period：上报周期单位(小时) 取值范围[1, 24]；safety_ports：安全端口白名单，数组，取值范围:[1, 65535] |
        /// | DEVICE_CPU_USAGE_CHECK | CRITICAL  | ADVANCE_SECURITY | 是       | 设备上报          | [{\&quot;key\&quot;:\&quot;cpu_usage_threshold\&quot;,\&quot;value\&quot;:80},{\&quot;key\&quot;:\&quot;report_period\&quot;,\&quot;value\&quot;:1}] | 设备CPU使用率检测，report_period：上报周期单位(小时) 取值范围[1, 24]；cpu_usage_threshold：CPU检测阈值百分比，取值范围：[1, 100] |
        /// | DEVICE_DISK_SPACE_CHECK | CRITICAL  | ADVANCE_SECURITY | 是       | 设备上报          | [{\&quot;key\&quot;:\&quot;disk_space_threshold\&quot;,\&quot;value\&quot;:80},{\&quot;key\&quot;:\&quot;report_period\&quot;,\&quot;value\&quot;:1}] | 设备磁盘使用率检测，report_period：上报周期单位(小时) 取值范围[1, 24]；disk_space_threshold：磁盘检测阈值百分比，取值范围：[1, 100] |
        /// | DEVICE_BATTERY_PERCENTAGE_CHECK | CRITICAL  | ADVANCE_SECURITY | 是       | 设备上报          | [{\&quot;key\&quot;:\&quot;battery_percentage_threshold\&quot;,\&quot;value\&quot;:20},{\&quot;key\&quot;:\&quot;report_period\&quot;,\&quot;value\&quot;:1}] | 设备电池电量检测，report_period：上报周期单位(小时) 取值范围[1, 24]；battery_percentage_threshold：电池检测阈值百分比，取值范围：[1, 100] |
        /// | DEVICE_LOGIN_LOCAL_CHECK | MINOR  | BASIC_SECURITY | 是       | 设备上报          | NA | 设备本地登录检测 |
        /// | DEVICE_MALICIOUS_IP_CHECK | MINOR  | BASIC_SECURITY | 是       | 设备上报          | {\&quot;key\&quot;:\&quot;safety_ips\&quot;,\&quot;value\&quot;:[\&quot;192.168.0.0/16\&quot;]} | 设备恶意ip检测 |
        /// | DEVICE_LOGIN_BRUTE_FORCE_CHECK | MINOR  | BASIC_SECURITY | 是       | 设备上报          | NA | 设备暴力破解登录检测 |
        /// | DEVICE_FILE_TAMPER_CHECK | MINOR  | BASIC_SECURITY | 是       | 设备上报          | NA | 设备本地文件篡改检测 |
        /// | INSECURE_TLS_PROTOCOL_CHECK | MAJOR  | ULTIMATE_SECURITY | 是       | 平台检测          | NA | 设备使用不安全的TLS协议接入检测 |
        /// | INSECURE_CIPHER_SUITE_CHECK | MAJOR  | ULTIMATE_SECURITY | 是       | 平台检测          | NA | 设备使用不安全TLS加密套件接入检测 |
        /// | CONNECT_MULTIPLE_TIMES_CHECK | CRITICAL  | ULTIMATE_SECURITY | 是       | 平台检测          | NA | 设备单位时间内多次建链检测 |
        /// | SECRET_COMPLEXITY_CHECK | MAJOR  | ULTIMATE_SECURITY | 是       | 平台检测          | NA | 设备弱密码检测 |
        /// | TLS_CONNECT_CHECK | MINOR  | ULTIMATE_SECURITY | 是       | 平台检测          | NA | 设备是否使用TLS加密通讯协议检测 |
        /// | DEVICE_AUTH_FAIL_CHECK | CRITICAL  | ULTIMATE_SECURITY | 是       | 平台检测          | NA | 设备鉴权失败检测 |
        /// | DEVICE_OFFLINE_CHECK | CRITICAL  | ULTIMATE_SECURITY | 是       | 平台检测          | NA | 设备异常离线检测 |
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSecurityProfileResponse CreateSecurityProfile(CreateSecurityProfileRequest createSecurityProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/security-profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityProfileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSecurityProfileResponse>(response);
        }

        public SyncInvoker<CreateSecurityProfileResponse> CreateSecurityProfileInvoker(CreateSecurityProfileRequest createSecurityProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/security-profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityProfileRequest);
            return new SyncInvoker<CreateSecurityProfileResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecurityProfileResponse>);
        }
        
        /// <summary>
        /// 删除某个具体id的安全态势感知配置信息
        ///
        /// 应用服务器可调用此接口删除某个具体id的安全态势感知配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSecurityProfileResponse DeleteSecurityProfile(DeleteSecurityProfileRequest deleteSecurityProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecurityProfileRequest.ProfileId, out var valueOfProfileId)) urlParam.Add("profile_id", valueOfProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/security-profiles/{profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityProfileRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSecurityProfileResponse>(response);
        }

        public SyncInvoker<DeleteSecurityProfileResponse> DeleteSecurityProfileInvoker(DeleteSecurityProfileRequest deleteSecurityProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSecurityProfileRequest.ProfileId, out var valueOfProfileId)) urlParam.Add("profile_id", valueOfProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/security-profiles/{profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityProfileRequest);
            return new SyncInvoker<DeleteSecurityProfileResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSecurityProfileResponse>);
        }
        
        /// <summary>
        /// 查询安全态势感知配置信息列表
        ///
        /// 接口说明：应用服务器调用该接口查询安全态势感知配置列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSecurityProfilesResponse ListSecurityProfiles(ListSecurityProfilesRequest listSecurityProfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/security-profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityProfilesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSecurityProfilesResponse>(response);
        }

        public SyncInvoker<ListSecurityProfilesResponse> ListSecurityProfilesInvoker(ListSecurityProfilesRequest listSecurityProfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/security-profiles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityProfilesRequest);
            return new SyncInvoker<ListSecurityProfilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecurityProfilesResponse>);
        }
        
        /// <summary>
        /// 查询某个具体id的安全态势感知配置详情
        ///
        /// 应用服务器可调用此接口查询某个具体id的安全态势感知配置详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSecurityProfileResponse ShowSecurityProfile(ShowSecurityProfileRequest showSecurityProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecurityProfileRequest.ProfileId, out var valueOfProfileId)) urlParam.Add("profile_id", valueOfProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/security-profiles/{profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityProfileRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSecurityProfileResponse>(response);
        }

        public SyncInvoker<ShowSecurityProfileResponse> ShowSecurityProfileInvoker(ShowSecurityProfileRequest showSecurityProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSecurityProfileRequest.ProfileId, out var valueOfProfileId)) urlParam.Add("profile_id", valueOfProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/security-profiles/{profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityProfileRequest);
            return new SyncInvoker<ShowSecurityProfileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSecurityProfileResponse>);
        }
        
        /// <summary>
        /// 更新某个具体id的安全态势感知配置信息
        ///
        /// 应用服务器可调用此接口更新某个具体id的安全态势感知配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSecurityProfileResponse UpdateSecurityProfile(UpdateSecurityProfileRequest updateSecurityProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSecurityProfileRequest.ProfileId, out var valueOfProfileId)) urlParam.Add("profile_id", valueOfProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/security-profiles/{profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityProfileRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSecurityProfileResponse>(response);
        }

        public SyncInvoker<UpdateSecurityProfileResponse> UpdateSecurityProfileInvoker(UpdateSecurityProfileRequest updateSecurityProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSecurityProfileRequest.ProfileId, out var valueOfProfileId)) urlParam.Add("profile_id", valueOfProfileId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/security-profiles/{profile_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityProfileRequest);
            return new SyncInvoker<UpdateSecurityProfileResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSecurityProfileResponse>);
        }
        
        /// <summary>
        /// 添加服务器证书
        ///
        /// 应用服务器可调用此接口在物联网平台上添加服务器证书，服务器证书配额限制为：2个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateServerCertificateResponse CreateServerCertificate(CreateServerCertificateRequest createServerCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/server-certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServerCertificateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateServerCertificateResponse>(response);
        }

        public SyncInvoker<CreateServerCertificateResponse> CreateServerCertificateInvoker(CreateServerCertificateRequest createServerCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/server-certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServerCertificateRequest);
            return new SyncInvoker<CreateServerCertificateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateServerCertificateResponse>);
        }
        
        /// <summary>
        /// 删除服务端证书
        ///
        /// 应用服务器可调用此接口在物联网平台删除服务器证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest deleteServerCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerCertificateRequest.ServerCertificateId, out var valueOfServerCertificateId)) urlParam.Add("server_certificate_id", valueOfServerCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/server-certificates/{server_certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerCertificateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteServerCertificateResponse>(response);
        }

        public SyncInvoker<DeleteServerCertificateResponse> DeleteServerCertificateInvoker(DeleteServerCertificateRequest deleteServerCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerCertificateRequest.ServerCertificateId, out var valueOfServerCertificateId)) urlParam.Add("server_certificate_id", valueOfServerCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/server-certificates/{server_certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerCertificateRequest);
            return new SyncInvoker<DeleteServerCertificateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteServerCertificateResponse>);
        }
        
        /// <summary>
        /// 获取服务器证书列表
        ///
        /// 应用服务器可调用此接口在物联网平台上获取服务器证书列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServerCertificateResponse ListServerCertificate(ListServerCertificateRequest listServerCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/server-certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerCertificateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServerCertificateResponse>(response);
        }

        public SyncInvoker<ListServerCertificateResponse> ListServerCertificateInvoker(ListServerCertificateRequest listServerCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/server-certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerCertificateRequest);
            return new SyncInvoker<ListServerCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerCertificateResponse>);
        }
        
        /// <summary>
        /// 查询服务器证书
        ///
        /// 应用服务器可调用此接口在物联网平台查询服务器证书
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerCertificateResponse ShowServerCertificate(ShowServerCertificateRequest showServerCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerCertificateRequest.ServerCertificateId, out var valueOfServerCertificateId)) urlParam.Add("server_certificate_id", valueOfServerCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/server-certificates/{server_certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerCertificateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerCertificateResponse>(response);
        }

        public SyncInvoker<ShowServerCertificateResponse> ShowServerCertificateInvoker(ShowServerCertificateRequest showServerCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerCertificateRequest.ServerCertificateId, out var valueOfServerCertificateId)) urlParam.Add("server_certificate_id", valueOfServerCertificateId);
            var urlPath = HttpUtils.AddUrlPath("/{project_id}/server-certificates/{server_certificate_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerCertificateRequest);
            return new SyncInvoker<ShowServerCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerCertificateResponse>);
        }
        
        /// <summary>
        /// 按标签查询资源
        ///
        /// 应用服务器可调用此接口查询绑定了指定标签的资源。当前支持标签的资源有Device(设备)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourcesByTagsResponse ListResourcesByTags(ListResourcesByTagsRequest listResourcesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/query-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListResourcesByTagsResponse>(response);
        }

        public SyncInvoker<ListResourcesByTagsResponse> ListResourcesByTagsInvoker(ListResourcesByTagsRequest listResourcesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/query-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagsRequest);
            return new SyncInvoker<ListResourcesByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourcesByTagsResponse>);
        }
        
        /// <summary>
        /// 绑定标签
        ///
        /// 应用服务器可调用此接口为指定资源绑定标签。当前支持标签的资源有Device(设备)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public TagDeviceResponse TagDevice(TagDeviceRequest tagDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/bind-resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagDeviceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<TagDeviceResponse>(response);
        }

        public SyncInvoker<TagDeviceResponse> TagDeviceInvoker(TagDeviceRequest tagDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/bind-resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagDeviceRequest);
            return new SyncInvoker<TagDeviceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<TagDeviceResponse>);
        }
        
        /// <summary>
        /// 解绑标签
        ///
        /// 应用服务器可调用此接口为指定资源解绑标签。当前支持标签的资源有Device(设备)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UntagDeviceResponse UntagDevice(UntagDeviceRequest untagDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/unbind-resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagDeviceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UntagDeviceResponse>(response);
        }

        public SyncInvoker<UntagDeviceResponse> UntagDeviceInvoker(UntagDeviceRequest untagDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tags/unbind-resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagDeviceRequest);
            return new SyncInvoker<UntagDeviceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UntagDeviceResponse>);
        }
        
        /// <summary>
        /// 创建设备隧道
        ///
        /// 用户可以通过该接口创建隧道（WebSocket协议），应用服务器和设备可以通过该隧道进行数据传输。
        /// 
        /// - 该API接口在基础版不支持。
        /// - 该API调用后平台会向对应的MQTT/MQTTS设备下发隧道地址及密钥，同时给应用服务器也返回隧道地址及密钥，设备可以通过该地址及密钥创建WebSocket协议连接。
        /// - 一个设备无法创建多个隧道。
        /// - 具体应用可见“设备远程登录”功能，请参见[[设备远程登录](https://support.huaweicloud.com/usermanual-iothub/iot_01_00301.html)](tag:hws)[[设备远程登录](https://support.huaweicloud.com/intl/zh-cn/usermanual-iothub/iot_01_00301.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddTunnelResponse AddTunnel(AddTunnelRequest addTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTunnelRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddTunnelResponse>(response);
        }

        public SyncInvoker<AddTunnelResponse> AddTunnelInvoker(AddTunnelRequest addTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTunnelRequest);
            return new SyncInvoker<AddTunnelResponse>(this, "POST", request, JsonUtils.DeSerialize<AddTunnelResponse>);
        }
        
        /// <summary>
        /// 关闭设备隧道
        ///
        /// 应用服务器可通过该接口关闭某个设备隧道。关闭后可以再次连接。
        /// - 该API接口在基础版不支持。
        /// - 具体应用可见“设备远程登录”功能，请参见[[设备远程登录](https://support.huaweicloud.com/usermanual-iothub/iot_01_00301.html)](tag:hws)[[设备远程登录](https://support.huaweicloud.com/intl/zh-cn/usermanual-iothub/iot_01_00301.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CloseDeviceTunnelResponse CloseDeviceTunnel(CloseDeviceTunnelRequest closeDeviceTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(closeDeviceTunnelRequest.TunnelId, out var valueOfTunnelId)) urlParam.Add("tunnel_id", valueOfTunnelId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels/{tunnel_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeDeviceTunnelRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<CloseDeviceTunnelResponse>(response);
        }

        public SyncInvoker<CloseDeviceTunnelResponse> CloseDeviceTunnelInvoker(CloseDeviceTunnelRequest closeDeviceTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(closeDeviceTunnelRequest.TunnelId, out var valueOfTunnelId)) urlParam.Add("tunnel_id", valueOfTunnelId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels/{tunnel_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeDeviceTunnelRequest);
            return new SyncInvoker<CloseDeviceTunnelResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CloseDeviceTunnelResponse>);
        }
        
        /// <summary>
        /// 删除设备隧道
        ///
        /// 用户可通过该接口删除某个设备隧道。删除后该通道不存在，无法再次连接。
        /// - 该API接口在基础版不支持。
        /// - 具体应用可见“设备远程登录”功能，请参见[[设备远程登录](https://support.huaweicloud.com/usermanual-iothub/iot_01_00301.html)](tag:hws)[[设备远程登录](https://support.huaweicloud.com/intl/zh-cn/usermanual-iothub/iot_01_00301.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDeviceTunnelResponse DeleteDeviceTunnel(DeleteDeviceTunnelRequest deleteDeviceTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceTunnelRequest.TunnelId, out var valueOfTunnelId)) urlParam.Add("tunnel_id", valueOfTunnelId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels/{tunnel_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceTunnelRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDeviceTunnelResponse>(response);
        }

        public SyncInvoker<DeleteDeviceTunnelResponse> DeleteDeviceTunnelInvoker(DeleteDeviceTunnelRequest deleteDeviceTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeviceTunnelRequest.TunnelId, out var valueOfTunnelId)) urlParam.Add("tunnel_id", valueOfTunnelId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels/{tunnel_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeviceTunnelRequest);
            return new SyncInvoker<DeleteDeviceTunnelResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDeviceTunnelResponse>);
        }
        
        /// <summary>
        /// 查询设备所有隧道
        ///
        /// 用户可通过该接口查询某项目下的所有设备隧道，以实现对设备管理。应用服务器可通过此接口向平台查询设备隧道建立的情况。
        /// - 该API接口在基础版不支持。
        /// - 具体应用可见“设备远程登录”功能，请参见[[设备远程登录](https://support.huaweicloud.com/usermanual-iothub/iot_01_00301.html)](tag:hws)[[设备远程登录](https://support.huaweicloud.com/intl/zh-cn/usermanual-iothub/iot_01_00301.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDeviceTunnelsResponse ListDeviceTunnels(ListDeviceTunnelsRequest listDeviceTunnelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceTunnelsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDeviceTunnelsResponse>(response);
        }

        public SyncInvoker<ListDeviceTunnelsResponse> ListDeviceTunnelsInvoker(ListDeviceTunnelsRequest listDeviceTunnelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDeviceTunnelsRequest);
            return new SyncInvoker<ListDeviceTunnelsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDeviceTunnelsResponse>);
        }
        
        /// <summary>
        /// 查询设备隧道
        ///
        /// 用户可通过该接口查询某项目中的某个设备隧道，查看该设备隧道的信息与连接情况。应用服务器可调用此接口向平台查询设备隧道建立情况。
        /// - 该API接口在基础版不支持。
        /// - 具体应用可见“设备远程登录”功能，请参见[[设备远程登录](https://support.huaweicloud.com/usermanual-iothub/iot_01_00301.html)](tag:hws)[[设备远程登录](https://support.huaweicloud.com/intl/zh-cn/usermanual-iothub/iot_01_00301.html)](tag:hws_hk)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDeviceTunnelResponse ShowDeviceTunnel(ShowDeviceTunnelRequest showDeviceTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceTunnelRequest.TunnelId, out var valueOfTunnelId)) urlParam.Add("tunnel_id", valueOfTunnelId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels/{tunnel_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceTunnelRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDeviceTunnelResponse>(response);
        }

        public SyncInvoker<ShowDeviceTunnelResponse> ShowDeviceTunnelInvoker(ShowDeviceTunnelRequest showDeviceTunnelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDeviceTunnelRequest.TunnelId, out var valueOfTunnelId)) urlParam.Add("tunnel_id", valueOfTunnelId);
            var urlPath = HttpUtils.AddUrlPath("/v5/iot/{project_id}/tunnels/{tunnel_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDeviceTunnelRequest);
            return new SyncInvoker<ShowDeviceTunnelResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDeviceTunnelResponse>);
        }
        
    }
}