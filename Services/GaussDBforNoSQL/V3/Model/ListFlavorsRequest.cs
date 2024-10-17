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
    public class ListFlavorsRequest 
    {

        /// <summary>
        /// 实例所在区域。
        /// </summary>
        [SDKProperty("region", IsQuery = true)]
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 数据库类型。   - 取值为“cassandra”，表示查询GeminiDB Cassandra数据库实例支持的规格。   - 取值为“mongodb”，表示查询GeminiDB Mongo数据库实例支持的规格。   - 取值为“influxdb”，表示查询GeminiDB Influx数据库实例支持的规格。   - 取值为“redis”，表示查询GeminiDB Redis数据库实例支持的规格。   - 如果不传该参数，默认为“cassandra”。
        /// </summary>
        [SDKProperty("engine_name", IsQuery = true)]
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFlavorsRequest {\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFlavorsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFlavorsRequest input)
        {
            if (input == null) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.EngineName != input.EngineName || (this.EngineName != null && !this.EngineName.Equals(input.EngineName))) return false;

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
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.EngineName != null) hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                return hashCode;
            }
        }
    }
}
