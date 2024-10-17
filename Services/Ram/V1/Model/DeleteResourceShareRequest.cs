using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ram.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteResourceShareRequest 
    {

        /// <summary>
        /// 资源共享实例的ID。
        /// </summary>
        [SDKProperty("resource_share_id", IsPath = true)]
        [JsonProperty("resource_share_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceShareId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteResourceShareRequest {\n");
            sb.Append("  resourceShareId: ").Append(ResourceShareId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteResourceShareRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteResourceShareRequest input)
        {
            if (input == null) return false;
            if (this.ResourceShareId != input.ResourceShareId || (this.ResourceShareId != null && !this.ResourceShareId.Equals(input.ResourceShareId))) return false;

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
                if (this.ResourceShareId != null) hashCode = hashCode * 59 + this.ResourceShareId.GetHashCode();
                return hashCode;
            }
        }
    }
}
