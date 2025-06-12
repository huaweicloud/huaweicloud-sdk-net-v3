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
    public class UpdatePolicy 
    {

        /// <summary>
        /// 资源的监控指标名称，必须以字母开头，只能包含0-9/a-z/A-Z/_，字符长度最短为1，最大为64；如：弹性云服务器中的监控指标cpu_util，表示弹性服务器的CPU使用率；文档数据库中的指标mongo001_command_ps，表示command执行频率；各服务的指标名称可查看：“[服务指标名称](ces_03_0059.xml)”。
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_info", NullValueHandling = NullValueHandling.Ignore)]
        public ExtraInfo ExtraInfo { get; set; }

        /// <summary>
        /// 指标周期，单位是秒； 0是默认值，例如事件类告警该字段就用0即可； 1代表指标的原始周期，比如RDS监控指标原始周期是60s，表示该RDS指标按60s周期为一个数据点参与告警计算；如想了解各个云服务的指标原始周期可以参考“[支持服务列表](ces_03_0059.xml)”，300代表指标按5分钟聚合周期为一个数据点参与告警计算。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        /// <summary>
        /// 聚合方式, 支持的值为(average|min|max|sum)
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        /// <summary>
        /// 阈值符号, 支持的值为(&gt;|&lt;|&gt;&#x3D;|&lt;&#x3D;|&#x3D;|!&#x3D;|cycle_decrease|cycle_increase|cycle_wave);cycle_decrease为环比下降,cycle_increase为环比上升,cycle_wave为环比波动； 指标告警可以使用的阈值符号有&gt;、&gt;&#x3D;、&lt;、&lt;&#x3D;、&#x3D;、!&#x3D;、cycle_decrease、cycle_increase、cycle_wave； 事件告警可以使用的阈值符号为&gt;、&gt;&#x3D;、&lt;、&lt;&#x3D;、&#x3D;、!&#x3D;； 
        /// </summary>
        [JsonProperty("comparison_operator", NullValueHandling = NullValueHandling.Ignore)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// 告警阈值。单一阈值时value和alarm_level配对使用，当hierarchical_value和value同时使用时以hierarchical_value为准。取值范围[0, Number.MAX_VALUE]，Number.MAX_VALUE值为1.7976931348623157e+108。具体阈值取值请参见附录中各服务监控指标中取值范围，如支持监控的服务列表中ECS的CPU使用率cpu_util取值范围可配置80。 [具体阈值取值请参见附录中各服务监控指标中取值范围，如[支持监控的服务列表](ces_03_0059.xml)中ECS的CPU使用率cpu_util取值范围可配置80。](tag: dt,g42,dt_test,hk_g42,hk_sbc,hws,hws_hk,ocb,sbc,tm) 
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hierarchical_value", NullValueHandling = NullValueHandling.Ignore)]
        public HierarchicalValue HierarchicalValue { get; set; }

        /// <summary>
        /// 数据的单位。
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 告警策略类型，默认为空
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 告警连续触发次数，事件告警时参数值为1~180（包括1和180）；指标告警和站点告警时，次数采用枚举值，枚举值分别为：1、2、3、4、5、10、15、30、60、90、120、180
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 告警抑制时间，单位为秒，对应页面上创建告警规则时告警策略最后一个字段，该字段主要为解决告警频繁的问题，0代表不抑制，满足条件即告警；300代表满足告警触发条件后每5分钟告警一次；
        /// </summary>
        [JsonProperty("suppress_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuppressDuration { get; set; }

        /// <summary>
        /// 告警级别, 1为紧急，2为重要，3为次要，4为提示。默认值为2。
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// 服务的命名空间，查询各服务命名空间请参考“[服务命名空间](ces_03_0059.xml)”
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 指标维度名称。各服务资源的指标维度名称可查看：“[指标维度名称](ces_03_0059.xml)”。 约束与限制：    资源层级为子维度的告警规则，修改告警策略时，指标维度名必须与告警规则监控资源的维度保持一致。    资源层级为云产品的告警规则，修改告警策略时，指标维度名中首层维度必须与告警规则监控资源的维度保持一致。 举例：    ECS服务的资源层级为子维度、维度为云服务器的告警规则，需要设置维度名为：instance_id；    ECS服务的资源层级为云产品的告警规则时，维度名可以为：instance_id,disk
        /// </summary>
        [JsonProperty("dimension_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DimensionName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePolicy {\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  extraInfo: ").Append(ExtraInfo).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  comparisonOperator: ").Append(ComparisonOperator).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  hierarchicalValue: ").Append(HierarchicalValue).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  suppressDuration: ").Append(SuppressDuration).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  dimensionName: ").Append(DimensionName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePolicy input)
        {
            if (input == null) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.ExtraInfo != input.ExtraInfo || (this.ExtraInfo != null && !this.ExtraInfo.Equals(input.ExtraInfo))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;
            if (this.ComparisonOperator != input.ComparisonOperator || (this.ComparisonOperator != null && !this.ComparisonOperator.Equals(input.ComparisonOperator))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.HierarchicalValue != input.HierarchicalValue || (this.HierarchicalValue != null && !this.HierarchicalValue.Equals(input.HierarchicalValue))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.SuppressDuration != input.SuppressDuration || (this.SuppressDuration != null && !this.SuppressDuration.Equals(input.SuppressDuration))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.DimensionName != input.DimensionName || (this.DimensionName != null && !this.DimensionName.Equals(input.DimensionName))) return false;

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
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.ExtraInfo != null) hashCode = hashCode * 59 + this.ExtraInfo.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.ComparisonOperator != null) hashCode = hashCode * 59 + this.ComparisonOperator.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.HierarchicalValue != null) hashCode = hashCode * 59 + this.HierarchicalValue.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.SuppressDuration != null) hashCode = hashCode * 59 + this.SuppressDuration.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.DimensionName != null) hashCode = hashCode * 59 + this.DimensionName.GetHashCode();
                return hashCode;
            }
        }
    }
}
