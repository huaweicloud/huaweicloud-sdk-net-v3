using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateDashboardRequestBody 
    {

        /// <summary>
        /// 自定义监控看板名称
        /// </summary>
        [JsonProperty("dashboard_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardName { get; set; }

        /// <summary>
        /// 监控看板是否标记收藏, true: 收藏, false: 未收藏
        /// </summary>
        [JsonProperty("is_favorite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// 监控视图展示模式，0表示自定义坐标，1代表每行一个
        /// </summary>
        [JsonProperty("row_widget_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? RowWidgetNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extend_info", NullValueHandling = NullValueHandling.Ignore)]
        public ExtendInfo ExtendInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDashboardRequestBody {\n");
            sb.Append("  dashboardName: ").Append(DashboardName).Append("\n");
            sb.Append("  isFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  rowWidgetNum: ").Append(RowWidgetNum).Append("\n");
            sb.Append("  extendInfo: ").Append(ExtendInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDashboardRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDashboardRequestBody input)
        {
            if (input == null) return false;
            if (this.DashboardName != input.DashboardName || (this.DashboardName != null && !this.DashboardName.Equals(input.DashboardName))) return false;
            if (this.IsFavorite != input.IsFavorite || (this.IsFavorite != null && !this.IsFavorite.Equals(input.IsFavorite))) return false;
            if (this.RowWidgetNum != input.RowWidgetNum || (this.RowWidgetNum != null && !this.RowWidgetNum.Equals(input.RowWidgetNum))) return false;
            if (this.ExtendInfo != input.ExtendInfo || (this.ExtendInfo != null && !this.ExtendInfo.Equals(input.ExtendInfo))) return false;

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
                if (this.DashboardName != null) hashCode = hashCode * 59 + this.DashboardName.GetHashCode();
                if (this.IsFavorite != null) hashCode = hashCode * 59 + this.IsFavorite.GetHashCode();
                if (this.RowWidgetNum != null) hashCode = hashCode * 59 + this.RowWidgetNum.GetHashCode();
                if (this.ExtendInfo != null) hashCode = hashCode * 59 + this.ExtendInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
