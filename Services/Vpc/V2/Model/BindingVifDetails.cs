using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BindingVifDetails 
    {

        /// <summary>
        /// 功能说明：取值为true，表示是虚拟机的主网卡。
        /// </summary>
        [JsonProperty("primary_interface", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrimaryInterface { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BindingVifDetails {\n");
            sb.Append("  primaryInterface: ").Append(PrimaryInterface).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BindingVifDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BindingVifDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrimaryInterface == input.PrimaryInterface ||
                    (this.PrimaryInterface != null &&
                    this.PrimaryInterface.Equals(input.PrimaryInterface))
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
                if (this.PrimaryInterface != null)
                    hashCode = hashCode * 59 + this.PrimaryInterface.GetHashCode();
                return hashCode;
            }
        }
    }
}
