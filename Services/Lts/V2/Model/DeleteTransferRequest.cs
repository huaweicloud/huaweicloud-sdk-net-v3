using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteTransferRequest 
    {

        /// <summary>
        /// 日志转储ID。获取ID有3种方式： 1. 调用查询日志转储接口，返回值有日志转储ID  2. 调用新增日志转储接口，返回值有日志转储ID 3. 调用删除日志转储接口，返回值有日志转储ID
        /// </summary>
        [SDKProperty("log_transfer_id", IsQuery = true)]
        [JsonProperty("log_transfer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogTransferId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTransferRequest {\n");
            sb.Append("  logTransferId: ").Append(LogTransferId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTransferRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTransferRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogTransferId == input.LogTransferId ||
                    (this.LogTransferId != null &&
                    this.LogTransferId.Equals(input.LogTransferId))
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
                if (this.LogTransferId != null)
                    hashCode = hashCode * 59 + this.LogTransferId.GetHashCode();
                return hashCode;
            }
        }
    }
}
