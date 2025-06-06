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
    /// Request Object
    /// </summary>
    public class KeystoneCreateUserTokenByPasswordAndMfaRequest 
    {

        /// <summary>
        /// 如果设置该参数，返回的响应体中将不显示catalog信息。任何非空字符串都将解释为true，并使该字段生效。
        /// </summary>
        [SDKProperty("nocatalog", IsQuery = true)]
        [JsonProperty("nocatalog", NullValueHandling = NullValueHandling.Ignore)]
        public string Nocatalog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public KeystoneCreateUserTokenByPasswordAndMfaRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneCreateUserTokenByPasswordAndMfaRequest {\n");
            sb.Append("  nocatalog: ").Append(Nocatalog).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneCreateUserTokenByPasswordAndMfaRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneCreateUserTokenByPasswordAndMfaRequest input)
        {
            if (input == null) return false;
            if (this.Nocatalog != input.Nocatalog || (this.Nocatalog != null && !this.Nocatalog.Equals(input.Nocatalog))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.Nocatalog != null) hashCode = hashCode * 59 + this.Nocatalog.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
