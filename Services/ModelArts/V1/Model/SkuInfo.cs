using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 计费信息。
    /// </summary>
    public class SkuInfo 
    {

        /// <summary>
        /// 计费码。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 计费时期。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 查询次数。
        /// </summary>
        [JsonProperty("queries_limit", NullValueHandling = NullValueHandling.Ignore)]
        public long? QueriesLimit { get; set; }

        /// <summary>
        /// 价格。
        /// </summary>
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public float? Price { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkuInfo {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  queriesLimit: ").Append(QueriesLimit).Append("\n");
            sb.Append("  price: ").Append(Price).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SkuInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SkuInfo input)
        {
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.QueriesLimit != input.QueriesLimit || (this.QueriesLimit != null && !this.QueriesLimit.Equals(input.QueriesLimit))) return false;
            if (this.Price != input.Price || (this.Price != null && !this.Price.Equals(input.Price))) return false;

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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.QueriesLimit != null) hashCode = hashCode * 59 + this.QueriesLimit.GetHashCode();
                if (this.Price != null) hashCode = hashCode * 59 + this.Price.GetHashCode();
                return hashCode;
            }
        }
    }
}
