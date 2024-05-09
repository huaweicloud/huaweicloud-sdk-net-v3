using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 对比结果信息体。
    /// </summary>
    public class ObjectsHealthCompareOverviewInfo 
    {

        /// <summary>
        /// 对象类型。取值： - DB：数据库。 - TABLE：表。 - VIEW：视图。 - EVENT：事件。 - ROUTINE：存储过程和函数。 - INDEX：索引。 - TRIGGER：触发器。 - SYNONYM：同义词。 - FUNCTION：函数。 - PROCEDURE：存储过程。 - TYPE：自定义类型。 - RULE：规则。 - DEFAULT_TYPE：缺省值。 - PLAN_GUIDE：执行计划。 - CONSTRAINT：约束。 - FILE_GROUP：文件组。 - PARTITION_FUNCTION：分区函数。 - PARTITION_SCHEME：分区方案。 - TABLE_COLLATION：表的排序规则。 - EXTENSIONS：插件。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 源数量。
        /// </summary>
        [JsonProperty("source_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? SourceCount { get; set; }

        /// <summary>
        /// 目标数量。
        /// </summary>
        [JsonProperty("target_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TargetCount { get; set; }

        /// <summary>
        /// 对比结果： - 0：不一致。 - 2：一致。 - 3：未完成。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectsHealthCompareOverviewInfo {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  sourceCount: ").Append(SourceCount).Append("\n");
            sb.Append("  targetCount: ").Append(TargetCount).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectsHealthCompareOverviewInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectsHealthCompareOverviewInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SourceCount == input.SourceCount ||
                    (this.SourceCount != null &&
                    this.SourceCount.Equals(input.SourceCount))
                ) && 
                (
                    this.TargetCount == input.TargetCount ||
                    (this.TargetCount != null &&
                    this.TargetCount.Equals(input.TargetCount))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SourceCount != null)
                    hashCode = hashCode * 59 + this.SourceCount.GetHashCode();
                if (this.TargetCount != null)
                    hashCode = hashCode * 59 + this.TargetCount.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
