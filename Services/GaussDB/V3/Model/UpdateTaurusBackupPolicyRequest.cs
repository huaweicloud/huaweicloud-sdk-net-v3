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
    /// 修改同区域备份策略请求体。
    /// </summary>
    public class UpdateTaurusBackupPolicyRequest 
    {

        /// <summary>
        /// **参数解释**：  备份时间段开始时间。  **约束限制**：  不涉及。  **取值范围**：  格式必须为hh:mm且有效，h为0~23的数字，m为0~59的数字，当前时间指UTC时间。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// **参数解释**：  备份时间段结束时间。  **约束限制**：  end_time必须大于begin_time。  **取值范围**：  格式必须为hh:mm且有效，h为0~23的数字，m为0~59的数字，当前时间指UTC时间。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**：  一级备份保留数量。  **约束限制**：  当一级备份开关开启时，该参数必传。反之，不能传。  **取值范围**：  - 0：不保留一级备份。 - 1：一级备份保留数量，单位为个。  **默认取值**：  0。
        /// </summary>
        [JsonProperty("retention_num_backup_level1", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionNumBackupLevel1 { get; set; }

        /// <summary>
        /// **参数解释**：  备份策略集，包含备份周期、保留天数和策略类型等配置信息，详见Policy数据结构。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Policy> Policies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTaurusBackupPolicyRequest {\n");
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
            return this.Equals(input as UpdateTaurusBackupPolicyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTaurusBackupPolicyRequest input)
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
