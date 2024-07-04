using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckStarrocksParamsResponse : SdkResponse
    {

        /// <summary>
        /// 参数之间区别的集合。
        /// </summary>
        [JsonProperty("check_starrocks_params_responce", NullValueHandling = NullValueHandling.Ignore)]
        public List<ParamGroupParameterDifferences> CheckStarrocksParamsResponce { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckStarrocksParamsResponse {\n");
            sb.Append("  checkStarrocksParamsResponce: ").Append(CheckStarrocksParamsResponce).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckStarrocksParamsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckStarrocksParamsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CheckStarrocksParamsResponce == input.CheckStarrocksParamsResponce ||
                    this.CheckStarrocksParamsResponce != null &&
                    input.CheckStarrocksParamsResponce != null &&
                    this.CheckStarrocksParamsResponce.SequenceEqual(input.CheckStarrocksParamsResponce)
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
                if (this.CheckStarrocksParamsResponce != null)
                    hashCode = hashCode * 59 + this.CheckStarrocksParamsResponce.GetHashCode();
                return hashCode;
            }
        }
    }
}
