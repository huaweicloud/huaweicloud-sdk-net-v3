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
    public class DataIpRequest 
    {

        /// <summary>
        /// 内网ip
        /// </summary>
        [JsonProperty("new_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string NewIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataIpRequest {\n");
            sb.Append("  newIp: ").Append(NewIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataIpRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataIpRequest input)
        {
            if (input == null) return false;
            if (this.NewIp != input.NewIp || (this.NewIp != null && !this.NewIp.Equals(input.NewIp))) return false;

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
                if (this.NewIp != null) hashCode = hashCode * 59 + this.NewIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
