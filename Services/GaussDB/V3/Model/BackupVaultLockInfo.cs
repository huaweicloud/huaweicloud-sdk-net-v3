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
    /// 
    /// </summary>
    public class BackupVaultLockInfo 
    {

        /// <summary>
        /// **参数解释**：  合规锁保留期，单位是天。  **取值范围**：  1-36500。
        /// </summary>
        [JsonProperty("lock_retention_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? LockRetentionDays { get; set; }

        /// <summary>
        /// **参数解释**：  合规锁配置策略。  **取值范围**：  - true：已开启合规锁配置。 - false: 未开启合规锁配置。
        /// </summary>
        [JsonProperty("lock_policy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LockPolicy { get; set; }

        /// <summary>
        /// **参数解释**：  合规锁开始时间，时间戳格式。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("lock_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LockStartTime { get; set; }

        /// <summary>
        /// **参数解释**：  合规锁结束时间，时间戳格式。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("lock_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LockEndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupVaultLockInfo {\n");
            sb.Append("  lockRetentionDays: ").Append(LockRetentionDays).Append("\n");
            sb.Append("  lockPolicy: ").Append(LockPolicy).Append("\n");
            sb.Append("  lockStartTime: ").Append(LockStartTime).Append("\n");
            sb.Append("  lockEndTime: ").Append(LockEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupVaultLockInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupVaultLockInfo input)
        {
            if (input == null) return false;
            if (this.LockRetentionDays != input.LockRetentionDays || (this.LockRetentionDays != null && !this.LockRetentionDays.Equals(input.LockRetentionDays))) return false;
            if (this.LockPolicy != input.LockPolicy || (this.LockPolicy != null && !this.LockPolicy.Equals(input.LockPolicy))) return false;
            if (this.LockStartTime != input.LockStartTime || (this.LockStartTime != null && !this.LockStartTime.Equals(input.LockStartTime))) return false;
            if (this.LockEndTime != input.LockEndTime || (this.LockEndTime != null && !this.LockEndTime.Equals(input.LockEndTime))) return false;

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
                if (this.LockRetentionDays != null) hashCode = hashCode * 59 + this.LockRetentionDays.GetHashCode();
                if (this.LockPolicy != null) hashCode = hashCode * 59 + this.LockPolicy.GetHashCode();
                if (this.LockStartTime != null) hashCode = hashCode * 59 + this.LockStartTime.GetHashCode();
                if (this.LockEndTime != null) hashCode = hashCode * 59 + this.LockEndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
