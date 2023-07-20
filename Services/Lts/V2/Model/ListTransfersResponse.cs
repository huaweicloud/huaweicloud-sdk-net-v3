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
    /// Response Object
    /// </summary>
    public class ListTransfersResponse : SdkResponse
    {

        /// <summary>
        /// 查询日志转储信息数组
        /// </summary>
        [JsonProperty("log_transfers", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateTransferResponseBody> LogTransfers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTransfersResponse {\n");
            sb.Append("  logTransfers: ").Append(LogTransfers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTransfersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTransfersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogTransfers == input.LogTransfers ||
                    this.LogTransfers != null &&
                    input.LogTransfers != null &&
                    this.LogTransfers.SequenceEqual(input.LogTransfers)
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
                if (this.LogTransfers != null)
                    hashCode = hashCode * 59 + this.LogTransfers.GetHashCode();
                return hashCode;
            }
        }
    }
}
