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
    public class ListTableVolumesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 数据库表占用空间列表。 
        /// </summary>
        [JsonProperty("table_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<TableVolumeResult> TableVolumes { get; set; }

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
            sb.Append("class ListTableVolumesResponse {\n");
            sb.Append("  tableVolumes: ").Append(TableVolumes).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTableVolumesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTableVolumesResponse input)
        {
            if (input == null) return false;
            if (this.TableVolumes != input.TableVolumes || (this.TableVolumes != null && input.TableVolumes != null && !this.TableVolumes.SequenceEqual(input.TableVolumes))) return false;
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
                if (this.TableVolumes != null) hashCode = hashCode * 59 + this.TableVolumes.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
