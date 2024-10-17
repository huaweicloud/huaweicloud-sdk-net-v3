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
    public class UpdateDomainProtectPolicyResponseBodyProtectPolicy 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("allow_user", NullValueHandling = NullValueHandling.Ignore)]
        public AllowUserBody AllowUser { get; set; }

        /// <summary>
        /// 是否开启操作保护，取值范围true或false。
        /// </summary>
        [JsonProperty("operation_protection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OperationProtection { get; set; }

        /// <summary>
        /// 是否指定人员验证。on为指定人员验证，必须填写scene参数。off为操作员验证。
        /// </summary>
        [JsonProperty("admin_check", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminCheck { get; set; }

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
            sb.Append("class UpdateDomainProtectPolicyResponseBodyProtectPolicy {\n");
            sb.Append("  allowUser: ").Append(AllowUser).Append("\n");
            sb.Append("  operationProtection: ").Append(OperationProtection).Append("\n");
            sb.Append("  adminCheck: ").Append(AdminCheck).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDomainProtectPolicyResponseBodyProtectPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDomainProtectPolicyResponseBodyProtectPolicy input)
        {
            if (input == null) return false;
            if (this.AllowUser != input.AllowUser || (this.AllowUser != null && !this.AllowUser.Equals(input.AllowUser))) return false;
            if (this.OperationProtection != input.OperationProtection || (this.OperationProtection != null && !this.OperationProtection.Equals(input.OperationProtection))) return false;
            if (this.AdminCheck != input.AdminCheck || (this.AdminCheck != null && !this.AdminCheck.Equals(input.AdminCheck))) return false;
            if (this.Scene != input.Scene || (this.Scene != null && !this.Scene.Equals(input.Scene))) return false;

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
                if (this.AllowUser != null) hashCode = hashCode * 59 + this.AllowUser.GetHashCode();
                if (this.OperationProtection != null) hashCode = hashCode * 59 + this.OperationProtection.GetHashCode();
                if (this.AdminCheck != null) hashCode = hashCode * 59 + this.AdminCheck.GetHashCode();
                if (this.Scene != null) hashCode = hashCode * 59 + this.Scene.GetHashCode();
                return hashCode;
            }
        }
    }
}
