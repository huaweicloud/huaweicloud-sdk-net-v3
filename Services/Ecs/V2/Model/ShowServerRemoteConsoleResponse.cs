using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowServerRemoteConsoleResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("remote_console", NullValueHandling = NullValueHandling.Ignore)]
        public ServerRemoteConsole RemoteConsole { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowServerRemoteConsoleResponse {\n");
            sb.Append("  remoteConsole: ").Append(RemoteConsole).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowServerRemoteConsoleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowServerRemoteConsoleResponse input)
        {
            if (input == null) return false;
            if (this.RemoteConsole != input.RemoteConsole || (this.RemoteConsole != null && !this.RemoteConsole.Equals(input.RemoteConsole))) return false;

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
                if (this.RemoteConsole != null) hashCode = hashCode * 59 + this.RemoteConsole.GetHashCode();
                return hashCode;
            }
        }
    }
}
