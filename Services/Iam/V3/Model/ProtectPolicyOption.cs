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
    /// 操作保护策略
    /// </summary>
    public class ProtectPolicyOption 
    {

        /// <summary>
        /// 是否开启操作保护，开启为\&quot;true\&quot;，未开启为\&quot;false\&quot;。
        /// </summary>
        [JsonProperty("operation_protection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OperationProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("allow_user", NullValueHandling = NullValueHandling.Ignore)]
        public AllowUserBody AllowUser { get; set; }

        /// <summary>
        /// 操作保护验证指定手机号码。示例：0086-123456789。
        /// </summary>
        [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string Mobile { get; set; }

        /// <summary>
        /// 是否指定人员验证。on为指定人员验证，必须填写scene参数。off为操作员验证。
        /// </summary>
        [JsonProperty("admin_check", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminCheck { get; set; }

        /// <summary>
        /// 操作保护验证指定邮件地址。示例：example@email.com。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 操作保护指定人员验证方式，admin_check为on时，必须填写。包括mobile、email。
        /// </summary>
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public string Scene { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtectPolicyOption {\n");
            sb.Append("  operationProtection: ").Append(OperationProtection).Append("\n");
            sb.Append("  allowUser: ").Append(AllowUser).Append("\n");
            sb.Append("  mobile: ").Append(Mobile).Append("\n");
            sb.Append("  adminCheck: ").Append(AdminCheck).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProtectPolicyOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProtectPolicyOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OperationProtection == input.OperationProtection ||
                    (this.OperationProtection != null &&
                    this.OperationProtection.Equals(input.OperationProtection))
                ) && 
                (
                    this.AllowUser == input.AllowUser ||
                    (this.AllowUser != null &&
                    this.AllowUser.Equals(input.AllowUser))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.AdminCheck == input.AdminCheck ||
                    (this.AdminCheck != null &&
                    this.AdminCheck.Equals(input.AdminCheck))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Scene == input.Scene ||
                    (this.Scene != null &&
                    this.Scene.Equals(input.Scene))
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
                if (this.OperationProtection != null)
                    hashCode = hashCode * 59 + this.OperationProtection.GetHashCode();
                if (this.AllowUser != null)
                    hashCode = hashCode * 59 + this.AllowUser.GetHashCode();
                if (this.Mobile != null)
                    hashCode = hashCode * 59 + this.Mobile.GetHashCode();
                if (this.AdminCheck != null)
                    hashCode = hashCode * 59 + this.AdminCheck.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Scene != null)
                    hashCode = hashCode * 59 + this.Scene.GetHashCode();
                return hashCode;
            }
        }
    }
}
