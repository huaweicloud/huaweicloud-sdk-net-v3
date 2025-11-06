using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ImportMrParamsDto 
    {
        /// <summary>
        /// 状态
        /// </summary>
        /// <value>状态</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum OPENED for value: opened
            /// </summary>
            public static readonly StateEnum OPENED = new StateEnum("opened");

            /// <summary>
            /// Enum CLOSED for value: closed
            /// </summary>
            public static readonly StateEnum CLOSED = new StateEnum("closed");

            /// <summary>
            /// Enum MERGED for value: merged
            /// </summary>
            public static readonly StateEnum MERGED = new StateEnum("merged");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "opened", OPENED },
                { "closed", CLOSED },
                { "merged", MERGED },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 合并请求iid
        /// </summary>
        [JsonProperty("iid", NullValueHandling = NullValueHandling.Ignore)]
        public int? Iid { get; set; }

        /// <summary>
        /// 导入唯一标识
        /// </summary>
        [JsonProperty("source_uniq_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceUniqKey { get; set; }

        /// <summary>
        /// 作者id
        /// </summary>
        [JsonProperty("author_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AuthorId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 源分支
        /// </summary>
        [JsonProperty("source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// 目标分支
        /// </summary>
        [JsonProperty("target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// 目标仓库
        /// </summary>
        [JsonProperty("target_repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetRepositoryId { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Object Labels { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 合并时间
        /// </summary>
        [JsonProperty("merged_at", NullValueHandling = NullValueHandling.Ignore)]
        public string MergedAt { get; set; }

        /// <summary>
        /// 关闭时间
        /// </summary>
        [JsonProperty("closed_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ClosedAt { get; set; }

        /// <summary>
        /// 审核人列表
        /// </summary>
        [JsonProperty("approvers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApproverParamDto> Approvers { get; set; }

        /// <summary>
        /// 合并请求变更commit列表
        /// </summary>
        [JsonProperty("diff_refs", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiffRefsParamDto> DiffRefs { get; set; }

        /// <summary>
        /// squash合并
        /// </summary>
        [JsonProperty("squash", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Squash { get; set; }

        /// <summary>
        /// 合并mr后删除源分支
        /// </summary>
        [JsonProperty("remove_source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemoveSourceBranch { get; set; }

        /// <summary>
        /// 源分支是否被删除
        /// </summary>
        [JsonProperty("branch_is_deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BranchIsDeleted { get; set; }

        /// <summary>
        /// 源合并请求是否是fork合并请求
        /// </summary>
        [JsonProperty("fork", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fork { get; set; }

        /// <summary>
        /// 导入来源
        /// </summary>
        [JsonProperty("import_source_from", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportSourceFrom { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportMrParamsDto {\n");
            sb.Append("  iid: ").Append(Iid).Append("\n");
            sb.Append("  sourceUniqKey: ").Append(SourceUniqKey).Append("\n");
            sb.Append("  authorId: ").Append(AuthorId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  sourceBranch: ").Append(SourceBranch).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("  targetRepositoryId: ").Append(TargetRepositoryId).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  mergedAt: ").Append(MergedAt).Append("\n");
            sb.Append("  closedAt: ").Append(ClosedAt).Append("\n");
            sb.Append("  approvers: ").Append(Approvers).Append("\n");
            sb.Append("  diffRefs: ").Append(DiffRefs).Append("\n");
            sb.Append("  squash: ").Append(Squash).Append("\n");
            sb.Append("  removeSourceBranch: ").Append(RemoveSourceBranch).Append("\n");
            sb.Append("  branchIsDeleted: ").Append(BranchIsDeleted).Append("\n");
            sb.Append("  fork: ").Append(Fork).Append("\n");
            sb.Append("  importSourceFrom: ").Append(ImportSourceFrom).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportMrParamsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportMrParamsDto input)
        {
            if (input == null) return false;
            if (this.Iid != input.Iid || (this.Iid != null && !this.Iid.Equals(input.Iid))) return false;
            if (this.SourceUniqKey != input.SourceUniqKey || (this.SourceUniqKey != null && !this.SourceUniqKey.Equals(input.SourceUniqKey))) return false;
            if (this.AuthorId != input.AuthorId || (this.AuthorId != null && !this.AuthorId.Equals(input.AuthorId))) return false;
            if (this.State != input.State) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.SourceBranch != input.SourceBranch || (this.SourceBranch != null && !this.SourceBranch.Equals(input.SourceBranch))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;
            if (this.TargetRepositoryId != input.TargetRepositoryId || (this.TargetRepositoryId != null && !this.TargetRepositoryId.Equals(input.TargetRepositoryId))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && !this.Labels.Equals(input.Labels))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.MergedAt != input.MergedAt || (this.MergedAt != null && !this.MergedAt.Equals(input.MergedAt))) return false;
            if (this.ClosedAt != input.ClosedAt || (this.ClosedAt != null && !this.ClosedAt.Equals(input.ClosedAt))) return false;
            if (this.Approvers != input.Approvers || (this.Approvers != null && input.Approvers != null && !this.Approvers.SequenceEqual(input.Approvers))) return false;
            if (this.DiffRefs != input.DiffRefs || (this.DiffRefs != null && input.DiffRefs != null && !this.DiffRefs.SequenceEqual(input.DiffRefs))) return false;
            if (this.Squash != input.Squash || (this.Squash != null && !this.Squash.Equals(input.Squash))) return false;
            if (this.RemoveSourceBranch != input.RemoveSourceBranch || (this.RemoveSourceBranch != null && !this.RemoveSourceBranch.Equals(input.RemoveSourceBranch))) return false;
            if (this.BranchIsDeleted != input.BranchIsDeleted || (this.BranchIsDeleted != null && !this.BranchIsDeleted.Equals(input.BranchIsDeleted))) return false;
            if (this.Fork != input.Fork || (this.Fork != null && !this.Fork.Equals(input.Fork))) return false;
            if (this.ImportSourceFrom != input.ImportSourceFrom || (this.ImportSourceFrom != null && !this.ImportSourceFrom.Equals(input.ImportSourceFrom))) return false;

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
                if (this.Iid != null) hashCode = hashCode * 59 + this.Iid.GetHashCode();
                if (this.SourceUniqKey != null) hashCode = hashCode * 59 + this.SourceUniqKey.GetHashCode();
                if (this.AuthorId != null) hashCode = hashCode * 59 + this.AuthorId.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SourceBranch != null) hashCode = hashCode * 59 + this.SourceBranch.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                if (this.TargetRepositoryId != null) hashCode = hashCode * 59 + this.TargetRepositoryId.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.MergedAt != null) hashCode = hashCode * 59 + this.MergedAt.GetHashCode();
                if (this.ClosedAt != null) hashCode = hashCode * 59 + this.ClosedAt.GetHashCode();
                if (this.Approvers != null) hashCode = hashCode * 59 + this.Approvers.GetHashCode();
                if (this.DiffRefs != null) hashCode = hashCode * 59 + this.DiffRefs.GetHashCode();
                if (this.Squash != null) hashCode = hashCode * 59 + this.Squash.GetHashCode();
                if (this.RemoveSourceBranch != null) hashCode = hashCode * 59 + this.RemoveSourceBranch.GetHashCode();
                if (this.BranchIsDeleted != null) hashCode = hashCode * 59 + this.BranchIsDeleted.GetHashCode();
                if (this.Fork != null) hashCode = hashCode * 59 + this.Fork.GetHashCode();
                if (this.ImportSourceFrom != null) hashCode = hashCode * 59 + this.ImportSourceFrom.GetHashCode();
                return hashCode;
            }
        }
    }
}
