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
    /// 
    /// </summary>
    public class BatchAttachSharableVolumesOption 
    {

        /// <summary>
        /// 共享磁盘需要挂载的弹性云服务器ID。
        /// </summary>
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 磁盘挂载点。  &gt; 说明： &gt;  &gt; - 新增加的磁盘挂载点不能和已有的磁盘挂载点相同。 &gt; - 对于采用XEN虚拟化类型的弹性云服务器，device为必选参数；系统盘挂载点请指定/dev/sda；数据盘挂载点请按英文字母顺序依次指定，如/dev/sdb，/dev/sdc，如果指定了以“/dev/vd”开头的挂载点，系统默认改为“/dev/sd”。 &gt; - 对于采用KVM虚拟化类型的弹性云服务器，系统盘挂载点请指定/dev/vda；数据盘挂载点可不用指定，也可按英文字母顺序依次指定，如/dev/vdb，/dev/vdc，如果指定了以“/dev/sd”开头的挂载点，系统默认改为“/dev/vd”。
        /// </summary>
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAttachSharableVolumesOption {\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  device: ").Append(Device).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAttachSharableVolumesOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAttachSharableVolumesOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                return hashCode;
            }
        }
    }
}
