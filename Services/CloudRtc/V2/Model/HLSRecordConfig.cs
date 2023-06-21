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
    public class HLSRecordConfig 
    {

        /// <summary>
        ///  周期录制时长。  取值范围：[60，43200]或者0，如果为0则整个流录制为一个文件。  单位：秒。 
        /// </summary>
        [JsonProperty("record_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordCycle { get; set; }

        /// <summary>
        /// 录制m3u8文件含路径和文件名的前缀  默认{app_id}/{record_format}/{stream}\\_{file_start_time}/{stream}\\_{file_start_time}  可自定义以下特殊变量： - {app_id}：应用id - {record_format}：录制格式 - {stream}：流名 - {file_start_time}：文件生成时间 
        /// </summary>
        [JsonProperty("record_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordPrefix { get; set; }

        /// <summary>
        ///  录制HLS时ts的切片时长，非必填。  取值范围：[2，60]，缺省为10。  单位：秒。 
        /// </summary>
        [JsonProperty("record_slice_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordSliceDuration { get; set; }

        /// <summary>
        /// 录制HLS文件拼接时长，如果流中断超过该时间，则生成新文件。  取值范围：[-1，300]，缺省为0。  单位：秒。  - 如果为0表示流中断就生成新文件。 - 如果为-1则表示流中断恢复后追加到原来的文件中（相隔不超过30天）。 
        /// </summary>
        [JsonProperty("record_max_duration_to_merge_file", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordMaxDurationToMergeFile { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HLSRecordConfig {\n");
            sb.Append("  recordCycle: ").Append(RecordCycle).Append("\n");
            sb.Append("  recordPrefix: ").Append(RecordPrefix).Append("\n");
            sb.Append("  recordSliceDuration: ").Append(RecordSliceDuration).Append("\n");
            sb.Append("  recordMaxDurationToMergeFile: ").Append(RecordMaxDurationToMergeFile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HLSRecordConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HLSRecordConfig input)
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
                    this.RecordSliceDuration == input.RecordSliceDuration ||
                    (this.RecordSliceDuration != null &&
                    this.RecordSliceDuration.Equals(input.RecordSliceDuration))
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
                if (this.RecordSliceDuration != null)
                    hashCode = hashCode * 59 + this.RecordSliceDuration.GetHashCode();
                if (this.RecordMaxDurationToMergeFile != null)
                    hashCode = hashCode * 59 + this.RecordMaxDurationToMergeFile.GetHashCode();
                return hashCode;
            }
        }
    }
}
