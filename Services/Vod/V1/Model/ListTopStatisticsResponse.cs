using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListTopStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("top_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopUrl> TopUrls { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTopStatisticsResponse {\n");
            sb.Append("  topUrls: ").Append(TopUrls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTopStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTopStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.TopUrls != input.TopUrls || (this.TopUrls != null && input.TopUrls != null && !this.TopUrls.SequenceEqual(input.TopUrls))) return false;

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
                if (this.TopUrls != null) hashCode = hashCode * 59 + this.TopUrls.GetHashCode();
                return hashCode;
            }
        }
    }
}
