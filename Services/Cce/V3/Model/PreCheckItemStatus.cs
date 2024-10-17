using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 检查项状态信息
    /// </summary>
    public class PreCheckItemStatus 
    {

        /// <summary>
        /// 检查项名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 检查项类型，取值如下 - Exception: 异常类，需要用户解决 - Risk：风险类，用户确认后可选择跳过
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// 检查项分组，取值如下 - LimitCheck: 集群限制检查 - MasterCheck：控制节点检查 - NodeCheck：用户节点检查 - AddonCheck：插件检查 - ExecuteException：检查流程错误
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        /// <summary>
        /// 检查项风险级别，取值如下 - Info: 提示级别 - Warning：风险级别 - Fatal：严重级别
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// 状态，取值如下 - Init: 初始化 - Running 运行中 - Success 成功 - Failed 失败
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("riskSource", NullValueHandling = NullValueHandling.Ignore)]
        public RiskSource RiskSource { get; set; }

        /// <summary>
        /// 错误码集合
        /// </summary>
        [JsonProperty("errorCodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ErrorCodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreCheckItemStatus {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  kind: ").Append(Kind).Append("\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  riskSource: ").Append(RiskSource).Append("\n");
            sb.Append("  errorCodes: ").Append(ErrorCodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PreCheckItemStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PreCheckItemStatus input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Kind != input.Kind || (this.Kind != null && !this.Kind.Equals(input.Kind))) return false;
            if (this.Group != input.Group || (this.Group != null && !this.Group.Equals(input.Group))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.RiskSource != input.RiskSource || (this.RiskSource != null && !this.RiskSource.Equals(input.RiskSource))) return false;
            if (this.ErrorCodes != input.ErrorCodes || (this.ErrorCodes != null && input.ErrorCodes != null && !this.ErrorCodes.SequenceEqual(input.ErrorCodes))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Kind != null) hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Group != null) hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.RiskSource != null) hashCode = hashCode * 59 + this.RiskSource.GetHashCode();
                if (this.ErrorCodes != null) hashCode = hashCode * 59 + this.ErrorCodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
