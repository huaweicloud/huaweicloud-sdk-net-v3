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
    public class PasswordPolicyResult 
    {

        /// <summary>
        /// 同一字符连续出现的最大次数。
        /// </summary>
        [JsonProperty("maximum_consecutive_identical_chars", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaximumConsecutiveIdenticalChars { get; set; }

        /// <summary>
        /// 密码最大字符数。
        /// </summary>
        [JsonProperty("maximum_password_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaximumPasswordLength { get; set; }

        /// <summary>
        /// 密码最短使用时间（分钟）。
        /// </summary>
        [JsonProperty("minimum_password_age", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumPasswordAge { get; set; }

        /// <summary>
        /// 密码最小字符数。
        /// </summary>
        [JsonProperty("minimum_password_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumPasswordLength { get; set; }

        /// <summary>
        /// 密码不能与历史密码重复次数。
        /// </summary>
        [JsonProperty("number_of_recent_passwords_disallowed", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfRecentPasswordsDisallowed { get; set; }

        /// <summary>
        /// 密码是否可以是用户名或用户名的反序。
        /// </summary>
        [JsonProperty("password_not_username_or_invert", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PasswordNotUsernameOrInvert { get; set; }

        /// <summary>
        /// 设置密码必须包含的字符要求。
        /// </summary>
        [JsonProperty("password_requirements", NullValueHandling = NullValueHandling.Ignore)]
        public string PasswordRequirements { get; set; }

        /// <summary>
        /// 密码有效期（天）。
        /// </summary>
        [JsonProperty("password_validity_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? PasswordValidityPeriod { get; set; }

        /// <summary>
        /// 至少包含字符种类的个数，取值区间[2,4]。
        /// </summary>
        [JsonProperty("password_char_combination", NullValueHandling = NullValueHandling.Ignore)]
        public int? PasswordCharCombination { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordPolicyResult {\n");
            sb.Append("  maximumConsecutiveIdenticalChars: ").Append(MaximumConsecutiveIdenticalChars).Append("\n");
            sb.Append("  maximumPasswordLength: ").Append(MaximumPasswordLength).Append("\n");
            sb.Append("  minimumPasswordAge: ").Append(MinimumPasswordAge).Append("\n");
            sb.Append("  minimumPasswordLength: ").Append(MinimumPasswordLength).Append("\n");
            sb.Append("  numberOfRecentPasswordsDisallowed: ").Append(NumberOfRecentPasswordsDisallowed).Append("\n");
            sb.Append("  passwordNotUsernameOrInvert: ").Append(PasswordNotUsernameOrInvert).Append("\n");
            sb.Append("  passwordRequirements: ").Append(PasswordRequirements).Append("\n");
            sb.Append("  passwordValidityPeriod: ").Append(PasswordValidityPeriod).Append("\n");
            sb.Append("  passwordCharCombination: ").Append(PasswordCharCombination).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PasswordPolicyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PasswordPolicyResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaximumConsecutiveIdenticalChars == input.MaximumConsecutiveIdenticalChars ||
                    (this.MaximumConsecutiveIdenticalChars != null &&
                    this.MaximumConsecutiveIdenticalChars.Equals(input.MaximumConsecutiveIdenticalChars))
                ) && 
                (
                    this.MaximumPasswordLength == input.MaximumPasswordLength ||
                    (this.MaximumPasswordLength != null &&
                    this.MaximumPasswordLength.Equals(input.MaximumPasswordLength))
                ) && 
                (
                    this.MinimumPasswordAge == input.MinimumPasswordAge ||
                    (this.MinimumPasswordAge != null &&
                    this.MinimumPasswordAge.Equals(input.MinimumPasswordAge))
                ) && 
                (
                    this.MinimumPasswordLength == input.MinimumPasswordLength ||
                    (this.MinimumPasswordLength != null &&
                    this.MinimumPasswordLength.Equals(input.MinimumPasswordLength))
                ) && 
                (
                    this.NumberOfRecentPasswordsDisallowed == input.NumberOfRecentPasswordsDisallowed ||
                    (this.NumberOfRecentPasswordsDisallowed != null &&
                    this.NumberOfRecentPasswordsDisallowed.Equals(input.NumberOfRecentPasswordsDisallowed))
                ) && 
                (
                    this.PasswordNotUsernameOrInvert == input.PasswordNotUsernameOrInvert ||
                    (this.PasswordNotUsernameOrInvert != null &&
                    this.PasswordNotUsernameOrInvert.Equals(input.PasswordNotUsernameOrInvert))
                ) && 
                (
                    this.PasswordRequirements == input.PasswordRequirements ||
                    (this.PasswordRequirements != null &&
                    this.PasswordRequirements.Equals(input.PasswordRequirements))
                ) && 
                (
                    this.PasswordValidityPeriod == input.PasswordValidityPeriod ||
                    (this.PasswordValidityPeriod != null &&
                    this.PasswordValidityPeriod.Equals(input.PasswordValidityPeriod))
                ) && 
                (
                    this.PasswordCharCombination == input.PasswordCharCombination ||
                    (this.PasswordCharCombination != null &&
                    this.PasswordCharCombination.Equals(input.PasswordCharCombination))
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
                if (this.MaximumConsecutiveIdenticalChars != null)
                    hashCode = hashCode * 59 + this.MaximumConsecutiveIdenticalChars.GetHashCode();
                if (this.MaximumPasswordLength != null)
                    hashCode = hashCode * 59 + this.MaximumPasswordLength.GetHashCode();
                if (this.MinimumPasswordAge != null)
                    hashCode = hashCode * 59 + this.MinimumPasswordAge.GetHashCode();
                if (this.MinimumPasswordLength != null)
                    hashCode = hashCode * 59 + this.MinimumPasswordLength.GetHashCode();
                if (this.NumberOfRecentPasswordsDisallowed != null)
                    hashCode = hashCode * 59 + this.NumberOfRecentPasswordsDisallowed.GetHashCode();
                if (this.PasswordNotUsernameOrInvert != null)
                    hashCode = hashCode * 59 + this.PasswordNotUsernameOrInvert.GetHashCode();
                if (this.PasswordRequirements != null)
                    hashCode = hashCode * 59 + this.PasswordRequirements.GetHashCode();
                if (this.PasswordValidityPeriod != null)
                    hashCode = hashCode * 59 + this.PasswordValidityPeriod.GetHashCode();
                if (this.PasswordCharCombination != null)
                    hashCode = hashCode * 59 + this.PasswordCharCombination.GetHashCode();
                return hashCode;
            }
        }
    }
}
