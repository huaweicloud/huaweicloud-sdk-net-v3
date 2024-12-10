using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 生成随机密码入参
    /// </summary>
    public class CreatePasswordRequestBody 
    {

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("password_policy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PasswordPolicyName { get; set; }

        /// <summary>
        /// 长度，默认32
        /// </summary>
        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public int? Length { get; set; }

        /// <summary>
        /// 需要排除的字符
        /// </summary>
        [JsonProperty("exclude_characters", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcludeCharacters { get; set; }

        /// <summary>
        /// 排除小写字母，默认false
        /// </summary>
        [JsonProperty("exclude_lowercase", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeLowercase { get; set; }

        /// <summary>
        /// 排除大写字母，默认false
        /// </summary>
        [JsonProperty("exclude_uppercase", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeUppercase { get; set; }

        /// <summary>
        /// 排除数字，默认false
        /// </summary>
        [JsonProperty("exclude_numbers", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeNumbers { get; set; }

        /// <summary>
        /// 排除符号，默认false
        /// </summary>
        [JsonProperty("exclude_punctuation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludePunctuation { get; set; }

        /// <summary>
        /// 包含空格，默认false
        /// </summary>
        [JsonProperty("include_space", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSpace { get; set; }

        /// <summary>
        /// 需要每个包含的类型，默认false
        /// </summary>
        [JsonProperty("require_each_included_type", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequireEachIncludedType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePasswordRequestBody {\n");
            sb.Append("  passwordPolicyName: ").Append(PasswordPolicyName).Append("\n");
            sb.Append("  length: ").Append(Length).Append("\n");
            sb.Append("  excludeCharacters: ").Append(ExcludeCharacters).Append("\n");
            sb.Append("  excludeLowercase: ").Append(ExcludeLowercase).Append("\n");
            sb.Append("  excludeUppercase: ").Append(ExcludeUppercase).Append("\n");
            sb.Append("  excludeNumbers: ").Append(ExcludeNumbers).Append("\n");
            sb.Append("  excludePunctuation: ").Append(ExcludePunctuation).Append("\n");
            sb.Append("  includeSpace: ").Append(IncludeSpace).Append("\n");
            sb.Append("  requireEachIncludedType: ").Append(RequireEachIncludedType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePasswordRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePasswordRequestBody input)
        {
            if (input == null) return false;
            if (this.PasswordPolicyName != input.PasswordPolicyName || (this.PasswordPolicyName != null && !this.PasswordPolicyName.Equals(input.PasswordPolicyName))) return false;
            if (this.Length != input.Length || (this.Length != null && !this.Length.Equals(input.Length))) return false;
            if (this.ExcludeCharacters != input.ExcludeCharacters || (this.ExcludeCharacters != null && !this.ExcludeCharacters.Equals(input.ExcludeCharacters))) return false;
            if (this.ExcludeLowercase != input.ExcludeLowercase || (this.ExcludeLowercase != null && !this.ExcludeLowercase.Equals(input.ExcludeLowercase))) return false;
            if (this.ExcludeUppercase != input.ExcludeUppercase || (this.ExcludeUppercase != null && !this.ExcludeUppercase.Equals(input.ExcludeUppercase))) return false;
            if (this.ExcludeNumbers != input.ExcludeNumbers || (this.ExcludeNumbers != null && !this.ExcludeNumbers.Equals(input.ExcludeNumbers))) return false;
            if (this.ExcludePunctuation != input.ExcludePunctuation || (this.ExcludePunctuation != null && !this.ExcludePunctuation.Equals(input.ExcludePunctuation))) return false;
            if (this.IncludeSpace != input.IncludeSpace || (this.IncludeSpace != null && !this.IncludeSpace.Equals(input.IncludeSpace))) return false;
            if (this.RequireEachIncludedType != input.RequireEachIncludedType || (this.RequireEachIncludedType != null && !this.RequireEachIncludedType.Equals(input.RequireEachIncludedType))) return false;

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
                if (this.PasswordPolicyName != null) hashCode = hashCode * 59 + this.PasswordPolicyName.GetHashCode();
                if (this.Length != null) hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.ExcludeCharacters != null) hashCode = hashCode * 59 + this.ExcludeCharacters.GetHashCode();
                if (this.ExcludeLowercase != null) hashCode = hashCode * 59 + this.ExcludeLowercase.GetHashCode();
                if (this.ExcludeUppercase != null) hashCode = hashCode * 59 + this.ExcludeUppercase.GetHashCode();
                if (this.ExcludeNumbers != null) hashCode = hashCode * 59 + this.ExcludeNumbers.GetHashCode();
                if (this.ExcludePunctuation != null) hashCode = hashCode * 59 + this.ExcludePunctuation.GetHashCode();
                if (this.IncludeSpace != null) hashCode = hashCode * 59 + this.IncludeSpace.GetHashCode();
                if (this.RequireEachIncludedType != null) hashCode = hashCode * 59 + this.RequireEachIncludedType.GetHashCode();
                return hashCode;
            }
        }
    }
}
