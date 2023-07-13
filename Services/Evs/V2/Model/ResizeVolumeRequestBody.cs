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
    public class ResizeVolumeRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bssParam", NullValueHandling = NullValueHandling.Ignore)]
        public BssParamForResizeVolume BssParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os-extend", NullValueHandling = NullValueHandling.Ignore)]
        public OsExtend OsExtend { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeVolumeRequestBody {\n");
            sb.Append("  bssParam: ").Append(BssParam).Append("\n");
            sb.Append("  osExtend: ").Append(OsExtend).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeVolumeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeVolumeRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BssParam == input.BssParam ||
                    (this.BssParam != null &&
                    this.BssParam.Equals(input.BssParam))
                ) && 
                (
                    this.OsExtend == input.OsExtend ||
                    (this.OsExtend != null &&
                    this.OsExtend.Equals(input.OsExtend))
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
                if (this.BssParam != null)
                    hashCode = hashCode * 59 + this.BssParam.GetHashCode();
                if (this.OsExtend != null)
                    hashCode = hashCode * 59 + this.OsExtend.GetHashCode();
                return hashCode;
            }
        }
    }
}
