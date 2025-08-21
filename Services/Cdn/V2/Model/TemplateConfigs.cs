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
    /// **参数解释：** 域名模板配置 **约束限制：** 不涉及
    /// </summary>
    public class TemplateConfigs 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("http_response_header", NullValueHandling = NullValueHandling.Ignore)]
        public List<HttpResponseHeader> HttpResponseHeader { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cache_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<CacheRules> CacheRules { get; set; }

        /// <summary>
        /// **参数解释：** 开启回源跟随，当源站地址因业务需求做了301/302 重定向，CDN节点会先跳转到301/302对应地址获取资源，缓存后再返回给用户 **约束限制：** 不涉及 **取值范围：** - on: 开启 - off: 关闭 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("origin_follow302_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginFollow302Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("compress", NullValueHandling = NullValueHandling.Ignore)]
        public Compress Compress { get; set; }

        /// <summary>
        /// **参数解释：** Range回源，开启后，源站在收到CDN节点回源请求时，根据HTTP请求头中的Range信息返回指定范围的数据给CDN节点 **约束限制：** 开启Range回源的前提是您的源站支持Range请求，即HTTP请求头中包含Range字段，否则可能导致回源失败 **取值范围：** - on: 开启 - off: 关闭 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("origin_range_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginRangeStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ip_filter", NullValueHandling = NullValueHandling.Ignore)]
        public IpFilter IpFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("referer", NullValueHandling = NullValueHandling.Ignore)]
        public RefererConfig Referer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_agent_filter", NullValueHandling = NullValueHandling.Ignore)]
        public UserAgentFilter UserAgentFilter { get; set; }

        /// <summary>
        /// **参数解释：** 设置用量封顶阈值，当实际用量大于阈值时停用域名，有效预防流量盗刷或恶意攻击带来的高额账单。  &gt; 由于监控数据存在时延，域名将在用量达到阈值后的10分钟左右被停用  **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("flow_limit_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlowLimitStrategy> FlowLimitStrategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateConfigs {\n");
            sb.Append("  httpResponseHeader: ").Append(HttpResponseHeader).Append("\n");
            sb.Append("  cacheRules: ").Append(CacheRules).Append("\n");
            sb.Append("  originFollow302Status: ").Append(OriginFollow302Status).Append("\n");
            sb.Append("  compress: ").Append(Compress).Append("\n");
            sb.Append("  originRangeStatus: ").Append(OriginRangeStatus).Append("\n");
            sb.Append("  ipFilter: ").Append(IpFilter).Append("\n");
            sb.Append("  referer: ").Append(Referer).Append("\n");
            sb.Append("  userAgentFilter: ").Append(UserAgentFilter).Append("\n");
            sb.Append("  flowLimitStrategy: ").Append(FlowLimitStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateConfigs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateConfigs input)
        {
            if (input == null) return false;
            if (this.HttpResponseHeader != input.HttpResponseHeader || (this.HttpResponseHeader != null && input.HttpResponseHeader != null && !this.HttpResponseHeader.SequenceEqual(input.HttpResponseHeader))) return false;
            if (this.CacheRules != input.CacheRules || (this.CacheRules != null && input.CacheRules != null && !this.CacheRules.SequenceEqual(input.CacheRules))) return false;
            if (this.OriginFollow302Status != input.OriginFollow302Status || (this.OriginFollow302Status != null && !this.OriginFollow302Status.Equals(input.OriginFollow302Status))) return false;
            if (this.Compress != input.Compress || (this.Compress != null && !this.Compress.Equals(input.Compress))) return false;
            if (this.OriginRangeStatus != input.OriginRangeStatus || (this.OriginRangeStatus != null && !this.OriginRangeStatus.Equals(input.OriginRangeStatus))) return false;
            if (this.IpFilter != input.IpFilter || (this.IpFilter != null && !this.IpFilter.Equals(input.IpFilter))) return false;
            if (this.Referer != input.Referer || (this.Referer != null && !this.Referer.Equals(input.Referer))) return false;
            if (this.UserAgentFilter != input.UserAgentFilter || (this.UserAgentFilter != null && !this.UserAgentFilter.Equals(input.UserAgentFilter))) return false;
            if (this.FlowLimitStrategy != input.FlowLimitStrategy || (this.FlowLimitStrategy != null && input.FlowLimitStrategy != null && !this.FlowLimitStrategy.SequenceEqual(input.FlowLimitStrategy))) return false;

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
                if (this.HttpResponseHeader != null) hashCode = hashCode * 59 + this.HttpResponseHeader.GetHashCode();
                if (this.CacheRules != null) hashCode = hashCode * 59 + this.CacheRules.GetHashCode();
                if (this.OriginFollow302Status != null) hashCode = hashCode * 59 + this.OriginFollow302Status.GetHashCode();
                if (this.Compress != null) hashCode = hashCode * 59 + this.Compress.GetHashCode();
                if (this.OriginRangeStatus != null) hashCode = hashCode * 59 + this.OriginRangeStatus.GetHashCode();
                if (this.IpFilter != null) hashCode = hashCode * 59 + this.IpFilter.GetHashCode();
                if (this.Referer != null) hashCode = hashCode * 59 + this.Referer.GetHashCode();
                if (this.UserAgentFilter != null) hashCode = hashCode * 59 + this.UserAgentFilter.GetHashCode();
                if (this.FlowLimitStrategy != null) hashCode = hashCode * 59 + this.FlowLimitStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
