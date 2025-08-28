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
    /// Area ID。
    /// </summary>
    public class AreaId 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("area_id", NullValueHandling = NullValueHandling.Ignore)]
        public AreaIdDef _AreaId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AreaId {\n");
            sb.Append("  _areaId: ").Append(_AreaId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AreaId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AreaId input)
        {
            if (input == null) return false;
            if (this._AreaId != input._AreaId) return false;

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
                hashCode = hashCode * 59 + this._AreaId.GetHashCode();
                return hashCode;
            }
        }
    }
}
