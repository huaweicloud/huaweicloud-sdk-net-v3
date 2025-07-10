using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BestPracticeCheckItemDetail 
    {

        /// <summary>
        /// 检查项编号
        /// </summary>
        [JsonProperty("check_item", NullValueHandling = NullValueHandling.Ignore)]
        public int? CheckItem { get; set; }

        /// <summary>
        /// 检查项描述
        /// </summary>
        [JsonProperty("check_item_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckItemName { get; set; }

        /// <summary>
        /// 检查项风险描述
        /// </summary>
        [JsonProperty("risk_description", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskDescription { get; set; }

        /// <summary>
        /// 检测结果
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 八大领域的细分场景
        /// </summary>
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public string Scene { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("risk_level", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskLevel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BestPracticeCheckItemDetail {\n");
            sb.Append("  checkItem: ").Append(CheckItem).Append("\n");
            sb.Append("  checkItemName: ").Append(CheckItemName).Append("\n");
            sb.Append("  riskDescription: ").Append(RiskDescription).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("  riskLevel: ").Append(RiskLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BestPracticeCheckItemDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BestPracticeCheckItemDetail input)
        {
            if (input == null) return false;
            if (this.CheckItem != input.CheckItem || (this.CheckItem != null && !this.CheckItem.Equals(input.CheckItem))) return false;
            if (this.CheckItemName != input.CheckItemName || (this.CheckItemName != null && !this.CheckItemName.Equals(input.CheckItemName))) return false;
            if (this.RiskDescription != input.RiskDescription || (this.RiskDescription != null && !this.RiskDescription.Equals(input.RiskDescription))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.Scene != input.Scene || (this.Scene != null && !this.Scene.Equals(input.Scene))) return false;
            if (this.RiskLevel != input.RiskLevel || (this.RiskLevel != null && !this.RiskLevel.Equals(input.RiskLevel))) return false;

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
                if (this.CheckItem != null) hashCode = hashCode * 59 + this.CheckItem.GetHashCode();
                if (this.CheckItemName != null) hashCode = hashCode * 59 + this.CheckItemName.GetHashCode();
                if (this.RiskDescription != null) hashCode = hashCode * 59 + this.RiskDescription.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Scene != null) hashCode = hashCode * 59 + this.Scene.GetHashCode();
                if (this.RiskLevel != null) hashCode = hashCode * 59 + this.RiskLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
