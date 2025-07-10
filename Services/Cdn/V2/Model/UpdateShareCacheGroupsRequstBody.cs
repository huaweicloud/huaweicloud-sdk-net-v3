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
    /// **参数解释：** 共享缓存组配置 **约束限制：** 不涉及
    /// </summary>
    public class UpdateShareCacheGroupsRequstBody 
    {

        /// <summary>
        /// **参数解释：** 关联域名 **约束限制：** - 必须传入主域名 - 最多可包含50个关联域名
        /// </summary>
        [JsonProperty("share_cache_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShareCacheGroupsRecord> ShareCacheRecords { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateShareCacheGroupsRequstBody {\n");
            sb.Append("  shareCacheRecords: ").Append(ShareCacheRecords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateShareCacheGroupsRequstBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateShareCacheGroupsRequstBody input)
        {
            if (input == null) return false;
            if (this.ShareCacheRecords != input.ShareCacheRecords || (this.ShareCacheRecords != null && input.ShareCacheRecords != null && !this.ShareCacheRecords.SequenceEqual(input.ShareCacheRecords))) return false;

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
                if (this.ShareCacheRecords != null) hashCode = hashCode * 59 + this.ShareCacheRecords.GetHashCode();
                return hashCode;
            }
        }
    }
}
