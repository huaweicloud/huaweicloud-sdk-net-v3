using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSpecialUserResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 租户是否可以查询总请求时长 **约束限制：** 不涉及 **取值范围：** - 1：表示租户可以查询总请求时长 - 0：表示租户不可以查询总请求时长 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public long? Status { get; set; }

        /// <summary>
        /// **参数解释：** 进制 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public long? Metric { get; set; }

        /// <summary>
        /// **参数解释：** 流量进制 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("flux_metric", NullValueHandling = NullValueHandling.Ignore)]
        public long? FluxMetric { get; set; }

        /// <summary>
        /// **参数解释：** 租户是否是开放国家及地区界面 **约束限制：** 不涉及 **取值范围：** - 1：表示租户开放国家及地区界面 - 0：表示租户不用开放国家及地区界面 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("cy", NullValueHandling = NullValueHandling.Ignore)]
        public long? Cy { get; set; }

        /// <summary>
        /// **参数解释：** 租户是否可以查询ipv6流量、https流量 **约束限制：** 不涉及 **取值范围：** - 1：表示租户可以查询ipv6流量、https流量 - 0：表示租户不可以查询ipv6流量、https流量 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("h6", NullValueHandling = NullValueHandling.Ignore)]
        public long? H6 { get; set; }

        /// <summary>
        /// **参数解释：** 租户是否可以查询具体的状态码详情 **约束限制：** 不涉及 **取值范围：** - 1：表示租户可以查询具体的状态码详情 - 0：表示租户不可以查询具体的状态码详情 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("c", NullValueHandling = NullValueHandling.Ignore)]
        public long? C { get; set; }

        /// <summary>
        /// **参数解释：** 查询查询top url时是否返回http状态码 **约束限制：** 不涉及 **取值范围：** - 1：表示租户查询top url时返回http状态码 - 0：表示租户查询top url时不返回http状态码 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("sc", NullValueHandling = NullValueHandling.Ignore)]
        public long? Sc { get; set; }

        /// <summary>
        /// **参数解释：** 租户是否可以查询回源状态码 **约束限制：** 不涉及 **取值范围：** - 1：表示租户可以查询回源状态码 - 0：表示租户不可以查询回源状态码 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("bhc", NullValueHandling = NullValueHandling.Ignore)]
        public long? Bhc { get; set; }

        /// <summary>
        /// **参数解释：** 租户是否可以查询protocol和IPVersion **约束限制：** 不涉及 **取值范围：** - 1：表示租户可以查询protocol和IPVersion - 0：表示租户不可以查询protocol和IPVersion **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("pi", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pi { get; set; }

        /// <summary>
        /// **参数解释：** 租户是否可以导出5分钟粒度数据 **约束限制：** 不涉及 **取值范围：** - 1：表示租户可以导出5分钟粒度数据 - 0：表示租户不可以导出5分钟粒度数据 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("exp5", NullValueHandling = NullValueHandling.Ignore)]
        public long? Exp5 { get; set; }

        /// <summary>
        /// **参数解释：** 租户是否可以查询1分钟粒度数据 **约束限制：** 不涉及 **取值范围：** - 1：表示租户可以查询1分钟粒度数据 - 0：表示租户不可以查询1分钟粒度数据 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("m1", NullValueHandling = NullValueHandling.Ignore)]
        public long? M1 { get; set; }

        /// <summary>
        /// **参数解释：** 租户是否可以查询1个月5分钟粒度统计数据 **约束限制：** 不涉及 **取值范围：** - 1：表示租户可以查询1个月5分钟粒度统计数据 - 0：表示租户不可以查询1个月5分钟粒度统计数据 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("is_month_m5", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsMonthM5 { get; set; }

        /// <summary>
        /// **参数解释：** 租户是否可以在租户界面指定下载链接可用范围 **约束限制：** 不涉及 **取值范围：** - 1：表示租户可以在租户界面指定下载链接可用范围 - 0：表示租户不可以在租户界面指定下载链接可用范围 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("exp_agy", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpAgy { get; set; }

        /// <summary>
        /// **参数解释：** 租户是否可以上报到国际站CES **约束限制：** 不涉及 **取值范围：** - 1：表示租户可以上报到国际站CES - 0：表示租户不可以上报到国际站CES **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("ces_report_site", NullValueHandling = NullValueHandling.Ignore)]
        public long? CesReportSite { get; set; }

        /// <summary>
        /// **参数解释：** 租户是否按上浮系数展示数据 **约束限制：** 不涉及 **取值范围：** - 1：表示租户按上浮系数展示数据 - 0：表示租户不按上浮系数展示数据 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("float", NullValueHandling = NullValueHandling.Ignore)]
        public long? Float { get; set; }

        /// <summary>
        /// **参数解释：** 租户是否允许查询入网带宽 **约束限制：** 不涉及 **取值范围：** - 1：表示租户允许查询入网带宽 - 0：表示租户不可以查询入网带宽 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("is_show_up_bw", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsShowUpBw { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSpecialUserResponse {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  fluxMetric: ").Append(FluxMetric).Append("\n");
            sb.Append("  cy: ").Append(Cy).Append("\n");
            sb.Append("  h6: ").Append(H6).Append("\n");
            sb.Append("  c: ").Append(C).Append("\n");
            sb.Append("  sc: ").Append(Sc).Append("\n");
            sb.Append("  bhc: ").Append(Bhc).Append("\n");
            sb.Append("  pi: ").Append(Pi).Append("\n");
            sb.Append("  exp5: ").Append(Exp5).Append("\n");
            sb.Append("  m1: ").Append(M1).Append("\n");
            sb.Append("  isMonthM5: ").Append(IsMonthM5).Append("\n");
            sb.Append("  expAgy: ").Append(ExpAgy).Append("\n");
            sb.Append("  cesReportSite: ").Append(CesReportSite).Append("\n");
            sb.Append("  Float: ").Append(Float).Append("\n");
            sb.Append("  isShowUpBw: ").Append(IsShowUpBw).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSpecialUserResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSpecialUserResponse input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Metric != input.Metric || (this.Metric != null && !this.Metric.Equals(input.Metric))) return false;
            if (this.FluxMetric != input.FluxMetric || (this.FluxMetric != null && !this.FluxMetric.Equals(input.FluxMetric))) return false;
            if (this.Cy != input.Cy || (this.Cy != null && !this.Cy.Equals(input.Cy))) return false;
            if (this.H6 != input.H6 || (this.H6 != null && !this.H6.Equals(input.H6))) return false;
            if (this.C != input.C || (this.C != null && !this.C.Equals(input.C))) return false;
            if (this.Sc != input.Sc || (this.Sc != null && !this.Sc.Equals(input.Sc))) return false;
            if (this.Bhc != input.Bhc || (this.Bhc != null && !this.Bhc.Equals(input.Bhc))) return false;
            if (this.Pi != input.Pi || (this.Pi != null && !this.Pi.Equals(input.Pi))) return false;
            if (this.Exp5 != input.Exp5 || (this.Exp5 != null && !this.Exp5.Equals(input.Exp5))) return false;
            if (this.M1 != input.M1 || (this.M1 != null && !this.M1.Equals(input.M1))) return false;
            if (this.IsMonthM5 != input.IsMonthM5 || (this.IsMonthM5 != null && !this.IsMonthM5.Equals(input.IsMonthM5))) return false;
            if (this.ExpAgy != input.ExpAgy || (this.ExpAgy != null && !this.ExpAgy.Equals(input.ExpAgy))) return false;
            if (this.CesReportSite != input.CesReportSite || (this.CesReportSite != null && !this.CesReportSite.Equals(input.CesReportSite))) return false;
            if (this.Float != input.Float || (this.Float != null && !this.Float.Equals(input.Float))) return false;
            if (this.IsShowUpBw != input.IsShowUpBw || (this.IsShowUpBw != null && !this.IsShowUpBw.Equals(input.IsShowUpBw))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Metric != null) hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.FluxMetric != null) hashCode = hashCode * 59 + this.FluxMetric.GetHashCode();
                if (this.Cy != null) hashCode = hashCode * 59 + this.Cy.GetHashCode();
                if (this.H6 != null) hashCode = hashCode * 59 + this.H6.GetHashCode();
                if (this.C != null) hashCode = hashCode * 59 + this.C.GetHashCode();
                if (this.Sc != null) hashCode = hashCode * 59 + this.Sc.GetHashCode();
                if (this.Bhc != null) hashCode = hashCode * 59 + this.Bhc.GetHashCode();
                if (this.Pi != null) hashCode = hashCode * 59 + this.Pi.GetHashCode();
                if (this.Exp5 != null) hashCode = hashCode * 59 + this.Exp5.GetHashCode();
                if (this.M1 != null) hashCode = hashCode * 59 + this.M1.GetHashCode();
                if (this.IsMonthM5 != null) hashCode = hashCode * 59 + this.IsMonthM5.GetHashCode();
                if (this.ExpAgy != null) hashCode = hashCode * 59 + this.ExpAgy.GetHashCode();
                if (this.CesReportSite != null) hashCode = hashCode * 59 + this.CesReportSite.GetHashCode();
                if (this.Float != null) hashCode = hashCode * 59 + this.Float.GetHashCode();
                if (this.IsShowUpBw != null) hashCode = hashCode * 59 + this.IsShowUpBw.GetHashCode();
                return hashCode;
            }
        }
    }
}
