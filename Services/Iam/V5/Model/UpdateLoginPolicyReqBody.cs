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
    public class UpdateLoginPolicyReqBody 
    {

        /// <summary>
        /// 如果IAM用户在该值设置的有效期（天）内未登录，则被停用，不适用于根用户，取值范围为[0,240]。
        /// </summary>
        [JsonProperty("user_validity_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserValidityPeriod { get; set; }

        /// <summary>
        /// 登录提示信息，不能包含特定字符\&quot;@\&quot;、\&quot;#\&quot;、\&quot;%\&quot;、\&quot;&amp;\&quot;、\&quot;&lt;\&quot;、\&quot;&gt;\&quot;、\&quot;\\\\\&quot;、\&quot;$\&quot;、\&quot;^\&quot;和\&quot;*\&quot;的字符串。
        /// </summary>
        [JsonProperty("custom_info_for_login", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomInfoForLogin { get; set; }

        /// <summary>
        /// IAM用户登录锁定时长（分钟），取值范围为[15,1440]。
        /// </summary>
        [JsonProperty("lockout_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? LockoutDuration { get; set; }

        /// <summary>
        /// 限定时间内登录失败次数，取值范围为[3,10]。
        /// </summary>
        [JsonProperty("login_failed_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? LoginFailedTimes { get; set; }

        /// <summary>
        /// 限定时间长度（分钟），取值范围为[15,60]。
        /// </summary>
        [JsonProperty("period_with_login_failures", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodWithLoginFailures { get; set; }

        /// <summary>
        /// 登录会话失效时间，取值范围为[15,1440]。
        /// </summary>
        [JsonProperty("session_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// 是否显示最近一次的登录信息。
        /// </summary>
        [JsonProperty("show_recent_login_info", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowRecentLoginInfo { get; set; }

        /// <summary>
        /// 允许访问的IP地址或网段，例如\&quot;xxx.xxx.xxx.xxx/24\&quot;。
        /// </summary>
        [JsonProperty("allow_address_netmasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowAddressNetmask> AllowAddressNetmasks { get; set; }

        /// <summary>
        /// 允许访问的IP地址区间，取值为IP地址区间，例如\&quot;0.0.0.0-255.255.255.255\&quot;。
        /// </summary>
        [JsonProperty("allow_ip_ranges", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowIpRange> AllowIpRanges { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLoginPolicyReqBody {\n");
            sb.Append("  userValidityPeriod: ").Append(UserValidityPeriod).Append("\n");
            sb.Append("  customInfoForLogin: ").Append(CustomInfoForLogin).Append("\n");
            sb.Append("  lockoutDuration: ").Append(LockoutDuration).Append("\n");
            sb.Append("  loginFailedTimes: ").Append(LoginFailedTimes).Append("\n");
            sb.Append("  periodWithLoginFailures: ").Append(PeriodWithLoginFailures).Append("\n");
            sb.Append("  sessionTimeout: ").Append(SessionTimeout).Append("\n");
            sb.Append("  showRecentLoginInfo: ").Append(ShowRecentLoginInfo).Append("\n");
            sb.Append("  allowAddressNetmasks: ").Append(AllowAddressNetmasks).Append("\n");
            sb.Append("  allowIpRanges: ").Append(AllowIpRanges).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLoginPolicyReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLoginPolicyReqBody input)
        {
            if (input == null) return false;
            if (this.UserValidityPeriod != input.UserValidityPeriod || (this.UserValidityPeriod != null && !this.UserValidityPeriod.Equals(input.UserValidityPeriod))) return false;
            if (this.CustomInfoForLogin != input.CustomInfoForLogin || (this.CustomInfoForLogin != null && !this.CustomInfoForLogin.Equals(input.CustomInfoForLogin))) return false;
            if (this.LockoutDuration != input.LockoutDuration || (this.LockoutDuration != null && !this.LockoutDuration.Equals(input.LockoutDuration))) return false;
            if (this.LoginFailedTimes != input.LoginFailedTimes || (this.LoginFailedTimes != null && !this.LoginFailedTimes.Equals(input.LoginFailedTimes))) return false;
            if (this.PeriodWithLoginFailures != input.PeriodWithLoginFailures || (this.PeriodWithLoginFailures != null && !this.PeriodWithLoginFailures.Equals(input.PeriodWithLoginFailures))) return false;
            if (this.SessionTimeout != input.SessionTimeout || (this.SessionTimeout != null && !this.SessionTimeout.Equals(input.SessionTimeout))) return false;
            if (this.ShowRecentLoginInfo != input.ShowRecentLoginInfo || (this.ShowRecentLoginInfo != null && !this.ShowRecentLoginInfo.Equals(input.ShowRecentLoginInfo))) return false;
            if (this.AllowAddressNetmasks != input.AllowAddressNetmasks || (this.AllowAddressNetmasks != null && input.AllowAddressNetmasks != null && !this.AllowAddressNetmasks.SequenceEqual(input.AllowAddressNetmasks))) return false;
            if (this.AllowIpRanges != input.AllowIpRanges || (this.AllowIpRanges != null && input.AllowIpRanges != null && !this.AllowIpRanges.SequenceEqual(input.AllowIpRanges))) return false;

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
                if (this.UserValidityPeriod != null) hashCode = hashCode * 59 + this.UserValidityPeriod.GetHashCode();
                if (this.CustomInfoForLogin != null) hashCode = hashCode * 59 + this.CustomInfoForLogin.GetHashCode();
                if (this.LockoutDuration != null) hashCode = hashCode * 59 + this.LockoutDuration.GetHashCode();
                if (this.LoginFailedTimes != null) hashCode = hashCode * 59 + this.LoginFailedTimes.GetHashCode();
                if (this.PeriodWithLoginFailures != null) hashCode = hashCode * 59 + this.PeriodWithLoginFailures.GetHashCode();
                if (this.SessionTimeout != null) hashCode = hashCode * 59 + this.SessionTimeout.GetHashCode();
                if (this.ShowRecentLoginInfo != null) hashCode = hashCode * 59 + this.ShowRecentLoginInfo.GetHashCode();
                if (this.AllowAddressNetmasks != null) hashCode = hashCode * 59 + this.AllowAddressNetmasks.GetHashCode();
                if (this.AllowIpRanges != null) hashCode = hashCode * 59 + this.AllowIpRanges.GetHashCode();
                return hashCode;
            }
        }
    }
}
