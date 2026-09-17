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
    public class Space 
    {

        /// <summary>
        /// **参数解释**：  日志备份用量，单位MB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("obs", NullValueHandling = NullValueHandling.Ignore)]
        public double? Obs { get; set; }

        /// <summary>
        /// **参数解释**：  审计日志用量，单位MB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("auditlog", NullValueHandling = NullValueHandling.Ignore)]
        public double? Auditlog { get; set; }

        /// <summary>
        /// **参数解释**：  rds侧快照备份用量，单位MB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public double? Snapshot { get; set; }

        /// <summary>
        /// **参数解释**：  rds侧CBR快照备份用量，单位MB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("cbr_snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public double? CbrSnapshot { get; set; }

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
        /// **参数解释**：  全量备份大小，单位GB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("db", NullValueHandling = NullValueHandling.Ignore)]
        public double? Db { get; set; }

        /// <summary>
        /// **参数解释**：  增量备份大小，单位GB。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("log", NullValueHandling = NullValueHandling.Ignore)]
        public double? Log { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Space {\n");
            sb.Append("  obs: ").Append(Obs).Append("\n");
            sb.Append("  auditlog: ").Append(Auditlog).Append("\n");
            sb.Append("  snapshot: ").Append(Snapshot).Append("\n");
            sb.Append("  cbrSnapshot: ").Append(CbrSnapshot).Append("\n");
            sb.Append("  obsFree: ").Append(ObsFree).Append("\n");
            sb.Append("  snapshotFree: ").Append(SnapshotFree).Append("\n");
            sb.Append("  db: ").Append(Db).Append("\n");
            sb.Append("  log: ").Append(Log).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Space);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Space input)
        {
            if (input == null) return false;
            if (this.Obs != input.Obs || (this.Obs != null && !this.Obs.Equals(input.Obs))) return false;
            if (this.Auditlog != input.Auditlog || (this.Auditlog != null && !this.Auditlog.Equals(input.Auditlog))) return false;
            if (this.Snapshot != input.Snapshot || (this.Snapshot != null && !this.Snapshot.Equals(input.Snapshot))) return false;
            if (this.CbrSnapshot != input.CbrSnapshot || (this.CbrSnapshot != null && !this.CbrSnapshot.Equals(input.CbrSnapshot))) return false;
            if (this.ObsFree != input.ObsFree || (this.ObsFree != null && !this.ObsFree.Equals(input.ObsFree))) return false;
            if (this.SnapshotFree != input.SnapshotFree || (this.SnapshotFree != null && !this.SnapshotFree.Equals(input.SnapshotFree))) return false;
            if (this.Db != input.Db || (this.Db != null && !this.Db.Equals(input.Db))) return false;
            if (this.Log != input.Log || (this.Log != null && !this.Log.Equals(input.Log))) return false;

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
                if (this.Auditlog != null) hashCode = hashCode * 59 + this.Auditlog.GetHashCode();
                if (this.Snapshot != null) hashCode = hashCode * 59 + this.Snapshot.GetHashCode();
                if (this.CbrSnapshot != null) hashCode = hashCode * 59 + this.CbrSnapshot.GetHashCode();
                if (this.ObsFree != null) hashCode = hashCode * 59 + this.ObsFree.GetHashCode();
                if (this.SnapshotFree != null) hashCode = hashCode * 59 + this.SnapshotFree.GetHashCode();
                if (this.Db != null) hashCode = hashCode * 59 + this.Db.GetHashCode();
                if (this.Log != null) hashCode = hashCode * 59 + this.Log.GetHashCode();
                return hashCode;
            }
        }
    }
}
