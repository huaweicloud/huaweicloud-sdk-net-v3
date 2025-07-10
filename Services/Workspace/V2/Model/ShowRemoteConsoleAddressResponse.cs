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
    /// Response Object
    /// </summary>
    public class ShowRemoteConsoleAddressResponse : SdkResponse
    {

        /// <summary>
        /// 登录类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 远程登录控制台地址。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 登录协议。
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRemoteConsoleAddressResponse {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRemoteConsoleAddressResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRemoteConsoleAddressResponse input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                return hashCode;
            }
        }
    }
}
