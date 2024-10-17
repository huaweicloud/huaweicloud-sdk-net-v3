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
    /// 备份策略信息。
    /// </summary>
    public class UpdateBackupOffsitePolicyInfo 
    {

        /// <summary>
        /// 是否开启跨区域全量备份。 - true：开启跨区域全量备份。 - false：关闭跨区域全量备份。
        /// </summary>
        [JsonProperty("open_auto_backup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenAutoBackup { get; set; }

        /// <summary>
        /// 是否开启跨区域增量备份。 - true：开启跨区域增量备份，当open_auto_backup开启时才可以开启。 - false：关闭跨区域增量备份。
        /// </summary>
        [JsonProperty("open_incremental_backup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenIncrementalBackup { get; set; }

        /// <summary>
        /// 设置跨区域备份策略的目标project ID。    租户在某一Region下的project ID。                              获取方法请参见[获取项目ID](https://support.huaweicloud.com/api-gaussdbformysql/gaussdbformysql_10_0004.html)。
        /// </summary>
        [JsonProperty("destination_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationProjectId { get; set; }

        /// <summary>
        /// 设置跨区域备份策略的目标区域。
        /// </summary>
        [JsonProperty("destination_region", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// 指定已生成的备份文件可以保存的天数。  取值范围：1～1825。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBackupOffsitePolicyInfo {\n");
            sb.Append("  openAutoBackup: ").Append(OpenAutoBackup).Append("\n");
            sb.Append("  openIncrementalBackup: ").Append(OpenIncrementalBackup).Append("\n");
            sb.Append("  destinationProjectId: ").Append(DestinationProjectId).Append("\n");
            sb.Append("  destinationRegion: ").Append(DestinationRegion).Append("\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateBackupOffsitePolicyInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateBackupOffsitePolicyInfo input)
        {
            if (input == null) return false;
            if (this.OpenAutoBackup != input.OpenAutoBackup || (this.OpenAutoBackup != null && !this.OpenAutoBackup.Equals(input.OpenAutoBackup))) return false;
            if (this.OpenIncrementalBackup != input.OpenIncrementalBackup || (this.OpenIncrementalBackup != null && !this.OpenIncrementalBackup.Equals(input.OpenIncrementalBackup))) return false;
            if (this.DestinationProjectId != input.DestinationProjectId || (this.DestinationProjectId != null && !this.DestinationProjectId.Equals(input.DestinationProjectId))) return false;
            if (this.DestinationRegion != input.DestinationRegion || (this.DestinationRegion != null && !this.DestinationRegion.Equals(input.DestinationRegion))) return false;
            if (this.KeepDays != input.KeepDays || (this.KeepDays != null && !this.KeepDays.Equals(input.KeepDays))) return false;

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
                if (this.OpenAutoBackup != null) hashCode = hashCode * 59 + this.OpenAutoBackup.GetHashCode();
                if (this.OpenIncrementalBackup != null) hashCode = hashCode * 59 + this.OpenIncrementalBackup.GetHashCode();
                if (this.DestinationProjectId != null) hashCode = hashCode * 59 + this.DestinationProjectId.GetHashCode();
                if (this.DestinationRegion != null) hashCode = hashCode * 59 + this.DestinationRegion.GetHashCode();
                if (this.KeepDays != null) hashCode = hashCode * 59 + this.KeepDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
