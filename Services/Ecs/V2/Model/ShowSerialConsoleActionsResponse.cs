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
    public class ShowSerialConsoleActionsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("serial_console", NullValueHandling = NullValueHandling.Ignore)]
        public ShowSerialConsoleActionsOption SerialConsole { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSerialConsoleActionsResponse {\n");
            sb.Append("  serialConsole: ").Append(SerialConsole).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSerialConsoleActionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSerialConsoleActionsResponse input)
        {
            if (input == null) return false;
            if (this.SerialConsole != input.SerialConsole || (this.SerialConsole != null && !this.SerialConsole.Equals(input.SerialConsole))) return false;

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
                if (this.SerialConsole != null) hashCode = hashCode * 59 + this.SerialConsole.GetHashCode();
                return hashCode;
            }
        }
    }
}
