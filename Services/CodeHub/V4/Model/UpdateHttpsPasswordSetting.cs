using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateHttpsPasswordSetting 
    {

        /// <summary>
        /// **参数解释：** 是否用https的认证方式 true,false。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("https_clone_iam_auth", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpsCloneIamAuth { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateHttpsPasswordSetting {\n");
            sb.Append("  httpsCloneIamAuth: ").Append(HttpsCloneIamAuth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateHttpsPasswordSetting);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateHttpsPasswordSetting input)
        {
            if (input == null) return false;
            if (this.HttpsCloneIamAuth != input.HttpsCloneIamAuth || (this.HttpsCloneIamAuth != null && !this.HttpsCloneIamAuth.Equals(input.HttpsCloneIamAuth))) return false;

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
                if (this.HttpsCloneIamAuth != null) hashCode = hashCode * 59 + this.HttpsCloneIamAuth.GetHashCode();
                return hashCode;
            }
        }
    }
}
