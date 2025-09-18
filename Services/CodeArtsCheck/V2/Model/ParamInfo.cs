using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 任务详情
    /// </summary>
    public class ParamInfo 
    {

        /// <summary>
        /// 仓库地址
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 仓库分支
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// 仓库语言
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 排除的目录
        /// </summary>
        [JsonProperty("exclude_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcludeDir { get; set; }

        /// <summary>
        /// 编码格式
        /// </summary>
        [JsonProperty("encode", NullValueHandling = NullValueHandling.Ignore)]
        public string Encode { get; set; }

        /// <summary>
        /// 编译配置信息
        /// </summary>
        [JsonProperty("compile_config", NullValueHandling = NullValueHandling.Ignore)]
        public string CompileConfig { get; set; }

        /// <summary>
        /// g规则集名称
        /// </summary>
        [JsonProperty("rule_template", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleTemplate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParamInfo {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  excludeDir: ").Append(ExcludeDir).Append("\n");
            sb.Append("  encode: ").Append(Encode).Append("\n");
            sb.Append("  compileConfig: ").Append(CompileConfig).Append("\n");
            sb.Append("  ruleTemplate: ").Append(RuleTemplate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParamInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParamInfo input)
        {
            if (input == null) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.ExcludeDir != input.ExcludeDir || (this.ExcludeDir != null && !this.ExcludeDir.Equals(input.ExcludeDir))) return false;
            if (this.Encode != input.Encode || (this.Encode != null && !this.Encode.Equals(input.Encode))) return false;
            if (this.CompileConfig != input.CompileConfig || (this.CompileConfig != null && !this.CompileConfig.Equals(input.CompileConfig))) return false;
            if (this.RuleTemplate != input.RuleTemplate || (this.RuleTemplate != null && !this.RuleTemplate.Equals(input.RuleTemplate))) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ExcludeDir != null) hashCode = hashCode * 59 + this.ExcludeDir.GetHashCode();
                if (this.Encode != null) hashCode = hashCode * 59 + this.Encode.GetHashCode();
                if (this.CompileConfig != null) hashCode = hashCode * 59 + this.CompileConfig.GetHashCode();
                if (this.RuleTemplate != null) hashCode = hashCode * 59 + this.RuleTemplate.GetHashCode();
                return hashCode;
            }
        }
    }
}
