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
    /// 
    /// </summary>
    public class CreateReplicationPolicyRequestBody 
    {

        /// <summary>
        /// 策略名称, 1-256字符组成，只能包含英文大小写、数字、汉字、中划线和下划线。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 策略描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("src_registry", NullValueHandling = NullValueHandling.Ignore)]
        public ReplicationRegistry SrcRegistry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dest_registry", NullValueHandling = NullValueHandling.Ignore)]
        public ReplicationRegistry DestRegistry { get; set; }

        /// <summary>
        /// 目标命名空间名，默认值为空值
        /// </summary>
        [JsonProperty("dest_namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string DestNamespace { get; set; }

        /// <summary>
        /// 过滤器（目前只支持harbor类型的仓库）
        /// </summary>
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Filter> Filters { get; set; }

        /// <summary>
        /// repo的选择方式，regular，selection
        /// </summary>
        [JsonProperty("repo_scope_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoScopeMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("trigger", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerConfig Trigger { get; set; }

        /// <summary>
        /// 是否覆盖，默认为false
        /// </summary>
        [JsonProperty("override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Override { get; set; }

        /// <summary>
        /// 是否使用，默认为false
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateReplicationPolicyRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  srcRegistry: ").Append(SrcRegistry).Append("\n");
            sb.Append("  destRegistry: ").Append(DestRegistry).Append("\n");
            sb.Append("  destNamespace: ").Append(DestNamespace).Append("\n");
            sb.Append("  filters: ").Append(Filters).Append("\n");
            sb.Append("  repoScopeMode: ").Append(RepoScopeMode).Append("\n");
            sb.Append("  trigger: ").Append(Trigger).Append("\n");
            sb.Append("  Override: ").Append(Override).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateReplicationPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateReplicationPolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.SrcRegistry != input.SrcRegistry || (this.SrcRegistry != null && !this.SrcRegistry.Equals(input.SrcRegistry))) return false;
            if (this.DestRegistry != input.DestRegistry || (this.DestRegistry != null && !this.DestRegistry.Equals(input.DestRegistry))) return false;
            if (this.DestNamespace != input.DestNamespace || (this.DestNamespace != null && !this.DestNamespace.Equals(input.DestNamespace))) return false;
            if (this.Filters != input.Filters || (this.Filters != null && input.Filters != null && !this.Filters.SequenceEqual(input.Filters))) return false;
            if (this.RepoScopeMode != input.RepoScopeMode || (this.RepoScopeMode != null && !this.RepoScopeMode.Equals(input.RepoScopeMode))) return false;
            if (this.Trigger != input.Trigger || (this.Trigger != null && !this.Trigger.Equals(input.Trigger))) return false;
            if (this.Override != input.Override || (this.Override != null && !this.Override.Equals(input.Override))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SrcRegistry != null) hashCode = hashCode * 59 + this.SrcRegistry.GetHashCode();
                if (this.DestRegistry != null) hashCode = hashCode * 59 + this.DestRegistry.GetHashCode();
                if (this.DestNamespace != null) hashCode = hashCode * 59 + this.DestNamespace.GetHashCode();
                if (this.Filters != null) hashCode = hashCode * 59 + this.Filters.GetHashCode();
                if (this.RepoScopeMode != null) hashCode = hashCode * 59 + this.RepoScopeMode.GetHashCode();
                if (this.Trigger != null) hashCode = hashCode * 59 + this.Trigger.GetHashCode();
                if (this.Override != null) hashCode = hashCode * 59 + this.Override.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
