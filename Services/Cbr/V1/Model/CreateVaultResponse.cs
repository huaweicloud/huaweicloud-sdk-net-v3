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
    public class CreateVaultResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vault", NullValueHandling = NullValueHandling.Ignore)]
        public VaultCreateResource Vault { get; set; }

        /// <summary>
        /// 包周期创建订单信息（仅包周期创建时显示）
        /// </summary>
        [JsonProperty("orders", NullValueHandling = NullValueHandling.Ignore)]
        public List<CbcOrderResult> Orders { get; set; }

        /// <summary>
        /// 包周期订购结果（仅包周期创建时显示）
        /// </summary>
        [JsonProperty("retCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetCode { get; set; }

        /// <summary>
        /// 包周期创建错误信息（仅包周期创建时显示）
        /// </summary>
        [JsonProperty("errText", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrText { get; set; }

        /// <summary>
        /// 包周期创建错误码（仅包周期创建时显示）
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVaultResponse {\n");
            sb.Append("  vault: ").Append(Vault).Append("\n");
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
            return this.Equals(input as CreateVaultResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateVaultResponse input)
        {
            if (input == null) return false;
            if (this.Vault != input.Vault || (this.Vault != null && !this.Vault.Equals(input.Vault))) return false;
            if (this.Orders != input.Orders || (this.Orders != null && input.Orders != null && !this.Orders.SequenceEqual(input.Orders))) return false;
            if (this.RetCode != input.RetCode || (this.RetCode != null && !this.RetCode.Equals(input.RetCode))) return false;
            if (this.ErrText != input.ErrText || (this.ErrText != null && !this.ErrText.Equals(input.ErrText))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;

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
                if (this.Vault != null) hashCode = hashCode * 59 + this.Vault.GetHashCode();
                if (this.Orders != null) hashCode = hashCode * 59 + this.Orders.GetHashCode();
                if (this.RetCode != null) hashCode = hashCode * 59 + this.RetCode.GetHashCode();
                if (this.ErrText != null) hashCode = hashCode * 59 + this.ErrText.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
