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
        /// 区域id
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 中文描述
        /// </summary>
        [JsonProperty("description_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string DescriptionCn { get; set; }

        /// <summary>
        /// 英文描述
        /// </summary>
        [JsonProperty("description_en", NullValueHandling = NullValueHandling.Ignore)]
        public string DescriptionEn { get; set; }

        /// <summary>
        /// 区域类型，0表示国家，1表示省份，2表示大洲
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
            if (input == null)
                return false;

            return 
                (
                    this.RegionId == input.RegionId ||
                    (this.RegionId != null &&
                    this.RegionId.Equals(input.RegionId))
                ) && 
                (
                    this.DescriptionCn == input.DescriptionCn ||
                    (this.DescriptionCn != null &&
                    this.DescriptionCn.Equals(input.DescriptionCn))
                ) && 
                (
                    this.DescriptionEn == input.DescriptionEn ||
                    (this.DescriptionEn != null &&
                    this.DescriptionEn.Equals(input.DescriptionEn))
                ) && 
                (
                    this.RegionType == input.RegionType ||
                    (this.RegionType != null &&
                    this.RegionType.Equals(input.RegionType))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.RegionId != null)
                    hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.DescriptionCn != null)
                    hashCode = hashCode * 59 + this.DescriptionCn.GetHashCode();
                if (this.DescriptionEn != null)
                    hashCode = hashCode * 59 + this.DescriptionEn.GetHashCode();
                if (this.RegionType != null)
                    hashCode = hashCode * 59 + this.RegionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
