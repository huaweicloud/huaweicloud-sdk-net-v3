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
    public class MysqlBackupPolicy 
    {

        /// <summary>
        /// 备份时间段。自动备份将在该时间段内触发。  取值范围：非空，格式必须为hh:mm-HH:MM且有效，当前时间指UTC时间。HH取值必须比hh大1。mm和MM取值必须相同，且取值必须为00。  取值示例：21:00-22:00
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 备份文件的保留天数。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }

        /// <summary>
        /// 备份周期配置。自动备份将在每星期指定的天进行。  取值范围：格式为逗号隔开的数字，数字代表星期。  取值示例：1,2,3,4则表示备份周期配置为星期一、星期二、星期三和星期四。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 一级备份保留数量，默认值为0。当一级备份开关开启时，该参数值有效。取值：0或1
        /// </summary>
        [JsonProperty("retention_num_backup_level1", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionNumBackupLevel1 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlBackupPolicy {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  retentionNumBackupLevel1: ").Append(RetentionNumBackupLevel1).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlBackupPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlBackupPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.KeepDays == input.KeepDays ||
                    (this.KeepDays != null &&
                    this.KeepDays.Equals(input.KeepDays))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.RetentionNumBackupLevel1 == input.RetentionNumBackupLevel1 ||
                    (this.RetentionNumBackupLevel1 != null &&
                    this.RetentionNumBackupLevel1.Equals(input.RetentionNumBackupLevel1))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.KeepDays != null)
                    hashCode = hashCode * 59 + this.KeepDays.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.RetentionNumBackupLevel1 != null)
                    hashCode = hashCode * 59 + this.RetentionNumBackupLevel1.GetHashCode();
                return hashCode;
            }
        }
    }
}
