using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 请求限速配置。
    /// </summary>
    public class RequestLimitRules 
    {

        /// <summary>
        /// status只支持on，off无效。  &gt; request_limit_rules字段置空时代表关闭请求限速功能。  &gt; 旧接口中的参数，后续将下线。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 优先级，值越大，优先级越高,取值范围：1-100。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 匹配类型，all：所有文件，catalog：目录。
        /// </summary>
        [JsonProperty("match_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchType { get; set; }

        /// <summary>
        /// 匹配类型值。 当match_type为all时传空值，例如：\&quot;\&quot;； 当match_type为catalog时传目录地址，以“/”作为首字符,例如：\&quot;/test\&quot;。  &gt; 值为catalog的时候必填
        /// </summary>
        [JsonProperty("match_value", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchValue { get; set; }

        /// <summary>
        /// 限速方式，当前仅支持按流量大小限速，取值为size。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 限速条件,type&#x3D;size,limit_rate_after&#x3D;50表示从传输表示传输50个字节后开始限速且限速值为limit_rate_value， 单位byte，取值范围：0-1073741824。
        /// </summary>
        [JsonProperty("limit_rate_after", NullValueHandling = NullValueHandling.Ignore)]
        public long? LimitRateAfter { get; set; }

        /// <summary>
        /// 限速值,单位Bps，取值范围 0-104857600。
        /// </summary>
        [JsonProperty("limit_rate_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? LimitRateValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestLimitRules {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  matchType: ").Append(MatchType).Append("\n");
            sb.Append("  matchValue: ").Append(MatchValue).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  limitRateAfter: ").Append(LimitRateAfter).Append("\n");
            sb.Append("  limitRateValue: ").Append(LimitRateValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RequestLimitRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RequestLimitRules input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.MatchType == input.MatchType ||
                    (this.MatchType != null &&
                    this.MatchType.Equals(input.MatchType))
                ) && 
                (
                    this.MatchValue == input.MatchValue ||
                    (this.MatchValue != null &&
                    this.MatchValue.Equals(input.MatchValue))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.LimitRateAfter == input.LimitRateAfter ||
                    (this.LimitRateAfter != null &&
                    this.LimitRateAfter.Equals(input.LimitRateAfter))
                ) && 
                (
                    this.LimitRateValue == input.LimitRateValue ||
                    (this.LimitRateValue != null &&
                    this.LimitRateValue.Equals(input.LimitRateValue))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.MatchType != null)
                    hashCode = hashCode * 59 + this.MatchType.GetHashCode();
                if (this.MatchValue != null)
                    hashCode = hashCode * 59 + this.MatchValue.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.LimitRateAfter != null)
                    hashCode = hashCode * 59 + this.LimitRateAfter.GetHashCode();
                if (this.LimitRateValue != null)
                    hashCode = hashCode * 59 + this.LimitRateValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
