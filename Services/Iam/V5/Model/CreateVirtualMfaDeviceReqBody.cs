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
    /// 
    /// </summary>
    public class CreateVirtualMfaDeviceReqBody 
    {

        /// <summary>
        /// MFA设备名称，长度为1到64个字符，只包含字母、数字、\&quot;_\&quot;和\&quot;-\&quot;的字符串。
        /// </summary>
        [JsonProperty("virtual_mfa_device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VirtualMfaDeviceName { get; set; }

        /// <summary>
        /// IAM用户ID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVirtualMfaDeviceReqBody {\n");
            sb.Append("  virtualMfaDeviceName: ").Append(VirtualMfaDeviceName).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateVirtualMfaDeviceReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateVirtualMfaDeviceReqBody input)
        {
            if (input == null) return false;
            if (this.VirtualMfaDeviceName != input.VirtualMfaDeviceName || (this.VirtualMfaDeviceName != null && !this.VirtualMfaDeviceName.Equals(input.VirtualMfaDeviceName))) return false;
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
                if (this.VirtualMfaDeviceName != null) hashCode = hashCode * 59 + this.VirtualMfaDeviceName.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }
    }
}
