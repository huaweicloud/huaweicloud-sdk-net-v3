using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExecutionPlanDiffAttribute 
    {

        /// <summary>
        /// 当前资源将要被修改的参数的名字。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 当前资源被修改的参数的原始值。  若是资源创建的场景，则previous_value为空  若远端资源产生了偏差，则同一个资源会返回两个ExecutionPlanItem，其中一个的drifted为true，另一个的drifted为false   * drifted为true的previous_value为资源栈中所维持的资源属性和状态   * drifted为false的previous_value为provider请求远端资源后，远端资源所返回的资源属性和状态  若远端资源未产生偏差，则只会返回一个drifted为false的ExecutionPlanItem   * drifted为false的previous_value为资源栈中所维持的资源属性和状态 
        /// </summary>
        [JsonProperty("previous_value", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousValue { get; set; }

        /// <summary>
        /// 当前资源被修改的参数的目的值。  若是资源删除的场景，则target_value为空  若远端资源产生了偏差，则同一个资源会返回两个ExecutionPlanItem，其中一个的drifted为true，另一个的drifted为false   * drifted为true的target_value为provider请求远端资源后，远端资源所返回的资源属性和状态   * drifted为false的target_value为基于用户模板更新的资源属性和状态  若远端资源未产生偏差，则只会返回一个drifted为false的ExecutionPlanItem   * drifted为false的target_value为基于用户模板更新的资源属性和状态 
        /// </summary>
        [JsonProperty("target_value", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionPlanDiffAttribute {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  previousValue: ").Append(PreviousValue).Append("\n");
            sb.Append("  targetValue: ").Append(TargetValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecutionPlanDiffAttribute);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecutionPlanDiffAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PreviousValue == input.PreviousValue ||
                    (this.PreviousValue != null &&
                    this.PreviousValue.Equals(input.PreviousValue))
                ) && 
                (
                    this.TargetValue == input.TargetValue ||
                    (this.TargetValue != null &&
                    this.TargetValue.Equals(input.TargetValue))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PreviousValue != null)
                    hashCode = hashCode * 59 + this.PreviousValue.GetHashCode();
                if (this.TargetValue != null)
                    hashCode = hashCode * 59 + this.TargetValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
