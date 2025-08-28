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
    /// 本端大区ID。
    /// </summary>
    public class LocalAreaId 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("local_area_id", NullValueHandling = NullValueHandling.Ignore)]
        public AreaIdDef _LocalAreaId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocalAreaId {\n");
            sb.Append("  _localAreaId: ").Append(_LocalAreaId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LocalAreaId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LocalAreaId input)
        {
            if (input == null) return false;
            if (this._LocalAreaId != input._LocalAreaId) return false;

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
                hashCode = hashCode * 59 + this._LocalAreaId.GetHashCode();
                return hashCode;
            }
        }
    }
}
