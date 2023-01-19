using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class RecognizeFlashAsrResponse : SdkResponse
    {

        /// <summary>
        /// 服务内部的令牌，可用于在日志中追溯具体调用流程
        /// </summary>
        [JsonProperty("trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }

        /// <summary>
        /// 音频时长
        /// </summary>
        [JsonProperty("audio_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? AudioDuration { get; set; }

        /// <summary>
        /// 识别结果
        /// </summary>
        [JsonProperty("flash_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlashResult> FlashResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecognizeFlashAsrResponse {\n");
            sb.Append("  traceId: ").Append(TraceId).Append("\n");
            sb.Append("  audioDuration: ").Append(AudioDuration).Append("\n");
            sb.Append("  flashResult: ").Append(FlashResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecognizeFlashAsrResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecognizeFlashAsrResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TraceId == input.TraceId ||
                    (this.TraceId != null &&
                    this.TraceId.Equals(input.TraceId))
                ) && 
                (
                    this.AudioDuration == input.AudioDuration ||
                    (this.AudioDuration != null &&
                    this.AudioDuration.Equals(input.AudioDuration))
                ) && 
                (
                    this.FlashResult == input.FlashResult ||
                    this.FlashResult != null &&
                    input.FlashResult != null &&
                    this.FlashResult.SequenceEqual(input.FlashResult)
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
                if (this.TraceId != null)
                    hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                if (this.AudioDuration != null)
                    hashCode = hashCode * 59 + this.AudioDuration.GetHashCode();
                if (this.FlashResult != null)
                    hashCode = hashCode * 59 + this.FlashResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
