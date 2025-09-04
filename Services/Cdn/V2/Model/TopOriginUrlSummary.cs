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
    /// top origin url 详情数据
    /// </summary>
    public class TopOriginUrlSummary 
    {

        /// <summary>
        /// 回源url名称
        /// </summary>
        [JsonProperty("origin_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginUrl { get; set; }

        /// <summary>
        /// 对应查询类型的值。（流量单位：Byte）
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        /// <summary>
        /// 该origin url的流量(或请求数)占当前查询条件下总流量(或请求数)的比例。保留4位小数
        /// </summary>
        [JsonProperty("ratio", NullValueHandling = NullValueHandling.Ignore)]
        public double? Ratio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopOriginUrlSummary {\n");
            sb.Append("  originUrl: ").Append(OriginUrl).Append("\n");
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
            return this.Equals(input as TopOriginUrlSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopOriginUrlSummary input)
        {
            if (input == null) return false;
            if (this.OriginUrl != input.OriginUrl || (this.OriginUrl != null && !this.OriginUrl.Equals(input.OriginUrl))) return false;
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
                if (this.OriginUrl != null) hashCode = hashCode * 59 + this.OriginUrl.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Ratio != null) hashCode = hashCode * 59 + this.Ratio.GetHashCode();
                return hashCode;
            }
        }
    }
}
