using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowSnapshotRequest 
    {

        /// <summary>
        /// 快照ID。
        /// </summary>
        [SDKProperty("snapshot_id", IsPath = true)]
        [JsonProperty("snapshot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSnapshotRequest {\n");
            sb.Append("  snapshotId: ").Append(SnapshotId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSnapshotRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSnapshotRequest input)
        {
            if (input == null) return false;
            if (this.SnapshotId != input.SnapshotId || (this.SnapshotId != null && !this.SnapshotId.Equals(input.SnapshotId))) return false;

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
                if (this.SnapshotId != null) hashCode = hashCode * 59 + this.SnapshotId.GetHashCode();
                return hashCode;
            }
        }
    }
}
