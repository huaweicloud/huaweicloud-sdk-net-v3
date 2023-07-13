using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 数据加工对象
    /// </summary>
    public class DataTransformationObjectVO 
    {

        /// <summary>
        /// 数据库对象、数据库表名称和过滤类型名称，例如格式为db1-*-*-tb1-*-*- --conditionFilter- -。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// contentConditionalFilter：普通行过滤配置； configConditionalFilter：高级行过滤配置。
        /// </summary>
        [JsonProperty("data_transformation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DataTransformationType { get; set; }

        /// <summary>
        /// 库名称。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// schema名称。
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// 表名称。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataTransformationObjectVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  dataTransformationType: ").Append(DataTransformationType).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataTransformationObjectVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataTransformationObjectVO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DataTransformationType == input.DataTransformationType ||
                    (this.DataTransformationType != null &&
                    this.DataTransformationType.Equals(input.DataTransformationType))
                ) && 
                (
                    this.DbName == input.DbName ||
                    (this.DbName != null &&
                    this.DbName.Equals(input.DbName))
                ) && 
                (
                    this.SchemaName == input.SchemaName ||
                    (this.SchemaName != null &&
                    this.SchemaName.Equals(input.SchemaName))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DataTransformationType != null)
                    hashCode = hashCode * 59 + this.DataTransformationType.GetHashCode();
                if (this.DbName != null)
                    hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.SchemaName != null)
                    hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                return hashCode;
            }
        }
    }
}
