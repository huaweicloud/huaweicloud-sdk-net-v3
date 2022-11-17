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
    public class IdentityprovidersLinks 
    {

        /// <summary>
        /// 身份提供商的资源链接地址。
        /// </summary>
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public string Self { get; set; }

        /// <summary>
        /// 协议的资源链接地址。
        /// </summary>
        [JsonProperty("protocols", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocols { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityprovidersLinks {\n");
            sb.Append("  self: ").Append(Self).Append("\n");
            sb.Append("  protocols: ").Append(Protocols).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdentityprovidersLinks);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdentityprovidersLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Protocols == input.Protocols ||
                    (this.Protocols != null &&
                    this.Protocols.Equals(input.Protocols))
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
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.Protocols != null)
                    hashCode = hashCode * 59 + this.Protocols.GetHashCode();
                return hashCode;
            }
        }
    }
}
