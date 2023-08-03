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
    /// 组件列表
    /// </summary>
    public class Components 
    {

        /// <summary>
        /// 组件id，当组件类型为DN，组件id为6001，则对应的值为dn_6001。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 节点类型，取值为“master”、“slave”，分别对应于主节点、备节点。
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// 组件状态。 Primary：该组件为主。 Normal：该组件状态正常。 Down：该组件处于宕机状态。 Standby：该组件为备。 StateFollower：该ETCD为备。 StateLeader：该ETCD为主。 StateCandidate：该ETCD为仲裁。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 分组id，只有dn组件有分组id，用于区分是否是同一个分片下的组件。其他组件为空字符串。
        /// </summary>
        [JsonProperty("distributed_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DistributedId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Components {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  distributedId: ").Append(DistributedId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Components);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Components input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.DistributedId == input.DistributedId ||
                    (this.DistributedId != null &&
                    this.DistributedId.Equals(input.DistributedId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DistributedId != null)
                    hashCode = hashCode * 59 + this.DistributedId.GetHashCode();
                return hashCode;
            }
        }
    }
}
