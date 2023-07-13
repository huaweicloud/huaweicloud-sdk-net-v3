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
    /// Response Object
    /// </summary>
    public class ShowTransitIpResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transit_ip", NullValueHandling = NullValueHandling.Ignore)]
        public TransitIp TransitIp { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTransitIpResponse {\n");
            sb.Append("  transitIp: ").Append(TransitIp).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTransitIpResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTransitIpResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransitIp == input.TransitIp ||
                    (this.TransitIp != null &&
                    this.TransitIp.Equals(input.TransitIp))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
