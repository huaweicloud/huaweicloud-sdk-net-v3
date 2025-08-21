using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InternetReport 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("eip", NullValueHandling = NullValueHandling.Ignore)]
        public Eip Eip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("in2out", NullValueHandling = NullValueHandling.Ignore)]
        public In2Out In2out { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("out2in", NullValueHandling = NullValueHandling.Ignore)]
        public Out2in Out2in { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("overview", NullValueHandling = NullValueHandling.Ignore)]
        public Overview Overview { get; set; }

        /// <summary>
        /// **参数解释**： 流量趋势 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("traffic_trend", NullValueHandling = NullValueHandling.Ignore)]
        public List<TrendVO> TrafficTrend { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InternetReport {\n");
            sb.Append("  eip: ").Append(Eip).Append("\n");
            sb.Append("  in2out: ").Append(In2out).Append("\n");
            sb.Append("  out2in: ").Append(Out2in).Append("\n");
            sb.Append("  overview: ").Append(Overview).Append("\n");
            sb.Append("  trafficTrend: ").Append(TrafficTrend).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InternetReport);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InternetReport input)
        {
            if (input == null) return false;
            if (this.Eip != input.Eip || (this.Eip != null && !this.Eip.Equals(input.Eip))) return false;
            if (this.In2out != input.In2out || (this.In2out != null && !this.In2out.Equals(input.In2out))) return false;
            if (this.Out2in != input.Out2in || (this.Out2in != null && !this.Out2in.Equals(input.Out2in))) return false;
            if (this.Overview != input.Overview || (this.Overview != null && !this.Overview.Equals(input.Overview))) return false;
            if (this.TrafficTrend != input.TrafficTrend || (this.TrafficTrend != null && input.TrafficTrend != null && !this.TrafficTrend.SequenceEqual(input.TrafficTrend))) return false;

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
                if (this.Eip != null) hashCode = hashCode * 59 + this.Eip.GetHashCode();
                if (this.In2out != null) hashCode = hashCode * 59 + this.In2out.GetHashCode();
                if (this.Out2in != null) hashCode = hashCode * 59 + this.Out2in.GetHashCode();
                if (this.Overview != null) hashCode = hashCode * 59 + this.Overview.GetHashCode();
                if (this.TrafficTrend != null) hashCode = hashCode * 59 + this.TrafficTrend.GetHashCode();
                return hashCode;
            }
        }
    }
}
