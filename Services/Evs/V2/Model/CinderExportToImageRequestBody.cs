using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class CinderExportToImageRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os-volume_upload_image", NullValueHandling = NullValueHandling.Ignore)]
        public CinderExportToImageOption OsVolumeUploadImage { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CinderExportToImageRequestBody {\n");
            sb.Append("  osVolumeUploadImage: ").Append(OsVolumeUploadImage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CinderExportToImageRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CinderExportToImageRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OsVolumeUploadImage == input.OsVolumeUploadImage ||
                    (this.OsVolumeUploadImage != null &&
                    this.OsVolumeUploadImage.Equals(input.OsVolumeUploadImage))
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
                if (this.OsVolumeUploadImage != null)
                    hashCode = hashCode * 59 + this.OsVolumeUploadImage.GetHashCode();
                return hashCode;
            }
        }
    }
}
