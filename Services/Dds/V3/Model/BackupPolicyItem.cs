using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 备份策略对象，包括备份保留的天数和备份开始时间。
    /// </summary>
    public class BackupPolicyItem 
    {

        /// <summary>
        /// 备份文件可以保存的天数。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }

        /// <summary>
        /// 备份时间段。自动备份将在该时间段内触发。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 备份周期配置。自动备份将在每星期指定的天进行。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 是否开启增量备份。true：表示增量备份策略为开启状态；false：表示增量备份策略为关闭状态。
        /// </summary>
        [JsonProperty("enable_incremental_backup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableIncrementalBackup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupPolicyItem {\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  enableIncrementalBackup: ").Append(EnableIncrementalBackup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupPolicyItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupPolicyItem input)
        {
            if (input == null) return false;
            if (this.KeepDays != input.KeepDays || (this.KeepDays != null && !this.KeepDays.Equals(input.KeepDays))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.EnableIncrementalBackup != input.EnableIncrementalBackup || (this.EnableIncrementalBackup != null && !this.EnableIncrementalBackup.Equals(input.EnableIncrementalBackup))) return false;

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
                if (this.KeepDays != null) hashCode = hashCode * 59 + this.KeepDays.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.EnableIncrementalBackup != null) hashCode = hashCode * 59 + this.EnableIncrementalBackup.GetHashCode();
                return hashCode;
            }
        }
    }
}
