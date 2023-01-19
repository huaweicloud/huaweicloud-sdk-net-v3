using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WebImageExtractedData 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("contact_info", NullValueHandling = NullValueHandling.Ignore)]
        public WebImageContactInfo ContactInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_size", NullValueHandling = NullValueHandling.Ignore)]
        public WebImageImageSize ImageSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebImageExtractedData {\n");
            sb.Append("  contactInfo: ").Append(ContactInfo).Append("\n");
            sb.Append("  imageSize: ").Append(ImageSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebImageExtractedData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WebImageExtractedData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContactInfo == input.ContactInfo ||
                    (this.ContactInfo != null &&
                    this.ContactInfo.Equals(input.ContactInfo))
                ) && 
                (
                    this.ImageSize == input.ImageSize ||
                    (this.ImageSize != null &&
                    this.ImageSize.Equals(input.ImageSize))
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
                if (this.ContactInfo != null)
                    hashCode = hashCode * 59 + this.ContactInfo.GetHashCode();
                if (this.ImageSize != null)
                    hashCode = hashCode * 59 + this.ImageSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
