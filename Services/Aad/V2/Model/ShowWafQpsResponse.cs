using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowWafQpsResponse : SdkResponse
    {

        /// <summary>
        /// qps
        /// </summary>
        [JsonProperty("qps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Qps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowWafQpsResponse {\n");
            sb.Append("  qps: ").Append(Qps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWafQpsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWafQpsResponse input)
        {
            if (input == null) return false;
            if (this.Qps != input.Qps || (this.Qps != null && !this.Qps.Equals(input.Qps))) return false;

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
                if (this.Qps != null) hashCode = hashCode * 59 + this.Qps.GetHashCode();
                return hashCode;
            }
        }
    }
}
