using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 可用域信息
    /// </summary>
    public class NovaAvailabilityZone 
    {

        /// <summary>
        /// 该字段的值为null。
        /// </summary>
        [JsonProperty("hosts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Hosts { get; set; }

        /// <summary>
        /// 可用域的名称。
        /// </summary>
        [JsonProperty("zoneName", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("zoneState", NullValueHandling = NullValueHandling.Ignore)]
        public NovaAvailabilityZoneState ZoneState { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaAvailabilityZone {\n");
            sb.Append("  hosts: ").Append(Hosts).Append("\n");
            sb.Append("  zoneName: ").Append(ZoneName).Append("\n");
            sb.Append("  zoneState: ").Append(ZoneState).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaAvailabilityZone);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaAvailabilityZone input)
        {
            if (input == null) return false;
            if (this.Hosts != input.Hosts || (this.Hosts != null && input.Hosts != null && !this.Hosts.SequenceEqual(input.Hosts))) return false;
            if (this.ZoneName != input.ZoneName || (this.ZoneName != null && !this.ZoneName.Equals(input.ZoneName))) return false;
            if (this.ZoneState != input.ZoneState || (this.ZoneState != null && !this.ZoneState.Equals(input.ZoneState))) return false;

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
                if (this.Hosts != null) hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                if (this.ZoneName != null) hashCode = hashCode * 59 + this.ZoneName.GetHashCode();
                if (this.ZoneState != null) hashCode = hashCode * 59 + this.ZoneState.GetHashCode();
                return hashCode;
            }
        }
    }
}
