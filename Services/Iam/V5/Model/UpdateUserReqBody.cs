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
    /// The request body of update user request.
    /// </summary>
    public class UpdateUserReqBody 
    {

        /// <summary>
        /// IAM用户名，长度为1到64个字符，只包含字母、数字、\&quot;_\&quot;、\&quot;-\&quot;、\&quot;.\&quot;和空格的字符串，且首位不能为数字。
        /// </summary>
        [JsonProperty("new_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NewUserName { get; set; }

        /// <summary>
        /// IAM用户描述信息，长度为0到255个字符，不能包含特定字符\&quot;@\&quot;、\&quot;#\&quot;、\&quot;%\&quot;、\&quot;&amp;\&quot;、\&quot;&lt;\&quot;、\&quot;&gt;\&quot;、\&quot;\\\\\&quot;、\&quot;$\&quot;、\&quot;^\&quot;和\&quot;*\&quot;的字符串。
        /// </summary>
        [JsonProperty("new_description", NullValueHandling = NullValueHandling.Ignore)]
        public string NewDescription { get; set; }

        /// <summary>
        /// IAM用户是否启用。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUserReqBody {\n");
            sb.Append("  newUserName: ").Append(NewUserName).Append("\n");
            sb.Append("  newDescription: ").Append(NewDescription).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateUserReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateUserReqBody input)
        {
            if (input == null) return false;
            if (this.NewUserName != input.NewUserName || (this.NewUserName != null && !this.NewUserName.Equals(input.NewUserName))) return false;
            if (this.NewDescription != input.NewDescription || (this.NewDescription != null && !this.NewDescription.Equals(input.NewDescription))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;

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
                if (this.NewUserName != null) hashCode = hashCode * 59 + this.NewUserName.GetHashCode();
                if (this.NewDescription != null) hashCode = hashCode * 59 + this.NewDescription.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
