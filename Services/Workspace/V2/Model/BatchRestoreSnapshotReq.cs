using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 批量恢复快照请求体。
    /// </summary>
    public class BatchRestoreSnapshotReq 
    {

        /// <summary>
        /// 桌面快照记录id数组，最多支持100。
        /// </summary>
        [JsonProperty("snapshot_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SnapshotIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRestoreSnapshotReq {\n");
            sb.Append("  snapshotIds: ").Append(SnapshotIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchRestoreSnapshotReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchRestoreSnapshotReq input)
        {
            if (input == null) return false;
            if (this.SnapshotIds != input.SnapshotIds || (this.SnapshotIds != null && input.SnapshotIds != null && !this.SnapshotIds.SequenceEqual(input.SnapshotIds))) return false;

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
                if (this.SnapshotIds != null) hashCode = hashCode * 59 + this.SnapshotIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
