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
    public class ListChildProxyRepositoriesListRequest 
    {

        /// <summary>
        /// **参数解释**: 仓库id，格式为{region}_{domainId}_{format}_{sequence}。可以从私有依赖库首页-&gt;仓库概览-&gt;仓库地址 url 中获取，最后两个\&quot;/\&quot;中间的字符串即为仓库id。 **约束限制**: 不涉及。 **取值范围**: 根据仓库id格式中region, domainId需要为有效值，format有效值为:npm|go|pypi|rpm|composer|maven|debian|conan|nuget|docker2|cocoapods|ohpm|generic|helm|conda, sequence取值根据套餐不同有不同上限值。 **默认取值**: 不涉及。
        /// </summary>
        [SDKProperty("repo_id", IsQuery = true)]
        [JsonProperty("repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoId { get; set; }

        /// <summary>
        /// **参数解释**: type。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListChildProxyRepositoriesListRequest {\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListChildProxyRepositoriesListRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListChildProxyRepositoriesListRequest input)
        {
            if (input == null) return false;
            if (this.RepoId != input.RepoId || (this.RepoId != null && !this.RepoId.Equals(input.RepoId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.RepoId != null) hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
