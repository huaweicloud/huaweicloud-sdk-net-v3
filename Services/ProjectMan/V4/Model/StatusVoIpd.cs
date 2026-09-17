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
    /// 工作项状态查询接口返回状态数据
    /// </summary>
    public class StatusVoIpd 
    {

        /// <summary>
        /// **参数解释**： 状态名称。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 工作项的状态属性。 **取值范围**： START、IN_PROGRESS、END。
        /// </summary>
        [JsonProperty("belonging", NullValueHandling = NullValueHandling.Ignore)]
        public string Belonging { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusVoIpd {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  belonging: ").Append(Belonging).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatusVoIpd);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatusVoIpd input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Belonging != input.Belonging || (this.Belonging != null && !this.Belonging.Equals(input.Belonging))) return false;

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
                if (this.Belonging != null) hashCode = hashCode * 59 + this.Belonging.GetHashCode();
                return hashCode;
            }
        }
    }
}
