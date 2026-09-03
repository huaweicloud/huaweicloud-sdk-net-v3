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
    /// 
    /// </summary>
    public class DeleteTaskParams 
    {

        /// <summary>
        /// 测试计划id
        /// </summary>
        [JsonProperty("planId", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }

        /// <summary>
        /// 任务id列表信息
        /// </summary>
        [JsonProperty("taskIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TaskIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTaskParams {\n");
            sb.Append("  planId: ").Append(PlanId).Append("\n");
            sb.Append("  taskIds: ").Append(TaskIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTaskParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTaskParams input)
        {
            if (input == null) return false;
            if (this.PlanId != input.PlanId || (this.PlanId != null && !this.PlanId.Equals(input.PlanId))) return false;
            if (this.TaskIds != input.TaskIds || (this.TaskIds != null && input.TaskIds != null && !this.TaskIds.SequenceEqual(input.TaskIds))) return false;

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
                if (this.PlanId != null) hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.TaskIds != null) hashCode = hashCode * 59 + this.TaskIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
