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
    /// **参数解释**： 磁盘IO信息。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
    /// </summary>
    public class RocketMQExtendProductIosEntity 
    {

        /// <summary>
        /// **参数解释**： 存储IO规格。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("io_spec", NullValueHandling = NullValueHandling.Ignore)]
        public string IoSpec { get; set; }

        /// <summary>
        /// **参数解释**： 可用分区列表。RocketMQ 5.X基础版部署架构为单机时，请选择1个可用区，为集群时可选择1个或2个可用区。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// **参数解释**： IO类型。 **约束限制**： 不涉及。 **取值范围**： - evs：[华为云磁盘类型。](tag:hws,hws_hk)[磁盘类型。](tag:ctc,hws_eu,ocb,g42,hk_g42,tm,sbc,hk_sbc,cmcc,hk_tm,hcs,fcs,dt,hcs_oemout,ax,srg) [- dss：专属云磁盘类型。](tag:hws,hws_hk) **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 不可用分区列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("unavailable_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UnavailableZones { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RocketMQExtendProductIosEntity {\n");
            sb.Append("  ioSpec: ").Append(IoSpec).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  unavailableZones: ").Append(UnavailableZones).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RocketMQExtendProductIosEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RocketMQExtendProductIosEntity input)
        {
            if (input == null) return false;
            if (this.IoSpec != input.IoSpec || (this.IoSpec != null && !this.IoSpec.Equals(input.IoSpec))) return false;
            if (this.AvailableZones != input.AvailableZones || (this.AvailableZones != null && input.AvailableZones != null && !this.AvailableZones.SequenceEqual(input.AvailableZones))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.UnavailableZones != input.UnavailableZones || (this.UnavailableZones != null && input.UnavailableZones != null && !this.UnavailableZones.SequenceEqual(input.UnavailableZones))) return false;

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
                if (this.IoSpec != null) hashCode = hashCode * 59 + this.IoSpec.GetHashCode();
                if (this.AvailableZones != null) hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UnavailableZones != null) hashCode = hashCode * 59 + this.UnavailableZones.GetHashCode();
                return hashCode;
            }
        }
    }
}
