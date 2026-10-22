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
    public class ListSnapshotGroupResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释** 快照一致性组列表信息。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("snapshot_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SnapshotGroupDetail> SnapshotGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSnapshotGroupResponse {\n");
            sb.Append("  snapshotGroups: ").Append(SnapshotGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSnapshotGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSnapshotGroupResponse input)
        {
            if (input == null) return false;
            if (this.SnapshotGroups != input.SnapshotGroups || (this.SnapshotGroups != null && input.SnapshotGroups != null && !this.SnapshotGroups.SequenceEqual(input.SnapshotGroups))) return false;

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
                if (this.SnapshotGroups != null) hashCode = hashCode * 59 + this.SnapshotGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
