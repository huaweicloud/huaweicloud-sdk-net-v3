using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 任务实例信息体。
    /// </summary>
    public class JobNodeInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public JobNodeSpecInfo Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vpc", NullValueHandling = NullValueHandling.Ignore)]
        public JobNodeVpcInfo Vpc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("base_info", NullValueHandling = NullValueHandling.Ignore)]
        public JobNodeBaseInfo BaseInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobNodeInfo {\n");
            sb.Append("  spec: ").Append(Spec).Append("\n");
            sb.Append("  vpc: ").Append(Vpc).Append("\n");
            sb.Append("  baseInfo: ").Append(BaseInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobNodeInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobNodeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Spec == input.Spec ||
                    (this.Spec != null &&
                    this.Spec.Equals(input.Spec))
                ) && 
                (
                    this.Vpc == input.Vpc ||
                    (this.Vpc != null &&
                    this.Vpc.Equals(input.Vpc))
                ) && 
                (
                    this.BaseInfo == input.BaseInfo ||
                    (this.BaseInfo != null &&
                    this.BaseInfo.Equals(input.BaseInfo))
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
                if (this.Spec != null)
                    hashCode = hashCode * 59 + this.Spec.GetHashCode();
                if (this.Vpc != null)
                    hashCode = hashCode * 59 + this.Vpc.GetHashCode();
                if (this.BaseInfo != null)
                    hashCode = hashCode * 59 + this.BaseInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
