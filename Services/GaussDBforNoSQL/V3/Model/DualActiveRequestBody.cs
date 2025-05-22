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
    /// 参数解释 搭建双活的目标实例信息。 约束限制 不涉及。 取值范围 不涉及。 默认取值 不涉及。
    /// </summary>
    public class DualActiveRequestBody 
    {

        /// <summary>
        /// 参数解释 搭建双活目标实例所在的region。 约束限制 不涉及。 取值范围 不涉及。 默认取值 不涉及。
        /// </summary>
        [JsonProperty("destination_region", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// 参数解释 搭建双活目标实例ID。 约束限制 不涉及。 取值范围 不涉及。 默认取值 不涉及。
        /// </summary>
        [JsonProperty("destination_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationInstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DualActiveRequestBody {\n");
            sb.Append("  destinationRegion: ").Append(DestinationRegion).Append("\n");
            sb.Append("  destinationInstanceId: ").Append(DestinationInstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DualActiveRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DualActiveRequestBody input)
        {
            if (input == null) return false;
            if (this.DestinationRegion != input.DestinationRegion || (this.DestinationRegion != null && !this.DestinationRegion.Equals(input.DestinationRegion))) return false;
            if (this.DestinationInstanceId != input.DestinationInstanceId || (this.DestinationInstanceId != null && !this.DestinationInstanceId.Equals(input.DestinationInstanceId))) return false;

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
                if (this.DestinationRegion != null) hashCode = hashCode * 59 + this.DestinationRegion.GetHashCode();
                if (this.DestinationInstanceId != null) hashCode = hashCode * 59 + this.DestinationInstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
