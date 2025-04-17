using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V2.Model
{
    /// <summary>
    /// ddos状态响应体
    /// </summary>
    public class DDosStatus 
    {

        /// <summary>
        /// EIP的ID
        /// </summary>
        [JsonProperty("floating_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingIpId { get; set; }

        /// <summary>
        /// 浮动IP地址
        /// </summary>
        [JsonProperty("floating_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingIpAddress { get; set; }

        /// <summary>
        /// EIP所属类型，可选范围： - Anti-DDoS：eip属于Anti-DDoS流量清洗 - CNAD：eip属于DDoS原生高级防护
        /// </summary>
        [JsonProperty("product_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductType { get; set; }

        /// <summary>
        /// 防护状态，可选范围： - normal：表示正常 - configging：表示设置中 - notConfig：表示未设置 - packetcleaning：表示清洗 - packetdropping：表示黑洞
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 清洗阈值
        /// </summary>
        [JsonProperty("clean_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public long? CleanThreshold { get; set; }

        /// <summary>
        /// 黑洞阈值
        /// </summary>
        [JsonProperty("block_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DDosStatus {\n");
            sb.Append("  floatingIpId: ").Append(FloatingIpId).Append("\n");
            sb.Append("  floatingIpAddress: ").Append(FloatingIpAddress).Append("\n");
            sb.Append("  productType: ").Append(ProductType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  cleanThreshold: ").Append(CleanThreshold).Append("\n");
            sb.Append("  blockThreshold: ").Append(BlockThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DDosStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DDosStatus input)
        {
            if (input == null) return false;
            if (this.FloatingIpId != input.FloatingIpId || (this.FloatingIpId != null && !this.FloatingIpId.Equals(input.FloatingIpId))) return false;
            if (this.FloatingIpAddress != input.FloatingIpAddress || (this.FloatingIpAddress != null && !this.FloatingIpAddress.Equals(input.FloatingIpAddress))) return false;
            if (this.ProductType != input.ProductType || (this.ProductType != null && !this.ProductType.Equals(input.ProductType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CleanThreshold != input.CleanThreshold || (this.CleanThreshold != null && !this.CleanThreshold.Equals(input.CleanThreshold))) return false;
            if (this.BlockThreshold != input.BlockThreshold || (this.BlockThreshold != null && !this.BlockThreshold.Equals(input.BlockThreshold))) return false;

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
                if (this.FloatingIpId != null) hashCode = hashCode * 59 + this.FloatingIpId.GetHashCode();
                if (this.FloatingIpAddress != null) hashCode = hashCode * 59 + this.FloatingIpAddress.GetHashCode();
                if (this.ProductType != null) hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CleanThreshold != null) hashCode = hashCode * 59 + this.CleanThreshold.GetHashCode();
                if (this.BlockThreshold != null) hashCode = hashCode * 59 + this.BlockThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
