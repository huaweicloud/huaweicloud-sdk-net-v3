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
    public class RetrieveMfaDevicesForUserEntryDto 
    {

        /// <summary>
        /// MFA设备列表
        /// </summary>
        [JsonProperty("mfa_devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<MfaDeviceDto> MfaDevices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public RetrieveMfaDevicesForUserDto User { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveMfaDevicesForUserEntryDto {\n");
            sb.Append("  mfaDevices: ").Append(MfaDevices).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetrieveMfaDevicesForUserEntryDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetrieveMfaDevicesForUserEntryDto input)
        {
            if (input == null) return false;
            if (this.MfaDevices != input.MfaDevices || (this.MfaDevices != null && input.MfaDevices != null && !this.MfaDevices.SequenceEqual(input.MfaDevices))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;

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
                if (this.MfaDevices != null) hashCode = hashCode * 59 + this.MfaDevices.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                return hashCode;
            }
        }
    }
}
