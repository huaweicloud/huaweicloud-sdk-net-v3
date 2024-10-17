using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateClientIpTransparentTransmissionRequestBody 
    {

        /// <summary>
        /// 开启或关闭客户ip透传标志
        /// </summary>
        [JsonProperty("transparent_client_ip_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TransparentClientIpEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateClientIpTransparentTransmissionRequestBody {\n");
            sb.Append("  transparentClientIpEnable: ").Append(TransparentClientIpEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateClientIpTransparentTransmissionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateClientIpTransparentTransmissionRequestBody input)
        {
            if (input == null) return false;
            if (this.TransparentClientIpEnable != input.TransparentClientIpEnable || (this.TransparentClientIpEnable != null && !this.TransparentClientIpEnable.Equals(input.TransparentClientIpEnable))) return false;

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
                if (this.TransparentClientIpEnable != null) hashCode = hashCode * 59 + this.TransparentClientIpEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
