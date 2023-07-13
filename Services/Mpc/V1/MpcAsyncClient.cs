using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Mpc.V1.Model;

namespace HuaweiCloud.SDK.Mpc.V1
{
    public partial class MpcAsyncClient : Client
    {
        public static ClientBuilder<MpcAsyncClient> NewBuilder()
        {
            return new ClientBuilder<MpcAsyncClient>();
        }

        
        /// <summary>
        /// 新建转动图任务
        ///
        /// 创建动图任务，用于将完整的视频文件或视频文件中的一部分转换为动态图文件，暂只支持输出GIF文件。
        /// 待转动图的视频文件需要存储在与媒体处理服务同区域的OBS桶中，且该OBS桶已授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAnimatedGraphicsTaskResponse> CreateAnimatedGraphicsTaskAsync(CreateAnimatedGraphicsTaskRequest createAnimatedGraphicsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAnimatedGraphicsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAnimatedGraphicsTaskResponse>(response);
        }
        
        /// <summary>
        /// 取消转动图任务
        ///
        /// 取消已下发的生成动图任务，仅支持取消正在排队中的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAnimatedGraphicsTaskResponse> DeleteAnimatedGraphicsTaskAsync(DeleteAnimatedGraphicsTaskRequest deleteAnimatedGraphicsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAnimatedGraphicsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAnimatedGraphicsTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询转动图任务
        ///
        /// 查询动图任务的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAnimatedGraphicsTaskResponse> ListAnimatedGraphicsTaskAsync(ListAnimatedGraphicsTaskRequest listAnimatedGraphicsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/animated-graphics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAnimatedGraphicsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAnimatedGraphicsTaskResponse>(response);
        }
        
        /// <summary>
        /// 请求委托任务
        ///
        /// 开启或关闭\&quot;委托授权\&quot;, 开启后，媒体处理服务将拥有您所有桶的读写权限，子账号不支持委托授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAgenciesTaskResponse> CreateAgenciesTaskAsync(CreateAgenciesTaskRequest createAgenciesTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgenciesTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateAgenciesTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询桶列表
        ///
        /// 请求查询自己创建的指定的桶区域位置的桶列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllBucketsResponse> ListAllBucketsAsync(ListAllBucketsRequest listAllBucketsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/buckets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllBucketsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAllBucketsResponse>(response);
        }
        
        /// <summary>
        /// 查询桶里的object
        ///
        /// 查询桶里的object。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllObsObjListResponse> ListAllObsObjListAsync(ListAllObsObjListRequest listAllObsObjListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0-ext/{project_id}/objects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllObsObjListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAllObsObjListResponse>(response);
        }
        
        /// <summary>
        /// 查询转码服务端所有事件
        ///
        /// 查询消息订阅功能板块, SMN主题的所有订阅事件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNotifyEventResponse> ListNotifyEventAsync(ListNotifyEventRequest listNotifyEventRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification/event",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifyEventRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNotifyEventResponse>(response);
        }
        
        /// <summary>
        /// 查询转码服务端事件通知
        ///
        /// 查询消息订阅功能板块, SMN主题的订阅事件的启用状态和订阅消息的启用状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNotifySmnTopicConfigResponse> ListNotifySmnTopicConfigAsync(ListNotifySmnTopicConfigRequest listNotifySmnTopicConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotifySmnTopicConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNotifySmnTopicConfigResponse>(response);
        }
        
        /// <summary>
        /// 配置转码服务端事件通知
        ///
        /// 配置转码服务端事件通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<NotifySmnTopicConfigResponse> NotifySmnTopicConfigAsync(NotifySmnTopicConfigRequest notifySmnTopicConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", notifySmnTopicConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<NotifySmnTopicConfigResponse>(response);
        }
        
        /// <summary>
        /// 查询创建委托任务状态
        ///
        /// 查询创建委托任务状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAgenciesTaskResponse> ShowAgenciesTaskAsync(ShowAgenciesTaskRequest showAgenciesTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgenciesTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAgenciesTaskResponse>(response);
        }
        
        /// <summary>
        /// 桶授权或取消授权
        ///
        /// 对OBS桶进行授权或取消授权，媒体处理服务仅拥有已授权桶的读写权限。（暂不支持KMS加密桶的授权）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBucketAuthorizedResponse> UpdateBucketAuthorizedAsync(UpdateBucketAuthorizedRequest updateBucketAuthorizedRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/authority",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBucketAuthorizedRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
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
        public async Task<CreateEditingJobResponse> CreateEditingJobAsync(CreateEditingJobRequest createEditingJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEditingJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateEditingJobResponse>(response);
        }
        
        /// <summary>
        /// 取消剪辑任务
        ///
        /// 取消已下发的生成剪辑任务，仅支持取消正在排队中的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEditingJobResponse> DeleteEditingJobAsync(DeleteEditingJobRequest deleteEditingJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEditingJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEditingJobResponse>(response);
        }
        
        /// <summary>
        /// 查询剪辑任务
        ///
        /// 查询剪辑任务的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEditingJobResponse> ListEditingJobAsync(ListEditingJobRequest listEditingJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/editing/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEditingJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
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
        public async Task<CreateEncryptTaskResponse> CreateEncryptTaskAsync(CreateEncryptTaskRequest createEncryptTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEncryptTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
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
        public async Task<DeleteEncryptTaskResponse> DeleteEncryptTaskAsync(DeleteEncryptTaskRequest deleteEncryptTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEncryptTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEncryptTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询独立加密任务
        ///
        /// 查询独立加密任务状态。返回任务执行结果或当前状态。该API已废弃。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEncryptTaskResponse> ListEncryptTaskAsync(ListEncryptTaskRequest listEncryptTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/encryptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEncryptTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEncryptTaskResponse>(response);
        }
        
        /// <summary>
        /// 新建视频解析任务
        ///
        /// 创建视频解析任务，解析视频元数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateExtractTaskResponse> CreateExtractTaskAsync(CreateExtractTaskRequest createExtractTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExtractTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateExtractTaskResponse>(response);
        }
        
        /// <summary>
        /// 取消视频解析任务
        ///
        /// 取消已下发的视频解析任务，仅支持取消正在排队中的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteExtractTaskResponse> DeleteExtractTaskAsync(DeleteExtractTaskRequest deleteExtractTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExtractTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteExtractTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询视频解析任务
        ///
        /// 查询解析任务的状态和结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListExtractTaskResponse> ListExtractTaskAsync(ListExtractTaskRequest listExtractTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/extract-metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExtractTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
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
        public async Task<CreateMbTasksReportResponse> CreateMbTasksReportAsync(CreateMbTasksReportRequest createMbTasksReportRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/mediabox/tasks/report",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMbTasksReportRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
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
        public async Task<CreateMergeChannelsTaskResponse> CreateMergeChannelsTaskAsync(CreateMergeChannelsTaskRequest createMergeChannelsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeChannelsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
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
        public async Task<CreateResetTracksTaskResponse> CreateResetTracksTaskAsync(CreateResetTracksTaskRequest createResetTracksTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResetTracksTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateResetTracksTaskResponse>(response);
        }
        
        /// <summary>
        /// 取消声道合并任务
        ///
        /// 取消合并音频多声道文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMergeChannelsTaskResponse> DeleteMergeChannelsTaskAsync(DeleteMergeChannelsTaskRequest deleteMergeChannelsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeChannelsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMergeChannelsTaskResponse>(response);
        }
        
        /// <summary>
        /// 取消音轨重置任务
        ///
        /// 取消重置音频文件声轨任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteResetTracksTaskResponse> DeleteResetTracksTaskAsync(DeleteResetTracksTaskRequest deleteResetTracksTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResetTracksTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteResetTracksTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询声道合并任务
        ///
        /// 查询声道合并任务的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMergeChannelsTaskResponse> ListMergeChannelsTaskAsync(ListMergeChannelsTaskRequest listMergeChannelsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/merge_channels/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeChannelsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMergeChannelsTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询音轨重置任务
        ///
        /// 查询音轨重置任务的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResetTracksTaskResponse> ListResetTracksTaskAsync(ListResetTracksTaskRequest listResetTracksTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/audio/services/reset_tracks/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResetTracksTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
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
        public async Task<CreateMediaProcessTaskResponse> CreateMediaProcessTaskAsync(CreateMediaProcessTaskRequest createMediaProcessTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMediaProcessTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
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
        public async Task<DeleteMediaProcessTaskResponse> DeleteMediaProcessTaskAsync(DeleteMediaProcessTaskRequest deleteMediaProcessTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMediaProcessTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
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
        public async Task<ListMediaProcessTaskResponse> ListMediaProcessTaskAsync(ListMediaProcessTaskRequest listMediaProcessTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/enhancements",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMediaProcessTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
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
        public async Task<CreateMpeCallBackResponse> CreateMpeCallBackAsync(CreateMpeCallBackRequest createMpeCallBackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/mpe/notification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMpeCallBackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateMpeCallBackResponse>(response);
        }
        
        /// <summary>
        /// 创建视频增强模板
        ///
        /// 创建视频增强模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateQualityEnhanceTemplateResponse> CreateQualityEnhanceTemplateAsync(CreateQualityEnhanceTemplateRequest createQualityEnhanceTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createQualityEnhanceTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateQualityEnhanceTemplateResponse>(response);
        }
        
        /// <summary>
        /// 删除用户视频增强模板
        ///
        /// 删除用户视频增强模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteQualityEnhanceTemplateResponse> DeleteQualityEnhanceTemplateAsync(DeleteQualityEnhanceTemplateRequest deleteQualityEnhanceTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQualityEnhanceTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteQualityEnhanceTemplateResponse>(response);
        }
        
        /// <summary>
        /// 查询视频增强预置模板
        ///
        /// 查询视频增强预置模板，返回所有结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQualityEnhanceDefaultTemplateResponse> ListQualityEnhanceDefaultTemplateAsync(ListQualityEnhanceDefaultTemplateRequest listQualityEnhanceDefaultTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance/default",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQualityEnhanceDefaultTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQualityEnhanceDefaultTemplateResponse>(response);
        }
        
        /// <summary>
        /// 更新视频增强模板
        ///
        /// 更新视频增强模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateQualityEnhanceTemplateResponse> UpdateQualityEnhanceTemplateAsync(UpdateQualityEnhanceTemplateRequest updateQualityEnhanceTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/qualityenhance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateQualityEnhanceTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateQualityEnhanceTemplateResponse>(response);
        }
        
        /// <summary>
        /// 查询媒资转码详情
        ///
        /// 查询媒资转码详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTranscodeDetailResponse> ListTranscodeDetailAsync(ListTranscodeDetailRequest listTranscodeDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTranscodeDetailResponse>(response);
        }
        
        /// <summary>
        /// 取消转封装任务
        ///
        /// 取消已下发的转封装任务，仅支持取消正在排队中的任务。。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelRemuxTaskResponse> CancelRemuxTaskAsync(CancelRemuxTaskRequest cancelRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelRemuxTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
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
        public async Task<CreateRemuxTaskResponse> CreateRemuxTaskAsync(CreateRemuxTaskRequest createRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRemuxTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRemuxTaskResponse>(response);
        }
        
        /// <summary>
        /// 重试转封装任务
        ///
        /// 对失败的转封装任务进行重试。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRetryRemuxTaskResponse> CreateRetryRemuxTaskAsync(CreateRetryRemuxTaskRequest createRetryRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetryRemuxTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<CreateRetryRemuxTaskResponse>(response);
        }
        
        /// <summary>
        /// 删除转封装任务记录
        ///
        /// 删除转封装任务记录，只能删除状态为“已取消”，“转码成功”，“转码失败”的任务记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRemuxTaskResponse> DeleteRemuxTaskAsync(DeleteRemuxTaskRequest deleteRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRemuxTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRemuxTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询转封装任务
        ///
        /// 查询转封装任务状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRemuxTaskResponse> ListRemuxTaskAsync(ListRemuxTaskRequest listRemuxTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/remux",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRemuxTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRemuxTaskResponse>(response);
        }
        
        /// <summary>
        /// 新建转码模板组
        ///
        /// 新建转码模板组，最多支持一进六出。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTemplateGroupResponse> CreateTemplateGroupAsync(CreateTemplateGroupRequest createTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTemplateGroupResponse>(response);
        }
        
        /// <summary>
        /// 删除转码模板组
        ///
        /// 删除转码模板组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTemplateGroupResponse> DeleteTemplateGroupAsync(DeleteTemplateGroupRequest deleteTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询转码模板组
        ///
        /// 查询转码模板组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTemplateGroupResponse> ListTemplateGroupAsync(ListTemplateGroupRequest listTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateGroupResponse>(response);
        }
        
        /// <summary>
        /// 更新转码模板组
        ///
        /// 修改模板组接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTemplateGroupResponse> UpdateTemplateGroupAsync(UpdateTemplateGroupRequest updateTemplateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template_group/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
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
        public async Task<CreateThumbnailsTaskResponse> CreateThumbnailsTaskAsync(CreateThumbnailsTaskRequest createThumbnailsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createThumbnailsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
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
        public async Task<DeleteThumbnailsTaskResponse> DeleteThumbnailsTaskAsync(DeleteThumbnailsTaskRequest deleteThumbnailsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteThumbnailsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteThumbnailsTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询截图任务
        ///
        /// 查询截图任务状态。返回任务执行结果，包括状态、输入、输出等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListThumbnailsTaskResponse> ListThumbnailsTaskAsync(ListThumbnailsTaskRequest listThumbnailsTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/thumbnails",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listThumbnailsTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
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
        public async Task<CreateTranscodingTaskResponse> CreateTranscodingTaskAsync(CreateTranscodingTaskRequest createTranscodingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTranscodingTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
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
        public async Task<DeleteTranscodingTaskResponse> DeleteTranscodingTaskAsync(DeleteTranscodingTaskRequest deleteTranscodingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTranscodingTaskResponse>(response);
        }
        
        /// <summary>
        /// 删除转码任务记录
        ///
        /// 删除转码任务记录，只能删除状态为“已取消”，“转码成功”，“转码失败”的转码任务记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTranscodingTaskByConsoleResponse> DeleteTranscodingTaskByConsoleAsync(DeleteTranscodingTaskByConsoleRequest deleteTranscodingTaskByConsoleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingTaskByConsoleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTranscodingTaskByConsoleResponse>(response);
        }
        
        /// <summary>
        /// 查询点播概览信息
        ///
        /// 查询最近一周，最近一月或者自定义时间段的“转码时长”，“调用转码API次数”。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStatSummaryResponse> ListStatSummaryAsync(ListStatSummaryRequest listStatSummaryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings/summaries",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatSummaryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStatSummaryResponse>(response);
        }
        
        /// <summary>
        /// 查询转码任务
        ///
        /// 查询转码任务状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTranscodingTaskResponse> ListTranscodingTaskAsync(ListTranscodingTaskRequest listTranscodingTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodingTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTranscodingTaskResponse>(response);
        }
        
        /// <summary>
        /// 新建转码模板
        ///
        /// 新建转码模板，采用自定义的模板转码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTransTemplateResponse> CreateTransTemplateAsync(CreateTransTemplateRequest createTransTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTransTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTransTemplateResponse>(response);
        }
        
        /// <summary>
        /// 删除转码模板
        ///
        /// 删除转码模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest deleteTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
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
        public async Task<ListTemplateResponse> ListTemplateAsync(ListTemplateRequest listTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateResponse>(response);
        }
        
        /// <summary>
        /// 更新转码模板
        ///
        /// 更新转码模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTransTemplateResponse> UpdateTransTemplateAsync(UpdateTransTemplateRequest updateTransTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTransTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTransTemplateResponse>(response);
        }
        
        /// <summary>
        /// 新建水印模板
        ///
        /// 自定义水印模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWatermarkTemplateResponse> CreateWatermarkTemplateAsync(CreateWatermarkTemplateRequest createWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWatermarkTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateWatermarkTemplateResponse>(response);
        }
        
        /// <summary>
        /// 删除水印模板
        ///
        /// 删除自定义水印模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteWatermarkTemplateResponse> DeleteWatermarkTemplateAsync(DeleteWatermarkTemplateRequest deleteWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWatermarkTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteWatermarkTemplateResponse>(response);
        }
        
        /// <summary>
        /// 查询水印模板
        ///
        /// 查询自定义水印模板。支持指定模板ID查询，或分页全量查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWatermarkTemplateResponse> ListWatermarkTemplateAsync(ListWatermarkTemplateRequest listWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWatermarkTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListWatermarkTemplateResponse>(response);
        }
        
        /// <summary>
        /// 更新水印模板
        ///
        /// 更新自定义水印模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWatermarkTemplateResponse> UpdateWatermarkTemplateAsync(UpdateWatermarkTemplateRequest updateWatermarkTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/watermark",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWatermarkTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateWatermarkTemplateResponse>(response);
        }
        
    }
}