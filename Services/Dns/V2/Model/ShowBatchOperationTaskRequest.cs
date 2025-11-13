using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowBatchOperationTaskRequest 
    {

        /// <summary>
        /// **参数解释：** 批量操作任务的ID。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("task_id", IsPath = true)]
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// **参数解释：** 分页查询时配置每页返回的失败条目个数。 **约束限制：** 不涉及。 **取值范围：** 0~500。 **默认取值：** 500
        /// </summary>
        [SDKProperty("error_item_limit", IsQuery = true)]
        [JsonProperty("error_item_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrorItemLimit { get; set; }

        /// <summary>
        /// **参数解释：** 分页查询起始偏移量，表示从偏移量的下一个失败条目开始查询。 **约束限制：** 不涉及。 **取值范围：** 0~2147483647。 **默认取值：** 0
        /// </summary>
        [SDKProperty("error_item_offset", IsQuery = true)]
        [JsonProperty("error_item_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrorItemOffset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBatchOperationTaskRequest {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  errorItemLimit: ").Append(ErrorItemLimit).Append("\n");
            sb.Append("  errorItemOffset: ").Append(ErrorItemOffset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBatchOperationTaskRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBatchOperationTaskRequest input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.ErrorItemLimit != input.ErrorItemLimit || (this.ErrorItemLimit != null && !this.ErrorItemLimit.Equals(input.ErrorItemLimit))) return false;
            if (this.ErrorItemOffset != input.ErrorItemOffset || (this.ErrorItemOffset != null && !this.ErrorItemOffset.Equals(input.ErrorItemOffset))) return false;

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
                if (this.ErrorItemLimit != null) hashCode = hashCode * 59 + this.ErrorItemLimit.GetHashCode();
                if (this.ErrorItemOffset != null) hashCode = hashCode * 59 + this.ErrorItemOffset.GetHashCode();
                return hashCode;
            }
        }
    }
}
