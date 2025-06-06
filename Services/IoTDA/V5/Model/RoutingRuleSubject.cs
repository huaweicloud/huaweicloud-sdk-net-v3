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
    /// 创建或修改规则条件时，指定资源及其范围
    /// </summary>
    public class RoutingRuleSubject 
    {

        /// <summary>
        /// **参数说明**：资源名称。 **取值范围**： - device：设备。 - device.property：设备属性。 - device.message：设备消息。 - device.message.status：设备消息状态。 - device.status：设备状态。 - batchtask：批量任务。 - product：产品。 - device.command.status：设备异步命令状态。
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        /// <summary>
        /// **参数说明**：资源事件。 **取值范围**：与资源有关，不同的资源，事件不同。event需要与resource关联使用，具体的“resource：event”映射关系如下： - device：create（设备添加） - device：delete（设备删除） - device：update（设备更新） - device.status：update （设备状态变更） - device.property：report（设备属性上报） - device.message：report（设备消息上报） - device.message.status：update（设备消息状态变更） - batchtask：update （批量任务状态变更） - product：create（产品添加） - product：delete（产品删除） - product：update（产品更新） - device.command.status：update（设备异步命令状态更新）
        /// </summary>
        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public string Event { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutingRuleSubject {\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoutingRuleSubject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RoutingRuleSubject input)
        {
            if (input == null) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
            if (this.Event != input.Event || (this.Event != null && !this.Event.Equals(input.Event))) return false;

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
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.Event != null) hashCode = hashCode * 59 + this.Event.GetHashCode();
                return hashCode;
            }
        }
    }
}
