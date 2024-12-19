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
    public class ShowInstanceParamGroupDetailResponse : SdkResponse
    {

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
        /// 创建时间，格式为\&quot;yyyy-MM-dd HH:mm:ss\&quot;。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 更新时间，格式为\&quot;yyyy-MM-ddHH:mm:ss\&quot;。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 参数对象，用户基于默认参数模板自定义的参数配置。
        /// </summary>
        [JsonProperty("configuration_parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConfigurationParameter> ConfigurationParameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceParamGroupDetailResponse {\n");
            sb.Append("  datastoreVersion: ").Append(DatastoreVersion).Append("\n");
            sb.Append("  datastoreName: ").Append(DatastoreName).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  configurationParameters: ").Append(ConfigurationParameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceParamGroupDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceParamGroupDetailResponse input)
        {
            if (input == null) return false;
            if (this.DatastoreVersion != input.DatastoreVersion || (this.DatastoreVersion != null && !this.DatastoreVersion.Equals(input.DatastoreVersion))) return false;
            if (this.DatastoreName != input.DatastoreName || (this.DatastoreName != null && !this.DatastoreName.Equals(input.DatastoreName))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.ConfigurationParameters != input.ConfigurationParameters || (this.ConfigurationParameters != null && input.ConfigurationParameters != null && !this.ConfigurationParameters.SequenceEqual(input.ConfigurationParameters))) return false;

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
                if (this.DatastoreVersion != null) hashCode = hashCode * 59 + this.DatastoreVersion.GetHashCode();
                if (this.DatastoreName != null) hashCode = hashCode * 59 + this.DatastoreName.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.ConfigurationParameters != null) hashCode = hashCode * 59 + this.ConfigurationParameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
