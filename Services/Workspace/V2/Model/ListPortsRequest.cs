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
    public class ListPortsRequest 
    {

        /// <summary>
        /// 分页查询的起始资源ID。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 功能说明：每页返回的个数。取值范围：1~2000。默认值：2000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// ip地址。
        /// </summary>
        [SDKProperty("ip_address", IsQuery = true)]
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 子网ID。
        /// </summary>
        [SDKProperty("subnet_id", IsQuery = true)]
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 是否被使用。
        /// </summary>
        [SDKProperty("is_used", IsQuery = true)]
        [JsonProperty("is_used", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUsed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPortsRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  isUsed: ").Append(IsUsed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPortsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPortsRequest input)
        {
            if (input == null) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.IsUsed != input.IsUsed || (this.IsUsed != null && !this.IsUsed.Equals(input.IsUsed))) return false;

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
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.IsUsed != null) hashCode = hashCode * 59 + this.IsUsed.GetHashCode();
                return hashCode;
            }
        }
    }
}
