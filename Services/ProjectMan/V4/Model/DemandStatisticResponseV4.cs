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
    /// 需求概览信息
    /// </summary>
    public class DemandStatisticResponseV4 
    {

        /// <summary>
        /// 已关闭数量
        /// </summary>
        [JsonProperty("closed_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClosedNum { get; set; }

        /// <summary>
        /// 模块
        /// </summary>
        [JsonProperty("module", NullValueHandling = NullValueHandling.Ignore)]
        public string Module { get; set; }

        /// <summary>
        /// 新建的数量
        /// </summary>
        [JsonProperty("new_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewNum { get; set; }

        /// <summary>
        /// 开发中的数量
        /// </summary>
        [JsonProperty("process_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProcessNum { get; set; }

        /// <summary>
        /// 已拒绝数量
        /// </summary>
        [JsonProperty("rejected_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? RejectedNum { get; set; }

        /// <summary>
        /// 已解决数量
        /// </summary>
        [JsonProperty("solved_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SolvedNum { get; set; }

        /// <summary>
        /// 测试中的数量
        /// </summary>
        [JsonProperty("test_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestNum { get; set; }

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
            sb.Append("class DemandStatisticResponseV4 {\n");
            sb.Append("  closedNum: ").Append(ClosedNum).Append("\n");
            sb.Append("  module: ").Append(Module).Append("\n");
            sb.Append("  newNum: ").Append(NewNum).Append("\n");
            sb.Append("  processNum: ").Append(ProcessNum).Append("\n");
            sb.Append("  rejectedNum: ").Append(RejectedNum).Append("\n");
            sb.Append("  solvedNum: ").Append(SolvedNum).Append("\n");
            sb.Append("  testNum: ").Append(TestNum).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DemandStatisticResponseV4);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DemandStatisticResponseV4 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClosedNum == input.ClosedNum ||
                    (this.ClosedNum != null &&
                    this.ClosedNum.Equals(input.ClosedNum))
                ) && 
                (
                    this.Module == input.Module ||
                    (this.Module != null &&
                    this.Module.Equals(input.Module))
                ) && 
                (
                    this.NewNum == input.NewNum ||
                    (this.NewNum != null &&
                    this.NewNum.Equals(input.NewNum))
                ) && 
                (
                    this.ProcessNum == input.ProcessNum ||
                    (this.ProcessNum != null &&
                    this.ProcessNum.Equals(input.ProcessNum))
                ) && 
                (
                    this.RejectedNum == input.RejectedNum ||
                    (this.RejectedNum != null &&
                    this.RejectedNum.Equals(input.RejectedNum))
                ) && 
                (
                    this.SolvedNum == input.SolvedNum ||
                    (this.SolvedNum != null &&
                    this.SolvedNum.Equals(input.SolvedNum))
                ) && 
                (
                    this.TestNum == input.TestNum ||
                    (this.TestNum != null &&
                    this.TestNum.Equals(input.TestNum))
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
                if (this.ClosedNum != null)
                    hashCode = hashCode * 59 + this.ClosedNum.GetHashCode();
                if (this.Module != null)
                    hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.NewNum != null)
                    hashCode = hashCode * 59 + this.NewNum.GetHashCode();
                if (this.ProcessNum != null)
                    hashCode = hashCode * 59 + this.ProcessNum.GetHashCode();
                if (this.RejectedNum != null)
                    hashCode = hashCode * 59 + this.RejectedNum.GetHashCode();
                if (this.SolvedNum != null)
                    hashCode = hashCode * 59 + this.SolvedNum.GetHashCode();
                if (this.TestNum != null)
                    hashCode = hashCode * 59 + this.TestNum.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
