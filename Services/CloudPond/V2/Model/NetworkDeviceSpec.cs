using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// 网络设备规格
    /// </summary>
    public class NetworkDeviceSpec 
    {

        /// <summary>
        /// 网络设备规格ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 网络设备规格名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 设备功率。单位：w
        /// </summary>
        [JsonProperty("power", NullValueHandling = NullValueHandling.Ignore)]
        public int? Power { get; set; }

        /// <summary>
        /// 设备高度。U位数。
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Unit { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        [JsonProperty("performance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PerformanceType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkDeviceSpec {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  power: ").Append(Power).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  performanceType: ").Append(PerformanceType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkDeviceSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkDeviceSpec input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Power != input.Power || (this.Power != null && !this.Power.Equals(input.Power))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;
            if (this.PerformanceType != input.PerformanceType || (this.PerformanceType != null && !this.PerformanceType.Equals(input.PerformanceType))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Power != null) hashCode = hashCode * 59 + this.Power.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.PerformanceType != null) hashCode = hashCode * 59 + this.PerformanceType.GetHashCode();
                return hashCode;
            }
        }
    }
}
