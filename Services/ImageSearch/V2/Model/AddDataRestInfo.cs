using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V2.Model
{
    /// <summary>
    /// 添加数据的相关信息。
    /// </summary>
    public class AddDataRestInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_info", NullValueHandling = NullValueHandling.Ignore)]
        public AddDataRestInfoImageInfo ImageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDataRestInfo {\n");
            sb.Append("  imageInfo: ").Append(ImageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddDataRestInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDataRestInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageInfo == input.ImageInfo ||
                    (this.ImageInfo != null &&
                    this.ImageInfo.Equals(input.ImageInfo))
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
                if (this.ImageInfo != null)
                    hashCode = hashCode * 59 + this.ImageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
