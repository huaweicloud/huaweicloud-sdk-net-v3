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
    /// Response Object
    /// </summary>
    public class ChangeFailoverModeResponse : SdkResponse
    {

        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("instanceId", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 同步模式
        /// </summary>
        [JsonProperty("replicationMode", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationMode { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("workflowId", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeFailoverModeResponse {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  replicationMode: ").Append(ReplicationMode).Append("\n");
            sb.Append("  workflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeFailoverModeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeFailoverModeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.ReplicationMode == input.ReplicationMode ||
                    (this.ReplicationMode != null &&
                    this.ReplicationMode.Equals(input.ReplicationMode))
                ) && 
                (
                    this.WorkflowId == input.WorkflowId ||
                    (this.WorkflowId != null &&
                    this.WorkflowId.Equals(input.WorkflowId))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.ReplicationMode != null)
                    hashCode = hashCode * 59 + this.ReplicationMode.GetHashCode();
                if (this.WorkflowId != null)
                    hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                return hashCode;
            }
        }
    }
}
