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
    /// Response Object
    /// </summary>
    public class BatchListMfaDevicesForUserResponse : SdkResponse
    {

        /// <summary>
        /// 用户MFA设备信息列表
        /// </summary>
        [JsonProperty("user_mfa_devices_entry_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RetrieveMfaDevicesForUserEntryDto> UserMfaDevicesEntryList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchListMfaDevicesForUserResponse {\n");
            sb.Append("  userMfaDevicesEntryList: ").Append(UserMfaDevicesEntryList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchListMfaDevicesForUserResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchListMfaDevicesForUserResponse input)
        {
            if (input == null) return false;
            if (this.UserMfaDevicesEntryList != input.UserMfaDevicesEntryList || (this.UserMfaDevicesEntryList != null && input.UserMfaDevicesEntryList != null && !this.UserMfaDevicesEntryList.SequenceEqual(input.UserMfaDevicesEntryList))) return false;

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
                if (this.UserMfaDevicesEntryList != null) hashCode = hashCode * 59 + this.UserMfaDevicesEntryList.GetHashCode();
                return hashCode;
            }
        }
    }
}
