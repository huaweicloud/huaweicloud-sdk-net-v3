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
    /// 下发设备命令消息结构
    /// </summary>
    public class ActionDeviceCommand 
    {

        /// <summary>
        /// **参数说明**：下发命令的设备ID。当创建设备数据规则时，若device_id为空，则命令下发给触发条件的设备。当创建定时规则时，不允许为空。 **取值范围**：长度不超过128，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cmd", NullValueHandling = NullValueHandling.Ignore)]
        public Cmd Cmd { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionDeviceCommand {\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  cmd: ").Append(Cmd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionDeviceCommand);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionDeviceCommand input)
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
                    this.Cmd == input.Cmd ||
                    (this.Cmd != null &&
                    this.Cmd.Equals(input.Cmd))
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
                if (this.Cmd != null)
                    hashCode = hashCode * 59 + this.Cmd.GetHashCode();
                return hashCode;
            }
        }
    }
}
