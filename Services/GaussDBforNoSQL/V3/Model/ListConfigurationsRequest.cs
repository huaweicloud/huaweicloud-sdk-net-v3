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
    public class ListConfigurationsRequest 
    {

        /// <summary>
        /// 【参数解释】 数据库名称。 【约束限制】 不限制。 【取值范围】 cassandra：表示支持GeminiDB Cassandra实例。 redis：表示支持GeminiDB Redis实例。 influxdb：表示支持GeminiDB Influx实例。 mongodb： 表示支持GeminiDB Mongo实例。 【默认取值】 不传该参数，则表示查询所有数据库类型。
        /// </summary>
        [SDKProperty("datastore_name", IsQuery = true)]
        [JsonProperty("datastore_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreName { get; set; }

        /// <summary>
        /// 【参数解释】 数据库实例类型。 【约束限制】 不限制。 【取值范围】 * 取值为“CloudNativeCluster”, 表示查询支持GeminiDB Cassandra云原生部署模式实例的参数模板。 * 取值为“Cluster”, 表示查询GeminiDB Cassandra经典部署模式实例、GeminiDB Influx经典部署模式实例、GeminiDB Redis Proxy集群经典部署模式实例支持的参数模板。 * 取值为“Replication”, 表示查询支持GeminiDB Redis经典部署模式主备类型实例的参数组。 * 取值为“InfluxdbSingle”, 表示查询支持GeminiDB Influx经典部署模式单节点类型实例的参数组。 * 取值为“ReplicaSet”, 表示查询支持GeminiDB Mongo副本集类型实例的参数组。 * 取值为“All”， 表示查询所有部署模式的参数模板。 【默认取值】 不传该参数，则表示查询经典部署模式实例支持的参数组。
        /// </summary>
        [SDKProperty("mode", IsQuery = true)]
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConfigurationsRequest {\n");
            sb.Append("  datastoreName: ").Append(DatastoreName).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConfigurationsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConfigurationsRequest input)
        {
            if (input == null) return false;
            if (this.DatastoreName != input.DatastoreName || (this.DatastoreName != null && !this.DatastoreName.Equals(input.DatastoreName))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;

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
                if (this.DatastoreName != null) hashCode = hashCode * 59 + this.DatastoreName.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
