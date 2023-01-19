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
    /// This is a auto create Body Object
    /// </summary>
    public class ShowServerRemoteConsoleRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("remote_console", NullValueHandling = NullValueHandling.Ignore)]
        public GetServerRemoteConsoleOption RemoteConsole { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowServerRemoteConsoleRequestBody {\n");
            sb.Append("  remoteConsole: ").Append(RemoteConsole).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowServerRemoteConsoleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowServerRemoteConsoleRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RemoteConsole == input.RemoteConsole ||
                    (this.RemoteConsole != null &&
                    this.RemoteConsole.Equals(input.RemoteConsole))
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
                if (this.RemoteConsole != null)
                    hashCode = hashCode * 59 + this.RemoteConsole.GetHashCode();
                return hashCode;
            }
        }
    }
}
