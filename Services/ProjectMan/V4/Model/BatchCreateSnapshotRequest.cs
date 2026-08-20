using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 批量创建工作项快照请求对象
    /// </summary>
    public class BatchCreateSnapshotRequest 
    {

        /// <summary>
        /// 需要创建快照的工作项数组。 每次最多支持对50个工作项创建快照。
        /// </summary>
        [JsonProperty("issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchCreateSnapshotRequestIssues> Issues { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateSnapshotRequest {\n");
            sb.Append("  issues: ").Append(Issues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateSnapshotRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateSnapshotRequest input)
        {
            if (input == null) return false;
            if (this.Issues != input.Issues || (this.Issues != null && input.Issues != null && !this.Issues.SequenceEqual(input.Issues))) return false;

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
                if (this.Issues != null) hashCode = hashCode * 59 + this.Issues.GetHashCode();
                return hashCode;
            }
        }
    }
}
