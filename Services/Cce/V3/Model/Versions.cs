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
    /// 具体插件版本信息
    /// </summary>
    public class Versions 
    {

        /// <summary>
        /// 插件版本号
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 插件安装参数
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public Object Input { get; set; }

        /// <summary>
        /// 是否为稳定版本
        /// </summary>
        [JsonProperty("stable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stable { get; set; }

        /// <summary>
        /// 供界面使用的翻译信息
        /// </summary>
        [JsonProperty("translate", NullValueHandling = NullValueHandling.Ignore)]
        public Object Translate { get; set; }

        /// <summary>
        /// 支持集群版本号
        /// </summary>
        [JsonProperty("supportVersions", NullValueHandling = NullValueHandling.Ignore)]
        public List<SupportVersions> SupportVersions { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("creationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreationTimestamp { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updateTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTimestamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Versions {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  stable: ").Append(Stable).Append("\n");
            sb.Append("  translate: ").Append(Translate).Append("\n");
            sb.Append("  supportVersions: ").Append(SupportVersions).Append("\n");
            sb.Append("  creationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("  updateTimestamp: ").Append(UpdateTimestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Versions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Versions input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Input != input.Input || (this.Input != null && !this.Input.Equals(input.Input))) return false;
            if (this.Stable != input.Stable || (this.Stable != null && !this.Stable.Equals(input.Stable))) return false;
            if (this.Translate != input.Translate || (this.Translate != null && !this.Translate.Equals(input.Translate))) return false;
            if (this.SupportVersions != input.SupportVersions || (this.SupportVersions != null && input.SupportVersions != null && !this.SupportVersions.SequenceEqual(input.SupportVersions))) return false;
            if (this.CreationTimestamp != input.CreationTimestamp || (this.CreationTimestamp != null && !this.CreationTimestamp.Equals(input.CreationTimestamp))) return false;
            if (this.UpdateTimestamp != input.UpdateTimestamp || (this.UpdateTimestamp != null && !this.UpdateTimestamp.Equals(input.UpdateTimestamp))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Input != null) hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Stable != null) hashCode = hashCode * 59 + this.Stable.GetHashCode();
                if (this.Translate != null) hashCode = hashCode * 59 + this.Translate.GetHashCode();
                if (this.SupportVersions != null) hashCode = hashCode * 59 + this.SupportVersions.GetHashCode();
                if (this.CreationTimestamp != null) hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                if (this.UpdateTimestamp != null) hashCode = hashCode * 59 + this.UpdateTimestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
