using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VolumeBatchDetachRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("serverinfo", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Serverinfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeBatchDetachRequest {\n");
            sb.Append("  serverinfo: ").Append(Serverinfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumeBatchDetachRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeBatchDetachRequest input)
        {
            if (input == null) return false;
            if (this.Serverinfo != input.Serverinfo || (this.Serverinfo != null && input.Serverinfo != null && !this.Serverinfo.SequenceEqual(input.Serverinfo))) return false;

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
                if (this.Serverinfo != null) hashCode = hashCode * 59 + this.Serverinfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
