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
    public class ListSnapshotsDetailsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释** 快照信息。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("snapshots", NullValueHandling = NullValueHandling.Ignore)]
        public List<SnapshotDetailV5> Snapshots { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSnapshotsDetailsResponse {\n");
            sb.Append("  snapshots: ").Append(Snapshots).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSnapshotsDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSnapshotsDetailsResponse input)
        {
            if (input == null) return false;
            if (this.Snapshots != input.Snapshots || (this.Snapshots != null && input.Snapshots != null && !this.Snapshots.SequenceEqual(input.Snapshots))) return false;

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
                if (this.Snapshots != null) hashCode = hashCode * 59 + this.Snapshots.GetHashCode();
                return hashCode;
            }
        }
    }
}
