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
    public class ShowNodePoolRequest 
    {

        /// <summary>
        /// 集群ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。
        /// </summary>
        [SDKProperty("cluster_id", IsPath = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 节点池ID
        /// </summary>
        [SDKProperty("nodepool_id", IsPath = true)]
        [JsonProperty("nodepool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodepoolId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNodePoolRequest {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  nodepoolId: ").Append(NodepoolId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowNodePoolRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowNodePoolRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.NodepoolId == input.NodepoolId ||
                    (this.NodepoolId != null &&
                    this.NodepoolId.Equals(input.NodepoolId))
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
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.NodepoolId != null)
                    hashCode = hashCode * 59 + this.NodepoolId.GetHashCode();
                return hashCode;
            }
        }
    }
}
