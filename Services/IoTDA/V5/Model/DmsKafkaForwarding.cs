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
        /// **参数说明**：转发kafka关联的鉴权机制。 **取值范围**： - PAAS：非SASL鉴权。 - PLAIN：SASL/PLAIN模式。需要填写对应的用户名密码信息。
        /// </summary>
        [JsonProperty("mechanism", NullValueHandling = NullValueHandling.Ignore)]
        public string Mechanism { get; set; }


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
            if (input == null)
                return false;

            return 
                (
                    this.RegionName == input.RegionName ||
                    (this.RegionName != null &&
                    this.RegionName.Equals(input.RegionName))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Mechanism == input.Mechanism ||
                    (this.Mechanism != null &&
                    this.Mechanism.Equals(input.Mechanism))
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
                if (this.RegionName != null)
                    hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Mechanism != null)
                    hashCode = hashCode * 59 + this.Mechanism.GetHashCode();
                return hashCode;
            }
        }
    }
}
