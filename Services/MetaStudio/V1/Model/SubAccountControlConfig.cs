using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 子账号控制配置
    /// </summary>
    public class SubAccountControlConfig 
    {

        /// <summary>
        /// 子账号业务是否单独控制。
        /// </summary>
        [JsonProperty("separately_controlled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SeparatelyControlled { get; set; }

        /// <summary>
        /// 子账号类型。 * IAM_USER: 使用调用者IAM user id填充 X-App-UserId。如果请求中携带X-App-UserId，也会被忽略替换。
        /// </summary>
        [JsonProperty("sub_account_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubAccountType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubAccountControlConfig {\n");
            sb.Append("  separatelyControlled: ").Append(SeparatelyControlled).Append("\n");
            sb.Append("  subAccountType: ").Append(SubAccountType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubAccountControlConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubAccountControlConfig input)
        {
            if (input == null) return false;
            if (this.SeparatelyControlled != input.SeparatelyControlled || (this.SeparatelyControlled != null && !this.SeparatelyControlled.Equals(input.SeparatelyControlled))) return false;
            if (this.SubAccountType != input.SubAccountType || (this.SubAccountType != null && !this.SubAccountType.Equals(input.SubAccountType))) return false;

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
                if (this.SeparatelyControlled != null) hashCode = hashCode * 59 + this.SeparatelyControlled.GetHashCode();
                if (this.SubAccountType != null) hashCode = hashCode * 59 + this.SubAccountType.GetHashCode();
                return hashCode;
            }
        }
    }
}
