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
    /// url重定向配置。
    /// </summary>
    public class UrlRedirectionOptions 
    {

        /// <summary>
        /// 允许重定向url。
        /// </summary>
        [JsonProperty("url_include_list", NullValueHandling = NullValueHandling.Ignore)]
        public string UrlIncludeList { get; set; }

        /// <summary>
        /// 拒绝重定向url。
        /// </summary>
        [JsonProperty("url_exclude_list", NullValueHandling = NullValueHandling.Ignore)]
        public string UrlExcludeList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UrlRedirectionOptions {\n");
            sb.Append("  urlIncludeList: ").Append(UrlIncludeList).Append("\n");
            sb.Append("  urlExcludeList: ").Append(UrlExcludeList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UrlRedirectionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UrlRedirectionOptions input)
        {
            if (input == null) return false;
            if (this.UrlIncludeList != input.UrlIncludeList || (this.UrlIncludeList != null && !this.UrlIncludeList.Equals(input.UrlIncludeList))) return false;
            if (this.UrlExcludeList != input.UrlExcludeList || (this.UrlExcludeList != null && !this.UrlExcludeList.Equals(input.UrlExcludeList))) return false;

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
                if (this.UrlIncludeList != null) hashCode = hashCode * 59 + this.UrlIncludeList.GetHashCode();
                if (this.UrlExcludeList != null) hashCode = hashCode * 59 + this.UrlExcludeList.GetHashCode();
                return hashCode;
            }
        }
    }
}
