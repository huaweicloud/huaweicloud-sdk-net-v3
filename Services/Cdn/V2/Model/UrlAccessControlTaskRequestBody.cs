using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 需要解禁或封禁的URL信息
    /// </summary>
    public class UrlAccessControlTaskRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("access_control_urls", NullValueHandling = NullValueHandling.Ignore)]
        public AccessControlUrls AccessControlUrls { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UrlAccessControlTaskRequestBody {\n");
            sb.Append("  accessControlUrls: ").Append(AccessControlUrls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UrlAccessControlTaskRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UrlAccessControlTaskRequestBody input)
        {
            if (input == null) return false;
            if (this.AccessControlUrls != input.AccessControlUrls || (this.AccessControlUrls != null && !this.AccessControlUrls.Equals(input.AccessControlUrls))) return false;

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
                if (this.AccessControlUrls != null) hashCode = hashCode * 59 + this.AccessControlUrls.GetHashCode();
                return hashCode;
            }
        }
    }
}
