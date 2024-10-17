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
    /// 转发MRS Kafka消息结构
    /// </summary>
    public class MrsKafkaForwarding 
    {

        /// <summary>
        /// **参数说明**：转发kafka消息对应的地址列表
        /// </summary>
        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<NetAddress> Addresses { get; set; }

        /// <summary>
        /// **参数说明**：转发kafka消息关联的topic信息。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 是否Kerberos认证，默认为false。
        /// </summary>
        [JsonProperty("kerberos_authentication", NullValueHandling = NullValueHandling.Ignore)]
        public bool? KerberosAuthentication { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MrsKafkaForwarding {\n");
            sb.Append("  addresses: ").Append(Addresses).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  kerberosAuthentication: ").Append(KerberosAuthentication).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MrsKafkaForwarding);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MrsKafkaForwarding input)
        {
            if (input == null) return false;
            if (this.Addresses != input.Addresses || (this.Addresses != null && input.Addresses != null && !this.Addresses.SequenceEqual(input.Addresses))) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.KerberosAuthentication != input.KerberosAuthentication || (this.KerberosAuthentication != null && !this.KerberosAuthentication.Equals(input.KerberosAuthentication))) return false;

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
                if (this.Addresses != null) hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.KerberosAuthentication != null) hashCode = hashCode * 59 + this.KerberosAuthentication.GetHashCode();
                return hashCode;
            }
        }
    }
}
