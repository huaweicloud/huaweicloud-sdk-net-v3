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
    /// 
    /// </summary>
    public class TranscriberResult 
    {

        /// <summary>
        /// 识别结果文本。
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("analysis_info", NullValueHandling = NullValueHandling.Ignore)]
        public AnalysisInfoResult AnalysisInfo { get; set; }

        /// <summary>
        /// 分词输出列表
        /// </summary>
        [JsonProperty("word_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<WordInfo> WordInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriberResult {\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("  analysisInfo: ").Append(AnalysisInfo).Append("\n");
            sb.Append("  wordInfo: ").Append(WordInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TranscriberResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TranscriberResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.AnalysisInfo == input.AnalysisInfo ||
                    (this.AnalysisInfo != null &&
                    this.AnalysisInfo.Equals(input.AnalysisInfo))
                ) && 
                (
                    this.WordInfo == input.WordInfo ||
                    this.WordInfo != null &&
                    input.WordInfo != null &&
                    this.WordInfo.SequenceEqual(input.WordInfo)
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
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.AnalysisInfo != null)
                    hashCode = hashCode * 59 + this.AnalysisInfo.GetHashCode();
                if (this.WordInfo != null)
                    hashCode = hashCode * 59 + this.WordInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
