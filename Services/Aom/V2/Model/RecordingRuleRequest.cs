using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RecordingRuleRequest 
    {

        /// <summary>
        /// 预聚合规则。 待创建的预聚合规则详细信息。支持如下子参数： - groups：规则组。一份RecordingRule.yaml可以配置多组规则组。 - name：规则组名称。规则组名称必须唯一。 - interval：规则组的执行周期。默认60s。（可选） - rules：规则。一个规则组可以包含多条规则。 - record：规则的名称。聚合规则的名称必须符合  [Prometheus指标名称规范](https://prometheus.io/docs/concepts/data_model/#metric-names-and-labels)。  - expr：计算表达式。Prometheus监控将通过该表达式计算得出预聚合指标。计算表达式必须符合[PromQL](https://prometheus.io/docs/prometheus/latest/querying/basics/)。 - labels：指标的标签。标签必须符合[Prometheus指标标签规范](https://prometheus.io/docs/concepts/data_model/#metric-names-and-labels)。（可选）
        /// </summary>
        [JsonProperty("recording_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordingRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingRuleRequest {\n");
            sb.Append("  recordingRule: ").Append(RecordingRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordingRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordingRuleRequest input)
        {
            if (input == null) return false;
            if (this.RecordingRule != input.RecordingRule || (this.RecordingRule != null && !this.RecordingRule.Equals(input.RecordingRule))) return false;

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
                if (this.RecordingRule != null) hashCode = hashCode * 59 + this.RecordingRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
