using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 备份用量详情
    /// </summary>
    public class Spaces 
    {

        /// <summary>
        /// **参数解释**：  日志备份用量，单位MB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("obs", NullValueHandling = NullValueHandling.Ignore)]
        public double? Obs { get; set; }

        /// <summary>
        /// **参数解释**：  rds侧快照备份用量，单位MB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public double? Snapshot { get; set; }

        /// <summary>
        /// **参数解释**：  日志备份赠送空间，单位GB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("obs_free", NullValueHandling = NullValueHandling.Ignore)]
        public double? ObsFree { get; set; }

        /// <summary>
        /// **参数解释**：  快照备份赠送空间，单位GB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("snapshot_free", NullValueHandling = NullValueHandling.Ignore)]
        public double? SnapshotFree { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Spaces {\n");
            sb.Append("  obs: ").Append(Obs).Append("\n");
            sb.Append("  snapshot: ").Append(Snapshot).Append("\n");
            sb.Append("  obsFree: ").Append(ObsFree).Append("\n");
            sb.Append("  snapshotFree: ").Append(SnapshotFree).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Spaces);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Spaces input)
        {
            if (input == null) return false;
            if (this.Obs != input.Obs || (this.Obs != null && !this.Obs.Equals(input.Obs))) return false;
            if (this.Snapshot != input.Snapshot || (this.Snapshot != null && !this.Snapshot.Equals(input.Snapshot))) return false;
            if (this.ObsFree != input.ObsFree || (this.ObsFree != null && !this.ObsFree.Equals(input.ObsFree))) return false;
            if (this.SnapshotFree != input.SnapshotFree || (this.SnapshotFree != null && !this.SnapshotFree.Equals(input.SnapshotFree))) return false;

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
                if (this.Obs != null) hashCode = hashCode * 59 + this.Obs.GetHashCode();
                if (this.Snapshot != null) hashCode = hashCode * 59 + this.Snapshot.GetHashCode();
                if (this.ObsFree != null) hashCode = hashCode * 59 + this.ObsFree.GetHashCode();
                if (this.SnapshotFree != null) hashCode = hashCode * 59 + this.SnapshotFree.GetHashCode();
                return hashCode;
            }
        }
    }
}
