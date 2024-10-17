using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// proxy更新连接池请求体。
    /// </summary>
    public class ProxyUpdateProxyConnectionPoolTypeRequest 
    {

        /// <summary>
        /// 连接池类型。 - CLOSED：关闭连接池。 - SESSION：开启会话级连接池
        /// </summary>
        [JsonProperty("connection_pool_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionPoolType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProxyUpdateProxyConnectionPoolTypeRequest {\n");
            sb.Append("  connectionPoolType: ").Append(ConnectionPoolType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProxyUpdateProxyConnectionPoolTypeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProxyUpdateProxyConnectionPoolTypeRequest input)
        {
            if (input == null) return false;
            if (this.ConnectionPoolType != input.ConnectionPoolType || (this.ConnectionPoolType != null && !this.ConnectionPoolType.Equals(input.ConnectionPoolType))) return false;

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
                if (this.ConnectionPoolType != null) hashCode = hashCode * 59 + this.ConnectionPoolType.GetHashCode();
                return hashCode;
            }
        }
    }
}
