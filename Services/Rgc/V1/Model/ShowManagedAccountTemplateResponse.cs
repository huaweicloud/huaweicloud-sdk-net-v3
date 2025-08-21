using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowManagedAccountTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 管理员账号ID。
        /// </summary>
        [JsonProperty("manage_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManageAccountId { get; set; }

        /// <summary>
        /// 纳管账号ID。
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 纳管账号名称。
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// 模板ID。
        /// </summary>
        [JsonProperty("blueprint_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BlueprintProductId { get; set; }

        /// <summary>
        /// 模板名称。
        /// </summary>
        [JsonProperty("blueprint_product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BlueprintProductName { get; set; }

        /// <summary>
        /// 模板版本。
        /// </summary>
        [JsonProperty("blueprint_product_version", NullValueHandling = NullValueHandling.Ignore)]
        public string BlueprintProductVersion { get; set; }

        /// <summary>
        /// 模板部署状态，包括失败, 完成, 进行中。
        /// </summary>
        [JsonProperty("blueprint_status", NullValueHandling = NullValueHandling.Ignore)]
        public string BlueprintStatus { get; set; }

        /// <summary>
        /// 模板实现类型。
        /// </summary>
        [JsonProperty("blueprint_product_impl_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BlueprintProductImplType { get; set; }

        /// <summary>
        /// 模板详情
        /// </summary>
        [JsonProperty("blueprint_product_impl_detail", NullValueHandling = NullValueHandling.Ignore)]
        public string BlueprintProductImplDetail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowManagedAccountTemplateResponse {\n");
            sb.Append("  manageAccountId: ").Append(ManageAccountId).Append("\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  blueprintProductId: ").Append(BlueprintProductId).Append("\n");
            sb.Append("  blueprintProductName: ").Append(BlueprintProductName).Append("\n");
            sb.Append("  blueprintProductVersion: ").Append(BlueprintProductVersion).Append("\n");
            sb.Append("  blueprintStatus: ").Append(BlueprintStatus).Append("\n");
            sb.Append("  blueprintProductImplType: ").Append(BlueprintProductImplType).Append("\n");
            sb.Append("  blueprintProductImplDetail: ").Append(BlueprintProductImplDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowManagedAccountTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowManagedAccountTemplateResponse input)
        {
            if (input == null) return false;
            if (this.ManageAccountId != input.ManageAccountId || (this.ManageAccountId != null && !this.ManageAccountId.Equals(input.ManageAccountId))) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;
            if (this.BlueprintProductId != input.BlueprintProductId || (this.BlueprintProductId != null && !this.BlueprintProductId.Equals(input.BlueprintProductId))) return false;
            if (this.BlueprintProductName != input.BlueprintProductName || (this.BlueprintProductName != null && !this.BlueprintProductName.Equals(input.BlueprintProductName))) return false;
            if (this.BlueprintProductVersion != input.BlueprintProductVersion || (this.BlueprintProductVersion != null && !this.BlueprintProductVersion.Equals(input.BlueprintProductVersion))) return false;
            if (this.BlueprintStatus != input.BlueprintStatus || (this.BlueprintStatus != null && !this.BlueprintStatus.Equals(input.BlueprintStatus))) return false;
            if (this.BlueprintProductImplType != input.BlueprintProductImplType || (this.BlueprintProductImplType != null && !this.BlueprintProductImplType.Equals(input.BlueprintProductImplType))) return false;
            if (this.BlueprintProductImplDetail != input.BlueprintProductImplDetail || (this.BlueprintProductImplDetail != null && !this.BlueprintProductImplDetail.Equals(input.BlueprintProductImplDetail))) return false;

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
                if (this.ManageAccountId != null) hashCode = hashCode * 59 + this.ManageAccountId.GetHashCode();
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.BlueprintProductId != null) hashCode = hashCode * 59 + this.BlueprintProductId.GetHashCode();
                if (this.BlueprintProductName != null) hashCode = hashCode * 59 + this.BlueprintProductName.GetHashCode();
                if (this.BlueprintProductVersion != null) hashCode = hashCode * 59 + this.BlueprintProductVersion.GetHashCode();
                if (this.BlueprintStatus != null) hashCode = hashCode * 59 + this.BlueprintStatus.GetHashCode();
                if (this.BlueprintProductImplType != null) hashCode = hashCode * 59 + this.BlueprintProductImplType.GetHashCode();
                if (this.BlueprintProductImplDetail != null) hashCode = hashCode * 59 + this.BlueprintProductImplDetail.GetHashCode();
                return hashCode;
            }
        }
    }
}
