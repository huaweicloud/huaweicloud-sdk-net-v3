using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SetRedisPitrPolicyRequestBody 
    {

        /// <summary>
        /// 标识Redis实例是否开启指定时间点恢复。 “true”，表示实例开启Redis指定时间点恢复功能。 “false”，表示实例不启用Redis指定时间点恢复功能。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 数据备份的时间间隔，该数据备份控制redis实例可恢复时间点的间隔，默认值为 20分钟。 取值范围：5～120  单位：分钟  例如，当interval 为20min时，可恢复时间点的间隔为20min，其interval约小，对性能影响越大，存储空间膨胀约明显。
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// 指定已生成的备份文件可以保存的天数，默认值为 1 天。 取值范围：1～7  单位：天
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetRedisPitrPolicyRequestBody {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetRedisPitrPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetRedisPitrPolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.Interval != input.Interval || (this.Interval != null && !this.Interval.Equals(input.Interval))) return false;
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
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Interval != null) hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.KeepDays != null) hashCode = hashCode * 59 + this.KeepDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
