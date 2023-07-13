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
    public class AttachEipResponse : SdkResponse
    {

        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 节点ID。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 节点名称。
        /// </summary>
        [JsonProperty("node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }

        /// <summary>
        /// 公网IP的ID。
        /// </summary>
        [JsonProperty("public_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpId { get; set; }

        /// <summary>
        /// 公网IP。
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachEipResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("  publicIpId: ").Append(PublicIpId).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachEipResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachEipResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.NodeName == input.NodeName ||
                    (this.NodeName != null &&
                    this.NodeName.Equals(input.NodeName))
                ) && 
                (
                    this.PublicIpId == input.PublicIpId ||
                    (this.PublicIpId != null &&
                    this.PublicIpId.Equals(input.PublicIpId))
                ) && 
                (
                    this.PublicIp == input.PublicIp ||
                    (this.PublicIp != null &&
                    this.PublicIp.Equals(input.PublicIp))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NodeName != null)
                    hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.PublicIpId != null)
                    hashCode = hashCode * 59 + this.PublicIpId.GetHashCode();
                if (this.PublicIp != null)
                    hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
