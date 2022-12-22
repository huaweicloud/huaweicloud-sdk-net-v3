using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateBandwidthRequest 
    {

        /// <summary>
        /// 带宽唯一标识
        /// </summary>
        [SDKProperty("bandwidth_id", IsPath = true)]
        [JsonProperty("bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateBandwidthRequestBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBandwidthRequest {\n");
            sb.Append("  bandwidthId: ").Append(BandwidthId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateBandwidthRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateBandwidthRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BandwidthId == input.BandwidthId ||
                    (this.BandwidthId != null &&
                    this.BandwidthId.Equals(input.BandwidthId))
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
                if (this.BandwidthId != null)
                    hashCode = hashCode * 59 + this.BandwidthId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
