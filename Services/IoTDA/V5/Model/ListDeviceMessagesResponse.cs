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
    /// Response Object
    /// </summary>
    public class ListDeviceMessagesResponse : SdkResponse
    {

        /// <summary>
        /// 设备ID，用于唯一标识一个设备，在注册设备时由物联网平台分配获得。
        /// </summary>
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备消息列表。
        /// </summary>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeviceMessage> Messages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDeviceMessagesResponse {\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  messages: ").Append(Messages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDeviceMessagesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDeviceMessagesResponse input)
        {
            if (input == null) return false;
            if (this.DeviceId != input.DeviceId || (this.DeviceId != null && !this.DeviceId.Equals(input.DeviceId))) return false;
            if (this.Messages != input.Messages || (this.Messages != null && input.Messages != null && !this.Messages.SequenceEqual(input.Messages))) return false;

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
                if (this.DeviceId != null) hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.Messages != null) hashCode = hashCode * 59 + this.Messages.GetHashCode();
                return hashCode;
            }
        }
    }
}
