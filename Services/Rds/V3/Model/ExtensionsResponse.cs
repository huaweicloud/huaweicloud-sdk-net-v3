using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExtensionsResponse 
    {

        /// <summary>
        /// 插件名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// 插件版本。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 依赖预加载库。
        /// </summary>
        [JsonProperty("shared_preload_libraries", NullValueHandling = NullValueHandling.Ignore)]
        public string SharedPreloadLibraries { get; set; }

        /// <summary>
        /// 是否创建。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Created { get; set; }

        /// <summary>
        /// 插件描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionsResponse {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  sharedPreloadLibraries: ").Append(SharedPreloadLibraries).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtensionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtensionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DatabaseName == input.DatabaseName ||
                    (this.DatabaseName != null &&
                    this.DatabaseName.Equals(input.DatabaseName))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.SharedPreloadLibraries == input.SharedPreloadLibraries ||
                    (this.SharedPreloadLibraries != null &&
                    this.SharedPreloadLibraries.Equals(input.SharedPreloadLibraries))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DatabaseName != null)
                    hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.SharedPreloadLibraries != null)
                    hashCode = hashCode * 59 + this.SharedPreloadLibraries.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
