using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Classroom.V3.Model;

namespace HuaweiCloud.SDK.Classroom.V3
{
    public partial class ClassroomAsyncClient : Client
    {
        public static ClientBuilder<ClassroomAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ClassroomAsyncClient>();
        }

        
        /// <summary>
        /// 下发判题任务
        ///
        /// 下发判题任务，根据回调地址、代码来源、源代码文本、语言类型、超时时长、输出类型，触发后台代码编译运行和判题
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ApplyJudgementResponse> ApplyJudgementAsync(ApplyJudgementRequest applyJudgementRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgements",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyJudgementRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ApplyJudgementResponse>(response);
        }
        
        /// <summary>
        /// 获取判题结果详情
        ///
        /// 根据判题任务ID获取判题结果详情
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJudgementDetailResponse> ShowJudgementDetailAsync(ShowJudgementDetailRequest showJudgementDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("judgement_id" , showJudgementDetailRequest.JudgementId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgements/{judgement_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJudgementDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJudgementDetailResponse>(response);
        }
        
        /// <summary>
        /// 下载判题结果文件
        ///
        /// 根据文件id或图片id下载输出结果文件
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJudgementFileResponse> ShowJudgementFileAsync(ShowJudgementFileRequest showJudgementFileRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("file_id" , showJudgementFileRequest.FileId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/enablement/judgement/files/{file_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJudgementFileRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJudgementFileResponse>(response);
        }
        
        /// <summary>
        /// 根据课堂ID获取指定课堂的课堂成员列表
        ///
        /// 根据课堂ID获取指定课堂的课堂成员列表，支持分页，搜索字段默认同时匹配姓名，学号，用户名，班级。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListClassroomMembersResponse> ListClassroomMembersAsync(ListClassroomMembersRequest listClassroomMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("classroom_id" , listClassroomMembersRequest.ClassroomId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomMembersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListClassroomMembersResponse>(response);
        }
        
        /// <summary>
        /// 获取当前用户的课堂列表
        ///
        /// 获取当前用户的课堂列表，课堂课表分为我创建的课堂，我加入的课堂以及所有课堂，支持分页查询。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListClassroomsResponse> ListClassroomsAsync(ListClassroomsRequest listClassroomsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/classrooms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListClassroomsResponse>(response);
        }
        
        /// <summary>
        /// 根据课堂ID获取指定课堂的详细信息
        ///
        /// 根据课堂ID获取指定课堂的详细信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClassroomDetailResponse> ShowClassroomDetailAsync(ShowClassroomDetailRequest showClassroomDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("classroom_id" , showClassroomDetailRequest.ClassroomId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClassroomDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowClassroomDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询课堂下指定成员的作业信息
        ///
        /// 查询课堂下指定成员的作业信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListClassroomMemberJobsResponse> ListClassroomMemberJobsAsync(ListClassroomMemberJobsRequest listClassroomMemberJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("classroom_id" , listClassroomMemberJobsRequest.ClassroomId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClassroomMemberJobsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListClassroomMemberJobsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定课堂下的作业列表信息
        ///
        /// 查询指定课堂下的作业列表信息，支持分页查询。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest listJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }
        
        /// <summary>
        /// 查询学生函数习题提交记录信息
        ///
        /// 查询学生指定作业的习题提交记录信息(针对函数习题)
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListMemberJobRecordsResponse> ListMemberJobRecordsAsync(ListMemberJobRecordsRequest listMemberJobRecordsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , listMemberJobRecordsRequest.JobId.ToString());
            urlParam.Add("exercise_id" , listMemberJobRecordsRequest.ExerciseId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/exercises/{exercise_id}/records",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMemberJobRecordsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMemberJobRecordsResponse>(response);
        }
        
        /// <summary>
        /// 根据作业ID，查询指定作业的信息
        ///
        /// 根据作业ID，查询指定作业的信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobDetailResponse> ShowJobDetailAsync(ShowJobDetailRequest showJobDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobDetailRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询指定作业下的习题信息
        ///
        /// 查询指定作业下的习题信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobExercisesResponse> ShowJobExercisesAsync(ShowJobExercisesRequest showJobExercisesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobExercisesRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/exercises",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobExercisesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobExercisesResponse>(response);
        }
        
    }
}