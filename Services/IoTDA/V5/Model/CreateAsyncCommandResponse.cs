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
    public class CreateAsyncCommandResponse : SdkResponse
    {

        /// <summary>
        /// 设备ID，用于唯一标识一个设备，在注册设备时由物联网平台分配获得。
        /// </summary>
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备命令ID，用于唯一标识一条命令，在下发设备命令时由物联网平台分配获得。
        /// </summary>
        [JsonProperty("command_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandId { get; set; }

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
        /// 设备执行的命令，Json格式，里面是一个个健值对，如果service_id不为空，每个健都是profile中命令的参数名（paraName）;如果service_id为空则由用户自定义命令格式。设备命令示例：{\&quot;value\&quot;:\&quot;1\&quot;}，具体格式需要应用和设备约定。
        /// </summary>
        [JsonProperty("paras", NullValueHandling = NullValueHandling.Ignore)]
        public Object Paras { get; set; }

        /// <summary>
        /// 物联网平台缓存命令的时长， 单位秒。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// 设备命令状态,如果命令被缓存，返回PENDING, 如果命令下发给设备，返回SENT。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 命令的创建时间，\&quot;yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;\&quot;格式的UTC字符串。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 下发策略， immediately表示立即下发，delay表示缓存起来，等数据上报或者设备上线之后下发。
        /// </summary>
        [JsonProperty("send_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string SendStrategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAsyncCommandResponse {\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  commandId: ").Append(CommandId).Append("\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  commandName: ").Append(CommandName).Append("\n");
            sb.Append("  paras: ").Append(Paras).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  sendStrategy: ").Append(SendStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAsyncCommandResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAsyncCommandResponse input)
        {
            if (input == null) return false;
            if (this.DeviceId != input.DeviceId || (this.DeviceId != null && !this.DeviceId.Equals(input.DeviceId))) return false;
            if (this.CommandId != input.CommandId || (this.CommandId != null && !this.CommandId.Equals(input.CommandId))) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.CommandName != input.CommandName || (this.CommandName != null && !this.CommandName.Equals(input.CommandName))) return false;
            if (this.Paras != input.Paras || (this.Paras != null && !this.Paras.Equals(input.Paras))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.SendStrategy != input.SendStrategy || (this.SendStrategy != null && !this.SendStrategy.Equals(input.SendStrategy))) return false;

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
                if (this.CommandId != null) hashCode = hashCode * 59 + this.CommandId.GetHashCode();
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.CommandName != null) hashCode = hashCode * 59 + this.CommandName.GetHashCode();
                if (this.Paras != null) hashCode = hashCode * 59 + this.Paras.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.SendStrategy != null) hashCode = hashCode * 59 + this.SendStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
