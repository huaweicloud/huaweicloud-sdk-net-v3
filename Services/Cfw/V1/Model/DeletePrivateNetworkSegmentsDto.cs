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
    public class DeletePrivateNetworkSegmentsDto 
    {

        /// <summary>
        /// **参数解释**： 删除的私网网段ID列表，可以通过调用[获取私网网段的信息]获得，通过返回值中的data.private_network_list.conf_id获得 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("conf_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ConfIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletePrivateNetworkSegmentsDto {\n");
            sb.Append("  confIds: ").Append(ConfIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeletePrivateNetworkSegmentsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeletePrivateNetworkSegmentsDto input)
        {
            if (input == null) return false;
            if (this.ConfIds != input.ConfIds || (this.ConfIds != null && input.ConfIds != null && !this.ConfIds.SequenceEqual(input.ConfIds))) return false;

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
                if (this.ConfIds != null) hashCode = hashCode * 59 + this.ConfIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
