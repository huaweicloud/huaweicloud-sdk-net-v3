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
    /// 变更磁盘类型
    /// </summary>
    public class RetypeVolume 
    {

        /// <summary>
        /// 磁盘变更至指定的磁盘类型
        /// </summary>
        [JsonProperty("new_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NewType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetypeVolume {\n");
            sb.Append("  newType: ").Append(NewType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetypeVolume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetypeVolume input)
        {
            if (input == null) return false;
            if (this.NewType != input.NewType || (this.NewType != null && !this.NewType.Equals(input.NewType))) return false;

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
                if (this.NewType != null) hashCode = hashCode * 59 + this.NewType.GetHashCode();
                return hashCode;
            }
        }
    }
}
