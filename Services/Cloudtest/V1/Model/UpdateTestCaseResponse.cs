using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateTestCaseResponse : SdkResponse
    {

        /// <summary>
        /// 测试用例唯一标识
        /// </summary>
        [JsonProperty("testcase_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseId { get; set; }

        /// <summary>
        /// 软开云项目唯一标识
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 注册测试类型服务接口返回的服务id
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceId { get; set; }

        /// <summary>
        /// 测试用例名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 测试用例编号
        /// </summary>
        [JsonProperty("testcase_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseNumber { get; set; }

        /// <summary>
        /// 测试用例等级
        /// </summary>
        [JsonProperty("rank_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RankId { get; set; }

        /// <summary>
        /// 测试用例状态
        /// </summary>
        [JsonProperty("status_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assigned_user", NullValueHandling = NullValueHandling.Ignore)]
        public AssignedUserInfo AssignedUser { get; set; }

        /// <summary>
        /// 测试用例执行次数
        /// </summary>
        [JsonProperty("execute_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteCount { get; set; }

        /// <summary>
        /// 测试用例执行结果
        /// </summary>
        [JsonProperty("result_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extend_info", NullValueHandling = NullValueHandling.Ignore)]
        public ExtendInfo ExtendInfo { get; set; }

        /// <summary>
        /// 接口调用失败错误码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 接口调用失败错误信息
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTestCaseResponse {\n");
            sb.Append("  testcaseId: ").Append(TestcaseId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  testcaseNumber: ").Append(TestcaseNumber).Append("\n");
            sb.Append("  rankId: ").Append(RankId).Append("\n");
            sb.Append("  statusId: ").Append(StatusId).Append("\n");
            sb.Append("  assignedUser: ").Append(AssignedUser).Append("\n");
            sb.Append("  executeCount: ").Append(ExecuteCount).Append("\n");
            sb.Append("  resultId: ").Append(ResultId).Append("\n");
            sb.Append("  extendInfo: ").Append(ExtendInfo).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTestCaseResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTestCaseResponse input)
        {
            if (input == null) return false;
            if (this.TestcaseId != input.TestcaseId || (this.TestcaseId != null && !this.TestcaseId.Equals(input.TestcaseId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.TestcaseNumber != input.TestcaseNumber || (this.TestcaseNumber != null && !this.TestcaseNumber.Equals(input.TestcaseNumber))) return false;
            if (this.RankId != input.RankId || (this.RankId != null && !this.RankId.Equals(input.RankId))) return false;
            if (this.StatusId != input.StatusId || (this.StatusId != null && !this.StatusId.Equals(input.StatusId))) return false;
            if (this.AssignedUser != input.AssignedUser || (this.AssignedUser != null && !this.AssignedUser.Equals(input.AssignedUser))) return false;
            if (this.ExecuteCount != input.ExecuteCount || (this.ExecuteCount != null && !this.ExecuteCount.Equals(input.ExecuteCount))) return false;
            if (this.ResultId != input.ResultId || (this.ResultId != null && !this.ResultId.Equals(input.ResultId))) return false;
            if (this.ExtendInfo != input.ExtendInfo || (this.ExtendInfo != null && !this.ExtendInfo.Equals(input.ExtendInfo))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.TestcaseId != null) hashCode = hashCode * 59 + this.TestcaseId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TestcaseNumber != null) hashCode = hashCode * 59 + this.TestcaseNumber.GetHashCode();
                if (this.RankId != null) hashCode = hashCode * 59 + this.RankId.GetHashCode();
                if (this.StatusId != null) hashCode = hashCode * 59 + this.StatusId.GetHashCode();
                if (this.AssignedUser != null) hashCode = hashCode * 59 + this.AssignedUser.GetHashCode();
                if (this.ExecuteCount != null) hashCode = hashCode * 59 + this.ExecuteCount.GetHashCode();
                if (this.ResultId != null) hashCode = hashCode * 59 + this.ResultId.GetHashCode();
                if (this.ExtendInfo != null) hashCode = hashCode * 59 + this.ExtendInfo.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
