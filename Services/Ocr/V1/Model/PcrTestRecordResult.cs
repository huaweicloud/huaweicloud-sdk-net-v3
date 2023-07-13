using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PcrTestRecordResult 
    {

        /// <summary>
        /// 姓名 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 核酸检测采样时间 
        /// </summary>
        [JsonProperty("sampling_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SamplingTime { get; set; }

        /// <summary>
        /// 核酸检测结果更新时间 
        /// </summary>
        [JsonProperty("test_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TestTime { get; set; }

        /// <summary>
        /// 核酸检测结果，可选值包括：  - \&quot;positive\&quot;,即阳性  - \&quot;negative\&quot;,即阴性  - \&quot;unknown\&quot;,未知 
        /// </summary>
        [JsonProperty("test_result", NullValueHandling = NullValueHandling.Ignore)]
        public string TestResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public PcrTestRecordConfidence Confidence { get; set; }

        /// <summary>
        /// 代表检测识别出来的文字块数目。 
        /// </summary>
        [JsonProperty("words_block_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? WordsBlockCount { get; set; }

        /// <summary>
        /// 识别文字块列表，输出顺序从左到右，从上到下。 
        /// </summary>
        [JsonProperty("words_block_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<PcrTestRecordWordsBlockList> WordsBlockList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PcrTestRecordResult {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  samplingTime: ").Append(SamplingTime).Append("\n");
            sb.Append("  testTime: ").Append(TestTime).Append("\n");
            sb.Append("  testResult: ").Append(TestResult).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  wordsBlockCount: ").Append(WordsBlockCount).Append("\n");
            sb.Append("  wordsBlockList: ").Append(WordsBlockList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PcrTestRecordResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PcrTestRecordResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SamplingTime == input.SamplingTime ||
                    (this.SamplingTime != null &&
                    this.SamplingTime.Equals(input.SamplingTime))
                ) && 
                (
                    this.TestTime == input.TestTime ||
                    (this.TestTime != null &&
                    this.TestTime.Equals(input.TestTime))
                ) && 
                (
                    this.TestResult == input.TestResult ||
                    (this.TestResult != null &&
                    this.TestResult.Equals(input.TestResult))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.WordsBlockCount == input.WordsBlockCount ||
                    (this.WordsBlockCount != null &&
                    this.WordsBlockCount.Equals(input.WordsBlockCount))
                ) && 
                (
                    this.WordsBlockList == input.WordsBlockList ||
                    this.WordsBlockList != null &&
                    input.WordsBlockList != null &&
                    this.WordsBlockList.SequenceEqual(input.WordsBlockList)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SamplingTime != null)
                    hashCode = hashCode * 59 + this.SamplingTime.GetHashCode();
                if (this.TestTime != null)
                    hashCode = hashCode * 59 + this.TestTime.GetHashCode();
                if (this.TestResult != null)
                    hashCode = hashCode * 59 + this.TestResult.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.WordsBlockCount != null)
                    hashCode = hashCode * 59 + this.WordsBlockCount.GetHashCode();
                if (this.WordsBlockList != null)
                    hashCode = hashCode * 59 + this.WordsBlockList.GetHashCode();
                return hashCode;
            }
        }
    }
}
