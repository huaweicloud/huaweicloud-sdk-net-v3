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
    /// Response Object
    /// </summary>
    public class ListAutoSnapshotPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 查询的自动快照策略列表信息。
        /// </summary>
        [JsonProperty("snapshot_policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<GetSnapshotPolicy> SnapshotPolicies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAutoSnapshotPolicyResponse {\n");
            sb.Append("  snapshotPolicies: ").Append(SnapshotPolicies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAutoSnapshotPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAutoSnapshotPolicyResponse input)
        {
            if (input == null) return false;
            if (this.SnapshotPolicies != input.SnapshotPolicies || (this.SnapshotPolicies != null && input.SnapshotPolicies != null && !this.SnapshotPolicies.SequenceEqual(input.SnapshotPolicies))) return false;

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
                if (this.SnapshotPolicies != null) hashCode = hashCode * 59 + this.SnapshotPolicies.GetHashCode();
                return hashCode;
            }
        }
    }
}
