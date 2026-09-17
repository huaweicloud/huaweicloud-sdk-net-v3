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
    /// 工作项操作返回值
    /// </summary>
    public class IssueOperateResult 
    {

        /// <summary>
        /// **参数解释**： 变更的工作项ID。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 工作项变更人ID。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public string Operator { get; set; }

        /// <summary>
        /// **参数解释**： 工作项的作废标识，枚举类型。 **取值范围**： - 正在工作：可正常操作的工作项 - 作废：软删除后的工作项，可在回收站恢复 - 删除：彻底删除后的工作项，无法恢复
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释**： 工作项变更时间。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("operate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueOperateResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  operateTime: ").Append(OperateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueOperateResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueOperateResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Operator != input.Operator || (this.Operator != null && !this.Operator.Equals(input.Operator))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.OperateTime != input.OperateTime || (this.OperateTime != null && !this.OperateTime.Equals(input.OperateTime))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Operator != null) hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.OperateTime != null) hashCode = hashCode * 59 + this.OperateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
