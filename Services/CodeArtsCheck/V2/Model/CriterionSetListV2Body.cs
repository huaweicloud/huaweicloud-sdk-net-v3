using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CriterionSetListV2Body 
    {

        /// <summary>
        /// **参数解释：** 规则集ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 规则集中文名称。 **取值范围：** 任意中英文字符，数字，点，连字符和下划线组成的字符串，长度为[1~128]个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 规则集中文描述。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("comments", NullValueHandling = NullValueHandling.Ignore)]
        public string Comments { get; set; }

        /// <summary>
        /// **参数解释：** 规则集类型。 **取值范围：** - system：系统规则集。 - custom：自定义规则集。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 规则集创建者。 **取值范围：** 用户名。
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// **参数解释：** 规则集创建时间。 **取值范围：** 0时区标准时间。
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// **参数解释：** 规则集最近一次更新的操作人。 **取值范围：** 用户名。
        /// </summary>
        [JsonProperty("lastReviser", NullValueHandling = NullValueHandling.Ignore)]
        public string LastReviser { get; set; }

        /// <summary>
        /// **参数解释：** 规则集最近一次更新的时间。 **取值范围：** 0时区标准时间。
        /// </summary>
        [JsonProperty("lastUpdateTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// **参数解释：** 规则集语言。 **取值范围：** - ARKTS - C# - CANGJIE - C++ - CSS - GO - HTML - JAVA - JAVASCRIPT - KOTLIN - LUA - PHP - PYTHON - RUST - SCALA - SHELL - SQL - TERRAFORM - TYPESCRIPT - AZURERESOURCEMANAGER - DOCKER - KUBERNETES
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// **参数解释：** 父规则集ID。 **取值范围：** 32位UUID组成的字符串。多个ID之间用逗号分隔。
        /// </summary>
        [JsonProperty("parentId", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// **参数解释：** 规则集中已启用的规则数量。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("numCriterion", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumCriterion { get; set; }

        /// <summary>
        /// **参数解释：** 当前用户是否具有修改该规则集的权限。 **取值范围：** - true：有编辑的权限。 - false：没有编辑的权限。
        /// </summary>
        [JsonProperty("canEdit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// **参数解释：** 当前用户是否具有删除该规则集的权限。 **取值范围：** - true：有删除的权限。 - false：没有删除的权限。
        /// </summary>
        [JsonProperty("canDelete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// **参数解释：** 规则集管理员。 **取值范围：** 用户ID。多个ID用逗号分隔。
        /// </summary>
        [JsonProperty("managers", NullValueHandling = NullValueHandling.Ignore)]
        public string Managers { get; set; }

        /// <summary>
        /// **参数解释：** 父规则集的名称。 **取值范围：** 多个规则集名称之间用逗号分隔。
        /// </summary>
        [JsonProperty("parentSetNames", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentSetNames { get; set; }

        /// <summary>
        /// **参数解释：** 租户ID，租户ID的值来源于IAM的租户ID。 **取值范围：** 32位UUID。
        /// </summary>
        [JsonProperty("domainId", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释：** 规则集创建时候的继承类型。 **取值范围：** - strong：规则集创建的时候来源于继承。 - null：规则集创建的时候来源于非继承。
        /// </summary>
        [JsonProperty("inheritMode", NullValueHandling = NullValueHandling.Ignore)]
        public string InheritMode { get; set; }

        /// <summary>
        /// **参数解释：** 创建者用户ID。 **取值范围：** 32位UUID。
        /// </summary>
        [JsonProperty("creatorId", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// **参数解释：** 是否为系统默认规则集。 **取值范围：** - 0：否。 - 1：是。
        /// </summary>
        [JsonProperty("isSystemDefault", NullValueHandling = NullValueHandling.Ignore)]
        public string IsSystemDefault { get; set; }

        /// <summary>
        /// **参数解释：** 是否为项目默认规则集。 **取值范围：** - 0：否。 - 1：是。
        /// </summary>
        [JsonProperty("isProjectDefault", NullValueHandling = NullValueHandling.Ignore)]
        public string IsProjectDefault { get; set; }

        /// <summary>
        /// **参数解释：** 是否为系统规则集。 **取值范围：** - 0：否。 - 1：是。
        /// </summary>
        [JsonProperty("isSystemSet", NullValueHandling = NullValueHandling.Ignore)]
        public string IsSystemSet { get; set; }

        /// <summary>
        /// **参数解释：** 规则集中已启用的能力规则unique_id。 **取值范围：** unique_id为32位UUID。多个unique_id之间用逗号分隔。
        /// </summary>
        [JsonProperty("ruleIds", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleIds { get; set; }

        /// <summary>
        /// **参数解释：** 规则集所在局点。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释：** 是否具有设置默认规则集的权限。 **取值范围：** - true：有权限。 - false：没有权限。
        /// </summary>
        [JsonProperty("canSetDefault", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanSetDefault { get; set; }

        /// <summary>
        /// **参数解释：** 规则集是否被使用。 **取值范围：** - true：规则集被使用。 - false：规则集未被使用。
        /// </summary>
        [JsonProperty("isUsed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUsed { get; set; }

        /// <summary>
        /// **参数解释：** 子规则集。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("childSets", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ChildSets { get; set; }

        /// <summary>
        /// **参数解释：** 是否为可信规则集。该字段已弃用。 **取值范围：** - true：是。 - false：否。
        /// </summary>
        [JsonProperty("isReliable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReliable { get; set; }

        /// <summary>
        /// **参数解释：** 是否为推荐规则集。该字段已弃用。 **取值范围：** - 1：是。 - 0：否。
        /// </summary>
        [JsonProperty("isRecommand", NullValueHandling = NullValueHandling.Ignore)]
        public string IsRecommand { get; set; }

        /// <summary>
        /// **参数解释：** 是否为默认规则集。该字段已弃用。 **取值范围：** - true：是。 - false：否。
        /// </summary>
        [JsonProperty("isDefault", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// **参数解释：** 是否为默认规则集。该字段已弃用。 **取值范围：** - \&quot;true\&quot;：是。 - \&quot;false\&quot;：否。
        /// </summary>
        [JsonProperty("defaultSet", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultSet { get; set; }

        /// <summary>
        /// **参数解释：** 该字段已弃用。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("deptId", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptId { get; set; }

        /// <summary>
        /// **参数解释：** 该字段已弃用。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// **参数解释：** 该字段已弃用。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("reliableTag", NullValueHandling = NullValueHandling.Ignore)]
        public string ReliableTag { get; set; }

        /// <summary>
        /// **参数解释：** 该字段已弃用。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("recommandType", NullValueHandling = NullValueHandling.Ignore)]
        public string RecommandType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CriterionSetListV2Body {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  comments: ").Append(Comments).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastReviser: ").Append(LastReviser).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  numCriterion: ").Append(NumCriterion).Append("\n");
            sb.Append("  canEdit: ").Append(CanEdit).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  managers: ").Append(Managers).Append("\n");
            sb.Append("  parentSetNames: ").Append(ParentSetNames).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  inheritMode: ").Append(InheritMode).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  isSystemDefault: ").Append(IsSystemDefault).Append("\n");
            sb.Append("  isProjectDefault: ").Append(IsProjectDefault).Append("\n");
            sb.Append("  isSystemSet: ").Append(IsSystemSet).Append("\n");
            sb.Append("  ruleIds: ").Append(RuleIds).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  canSetDefault: ").Append(CanSetDefault).Append("\n");
            sb.Append("  isUsed: ").Append(IsUsed).Append("\n");
            sb.Append("  childSets: ").Append(ChildSets).Append("\n");
            sb.Append("  isReliable: ").Append(IsReliable).Append("\n");
            sb.Append("  isRecommand: ").Append(IsRecommand).Append("\n");
            sb.Append("  isDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  defaultSet: ").Append(DefaultSet).Append("\n");
            sb.Append("  deptId: ").Append(DeptId).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  reliableTag: ").Append(ReliableTag).Append("\n");
            sb.Append("  recommandType: ").Append(RecommandType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CriterionSetListV2Body);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CriterionSetListV2Body input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Comments != input.Comments || (this.Comments != null && !this.Comments.Equals(input.Comments))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LastReviser != input.LastReviser || (this.LastReviser != null && !this.LastReviser.Equals(input.LastReviser))) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.NumCriterion != input.NumCriterion || (this.NumCriterion != null && !this.NumCriterion.Equals(input.NumCriterion))) return false;
            if (this.CanEdit != input.CanEdit || (this.CanEdit != null && !this.CanEdit.Equals(input.CanEdit))) return false;
            if (this.CanDelete != input.CanDelete || (this.CanDelete != null && !this.CanDelete.Equals(input.CanDelete))) return false;
            if (this.Managers != input.Managers || (this.Managers != null && !this.Managers.Equals(input.Managers))) return false;
            if (this.ParentSetNames != input.ParentSetNames || (this.ParentSetNames != null && !this.ParentSetNames.Equals(input.ParentSetNames))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.InheritMode != input.InheritMode || (this.InheritMode != null && !this.InheritMode.Equals(input.InheritMode))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.IsSystemDefault != input.IsSystemDefault || (this.IsSystemDefault != null && !this.IsSystemDefault.Equals(input.IsSystemDefault))) return false;
            if (this.IsProjectDefault != input.IsProjectDefault || (this.IsProjectDefault != null && !this.IsProjectDefault.Equals(input.IsProjectDefault))) return false;
            if (this.IsSystemSet != input.IsSystemSet || (this.IsSystemSet != null && !this.IsSystemSet.Equals(input.IsSystemSet))) return false;
            if (this.RuleIds != input.RuleIds || (this.RuleIds != null && !this.RuleIds.Equals(input.RuleIds))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.CanSetDefault != input.CanSetDefault || (this.CanSetDefault != null && !this.CanSetDefault.Equals(input.CanSetDefault))) return false;
            if (this.IsUsed != input.IsUsed || (this.IsUsed != null && !this.IsUsed.Equals(input.IsUsed))) return false;
            if (this.ChildSets != input.ChildSets || (this.ChildSets != null && input.ChildSets != null && !this.ChildSets.SequenceEqual(input.ChildSets))) return false;
            if (this.IsReliable != input.IsReliable || (this.IsReliable != null && !this.IsReliable.Equals(input.IsReliable))) return false;
            if (this.IsRecommand != input.IsRecommand || (this.IsRecommand != null && !this.IsRecommand.Equals(input.IsRecommand))) return false;
            if (this.IsDefault != input.IsDefault || (this.IsDefault != null && !this.IsDefault.Equals(input.IsDefault))) return false;
            if (this.DefaultSet != input.DefaultSet || (this.DefaultSet != null && !this.DefaultSet.Equals(input.DefaultSet))) return false;
            if (this.DeptId != input.DeptId || (this.DeptId != null && !this.DeptId.Equals(input.DeptId))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.ReliableTag != input.ReliableTag || (this.ReliableTag != null && !this.ReliableTag.Equals(input.ReliableTag))) return false;
            if (this.RecommandType != input.RecommandType || (this.RecommandType != null && !this.RecommandType.Equals(input.RecommandType))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Comments != null) hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastReviser != null) hashCode = hashCode * 59 + this.LastReviser.GetHashCode();
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.NumCriterion != null) hashCode = hashCode * 59 + this.NumCriterion.GetHashCode();
                if (this.CanEdit != null) hashCode = hashCode * 59 + this.CanEdit.GetHashCode();
                if (this.CanDelete != null) hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.Managers != null) hashCode = hashCode * 59 + this.Managers.GetHashCode();
                if (this.ParentSetNames != null) hashCode = hashCode * 59 + this.ParentSetNames.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.InheritMode != null) hashCode = hashCode * 59 + this.InheritMode.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.IsSystemDefault != null) hashCode = hashCode * 59 + this.IsSystemDefault.GetHashCode();
                if (this.IsProjectDefault != null) hashCode = hashCode * 59 + this.IsProjectDefault.GetHashCode();
                if (this.IsSystemSet != null) hashCode = hashCode * 59 + this.IsSystemSet.GetHashCode();
                if (this.RuleIds != null) hashCode = hashCode * 59 + this.RuleIds.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.CanSetDefault != null) hashCode = hashCode * 59 + this.CanSetDefault.GetHashCode();
                if (this.IsUsed != null) hashCode = hashCode * 59 + this.IsUsed.GetHashCode();
                if (this.ChildSets != null) hashCode = hashCode * 59 + this.ChildSets.GetHashCode();
                if (this.IsReliable != null) hashCode = hashCode * 59 + this.IsReliable.GetHashCode();
                if (this.IsRecommand != null) hashCode = hashCode * 59 + this.IsRecommand.GetHashCode();
                if (this.IsDefault != null) hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                if (this.DefaultSet != null) hashCode = hashCode * 59 + this.DefaultSet.GetHashCode();
                if (this.DeptId != null) hashCode = hashCode * 59 + this.DeptId.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.ReliableTag != null) hashCode = hashCode * 59 + this.ReliableTag.GetHashCode();
                if (this.RecommandType != null) hashCode = hashCode * 59 + this.RecommandType.GetHashCode();
                return hashCode;
            }
        }
    }
}
