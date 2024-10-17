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
    public class TranscodeDetail 
    {

        /// <summary>
        /// 一进多出情况下部分转码失败的情况。 
        /// </summary>
        [JsonProperty("multitask_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<MultiTaskInfo> MultitaskInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("input_file", NullValueHandling = NullValueHandling.Ignore)]
        public SourceInfo InputFile { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscodeDetail {\n");
            sb.Append("  multitaskInfo: ").Append(MultitaskInfo).Append("\n");
            sb.Append("  inputFile: ").Append(InputFile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TranscodeDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TranscodeDetail input)
        {
            if (input == null) return false;
            if (this.MultitaskInfo != input.MultitaskInfo || (this.MultitaskInfo != null && input.MultitaskInfo != null && !this.MultitaskInfo.SequenceEqual(input.MultitaskInfo))) return false;
            if (this.InputFile != input.InputFile || (this.InputFile != null && !this.InputFile.Equals(input.InputFile))) return false;

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
                if (this.MultitaskInfo != null) hashCode = hashCode * 59 + this.MultitaskInfo.GetHashCode();
                if (this.InputFile != null) hashCode = hashCode * 59 + this.InputFile.GetHashCode();
                return hashCode;
            }
        }
    }
}
