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
    public class ListInstanceReplicationPolicyExecSubTasksResponse : SdkResponse
    {

        /// <summary>
        /// 老化策略执行记录子任务列表
        /// </summary>
        [JsonProperty("subtasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubtaskDetail> Subtasks { get; set; }

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
            sb.Append("class ListInstanceReplicationPolicyExecSubTasksResponse {\n");
            sb.Append("  subtasks: ").Append(Subtasks).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceReplicationPolicyExecSubTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceReplicationPolicyExecSubTasksResponse input)
        {
            if (input == null) return false;
            if (this.Subtasks != input.Subtasks || (this.Subtasks != null && input.Subtasks != null && !this.Subtasks.SequenceEqual(input.Subtasks))) return false;
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
                if (this.Subtasks != null) hashCode = hashCode * 59 + this.Subtasks.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
