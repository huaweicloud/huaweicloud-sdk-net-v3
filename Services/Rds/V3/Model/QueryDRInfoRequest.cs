using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryDRInfoRequest 
    {

        /// <summary>
        /// 容灾关系id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 容灾搭建状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 灾备实例id
        /// </summary>
        [JsonProperty("master_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterInstanceId { get; set; }

        /// <summary>
        /// 主实例region
        /// </summary>
        [JsonProperty("master_region", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterRegion { get; set; }

        /// <summary>
        /// 灾备实例id
        /// </summary>
        [JsonProperty("slave_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveInstanceId { get; set; }

        /// <summary>
        /// 灾备实例region
        /// </summary>
        [JsonProperty("slave_region", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveRegion { get; set; }

        /// <summary>
        /// 创建起始时间
        /// </summary>
        [JsonProperty("create_at_start", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAtStart { get; set; }

        /// <summary>
        /// 创建结束时间
        /// </summary>
        [JsonProperty("create_at_end", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAtEnd { get; set; }

        /// <summary>
        /// 排序方式。 DESC，降序。 ASC，升序。 默认降序。
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public string Order { get; set; }

        /// <summary>
        /// 排序字段。 status 容灾搭建状态。 time 容灾搭建时间。 master_region 主实例region。 slave_region 灾备实例region 默认容灾搭建时间。
        /// </summary>
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public string SortField { get; set; }

        /// <summary>
        /// 索引位置，偏移量。从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询），必须为数字，不能为负数。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询记录数。默认为10，不能为负数，最小值为1，最大值为100。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryDRInfoRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  masterInstanceId: ").Append(MasterInstanceId).Append("\n");
            sb.Append("  masterRegion: ").Append(MasterRegion).Append("\n");
            sb.Append("  slaveInstanceId: ").Append(SlaveInstanceId).Append("\n");
            sb.Append("  slaveRegion: ").Append(SlaveRegion).Append("\n");
            sb.Append("  createAtStart: ").Append(CreateAtStart).Append("\n");
            sb.Append("  createAtEnd: ").Append(CreateAtEnd).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryDRInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryDRInfoRequest input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.MasterInstanceId != input.MasterInstanceId || (this.MasterInstanceId != null && !this.MasterInstanceId.Equals(input.MasterInstanceId))) return false;
            if (this.MasterRegion != input.MasterRegion || (this.MasterRegion != null && !this.MasterRegion.Equals(input.MasterRegion))) return false;
            if (this.SlaveInstanceId != input.SlaveInstanceId || (this.SlaveInstanceId != null && !this.SlaveInstanceId.Equals(input.SlaveInstanceId))) return false;
            if (this.SlaveRegion != input.SlaveRegion || (this.SlaveRegion != null && !this.SlaveRegion.Equals(input.SlaveRegion))) return false;
            if (this.CreateAtStart != input.CreateAtStart || (this.CreateAtStart != null && !this.CreateAtStart.Equals(input.CreateAtStart))) return false;
            if (this.CreateAtEnd != input.CreateAtEnd || (this.CreateAtEnd != null && !this.CreateAtEnd.Equals(input.CreateAtEnd))) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;
            if (this.SortField != input.SortField || (this.SortField != null && !this.SortField.Equals(input.SortField))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.MasterInstanceId != null) hashCode = hashCode * 59 + this.MasterInstanceId.GetHashCode();
                if (this.MasterRegion != null) hashCode = hashCode * 59 + this.MasterRegion.GetHashCode();
                if (this.SlaveInstanceId != null) hashCode = hashCode * 59 + this.SlaveInstanceId.GetHashCode();
                if (this.SlaveRegion != null) hashCode = hashCode * 59 + this.SlaveRegion.GetHashCode();
                if (this.CreateAtStart != null) hashCode = hashCode * 59 + this.CreateAtStart.GetHashCode();
                if (this.CreateAtEnd != null) hashCode = hashCode * 59 + this.CreateAtEnd.GetHashCode();
                if (this.Order != null) hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.SortField != null) hashCode = hashCode * 59 + this.SortField.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
