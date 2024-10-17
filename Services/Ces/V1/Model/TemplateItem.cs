using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// 创建自定义告警模板添加的告警规则。
    /// </summary>
    public class TemplateItem 
    {

        /// <summary>
        /// 告警模板添加的监控指标，如弹性云服务器可添加的监控指标为cpu_util等；各服务的指标名称可查看：“[服务指标名称](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)”。
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmTemplateCondition Condition { get; set; }

        /// <summary>
        /// 设置告警级别，值为1,2,3,4；1为紧急，2为重要，3为次要，4为提示。
        /// </summary>
        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlarmLevel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateItem {\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateItem input)
        {
            if (input == null) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.Condition != input.Condition || (this.Condition != null && !this.Condition.Equals(input.Condition))) return false;
            if (this.AlarmLevel != input.AlarmLevel || (this.AlarmLevel != null && !this.AlarmLevel.Equals(input.AlarmLevel))) return false;

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
                if (this.Condition != null) hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.AlarmLevel != null) hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
