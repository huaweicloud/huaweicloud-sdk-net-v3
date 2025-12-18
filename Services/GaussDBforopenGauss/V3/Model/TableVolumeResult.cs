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
    /// 
    /// </summary>
    public class TableVolumeResult 
    {

        /// <summary>
        /// **参数解释**: 表的大小。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("table_size", NullValueHandling = NullValueHandling.Ignore)]
        public string TableSize { get; set; }

        /// <summary>
        /// **参数解释**: 表ID。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**: 表名称。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// **参数解释**: 表所属用户名称。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("table_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string TableOwner { get; set; }

        /// <summary>
        /// **参数解释**: schema名称。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// **参数解释**: 数据库名称。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// **参数解释**: 表或者索引是否具有分区表的性质。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("is_part_type", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPartType { get; set; }

        /// <summary>
        /// **参数解释**: 是否包含hash分区列信息。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("is_hash_cluster_key", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHashClusterKey { get; set; }

        /// <summary>
        /// **参数解释**: 表中行的数目。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("tuples", NullValueHandling = NullValueHandling.Ignore)]
        public string Tuples { get; set; }

        /// <summary>
        /// **参数解释**: 创建时间。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// **参数解释**: 修改时间。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// **参数解释**: 表大小平均值(totalsize/DN个数，该值为平均分布的理想情况下，表在各DN占用空间大小)。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("average_size", NullValueHandling = NullValueHandling.Ignore)]
        public string AverageSize { get; set; }

        /// <summary>
        /// **参数解释**: 单DN表大小最大值占比（表在各DN占用空间的最大值/totalsize）。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("max_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxRatio { get; set; }

        /// <summary>
        /// **参数解释**: 单DN表大小最小值占比（表在各DN占用空间的最小值/totalsize）。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("min_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string MinRatio { get; set; }

        /// <summary>
        /// **参数解释**: 表分布倾斜值（单DN表大小最大值 - 单DN表大小最小值）。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("skew_size", NullValueHandling = NullValueHandling.Ignore)]
        public string SkewSize { get; set; }

        /// <summary>
        /// **参数解释**: 表分布倾斜率（skewsize/totalsize）。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("skew_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string SkewRatio { get; set; }

        /// <summary>
        /// **参数解释**: 表分布标准方差（在表大小一定的情况下，该值越大表明表的整体分布情况越倾斜）。。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("skew_stddev", NullValueHandling = NullValueHandling.Ignore)]
        public string SkewStddev { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableVolumeResult {\n");
            sb.Append("  tableSize: ").Append(TableSize).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  tableOwner: ").Append(TableOwner).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  isPartType: ").Append(IsPartType).Append("\n");
            sb.Append("  isHashClusterKey: ").Append(IsHashClusterKey).Append("\n");
            sb.Append("  tuples: ").Append(Tuples).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  averageSize: ").Append(AverageSize).Append("\n");
            sb.Append("  maxRatio: ").Append(MaxRatio).Append("\n");
            sb.Append("  minRatio: ").Append(MinRatio).Append("\n");
            sb.Append("  skewSize: ").Append(SkewSize).Append("\n");
            sb.Append("  skewRatio: ").Append(SkewRatio).Append("\n");
            sb.Append("  skewStddev: ").Append(SkewStddev).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TableVolumeResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TableVolumeResult input)
        {
            if (input == null) return false;
            if (this.TableSize != input.TableSize || (this.TableSize != null && !this.TableSize.Equals(input.TableSize))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.TableOwner != input.TableOwner || (this.TableOwner != null && !this.TableOwner.Equals(input.TableOwner))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.IsPartType != input.IsPartType || (this.IsPartType != null && !this.IsPartType.Equals(input.IsPartType))) return false;
            if (this.IsHashClusterKey != input.IsHashClusterKey || (this.IsHashClusterKey != null && !this.IsHashClusterKey.Equals(input.IsHashClusterKey))) return false;
            if (this.Tuples != input.Tuples || (this.Tuples != null && !this.Tuples.Equals(input.Tuples))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.AverageSize != input.AverageSize || (this.AverageSize != null && !this.AverageSize.Equals(input.AverageSize))) return false;
            if (this.MaxRatio != input.MaxRatio || (this.MaxRatio != null && !this.MaxRatio.Equals(input.MaxRatio))) return false;
            if (this.MinRatio != input.MinRatio || (this.MinRatio != null && !this.MinRatio.Equals(input.MinRatio))) return false;
            if (this.SkewSize != input.SkewSize || (this.SkewSize != null && !this.SkewSize.Equals(input.SkewSize))) return false;
            if (this.SkewRatio != input.SkewRatio || (this.SkewRatio != null && !this.SkewRatio.Equals(input.SkewRatio))) return false;
            if (this.SkewStddev != input.SkewStddev || (this.SkewStddev != null && !this.SkewStddev.Equals(input.SkewStddev))) return false;

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
                if (this.TableSize != null) hashCode = hashCode * 59 + this.TableSize.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.TableOwner != null) hashCode = hashCode * 59 + this.TableOwner.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.IsPartType != null) hashCode = hashCode * 59 + this.IsPartType.GetHashCode();
                if (this.IsHashClusterKey != null) hashCode = hashCode * 59 + this.IsHashClusterKey.GetHashCode();
                if (this.Tuples != null) hashCode = hashCode * 59 + this.Tuples.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.AverageSize != null) hashCode = hashCode * 59 + this.AverageSize.GetHashCode();
                if (this.MaxRatio != null) hashCode = hashCode * 59 + this.MaxRatio.GetHashCode();
                if (this.MinRatio != null) hashCode = hashCode * 59 + this.MinRatio.GetHashCode();
                if (this.SkewSize != null) hashCode = hashCode * 59 + this.SkewSize.GetHashCode();
                if (this.SkewRatio != null) hashCode = hashCode * 59 + this.SkewRatio.GetHashCode();
                if (this.SkewStddev != null) hashCode = hashCode * 59 + this.SkewStddev.GetHashCode();
                return hashCode;
            }
        }
    }
}
