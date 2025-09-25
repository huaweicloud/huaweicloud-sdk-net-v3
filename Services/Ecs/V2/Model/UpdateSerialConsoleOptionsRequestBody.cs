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
    public class UpdateSerialConsoleOptionsRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("serial_console_options", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateSerialConsoleOptionsOption SerialConsoleOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSerialConsoleOptionsRequestBody {\n");
            sb.Append("  serialConsoleOptions: ").Append(SerialConsoleOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSerialConsoleOptionsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSerialConsoleOptionsRequestBody input)
        {
            if (input == null) return false;
            if (this.SerialConsoleOptions != input.SerialConsoleOptions || (this.SerialConsoleOptions != null && !this.SerialConsoleOptions.Equals(input.SerialConsoleOptions))) return false;

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
                if (this.SerialConsoleOptions != null) hashCode = hashCode * 59 + this.SerialConsoleOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
