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
    /// 调用返回结果。
    /// </summary>
    public class IvsStandardByIdCardImageResponseBodyResult 
    {

        /// <summary>
        /// 子服务名称。
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 成功的结果数量，与resp_data字段对应。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 请求列表，用于支持批量调用。目前暂时只支持单个数据查询。
        /// </summary>
        [JsonProperty("resp_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<RespDataByIdCardImage> RespData { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IvsStandardByIdCardImageResponseBodyResult {\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  respData: ").Append(RespData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IvsStandardByIdCardImageResponseBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IvsStandardByIdCardImageResponseBodyResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.RespData == input.RespData ||
                    this.RespData != null &&
                    input.RespData != null &&
                    this.RespData.SequenceEqual(input.RespData)
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
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.RespData != null)
                    hashCode = hashCode * 59 + this.RespData.GetHashCode();
                return hashCode;
            }
        }
    }
}
