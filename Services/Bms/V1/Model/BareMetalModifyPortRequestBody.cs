using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BareMetalModifyPortRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nic", NullValueHandling = NullValueHandling.Ignore)]
        public BareMetalModifyPortRequest Nic { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BareMetalModifyPortRequestBody {\n");
            sb.Append("  nic: ").Append(Nic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BareMetalModifyPortRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BareMetalModifyPortRequestBody input)
        {
            if (input == null) return false;
            if (this.Nic != input.Nic || (this.Nic != null && !this.Nic.Equals(input.Nic))) return false;

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
                if (this.Nic != null) hashCode = hashCode * 59 + this.Nic.GetHashCode();
                return hashCode;
            }
        }
    }
}
