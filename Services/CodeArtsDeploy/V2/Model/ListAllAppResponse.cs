using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAllAppResponse : SdkResponse
    {

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// 应用列表数组
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public List<AppExecutionInfo> Result { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAllAppResponse {\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAllAppResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAllAppResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalNum == input.TotalNum ||
                    (this.TotalNum != null &&
                    this.TotalNum.Equals(input.TotalNum))
                ) && 
                (
                    this.Result == input.Result ||
                    this.Result != null &&
                    input.Result != null &&
                    this.Result.SequenceEqual(input.Result)
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
                if (this.TotalNum != null)
                    hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                return hashCode;
            }
        }
    }
}
