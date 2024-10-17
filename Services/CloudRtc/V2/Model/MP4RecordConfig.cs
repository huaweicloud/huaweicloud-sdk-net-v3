using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MP4RecordConfig 
    {

        /// <summary>
        ///  周期录制时长。  取值范围：[60，10800]。  单位：秒。 
        /// </summary>
        [JsonProperty("record_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordCycle { get; set; }

        /// <summary>
        /// 录制文件含路径和文件名的前缀。  默认{app_id}/{record_format}/{stream}\\_{file_start_time}/{stream}\\_{file_start_time}  可自定义以下特殊变量： - {app_id}：应用id - {record_format}：录制格式 - {stream}：流名 - {file_start_time}：文件生成时间 
        /// </summary>
        [JsonProperty("record_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordPrefix { get; set; }

        /// <summary>
        /// 录制MP4拼接时长，如果流中断超过该时间，则生成新文件。  取值范围：[0，300]，缺省为0。  单位：秒。  如果为0表示流中断就生成新文件。 
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
            if (input == null) return false;
            if (this.RecordCycle != input.RecordCycle || (this.RecordCycle != null && !this.RecordCycle.Equals(input.RecordCycle))) return false;
            if (this.RecordPrefix != input.RecordPrefix || (this.RecordPrefix != null && !this.RecordPrefix.Equals(input.RecordPrefix))) return false;
            if (this.RecordMaxDurationToMergeFile != input.RecordMaxDurationToMergeFile || (this.RecordMaxDurationToMergeFile != null && !this.RecordMaxDurationToMergeFile.Equals(input.RecordMaxDurationToMergeFile))) return false;

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
                if (this.RecordCycle != null) hashCode = hashCode * 59 + this.RecordCycle.GetHashCode();
                if (this.RecordPrefix != null) hashCode = hashCode * 59 + this.RecordPrefix.GetHashCode();
                if (this.RecordMaxDurationToMergeFile != null) hashCode = hashCode * 59 + this.RecordMaxDurationToMergeFile.GetHashCode();
                return hashCode;
            }
        }
    }
}
