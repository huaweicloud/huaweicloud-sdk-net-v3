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
    public class ShowExpansionParametersResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 参数信息。
        /// </summary>
        [JsonProperty("expansion_parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExpansionParameterResult> ExpansionParameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowExpansionParametersResponse {\n");
            sb.Append("  expansionParameters: ").Append(ExpansionParameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowExpansionParametersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowExpansionParametersResponse input)
        {
            if (input == null) return false;
            if (this.ExpansionParameters != input.ExpansionParameters || (this.ExpansionParameters != null && input.ExpansionParameters != null && !this.ExpansionParameters.SequenceEqual(input.ExpansionParameters))) return false;

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
                if (this.ExpansionParameters != null) hashCode = hashCode * 59 + this.ExpansionParameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
