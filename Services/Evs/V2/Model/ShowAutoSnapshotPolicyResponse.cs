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
    public class ShowAutoSnapshotPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("snapshot_policy", NullValueHandling = NullValueHandling.Ignore)]
        public GetSnapshotPolicy SnapshotPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAutoSnapshotPolicyResponse {\n");
            sb.Append("  snapshotPolicy: ").Append(SnapshotPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAutoSnapshotPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAutoSnapshotPolicyResponse input)
        {
            if (input == null) return false;
            if (this.SnapshotPolicy != input.SnapshotPolicy || (this.SnapshotPolicy != null && !this.SnapshotPolicy.Equals(input.SnapshotPolicy))) return false;

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
                if (this.SnapshotPolicy != null) hashCode = hashCode * 59 + this.SnapshotPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
