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
    public class ListUsedDesktopInfoResponse : SdkResponse
    {

        /// <summary>
        /// 桌面使用信息（以桌面Id划分）。
        /// </summary>
        [JsonProperty("desktop_used_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopUsedHoursInfo> DesktopUsedInfoList { get; set; }

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
            sb.Append("class ListUsedDesktopInfoResponse {\n");
            sb.Append("  desktopUsedInfoList: ").Append(DesktopUsedInfoList).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUsedDesktopInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUsedDesktopInfoResponse input)
        {
            if (input == null) return false;
            if (this.DesktopUsedInfoList != input.DesktopUsedInfoList || (this.DesktopUsedInfoList != null && input.DesktopUsedInfoList != null && !this.DesktopUsedInfoList.SequenceEqual(input.DesktopUsedInfoList))) return false;
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
                if (this.DesktopUsedInfoList != null) hashCode = hashCode * 59 + this.DesktopUsedInfoList.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
