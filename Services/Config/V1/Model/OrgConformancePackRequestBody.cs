using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 组织合规规则包请求体。
    /// </summary>
    public class OrgConformancePackRequestBody 
    {

        /// <summary>
        /// 组织合规规则包名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 排除配置合规包的帐号。
        /// </summary>
        [JsonProperty("excluded_accounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExcludedAccounts { get; set; }

        /// <summary>
        /// 预定义合规规则包模板名称。
        /// </summary>
        [JsonProperty("template_key", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateKey { get; set; }

        /// <summary>
        /// 自定义合规规则包内容。
        /// </summary>
        [JsonProperty("template_body", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// 合规规则包模板OBS地址。
        /// </summary>
        [JsonProperty("template_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateUri { get; set; }

        /// <summary>
        /// 合规规则包参数。
        /// </summary>
        [JsonProperty("vars_structure", NullValueHandling = NullValueHandling.Ignore)]
        public List<VarsStructure> VarsStructure { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgConformancePackRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  excludedAccounts: ").Append(ExcludedAccounts).Append("\n");
            sb.Append("  templateKey: ").Append(TemplateKey).Append("\n");
            sb.Append("  templateBody: ").Append(TemplateBody).Append("\n");
            sb.Append("  templateUri: ").Append(TemplateUri).Append("\n");
            sb.Append("  varsStructure: ").Append(VarsStructure).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrgConformancePackRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrgConformancePackRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ExcludedAccounts != input.ExcludedAccounts || (this.ExcludedAccounts != null && input.ExcludedAccounts != null && !this.ExcludedAccounts.SequenceEqual(input.ExcludedAccounts))) return false;
            if (this.TemplateKey != input.TemplateKey || (this.TemplateKey != null && !this.TemplateKey.Equals(input.TemplateKey))) return false;
            if (this.TemplateBody != input.TemplateBody || (this.TemplateBody != null && !this.TemplateBody.Equals(input.TemplateBody))) return false;
            if (this.TemplateUri != input.TemplateUri || (this.TemplateUri != null && !this.TemplateUri.Equals(input.TemplateUri))) return false;
            if (this.VarsStructure != input.VarsStructure || (this.VarsStructure != null && input.VarsStructure != null && !this.VarsStructure.SequenceEqual(input.VarsStructure))) return false;

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
                if (this.ExcludedAccounts != null) hashCode = hashCode * 59 + this.ExcludedAccounts.GetHashCode();
                if (this.TemplateKey != null) hashCode = hashCode * 59 + this.TemplateKey.GetHashCode();
                if (this.TemplateBody != null) hashCode = hashCode * 59 + this.TemplateBody.GetHashCode();
                if (this.TemplateUri != null) hashCode = hashCode * 59 + this.TemplateUri.GetHashCode();
                if (this.VarsStructure != null) hashCode = hashCode * 59 + this.VarsStructure.GetHashCode();
                return hashCode;
            }
        }
    }
}
