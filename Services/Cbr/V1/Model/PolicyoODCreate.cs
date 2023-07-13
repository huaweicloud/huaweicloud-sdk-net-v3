using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PolicyoODCreate 
    {

        /// <summary>
        /// 保留日备个数，该备份不受保留最大备份数限制。取值为0到100。若选择该参数，则timezone 也必选。
        /// </summary>
        [JsonProperty("day_backups", NullValueHandling = NullValueHandling.Ignore)]
        public int? DayBackups { get; set; }

        /// <summary>
        /// 复制的目标项目ID，仅在跨区域复制时才会使用并且必须指定。
        /// </summary>
        [JsonProperty("destination_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationProjectId { get; set; }

        /// <summary>
        /// 复制的目标区域，仅在跨区域复制时才会使用并且必须指定。长度限制：0- 255，只能由字母、数字、“_”、“-”组成
        /// </summary>
        [JsonProperty("destination_region", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// 跨区域复制时，是否启用加速从而缩减复制的时间，如果不指定，默认不启用加速。
        /// </summary>
        [JsonProperty("enable_acceleration", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAcceleration { get; set; }

        /// <summary>
        /// 单个备份对象自动备份的最大备份数。取值为-1或0-99999。-1代表不按备份数清理。若该字段和retention_duration_days字段同时为空，备份会永久保留。
        /// </summary>
        [JsonProperty("max_backups", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxBackups { get; set; }

        /// <summary>
        /// 保留月备个数，该备份不受保留最大备份数限制。取值为0到100。若选择该参数，则timezone 也必选。
        /// </summary>
        [JsonProperty("month_backups", NullValueHandling = NullValueHandling.Ignore)]
        public int? MonthBackups { get; set; }

        /// <summary>
        /// 备份保留时长，单位天。最长支持99999天。-1代表不按时间清理。若该字段和max_backups 参数同时为空，备份会永久保留。
        /// </summary>
        [JsonProperty("retention_duration_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDurationDays { get; set; }

        /// <summary>
        /// 用户所在时区,格式形如UTC+08:00, 若选择年备，月备，周备，日备中任一参数，则该参数不能为空。
        /// </summary>
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        /// <summary>
        /// 保留周备个数，该备份不受保留最大备份数限制。取值为0到100。若选择该参数，则timezone 也必选。
        /// </summary>
        [JsonProperty("week_backups", NullValueHandling = NullValueHandling.Ignore)]
        public int? WeekBackups { get; set; }

        /// <summary>
        /// 保留年备个数，该备份不受保留最大备份数限制。取值为0到100。若选择该参数，则timezone 也必选。
        /// </summary>
        [JsonProperty("year_backups", NullValueHandling = NullValueHandling.Ignore)]
        public int? YearBackups { get; set; }

        /// <summary>
        /// 每间隔多少次执行一次全量备份，当取值为 -1 时，不执行全量备份。  最小值：-1  最大值：100
        /// </summary>
        [JsonProperty("full_backup_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? FullBackupInterval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyoODCreate {\n");
            sb.Append("  dayBackups: ").Append(DayBackups).Append("\n");
            sb.Append("  destinationProjectId: ").Append(DestinationProjectId).Append("\n");
            sb.Append("  destinationRegion: ").Append(DestinationRegion).Append("\n");
            sb.Append("  enableAcceleration: ").Append(EnableAcceleration).Append("\n");
            sb.Append("  maxBackups: ").Append(MaxBackups).Append("\n");
            sb.Append("  monthBackups: ").Append(MonthBackups).Append("\n");
            sb.Append("  retentionDurationDays: ").Append(RetentionDurationDays).Append("\n");
            sb.Append("  timezone: ").Append(Timezone).Append("\n");
            sb.Append("  weekBackups: ").Append(WeekBackups).Append("\n");
            sb.Append("  yearBackups: ").Append(YearBackups).Append("\n");
            sb.Append("  fullBackupInterval: ").Append(FullBackupInterval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyoODCreate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyoODCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DayBackups == input.DayBackups ||
                    (this.DayBackups != null &&
                    this.DayBackups.Equals(input.DayBackups))
                ) && 
                (
                    this.DestinationProjectId == input.DestinationProjectId ||
                    (this.DestinationProjectId != null &&
                    this.DestinationProjectId.Equals(input.DestinationProjectId))
                ) && 
                (
                    this.DestinationRegion == input.DestinationRegion ||
                    (this.DestinationRegion != null &&
                    this.DestinationRegion.Equals(input.DestinationRegion))
                ) && 
                (
                    this.EnableAcceleration == input.EnableAcceleration ||
                    (this.EnableAcceleration != null &&
                    this.EnableAcceleration.Equals(input.EnableAcceleration))
                ) && 
                (
                    this.MaxBackups == input.MaxBackups ||
                    (this.MaxBackups != null &&
                    this.MaxBackups.Equals(input.MaxBackups))
                ) && 
                (
                    this.MonthBackups == input.MonthBackups ||
                    (this.MonthBackups != null &&
                    this.MonthBackups.Equals(input.MonthBackups))
                ) && 
                (
                    this.RetentionDurationDays == input.RetentionDurationDays ||
                    (this.RetentionDurationDays != null &&
                    this.RetentionDurationDays.Equals(input.RetentionDurationDays))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.WeekBackups == input.WeekBackups ||
                    (this.WeekBackups != null &&
                    this.WeekBackups.Equals(input.WeekBackups))
                ) && 
                (
                    this.YearBackups == input.YearBackups ||
                    (this.YearBackups != null &&
                    this.YearBackups.Equals(input.YearBackups))
                ) && 
                (
                    this.FullBackupInterval == input.FullBackupInterval ||
                    (this.FullBackupInterval != null &&
                    this.FullBackupInterval.Equals(input.FullBackupInterval))
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
                if (this.DayBackups != null)
                    hashCode = hashCode * 59 + this.DayBackups.GetHashCode();
                if (this.DestinationProjectId != null)
                    hashCode = hashCode * 59 + this.DestinationProjectId.GetHashCode();
                if (this.DestinationRegion != null)
                    hashCode = hashCode * 59 + this.DestinationRegion.GetHashCode();
                if (this.EnableAcceleration != null)
                    hashCode = hashCode * 59 + this.EnableAcceleration.GetHashCode();
                if (this.MaxBackups != null)
                    hashCode = hashCode * 59 + this.MaxBackups.GetHashCode();
                if (this.MonthBackups != null)
                    hashCode = hashCode * 59 + this.MonthBackups.GetHashCode();
                if (this.RetentionDurationDays != null)
                    hashCode = hashCode * 59 + this.RetentionDurationDays.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.WeekBackups != null)
                    hashCode = hashCode * 59 + this.WeekBackups.GetHashCode();
                if (this.YearBackups != null)
                    hashCode = hashCode * 59 + this.YearBackups.GetHashCode();
                if (this.FullBackupInterval != null)
                    hashCode = hashCode * 59 + this.FullBackupInterval.GetHashCode();
                return hashCode;
            }
        }
    }
}
