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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAnimatedGraphicsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAnimatedGraphicsTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAnimatedGraphicsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAnimatedGraphicsTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAnimatedGraphicsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAnimatedGraphicsTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgenciesTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateAgenciesTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/buckets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllBucketsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAllBucketsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0-ext/{project_id}/objects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllObsObjListRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAllObsObjListResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification/event",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifyEventRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNotifyEventResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifySmnTopicConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNotifySmnTopicConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", notifySmnTopicConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<NotifySmnTopicConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgenciesTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAgenciesTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/authority",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBucketAuthorizedRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateBucketAuthorizedResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEditingJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateEditingJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEditingJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEditingJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEditingJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListEditingJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEncryptTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateEncryptTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEncryptTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEncryptTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEncryptTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListEncryptTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExtractTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateExtractTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExtractTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteExtractTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExtractTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListExtractTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/mediabox/tasks/report",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMbTasksReportRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<CreateMbTasksReportResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeChannelsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateMergeChannelsTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResetTracksTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateResetTracksTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeChannelsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMergeChannelsTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResetTracksTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteResetTracksTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeChannelsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListMergeChannelsTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResetTracksTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListResetTracksTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMediaProcessTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateMediaProcessTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMediaProcessTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMediaProcessTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMediaProcessTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListMediaProcessTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/mpe/notification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMpeCallBackRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateMpeCallBackResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createQualityEnhanceTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateQualityEnhanceTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQualityEnhanceTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteQualityEnhanceTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance/default",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQualityEnhanceDefaultTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListQualityEnhanceDefaultTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateQualityEnhanceTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateQualityEnhanceTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTranscodeDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRemuxTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<CancelRemuxTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRemuxTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRemuxTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetryRemuxTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<CreateRetryRemuxTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRemuxTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRemuxTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRemuxTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRemuxTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTemplateGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTemplateGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createThumbnailsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateThumbnailsTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteThumbnailsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteThumbnailsTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listThumbnailsTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListThumbnailsTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTranscodingTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTranscodingTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTranscodingTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingTaskByConsoleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTranscodingTaskByConsoleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/summaries",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatSummaryRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListStatSummaryResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodingTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTranscodingTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTransTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTransTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTransTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWatermarkTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateWatermarkTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWatermarkTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteWatermarkTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWatermarkTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListWatermarkTemplateResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWatermarkTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateWatermarkTemplateResponse>(response);
        }
        
    }
}