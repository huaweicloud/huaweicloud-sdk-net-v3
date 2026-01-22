using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ScheduleVO 
    {

        /// <summary>
        /// **参数解释**： 时间表ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("schedule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// **参数解释**： 时间表名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 时间表描述 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 引用次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("ref_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RefCount { get; set; }

        /// <summary>
        /// **参数解释**： 周期计划 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("periodic", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScheduleVOPeriodic> Periodic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("absolute", NullValueHandling = NullValueHandling.Ignore)]
        public ScheduleVOAbsolute Absolute { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleVO {\n");
            sb.Append("  scheduleId: ").Append(ScheduleId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  refCount: ").Append(RefCount).Append("\n");
            sb.Append("  periodic: ").Append(Periodic).Append("\n");
            sb.Append("  absolute: ").Append(Absolute).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduleVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScheduleVO input)
        {
            if (input == null) return false;
            if (this.ScheduleId != input.ScheduleId || (this.ScheduleId != null && !this.ScheduleId.Equals(input.ScheduleId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.RefCount != input.RefCount || (this.RefCount != null && !this.RefCount.Equals(input.RefCount))) return false;
            if (this.Periodic != input.Periodic || (this.Periodic != null && input.Periodic != null && !this.Periodic.SequenceEqual(input.Periodic))) return false;
            if (this.Absolute != input.Absolute || (this.Absolute != null && !this.Absolute.Equals(input.Absolute))) return false;

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
                if (this.ScheduleId != null) hashCode = hashCode * 59 + this.ScheduleId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RefCount != null) hashCode = hashCode * 59 + this.RefCount.GetHashCode();
                if (this.Periodic != null) hashCode = hashCode * 59 + this.Periodic.GetHashCode();
                if (this.Absolute != null) hashCode = hashCode * 59 + this.Absolute.GetHashCode();
                return hashCode;
            }
        }
    }
}
