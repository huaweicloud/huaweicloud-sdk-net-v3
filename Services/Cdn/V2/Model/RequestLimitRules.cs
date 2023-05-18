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
    /// 请求限速配置。
    /// </summary>
    public class RequestLimitRules 
    {

        /// <summary>
        /// 配置开关（on/off）
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 限速方式，目前只支持按流量大小限速，size:大小。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 限速条件,type&#x3D;size,limit_rate_after&#x3D;50表示从传输表示传输50个字节后开始限速且限速值为limit_rate_value， 单位byte，取值范围：0-1073741824。
        /// </summary>
        [JsonProperty("limit_rate_after", NullValueHandling = NullValueHandling.Ignore)]
        public long? LimitRateAfter { get; set; }

        /// <summary>
        /// 限速值,单位Bps，取值范围 0-104857600
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
