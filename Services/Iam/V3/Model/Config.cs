using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Config 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("security_compliance", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityCompliance SecurityCompliance { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Config {\n");
            sb.Append("  securityCompliance: ").Append(SecurityCompliance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Config);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Config input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecurityCompliance == input.SecurityCompliance ||
                    (this.SecurityCompliance != null &&
                    this.SecurityCompliance.Equals(input.SecurityCompliance))
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
                if (this.SecurityCompliance != null)
                    hashCode = hashCode * 59 + this.SecurityCompliance.GetHashCode();
                return hashCode;
            }
        }
    }
}
