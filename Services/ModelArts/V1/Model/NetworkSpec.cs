using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 对外网络的描述。
    /// </summary>
    public class NetworkSpec 
    {

        /// <summary>
        /// **参数解释**：网络的cidr值。 **取值范围**： - 172.16.0.0/12~24 - 192.168.0.0/16~24
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("connection", NullValueHandling = NullValueHandling.Ignore)]
        public NetworkConnection Connection { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkSpec {\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  connection: ").Append(Connection).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkSpec input)
        {
            if (input == null) return false;
            if (this.Cidr != input.Cidr || (this.Cidr != null && !this.Cidr.Equals(input.Cidr))) return false;
            if (this.Connection != input.Connection || (this.Connection != null && !this.Connection.Equals(input.Connection))) return false;

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
                if (this.Cidr != null) hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.Connection != null) hashCode = hashCode * 59 + this.Connection.GetHashCode();
                return hashCode;
            }
        }
    }
}
