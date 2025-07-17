using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 信息窗素材信息。
    /// </summary>
    public class UpdateMaterialRequestDTO 
    {

        /// <summary>
        /// 素材名称。
        /// </summary>
        [JsonProperty("materialName", NullValueHandling = NullValueHandling.Ignore)]
        public string MaterialName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMaterialRequestDTO {\n");
            sb.Append("  materialName: ").Append(MaterialName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateMaterialRequestDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateMaterialRequestDTO input)
        {
            if (input == null) return false;
            if (this.MaterialName != input.MaterialName || (this.MaterialName != null && !this.MaterialName.Equals(input.MaterialName))) return false;

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
                if (this.MaterialName != null) hashCode = hashCode * 59 + this.MaterialName.GetHashCode();
                return hashCode;
            }
        }
    }
}
