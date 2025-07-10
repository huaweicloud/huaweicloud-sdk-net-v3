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
    /// **参数解释：** 浏览器缓存过期时间，当终端用户请求资源时，如果浏览器有缓存，直接返回给用户 **约束限制：** 不涉及
    /// </summary>
    public class BrowserCacheRulesEngine 
    {

        /// <summary>
        /// **参数解释：** 缓存生效类型 **约束限制：** 不涉及 **取值范围：** - follow_origin: 遵循源站的缓存策略，即Cache-Control头部的设置 - ttl: 浏览器缓存遵循当前规则设置的过期时间 - never: 浏览器不缓存资源 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("cache_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CacheType { get; set; }

        /// <summary>
        /// **参数解释：** 缓存过期时间 **约束限制：** - 最大支持365天 - 当缓存生效类型为ttl时必填 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ttl { get; set; }

        /// <summary>
        /// **参数解释：** 缓存过期时间单位 **约束限制：** 当缓存生效类型为ttl时必填 **取值范围：** - s：秒 - m：分种 - h：小时 - d：天 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("ttl_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string TtlUnit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrowserCacheRulesEngine {\n");
            sb.Append("  cacheType: ").Append(CacheType).Append("\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("  ttlUnit: ").Append(TtlUnit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BrowserCacheRulesEngine);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BrowserCacheRulesEngine input)
        {
            if (input == null) return false;
            if (this.CacheType != input.CacheType || (this.CacheType != null && !this.CacheType.Equals(input.CacheType))) return false;
            if (this.Ttl != input.Ttl || (this.Ttl != null && !this.Ttl.Equals(input.Ttl))) return false;
            if (this.TtlUnit != input.TtlUnit || (this.TtlUnit != null && !this.TtlUnit.Equals(input.TtlUnit))) return false;

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
                if (this.CacheType != null) hashCode = hashCode * 59 + this.CacheType.GetHashCode();
                if (this.Ttl != null) hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                if (this.TtlUnit != null) hashCode = hashCode * 59 + this.TtlUnit.GetHashCode();
                return hashCode;
            }
        }
    }
}
