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
    /// The full name of the user.
    /// </summary>
    public class NameDto 
    {

        /// <summary>
        /// 用户的姓氏
        /// </summary>
        [JsonProperty("family_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FamilyName { get; set; }

        /// <summary>
        /// 包含要显示的名称的格式化版本的字符串display.
        /// </summary>
        [JsonProperty("formatted", NullValueHandling = NullValueHandling.Ignore)]
        public string Formatted { get; set; }

        /// <summary>
        /// 用户的名字
        /// </summary>
        [JsonProperty("given_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GivenName { get; set; }

        /// <summary>
        /// 用户的尊称前缀
        /// </summary>
        [JsonProperty("honorific_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string HonorificPrefix { get; set; }

        /// <summary>
        /// 用户的尊称后缀
        /// </summary>
        [JsonProperty("honorific_suffix", NullValueHandling = NullValueHandling.Ignore)]
        public string HonorificSuffix { get; set; }

        /// <summary>
        /// 用户的中间名
        /// </summary>
        [JsonProperty("middle_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MiddleName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NameDto {\n");
            sb.Append("  familyName: ").Append(FamilyName).Append("\n");
            sb.Append("  formatted: ").Append(Formatted).Append("\n");
            sb.Append("  givenName: ").Append(GivenName).Append("\n");
            sb.Append("  honorificPrefix: ").Append(HonorificPrefix).Append("\n");
            sb.Append("  honorificSuffix: ").Append(HonorificSuffix).Append("\n");
            sb.Append("  middleName: ").Append(MiddleName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NameDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NameDto input)
        {
            if (input == null) return false;
            if (this.FamilyName != input.FamilyName || (this.FamilyName != null && !this.FamilyName.Equals(input.FamilyName))) return false;
            if (this.Formatted != input.Formatted || (this.Formatted != null && !this.Formatted.Equals(input.Formatted))) return false;
            if (this.GivenName != input.GivenName || (this.GivenName != null && !this.GivenName.Equals(input.GivenName))) return false;
            if (this.HonorificPrefix != input.HonorificPrefix || (this.HonorificPrefix != null && !this.HonorificPrefix.Equals(input.HonorificPrefix))) return false;
            if (this.HonorificSuffix != input.HonorificSuffix || (this.HonorificSuffix != null && !this.HonorificSuffix.Equals(input.HonorificSuffix))) return false;
            if (this.MiddleName != input.MiddleName || (this.MiddleName != null && !this.MiddleName.Equals(input.MiddleName))) return false;

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
                if (this.FamilyName != null) hashCode = hashCode * 59 + this.FamilyName.GetHashCode();
                if (this.Formatted != null) hashCode = hashCode * 59 + this.Formatted.GetHashCode();
                if (this.GivenName != null) hashCode = hashCode * 59 + this.GivenName.GetHashCode();
                if (this.HonorificPrefix != null) hashCode = hashCode * 59 + this.HonorificPrefix.GetHashCode();
                if (this.HonorificSuffix != null) hashCode = hashCode * 59 + this.HonorificSuffix.GetHashCode();
                if (this.MiddleName != null) hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                return hashCode;
            }
        }
    }
}
