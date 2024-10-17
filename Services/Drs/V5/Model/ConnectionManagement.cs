using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConnectionManagement 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("driver_management", NullValueHandling = NullValueHandling.Ignore)]
        public DriverManagement DriverManagement { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionManagement {\n");
            sb.Append("  driverManagement: ").Append(DriverManagement).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConnectionManagement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConnectionManagement input)
        {
            if (input == null) return false;
            if (this.DriverManagement != input.DriverManagement || (this.DriverManagement != null && !this.DriverManagement.Equals(input.DriverManagement))) return false;

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
                if (this.DriverManagement != null) hashCode = hashCode * 59 + this.DriverManagement.GetHashCode();
                return hashCode;
            }
        }
    }
}
