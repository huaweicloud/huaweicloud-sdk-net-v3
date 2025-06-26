using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Session 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sbc", NullValueHandling = NullValueHandling.Ignore)]
        public Sbc Sbc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Session {\n");
            sb.Append("  sbc: ").Append(Sbc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Session);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Session input)
        {
            if (input == null) return false;
            if (this.Sbc != input.Sbc || (this.Sbc != null && !this.Sbc.Equals(input.Sbc))) return false;

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
                if (this.Sbc != null) hashCode = hashCode * 59 + this.Sbc.GetHashCode();
                return hashCode;
            }
        }
    }
}
