using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 共享Vpc专线入参。
    /// </summary>
    public class ApplySharedVpcDedicatedParam 
    {

        /// <summary>
        /// 租户指定的共享Vpc专线地址。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 租户指定共享Vpc专线地址端口。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 开通服务资源使用的可用分区，默认随机使用2个可用区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplySharedVpcDedicatedParam {\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplySharedVpcDedicatedParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplySharedVpcDedicatedParam input)
        {
            if (input == null) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && input.AvailabilityZone != null && !this.AvailabilityZone.SequenceEqual(input.AvailabilityZone))) return false;

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
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
