using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 用例状态数据
    /// </summary>
    public class QueryCasesStatusResponseV2 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("casesStatusJA", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> CasesStatusJA { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryCasesStatusResponseV2 {\n");
            sb.Append("  casesStatusJA: ").Append(CasesStatusJA).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryCasesStatusResponseV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryCasesStatusResponseV2 input)
        {
            if (input == null) return false;
            if (this.CasesStatusJA != input.CasesStatusJA || (this.CasesStatusJA != null && input.CasesStatusJA != null && !this.CasesStatusJA.SequenceEqual(input.CasesStatusJA))) return false;

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
                if (this.CasesStatusJA != null) hashCode = hashCode * 59 + this.CasesStatusJA.GetHashCode();
                return hashCode;
            }
        }
    }
}
