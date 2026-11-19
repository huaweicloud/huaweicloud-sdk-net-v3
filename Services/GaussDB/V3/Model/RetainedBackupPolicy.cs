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
    /// 保留策略信息。
    /// </summary>
    public class RetainedBackupPolicy 
    {

        /// <summary>
        /// **参数解释**：  实例释放保留策略。  **约束限制**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("backup_retention_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupRetentionStrategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetainedBackupPolicy {\n");
            sb.Append("  backupRetentionStrategy: ").Append(BackupRetentionStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetainedBackupPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetainedBackupPolicy input)
        {
            if (input == null) return false;
            if (this.BackupRetentionStrategy != input.BackupRetentionStrategy || (this.BackupRetentionStrategy != null && !this.BackupRetentionStrategy.Equals(input.BackupRetentionStrategy))) return false;

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
                if (this.BackupRetentionStrategy != null) hashCode = hashCode * 59 + this.BackupRetentionStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
