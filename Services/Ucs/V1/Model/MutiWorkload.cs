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
    public class MutiWorkload 
    {

        /// <summary>
        /// 资源类型，有以下取值： - Deployment：用于管理无状态应用 - Service：实现服务发现和负载均衡 - Ingress：管理对集群内服务的外部 HTTP/HTTPS 访问 - ConfigMap：用于存储非敏感的配置数据 - Secret：用于存储敏感信息 - Job：用于运行一次性任务的资源 - StatefulSet：用于管理有状态应用 - DaemonSet：用于在每个节点上运行一个 Pod 的资源 - PersistentVolumeClaim：用于向集群申请并使用持久化存储资源的声明
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// API版本
        /// </summary>
        [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectMeta Metadata { get; set; }

        /// <summary>
        /// 要部署的应用模板
        /// </summary>
        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public Object Template { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("propagationPolicy", NullValueHandling = NullValueHandling.Ignore)]
        public PropagationPolicy PropagationPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("overridePolicy", NullValueHandling = NullValueHandling.Ignore)]
        public OverridePolicy OverridePolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resourceBinding", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceBinding ResourceBinding { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MutiWorkload {\n");
            sb.Append("  kind: ").Append(Kind).Append("\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  template: ").Append(Template).Append("\n");
            sb.Append("  propagationPolicy: ").Append(PropagationPolicy).Append("\n");
            sb.Append("  overridePolicy: ").Append(OverridePolicy).Append("\n");
            sb.Append("  resourceBinding: ").Append(ResourceBinding).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MutiWorkload);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MutiWorkload input)
        {
            if (input == null) return false;
            if (this.Kind != input.Kind || (this.Kind != null && !this.Kind.Equals(input.Kind))) return false;
            if (this.ApiVersion != input.ApiVersion || (this.ApiVersion != null && !this.ApiVersion.Equals(input.ApiVersion))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.Template != input.Template || (this.Template != null && !this.Template.Equals(input.Template))) return false;
            if (this.PropagationPolicy != input.PropagationPolicy || (this.PropagationPolicy != null && !this.PropagationPolicy.Equals(input.PropagationPolicy))) return false;
            if (this.OverridePolicy != input.OverridePolicy || (this.OverridePolicy != null && !this.OverridePolicy.Equals(input.OverridePolicy))) return false;
            if (this.ResourceBinding != input.ResourceBinding || (this.ResourceBinding != null && !this.ResourceBinding.Equals(input.ResourceBinding))) return false;

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
                if (this.Kind != null) hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.ApiVersion != null) hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Template != null) hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.PropagationPolicy != null) hashCode = hashCode * 59 + this.PropagationPolicy.GetHashCode();
                if (this.OverridePolicy != null) hashCode = hashCode * 59 + this.OverridePolicy.GetHashCode();
                if (this.ResourceBinding != null) hashCode = hashCode * 59 + this.ResourceBinding.GetHashCode();
                return hashCode;
            }
        }
    }
}
