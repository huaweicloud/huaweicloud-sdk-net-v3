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
    /// 备份策略对象，包括备份类型、备份保留天数、目标区域ID和目标project ID。
    /// </summary>
    public class OffSiteBackupPolicy 
    {

        /// <summary>
        /// 指定备份的类型。  SQL Server仅支持设置为“all”。  取值如下：  - auto：自动全量备份。 - incremental：自动增量备份。 - all：同时设置所有备份类型。   - MySQL：同时设置自动全量和自动增量备份。   - SQL Server：同时设置自动全量、自动增量备份和手动备份。
        /// </summary>
        [JsonProperty("backup_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupType { get; set; }

        /// <summary>
        /// 备份文件可以保存的天数。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }

        /// <summary>
        /// 设置跨区域备份策略的目标区域ID。
        /// </summary>
        [JsonProperty("destination_region", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// 设置跨区域备份策略的目标project ID。
        /// </summary>
        [JsonProperty("destination_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OffSiteBackupPolicy {\n");
            sb.Append("  backupType: ").Append(BackupType).Append("\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("  destinationRegion: ").Append(DestinationRegion).Append("\n");
            sb.Append("  destinationProjectId: ").Append(DestinationProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OffSiteBackupPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OffSiteBackupPolicy input)
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
                    this.KeepDays == input.KeepDays ||
                    (this.KeepDays != null &&
                    this.KeepDays.Equals(input.KeepDays))
                ) && 
                (
                    this.DestinationRegion == input.DestinationRegion ||
                    (this.DestinationRegion != null &&
                    this.DestinationRegion.Equals(input.DestinationRegion))
                ) && 
                (
                    this.DestinationProjectId == input.DestinationProjectId ||
                    (this.DestinationProjectId != null &&
                    this.DestinationProjectId.Equals(input.DestinationProjectId))
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
                if (this.KeepDays != null)
                    hashCode = hashCode * 59 + this.KeepDays.GetHashCode();
                if (this.DestinationRegion != null)
                    hashCode = hashCode * 59 + this.DestinationRegion.GetHashCode();
                if (this.DestinationProjectId != null)
                    hashCode = hashCode * 59 + this.DestinationProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
