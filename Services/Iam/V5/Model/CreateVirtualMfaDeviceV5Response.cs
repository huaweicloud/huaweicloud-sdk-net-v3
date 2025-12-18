using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateVirtualMfaDeviceV5Response : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("virtual_mfa_device", NullValueHandling = NullValueHandling.Ignore)]
        public VirtualMfaDevice VirtualMfaDevice { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVirtualMfaDeviceV5Response {\n");
            sb.Append("  virtualMfaDevice: ").Append(VirtualMfaDevice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateVirtualMfaDeviceV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateVirtualMfaDeviceV5Response input)
        {
            if (input == null) return false;
            if (this.VirtualMfaDevice != input.VirtualMfaDevice || (this.VirtualMfaDevice != null && !this.VirtualMfaDevice.Equals(input.VirtualMfaDevice))) return false;

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
                if (this.VirtualMfaDevice != null) hashCode = hashCode * 59 + this.VirtualMfaDevice.GetHashCode();
                return hashCode;
            }
        }
    }
}
