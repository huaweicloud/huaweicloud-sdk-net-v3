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
    public class ListBackupRecordsResponse : SdkResponse
    {

        /// <summary>
        /// 返回记录数。
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// 备份信息的详情数组。
        /// </summary>
        [JsonProperty("backup_record_response", NullValueHandling = NullValueHandling.Ignore)]
        public List<BackupRecordResponse> BackupRecordResponse { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBackupRecordsResponse {\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  backupRecordResponse: ").Append(BackupRecordResponse).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBackupRecordsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBackupRecordsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalNum == input.TotalNum ||
                    (this.TotalNum != null &&
                    this.TotalNum.Equals(input.TotalNum))
                ) && 
                (
                    this.BackupRecordResponse == input.BackupRecordResponse ||
                    this.BackupRecordResponse != null &&
                    input.BackupRecordResponse != null &&
                    this.BackupRecordResponse.SequenceEqual(input.BackupRecordResponse)
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
                if (this.TotalNum != null)
                    hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                if (this.BackupRecordResponse != null)
                    hashCode = hashCode * 59 + this.BackupRecordResponse.GetHashCode();
                return hashCode;
            }
        }
    }
}
