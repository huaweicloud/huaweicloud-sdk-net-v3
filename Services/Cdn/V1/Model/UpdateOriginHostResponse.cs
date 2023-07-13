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
    /// Response Object
    /// </summary>
    public class UpdateOriginHostResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("origin_host", NullValueHandling = NullValueHandling.Ignore)]
        public DomainOriginHost OriginHost { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateOriginHostResponse {\n");
            sb.Append("  originHost: ").Append(OriginHost).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateOriginHostResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateOriginHostResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OriginHost == input.OriginHost ||
                    (this.OriginHost != null &&
                    this.OriginHost.Equals(input.OriginHost))
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
                if (this.OriginHost != null)
                    hashCode = hashCode * 59 + this.OriginHost.GetHashCode();
                return hashCode;
            }
        }
    }
}
