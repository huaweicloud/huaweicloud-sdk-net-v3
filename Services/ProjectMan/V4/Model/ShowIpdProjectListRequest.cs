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
    /// Request Object
    /// </summary>
    public class ShowIpdProjectListRequest 
    {

        /// <summary>
        /// **参数解释**： 项目名称搜索关键字。 **约束限制**： 最大256个字符。 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// **参数解释**： IPD项目模型id。 **约束限制**： 不涉及 **取值范围**： 10001（系统设备类） 10002（独立软件类） 10003（云服务类型） **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("model", IsQuery = true)]
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIpdProjectListRequest {\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  model: ").Append(Model).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIpdProjectListRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIpdProjectListRequest input)
        {
            if (input == null) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.Model != input.Model || (this.Model != null && !this.Model.Equals(input.Model))) return false;

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
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.Model != null) hashCode = hashCode * 59 + this.Model.GetHashCode();
                return hashCode;
            }
        }
    }
}
