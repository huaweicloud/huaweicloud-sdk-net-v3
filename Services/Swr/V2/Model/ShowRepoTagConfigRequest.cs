using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowRepoTagConfigRequest 
    {

        /// <summary>
        /// **参数解释**： 组织名称。用于唯一标识一个组织，组织下的所有镜像仓库都属于该组织。  **约束限制**： 不涉及。  **取值范围**： 小写字母开头，后面跟小写字母、数字、小数点、下划线或中划线（其中下划线最多允许连续两个，不同类型分隔符不能直接相连），小写字母或数字结尾，长度1~64个字符。  **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("namespace", IsPath = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// **参数解释**： 镜像仓库名称过滤关键字，用于模糊匹配镜像仓库列表。  **约束限制**： 不涉及。  **取值范围**： 小写字母或数字开头，后面跟小写字母、数字、小数点、斜杠、下划线或中划线（其中下划线最多允许连续两个，不同类型分隔符不能直接相连），小写字母或数字结尾，长度1~128个字符。  **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("repository", IsPath = true)]
        [JsonProperty("repository", NullValueHandling = NullValueHandling.Ignore)]
        public string Repository { get; set; }

        /// <summary>
        /// **参数解释**： 镜像版本名称。用于唯一标识镜像仓库下的一个镜像版本。  **约束限制**： 不涉及。  **取值范围**： 小写字母或数字开头，后面跟小写字母、数字、小数点、斜杠、下划线或中划线（其中下划线最多允许连续两个，不同类型分隔符不能直接相连），小写字母或数字结尾，长度1~128个字符。  **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("tag", IsPath = true)]
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRepoTagConfigRequest {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  repository: ").Append(Repository).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRepoTagConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRepoTagConfigRequest input)
        {
            if (input == null) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.Repository != input.Repository || (this.Repository != null && !this.Repository.Equals(input.Repository))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;

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
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Repository != null) hashCode = hashCode * 59 + this.Repository.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                return hashCode;
            }
        }
    }
}
