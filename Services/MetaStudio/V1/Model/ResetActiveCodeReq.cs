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
    /// 重置激活码请求。
    /// </summary>
    public class ResetActiveCodeReq 
    {

        /// <summary>
        /// 是否清除鉴权凭证。
        /// </summary>
        [JsonProperty("clean_auth_credential", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CleanAuthCredential { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetActiveCodeReq {\n");
            sb.Append("  cleanAuthCredential: ").Append(CleanAuthCredential).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetActiveCodeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetActiveCodeReq input)
        {
            if (input == null) return false;
            if (this.CleanAuthCredential != input.CleanAuthCredential || (this.CleanAuthCredential != null && !this.CleanAuthCredential.Equals(input.CleanAuthCredential))) return false;

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
                if (this.CleanAuthCredential != null) hashCode = hashCode * 59 + this.CleanAuthCredential.GetHashCode();
                return hashCode;
            }
        }
    }
}
