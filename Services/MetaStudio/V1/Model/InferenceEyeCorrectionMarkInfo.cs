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
    /// 分身数字人推理预处理眼神矫正信息。
    /// </summary>
    public class InferenceEyeCorrectionMarkInfo 
    {

        /// <summary>
        /// 选取推理数据预处理眼神矫正起始时间。格式：“HH:MM:SS.mmm”。
        /// </summary>
        [JsonProperty("eye_correction_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EyeCorrectionStartTime { get; set; }

        /// <summary>
        /// 选取推理数据预处理眼神矫正结束时间。格式：“HH:MM:SS.mmm”。
        /// </summary>
        [JsonProperty("eye_correction_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EyeCorrectionEndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InferenceEyeCorrectionMarkInfo {\n");
            sb.Append("  eyeCorrectionStartTime: ").Append(EyeCorrectionStartTime).Append("\n");
            sb.Append("  eyeCorrectionEndTime: ").Append(EyeCorrectionEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InferenceEyeCorrectionMarkInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InferenceEyeCorrectionMarkInfo input)
        {
            if (input == null) return false;
            if (this.EyeCorrectionStartTime != input.EyeCorrectionStartTime || (this.EyeCorrectionStartTime != null && !this.EyeCorrectionStartTime.Equals(input.EyeCorrectionStartTime))) return false;
            if (this.EyeCorrectionEndTime != input.EyeCorrectionEndTime || (this.EyeCorrectionEndTime != null && !this.EyeCorrectionEndTime.Equals(input.EyeCorrectionEndTime))) return false;

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
                if (this.EyeCorrectionStartTime != null) hashCode = hashCode * 59 + this.EyeCorrectionStartTime.GetHashCode();
                if (this.EyeCorrectionEndTime != null) hashCode = hashCode * 59 + this.EyeCorrectionEndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
