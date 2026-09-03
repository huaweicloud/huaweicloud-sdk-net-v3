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
    /// 切换实例备份方式请求体
    /// </summary>
    public class UpdateInstanceBackupMethodRequestBody 
    {

        /// <summary>
        /// **参数解释**：  修改的备份方式。Db为物理备份（OBS），EBackup为CBR快照备份。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("backup_method", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupMethod { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstanceBackupMethodRequestBody {\n");
            sb.Append("  backupMethod: ").Append(BackupMethod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInstanceBackupMethodRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInstanceBackupMethodRequestBody input)
        {
            if (input == null) return false;
            if (this.BackupMethod != input.BackupMethod || (this.BackupMethod != null && !this.BackupMethod.Equals(input.BackupMethod))) return false;

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
                if (this.BackupMethod != null) hashCode = hashCode * 59 + this.BackupMethod.GetHashCode();
                return hashCode;
            }
        }
    }
}
