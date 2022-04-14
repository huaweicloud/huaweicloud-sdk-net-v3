using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 转发IoTA服务消息结构
    /// </summary>
    public class IoTAForwarding 
    {

        /// <summary>
        /// **参数说明**：IoTA服务对应的数据源Id。
        /// </summary>
        [JsonProperty("data_source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// **参数说明**：IoTA服务对应的projectId信息。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IoTAForwarding {\n");
            sb.Append("  dataSourceId: ").Append(DataSourceId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IoTAForwarding);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IoTAForwarding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataSourceId == input.DataSourceId ||
                    (this.DataSourceId != null &&
                    this.DataSourceId.Equals(input.DataSourceId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                if (this.DataSourceId != null)
                    hashCode = hashCode * 59 + this.DataSourceId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
