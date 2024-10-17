using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NodeTemplateExtendParam 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("userID", NullValueHandling = NullValueHandling.Ignore)]
        public string UserID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeTemplateExtendParam {\n");
            sb.Append("  userID: ").Append(UserID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeTemplateExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeTemplateExtendParam input)
        {
            if (input == null) return false;
            if (this.UserID != input.UserID || (this.UserID != null && !this.UserID.Equals(input.UserID))) return false;

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
                if (this.UserID != null) hashCode = hashCode * 59 + this.UserID.GetHashCode();
                return hashCode;
            }
        }
    }
}
