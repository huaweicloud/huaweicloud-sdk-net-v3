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
    /// Response Object
    /// </summary>
    public class ShowSlowSqlPlanResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 执行计划信息。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("gs_explain", NullValueHandling = NullValueHandling.Ignore)]
        public string GsExplain { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSlowSqlPlanResponse {\n");
            sb.Append("  gsExplain: ").Append(GsExplain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSlowSqlPlanResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSlowSqlPlanResponse input)
        {
            if (input == null) return false;
            if (this.GsExplain != input.GsExplain || (this.GsExplain != null && !this.GsExplain.Equals(input.GsExplain))) return false;

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
                if (this.GsExplain != null) hashCode = hashCode * 59 + this.GsExplain.GetHashCode();
                return hashCode;
            }
        }
    }
}
