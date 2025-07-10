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
    public class ListDesktopActionsResponse : SdkResponse
    {

        /// <summary>
        /// 桌面开关列表。
        /// </summary>
        [JsonProperty("desktop_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopAction> DesktopActions { get; set; }

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
            sb.Append("class ListDesktopActionsResponse {\n");
            sb.Append("  desktopActions: ").Append(DesktopActions).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDesktopActionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDesktopActionsResponse input)
        {
            if (input == null) return false;
            if (this.DesktopActions != input.DesktopActions || (this.DesktopActions != null && input.DesktopActions != null && !this.DesktopActions.SequenceEqual(input.DesktopActions))) return false;
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
                if (this.DesktopActions != null) hashCode = hashCode * 59 + this.DesktopActions.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
