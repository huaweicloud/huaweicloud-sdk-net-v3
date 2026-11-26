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
    /// **参数解释：** 需要复制的原域名配置 **约束限制：** 不涉及
    /// </summary>
    public class BatchCopyConfigs 
    {

        /// <summary>
        /// **参数解释：** 目标域名，即需要复制配置的域名，支持配置多个域名 **约束限制：** - 多个域名以“,”分隔 - 最多配置10个域名 - 域名状态为已开启、已停用、审核未通过且未被封禁和未被锁定时，才可以使用复制配置功能  **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("target_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDomain { get; set; }

        /// <summary>
        /// **参数解释：** 原域名，将该域名的配置复制给目标域名 **约束限制：** 域名状态为已开启、已停用、审核未通过且未被封禁时，才可以使用复制配置功能 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("source_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDomain { get; set; }

        /// <summary>
        /// **参数解释：** 需要复制的域名配置项 **约束限制：** 多个配置项以“,”分隔 **取值范围：** - origin_request_header: 回源请求头 - http_response_header: HTTP header配置 - url_auth: URL鉴权配置 - user_agent_black_and_white_list: User-Agent黑白名单 - ipv6_accelerate: IPv6开关 - range_status: Range回源 - cache_rules: 缓存规则 - follow_302_status: 回源跟随 - sources: 源站配置 - compress: 智能压缩 - referer: 防盗链 - ip_black_and_white_list: IP黑白名单 - browser_cacheRules: 浏览器缓存过期时间 - cache_valid_error_code: 状态码缓存时间 - access_area_filter: 区域访问控制 - http2_status: HTTP/2 - ocsp_stapling_status: OCSP Stapling - force_redirect: 强制跳转 - https_tls_version: TLS版本与加密套件配置 - rules: 规则引擎 - error_code_redirect_rules: 自定义错误页面配置  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("config_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ConfigList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCopyConfigs {\n");
            sb.Append("  targetDomain: ").Append(TargetDomain).Append("\n");
            sb.Append("  sourceDomain: ").Append(SourceDomain).Append("\n");
            sb.Append("  configList: ").Append(ConfigList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCopyConfigs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCopyConfigs input)
        {
            if (input == null) return false;
            if (this.TargetDomain != input.TargetDomain || (this.TargetDomain != null && !this.TargetDomain.Equals(input.TargetDomain))) return false;
            if (this.SourceDomain != input.SourceDomain || (this.SourceDomain != null && !this.SourceDomain.Equals(input.SourceDomain))) return false;
            if (this.ConfigList != input.ConfigList || (this.ConfigList != null && input.ConfigList != null && !this.ConfigList.SequenceEqual(input.ConfigList))) return false;

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
                if (this.TargetDomain != null) hashCode = hashCode * 59 + this.TargetDomain.GetHashCode();
                if (this.SourceDomain != null) hashCode = hashCode * 59 + this.SourceDomain.GetHashCode();
                if (this.ConfigList != null) hashCode = hashCode * 59 + this.ConfigList.GetHashCode();
                return hashCode;
            }
        }
    }
}
