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
    /// 本端 Region ID。
    /// </summary>
    public class LocalRegionId 
    {

        /// <summary>
        /// RegionID。
        /// </summary>
        [JsonProperty("local_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _LocalRegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocalRegionId {\n");
            sb.Append("  _localRegionId: ").Append(_LocalRegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LocalRegionId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LocalRegionId input)
        {
            if (input == null) return false;
            if (this._LocalRegionId != input._LocalRegionId || (this._LocalRegionId != null && !this._LocalRegionId.Equals(input._LocalRegionId))) return false;

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
                if (this._LocalRegionId != null) hashCode = hashCode * 59 + this._LocalRegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
