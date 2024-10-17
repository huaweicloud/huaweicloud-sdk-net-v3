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
    public class ModifyEpsQuotaRequestBody 
    {

        /// <summary>
        /// 需要修改的企业配额列表。
        /// </summary>
        [JsonProperty("eps_quotas", NullValueHandling = NullValueHandling.Ignore)]
        public List<EpsQuotasOption> EpsQuotas { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyEpsQuotaRequestBody {\n");
            sb.Append("  epsQuotas: ").Append(EpsQuotas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyEpsQuotaRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyEpsQuotaRequestBody input)
        {
            if (input == null) return false;
            if (this.EpsQuotas != input.EpsQuotas || (this.EpsQuotas != null && input.EpsQuotas != null && !this.EpsQuotas.SequenceEqual(input.EpsQuotas))) return false;

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
                if (this.EpsQuotas != null) hashCode = hashCode * 59 + this.EpsQuotas.GetHashCode();
                return hashCode;
            }
        }
    }
}
