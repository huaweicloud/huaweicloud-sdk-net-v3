using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InstanceRestartRequsetBody 
    {

        /// <summary>
        /// 空值
        /// </summary>
        [JsonProperty("restart", NullValueHandling = NullValueHandling.Ignore)]
        public Object Restart { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceRestartRequsetBody {\n");
            sb.Append("  restart: ").Append(Restart).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceRestartRequsetBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceRestartRequsetBody input)
        {
            if (input == null) return false;
            if (this.Restart != input.Restart || (this.Restart != null && !this.Restart.Equals(input.Restart))) return false;

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
                if (this.Restart != null) hashCode = hashCode * 59 + this.Restart.GetHashCode();
                return hashCode;
            }
        }
    }
}
