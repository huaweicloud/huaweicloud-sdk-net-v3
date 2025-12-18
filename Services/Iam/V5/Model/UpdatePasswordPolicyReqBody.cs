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
    public class UpdatePasswordPolicyReqBody 
    {

        /// <summary>
        /// 同一字符连续出现的最大次数，取值范围为[0,32]。
        /// </summary>
        [JsonProperty("maximum_consecutive_identical_chars", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaximumConsecutiveIdenticalChars { get; set; }

        /// <summary>
        /// 密码最短使用时间（分钟），取值范围为[0,1440]。
        /// </summary>
        [JsonProperty("minimum_password_age", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumPasswordAge { get; set; }

        /// <summary>
        /// 密码最小字符数，取值范围为[8,32]。
        /// </summary>
        [JsonProperty("minimum_password_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumPasswordLength { get; set; }

        /// <summary>
        /// 密码不能与历史密码重复次数，取值范围为[0,24]。
        /// </summary>
        [JsonProperty("password_reuse_prevention", NullValueHandling = NullValueHandling.Ignore)]
        public int? PasswordReusePrevention { get; set; }

        /// <summary>
        /// 密码是否可以是用户名或用户名的反序。默认值为true，为true时表示密码不可以是用户名或用户名的反序。
        /// </summary>
        [JsonProperty("password_not_username_or_invert", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PasswordNotUsernameOrInvert { get; set; }

        /// <summary>
        /// 密码有效期（天），取值范围为[0,180]。
        /// </summary>
        [JsonProperty("password_validity_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? PasswordValidityPeriod { get; set; }

        /// <summary>
        /// 至少包含字符种类的个数，取值范围为[2,4]。
        /// </summary>
        [JsonProperty("password_char_combination", NullValueHandling = NullValueHandling.Ignore)]
        public int? PasswordCharCombination { get; set; }

        /// <summary>
        /// 是否允许IAM用户修改自己的密码，不适用于根用户。
        /// </summary>
        [JsonProperty("allow_user_to_change_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowUserToChangePassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePasswordPolicyReqBody {\n");
            sb.Append("  maximumConsecutiveIdenticalChars: ").Append(MaximumConsecutiveIdenticalChars).Append("\n");
            sb.Append("  minimumPasswordAge: ").Append(MinimumPasswordAge).Append("\n");
            sb.Append("  minimumPasswordLength: ").Append(MinimumPasswordLength).Append("\n");
            sb.Append("  passwordReusePrevention: ").Append(PasswordReusePrevention).Append("\n");
            sb.Append("  passwordNotUsernameOrInvert: ").Append(PasswordNotUsernameOrInvert).Append("\n");
            sb.Append("  passwordValidityPeriod: ").Append(PasswordValidityPeriod).Append("\n");
            sb.Append("  passwordCharCombination: ").Append(PasswordCharCombination).Append("\n");
            sb.Append("  allowUserToChangePassword: ").Append(AllowUserToChangePassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePasswordPolicyReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePasswordPolicyReqBody input)
        {
            if (input == null) return false;
            if (this.MaximumConsecutiveIdenticalChars != input.MaximumConsecutiveIdenticalChars || (this.MaximumConsecutiveIdenticalChars != null && !this.MaximumConsecutiveIdenticalChars.Equals(input.MaximumConsecutiveIdenticalChars))) return false;
            if (this.MinimumPasswordAge != input.MinimumPasswordAge || (this.MinimumPasswordAge != null && !this.MinimumPasswordAge.Equals(input.MinimumPasswordAge))) return false;
            if (this.MinimumPasswordLength != input.MinimumPasswordLength || (this.MinimumPasswordLength != null && !this.MinimumPasswordLength.Equals(input.MinimumPasswordLength))) return false;
            if (this.PasswordReusePrevention != input.PasswordReusePrevention || (this.PasswordReusePrevention != null && !this.PasswordReusePrevention.Equals(input.PasswordReusePrevention))) return false;
            if (this.PasswordNotUsernameOrInvert != input.PasswordNotUsernameOrInvert || (this.PasswordNotUsernameOrInvert != null && !this.PasswordNotUsernameOrInvert.Equals(input.PasswordNotUsernameOrInvert))) return false;
            if (this.PasswordValidityPeriod != input.PasswordValidityPeriod || (this.PasswordValidityPeriod != null && !this.PasswordValidityPeriod.Equals(input.PasswordValidityPeriod))) return false;
            if (this.PasswordCharCombination != input.PasswordCharCombination || (this.PasswordCharCombination != null && !this.PasswordCharCombination.Equals(input.PasswordCharCombination))) return false;
            if (this.AllowUserToChangePassword != input.AllowUserToChangePassword || (this.AllowUserToChangePassword != null && !this.AllowUserToChangePassword.Equals(input.AllowUserToChangePassword))) return false;

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
                if (this.MaximumConsecutiveIdenticalChars != null) hashCode = hashCode * 59 + this.MaximumConsecutiveIdenticalChars.GetHashCode();
                if (this.MinimumPasswordAge != null) hashCode = hashCode * 59 + this.MinimumPasswordAge.GetHashCode();
                if (this.MinimumPasswordLength != null) hashCode = hashCode * 59 + this.MinimumPasswordLength.GetHashCode();
                if (this.PasswordReusePrevention != null) hashCode = hashCode * 59 + this.PasswordReusePrevention.GetHashCode();
                if (this.PasswordNotUsernameOrInvert != null) hashCode = hashCode * 59 + this.PasswordNotUsernameOrInvert.GetHashCode();
                if (this.PasswordValidityPeriod != null) hashCode = hashCode * 59 + this.PasswordValidityPeriod.GetHashCode();
                if (this.PasswordCharCombination != null) hashCode = hashCode * 59 + this.PasswordCharCombination.GetHashCode();
                if (this.AllowUserToChangePassword != null) hashCode = hashCode * 59 + this.AllowUserToChangePassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
