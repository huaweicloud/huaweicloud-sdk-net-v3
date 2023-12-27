using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowShrinkCheckResultResponse : SdkResponse
    {

        /// <summary>
        /// 缩容检查是否通过
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }

        /// <summary>
        /// broker检查结果
        /// </summary>
        [JsonProperty("check_detail", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowShrinkCheckResponseBodyCheckDetail> CheckDetail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowShrinkCheckResultResponse {\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  checkDetail: ").Append(CheckDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowShrinkCheckResultResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowShrinkCheckResultResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.CheckDetail == input.CheckDetail ||
                    this.CheckDetail != null &&
                    input.CheckDetail != null &&
                    this.CheckDetail.SequenceEqual(input.CheckDetail)
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.CheckDetail != null)
                    hashCode = hashCode * 59 + this.CheckDetail.GetHashCode();
                return hashCode;
            }
        }
    }
}
