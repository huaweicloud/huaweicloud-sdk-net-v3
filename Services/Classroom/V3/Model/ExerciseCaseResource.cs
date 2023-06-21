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
    /// 测试用例信息
    /// </summary>
    public class ExerciseCaseResource 
    {

        /// <summary>
        /// 测试用例存储id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 资源聚合id
        /// </summary>
        [JsonProperty("polymeric_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolymericResourceId { get; set; }

        /// <summary>
        /// 用例输入
        /// </summary>
        [JsonProperty("input_file", NullValueHandling = NullValueHandling.Ignore)]
        public string InputFile { get; set; }

        /// <summary>
        /// 用例输出
        /// </summary>
        [JsonProperty("output_file", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputFile { get; set; }

        /// <summary>
        /// 用例顺序位置
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public int? Index { get; set; }

        /// <summary>
        /// 用例类型
        /// </summary>
        [JsonProperty("input_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InputType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExerciseCaseResource {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  polymericResourceId: ").Append(PolymericResourceId).Append("\n");
            sb.Append("  inputFile: ").Append(InputFile).Append("\n");
            sb.Append("  outputFile: ").Append(OutputFile).Append("\n");
            sb.Append("  index: ").Append(Index).Append("\n");
            sb.Append("  inputType: ").Append(InputType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExerciseCaseResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExerciseCaseResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PolymericResourceId == input.PolymericResourceId ||
                    (this.PolymericResourceId != null &&
                    this.PolymericResourceId.Equals(input.PolymericResourceId))
                ) && 
                (
                    this.InputFile == input.InputFile ||
                    (this.InputFile != null &&
                    this.InputFile.Equals(input.InputFile))
                ) && 
                (
                    this.OutputFile == input.OutputFile ||
                    (this.OutputFile != null &&
                    this.OutputFile.Equals(input.OutputFile))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.InputType == input.InputType ||
                    (this.InputType != null &&
                    this.InputType.Equals(input.InputType))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PolymericResourceId != null)
                    hashCode = hashCode * 59 + this.PolymericResourceId.GetHashCode();
                if (this.InputFile != null)
                    hashCode = hashCode * 59 + this.InputFile.GetHashCode();
                if (this.OutputFile != null)
                    hashCode = hashCode * 59 + this.OutputFile.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.InputType != null)
                    hashCode = hashCode * 59 + this.InputType.GetHashCode();
                return hashCode;
            }
        }
    }
}
