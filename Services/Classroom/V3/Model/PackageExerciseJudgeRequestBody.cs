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
    /// 习题库里习题判题调用参数
    /// </summary>
    public class PackageExerciseJudgeRequestBody 
    {

        /// <summary>
        /// 判题结束后的回调url
        /// </summary>
        [JsonProperty("notify_url", NullValueHandling = NullValueHandling.Ignore)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 代码超时时间
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 结果返回类型
        /// </summary>
        [JsonProperty("output_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputType { get; set; }

        /// <summary>
        /// 习题作答（需Base64编码）
        /// </summary>
        [JsonProperty("code_answer", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeAnswer { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageExerciseJudgeRequestBody {\n");
            sb.Append("  notifyUrl: ").Append(NotifyUrl).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  outputType: ").Append(OutputType).Append("\n");
            sb.Append("  codeAnswer: ").Append(CodeAnswer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PackageExerciseJudgeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PackageExerciseJudgeRequestBody input)
        {
            if (input == null) return false;
            if (this.NotifyUrl != input.NotifyUrl || (this.NotifyUrl != null && !this.NotifyUrl.Equals(input.NotifyUrl))) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.OutputType != input.OutputType || (this.OutputType != null && !this.OutputType.Equals(input.OutputType))) return false;
            if (this.CodeAnswer != input.CodeAnswer || (this.CodeAnswer != null && !this.CodeAnswer.Equals(input.CodeAnswer))) return false;

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
                if (this.NotifyUrl != null) hashCode = hashCode * 59 + this.NotifyUrl.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.OutputType != null) hashCode = hashCode * 59 + this.OutputType.GetHashCode();
                if (this.CodeAnswer != null) hashCode = hashCode * 59 + this.CodeAnswer.GetHashCode();
                return hashCode;
            }
        }
    }
}
