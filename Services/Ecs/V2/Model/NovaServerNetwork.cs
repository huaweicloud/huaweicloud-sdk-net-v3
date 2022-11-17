using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NovaServerNetwork 
    {

        /// <summary>
        /// 网络port uuid。  没有指定网络uuid时必须指定。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// 网络uuid。  没有指定网络port时必须指定。
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// 指定的IP地址。网络的三个参数（port、uuid和fixed_ip）中，port优先级最高；指定fixed_ip时必须指明uuid。
        /// </summary>
        [JsonProperty("fixed_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string FixedIp { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaServerNetwork {\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  fixedIp: ").Append(FixedIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaServerNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaServerNetwork input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.FixedIp == input.FixedIp ||
                    (this.FixedIp != null &&
                    this.FixedIp.Equals(input.FixedIp))
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
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.FixedIp != null)
                    hashCode = hashCode * 59 + this.FixedIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
