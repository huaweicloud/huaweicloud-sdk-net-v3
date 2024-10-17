using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 创建备份迁移任务请求。
    /// </summary>
    public class CreateOfflineTaskReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("base_info", NullValueHandling = NullValueHandling.Ignore)]
        public BackupJobBaseInfo BaseInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_db_info", NullValueHandling = NullValueHandling.Ignore)]
        public BackupJobEndpointInfo TargetDbInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_info", NullValueHandling = NullValueHandling.Ignore)]
        public BackupInfo BackupInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public BackupRestoreOptionInfo Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOfflineTaskReq {\n");
            sb.Append("  baseInfo: ").Append(BaseInfo).Append("\n");
            sb.Append("  targetDbInfo: ").Append(TargetDbInfo).Append("\n");
            sb.Append("  backupInfo: ").Append(BackupInfo).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOfflineTaskReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateOfflineTaskReq input)
        {
            if (input == null) return false;
            if (this.BaseInfo != input.BaseInfo || (this.BaseInfo != null && !this.BaseInfo.Equals(input.BaseInfo))) return false;
            if (this.TargetDbInfo != input.TargetDbInfo || (this.TargetDbInfo != null && !this.TargetDbInfo.Equals(input.TargetDbInfo))) return false;
            if (this.BackupInfo != input.BackupInfo || (this.BackupInfo != null && !this.BackupInfo.Equals(input.BackupInfo))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;

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
                if (this.BaseInfo != null) hashCode = hashCode * 59 + this.BaseInfo.GetHashCode();
                if (this.TargetDbInfo != null) hashCode = hashCode * 59 + this.TargetDbInfo.GetHashCode();
                if (this.BackupInfo != null) hashCode = hashCode * 59 + this.BackupInfo.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
