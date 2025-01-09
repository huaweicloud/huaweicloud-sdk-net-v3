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
    public class ListUnusedDesktopsResponse : SdkResponse
    {

        /// <summary>
        /// 指定时间段内未使用桌面列表。
        /// </summary>
        [JsonProperty("unused_desktops", NullValueHandling = NullValueHandling.Ignore)]
        public List<UnusedDesktopInfo> UnusedDesktops { get; set; }

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUnusedDesktopsResponse {\n");
            sb.Append("  unusedDesktops: ").Append(UnusedDesktops).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUnusedDesktopsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUnusedDesktopsResponse input)
        {
            if (input == null) return false;
            if (this.UnusedDesktops != input.UnusedDesktops || (this.UnusedDesktops != null && input.UnusedDesktops != null && !this.UnusedDesktops.SequenceEqual(input.UnusedDesktops))) return false;
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
                if (this.UnusedDesktops != null) hashCode = hashCode * 59 + this.UnusedDesktops.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
