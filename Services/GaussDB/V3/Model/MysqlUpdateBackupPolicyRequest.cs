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
    /// 设置自动备份策略信息
    /// </summary>
    public class MysqlUpdateBackupPolicyRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_policy", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlBackupPolicy BackupPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlUpdateBackupPolicyRequest {\n");
            sb.Append("  backupPolicy: ").Append(BackupPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlUpdateBackupPolicyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlUpdateBackupPolicyRequest input)
        {
            if (input == null) return false;
            if (this.BackupPolicy != input.BackupPolicy || (this.BackupPolicy != null && !this.BackupPolicy.Equals(input.BackupPolicy))) return false;

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
                if (this.BackupPolicy != null) hashCode = hashCode * 59 + this.BackupPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
