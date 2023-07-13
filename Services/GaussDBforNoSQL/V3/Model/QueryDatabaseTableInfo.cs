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
    /// 备份里的库表信息。 - 为空表示实例级查询 - 非空表示库表级查询
    /// </summary>
    public class QueryDatabaseTableInfo 
    {

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// 表名称列表。 - table_names为空的时候，表示库级别查询。 - table_names非空的时候，表示表级别查询。
        /// </summary>
        [JsonProperty("table_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TableNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryDatabaseTableInfo {\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  tableNames: ").Append(TableNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryDatabaseTableInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryDatabaseTableInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatabaseName == input.DatabaseName ||
                    (this.DatabaseName != null &&
                    this.DatabaseName.Equals(input.DatabaseName))
                ) && 
                (
                    this.TableNames == input.TableNames ||
                    this.TableNames != null &&
                    input.TableNames != null &&
                    this.TableNames.SequenceEqual(input.TableNames)
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
                if (this.DatabaseName != null)
                    hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.TableNames != null)
                    hashCode = hashCode * 59 + this.TableNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
