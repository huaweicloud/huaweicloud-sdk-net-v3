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
    /// 生成接入凭证的结构体。
    /// </summary>
    public class CreateAccessCodeRequestBody 
    {

        /// <summary>
        /// **参数说明**：接入凭证类型，默认为AMQP的接入凭证类型。 **取值范围**： - [AMQP,MQTT]
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数说明**: 是否将AMQP/MQTT连接断开
        /// </summary>
        [JsonProperty("force_disconnect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceDisconnect { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccessCodeRequestBody {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  forceDisconnect: ").Append(ForceDisconnect).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAccessCodeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAccessCodeRequestBody input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ForceDisconnect != input.ForceDisconnect || (this.ForceDisconnect != null && !this.ForceDisconnect.Equals(input.ForceDisconnect))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ForceDisconnect != null) hashCode = hashCode * 59 + this.ForceDisconnect.GetHashCode();
                return hashCode;
            }
        }
    }
}
