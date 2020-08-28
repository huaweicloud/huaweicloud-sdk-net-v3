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
    public class ListUserLoginProtectsResponse : SdkResponse
    {

        /// <summary>
        /// 登录状态保护信息列表。
        /// </summary>
        [JsonProperty("login_protects", NullValueHandling = NullValueHandling.Ignore)]
        public List<LoginProtectResult> LoginProtects { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUserLoginProtectsResponse {\n");
            sb.Append("  loginProtects: ").Append(LoginProtects).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUserLoginProtectsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUserLoginProtectsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoginProtects == input.LoginProtects ||
                    this.LoginProtects != null &&
                    input.LoginProtects != null &&
                    this.LoginProtects.SequenceEqual(input.LoginProtects)
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
                if (this.LoginProtects != null)
                    hashCode = hashCode * 59 + this.LoginProtects.GetHashCode();
                return hashCode;
            }
        }
    }
}
