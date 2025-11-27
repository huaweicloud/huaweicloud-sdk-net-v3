using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PropagationSpec 
    {

        /// <summary>
        /// 资源选择器，用于选择要传播的资源
        /// </summary>
        [JsonProperty("resourceSelectors", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceSelector> ResourceSelectors { get; set; }

        /// <summary>
        /// 是否自动传播引用的资源
        /// </summary>
        [JsonProperty("propagateDeps", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PropagateDeps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("placement", NullValueHandling = NullValueHandling.Ignore)]
        public Placement Placement { get; set; }

        /// <summary>
        /// 策略的优先级，默认值为0
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 调度器名称，默认值为“default-scheduler”
        /// </summary>
        [JsonProperty("schedulerName", NullValueHandling = NullValueHandling.Ignore)]
        public string SchedulerName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropagationSpec {\n");
            sb.Append("  resourceSelectors: ").Append(ResourceSelectors).Append("\n");
            sb.Append("  propagateDeps: ").Append(PropagateDeps).Append("\n");
            sb.Append("  placement: ").Append(Placement).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  schedulerName: ").Append(SchedulerName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PropagationSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PropagationSpec input)
        {
            if (input == null) return false;
            if (this.ResourceSelectors != input.ResourceSelectors || (this.ResourceSelectors != null && input.ResourceSelectors != null && !this.ResourceSelectors.SequenceEqual(input.ResourceSelectors))) return false;
            if (this.PropagateDeps != input.PropagateDeps || (this.PropagateDeps != null && !this.PropagateDeps.Equals(input.PropagateDeps))) return false;
            if (this.Placement != input.Placement || (this.Placement != null && !this.Placement.Equals(input.Placement))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.SchedulerName != input.SchedulerName || (this.SchedulerName != null && !this.SchedulerName.Equals(input.SchedulerName))) return false;

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
                if (this.ResourceSelectors != null) hashCode = hashCode * 59 + this.ResourceSelectors.GetHashCode();
                if (this.PropagateDeps != null) hashCode = hashCode * 59 + this.PropagateDeps.GetHashCode();
                if (this.Placement != null) hashCode = hashCode * 59 + this.Placement.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.SchedulerName != null) hashCode = hashCode * 59 + this.SchedulerName.GetHashCode();
                return hashCode;
            }
        }
    }
}
