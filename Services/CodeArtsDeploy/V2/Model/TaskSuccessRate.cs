using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 单个应用的部署成功率
    /// </summary>
    public class TaskSuccessRate 
    {

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 成功率
        /// </summary>
        [JsonProperty("success_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string SuccessRate { get; set; }

        /// <summary>
        /// 部署记录数
        /// </summary>
        [JsonProperty("record_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordCount { get; set; }

        /// <summary>
        /// 成功的部署记录数
        /// </summary>
        [JsonProperty("success_record_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessRecordCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskSuccessRate {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  successRate: ").Append(SuccessRate).Append("\n");
            sb.Append("  recordCount: ").Append(RecordCount).Append("\n");
            sb.Append("  successRecordCount: ").Append(SuccessRecordCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskSuccessRate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskSuccessRate input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.SuccessRate != input.SuccessRate || (this.SuccessRate != null && !this.SuccessRate.Equals(input.SuccessRate))) return false;
            if (this.RecordCount != input.RecordCount || (this.RecordCount != null && !this.RecordCount.Equals(input.RecordCount))) return false;
            if (this.SuccessRecordCount != input.SuccessRecordCount || (this.SuccessRecordCount != null && !this.SuccessRecordCount.Equals(input.SuccessRecordCount))) return false;

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
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.SuccessRate != null) hashCode = hashCode * 59 + this.SuccessRate.GetHashCode();
                if (this.RecordCount != null) hashCode = hashCode * 59 + this.RecordCount.GetHashCode();
                if (this.SuccessRecordCount != null) hashCode = hashCode * 59 + this.SuccessRecordCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
