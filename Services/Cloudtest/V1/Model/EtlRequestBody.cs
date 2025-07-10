using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EtlRequestBody 
    {

        /// <summary>
        /// 分页偏移量
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 分页大小，最大值1000
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 需要同步的表名称
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// 是否是bak表数据
        /// </summary>
        [JsonProperty("is_bak", NullValueHandling = NullValueHandling.Ignore)]
        public string IsBak { get; set; }

        /// <summary>
        /// 查询时间段起始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 查询时间段截止时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 用于时间段过滤的字段
        /// </summary>
        [JsonProperty("filter_time_field", NullValueHandling = NullValueHandling.Ignore)]
        public string FilterTimeField { get; set; }

        /// <summary>
        /// 用于时间排序的字段，不传默认按照更新时间排序
        /// </summary>
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public string SortField { get; set; }

        /// <summary>
        /// 分库编号（数字类型）
        /// </summary>
        [JsonProperty("schema_no", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaNo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EtlRequestBody {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  isBak: ").Append(IsBak).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  filterTimeField: ").Append(FilterTimeField).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  schemaNo: ").Append(SchemaNo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EtlRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EtlRequestBody input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.IsBak != input.IsBak || (this.IsBak != null && !this.IsBak.Equals(input.IsBak))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.FilterTimeField != input.FilterTimeField || (this.FilterTimeField != null && !this.FilterTimeField.Equals(input.FilterTimeField))) return false;
            if (this.SortField != input.SortField || (this.SortField != null && !this.SortField.Equals(input.SortField))) return false;
            if (this.SchemaNo != input.SchemaNo || (this.SchemaNo != null && !this.SchemaNo.Equals(input.SchemaNo))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.IsBak != null) hashCode = hashCode * 59 + this.IsBak.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.FilterTimeField != null) hashCode = hashCode * 59 + this.FilterTimeField.GetHashCode();
                if (this.SortField != null) hashCode = hashCode * 59 + this.SortField.GetHashCode();
                if (this.SchemaNo != null) hashCode = hashCode * 59 + this.SchemaNo.GetHashCode();
                return hashCode;
            }
        }
    }
}
