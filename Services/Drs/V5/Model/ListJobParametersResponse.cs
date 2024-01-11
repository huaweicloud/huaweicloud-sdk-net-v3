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
    /// Response Object
    /// </summary>
    public class ListJobParametersResponse : SdkResponse
    {

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 任务参数列表
        /// </summary>
        [JsonProperty("parameter_config_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ParameterConfig> ParameterConfigList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListJobParametersResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  parameterConfigList: ").Append(ParameterConfigList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListJobParametersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListJobParametersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.ParameterConfigList == input.ParameterConfigList ||
                    this.ParameterConfigList != null &&
                    input.ParameterConfigList != null &&
                    this.ParameterConfigList.SequenceEqual(input.ParameterConfigList)
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.ParameterConfigList != null)
                    hashCode = hashCode * 59 + this.ParameterConfigList.GetHashCode();
                return hashCode;
            }
        }
    }
}
