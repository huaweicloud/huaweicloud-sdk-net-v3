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
    public class ShowQuotasRequest 
    {

        /// <summary>
        /// 数据库类型。 取值为“cassandra”，表示查询GaussDB(for Cassandra)数据库实例配额。 取值为“mongodb”，表示GaussDB(for Mongo)查询数据库实例配额。 取值为“influxdb”，表示查询GaussDB(for Influx)数据库实例配额。 取值为“redis”，表示查询GaussDB(for Redis)数据库实例配额。 如果不传该参数，表示查询所有数据库实例配额。
        /// </summary>
        [SDKProperty("datastore_type", IsQuery = true)]
        [JsonProperty("datastore_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreType { get; set; }

        /// <summary>
        /// 实例类型。 取值为“Cluster”，表示GaussDB(for Cassandra)、GaussDB(for Influx)、GaussDB(for Redis)集群实例类型。 取值为“InfluxdbSingle”，表示GaussDB(for Influx)单节点实例类型。 取值为“ReplicaSet”，表示GaussDB(for Mongo)副本集实例类型。 如果不传datastore_type参数，自动忽略该参数设置，传入datastore_type时，该参数必填。
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
            sb.Append("class ShowQuotasRequest {\n");
            sb.Append("  datastoreType: ").Append(DatastoreType).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowQuotasRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowQuotasRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatastoreType == input.DatastoreType ||
                    (this.DatastoreType != null &&
                    this.DatastoreType.Equals(input.DatastoreType))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
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
                if (this.DatastoreType != null)
                    hashCode = hashCode * 59 + this.DatastoreType.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
