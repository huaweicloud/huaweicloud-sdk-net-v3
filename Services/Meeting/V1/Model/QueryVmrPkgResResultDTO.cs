using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 查询Vmr套餐包分配数量结果。
    /// </summary>
    public class QueryVmrPkgResResultDTO 
    {

        /// <summary>
        /// 云会议室套餐包id。
        /// </summary>
        [JsonProperty("vmrPkgId", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrPkgId { get; set; }

        /// <summary>
        /// 云会议室套餐包名称。
        /// </summary>
        [JsonProperty("vmrName", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrName { get; set; }

        /// <summary>
        /// 云会议室套餐方数。
        /// </summary>
        [JsonProperty("vmrPkgParties", NullValueHandling = NullValueHandling.Ignore)]
        public int? VmrPkgParties { get; set; }

        /// <summary>
        /// 该云会议室套餐分配的总数。
        /// </summary>
        [JsonProperty("vmrPkgCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? VmrPkgCount { get; set; }

        /// <summary>
        /// 该套餐对应的云会议室已分配数量。
        /// </summary>
        [JsonProperty("vmrPkgUsedCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? VmrPkgUsedCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryVmrPkgResResultDTO {\n");
            sb.Append("  vmrPkgId: ").Append(VmrPkgId).Append("\n");
            sb.Append("  vmrName: ").Append(VmrName).Append("\n");
            sb.Append("  vmrPkgParties: ").Append(VmrPkgParties).Append("\n");
            sb.Append("  vmrPkgCount: ").Append(VmrPkgCount).Append("\n");
            sb.Append("  vmrPkgUsedCount: ").Append(VmrPkgUsedCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryVmrPkgResResultDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryVmrPkgResResultDTO input)
        {
            if (input == null) return false;
            if (this.VmrPkgId != input.VmrPkgId || (this.VmrPkgId != null && !this.VmrPkgId.Equals(input.VmrPkgId))) return false;
            if (this.VmrName != input.VmrName || (this.VmrName != null && !this.VmrName.Equals(input.VmrName))) return false;
            if (this.VmrPkgParties != input.VmrPkgParties || (this.VmrPkgParties != null && !this.VmrPkgParties.Equals(input.VmrPkgParties))) return false;
            if (this.VmrPkgCount != input.VmrPkgCount || (this.VmrPkgCount != null && !this.VmrPkgCount.Equals(input.VmrPkgCount))) return false;
            if (this.VmrPkgUsedCount != input.VmrPkgUsedCount || (this.VmrPkgUsedCount != null && !this.VmrPkgUsedCount.Equals(input.VmrPkgUsedCount))) return false;

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
                if (this.VmrPkgId != null) hashCode = hashCode * 59 + this.VmrPkgId.GetHashCode();
                if (this.VmrName != null) hashCode = hashCode * 59 + this.VmrName.GetHashCode();
                if (this.VmrPkgParties != null) hashCode = hashCode * 59 + this.VmrPkgParties.GetHashCode();
                if (this.VmrPkgCount != null) hashCode = hashCode * 59 + this.VmrPkgCount.GetHashCode();
                if (this.VmrPkgUsedCount != null) hashCode = hashCode * 59 + this.VmrPkgUsedCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
