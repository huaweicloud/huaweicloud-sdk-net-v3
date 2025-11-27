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
    public class FederationVersionSpec 
    {

        /// <summary>
        /// 联邦版本
        /// </summary>
        [JsonProperty("FederationVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string FederationVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FederationVersionSpec {\n");
            sb.Append("  federationVersion: ").Append(FederationVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FederationVersionSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FederationVersionSpec input)
        {
            if (input == null) return false;
            if (this.FederationVersion != input.FederationVersion || (this.FederationVersion != null && !this.FederationVersion.Equals(input.FederationVersion))) return false;

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
                if (this.FederationVersion != null) hashCode = hashCode * 59 + this.FederationVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
