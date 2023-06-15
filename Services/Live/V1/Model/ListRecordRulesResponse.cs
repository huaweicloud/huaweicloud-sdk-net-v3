using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListRecordRulesResponse : SdkResponse
    {

        /// <summary>
        /// 查询结果的总元素数量
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 录制配置数组
        /// </summary>
        [JsonProperty("record_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecordRule> RecordConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRecordRulesResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  recordConfig: ").Append(RecordConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRecordRulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRecordRulesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.RecordConfig == input.RecordConfig ||
                    this.RecordConfig != null &&
                    input.RecordConfig != null &&
                    this.RecordConfig.SequenceEqual(input.RecordConfig)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.RecordConfig != null)
                    hashCode = hashCode * 59 + this.RecordConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
