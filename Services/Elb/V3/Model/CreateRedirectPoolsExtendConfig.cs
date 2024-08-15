using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 参数解释：转发到的后端主机组的配置。  约束限制：当action为REDIRECT_TO_POOL时生效。
    /// </summary>
    public class CreateRedirectPoolsExtendConfig 
    {

        /// <summary>
        /// 参数解释：是否开启url重定向。
        /// </summary>
        [JsonProperty("rewrite_url_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RewriteUrlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rewrite_url_config", NullValueHandling = NullValueHandling.Ignore)]
        public CreateRewriteUrlConfig RewriteUrlConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("insert_headers_config", NullValueHandling = NullValueHandling.Ignore)]
        public CreateInsertHeadersConfig InsertHeadersConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("remove_headers_config", NullValueHandling = NullValueHandling.Ignore)]
        public CreateRemoveHeadersConfig RemoveHeadersConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("traffic_limit_config", NullValueHandling = NullValueHandling.Ignore)]
        public CreateTrafficLimitConfig TrafficLimitConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRedirectPoolsExtendConfig {\n");
            sb.Append("  rewriteUrlEnable: ").Append(RewriteUrlEnable).Append("\n");
            sb.Append("  rewriteUrlConfig: ").Append(RewriteUrlConfig).Append("\n");
            sb.Append("  insertHeadersConfig: ").Append(InsertHeadersConfig).Append("\n");
            sb.Append("  removeHeadersConfig: ").Append(RemoveHeadersConfig).Append("\n");
            sb.Append("  trafficLimitConfig: ").Append(TrafficLimitConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRedirectPoolsExtendConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRedirectPoolsExtendConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RewriteUrlEnable == input.RewriteUrlEnable ||
                    (this.RewriteUrlEnable != null &&
                    this.RewriteUrlEnable.Equals(input.RewriteUrlEnable))
                ) && 
                (
                    this.RewriteUrlConfig == input.RewriteUrlConfig ||
                    (this.RewriteUrlConfig != null &&
                    this.RewriteUrlConfig.Equals(input.RewriteUrlConfig))
                ) && 
                (
                    this.InsertHeadersConfig == input.InsertHeadersConfig ||
                    (this.InsertHeadersConfig != null &&
                    this.InsertHeadersConfig.Equals(input.InsertHeadersConfig))
                ) && 
                (
                    this.RemoveHeadersConfig == input.RemoveHeadersConfig ||
                    (this.RemoveHeadersConfig != null &&
                    this.RemoveHeadersConfig.Equals(input.RemoveHeadersConfig))
                ) && 
                (
                    this.TrafficLimitConfig == input.TrafficLimitConfig ||
                    (this.TrafficLimitConfig != null &&
                    this.TrafficLimitConfig.Equals(input.TrafficLimitConfig))
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
                if (this.RewriteUrlEnable != null)
                    hashCode = hashCode * 59 + this.RewriteUrlEnable.GetHashCode();
                if (this.RewriteUrlConfig != null)
                    hashCode = hashCode * 59 + this.RewriteUrlConfig.GetHashCode();
                if (this.InsertHeadersConfig != null)
                    hashCode = hashCode * 59 + this.InsertHeadersConfig.GetHashCode();
                if (this.RemoveHeadersConfig != null)
                    hashCode = hashCode * 59 + this.RemoveHeadersConfig.GetHashCode();
                if (this.TrafficLimitConfig != null)
                    hashCode = hashCode * 59 + this.TrafficLimitConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
