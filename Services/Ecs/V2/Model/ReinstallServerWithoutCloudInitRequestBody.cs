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
    public class ReinstallServerWithoutCloudInitRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os-reinstall", NullValueHandling = NullValueHandling.Ignore)]
        public ReinstallServerWithoutCloudInitOption OsReinstall { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReinstallServerWithoutCloudInitRequestBody {\n");
            sb.Append("  osReinstall: ").Append(OsReinstall).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReinstallServerWithoutCloudInitRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReinstallServerWithoutCloudInitRequestBody input)
        {
            if (input == null) return false;
            if (this.OsReinstall != input.OsReinstall || (this.OsReinstall != null && !this.OsReinstall.Equals(input.OsReinstall))) return false;

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
                if (this.OsReinstall != null) hashCode = hashCode * 59 + this.OsReinstall.GetHashCode();
                return hashCode;
            }
        }
    }
}
