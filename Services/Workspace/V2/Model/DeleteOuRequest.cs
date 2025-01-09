using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteOuRequest 
    {

        /// <summary>
        /// OU的id。
        /// </summary>
        [SDKProperty("ou_id", IsPath = true)]
        [JsonProperty("ou_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OuId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteOuRequest {\n");
            sb.Append("  ouId: ").Append(OuId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteOuRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteOuRequest input)
        {
            if (input == null) return false;
            if (this.OuId != input.OuId || (this.OuId != null && !this.OuId.Equals(input.OuId))) return false;

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
                if (this.OuId != null) hashCode = hashCode * 59 + this.OuId.GetHashCode();
                return hashCode;
            }
        }
    }
}
