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
    public class AsyncDeviceCommandRequest 
    {

        /// <summary>
        /// **参数说明**：设备命令所属的设备服务ID，在设备关联的产品模型中定义。如设备需要编解码插件来解析命令，此参数为必填项。 **取值范围**：长度不超过64的字符串。
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// **参数说明**：设备命令名称，在设备关联的产品模型中定义。如设备需要编解码插件来解析命令，此参数为必填项。 **取值范围**：长度不超过128的字符串。
        /// </summary>
        [JsonProperty("command_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandName { get; set; }

        /// <summary>
        /// **参数说明**：设备执行的命令，Json格式，里面是一个个健值对，如果service_id不为空，每个健都是profile中命令的参数名（paraName）;如果service_id为空则由用户自定义命令格式。设备命令示例：{\&quot;value\&quot;:\&quot;1\&quot;}，具体格式需要应用和设备约定， 最大32K。
        /// </summary>
        [JsonProperty("paras", NullValueHandling = NullValueHandling.Ignore)]
        public Object Paras { get; set; }

        /// <summary>
        /// **参数说明**：物联网平台缓存命令的时长， 单位秒, 平台最多缓存20条消息（即最多缓存20条PENDING状态的命令） 该参数在send_strategy字段为delay时有效，默认缓存24小时，最大缓存2天。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// **参数说明**：下发策略，默认缓存下发。 **取值范围**： - immediately:表示立即下发，此时expire_time无效。 - delay:表示缓存下发，等数据上报或者设备上线之后下发。expire_time为0或空时，命令会默认缓存24小时。
        /// </summary>
        [JsonProperty("send_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string SendStrategy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncDeviceCommandRequest {\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  commandName: ").Append(CommandName).Append("\n");
            sb.Append("  paras: ").Append(Paras).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  sendStrategy: ").Append(SendStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AsyncDeviceCommandRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AsyncDeviceCommandRequest input)
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
                ) && 
                (
                    this.ExpireTime == input.ExpireTime ||
                    (this.ExpireTime != null &&
                    this.ExpireTime.Equals(input.ExpireTime))
                ) && 
                (
                    this.SendStrategy == input.SendStrategy ||
                    (this.SendStrategy != null &&
                    this.SendStrategy.Equals(input.SendStrategy))
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
                if (this.ExpireTime != null)
                    hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.SendStrategy != null)
                    hashCode = hashCode * 59 + this.SendStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
