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
    public class RetrieveMfaDevicesForUserDto 
    {

        /// <summary>
        /// 身份源的全局唯一标识符（ID）
        /// </summary>
        [JsonProperty("identity_store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// 用户唯一标识符（ID）
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveMfaDevicesForUserDto {\n");
            sb.Append("  identityStoreId: ").Append(IdentityStoreId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetrieveMfaDevicesForUserDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetrieveMfaDevicesForUserDto input)
        {
            if (input == null) return false;
            if (this.IdentityStoreId != input.IdentityStoreId || (this.IdentityStoreId != null && !this.IdentityStoreId.Equals(input.IdentityStoreId))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;

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
                if (this.IdentityStoreId != null) hashCode = hashCode * 59 + this.IdentityStoreId.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }
    }
}
