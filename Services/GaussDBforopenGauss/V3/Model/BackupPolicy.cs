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
    public class BackupPolicy 
    {

        /// <summary>
        /// **参数解释**: 备份文件可以保存的天数。 **约束限制**: 不涉及。 **取值范围**: 1-36500天。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }

        /// <summary>
        /// **参数解释**: 备份时间段。自动备份将在该时间段内触发。 **约束限制**: 不涉及。 **取值范围**: 备份时间段。自动备份将在该时间段内触发。  取值范围：非空，格式必须为hh:mm-HH:MM且有效，当前时间指UTC时间。  HH取值必须比hh大1，mm和MM取值必须相同，且取值必须为00。  取值示例：  21:00-22:00 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**: 全量备份周期配置。自动全量备份将在每周对应的UTC日期进行。 **约束限制**: 不涉及。 **取值范围**: 格式为逗号隔开的数字，数字代表星期，取1~7。  取值示例： - 1,2,3,4 表示备份周期配置为星期一、星期二、星期三和星期四。 - 1,2,3,4,5,6,7 则表示星期一至星期日每天执行一次自动备份。 - 1,3,5表示周一、周三、周五执行一次自动备份。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// **参数解释**: 差异备份间隔时间配置。每次自动差异备份的间隔时间。 **约束限制**: 不涉及。 **取值范围**: 15、30、60、180、360、720、1440。单位：分钟。 取值示例：30 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("differential_period", NullValueHandling = NullValueHandling.Ignore)]
        public string DifferentialPeriod { get; set; }

        /// <summary>
        /// **参数解释**: 备份限速。控制备份时备份数据上传OBS的速度，限速用于限制上传备份对上传带宽的影响。单位为MB/s。 **约束限制**: 不涉及。 **取值范围**: 0~1024MB/s，0表示不限速。 **默认取值**: 75MB/s
        /// </summary>
        [JsonProperty("rate_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? RateLimit { get; set; }

        /// <summary>
        /// **参数解释**: 差量预取页面个数。控制差量备份时读取磁盘上表文件差量修改页面的预取页面个数。当差量修改页面非常集中时（如数据导入场景），可以适当调大该值；当差量修改页面非常分散时（如随机更新），可以适当调小该值。 **约束限制**: 不涉及。 **取值范围**: 1~8192 **默认取值**: 64
        /// </summary>
        [JsonProperty("prefetch_block", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrefetchBlock { get; set; }

        /// <summary>
        /// **参数解释**: 文件拆分大小。全量、差量备份时产生的备份文件会根据该参数的值进行拆分。 **约束限制**: 需为4的倍数。 **取值范围**: 可设置范围为0~1024GB。0GB表示不限制大小。 **默认取值**: 4GB
        /// </summary>
        [JsonProperty("file_split_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FileSplitSize { get; set; }

        /// <summary>
        /// **参数解释**: 文件拆分大小。全量、差量备份时产生的备份文件会根据该参数的值进行拆分。废弃，无需填写。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("filesplit_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FilesplitSize { get; set; }

        /// <summary>
        /// **参数解释**: 是否启用备机备份。 **约束限制**: 不支持单节点实例及V2.0-3.100.0以下的实例。 **取值范围**: - true：启用备机备份。 - false：不启用备机备份。  **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("enable_standby_backup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableStandbyBackup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupPolicy {\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  differentialPeriod: ").Append(DifferentialPeriod).Append("\n");
            sb.Append("  rateLimit: ").Append(RateLimit).Append("\n");
            sb.Append("  prefetchBlock: ").Append(PrefetchBlock).Append("\n");
            sb.Append("  fileSplitSize: ").Append(FileSplitSize).Append("\n");
            sb.Append("  filesplitSize: ").Append(FilesplitSize).Append("\n");
            sb.Append("  enableStandbyBackup: ").Append(EnableStandbyBackup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupPolicy input)
        {
            if (input == null) return false;
            if (this.KeepDays != input.KeepDays || (this.KeepDays != null && !this.KeepDays.Equals(input.KeepDays))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.DifferentialPeriod != input.DifferentialPeriod || (this.DifferentialPeriod != null && !this.DifferentialPeriod.Equals(input.DifferentialPeriod))) return false;
            if (this.RateLimit != input.RateLimit || (this.RateLimit != null && !this.RateLimit.Equals(input.RateLimit))) return false;
            if (this.PrefetchBlock != input.PrefetchBlock || (this.PrefetchBlock != null && !this.PrefetchBlock.Equals(input.PrefetchBlock))) return false;
            if (this.FileSplitSize != input.FileSplitSize || (this.FileSplitSize != null && !this.FileSplitSize.Equals(input.FileSplitSize))) return false;
            if (this.FilesplitSize != input.FilesplitSize || (this.FilesplitSize != null && !this.FilesplitSize.Equals(input.FilesplitSize))) return false;
            if (this.EnableStandbyBackup != input.EnableStandbyBackup || (this.EnableStandbyBackup != null && !this.EnableStandbyBackup.Equals(input.EnableStandbyBackup))) return false;

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
                if (this.DifferentialPeriod != null) hashCode = hashCode * 59 + this.DifferentialPeriod.GetHashCode();
                if (this.RateLimit != null) hashCode = hashCode * 59 + this.RateLimit.GetHashCode();
                if (this.PrefetchBlock != null) hashCode = hashCode * 59 + this.PrefetchBlock.GetHashCode();
                if (this.FileSplitSize != null) hashCode = hashCode * 59 + this.FileSplitSize.GetHashCode();
                if (this.FilesplitSize != null) hashCode = hashCode * 59 + this.FilesplitSize.GetHashCode();
                if (this.EnableStandbyBackup != null) hashCode = hashCode * 59 + this.EnableStandbyBackup.GetHashCode();
                return hashCode;
            }
        }
    }
}
