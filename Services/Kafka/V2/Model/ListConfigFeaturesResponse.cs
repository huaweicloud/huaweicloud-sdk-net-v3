using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListConfigFeaturesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 特性列表。
        /// </summary>
        [JsonProperty("features", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListConfigFeatures> Features { get; set; }

        /// <summary>
        /// **参数解释**： 总特性数量。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("totalRecord", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRecord { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConfigFeaturesResponse {\n");
            sb.Append("  features: ").Append(Features).Append("\n");
            sb.Append("  totalRecord: ").Append(TotalRecord).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConfigFeaturesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConfigFeaturesResponse input)
        {
            if (input == null) return false;
            if (this.Features != input.Features || (this.Features != null && input.Features != null && !this.Features.SequenceEqual(input.Features))) return false;
            if (this.TotalRecord != input.TotalRecord || (this.TotalRecord != null && !this.TotalRecord.Equals(input.TotalRecord))) return false;

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
                if (this.Features != null) hashCode = hashCode * 59 + this.Features.GetHashCode();
                if (this.TotalRecord != null) hashCode = hashCode * 59 + this.TotalRecord.GetHashCode();
                return hashCode;
            }
        }
    }
}
