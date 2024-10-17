using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class ModifyVolumeQoSRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("qos_modify", NullValueHandling = NullValueHandling.Ignore)]
        public ModifyVolumeQoSOption QosModify { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyVolumeQoSRequestBody {\n");
            sb.Append("  qosModify: ").Append(QosModify).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyVolumeQoSRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyVolumeQoSRequestBody input)
        {
            if (input == null) return false;
            if (this.QosModify != input.QosModify || (this.QosModify != null && !this.QosModify.Equals(input.QosModify))) return false;

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
                if (this.QosModify != null) hashCode = hashCode * 59 + this.QosModify.GetHashCode();
                return hashCode;
            }
        }
    }
}
