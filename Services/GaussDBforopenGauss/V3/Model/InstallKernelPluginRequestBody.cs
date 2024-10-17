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
    /// 
    /// </summary>
    public class InstallKernelPluginRequestBody 
    {

        /// <summary>
        /// 插件名称
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// 插件安装包链接
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 插件安装包的sha256值
        /// </summary>
        [JsonProperty("sha_256", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha256 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstallKernelPluginRequestBody {\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  sha256: ").Append(Sha256).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstallKernelPluginRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstallKernelPluginRequestBody input)
        {
            if (input == null) return false;
            if (this.PluginName != input.PluginName || (this.PluginName != null && !this.PluginName.Equals(input.PluginName))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Sha256 != input.Sha256 || (this.Sha256 != null && !this.Sha256.Equals(input.Sha256))) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Sha256 != null) hashCode = hashCode * 59 + this.Sha256.GetHashCode();
                return hashCode;
            }
        }
    }
}
