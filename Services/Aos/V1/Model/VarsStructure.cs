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
    /// HCL支持参数，即，同一个模板可以给予不同的参数而达到不同的效果。  var_structure可以允许客户提交最简单的字符串类型的参数  资源编排服务支持vars_structure，vars_body和vars_uri，如果他们中声名了同一个变量，将报错400  vars_structure中的值只支持简单的字符串类型，如果需要使用其他类型，需要用户自己在HCL引用时转换， 或者用户可以使用vars_uri、vars_body，vars_uri和vars_body中支持HCL支持的各种类型以及复杂结构  如果vars_structure过大，可以使用vars_uri  注意：vars中不应该传递任何敏感信息，资源编排服务会直接明文使用、log、展示、存储对应的vars 
    /// </summary>
    public class VarsStructure 
    {

        /// <summary>
        /// 参数的名字
        /// </summary>
        [JsonProperty("var_key", NullValueHandling = NullValueHandling.Ignore)]
        public string VarKey { get; set; }

        /// <summary>
        /// 参数的值。  注意，参数需要以字符串形式存在，如果是数字，也需要以字符串形式存在，如&#39;10&#39;。  如果需要支持不同类型，或者复杂结构，请使用vars_uri或vars_body 
        /// </summary>
        [JsonProperty("var_value", NullValueHandling = NullValueHandling.Ignore)]
        public string VarValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("encryption", NullValueHandling = NullValueHandling.Ignore)]
        public EncryptionStructure Encryption { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VarsStructure {\n");
            sb.Append("  varKey: ").Append(VarKey).Append("\n");
            sb.Append("  varValue: ").Append(VarValue).Append("\n");
            sb.Append("  encryption: ").Append(Encryption).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VarsStructure);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VarsStructure input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VarKey == input.VarKey ||
                    (this.VarKey != null &&
                    this.VarKey.Equals(input.VarKey))
                ) && 
                (
                    this.VarValue == input.VarValue ||
                    (this.VarValue != null &&
                    this.VarValue.Equals(input.VarValue))
                ) && 
                (
                    this.Encryption == input.Encryption ||
                    (this.Encryption != null &&
                    this.Encryption.Equals(input.Encryption))
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
                if (this.VarKey != null)
                    hashCode = hashCode * 59 + this.VarKey.GetHashCode();
                if (this.VarValue != null)
                    hashCode = hashCode * 59 + this.VarValue.GetHashCode();
                if (this.Encryption != null)
                    hashCode = hashCode * 59 + this.Encryption.GetHashCode();
                return hashCode;
            }
        }
    }
}
