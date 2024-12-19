using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// tracker通道配置
    /// </summary>
    public class ChannelConfigBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("smn", NullValueHandling = NullValueHandling.Ignore)]
        public TrackerSMNChannelConfigBody Smn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs", NullValueHandling = NullValueHandling.Ignore)]
        public TrackerOBSChannelConfigBody Obs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelConfigBody {\n");
            sb.Append("  smn: ").Append(Smn).Append("\n");
            sb.Append("  obs: ").Append(Obs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChannelConfigBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChannelConfigBody input)
        {
            if (input == null) return false;
            if (this.Smn != input.Smn || (this.Smn != null && !this.Smn.Equals(input.Smn))) return false;
            if (this.Obs != input.Obs || (this.Obs != null && !this.Obs.Equals(input.Obs))) return false;

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
                if (this.Smn != null) hashCode = hashCode * 59 + this.Smn.GetHashCode();
                if (this.Obs != null) hashCode = hashCode * 59 + this.Obs.GetHashCode();
                return hashCode;
            }
        }
    }
}
