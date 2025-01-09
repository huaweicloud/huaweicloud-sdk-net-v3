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
    public class ListMarketImagesRequest 
    {

        /// <summary>
        /// 镜像id，支持传1到100个。
        /// </summary>
        [SDKProperty("image_ids", IsQuery = true)]
        [JsonProperty("image_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ImageIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMarketImagesRequest {\n");
            sb.Append("  imageIds: ").Append(ImageIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMarketImagesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMarketImagesRequest input)
        {
            if (input == null) return false;
            if (this.ImageIds != input.ImageIds || (this.ImageIds != null && input.ImageIds != null && !this.ImageIds.SequenceEqual(input.ImageIds))) return false;

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
                if (this.ImageIds != null) hashCode = hashCode * 59 + this.ImageIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
