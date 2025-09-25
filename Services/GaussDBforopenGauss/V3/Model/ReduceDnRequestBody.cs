using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReduceDnRequestBody 
    {

        /// <summary>
        /// **参数解释**: 缩容分片数量。 **约束限制**: 缩容分片数量需要大于0且集群至少保留一个分片。 **取值范围**: 大于0的正整数。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("contraction_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractionNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReduceDnRequestBody {\n");
            sb.Append("  contractionNum: ").Append(ContractionNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReduceDnRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReduceDnRequestBody input)
        {
            if (input == null) return false;
            if (this.ContractionNum != input.ContractionNum || (this.ContractionNum != null && !this.ContractionNum.Equals(input.ContractionNum))) return false;

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
                if (this.ContractionNum != null) hashCode = hashCode * 59 + this.ContractionNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
