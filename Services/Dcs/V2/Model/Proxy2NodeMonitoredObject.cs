using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Redis 4.0 和 5.0 proxy集群中proxy节点监控对象结构
    /// </summary>
    public class Proxy2NodeMonitoredObject 
    {

        /// <summary>
        /// 测量对象ID，即节点的ID。
        /// </summary>
        [JsonProperty("dcs_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DcsInstanceId { get; set; }

        /// <summary>
        /// 测量对象名称，即节点IP。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 维度dcs_cluster_proxy2_node 的测量对象的ID。
        /// </summary>
        [JsonProperty("dcs_cluster_proxy2_node", NullValueHandling = NullValueHandling.Ignore)]
        public string DcsClusterProxy2Node { get; set; }

        /// <summary>
        /// 测量对象状态，即节点状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Proxy2NodeMonitoredObject {\n");
            sb.Append("  dcsInstanceId: ").Append(DcsInstanceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  dcsClusterProxy2Node: ").Append(DcsClusterProxy2Node).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Proxy2NodeMonitoredObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Proxy2NodeMonitoredObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DcsInstanceId == input.DcsInstanceId ||
                    (this.DcsInstanceId != null &&
                    this.DcsInstanceId.Equals(input.DcsInstanceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DcsClusterProxy2Node == input.DcsClusterProxy2Node ||
                    (this.DcsClusterProxy2Node != null &&
                    this.DcsClusterProxy2Node.Equals(input.DcsClusterProxy2Node))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.DcsInstanceId != null)
                    hashCode = hashCode * 59 + this.DcsInstanceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DcsClusterProxy2Node != null)
                    hashCode = hashCode * 59 + this.DcsClusterProxy2Node.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
