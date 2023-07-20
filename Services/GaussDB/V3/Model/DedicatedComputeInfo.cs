using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DedicatedComputeInfo 
    {

        /// <summary>
        /// 专属资源池中cpu总数。
        /// </summary>
        [JsonProperty("vcpus_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? VcpusTotal { get; set; }

        /// <summary>
        /// 专属资源池已使用的cpu数。
        /// </summary>
        [JsonProperty("vcpus_used", NullValueHandling = NullValueHandling.Ignore)]
        public int? VcpusUsed { get; set; }

        /// <summary>
        /// 专属资源池计算内存大小, 单位GB。
        /// </summary>
        [JsonProperty("ram_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? RamTotal { get; set; }

        /// <summary>
        /// 专属资源池已使用的计算内存大小，单位GB。
        /// </summary>
        [JsonProperty("ram_used", NullValueHandling = NullValueHandling.Ignore)]
        public int? RamUsed { get; set; }

        /// <summary>
        /// 专属资源池计算资源规格码。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 专属资源池计算主机数量。
        /// </summary>
        [JsonProperty("host_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? HostNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DedicatedComputeInfo {\n");
            sb.Append("  vcpusTotal: ").Append(VcpusTotal).Append("\n");
            sb.Append("  vcpusUsed: ").Append(VcpusUsed).Append("\n");
            sb.Append("  ramTotal: ").Append(RamTotal).Append("\n");
            sb.Append("  ramUsed: ").Append(RamUsed).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  hostNum: ").Append(HostNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DedicatedComputeInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DedicatedComputeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VcpusTotal == input.VcpusTotal ||
                    (this.VcpusTotal != null &&
                    this.VcpusTotal.Equals(input.VcpusTotal))
                ) && 
                (
                    this.VcpusUsed == input.VcpusUsed ||
                    (this.VcpusUsed != null &&
                    this.VcpusUsed.Equals(input.VcpusUsed))
                ) && 
                (
                    this.RamTotal == input.RamTotal ||
                    (this.RamTotal != null &&
                    this.RamTotal.Equals(input.RamTotal))
                ) && 
                (
                    this.RamUsed == input.RamUsed ||
                    (this.RamUsed != null &&
                    this.RamUsed.Equals(input.RamUsed))
                ) && 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.HostNum == input.HostNum ||
                    (this.HostNum != null &&
                    this.HostNum.Equals(input.HostNum))
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
                if (this.VcpusTotal != null)
                    hashCode = hashCode * 59 + this.VcpusTotal.GetHashCode();
                if (this.VcpusUsed != null)
                    hashCode = hashCode * 59 + this.VcpusUsed.GetHashCode();
                if (this.RamTotal != null)
                    hashCode = hashCode * 59 + this.RamTotal.GetHashCode();
                if (this.RamUsed != null)
                    hashCode = hashCode * 59 + this.RamUsed.GetHashCode();
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.HostNum != null)
                    hashCode = hashCode * 59 + this.HostNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
