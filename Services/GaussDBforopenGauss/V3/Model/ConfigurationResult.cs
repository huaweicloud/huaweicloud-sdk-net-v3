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
    /// 参数模板信息。
    /// </summary>
    public class ConfigurationResult 
    {

        /// <summary>
        /// 参数组ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 参数组名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数组描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 引擎版本。
        /// </summary>
        [JsonProperty("datastore_version", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreVersion { get; set; }

        /// <summary>
        /// 引擎名称。
        /// </summary>
        [JsonProperty("datastore_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreName { get; set; }

        /// <summary>
        /// 实例类型。
        /// </summary>
        [JsonProperty("ha_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string HaMode { get; set; }

        /// <summary>
        /// 创建时间，格式为\&quot;yyyy-MM-dd HH:mm:ss\&quot;。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 更新时间，格式为\&quot;yyyy-MM-dd HH:mm:ss\&quot;。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 是否是用户自定义参数模板：  - false，表示为系统默认参数模板。 - true，表示为用户自定义参数模板。
        /// </summary>
        [JsonProperty("user_defined", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserDefined { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  datastoreVersion: ").Append(DatastoreVersion).Append("\n");
            sb.Append("  datastoreName: ").Append(DatastoreName).Append("\n");
            sb.Append("  haMode: ").Append(HaMode).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  userDefined: ").Append(UserDefined).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigurationResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigurationResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DatastoreVersion != input.DatastoreVersion || (this.DatastoreVersion != null && !this.DatastoreVersion.Equals(input.DatastoreVersion))) return false;
            if (this.DatastoreName != input.DatastoreName || (this.DatastoreName != null && !this.DatastoreName.Equals(input.DatastoreName))) return false;
            if (this.HaMode != input.HaMode || (this.HaMode != null && !this.HaMode.Equals(input.HaMode))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.UserDefined != input.UserDefined || (this.UserDefined != null && !this.UserDefined.Equals(input.UserDefined))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DatastoreVersion != null) hashCode = hashCode * 59 + this.DatastoreVersion.GetHashCode();
                if (this.DatastoreName != null) hashCode = hashCode * 59 + this.DatastoreName.GetHashCode();
                if (this.HaMode != null) hashCode = hashCode * 59 + this.HaMode.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.UserDefined != null) hashCode = hashCode * 59 + this.UserDefined.GetHashCode();
                return hashCode;
            }
        }
    }
}
