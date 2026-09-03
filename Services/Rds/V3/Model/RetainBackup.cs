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
    /// **参数解释**  保留的备份  **约束限制**  不涉及  **取值范围**  不涉及  **默认取值**  不涉及
    /// </summary>
    public class RetainBackup 
    {

        /// <summary>
        /// **参数解释**：  备份名字  **约束限制**  不涉及  **取值范围**  不涉及  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：  备份ID  **约束限制**  不涉及  **取值范围**  不涉及  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：  备份类型。Db表示自动备份、Snapshot表示手动备份  **约束限制**  不涉及  **取值范围**  Db、Snapshot  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：  备份开始时间  **约束限制**  不涉及  **取值范围**  不涉及  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// **参数解释**：  备份结束时间  **约束限制**  不涉及  **取值范围**  不涉及  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**：  备份大小  **约束限制**  不涉及  **取值范围**  不涉及  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        /// <summary>
        /// **参数解释**：  备份描述信息  **约束限制**  不涉及  **取值范围**  不涉及  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("describe", NullValueHandling = NullValueHandling.Ignore)]
        public string Describe { get; set; }

        /// <summary>
        /// **参数解释**：  备份方式。Physics表示物理备份、Snapshot表示快照备份  **约束限制**  不涉及  **取值范围**  Physics、Snapshot  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("backup_method", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// **参数解释**：  备份是否tde加密  **约束限制**  不涉及  **取值范围**  false、true  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("tde", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tde { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetainBackup {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  describe: ").Append(Describe).Append("\n");
            sb.Append("  backupMethod: ").Append(BackupMethod).Append("\n");
            sb.Append("  tde: ").Append(Tde).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetainBackup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetainBackup input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Describe != input.Describe || (this.Describe != null && !this.Describe.Equals(input.Describe))) return false;
            if (this.BackupMethod != input.BackupMethod || (this.BackupMethod != null && !this.BackupMethod.Equals(input.BackupMethod))) return false;
            if (this.Tde != input.Tde || (this.Tde != null && !this.Tde.Equals(input.Tde))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Describe != null) hashCode = hashCode * 59 + this.Describe.GetHashCode();
                if (this.BackupMethod != null) hashCode = hashCode * 59 + this.BackupMethod.GetHashCode();
                if (this.Tde != null) hashCode = hashCode * 59 + this.Tde.GetHashCode();
                return hashCode;
            }
        }
    }
}
