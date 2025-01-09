using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDesktopSnapshotResponse : SdkResponse
    {

        /// <summary>
        /// 桌面快照详情列表。
        /// </summary>
        [JsonProperty("desktop_snapshots", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopSnapshotDetailInfo> DesktopSnapshots { get; set; }

        /// <summary>
        /// 桌面快照总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDesktopSnapshotResponse {\n");
            sb.Append("  desktopSnapshots: ").Append(DesktopSnapshots).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDesktopSnapshotResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDesktopSnapshotResponse input)
        {
            if (input == null) return false;
            if (this.DesktopSnapshots != input.DesktopSnapshots || (this.DesktopSnapshots != null && input.DesktopSnapshots != null && !this.DesktopSnapshots.SequenceEqual(input.DesktopSnapshots))) return false;
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
                if (this.DesktopSnapshots != null) hashCode = hashCode * 59 + this.DesktopSnapshots.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
