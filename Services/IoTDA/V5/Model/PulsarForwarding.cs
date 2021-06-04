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
    /// pulsar通道配置信
    /// </summary>
    public class PulsarForwarding 
    {

        /// <summary>
        /// **参数说明**：pulsar的访问url。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数说明**：用于接收满足规则条件数据的topic。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// **参数说明**：证书id
        /// </summary>
        [JsonProperty("cert_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CertId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PulsarForwarding {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  certId: ").Append(CertId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PulsarForwarding);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PulsarForwarding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.CertId == input.CertId ||
                    (this.CertId != null &&
                    this.CertId.Equals(input.CertId))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.CertId != null)
                    hashCode = hashCode * 59 + this.CertId.GetHashCode();
                return hashCode;
            }
        }
    }
}
