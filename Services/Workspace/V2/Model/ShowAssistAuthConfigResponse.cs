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
    public class ShowAssistAuthConfigResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("otp_config_info", NullValueHandling = NullValueHandling.Ignore)]
        public OtpConfigInfo OtpConfigInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("radius_config_info", NullValueHandling = NullValueHandling.Ignore)]
        public RadiusConfigInfo RadiusConfigInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("radius_gateway_config_info", NullValueHandling = NullValueHandling.Ignore)]
        public RadiusGatewayConfigInfo RadiusGatewayConfigInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAssistAuthConfigResponse {\n");
            sb.Append("  otpConfigInfo: ").Append(OtpConfigInfo).Append("\n");
            sb.Append("  radiusConfigInfo: ").Append(RadiusConfigInfo).Append("\n");
            sb.Append("  radiusGatewayConfigInfo: ").Append(RadiusGatewayConfigInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssistAuthConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssistAuthConfigResponse input)
        {
            if (input == null) return false;
            if (this.OtpConfigInfo != input.OtpConfigInfo || (this.OtpConfigInfo != null && !this.OtpConfigInfo.Equals(input.OtpConfigInfo))) return false;
            if (this.RadiusConfigInfo != input.RadiusConfigInfo || (this.RadiusConfigInfo != null && !this.RadiusConfigInfo.Equals(input.RadiusConfigInfo))) return false;
            if (this.RadiusGatewayConfigInfo != input.RadiusGatewayConfigInfo || (this.RadiusGatewayConfigInfo != null && !this.RadiusGatewayConfigInfo.Equals(input.RadiusGatewayConfigInfo))) return false;

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
                if (this.OtpConfigInfo != null) hashCode = hashCode * 59 + this.OtpConfigInfo.GetHashCode();
                if (this.RadiusConfigInfo != null) hashCode = hashCode * 59 + this.RadiusConfigInfo.GetHashCode();
                if (this.RadiusGatewayConfigInfo != null) hashCode = hashCode * 59 + this.RadiusGatewayConfigInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
