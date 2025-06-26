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
    /// Response Object
    /// </summary>
    public class ShowInstanceConfigurationResponse : SdkResponse
    {

        /// <summary>
        /// 是否开启匿名登录
        /// </summary>
        [JsonProperty("anonymous_access", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AnonymousAccess { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceConfigurationResponse {\n");
            sb.Append("  anonymousAccess: ").Append(AnonymousAccess).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceConfigurationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceConfigurationResponse input)
        {
            if (input == null) return false;
            if (this.AnonymousAccess != input.AnonymousAccess || (this.AnonymousAccess != null && !this.AnonymousAccess.Equals(input.AnonymousAccess))) return false;

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
                if (this.AnonymousAccess != null) hashCode = hashCode * 59 + this.AnonymousAccess.GetHashCode();
                return hashCode;
            }
        }
    }
}
