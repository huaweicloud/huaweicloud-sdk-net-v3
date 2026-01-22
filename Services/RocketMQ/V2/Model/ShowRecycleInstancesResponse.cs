using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRecycleInstancesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 保留天数。 **约束限制**： 不涉及。 **取值范围**： 1~7。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("retention_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// **参数解释**： 是否使用回收站。 **约束限制**： 不涉及。 **取值范围**： - true：使用回收站。 - false：不使用回收站。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("default_use_recycle", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultUseRecycle { get; set; }

        /// <summary>
        /// **参数解释**： 回收实例列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("recycle_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceRecycleInfo> RecycleInstances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRecycleInstancesResponse {\n");
            sb.Append("  retentionDays: ").Append(RetentionDays).Append("\n");
            sb.Append("  defaultUseRecycle: ").Append(DefaultUseRecycle).Append("\n");
            sb.Append("  recycleInstances: ").Append(RecycleInstances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRecycleInstancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRecycleInstancesResponse input)
        {
            if (input == null) return false;
            if (this.RetentionDays != input.RetentionDays || (this.RetentionDays != null && !this.RetentionDays.Equals(input.RetentionDays))) return false;
            if (this.DefaultUseRecycle != input.DefaultUseRecycle || (this.DefaultUseRecycle != null && !this.DefaultUseRecycle.Equals(input.DefaultUseRecycle))) return false;
            if (this.RecycleInstances != input.RecycleInstances || (this.RecycleInstances != null && input.RecycleInstances != null && !this.RecycleInstances.SequenceEqual(input.RecycleInstances))) return false;

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
                if (this.RetentionDays != null) hashCode = hashCode * 59 + this.RetentionDays.GetHashCode();
                if (this.DefaultUseRecycle != null) hashCode = hashCode * 59 + this.DefaultUseRecycle.GetHashCode();
                if (this.RecycleInstances != null) hashCode = hashCode * 59 + this.RecycleInstances.GetHashCode();
                return hashCode;
            }
        }
    }
}
