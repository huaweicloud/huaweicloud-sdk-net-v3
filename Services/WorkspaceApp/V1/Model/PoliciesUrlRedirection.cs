using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 配置url重定向。
    /// </summary>
    public class PoliciesUrlRedirection 
    {

        /// <summary>
        /// 配置url重定向开关： false: 表示关闭 true: 表示开启
        /// </summary>
        [JsonProperty("url_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UrlRedirectionEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public UrlRedirectionOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesUrlRedirection {\n");
            sb.Append("  urlRedirectionEnable: ").Append(UrlRedirectionEnable).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesUrlRedirection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesUrlRedirection input)
        {
            if (input == null) return false;
            if (this.UrlRedirectionEnable != input.UrlRedirectionEnable || (this.UrlRedirectionEnable != null && !this.UrlRedirectionEnable.Equals(input.UrlRedirectionEnable))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;

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
                if (this.UrlRedirectionEnable != null) hashCode = hashCode * 59 + this.UrlRedirectionEnable.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
