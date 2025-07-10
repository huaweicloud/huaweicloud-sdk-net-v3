using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListTerminalsBindingDesktopsRequest 
    {

        /// <summary>
        /// 桌面名。
        /// </summary>
        [SDKProperty("computer_name", IsQuery = true)]
        [JsonProperty("computer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComputerName { get; set; }

        /// <summary>
        /// mac地址。
        /// </summary>
        [SDKProperty("mac", IsQuery = true)]
        [JsonProperty("mac", NullValueHandling = NullValueHandling.Ignore)]
        public string Mac { get; set; }

        /// <summary>
        /// 起始数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 是否只查询结果总条数。
        /// </summary>
        [SDKProperty("count_only", IsQuery = true)]
        [JsonProperty("count_only", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CountOnly { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTerminalsBindingDesktopsRequest {\n");
            sb.Append("  computerName: ").Append(ComputerName).Append("\n");
            sb.Append("  mac: ").Append(Mac).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  countOnly: ").Append(CountOnly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTerminalsBindingDesktopsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTerminalsBindingDesktopsRequest input)
        {
            if (input == null) return false;
            if (this.ComputerName != input.ComputerName || (this.ComputerName != null && !this.ComputerName.Equals(input.ComputerName))) return false;
            if (this.Mac != input.Mac || (this.Mac != null && !this.Mac.Equals(input.Mac))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.CountOnly != input.CountOnly || (this.CountOnly != null && !this.CountOnly.Equals(input.CountOnly))) return false;

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
                if (this.ComputerName != null) hashCode = hashCode * 59 + this.ComputerName.GetHashCode();
                if (this.Mac != null) hashCode = hashCode * 59 + this.Mac.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.CountOnly != null) hashCode = hashCode * 59 + this.CountOnly.GetHashCode();
                return hashCode;
            }
        }
    }
}
