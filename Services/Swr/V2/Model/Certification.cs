using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Certification 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cert", NullValueHandling = NullValueHandling.Ignore)]
        public AuthInfo Cert { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Certification {\n");
            sb.Append("  cert: ").Append(Cert).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Certification);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Certification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cert == input.Cert ||
                    (this.Cert != null &&
                    this.Cert.Equals(input.Cert))
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
                if (this.Cert != null)
                    hashCode = hashCode * 59 + this.Cert.GetHashCode();
                return hashCode;
            }
        }
    }
}
