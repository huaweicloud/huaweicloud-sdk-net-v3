using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PasswordPolicyDto 
    {

        /// <summary>
        /// 最小密码长度
        /// </summary>
        [JsonProperty("minimum_password_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumPasswordLength { get; set; }

        /// <summary>
        /// 是否要求小写字母
        /// </summary>
        [JsonProperty("require_lowercase_characters", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequireLowercaseCharacters { get; set; }

        /// <summary>
        /// 是否要求数字
        /// </summary>
        [JsonProperty("require_numbers", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequireNumbers { get; set; }

        /// <summary>
        /// 是否要求特殊字符
        /// </summary>
        [JsonProperty("require_symbols", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequireSymbols { get; set; }

        /// <summary>
        /// 是否要求大写字母
        /// </summary>
        [JsonProperty("require_uppercase_characters", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequireUppercaseCharacters { get; set; }

        /// <summary>
        /// 密码有效期
        /// </summary>
        [JsonProperty("max_password_age", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPasswordAge { get; set; }

        /// <summary>
        /// 密码重复使用次数，默认只支持1
        /// </summary>
        [JsonProperty("password_reuse_prevention", NullValueHandling = NullValueHandling.Ignore)]
        public int? PasswordReusePrevention { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordPolicyDto {\n");
            sb.Append("  minimumPasswordLength: ").Append(MinimumPasswordLength).Append("\n");
            sb.Append("  requireLowercaseCharacters: ").Append(RequireLowercaseCharacters).Append("\n");
            sb.Append("  requireNumbers: ").Append(RequireNumbers).Append("\n");
            sb.Append("  requireSymbols: ").Append(RequireSymbols).Append("\n");
            sb.Append("  requireUppercaseCharacters: ").Append(RequireUppercaseCharacters).Append("\n");
            sb.Append("  maxPasswordAge: ").Append(MaxPasswordAge).Append("\n");
            sb.Append("  passwordReusePrevention: ").Append(PasswordReusePrevention).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PasswordPolicyDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PasswordPolicyDto input)
        {
            if (input == null) return false;
            if (this.MinimumPasswordLength != input.MinimumPasswordLength || (this.MinimumPasswordLength != null && !this.MinimumPasswordLength.Equals(input.MinimumPasswordLength))) return false;
            if (this.RequireLowercaseCharacters != input.RequireLowercaseCharacters || (this.RequireLowercaseCharacters != null && !this.RequireLowercaseCharacters.Equals(input.RequireLowercaseCharacters))) return false;
            if (this.RequireNumbers != input.RequireNumbers || (this.RequireNumbers != null && !this.RequireNumbers.Equals(input.RequireNumbers))) return false;
            if (this.RequireSymbols != input.RequireSymbols || (this.RequireSymbols != null && !this.RequireSymbols.Equals(input.RequireSymbols))) return false;
            if (this.RequireUppercaseCharacters != input.RequireUppercaseCharacters || (this.RequireUppercaseCharacters != null && !this.RequireUppercaseCharacters.Equals(input.RequireUppercaseCharacters))) return false;
            if (this.MaxPasswordAge != input.MaxPasswordAge || (this.MaxPasswordAge != null && !this.MaxPasswordAge.Equals(input.MaxPasswordAge))) return false;
            if (this.PasswordReusePrevention != input.PasswordReusePrevention || (this.PasswordReusePrevention != null && !this.PasswordReusePrevention.Equals(input.PasswordReusePrevention))) return false;

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
                if (this.MinimumPasswordLength != null) hashCode = hashCode * 59 + this.MinimumPasswordLength.GetHashCode();
                if (this.RequireLowercaseCharacters != null) hashCode = hashCode * 59 + this.RequireLowercaseCharacters.GetHashCode();
                if (this.RequireNumbers != null) hashCode = hashCode * 59 + this.RequireNumbers.GetHashCode();
                if (this.RequireSymbols != null) hashCode = hashCode * 59 + this.RequireSymbols.GetHashCode();
                if (this.RequireUppercaseCharacters != null) hashCode = hashCode * 59 + this.RequireUppercaseCharacters.GetHashCode();
                if (this.MaxPasswordAge != null) hashCode = hashCode * 59 + this.MaxPasswordAge.GetHashCode();
                if (this.PasswordReusePrevention != null) hashCode = hashCode * 59 + this.PasswordReusePrevention.GetHashCode();
                return hashCode;
            }
        }
    }
}
