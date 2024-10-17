using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientData 
    {

        /// <summary>
        /// 客户端语言。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 客户端版本。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 客户端ID。
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// 客户端地址。
        /// </summary>
        [JsonProperty("client_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientAddr { get; set; }

        /// <summary>
        /// 订阅关系列表。
        /// </summary>
        [JsonProperty("subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Subscription> Subscriptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientData {\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  clientId: ").Append(ClientId).Append("\n");
            sb.Append("  clientAddr: ").Append(ClientAddr).Append("\n");
            sb.Append("  subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClientData input)
        {
            if (input == null) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.ClientId != input.ClientId || (this.ClientId != null && !this.ClientId.Equals(input.ClientId))) return false;
            if (this.ClientAddr != input.ClientAddr || (this.ClientAddr != null && !this.ClientAddr.Equals(input.ClientAddr))) return false;
            if (this.Subscriptions != input.Subscriptions || (this.Subscriptions != null && input.Subscriptions != null && !this.Subscriptions.SequenceEqual(input.Subscriptions))) return false;

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
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ClientId != null) hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientAddr != null) hashCode = hashCode * 59 + this.ClientAddr.GetHashCode();
                if (this.Subscriptions != null) hashCode = hashCode * 59 + this.Subscriptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
