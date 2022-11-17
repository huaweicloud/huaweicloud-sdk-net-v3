using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListRestoreRecordsResponse : SdkResponse
    {

        /// <summary>
        /// 实例恢复记录的详情数组。
        /// </summary>
        [JsonProperty("restore_record_response", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceRestoreInfo> RestoreRecordResponse { get; set; }

        /// <summary>
        /// 返回记录数。
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNum { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRestoreRecordsResponse {\n");
            sb.Append("  restoreRecordResponse: ").Append(RestoreRecordResponse).Append("\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRestoreRecordsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRestoreRecordsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestoreRecordResponse == input.RestoreRecordResponse ||
                    this.RestoreRecordResponse != null &&
                    input.RestoreRecordResponse != null &&
                    this.RestoreRecordResponse.SequenceEqual(input.RestoreRecordResponse)
                ) && 
                (
                    this.TotalNum == input.TotalNum ||
                    (this.TotalNum != null &&
                    this.TotalNum.Equals(input.TotalNum))
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
                if (this.RestoreRecordResponse != null)
                    hashCode = hashCode * 59 + this.RestoreRecordResponse.GetHashCode();
                if (this.TotalNum != null)
                    hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
