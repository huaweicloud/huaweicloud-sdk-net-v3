using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 转码生成文件信息。  &gt; 仅当转码成功后才能查询到此信息，未转码、正在转码以及转码失败时，无此字段信息。
    /// </summary>
    public class TranscodeInfo 
    {

        /// <summary>
        /// 转码模板组名称。
        /// </summary>
        [JsonProperty("template_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateGroupName { get; set; }

        /// <summary>
        /// 转码输出数组。 - HLS或DASH格式：此数组的成员个数为n+1，n为转码输出路数。 - MP4格式：此数组的成员个数为n，n为转码输出路数。
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public List<Output> Output { get; set; }

        /// <summary>
        /// 执行情况描述。
        /// </summary>
        [JsonProperty("exec_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecDesc { get; set; }

        /// <summary>
        /// 转码状态。  取值如下： - UN_TRANSCODE：未转码 - WAITING_TRANSCODE：待转码 - TRANSCODING：转码中 - TRANSCODE_SUCCEED：转码成功 - TRANSCODE_FAILED：转码失败
        /// </summary>
        [JsonProperty("transcode_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TranscodeStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscodeInfo {\n");
            sb.Append("  templateGroupName: ").Append(TemplateGroupName).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  execDesc: ").Append(ExecDesc).Append("\n");
            sb.Append("  transcodeStatus: ").Append(TranscodeStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TranscodeInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TranscodeInfo input)
        {
            if (input == null) return false;
            if (this.TemplateGroupName != input.TemplateGroupName || (this.TemplateGroupName != null && !this.TemplateGroupName.Equals(input.TemplateGroupName))) return false;
            if (this.Output != input.Output || (this.Output != null && input.Output != null && !this.Output.SequenceEqual(input.Output))) return false;
            if (this.ExecDesc != input.ExecDesc || (this.ExecDesc != null && !this.ExecDesc.Equals(input.ExecDesc))) return false;
            if (this.TranscodeStatus != input.TranscodeStatus || (this.TranscodeStatus != null && !this.TranscodeStatus.Equals(input.TranscodeStatus))) return false;

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
                if (this.TemplateGroupName != null) hashCode = hashCode * 59 + this.TemplateGroupName.GetHashCode();
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.ExecDesc != null) hashCode = hashCode * 59 + this.ExecDesc.GetHashCode();
                if (this.TranscodeStatus != null) hashCode = hashCode * 59 + this.TranscodeStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
