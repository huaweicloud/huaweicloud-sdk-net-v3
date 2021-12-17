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
    /// 单个音素的发音评测结果
    /// </summary>
    public class Phoneme 
    {

        /// <summary>
        /// 音标（ARPAbet音标系统）
        /// </summary>
        [JsonProperty("arpa", NullValueHandling = NullValueHandling.Ignore)]
        public string Arpa { get; set; }

        /// <summary>
        /// 音标（国际音标系统）
        /// </summary>
        [JsonProperty("ipa", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipa { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public float? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public float? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fluency", NullValueHandling = NullValueHandling.Ignore)]
        public PhonemeFluency Fluency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pronunciation", NullValueHandling = NullValueHandling.Ignore)]
        public PhonemePronunciation Pronunciation { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Phoneme {\n");
            sb.Append("  arpa: ").Append(Arpa).Append("\n");
            sb.Append("  ipa: ").Append(Ipa).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  fluency: ").Append(Fluency).Append("\n");
            sb.Append("  pronunciation: ").Append(Pronunciation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Phoneme);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Phoneme input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Arpa == input.Arpa ||
                    (this.Arpa != null &&
                    this.Arpa.Equals(input.Arpa))
                ) && 
                (
                    this.Ipa == input.Ipa ||
                    (this.Ipa != null &&
                    this.Ipa.Equals(input.Ipa))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Fluency == input.Fluency ||
                    (this.Fluency != null &&
                    this.Fluency.Equals(input.Fluency))
                ) && 
                (
                    this.Pronunciation == input.Pronunciation ||
                    (this.Pronunciation != null &&
                    this.Pronunciation.Equals(input.Pronunciation))
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
                if (this.Arpa != null)
                    hashCode = hashCode * 59 + this.Arpa.GetHashCode();
                if (this.Ipa != null)
                    hashCode = hashCode * 59 + this.Ipa.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Fluency != null)
                    hashCode = hashCode * 59 + this.Fluency.GetHashCode();
                if (this.Pronunciation != null)
                    hashCode = hashCode * 59 + this.Pronunciation.GetHashCode();
                return hashCode;
            }
        }
    }
}
