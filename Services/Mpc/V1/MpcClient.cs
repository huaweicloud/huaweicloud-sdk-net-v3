using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Mpc.V1.Model;

namespace HuaweiCloud.SDK.Mpc.V1
{
    public partial class MpcClient : Client
    {
        public static ClientBuilder<MpcClient> NewBuilder()
        {
            return new ClientBuilder<MpcClient>();
        }

        
        /// <summary>
        /// 新建转动图任务
        ///
        /// 创建动图任务，用于将完整的视频文件或视频文件中的一部分转换为动态图文件，暂只支持输出GIF文件。
        /// 待转动图的视频文件需要存储在与媒体处理服务同区域的OBS桶中，且该OBS桶已授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAnimatedGraphicsTaskResponse CreateAnimatedGraphicsTask(CreateAnimatedGraphicsTaskRequest createAnimatedGraphicsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAnimatedGraphicsTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAnimatedGraphicsTaskResponse>(response);
        }

        public SyncInvoker<CreateAnimatedGraphicsTaskResponse> CreateAnimatedGraphicsTaskInvoker(CreateAnimatedGraphicsTaskRequest createAnimatedGraphicsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAnimatedGraphicsTaskRequest);
            return new SyncInvoker<CreateAnimatedGraphicsTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAnimatedGraphicsTaskResponse>);
        }
        
        /// <summary>
        /// 取消转动图任务
        ///
        /// 取消已下发的生成动图任务，仅支持取消正在排队中的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAnimatedGraphicsTaskResponse DeleteAnimatedGraphicsTask(DeleteAnimatedGraphicsTaskRequest deleteAnimatedGraphicsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAnimatedGraphicsTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAnimatedGraphicsTaskResponse>(response);
        }

        public SyncInvoker<DeleteAnimatedGraphicsTaskResponse> DeleteAnimatedGraphicsTaskInvoker(DeleteAnimatedGraphicsTaskRequest deleteAnimatedGraphicsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAnimatedGraphicsTaskRequest);
            return new SyncInvoker<DeleteAnimatedGraphicsTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAnimatedGraphicsTaskResponse>);
        }
        
        /// <summary>
        /// 查询转动图任务
        ///
        /// 查询动图任务的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAnimatedGraphicsTaskResponse ListAnimatedGraphicsTask(ListAnimatedGraphicsTaskRequest listAnimatedGraphicsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAnimatedGraphicsTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAnimatedGraphicsTaskResponse>(response);
        }

        public SyncInvoker<ListAnimatedGraphicsTaskResponse> ListAnimatedGraphicsTaskInvoker(ListAnimatedGraphicsTaskRequest listAnimatedGraphicsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAnimatedGraphicsTaskRequest);
            return new SyncInvoker<ListAnimatedGraphicsTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAnimatedGraphicsTaskResponse>);
        }
        
        /// <summary>
        /// 请求委托任务
        ///
        /// 开启或关闭\&quot;委托授权\&quot;, 开启后，媒体处理服务将拥有您所有桶的读写权限，子账号不支持委托授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAgenciesTaskResponse CreateAgenciesTask(CreateAgenciesTaskRequest createAgenciesTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgenciesTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateAgenciesTaskResponse>(response);
        }

        public SyncInvoker<CreateAgenciesTaskResponse> CreateAgenciesTaskInvoker(CreateAgenciesTaskRequest createAgenciesTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgenciesTaskRequest);
            return new SyncInvoker<CreateAgenciesTaskResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateAgenciesTaskResponse>);
        }
        
        /// <summary>
        /// 查询桶列表
        ///
        /// 请求查询自己创建的指定的桶区域位置的桶列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllBucketsResponse ListAllBuckets(ListAllBucketsRequest listAllBucketsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllBucketsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllBucketsResponse>(response);
        }

        public SyncInvoker<ListAllBucketsResponse> ListAllBucketsInvoker(ListAllBucketsRequest listAllBucketsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllBucketsRequest);
            return new SyncInvoker<ListAllBucketsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllBucketsResponse>);
        }
        
        /// <summary>
        /// 查询桶里的object
        ///
        /// 查询桶里的object。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllObsObjListResponse ListAllObsObjList(ListAllObsObjListRequest listAllObsObjListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0-ext/{project_id}/objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllObsObjListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllObsObjListResponse>(response);
        }

        public SyncInvoker<ListAllObsObjListResponse> ListAllObsObjListInvoker(ListAllObsObjListRequest listAllObsObjListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0-ext/{project_id}/objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllObsObjListRequest);
            return new SyncInvoker<ListAllObsObjListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllObsObjListResponse>);
        }
        
        /// <summary>
        /// 查询转码服务端所有事件
        ///
        /// 查询消息订阅功能板块, SMN主题的所有订阅事件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNotifyEventResponse ListNotifyEvent(ListNotifyEventRequest listNotifyEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification/event", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifyEventRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNotifyEventResponse>(response);
        }

        public SyncInvoker<ListNotifyEventResponse> ListNotifyEventInvoker(ListNotifyEventRequest listNotifyEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification/event", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifyEventRequest);
            return new SyncInvoker<ListNotifyEventResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotifyEventResponse>);
        }
        
        /// <summary>
        /// 查询转码服务端事件通知
        ///
        /// 查询消息订阅功能板块, SMN主题的订阅事件的启用状态和订阅消息的启用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNotifySmnTopicConfigResponse ListNotifySmnTopicConfig(ListNotifySmnTopicConfigRequest listNotifySmnTopicConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifySmnTopicConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNotifySmnTopicConfigResponse>(response);
        }

        public SyncInvoker<ListNotifySmnTopicConfigResponse> ListNotifySmnTopicConfigInvoker(ListNotifySmnTopicConfigRequest listNotifySmnTopicConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifySmnTopicConfigRequest);
            return new SyncInvoker<ListNotifySmnTopicConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotifySmnTopicConfigResponse>);
        }
        
        /// <summary>
        /// 配置转码服务端事件通知
        ///
        /// 配置转码服务端事件通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public NotifySmnTopicConfigResponse NotifySmnTopicConfig(NotifySmnTopicConfigRequest notifySmnTopicConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", notifySmnTopicConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<NotifySmnTopicConfigResponse>(response);
        }

        public SyncInvoker<NotifySmnTopicConfigResponse> NotifySmnTopicConfigInvoker(NotifySmnTopicConfigRequest notifySmnTopicConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", notifySmnTopicConfigRequest);
            return new SyncInvoker<NotifySmnTopicConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<NotifySmnTopicConfigResponse>);
        }
        
        /// <summary>
        /// 查询创建委托任务状态
        ///
        /// 查询创建委托任务状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAgenciesTaskResponse ShowAgenciesTask(ShowAgenciesTaskRequest showAgenciesTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgenciesTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAgenciesTaskResponse>(response);
        }

        public SyncInvoker<ShowAgenciesTaskResponse> ShowAgenciesTaskInvoker(ShowAgenciesTaskRequest showAgenciesTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgenciesTaskRequest);
            return new SyncInvoker<ShowAgenciesTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAgenciesTaskResponse>);
        }
        
        /// <summary>
        /// 桶授权或取消授权
        ///
        /// 对OBS桶进行授权或取消授权，媒体处理服务仅拥有已授权桶的读写权限。（暂不支持KMS加密桶的授权）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBucketAuthorizedResponse UpdateBucketAuthorized(UpdateBucketAuthorizedRequest updateBucketAuthorizedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/authority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBucketAuthorizedRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateBucketAuthorizedResponse>(response);
        }

        public SyncInvoker<UpdateBucketAuthorizedResponse> UpdateBucketAuthorizedInvoker(UpdateBucketAuthorizedRequest updateBucketAuthorizedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/authority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBucketAuthorizedRequest);
            return new SyncInvoker<UpdateBucketAuthorizedResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateBucketAuthorizedResponse>);
        }
        
        /// <summary>
        /// 新建剪辑任务
        ///
        /// 创建剪辑任务，用于将多个视频文件进行裁剪成多个视频分段，并且可以把这些视频分段合并成一个视频，剪切和拼接功能可以单独使用。
        /// 待剪辑的视频文件需要存储在与媒体处理服务同区域的OBS桶中，且该OBS桶已授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEditingJobResponse CreateEditingJob(CreateEditingJobRequest createEditingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEditingJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEditingJobResponse>(response);
        }

        public SyncInvoker<CreateEditingJobResponse> CreateEditingJobInvoker(CreateEditingJobRequest createEditingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEditingJobRequest);
            return new SyncInvoker<CreateEditingJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEditingJobResponse>);
        }
        
        /// <summary>
        /// 取消剪辑任务
        ///
        /// 取消已下发的生成剪辑任务，仅支持取消正在排队中的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEditingJobResponse DeleteEditingJob(DeleteEditingJobRequest deleteEditingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEditingJobRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEditingJobResponse>(response);
        }

        public SyncInvoker<DeleteEditingJobResponse> DeleteEditingJobInvoker(DeleteEditingJobRequest deleteEditingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEditingJobRequest);
            return new SyncInvoker<DeleteEditingJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEditingJobResponse>);
        }
        
        /// <summary>
        /// 查询剪辑任务
        ///
        /// 查询剪辑任务的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEditingJobResponse ListEditingJob(ListEditingJobRequest listEditingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEditingJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEditingJobResponse>(response);
        }

        public SyncInvoker<ListEditingJobResponse> ListEditingJobInvoker(ListEditingJobRequest listEditingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEditingJobRequest);
            return new SyncInvoker<ListEditingJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEditingJobResponse>);
        }
        
        /// <summary>
        /// 新建独立加密任务
        ///
        /// 支持独立加密，包括创建、查询、删除独立加密任务。该API已废弃。
        /// 
        /// 约束：
        ///   - 只支持转码后的文件进行加密。
        ///   - 加密的文件必须是m3u8或者mpd结尾的文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEncryptTaskResponse CreateEncryptTask(CreateEncryptTaskRequest createEncryptTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEncryptTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEncryptTaskResponse>(response);
        }

        public SyncInvoker<CreateEncryptTaskResponse> CreateEncryptTaskInvoker(CreateEncryptTaskRequest createEncryptTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEncryptTaskRequest);
            return new SyncInvoker<CreateEncryptTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEncryptTaskResponse>);
        }
        
        /// <summary>
        /// 取消独立加密任务
        ///
        /// 取消独立加密任务。该API已废弃。
        /// 
        /// 约束：
        /// 
        ///   只能取消正在任务队列中排队的任务。已开始加密或已完成的加密任务不能取消。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEncryptTaskResponse DeleteEncryptTask(DeleteEncryptTaskRequest deleteEncryptTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEncryptTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEncryptTaskResponse>(response);
        }

        public SyncInvoker<DeleteEncryptTaskResponse> DeleteEncryptTaskInvoker(DeleteEncryptTaskRequest deleteEncryptTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEncryptTaskRequest);
            return new SyncInvoker<DeleteEncryptTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEncryptTaskResponse>);
        }
        
        /// <summary>
        /// 查询独立加密任务
        ///
        /// 查询独立加密任务状态。返回任务执行结果或当前状态。该API已废弃。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEncryptTaskResponse ListEncryptTask(ListEncryptTaskRequest listEncryptTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEncryptTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEncryptTaskResponse>(response);
        }

        public SyncInvoker<ListEncryptTaskResponse> ListEncryptTaskInvoker(ListEncryptTaskRequest listEncryptTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEncryptTaskRequest);
            return new SyncInvoker<ListEncryptTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEncryptTaskResponse>);
        }
        
        /// <summary>
        /// 新建视频解析任务
        ///
        /// 创建视频解析任务，解析视频元数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateExtractTaskResponse CreateExtractTask(CreateExtractTaskRequest createExtractTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExtractTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateExtractTaskResponse>(response);
        }

        public SyncInvoker<CreateExtractTaskResponse> CreateExtractTaskInvoker(CreateExtractTaskRequest createExtractTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExtractTaskRequest);
            return new SyncInvoker<CreateExtractTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateExtractTaskResponse>);
        }
        
        /// <summary>
        /// 取消视频解析任务
        ///
        /// 取消已下发的视频解析任务，仅支持取消正在排队中的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteExtractTaskResponse DeleteExtractTask(DeleteExtractTaskRequest deleteExtractTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExtractTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteExtractTaskResponse>(response);
        }

        public SyncInvoker<DeleteExtractTaskResponse> DeleteExtractTaskInvoker(DeleteExtractTaskRequest deleteExtractTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExtractTaskRequest);
            return new SyncInvoker<DeleteExtractTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteExtractTaskResponse>);
        }
        
        /// <summary>
        /// 查询视频解析任务
        ///
        /// 查询解析任务的状态和结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListExtractTaskResponse ListExtractTask(ListExtractTaskRequest listExtractTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExtractTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListExtractTaskResponse>(response);
        }

        public SyncInvoker<ListExtractTaskResponse> ListExtractTaskInvoker(ListExtractTaskRequest listExtractTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExtractTaskRequest);
            return new SyncInvoker<ListExtractTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListExtractTaskResponse>);
        }
        
        /// <summary>
        /// 合并多声道任务、重置声轨任务上报接口
        ///
        /// ## 典型场景 ##
        ///   合并音频多声道文件任务、重置音频文件声轨任务上报结果接口。
        /// ## 接口功能 ##
        ///   合并音频多声道文件任务、重置音频文件声轨任务上报结果接口。
        /// ## 接口约束 ##
        ///   无。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMbTasksReportResponse CreateMbTasksReport(CreateMbTasksReportRequest createMbTasksReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mediabox/tasks/report", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMbTasksReportRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<CreateMbTasksReportResponse>(response);
        }

        public SyncInvoker<CreateMbTasksReportResponse> CreateMbTasksReportInvoker(CreateMbTasksReportRequest createMbTasksReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mediabox/tasks/report", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMbTasksReportRequest);
            return new SyncInvoker<CreateMbTasksReportResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CreateMbTasksReportResponse>);
        }
        
        /// <summary>
        /// 创建声道合并任务
        ///
        /// 创建声道合并任务，合并声道任务支持将每个声道各放一个文件中的片源，合并为单个音频文件。
        /// 执行合并声道的源音频文件需要存储在与媒体处理服务同区域的OBS桶中，且该OBS桶已授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMergeChannelsTaskResponse CreateMergeChannelsTask(CreateMergeChannelsTaskRequest createMergeChannelsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeChannelsTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeChannelsTaskResponse>(response);
        }

        public SyncInvoker<CreateMergeChannelsTaskResponse> CreateMergeChannelsTaskInvoker(CreateMergeChannelsTaskRequest createMergeChannelsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeChannelsTaskRequest);
            return new SyncInvoker<CreateMergeChannelsTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeChannelsTaskResponse>);
        }
        
        /// <summary>
        /// 创建音轨重置任务
        ///
        /// 创建音轨重置任务，重置音轨任务支持按人工指定关系声道layout，语言标签，转封装片源，使其满足转码输入。
        /// 执行音轨重置的源音频文件需要存储在与媒体处理服务同区域的OBS桶中，且该OBS桶已授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateResetTracksTaskResponse CreateResetTracksTask(CreateResetTracksTaskRequest createResetTracksTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResetTracksTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateResetTracksTaskResponse>(response);
        }

        public SyncInvoker<CreateResetTracksTaskResponse> CreateResetTracksTaskInvoker(CreateResetTracksTaskRequest createResetTracksTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResetTracksTaskRequest);
            return new SyncInvoker<CreateResetTracksTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResetTracksTaskResponse>);
        }
        
        /// <summary>
        /// 取消声道合并任务
        ///
        /// 取消合并音频多声道文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMergeChannelsTaskResponse DeleteMergeChannelsTask(DeleteMergeChannelsTaskRequest deleteMergeChannelsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeChannelsTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMergeChannelsTaskResponse>(response);
        }

        public SyncInvoker<DeleteMergeChannelsTaskResponse> DeleteMergeChannelsTaskInvoker(DeleteMergeChannelsTaskRequest deleteMergeChannelsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeChannelsTaskRequest);
            return new SyncInvoker<DeleteMergeChannelsTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMergeChannelsTaskResponse>);
        }
        
        /// <summary>
        /// 取消音轨重置任务
        ///
        /// 取消重置音频文件声轨任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteResetTracksTaskResponse DeleteResetTracksTask(DeleteResetTracksTaskRequest deleteResetTracksTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResetTracksTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteResetTracksTaskResponse>(response);
        }

        public SyncInvoker<DeleteResetTracksTaskResponse> DeleteResetTracksTaskInvoker(DeleteResetTracksTaskRequest deleteResetTracksTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResetTracksTaskRequest);
            return new SyncInvoker<DeleteResetTracksTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteResetTracksTaskResponse>);
        }
        
        /// <summary>
        /// 查询声道合并任务
        ///
        /// 查询声道合并任务的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeChannelsTaskResponse ListMergeChannelsTask(ListMergeChannelsTaskRequest listMergeChannelsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeChannelsTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMergeChannelsTaskResponse>(response);
        }

        public SyncInvoker<ListMergeChannelsTaskResponse> ListMergeChannelsTaskInvoker(ListMergeChannelsTaskRequest listMergeChannelsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeChannelsTaskRequest);
            return new SyncInvoker<ListMergeChannelsTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeChannelsTaskResponse>);
        }
        
        /// <summary>
        /// 查询音轨重置任务
        ///
        /// 查询音轨重置任务的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResetTracksTaskResponse ListResetTracksTask(ListResetTracksTaskRequest listResetTracksTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResetTracksTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResetTracksTaskResponse>(response);
        }

        public SyncInvoker<ListResetTracksTaskResponse> ListResetTracksTaskInvoker(ListResetTracksTaskRequest listResetTracksTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResetTracksTaskRequest);
            return new SyncInvoker<ListResetTracksTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResetTracksTaskResponse>);
        }
        
        /// <summary>
        /// 创建视频增强任务
        ///
        /// ## 典型场景 ##
        ///   创建视频增强任务。
        /// 
        /// ## 接口功能 ##
        ///   创建视频增强任务。
        /// 
        /// ## 接口约束 ##
        ///   无。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMediaProcessTaskResponse CreateMediaProcessTask(CreateMediaProcessTaskRequest createMediaProcessTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMediaProcessTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMediaProcessTaskResponse>(response);
        }

        public SyncInvoker<CreateMediaProcessTaskResponse> CreateMediaProcessTaskInvoker(CreateMediaProcessTaskRequest createMediaProcessTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMediaProcessTaskRequest);
            return new SyncInvoker<CreateMediaProcessTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMediaProcessTaskResponse>);
        }
        
        /// <summary>
        /// 取消视频增强任务
        ///
        /// ## 典型场景 ##
        ///   取消视频增强任务。
        /// 
        /// ## 接口功能 ##
        ///   取消视频增强任务。
        /// 
        /// ## 接口约束 ##
        ///   仅可删除正在排队中的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMediaProcessTaskResponse DeleteMediaProcessTask(DeleteMediaProcessTaskRequest deleteMediaProcessTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMediaProcessTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMediaProcessTaskResponse>(response);
        }

        public SyncInvoker<DeleteMediaProcessTaskResponse> DeleteMediaProcessTaskInvoker(DeleteMediaProcessTaskRequest deleteMediaProcessTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMediaProcessTaskRequest);
            return new SyncInvoker<DeleteMediaProcessTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMediaProcessTaskResponse>);
        }
        
        /// <summary>
        /// 查询视频增强任务
        ///
        /// ## 典型场景 ##
        ///   查询视频增强任务。
        /// 
        /// ## 接口功能 ##
        ///   查询视频增强任务。
        /// 
        /// ## 接口约束 ##
        ///   无。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMediaProcessTaskResponse ListMediaProcessTask(ListMediaProcessTaskRequest listMediaProcessTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMediaProcessTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMediaProcessTaskResponse>(response);
        }

        public SyncInvoker<ListMediaProcessTaskResponse> ListMediaProcessTaskInvoker(ListMediaProcessTaskRequest listMediaProcessTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMediaProcessTaskRequest);
            return new SyncInvoker<ListMediaProcessTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMediaProcessTaskResponse>);
        }
        
        /// <summary>
        /// mpe通知mpc
        ///
        /// ## 典型场景 ##
        ///   mpe通知mpc。
        /// ## 接口功能 ##
        ///   mpe调用此接口通知mpc转封装等结果。
        /// ## 接口约束 ##
        ///   无。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMpeCallBackResponse CreateMpeCallBack(CreateMpeCallBackRequest createMpeCallBackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mpe/notification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMpeCallBackRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateMpeCallBackResponse>(response);
        }

        public SyncInvoker<CreateMpeCallBackResponse> CreateMpeCallBackInvoker(CreateMpeCallBackRequest createMpeCallBackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/mpe/notification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMpeCallBackRequest);
            return new SyncInvoker<CreateMpeCallBackResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateMpeCallBackResponse>);
        }
        
        /// <summary>
        /// 创建视频增强模板
        ///
        /// 创建视频增强模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateQualityEnhanceTemplateResponse CreateQualityEnhanceTemplate(CreateQualityEnhanceTemplateRequest createQualityEnhanceTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createQualityEnhanceTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateQualityEnhanceTemplateResponse>(response);
        }

        public SyncInvoker<CreateQualityEnhanceTemplateResponse> CreateQualityEnhanceTemplateInvoker(CreateQualityEnhanceTemplateRequest createQualityEnhanceTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createQualityEnhanceTemplateRequest);
            return new SyncInvoker<CreateQualityEnhanceTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateQualityEnhanceTemplateResponse>);
        }
        
        /// <summary>
        /// 删除用户视频增强模板
        ///
        /// 删除用户视频增强模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteQualityEnhanceTemplateResponse DeleteQualityEnhanceTemplate(DeleteQualityEnhanceTemplateRequest deleteQualityEnhanceTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQualityEnhanceTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteQualityEnhanceTemplateResponse>(response);
        }

        public SyncInvoker<DeleteQualityEnhanceTemplateResponse> DeleteQualityEnhanceTemplateInvoker(DeleteQualityEnhanceTemplateRequest deleteQualityEnhanceTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQualityEnhanceTemplateRequest);
            return new SyncInvoker<DeleteQualityEnhanceTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteQualityEnhanceTemplateResponse>);
        }
        
        /// <summary>
        /// 查询视频增强预置模板
        ///
        /// 查询视频增强预置模板，返回所有结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQualityEnhanceDefaultTemplateResponse ListQualityEnhanceDefaultTemplate(ListQualityEnhanceDefaultTemplateRequest listQualityEnhanceDefaultTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance/default", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQualityEnhanceDefaultTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQualityEnhanceDefaultTemplateResponse>(response);
        }

        public SyncInvoker<ListQualityEnhanceDefaultTemplateResponse> ListQualityEnhanceDefaultTemplateInvoker(ListQualityEnhanceDefaultTemplateRequest listQualityEnhanceDefaultTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance/default", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQualityEnhanceDefaultTemplateRequest);
            return new SyncInvoker<ListQualityEnhanceDefaultTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQualityEnhanceDefaultTemplateResponse>);
        }
        
        /// <summary>
        /// 更新视频增强模板
        ///
        /// 更新视频增强模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateQualityEnhanceTemplateResponse UpdateQualityEnhanceTemplate(UpdateQualityEnhanceTemplateRequest updateQualityEnhanceTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateQualityEnhanceTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateQualityEnhanceTemplateResponse>(response);
        }

        public SyncInvoker<UpdateQualityEnhanceTemplateResponse> UpdateQualityEnhanceTemplateInvoker(UpdateQualityEnhanceTemplateRequest updateQualityEnhanceTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateQualityEnhanceTemplateRequest);
            return new SyncInvoker<UpdateQualityEnhanceTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateQualityEnhanceTemplateResponse>);
        }
        
        /// <summary>
        /// 查询媒资转码详情
        ///
        /// 查询媒资转码详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTranscodeDetailResponse ListTranscodeDetail(ListTranscodeDetailRequest listTranscodeDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTranscodeDetailResponse>(response);
        }

        public SyncInvoker<ListTranscodeDetailResponse> ListTranscodeDetailInvoker(ListTranscodeDetailRequest listTranscodeDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeDetailRequest);
            return new SyncInvoker<ListTranscodeDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTranscodeDetailResponse>);
        }
        
        /// <summary>
        /// 取消转封装任务
        ///
        /// 取消已下发的转封装任务，仅支持取消正在排队中的任务。。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelRemuxTaskResponse CancelRemuxTask(CancelRemuxTaskRequest cancelRemuxTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRemuxTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<CancelRemuxTaskResponse>(response);
        }

        public SyncInvoker<CancelRemuxTaskResponse> CancelRemuxTaskInvoker(CancelRemuxTaskRequest cancelRemuxTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRemuxTaskRequest);
            return new SyncInvoker<CancelRemuxTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CancelRemuxTaskResponse>);
        }
        
        /// <summary>
        /// 新建转封装任务
        ///
        /// 创建转封装任务，转换音视频文件的格式，但不改变其分辨率和码率。
        /// 待转封装的媒资文件需要存储在与媒体处理服务同区域的OBS桶中，且该OBS桶已授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRemuxTaskResponse CreateRemuxTask(CreateRemuxTaskRequest createRemuxTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRemuxTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRemuxTaskResponse>(response);
        }

        public SyncInvoker<CreateRemuxTaskResponse> CreateRemuxTaskInvoker(CreateRemuxTaskRequest createRemuxTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRemuxTaskRequest);
            return new SyncInvoker<CreateRemuxTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRemuxTaskResponse>);
        }
        
        /// <summary>
        /// 重试转封装任务
        ///
        /// 对失败的转封装任务进行重试。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRetryRemuxTaskResponse CreateRetryRemuxTask(CreateRetryRemuxTaskRequest createRetryRemuxTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetryRemuxTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<CreateRetryRemuxTaskResponse>(response);
        }

        public SyncInvoker<CreateRetryRemuxTaskResponse> CreateRetryRemuxTaskInvoker(CreateRetryRemuxTaskRequest createRetryRemuxTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetryRemuxTaskRequest);
            return new SyncInvoker<CreateRetryRemuxTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CreateRetryRemuxTaskResponse>);
        }
        
        /// <summary>
        /// 删除转封装任务记录
        ///
        /// 删除转封装任务记录，只能删除状态为“已取消”，“转码成功”，“转码失败”的任务记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRemuxTaskResponse DeleteRemuxTask(DeleteRemuxTaskRequest deleteRemuxTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRemuxTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRemuxTaskResponse>(response);
        }

        public SyncInvoker<DeleteRemuxTaskResponse> DeleteRemuxTaskInvoker(DeleteRemuxTaskRequest deleteRemuxTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRemuxTaskRequest);
            return new SyncInvoker<DeleteRemuxTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRemuxTaskResponse>);
        }
        
        /// <summary>
        /// 查询转封装任务
        ///
        /// 查询转封装任务状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRemuxTaskResponse ListRemuxTask(ListRemuxTaskRequest listRemuxTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRemuxTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRemuxTaskResponse>(response);
        }

        public SyncInvoker<ListRemuxTaskResponse> ListRemuxTaskInvoker(ListRemuxTaskRequest listRemuxTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRemuxTaskRequest);
            return new SyncInvoker<ListRemuxTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRemuxTaskResponse>);
        }
        
        /// <summary>
        /// 新建转码模板组
        ///
        /// 新建转码模板组，最多支持一进六出。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTemplateGroupResponse CreateTemplateGroup(CreateTemplateGroupRequest createTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTemplateGroupResponse>(response);
        }

        public SyncInvoker<CreateTemplateGroupResponse> CreateTemplateGroupInvoker(CreateTemplateGroupRequest createTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupRequest);
            return new SyncInvoker<CreateTemplateGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemplateGroupResponse>);
        }
        
        /// <summary>
        /// 删除转码模板组
        ///
        /// 删除转码模板组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTemplateGroupResponse DeleteTemplateGroup(DeleteTemplateGroupRequest deleteTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTemplateGroupResponse>(response);
        }

        public SyncInvoker<DeleteTemplateGroupResponse> DeleteTemplateGroupInvoker(DeleteTemplateGroupRequest deleteTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupRequest);
            return new SyncInvoker<DeleteTemplateGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTemplateGroupResponse>);
        }
        
        /// <summary>
        /// 查询转码模板组
        ///
        /// 查询转码模板组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTemplateGroupResponse ListTemplateGroup(ListTemplateGroupRequest listTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTemplateGroupResponse>(response);
        }

        public SyncInvoker<ListTemplateGroupResponse> ListTemplateGroupInvoker(ListTemplateGroupRequest listTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupRequest);
            return new SyncInvoker<ListTemplateGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplateGroupResponse>);
        }
        
        /// <summary>
        /// 更新转码模板组
        ///
        /// 修改模板组接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTemplateGroupResponse UpdateTemplateGroup(UpdateTemplateGroupRequest updateTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTemplateGroupResponse>(response);
        }

        public SyncInvoker<UpdateTemplateGroupResponse> UpdateTemplateGroupInvoker(UpdateTemplateGroupRequest updateTemplateGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupRequest);
            return new SyncInvoker<UpdateTemplateGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTemplateGroupResponse>);
        }
        
        /// <summary>
        /// 新建截图任务
        ///
        /// 新建截图任务，视频截图将从首帧开始，按设置的时间间隔截图，最后截取末帧。
        /// 待截图的视频文件需要存储在与媒体处理服务同区域的OBS桶中，且该OBS桶已授权。
        /// 
        /// 约束：
        ///   暂只支持生成JPG格式的图片文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateThumbnailsTaskResponse CreateThumbnailsTask(CreateThumbnailsTaskRequest createThumbnailsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createThumbnailsTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateThumbnailsTaskResponse>(response);
        }

        public SyncInvoker<CreateThumbnailsTaskResponse> CreateThumbnailsTaskInvoker(CreateThumbnailsTaskRequest createThumbnailsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createThumbnailsTaskRequest);
            return new SyncInvoker<CreateThumbnailsTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateThumbnailsTaskResponse>);
        }
        
        /// <summary>
        /// 取消截图任务
        ///
        /// 取消已下发截图任务。
        /// 只能取消已接受尚在队列中等待处理的任务，已完成或正在执行阶段的任务不能取消。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteThumbnailsTaskResponse DeleteThumbnailsTask(DeleteThumbnailsTaskRequest deleteThumbnailsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteThumbnailsTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteThumbnailsTaskResponse>(response);
        }

        public SyncInvoker<DeleteThumbnailsTaskResponse> DeleteThumbnailsTaskInvoker(DeleteThumbnailsTaskRequest deleteThumbnailsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteThumbnailsTaskRequest);
            return new SyncInvoker<DeleteThumbnailsTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteThumbnailsTaskResponse>);
        }
        
        /// <summary>
        /// 查询截图任务
        ///
        /// 查询截图任务状态。返回任务执行结果，包括状态、输入、输出等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListThumbnailsTaskResponse ListThumbnailsTask(ListThumbnailsTaskRequest listThumbnailsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listThumbnailsTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListThumbnailsTaskResponse>(response);
        }

        public SyncInvoker<ListThumbnailsTaskResponse> ListThumbnailsTaskInvoker(ListThumbnailsTaskRequest listThumbnailsTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listThumbnailsTaskRequest);
            return new SyncInvoker<ListThumbnailsTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListThumbnailsTaskResponse>);
        }
        
        /// <summary>
        /// 新建转码任务
        ///
        /// 新建转码任务可以将视频进行转码，并在转码过程中压制水印、视频截图等。视频转码前需要配置转码模板。
        /// 待转码的音视频需要存储在与媒体处理服务同区域的OBS桶中，且该OBS桶已授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTranscodingTaskResponse CreateTranscodingTask(CreateTranscodingTaskRequest createTranscodingTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTranscodingTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTranscodingTaskResponse>(response);
        }

        public SyncInvoker<CreateTranscodingTaskResponse> CreateTranscodingTaskInvoker(CreateTranscodingTaskRequest createTranscodingTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTranscodingTaskRequest);
            return new SyncInvoker<CreateTranscodingTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTranscodingTaskResponse>);
        }
        
        /// <summary>
        /// 取消转码任务
        ///
        /// 取消已下发转码任务。
        /// 只能取消正在转码任务队列中排队的转码任务。已开始转码或已完成的转码任务不能取消。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTranscodingTaskResponse DeleteTranscodingTask(DeleteTranscodingTaskRequest deleteTranscodingTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTranscodingTaskResponse>(response);
        }

        public SyncInvoker<DeleteTranscodingTaskResponse> DeleteTranscodingTaskInvoker(DeleteTranscodingTaskRequest deleteTranscodingTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingTaskRequest);
            return new SyncInvoker<DeleteTranscodingTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTranscodingTaskResponse>);
        }
        
        /// <summary>
        /// 删除转码任务记录
        ///
        /// 删除转码任务记录，只能删除状态为“已取消”，“转码成功”，“转码失败”的转码任务记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTranscodingTaskByConsoleResponse DeleteTranscodingTaskByConsole(DeleteTranscodingTaskByConsoleRequest deleteTranscodingTaskByConsoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingTaskByConsoleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTranscodingTaskByConsoleResponse>(response);
        }

        public SyncInvoker<DeleteTranscodingTaskByConsoleResponse> DeleteTranscodingTaskByConsoleInvoker(DeleteTranscodingTaskByConsoleRequest deleteTranscodingTaskByConsoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingTaskByConsoleRequest);
            return new SyncInvoker<DeleteTranscodingTaskByConsoleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTranscodingTaskByConsoleResponse>);
        }
        
        /// <summary>
        /// 查询点播概览信息
        ///
        /// 查询最近一周，最近一月或者自定义时间段的“转码时长”，“调用转码API次数”。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStatSummaryResponse ListStatSummary(ListStatSummaryRequest listStatSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/summaries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStatSummaryResponse>(response);
        }

        public SyncInvoker<ListStatSummaryResponse> ListStatSummaryInvoker(ListStatSummaryRequest listStatSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/summaries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatSummaryRequest);
            return new SyncInvoker<ListStatSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStatSummaryResponse>);
        }
        
        /// <summary>
        /// 查询转码任务
        ///
        /// 查询转码任务状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTranscodingTaskResponse ListTranscodingTask(ListTranscodingTaskRequest listTranscodingTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodingTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTranscodingTaskResponse>(response);
        }

        public SyncInvoker<ListTranscodingTaskResponse> ListTranscodingTaskInvoker(ListTranscodingTaskRequest listTranscodingTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodingTaskRequest);
            return new SyncInvoker<ListTranscodingTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTranscodingTaskResponse>);
        }
        
        /// <summary>
        /// 新建转码模板
        ///
        /// 新建转码模板，采用自定义的模板转码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTransTemplateResponse CreateTransTemplate(CreateTransTemplateRequest createTransTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTransTemplateResponse>(response);
        }

        public SyncInvoker<CreateTransTemplateResponse> CreateTransTemplateInvoker(CreateTransTemplateRequest createTransTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransTemplateRequest);
            return new SyncInvoker<CreateTransTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTransTemplateResponse>);
        }
        
        /// <summary>
        /// 删除转码模板
        ///
        /// 删除转码模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest deleteTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTemplateResponse>(response);
        }

        public SyncInvoker<DeleteTemplateResponse> DeleteTemplateInvoker(DeleteTemplateRequest deleteTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            return new SyncInvoker<DeleteTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTemplateResponse>);
        }
        
        /// <summary>
        /// 查询转码模板
        ///
        /// 查询用户自定义转码配置模板。
        /// 支持指定模板ID查询，或分页全量查询。转码配置模板ID，最多10个。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTemplateResponse ListTemplate(ListTemplateRequest listTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTemplateResponse>(response);
        }

        public SyncInvoker<ListTemplateResponse> ListTemplateInvoker(ListTemplateRequest listTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateRequest);
            return new SyncInvoker<ListTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplateResponse>);
        }
        
        /// <summary>
        /// 更新转码模板
        ///
        /// 更新转码模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTransTemplateResponse UpdateTransTemplate(UpdateTransTemplateRequest updateTransTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTransTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTransTemplateResponse>(response);
        }

        public SyncInvoker<UpdateTransTemplateResponse> UpdateTransTemplateInvoker(UpdateTransTemplateRequest updateTransTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTransTemplateRequest);
            return new SyncInvoker<UpdateTransTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTransTemplateResponse>);
        }
        
        /// <summary>
        /// 新建水印模板
        ///
        /// 自定义水印模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateWatermarkTemplateResponse CreateWatermarkTemplate(CreateWatermarkTemplateRequest createWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWatermarkTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateWatermarkTemplateResponse>(response);
        }

        public SyncInvoker<CreateWatermarkTemplateResponse> CreateWatermarkTemplateInvoker(CreateWatermarkTemplateRequest createWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWatermarkTemplateRequest);
            return new SyncInvoker<CreateWatermarkTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWatermarkTemplateResponse>);
        }
        
        /// <summary>
        /// 删除水印模板
        ///
        /// 删除自定义水印模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteWatermarkTemplateResponse DeleteWatermarkTemplate(DeleteWatermarkTemplateRequest deleteWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWatermarkTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWatermarkTemplateResponse>(response);
        }

        public SyncInvoker<DeleteWatermarkTemplateResponse> DeleteWatermarkTemplateInvoker(DeleteWatermarkTemplateRequest deleteWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWatermarkTemplateRequest);
            return new SyncInvoker<DeleteWatermarkTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWatermarkTemplateResponse>);
        }
        
        /// <summary>
        /// 查询水印模板
        ///
        /// 查询自定义水印模板。支持指定模板ID查询，或分页全量查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWatermarkTemplateResponse ListWatermarkTemplate(ListWatermarkTemplateRequest listWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWatermarkTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWatermarkTemplateResponse>(response);
        }

        public SyncInvoker<ListWatermarkTemplateResponse> ListWatermarkTemplateInvoker(ListWatermarkTemplateRequest listWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWatermarkTemplateRequest);
            return new SyncInvoker<ListWatermarkTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWatermarkTemplateResponse>);
        }
        
        /// <summary>
        /// 更新水印模板
        ///
        /// 更新自定义水印模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateWatermarkTemplateResponse UpdateWatermarkTemplate(UpdateWatermarkTemplateRequest updateWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWatermarkTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateWatermarkTemplateResponse>(response);
        }

        public SyncInvoker<UpdateWatermarkTemplateResponse> UpdateWatermarkTemplateInvoker(UpdateWatermarkTemplateRequest updateWatermarkTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWatermarkTemplateRequest);
            return new SyncInvoker<UpdateWatermarkTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateWatermarkTemplateResponse>);
        }
        
    }
}