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
    public class NodePoolMetadata 
    {

        /// <summary>
        /// 节点名池名称。  &gt; 命名规则： &gt; &gt;  - 以小写字母开头，由小写字母、数字、中划线(-)组成，长度范围1-50位，且不能以中划线(-)结尾。 &gt; &gt;  - 不允许创建名为 DefaultPool 的节点池。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 节点池的uid。创建成功后自动生成，填写无效
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 节点池的注解，以key value对表示。 
        /// </summary>
        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updateTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTimestamp { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("creationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationTimestamp { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodePoolMetadata {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  annotations: ").Append(Annotations).Append("\n");
            sb.Append("  updateTimestamp: ").Append(UpdateTimestamp).Append("\n");
            sb.Append("  creationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodePoolMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodePoolMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && 
                (
                    this.UpdateTimestamp == input.UpdateTimestamp ||
                    (this.UpdateTimestamp != null &&
                    this.UpdateTimestamp.Equals(input.UpdateTimestamp))
                ) && 
                (
                    this.CreationTimestamp == input.CreationTimestamp ||
                    (this.CreationTimestamp != null &&
                    this.CreationTimestamp.Equals(input.CreationTimestamp))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.UpdateTimestamp != null)
                    hashCode = hashCode * 59 + this.UpdateTimestamp.GetHashCode();
                if (this.CreationTimestamp != null)
                    hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
