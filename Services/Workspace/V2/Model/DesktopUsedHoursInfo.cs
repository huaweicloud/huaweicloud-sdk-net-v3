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
    /// 桌面使用时间信息。
    /// </summary>
    public class DesktopUsedHoursInfo 
    {

        /// <summary>
        /// 桌面Id。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 使用的用户。
        /// </summary>
        [JsonProperty("desktop_username", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopUsername { get; set; }

        /// <summary>
        /// 桌面使用时间列表。
        /// </summary>
        [JsonProperty("used_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopUsedInfo> UsedInfoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopUsedHoursInfo {\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  desktopUsername: ").Append(DesktopUsername).Append("\n");
            sb.Append("  usedInfoList: ").Append(UsedInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesktopUsedHoursInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesktopUsedHoursInfo input)
        {
            if (input == null) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.DesktopUsername != input.DesktopUsername || (this.DesktopUsername != null && !this.DesktopUsername.Equals(input.DesktopUsername))) return false;
            if (this.UsedInfoList != input.UsedInfoList || (this.UsedInfoList != null && input.UsedInfoList != null && !this.UsedInfoList.SequenceEqual(input.UsedInfoList))) return false;

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
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.DesktopUsername != null) hashCode = hashCode * 59 + this.DesktopUsername.GetHashCode();
                if (this.UsedInfoList != null) hashCode = hashCode * 59 + this.UsedInfoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
