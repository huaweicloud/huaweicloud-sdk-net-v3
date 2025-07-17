using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateAnonymousAuthRandomResponse : SdkResponse
    {

        /// <summary>
        /// 下一跳URL。
        /// </summary>
        [JsonProperty("siteUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteUrl { get; set; }

        /// <summary>
        /// 鉴权随机数。
        /// </summary>
        [JsonProperty("random", NullValueHandling = NullValueHandling.Ignore)]
        public string Random { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAnonymousAuthRandomResponse {\n");
            sb.Append("  siteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  random: ").Append(Random).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAnonymousAuthRandomResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAnonymousAuthRandomResponse input)
        {
            if (input == null) return false;
            if (this.SiteUrl != input.SiteUrl || (this.SiteUrl != null && !this.SiteUrl.Equals(input.SiteUrl))) return false;
            if (this.Random != input.Random || (this.Random != null && !this.Random.Equals(input.Random))) return false;

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
                if (this.SiteUrl != null) hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                if (this.Random != null) hashCode = hashCode * 59 + this.Random.GetHashCode();
                return hashCode;
            }
        }
    }
}
