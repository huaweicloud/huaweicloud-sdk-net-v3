using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 发布的设备信息。
    /// </summary>
    public class PublishDeviceResponseDTO 
    {

        /// <summary>
        /// 设备用户ID。
        /// </summary>
        [JsonProperty("deviceUserId", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceUserId { get; set; }

        /// <summary>
        /// 设备名称。
        /// </summary>
        [JsonProperty("deviceName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublishDeviceResponseDTO {\n");
            sb.Append("  deviceUserId: ").Append(DeviceUserId).Append("\n");
            sb.Append("  deviceName: ").Append(DeviceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublishDeviceResponseDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublishDeviceResponseDTO input)
        {
            if (input == null) return false;
            if (this.DeviceUserId != input.DeviceUserId || (this.DeviceUserId != null && !this.DeviceUserId.Equals(input.DeviceUserId))) return false;
            if (this.DeviceName != input.DeviceName || (this.DeviceName != null && !this.DeviceName.Equals(input.DeviceName))) return false;

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
                if (this.DeviceUserId != null) hashCode = hashCode * 59 + this.DeviceUserId.GetHashCode();
                if (this.DeviceName != null) hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
