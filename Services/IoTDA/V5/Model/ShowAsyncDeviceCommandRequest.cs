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
    /// Request Object
    /// </summary>
    public class ShowAsyncDeviceCommandRequest 
    {

        /// <summary>
        /// **参数说明**：下发命令的设备ID，用于唯一标识一个设备，在注册设备时由物联网平台分配获得。 **取值范围**：长度不超过128，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [SDKProperty("device_id", IsPath = true)]
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// **参数说明**：实例ID。物理多租下各实例的唯一标识，一般华为云租户无需携带该参数，仅在物理多租场景下从管理面访问API时需要携带该参数。
        /// </summary>
        [SDKProperty("Instance-Id", IsHeader = true)]
        [JsonProperty("Instance-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数说明**：下发命令的命令id，用于唯一标识一个消息，在下发命令时由物联网平台分配获得。 **取值范围**：长度不超过100，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [SDKProperty("command_id", IsPath = true)]
        [JsonProperty("command_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAsyncDeviceCommandRequest {\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  commandId: ").Append(CommandId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAsyncDeviceCommandRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAsyncDeviceCommandRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.CommandId == input.CommandId ||
                    (this.CommandId != null &&
                    this.CommandId.Equals(input.CommandId))
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
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.CommandId != null)
                    hashCode = hashCode * 59 + this.CommandId.GetHashCode();
                return hashCode;
            }
        }
    }
}
