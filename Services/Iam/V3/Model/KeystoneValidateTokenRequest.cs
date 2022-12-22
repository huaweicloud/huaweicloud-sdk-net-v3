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
    public class KeystoneValidateTokenRequest 
    {

        /// <summary>
        /// 待校验的token。
        /// </summary>
        [SDKProperty("X-Subject-Token", IsHeader = true)]
        [JsonProperty("X-Subject-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XSubjectToken { get; set; }

        /// <summary>
        /// 如果设置该参数，返回的响应体中将不显示catalog信息。任何非空字符串都将解释为true，并使该字段生效。
        /// </summary>
        [SDKProperty("nocatalog", IsQuery = true)]
        [JsonProperty("nocatalog", NullValueHandling = NullValueHandling.Ignore)]
        public string Nocatalog { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneValidateTokenRequest {\n");
            sb.Append("  xSubjectToken: ").Append(XSubjectToken).Append("\n");
            sb.Append("  nocatalog: ").Append(Nocatalog).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneValidateTokenRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneValidateTokenRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XSubjectToken == input.XSubjectToken ||
                    (this.XSubjectToken != null &&
                    this.XSubjectToken.Equals(input.XSubjectToken))
                ) && 
                (
                    this.Nocatalog == input.Nocatalog ||
                    (this.Nocatalog != null &&
                    this.Nocatalog.Equals(input.Nocatalog))
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
                if (this.XSubjectToken != null)
                    hashCode = hashCode * 59 + this.XSubjectToken.GetHashCode();
                if (this.Nocatalog != null)
                    hashCode = hashCode * 59 + this.Nocatalog.GetHashCode();
                return hashCode;
            }
        }
    }
}
