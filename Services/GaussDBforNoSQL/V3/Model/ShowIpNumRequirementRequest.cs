using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowIpNumRequirementRequest 
    {

        /// <summary>
        /// 创建实例或扩容节点的个数。最大支持输入200。
        /// </summary>
        [SDKProperty("node_num", IsQuery = true)]
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// 数据库引擎名称。没有传入实例ID的时候该字段为必传。   - 取值为“cassandra”，表示GeminiDB Cassandra数据库引擎。   - 取值为“mongodb”，表示GeminiDB Mongo数据库引擎。   - 取值为“influxdb”，表示GeminiDB Influx数据库引擎。   - 取值为“redis”，表示GeminiDB Redis数据库引擎。
        /// </summary>
        [SDKProperty("engine_name", IsQuery = true)]
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// 实例类型。没有传入实例ID的时候该字段为必传。   -  取值为“Cluster”，表示GeminiDB Cassandra、GeminiDB Influx、GeminiDB Redis Proxy经典部署模式集群实例类型。   -  取值为“CloudNativeCluster”，表示GeminiDB Cassandra、GeminiDB Influx、GeminiDB Redis云原生部署模式集群实例类型。   -  取值为“RedisCluster”，表示GeminiDB Redis Cluster经典部署模式集群实例类型。   -  取值为“Replication”，表示GeminiDB Redis经典部署模式主备实例类型。   -  取值为“InfluxdbSingle”，表示GeminiDB Influx经典部署模式单节点实例类型。   -  取值为“ReplicaSet”，表示GeminiDB Mongo副本集实例类型。
        /// </summary>
        [SDKProperty("instance_mode", IsQuery = true)]
        [JsonProperty("instance_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceMode { get; set; }

        /// <summary>
        /// 实例Id，可以调用5.3.3 查询实例列表和详情接口获取。如果未申请实例，可以调用5.3.1 创建实例接口创建。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIpNumRequirementRequest {\n");
            sb.Append("  nodeNum: ").Append(NodeNum).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  instanceMode: ").Append(InstanceMode).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIpNumRequirementRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIpNumRequirementRequest input)
        {
            if (input == null) return false;
            if (this.NodeNum != input.NodeNum || (this.NodeNum != null && !this.NodeNum.Equals(input.NodeNum))) return false;
            if (this.EngineName != input.EngineName || (this.EngineName != null && !this.EngineName.Equals(input.EngineName))) return false;
            if (this.InstanceMode != input.InstanceMode || (this.InstanceMode != null && !this.InstanceMode.Equals(input.InstanceMode))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;

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
                if (this.NodeNum != null) hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                if (this.EngineName != null) hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.InstanceMode != null) hashCode = hashCode * 59 + this.InstanceMode.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
