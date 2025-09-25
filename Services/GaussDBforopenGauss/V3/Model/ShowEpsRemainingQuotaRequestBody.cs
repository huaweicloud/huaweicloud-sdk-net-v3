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
    public class ShowEpsRemainingQuotaRequestBody 
    {

        /// <summary>
        /// **参数解释**: 企业项目ID列表。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("eps_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EpsTags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEpsRemainingQuotaRequestBody {\n");
            sb.Append("  epsTags: ").Append(EpsTags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEpsRemainingQuotaRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEpsRemainingQuotaRequestBody input)
        {
            if (input == null) return false;
            if (this.EpsTags != input.EpsTags || (this.EpsTags != null && input.EpsTags != null && !this.EpsTags.SequenceEqual(input.EpsTags))) return false;

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
                if (this.EpsTags != null) hashCode = hashCode * 59 + this.EpsTags.GetHashCode();
                return hashCode;
            }
        }
    }
}
