using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchShowParamsResponse : SdkResponse
    {

        /// <summary>
        /// 查询数据库参数响应体
        /// </summary>
        [JsonProperty("params_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryDbParamsResp> ParamsList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchShowParamsResponse {\n");
            sb.Append("  paramsList: ").Append(ParamsList).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchShowParamsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchShowParamsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParamsList == input.ParamsList ||
                    this.ParamsList != null &&
                    input.ParamsList != null &&
                    this.ParamsList.SequenceEqual(input.ParamsList)
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.ParamsList != null)
                    hashCode = hashCode * 59 + this.ParamsList.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
