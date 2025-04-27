using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PublicIpRes 
    {

        /// <summary>
        /// 弹性公网IP（EIP）所属的区域。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 弹性公网IP（EIP）的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 弹性公网IP（EIP）。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicIpRes {\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicIpRes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicIpRes input)
        {
            if (input == null) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;

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
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                return hashCode;
            }
        }
    }
}
