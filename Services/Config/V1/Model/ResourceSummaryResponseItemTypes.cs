using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 资源类型
    /// </summary>
    public class ResourceSummaryResponseItemTypes 
    {

        /// <summary>
        /// 资源类型名称
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 区域列表
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceSummaryResponseItemRegions> Regions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceSummaryResponseItemTypes {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  regions: ").Append(Regions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceSummaryResponseItemTypes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceSummaryResponseItemTypes input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Regions != input.Regions || (this.Regions != null && input.Regions != null && !this.Regions.SequenceEqual(input.Regions))) return false;

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
                if (this.Regions != null) hashCode = hashCode * 59 + this.Regions.GetHashCode();
                return hashCode;
            }
        }
    }
}
