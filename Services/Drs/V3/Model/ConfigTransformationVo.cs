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
    /// 数据同步配置库规则信息体
    /// </summary>
    public class ConfigTransformationVo 
    {

        /// <summary>
        /// 库名.表名。
        /// </summary>
        [JsonProperty("db_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbTableName { get; set; }

        /// <summary>
        /// 库名。长度限制256。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 表名。长度限制256。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// 列名。长度限制256。
        /// </summary>
        [JsonProperty("col_names", NullValueHandling = NullValueHandling.Ignore)]
        public string ColNames { get; set; }

        /// <summary>
        /// 主键或唯一索引。长度限制256。
        /// </summary>
        [JsonProperty("prim_key_or_index", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimKeyOrIndex { get; set; }

        /// <summary>
        /// 优化查询所需的索引。长度限制256。
        /// </summary>
        [JsonProperty("indexs", NullValueHandling = NullValueHandling.Ignore)]
        public string Indexs { get; set; }

        /// <summary>
        /// 过滤条件。长度限制256。
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public string Values { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigTransformationVo {\n");
            sb.Append("  dbTableName: ").Append(DbTableName).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  colNames: ").Append(ColNames).Append("\n");
            sb.Append("  primKeyOrIndex: ").Append(PrimKeyOrIndex).Append("\n");
            sb.Append("  indexs: ").Append(Indexs).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigTransformationVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigTransformationVo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DbTableName == input.DbTableName ||
                    (this.DbTableName != null &&
                    this.DbTableName.Equals(input.DbTableName))
                ) && 
                (
                    this.DbName == input.DbName ||
                    (this.DbName != null &&
                    this.DbName.Equals(input.DbName))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.ColNames == input.ColNames ||
                    (this.ColNames != null &&
                    this.ColNames.Equals(input.ColNames))
                ) && 
                (
                    this.PrimKeyOrIndex == input.PrimKeyOrIndex ||
                    (this.PrimKeyOrIndex != null &&
                    this.PrimKeyOrIndex.Equals(input.PrimKeyOrIndex))
                ) && 
                (
                    this.Indexs == input.Indexs ||
                    (this.Indexs != null &&
                    this.Indexs.Equals(input.Indexs))
                ) && 
                (
                    this.Values == input.Values ||
                    (this.Values != null &&
                    this.Values.Equals(input.Values))
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
                if (this.DbTableName != null)
                    hashCode = hashCode * 59 + this.DbTableName.GetHashCode();
                if (this.DbName != null)
                    hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.ColNames != null)
                    hashCode = hashCode * 59 + this.ColNames.GetHashCode();
                if (this.PrimKeyOrIndex != null)
                    hashCode = hashCode * 59 + this.PrimKeyOrIndex.GetHashCode();
                if (this.Indexs != null)
                    hashCode = hashCode * 59 + this.Indexs.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
