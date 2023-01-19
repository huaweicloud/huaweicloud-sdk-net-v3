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
    public class DatastoreOption 
    {

        /// <summary>
        /// 数据库类型。 - 支持GaussDB(for Cassandra)，GaussDB(for Mongo)，GaussDB(for Influx)数据库实例。 - 取值为“cassandra”，表示创建GaussDB(for Cassandra)数据库实例。 - 取值为“mongodb”，表示创建GaussDB(for Mongo)数据库实例。 - 取值为“influxdb”，表示创建GaussDB(for Influx)数据库实例。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 数据库版本。 - GaussDB(for Cassandra)实例支持3.11版本，取值为“3.11”。 - GaussDB(for Mongo)实例支持3.4，4.0版本，取值为\&quot;3.4\&quot;或\&quot;4.0\&quot;。 - GaussDB(for Influx)实例支持1.7版本，取值为“1.7”。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 存储引擎。 - GaussDB(for Cassandra)实例支持RocksDB存储引擎，取值为“rocksDB”。 - GaussDB(for Mongo)实例支持RocksDB存储引擎，取值为“rocksDB”。 - GaussDB(for Influx)实例支持RocksDB存储引擎，取值为“rocksDB”。
        /// </summary>
        [JsonProperty("storage_engine", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageEngine { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatastoreOption {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  storageEngine: ").Append(StorageEngine).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatastoreOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatastoreOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.StorageEngine == input.StorageEngine ||
                    (this.StorageEngine != null &&
                    this.StorageEngine.Equals(input.StorageEngine))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.StorageEngine != null)
                    hashCode = hashCode * 59 + this.StorageEngine.GetHashCode();
                return hashCode;
            }
        }
    }
}
