using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListHtapStorageTypeRequest 
    {

        /// <summary>
        /// HTAP数据库名。 取值范围： - star-rocks - click-house
        /// </summary>
        [SDKProperty("database", IsPath = true)]
        [JsonProperty("database", NullValueHandling = NullValueHandling.Ignore)]
        public string Database { get; set; }

        /// <summary>
        /// 数据库大版本号
        /// </summary>
        [SDKProperty("version_name", IsQuery = true)]
        [JsonProperty("version_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionName { get; set; }

        /// <summary>
        /// 请求语言类型。默认en-us。 取值范围： - en-us - zh-cn
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHtapStorageTypeRequest {\n");
            sb.Append("  database: ").Append(Database).Append("\n");
            sb.Append("  versionName: ").Append(VersionName).Append("\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHtapStorageTypeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHtapStorageTypeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Database == input.Database ||
                    (this.Database != null &&
                    this.Database.Equals(input.Database))
                ) && 
                (
                    this.VersionName == input.VersionName ||
                    (this.VersionName != null &&
                    this.VersionName.Equals(input.VersionName))
                ) && 
                (
                    this.XLanguage == input.XLanguage ||
                    (this.XLanguage != null &&
                    this.XLanguage.Equals(input.XLanguage))
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
                if (this.Database != null)
                    hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.VersionName != null)
                    hashCode = hashCode * 59 + this.VersionName.GetHashCode();
                if (this.XLanguage != null)
                    hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                return hashCode;
            }
        }
    }
}
