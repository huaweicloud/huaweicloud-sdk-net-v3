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
    /// 参数解释：后端服务器组基于部分DST CID的多径分发策略
    /// </summary>
    public class QuicCidHashStrategy 
    {

        /// <summary>
        /// 参数解释：仅当负载均衡算法为QUIC_CID的时候才生效，表示hash的时候取CID的长度。 取值范围：1-20 默认取值：3
        /// </summary>
        [JsonProperty("len", NullValueHandling = NullValueHandling.Ignore)]
        public int? Len { get; set; }

        /// <summary>
        /// 参数解释：仅当负载均衡算法为QUIC_CID的时候才生效，表示hash的时候取CID的偏移量。 取值范围：0-19 默认取值：1
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuicCidHashStrategy {\n");
            sb.Append("  len: ").Append(Len).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuicCidHashStrategy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuicCidHashStrategy input)
        {
            if (input == null) return false;
            if (this.Len != input.Len || (this.Len != null && !this.Len.Equals(input.Len))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.Len != null) hashCode = hashCode * 59 + this.Len.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
