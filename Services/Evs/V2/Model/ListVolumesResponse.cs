using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListVolumesResponse : SdkResponse
    {

        /// <summary>
        /// 查询到的云硬盘总数量，不受分页影响。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 云硬盘列表查询位置标记。如果本次查询只返回部分列表信息时，会返回查询到的当前磁盘mark标记的url，可以继续使用这个url查询剩余列表信息。
        /// </summary>
        [JsonProperty("volumes_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Link> VolumesLinks { get; set; }

        /// <summary>
        /// 查询请求返回的云硬盘列表。
        /// </summary>
        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeDetail> Volumes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVolumesResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  volumesLinks: ").Append(VolumesLinks).Append("\n");
            sb.Append("  volumes: ").Append(Volumes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVolumesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVolumesResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.VolumesLinks != input.VolumesLinks || (this.VolumesLinks != null && input.VolumesLinks != null && !this.VolumesLinks.SequenceEqual(input.VolumesLinks))) return false;
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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.VolumesLinks != null) hashCode = hashCode * 59 + this.VolumesLinks.GetHashCode();
                if (this.Volumes != null) hashCode = hashCode * 59 + this.Volumes.GetHashCode();
                return hashCode;
            }
        }
    }
}
