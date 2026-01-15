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
    /// 域控制器信息。
    /// </summary>
    public class DomainController 
    {

        /// <summary>
        /// 域控制器IP地址。
        /// </summary>
        [JsonProperty("dc_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DcIp { get; set; }

        /// <summary>
        /// 域控制器名称。
        /// </summary>
        [JsonProperty("dc_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DcName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainController {\n");
            sb.Append("  dcIp: ").Append(DcIp).Append("\n");
            sb.Append("  dcName: ").Append(DcName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainController);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainController input)
        {
            if (input == null) return false;
            if (this.DcIp != input.DcIp || (this.DcIp != null && !this.DcIp.Equals(input.DcIp))) return false;
            if (this.DcName != input.DcName || (this.DcName != null && !this.DcName.Equals(input.DcName))) return false;

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
                if (this.DcIp != null) hashCode = hashCode * 59 + this.DcIp.GetHashCode();
                if (this.DcName != null) hashCode = hashCode * 59 + this.DcName.GetHashCode();
                return hashCode;
            }
        }
    }
}
