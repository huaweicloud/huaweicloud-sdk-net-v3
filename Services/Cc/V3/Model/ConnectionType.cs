using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 连接类型。
    /// </summary>
    public class ConnectionType 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("connection_type", NullValueHandling = NullValueHandling.Ignore)]
        public ConnectionTypeEnum _ConnectionType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionType {\n");
            sb.Append("  _connectionType: ").Append(_ConnectionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConnectionType);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConnectionType input)
        {
            if (input == null) return false;
            if (this._ConnectionType != input._ConnectionType) return false;

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
                hashCode = hashCode * 59 + this._ConnectionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
