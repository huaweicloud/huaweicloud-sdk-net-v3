using System;
using System.Collections.Generic;
using System.IO;
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
    public class CreateUnscopeTokenByIdpInitiatedRequestBody : IFormDataBody
    {

        /// <summary>
        /// 在IdP认证成功后返回的响应体。详情请参见：[获取联邦认证unscoped token(IdP initiated)](https://support.huaweicloud.com/api-iam/iam_02_0003.html)。
        /// </summary>
        [JsonProperty("SAMLResponse", NullValueHandling = NullValueHandling.Ignore)]
        public string SAMLResponse { get; set; }


        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("SAMLResponse", new FormDataPart<string>(SAMLResponse));

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUnscopeTokenByIdpInitiatedRequestBody {\n");
            sb.Append("  sAMLResponse: ").Append(SAMLResponse).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateUnscopeTokenByIdpInitiatedRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateUnscopeTokenByIdpInitiatedRequestBody input)
        {
            if (input == null) return false;
            if (this.SAMLResponse != input.SAMLResponse || (this.SAMLResponse != null && !this.SAMLResponse.Equals(input.SAMLResponse))) return false;

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
                if (this.SAMLResponse != null) hashCode = hashCode * 59 + this.SAMLResponse.GetHashCode();
                return hashCode;
            }
        }
    }
}
