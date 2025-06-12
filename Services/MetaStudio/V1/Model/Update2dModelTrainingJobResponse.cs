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
    /// Response Object
    /// </summary>
    public class Update2dModelTrainingJobResponse : SdkResponse
    {

        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 分身数字人训练视频上传URL。该url在文件上传成功后失效，只能上传一次。注意：视频必须是1080p或者4K分辨率（横、竖屏皆可）的mp4格式，视频长度须大于等于3分钟且小于等于10分钟，否则审核会不通过。 &gt; 通过该地址上传时，需设置content-type为application/octet-stream
        /// </summary>
        [JsonProperty("training_video_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TrainingVideoUploadUrl { get; set; }

        /// <summary>
        /// 分身数字人训练视频上传URL。该url在文件上传成功后失效，只能上传一次。注意：视频必须是1080p或者4K分辨率（横、竖屏皆可）的mp4格式，视频长度须大于等于3分钟且小于等于10分钟，否则审核会不通过。 &gt; 通过该地址上传时，需设置content-type为application/octet-stream
        /// </summary>
        [JsonProperty("action_video_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ActionVideoUploadUrl { get; set; }

        /// <summary>
        /// 音频数据训练上传URL。该url在文件上传成功后失效，只能上传一次 &gt; 通过该地址上传时，需设置content-type为application/zip。
        /// </summary>
        [JsonProperty("audio_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioUploadUrl { get; set; }

        /// <summary>
        /// 模型封面上传URL。该URL在文件上传成功后失效，只能上传一次。 &gt; 通过该地址上传时，需设置content-type为application/octet-stream
        /// </summary>
        [JsonProperty("cover_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverUploadUrl { get; set; }

        /// <summary>
        /// 身份证正面照片上传URL。该URL在文件上传成功后失效，只能上传一次。注意：非NA用户必须上传，否则审核会不通过。 &gt; 通过该地址上传时，需设置content-type为application/octet-stream
        /// </summary>
        [JsonProperty("id_card_image1_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IdCardImage1UploadUrl { get; set; }

        /// <summary>
        /// 身份证反面照片上传URL。该URL在文件上传成功后失效，只能上传一次。注意：非NA用户必须上传，否则审核会不通过。 &gt; 通过该地址上传时，需设置content-type为application/octet-stream
        /// </summary>
        [JsonProperty("id_card_image2_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IdCardImage2UploadUrl { get; set; }

        /// <summary>
        /// 授权书上传URL。该URL在文件上传成功后失效，只能上传一次。注意：非NA用户必须上传，否则审核会不通过。 &gt; 通过该地址上传时，需设置content-type为application/octet-stream
        /// </summary>
        [JsonProperty("grant_file_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GrantFileUploadUrl { get; set; }

        /// <summary>
        /// 美白前图片上传url。 &gt; 通过该地址上传时，需设置content-type为application/octet-stream
        /// </summary>
        [JsonProperty("pre_beauty_image_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PreBeautyImageUploadUrl { get; set; }

        /// <summary>
        /// 美白后图片上传url。 &gt; 通过该地址上传时，需设置content-type为application/octet-stream
        /// </summary>
        [JsonProperty("post_beauty_image_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PostBeautyImageUploadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Update2dModelTrainingJobResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  trainingVideoUploadUrl: ").Append(TrainingVideoUploadUrl).Append("\n");
            sb.Append("  actionVideoUploadUrl: ").Append(ActionVideoUploadUrl).Append("\n");
            sb.Append("  audioUploadUrl: ").Append(AudioUploadUrl).Append("\n");
            sb.Append("  coverUploadUrl: ").Append(CoverUploadUrl).Append("\n");
            sb.Append("  idCardImage1UploadUrl: ").Append(IdCardImage1UploadUrl).Append("\n");
            sb.Append("  idCardImage2UploadUrl: ").Append(IdCardImage2UploadUrl).Append("\n");
            sb.Append("  grantFileUploadUrl: ").Append(GrantFileUploadUrl).Append("\n");
            sb.Append("  preBeautyImageUploadUrl: ").Append(PreBeautyImageUploadUrl).Append("\n");
            sb.Append("  postBeautyImageUploadUrl: ").Append(PostBeautyImageUploadUrl).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Update2dModelTrainingJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Update2dModelTrainingJobResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.TrainingVideoUploadUrl != input.TrainingVideoUploadUrl || (this.TrainingVideoUploadUrl != null && input.TrainingVideoUploadUrl != null && !this.TrainingVideoUploadUrl.SequenceEqual(input.TrainingVideoUploadUrl))) return false;
            if (this.ActionVideoUploadUrl != input.ActionVideoUploadUrl || (this.ActionVideoUploadUrl != null && input.ActionVideoUploadUrl != null && !this.ActionVideoUploadUrl.SequenceEqual(input.ActionVideoUploadUrl))) return false;
            if (this.AudioUploadUrl != input.AudioUploadUrl || (this.AudioUploadUrl != null && !this.AudioUploadUrl.Equals(input.AudioUploadUrl))) return false;
            if (this.CoverUploadUrl != input.CoverUploadUrl || (this.CoverUploadUrl != null && !this.CoverUploadUrl.Equals(input.CoverUploadUrl))) return false;
            if (this.IdCardImage1UploadUrl != input.IdCardImage1UploadUrl || (this.IdCardImage1UploadUrl != null && !this.IdCardImage1UploadUrl.Equals(input.IdCardImage1UploadUrl))) return false;
            if (this.IdCardImage2UploadUrl != input.IdCardImage2UploadUrl || (this.IdCardImage2UploadUrl != null && !this.IdCardImage2UploadUrl.Equals(input.IdCardImage2UploadUrl))) return false;
            if (this.GrantFileUploadUrl != input.GrantFileUploadUrl || (this.GrantFileUploadUrl != null && !this.GrantFileUploadUrl.Equals(input.GrantFileUploadUrl))) return false;
            if (this.PreBeautyImageUploadUrl != input.PreBeautyImageUploadUrl || (this.PreBeautyImageUploadUrl != null && !this.PreBeautyImageUploadUrl.Equals(input.PreBeautyImageUploadUrl))) return false;
            if (this.PostBeautyImageUploadUrl != input.PostBeautyImageUploadUrl || (this.PostBeautyImageUploadUrl != null && !this.PostBeautyImageUploadUrl.Equals(input.PostBeautyImageUploadUrl))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.TrainingVideoUploadUrl != null) hashCode = hashCode * 59 + this.TrainingVideoUploadUrl.GetHashCode();
                if (this.ActionVideoUploadUrl != null) hashCode = hashCode * 59 + this.ActionVideoUploadUrl.GetHashCode();
                if (this.AudioUploadUrl != null) hashCode = hashCode * 59 + this.AudioUploadUrl.GetHashCode();
                if (this.CoverUploadUrl != null) hashCode = hashCode * 59 + this.CoverUploadUrl.GetHashCode();
                if (this.IdCardImage1UploadUrl != null) hashCode = hashCode * 59 + this.IdCardImage1UploadUrl.GetHashCode();
                if (this.IdCardImage2UploadUrl != null) hashCode = hashCode * 59 + this.IdCardImage2UploadUrl.GetHashCode();
                if (this.GrantFileUploadUrl != null) hashCode = hashCode * 59 + this.GrantFileUploadUrl.GetHashCode();
                if (this.PreBeautyImageUploadUrl != null) hashCode = hashCode * 59 + this.PreBeautyImageUploadUrl.GetHashCode();
                if (this.PostBeautyImageUploadUrl != null) hashCode = hashCode * 59 + this.PostBeautyImageUploadUrl.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
