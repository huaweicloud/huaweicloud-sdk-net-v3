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
    /// 跨地域类型。
    /// </summary>
    public class CrossRegionType 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cross_region_type", NullValueHandling = NullValueHandling.Ignore)]
        public CrossRegionTypeEnum _CrossRegionType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrossRegionType {\n");
            sb.Append("  _crossRegionType: ").Append(_CrossRegionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CrossRegionType);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CrossRegionType input)
        {
            if (input == null) return false;
            if (this._CrossRegionType != input._CrossRegionType) return false;

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
                hashCode = hashCode * 59 + this._CrossRegionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
