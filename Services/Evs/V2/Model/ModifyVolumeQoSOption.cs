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
    /// 
    /// </summary>
    public class ModifyVolumeQoSOption 
    {

        /// <summary>
        /// 修改后的云硬盘iops，只支持GPSSD2、ESSD2类型的云硬盘。  说明： 了解GPSSD2、ESSD2类型的iops大小范围，请参见 [云硬盘类型及性能介绍里面的云硬盘性能数据表](https://support.huaweicloud.com/productdesc-evs/zh-cn_topic_0044524691.html)。
        /// </summary>
        [JsonProperty("iops", NullValueHandling = NullValueHandling.Ignore)]
        public int? Iops { get; set; }

        /// <summary>
        /// 修改后的云硬盘吞吐量，单位是MiB/s，GPSSD2类型云盘必须填写，其他类型不能填写。  说明： 了解GPSSD2类型的吞吐量大小范围，请参见 [云硬盘类型及性能介绍里面的云硬盘性能数据表](https://support.huaweicloud.com/productdesc-evs/zh-cn_topic_0044524691.html)。
        /// </summary>
        [JsonProperty("throughput", NullValueHandling = NullValueHandling.Ignore)]
        public int? Throughput { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyVolumeQoSOption {\n");
            sb.Append("  iops: ").Append(Iops).Append("\n");
            sb.Append("  throughput: ").Append(Throughput).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyVolumeQoSOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyVolumeQoSOption input)
        {
            if (input == null) return false;
            if (this.Iops != input.Iops || (this.Iops != null && !this.Iops.Equals(input.Iops))) return false;
            if (this.Throughput != input.Throughput || (this.Throughput != null && !this.Throughput.Equals(input.Throughput))) return false;

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
                if (this.Iops != null) hashCode = hashCode * 59 + this.Iops.GetHashCode();
                if (this.Throughput != null) hashCode = hashCode * 59 + this.Throughput.GetHashCode();
                return hashCode;
            }
        }
    }
}
