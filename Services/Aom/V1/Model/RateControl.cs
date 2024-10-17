using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RateControl 
    {

        /// <summary>
        /// 是否分批发布，默认值是false。
        /// </summary>
        [JsonProperty("have_rate_control", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaveRateControl { get; set; }

        /// <summary>
        /// 每批间隔。
        /// </summary>
        [JsonProperty("time_delay", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeDelay { get; set; }

        /// <summary>
        /// 每批支持的最大实例数。
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public int? Max { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RateControl {\n");
            sb.Append("  haveRateControl: ").Append(HaveRateControl).Append("\n");
            sb.Append("  timeDelay: ").Append(TimeDelay).Append("\n");
            sb.Append("  max: ").Append(Max).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RateControl);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RateControl input)
        {
            if (input == null) return false;
            if (this.HaveRateControl != input.HaveRateControl || (this.HaveRateControl != null && !this.HaveRateControl.Equals(input.HaveRateControl))) return false;
            if (this.TimeDelay != input.TimeDelay || (this.TimeDelay != null && !this.TimeDelay.Equals(input.TimeDelay))) return false;
            if (this.Max != input.Max || (this.Max != null && !this.Max.Equals(input.Max))) return false;

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
                if (this.HaveRateControl != null) hashCode = hashCode * 59 + this.HaveRateControl.GetHashCode();
                if (this.TimeDelay != null) hashCode = hashCode * 59 + this.TimeDelay.GetHashCode();
                if (this.Max != null) hashCode = hashCode * 59 + this.Max.GetHashCode();
                return hashCode;
            }
        }
    }
}
