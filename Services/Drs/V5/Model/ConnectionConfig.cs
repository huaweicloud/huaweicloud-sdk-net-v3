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
    public class ConnectionConfig 
    {

        /// <summary>
        /// 驱动程序名称。
        /// </summary>
        [JsonProperty("driver_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DriverName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionConfig {\n");
            sb.Append("  driverName: ").Append(DriverName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConnectionConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConnectionConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DriverName == input.DriverName ||
                    (this.DriverName != null &&
                    this.DriverName.Equals(input.DriverName))
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
                if (this.DriverName != null)
                    hashCode = hashCode * 59 + this.DriverName.GetHashCode();
                return hashCode;
            }
        }
    }
}
