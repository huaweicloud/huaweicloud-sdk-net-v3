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
    /// 导出流量回放任务SQL文件请求体
    /// </summary>
    public class ExportSqlDataReq 
    {

        /// <summary>
        /// 导出的sql文件类型。取值范围： - abnormal_sql ：异常sql列表 - abnormal_sql_detail ：异常sql详情 - slow_sql ：慢sql列表 - slow_sql_detail ： 慢sql详情
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 导出的字段名。file_type为时为error_sql_detail、slow_sql_detail必填。取值范围： -id ：自增ID -gmtCreate ：创建时间 -gmtModified ：修改时间 -shardId ：分片ID -startTimestamp ：源库SQL开始执行时间戳 -executeTimePartition ：回放时间分区 -schemaName ：库名 -queryType ：SQL类型 -sqlStatement ：SQL内容 -sqlTemplate ：SQL模板 -errorInfo ：异常信息 -targetType ：目标库类型
        /// </summary>
        [JsonProperty("field_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FieldNames { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportSqlDataReq {\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  fieldNames: ").Append(FieldNames).Append("\n");
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
            return this.Equals(input as ExportSqlDataReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportSqlDataReq input)
        {
            if (input == null) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.FieldNames != input.FieldNames || (this.FieldNames != null && input.FieldNames != null && !this.FieldNames.SequenceEqual(input.FieldNames))) return false;
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
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.FieldNames != null) hashCode = hashCode * 59 + this.FieldNames.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
