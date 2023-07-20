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
    /// 备份策略信息。
    /// </summary>
    public class BackupPolicy 
    {

        /// <summary>
        /// 指定已生成的备份文件可以保存的天数。  取值范围：0～732。取0值，表示关闭自动备份策略。如果需要延长保留时间请联系客服人员申请，自动备份最长可以保留2562天。  注意： 关闭备份策略后，备份任务将立即停止，所有增量备份任务将立即删除，使用增量备份的相关操作可能失败，相关操作不限于下载、复制、恢复、重建等，请谨慎操作。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }

        /// <summary>
        /// 备份时间段。自动备份将在该时间段内触发。除关闭自动备份策略外，必选。  取值范围：格式必须为hh:mm-HH:MM且有效，当前时间指UTC时间。  - HH取值必须比hh大1。 - mm和MM取值必须相同，且取值必须为00、15、30或45。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 备份周期配置。自动备份将在每星期指定的天进行。除关闭自动备份策略外，必选。  取值范围：格式为逗号隔开的数字，数字代表星期。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }



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
                return hashCode;
            }
        }
    }
}
