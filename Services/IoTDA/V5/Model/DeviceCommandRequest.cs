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
    /// 
    /// </summary>
    public class DeviceCommandRequest 
    {

        /// <summary>
        /// 设备命令所属的设备服务ID，在设备关联的产品模型中定义。
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// 设备命令名称，在设备关联的产品模型中定义。
        /// </summary>
        [JsonProperty("command_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandName { get; set; }

        /// <summary>
        /// 设备执行的命令，Json格式，里面是一个个健值对，如果serviceId不为空，每个健都是profile中命令的参数名（paraName）;如果serviceId为空则由用户自定义命令格式。设备命令示例：{\&quot;value\&quot;:\&quot;1\&quot;}，具体格式需要应用和设备约定。 
        /// </summary>
        [JsonProperty("paras", NullValueHandling = NullValueHandling.Ignore)]
        public Object Paras { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceCommandRequest {\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  commandName: ").Append(CommandName).Append("\n");
            sb.Append("  paras: ").Append(Paras).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeviceCommandRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeviceCommandRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.CommandName == input.CommandName ||
                    (this.CommandName != null &&
                    this.CommandName.Equals(input.CommandName))
                ) && 
                (
                    this.Paras == input.Paras ||
                    (this.Paras != null &&
                    this.Paras.Equals(input.Paras))
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
                if (this.ServiceId != null)
                    hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.CommandName != null)
                    hashCode = hashCode * 59 + this.CommandName.GetHashCode();
                if (this.Paras != null)
                    hashCode = hashCode * 59 + this.Paras.GetHashCode();
                return hashCode;
            }
        }
    }
}
