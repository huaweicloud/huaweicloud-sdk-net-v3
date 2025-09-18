using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// create ip group request
    /// </summary>
    public class CreateIpGroupRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ip_group", NullValueHandling = NullValueHandling.Ignore)]
        public CreateIpGroupOption IpGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateIpGroupRequestBody {\n");
            sb.Append("  ipGroup: ").Append(IpGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateIpGroupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateIpGroupRequestBody input)
        {
            if (input == null) return false;
            if (this.IpGroup != input.IpGroup || (this.IpGroup != null && !this.IpGroup.Equals(input.IpGroup))) return false;

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
                if (this.IpGroup != null) hashCode = hashCode * 59 + this.IpGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
