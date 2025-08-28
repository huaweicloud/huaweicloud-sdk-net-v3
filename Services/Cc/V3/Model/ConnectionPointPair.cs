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
    /// 带宽包两端接入站点的站点编码，成对配置
    /// </summary>
    public class ConnectionPointPair 
    {

        /// <summary>
        /// 中心网络连接的两个端点定义，长度固定为2的数组。
        /// </summary>
        [JsonProperty("connection_point_pair", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConnectionPoint> _ConnectionPointPair { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionPointPair {\n");
            sb.Append("  _connectionPointPair: ").Append(_ConnectionPointPair).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConnectionPointPair);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConnectionPointPair input)
        {
            if (input == null) return false;
            if (this._ConnectionPointPair != input._ConnectionPointPair || (this._ConnectionPointPair != null && input._ConnectionPointPair != null && !this._ConnectionPointPair.SequenceEqual(input._ConnectionPointPair))) return false;

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
                if (this._ConnectionPointPair != null) hashCode = hashCode * 59 + this._ConnectionPointPair.GetHashCode();
                return hashCode;
            }
        }
    }
}
