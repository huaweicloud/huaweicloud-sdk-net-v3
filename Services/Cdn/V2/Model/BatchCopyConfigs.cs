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
    /// 原域名所有配置
    /// </summary>
    public class BatchCopyConfigs 
    {

        /// <summary>
        /// 目标域名列表,多个域名以逗号（半角）分隔,域名数最大10个。
        /// </summary>
        [JsonProperty("target_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDomain { get; set; }

        /// <summary>
        /// 原域名
        /// </summary>
        [JsonProperty("source_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDomain { get; set; }

        /// <summary>
        /// 需要复制的域名配置项,多个配置项以逗号（半角）分隔，支持复制的配置项： - originRequestHeader（回源请求头） - httpResponseHeader（HTTP header配置） - cacheUrlParamsConfig（URL参数） - urlAuth（URL鉴权配置） - userAgentBlackAndWhiteList（User-Agent黑白名单） - ipv6Accelerate（IPv6开关） - rangeStatus（Range回源） - cacheRules（缓存规则） - followOrigin（缓存遵循源站） - privateBucketRetrieval（私有桶回源） - follow302Status（回源跟随） - sources（源站配置） - compress（智能压缩） - referer（防盗链） - ipBlackAndWhiteList（IP黑白名单）
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
            if (input == null)
                return false;

            return 
                (
                    this.TargetDomain == input.TargetDomain ||
                    (this.TargetDomain != null &&
                    this.TargetDomain.Equals(input.TargetDomain))
                ) && 
                (
                    this.SourceDomain == input.SourceDomain ||
                    (this.SourceDomain != null &&
                    this.SourceDomain.Equals(input.SourceDomain))
                ) && 
                (
                    this.ConfigList == input.ConfigList ||
                    this.ConfigList != null &&
                    input.ConfigList != null &&
                    this.ConfigList.SequenceEqual(input.ConfigList)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TargetDomain != null)
                    hashCode = hashCode * 59 + this.TargetDomain.GetHashCode();
                if (this.SourceDomain != null)
                    hashCode = hashCode * 59 + this.SourceDomain.GetHashCode();
                if (this.ConfigList != null)
                    hashCode = hashCode * 59 + this.ConfigList.GetHashCode();
                return hashCode;
            }
        }
    }
}
