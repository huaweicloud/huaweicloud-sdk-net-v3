using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class JobEntities 
    {

        /// <summary>
        /// 镜像ID
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 当前任务名称
        /// </summary>
        [JsonProperty("current_task", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentTask { get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("image_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageName { get; set; }

        /// <summary>
        /// 添加错误码
        /// </summary>
        [JsonProperty("addition_error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionErrorCode { get; set; }

        /// <summary>
        /// 添加错误消息
        /// </summary>
        [JsonProperty("addition_error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionErrorMsg { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        /// <summary>
        /// 告警代码
        /// </summary>
        [JsonProperty("alarm_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmCode { get; set; }

        /// <summary>
        /// 任务执行进度
        /// </summary>
        [JsonProperty("process_percent", NullValueHandling = NullValueHandling.Ignore)]
        public double? ProcessPercent { get; set; }

        /// <summary>
        /// 批量任务执行结果
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobEntitiesResult> Results { get; set; }

        /// <summary>
        /// 子任务结果列表
        /// </summary>
        [JsonProperty("sub_jobs_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubJobResult> SubJobsResult { get; set; }

        /// <summary>
        /// 子任务ID列表
        /// </summary>
        [JsonProperty("sub_jobs_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubJobsList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobEntities {\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  currentTask: ").Append(CurrentTask).Append("\n");
            sb.Append("  imageName: ").Append(ImageName).Append("\n");
            sb.Append("  additionErrorCode: ").Append(AdditionErrorCode).Append("\n");
            sb.Append("  additionErrorMsg: ").Append(AdditionErrorMsg).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  error: ").Append(Error).Append("\n");
            sb.Append("  alarmCode: ").Append(AlarmCode).Append("\n");
            sb.Append("  processPercent: ").Append(ProcessPercent).Append("\n");
            sb.Append("  results: ").Append(Results).Append("\n");
            sb.Append("  subJobsResult: ").Append(SubJobsResult).Append("\n");
            sb.Append("  subJobsList: ").Append(SubJobsList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobEntities);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobEntities input)
        {
            if (input == null) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.CurrentTask != input.CurrentTask || (this.CurrentTask != null && !this.CurrentTask.Equals(input.CurrentTask))) return false;
            if (this.ImageName != input.ImageName || (this.ImageName != null && !this.ImageName.Equals(input.ImageName))) return false;
            if (this.AdditionErrorCode != input.AdditionErrorCode || (this.AdditionErrorCode != null && !this.AdditionErrorCode.Equals(input.AdditionErrorCode))) return false;
            if (this.AdditionErrorMsg != input.AdditionErrorMsg || (this.AdditionErrorMsg != null && !this.AdditionErrorMsg.Equals(input.AdditionErrorMsg))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.Error != input.Error || (this.Error != null && !this.Error.Equals(input.Error))) return false;
            if (this.AlarmCode != input.AlarmCode || (this.AlarmCode != null && !this.AlarmCode.Equals(input.AlarmCode))) return false;
            if (this.ProcessPercent != input.ProcessPercent || (this.ProcessPercent != null && !this.ProcessPercent.Equals(input.ProcessPercent))) return false;
            if (this.Results != input.Results || (this.Results != null && input.Results != null && !this.Results.SequenceEqual(input.Results))) return false;
            if (this.SubJobsResult != input.SubJobsResult || (this.SubJobsResult != null && input.SubJobsResult != null && !this.SubJobsResult.SequenceEqual(input.SubJobsResult))) return false;
            if (this.SubJobsList != input.SubJobsList || (this.SubJobsList != null && input.SubJobsList != null && !this.SubJobsList.SequenceEqual(input.SubJobsList))) return false;

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
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.CurrentTask != null) hashCode = hashCode * 59 + this.CurrentTask.GetHashCode();
                if (this.ImageName != null) hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.AdditionErrorCode != null) hashCode = hashCode * 59 + this.AdditionErrorCode.GetHashCode();
                if (this.AdditionErrorMsg != null) hashCode = hashCode * 59 + this.AdditionErrorMsg.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.Error != null) hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.AlarmCode != null) hashCode = hashCode * 59 + this.AlarmCode.GetHashCode();
                if (this.ProcessPercent != null) hashCode = hashCode * 59 + this.ProcessPercent.GetHashCode();
                if (this.Results != null) hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.SubJobsResult != null) hashCode = hashCode * 59 + this.SubJobsResult.GetHashCode();
                if (this.SubJobsList != null) hashCode = hashCode * 59 + this.SubJobsList.GetHashCode();
                return hashCode;
            }
        }
    }
}
