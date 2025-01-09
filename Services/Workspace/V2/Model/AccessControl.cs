using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AccessControl 
    {

        /// <summary>
        /// IP接入控制。IP接入控制需输入有效的IP地址和子网掩码，IP和子网掩码间以\&quot;|\&quot;拼接组成一组，如果有多组用\&quot;;\&quot;分隔。如：IP|掩码;IP|掩码;IP|掩码。
        /// </summary>
        [JsonProperty("ip_access_control", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAccessControl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessControl {\n");
            sb.Append("  ipAccessControl: ").Append(IpAccessControl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessControl);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessControl input)
        {
            if (input == null) return false;
            if (this.IpAccessControl != input.IpAccessControl || (this.IpAccessControl != null && !this.IpAccessControl.Equals(input.IpAccessControl))) return false;

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
                if (this.IpAccessControl != null) hashCode = hashCode * 59 + this.IpAccessControl.GetHashCode();
                return hashCode;
            }
        }
    }
}
