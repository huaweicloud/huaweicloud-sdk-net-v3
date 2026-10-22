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
    /// 创建快照一致性组的请求体。
    /// </summary>
    public class CreateSnapshotGroupRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("snapshot_group", NullValueHandling = NullValueHandling.Ignore)]
        public SnapshotGroup SnapshotGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSnapshotGroupRequestBody {\n");
            sb.Append("  snapshotGroup: ").Append(SnapshotGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSnapshotGroupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSnapshotGroupRequestBody input)
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
