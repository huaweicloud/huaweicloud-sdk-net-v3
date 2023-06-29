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
    public class Subtitle 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Input { get; set; }

        /// <summary>
        /// 多字幕文件地址。 
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<MulInputFileInfo> Inputs { get; set; }

        /// <summary>
        /// 字幕类型。取值如下：  - 0，表示不输出字幕 - 1，表示外部字幕文件嵌入视频流 - 2，表示输出WebVTT格式字幕 
        /// </summary>
        [JsonProperty("subtitle_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubtitleType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subtitle {\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  subtitleType: ").Append(SubtitleType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Subtitle);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Subtitle input)
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
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.SubtitleType == input.SubtitleType ||
                    (this.SubtitleType != null &&
                    this.SubtitleType.Equals(input.SubtitleType))
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
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.SubtitleType != null)
                    hashCode = hashCode * 59 + this.SubtitleType.GetHashCode();
                return hashCode;
            }
        }
    }
}
