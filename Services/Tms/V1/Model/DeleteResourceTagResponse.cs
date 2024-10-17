using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Tms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DeleteResourceTagResponse : SdkResponse
    {

        /// <summary>
        /// 查询标签下的资源
        /// </summary>
        [JsonProperty("failed_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagDeleteResponseItem> FailedResources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteResourceTagResponse {\n");
            sb.Append("  failedResources: ").Append(FailedResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteResourceTagResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteResourceTagResponse input)
        {
            if (input == null) return false;
            if (this.FailedResources != input.FailedResources || (this.FailedResources != null && input.FailedResources != null && !this.FailedResources.SequenceEqual(input.FailedResources))) return false;

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
                if (this.FailedResources != null) hashCode = hashCode * 59 + this.FailedResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
