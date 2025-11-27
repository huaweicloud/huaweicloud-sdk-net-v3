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
    public class AccessControlUrls 
    {

        /// <summary>
        /// URL必须带有“http://”或“https://”，单次最多输入1000个url。
        /// </summary>
        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Urls { get; set; }

        /// <summary>
        /// URL封禁天数，默认7天，取值范围1-30。
        /// </summary>
        [JsonProperty("ban_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? BanDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessControlUrls {\n");
            sb.Append("  urls: ").Append(Urls).Append("\n");
            sb.Append("  banDuration: ").Append(BanDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessControlUrls);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessControlUrls input)
        {
            if (input == null) return false;
            if (this.Urls != input.Urls || (this.Urls != null && input.Urls != null && !this.Urls.SequenceEqual(input.Urls))) return false;
            if (this.BanDuration != input.BanDuration || (this.BanDuration != null && !this.BanDuration.Equals(input.BanDuration))) return false;

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
                if (this.Urls != null) hashCode = hashCode * 59 + this.Urls.GetHashCode();
                if (this.BanDuration != null) hashCode = hashCode * 59 + this.BanDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
