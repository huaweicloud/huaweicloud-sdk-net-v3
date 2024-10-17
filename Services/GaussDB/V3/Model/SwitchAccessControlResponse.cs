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
    /// Response Object
    /// </summary>
    public class SwitchAccessControlResponse : SdkResponse
    {

        /// <summary>
        /// 是否已开启访问控制。 取值： - true：开启。 - false：关闭。
        /// </summary>
        [JsonProperty("open_access_control", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenAccessControl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchAccessControlResponse {\n");
            sb.Append("  openAccessControl: ").Append(OpenAccessControl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchAccessControlResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchAccessControlResponse input)
        {
            if (input == null) return false;
            if (this.OpenAccessControl != input.OpenAccessControl || (this.OpenAccessControl != null && !this.OpenAccessControl.Equals(input.OpenAccessControl))) return false;

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
                if (this.OpenAccessControl != null) hashCode = hashCode * 59 + this.OpenAccessControl.GetHashCode();
                return hashCode;
            }
        }
    }
}
