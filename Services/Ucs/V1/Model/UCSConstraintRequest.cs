using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UCSConstraintRequest 
    {

        /// <summary>
        /// 策略模板的ID
        /// </summary>
        [JsonProperty("constraintTemplateID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConstraintTemplateID { get; set; }

        /// <summary>
        /// 策略执行方式，当前支持warn和deny
        /// </summary>
        [JsonProperty("enforcementAction", NullValueHandling = NullValueHandling.Ignore)]
        public string EnforcementAction { get; set; }

        /// <summary>
        /// 生效的命名空间
        /// </summary>
        [JsonProperty("namespaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// 策略实例的参数
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Object Parameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UCSConstraintRequest {\n");
            sb.Append("  constraintTemplateID: ").Append(ConstraintTemplateID).Append("\n");
            sb.Append("  enforcementAction: ").Append(EnforcementAction).Append("\n");
            sb.Append("  namespaces: ").Append(Namespaces).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UCSConstraintRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UCSConstraintRequest input)
        {
            if (input == null) return false;
            if (this.ConstraintTemplateID != input.ConstraintTemplateID || (this.ConstraintTemplateID != null && !this.ConstraintTemplateID.Equals(input.ConstraintTemplateID))) return false;
            if (this.EnforcementAction != input.EnforcementAction || (this.EnforcementAction != null && !this.EnforcementAction.Equals(input.EnforcementAction))) return false;
            if (this.Namespaces != input.Namespaces || (this.Namespaces != null && input.Namespaces != null && !this.Namespaces.SequenceEqual(input.Namespaces))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && !this.Parameters.Equals(input.Parameters))) return false;

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
                if (this.ConstraintTemplateID != null) hashCode = hashCode * 59 + this.ConstraintTemplateID.GetHashCode();
                if (this.EnforcementAction != null) hashCode = hashCode * 59 + this.EnforcementAction.GetHashCode();
                if (this.Namespaces != null) hashCode = hashCode * 59 + this.Namespaces.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
