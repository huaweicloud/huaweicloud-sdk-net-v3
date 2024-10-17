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
    public class ListJobHistoryParametersResponse : SdkResponse
    {

        /// <summary>
        /// 历史记录总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 任务参数历史修改列表
        /// </summary>
        [JsonProperty("parameter_history_config_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListJobHistoryParameter> ParameterHistoryConfigList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListJobHistoryParametersResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  parameterHistoryConfigList: ").Append(ParameterHistoryConfigList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListJobHistoryParametersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListJobHistoryParametersResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.ParameterHistoryConfigList != input.ParameterHistoryConfigList || (this.ParameterHistoryConfigList != null && input.ParameterHistoryConfigList != null && !this.ParameterHistoryConfigList.SequenceEqual(input.ParameterHistoryConfigList))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.ParameterHistoryConfigList != null) hashCode = hashCode * 59 + this.ParameterHistoryConfigList.GetHashCode();
                return hashCode;
            }
        }
    }
}
