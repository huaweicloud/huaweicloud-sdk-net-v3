using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckQuotaResponse : SdkResponse
    {

        /// <summary>
        /// 配额是否足够true：足够 false：不足。
        /// </summary>
        [JsonProperty("is_enough", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEnough { get; set; }

        /// <summary>
        /// 配额剩余数量信息。
        /// </summary>
        [JsonProperty("quota_remainder", NullValueHandling = NullValueHandling.Ignore)]
        public List<QuotaRemainderData> QuotaRemainder { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckQuotaResponse {\n");
            sb.Append("  isEnough: ").Append(IsEnough).Append("\n");
            sb.Append("  quotaRemainder: ").Append(QuotaRemainder).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckQuotaResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckQuotaResponse input)
        {
            if (input == null) return false;
            if (this.IsEnough != input.IsEnough || (this.IsEnough != null && !this.IsEnough.Equals(input.IsEnough))) return false;
            if (this.QuotaRemainder != input.QuotaRemainder || (this.QuotaRemainder != null && input.QuotaRemainder != null && !this.QuotaRemainder.SequenceEqual(input.QuotaRemainder))) return false;

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
                if (this.IsEnough != null) hashCode = hashCode * 59 + this.IsEnough.GetHashCode();
                if (this.QuotaRemainder != null) hashCode = hashCode * 59 + this.QuotaRemainder.GetHashCode();
                return hashCode;
            }
        }
    }
}
