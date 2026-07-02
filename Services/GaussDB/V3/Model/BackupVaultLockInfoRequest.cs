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
    public class BackupVaultLockInfoRequest 
    {

        /// <summary>
        /// **参数解释**：  合规锁保留期，单位是天。  **约束限制**：  仅支持按天配置。  **取值范围**：  1-36500。  **默认取值**：  1。
        /// </summary>
        [JsonProperty("lock_retention_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? LockRetentionDays { get; set; }

        /// <summary>
        /// **参数解释**：  合规锁配置策略。  **约束限制**：  不涉及。  **取值范围**：  当前仅支持设置为true，表示开启或延期合规锁。  **默认取值**：  true。
        /// </summary>
        [JsonProperty("lock_policy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LockPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupVaultLockInfoRequest {\n");
            sb.Append("  lockRetentionDays: ").Append(LockRetentionDays).Append("\n");
            sb.Append("  lockPolicy: ").Append(LockPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupVaultLockInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupVaultLockInfoRequest input)
        {
            if (input == null) return false;
            if (this.LockRetentionDays != input.LockRetentionDays || (this.LockRetentionDays != null && !this.LockRetentionDays.Equals(input.LockRetentionDays))) return false;
            if (this.LockPolicy != input.LockPolicy || (this.LockPolicy != null && !this.LockPolicy.Equals(input.LockPolicy))) return false;

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
                return hashCode;
            }
        }
    }
}
