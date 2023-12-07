using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Frs.V2.Model;

namespace HuaweiCloud.SDK.Frs.V2
{
    public partial class FrsAsyncClient : Client
    {
        public static ClientBuilder<FrsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<FrsAsyncClient>();
        }

        
        /// <summary>
        /// 添加人脸
        ///
        /// 添加人脸到人脸库中。将单张图片中的人脸添加至人脸库中，支持添加最大人脸或所有人脸。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddFacesByBase64Response> AddFacesByBase64Async(AddFacesByBase64Request addFacesByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", addFacesByBase64Request.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFacesByBase64Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddFacesByBase64Response>(response);
        }

        public AsyncInvoker<AddFacesByBase64Response> AddFacesByBase64AsyncInvoker(AddFacesByBase64Request addFacesByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", addFacesByBase64Request.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFacesByBase64Request);
            return new AsyncInvoker<AddFacesByBase64Response>(this, "POST", request, JsonUtils.DeSerialize<AddFacesByBase64Response>);
        }
        
        /// <summary>
        /// 添加人脸
        ///
        /// 添加人脸到人脸库中。将单张图片中的人脸添加至人脸库中，支持添加最大人脸或所有人脸。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddFacesByFileResponse> AddFacesByFileAsync(AddFacesByFileRequest addFacesByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", addFacesByFileRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", addFacesByFileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddFacesByFileResponse>(response);
        }

        public AsyncInvoker<AddFacesByFileResponse> AddFacesByFileAsyncInvoker(AddFacesByFileRequest addFacesByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", addFacesByFileRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", addFacesByFileRequest);
            return new AsyncInvoker<AddFacesByFileResponse>(this, "POST", request, JsonUtils.DeSerialize<AddFacesByFileResponse>);
        }
        
        /// <summary>
        /// 添加人脸
        ///
        /// 添加人脸到人脸库中。将单张图片中的人脸添加至人脸库中，支持添加最大人脸或所有人脸。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddFacesByUrlResponse> AddFacesByUrlAsync(AddFacesByUrlRequest addFacesByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", addFacesByUrlRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFacesByUrlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddFacesByUrlResponse>(response);
        }

        public AsyncInvoker<AddFacesByUrlResponse> AddFacesByUrlAsyncInvoker(AddFacesByUrlRequest addFacesByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", addFacesByUrlRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addFacesByUrlRequest);
            return new AsyncInvoker<AddFacesByUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<AddFacesByUrlResponse>);
        }
        
        /// <summary>
        /// 批量删除人脸
        ///
        /// 自定义筛选条件，批量删除人脸库中的符合指定条件的多张人脸。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteFacesResponse> BatchDeleteFacesAsync(BatchDeleteFacesRequest batchDeleteFacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", batchDeleteFacesRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFacesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteFacesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteFacesResponse> BatchDeleteFacesAsyncInvoker(BatchDeleteFacesRequest batchDeleteFacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", batchDeleteFacesRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFacesRequest);
            return new AsyncInvoker<BatchDeleteFacesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteFacesResponse>);
        }
        
        /// <summary>
        /// 人脸比对
        ///
        /// 人脸比对是将两个人脸进行比对，来判断是否为同一个人，返回比对置信度。如果传入的图片中包含多个人脸，选取最大的人脸进行比对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CompareFaceByBase64Response> CompareFaceByBase64Async(CompareFaceByBase64Request compareFaceByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareFaceByBase64Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CompareFaceByBase64Response>(response);
        }

        public AsyncInvoker<CompareFaceByBase64Response> CompareFaceByBase64AsyncInvoker(CompareFaceByBase64Request compareFaceByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareFaceByBase64Request);
            return new AsyncInvoker<CompareFaceByBase64Response>(this, "POST", request, JsonUtils.DeSerialize<CompareFaceByBase64Response>);
        }
        
        /// <summary>
        /// 人脸比对
        ///
        /// 人脸比对是将两个人脸进行比对，来判断是否为同一个人，返回比对置信度。如果传入的图片中包含多个人脸，选取最大的人脸进行比对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CompareFaceByFileResponse> CompareFaceByFileAsync(CompareFaceByFileRequest compareFaceByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", compareFaceByFileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CompareFaceByFileResponse>(response);
        }

        public AsyncInvoker<CompareFaceByFileResponse> CompareFaceByFileAsyncInvoker(CompareFaceByFileRequest compareFaceByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", compareFaceByFileRequest);
            return new AsyncInvoker<CompareFaceByFileResponse>(this, "POST", request, JsonUtils.DeSerialize<CompareFaceByFileResponse>);
        }
        
        /// <summary>
        /// 人脸比对
        ///
        /// 人脸比对是将两个人脸进行比对，来判断是否为同一个人，返回比对置信度。如果传入的图片中包含多个人脸，选取最大的人脸进行比对。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CompareFaceByUrlResponse> CompareFaceByUrlAsync(CompareFaceByUrlRequest compareFaceByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareFaceByUrlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CompareFaceByUrlResponse>(response);
        }

        public AsyncInvoker<CompareFaceByUrlResponse> CompareFaceByUrlAsyncInvoker(CompareFaceByUrlRequest compareFaceByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", compareFaceByUrlRequest);
            return new AsyncInvoker<CompareFaceByUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<CompareFaceByUrlResponse>);
        }
        
        /// <summary>
        /// 创建人脸库
        ///
        /// 创建用于存储人脸特征的人脸库。您最多可以创建10个人脸库，每个人脸库最大容量为10万个人脸特征。如有更大规格的需求请联系客服。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFaceSetResponse> CreateFaceSetAsync(CreateFaceSetRequest createFaceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFaceSetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateFaceSetResponse>(response);
        }

        public AsyncInvoker<CreateFaceSetResponse> CreateFaceSetAsyncInvoker(CreateFaceSetRequest createFaceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFaceSetRequest);
            return new AsyncInvoker<CreateFaceSetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFaceSetResponse>);
        }
        
        /// <summary>
        /// 删除人脸
        ///
        /// 根据external_image_id删除人脸。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFaceByExternalImageIdResponse> DeleteFaceByExternalImageIdAsync(DeleteFaceByExternalImageIdRequest deleteFaceByExternalImageIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", deleteFaceByExternalImageIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceByExternalImageIdRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteFaceByExternalImageIdResponse>(response);
        }

        public AsyncInvoker<DeleteFaceByExternalImageIdResponse> DeleteFaceByExternalImageIdAsyncInvoker(DeleteFaceByExternalImageIdRequest deleteFaceByExternalImageIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", deleteFaceByExternalImageIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceByExternalImageIdRequest);
            return new AsyncInvoker<DeleteFaceByExternalImageIdResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteFaceByExternalImageIdResponse>);
        }
        
        /// <summary>
        /// 删除人脸
        ///
        /// 根据face_id删除人脸。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFaceByFaceIdResponse> DeleteFaceByFaceIdAsync(DeleteFaceByFaceIdRequest deleteFaceByFaceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", deleteFaceByFaceIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceByFaceIdRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteFaceByFaceIdResponse>(response);
        }

        public AsyncInvoker<DeleteFaceByFaceIdResponse> DeleteFaceByFaceIdAsyncInvoker(DeleteFaceByFaceIdRequest deleteFaceByFaceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", deleteFaceByFaceIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceByFaceIdRequest);
            return new AsyncInvoker<DeleteFaceByFaceIdResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteFaceByFaceIdResponse>);
        }
        
        /// <summary>
        /// 删除人脸库
        ///
        /// 删除人脸库以及其中所有的人脸。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFaceSetResponse> DeleteFaceSetAsync(DeleteFaceSetRequest deleteFaceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", deleteFaceSetRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceSetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteFaceSetResponse>(response);
        }

        public AsyncInvoker<DeleteFaceSetResponse> DeleteFaceSetAsyncInvoker(DeleteFaceSetRequest deleteFaceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", deleteFaceSetRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFaceSetRequest);
            return new AsyncInvoker<DeleteFaceSetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteFaceSetResponse>);
        }
        
        /// <summary>
        /// 人脸检测
        ///
        /// 人脸检测是对输入图片进行人脸检测和分析，输出人脸在图像中的位置、人脸关键点位置和人脸关键属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectFaceByBase64Response> DetectFaceByBase64Async(DetectFaceByBase64Request detectFaceByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByBase64Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectFaceByBase64Response>(response);
        }

        public AsyncInvoker<DetectFaceByBase64Response> DetectFaceByBase64AsyncInvoker(DetectFaceByBase64Request detectFaceByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByBase64Request);
            return new AsyncInvoker<DetectFaceByBase64Response>(this, "POST", request, JsonUtils.DeSerialize<DetectFaceByBase64Response>);
        }
        
        /// <summary>
        /// 人脸检测
        ///
        /// 人脸检测是对输入图片进行人脸检测和分析，输出人脸在图像中的位置、人脸关键点位置和人脸关键属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectFaceByBase64IntlResponse> DetectFaceByBase64IntlAsync(DetectFaceByBase64IntlRequest detectFaceByBase64IntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByBase64IntlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectFaceByBase64IntlResponse>(response);
        }

        public AsyncInvoker<DetectFaceByBase64IntlResponse> DetectFaceByBase64IntlAsyncInvoker(DetectFaceByBase64IntlRequest detectFaceByBase64IntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByBase64IntlRequest);
            return new AsyncInvoker<DetectFaceByBase64IntlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectFaceByBase64IntlResponse>);
        }
        
        /// <summary>
        /// 人脸检测
        ///
        /// 人脸检测是对输入图片进行人脸检测和分析，输出人脸在图像中的位置、人脸关键点位置和人脸关键属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectFaceByFileResponse> DetectFaceByFileAsync(DetectFaceByFileRequest detectFaceByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectFaceByFileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectFaceByFileResponse>(response);
        }

        public AsyncInvoker<DetectFaceByFileResponse> DetectFaceByFileAsyncInvoker(DetectFaceByFileRequest detectFaceByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectFaceByFileRequest);
            return new AsyncInvoker<DetectFaceByFileResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectFaceByFileResponse>);
        }
        
        /// <summary>
        /// 人脸检测
        ///
        /// 人脸检测是对输入图片进行人脸检测和分析，输出人脸在图像中的位置、人脸关键点位置和人脸关键属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectFaceByFileIntlResponse> DetectFaceByFileIntlAsync(DetectFaceByFileIntlRequest detectFaceByFileIntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectFaceByFileIntlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectFaceByFileIntlResponse>(response);
        }

        public AsyncInvoker<DetectFaceByFileIntlResponse> DetectFaceByFileIntlAsyncInvoker(DetectFaceByFileIntlRequest detectFaceByFileIntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectFaceByFileIntlRequest);
            return new AsyncInvoker<DetectFaceByFileIntlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectFaceByFileIntlResponse>);
        }
        
        /// <summary>
        /// 人脸检测
        ///
        /// 人脸检测是对输入图片进行人脸检测和分析，输出人脸在图像中的位置、人脸关键点位置和人脸关键属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectFaceByUrlResponse> DetectFaceByUrlAsync(DetectFaceByUrlRequest detectFaceByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByUrlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectFaceByUrlResponse>(response);
        }

        public AsyncInvoker<DetectFaceByUrlResponse> DetectFaceByUrlAsyncInvoker(DetectFaceByUrlRequest detectFaceByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByUrlRequest);
            return new AsyncInvoker<DetectFaceByUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectFaceByUrlResponse>);
        }
        
        /// <summary>
        /// 人脸检测
        ///
        /// 人脸检测是对输入图片进行人脸检测和分析，输出人脸在图像中的位置、人脸关键点位置和人脸关键属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectFaceByUrlIntlResponse> DetectFaceByUrlIntlAsync(DetectFaceByUrlIntlRequest detectFaceByUrlIntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByUrlIntlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectFaceByUrlIntlResponse>(response);
        }

        public AsyncInvoker<DetectFaceByUrlIntlResponse> DetectFaceByUrlIntlAsyncInvoker(DetectFaceByUrlIntlRequest detectFaceByUrlIntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectFaceByUrlIntlRequest);
            return new AsyncInvoker<DetectFaceByUrlIntlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectFaceByUrlIntlResponse>);
        }
        
        /// <summary>
        /// 动作活体检测
        ///
        /// 动作活体检测是通过判断视频中的人物动作与传入动作列表是否一致来识别视频中人物是否为活体。如果有多张人脸出现，则选取最大的人脸进行判定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectLiveByBase64Response> DetectLiveByBase64Async(DetectLiveByBase64Request detectLiveByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByBase64Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveByBase64Response>(response);
        }

        public AsyncInvoker<DetectLiveByBase64Response> DetectLiveByBase64AsyncInvoker(DetectLiveByBase64Request detectLiveByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByBase64Request);
            return new AsyncInvoker<DetectLiveByBase64Response>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveByBase64Response>);
        }
        
        /// <summary>
        /// 动作活体检测
        ///
        /// 动作活体检测是通过判断视频中的人物动作与传入动作列表是否一致来识别视频中人物是否为活体。如果有多张人脸出现，则选取最大的人脸进行判定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectLiveByBase64IntlResponse> DetectLiveByBase64IntlAsync(DetectLiveByBase64IntlRequest detectLiveByBase64IntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByBase64IntlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveByBase64IntlResponse>(response);
        }

        public AsyncInvoker<DetectLiveByBase64IntlResponse> DetectLiveByBase64IntlAsyncInvoker(DetectLiveByBase64IntlRequest detectLiveByBase64IntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByBase64IntlRequest);
            return new AsyncInvoker<DetectLiveByBase64IntlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveByBase64IntlResponse>);
        }
        
        /// <summary>
        /// 动作活体检测
        ///
        /// 动作活体检测是通过判断视频中的人物动作与传入动作列表是否一致来识别视频中人物是否为活体。如果有多张人脸出现，则选取最大的人脸进行判定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectLiveByFileResponse> DetectLiveByFileAsync(DetectLiveByFileRequest detectLiveByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveByFileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveByFileResponse>(response);
        }

        public AsyncInvoker<DetectLiveByFileResponse> DetectLiveByFileAsyncInvoker(DetectLiveByFileRequest detectLiveByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveByFileRequest);
            return new AsyncInvoker<DetectLiveByFileResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveByFileResponse>);
        }
        
        /// <summary>
        /// 动作活体检测
        ///
        /// 动作活体检测是通过判断视频中的人物动作与传入动作列表是否一致来识别视频中人物是否为活体。如果有多张人脸出现，则选取最大的人脸进行判定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectLiveByFileIntlResponse> DetectLiveByFileIntlAsync(DetectLiveByFileIntlRequest detectLiveByFileIntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveByFileIntlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveByFileIntlResponse>(response);
        }

        public AsyncInvoker<DetectLiveByFileIntlResponse> DetectLiveByFileIntlAsyncInvoker(DetectLiveByFileIntlRequest detectLiveByFileIntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveByFileIntlRequest);
            return new AsyncInvoker<DetectLiveByFileIntlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveByFileIntlResponse>);
        }
        
        /// <summary>
        /// 动作活体检测
        ///
        /// 动作活体检测是通过判断视频中的人物动作与传入动作列表是否一致来识别视频中人物是否为活体。如果有多张人脸出现，则选取最大的人脸进行判定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectLiveByUrlResponse> DetectLiveByUrlAsync(DetectLiveByUrlRequest detectLiveByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByUrlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveByUrlResponse>(response);
        }

        public AsyncInvoker<DetectLiveByUrlResponse> DetectLiveByUrlAsyncInvoker(DetectLiveByUrlRequest detectLiveByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByUrlRequest);
            return new AsyncInvoker<DetectLiveByUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveByUrlResponse>);
        }
        
        /// <summary>
        /// 动作活体检测
        ///
        /// 动作活体检测是通过判断视频中的人物动作与传入动作列表是否一致来识别视频中人物是否为活体。如果有多张人脸出现，则选取最大的人脸进行判定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectLiveByUrlIntlResponse> DetectLiveByUrlIntlAsync(DetectLiveByUrlIntlRequest detectLiveByUrlIntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByUrlIntlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveByUrlIntlResponse>(response);
        }

        public AsyncInvoker<DetectLiveByUrlIntlResponse> DetectLiveByUrlIntlAsyncInvoker(DetectLiveByUrlIntlRequest detectLiveByUrlIntlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/live-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveByUrlIntlRequest);
            return new AsyncInvoker<DetectLiveByUrlIntlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveByUrlIntlResponse>);
        }
        
        /// <summary>
        /// 静默活体检测
        ///
        /// 静默活体检测是基于人脸图片中可能存在的畸变、摩尔纹、反光、倒影、边框等信息，判断图片中的人脸是否来自于真人活体，有效抵御纸质翻拍照、电子翻拍照以及视频翻拍等各种攻击方式。静默活体检测支持单张图片，不支持多人脸图片。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectLiveFaceByBase64Response> DetectLiveFaceByBase64Async(DetectLiveFaceByBase64Request detectLiveFaceByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveFaceByBase64Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveFaceByBase64Response>(response);
        }

        public AsyncInvoker<DetectLiveFaceByBase64Response> DetectLiveFaceByBase64AsyncInvoker(DetectLiveFaceByBase64Request detectLiveFaceByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveFaceByBase64Request);
            return new AsyncInvoker<DetectLiveFaceByBase64Response>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveFaceByBase64Response>);
        }
        
        /// <summary>
        /// 静默活体检测
        ///
        /// 静默活体检测是基于人脸图片中可能存在的畸变、摩尔纹、反光、倒影、边框等信息，判断图片中的人脸是否来自于真人活体，有效抵御纸质翻拍照、电子翻拍照以及视频翻拍等各种攻击方式。静默活体检测支持单张图片，不支持多人脸图片。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectLiveFaceByFileResponse> DetectLiveFaceByFileAsync(DetectLiveFaceByFileRequest detectLiveFaceByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveFaceByFileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveFaceByFileResponse>(response);
        }

        public AsyncInvoker<DetectLiveFaceByFileResponse> DetectLiveFaceByFileAsyncInvoker(DetectLiveFaceByFileRequest detectLiveFaceByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", detectLiveFaceByFileRequest);
            return new AsyncInvoker<DetectLiveFaceByFileResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveFaceByFileResponse>);
        }
        
        /// <summary>
        /// 静默活体检测
        ///
        /// 静默活体检测是基于人脸图片中可能存在的畸变、摩尔纹、反光、倒影、边框等信息，判断图片中的人脸是否来自于真人活体，有效抵御纸质翻拍照、电子翻拍照以及视频翻拍等各种攻击方式。静默活体检测支持单张图片，不支持多人脸图片。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetectLiveFaceByUrlResponse> DetectLiveFaceByUrlAsync(DetectLiveFaceByUrlRequest detectLiveFaceByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveFaceByUrlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetectLiveFaceByUrlResponse>(response);
        }

        public AsyncInvoker<DetectLiveFaceByUrlResponse> DetectLiveFaceByUrlAsyncInvoker(DetectLiveFaceByUrlRequest detectLiveFaceByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-detect-face", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detectLiveFaceByUrlRequest);
            return new AsyncInvoker<DetectLiveFaceByUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<DetectLiveFaceByUrlResponse>);
        }
        
        /// <summary>
        /// 人脸搜索
        ///
        /// 人脸搜索是指在已有的人脸库中，查询与目标人脸相似的一张或者多张人脸，并返回相应的置信度。
        /// 支持传入图片或者faceID进行人脸搜索，如果传入的是多张人脸图片，选取图片中检测到的最大尺寸人脸作为检索的输入。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchFaceByBase64Response> SearchFaceByBase64Async(SearchFaceByBase64Request searchFaceByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByBase64Request.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByBase64Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchFaceByBase64Response>(response);
        }

        public AsyncInvoker<SearchFaceByBase64Response> SearchFaceByBase64AsyncInvoker(SearchFaceByBase64Request searchFaceByBase64Request)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByBase64Request.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByBase64Request);
            return new AsyncInvoker<SearchFaceByBase64Response>(this, "POST", request, JsonUtils.DeSerialize<SearchFaceByBase64Response>);
        }
        
        /// <summary>
        /// 人脸搜索
        ///
        /// 人脸搜索是指在已有的人脸库中，查询与目标人脸相似的一张或者多张人脸，并返回相应的置信度。
        /// 支持传入图片或者faceID进行人脸搜索，如果传入的是多张人脸图片，选取图片中检测到的最大尺寸人脸作为检索的输入。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchFaceByFaceIdResponse> SearchFaceByFaceIdAsync(SearchFaceByFaceIdRequest searchFaceByFaceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByFaceIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByFaceIdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchFaceByFaceIdResponse>(response);
        }

        public AsyncInvoker<SearchFaceByFaceIdResponse> SearchFaceByFaceIdAsyncInvoker(SearchFaceByFaceIdRequest searchFaceByFaceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByFaceIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByFaceIdRequest);
            return new AsyncInvoker<SearchFaceByFaceIdResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchFaceByFaceIdResponse>);
        }
        
        /// <summary>
        /// 人脸搜索
        ///
        /// 人脸搜索是指在已有的人脸库中，查询与目标人脸相似的一张或者多张人脸，并返回相应的置信度。
        /// 支持传入图片或者faceID进行人脸搜索，如果传入的是多张人脸图片，选取图片中检测到的最大尺寸人脸作为检索的输入。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchFaceByFileResponse> SearchFaceByFileAsync(SearchFaceByFileRequest searchFaceByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByFileRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", searchFaceByFileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchFaceByFileResponse>(response);
        }

        public AsyncInvoker<SearchFaceByFileResponse> SearchFaceByFileAsyncInvoker(SearchFaceByFileRequest searchFaceByFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByFileRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", searchFaceByFileRequest);
            return new AsyncInvoker<SearchFaceByFileResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchFaceByFileResponse>);
        }
        
        /// <summary>
        /// 人脸搜索
        ///
        /// 人脸搜索是指在已有的人脸库中，查询与目标人脸相似的一张或者多张人脸，并返回相应的置信度。
        /// 支持传入图片或者faceID进行人脸搜索，如果传入的是多张人脸图片，选取图片中检测到的最大尺寸人脸作为检索的输入。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchFaceByUrlResponse> SearchFaceByUrlAsync(SearchFaceByUrlRequest searchFaceByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByUrlRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByUrlRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchFaceByUrlResponse>(response);
        }

        public AsyncInvoker<SearchFaceByUrlResponse> SearchFaceByUrlAsyncInvoker(SearchFaceByUrlRequest searchFaceByUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", searchFaceByUrlRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchFaceByUrlRequest);
            return new AsyncInvoker<SearchFaceByUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchFaceByUrlResponse>);
        }
        
        /// <summary>
        /// 查询所有人脸库
        ///
        /// 查询当前用户所有人脸库的状态信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAllFaceSetsResponse> ShowAllFaceSetsAsync(ShowAllFaceSetsRequest showAllFaceSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllFaceSetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAllFaceSetsResponse>(response);
        }

        public AsyncInvoker<ShowAllFaceSetsResponse> ShowAllFaceSetsAsyncInvoker(ShowAllFaceSetsRequest showAllFaceSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllFaceSetsRequest);
            return new AsyncInvoker<ShowAllFaceSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAllFaceSetsResponse>);
        }
        
        /// <summary>
        /// 查询人脸库
        ///
        /// 查询人脸库当前的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFaceSetResponse> ShowFaceSetAsync(ShowFaceSetRequest showFaceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", showFaceSetRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFaceSetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFaceSetResponse>(response);
        }

        public AsyncInvoker<ShowFaceSetResponse> ShowFaceSetAsyncInvoker(ShowFaceSetRequest showFaceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", showFaceSetRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFaceSetRequest);
            return new AsyncInvoker<ShowFaceSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFaceSetResponse>);
        }
        
        /// <summary>
        /// 查询人脸
        ///
        /// 查询指定人脸库中人脸信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFacesByFaceIdResponse> ShowFacesByFaceIdAsync(ShowFacesByFaceIdRequest showFacesByFaceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", showFacesByFaceIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFacesByFaceIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFacesByFaceIdResponse>(response);
        }

        public AsyncInvoker<ShowFacesByFaceIdResponse> ShowFacesByFaceIdAsyncInvoker(ShowFacesByFaceIdRequest showFacesByFaceIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", showFacesByFaceIdRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFacesByFaceIdRequest);
            return new AsyncInvoker<ShowFacesByFaceIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFacesByFaceIdResponse>);
        }
        
        /// <summary>
        /// 查询人脸
        ///
        /// 查询指定人脸库中人脸信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFacesByLimitResponse> ShowFacesByLimitAsync(ShowFacesByLimitRequest showFacesByLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", showFacesByLimitRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFacesByLimitRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFacesByLimitResponse>(response);
        }

        public AsyncInvoker<ShowFacesByLimitResponse> ShowFacesByLimitAsyncInvoker(ShowFacesByLimitRequest showFacesByLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", showFacesByLimitRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFacesByLimitRequest);
            return new AsyncInvoker<ShowFacesByLimitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFacesByLimitResponse>);
        }
        
        /// <summary>
        /// 更新人脸
        ///
        /// 根据人脸ID（face_id）更新单张人脸信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFaceResponse> UpdateFaceAsync(UpdateFaceRequest updateFaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", updateFaceRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFaceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFaceResponse>(response);
        }

        public AsyncInvoker<UpdateFaceResponse> UpdateFaceAsyncInvoker(UpdateFaceRequest updateFaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("face_set_name", updateFaceRequest.FaceSetName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/face-sets/{face_set_name}/faces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFaceRequest);
            return new AsyncInvoker<UpdateFaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFaceResponse>);
        }
        
    }
}