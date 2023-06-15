using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MP4RecordConfig 
    {

        /// <summary>
        /// 单位为秒，周期录制时长，最小1分钟，最大12小时。如果为0则整个流录制一个文件。
        /// </summary>
        [JsonProperty("record_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordCycle { get; set; }

        /// <summary>
        /// 录制文件含路径和文件名的前缀， 默认Record/{publish_domain}/{app}/{record_type}/{record_format}/{stream}_{file_start_time}/{file_start_time}
        /// </summary>
        [JsonProperty("record_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordPrefix { get; set; }

        /// <summary>
        /// 录制mp4拼接时长，如果流中断超过该时间，则生成新文件。单位秒。如果为0表示流中断就生成新文件。默认为0。
        /// </summary>
        [JsonProperty("record_max_duration_to_merge_file", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordMaxDurationToMergeFile { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MP4RecordConfig {\n");
            sb.Append("  recordCycle: ").Append(RecordCycle).Append("\n");
            sb.Append("  recordPrefix: ").Append(RecordPrefix).Append("\n");
            sb.Append("  recordMaxDurationToMergeFile: ").Append(RecordMaxDurationToMergeFile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MP4RecordConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MP4RecordConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecordCycle == input.RecordCycle ||
                    (this.RecordCycle != null &&
                    this.RecordCycle.Equals(input.RecordCycle))
                ) && 
                (
                    this.RecordPrefix == input.RecordPrefix ||
                    (this.RecordPrefix != null &&
                    this.RecordPrefix.Equals(input.RecordPrefix))
                ) && 
                (
                    this.RecordMaxDurationToMergeFile == input.RecordMaxDurationToMergeFile ||
                    (this.RecordMaxDurationToMergeFile != null &&
                    this.RecordMaxDurationToMergeFile.Equals(input.RecordMaxDurationToMergeFile))
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
                if (this.RecordCycle != null)
                    hashCode = hashCode * 59 + this.RecordCycle.GetHashCode();
                if (this.RecordPrefix != null)
                    hashCode = hashCode * 59 + this.RecordPrefix.GetHashCode();
                if (this.RecordMaxDurationToMergeFile != null)
                    hashCode = hashCode * 59 + this.RecordMaxDurationToMergeFile.GetHashCode();
                return hashCode;
            }
        }
    }
}
