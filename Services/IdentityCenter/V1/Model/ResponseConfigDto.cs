using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// 联邦配置
    /// </summary>
    public class ResponseConfigDto 
    {

        /// <summary>
        /// 额外添加的属性映射配置
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, ResponseSourceDetailsDto> Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public ResponseSourceDetailsDto Subject { get; set; }

        /// <summary>
        /// 中继状态
        /// </summary>
        [JsonProperty("relay_state", NullValueHandling = NullValueHandling.Ignore)]
        public string RelayState { get; set; }

        /// <summary>
        /// 会话过期时间
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public string Ttl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseConfigDto {\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  relayState: ").Append(RelayState).Append("\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResponseConfigDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResponseConfigDto input)
        {
            if (input == null) return false;
            if (this.Properties != input.Properties || (this.Properties != null && input.Properties != null && !this.Properties.SequenceEqual(input.Properties))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.RelayState != input.RelayState || (this.RelayState != null && !this.RelayState.Equals(input.RelayState))) return false;
            if (this.Ttl != input.Ttl || (this.Ttl != null && !this.Ttl.Equals(input.Ttl))) return false;

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
                if (this.Properties != null) hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.RelayState != null) hashCode = hashCode * 59 + this.RelayState.GetHashCode();
                if (this.Ttl != null) hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                return hashCode;
            }
        }
    }
}
