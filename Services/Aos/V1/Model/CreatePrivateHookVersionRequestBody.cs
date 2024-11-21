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
    public class CreatePrivateHookVersionRequestBody 
    {

        /// <summary>
        /// 私有hook（private-hook）的唯一Id。  此Id由资源编排服务在生成私有hook的时候生成，为UUID。  由于私有hook名称仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的私有hook，删除，再重新创建一个同名私有hook。  对于团队并行开发，用户可能希望确保，当前我操作的私有hook就是我认为的那个，而不是其他队友删除后创建的同名私有hook。因此，使用Id就可以做到强匹配。  资源编排服务保证每次创建的私有hook所对应的Id都不相同，更新不会影响Id。如果给予的hook_id和当前hook的Id不一致，则返回400。
        /// </summary>
        [JsonProperty("hook_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HookId { get; set; }

        /// <summary>
        /// 私有hook的版本号。版本号必须遵循语义化版本号（Semantic Version），为用户自定义。
        /// </summary>
        [JsonProperty("hook_version", NullValueHandling = NullValueHandling.Ignore)]
        public string HookVersion { get; set; }

        /// <summary>
        /// 私有hook版本的描述。可用于客户识别创建私有hook的版本。注意：hook版本为不可更新（immutable），所以该字段不可更新，如果需要更新，请删除后重建。
        /// </summary>
        [JsonProperty("hook_version_description", NullValueHandling = NullValueHandling.Ignore)]
        public string HookVersionDescription { get; set; }

        /// <summary>
        /// 策略文件的OBS地址。内容仅支持OPA开源引擎识别的，以Rego（https://www.openpolicyagent.org/docs/latest/policy-language/）语言编写的策略模板。  请确保OBS地址所在局点与使用RFS服务局点一致。  策略文件当前支持单文件或zip压缩包，单文件需要以\&quot;.rego\&quot;结尾，压缩包当前只支持zip格式，文件需要以&#x60;.zip&#x60;结尾。  关于策略文件的校验要求如下：   * 文件必须是UTF8编码   * 创建时会对大小、格式、语法等进行校验   * 策略文件必须是UTF-8编码   * 单文件或压缩包解压前后的大小应控制在1MB以内   * 压缩包内的文件数量不能超过100个   * 压缩包内的文件路径最长为2048   * 压缩包内的文件名最长为255个字节  policy_uri和policy_body必须有且只有一个存在
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
            sb.Append("class CreatePrivateHookVersionRequestBody {\n");
            sb.Append("  hookId: ").Append(HookId).Append("\n");
            sb.Append("  hookVersion: ").Append(HookVersion).Append("\n");
            sb.Append("  hookVersionDescription: ").Append(HookVersionDescription).Append("\n");
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
            return this.Equals(input as CreatePrivateHookVersionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePrivateHookVersionRequestBody input)
        {
            if (input == null) return false;
            if (this.HookId != input.HookId || (this.HookId != null && !this.HookId.Equals(input.HookId))) return false;
            if (this.HookVersion != input.HookVersion || (this.HookVersion != null && !this.HookVersion.Equals(input.HookVersion))) return false;
            if (this.HookVersionDescription != input.HookVersionDescription || (this.HookVersionDescription != null && !this.HookVersionDescription.Equals(input.HookVersionDescription))) return false;
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
                if (this.HookId != null) hashCode = hashCode * 59 + this.HookId.GetHashCode();
                if (this.HookVersion != null) hashCode = hashCode * 59 + this.HookVersion.GetHashCode();
                if (this.HookVersionDescription != null) hashCode = hashCode * 59 + this.HookVersionDescription.GetHashCode();
                if (this.PolicyUri != null) hashCode = hashCode * 59 + this.PolicyUri.GetHashCode();
                if (this.PolicyBody != null) hashCode = hashCode * 59 + this.PolicyBody.GetHashCode();
                return hashCode;
            }
        }
    }
}
