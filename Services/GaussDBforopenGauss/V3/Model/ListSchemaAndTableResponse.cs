using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSchemaAndTableResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 数据库表信息列表。
        /// </summary>
        [JsonProperty("database_tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatabaseSchemaTableResult> DatabaseTables { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSchemaAndTableResponse {\n");
            sb.Append("  databaseTables: ").Append(DatabaseTables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSchemaAndTableResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSchemaAndTableResponse input)
        {
            if (input == null) return false;
            if (this.DatabaseTables != input.DatabaseTables || (this.DatabaseTables != null && input.DatabaseTables != null && !this.DatabaseTables.SequenceEqual(input.DatabaseTables))) return false;

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
                if (this.DatabaseTables != null) hashCode = hashCode * 59 + this.DatabaseTables.GetHashCode();
                return hashCode;
            }
        }
    }
}
