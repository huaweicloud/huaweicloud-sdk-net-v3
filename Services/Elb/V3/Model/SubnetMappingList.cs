using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 源子网信息和目标子网的对应关系
    /// </summary>
    public class SubnetMappingList 
    {

        /// <summary>
        /// **参数解释**：源监听器下后端服务器所在VPC的子网ID。  **约束限制**：不涉及  **取值范围**：标准的UUID格式，长度为36个字符。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("subnet_cidr_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetCidrId { get; set; }

        /// <summary>
        /// **参数解释**：新监听器下后端服务器需要绑定的VPC子网ID。  **约束限制**：该VPC子网ID需要存在，且与源子网网段相同。  **取值范围**：标准的UUID格式，长度为36个字符。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("dst_subnet_cidr_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DstSubnetCidrId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubnetMappingList {\n");
            sb.Append("  subnetCidrId: ").Append(SubnetCidrId).Append("\n");
            sb.Append("  dstSubnetCidrId: ").Append(DstSubnetCidrId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubnetMappingList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubnetMappingList input)
        {
            if (input == null) return false;
            if (this.SubnetCidrId != input.SubnetCidrId || (this.SubnetCidrId != null && !this.SubnetCidrId.Equals(input.SubnetCidrId))) return false;
            if (this.DstSubnetCidrId != input.DstSubnetCidrId || (this.DstSubnetCidrId != null && !this.DstSubnetCidrId.Equals(input.DstSubnetCidrId))) return false;

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
                if (this.SubnetCidrId != null) hashCode = hashCode * 59 + this.SubnetCidrId.GetHashCode();
                if (this.DstSubnetCidrId != null) hashCode = hashCode * 59 + this.DstSubnetCidrId.GetHashCode();
                return hashCode;
            }
        }
    }
}
