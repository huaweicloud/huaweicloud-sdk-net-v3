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
    /// 
    /// </summary>
    public class SparseBackupPolicy 
    {

        /// <summary>
        /// 参数解释：  备份策略ID。  取值范围：  不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 参数解释：  备份周期配置。  取值范围：  格式为“日期 月份 星期”形式的Cron表达式，时区为UTC时区。 日期支持范围为1~31、特殊字符*（表示任意值）、特殊字符L（表示最后一天）。填写1~31或L时支持填写多个，以逗号隔开。 月份支持范围为1~12、特殊字符*（表示任意值）。 星期支持范围为1~7（1表示星期一，2表示星期二，依次类推）、特殊字符*（表示任意值）。填写1~7数字时支持填写多个，以逗号隔开。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 参数解释：  备份文件可以保存的天数。  取值范围：  1~3660。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }

        /// <summary>
        /// 参数解释：  全量备份时间段。自动备份将在该时间段内触发。  取值范围：  格式为hh:mm-HH:MM，为UTC时间。 HH的值比hh大1。 mm和MM的值相同，且取值必须为00。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SparseBackupPolicy {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SparseBackupPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SparseBackupPolicy input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.KeepDays != input.KeepDays || (this.KeepDays != null && !this.KeepDays.Equals(input.KeepDays))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.KeepDays != null) hashCode = hashCode * 59 + this.KeepDays.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
