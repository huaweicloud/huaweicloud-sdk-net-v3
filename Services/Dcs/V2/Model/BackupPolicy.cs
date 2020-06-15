using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BackupPolicy 
    {

        /// <summary>
        /// 备份类型。 - auto：自动备份 - manual：手动备份 
        /// </summary>
        [JsonProperty("backup_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupType { get; set; }

        /// <summary>
        /// 当backup_type设置为manual时，该参数为必填。 保留天数，单位：天，取值范围：1-7。 
        /// </summary>
        [JsonProperty("save_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? SaveDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("periodical_backup_plan", NullValueHandling = NullValueHandling.Ignore)]
        public BackupPlan PeriodicalBackupPlan { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupPolicy {\n");
            sb.Append("  backupType: ").Append(BackupType).Append("\n");
            sb.Append("  saveDays: ").Append(SaveDays).Append("\n");
            sb.Append("  periodicalBackupPlan: ").Append(PeriodicalBackupPlan).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupType == input.BackupType ||
                    (this.BackupType != null &&
                    this.BackupType.Equals(input.BackupType))
                ) && 
                (
                    this.SaveDays == input.SaveDays ||
                    (this.SaveDays != null &&
                    this.SaveDays.Equals(input.SaveDays))
                ) && 
                (
                    this.PeriodicalBackupPlan == input.PeriodicalBackupPlan ||
                    (this.PeriodicalBackupPlan != null &&
                    this.PeriodicalBackupPlan.Equals(input.PeriodicalBackupPlan))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.BackupType != null)
                    hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.SaveDays != null)
                    hashCode = hashCode * 59 + this.SaveDays.GetHashCode();
                if (this.PeriodicalBackupPlan != null)
                    hashCode = hashCode * 59 + this.PeriodicalBackupPlan.GetHashCode();
                return hashCode;
            }
        }
    }
}
