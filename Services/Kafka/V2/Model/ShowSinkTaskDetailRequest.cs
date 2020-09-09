using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowSinkTaskDetailRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("connector_id", IsPath = true)]
        [JsonProperty("connector_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("task_id", IsPath = true)]
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSinkTaskDetailRequest {\n");
            sb.Append("  connectorId: ").Append(ConnectorId).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSinkTaskDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSinkTaskDetailRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConnectorId == input.ConnectorId ||
                    (this.ConnectorId != null &&
                    this.ConnectorId.Equals(input.ConnectorId))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
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
                if (this.ConnectorId != null)
                    hashCode = hashCode * 59 + this.ConnectorId.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                return hashCode;
            }
        }
    }
}
