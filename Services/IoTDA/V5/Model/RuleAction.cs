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
    /// 规则动作结构体
    /// </summary>
    public class RuleAction 
    {

        /// <summary>
        /// **参数说明**：规则动作的类型，端侧执行只支持下发设备命令消息类型。 **取值范围**： - DEVICE_CMD：下发设备命令消息类型。 - SMN_FORWARDING：发送SMN消息类型。 - DEVICE_ALARM：上报设备告警消息类型。当选择该类型时，condition中必须有DEVICE_DATA条件类型。该类型动作只能唯一。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("device_command", NullValueHandling = NullValueHandling.Ignore)]
        public ActionDeviceCommand DeviceCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("smn_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public ActionSmnForwarding SmnForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("device_alarm", NullValueHandling = NullValueHandling.Ignore)]
        public ActionDeviceAlarm DeviceAlarm { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleAction {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  deviceCommand: ").Append(DeviceCommand).Append("\n");
            sb.Append("  smnForwarding: ").Append(SmnForwarding).Append("\n");
            sb.Append("  deviceAlarm: ").Append(DeviceAlarm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DeviceCommand == input.DeviceCommand ||
                    (this.DeviceCommand != null &&
                    this.DeviceCommand.Equals(input.DeviceCommand))
                ) && 
                (
                    this.SmnForwarding == input.SmnForwarding ||
                    (this.SmnForwarding != null &&
                    this.SmnForwarding.Equals(input.SmnForwarding))
                ) && 
                (
                    this.DeviceAlarm == input.DeviceAlarm ||
                    (this.DeviceAlarm != null &&
                    this.DeviceAlarm.Equals(input.DeviceAlarm))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DeviceCommand != null)
                    hashCode = hashCode * 59 + this.DeviceCommand.GetHashCode();
                if (this.SmnForwarding != null)
                    hashCode = hashCode * 59 + this.SmnForwarding.GetHashCode();
                if (this.DeviceAlarm != null)
                    hashCode = hashCode * 59 + this.DeviceAlarm.GetHashCode();
                return hashCode;
            }
        }
    }
}
