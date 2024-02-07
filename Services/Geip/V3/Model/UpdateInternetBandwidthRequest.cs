using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateInternetBandwidthRequest 
    {

        /// <summary>
        /// 全域公网带宽的ID
        /// </summary>
        [SDKProperty("internet_bandwidth_id", IsPath = true)]
        [JsonProperty("internet_bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InternetBandwidthId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateInternetBandwidthRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInternetBandwidthRequest {\n");
            sb.Append("  internetBandwidthId: ").Append(InternetBandwidthId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInternetBandwidthRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInternetBandwidthRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InternetBandwidthId == input.InternetBandwidthId ||
                    (this.InternetBandwidthId != null &&
                    this.InternetBandwidthId.Equals(input.InternetBandwidthId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.InternetBandwidthId != null)
                    hashCode = hashCode * 59 + this.InternetBandwidthId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
