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
    /// 扩容桌面池磁盘请求。
    /// </summary>
    public class ExpandDesktopPoolVolumesReq 
    {

        /// <summary>
        /// 扩容的桌面池磁盘列表。
        /// </summary>
        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeInfo> Volumes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpandDesktopPoolVolumesReq {\n");
            sb.Append("  volumes: ").Append(Volumes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExpandDesktopPoolVolumesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExpandDesktopPoolVolumesReq input)
        {
            if (input == null) return false;
            if (this.Volumes != input.Volumes || (this.Volumes != null && input.Volumes != null && !this.Volumes.SequenceEqual(input.Volumes))) return false;

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
                if (this.Volumes != null) hashCode = hashCode * 59 + this.Volumes.GetHashCode();
                return hashCode;
            }
        }
    }
}
