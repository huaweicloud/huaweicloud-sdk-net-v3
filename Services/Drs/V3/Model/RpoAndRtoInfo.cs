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
    /// RpoAndRTO信息体
    /// </summary>
    public class RpoAndRtoInfo 
    {

        /// <summary>
        /// 检查点
        /// </summary>
        [JsonProperty("check_point", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckPoint { get; set; }

        /// <summary>
        /// 延迟
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public string Delay { get; set; }

        /// <summary>
        /// gtid集合
        /// </summary>
        [JsonProperty("gtid_set", NullValueHandling = NullValueHandling.Ignore)]
        public string GtidSet { get; set; }

        /// <summary>
        /// 当前时间 ，格式为“yyyy-MM-dd HH:mm:ss”
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RpoAndRtoInfo {\n");
            sb.Append("  checkPoint: ").Append(CheckPoint).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  gtidSet: ").Append(GtidSet).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RpoAndRtoInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RpoAndRtoInfo input)
        {
            if (input == null) return false;
            if (this.CheckPoint != input.CheckPoint || (this.CheckPoint != null && !this.CheckPoint.Equals(input.CheckPoint))) return false;
            if (this.Delay != input.Delay || (this.Delay != null && !this.Delay.Equals(input.Delay))) return false;
            if (this.GtidSet != input.GtidSet || (this.GtidSet != null && !this.GtidSet.Equals(input.GtidSet))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;

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
                if (this.CheckPoint != null) hashCode = hashCode * 59 + this.CheckPoint.GetHashCode();
                if (this.Delay != null) hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.GtidSet != null) hashCode = hashCode * 59 + this.GtidSet.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }
}
