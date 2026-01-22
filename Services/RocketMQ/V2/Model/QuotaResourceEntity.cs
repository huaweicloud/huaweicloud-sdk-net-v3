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
    /// 
    /// </summary>
    public class QuotaResourceEntity 
    {

        /// <summary>
        /// **参数解释**： 支持[rabbitmqInstance、](tag:ctc,hws_eu,ocb,g42,hk_g42,tm,sbc,hk_sbc,cmcc,hk_tm,fcs,ax,srg)kafkaInstance、rocketmqInstance、tags。 [- rabbitmqInstance表示RabbitMQ实例配额。](tag:ctc,hws_eu,ocb,g42,hk_g42,tm,sbc,hk_sbc,cmcc,hk_tm,fcs,ax,srg) - kafkaInstance表示Kafka实例配额。 - rocketmqInstance表示RocketMQ实例配额。 - tags表示标签的配额。 - kafkaInstancePublic表示kafka公网配额，已弃用。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 租户最大可以创建的实例个数，或者每个实例最大可以创建的标签个数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quota { get; set; }

        /// <summary>
        /// **参数解释**： 已创建的实例个数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public int? Used { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaResourceEntity {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  quota: ").Append(Quota).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuotaResourceEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuotaResourceEntity input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Quota != input.Quota || (this.Quota != null && !this.Quota.Equals(input.Quota))) return false;
            if (this.Used != input.Used || (this.Used != null && !this.Used.Equals(input.Used))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Quota != null) hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.Used != null) hashCode = hashCode * 59 + this.Used.GetHashCode();
                return hashCode;
            }
        }
    }
}
