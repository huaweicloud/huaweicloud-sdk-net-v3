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
    public class ListSnapshotChainsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释** 快照链列表。 **取值范围** 不涉及
        /// </summary>
        [JsonProperty("snapshot_chains", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListSnapshotChainsResponseBodySnapshotChains> SnapshotChains { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSnapshotChainsResponse {\n");
            sb.Append("  snapshotChains: ").Append(SnapshotChains).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSnapshotChainsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSnapshotChainsResponse input)
        {
            if (input == null) return false;
            if (this.SnapshotChains != input.SnapshotChains || (this.SnapshotChains != null && input.SnapshotChains != null && !this.SnapshotChains.SequenceEqual(input.SnapshotChains))) return false;

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
                if (this.SnapshotChains != null) hashCode = hashCode * 59 + this.SnapshotChains.GetHashCode();
                return hashCode;
            }
        }
    }
}
