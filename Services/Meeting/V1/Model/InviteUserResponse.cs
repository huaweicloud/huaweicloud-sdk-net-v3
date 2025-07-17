using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class InviteUserResponse : SdkResponse
    {

        /// <summary>
        /// 用户是否存在
        /// </summary>
        [JsonProperty("userExist", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserExist { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InviteUserResponse {\n");
            sb.Append("  userExist: ").Append(UserExist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InviteUserResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InviteUserResponse input)
        {
            if (input == null) return false;
            if (this.UserExist != input.UserExist || (this.UserExist != null && !this.UserExist.Equals(input.UserExist))) return false;

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
                if (this.UserExist != null) hashCode = hashCode * 59 + this.UserExist.GetHashCode();
                return hashCode;
            }
        }
    }
}
