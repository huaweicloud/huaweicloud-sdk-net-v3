using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// 封堵信息
    /// </summary>
    public class IpStatusDetail 
    {

        /// <summary>
        /// 封堵时间
        /// </summary>
        [JsonProperty("block_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? BlockTime { get; set; }

        /// <summary>
        /// 解封时间
        /// </summary>
        [JsonProperty("unblock_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UnblockTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpStatusDetail {\n");
            sb.Append("  blockTime: ").Append(BlockTime).Append("\n");
            sb.Append("  unblockTime: ").Append(UnblockTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpStatusDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpStatusDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlockTime == input.BlockTime ||
                    (this.BlockTime != null &&
                    this.BlockTime.Equals(input.BlockTime))
                ) && 
                (
                    this.UnblockTime == input.UnblockTime ||
                    (this.UnblockTime != null &&
                    this.UnblockTime.Equals(input.UnblockTime))
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
                if (this.BlockTime != null)
                    hashCode = hashCode * 59 + this.BlockTime.GetHashCode();
                if (this.UnblockTime != null)
                    hashCode = hashCode * 59 + this.UnblockTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
