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
    public class AddMsdtcRequestBody 
    {

        /// <summary>
        /// 主机信息，key为hostname ，value 为IP
        /// </summary>
        [JsonProperty("hosts", NullValueHandling = NullValueHandling.Ignore)]
        public List<MsdtcHostOption> Hosts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddMsdtcRequestBody {\n");
            sb.Append("  hosts: ").Append(Hosts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddMsdtcRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddMsdtcRequestBody input)
        {
            if (input == null) return false;
            if (this.Hosts != input.Hosts || (this.Hosts != null && input.Hosts != null && !this.Hosts.SequenceEqual(input.Hosts))) return false;

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
                if (this.Hosts != null) hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                return hashCode;
            }
        }
    }
}
