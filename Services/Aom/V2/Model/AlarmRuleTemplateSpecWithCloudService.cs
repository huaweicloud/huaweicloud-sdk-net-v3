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
    public class AlarmRuleTemplateSpecWithCloudService 
    {

        /// <summary>
        /// 关联的云服务。
        /// </summary>
        [JsonProperty("related_cloud_service", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedCloudService { get; set; }

        /// <summary>
        /// 关联的CCE集群。
        /// </summary>
        [JsonProperty("related_cce_clusters", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RelatedCceClusters { get; set; }

        /// <summary>
        /// 关联的Prom实例。
        /// </summary>
        [JsonProperty("related_prometheus_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RelatedPrometheusInstances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alarm_notification", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmNotification AlarmNotification { get; set; }

        /// <summary>
        /// 告警模板列表。
        /// </summary>
        [JsonProperty("alarm_template_spec_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmTemplateSpecItem> AlarmTemplateSpecItems { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmRuleTemplateSpecWithCloudService {\n");
            sb.Append("  relatedCloudService: ").Append(RelatedCloudService).Append("\n");
            sb.Append("  relatedCceClusters: ").Append(RelatedCceClusters).Append("\n");
            sb.Append("  relatedPrometheusInstances: ").Append(RelatedPrometheusInstances).Append("\n");
            sb.Append("  alarmNotification: ").Append(AlarmNotification).Append("\n");
            sb.Append("  alarmTemplateSpecItems: ").Append(AlarmTemplateSpecItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmRuleTemplateSpecWithCloudService);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmRuleTemplateSpecWithCloudService input)
        {
            if (input == null) return false;
            if (this.RelatedCloudService != input.RelatedCloudService || (this.RelatedCloudService != null && !this.RelatedCloudService.Equals(input.RelatedCloudService))) return false;
            if (this.RelatedCceClusters != input.RelatedCceClusters || (this.RelatedCceClusters != null && input.RelatedCceClusters != null && !this.RelatedCceClusters.SequenceEqual(input.RelatedCceClusters))) return false;
            if (this.RelatedPrometheusInstances != input.RelatedPrometheusInstances || (this.RelatedPrometheusInstances != null && input.RelatedPrometheusInstances != null && !this.RelatedPrometheusInstances.SequenceEqual(input.RelatedPrometheusInstances))) return false;
            if (this.AlarmNotification != input.AlarmNotification || (this.AlarmNotification != null && !this.AlarmNotification.Equals(input.AlarmNotification))) return false;
            if (this.AlarmTemplateSpecItems != input.AlarmTemplateSpecItems || (this.AlarmTemplateSpecItems != null && input.AlarmTemplateSpecItems != null && !this.AlarmTemplateSpecItems.SequenceEqual(input.AlarmTemplateSpecItems))) return false;

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
                if (this.RelatedCloudService != null) hashCode = hashCode * 59 + this.RelatedCloudService.GetHashCode();
                if (this.RelatedCceClusters != null) hashCode = hashCode * 59 + this.RelatedCceClusters.GetHashCode();
                if (this.RelatedPrometheusInstances != null) hashCode = hashCode * 59 + this.RelatedPrometheusInstances.GetHashCode();
                if (this.AlarmNotification != null) hashCode = hashCode * 59 + this.AlarmNotification.GetHashCode();
                if (this.AlarmTemplateSpecItems != null) hashCode = hashCode * 59 + this.AlarmTemplateSpecItems.GetHashCode();
                return hashCode;
            }
        }
    }
}
