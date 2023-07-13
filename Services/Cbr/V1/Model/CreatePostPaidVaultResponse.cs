using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreatePostPaidVaultResponse : SdkResponse
    {

        /// <summary>
        /// 订单详情
        /// </summary>
        [JsonProperty("orders", NullValueHandling = NullValueHandling.Ignore)]
        public List<CbcOrderResult> Orders { get; set; }

        /// <summary>
        /// 创建结果代码 0：成功
        /// </summary>
        [JsonProperty("retCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetCode { get; set; }

        /// <summary>
        /// 创建结果信息
        /// </summary>
        [JsonProperty("errText", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrText { get; set; }

        /// <summary>
        /// 操作错误码 0：无错误
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePostPaidVaultResponse {\n");
            sb.Append("  orders: ").Append(Orders).Append("\n");
            sb.Append("  retCode: ").Append(RetCode).Append("\n");
            sb.Append("  errText: ").Append(ErrText).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePostPaidVaultResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePostPaidVaultResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Orders == input.Orders ||
                    this.Orders != null &&
                    input.Orders != null &&
                    this.Orders.SequenceEqual(input.Orders)
                ) && 
                (
                    this.RetCode == input.RetCode ||
                    (this.RetCode != null &&
                    this.RetCode.Equals(input.RetCode))
                ) && 
                (
                    this.ErrText == input.ErrText ||
                    (this.ErrText != null &&
                    this.ErrText.Equals(input.ErrText))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
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
                if (this.Orders != null)
                    hashCode = hashCode * 59 + this.Orders.GetHashCode();
                if (this.RetCode != null)
                    hashCode = hashCode * 59 + this.RetCode.GetHashCode();
                if (this.ErrText != null)
                    hashCode = hashCode * 59 + this.ErrText.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
