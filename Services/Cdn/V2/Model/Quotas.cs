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
    /// 
    /// </summary>
    public class Quotas 
    {

        /// <summary>
        /// 配额上限。
        /// </summary>
        [JsonProperty("quota_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaLimit { get; set; }

        /// <summary>
        /// 配额类型。取值意义： - file_refresh：文件级别刷新配额 - dir_refresh：目录级别刷新配额 - preheat：预热配额 - domain：加速域名配额 - ip_filter：IP黑白名单配额 - browser_cache_rule：浏览器缓存规则配额 - http_response_header：HTTP响应头配额 - referer：REFERER防盗链配额 - flexible_origin：高级回源配额 - flexible_origin_match_value：高级回源匹配内容配额 - cache_rule：缓存规则配额 - custom_cache_key：自定义CACHE KEY配额 - custom_cache_key_match_value：自定义CACHE KEY匹配内容配额 - rule：规则引擎配额 - edge_function：函数阶段配额 - origin_request_url_rewrite：回源URL改写配额 - origin_request_header：回源请求头配额 - request_url_rewrite：请求URL改写配额 - access_area_filter：区域访问控制配额 - request_limit_rules：请求限速配置配额 - user_agent：UA配额
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 已使用配额数。
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public int? Used { get; set; }

        /// <summary>
        /// 域名所属用户的domain_id。
        /// </summary>
        [JsonProperty("user_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserDomainId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quotas {\n");
            sb.Append("  quotaLimit: ").Append(QuotaLimit).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("  userDomainId: ").Append(UserDomainId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Quotas);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Quotas input)
        {
            if (input == null) return false;
            if (this.QuotaLimit != input.QuotaLimit || (this.QuotaLimit != null && !this.QuotaLimit.Equals(input.QuotaLimit))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Used != input.Used || (this.Used != null && !this.Used.Equals(input.Used))) return false;
            if (this.UserDomainId != input.UserDomainId || (this.UserDomainId != null && !this.UserDomainId.Equals(input.UserDomainId))) return false;

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
                if (this.QuotaLimit != null) hashCode = hashCode * 59 + this.QuotaLimit.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Used != null) hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.UserDomainId != null) hashCode = hashCode * 59 + this.UserDomainId.GetHashCode();
                return hashCode;
            }
        }
    }
}
