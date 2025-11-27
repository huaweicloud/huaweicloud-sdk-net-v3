using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// ObjectMeta是Kubernetes中所有持久化资源必须包含的元数据结构
    /// </summary>
    public class ObjectMeta 
    {

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 当未提供name时，服务器使用的前缀来生成唯一名称
        /// </summary>
        [JsonProperty("generateName", NullValueHandling = NullValueHandling.Ignore)]
        public string GenerateName { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// 注解
        /// </summary>
        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("creationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationTimestamp { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updateTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTimestamp { get; set; }

        /// <summary>
        /// 资源内部版本
        /// </summary>
        [JsonProperty("resourceVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceVersion { get; set; }

        /// <summary>
        /// 资源期望状态的代数
        /// </summary>
        [JsonProperty("generation", NullValueHandling = NullValueHandling.Ignore)]
        public string Generation { get; set; }

        /// <summary>
        /// 记录哪些字段由哪些工作流管理
        /// </summary>
        [JsonProperty("managedFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<ManagedFieldsEntry> ManagedFields { get; set; }

        /// <summary>
        /// 用于定义对象间所有权关系，管理对象的依赖关系和垃圾回收机制，支持控制器对资源的管理
        /// </summary>
        [JsonProperty("ownerReferences", NullValueHandling = NullValueHandling.Ignore)]
        public List<OwnerReference> OwnerReferences { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectMeta {\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  generateName: ").Append(GenerateName).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  annotations: ").Append(Annotations).Append("\n");
            sb.Append("  creationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("  updateTimestamp: ").Append(UpdateTimestamp).Append("\n");
            sb.Append("  resourceVersion: ").Append(ResourceVersion).Append("\n");
            sb.Append("  generation: ").Append(Generation).Append("\n");
            sb.Append("  managedFields: ").Append(ManagedFields).Append("\n");
            sb.Append("  ownerReferences: ").Append(OwnerReferences).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectMeta input)
        {
            if (input == null) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.GenerateName != input.GenerateName || (this.GenerateName != null && !this.GenerateName.Equals(input.GenerateName))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.Annotations != input.Annotations || (this.Annotations != null && input.Annotations != null && !this.Annotations.SequenceEqual(input.Annotations))) return false;
            if (this.CreationTimestamp != input.CreationTimestamp || (this.CreationTimestamp != null && !this.CreationTimestamp.Equals(input.CreationTimestamp))) return false;
            if (this.UpdateTimestamp != input.UpdateTimestamp || (this.UpdateTimestamp != null && !this.UpdateTimestamp.Equals(input.UpdateTimestamp))) return false;
            if (this.ResourceVersion != input.ResourceVersion || (this.ResourceVersion != null && !this.ResourceVersion.Equals(input.ResourceVersion))) return false;
            if (this.Generation != input.Generation || (this.Generation != null && !this.Generation.Equals(input.Generation))) return false;
            if (this.ManagedFields != input.ManagedFields || (this.ManagedFields != null && input.ManagedFields != null && !this.ManagedFields.SequenceEqual(input.ManagedFields))) return false;
            if (this.OwnerReferences != input.OwnerReferences || (this.OwnerReferences != null && input.OwnerReferences != null && !this.OwnerReferences.SequenceEqual(input.OwnerReferences))) return false;

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
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.GenerateName != null) hashCode = hashCode * 59 + this.GenerateName.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Annotations != null) hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.CreationTimestamp != null) hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                if (this.UpdateTimestamp != null) hashCode = hashCode * 59 + this.UpdateTimestamp.GetHashCode();
                if (this.ResourceVersion != null) hashCode = hashCode * 59 + this.ResourceVersion.GetHashCode();
                if (this.Generation != null) hashCode = hashCode * 59 + this.Generation.GetHashCode();
                if (this.ManagedFields != null) hashCode = hashCode * 59 + this.ManagedFields.GetHashCode();
                if (this.OwnerReferences != null) hashCode = hashCode * 59 + this.OwnerReferences.GetHashCode();
                return hashCode;
            }
        }
    }
}
