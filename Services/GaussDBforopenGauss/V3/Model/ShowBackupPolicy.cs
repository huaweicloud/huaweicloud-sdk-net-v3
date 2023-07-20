using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 备份策略信息。
    /// </summary>
    public class ShowBackupPolicy 
    {

        /// <summary>
        /// 全量备份文件可以保存的天数。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }

        /// <summary>
        /// 全量备份时间段。自动备份将在该时间段内触发。除关闭自动备份策略外，必选。  取值范围：格式必须为hh:mm-HH:MM且有效，当前时间指UTC时间。  - HH取值必须比hh大1。 - mm和MM取值必须相同，且取值必须为00。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 全量备份周期配置。自动备份将在每星期指定的天进行。  取值范围：格式为逗号隔开的数字，数字代表星期。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 差量备份周期配置。自动差量备份将每隔周期分钟执行(废弃)。
        /// </summary>
        [JsonProperty("differential_priod", NullValueHandling = NullValueHandling.Ignore)]
        public string DifferentialPriod { get; set; }

        /// <summary>
        /// 差量备份周期配置。自动差量备份将每隔周期分钟执行。
        /// </summary>
        [JsonProperty("differential_period", NullValueHandling = NullValueHandling.Ignore)]
        public string DifferentialPeriod { get; set; }

        /// <summary>
        /// 备份时备份数据上传OBS的速度，单位为MB/s。范围为0~1024MB/s，默认75MB/s，0MB/s表示不限速。
        /// </summary>
        [JsonProperty("rate_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? RateLimit { get; set; }

        /// <summary>
        /// 控制差量备份时读取磁盘上表文件差量修改页面的预取页面个数，可设置范围为1~8192，默认64。
        /// </summary>
        [JsonProperty("prefetch_block", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrefetchBlock { get; set; }

        /// <summary>
        /// 废弃。
        /// </summary>
        [JsonProperty("filesplit_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FilesplitSize { get; set; }

        /// <summary>
        /// 全量、差量备份时产生的备份文件会根据分片大小进行拆分，可设置范围为0~1024GB，设置需为4的倍数，默认4GB，0GB表示不限制大小。  取值范围：0 ~ 1024
        /// </summary>
        [JsonProperty("file_split_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FileSplitSize { get; set; }

        /// <summary>
        /// 是否启用备机备份。  取值范围：true|false
        /// </summary>
        [JsonProperty("enable_standby_backup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableStandbyBackup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBackupPolicy {\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  differentialPriod: ").Append(DifferentialPriod).Append("\n");
            sb.Append("  differentialPeriod: ").Append(DifferentialPeriod).Append("\n");
            sb.Append("  rateLimit: ").Append(RateLimit).Append("\n");
            sb.Append("  prefetchBlock: ").Append(PrefetchBlock).Append("\n");
            sb.Append("  filesplitSize: ").Append(FilesplitSize).Append("\n");
            sb.Append("  fileSplitSize: ").Append(FileSplitSize).Append("\n");
            sb.Append("  enableStandbyBackup: ").Append(EnableStandbyBackup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBackupPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBackupPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeepDays == input.KeepDays ||
                    (this.KeepDays != null &&
                    this.KeepDays.Equals(input.KeepDays))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.DifferentialPriod == input.DifferentialPriod ||
                    (this.DifferentialPriod != null &&
                    this.DifferentialPriod.Equals(input.DifferentialPriod))
                ) && 
                (
                    this.DifferentialPeriod == input.DifferentialPeriod ||
                    (this.DifferentialPeriod != null &&
                    this.DifferentialPeriod.Equals(input.DifferentialPeriod))
                ) && 
                (
                    this.RateLimit == input.RateLimit ||
                    (this.RateLimit != null &&
                    this.RateLimit.Equals(input.RateLimit))
                ) && 
                (
                    this.PrefetchBlock == input.PrefetchBlock ||
                    (this.PrefetchBlock != null &&
                    this.PrefetchBlock.Equals(input.PrefetchBlock))
                ) && 
                (
                    this.FilesplitSize == input.FilesplitSize ||
                    (this.FilesplitSize != null &&
                    this.FilesplitSize.Equals(input.FilesplitSize))
                ) && 
                (
                    this.FileSplitSize == input.FileSplitSize ||
                    (this.FileSplitSize != null &&
                    this.FileSplitSize.Equals(input.FileSplitSize))
                ) && 
                (
                    this.EnableStandbyBackup == input.EnableStandbyBackup ||
                    (this.EnableStandbyBackup != null &&
                    this.EnableStandbyBackup.Equals(input.EnableStandbyBackup))
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
                if (this.KeepDays != null)
                    hashCode = hashCode * 59 + this.KeepDays.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.DifferentialPriod != null)
                    hashCode = hashCode * 59 + this.DifferentialPriod.GetHashCode();
                if (this.DifferentialPeriod != null)
                    hashCode = hashCode * 59 + this.DifferentialPeriod.GetHashCode();
                if (this.RateLimit != null)
                    hashCode = hashCode * 59 + this.RateLimit.GetHashCode();
                if (this.PrefetchBlock != null)
                    hashCode = hashCode * 59 + this.PrefetchBlock.GetHashCode();
                if (this.FilesplitSize != null)
                    hashCode = hashCode * 59 + this.FilesplitSize.GetHashCode();
                if (this.FileSplitSize != null)
                    hashCode = hashCode * 59 + this.FileSplitSize.GetHashCode();
                if (this.EnableStandbyBackup != null)
                    hashCode = hashCode * 59 + this.EnableStandbyBackup.GetHashCode();
                return hashCode;
            }
        }
    }
}
