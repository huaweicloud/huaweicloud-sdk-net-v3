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
    /// 工作项不同状态下的数量
    /// </summary>
    public class IssueCompletionRateV4IssueStatus 
    {

        /// <summary>
        /// 已关闭的工作项
        /// </summary>
        [JsonProperty("closed_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClosedNum { get; set; }

        /// <summary>
        /// 新建的工作项
        /// </summary>
        [JsonProperty("new_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewNum { get; set; }

        /// <summary>
        /// 进行中的工作项数目
        /// </summary>
        [JsonProperty("process_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProcessNum { get; set; }

        /// <summary>
        /// 已经拒绝的工作项
        /// </summary>
        [JsonProperty("rejected_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? RejectedNum { get; set; }

        /// <summary>
        /// 已经解决的工作项
        /// </summary>
        [JsonProperty("solved_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SolvedNum { get; set; }

        /// <summary>
        /// 测试中的工作项
        /// </summary>
        [JsonProperty("test_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestNum { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueCompletionRateV4IssueStatus {\n");
            sb.Append("  closedNum: ").Append(ClosedNum).Append("\n");
            sb.Append("  newNum: ").Append(NewNum).Append("\n");
            sb.Append("  processNum: ").Append(ProcessNum).Append("\n");
            sb.Append("  rejectedNum: ").Append(RejectedNum).Append("\n");
            sb.Append("  solvedNum: ").Append(SolvedNum).Append("\n");
            sb.Append("  testNum: ").Append(TestNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueCompletionRateV4IssueStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueCompletionRateV4IssueStatus input)
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
                return hashCode;
            }
        }
    }
}
