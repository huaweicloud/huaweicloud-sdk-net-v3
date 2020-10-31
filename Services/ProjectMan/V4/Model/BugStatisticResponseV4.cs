using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Bug信息
    /// </summary>
    public class BugStatisticResponseV4 
    {

        /// <summary>
        /// 重要程度为关键的缺陷数
        /// </summary>
        [JsonProperty("critical_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CriticalNum { get; set; }

        /// <summary>
        /// DI
        /// </summary>
        [JsonProperty("defect_index", NullValueHandling = NullValueHandling.Ignore)]
        public double? DefectIndex { get; set; }

        /// <summary>
        /// 模块
        /// </summary>
        [JsonProperty("module", NullValueHandling = NullValueHandling.Ignore)]
        public string Module { get; set; }

        /// <summary>
        /// 重要程度为一般的缺陷数
        /// </summary>
        [JsonProperty("normal_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NormalNum { get; set; }

        /// <summary>
        /// 重要程度为严重的缺陷数
        /// </summary>
        [JsonProperty("serious_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SeriousNum { get; set; }

        /// <summary>
        /// 重要程度为提示的缺陷数
        /// </summary>
        [JsonProperty("tip_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TipNum { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BugStatisticResponseV4 {\n");
            sb.Append("  criticalNum: ").Append(CriticalNum).Append("\n");
            sb.Append("  defectIndex: ").Append(DefectIndex).Append("\n");
            sb.Append("  module: ").Append(Module).Append("\n");
            sb.Append("  normalNum: ").Append(NormalNum).Append("\n");
            sb.Append("  seriousNum: ").Append(SeriousNum).Append("\n");
            sb.Append("  tipNum: ").Append(TipNum).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BugStatisticResponseV4);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BugStatisticResponseV4 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CriticalNum == input.CriticalNum ||
                    (this.CriticalNum != null &&
                    this.CriticalNum.Equals(input.CriticalNum))
                ) && 
                (
                    this.DefectIndex == input.DefectIndex ||
                    (this.DefectIndex != null &&
                    this.DefectIndex.Equals(input.DefectIndex))
                ) && 
                (
                    this.Module == input.Module ||
                    (this.Module != null &&
                    this.Module.Equals(input.Module))
                ) && 
                (
                    this.NormalNum == input.NormalNum ||
                    (this.NormalNum != null &&
                    this.NormalNum.Equals(input.NormalNum))
                ) && 
                (
                    this.SeriousNum == input.SeriousNum ||
                    (this.SeriousNum != null &&
                    this.SeriousNum.Equals(input.SeriousNum))
                ) && 
                (
                    this.TipNum == input.TipNum ||
                    (this.TipNum != null &&
                    this.TipNum.Equals(input.TipNum))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.CriticalNum != null)
                    hashCode = hashCode * 59 + this.CriticalNum.GetHashCode();
                if (this.DefectIndex != null)
                    hashCode = hashCode * 59 + this.DefectIndex.GetHashCode();
                if (this.Module != null)
                    hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.NormalNum != null)
                    hashCode = hashCode * 59 + this.NormalNum.GetHashCode();
                if (this.SeriousNum != null)
                    hashCode = hashCode * 59 + this.SeriousNum.GetHashCode();
                if (this.TipNum != null)
                    hashCode = hashCode * 59 + this.TipNum.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
