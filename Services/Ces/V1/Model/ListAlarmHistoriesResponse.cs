using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAlarmHistoriesResponse : SdkResponse
    {

        /// <summary>
        /// 一条或者多条告警历史详细信息
        /// </summary>
        [JsonProperty("alarm_histories", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmHistoryInfo> AlarmHistories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public MetaDataForAlarmHistory MetaData { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmHistoriesResponse {\n");
            sb.Append("  alarmHistories: ").Append(AlarmHistories).Append("\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmHistoriesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmHistoriesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmHistories == input.AlarmHistories ||
                    this.AlarmHistories != null &&
                    input.AlarmHistories != null &&
                    this.AlarmHistories.SequenceEqual(input.AlarmHistories)
                ) && 
                (
                    this.MetaData == input.MetaData ||
                    (this.MetaData != null &&
                    this.MetaData.Equals(input.MetaData))
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
                if (this.AlarmHistories != null)
                    hashCode = hashCode * 59 + this.AlarmHistories.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                return hashCode;
            }
        }
    }
}
