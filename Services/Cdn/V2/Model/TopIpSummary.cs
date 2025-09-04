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
    /// top ip 详情数据
    /// </summary>
    public class TopIpSummary 
    {

        /// <summary>
        /// IP值。
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 对应查询类型的值。（流量单位：Byte）
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        /// <summary>
        /// 该IP的流量(或请求数)占当前查询条件下总流量(或请求数)的比例。保留4位小数
        /// </summary>
        [JsonProperty("ratio", NullValueHandling = NullValueHandling.Ignore)]
        public double? Ratio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopIpSummary {\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  ratio: ").Append(Ratio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopIpSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopIpSummary input)
        {
            if (input == null) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Ratio != input.Ratio || (this.Ratio != null && !this.Ratio.Equals(input.Ratio))) return false;

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
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Ratio != null) hashCode = hashCode * 59 + this.Ratio.GetHashCode();
                return hashCode;
            }
        }
    }
}
