using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DashBoardNameItem 
    {

        /// <summary>
        /// **参数描述**： 自定义监控看板名称 **约束限制** 不涉及 **取值范围** 长度为[1,128]个字符，只允许中文、英文、数字0-9、_和- **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("dashboard_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashBoardNameItem {\n");
            sb.Append("  dashboardName: ").Append(DashboardName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DashBoardNameItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DashBoardNameItem input)
        {
            if (input == null) return false;
            if (this.DashboardName != input.DashboardName || (this.DashboardName != null && !this.DashboardName.Equals(input.DashboardName))) return false;

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
                if (this.DashboardName != null) hashCode = hashCode * 59 + this.DashboardName.GetHashCode();
                return hashCode;
            }
        }
    }
}
