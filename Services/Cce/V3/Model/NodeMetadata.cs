using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NodeMetadata 
    {

        /// <summary>
        /// **参数解释**： 节点名称 **约束限制**： - 命名规则：以小写字母开头，由小写字母、数字、中划线(-)、点(.)组成，长度范围1-56位，且不能以中划线(-)结尾。 - 若name未指定或指定为空字符串，则按照默认规则生成节点名称。默认规则为：“集群名称-随机字符串”，若集群名称过长，则只取前36个字符。 - 若节点数量(count)大于1时，则按照默认规则会在用户输入的节点名称末尾添加随机字符串。默认规则为：“用户输入名称-随机字符串”，若用户输入的节点名称长度范围超过50位时，系统截取前50位，并在末尾添加随机字符串。  **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 节点ID，资源唯一标识。 **约束限制**： 创建成功后自动生成，填写无效 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// **参数解释**： CCE自有节点标签，非Kubernetes原生labels。 &gt; 标签可用于选择对象并查找满足某些条件的对象集合，格式为key/value键值对。  **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及  示例：  &#x60;&#x60;&#x60; \&quot;labels\&quot;: {   \&quot;key\&quot; : \&quot;value\&quot; } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// **参数解释**： CCE自有节点注解，非Kubernetes原生annotations，格式为key/value键值对。 &gt; Annotations不用于标识和选择对象。Annotations中的元数据可以是small或large，structured或unstructured，并且可以包括标签不允许使用的字符。  **约束限制**： 仅用于查询，不支持请求时传入，填写无效。 **取值范围**： 不涉及 **默认取值**： 不涉及  示例： &#x60;&#x60;&#x60; \&quot;annotations\&quot;: {   \&quot;key1\&quot; : \&quot;value1\&quot;,   \&quot;key2\&quot; : \&quot;value2\&quot; } &#x60;&#x60;&#x60; 
        /// </summary>
        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// **参数解释**： 节点创建时间。 **约束限制**： 创建成功后自动生成，填写无效。 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("creationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationTimestamp { get; set; }

        /// <summary>
        /// **参数解释**： 节点更新时间。 **约束限制**： 创建成功后自动生成，填写无效。 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("updateTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ownerReferences", NullValueHandling = NullValueHandling.Ignore)]
        public NodeMetadataOwnerReferences OwnerReferences { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeMetadata {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  annotations: ").Append(Annotations).Append("\n");
            sb.Append("  creationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("  updateTimestamp: ").Append(UpdateTimestamp).Append("\n");
            sb.Append("  ownerReferences: ").Append(OwnerReferences).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeMetadata input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.Annotations != input.Annotations || (this.Annotations != null && input.Annotations != null && !this.Annotations.SequenceEqual(input.Annotations))) return false;
            if (this.CreationTimestamp != input.CreationTimestamp || (this.CreationTimestamp != null && !this.CreationTimestamp.Equals(input.CreationTimestamp))) return false;
            if (this.UpdateTimestamp != input.UpdateTimestamp || (this.UpdateTimestamp != null && !this.UpdateTimestamp.Equals(input.UpdateTimestamp))) return false;
            if (this.OwnerReferences != input.OwnerReferences || (this.OwnerReferences != null && !this.OwnerReferences.Equals(input.OwnerReferences))) return false;

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
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Annotations != null) hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.CreationTimestamp != null) hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                if (this.UpdateTimestamp != null) hashCode = hashCode * 59 + this.UpdateTimestamp.GetHashCode();
                if (this.OwnerReferences != null) hashCode = hashCode * 59 + this.OwnerReferences.GetHashCode();
                return hashCode;
            }
        }
    }
}
