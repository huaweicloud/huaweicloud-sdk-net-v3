using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RegisterDmsKafkaInstanceRequestBody 
    {

        /// <summary>
        /// kafka ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// kafka 名称
        /// </summary>
        [JsonProperty("kafka_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("connect_info", NullValueHandling = NullValueHandling.Ignore)]
        public RegisterDmsKafkaInstanceRequestBodyConnectInfo ConnectInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterDmsKafkaInstanceRequestBody {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  kafkaName: ").Append(KafkaName).Append("\n");
            sb.Append("  connectInfo: ").Append(ConnectInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisterDmsKafkaInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegisterDmsKafkaInstanceRequestBody input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.KafkaName != input.KafkaName || (this.KafkaName != null && !this.KafkaName.Equals(input.KafkaName))) return false;
            if (this.ConnectInfo != input.ConnectInfo || (this.ConnectInfo != null && !this.ConnectInfo.Equals(input.ConnectInfo))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.KafkaName != null) hashCode = hashCode * 59 + this.KafkaName.GetHashCode();
                if (this.ConnectInfo != null) hashCode = hashCode * 59 + this.ConnectInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
