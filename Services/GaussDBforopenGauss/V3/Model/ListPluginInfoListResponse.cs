using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListPluginInfoListResponse : SdkResponse
    {

        /// <summary>
        /// 插件名称
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// 插件版本
        /// </summary>
        [JsonProperty("plugin_version", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginVersion { get; set; }

        /// <summary>
        /// 是否已安装
        /// </summary>
        [JsonProperty("installed", NullValueHandling = NullValueHandling.Ignore)]
        public string Installed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPluginInfoListResponse {\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  pluginVersion: ").Append(PluginVersion).Append("\n");
            sb.Append("  installed: ").Append(Installed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPluginInfoListResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPluginInfoListResponse input)
        {
            if (input == null) return false;
            if (this.PluginName != input.PluginName || (this.PluginName != null && !this.PluginName.Equals(input.PluginName))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.PluginVersion != input.PluginVersion || (this.PluginVersion != null && !this.PluginVersion.Equals(input.PluginVersion))) return false;
            if (this.Installed != input.Installed || (this.Installed != null && !this.Installed.Equals(input.Installed))) return false;

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
                if (this.PluginName != null) hashCode = hashCode * 59 + this.PluginName.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.PluginVersion != null) hashCode = hashCode * 59 + this.PluginVersion.GetHashCode();
                if (this.Installed != null) hashCode = hashCode * 59 + this.Installed.GetHashCode();
                return hashCode;
            }
        }
    }
}
