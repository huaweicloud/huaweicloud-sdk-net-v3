using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstanceRetentionPoliciesResponse : SdkResponse
    {

        /// <summary>
        /// 策略总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 老化策略详情
        /// </summary>
        [JsonProperty("retentions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageRetention> Retentions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceRetentionPoliciesResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  retentions: ").Append(Retentions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceRetentionPoliciesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceRetentionPoliciesResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Retentions != input.Retentions || (this.Retentions != null && input.Retentions != null && !this.Retentions.SequenceEqual(input.Retentions))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Retentions != null) hashCode = hashCode * 59 + this.Retentions.GetHashCode();
                return hashCode;
            }
        }
    }
}
