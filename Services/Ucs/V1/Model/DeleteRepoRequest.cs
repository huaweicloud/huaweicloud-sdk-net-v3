using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteRepoRequest 
    {

        /// <summary>
        /// 仓库id
        /// </summary>
        [SDKProperty("repoid", IsPath = true)]
        [JsonProperty("repoid", NullValueHandling = NullValueHandling.Ignore)]
        public string Repoid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteRepoRequest {\n");
            sb.Append("  repoid: ").Append(Repoid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteRepoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteRepoRequest input)
        {
            if (input == null) return false;
            if (this.Repoid != input.Repoid || (this.Repoid != null && !this.Repoid.Equals(input.Repoid))) return false;

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
                if (this.Repoid != null) hashCode = hashCode * 59 + this.Repoid.GetHashCode();
                return hashCode;
            }
        }
    }
}
