using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 模板的部署参数的变量。
    /// </summary>
    public class TemplateParamVariable 
    {

        /// <summary>
        /// 变量默认值。
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public Object Default { get; set; }

        /// <summary>
        /// 变量名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 变量描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 变量是否可以为空。
        /// </summary>
        [JsonProperty("nullable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nullable { get; set; }

        /// <summary>
        /// 变量是否为敏感字段。
        /// </summary>
        [JsonProperty("sensitive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// 变量类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 模板的部署参数变量的校验规则。
        /// </summary>
        [JsonProperty("validations", NullValueHandling = NullValueHandling.Ignore)]
        public List<TemplateParamVariableValidation> Validations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateParamVariable {\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  nullable: ").Append(Nullable).Append("\n");
            sb.Append("  sensitive: ").Append(Sensitive).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  validations: ").Append(Validations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateParamVariable);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateParamVariable input)
        {
            if (input == null) return false;
            if (this.Default != input.Default || (this.Default != null && !this.Default.Equals(input.Default))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Nullable != input.Nullable || (this.Nullable != null && !this.Nullable.Equals(input.Nullable))) return false;
            if (this.Sensitive != input.Sensitive || (this.Sensitive != null && !this.Sensitive.Equals(input.Sensitive))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Validations != input.Validations || (this.Validations != null && input.Validations != null && !this.Validations.SequenceEqual(input.Validations))) return false;

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
                if (this.Default != null) hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Nullable != null) hashCode = hashCode * 59 + this.Nullable.GetHashCode();
                if (this.Sensitive != null) hashCode = hashCode * 59 + this.Sensitive.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Validations != null) hashCode = hashCode * 59 + this.Validations.GetHashCode();
                return hashCode;
            }
        }
    }
}
