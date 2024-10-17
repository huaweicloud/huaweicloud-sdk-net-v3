using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DetectLiveFaceByFileRequestBody : IFormDataBody
    {

        /// <summary>
        /// 本地图片文件。上传文件时，请求格式为multipart。
        /// </summary>
        [JsonProperty("image_file", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart ImageFile { get; set; }


        
        public DetectLiveFaceByFileRequestBody WithImageFile(Stream stream, string filename)
        {
            this.ImageFile = new FormDataFilePart(stream, filename);
            return this;
        }

        public DetectLiveFaceByFileRequestBody WithImageFile(Stream stream, string filename, string contentType)
        {
            this.ImageFile = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("image_file", ImageFile);

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectLiveFaceByFileRequestBody {\n");
            sb.Append("  imageFile: ").Append(ImageFile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetectLiveFaceByFileRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetectLiveFaceByFileRequestBody input)
        {
            if (input == null) return false;
            if (this.ImageFile != input.ImageFile || (this.ImageFile != null && !this.ImageFile.Equals(input.ImageFile))) return false;

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
                if (this.ImageFile != null) hashCode = hashCode * 59 + this.ImageFile.GetHashCode();
                return hashCode;
            }
        }
    }
}
