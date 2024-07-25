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
    /// 
    /// </summary>
    public class NodePoolUpgradeSpec 
    {

        /// <summary>
        /// 节点池id。
        /// </summary>
        [JsonProperty("nodePoolID", NullValueHandling = NullValueHandling.Ignore)]
        public string NodePoolID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeIDs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeIDs { get; set; }

        /// <summary>
        /// Pod无法驱逐时，是否强制重置。
        /// </summary>
        [JsonProperty("force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public NodeTemplate NodeTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("maxUnavailable", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxUnavailable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("retryTimes", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetryTimes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("skippedNodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SkippedNodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodePoolUpgradeSpec {\n");
            sb.Append("  nodePoolID: ").Append(NodePoolID).Append("\n");
            sb.Append("  nodeIDs: ").Append(NodeIDs).Append("\n");
            sb.Append("  force: ").Append(Force).Append("\n");
            sb.Append("  nodeTemplate: ").Append(NodeTemplate).Append("\n");
            sb.Append("  maxUnavailable: ").Append(MaxUnavailable).Append("\n");
            sb.Append("  retryTimes: ").Append(RetryTimes).Append("\n");
            sb.Append("  skippedNodes: ").Append(SkippedNodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodePoolUpgradeSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodePoolUpgradeSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodePoolID == input.NodePoolID ||
                    (this.NodePoolID != null &&
                    this.NodePoolID.Equals(input.NodePoolID))
                ) && 
                (
                    this.NodeIDs == input.NodeIDs ||
                    this.NodeIDs != null &&
                    input.NodeIDs != null &&
                    this.NodeIDs.SequenceEqual(input.NodeIDs)
                ) && 
                (
                    this.Force == input.Force ||
                    (this.Force != null &&
                    this.Force.Equals(input.Force))
                ) && 
                (
                    this.NodeTemplate == input.NodeTemplate ||
                    (this.NodeTemplate != null &&
                    this.NodeTemplate.Equals(input.NodeTemplate))
                ) && 
                (
                    this.MaxUnavailable == input.MaxUnavailable ||
                    (this.MaxUnavailable != null &&
                    this.MaxUnavailable.Equals(input.MaxUnavailable))
                ) && 
                (
                    this.RetryTimes == input.RetryTimes ||
                    (this.RetryTimes != null &&
                    this.RetryTimes.Equals(input.RetryTimes))
                ) && 
                (
                    this.SkippedNodes == input.SkippedNodes ||
                    this.SkippedNodes != null &&
                    input.SkippedNodes != null &&
                    this.SkippedNodes.SequenceEqual(input.SkippedNodes)
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
                if (this.NodePoolID != null)
                    hashCode = hashCode * 59 + this.NodePoolID.GetHashCode();
                if (this.NodeIDs != null)
                    hashCode = hashCode * 59 + this.NodeIDs.GetHashCode();
                if (this.Force != null)
                    hashCode = hashCode * 59 + this.Force.GetHashCode();
                if (this.NodeTemplate != null)
                    hashCode = hashCode * 59 + this.NodeTemplate.GetHashCode();
                if (this.MaxUnavailable != null)
                    hashCode = hashCode * 59 + this.MaxUnavailable.GetHashCode();
                if (this.RetryTimes != null)
                    hashCode = hashCode * 59 + this.RetryTimes.GetHashCode();
                if (this.SkippedNodes != null)
                    hashCode = hashCode * 59 + this.SkippedNodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
