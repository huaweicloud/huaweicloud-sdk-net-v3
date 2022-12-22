using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ivs.V2.Model
{
    /// <summary>
    /// 请求消息的数据部分。
    /// </summary>
    public class IvsExtentionByNameAndIdRequestBodyData 
    {

        /// <summary>
        /// 请求列表，用于支持批量调用。目前暂时只支持单个数据查询。
        /// </summary>
        [JsonProperty("req_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtentionReqDataByNameAndId> ReqData { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IvsExtentionByNameAndIdRequestBodyData {\n");
            sb.Append("  reqData: ").Append(ReqData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IvsExtentionByNameAndIdRequestBodyData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IvsExtentionByNameAndIdRequestBodyData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReqData == input.ReqData ||
                    this.ReqData != null &&
                    input.ReqData != null &&
                    this.ReqData.SequenceEqual(input.ReqData)
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
                if (this.ReqData != null)
                    hashCode = hashCode * 59 + this.ReqData.GetHashCode();
                return hashCode;
            }
        }
    }
}
