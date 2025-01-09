using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Radius主机配置信息
    /// </summary>
    public class RadiusHost 
    {

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        [JsonProperty("radius_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string RadiusIp { get; set; }

        /// <summary>
        /// 认证端口
        /// </summary>
        [JsonProperty("auth_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? AuthPort { get; set; }

        /// <summary>
        /// 接收端口
        /// </summary>
        [JsonProperty("accept_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? AcceptPort { get; set; }

        /// <summary>
        /// NAS ID
        /// </summary>
        [JsonProperty("nas_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NasId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadiusHost {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  radiusIp: ").Append(RadiusIp).Append("\n");
            sb.Append("  authPort: ").Append(AuthPort).Append("\n");
            sb.Append("  acceptPort: ").Append(AcceptPort).Append("\n");
            sb.Append("  nasId: ").Append(NasId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RadiusHost);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RadiusHost input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.RadiusIp != input.RadiusIp || (this.RadiusIp != null && !this.RadiusIp.Equals(input.RadiusIp))) return false;
            if (this.AuthPort != input.AuthPort || (this.AuthPort != null && !this.AuthPort.Equals(input.AuthPort))) return false;
            if (this.AcceptPort != input.AcceptPort || (this.AcceptPort != null && !this.AcceptPort.Equals(input.AcceptPort))) return false;
            if (this.NasId != input.NasId || (this.NasId != null && !this.NasId.Equals(input.NasId))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RadiusIp != null) hashCode = hashCode * 59 + this.RadiusIp.GetHashCode();
                if (this.AuthPort != null) hashCode = hashCode * 59 + this.AuthPort.GetHashCode();
                if (this.AcceptPort != null) hashCode = hashCode * 59 + this.AcceptPort.GetHashCode();
                if (this.NasId != null) hashCode = hashCode * 59 + this.NasId.GetHashCode();
                return hashCode;
            }
        }
    }
}
