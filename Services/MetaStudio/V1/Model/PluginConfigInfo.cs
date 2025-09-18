using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 插件配置基本信息。
    /// </summary>
    public class PluginConfigInfo 
    {

        /// <summary>
        /// 插件配置ID。
        /// </summary>
        [JsonProperty("plugin_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginConfigId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("plugin_provider", NullValueHandling = NullValueHandling.Ignore)]
        public PluginProviderEnum? PluginProvider { get; set; }

        /// <summary>
        /// 创建时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginConfigInfo {\n");
            sb.Append("  pluginConfigId: ").Append(PluginConfigId).Append("\n");
            sb.Append("  pluginProvider: ").Append(PluginProvider).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginConfigInfo input)
        {
            if (input == null) return false;
            if (this.PluginConfigId != input.PluginConfigId || (this.PluginConfigId != null && !this.PluginConfigId.Equals(input.PluginConfigId))) return false;
            if (this.PluginProvider != input.PluginProvider || (this.PluginProvider != null && !this.PluginProvider.Equals(input.PluginProvider))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.PluginConfigId != null) hashCode = hashCode * 59 + this.PluginConfigId.GetHashCode();
                if (this.PluginProvider != null) hashCode = hashCode * 59 + this.PluginProvider.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
