using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AreaBandwidthPackageSpecification 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("local_area_id", NullValueHandling = NullValueHandling.Ignore)]
        public AreaIdDef LocalAreaId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("remote_area_id", NullValueHandling = NullValueHandling.Ignore)]
        public AreaIdDef RemoteAreaId { get; set; }
        /// <summary>
        /// 互通大区带宽包的规格ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 带宽包产品规格列表。
        /// </summary>
        [JsonProperty("spec_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<SpecificationCodeInfo> SpecCodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AreaBandwidthPackageSpecification {\n");
            sb.Append("  localAreaId: ").Append(LocalAreaId).Append("\n");
            sb.Append("  remoteAreaId: ").Append(RemoteAreaId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  specCodes: ").Append(SpecCodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AreaBandwidthPackageSpecification);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AreaBandwidthPackageSpecification input)
        {
            if (input == null) return false;
            if (this.LocalAreaId != input.LocalAreaId) return false;
            if (this.RemoteAreaId != input.RemoteAreaId) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.SpecCodes != input.SpecCodes || (this.SpecCodes != null && input.SpecCodes != null && !this.SpecCodes.SequenceEqual(input.SpecCodes))) return false;

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
                hashCode = hashCode * 59 + this.LocalAreaId.GetHashCode();
                hashCode = hashCode * 59 + this.RemoteAreaId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SpecCodes != null) hashCode = hashCode * 59 + this.SpecCodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
