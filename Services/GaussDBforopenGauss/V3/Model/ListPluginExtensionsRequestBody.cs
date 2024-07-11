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
    public class ListPluginExtensionsRequestBody 
    {

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 插件名称
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPluginExtensionsRequestBody {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPluginExtensionsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPluginExtensionsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DbName == input.DbName ||
                    (this.DbName != null &&
                    this.DbName.Equals(input.DbName))
                ) && 
                (
                    this.PluginName == input.PluginName ||
                    (this.PluginName != null &&
                    this.PluginName.Equals(input.PluginName))
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
                if (this.DbName != null)
                    hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.PluginName != null)
                    hashCode = hashCode * 59 + this.PluginName.GetHashCode();
                return hashCode;
            }
        }
    }
}
