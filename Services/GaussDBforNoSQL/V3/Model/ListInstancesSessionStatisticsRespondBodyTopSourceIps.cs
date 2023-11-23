using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListInstancesSessionStatisticsRespondBodyTopSourceIps 
    {

        /// <summary>
        /// 客户端ip地址。
        /// </summary>
        [JsonProperty("client_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIp { get; set; }

        /// <summary>
        /// 客户端连接数。
        /// </summary>
        [JsonProperty("connection_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectionCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesSessionStatisticsRespondBodyTopSourceIps {\n");
            sb.Append("  clientIp: ").Append(ClientIp).Append("\n");
            sb.Append("  connectionCount: ").Append(ConnectionCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesSessionStatisticsRespondBodyTopSourceIps);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesSessionStatisticsRespondBodyTopSourceIps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientIp == input.ClientIp ||
                    (this.ClientIp != null &&
                    this.ClientIp.Equals(input.ClientIp))
                ) && 
                (
                    this.ConnectionCount == input.ConnectionCount ||
                    (this.ConnectionCount != null &&
                    this.ConnectionCount.Equals(input.ConnectionCount))
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
                if (this.ClientIp != null)
                    hashCode = hashCode * 59 + this.ClientIp.GetHashCode();
                if (this.ConnectionCount != null)
                    hashCode = hashCode * 59 + this.ConnectionCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
