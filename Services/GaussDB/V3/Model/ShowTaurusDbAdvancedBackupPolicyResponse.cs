using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTaurusDbAdvancedBackupPolicyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  备份时间段开始时间。  **取值范围**：  非空，格式必须为hh:mm且有效，当前时间指UTC时间。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// **参数解释**：  备份时间段结束时间。  **取值范围**：  非空，格式必须为hh:mm且有效，当前时间指UTC时间。end_time必须大于begin_time。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**：  一级备份保留数量。当一级备份开关开启时，返回此参数。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("retention_num_backup_level1", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionNumBackupLevel1 { get; set; }

        /// <summary>
        /// **参数解释**：  备份策略集。
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<BackupPolicyInfo> Policies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTaurusDbAdvancedBackupPolicyResponse {\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  retentionNumBackupLevel1: ").Append(RetentionNumBackupLevel1).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTaurusDbAdvancedBackupPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTaurusDbAdvancedBackupPolicyResponse input)
        {
            if (input == null) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.RetentionNumBackupLevel1 != input.RetentionNumBackupLevel1 || (this.RetentionNumBackupLevel1 != null && !this.RetentionNumBackupLevel1.Equals(input.RetentionNumBackupLevel1))) return false;
            if (this.Policies != input.Policies || (this.Policies != null && input.Policies != null && !this.Policies.SequenceEqual(input.Policies))) return false;

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
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.RetentionNumBackupLevel1 != null) hashCode = hashCode * 59 + this.RetentionNumBackupLevel1.GetHashCode();
                if (this.Policies != null) hashCode = hashCode * 59 + this.Policies.GetHashCode();
                return hashCode;
            }
        }
    }
}
