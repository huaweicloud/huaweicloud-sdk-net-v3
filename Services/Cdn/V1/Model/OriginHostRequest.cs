using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OriginHostRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("origin_host", NullValueHandling = NullValueHandling.Ignore)]
        public OriginHostBody OriginHost { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OriginHostRequest {\n");
            sb.Append("  originHost: ").Append(OriginHost).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OriginHostRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OriginHostRequest input)
        {
            if (input == null) return false;
            if (this.OriginHost != input.OriginHost || (this.OriginHost != null && !this.OriginHost.Equals(input.OriginHost))) return false;

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
                if (this.OriginHost != null) hashCode = hashCode * 59 + this.OriginHost.GetHashCode();
                return hashCode;
            }
        }
    }
}
