using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IamAccount 
    {

        /// <summary>
        /// iam账号。
        /// </summary>
        [JsonProperty("iam_user", NullValueHandling = NullValueHandling.Ignore)]
        public string IamUser { get; set; }

        /// <summary>
        /// iam账号id。
        /// </summary>
        [JsonProperty("iam_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IamUserId { get; set; }

        /// <summary>
        /// iam账号权限。
        /// </summary>
        [JsonProperty("user_account", NullValueHandling = NullValueHandling.Ignore)]
        public string UserAccount { get; set; }

        /// <summary>
        /// iam账号token。
        /// </summary>
        [JsonProperty("iam_token", NullValueHandling = NullValueHandling.Ignore)]
        public string IamToken { get; set; }

        /// <summary>
        /// iamdomain账号。
        /// </summary>
        [JsonProperty("iam_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string IamDomain { get; set; }

        /// <summary>
        /// iamdomain账号id。
        /// </summary>
        [JsonProperty("iam_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IamDomainId { get; set; }

        /// <summary>
        /// iamxdomain账号id。
        /// </summary>
        [JsonProperty("iam_x_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IamXDomainId { get; set; }

        /// <summary>
        /// iamxdomain账号类型。
        /// </summary>
        [JsonProperty("iam_x_domain_type", NullValueHandling = NullValueHandling.Ignore)]
        public string IamXDomainType { get; set; }

        /// <summary>
        /// iam项目id。
        /// </summary>
        [JsonProperty("iam_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IamProjectId { get; set; }

        /// <summary>
        /// iam项目名称。
        /// </summary>
        [JsonProperty("iam_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IamProjectName { get; set; }

        /// <summary>
        /// 语言。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 实例id。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// assumed_by_domain_id。
        /// </summary>
        [JsonProperty("assumed_by_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssumedByDomainId { get; set; }

        /// <summary>
        /// assumed_by_user_id。
        /// </summary>
        [JsonProperty("assumed_by_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssumedByUserId { get; set; }

        /// <summary>
        /// assumed_by_user_name。
        /// </summary>
        [JsonProperty("assumed_by_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssumedByUserName { get; set; }

        /// <summary>
        /// 角色信息。
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// exclusive_project_id。
        /// </summary>
        [JsonProperty("exclusive_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExclusiveProjectId { get; set; }

        /// <summary>
        /// 是否支持eps。
        /// </summary>
        [JsonProperty("eps_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EpsEnable { get; set; }

        /// <summary>
        /// shared_project_name。
        /// </summary>
        [JsonProperty("shared_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SharedProjectName { get; set; }

        /// <summary>
        /// authorization。
        /// </summary>
        [JsonProperty("authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// 文本属性。
        /// </summary>
        [JsonProperty("context_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public string ContextAttributes { get; set; }

        /// <summary>
        /// 用户文件。
        /// </summary>
        [JsonProperty("user_profile", NullValueHandling = NullValueHandling.Ignore)]
        public string UserProfile { get; set; }

        /// <summary>
        /// sts_token。
        /// </summary>
        [JsonProperty("sts_token", NullValueHandling = NullValueHandling.Ignore)]
        public string StsToken { get; set; }

        /// <summary>
        /// access_key_id。
        /// </summary>
        [JsonProperty("access_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// secret_access_key。
        /// </summary>
        [JsonProperty("secret_access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// source_account。
        /// </summary>
        [JsonProperty("source_account", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceAccount { get; set; }

        /// <summary>
        /// source_urn。
        /// </summary>
        [JsonProperty("source_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceUrn { get; set; }

        /// <summary>
        /// request_proof。
        /// </summary>
        [JsonProperty("request_proof", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestProof { get; set; }

        /// <summary>
        /// x_project_id。
        /// </summary>
        [JsonProperty("x_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string XProjectId { get; set; }

        /// <summary>
        /// fulfillment_agency。
        /// </summary>
        [JsonProperty("fulfillment_agency", NullValueHandling = NullValueHandling.Ignore)]
        public string FulfillmentAgency { get; set; }

        /// <summary>
        /// operation_id。
        /// </summary>
        [JsonProperty("operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IamAccount {\n");
            sb.Append("  iamUser: ").Append(IamUser).Append("\n");
            sb.Append("  iamUserId: ").Append(IamUserId).Append("\n");
            sb.Append("  userAccount: ").Append(UserAccount).Append("\n");
            sb.Append("  iamToken: ").Append(IamToken).Append("\n");
            sb.Append("  iamDomain: ").Append(IamDomain).Append("\n");
            sb.Append("  iamDomainId: ").Append(IamDomainId).Append("\n");
            sb.Append("  iamXDomainId: ").Append(IamXDomainId).Append("\n");
            sb.Append("  iamXDomainType: ").Append(IamXDomainType).Append("\n");
            sb.Append("  iamProjectId: ").Append(IamProjectId).Append("\n");
            sb.Append("  iamProjectName: ").Append(IamProjectName).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  assumedByDomainId: ").Append(AssumedByDomainId).Append("\n");
            sb.Append("  assumedByUserId: ").Append(AssumedByUserId).Append("\n");
            sb.Append("  assumedByUserName: ").Append(AssumedByUserName).Append("\n");
            sb.Append("  roles: ").Append(Roles).Append("\n");
            sb.Append("  exclusiveProjectId: ").Append(ExclusiveProjectId).Append("\n");
            sb.Append("  epsEnable: ").Append(EpsEnable).Append("\n");
            sb.Append("  sharedProjectName: ").Append(SharedProjectName).Append("\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  contextAttributes: ").Append(ContextAttributes).Append("\n");
            sb.Append("  userProfile: ").Append(UserProfile).Append("\n");
            sb.Append("  stsToken: ").Append(StsToken).Append("\n");
            sb.Append("  accessKeyId: ").Append(AccessKeyId).Append("\n");
            sb.Append("  secretAccessKey: ").Append(SecretAccessKey).Append("\n");
            sb.Append("  sourceAccount: ").Append(SourceAccount).Append("\n");
            sb.Append("  sourceUrn: ").Append(SourceUrn).Append("\n");
            sb.Append("  requestProof: ").Append(RequestProof).Append("\n");
            sb.Append("  xProjectId: ").Append(XProjectId).Append("\n");
            sb.Append("  fulfillmentAgency: ").Append(FulfillmentAgency).Append("\n");
            sb.Append("  operationId: ").Append(OperationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IamAccount);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IamAccount input)
        {
            if (input == null) return false;
            if (this.IamUser != input.IamUser || (this.IamUser != null && !this.IamUser.Equals(input.IamUser))) return false;
            if (this.IamUserId != input.IamUserId || (this.IamUserId != null && !this.IamUserId.Equals(input.IamUserId))) return false;
            if (this.UserAccount != input.UserAccount || (this.UserAccount != null && !this.UserAccount.Equals(input.UserAccount))) return false;
            if (this.IamToken != input.IamToken || (this.IamToken != null && !this.IamToken.Equals(input.IamToken))) return false;
            if (this.IamDomain != input.IamDomain || (this.IamDomain != null && !this.IamDomain.Equals(input.IamDomain))) return false;
            if (this.IamDomainId != input.IamDomainId || (this.IamDomainId != null && !this.IamDomainId.Equals(input.IamDomainId))) return false;
            if (this.IamXDomainId != input.IamXDomainId || (this.IamXDomainId != null && !this.IamXDomainId.Equals(input.IamXDomainId))) return false;
            if (this.IamXDomainType != input.IamXDomainType || (this.IamXDomainType != null && !this.IamXDomainType.Equals(input.IamXDomainType))) return false;
            if (this.IamProjectId != input.IamProjectId || (this.IamProjectId != null && !this.IamProjectId.Equals(input.IamProjectId))) return false;
            if (this.IamProjectName != input.IamProjectName || (this.IamProjectName != null && !this.IamProjectName.Equals(input.IamProjectName))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.AssumedByDomainId != input.AssumedByDomainId || (this.AssumedByDomainId != null && !this.AssumedByDomainId.Equals(input.AssumedByDomainId))) return false;
            if (this.AssumedByUserId != input.AssumedByUserId || (this.AssumedByUserId != null && !this.AssumedByUserId.Equals(input.AssumedByUserId))) return false;
            if (this.AssumedByUserName != input.AssumedByUserName || (this.AssumedByUserName != null && !this.AssumedByUserName.Equals(input.AssumedByUserName))) return false;
            if (this.Roles != input.Roles || (this.Roles != null && input.Roles != null && !this.Roles.SequenceEqual(input.Roles))) return false;
            if (this.ExclusiveProjectId != input.ExclusiveProjectId || (this.ExclusiveProjectId != null && !this.ExclusiveProjectId.Equals(input.ExclusiveProjectId))) return false;
            if (this.EpsEnable != input.EpsEnable || (this.EpsEnable != null && !this.EpsEnable.Equals(input.EpsEnable))) return false;
            if (this.SharedProjectName != input.SharedProjectName || (this.SharedProjectName != null && !this.SharedProjectName.Equals(input.SharedProjectName))) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;
            if (this.ContextAttributes != input.ContextAttributes || (this.ContextAttributes != null && !this.ContextAttributes.Equals(input.ContextAttributes))) return false;
            if (this.UserProfile != input.UserProfile || (this.UserProfile != null && !this.UserProfile.Equals(input.UserProfile))) return false;
            if (this.StsToken != input.StsToken || (this.StsToken != null && !this.StsToken.Equals(input.StsToken))) return false;
            if (this.AccessKeyId != input.AccessKeyId || (this.AccessKeyId != null && !this.AccessKeyId.Equals(input.AccessKeyId))) return false;
            if (this.SecretAccessKey != input.SecretAccessKey || (this.SecretAccessKey != null && !this.SecretAccessKey.Equals(input.SecretAccessKey))) return false;
            if (this.SourceAccount != input.SourceAccount || (this.SourceAccount != null && !this.SourceAccount.Equals(input.SourceAccount))) return false;
            if (this.SourceUrn != input.SourceUrn || (this.SourceUrn != null && !this.SourceUrn.Equals(input.SourceUrn))) return false;
            if (this.RequestProof != input.RequestProof || (this.RequestProof != null && !this.RequestProof.Equals(input.RequestProof))) return false;
            if (this.XProjectId != input.XProjectId || (this.XProjectId != null && !this.XProjectId.Equals(input.XProjectId))) return false;
            if (this.FulfillmentAgency != input.FulfillmentAgency || (this.FulfillmentAgency != null && !this.FulfillmentAgency.Equals(input.FulfillmentAgency))) return false;
            if (this.OperationId != input.OperationId || (this.OperationId != null && !this.OperationId.Equals(input.OperationId))) return false;

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
                if (this.IamUser != null) hashCode = hashCode * 59 + this.IamUser.GetHashCode();
                if (this.IamUserId != null) hashCode = hashCode * 59 + this.IamUserId.GetHashCode();
                if (this.UserAccount != null) hashCode = hashCode * 59 + this.UserAccount.GetHashCode();
                if (this.IamToken != null) hashCode = hashCode * 59 + this.IamToken.GetHashCode();
                if (this.IamDomain != null) hashCode = hashCode * 59 + this.IamDomain.GetHashCode();
                if (this.IamDomainId != null) hashCode = hashCode * 59 + this.IamDomainId.GetHashCode();
                if (this.IamXDomainId != null) hashCode = hashCode * 59 + this.IamXDomainId.GetHashCode();
                if (this.IamXDomainType != null) hashCode = hashCode * 59 + this.IamXDomainType.GetHashCode();
                if (this.IamProjectId != null) hashCode = hashCode * 59 + this.IamProjectId.GetHashCode();
                if (this.IamProjectName != null) hashCode = hashCode * 59 + this.IamProjectName.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.AssumedByDomainId != null) hashCode = hashCode * 59 + this.AssumedByDomainId.GetHashCode();
                if (this.AssumedByUserId != null) hashCode = hashCode * 59 + this.AssumedByUserId.GetHashCode();
                if (this.AssumedByUserName != null) hashCode = hashCode * 59 + this.AssumedByUserName.GetHashCode();
                if (this.Roles != null) hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.ExclusiveProjectId != null) hashCode = hashCode * 59 + this.ExclusiveProjectId.GetHashCode();
                if (this.EpsEnable != null) hashCode = hashCode * 59 + this.EpsEnable.GetHashCode();
                if (this.SharedProjectName != null) hashCode = hashCode * 59 + this.SharedProjectName.GetHashCode();
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.ContextAttributes != null) hashCode = hashCode * 59 + this.ContextAttributes.GetHashCode();
                if (this.UserProfile != null) hashCode = hashCode * 59 + this.UserProfile.GetHashCode();
                if (this.StsToken != null) hashCode = hashCode * 59 + this.StsToken.GetHashCode();
                if (this.AccessKeyId != null) hashCode = hashCode * 59 + this.AccessKeyId.GetHashCode();
                if (this.SecretAccessKey != null) hashCode = hashCode * 59 + this.SecretAccessKey.GetHashCode();
                if (this.SourceAccount != null) hashCode = hashCode * 59 + this.SourceAccount.GetHashCode();
                if (this.SourceUrn != null) hashCode = hashCode * 59 + this.SourceUrn.GetHashCode();
                if (this.RequestProof != null) hashCode = hashCode * 59 + this.RequestProof.GetHashCode();
                if (this.XProjectId != null) hashCode = hashCode * 59 + this.XProjectId.GetHashCode();
                if (this.FulfillmentAgency != null) hashCode = hashCode * 59 + this.FulfillmentAgency.GetHashCode();
                if (this.OperationId != null) hashCode = hashCode * 59 + this.OperationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
