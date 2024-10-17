using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EditingJob 
    {

        /// <summary>
        /// 任务ID 
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务状态。  取值如下： - INIT：初始状态。 - WAITING：等待启动。 - PROCESSING：处理中。 - SUCCEED：处理成功。 - FAILED：处理失败。 - CANCELED：已取消。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 任务创建时间 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 任务启动时间 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务结束时间 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 任务的返回码。 
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 用户数据。 
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// 任务ID 
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 剪辑任务类型。取值如下：\&quot;CLIP\&quot;,\&quot;CONCAT\&quot;,\&quot;CONCATS\&quot;,\&quot;MIX\&quot;。
        /// </summary>
        [JsonProperty("edit_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EditType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("edit_task_req", NullValueHandling = NullValueHandling.Ignore)]
        public CreateEditingJobReq EditTaskReq { get; set; }

        /// <summary>
        /// 剪辑输出meta信息
        /// </summary>
        [JsonProperty("output_file_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<OutputFileInfo> OutputFileInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditingJob {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  editType: ").Append(EditType).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  editTaskReq: ").Append(EditTaskReq).Append("\n");
            sb.Append("  outputFileInfo: ").Append(OutputFileInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EditingJob);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EditingJob input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.UserData != input.UserData || (this.UserData != null && !this.UserData.Equals(input.UserData))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.EditType != input.EditType || (this.EditType != null && input.EditType != null && !this.EditType.SequenceEqual(input.EditType))) return false;
            if (this.Output != input.Output || (this.Output != null && !this.Output.Equals(input.Output))) return false;
            if (this.EditTaskReq != input.EditTaskReq || (this.EditTaskReq != null && !this.EditTaskReq.Equals(input.EditTaskReq))) return false;
            if (this.OutputFileInfo != input.OutputFileInfo || (this.OutputFileInfo != null && input.OutputFileInfo != null && !this.OutputFileInfo.SequenceEqual(input.OutputFileInfo))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UserData != null) hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.EditType != null) hashCode = hashCode * 59 + this.EditType.GetHashCode();
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.EditTaskReq != null) hashCode = hashCode * 59 + this.EditTaskReq.GetHashCode();
                if (this.OutputFileInfo != null) hashCode = hashCode * 59 + this.OutputFileInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
