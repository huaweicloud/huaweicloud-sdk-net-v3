using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SessionPersistence 
    {

        /// <summary>
        /// **参数解释**：cookie名称。  **取值范围**：最大长度1024个字符。  [不支持该字段，请勿使用。](tag:hws_eu,hcso_dt)
        /// </summary>
        [JsonProperty("cookie_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CookieName { get; set; }

        /// <summary>
        /// **参数解释**：会话保持类型。  **取值范围**： - SOURCE_IP：基于源IP地址的会话保持，也就是根据客户端的源IP地址将流量持续转发到同一后端服务器（member）。 - HTTP_COOKIE：通过在HTTP响应中插入一个特殊的Cookie，实现会话保持。负载均衡会在后续请求中识别该Cookie，并将请求转发到对应的后端服务器。 - APP_COOKIE：基于应用层Cookie的会话保持。与HTTP_COOKIE不同的是，APP_COOKIE要求后端服务在响应中插入一个指定名称的Cookie，负载均衡器识别后，将后续请求转发到相同后端member。  [荷兰region不支持QUIC。](tag:dt) [不支持QUIC。](tag:tm)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：会话保持的时间。当type为APP_COOKIE时不生效。  **取值范围**： - 若pool的protocol为TCP、UDP和QUIC则范围为[1,60]（分钟），默认值1。 - 若pool的protocol为HTTP和HTTPS则范围为[1,1440]（分钟），默认值1440。  [荷兰region不支持QUIC。](tag:dt)
        /// </summary>
        [JsonProperty("persistence_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? PersistenceTimeout { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionPersistence {\n");
            sb.Append("  cookieName: ").Append(CookieName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  persistenceTimeout: ").Append(PersistenceTimeout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SessionPersistence);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SessionPersistence input)
        {
            if (input == null) return false;
            if (this.CookieName != input.CookieName || (this.CookieName != null && !this.CookieName.Equals(input.CookieName))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.PersistenceTimeout != input.PersistenceTimeout || (this.PersistenceTimeout != null && !this.PersistenceTimeout.Equals(input.PersistenceTimeout))) return false;

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
                if (this.CookieName != null) hashCode = hashCode * 59 + this.CookieName.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PersistenceTimeout != null) hashCode = hashCode * 59 + this.PersistenceTimeout.GetHashCode();
                return hashCode;
            }
        }
    }
}
