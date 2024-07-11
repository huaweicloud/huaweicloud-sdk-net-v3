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
    public class ResumePluginExtensionsRequestBody 
    {

        /// <summary>
        /// 插件名称
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// 数据库列表
        /// </summary>
        [JsonProperty("db_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DbList { get; set; }

        /// <summary>
        /// 拓展模块名称
        /// </summary>
        [JsonProperty("extension_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtensionName { get; set; }

        /// <summary>
        /// 扩展开关。on表示开启，off表示关闭。
        /// </summary>
        [JsonProperty("extension_action", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtensionAction { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResumePluginExtensionsRequestBody {\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  dbList: ").Append(DbList).Append("\n");
            sb.Append("  extensionName: ").Append(ExtensionName).Append("\n");
            sb.Append("  extensionAction: ").Append(ExtensionAction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResumePluginExtensionsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResumePluginExtensionsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PluginName == input.PluginName ||
                    (this.PluginName != null &&
                    this.PluginName.Equals(input.PluginName))
                ) && 
                (
                    this.DbList == input.DbList ||
                    this.DbList != null &&
                    input.DbList != null &&
                    this.DbList.SequenceEqual(input.DbList)
                ) && 
                (
                    this.ExtensionName == input.ExtensionName ||
                    (this.ExtensionName != null &&
                    this.ExtensionName.Equals(input.ExtensionName))
                ) && 
                (
                    this.ExtensionAction == input.ExtensionAction ||
                    (this.ExtensionAction != null &&
                    this.ExtensionAction.Equals(input.ExtensionAction))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PluginName != null)
                    hashCode = hashCode * 59 + this.PluginName.GetHashCode();
                if (this.DbList != null)
                    hashCode = hashCode * 59 + this.DbList.GetHashCode();
                if (this.ExtensionName != null)
                    hashCode = hashCode * 59 + this.ExtensionName.GetHashCode();
                if (this.ExtensionAction != null)
                    hashCode = hashCode * 59 + this.ExtensionAction.GetHashCode();
                return hashCode;
            }
        }
    }
}
