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
    /// Request Object
    /// </summary>
    public class GetAuthorizationSchemaV5Request 
    {

        /// <summary>
        /// 服务名称缩写，长度为1到56个字符，只包含字母、数字和\&quot;-\&quot;的字符串。
        /// </summary>
        [SDKProperty("service_code", IsPath = true)]
        [JsonProperty("service_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAuthorizationSchemaV5Request {\n");
            sb.Append("  serviceCode: ").Append(ServiceCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetAuthorizationSchemaV5Request);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetAuthorizationSchemaV5Request input)
        {
            if (input == null) return false;
            if (this.ServiceCode != input.ServiceCode || (this.ServiceCode != null && !this.ServiceCode.Equals(input.ServiceCode))) return false;

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
                if (this.ServiceCode != null) hashCode = hashCode * 59 + this.ServiceCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
