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
    /// 
    /// </summary>
    public class LoginPolicyOption 
    {

        /// <summary>
        /// 账号在该值设置的有效期内未使用，则被停用。
        /// </summary>
        [JsonProperty("account_validity_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountValidityPeriod { get; set; }

        /// <summary>
        /// 登录提示信息。
        /// </summary>
        [JsonProperty("custom_info_for_login", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomInfoForLogin { get; set; }

        /// <summary>
        /// 帐号锁定时长（分钟），取值范围[15,30]。
        /// </summary>
        [JsonProperty("lockout_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? LockoutDuration { get; set; }

        /// <summary>
        /// 限定时间内登录失败次数，取值范围[3,10]。
        /// </summary>
        [JsonProperty("login_failed_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? LoginFailedTimes { get; set; }

        /// <summary>
        /// 限定时间长度（分钟），取值范围[15,60]。
        /// </summary>
        [JsonProperty("period_with_login_failures", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodWithLoginFailures { get; set; }

        /// <summary>
        /// 登录会话失效时间，取值范围[15,1440]。
        /// </summary>
        [JsonProperty("session_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// 显示最近一次的登录信息。取值范围true或false。
        /// </summary>
        [JsonProperty("show_recent_login_info", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowRecentLoginInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginPolicyOption {\n");
            sb.Append("  accountValidityPeriod: ").Append(AccountValidityPeriod).Append("\n");
            sb.Append("  customInfoForLogin: ").Append(CustomInfoForLogin).Append("\n");
            sb.Append("  lockoutDuration: ").Append(LockoutDuration).Append("\n");
            sb.Append("  loginFailedTimes: ").Append(LoginFailedTimes).Append("\n");
            sb.Append("  periodWithLoginFailures: ").Append(PeriodWithLoginFailures).Append("\n");
            sb.Append("  sessionTimeout: ").Append(SessionTimeout).Append("\n");
            sb.Append("  showRecentLoginInfo: ").Append(ShowRecentLoginInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoginPolicyOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoginPolicyOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountValidityPeriod == input.AccountValidityPeriod ||
                    (this.AccountValidityPeriod != null &&
                    this.AccountValidityPeriod.Equals(input.AccountValidityPeriod))
                ) && 
                (
                    this.CustomInfoForLogin == input.CustomInfoForLogin ||
                    (this.CustomInfoForLogin != null &&
                    this.CustomInfoForLogin.Equals(input.CustomInfoForLogin))
                ) && 
                (
                    this.LockoutDuration == input.LockoutDuration ||
                    (this.LockoutDuration != null &&
                    this.LockoutDuration.Equals(input.LockoutDuration))
                ) && 
                (
                    this.LoginFailedTimes == input.LoginFailedTimes ||
                    (this.LoginFailedTimes != null &&
                    this.LoginFailedTimes.Equals(input.LoginFailedTimes))
                ) && 
                (
                    this.PeriodWithLoginFailures == input.PeriodWithLoginFailures ||
                    (this.PeriodWithLoginFailures != null &&
                    this.PeriodWithLoginFailures.Equals(input.PeriodWithLoginFailures))
                ) && 
                (
                    this.SessionTimeout == input.SessionTimeout ||
                    (this.SessionTimeout != null &&
                    this.SessionTimeout.Equals(input.SessionTimeout))
                ) && 
                (
                    this.ShowRecentLoginInfo == input.ShowRecentLoginInfo ||
                    (this.ShowRecentLoginInfo != null &&
                    this.ShowRecentLoginInfo.Equals(input.ShowRecentLoginInfo))
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
                if (this.AccountValidityPeriod != null)
                    hashCode = hashCode * 59 + this.AccountValidityPeriod.GetHashCode();
                if (this.CustomInfoForLogin != null)
                    hashCode = hashCode * 59 + this.CustomInfoForLogin.GetHashCode();
                if (this.LockoutDuration != null)
                    hashCode = hashCode * 59 + this.LockoutDuration.GetHashCode();
                if (this.LoginFailedTimes != null)
                    hashCode = hashCode * 59 + this.LoginFailedTimes.GetHashCode();
                if (this.PeriodWithLoginFailures != null)
                    hashCode = hashCode * 59 + this.PeriodWithLoginFailures.GetHashCode();
                if (this.SessionTimeout != null)
                    hashCode = hashCode * 59 + this.SessionTimeout.GetHashCode();
                if (this.ShowRecentLoginInfo != null)
                    hashCode = hashCode * 59 + this.ShowRecentLoginInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
