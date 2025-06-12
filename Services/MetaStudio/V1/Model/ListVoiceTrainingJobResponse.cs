using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListVoiceTrainingJobResponse : SdkResponse
    {

        /// <summary>
        /// 满足查询要求的任务总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 分身数字人模型训练任务列表。
        /// </summary>
        [JsonProperty("jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<TrainingJobInfo> Jobs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVoiceTrainingJobResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  jobs: ").Append(Jobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVoiceTrainingJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVoiceTrainingJobResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.Jobs != input.Jobs || (this.Jobs != null && input.Jobs != null && !this.Jobs.SequenceEqual(input.Jobs))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Jobs != null) hashCode = hashCode * 59 + this.Jobs.GetHashCode();
                return hashCode;
            }
        }
    }
}
