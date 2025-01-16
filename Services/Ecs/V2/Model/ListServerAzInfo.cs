using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListServerAzInfo 
    {

        /// <summary>
        /// 可用区ID
        /// </summary>
        [JsonProperty("availability_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// 可用区类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 可用区模式
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// 公网边界组，网络eip类别标识，用于查找az可用的eip池
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }

        /// <summary>
        /// 可用区别名
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>
        /// 可用区所属的AZGroup列表
        /// </summary>
        [JsonProperty("az_group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AzGroupIds { get; set; }

        /// <summary>
        /// 可用区类型对应的子类型
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public int? Category { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServerAzInfo {\n");
            sb.Append("  availabilityZoneId: ").Append(AvailabilityZoneId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("  azGroupIds: ").Append(AzGroupIds).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServerAzInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServerAzInfo input)
        {
            if (input == null) return false;
            if (this.AvailabilityZoneId != input.AvailabilityZoneId || (this.AvailabilityZoneId != null && !this.AvailabilityZoneId.Equals(input.AvailabilityZoneId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;
            if (this.PublicBorderGroup != input.PublicBorderGroup || (this.PublicBorderGroup != null && !this.PublicBorderGroup.Equals(input.PublicBorderGroup))) return false;
            if (this.Alias != input.Alias || (this.Alias != null && !this.Alias.Equals(input.Alias))) return false;
            if (this.AzGroupIds != input.AzGroupIds || (this.AzGroupIds != null && input.AzGroupIds != null && !this.AzGroupIds.SequenceEqual(input.AzGroupIds))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;

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
                if (this.AvailabilityZoneId != null) hashCode = hashCode * 59 + this.AvailabilityZoneId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.PublicBorderGroup != null) hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                if (this.Alias != null) hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.AzGroupIds != null) hashCode = hashCode * 59 + this.AzGroupIds.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                return hashCode;
            }
        }
    }
}
