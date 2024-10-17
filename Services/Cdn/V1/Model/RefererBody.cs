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
    public class RefererBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("referer", NullValueHandling = NullValueHandling.Ignore)]
        public Referer Referer { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefererBody {\n");
            sb.Append("  referer: ").Append(Referer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RefererBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RefererBody input)
        {
            if (input == null) return false;
            if (this.Referer != input.Referer || (this.Referer != null && !this.Referer.Equals(input.Referer))) return false;

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
                if (this.Referer != null) hashCode = hashCode * 59 + this.Referer.GetHashCode();
                return hashCode;
            }
        }
    }
}
