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
    /// 网络接口，网卡
    /// </summary>
    public class TemplateNetworkInterfaceAttachmentOption 
    {

        /// <summary>
        /// 加载顺序, 0代表主网卡
        /// </summary>
        [JsonProperty("device_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeviceIndex { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateNetworkInterfaceAttachmentOption {\n");
            sb.Append("  deviceIndex: ").Append(DeviceIndex).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateNetworkInterfaceAttachmentOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateNetworkInterfaceAttachmentOption input)
        {
            if (input == null) return false;
            if (this.DeviceIndex != input.DeviceIndex || (this.DeviceIndex != null && !this.DeviceIndex.Equals(input.DeviceIndex))) return false;

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
                if (this.DeviceIndex != null) hashCode = hashCode * 59 + this.DeviceIndex.GetHashCode();
                return hashCode;
            }
        }
    }
}
