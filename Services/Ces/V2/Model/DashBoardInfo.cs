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
    public class DashBoardInfo 
    {

        /// <summary>
        /// 监控看板id
        /// </summary>
        [JsonProperty("dashboard_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardId { get; set; }

        /// <summary>
        /// 自定义监控看板名称
        /// </summary>
        [JsonProperty("dashboard_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardName { get; set; }

        /// <summary>
        /// 企业项目Id
        /// </summary>
        [JsonProperty("enterprise_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 监控视图展示模式，0表示自定义坐标，1代表每行一个
        /// </summary>
        [JsonProperty("row_widget_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? RowWidgetNum { get; set; }

        /// <summary>
        /// 监控看板是否标记收藏, true: 收藏, false: 未收藏
        /// </summary>
        [JsonProperty("is_favorite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// 监控看板的创建用户名
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 监控看板创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 看板下的视图总数
        /// </summary>
        [JsonProperty("widgets_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? WidgetsNum { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 子产品标识
        /// </summary>
        [JsonProperty("sub_product", NullValueHandling = NullValueHandling.Ignore)]
        public string SubProduct { get; set; }

        /// <summary>
        /// 监控大盘模板id
        /// </summary>
        [JsonProperty("dashboard_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardTemplateId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashBoardInfo {\n");
            sb.Append("  dashboardId: ").Append(DashboardId).Append("\n");
            sb.Append("  dashboardName: ").Append(DashboardName).Append("\n");
            sb.Append("  enterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  rowWidgetNum: ").Append(RowWidgetNum).Append("\n");
            sb.Append("  isFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  widgetsNum: ").Append(WidgetsNum).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  subProduct: ").Append(SubProduct).Append("\n");
            sb.Append("  dashboardTemplateId: ").Append(DashboardTemplateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DashBoardInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DashBoardInfo input)
        {
            if (input == null) return false;
            if (this.DashboardId != input.DashboardId || (this.DashboardId != null && !this.DashboardId.Equals(input.DashboardId))) return false;
            if (this.DashboardName != input.DashboardName || (this.DashboardName != null && !this.DashboardName.Equals(input.DashboardName))) return false;
            if (this.EnterpriseId != input.EnterpriseId || (this.EnterpriseId != null && !this.EnterpriseId.Equals(input.EnterpriseId))) return false;
            if (this.RowWidgetNum != input.RowWidgetNum || (this.RowWidgetNum != null && !this.RowWidgetNum.Equals(input.RowWidgetNum))) return false;
            if (this.IsFavorite != input.IsFavorite || (this.IsFavorite != null && !this.IsFavorite.Equals(input.IsFavorite))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.WidgetsNum != input.WidgetsNum || (this.WidgetsNum != null && !this.WidgetsNum.Equals(input.WidgetsNum))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.SubProduct != input.SubProduct || (this.SubProduct != null && !this.SubProduct.Equals(input.SubProduct))) return false;
            if (this.DashboardTemplateId != input.DashboardTemplateId || (this.DashboardTemplateId != null && !this.DashboardTemplateId.Equals(input.DashboardTemplateId))) return false;

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
                if (this.DashboardId != null) hashCode = hashCode * 59 + this.DashboardId.GetHashCode();
                if (this.DashboardName != null) hashCode = hashCode * 59 + this.DashboardName.GetHashCode();
                if (this.EnterpriseId != null) hashCode = hashCode * 59 + this.EnterpriseId.GetHashCode();
                if (this.RowWidgetNum != null) hashCode = hashCode * 59 + this.RowWidgetNum.GetHashCode();
                if (this.IsFavorite != null) hashCode = hashCode * 59 + this.IsFavorite.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.WidgetsNum != null) hashCode = hashCode * 59 + this.WidgetsNum.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.SubProduct != null) hashCode = hashCode * 59 + this.SubProduct.GetHashCode();
                if (this.DashboardTemplateId != null) hashCode = hashCode * 59 + this.DashboardTemplateId.GetHashCode();
                return hashCode;
            }
        }
    }
}
