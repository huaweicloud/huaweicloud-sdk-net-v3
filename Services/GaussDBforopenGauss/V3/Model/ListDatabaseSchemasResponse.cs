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
    public class ListDatabaseSchemasResponse : SdkResponse
    {

        /// <summary>
        /// 列表中每个元素表示一个数据库schema。
        /// </summary>
        [JsonProperty("database_schemas", NullValueHandling = NullValueHandling.Ignore)]
        public List<GaussDBforOpenGaussDatabaseForListSchema> DatabaseSchemas { get; set; }

        /// <summary>
        /// 数据库schema总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDatabaseSchemasResponse {\n");
            sb.Append("  databaseSchemas: ").Append(DatabaseSchemas).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDatabaseSchemasResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDatabaseSchemasResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatabaseSchemas == input.DatabaseSchemas ||
                    this.DatabaseSchemas != null &&
                    input.DatabaseSchemas != null &&
                    this.DatabaseSchemas.SequenceEqual(input.DatabaseSchemas)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.DatabaseSchemas != null)
                    hashCode = hashCode * 59 + this.DatabaseSchemas.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
