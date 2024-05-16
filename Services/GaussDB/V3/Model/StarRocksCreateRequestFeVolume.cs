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
    /// FE节点存储规格。
    /// </summary>
    public class StarRocksCreateRequestFeVolume 
    {

        /// <summary>
        /// 磁盘类型。通过查询HTAP引擎资源返回消息获取。
        /// </summary>
        [JsonProperty("io_type", NullValueHandling = NullValueHandling.Ignore)]
        public string IoType { get; set; }

        /// <summary>
        /// 磁盘容量，单位GB 增长的步长：10GB。
        /// </summary>
        [JsonProperty("capacity_in_gb", NullValueHandling = NullValueHandling.Ignore)]
        public int? CapacityInGb { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StarRocksCreateRequestFeVolume {\n");
            sb.Append("  ioType: ").Append(IoType).Append("\n");
            sb.Append("  capacityInGb: ").Append(CapacityInGb).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StarRocksCreateRequestFeVolume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StarRocksCreateRequestFeVolume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IoType == input.IoType ||
                    (this.IoType != null &&
                    this.IoType.Equals(input.IoType))
                ) && 
                (
                    this.CapacityInGb == input.CapacityInGb ||
                    (this.CapacityInGb != null &&
                    this.CapacityInGb.Equals(input.CapacityInGb))
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
                if (this.IoType != null)
                    hashCode = hashCode * 59 + this.IoType.GetHashCode();
                if (this.CapacityInGb != null)
                    hashCode = hashCode * 59 + this.CapacityInGb.GetHashCode();
                return hashCode;
            }
        }
    }
}
