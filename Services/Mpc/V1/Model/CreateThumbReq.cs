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
    public class CreateThumbReq 
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
        /// 用户自定义数据。 
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thumbnail_para", NullValueHandling = NullValueHandling.Ignore)]
        public ThumbnailPara ThumbnailPara { get; set; }

        /// <summary>
        /// 是否压缩抽帧图片生成tar包。  取值如下： - 0：压缩。 - 1：不压缩 默认值：1 
        /// </summary>
        [JsonProperty("tar", NullValueHandling = NullValueHandling.Ignore)]
        public int? Tar { get; set; }

        /// <summary>
        /// 是否同步处理，同步处理是指不下载全部文件，快速定位到截图位置进行截图。  取值如下： - 0：排队处理。 - 1：同步处理，暂只支持按时间点截单张图。 默认值：0 
        /// </summary>
        [JsonProperty("sync", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sync { get; set; }

        /// <summary>
        /// 是否使用原始输出目录。  取值如下： - 0：不使用原始输出目录，下发的输出目录后面追加随机目录，防止截图文件outputUri相同被覆盖。 - 1：使用原始输出目录。 默认值：0 
        /// </summary>
        [JsonProperty("original_dir", NullValueHandling = NullValueHandling.Ignore)]
        public int? OriginalDir { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateThumbReq {\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  thumbnailPara: ").Append(ThumbnailPara).Append("\n");
            sb.Append("  tar: ").Append(Tar).Append("\n");
            sb.Append("  sync: ").Append(Sync).Append("\n");
            sb.Append("  originalDir: ").Append(OriginalDir).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateThumbReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateThumbReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
                ) && 
                (
                    this.ThumbnailPara == input.ThumbnailPara ||
                    (this.ThumbnailPara != null &&
                    this.ThumbnailPara.Equals(input.ThumbnailPara))
                ) && 
                (
                    this.Tar == input.Tar ||
                    (this.Tar != null &&
                    this.Tar.Equals(input.Tar))
                ) && 
                (
                    this.Sync == input.Sync ||
                    (this.Sync != null &&
                    this.Sync.Equals(input.Sync))
                ) && 
                (
                    this.OriginalDir == input.OriginalDir ||
                    (this.OriginalDir != null &&
                    this.OriginalDir.Equals(input.OriginalDir))
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
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.ThumbnailPara != null)
                    hashCode = hashCode * 59 + this.ThumbnailPara.GetHashCode();
                if (this.Tar != null)
                    hashCode = hashCode * 59 + this.Tar.GetHashCode();
                if (this.Sync != null)
                    hashCode = hashCode * 59 + this.Sync.GetHashCode();
                if (this.OriginalDir != null)
                    hashCode = hashCode * 59 + this.OriginalDir.GetHashCode();
                return hashCode;
            }
        }
    }
}
