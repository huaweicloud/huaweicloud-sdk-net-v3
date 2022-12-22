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
    /// 属性数据
    /// </summary>
    public class PropertiesDTO 
    {

        /// <summary>
        /// **参数说明**：MQTT 5.0版本请求和响应模式中的相关数据，可选。用户可以通过该参数配置MQTT协议请求和响应模式中的相关数据。 **取值范围**：长度不超过128，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("correlation_data", NullValueHandling = NullValueHandling.Ignore)]
        public string CorrelationData { get; set; }

        /// <summary>
        /// **参数说明**：MQTT 5.0版本请求和响应模式中的响应主题，可选。用户可以通过该参数配置MQTT协议请求和响应模式中的响应主题。 **取值范围**：长度不超过128, 只允许字母、数字、以及_-?&#x3D;$#+/等字符的组合。
        /// </summary>
        [JsonProperty("response_topic", NullValueHandling = NullValueHandling.Ignore)]
        public string ResponseTopic { get; set; }

        /// <summary>
        /// **参数说明**：用户自定义属性，可选。用户可以通过该参数配置用户自定义属性。可以配置的最大自定义属性数量为20。
        /// </summary>
        [JsonProperty("user_properties", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserPropDTO> UserProperties { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertiesDTO {\n");
            sb.Append("  correlationData: ").Append(CorrelationData).Append("\n");
            sb.Append("  responseTopic: ").Append(ResponseTopic).Append("\n");
            sb.Append("  userProperties: ").Append(UserProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PropertiesDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PropertiesDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CorrelationData == input.CorrelationData ||
                    (this.CorrelationData != null &&
                    this.CorrelationData.Equals(input.CorrelationData))
                ) && 
                (
                    this.ResponseTopic == input.ResponseTopic ||
                    (this.ResponseTopic != null &&
                    this.ResponseTopic.Equals(input.ResponseTopic))
                ) && 
                (
                    this.UserProperties == input.UserProperties ||
                    this.UserProperties != null &&
                    input.UserProperties != null &&
                    this.UserProperties.SequenceEqual(input.UserProperties)
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
                if (this.CorrelationData != null)
                    hashCode = hashCode * 59 + this.CorrelationData.GetHashCode();
                if (this.ResponseTopic != null)
                    hashCode = hashCode * 59 + this.ResponseTopic.GetHashCode();
                if (this.UserProperties != null)
                    hashCode = hashCode * 59 + this.UserProperties.GetHashCode();
                return hashCode;
            }
        }
    }
}
