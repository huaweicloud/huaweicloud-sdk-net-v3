using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// 全局参数
    /// </summary>
    public class Parameter 
    {

        /// <summary>
        /// 参数名称。
        /// </summary>
        [JsonProperty("param_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamName { get; set; }

        /// <summary>
        /// 参数类型。
        /// </summary>
        [JsonProperty("param_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamType { get; set; }

        /// <summary>
        /// 参数分组。
        /// </summary>
        [JsonProperty("param_group", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamGroup { get; set; }

        /// <summary>
        /// 参数初始值。
        /// </summary>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// 参数id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 是否加密。
        /// </summary>
        [JsonProperty("encryption", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Encryption { get; set; }

        /// <summary>
        /// 参数提示。
        /// </summary>
        [JsonProperty("hint", NullValueHandling = NullValueHandling.Ignore)]
        public string Hint { get; set; }

        /// <summary>
        /// 是否从参数库选择。
        /// </summary>
        [JsonProperty("quote_param", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QuoteParam { get; set; }

        /// <summary>
        /// 是否为必填参数。
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Required { get; set; }

        /// <summary>
        /// 参数描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Parameter {\n");
            sb.Append("  paramName: ").Append(ParamName).Append("\n");
            sb.Append("  paramType: ").Append(ParamType).Append("\n");
            sb.Append("  paramGroup: ").Append(ParamGroup).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  encryption: ").Append(Encryption).Append("\n");
            sb.Append("  hint: ").Append(Hint).Append("\n");
            sb.Append("  quoteParam: ").Append(QuoteParam).Append("\n");
            sb.Append("  required: ").Append(Required).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Parameter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Parameter input)
        {
            if (input == null) return false;
            if (this.ParamName != input.ParamName || (this.ParamName != null && !this.ParamName.Equals(input.ParamName))) return false;
            if (this.ParamType != input.ParamType || (this.ParamType != null && !this.ParamType.Equals(input.ParamType))) return false;
            if (this.ParamGroup != input.ParamGroup || (this.ParamGroup != null && !this.ParamGroup.Equals(input.ParamGroup))) return false;
            if (this.DefaultValue != input.DefaultValue || (this.DefaultValue != null && !this.DefaultValue.Equals(input.DefaultValue))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Encryption != input.Encryption || (this.Encryption != null && !this.Encryption.Equals(input.Encryption))) return false;
            if (this.Hint != input.Hint || (this.Hint != null && !this.Hint.Equals(input.Hint))) return false;
            if (this.QuoteParam != input.QuoteParam || (this.QuoteParam != null && !this.QuoteParam.Equals(input.QuoteParam))) return false;
            if (this.Required != input.Required || (this.Required != null && !this.Required.Equals(input.Required))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.ParamName != null) hashCode = hashCode * 59 + this.ParamName.GetHashCode();
                if (this.ParamType != null) hashCode = hashCode * 59 + this.ParamType.GetHashCode();
                if (this.ParamGroup != null) hashCode = hashCode * 59 + this.ParamGroup.GetHashCode();
                if (this.DefaultValue != null) hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Encryption != null) hashCode = hashCode * 59 + this.Encryption.GetHashCode();
                if (this.Hint != null) hashCode = hashCode * 59 + this.Hint.GetHashCode();
                if (this.QuoteParam != null) hashCode = hashCode * 59 + this.QuoteParam.GetHashCode();
                if (this.Required != null) hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
