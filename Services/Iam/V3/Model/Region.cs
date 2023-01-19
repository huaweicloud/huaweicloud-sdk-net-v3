using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Region 
    {

        /// <summary>
        /// 区域描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// null.
        /// </summary>
        [JsonProperty("parent_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentRegionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public LinksSelf Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("locales", NullValueHandling = NullValueHandling.Ignore)]
        public RegionLocales Locales { get; set; }

        /// <summary>
        /// 区域ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 区域类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Region {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  parentRegionId: ").Append(ParentRegionId).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  locales: ").Append(Locales).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Region);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Region input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ParentRegionId == input.ParentRegionId ||
                    (this.ParentRegionId != null &&
                    this.ParentRegionId.Equals(input.ParentRegionId))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Locales == input.Locales ||
                    (this.Locales != null &&
                    this.Locales.Equals(input.Locales))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ParentRegionId != null)
                    hashCode = hashCode * 59 + this.ParentRegionId.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Locales != null)
                    hashCode = hashCode * 59 + this.Locales.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
