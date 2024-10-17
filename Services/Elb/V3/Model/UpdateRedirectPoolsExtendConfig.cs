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
    /// 参数解释：转发到的后端主机组的URL配置。
    /// </summary>
    public class UpdateRedirectPoolsExtendConfig 
    {

        /// <summary>
        /// 参数解释：是否开启url重定向
        /// </summary>
        [JsonProperty("rewrite_url_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RewriteUrlEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rewrite_url_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateRewriteUrlConfig RewriteUrlConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("insert_headers_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateInsertHeadersConfig InsertHeadersConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("remove_headers_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateRemoveHeadersConfig RemoveHeadersConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("traffic_limit_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateTrafficLimitConfig TrafficLimitConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRedirectPoolsExtendConfig {\n");
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
            return this.Equals(input as UpdateRedirectPoolsExtendConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRedirectPoolsExtendConfig input)
        {
            if (input == null) return false;
            if (this.RewriteUrlEnable != input.RewriteUrlEnable || (this.RewriteUrlEnable != null && !this.RewriteUrlEnable.Equals(input.RewriteUrlEnable))) return false;
            if (this.RewriteUrlConfig != input.RewriteUrlConfig || (this.RewriteUrlConfig != null && !this.RewriteUrlConfig.Equals(input.RewriteUrlConfig))) return false;
            if (this.InsertHeadersConfig != input.InsertHeadersConfig || (this.InsertHeadersConfig != null && !this.InsertHeadersConfig.Equals(input.InsertHeadersConfig))) return false;
            if (this.RemoveHeadersConfig != input.RemoveHeadersConfig || (this.RemoveHeadersConfig != null && !this.RemoveHeadersConfig.Equals(input.RemoveHeadersConfig))) return false;
            if (this.TrafficLimitConfig != input.TrafficLimitConfig || (this.TrafficLimitConfig != null && !this.TrafficLimitConfig.Equals(input.TrafficLimitConfig))) return false;

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
                if (this.RewriteUrlEnable != null) hashCode = hashCode * 59 + this.RewriteUrlEnable.GetHashCode();
                if (this.RewriteUrlConfig != null) hashCode = hashCode * 59 + this.RewriteUrlConfig.GetHashCode();
                if (this.InsertHeadersConfig != null) hashCode = hashCode * 59 + this.InsertHeadersConfig.GetHashCode();
                if (this.RemoveHeadersConfig != null) hashCode = hashCode * 59 + this.RemoveHeadersConfig.GetHashCode();
                if (this.TrafficLimitConfig != null) hashCode = hashCode * 59 + this.TrafficLimitConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
