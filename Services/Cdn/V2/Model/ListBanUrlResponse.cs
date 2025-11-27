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
    /// Response Object
    /// </summary>
    public class ListBanUrlResponse : SdkResponse
    {

        /// <summary>
        /// 查询结果总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// url信息。
        /// </summary>
        [JsonProperty("ban_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<BanUrlList> BanUrls { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBanUrlResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  banUrls: ").Append(BanUrls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBanUrlResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBanUrlResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.BanUrls != input.BanUrls || (this.BanUrls != null && input.BanUrls != null && !this.BanUrls.SequenceEqual(input.BanUrls))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.BanUrls != null) hashCode = hashCode * 59 + this.BanUrls.GetHashCode();
                return hashCode;
            }
        }
    }
}
