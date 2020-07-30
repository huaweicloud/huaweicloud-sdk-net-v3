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
        /// 根据课堂ID获取指定课堂的课堂成员列表
        /// </summary>
        public async Task<ListClassroomMembersResponse> ListClassroomMembersAsync(ListClassroomMembersRequest listClassroomMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("classroom_id" , listClassroomMembersRequest.ClassroomId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listClassroomMembersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListClassroomMembersResponse>(response);
        }
        
        /// <summary>
        /// 获取当前用户的课堂列表
        /// </summary>
        public async Task<ListClassroomsResponse> ListClassroomsAsync(ListClassroomsRequest listClassroomsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/classrooms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listClassroomsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListClassroomsResponse>(response);
        }
        
        /// <summary>
        /// 根据课堂ID获取指定课堂的详细信息
        /// </summary>
        public async Task<ShowClassroomDetailResponse> ShowClassroomDetailAsync(ShowClassroomDetailRequest showClassroomDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("classroom_id" , showClassroomDetailRequest.ClassroomId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showClassroomDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowClassroomDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询课堂下指定成员的作业信息
        /// </summary>
        public async Task<ListClassroomMemberJobsResponse> ListClassroomMemberJobsAsync(ListClassroomMemberJobsRequest listClassroomMemberJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("classroom_id" , listClassroomMemberJobsRequest.ClassroomId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/classrooms/{classroom_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listClassroomMemberJobsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListClassroomMemberJobsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定课堂下的作业列表信息
        /// </summary>
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest listJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listJobsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }
        
        /// <summary>
        /// 查询学生函数习题提交记录信息
        /// </summary>
        public async Task<ListMemberJobRecordsResponse> ListMemberJobRecordsAsync(ListMemberJobRecordsRequest listMemberJobRecordsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , listMemberJobRecordsRequest.JobId.ToString());
            urlParam.Add("exercise_id" , listMemberJobRecordsRequest.ExerciseId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/exercises/{exercise_id}/records",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listMemberJobRecordsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMemberJobRecordsResponse>(response);
        }
        
        /// <summary>
        /// 根据作业ID，查询指定作业的信息
        /// </summary>
        public async Task<ShowJobDetailResponse> ShowJobDetailAsync(ShowJobDetailRequest showJobDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobDetailRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showJobDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询指定作业下的习题信息
        /// </summary>
        public async Task<ShowJobExercisesResponse> ShowJobExercisesAsync(ShowJobExercisesRequest showJobExercisesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobExercisesRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/exercises",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showJobExercisesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobExercisesResponse>(response);
        }
        
    }
}