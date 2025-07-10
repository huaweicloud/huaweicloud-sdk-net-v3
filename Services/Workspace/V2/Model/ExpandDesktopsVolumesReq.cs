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
    /// 扩容磁盘请求。
    /// </summary>
    public class ExpandDesktopsVolumesReq 
    {

        /// <summary>
        /// 扩容磁盘参数。
        /// </summary>
        [JsonProperty("desktop_volumes_expansion", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExpandVolumesReq> DesktopVolumesExpansion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpandDesktopsVolumesReq {\n");
            sb.Append("  desktopVolumesExpansion: ").Append(DesktopVolumesExpansion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExpandDesktopsVolumesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExpandDesktopsVolumesReq input)
        {
            if (input == null) return false;
            if (this.DesktopVolumesExpansion != input.DesktopVolumesExpansion || (this.DesktopVolumesExpansion != null && input.DesktopVolumesExpansion != null && !this.DesktopVolumesExpansion.SequenceEqual(input.DesktopVolumesExpansion))) return false;

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
                if (this.DesktopVolumesExpansion != null) hashCode = hashCode * 59 + this.DesktopVolumesExpansion.GetHashCode();
                return hashCode;
            }
        }
    }
}
