using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListVolumeTypeResponse : SdkResponse
    {

        /// <summary>
        /// 磁盘列表。
        /// </summary>
        [JsonProperty("volume_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeTypeInfo> VolumeTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVolumeTypeResponse {\n");
            sb.Append("  volumeTypes: ").Append(VolumeTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVolumeTypeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVolumeTypeResponse input)
        {
            if (input == null) return false;
            if (this.VolumeTypes != input.VolumeTypes || (this.VolumeTypes != null && input.VolumeTypes != null && !this.VolumeTypes.SequenceEqual(input.VolumeTypes))) return false;

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
                if (this.VolumeTypes != null) hashCode = hashCode * 59 + this.VolumeTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
