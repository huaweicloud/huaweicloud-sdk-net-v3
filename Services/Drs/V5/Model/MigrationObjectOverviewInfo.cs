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
    /// 迁移详情概览。
    /// </summary>
    public class MigrationObjectOverviewInfo 
    {

        /// <summary>
        /// 类型。 DATABASE：数据库 SCHEMA：SCHEMA PACKAGE：package TABLE：数据表 COLUMN：列 VIEW：视图 FUNCTION：函数 PROCEDURE：存储过程 ROUTINE：routine TRIGGER：触发器 INDEX：索引 TABLE_INDEX：普通索引，根据表汇聚 TABLE_RENAME_OR_COPY：表重命名或复制 TABLE_STRUCTURE：表结构 EVENT：事件 SYNONYM：同义词,sqlserver特有 TYPE：自定义类型,sqlserver特有 RULE：规则,sqlserver特有 DEFAULT：缺省值,sqlserver特有 PLAN_GUIDE：执行计划,sqlserver特有 FILE_GROUP：文件组,sqlserver特有 PARTITION_FUNCTION：分区函数,sqlserver特有 SHARD_KEY：mongo特有 VALIDATOR：mongo特有 SEQUENCE：序列 MATVIEW：物化视图 PARTITION_SCHEME：分区方案,sqlserver特有 ACCOUNT：账户 EXTENSION：PG 特有的一些对象:插件 AGGREGATE：PG 特有的一些对象:聚合函数 MATERIALIZED_VIEW：PG 特有的一些对象:物化视图 TEXT_SEARCH_DICTIONARY：PG 特有的一些对象:文本搜索字典 CONVERSION：PG 特有的一些对象:类型转换 DATA_TYPE：PG 特有的一些对象:数据类型 TEXT_SEARCH_CONFIGURATION：PG 特有的一些对象:文本搜索配置 STATISTICS_EXTENSION：PG 特有的一些对象:插件统计 MEMBERSHIP：PG 特有的一些对象:用户成员关系 EVENT_TRIGGER：PG 特有的一些对象:事件触发器 COLLATION：PG 特有的一些对象:排序规则 TEXT_SEARCH_PARSER：PG 特有的一些对象:文本搜索解析器 PRIVILEGES：PG 特有的一些对象:权限 FOREIGN_KEY：PG 特有的一些对象:外键 ROLE：权限
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 待迁移数量。
        /// </summary>
        [JsonProperty("src_count", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcCount { get; set; }

        /// <summary>
        /// 已迁移数量。
        /// </summary>
        [JsonProperty("dst_count", NullValueHandling = NullValueHandling.Ignore)]
        public string DstCount { get; set; }

        /// <summary>
        /// 状态. NOT_START：未启动，TRANSFERING：迁移中，COMPLETED：已完成，FAILED：失败，TRANSFER_WHEN_END：结束后迁移
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationObjectOverviewInfo {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  srcCount: ").Append(SrcCount).Append("\n");
            sb.Append("  dstCount: ").Append(DstCount).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrationObjectOverviewInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrationObjectOverviewInfo input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.SrcCount != input.SrcCount || (this.SrcCount != null && !this.SrcCount.Equals(input.SrcCount))) return false;
            if (this.DstCount != input.DstCount || (this.DstCount != null && !this.DstCount.Equals(input.DstCount))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SrcCount != null) hashCode = hashCode * 59 + this.SrcCount.GetHashCode();
                if (this.DstCount != null) hashCode = hashCode * 59 + this.DstCount.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
