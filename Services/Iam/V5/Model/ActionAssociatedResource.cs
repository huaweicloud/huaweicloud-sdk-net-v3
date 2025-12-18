using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 与该授权项关联的资源。
    /// </summary>
    public class ActionAssociatedResource 
    {

        /// <summary>
        /// 统一资源名称模板，表示可以通过这类资源的统一资源名称对该授权项进行资源粒度的授权。
        /// </summary>
        [JsonProperty("urn_template", NullValueHandling = NullValueHandling.Ignore)]
        public string UrnTemplate { get; set; }

        /// <summary>
        /// 标识该资源类型是否是这个授权项必选的，即授权项一定涉及对这类资源的操作；例如subnet是vpc:subnets:get的必选资源类型；而ou是organizations::tagResource的可选资源类型，因为organizations::tagResource操作的资源还可能是account或者policy。
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Required { get; set; }

        /// <summary>
        /// 针对该授权项和资源的服务自定义条件属性以及部分全局属性，只有授权项和资源同时匹配时才会生效。
        /// </summary>
        [JsonProperty("condition_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ConditionKeys { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionAssociatedResource {\n");
            sb.Append("  urnTemplate: ").Append(UrnTemplate).Append("\n");
            sb.Append("  required: ").Append(Required).Append("\n");
            sb.Append("  conditionKeys: ").Append(ConditionKeys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionAssociatedResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionAssociatedResource input)
        {
            if (input == null) return false;
            if (this.UrnTemplate != input.UrnTemplate || (this.UrnTemplate != null && !this.UrnTemplate.Equals(input.UrnTemplate))) return false;
            if (this.Required != input.Required || (this.Required != null && !this.Required.Equals(input.Required))) return false;
            if (this.ConditionKeys != input.ConditionKeys || (this.ConditionKeys != null && input.ConditionKeys != null && !this.ConditionKeys.SequenceEqual(input.ConditionKeys))) return false;

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
                if (this.UrnTemplate != null) hashCode = hashCode * 59 + this.UrnTemplate.GetHashCode();
                if (this.Required != null) hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.ConditionKeys != null) hashCode = hashCode * 59 + this.ConditionKeys.GetHashCode();
                return hashCode;
            }
        }
    }
}
