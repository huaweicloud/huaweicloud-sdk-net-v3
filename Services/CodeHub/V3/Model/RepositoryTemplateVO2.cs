using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RepositoryTemplateVO2 
    {

        /// <summary>
        /// 模板类型
        /// </summary>
        [JsonProperty("template_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateType { get; set; }

        /// <summary>
        /// 代码模板名称
        /// </summary>
        [JsonProperty("code_title", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeTitle { get; set; }

        /// <summary>
        /// 创建者名称
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 代码模板描述
        /// </summary>
        [JsonProperty("code_description", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeDescription { get; set; }

        /// <summary>
        /// 模板语言
        /// </summary>
        [JsonProperty("languages", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Languages { get; set; }

        /// <summary>
        /// 模板平台
        /// </summary>
        [JsonProperty("plateform", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Plateform { get; set; }

        /// <summary>
        /// 模板类型
        /// </summary>
        [JsonProperty("entertype", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Entertype { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryTemplateVO2 {\n");
            sb.Append("  templateType: ").Append(TemplateType).Append("\n");
            sb.Append("  codeTitle: ").Append(CodeTitle).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  codeDescription: ").Append(CodeDescription).Append("\n");
            sb.Append("  languages: ").Append(Languages).Append("\n");
            sb.Append("  plateform: ").Append(Plateform).Append("\n");
            sb.Append("  entertype: ").Append(Entertype).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryTemplateVO2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryTemplateVO2 input)
        {
            if (input == null) return false;
            if (this.TemplateType != input.TemplateType || (this.TemplateType != null && !this.TemplateType.Equals(input.TemplateType))) return false;
            if (this.CodeTitle != input.CodeTitle || (this.CodeTitle != null && !this.CodeTitle.Equals(input.CodeTitle))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.CodeDescription != input.CodeDescription || (this.CodeDescription != null && !this.CodeDescription.Equals(input.CodeDescription))) return false;
            if (this.Languages != input.Languages || (this.Languages != null && input.Languages != null && !this.Languages.SequenceEqual(input.Languages))) return false;
            if (this.Plateform != input.Plateform || (this.Plateform != null && input.Plateform != null && !this.Plateform.SequenceEqual(input.Plateform))) return false;
            if (this.Entertype != input.Entertype || (this.Entertype != null && input.Entertype != null && !this.Entertype.SequenceEqual(input.Entertype))) return false;

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
                if (this.TemplateType != null) hashCode = hashCode * 59 + this.TemplateType.GetHashCode();
                if (this.CodeTitle != null) hashCode = hashCode * 59 + this.CodeTitle.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.CodeDescription != null) hashCode = hashCode * 59 + this.CodeDescription.GetHashCode();
                if (this.Languages != null) hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.Plateform != null) hashCode = hashCode * 59 + this.Plateform.GetHashCode();
                if (this.Entertype != null) hashCode = hashCode * 59 + this.Entertype.GetHashCode();
                return hashCode;
            }
        }
    }
}
