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
    public class ConfigByOption 
    {

        /// <summary>
        /// 密码强度策略的正则表达式。(当option为password_regex时返回)
        /// </summary>
        [JsonProperty("password_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string PasswordRegex { get; set; }

        /// <summary>
        /// 密码强度策略的描述。(当option为password_regex_description时返回)
        /// </summary>
        [JsonProperty("password_regex_description", NullValueHandling = NullValueHandling.Ignore)]
        public string PasswordRegexDescription { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigByOption {\n");
            sb.Append("  passwordRegex: ").Append(PasswordRegex).Append("\n");
            sb.Append("  passwordRegexDescription: ").Append(PasswordRegexDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigByOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigByOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PasswordRegex == input.PasswordRegex ||
                    (this.PasswordRegex != null &&
                    this.PasswordRegex.Equals(input.PasswordRegex))
                ) && 
                (
                    this.PasswordRegexDescription == input.PasswordRegexDescription ||
                    (this.PasswordRegexDescription != null &&
                    this.PasswordRegexDescription.Equals(input.PasswordRegexDescription))
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
                if (this.PasswordRegex != null)
                    hashCode = hashCode * 59 + this.PasswordRegex.GetHashCode();
                if (this.PasswordRegexDescription != null)
                    hashCode = hashCode * 59 + this.PasswordRegexDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
