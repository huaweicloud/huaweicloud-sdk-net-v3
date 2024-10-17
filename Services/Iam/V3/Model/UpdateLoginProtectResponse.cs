using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateLoginProtectResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("login_protect", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateLoginProtectRespon LoginProtect { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLoginProtectResponse {\n");
            sb.Append("  loginProtect: ").Append(LoginProtect).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLoginProtectResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLoginProtectResponse input)
        {
            if (input == null) return false;
            if (this.LoginProtect != input.LoginProtect || (this.LoginProtect != null && !this.LoginProtect.Equals(input.LoginProtect))) return false;

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
                if (this.LoginProtect != null) hashCode = hashCode * 59 + this.LoginProtect.GetHashCode();
                return hashCode;
            }
        }
    }
}
