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
    public class ResourceBindingStatus 
    {

        /// <summary>
        /// 记录调度器当前观察到的资源生成版本代数
        /// </summary>
        [JsonProperty("schedulerObservedGeneration", NullValueHandling = NullValueHandling.Ignore)]
        public int? SchedulerObservedGeneration { get; set; }

        /// <summary>
        /// 资源的各种状态条件
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConditionStatus> Conditions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceBindingStatus {\n");
            sb.Append("  schedulerObservedGeneration: ").Append(SchedulerObservedGeneration).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceBindingStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceBindingStatus input)
        {
            if (input == null) return false;
            if (this.SchedulerObservedGeneration != input.SchedulerObservedGeneration || (this.SchedulerObservedGeneration != null && !this.SchedulerObservedGeneration.Equals(input.SchedulerObservedGeneration))) return false;
            if (this.Conditions != input.Conditions || (this.Conditions != null && input.Conditions != null && !this.Conditions.SequenceEqual(input.Conditions))) return false;

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
                if (this.SchedulerObservedGeneration != null) hashCode = hashCode * 59 + this.SchedulerObservedGeneration.GetHashCode();
                if (this.Conditions != null) hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                return hashCode;
            }
        }
    }
}
