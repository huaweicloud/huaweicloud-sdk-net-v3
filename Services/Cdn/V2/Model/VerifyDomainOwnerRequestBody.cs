using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 域名归属校验请求体
    /// </summary>
    public class VerifyDomainOwnerRequestBody 
    {

        /// <summary>
        /// 校验类型： - dns：DNS解析校验； - file：文件校验； - all：DNS与文件都会进行探测，默认为all。
        /// </summary>
        [JsonProperty("verify_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifyType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyDomainOwnerRequestBody {\n");
            sb.Append("  verifyType: ").Append(VerifyType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VerifyDomainOwnerRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VerifyDomainOwnerRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VerifyType == input.VerifyType ||
                    (this.VerifyType != null &&
                    this.VerifyType.Equals(input.VerifyType))
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
                if (this.VerifyType != null)
                    hashCode = hashCode * 59 + this.VerifyType.GetHashCode();
                return hashCode;
            }
        }
    }
}
