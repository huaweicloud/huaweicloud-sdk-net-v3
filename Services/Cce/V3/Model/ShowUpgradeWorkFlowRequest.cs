using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowUpgradeWorkFlowRequest 
    {

        /// <summary>
        /// 集群ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。
        /// </summary>
        [SDKProperty("cluster_id", IsPath = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 集群升级任务引导流程ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。
        /// </summary>
        [SDKProperty("upgrade_workflow_id", IsPath = true)]
        [JsonProperty("upgrade_workflow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeWorkflowId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUpgradeWorkFlowRequest {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  upgradeWorkflowId: ").Append(UpgradeWorkflowId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUpgradeWorkFlowRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUpgradeWorkFlowRequest input)
        {
            if (input == null) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.UpgradeWorkflowId != input.UpgradeWorkflowId || (this.UpgradeWorkflowId != null && !this.UpgradeWorkflowId.Equals(input.UpgradeWorkflowId))) return false;

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
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.UpgradeWorkflowId != null) hashCode = hashCode * 59 + this.UpgradeWorkflowId.GetHashCode();
                return hashCode;
            }
        }
    }
}
