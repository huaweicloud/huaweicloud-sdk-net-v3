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
    public class UpdateUserInformationOption 
    {

        /// <summary>
        /// IAM用户的新邮箱，符合邮箱格式，长度小于等于255字符。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// IAM用户的国家码+新手机号，手机号为纯数字，长度小于等于32字符。
        /// </summary>
        [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string Mobile { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUserInformationOption {\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  mobile: ").Append(Mobile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateUserInformationOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateUserInformationOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Mobile != null)
                    hashCode = hashCode * 59 + this.Mobile.GetHashCode();
                return hashCode;
            }
        }
    }
}
