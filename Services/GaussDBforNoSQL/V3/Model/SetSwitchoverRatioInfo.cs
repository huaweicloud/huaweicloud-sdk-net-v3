using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SetSwitchoverRatioInfo 
    {

        /// <summary>
        /// **参数解释：** 实例ID，可以调用“查询实例列表”接口获取。如果未申请实例，可以调用“创建实例”接口创建。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释：** 容灾切换的故障节点比例。 **约束限制**： 下限是50，步长是10，最大是100。 **取值范围：** - 50 - 60 - 70 - 80 - 90 - 100 **默认取值：** 100。
        /// </summary>
        [JsonProperty("switchover_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? SwitchoverRatio { get; set; }

        /// <summary>
        /// **参数解释：** 容灾实例数据同步时延，单位s。备实例和主实例同步时延超过该值时，不进行容灾倒换。默认不判断时延。 **约束限制：** 若需指定此参数，最小为10s。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("sync_delay", NullValueHandling = NullValueHandling.Ignore)]
        public long? SyncDelay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetSwitchoverRatioInfo {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  switchoverRatio: ").Append(SwitchoverRatio).Append("\n");
            sb.Append("  syncDelay: ").Append(SyncDelay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetSwitchoverRatioInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetSwitchoverRatioInfo input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.SwitchoverRatio != input.SwitchoverRatio || (this.SwitchoverRatio != null && !this.SwitchoverRatio.Equals(input.SwitchoverRatio))) return false;
            if (this.SyncDelay != input.SyncDelay || (this.SyncDelay != null && !this.SyncDelay.Equals(input.SyncDelay))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.SwitchoverRatio != null) hashCode = hashCode * 59 + this.SwitchoverRatio.GetHashCode();
                if (this.SyncDelay != null) hashCode = hashCode * 59 + this.SyncDelay.GetHashCode();
                return hashCode;
            }
        }
    }
}
