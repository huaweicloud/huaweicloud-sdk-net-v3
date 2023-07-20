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
    public class ExtensionRequest 
    {

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// 插件名称。
        /// </summary>
        [JsonProperty("extension_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtensionName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionRequest {\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  extensionName: ").Append(ExtensionName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtensionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtensionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatabaseName == input.DatabaseName ||
                    (this.DatabaseName != null &&
                    this.DatabaseName.Equals(input.DatabaseName))
                ) && 
                (
                    this.ExtensionName == input.ExtensionName ||
                    (this.ExtensionName != null &&
                    this.ExtensionName.Equals(input.ExtensionName))
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
                if (this.DatabaseName != null)
                    hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.ExtensionName != null)
                    hashCode = hashCode * 59 + this.ExtensionName.GetHashCode();
                return hashCode;
            }
        }
    }
}
