using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateSubCustomerReqV2 
    {

        /// <summary>
        /// 企业子账号挂载的组织单元。 组织单元的Party ID，通过查询企业组织结构接口的响应获得。
        /// </summary>
        [JsonProperty("party_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PartyId { get; set; }

        /// <summary>
        /// 企业子账号的显示名称，不限制特殊字符。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 子账号关联类型：1：同一法人。 关联类型目前只能是同一法人。
        /// </summary>
        [JsonProperty("sub_customer_association_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubCustomerAssociationType { get; set; }

        /// <summary>
        /// 申请的权限列表。 支持的权限项请参见下表。当financial_custody为1时，此参数不生效，默认指定权限项：READ_FINANCE_INFO、READ_CONSUME_BILL、SHARE-BIZ-DISCOUNT-TO-SUB。
        /// </summary>
        [JsonProperty("permission_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PermissionIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("new_sub_customer", NullValueHandling = NullValueHandling.Ignore)]
        public NewCustomerV2 NewSubCustomer { get; set; }

        /// <summary>
        /// 是否开通财务托管，0：不开通；1：开通。默认值0，默认不开通。
        /// </summary>
        [JsonProperty("financial_custody", NullValueHandling = NullValueHandling.Ignore)]
        public int? FinancialCustody { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubCustomerReqV2 {\n");
            sb.Append("  partyId: ").Append(PartyId).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  subCustomerAssociationType: ").Append(SubCustomerAssociationType).Append("\n");
            sb.Append("  permissionIds: ").Append(PermissionIds).Append("\n");
            sb.Append("  newSubCustomer: ").Append(NewSubCustomer).Append("\n");
            sb.Append("  financialCustody: ").Append(FinancialCustody).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubCustomerReqV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubCustomerReqV2 input)
        {
            if (input == null) return false;
            if (this.PartyId != input.PartyId || (this.PartyId != null && !this.PartyId.Equals(input.PartyId))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.SubCustomerAssociationType != input.SubCustomerAssociationType || (this.SubCustomerAssociationType != null && !this.SubCustomerAssociationType.Equals(input.SubCustomerAssociationType))) return false;
            if (this.PermissionIds != input.PermissionIds || (this.PermissionIds != null && input.PermissionIds != null && !this.PermissionIds.SequenceEqual(input.PermissionIds))) return false;
            if (this.NewSubCustomer != input.NewSubCustomer || (this.NewSubCustomer != null && !this.NewSubCustomer.Equals(input.NewSubCustomer))) return false;
            if (this.FinancialCustody != input.FinancialCustody || (this.FinancialCustody != null && !this.FinancialCustody.Equals(input.FinancialCustody))) return false;

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
                if (this.PartyId != null) hashCode = hashCode * 59 + this.PartyId.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.SubCustomerAssociationType != null) hashCode = hashCode * 59 + this.SubCustomerAssociationType.GetHashCode();
                if (this.PermissionIds != null) hashCode = hashCode * 59 + this.PermissionIds.GetHashCode();
                if (this.NewSubCustomer != null) hashCode = hashCode * 59 + this.NewSubCustomer.GetHashCode();
                if (this.FinancialCustody != null) hashCode = hashCode * 59 + this.FinancialCustody.GetHashCode();
                return hashCode;
            }
        }
    }
}
