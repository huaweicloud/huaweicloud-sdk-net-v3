using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListErrorLogsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_log_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ErrorLog> ErrorLogList { get; set; }

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("total_record", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRecord { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListErrorLogsResponse {\n");
            sb.Append("  errorLogList: ").Append(ErrorLogList).Append("\n");
            sb.Append("  totalRecord: ").Append(TotalRecord).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListErrorLogsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListErrorLogsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorLogList == input.ErrorLogList ||
                    this.ErrorLogList != null &&
                    input.ErrorLogList != null &&
                    this.ErrorLogList.SequenceEqual(input.ErrorLogList)
                ) && 
                (
                    this.TotalRecord == input.TotalRecord ||
                    (this.TotalRecord != null &&
                    this.TotalRecord.Equals(input.TotalRecord))
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
                if (this.ErrorLogList != null)
                    hashCode = hashCode * 59 + this.ErrorLogList.GetHashCode();
                if (this.TotalRecord != null)
                    hashCode = hashCode * 59 + this.TotalRecord.GetHashCode();
                return hashCode;
            }
        }
    }
}
