using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 节点。
    /// </summary>
    public class ShowClusterRespClusterBrokers 
    {

        /// <summary>
        /// 节点IP。
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// 端口号。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 节点ID。
        /// </summary>
        [JsonProperty("broker_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerId { get; set; }

        /// <summary>
        /// 是否为contoller节点。
        /// </summary>
        [JsonProperty("is_controller", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsController { get; set; }

        /// <summary>
        /// 服务端版本。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// broker注册时间，为unix时间戳格式。
        /// </summary>
        [JsonProperty("register_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RegisterTime { get; set; }

        /// <summary>
        /// Kafka实例节点的连通性是否正常。
        /// </summary>
        [JsonProperty("is_health", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHealth { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowClusterRespClusterBrokers {\n");
            sb.Append("  host: ").Append(Host).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  brokerId: ").Append(BrokerId).Append("\n");
            sb.Append("  isController: ").Append(IsController).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  registerTime: ").Append(RegisterTime).Append("\n");
            sb.Append("  isHealth: ").Append(IsHealth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowClusterRespClusterBrokers);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowClusterRespClusterBrokers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.BrokerId == input.BrokerId ||
                    (this.BrokerId != null &&
                    this.BrokerId.Equals(input.BrokerId))
                ) && 
                (
                    this.IsController == input.IsController ||
                    (this.IsController != null &&
                    this.IsController.Equals(input.IsController))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.RegisterTime == input.RegisterTime ||
                    (this.RegisterTime != null &&
                    this.RegisterTime.Equals(input.RegisterTime))
                ) && 
                (
                    this.IsHealth == input.IsHealth ||
                    (this.IsHealth != null &&
                    this.IsHealth.Equals(input.IsHealth))
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
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.BrokerId != null)
                    hashCode = hashCode * 59 + this.BrokerId.GetHashCode();
                if (this.IsController != null)
                    hashCode = hashCode * 59 + this.IsController.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.RegisterTime != null)
                    hashCode = hashCode * 59 + this.RegisterTime.GetHashCode();
                if (this.IsHealth != null)
                    hashCode = hashCode * 59 + this.IsHealth.GetHashCode();
                return hashCode;
            }
        }
    }
}
