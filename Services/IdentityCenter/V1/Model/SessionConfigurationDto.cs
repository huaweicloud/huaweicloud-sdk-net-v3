using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// the struct of SessionConfiguration
    /// </summary>
    public class SessionConfigurationDto 
    {

        /// <summary>
        /// 会话生效时间
        /// </summary>
        [JsonProperty("max_authentication_age", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxAuthenticationAge { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionConfigurationDto {\n");
            sb.Append("  maxAuthenticationAge: ").Append(MaxAuthenticationAge).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SessionConfigurationDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SessionConfigurationDto input)
        {
            if (input == null) return false;
            if (this.MaxAuthenticationAge != input.MaxAuthenticationAge || (this.MaxAuthenticationAge != null && !this.MaxAuthenticationAge.Equals(input.MaxAuthenticationAge))) return false;

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
                if (this.MaxAuthenticationAge != null) hashCode = hashCode * 59 + this.MaxAuthenticationAge.GetHashCode();
                return hashCode;
            }
        }
    }
}
