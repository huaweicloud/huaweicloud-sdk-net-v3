using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchListMfaDevicesForUserReqBody 
    {

        /// <summary>
        /// 用户列表
        /// </summary>
        [JsonProperty("user_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RetrieveMfaDevicesForUserDto> UserList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchListMfaDevicesForUserReqBody {\n");
            sb.Append("  userList: ").Append(UserList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchListMfaDevicesForUserReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchListMfaDevicesForUserReqBody input)
        {
            if (input == null) return false;
            if (this.UserList != input.UserList || (this.UserList != null && input.UserList != null && !this.UserList.SequenceEqual(input.UserList))) return false;

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
                if (this.UserList != null) hashCode = hashCode * 59 + this.UserList.GetHashCode();
                return hashCode;
            }
        }
    }
}
