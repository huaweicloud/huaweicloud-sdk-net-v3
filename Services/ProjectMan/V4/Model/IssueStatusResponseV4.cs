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
    /// 工作项的统计信息
    /// </summary>
    public class IssueStatusResponseV4 
    {

        /// <summary>
        /// 已关闭数量
        /// </summary>
        [JsonProperty("closed_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClosedNum { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueStatusResponseV4 {\n");
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
            return this.Equals(input as IssueStatusResponseV4);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueStatusResponseV4 input)
        {
            if (input == null) return false;
            if (this.ClosedNum != input.ClosedNum || (this.ClosedNum != null && !this.ClosedNum.Equals(input.ClosedNum))) return false;
            if (this.NewNum != input.NewNum || (this.NewNum != null && !this.NewNum.Equals(input.NewNum))) return false;
            if (this.ProcessNum != input.ProcessNum || (this.ProcessNum != null && !this.ProcessNum.Equals(input.ProcessNum))) return false;
            if (this.RejectedNum != input.RejectedNum || (this.RejectedNum != null && !this.RejectedNum.Equals(input.RejectedNum))) return false;
            if (this.SolvedNum != input.SolvedNum || (this.SolvedNum != null && !this.SolvedNum.Equals(input.SolvedNum))) return false;
            if (this.TestNum != input.TestNum || (this.TestNum != null && !this.TestNum.Equals(input.TestNum))) return false;

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
                if (this.ClosedNum != null) hashCode = hashCode * 59 + this.ClosedNum.GetHashCode();
                if (this.NewNum != null) hashCode = hashCode * 59 + this.NewNum.GetHashCode();
                if (this.ProcessNum != null) hashCode = hashCode * 59 + this.ProcessNum.GetHashCode();
                if (this.RejectedNum != null) hashCode = hashCode * 59 + this.RejectedNum.GetHashCode();
                if (this.SolvedNum != null) hashCode = hashCode * 59 + this.SolvedNum.GetHashCode();
                if (this.TestNum != null) hashCode = hashCode * 59 + this.TestNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
