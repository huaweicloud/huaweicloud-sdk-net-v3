using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyInternalIpRequest 
    {

        /// <summary>
        /// 内网IP。
        /// </summary>
        [JsonProperty("internal_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string InternalIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyInternalIpRequest {\n");
            sb.Append("  internalIp: ").Append(InternalIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyInternalIpRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyInternalIpRequest input)
        {
            if (input == null) return false;
            if (this.InternalIp != input.InternalIp || (this.InternalIp != null && !this.InternalIp.Equals(input.InternalIp))) return false;

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
                if (this.InternalIp != null) hashCode = hashCode * 59 + this.InternalIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
