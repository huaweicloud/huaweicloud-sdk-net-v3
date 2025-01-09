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
    /// 删除桌面数据盘请求。
    /// </summary>
    public class DeleteVolumesReq 
    {

        /// <summary>
        /// 待删除的桌面数据盘ID列表。
        /// </summary>
        [JsonProperty("volume_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VolumeIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteVolumesReq {\n");
            sb.Append("  volumeIds: ").Append(VolumeIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteVolumesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteVolumesReq input)
        {
            if (input == null) return false;
            if (this.VolumeIds != input.VolumeIds || (this.VolumeIds != null && input.VolumeIds != null && !this.VolumeIds.SequenceEqual(input.VolumeIds))) return false;

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
                if (this.VolumeIds != null) hashCode = hashCode * 59 + this.VolumeIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
