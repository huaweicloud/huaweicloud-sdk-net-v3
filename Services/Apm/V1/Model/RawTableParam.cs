using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 获取原始数据表格入参。
    /// </summary>
    public class RawTableParam 
    {

        /// <summary>
        /// 上一次扫描的数据ID。
        /// </summary>
        [JsonProperty("last_row_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LastRowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("view_config", NullValueHandling = NullValueHandling.Ignore)]
        public RawTableView ViewConfig { get; set; }

        /// <summary>
        /// 当前页码。
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 每页数据总数。
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 排序。
        /// </summary>
        [JsonProperty("order_by", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderBy { get; set; }

        /// <summary>
        /// 搜索关键字。
        /// </summary>
        [JsonProperty("search_word", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchWord { get; set; }

        /// <summary>
        /// 实例id。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// 监控项id。
        /// </summary>
        [JsonProperty("monitor_item_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MonitorItemId { get; set; }

        /// <summary>
        /// 环境id。
        /// </summary>
        [JsonProperty("env_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnvId { get; set; }

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
            sb.Append("class RawTableParam {\n");
            sb.Append("  lastRowId: ").Append(LastRowId).Append("\n");
            sb.Append("  viewConfig: ").Append(ViewConfig).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  orderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  searchWord: ").Append(SearchWord).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  monitorItemId: ").Append(MonitorItemId).Append("\n");
            sb.Append("  envId: ").Append(EnvId).Append("\n");
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
            return this.Equals(input as RawTableParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RawTableParam input)
        {
            if (input == null) return false;
            if (this.LastRowId != input.LastRowId || (this.LastRowId != null && !this.LastRowId.Equals(input.LastRowId))) return false;
            if (this.ViewConfig != input.ViewConfig || (this.ViewConfig != null && !this.ViewConfig.Equals(input.ViewConfig))) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.OrderBy != input.OrderBy || (this.OrderBy != null && !this.OrderBy.Equals(input.OrderBy))) return false;
            if (this.SearchWord != input.SearchWord || (this.SearchWord != null && !this.SearchWord.Equals(input.SearchWord))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.MonitorItemId != input.MonitorItemId || (this.MonitorItemId != null && !this.MonitorItemId.Equals(input.MonitorItemId))) return false;
            if (this.EnvId != input.EnvId || (this.EnvId != null && !this.EnvId.Equals(input.EnvId))) return false;
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
                if (this.LastRowId != null) hashCode = hashCode * 59 + this.LastRowId.GetHashCode();
                if (this.ViewConfig != null) hashCode = hashCode * 59 + this.ViewConfig.GetHashCode();
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.OrderBy != null) hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.SearchWord != null) hashCode = hashCode * 59 + this.SearchWord.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.MonitorItemId != null) hashCode = hashCode * 59 + this.MonitorItemId.GetHashCode();
                if (this.EnvId != null) hashCode = hashCode * 59 + this.EnvId.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
