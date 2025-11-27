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
    public class KustomizationSpec 
    {

        /// <summary>
        /// kustomization.yaml文件的路径
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 用于指定控制器执行 Kustomization同步与校验的时间间隔
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public string Interval { get; set; }

        /// <summary>
        /// 用于定义验证、应用和健康检查操作的超时
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public string Timeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sourceRef", NullValueHandling = NullValueHandling.Ignore)]
        public SourceRef SourceRef { get; set; }

        /// <summary>
        /// 用于设置或覆盖kustomization.yaml文件中的命名空间
        /// </summary>
        [JsonProperty("targetNamespace", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetNamespace { get; set; }

        /// <summary>
        /// 是否启用垃圾回收功能
        /// </summary>
        [JsonProperty("prune", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prune { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KustomizationSpec {\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  sourceRef: ").Append(SourceRef).Append("\n");
            sb.Append("  targetNamespace: ").Append(TargetNamespace).Append("\n");
            sb.Append("  prune: ").Append(Prune).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KustomizationSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KustomizationSpec input)
        {
            if (input == null) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.Interval != input.Interval || (this.Interval != null && !this.Interval.Equals(input.Interval))) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.SourceRef != input.SourceRef || (this.SourceRef != null && !this.SourceRef.Equals(input.SourceRef))) return false;
            if (this.TargetNamespace != input.TargetNamespace || (this.TargetNamespace != null && !this.TargetNamespace.Equals(input.TargetNamespace))) return false;
            if (this.Prune != input.Prune || (this.Prune != null && !this.Prune.Equals(input.Prune))) return false;

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
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Interval != null) hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.SourceRef != null) hashCode = hashCode * 59 + this.SourceRef.GetHashCode();
                if (this.TargetNamespace != null) hashCode = hashCode * 59 + this.TargetNamespace.GetHashCode();
                if (this.Prune != null) hashCode = hashCode * 59 + this.Prune.GetHashCode();
                return hashCode;
            }
        }
    }
}
