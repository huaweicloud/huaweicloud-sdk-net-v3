using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeploymentHostsCopyRequest 
    {

        /// <summary>
        /// 主机id列表
        /// </summary>
        [JsonProperty("host_uuids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HostUuids { get; set; }

        /// <summary>
        /// 目标主机集群id
        /// </summary>
        [JsonProperty("target_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentHostsCopyRequest {\n");
            sb.Append("  hostUuids: ").Append(HostUuids).Append("\n");
            sb.Append("  targetGroupId: ").Append(TargetGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeploymentHostsCopyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeploymentHostsCopyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HostUuids == input.HostUuids ||
                    this.HostUuids != null &&
                    input.HostUuids != null &&
                    this.HostUuids.SequenceEqual(input.HostUuids)
                ) && 
                (
                    this.TargetGroupId == input.TargetGroupId ||
                    (this.TargetGroupId != null &&
                    this.TargetGroupId.Equals(input.TargetGroupId))
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
                if (this.HostUuids != null)
                    hashCode = hashCode * 59 + this.HostUuids.GetHashCode();
                if (this.TargetGroupId != null)
                    hashCode = hashCode * 59 + this.TargetGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
