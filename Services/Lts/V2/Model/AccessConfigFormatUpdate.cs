using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AccessConfigFormatUpdate 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("single", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigFormatSingle Single { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("multi", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigFormatMutil Multi { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessConfigFormatUpdate {\n");
            sb.Append("  single: ").Append(Single).Append("\n");
            sb.Append("  multi: ").Append(Multi).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessConfigFormatUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessConfigFormatUpdate input)
        {
            if (input == null) return false;
            if (this.Single != input.Single || (this.Single != null && !this.Single.Equals(input.Single))) return false;
            if (this.Multi != input.Multi || (this.Multi != null && !this.Multi.Equals(input.Multi))) return false;

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
                if (this.Single != null) hashCode = hashCode * 59 + this.Single.GetHashCode();
                if (this.Multi != null) hashCode = hashCode * 59 + this.Multi.GetHashCode();
                return hashCode;
            }
        }
    }
}
