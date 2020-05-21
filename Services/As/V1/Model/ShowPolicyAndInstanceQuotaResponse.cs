using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowPolicyAndInstanceQuotaResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AllQuotas", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyInstanceQuotas AllQuotas { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPolicyAndInstanceQuotaResponse {\n");
            sb.Append("  allQuotas: ").Append(AllQuotas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPolicyAndInstanceQuotaResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPolicyAndInstanceQuotaResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllQuotas == input.AllQuotas ||
                    (this.AllQuotas != null &&
                    this.AllQuotas.Equals(input.AllQuotas))
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
                if (this.AllQuotas != null)
                    hashCode = hashCode * 59 + this.AllQuotas.GetHashCode();
                return hashCode;
            }
        }
    }
}
