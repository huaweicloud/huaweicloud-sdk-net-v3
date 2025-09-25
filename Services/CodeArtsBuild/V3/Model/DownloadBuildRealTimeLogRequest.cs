using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DownloadBuildRealTimeLogRequest 
    {

        /// <summary>
        /// 构建的任务ID； 编辑构建任务时，浏览器URL末尾的32位数字、字母组合的字符串。
        /// </summary>
        [SDKProperty("job_id", IsPath = true)]
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 构建任务的构建编号，从1开始，每次构建递增1
        /// </summary>
        [SDKProperty("build_no", IsPath = true)]
        [JsonProperty("build_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildNo { get; set; }

        /// <summary>
        /// **参数解释**： 起始偏移量，表示从此开始查询。 **约束限制**： 不涉及。 **取值范围**： 只能使用数字，大于等于0。
        /// </summary>
        [SDKProperty("start_offset", IsQuery = true)]
        [JsonProperty("start_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartOffset { get; set; }

        /// <summary>
        /// **参数解释**： 结束偏移量，表示查询到此结束。 **约束限制**： 不涉及。 **取值范围**： 只能使用数字，大于等于0。
        /// </summary>
        [SDKProperty("end_offset", IsQuery = true)]
        [JsonProperty("end_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndOffset { get; set; }

        /// <summary>
        /// **参数解释**： 排序方式。 **约束限制**： 不涉及。 **取值范围**： AES|DESC。
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public string Sort { get; set; }

        /// <summary>
        /// **参数解释**： 可控制返回内容长度，固定1000。 **约束限制**： 不涉及。 **取值范围**： 只能使用数字，大于等于0。 **默认取值**： 1000
        /// </summary>
        [SDKProperty("size", IsQuery = true)]
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadBuildRealTimeLogRequest {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  buildNo: ").Append(BuildNo).Append("\n");
            sb.Append("  startOffset: ").Append(StartOffset).Append("\n");
            sb.Append("  endOffset: ").Append(EndOffset).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadBuildRealTimeLogRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadBuildRealTimeLogRequest input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.BuildNo != input.BuildNo || (this.BuildNo != null && !this.BuildNo.Equals(input.BuildNo))) return false;
            if (this.StartOffset != input.StartOffset || (this.StartOffset != null && !this.StartOffset.Equals(input.StartOffset))) return false;
            if (this.EndOffset != input.EndOffset || (this.EndOffset != null && !this.EndOffset.Equals(input.EndOffset))) return false;
            if (this.Sort != input.Sort || (this.Sort != null && !this.Sort.Equals(input.Sort))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.BuildNo != null) hashCode = hashCode * 59 + this.BuildNo.GetHashCode();
                if (this.StartOffset != null) hashCode = hashCode * 59 + this.StartOffset.GetHashCode();
                if (this.EndOffset != null) hashCode = hashCode * 59 + this.EndOffset.GetHashCode();
                if (this.Sort != null) hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }
}
