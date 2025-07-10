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
    /// **参数解释：** 通过不同参数控制源站资源在CDN节点的缓存时长 **约束限制：** 不涉及
    /// </summary>
    public class CacheRulesEngine 
    {

        /// <summary>
        /// **参数解释：** 资源在CDN节点的缓存过期时间 **约束限制：** 最大支持365天 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ttl { get; set; }

        /// <summary>
        /// **参数解释：** 缓存过期时间单位 **约束限制：** 不涉及 **取值范围：** - s: 秒 - m: 分 - h: 小时 - d: 天 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("ttl_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string TtlUnit { get; set; }

        /// <summary>
        /// **参数解释：** 缓存过期时间来源，设置CDN节点的缓存遵循源站还是CDN侧的配置 **约束限制：** 不涉及 **取值范围：** - on: CDN节点的缓存过期时间遵循源站的设置 - off: CDN节点的缓存过期时间遵循“缓存规则”中的“缓存过期时间” - min_ttl: CDN节点的缓存过期时间取缓存规则和源站二者的最小值 **默认取值：** off: CDN节点的缓存过期时间遵循“缓存规则”中的“缓存过期时间”
        /// </summary>
        [JsonProperty("follow_origin", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowOrigin { get; set; }

        /// <summary>
        /// **参数解释：** 强制缓存：CDN节点缓存过期时间是否忽略源站响应头Cache-Control中的no-cache、private、no-store字段 **约束限制：** 强制缓存与缓存过期时间来源功能配合使用，具体使用限制及配置效果请参考CDN用户指南的配置节点缓存规则章节 **取值范围：** - on: 打开强制缓存 - off: 关闭强制缓存 **默认取值：** off: 关闭强制缓存
        /// </summary>
        [JsonProperty("force_cache", NullValueHandling = NullValueHandling.Ignore)]
        public string ForceCache { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CacheRulesEngine {\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("  ttlUnit: ").Append(TtlUnit).Append("\n");
            sb.Append("  followOrigin: ").Append(FollowOrigin).Append("\n");
            sb.Append("  forceCache: ").Append(ForceCache).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CacheRulesEngine);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CacheRulesEngine input)
        {
            if (input == null) return false;
            if (this.Ttl != input.Ttl || (this.Ttl != null && !this.Ttl.Equals(input.Ttl))) return false;
            if (this.TtlUnit != input.TtlUnit || (this.TtlUnit != null && !this.TtlUnit.Equals(input.TtlUnit))) return false;
            if (this.FollowOrigin != input.FollowOrigin || (this.FollowOrigin != null && !this.FollowOrigin.Equals(input.FollowOrigin))) return false;
            if (this.ForceCache != input.ForceCache || (this.ForceCache != null && !this.ForceCache.Equals(input.ForceCache))) return false;

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
                if (this.Ttl != null) hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                if (this.TtlUnit != null) hashCode = hashCode * 59 + this.TtlUnit.GetHashCode();
                if (this.FollowOrigin != null) hashCode = hashCode * 59 + this.FollowOrigin.GetHashCode();
                if (this.ForceCache != null) hashCode = hashCode * 59 + this.ForceCache.GetHashCode();
                return hashCode;
            }
        }
    }
}
