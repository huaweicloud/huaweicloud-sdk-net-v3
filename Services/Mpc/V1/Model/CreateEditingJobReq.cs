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
    /// 创建剪辑任务
    /// </summary>
    public class CreateEditingJobReq 
    {

        /// <summary>
        /// 剪辑任务类型。取值如下：\&quot;CLIP\&quot;,\&quot;CONCAT\&quot;,\&quot;CONCATS\&quot;,\&quot;MIX\&quot;。
        /// </summary>
        [JsonProperty("edit_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EditType { get; set; }

        /// <summary>
        /// 剪切信息
        /// </summary>
        [JsonProperty("clips", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClipInfo> Clips { get; set; }

        /// <summary>
        /// 多拼接任务信息，支持多个拼接输出，与concat参数只能二选一。 
        /// </summary>
        [JsonProperty("concats", NullValueHandling = NullValueHandling.Ignore)]
        public List<MultiConcatInfo> Concats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("concat", NullValueHandling = NullValueHandling.Ignore)]
        public ConcatInfo Concat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mix", NullValueHandling = NullValueHandling.Ignore)]
        public MixInfo Mix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output_setting", NullValueHandling = NullValueHandling.Ignore)]
        public OutputSetting OutputSetting { get; set; }

        /// <summary>
        /// 水印信息。
        /// </summary>
        [JsonProperty("image_watermark_settings", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageWatermarkSetting> ImageWatermarkSettings { get; set; }

        /// <summary>
        /// 媒体处理配置，当edit_type为空时该参数生效。会根据该参数配置，对input参数指定的源文件进行处理 
        /// </summary>
        [JsonProperty("edit_settings", NullValueHandling = NullValueHandling.Ignore)]
        public List<EditSetting> EditSettings { get; set; }

        /// <summary>
        /// 用户自定义数据。
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEditingJobReq {\n");
            sb.Append("  editType: ").Append(EditType).Append("\n");
            sb.Append("  clips: ").Append(Clips).Append("\n");
            sb.Append("  concats: ").Append(Concats).Append("\n");
            sb.Append("  concat: ").Append(Concat).Append("\n");
            sb.Append("  mix: ").Append(Mix).Append("\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  outputSetting: ").Append(OutputSetting).Append("\n");
            sb.Append("  imageWatermarkSettings: ").Append(ImageWatermarkSettings).Append("\n");
            sb.Append("  editSettings: ").Append(EditSettings).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateEditingJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateEditingJobReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EditType == input.EditType ||
                    this.EditType != null &&
                    input.EditType != null &&
                    this.EditType.SequenceEqual(input.EditType)
                ) && 
                (
                    this.Clips == input.Clips ||
                    this.Clips != null &&
                    input.Clips != null &&
                    this.Clips.SequenceEqual(input.Clips)
                ) && 
                (
                    this.Concats == input.Concats ||
                    this.Concats != null &&
                    input.Concats != null &&
                    this.Concats.SequenceEqual(input.Concats)
                ) && 
                (
                    this.Concat == input.Concat ||
                    (this.Concat != null &&
                    this.Concat.Equals(input.Concat))
                ) && 
                (
                    this.Mix == input.Mix ||
                    (this.Mix != null &&
                    this.Mix.Equals(input.Mix))
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.OutputSetting == input.OutputSetting ||
                    (this.OutputSetting != null &&
                    this.OutputSetting.Equals(input.OutputSetting))
                ) && 
                (
                    this.ImageWatermarkSettings == input.ImageWatermarkSettings ||
                    this.ImageWatermarkSettings != null &&
                    input.ImageWatermarkSettings != null &&
                    this.ImageWatermarkSettings.SequenceEqual(input.ImageWatermarkSettings)
                ) && 
                (
                    this.EditSettings == input.EditSettings ||
                    this.EditSettings != null &&
                    input.EditSettings != null &&
                    this.EditSettings.SequenceEqual(input.EditSettings)
                ) && 
                (
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
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
                if (this.EditType != null)
                    hashCode = hashCode * 59 + this.EditType.GetHashCode();
                if (this.Clips != null)
                    hashCode = hashCode * 59 + this.Clips.GetHashCode();
                if (this.Concats != null)
                    hashCode = hashCode * 59 + this.Concats.GetHashCode();
                if (this.Concat != null)
                    hashCode = hashCode * 59 + this.Concat.GetHashCode();
                if (this.Mix != null)
                    hashCode = hashCode * 59 + this.Mix.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.OutputSetting != null)
                    hashCode = hashCode * 59 + this.OutputSetting.GetHashCode();
                if (this.ImageWatermarkSettings != null)
                    hashCode = hashCode * 59 + this.ImageWatermarkSettings.GetHashCode();
                if (this.EditSettings != null)
                    hashCode = hashCode * 59 + this.EditSettings.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                return hashCode;
            }
        }
    }
}
