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
    /// TOP100 Referer数据明细
    /// </summary>
    public class TopReferSummary 
    {

        /// <summary>
        /// referer值。
        /// </summary>
        [JsonProperty("refer", NullValueHandling = NullValueHandling.Ignore)]
        public string Refer { get; set; }

        /// <summary>
        /// 对应查询类型的值。（流量单位：Byte）
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopReferSummary {\n");
            sb.Append("  refer: ").Append(Refer).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopReferSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopReferSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Refer == input.Refer ||
                    (this.Refer != null &&
                    this.Refer.Equals(input.Refer))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Refer != null)
                    hashCode = hashCode * 59 + this.Refer.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
