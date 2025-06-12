using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreatePictureModelingJobRequestBody : IFormDataBody
    {

        /// <summary>
        /// 照片文件。 &gt; 只能上传jpg/jpeg/png格式文件， 最大分辨率为3840*2160
        /// </summary>
        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart File { get; set; }

        /// <summary>
        /// 数字人风格ID。 * system_male_001：男性风格01 * system_female_001：女性风格01 * system_male_002：男性风格02 * system_female_002：女性风格02
        /// </summary>
        [JsonProperty("style_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StyleId { get; set; }

        /// <summary>
        /// 数字人模型名称，首次创建时使用。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 照片建模任务结束的回调地址。
        /// </summary>
        [JsonProperty("notify_url", NullValueHandling = NullValueHandling.Ignore)]
        public string NotifyUrl { get; set; }


        
        public CreatePictureModelingJobRequestBody WithFile(Stream stream, string filename)
        {
            this.File = new FormDataFilePart(stream, filename);
            return this;
        }

        public CreatePictureModelingJobRequestBody WithFile(Stream stream, string filename, string contentType)
        {
            this.File = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("file", File);
            formData.Add("style_id", new FormDataPart<string>(StyleId));
            formData.Add("name", new FormDataPart<string>(Name));
            if (NotifyUrl != null) {
                formData.Add("notify_url", new FormDataPart<string>(NotifyUrl));
            }

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePictureModelingJobRequestBody {\n");
            sb.Append("  file: ").Append(File).Append("\n");
            sb.Append("  styleId: ").Append(StyleId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  notifyUrl: ").Append(NotifyUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePictureModelingJobRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePictureModelingJobRequestBody input)
        {
            if (input == null) return false;
            if (this.File != input.File || (this.File != null && !this.File.Equals(input.File))) return false;
            if (this.StyleId != input.StyleId || (this.StyleId != null && !this.StyleId.Equals(input.StyleId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NotifyUrl != input.NotifyUrl || (this.NotifyUrl != null && !this.NotifyUrl.Equals(input.NotifyUrl))) return false;

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
                if (this.File != null) hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.StyleId != null) hashCode = hashCode * 59 + this.StyleId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NotifyUrl != null) hashCode = hashCode * 59 + this.NotifyUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
