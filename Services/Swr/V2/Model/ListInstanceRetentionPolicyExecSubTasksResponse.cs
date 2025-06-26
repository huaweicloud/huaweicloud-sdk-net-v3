using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstanceRetentionPolicyExecSubTasksResponse : SdkResponse
    {

        /// <summary>
        /// 老化策略执行记录子任务列表
        /// </summary>
        [JsonProperty("sub_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Subtask> SubTasks { get; set; }

        /// <summary>
        /// 老化策略执行记录子任务总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceRetentionPolicyExecSubTasksResponse {\n");
            sb.Append("  subTasks: ").Append(SubTasks).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceRetentionPolicyExecSubTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceRetentionPolicyExecSubTasksResponse input)
        {
            if (input == null) return false;
            if (this.SubTasks != input.SubTasks || (this.SubTasks != null && input.SubTasks != null && !this.SubTasks.SequenceEqual(input.SubTasks))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.SubTasks != null) hashCode = hashCode * 59 + this.SubTasks.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
