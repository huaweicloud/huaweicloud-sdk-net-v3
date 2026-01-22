using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateTranscodingReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Output { get; set; }

        /// <summary>
        /// 转码模板ID，没带av_parameter参数时，必须带该参数，数组，每一路转码输出对应一个转码配置模板ID，最多支持9个模板ID。  多个转码模板中如下参数可变，其他都必须一致：  视频bitrate，height，width。 
        /// </summary>
        [JsonProperty("trans_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> TransTemplateId { get; set; }

        /// <summary>
        /// 转码模板数组 
        /// </summary>
        [JsonProperty("trans_template_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TransIdTemplate> TransTemplateList { get; set; }

        /// <summary>
        /// 转码参数。  若同时设置“trans_template_id”和此参数，则优先使用此参数进行转码，不带trans_template_id时，该参数必选。 
        /// </summary>
        [JsonProperty("av_parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<AvParameters> AvParameters { get; set; }

        /// <summary>
        /// 主索引定制参数。 
        /// </summary>
        [JsonProperty("additional_manifests", NullValueHandling = NullValueHandling.Ignore)]
        public List<AdditionalManifests> AdditionalManifests { get; set; }

        /// <summary>
        /// 输出文件名称，每一路转码输出对应一个名称，需要与转码模板ID数组的顺序对应。  - 若设置该参数，表示输出文件按该参数命名。 - 若不设置该参数，表示输出文件按默认方式命名。 
        /// </summary>
        [JsonProperty("output_filenames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OutputFilenames { get; set; }

        /// <summary>
        /// 用户自定义数据，该字段可在查询接口或消息通知中按原内容透传给用户。 
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// 图片水印参数，数组，最多支持20个成员。 
        /// </summary>
        [JsonProperty("watermarks", NullValueHandling = NullValueHandling.Ignore)]
        public List<WatermarkRequest> Watermarks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Thumbnail Thumbnail { get; set; }

        /// <summary>
        /// 多截图任务，数组，最多支持20个成员。 
        /// </summary>
        [JsonProperty("thumbnails", NullValueHandling = NullValueHandling.Ignore)]
        public List<Thumbnail> Thumbnails { get; set; }

        /// <summary>
        /// 雪碧图参数，数组，最多支持20个成员。 
        /// </summary>
        [JsonProperty("image_sprites", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageSprite> ImageSprites { get; set; }

        /// <summary>
        /// 任务优先级，取值如下： - 9代表高优先级。 - 6代表中优先级，默认为6。  暂时只支持6和9。 
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subtitle", NullValueHandling = NullValueHandling.Ignore)]
        public Subtitle Subtitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("encryption", NullValueHandling = NullValueHandling.Ignore)]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("crop", NullValueHandling = NullValueHandling.Ignore)]
        public Crop Crop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio_track", NullValueHandling = NullValueHandling.Ignore)]
        public AudioTrack AudioTrack { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("multi_audio", NullValueHandling = NullValueHandling.Ignore)]
        public MultiAudio MultiAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_process", NullValueHandling = NullValueHandling.Ignore)]
        public VideoProcess VideoProcess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio_process", NullValueHandling = NullValueHandling.Ignore)]
        public AudioProcess AudioProcess { get; set; }

        /// <summary>
        /// metadata设置，默认只支持AIGC 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public List<FileMetaData> Metadata { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTranscodingReq {\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  transTemplateId: ").Append(TransTemplateId).Append("\n");
            sb.Append("  transTemplateList: ").Append(TransTemplateList).Append("\n");
            sb.Append("  avParameters: ").Append(AvParameters).Append("\n");
            sb.Append("  additionalManifests: ").Append(AdditionalManifests).Append("\n");
            sb.Append("  outputFilenames: ").Append(OutputFilenames).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  watermarks: ").Append(Watermarks).Append("\n");
            sb.Append("  thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  thumbnails: ").Append(Thumbnails).Append("\n");
            sb.Append("  imageSprites: ").Append(ImageSprites).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  encryption: ").Append(Encryption).Append("\n");
            sb.Append("  crop: ").Append(Crop).Append("\n");
            sb.Append("  audioTrack: ").Append(AudioTrack).Append("\n");
            sb.Append("  multiAudio: ").Append(MultiAudio).Append("\n");
            sb.Append("  videoProcess: ").Append(VideoProcess).Append("\n");
            sb.Append("  audioProcess: ").Append(AudioProcess).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTranscodingReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTranscodingReq input)
        {
            if (input == null) return false;
            if (this.Input != input.Input || (this.Input != null && !this.Input.Equals(input.Input))) return false;
            if (this.Output != input.Output || (this.Output != null && !this.Output.Equals(input.Output))) return false;
            if (this.TransTemplateId != input.TransTemplateId || (this.TransTemplateId != null && input.TransTemplateId != null && !this.TransTemplateId.SequenceEqual(input.TransTemplateId))) return false;
            if (this.TransTemplateList != input.TransTemplateList || (this.TransTemplateList != null && input.TransTemplateList != null && !this.TransTemplateList.SequenceEqual(input.TransTemplateList))) return false;
            if (this.AvParameters != input.AvParameters || (this.AvParameters != null && input.AvParameters != null && !this.AvParameters.SequenceEqual(input.AvParameters))) return false;
            if (this.AdditionalManifests != input.AdditionalManifests || (this.AdditionalManifests != null && input.AdditionalManifests != null && !this.AdditionalManifests.SequenceEqual(input.AdditionalManifests))) return false;
            if (this.OutputFilenames != input.OutputFilenames || (this.OutputFilenames != null && input.OutputFilenames != null && !this.OutputFilenames.SequenceEqual(input.OutputFilenames))) return false;
            if (this.UserData != input.UserData || (this.UserData != null && !this.UserData.Equals(input.UserData))) return false;
            if (this.Watermarks != input.Watermarks || (this.Watermarks != null && input.Watermarks != null && !this.Watermarks.SequenceEqual(input.Watermarks))) return false;
            if (this.Thumbnail != input.Thumbnail || (this.Thumbnail != null && !this.Thumbnail.Equals(input.Thumbnail))) return false;
            if (this.Thumbnails != input.Thumbnails || (this.Thumbnails != null && input.Thumbnails != null && !this.Thumbnails.SequenceEqual(input.Thumbnails))) return false;
            if (this.ImageSprites != input.ImageSprites || (this.ImageSprites != null && input.ImageSprites != null && !this.ImageSprites.SequenceEqual(input.ImageSprites))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.Subtitle != input.Subtitle || (this.Subtitle != null && !this.Subtitle.Equals(input.Subtitle))) return false;
            if (this.Encryption != input.Encryption || (this.Encryption != null && !this.Encryption.Equals(input.Encryption))) return false;
            if (this.Crop != input.Crop || (this.Crop != null && !this.Crop.Equals(input.Crop))) return false;
            if (this.AudioTrack != input.AudioTrack || (this.AudioTrack != null && !this.AudioTrack.Equals(input.AudioTrack))) return false;
            if (this.MultiAudio != input.MultiAudio || (this.MultiAudio != null && !this.MultiAudio.Equals(input.MultiAudio))) return false;
            if (this.VideoProcess != input.VideoProcess || (this.VideoProcess != null && !this.VideoProcess.Equals(input.VideoProcess))) return false;
            if (this.AudioProcess != input.AudioProcess || (this.AudioProcess != null && !this.AudioProcess.Equals(input.AudioProcess))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && input.Metadata != null && !this.Metadata.SequenceEqual(input.Metadata))) return false;

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
                if (this.Input != null) hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.TransTemplateId != null) hashCode = hashCode * 59 + this.TransTemplateId.GetHashCode();
                if (this.TransTemplateList != null) hashCode = hashCode * 59 + this.TransTemplateList.GetHashCode();
                if (this.AvParameters != null) hashCode = hashCode * 59 + this.AvParameters.GetHashCode();
                if (this.AdditionalManifests != null) hashCode = hashCode * 59 + this.AdditionalManifests.GetHashCode();
                if (this.OutputFilenames != null) hashCode = hashCode * 59 + this.OutputFilenames.GetHashCode();
                if (this.UserData != null) hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.Watermarks != null) hashCode = hashCode * 59 + this.Watermarks.GetHashCode();
                if (this.Thumbnail != null) hashCode = hashCode * 59 + this.Thumbnail.GetHashCode();
                if (this.Thumbnails != null) hashCode = hashCode * 59 + this.Thumbnails.GetHashCode();
                if (this.ImageSprites != null) hashCode = hashCode * 59 + this.ImageSprites.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Subtitle != null) hashCode = hashCode * 59 + this.Subtitle.GetHashCode();
                if (this.Encryption != null) hashCode = hashCode * 59 + this.Encryption.GetHashCode();
                if (this.Crop != null) hashCode = hashCode * 59 + this.Crop.GetHashCode();
                if (this.AudioTrack != null) hashCode = hashCode * 59 + this.AudioTrack.GetHashCode();
                if (this.MultiAudio != null) hashCode = hashCode * 59 + this.MultiAudio.GetHashCode();
                if (this.VideoProcess != null) hashCode = hashCode * 59 + this.VideoProcess.GetHashCode();
                if (this.AudioProcess != null) hashCode = hashCode * 59 + this.AudioProcess.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
