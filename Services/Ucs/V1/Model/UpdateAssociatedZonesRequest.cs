using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateAssociatedZonesRequest 
    {

        /// <summary>
        /// 在联邦管理的域名访问功能中，用于更改根域名
        /// </summary>
        [JsonProperty("dnsSuffix", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DnsSuffix { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAssociatedZonesRequest {\n");
            sb.Append("  dnsSuffix: ").Append(DnsSuffix).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAssociatedZonesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAssociatedZonesRequest input)
        {
            if (input == null) return false;
            if (this.DnsSuffix != input.DnsSuffix || (this.DnsSuffix != null && input.DnsSuffix != null && !this.DnsSuffix.SequenceEqual(input.DnsSuffix))) return false;

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
                if (this.DnsSuffix != null) hashCode = hashCode * 59 + this.DnsSuffix.GetHashCode();
                return hashCode;
            }
        }
    }
}
