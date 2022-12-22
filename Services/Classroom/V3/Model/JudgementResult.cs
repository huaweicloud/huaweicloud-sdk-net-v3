using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Classroom.V3.Model
{
    /// <summary>
    /// 任务执行结果
    /// </summary>
    public class JudgementResult 
    {

        /// <summary>
        /// 标准类型输出结果
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public string Output { get; set; }

        /// <summary>
        /// 文件形式输出的文件id，可根据文件id下载详情
        /// </summary>
        [JsonProperty("file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        /// <summary>
        /// 图片形式输出的图片id，可根据图片id下载详情
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 用例形式输出的用例总个数
        /// </summary>
        [JsonProperty("case_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaseCount { get; set; }

        /// <summary>
        /// 用例形式输出的已执行用例的个数
        /// </summary>
        [JsonProperty("executed_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecutedCount { get; set; }

        /// <summary>
        /// 用例形式输出的已执行用例的结果
        /// </summary>
        [JsonProperty("testcases", NullValueHandling = NullValueHandling.Ignore)]
        public List<JudgementCaseResult> Testcases { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JudgementResult {\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  fileId: ").Append(FileId).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  caseCount: ").Append(CaseCount).Append("\n");
            sb.Append("  executedCount: ").Append(ExecutedCount).Append("\n");
            sb.Append("  testcases: ").Append(Testcases).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JudgementResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JudgementResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.CaseCount == input.CaseCount ||
                    (this.CaseCount != null &&
                    this.CaseCount.Equals(input.CaseCount))
                ) && 
                (
                    this.ExecutedCount == input.ExecutedCount ||
                    (this.ExecutedCount != null &&
                    this.ExecutedCount.Equals(input.ExecutedCount))
                ) && 
                (
                    this.Testcases == input.Testcases ||
                    this.Testcases != null &&
                    input.Testcases != null &&
                    this.Testcases.SequenceEqual(input.Testcases)
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
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.ImageId != null)
                    hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.CaseCount != null)
                    hashCode = hashCode * 59 + this.CaseCount.GetHashCode();
                if (this.ExecutedCount != null)
                    hashCode = hashCode * 59 + this.ExecutedCount.GetHashCode();
                if (this.Testcases != null)
                    hashCode = hashCode * 59 + this.Testcases.GetHashCode();
                return hashCode;
            }
        }
    }
}
