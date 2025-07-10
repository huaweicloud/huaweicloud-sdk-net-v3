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
    /// 增加磁盘请求。
    /// </summary>
    public class AddDesktopsVolumesReq 
    {

        /// <summary>
        /// 新增磁盘参数。
        /// </summary>
        [JsonProperty("desktop_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddDesktopVolumesReq> DesktopVolumes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDesktopsVolumesReq {\n");
            sb.Append("  desktopVolumes: ").Append(DesktopVolumes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddDesktopsVolumesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDesktopsVolumesReq input)
        {
            if (input == null) return false;
            if (this.DesktopVolumes != input.DesktopVolumes || (this.DesktopVolumes != null && input.DesktopVolumes != null && !this.DesktopVolumes.SequenceEqual(input.DesktopVolumes))) return false;

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
                if (this.DesktopVolumes != null) hashCode = hashCode * 59 + this.DesktopVolumes.GetHashCode();
                return hashCode;
            }
        }
    }
}
