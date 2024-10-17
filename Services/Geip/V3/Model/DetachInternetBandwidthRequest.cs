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
    public class DetachInternetBandwidthRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("global_eip_id", IsPath = true)]
        [JsonProperty("global_eip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalEipId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("force_unbind", IsQuery = true)]
        [JsonProperty("force_unbind", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceUnbind { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetachInternetBandwidthRequest {\n");
            sb.Append("  globalEipId: ").Append(GlobalEipId).Append("\n");
            sb.Append("  forceUnbind: ").Append(ForceUnbind).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetachInternetBandwidthRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetachInternetBandwidthRequest input)
        {
            if (input == null) return false;
            if (this.GlobalEipId != input.GlobalEipId || (this.GlobalEipId != null && !this.GlobalEipId.Equals(input.GlobalEipId))) return false;
            if (this.ForceUnbind != input.ForceUnbind || (this.ForceUnbind != null && !this.ForceUnbind.Equals(input.ForceUnbind))) return false;

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
                if (this.GlobalEipId != null) hashCode = hashCode * 59 + this.GlobalEipId.GetHashCode();
                if (this.ForceUnbind != null) hashCode = hashCode * 59 + this.ForceUnbind.GetHashCode();
                return hashCode;
            }
        }
    }
}
