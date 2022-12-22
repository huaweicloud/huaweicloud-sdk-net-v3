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
    public class CreatePublicZoneFindReq 
    {

        /// <summary>
        /// 找回域名名称
        /// </summary>
        [JsonProperty("zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePublicZoneFindReq {\n");
            sb.Append("  zoneName: ").Append(ZoneName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePublicZoneFindReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePublicZoneFindReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ZoneName == input.ZoneName ||
                    (this.ZoneName != null &&
                    this.ZoneName.Equals(input.ZoneName))
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
                if (this.ZoneName != null)
                    hashCode = hashCode * 59 + this.ZoneName.GetHashCode();
                return hashCode;
            }
        }
    }
}
