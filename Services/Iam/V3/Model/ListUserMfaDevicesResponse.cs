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
    public class ListUserMfaDevicesResponse : SdkResponse
    {

        /// <summary>
        /// 虚拟MFA设备信息列表。
        /// </summary>
        [JsonProperty("virtual_mfa_devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<MfaDeviceResult> VirtualMfaDevices { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUserMfaDevicesResponse {\n");
            sb.Append("  virtualMfaDevices: ").Append(VirtualMfaDevices).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUserMfaDevicesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUserMfaDevicesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VirtualMfaDevices == input.VirtualMfaDevices ||
                    this.VirtualMfaDevices != null &&
                    input.VirtualMfaDevices != null &&
                    this.VirtualMfaDevices.SequenceEqual(input.VirtualMfaDevices)
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
                if (this.VirtualMfaDevices != null)
                    hashCode = hashCode * 59 + this.VirtualMfaDevices.GetHashCode();
                return hashCode;
            }
        }
    }
}
