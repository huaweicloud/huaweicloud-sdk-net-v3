using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PrivateProviderSourcePrimitiveTypeHolder 
    {

        /// <summary>
        /// 用户使用私有provider，在Terraform模板中定义required_providers信息时，需要指明的source参数。  该参数按照“huawei.com/private-provider/{provider_name}”的形式拼接。关于provider_name和provider_source字段在模板中的使用细节，详见创建私有Provider的API描述。
        /// </summary>
        [JsonProperty("provider_source", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderSource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateProviderSourcePrimitiveTypeHolder {\n");
            sb.Append("  providerSource: ").Append(ProviderSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateProviderSourcePrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateProviderSourcePrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.ProviderSource != input.ProviderSource || (this.ProviderSource != null && !this.ProviderSource.Equals(input.ProviderSource))) return false;

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
                if (this.ProviderSource != null) hashCode = hashCode * 59 + this.ProviderSource.GetHashCode();
                return hashCode;
            }
        }
    }
}
