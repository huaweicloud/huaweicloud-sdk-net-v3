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
    public class CompareFaceByFileRequestBody : IFormDataBody
    {

        /// <summary>
        /// 本地图片文件，图片不能超过8MB。上传文件时，请求格式为multipart。
        /// </summary>
        [JsonProperty("image1_file", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart Image1File { get; set; }

        /// <summary>
        /// 本地图片文件，图片不能超过8MB。上传文件时，请求格式为multipart。
        /// </summary>
        [JsonProperty("image2_file", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart Image2File { get; set; }


        
        public CompareFaceByFileRequestBody WithImage1File(Stream stream, string filename)
        {
            this.Image1File = new FormDataFilePart(stream, filename);
            return this;
        }

        public CompareFaceByFileRequestBody WithImage1File(Stream stream, string filename, string contentType)
        {
            this.Image1File = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        
        public CompareFaceByFileRequestBody WithImage2File(Stream stream, string filename)
        {
            this.Image2File = new FormDataFilePart(stream, filename);
            return this;
        }

        public CompareFaceByFileRequestBody WithImage2File(Stream stream, string filename, string contentType)
        {
            this.Image2File = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("image1_file", Image1File);
            formData.Add("image2_file", Image2File);

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareFaceByFileRequestBody {\n");
            sb.Append("  image1File: ").Append(Image1File).Append("\n");
            sb.Append("  image2File: ").Append(Image2File).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompareFaceByFileRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompareFaceByFileRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Image1File == input.Image1File ||
                    (this.Image1File != null &&
                    this.Image1File.Equals(input.Image1File))
                ) && 
                (
                    this.Image2File == input.Image2File ||
                    (this.Image2File != null &&
                    this.Image2File.Equals(input.Image2File))
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
                if (this.Image1File != null)
                    hashCode = hashCode * 59 + this.Image1File.GetHashCode();
                if (this.Image2File != null)
                    hashCode = hashCode * 59 + this.Image2File.GetHashCode();
                return hashCode;
            }
        }
    }
}
