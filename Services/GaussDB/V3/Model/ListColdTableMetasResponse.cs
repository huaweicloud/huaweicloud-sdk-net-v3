using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListColdTableMetasResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  冷表元信息记录总数。  **取值范围**：  ≥0。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**：  冷表元记录列表。
        /// </summary>
        [JsonProperty("meta_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<ColdTableMetaInfo> MetaInfo { get; set; }

        /// <summary>
        /// **参数解释**：  冷表数据量总大小（MB）。  **取值范围**：  ≥0。
        /// </summary>
        [JsonProperty("total_data_size", NullValueHandling = NullValueHandling.Ignore)]
        public float? TotalDataSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListColdTableMetasResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  metaInfo: ").Append(MetaInfo).Append("\n");
            sb.Append("  totalDataSize: ").Append(TotalDataSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListColdTableMetasResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListColdTableMetasResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.MetaInfo != input.MetaInfo || (this.MetaInfo != null && input.MetaInfo != null && !this.MetaInfo.SequenceEqual(input.MetaInfo))) return false;
            if (this.TotalDataSize != input.TotalDataSize || (this.TotalDataSize != null && !this.TotalDataSize.Equals(input.TotalDataSize))) return false;

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
                if (this.MetaInfo != null) hashCode = hashCode * 59 + this.MetaInfo.GetHashCode();
                if (this.TotalDataSize != null) hashCode = hashCode * 59 + this.TotalDataSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
