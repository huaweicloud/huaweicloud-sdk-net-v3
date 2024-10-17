using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 扩展伸缩组配置，承载区别于默认伸缩组的差异化配置
    /// </summary>
    public class ExtensionScaleGroupSpec 
    {

        /// <summary>
        /// 节点规格
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// 节点可用区，未指定或者为空则以默认伸缩组中配置为准
        /// </summary>
        [JsonProperty("az", NullValueHandling = NullValueHandling.Ignore)]
        public string Az { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("capacityReservationSpecification", NullValueHandling = NullValueHandling.Ignore)]
        public CapacityReservationSpecification CapacityReservationSpecification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("autoscaling", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleGroupAutoscaling Autoscaling { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionScaleGroupSpec {\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  az: ").Append(Az).Append("\n");
            sb.Append("  capacityReservationSpecification: ").Append(CapacityReservationSpecification).Append("\n");
            sb.Append("  autoscaling: ").Append(Autoscaling).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtensionScaleGroupSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtensionScaleGroupSpec input)
        {
            if (input == null) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.Az != input.Az || (this.Az != null && !this.Az.Equals(input.Az))) return false;
            if (this.CapacityReservationSpecification != input.CapacityReservationSpecification || (this.CapacityReservationSpecification != null && !this.CapacityReservationSpecification.Equals(input.CapacityReservationSpecification))) return false;
            if (this.Autoscaling != input.Autoscaling || (this.Autoscaling != null && !this.Autoscaling.Equals(input.Autoscaling))) return false;

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
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Az != null) hashCode = hashCode * 59 + this.Az.GetHashCode();
                if (this.CapacityReservationSpecification != null) hashCode = hashCode * 59 + this.CapacityReservationSpecification.GetHashCode();
                if (this.Autoscaling != null) hashCode = hashCode * 59 + this.Autoscaling.GetHashCode();
                return hashCode;
            }
        }
    }
}
