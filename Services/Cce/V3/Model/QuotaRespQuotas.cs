using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 模板配额
    /// </summary>
    public class QuotaRespQuotas 
    {

        /// <summary>
        /// 资源
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<QuotaRespQuotasResources> Resources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaRespQuotas {\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuotaRespQuotas);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuotaRespQuotas input)
        {
            if (input == null) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;

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
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                return hashCode;
            }
        }
    }
}
