using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListOtpDevicesByUserIdResponse : SdkResponse
    {

        /// <summary>
        /// otp设备。
        /// </summary>
        [JsonProperty("otp_devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<OtpDevice> OtpDevices { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOtpDevicesByUserIdResponse {\n");
            sb.Append("  otpDevices: ").Append(OtpDevices).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOtpDevicesByUserIdResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOtpDevicesByUserIdResponse input)
        {
            if (input == null) return false;
            if (this.OtpDevices != input.OtpDevices || (this.OtpDevices != null && input.OtpDevices != null && !this.OtpDevices.SequenceEqual(input.OtpDevices))) return false;

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
                if (this.OtpDevices != null) hashCode = hashCode * 59 + this.OtpDevices.GetHashCode();
                return hashCode;
            }
        }
    }
}
