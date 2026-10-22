using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释：** 单副本资源实例调度约束配置。 **约束限制：** 不涉及。 **取值范围：** 不涉及。
    /// </summary>
    public class UnitGroupPolicy 
    {

        /// <summary>
        /// **参数解释：** 调度范围，仅A5超节点规格生效。 **约束限制：** - 仅当资源池包含A5(snt9e)规格时有效，非A5规格不执行调度范围校验。 - A5规格仅支持LWS工作负载类型，不支持DEPLOYMENT。 - A5规格需要Volcano调度插件版本满足要求。 **取值范围：** - HYPERNODE：超节点调度 - SLICE：柜级调度 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("schedule_scope", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduleScope { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnitGroupPolicy {\n");
            sb.Append("  scheduleScope: ").Append(ScheduleScope).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnitGroupPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnitGroupPolicy input)
        {
            if (input == null) return false;
            if (this.ScheduleScope != input.ScheduleScope || (this.ScheduleScope != null && !this.ScheduleScope.Equals(input.ScheduleScope))) return false;

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
                if (this.ScheduleScope != null) hashCode = hashCode * 59 + this.ScheduleScope.GetHashCode();
                return hashCode;
            }
        }
    }
}
