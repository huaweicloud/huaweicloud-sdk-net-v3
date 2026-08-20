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
    /// 批量创建快照的结果。
    /// </summary>
    public class BatchCreateSnapshotResponseResult 
    {

        /// <summary>
        /// 创建成功的快照列表。
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateSnapshotResult> Success { get; set; }

        /// <summary>
        /// 创建失败的快照列表。
        /// </summary>
        [JsonProperty("failed", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateSnapshotResult> Failed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateSnapshotResponseResult {\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  failed: ").Append(Failed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateSnapshotResponseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateSnapshotResponseResult input)
        {
            if (input == null) return false;
            if (this.Success != input.Success || (this.Success != null && input.Success != null && !this.Success.SequenceEqual(input.Success))) return false;
            if (this.Failed != input.Failed || (this.Failed != null && input.Failed != null && !this.Failed.SequenceEqual(input.Failed))) return false;

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
                if (this.Success != null) hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Failed != null) hashCode = hashCode * 59 + this.Failed.GetHashCode();
                return hashCode;
            }
        }
    }
}
