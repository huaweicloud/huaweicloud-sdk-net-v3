using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowConfigurationParameterResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 参数模板ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 参数模板名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 数据库版本。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("datastore_version", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreVersion { get; set; }

        /// <summary>
        /// **参数解释：** 数据库类型。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("datastore_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreName { get; set; }

        /// <summary>
        /// **参数解释：** 参数模板描述。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间，格式为“yyyy-MM-ddTHH:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间，格式为“yyyy-MM-ddTHH:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// **参数解释：** 参数对象，用户基于默认参数模板自定义的参数配置。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConfigurationParametersResult> Parameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowConfigurationParameterResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  datastoreVersion: ").Append(DatastoreVersion).Append("\n");
            sb.Append("  datastoreName: ").Append(DatastoreName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowConfigurationParameterResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConfigurationParameterResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.DatastoreVersion != input.DatastoreVersion || (this.DatastoreVersion != null && !this.DatastoreVersion.Equals(input.DatastoreVersion))) return false;
            if (this.DatastoreName != input.DatastoreName || (this.DatastoreName != null && !this.DatastoreName.Equals(input.DatastoreName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;

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
                if (this.DatastoreVersion != null) hashCode = hashCode * 59 + this.DatastoreVersion.GetHashCode();
                if (this.DatastoreName != null) hashCode = hashCode * 59 + this.DatastoreName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
