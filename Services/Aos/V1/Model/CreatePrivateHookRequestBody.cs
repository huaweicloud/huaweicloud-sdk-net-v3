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
    public class CreatePrivateHookRequestBody 
    {

        /// <summary>
        /// 私有hook的名字。此名字在domain_id+region下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。  推荐用户使用三段命名空间：{自定义hook名称}-{hook应用场景}-hook。
        /// </summary>
        [JsonProperty("hook_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HookName { get; set; }

        /// <summary>
        /// 私有hook的版本号。版本号必须遵循语义化版本号（Semantic Version），为用户自定义。
        /// </summary>
        [JsonProperty("hook_version", NullValueHandling = NullValueHandling.Ignore)]
        public string HookVersion { get; set; }

        /// <summary>
        /// 私有hook的描述。可用于客户识别创建的私有hook。可通过UpdatePrivateHook API更新私有hook的描述。
        /// </summary>
        [JsonProperty("hook_description", NullValueHandling = NullValueHandling.Ignore)]
        public string HookDescription { get; set; }

        /// <summary>
        /// 私有hook版本的描述。可用于客户识别创建私有hook的版本。注意：hook版本为不可更新（immutable），所以该字段不可更新，如果需要更新，请删除后重建。
        /// </summary>
        [JsonProperty("hook_version_description", NullValueHandling = NullValueHandling.Ignore)]
        public string HookVersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("configuration", NullValueHandling = NullValueHandling.Ignore)]
        public ConfigurationPrimitiveTypeHolderConfiguration Configuration { get; set; }

        /// <summary>
        /// 策略文件的OBS地址。内容仅支持OPA开源引擎识别的，以Rego（https://www.openpolicyagent.org/docs/latest/policy-language/）语言编写的策略模板。  OBS地址支持同类型Region之间进行互相访问（Region分为通用Region和专属Region，通用Region指面向公共租户提供通用云服务的Region；专属Region指只承载同一类业务或只面向特定租户提供业务服务的专用Region）  策略文件当前支持单文件或zip压缩包，单文件需要以\&quot;.rego\&quot;结尾，压缩包当前只支持zip格式，文件需要以&#x60;.zip&#x60;结尾。  关于策略文件的校验要求如下：   * 文件必须是UTF8编码   * 创建时会对大小、格式、语法等进行校验   * 策略文件必须是UTF-8编码   * 单文件或压缩包解压前后的大小应控制在1MB以内   * 压缩包内的文件数量不能超过100个   * 压缩包内的文件路径最长为2048   * 压缩包内的文件名最长为255个字节  policy_uri和policy_body必须有且只有一个存在
        /// </summary>
        [JsonProperty("policy_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyUri { get; set; }

        /// <summary>
        /// 策略内容。仅支持OPA开源引擎识别的，以Rego（https://www.openpolicyagent.org/docs/latest/policy-language/）语言编写的策略模板。  policy_body和policy_uri 必须有且只有一个存在
        /// </summary>
        [JsonProperty("policy_body", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyBody { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePrivateHookRequestBody {\n");
            sb.Append("  hookName: ").Append(HookName).Append("\n");
            sb.Append("  hookVersion: ").Append(HookVersion).Append("\n");
            sb.Append("  hookDescription: ").Append(HookDescription).Append("\n");
            sb.Append("  hookVersionDescription: ").Append(HookVersionDescription).Append("\n");
            sb.Append("  configuration: ").Append(Configuration).Append("\n");
            sb.Append("  policyUri: ").Append(PolicyUri).Append("\n");
            sb.Append("  policyBody: ").Append(PolicyBody).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePrivateHookRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePrivateHookRequestBody input)
        {
            if (input == null) return false;
            if (this.HookName != input.HookName || (this.HookName != null && !this.HookName.Equals(input.HookName))) return false;
            if (this.HookVersion != input.HookVersion || (this.HookVersion != null && !this.HookVersion.Equals(input.HookVersion))) return false;
            if (this.HookDescription != input.HookDescription || (this.HookDescription != null && !this.HookDescription.Equals(input.HookDescription))) return false;
            if (this.HookVersionDescription != input.HookVersionDescription || (this.HookVersionDescription != null && !this.HookVersionDescription.Equals(input.HookVersionDescription))) return false;
            if (this.Configuration != input.Configuration || (this.Configuration != null && !this.Configuration.Equals(input.Configuration))) return false;
            if (this.PolicyUri != input.PolicyUri || (this.PolicyUri != null && !this.PolicyUri.Equals(input.PolicyUri))) return false;
            if (this.PolicyBody != input.PolicyBody || (this.PolicyBody != null && !this.PolicyBody.Equals(input.PolicyBody))) return false;

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
                if (this.HookName != null) hashCode = hashCode * 59 + this.HookName.GetHashCode();
                if (this.HookVersion != null) hashCode = hashCode * 59 + this.HookVersion.GetHashCode();
                if (this.HookDescription != null) hashCode = hashCode * 59 + this.HookDescription.GetHashCode();
                if (this.HookVersionDescription != null) hashCode = hashCode * 59 + this.HookVersionDescription.GetHashCode();
                if (this.Configuration != null) hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                if (this.PolicyUri != null) hashCode = hashCode * 59 + this.PolicyUri.GetHashCode();
                if (this.PolicyBody != null) hashCode = hashCode * 59 + this.PolicyBody.GetHashCode();
                return hashCode;
            }
        }
    }
}
