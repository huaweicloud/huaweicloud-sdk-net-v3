using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// 创建中转IP的请求体。
    /// </summary>
    public class CreateTransitIpRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transit_ip", NullValueHandling = NullValueHandling.Ignore)]
        public CreatTransitIpOption TransitIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTransitIpRequestBody {\n");
            sb.Append("  transitIp: ").Append(TransitIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTransitIpRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTransitIpRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransitIp == input.TransitIp ||
                    (this.TransitIp != null &&
                    this.TransitIp.Equals(input.TransitIp))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TransitIp != null)
                    hashCode = hashCode * 59 + this.TransitIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
