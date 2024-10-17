using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 云服务器挂载磁盘信息。
    /// </summary>
    public class VolumeAttach 
    {

        /// <summary>
        /// 云磁盘ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 一个标志，指示在删除服务器时是否删除附加的卷。 默认情况下，这是False
        /// </summary>
        [JsonProperty("delete_on_termination", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteOnTermination { get; set; }

        /// <summary>
        /// 挂载点
        /// </summary>
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// 盘在云服务器上的挂载顺序，0表示启动盘。
        /// </summary>
        [JsonProperty("bootIndex", NullValueHandling = NullValueHandling.Ignore)]
        public string BootIndex { get; set; }

        /// <summary>
        /// 云盘大小（单位：GB）。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeAttach {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  deleteOnTermination: ").Append(DeleteOnTermination).Append("\n");
            sb.Append("  device: ").Append(Device).Append("\n");
            sb.Append("  bootIndex: ").Append(BootIndex).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumeAttach);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeAttach input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DeleteOnTermination != input.DeleteOnTermination || (this.DeleteOnTermination != null && !this.DeleteOnTermination.Equals(input.DeleteOnTermination))) return false;
            if (this.Device != input.Device || (this.Device != null && !this.Device.Equals(input.Device))) return false;
            if (this.BootIndex != input.BootIndex || (this.BootIndex != null && !this.BootIndex.Equals(input.BootIndex))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DeleteOnTermination != null) hashCode = hashCode * 59 + this.DeleteOnTermination.GetHashCode();
                if (this.Device != null) hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.BootIndex != null) hashCode = hashCode * 59 + this.BootIndex.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }
}
