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
    /// 滑块验证码相关配置。
    /// </summary>
    public class LoginCaptchaConfig 
    {

        /// <summary>
        /// 是否开启滑块验证码。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 用户登录失败 trigger_threshold 次后开始要求验证码认证。验证码不启用时无意义，启用时若不传默认为 3。
        /// </summary>
        [JsonProperty("trigger_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginCaptchaConfig {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  triggerThreshold: ").Append(TriggerThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoginCaptchaConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoginCaptchaConfig input)
        {
            if (input == null) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.TriggerThreshold != input.TriggerThreshold || (this.TriggerThreshold != null && !this.TriggerThreshold.Equals(input.TriggerThreshold))) return false;

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
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.TriggerThreshold != null) hashCode = hashCode * 59 + this.TriggerThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
