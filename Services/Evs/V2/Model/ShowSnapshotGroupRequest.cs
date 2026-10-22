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
    public class ShowSnapshotGroupRequest 
    {

        /// <summary>
        /// **参数解释** 快照一致性组ID。 可通过[查询快照一致性组列表](ListSnapshotGroup.xml)接口获取快照一致性组ID。 **约束限制** 不涉及。 **取值范围** 不涉及。 **默认取值** 不涉及。
        /// </summary>
        [SDKProperty("snapshot_group_id", IsPath = true)]
        [JsonProperty("snapshot_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSnapshotGroupRequest {\n");
            sb.Append("  snapshotGroupId: ").Append(SnapshotGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSnapshotGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSnapshotGroupRequest input)
        {
            if (input == null) return false;
            if (this.SnapshotGroupId != input.SnapshotGroupId || (this.SnapshotGroupId != null && !this.SnapshotGroupId.Equals(input.SnapshotGroupId))) return false;

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
                if (this.SnapshotGroupId != null) hashCode = hashCode * 59 + this.SnapshotGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
