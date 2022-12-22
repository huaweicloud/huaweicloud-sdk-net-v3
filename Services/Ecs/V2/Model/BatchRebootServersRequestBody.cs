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
    public class BatchRebootServersRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("reboot", NullValueHandling = NullValueHandling.Ignore)]
        public BatchRebootSeversOption Reboot { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRebootServersRequestBody {\n");
            sb.Append("  reboot: ").Append(Reboot).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchRebootServersRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchRebootServersRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reboot == input.Reboot ||
                    (this.Reboot != null &&
                    this.Reboot.Equals(input.Reboot))
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
                if (this.Reboot != null)
                    hashCode = hashCode * 59 + this.Reboot.GetHashCode();
                return hashCode;
            }
        }
    }
}
