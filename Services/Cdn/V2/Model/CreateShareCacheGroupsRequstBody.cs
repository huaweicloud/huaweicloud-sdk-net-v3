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
    public class CreateShareCacheGroupsRequstBody 
    {

        /// <summary>
        /// **参数解释：** 共享缓存组名称 **约束限制：** 不涉及 **取值范围：** - 1-128个字符 - 不支持特殊字符“%”、“&amp;”、“&#x3D;”、“?”、“$”\&quot;、“\&quot;”、“&lt;”、“&gt;” **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// **参数解释：** 主域名 **约束限制：** 只能有一个主域名 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("primary_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryDomain { get; set; }

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
            sb.Append("class CreateShareCacheGroupsRequstBody {\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  primaryDomain: ").Append(PrimaryDomain).Append("\n");
            sb.Append("  shareCacheRecords: ").Append(ShareCacheRecords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateShareCacheGroupsRequstBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateShareCacheGroupsRequstBody input)
        {
            if (input == null) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.PrimaryDomain != input.PrimaryDomain || (this.PrimaryDomain != null && !this.PrimaryDomain.Equals(input.PrimaryDomain))) return false;
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
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.PrimaryDomain != null) hashCode = hashCode * 59 + this.PrimaryDomain.GetHashCode();
                if (this.ShareCacheRecords != null) hashCode = hashCode * 59 + this.ShareCacheRecords.GetHashCode();
                return hashCode;
            }
        }
    }
}
