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
    public class DualActiveInfo 
    {

        /// <summary>
        /// **参数解释：** 双活角色。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// **参数解释：** 双活状态。 **取值范围：** - normal：表示双活状态正常。 - abnormal：表示双活状态异常。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 双活对端实例id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("destination_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationInstanceId { get; set; }

        /// <summary>
        /// **参数解释：** 双活对端region。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("destination_region", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// **参数解释：** 双活对端实例名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("destination_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationInstanceName { get; set; }

        /// <summary>
        /// **参数解释：** 双活对端实例节点数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("destination_instance_node_num", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationInstanceNodeNum { get; set; }

        /// <summary>
        /// **参数解释：** 双活对端实例规格。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("destination_instance_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationInstanceSpecCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DualActiveInfo {\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  destinationInstanceId: ").Append(DestinationInstanceId).Append("\n");
            sb.Append("  destinationRegion: ").Append(DestinationRegion).Append("\n");
            sb.Append("  destinationInstanceName: ").Append(DestinationInstanceName).Append("\n");
            sb.Append("  destinationInstanceNodeNum: ").Append(DestinationInstanceNodeNum).Append("\n");
            sb.Append("  destinationInstanceSpecCode: ").Append(DestinationInstanceSpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DualActiveInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DualActiveInfo input)
        {
            if (input == null) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.DestinationInstanceId != input.DestinationInstanceId || (this.DestinationInstanceId != null && !this.DestinationInstanceId.Equals(input.DestinationInstanceId))) return false;
            if (this.DestinationRegion != input.DestinationRegion || (this.DestinationRegion != null && !this.DestinationRegion.Equals(input.DestinationRegion))) return false;
            if (this.DestinationInstanceName != input.DestinationInstanceName || (this.DestinationInstanceName != null && !this.DestinationInstanceName.Equals(input.DestinationInstanceName))) return false;
            if (this.DestinationInstanceNodeNum != input.DestinationInstanceNodeNum || (this.DestinationInstanceNodeNum != null && !this.DestinationInstanceNodeNum.Equals(input.DestinationInstanceNodeNum))) return false;
            if (this.DestinationInstanceSpecCode != input.DestinationInstanceSpecCode || (this.DestinationInstanceSpecCode != null && !this.DestinationInstanceSpecCode.Equals(input.DestinationInstanceSpecCode))) return false;

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
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DestinationInstanceId != null) hashCode = hashCode * 59 + this.DestinationInstanceId.GetHashCode();
                if (this.DestinationRegion != null) hashCode = hashCode * 59 + this.DestinationRegion.GetHashCode();
                if (this.DestinationInstanceName != null) hashCode = hashCode * 59 + this.DestinationInstanceName.GetHashCode();
                if (this.DestinationInstanceNodeNum != null) hashCode = hashCode * 59 + this.DestinationInstanceNodeNum.GetHashCode();
                if (this.DestinationInstanceSpecCode != null) hashCode = hashCode * 59 + this.DestinationInstanceSpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
