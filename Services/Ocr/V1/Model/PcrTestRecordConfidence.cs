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
    public class PcrTestRecordConfidence 
    {

        /// <summary>
        /// 姓名的置信度 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public float? Name { get; set; }

        /// <summary>
        /// 核酸检测采样时间的置信度 
        /// </summary>
        [JsonProperty("sampling_time", NullValueHandling = NullValueHandling.Ignore)]
        public float? SamplingTime { get; set; }

        /// <summary>
        /// 核酸检测结果更新时间的置信度 
        /// </summary>
        [JsonProperty("test_time", NullValueHandling = NullValueHandling.Ignore)]
        public float? TestTime { get; set; }

        /// <summary>
        /// 核酸检测结果的置信度 
        /// </summary>
        [JsonProperty("test_result", NullValueHandling = NullValueHandling.Ignore)]
        public float? TestResult { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PcrTestRecordConfidence {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  samplingTime: ").Append(SamplingTime).Append("\n");
            sb.Append("  testTime: ").Append(TestTime).Append("\n");
            sb.Append("  testResult: ").Append(TestResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PcrTestRecordConfidence);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PcrTestRecordConfidence input)
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
                return hashCode;
            }
        }
    }
}
