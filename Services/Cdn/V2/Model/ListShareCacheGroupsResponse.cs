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
    public class ListShareCacheGroupsResponse : SdkResponse
    {

        /// <summary>
        /// 共享缓存配置总数量
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 共享缓存配置
        /// </summary>
        [JsonProperty("share_cache_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListShareCacheGroupsConfig> ShareCacheGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListShareCacheGroupsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  shareCacheGroups: ").Append(ShareCacheGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListShareCacheGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListShareCacheGroupsResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.ShareCacheGroups != input.ShareCacheGroups || (this.ShareCacheGroups != null && input.ShareCacheGroups != null && !this.ShareCacheGroups.SequenceEqual(input.ShareCacheGroups))) return false;

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
                if (this.ShareCacheGroups != null) hashCode = hashCode * 59 + this.ShareCacheGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
