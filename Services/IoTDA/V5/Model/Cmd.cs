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
    /// 给设备下发命令的命令内容，在动作的type为“DEVICE_CMD”时有效，且为必选
    /// </summary>
    public class Cmd 
    {

        /// <summary>
        /// **参数说明**：设备命令名称，在设备关联的产品模型中定义。
        /// </summary>
        [JsonProperty("command_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandName { get; set; }

        /// <summary>
        /// **参数说明**：设备命令参数，Json格式。 使用LWM2M协议设备命令示例：{\&quot;value\&quot;:\&quot;1\&quot;}，里面是一个个健值对，每个健都是产品模型中命令的参数名（paraName）。 使用MQTT协议设备命令示例：{\&quot;header\&quot;: {\&quot;mode\&quot;: \&quot;ACK\&quot;,\&quot;from\&quot;: \&quot;/users/testUser\&quot;,\&quot;method\&quot;: \&quot;SET_TEMPERATURE_READ_PERIOD\&quot;,\&quot;to\&quot;:\&quot;/devices/{device_id}/services/{service_id}\&quot;},\&quot;body\&quot;: {\&quot;value\&quot; : \&quot;1\&quot;}}。 - mode：必选，设备收到命令后是否需要回复确认消息，默认为ACK模式。ACK表示需要回复确认消息，NOACK表示不需要回复确认消息，其它值无效。 - from：可选，命令发送方的地址。App发起请求时格式为/users/{userId} ，应用服务器发起请求时格式为/{serviceName}，物联网平台发起请求时格式为/cloud/{serviceName}。 - to：可选，命令接收方的地址，格式为/devices/{device_id}/services/{service_id}。 - method：可选，产品模型中定义的命令名称。 - body：可选，命令的消息体，里面是一个个键值对，每个键都是产品模型中命令的参数名（paraName）。具体格式需要应用和设备约定。
        /// </summary>
        [JsonProperty("command_body", NullValueHandling = NullValueHandling.Ignore)]
        public Object CommandBody { get; set; }

        /// <summary>
        /// **参数说明**：设备命令所属的设备服务ID，在设备关联的产品模型中定义。
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// **参数说明**：设备命令的缓存时间，单位为秒，表示物联网平台在把命令下发给设备前缓存命令的有效时间，超过这个时间后命令将不再下发，默认值为172800s（48小时）。 如果buffer_timeout设置为0，则无论物联网平台上设置的命令下发模式是什么，该命令都会立即下发给设备。
        /// </summary>
        [JsonProperty("buffer_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? BufferTimeout { get; set; }

        /// <summary>
        /// **参数说明**：命令响应的有效时间，单位为秒，表示设备接收到命令后，在response_timeout时间内响应有效，超过这个时间未收到命令的响应，则认为命令响应超时，默认值为1800s。
        /// </summary>
        [JsonProperty("response_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResponseTimeout { get; set; }

        /// <summary>
        /// **参数说明**：设备命令的下发模式，仅当buffer_timeout的值大于0时有效。 - ACTIVE：主动模式，物联网平台主动将命令下发给设备。 - PASSIVE：被动模式，物联网平台创建设备命令后，会直接缓存命令。等到设备再次上线或者上报上一条命令的执行结果后才下发命令。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cmd {\n");
            sb.Append("  commandName: ").Append(CommandName).Append("\n");
            sb.Append("  commandBody: ").Append(CommandBody).Append("\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  bufferTimeout: ").Append(BufferTimeout).Append("\n");
            sb.Append("  responseTimeout: ").Append(ResponseTimeout).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Cmd);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Cmd input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CommandName == input.CommandName ||
                    (this.CommandName != null &&
                    this.CommandName.Equals(input.CommandName))
                ) && 
                (
                    this.CommandBody == input.CommandBody ||
                    (this.CommandBody != null &&
                    this.CommandBody.Equals(input.CommandBody))
                ) && 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.BufferTimeout == input.BufferTimeout ||
                    (this.BufferTimeout != null &&
                    this.BufferTimeout.Equals(input.BufferTimeout))
                ) && 
                (
                    this.ResponseTimeout == input.ResponseTimeout ||
                    (this.ResponseTimeout != null &&
                    this.ResponseTimeout.Equals(input.ResponseTimeout))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
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
                if (this.CommandName != null)
                    hashCode = hashCode * 59 + this.CommandName.GetHashCode();
                if (this.CommandBody != null)
                    hashCode = hashCode * 59 + this.CommandBody.GetHashCode();
                if (this.ServiceId != null)
                    hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.BufferTimeout != null)
                    hashCode = hashCode * 59 + this.BufferTimeout.GetHashCode();
                if (this.ResponseTimeout != null)
                    hashCode = hashCode * 59 + this.ResponseTimeout.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
