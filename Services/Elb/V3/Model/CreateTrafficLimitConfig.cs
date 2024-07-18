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
    /// 转发策略限速的配置。
    /// </summary>
    public class CreateTrafficLimitConfig 
    {

        /// <summary>
        /// 转发策略整体限速。取值： 0-100000s。0表示不限速
        /// </summary>
        [JsonProperty("qps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Qps { get; set; }

        /// <summary>
        /// 对转发策略单源进行限速。 quic监听器下转发策略不支持配置单源限速。指定该字段时，赋值可以为0或者为null。 取值： 0-100000s。0表示不限速，如果qps不为0，per_source_ip_qps需要小于qps。
        /// </summary>
        [JsonProperty("per_source_ip_qps", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerSourceIpQps { get; set; }

        /// <summary>
        /// 对转发策略单源进行限速。取值： 0-100000s。当qps超限的时候，不返回503，支持允许局部突增burst大小的请求。
        /// </summary>
        [JsonProperty("burst", NullValueHandling = NullValueHandling.Ignore)]
        public int? Burst { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTrafficLimitConfig {\n");
            sb.Append("  qps: ").Append(Qps).Append("\n");
            sb.Append("  perSourceIpQps: ").Append(PerSourceIpQps).Append("\n");
            sb.Append("  burst: ").Append(Burst).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTrafficLimitConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTrafficLimitConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Qps == input.Qps ||
                    (this.Qps != null &&
                    this.Qps.Equals(input.Qps))
                ) && 
                (
                    this.PerSourceIpQps == input.PerSourceIpQps ||
                    (this.PerSourceIpQps != null &&
                    this.PerSourceIpQps.Equals(input.PerSourceIpQps))
                ) && 
                (
                    this.Burst == input.Burst ||
                    (this.Burst != null &&
                    this.Burst.Equals(input.Burst))
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
                if (this.Qps != null)
                    hashCode = hashCode * 59 + this.Qps.GetHashCode();
                if (this.PerSourceIpQps != null)
                    hashCode = hashCode * 59 + this.PerSourceIpQps.GetHashCode();
                if (this.Burst != null)
                    hashCode = hashCode * 59 + this.Burst.GetHashCode();
                return hashCode;
            }
        }
    }
}
