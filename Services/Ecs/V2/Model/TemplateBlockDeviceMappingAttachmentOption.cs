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
    public class TemplateBlockDeviceMappingAttachmentOption 
    {

        /// <summary>
        /// 盘在虚拟机上的挂载顺序，0表示启动盘
        /// </summary>
        [JsonProperty("boot_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? BootIndex { get; set; }

        /// <summary>
        /// 卷是否随实例一同释放 默认系统盘设置为true随实例释放，数据盘设置为false不随实例释放
        /// </summary>
        [JsonProperty("delete_on_termination", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteOnTermination { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateBlockDeviceMappingAttachmentOption {\n");
            sb.Append("  bootIndex: ").Append(BootIndex).Append("\n");
            sb.Append("  deleteOnTermination: ").Append(DeleteOnTermination).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateBlockDeviceMappingAttachmentOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateBlockDeviceMappingAttachmentOption input)
        {
            if (input == null) return false;
            if (this.BootIndex != input.BootIndex || (this.BootIndex != null && !this.BootIndex.Equals(input.BootIndex))) return false;
            if (this.DeleteOnTermination != input.DeleteOnTermination || (this.DeleteOnTermination != null && !this.DeleteOnTermination.Equals(input.DeleteOnTermination))) return false;

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
                if (this.BootIndex != null) hashCode = hashCode * 59 + this.BootIndex.GetHashCode();
                if (this.DeleteOnTermination != null) hashCode = hashCode * 59 + this.DeleteOnTermination.GetHashCode();
                return hashCode;
            }
        }
    }
}
