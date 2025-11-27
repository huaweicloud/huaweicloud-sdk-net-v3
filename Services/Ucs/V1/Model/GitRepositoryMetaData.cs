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
    /// 
    /// </summary>
    public class GitRepositoryMetaData 
    {

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 所属命名空间
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 唯一标识符
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 资源的内部版本标识，用于并发控制
        /// </summary>
        [JsonProperty("resourceVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceVersion { get; set; }

        /// <summary>
        /// 资源的期望状态的代数，每次修改spec会自增
        /// </summary>
        [JsonProperty("generation", NullValueHandling = NullValueHandling.Ignore)]
        public int? Generation { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("creationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationTimestamp { get; set; }

        /// <summary>
        /// 删除前需要执行的清理操作
        /// </summary>
        [JsonProperty("finalizers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Finalizers { get; set; }

        /// <summary>
        /// 用于跟踪资源字段管理权，记录每个字段的管理者
        /// </summary>
        [JsonProperty("managedFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<ManagedFieldsEntry> ManagedFields { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GitRepositoryMetaData {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  resourceVersion: ").Append(ResourceVersion).Append("\n");
            sb.Append("  generation: ").Append(Generation).Append("\n");
            sb.Append("  creationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("  finalizers: ").Append(Finalizers).Append("\n");
            sb.Append("  managedFields: ").Append(ManagedFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GitRepositoryMetaData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GitRepositoryMetaData input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.ResourceVersion != input.ResourceVersion || (this.ResourceVersion != null && !this.ResourceVersion.Equals(input.ResourceVersion))) return false;
            if (this.Generation != input.Generation || (this.Generation != null && !this.Generation.Equals(input.Generation))) return false;
            if (this.CreationTimestamp != input.CreationTimestamp || (this.CreationTimestamp != null && !this.CreationTimestamp.Equals(input.CreationTimestamp))) return false;
            if (this.Finalizers != input.Finalizers || (this.Finalizers != null && input.Finalizers != null && !this.Finalizers.SequenceEqual(input.Finalizers))) return false;
            if (this.ManagedFields != input.ManagedFields || (this.ManagedFields != null && input.ManagedFields != null && !this.ManagedFields.SequenceEqual(input.ManagedFields))) return false;

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
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.ResourceVersion != null) hashCode = hashCode * 59 + this.ResourceVersion.GetHashCode();
                if (this.Generation != null) hashCode = hashCode * 59 + this.Generation.GetHashCode();
                if (this.CreationTimestamp != null) hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                if (this.Finalizers != null) hashCode = hashCode * 59 + this.Finalizers.GetHashCode();
                if (this.ManagedFields != null) hashCode = hashCode * 59 + this.ManagedFields.GetHashCode();
                return hashCode;
            }
        }
    }
}
