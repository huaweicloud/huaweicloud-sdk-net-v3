using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterOIDC.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class StartDeviceAuthorizationResponse : SdkResponse
    {

        /// <summary>
        /// 设备在轮询会话令牌时使用的设备码
        /// </summary>
        [JsonProperty("device_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceCode { get; set; }

        /// <summary>
        /// 设备码失效时间（以秒为单位）
        /// </summary>
        [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// 指示轮询会话时，客户端在两次尝试之间必须等待的秒数
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// 一次性用户验证码。授权正在使用的设备时需要此操作
        /// </summary>
        [JsonProperty("user_code", NullValueHandling = NullValueHandling.Ignore)]
        public string UserCode { get; set; }

        /// <summary>
        /// 使用一次性用户验证码授权设备的验证页面的URI
        /// </summary>
        [JsonProperty("verification_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationUri { get; set; }

        /// <summary>
        /// 客户端可用于自动启动浏览器的备用URL。此过程跳过用户访问验证页面并输入代码的手动步骤
        /// </summary>
        [JsonProperty("verification_uri_complete", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationUriComplete { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartDeviceAuthorizationResponse {\n");
            sb.Append("  deviceCode: ").Append(DeviceCode).Append("\n");
            sb.Append("  expiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  userCode: ").Append(UserCode).Append("\n");
            sb.Append("  verificationUri: ").Append(VerificationUri).Append("\n");
            sb.Append("  verificationUriComplete: ").Append(VerificationUriComplete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartDeviceAuthorizationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartDeviceAuthorizationResponse input)
        {
            if (input == null) return false;
            if (this.DeviceCode != input.DeviceCode || (this.DeviceCode != null && !this.DeviceCode.Equals(input.DeviceCode))) return false;
            if (this.ExpiresIn != input.ExpiresIn || (this.ExpiresIn != null && !this.ExpiresIn.Equals(input.ExpiresIn))) return false;
            if (this.Interval != input.Interval || (this.Interval != null && !this.Interval.Equals(input.Interval))) return false;
            if (this.UserCode != input.UserCode || (this.UserCode != null && !this.UserCode.Equals(input.UserCode))) return false;
            if (this.VerificationUri != input.VerificationUri || (this.VerificationUri != null && !this.VerificationUri.Equals(input.VerificationUri))) return false;
            if (this.VerificationUriComplete != input.VerificationUriComplete || (this.VerificationUriComplete != null && !this.VerificationUriComplete.Equals(input.VerificationUriComplete))) return false;

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
                if (this.DeviceCode != null) hashCode = hashCode * 59 + this.DeviceCode.GetHashCode();
                if (this.ExpiresIn != null) hashCode = hashCode * 59 + this.ExpiresIn.GetHashCode();
                if (this.Interval != null) hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.UserCode != null) hashCode = hashCode * 59 + this.UserCode.GetHashCode();
                if (this.VerificationUri != null) hashCode = hashCode * 59 + this.VerificationUri.GetHashCode();
                if (this.VerificationUriComplete != null) hashCode = hashCode * 59 + this.VerificationUriComplete.GetHashCode();
                return hashCode;
            }
        }
    }
}
