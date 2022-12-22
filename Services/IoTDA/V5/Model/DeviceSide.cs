using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 端侧设备信息
    /// </summary>
    public class DeviceSide 
    {

        /// <summary>
        /// **参数说明**：端侧执行下发的目标设备ID列表。设备ID，用于唯一标识一个设备，在注册设备时由物联网平台分配获得。
        /// </summary>
        [JsonProperty("device_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeviceIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceSide {\n");
            sb.Append("  deviceIds: ").Append(DeviceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeviceSide);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeviceSide input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceIds == input.DeviceIds ||
                    this.DeviceIds != null &&
                    input.DeviceIds != null &&
                    this.DeviceIds.SequenceEqual(input.DeviceIds)
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
                if (this.DeviceIds != null)
                    hashCode = hashCode * 59 + this.DeviceIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
