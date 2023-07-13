using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListRecordDataResponse : SdkResponse
    {

        /// <summary>
        /// 采样数据列表。 
        /// </summary>
        [JsonProperty("record_data_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecordData> RecordDataList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRecordDataResponse {\n");
            sb.Append("  recordDataList: ").Append(RecordDataList).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRecordDataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRecordDataResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecordDataList == input.RecordDataList ||
                    this.RecordDataList != null &&
                    input.RecordDataList != null &&
                    this.RecordDataList.SequenceEqual(input.RecordDataList)
                ) && 
                (
                    this.XRequestId == input.XRequestId ||
                    (this.XRequestId != null &&
                    this.XRequestId.Equals(input.XRequestId))
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
                if (this.RecordDataList != null)
                    hashCode = hashCode * 59 + this.RecordDataList.GetHashCode();
                if (this.XRequestId != null)
                    hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
