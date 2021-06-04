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
    /// ServiceCapability结构体。
    /// </summary>
    public class ServiceCapability 
    {

        /// <summary>
        /// **参数说明**：设备的服务ID。 **取值范围**：长度不超过32，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-$等字符的组合。
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// **参数说明**：设备的服务类型。 **取值范围**：长度不超过32，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-$等字符的组合。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// **参数说明**：设备服务支持的属性列表
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceProperty> Properties { get; set; }

        /// <summary>
        /// **参数说明**：设备服务支持的命令列表。
        /// </summary>
        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceCommand> Commands { get; set; }

        /// <summary>
        /// **参数说明**：设备服务支持的事件列表。
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceEvent> Events { get; set; }

        /// <summary>
        /// **参数说明**：设备服务的描述信息。 **取值范围**：长度不超过128，只允许中文、字母、数字、空白字符、以及_?&#39;#().,;&amp;%@!- ，、：；。/等字符的组合。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数说明**：指定设备服务是否必选。目前本字段为非功能性字段，仅起到标识作用。 **取值范围**： - Master：主服务 - Mandatory：必选服务 - Optional：可选服务 默认值为Optional。
        /// </summary>
        [JsonProperty("option", NullValueHandling = NullValueHandling.Ignore)]
        public string Option { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceCapability {\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("  commands: ").Append(Commands).Append("\n");
            sb.Append("  events: ").Append(Events).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  option: ").Append(Option).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceCapability);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceCapability input)
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
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Commands == input.Commands ||
                    this.Commands != null &&
                    input.Commands != null &&
                    this.Commands.SequenceEqual(input.Commands)
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Option == input.Option ||
                    (this.Option != null &&
                    this.Option.Equals(input.Option))
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
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Commands != null)
                    hashCode = hashCode * 59 + this.Commands.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Option != null)
                    hashCode = hashCode * 59 + this.Option.GetHashCode();
                return hashCode;
            }
        }
    }
}
