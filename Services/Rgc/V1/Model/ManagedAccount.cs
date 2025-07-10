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
    /// 注册OU信息。
    /// </summary>
    public class ManagedAccount 
    {

        /// <summary>
        /// Landing Zone版本。
        /// </summary>
        [JsonProperty("landing_zone_version", NullValueHandling = NullValueHandling.Ignore)]
        public string LandingZoneVersion { get; set; }

        /// <summary>
        /// 管理纳管账号ID。
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
        /// 纳管账号类型。
        /// </summary>
        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountType { get; set; }

        /// <summary>
        /// 纳管账号的创建来源，包括CUSTOM和RGC。
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 纳管账号状态。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 错误状态描述信息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 父注册OU ID。
        /// </summary>
        [JsonProperty("parent_organizational_unit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentOrganizationalUnitId { get; set; }

        /// <summary>
        /// 父注册OU名称。
        /// </summary>
        [JsonProperty("parent_organizational_unit_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentOrganizationalUnitName { get; set; }

        /// <summary>
        /// Identity Center用户名。
        /// </summary>
        [JsonProperty("identity_store_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityStoreUserName { get; set; }

        /// <summary>
        /// 模板ID。
        /// </summary>
        [JsonProperty("blueprint_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BlueprintProductId { get; set; }

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
        /// 模板是否包含多账号资源。
        /// </summary>
        [JsonProperty("is_blueprint_has_multi_account_resource", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBlueprintHasMultiAccountResource { get; set; }

        /// <summary>
        /// 区域信息。
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<RegionManagedList> Regions { get; set; }

        /// <summary>
        /// 组织里某个注册OU下的纳管账号被创建的时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 组织里某个注册OU下的纳管账号最后一次更新的时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagedAccount {\n");
            sb.Append("  landingZoneVersion: ").Append(LandingZoneVersion).Append("\n");
            sb.Append("  manageAccountId: ").Append(ManageAccountId).Append("\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  accountType: ").Append(AccountType).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  parentOrganizationalUnitId: ").Append(ParentOrganizationalUnitId).Append("\n");
            sb.Append("  parentOrganizationalUnitName: ").Append(ParentOrganizationalUnitName).Append("\n");
            sb.Append("  identityStoreUserName: ").Append(IdentityStoreUserName).Append("\n");
            sb.Append("  blueprintProductId: ").Append(BlueprintProductId).Append("\n");
            sb.Append("  blueprintProductVersion: ").Append(BlueprintProductVersion).Append("\n");
            sb.Append("  blueprintStatus: ").Append(BlueprintStatus).Append("\n");
            sb.Append("  isBlueprintHasMultiAccountResource: ").Append(IsBlueprintHasMultiAccountResource).Append("\n");
            sb.Append("  regions: ").Append(Regions).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ManagedAccount);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ManagedAccount input)
        {
            if (input == null) return false;
            if (this.LandingZoneVersion != input.LandingZoneVersion || (this.LandingZoneVersion != null && !this.LandingZoneVersion.Equals(input.LandingZoneVersion))) return false;
            if (this.ManageAccountId != input.ManageAccountId || (this.ManageAccountId != null && !this.ManageAccountId.Equals(input.ManageAccountId))) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;
            if (this.AccountType != input.AccountType || (this.AccountType != null && !this.AccountType.Equals(input.AccountType))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.ParentOrganizationalUnitId != input.ParentOrganizationalUnitId || (this.ParentOrganizationalUnitId != null && !this.ParentOrganizationalUnitId.Equals(input.ParentOrganizationalUnitId))) return false;
            if (this.ParentOrganizationalUnitName != input.ParentOrganizationalUnitName || (this.ParentOrganizationalUnitName != null && !this.ParentOrganizationalUnitName.Equals(input.ParentOrganizationalUnitName))) return false;
            if (this.IdentityStoreUserName != input.IdentityStoreUserName || (this.IdentityStoreUserName != null && !this.IdentityStoreUserName.Equals(input.IdentityStoreUserName))) return false;
            if (this.BlueprintProductId != input.BlueprintProductId || (this.BlueprintProductId != null && !this.BlueprintProductId.Equals(input.BlueprintProductId))) return false;
            if (this.BlueprintProductVersion != input.BlueprintProductVersion || (this.BlueprintProductVersion != null && !this.BlueprintProductVersion.Equals(input.BlueprintProductVersion))) return false;
            if (this.BlueprintStatus != input.BlueprintStatus || (this.BlueprintStatus != null && !this.BlueprintStatus.Equals(input.BlueprintStatus))) return false;
            if (this.IsBlueprintHasMultiAccountResource != input.IsBlueprintHasMultiAccountResource || (this.IsBlueprintHasMultiAccountResource != null && !this.IsBlueprintHasMultiAccountResource.Equals(input.IsBlueprintHasMultiAccountResource))) return false;
            if (this.Regions != input.Regions || (this.Regions != null && input.Regions != null && !this.Regions.SequenceEqual(input.Regions))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.LandingZoneVersion != null) hashCode = hashCode * 59 + this.LandingZoneVersion.GetHashCode();
                if (this.ManageAccountId != null) hashCode = hashCode * 59 + this.ManageAccountId.GetHashCode();
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.AccountType != null) hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ParentOrganizationalUnitId != null) hashCode = hashCode * 59 + this.ParentOrganizationalUnitId.GetHashCode();
                if (this.ParentOrganizationalUnitName != null) hashCode = hashCode * 59 + this.ParentOrganizationalUnitName.GetHashCode();
                if (this.IdentityStoreUserName != null) hashCode = hashCode * 59 + this.IdentityStoreUserName.GetHashCode();
                if (this.BlueprintProductId != null) hashCode = hashCode * 59 + this.BlueprintProductId.GetHashCode();
                if (this.BlueprintProductVersion != null) hashCode = hashCode * 59 + this.BlueprintProductVersion.GetHashCode();
                if (this.BlueprintStatus != null) hashCode = hashCode * 59 + this.BlueprintStatus.GetHashCode();
                if (this.IsBlueprintHasMultiAccountResource != null) hashCode = hashCode * 59 + this.IsBlueprintHasMultiAccountResource.GetHashCode();
                if (this.Regions != null) hashCode = hashCode * 59 + this.Regions.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
