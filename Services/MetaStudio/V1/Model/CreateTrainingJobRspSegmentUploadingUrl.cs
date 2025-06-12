using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 分句上传任务的上传地址,create_type为segment时设置。
    /// </summary>
    public class CreateTrainingJobRspSegmentUploadingUrl 
    {

        /// <summary>
        /// 音频上传的地址。  通过该obs地址上传时，需设置content-type为audio/wav
        /// </summary>
        [JsonProperty("audio_uploading_url", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AudioUploadingUrl { get; set; }

        /// <summary>
        /// 文本上传的地址。  通过该obs地址上传时需设置content-type为text/plain
        /// </summary>
        [JsonProperty("txt_uploading_url", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TxtUploadingUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTrainingJobRspSegmentUploadingUrl {\n");
            sb.Append("  audioUploadingUrl: ").Append(AudioUploadingUrl).Append("\n");
            sb.Append("  txtUploadingUrl: ").Append(TxtUploadingUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTrainingJobRspSegmentUploadingUrl);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTrainingJobRspSegmentUploadingUrl input)
        {
            if (input == null) return false;
            if (this.AudioUploadingUrl != input.AudioUploadingUrl || (this.AudioUploadingUrl != null && input.AudioUploadingUrl != null && !this.AudioUploadingUrl.SequenceEqual(input.AudioUploadingUrl))) return false;
            if (this.TxtUploadingUrl != input.TxtUploadingUrl || (this.TxtUploadingUrl != null && input.TxtUploadingUrl != null && !this.TxtUploadingUrl.SequenceEqual(input.TxtUploadingUrl))) return false;

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
                if (this.AudioUploadingUrl != null) hashCode = hashCode * 59 + this.AudioUploadingUrl.GetHashCode();
                if (this.TxtUploadingUrl != null) hashCode = hashCode * 59 + this.TxtUploadingUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
