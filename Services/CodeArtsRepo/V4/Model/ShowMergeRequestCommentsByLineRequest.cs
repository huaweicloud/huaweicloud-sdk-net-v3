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
    /// Request Object
    /// </summary>
    public class ShowMergeRequestCommentsByLineRequest 
    {
        /// <summary>
        /// Defines view
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ViewEnum>))]
        public class ViewEnum
        {
            /// <summary>
            /// Enum BASIC for value: basic
            /// </summary>
            public static readonly ViewEnum BASIC = new ViewEnum("basic");

            private static readonly Dictionary<string, ViewEnum> StaticFields =
            new Dictionary<string, ViewEnum>()
            {
                { "basic", BASIC },
            };

            private string _value;

            public ViewEnum()
            {

            }

            public ViewEnum(string value)
            {
                _value = value;
            }

            public static ViewEnum FromValue(string value)
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

                if (this.Equals(obj as ViewEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ViewEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ViewEnum a, ViewEnum b)
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

            public static bool operator !=(ViewEnum a, ViewEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：**  合并请求 iid。
        /// </summary>
        [SDKProperty("merge_request_iid", IsPath = true)]
        [JsonProperty("merge_request_iid", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequestIid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("line", IsQuery = true)]
        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public int? Line { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("with_commit_comments", IsQuery = true)]
        [JsonProperty("with_commit_comments", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithCommitComments { get; set; }

        /// <summary>
        /// **参数解释：** 文件路径。 **取值范围：** 字符串长度不少于1，不超过100000。
        /// </summary>
        [SDKProperty("path", IsQuery = true)]
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("view", IsQuery = true)]
        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public ViewEnum View { get; set; }
        /// <summary>
        /// 合并请求中原分支与目标分支的共同基准点
        /// </summary>
        [SDKProperty("base_sha", IsQuery = true)]
        [JsonProperty("base_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseSha { get; set; }

        /// <summary>
        /// 合并请求中，从共同基准点开始到原分支方向的第一个提交点
        /// </summary>
        [SDKProperty("start_sha", IsQuery = true)]
        [JsonProperty("start_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string StartSha { get; set; }

        /// <summary>
        /// 合并请求中原分支指向的提交点
        /// </summary>
        [SDKProperty("head_sha", IsQuery = true)]
        [JsonProperty("head_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string HeadSha { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMergeRequestCommentsByLineRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  mergeRequestIid: ").Append(MergeRequestIid).Append("\n");
            sb.Append("  line: ").Append(Line).Append("\n");
            sb.Append("  withCommitComments: ").Append(WithCommitComments).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  view: ").Append(View).Append("\n");
            sb.Append("  baseSha: ").Append(BaseSha).Append("\n");
            sb.Append("  startSha: ").Append(StartSha).Append("\n");
            sb.Append("  headSha: ").Append(HeadSha).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMergeRequestCommentsByLineRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMergeRequestCommentsByLineRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.MergeRequestIid != input.MergeRequestIid || (this.MergeRequestIid != null && !this.MergeRequestIid.Equals(input.MergeRequestIid))) return false;
            if (this.Line != input.Line || (this.Line != null && !this.Line.Equals(input.Line))) return false;
            if (this.WithCommitComments != input.WithCommitComments || (this.WithCommitComments != null && !this.WithCommitComments.Equals(input.WithCommitComments))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.View != input.View) return false;
            if (this.BaseSha != input.BaseSha || (this.BaseSha != null && !this.BaseSha.Equals(input.BaseSha))) return false;
            if (this.StartSha != input.StartSha || (this.StartSha != null && !this.StartSha.Equals(input.StartSha))) return false;
            if (this.HeadSha != input.HeadSha || (this.HeadSha != null && !this.HeadSha.Equals(input.HeadSha))) return false;

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
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.MergeRequestIid != null) hashCode = hashCode * 59 + this.MergeRequestIid.GetHashCode();
                if (this.Line != null) hashCode = hashCode * 59 + this.Line.GetHashCode();
                if (this.WithCommitComments != null) hashCode = hashCode * 59 + this.WithCommitComments.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                hashCode = hashCode * 59 + this.View.GetHashCode();
                if (this.BaseSha != null) hashCode = hashCode * 59 + this.BaseSha.GetHashCode();
                if (this.StartSha != null) hashCode = hashCode * 59 + this.StartSha.GetHashCode();
                if (this.HeadSha != null) hashCode = hashCode * 59 + this.HeadSha.GetHashCode();
                return hashCode;
            }
        }
    }
}
