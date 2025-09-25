using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 流水线参数
    /// </summary>
    public class TemplateParam 
    {

        /// <summary>
        /// 是否必须
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public string Required { get; set; }

        /// <summary>
        /// 是否可见
        /// </summary>
        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public string Visible { get; set; }

        /// <summary>
        /// 流水线参数名字
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 流水线参数值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 流水线参数描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 流水线参数类型
        /// </summary>
        [JsonProperty("paramtype", NullValueHandling = NullValueHandling.Ignore)]
        public string Paramtype { get; set; }

        /// <summary>
        /// 流水线参数展示类型
        /// </summary>
        [JsonProperty("display_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayType { get; set; }

        /// <summary>
        /// 流水线参数展示名字
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 是否静态参数
        /// </summary>
        [JsonProperty("is_static", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsStatic { get; set; }

        /// <summary>
        /// 是否默认参数
        /// </summary>
        [JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// array类型数据
        /// </summary>
        [JsonProperty("limits", NullValueHandling = NullValueHandling.Ignore)]
        public List<ParamTypeLimits> Limits { get; set; }

        /// <summary>
        /// array类型数据
        /// </summary>
        [JsonProperty("constraints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Constraint> Constraints { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateParam {\n");
            sb.Append("  required: ").Append(Required).Append("\n");
            sb.Append("  visible: ").Append(Visible).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  paramtype: ").Append(Paramtype).Append("\n");
            sb.Append("  displayType: ").Append(DisplayType).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  isStatic: ").Append(IsStatic).Append("\n");
            sb.Append("  isDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  limits: ").Append(Limits).Append("\n");
            sb.Append("  constraints: ").Append(Constraints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateParam input)
        {
            if (input == null) return false;
            if (this.Required != input.Required || (this.Required != null && !this.Required.Equals(input.Required))) return false;
            if (this.Visible != input.Visible || (this.Visible != null && !this.Visible.Equals(input.Visible))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Paramtype != input.Paramtype || (this.Paramtype != null && !this.Paramtype.Equals(input.Paramtype))) return false;
            if (this.DisplayType != input.DisplayType || (this.DisplayType != null && !this.DisplayType.Equals(input.DisplayType))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.IsStatic != input.IsStatic || (this.IsStatic != null && !this.IsStatic.Equals(input.IsStatic))) return false;
            if (this.IsDefault != input.IsDefault || (this.IsDefault != null && !this.IsDefault.Equals(input.IsDefault))) return false;
            if (this.Limits != input.Limits || (this.Limits != null && input.Limits != null && !this.Limits.SequenceEqual(input.Limits))) return false;
            if (this.Constraints != input.Constraints || (this.Constraints != null && input.Constraints != null && !this.Constraints.SequenceEqual(input.Constraints))) return false;

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
                if (this.Required != null) hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Visible != null) hashCode = hashCode * 59 + this.Visible.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Paramtype != null) hashCode = hashCode * 59 + this.Paramtype.GetHashCode();
                if (this.DisplayType != null) hashCode = hashCode * 59 + this.DisplayType.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.IsStatic != null) hashCode = hashCode * 59 + this.IsStatic.GetHashCode();
                if (this.IsDefault != null) hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                if (this.Limits != null) hashCode = hashCode * 59 + this.Limits.GetHashCode();
                if (this.Constraints != null) hashCode = hashCode * 59 + this.Constraints.GetHashCode();
                return hashCode;
            }
        }
    }
}
