using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 恢复模式信息
    /// </summary>
    public class PostgreSQLRestoreSchema 
    {

        /// <summary>
        /// 模式信息
        /// </summary>
        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public string Schema { get; set; }

        /// <summary>
        /// 表信息
        /// </summary>
        [JsonProperty("tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<PostgreSQLRestoreTable> Tables { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostgreSQLRestoreSchema {\n");
            sb.Append("  schema: ").Append(Schema).Append("\n");
            sb.Append("  tables: ").Append(Tables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostgreSQLRestoreSchema);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostgreSQLRestoreSchema input)
        {
            if (input == null) return false;
            if (this.Schema != input.Schema || (this.Schema != null && !this.Schema.Equals(input.Schema))) return false;
            if (this.Tables != input.Tables || (this.Tables != null && input.Tables != null && !this.Tables.SequenceEqual(input.Tables))) return false;

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
                if (this.Schema != null) hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.Tables != null) hashCode = hashCode * 59 + this.Tables.GetHashCode();
                return hashCode;
            }
        }
    }
}
