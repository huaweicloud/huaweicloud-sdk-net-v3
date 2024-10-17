using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 限速信息体。 - 限速：自定义的最大迁移速度，迁移过程中的迁移速度将不会超过该速度。 - 不限速：对迁移速度不进行限制，通常会最大化使用源数据库的出口带宽。该流速模式同时会对源数据库造成读消耗，消耗取决于源数据库的出口带宽。比如：源数据库的出口带宽为100MB/s，假设高速模式使用了80%带宽，则迁移对源数据库将造成80MB/s的读操作IO消耗。
    /// </summary>
    public class SpeedLimitInfo 
    {

        /// <summary>
        /// 开始限速时间，此时间为UTC时间，开始时间为整时，若有分钟，则会忽略，格式为hh:mm，小时数为两位，例如：01:00。
        /// </summary>
        [JsonProperty("begin", NullValueHandling = NullValueHandling.Ignore)]
        public string Begin { get; set; }

        /// <summary>
        /// 结束时间，此时间为UTC时间，输入必须为59分结尾，格式为hh:mm，例如：15:59。
        /// </summary>
        [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
        public string End { get; set; }

        /// <summary>
        /// 限速值，取值范围为1~9999，单位为MB/s。
        /// </summary>
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public string Speed { get; set; }



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
                return hashCode;
            }
        }
    }
}
