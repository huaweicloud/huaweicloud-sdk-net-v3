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
    public class ListSchemaVolumesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 数据库schema占用空间列表 
        /// </summary>
        [JsonProperty("schema_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<SchemaVolumeResult> SchemaVolumes { get; set; }

        /// <summary>
        /// **参数解释**: 总数。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSchemaVolumesResponse {\n");
            sb.Append("  schemaVolumes: ").Append(SchemaVolumes).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSchemaVolumesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSchemaVolumesResponse input)
        {
            if (input == null) return false;
            if (this.SchemaVolumes != input.SchemaVolumes || (this.SchemaVolumes != null && input.SchemaVolumes != null && !this.SchemaVolumes.SequenceEqual(input.SchemaVolumes))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.SchemaVolumes != null) hashCode = hashCode * 59 + this.SchemaVolumes.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
