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
    public class ListBackupTransfersResponse : SdkResponse
    {

        /// <summary>
        /// 任务数量
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }

        /// <summary>
        /// 任务列表
        /// </summary>
        [JsonProperty("transfer_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<BackupTransferInfo> TransferList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBackupTransfersResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  transferList: ").Append(TransferList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBackupTransfersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBackupTransfersResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.TransferList != input.TransferList || (this.TransferList != null && input.TransferList != null && !this.TransferList.SequenceEqual(input.TransferList))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.TransferList != null) hashCode = hashCode * 59 + this.TransferList.GetHashCode();
                return hashCode;
            }
        }
    }
}
