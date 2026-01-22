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
    public class IpRegionDto 
    {

        /// <summary>
        /// **参数解释**： 区域ID，用于明确规则引用地域，可通过[获取账号、IAM用户、项目、用户组、区域、委托的名称和ID](cfw_02_0030.xml)获取。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// **参数解释**： 区域中文描述，仅当区域为中国区域时使用，可通过[地域信息表](cfw_02_0031.xml)获取 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("description_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string DescriptionCn { get; set; }

        /// <summary>
        /// **参数解释**： 区域英文描述，仅当区域为非中国区域时使用，可通过[地域信息表](cfw_02_0031.xml)获取。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("description_en", NullValueHandling = NullValueHandling.Ignore)]
        public string DescriptionEn { get; set; }

        /// <summary>
        /// **参数解释**： 区域类型 **约束限制**： 不涉及 **取值范围**： - 0：国家 - 1：省份 - 2：大洲 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("region_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? RegionType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpRegionDto {\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  descriptionCn: ").Append(DescriptionCn).Append("\n");
            sb.Append("  descriptionEn: ").Append(DescriptionEn).Append("\n");
            sb.Append("  regionType: ").Append(RegionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpRegionDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpRegionDto input)
        {
            if (input == null) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.DescriptionCn != input.DescriptionCn || (this.DescriptionCn != null && !this.DescriptionCn.Equals(input.DescriptionCn))) return false;
            if (this.DescriptionEn != input.DescriptionEn || (this.DescriptionEn != null && !this.DescriptionEn.Equals(input.DescriptionEn))) return false;
            if (this.RegionType != input.RegionType || (this.RegionType != null && !this.RegionType.Equals(input.RegionType))) return false;

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
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.DescriptionCn != null) hashCode = hashCode * 59 + this.DescriptionCn.GetHashCode();
                if (this.DescriptionEn != null) hashCode = hashCode * 59 + this.DescriptionEn.GetHashCode();
                if (this.RegionType != null) hashCode = hashCode * 59 + this.RegionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
