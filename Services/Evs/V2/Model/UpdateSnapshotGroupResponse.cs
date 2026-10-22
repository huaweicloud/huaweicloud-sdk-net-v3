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
    public class UpdateSnapshotGroupResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("snapshot_group", NullValueHandling = NullValueHandling.Ignore)]
        public SnapshotGroupDetail SnapshotGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSnapshotGroupResponse {\n");
            sb.Append("  snapshotGroup: ").Append(SnapshotGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSnapshotGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSnapshotGroupResponse input)
        {
            if (input == null) return false;
            if (this.SnapshotGroup != input.SnapshotGroup || (this.SnapshotGroup != null && !this.SnapshotGroup.Equals(input.SnapshotGroup))) return false;

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
                if (this.SnapshotGroup != null) hashCode = hashCode * 59 + this.SnapshotGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
