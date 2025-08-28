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
    /// 默认插件支持信息。
    /// </summary>
    public class DefaultPluginInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("plugin_type", NullValueHandling = NullValueHandling.Ignore)]
        public PluginTypeEnum PluginType { get; set; }
        /// <summary>
        /// 支持默认插件。
        /// </summary>
        [JsonProperty("support_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportDefault { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefaultPluginInfo {\n");
            sb.Append("  pluginType: ").Append(PluginType).Append("\n");
            sb.Append("  supportDefault: ").Append(SupportDefault).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DefaultPluginInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DefaultPluginInfo input)
        {
            if (input == null) return false;
            if (this.PluginType != input.PluginType) return false;
            if (this.SupportDefault != input.SupportDefault || (this.SupportDefault != null && !this.SupportDefault.Equals(input.SupportDefault))) return false;

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
                hashCode = hashCode * 59 + this.PluginType.GetHashCode();
                if (this.SupportDefault != null) hashCode = hashCode * 59 + this.SupportDefault.GetHashCode();
                return hashCode;
            }
        }
    }
}
