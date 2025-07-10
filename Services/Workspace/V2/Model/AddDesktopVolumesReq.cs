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
    /// 单个桌面添加磁盘参数。
    /// </summary>
    public class AddDesktopVolumesReq 
    {

        /// <summary>
        /// 桌面Id。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 待新增的磁盘信息，每个桌面的数据盘数量不超过10个。
        /// </summary>
        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Volume> Volumes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDesktopVolumesReq {\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  volumes: ").Append(Volumes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddDesktopVolumesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDesktopVolumesReq input)
        {
            if (input == null) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
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
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.Volumes != null) hashCode = hashCode * 59 + this.Volumes.GetHashCode();
                return hashCode;
            }
        }
    }
}
