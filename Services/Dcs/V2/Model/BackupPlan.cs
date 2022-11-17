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
    public class BackupPlan 
    {

        /// <summary>
        /// 备份的时区。取值为-1200 ~+1200之间的时区。若为空则默认使用DCS-Server节点的当前时区。
        /// </summary>
        [JsonProperty("timezone_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string TimezoneOffset { get; set; }

        /// <summary>
        /// 每周的周几开始备份，取值1-7，1代表周一，7代表周日。
        /// </summary>
        [JsonProperty("backup_at", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> BackupAt { get; set; }

        /// <summary>
        /// 备份周期类型，目前支持“weekly”。
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodType { get; set; }

        /// <summary>
        /// 备份执行时间，“00:00-01:00”代表0点开始执行备份。
        /// </summary>
        [JsonProperty("begin_at", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginAt { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupPlan {\n");
            sb.Append("  timezoneOffset: ").Append(TimezoneOffset).Append("\n");
            sb.Append("  backupAt: ").Append(BackupAt).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  beginAt: ").Append(BeginAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupPlan);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupPlan input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimezoneOffset == input.TimezoneOffset ||
                    (this.TimezoneOffset != null &&
                    this.TimezoneOffset.Equals(input.TimezoneOffset))
                ) && 
                (
                    this.BackupAt == input.BackupAt ||
                    this.BackupAt != null &&
                    input.BackupAt != null &&
                    this.BackupAt.SequenceEqual(input.BackupAt)
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) && 
                (
                    this.BeginAt == input.BeginAt ||
                    (this.BeginAt != null &&
                    this.BeginAt.Equals(input.BeginAt))
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
                if (this.TimezoneOffset != null)
                    hashCode = hashCode * 59 + this.TimezoneOffset.GetHashCode();
                if (this.BackupAt != null)
                    hashCode = hashCode * 59 + this.BackupAt.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.BeginAt != null)
                    hashCode = hashCode * 59 + this.BeginAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
