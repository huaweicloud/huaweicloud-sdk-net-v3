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
    public class ListWdrSnapshotsCollectResultsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 总记录数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// **参数解释**： WDR快照信息列表。
        /// </summary>
        [JsonProperty("wdr_snapshots", NullValueHandling = NullValueHandling.Ignore)]
        public List<CollectedWdrSnapshotInfoResult> WdrSnapshots { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWdrSnapshotsCollectResultsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  wdrSnapshots: ").Append(WdrSnapshots).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWdrSnapshotsCollectResultsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWdrSnapshotsCollectResultsResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.WdrSnapshots != input.WdrSnapshots || (this.WdrSnapshots != null && input.WdrSnapshots != null && !this.WdrSnapshots.SequenceEqual(input.WdrSnapshots))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.WdrSnapshots != null) hashCode = hashCode * 59 + this.WdrSnapshots.GetHashCode();
                return hashCode;
            }
        }
    }
}
