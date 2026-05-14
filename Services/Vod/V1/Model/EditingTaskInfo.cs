using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EditingTaskInfo 
    {

        /// <summary>
        /// 编辑任务ID 
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 输出的媒资ID 
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 任务状态 - WAITING 等待中 - PROCESSING 处理中； - SUCCEED 成功； - FAILED 失败； - CANCEL 已取消； 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 进度，取值0-100 
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public int? Progress { get; set; }

        /// <summary>
        /// 任务创建时间，格式按照RFC3339，UTC时间，如2020-09-01T18:50:20Z 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 任务结束时间，格式按照RFC3339，UTC时间，如2020-09-01T18:50:20Z，当任务结束时才有值 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditingTaskInfo {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EditingTaskInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EditingTaskInfo input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
