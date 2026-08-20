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
    /// 用户可配置参数
    /// </summary>
    public class ExtensionParameter 
    {

        /// <summary>
        /// 参数名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数显示标签
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("validation", NullValueHandling = NullValueHandling.Ignore)]
        public ExtensionParameterValidation Validation { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("defaultValue", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// 帮助文档(markdown格式)。
        /// </summary>
        [JsonProperty("helpMarkdown", NullValueHandling = NullValueHandling.Ignore)]
        public string HelpMarkdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("displaySettings", NullValueHandling = NullValueHandling.Ignore)]
        public ExtensionParameterDisplaySettings DisplaySettings { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionParameter {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  validation: ").Append(Validation).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  helpMarkdown: ").Append(HelpMarkdown).Append("\n");
            sb.Append("  displaySettings: ").Append(DisplaySettings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtensionParameter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtensionParameter input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Label != input.Label || (this.Label != null && !this.Label.Equals(input.Label))) return false;
            if (this.Validation != input.Validation || (this.Validation != null && !this.Validation.Equals(input.Validation))) return false;
            if (this.DefaultValue != input.DefaultValue || (this.DefaultValue != null && !this.DefaultValue.Equals(input.DefaultValue))) return false;
            if (this.HelpMarkdown != input.HelpMarkdown || (this.HelpMarkdown != null && !this.HelpMarkdown.Equals(input.HelpMarkdown))) return false;
            if (this.DisplaySettings != input.DisplaySettings || (this.DisplaySettings != null && !this.DisplaySettings.Equals(input.DisplaySettings))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Validation != null) hashCode = hashCode * 59 + this.Validation.GetHashCode();
                if (this.DefaultValue != null) hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.HelpMarkdown != null) hashCode = hashCode * 59 + this.HelpMarkdown.GetHashCode();
                if (this.DisplaySettings != null) hashCode = hashCode * 59 + this.DisplaySettings.GetHashCode();
                return hashCode;
            }
        }
    }
}
