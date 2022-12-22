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
    /// 
    /// </summary>
    public class UpdateLoginProjectReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("login_protect", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateLoginProject LoginProtect { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLoginProjectReq {\n");
            sb.Append("  loginProtect: ").Append(LoginProtect).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLoginProjectReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLoginProjectReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoginProtect == input.LoginProtect ||
                    (this.LoginProtect != null &&
                    this.LoginProtect.Equals(input.LoginProtect))
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
                if (this.LoginProtect != null)
                    hashCode = hashCode * 59 + this.LoginProtect.GetHashCode();
                return hashCode;
            }
        }
    }
}
