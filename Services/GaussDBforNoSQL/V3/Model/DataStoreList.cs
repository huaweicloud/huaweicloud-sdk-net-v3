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
    /// 
    /// </summary>
    public class DataStoreList 
    {

        /// <summary>
        /// 数据库引擎。
        /// </summary>
        [JsonProperty("datastore_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreName { get; set; }

        /// <summary>
        /// 数据库引擎版本。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 实例类型。 取值为“Cluster”，表示GaussDB(for Cassandra)、GaussDB(for Influx)、GaussDB(for Redis)集群实例类型。 取值为“InfluxdbSingle”，表示GaussDB(for Influx)单节点实例类型。 取值为“ReplicaSet”，表示GaussDB(for Mongo)副本集实例类型。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataStoreList {\n");
            sb.Append("  datastoreName: ").Append(DatastoreName).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataStoreList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataStoreList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatastoreName == input.DatastoreName ||
                    (this.DatastoreName != null &&
                    this.DatastoreName.Equals(input.DatastoreName))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.DatastoreName != null)
                    hashCode = hashCode * 59 + this.DatastoreName.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
