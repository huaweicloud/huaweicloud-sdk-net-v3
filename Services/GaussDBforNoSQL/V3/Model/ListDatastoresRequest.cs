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
    public class ListDatastoresRequest 
    {

        /// <summary>
        /// 数据库类型。   - GeminiDB Cassandra数据库实例，取值为“cassandra”。   - GeminiDB Mongo数据库实例，取值为“mongodb”。   - GeminiDB Influx数据库实例，取值为“influxdb”。   - GeminiDB Redis数据库实例，取值为“redis”。
        /// </summary>
        [SDKProperty("datastore_name", IsPath = true)]
        [JsonProperty("datastore_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDatastoresRequest {\n");
            sb.Append("  datastoreName: ").Append(DatastoreName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDatastoresRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDatastoresRequest input)
        {
            if (input == null) return false;
            if (this.DatastoreName != input.DatastoreName || (this.DatastoreName != null && !this.DatastoreName.Equals(input.DatastoreName))) return false;

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
                return hashCode;
            }
        }
    }
}
