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
    public class ShowDeploymentFormResponse : SdkResponse
    {

        /// <summary>
        /// 初始节点数。
        /// </summary>
        [JsonProperty("initial_node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? InitialNodeNum { get; set; }

        /// <summary>
        /// 解决方案模板名称。
        /// </summary>
        [JsonProperty("solution", NullValueHandling = NullValueHandling.Ignore)]
        public string Solution { get; set; }

        /// <summary>
        /// 分片数。
        /// </summary>
        [JsonProperty("shard_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShardNum { get; set; }

        /// <summary>
        /// 副本数。
        /// </summary>
        [JsonProperty("replica_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReplicaNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDeploymentFormResponse {\n");
            sb.Append("  initialNodeNum: ").Append(InitialNodeNum).Append("\n");
            sb.Append("  solution: ").Append(Solution).Append("\n");
            sb.Append("  shardNum: ").Append(ShardNum).Append("\n");
            sb.Append("  replicaNum: ").Append(ReplicaNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDeploymentFormResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDeploymentFormResponse input)
        {
            if (input == null) return false;
            if (this.InitialNodeNum != input.InitialNodeNum || (this.InitialNodeNum != null && !this.InitialNodeNum.Equals(input.InitialNodeNum))) return false;
            if (this.Solution != input.Solution || (this.Solution != null && !this.Solution.Equals(input.Solution))) return false;
            if (this.ShardNum != input.ShardNum || (this.ShardNum != null && !this.ShardNum.Equals(input.ShardNum))) return false;
            if (this.ReplicaNum != input.ReplicaNum || (this.ReplicaNum != null && !this.ReplicaNum.Equals(input.ReplicaNum))) return false;

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
                if (this.InitialNodeNum != null) hashCode = hashCode * 59 + this.InitialNodeNum.GetHashCode();
                if (this.Solution != null) hashCode = hashCode * 59 + this.Solution.GetHashCode();
                if (this.ShardNum != null) hashCode = hashCode * 59 + this.ShardNum.GetHashCode();
                if (this.ReplicaNum != null) hashCode = hashCode * 59 + this.ReplicaNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
