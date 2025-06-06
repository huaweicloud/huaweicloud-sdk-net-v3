using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListAvailableZonesRespAvailableZones 
    {

        /// <summary>
        /// **参数解释**： 是否售罄。 **取值范围**： - true：售罄 - false：没有售罄
        /// </summary>
        [JsonProperty("soldOut", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SoldOut { get; set; }

        /// <summary>
        /// **参数解释**： 可用区ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 可用区编码。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// **参数解释**： 可用区名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 可用区端口号。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// **参数解释**： 分区上是否还有可用资源。 **取值范围**： - true：有可用资源。 - false：没有可用资源。
        /// </summary>
        [JsonProperty("resource_availability", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceAvailability { get; set; }

        /// <summary>
        /// **参数解释**： 是否为默认可用区。 **取值范围**： - true：默认可用区 - false：不是默认可用区
        /// </summary>
        [JsonProperty("default_az", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultAz { get; set; }

        /// <summary>
        /// **参数解释**： 剩余时间，以Unix时间戳显示。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("remain_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RemainTime { get; set; }

        /// <summary>
        /// **参数解释**： 是否支持IPv6。 **取值范围**： - true：支持IPv6 - false：不支持IPv6
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAvailableZonesRespAvailableZones {\n");
            sb.Append("  soldOut: ").Append(SoldOut).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  resourceAvailability: ").Append(ResourceAvailability).Append("\n");
            sb.Append("  defaultAz: ").Append(DefaultAz).Append("\n");
            sb.Append("  remainTime: ").Append(RemainTime).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAvailableZonesRespAvailableZones);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAvailableZonesRespAvailableZones input)
        {
            if (input == null) return false;
            if (this.SoldOut != input.SoldOut || (this.SoldOut != null && !this.SoldOut.Equals(input.SoldOut))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.ResourceAvailability != input.ResourceAvailability || (this.ResourceAvailability != null && !this.ResourceAvailability.Equals(input.ResourceAvailability))) return false;
            if (this.DefaultAz != input.DefaultAz || (this.DefaultAz != null && !this.DefaultAz.Equals(input.DefaultAz))) return false;
            if (this.RemainTime != input.RemainTime || (this.RemainTime != null && !this.RemainTime.Equals(input.RemainTime))) return false;
            if (this.Ipv6Enable != input.Ipv6Enable || (this.Ipv6Enable != null && !this.Ipv6Enable.Equals(input.Ipv6Enable))) return false;

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
                if (this.SoldOut != null) hashCode = hashCode * 59 + this.SoldOut.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.ResourceAvailability != null) hashCode = hashCode * 59 + this.ResourceAvailability.GetHashCode();
                if (this.DefaultAz != null) hashCode = hashCode * 59 + this.DefaultAz.GetHashCode();
                if (this.RemainTime != null) hashCode = hashCode * 59 + this.RemainTime.GetHashCode();
                if (this.Ipv6Enable != null) hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                return hashCode;
            }
        }
    }
}
