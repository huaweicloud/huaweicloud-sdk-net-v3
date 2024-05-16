using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 端口信息。
    /// </summary>
    public class StarRocksInstanceInfoPortInfo 
    {

        /// <summary>
        /// MySQL端口号。默认3306。
        /// </summary>
        [JsonProperty("mysql_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? MysqlPort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StarRocksInstanceInfoPortInfo {\n");
            sb.Append("  mysqlPort: ").Append(MysqlPort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StarRocksInstanceInfoPortInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StarRocksInstanceInfoPortInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MysqlPort == input.MysqlPort ||
                    (this.MysqlPort != null &&
                    this.MysqlPort.Equals(input.MysqlPort))
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
                if (this.MysqlPort != null)
                    hashCode = hashCode * 59 + this.MysqlPort.GetHashCode();
                return hashCode;
            }
        }
    }
}
