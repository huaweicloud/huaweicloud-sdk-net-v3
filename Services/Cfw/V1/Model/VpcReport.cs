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
    public class VpcReport 
    {

        /// <summary>
        /// **参数解释**： TOP应用数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> App { get; set; }

        /// <summary>
        /// **参数解释**： TOP访问目的IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> DstIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("overview", NullValueHandling = NullValueHandling.Ignore)]
        public Overview Overview { get; set; }

        /// <summary>
        /// **参数解释**： TOP访问源IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> SrcIp { get; set; }

        /// <summary>
        /// **参数解释**： 流量趋势 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("traffic_trend", NullValueHandling = NullValueHandling.Ignore)]
        public List<TrendVO> TrafficTrend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vpc", NullValueHandling = NullValueHandling.Ignore)]
        public Vpc Vpc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpcReport {\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  dstIp: ").Append(DstIp).Append("\n");
            sb.Append("  overview: ").Append(Overview).Append("\n");
            sb.Append("  srcIp: ").Append(SrcIp).Append("\n");
            sb.Append("  trafficTrend: ").Append(TrafficTrend).Append("\n");
            sb.Append("  vpc: ").Append(Vpc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VpcReport);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VpcReport input)
        {
            if (input == null) return false;
            if (this.App != input.App || (this.App != null && input.App != null && !this.App.SequenceEqual(input.App))) return false;
            if (this.DstIp != input.DstIp || (this.DstIp != null && input.DstIp != null && !this.DstIp.SequenceEqual(input.DstIp))) return false;
            if (this.Overview != input.Overview || (this.Overview != null && !this.Overview.Equals(input.Overview))) return false;
            if (this.SrcIp != input.SrcIp || (this.SrcIp != null && input.SrcIp != null && !this.SrcIp.SequenceEqual(input.SrcIp))) return false;
            if (this.TrafficTrend != input.TrafficTrend || (this.TrafficTrend != null && input.TrafficTrend != null && !this.TrafficTrend.SequenceEqual(input.TrafficTrend))) return false;
            if (this.Vpc != input.Vpc || (this.Vpc != null && !this.Vpc.Equals(input.Vpc))) return false;

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
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.DstIp != null) hashCode = hashCode * 59 + this.DstIp.GetHashCode();
                if (this.Overview != null) hashCode = hashCode * 59 + this.Overview.GetHashCode();
                if (this.SrcIp != null) hashCode = hashCode * 59 + this.SrcIp.GetHashCode();
                if (this.TrafficTrend != null) hashCode = hashCode * 59 + this.TrafficTrend.GetHashCode();
                if (this.Vpc != null) hashCode = hashCode * 59 + this.Vpc.GetHashCode();
                return hashCode;
            }
        }
    }
}
