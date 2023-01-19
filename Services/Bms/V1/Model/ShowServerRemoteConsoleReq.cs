using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class ShowServerRemoteConsoleReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("remote_console", NullValueHandling = NullValueHandling.Ignore)]
        public RemoteConsole RemoteConsole { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowServerRemoteConsoleReq {\n");
            sb.Append("  remoteConsole: ").Append(RemoteConsole).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowServerRemoteConsoleReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowServerRemoteConsoleReq input)
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
