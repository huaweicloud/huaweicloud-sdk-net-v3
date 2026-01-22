using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ChannelDetails 
    {

        /// <summary>
        /// **参数解释**： channel信息，包括客户端IP:Port到服务端IP:Port(channel_id)。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： channel数量。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public int? Number { get; set; }

        /// <summary>
        /// **参数解释**： 消费者用户名，在开启ACL访问控制后返回真实用户名，未开启ACL时返回null。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// **参数解释**： connection信息，包括客户端IP:Port到服务端IP:Port。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("connection_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// **参数解释**： 连接的消费者IP。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("peer_host", NullValueHandling = NullValueHandling.Ignore)]
        public string PeerHost { get; set; }

        /// <summary>
        /// **参数解释**： 连接的消费者进程端口号。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("peer_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeerPort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelDetails {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  connectionName: ").Append(ConnectionName).Append("\n");
            sb.Append("  peerHost: ").Append(PeerHost).Append("\n");
            sb.Append("  peerPort: ").Append(PeerPort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChannelDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChannelDetails input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.ConnectionName != input.ConnectionName || (this.ConnectionName != null && !this.ConnectionName.Equals(input.ConnectionName))) return false;
            if (this.PeerHost != input.PeerHost || (this.PeerHost != null && !this.PeerHost.Equals(input.PeerHost))) return false;
            if (this.PeerPort != input.PeerPort || (this.PeerPort != null && !this.PeerPort.Equals(input.PeerPort))) return false;

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
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.ConnectionName != null) hashCode = hashCode * 59 + this.ConnectionName.GetHashCode();
                if (this.PeerHost != null) hashCode = hashCode * 59 + this.PeerHost.GetHashCode();
                if (this.PeerPort != null) hashCode = hashCode * 59 + this.PeerPort.GetHashCode();
                return hashCode;
            }
        }
    }
}
