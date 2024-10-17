using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 限制迁移速度请求体
    /// </summary>
    public class SpeedLimitInfo 
    {

        /// <summary>
        /// 开始限速时间, 此时间为UTC时间，开始时间为整时，若有分钟，则会忽略，格式为hh:mm，小时数为两位，例如：01:00。
        /// </summary>
        [JsonProperty("begin", NullValueHandling = NullValueHandling.Ignore)]
        public string Begin { get; set; }

        /// <summary>
        /// 结束时间,此时间为UTC时间,输入必须为59分结尾，格式为hh:mm，小时数为两位，例如：05:59。
        /// </summary>
        [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
        public string End { get; set; }

        /// <summary>
        /// 限速，取值范围为1~9999 ,单位为MB/s
        /// </summary>
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public string Speed { get; set; }

        /// <summary>
        /// 是否为UTC时间
        /// </summary>
        [JsonProperty("is_utc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUtc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpeedLimitInfo {\n");
            sb.Append("  begin: ").Append(Begin).Append("\n");
            sb.Append("  end: ").Append(End).Append("\n");
            sb.Append("  speed: ").Append(Speed).Append("\n");
            sb.Append("  isUtc: ").Append(IsUtc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SpeedLimitInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SpeedLimitInfo input)
        {
            if (input == null) return false;
            if (this.Begin != input.Begin || (this.Begin != null && !this.Begin.Equals(input.Begin))) return false;
            if (this.End != input.End || (this.End != null && !this.End.Equals(input.End))) return false;
            if (this.Speed != input.Speed || (this.Speed != null && !this.Speed.Equals(input.Speed))) return false;
            if (this.IsUtc != input.IsUtc || (this.IsUtc != null && !this.IsUtc.Equals(input.IsUtc))) return false;

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
                if (this.Begin != null) hashCode = hashCode * 59 + this.Begin.GetHashCode();
                if (this.End != null) hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.Speed != null) hashCode = hashCode * 59 + this.Speed.GetHashCode();
                if (this.IsUtc != null) hashCode = hashCode * 59 + this.IsUtc.GetHashCode();
                return hashCode;
            }
        }
    }
}
