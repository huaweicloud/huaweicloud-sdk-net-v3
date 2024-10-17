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
    /// 转发kafka消息结构
    /// </summary>
    public class DmsKafkaForwarding 
    {

        /// <summary>
        /// **参数说明**：Kafka服务对应的region区域
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }

        /// <summary>
        /// **参数说明**：Kafka服务对应的projectId信息
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

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
        /// **参数说明**：转发kafka关联的用户名信息。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// **参数说明**：转发kafka关联的密码信息。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// **参数说明**：转发kafka关联的SASL认证机制。 **取值范围**： - PAAS：明文传输，此模式下为非数据加密传输模式，数据传输不安全，建议您使用更安全的数据加密模式。 - PLAIN：SASL/PLAIN模式。需要填写对应的用户名密码信息。一种简单的用户名密码校验机制，在SASL_PLAINTEXT场景下，不建议使用。 - SCRAM-SHA-512：SASL/SCRAM-SHA-512模式。需要填写对应的用户名密码信息。采用哈希算法对用户名与密码生成凭证，进行身份校验的安全认证机制，比PLAIN机制安全性更高。
        /// </summary>
        [JsonProperty("mechanism", NullValueHandling = NullValueHandling.Ignore)]
        public string Mechanism { get; set; }

        /// <summary>
        /// **参数说明**：kafka传输安全协议，此字段不填默认为SASL_SSL。当mechanism为PAAS或不填时，该字段不生效。 **取值范围**： - SASL_SSL：采用SSL证书进行加密传输，支持帐号密码认证，安全性更高。 - SASL_PLAINTEXT：明文传输，支持帐号密码认证，性能更好，建议mechanism使用SCRAM-SHA-512机制。
        /// </summary>
        [JsonProperty("security_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityProtocol { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DmsKafkaForwarding {\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  addresses: ").Append(Addresses).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  mechanism: ").Append(Mechanism).Append("\n");
            sb.Append("  securityProtocol: ").Append(SecurityProtocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DmsKafkaForwarding);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DmsKafkaForwarding input)
        {
            if (input == null) return false;
            if (this.RegionName != input.RegionName || (this.RegionName != null && !this.RegionName.Equals(input.RegionName))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Addresses != input.Addresses || (this.Addresses != null && input.Addresses != null && !this.Addresses.SequenceEqual(input.Addresses))) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.Mechanism != input.Mechanism || (this.Mechanism != null && !this.Mechanism.Equals(input.Mechanism))) return false;
            if (this.SecurityProtocol != input.SecurityProtocol || (this.SecurityProtocol != null && !this.SecurityProtocol.Equals(input.SecurityProtocol))) return false;

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
                if (this.RegionName != null) hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Addresses != null) hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Mechanism != null) hashCode = hashCode * 59 + this.Mechanism.GetHashCode();
                if (this.SecurityProtocol != null) hashCode = hashCode * 59 + this.SecurityProtocol.GetHashCode();
                return hashCode;
            }
        }
    }
}
