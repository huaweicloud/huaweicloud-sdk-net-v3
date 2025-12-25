using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListMavenListRequest 
    {

        /// <summary>
        /// **参数解释**: 项目ID，可以从调用API处获取，也可以从控制台获取。获取方式请参考[获取项目ID](CloudArtifact_api_0015.xml)。 **约束限制**: 只能由英文字母、数字组成，且长度为32个字符。 **取值范围**: 不涉及。 **默认取值**: 无。
        /// </summary>
        [SDKProperty("project_id", IsQuery = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**: 是否返回默认仓库。 **约束限制**: 不涉及。 **取值范围**: true or false。 **默认取值**: false。
        /// </summary>
        [SDKProperty("default", IsQuery = true)]
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; }

        /// <summary>
        /// **参数解释**: 仓库类型：snapshot 或 release。 **约束限制**: 不涉及。 **取值范围**: snapshot or releases。 **默认取值**: 不涉及。
        /// </summary>
        [SDKProperty("policy", IsQuery = true)]
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public string Policy { get; set; }

        /// <summary>
        /// **参数解释**: 仓库id，多个仓库id用英文逗号间隔。仓库id格式为{region}_{domainId}_{format}_{sequence}。可以从私有依赖库首页-&gt;仓库概览-&gt;仓库地址 url 中获取，最后两个\&quot;/\&quot;中间的字符串即为仓库id。 **约束限制**: 不涉及。 **取值范围**: 最大长度512。 **默认取值**: 不涉及。
        /// </summary>
        [SDKProperty("repo_ids", IsQuery = true)]
        [JsonProperty("repo_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoIds { get; set; }

        /// <summary>
        /// **参数解释**: 权限过滤设置，允许过滤读(r)和读写(rw)权限。 **约束限制**: 不涉及。 **取值范围**: r or rw。 **默认取值**: r。
        /// </summary>
        [SDKProperty("access", IsQuery = true)]
        [JsonProperty("access", NullValueHandling = NullValueHandling.Ignore)]
        public string Access { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMavenListRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  repoIds: ").Append(RepoIds).Append("\n");
            sb.Append("  access: ").Append(Access).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMavenListRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMavenListRequest input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Default != input.Default || (this.Default != null && !this.Default.Equals(input.Default))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.RepoIds != input.RepoIds || (this.RepoIds != null && !this.RepoIds.Equals(input.RepoIds))) return false;
            if (this.Access != input.Access || (this.Access != null && !this.Access.Equals(input.Access))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Default != null) hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.RepoIds != null) hashCode = hashCode * 59 + this.RepoIds.GetHashCode();
                if (this.Access != null) hashCode = hashCode * 59 + this.Access.GetHashCode();
                return hashCode;
            }
        }
    }
}
