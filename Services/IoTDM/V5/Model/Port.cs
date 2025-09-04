using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDM.V5.Model
{
    /// <summary>
    /// 企业版端口信息。创建企业版实例时必填。 
    /// </summary>
    public class Port 
    {

        /// <summary>
        /// **参数说明**：应用接入HTTPS协议端口，默认值：443。 
        /// </summary>
        [JsonProperty("app_https_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppHttpsPort { get; set; }

        /// <summary>
        /// **参数说明**：应用接入AMQP协议端口, 默认值：5671。 
        /// </summary>
        [JsonProperty("app_amqps_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppAmqpsPort { get; set; }

        /// <summary>
        /// **参数说明**：应用接入MQTTS协议端口, 默认值：8883。 
        /// </summary>
        [JsonProperty("app_mqtts_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppMqttsPort { get; set; }

        /// <summary>
        /// **参数说明**：设备接入COAP协议端口, 默认值：5683。 
        /// </summary>
        [JsonProperty("device_coap_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeviceCoapPort { get; set; }

        /// <summary>
        /// **参数说明**：设备接入COAPS协议端口, 默认值：5684。 
        /// </summary>
        [JsonProperty("device_coaps_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeviceCoapsPort { get; set; }

        /// <summary>
        /// **参数说明**：设备接入MQTT协议端口, 默认值：1883。 
        /// </summary>
        [JsonProperty("device_mqtt_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeviceMqttPort { get; set; }

        /// <summary>
        /// **参数说明**：设备接入MQTTS协议端口, 默认值：8883。 
        /// </summary>
        [JsonProperty("device_mqtts_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeviceMqttsPort { get; set; }

        /// <summary>
        /// **参数说明**：设备接入HTTPS协议端口, 默认值：443。 
        /// </summary>
        [JsonProperty("device_https_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeviceHttpsPort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Port {\n");
            sb.Append("  appHttpsPort: ").Append(AppHttpsPort).Append("\n");
            sb.Append("  appAmqpsPort: ").Append(AppAmqpsPort).Append("\n");
            sb.Append("  appMqttsPort: ").Append(AppMqttsPort).Append("\n");
            sb.Append("  deviceCoapPort: ").Append(DeviceCoapPort).Append("\n");
            sb.Append("  deviceCoapsPort: ").Append(DeviceCoapsPort).Append("\n");
            sb.Append("  deviceMqttPort: ").Append(DeviceMqttPort).Append("\n");
            sb.Append("  deviceMqttsPort: ").Append(DeviceMqttsPort).Append("\n");
            sb.Append("  deviceHttpsPort: ").Append(DeviceHttpsPort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Port);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Port input)
        {
            if (input == null) return false;
            if (this.AppHttpsPort != input.AppHttpsPort || (this.AppHttpsPort != null && !this.AppHttpsPort.Equals(input.AppHttpsPort))) return false;
            if (this.AppAmqpsPort != input.AppAmqpsPort || (this.AppAmqpsPort != null && !this.AppAmqpsPort.Equals(input.AppAmqpsPort))) return false;
            if (this.AppMqttsPort != input.AppMqttsPort || (this.AppMqttsPort != null && !this.AppMqttsPort.Equals(input.AppMqttsPort))) return false;
            if (this.DeviceCoapPort != input.DeviceCoapPort || (this.DeviceCoapPort != null && !this.DeviceCoapPort.Equals(input.DeviceCoapPort))) return false;
            if (this.DeviceCoapsPort != input.DeviceCoapsPort || (this.DeviceCoapsPort != null && !this.DeviceCoapsPort.Equals(input.DeviceCoapsPort))) return false;
            if (this.DeviceMqttPort != input.DeviceMqttPort || (this.DeviceMqttPort != null && !this.DeviceMqttPort.Equals(input.DeviceMqttPort))) return false;
            if (this.DeviceMqttsPort != input.DeviceMqttsPort || (this.DeviceMqttsPort != null && !this.DeviceMqttsPort.Equals(input.DeviceMqttsPort))) return false;
            if (this.DeviceHttpsPort != input.DeviceHttpsPort || (this.DeviceHttpsPort != null && !this.DeviceHttpsPort.Equals(input.DeviceHttpsPort))) return false;

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
                if (this.AppHttpsPort != null) hashCode = hashCode * 59 + this.AppHttpsPort.GetHashCode();
                if (this.AppAmqpsPort != null) hashCode = hashCode * 59 + this.AppAmqpsPort.GetHashCode();
                if (this.AppMqttsPort != null) hashCode = hashCode * 59 + this.AppMqttsPort.GetHashCode();
                if (this.DeviceCoapPort != null) hashCode = hashCode * 59 + this.DeviceCoapPort.GetHashCode();
                if (this.DeviceCoapsPort != null) hashCode = hashCode * 59 + this.DeviceCoapsPort.GetHashCode();
                if (this.DeviceMqttPort != null) hashCode = hashCode * 59 + this.DeviceMqttPort.GetHashCode();
                if (this.DeviceMqttsPort != null) hashCode = hashCode * 59 + this.DeviceMqttsPort.GetHashCode();
                if (this.DeviceHttpsPort != null) hashCode = hashCode * 59 + this.DeviceHttpsPort.GetHashCode();
                return hashCode;
            }
        }
    }
}
