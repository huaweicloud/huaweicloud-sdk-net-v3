using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// volumeAttachment数据结构说明
    /// </summary>
    public class VolumeAttachment 
    {

        /// <summary>
        /// 要挂卷的卷ID。可以从云硬盘控制台查询，或者通过调用“查询云硬盘列表”API获取。
        /// </summary>
        [JsonProperty("volumeId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? VolumeId { get; set; }

        /// <summary>
        /// 磁盘挂载点，如/dev/sda、/dev/sdb。新增加的磁盘挂载点不能和已有的磁盘挂载点相同。需要根据已有设备名称顺序指定，否则不写device或device的值为空时，由系统自动生成。
        /// </summary>
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeAttachment {\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("  device: ").Append(Device).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumeAttachment);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeAttachment input)
        {
            if (input == null) return false;
            if (this.VolumeId != input.VolumeId || (this.VolumeId != null && !this.VolumeId.Equals(input.VolumeId))) return false;
            if (this.Device != input.Device || (this.Device != null && !this.Device.Equals(input.Device))) return false;

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
                if (this.VolumeId != null) hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                if (this.Device != null) hashCode = hashCode * 59 + this.Device.GetHashCode();
                return hashCode;
            }
        }
    }
}
