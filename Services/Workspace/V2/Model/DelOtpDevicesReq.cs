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
    /// 
    /// </summary>
    public class DelOtpDevicesReq 
    {

        /// <summary>
        /// 待解绑的otp配置id数组。
        /// </summary>
        [JsonProperty("otp_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OtpIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DelOtpDevicesReq {\n");
            sb.Append("  otpIds: ").Append(OtpIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DelOtpDevicesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DelOtpDevicesReq input)
        {
            if (input == null) return false;
            if (this.OtpIds != input.OtpIds || (this.OtpIds != null && input.OtpIds != null && !this.OtpIds.SequenceEqual(input.OtpIds))) return false;

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
                if (this.OtpIds != null) hashCode = hashCode * 59 + this.OtpIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
