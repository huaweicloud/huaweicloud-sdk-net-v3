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
    public class MpcMultiAudio 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Output { get; set; }

        /// <summary>
        /// 音频文件列表
        /// </summary>
        [JsonProperty("audio_files", NullValueHandling = NullValueHandling.Ignore)]
        public List<AudioFile> AudioFiles { get; set; }

        /// <summary>
        /// 输出文件名。 
        /// </summary>
        [JsonProperty("output_filename", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputFilename { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MpcMultiAudio {\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  audioFiles: ").Append(AudioFiles).Append("\n");
            sb.Append("  outputFilename: ").Append(OutputFilename).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MpcMultiAudio);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MpcMultiAudio input)
        {
            if (input == null) return false;
            if (this.Output != input.Output || (this.Output != null && !this.Output.Equals(input.Output))) return false;
            if (this.AudioFiles != input.AudioFiles || (this.AudioFiles != null && input.AudioFiles != null && !this.AudioFiles.SequenceEqual(input.AudioFiles))) return false;
            if (this.OutputFilename != input.OutputFilename || (this.OutputFilename != null && !this.OutputFilename.Equals(input.OutputFilename))) return false;

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
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.AudioFiles != null) hashCode = hashCode * 59 + this.AudioFiles.GetHashCode();
                if (this.OutputFilename != null) hashCode = hashCode * 59 + this.OutputFilename.GetHashCode();
                return hashCode;
            }
        }
    }
}
