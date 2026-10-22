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
    public class DeleteAutoSnapshotPolicyRequest 
    {

        /// <summary>
        /// 自动快照策略ID。
        /// </summary>
        [SDKProperty("snapshot_policy_id", IsPath = true)]
        [JsonProperty("snapshot_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotPolicyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAutoSnapshotPolicyRequest {\n");
            sb.Append("  snapshotPolicyId: ").Append(SnapshotPolicyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAutoSnapshotPolicyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAutoSnapshotPolicyRequest input)
        {
            if (input == null) return false;
            if (this.SnapshotPolicyId != input.SnapshotPolicyId || (this.SnapshotPolicyId != null && !this.SnapshotPolicyId.Equals(input.SnapshotPolicyId))) return false;

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
                if (this.SnapshotPolicyId != null) hashCode = hashCode * 59 + this.SnapshotPolicyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
