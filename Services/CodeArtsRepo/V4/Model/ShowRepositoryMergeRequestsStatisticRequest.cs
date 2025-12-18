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
    public class ShowRepositoryMergeRequestsStatisticRequest 
    {
        /// <summary>
        /// **参数解释：** 统计字段。 **约束限制 ** - commits_count，统计提交数 - changed_files_count，文件变更数 - notes_count， 检视意见数 - changed_lines_count，代码变更行数
        /// </summary>
        /// <value>**参数解释：** 统计字段。 **约束限制 ** - commits_count，统计提交数 - changed_files_count，文件变更数 - notes_count， 检视意见数 - changed_lines_count，代码变更行数</value>
        [JsonConverter(typeof(EnumClassConverter<FieldsEnum>))]
        public class FieldsEnum
        {
            /// <summary>
            /// Enum COMMITS_COUNT for value: commits_count
            /// </summary>
            public static readonly FieldsEnum COMMITS_COUNT = new FieldsEnum("commits_count");

            /// <summary>
            /// Enum CHANGED_FILES_COUNT for value: changed_files_count
            /// </summary>
            public static readonly FieldsEnum CHANGED_FILES_COUNT = new FieldsEnum("changed_files_count");

            /// <summary>
            /// Enum NOTES_COUNT for value: notes_count
            /// </summary>
            public static readonly FieldsEnum NOTES_COUNT = new FieldsEnum("notes_count");

            /// <summary>
            /// Enum CHANGED_LINES_COUNT for value: changed_lines_count
            /// </summary>
            public static readonly FieldsEnum CHANGED_LINES_COUNT = new FieldsEnum("changed_lines_count");

            private static readonly Dictionary<string, FieldsEnum> StaticFields =
            new Dictionary<string, FieldsEnum>()
            {
                { "commits_count", COMMITS_COUNT },
                { "changed_files_count", CHANGED_FILES_COUNT },
                { "notes_count", NOTES_COUNT },
                { "changed_lines_count", CHANGED_LINES_COUNT },
            };

            private string _value;

            public FieldsEnum()
            {

            }

            public FieldsEnum(string value)
            {
                _value = value;
            }

            public static FieldsEnum FromValue(string value)
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

                if (this.Equals(obj as FieldsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FieldsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FieldsEnum a, FieldsEnum b)
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

            public static bool operator !=(FieldsEnum a, FieldsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[[查询用户所有仓库](https://support.huaweicloud.com/eu/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_eu)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求iid。
        /// </summary>
        [SDKProperty("iids", IsQuery = true)]
        [JsonProperty("iids", NullValueHandling = NullValueHandling.Ignore)]
        public string Iids { get; set; }

        /// <summary>
        /// **参数解释：** 统计字段。 **约束限制 ** - commits_count，统计提交数 - changed_files_count，文件变更数 - notes_count， 检视意见数 - changed_lines_count，代码变更行数
        /// </summary>
        [SDKProperty("fields", IsQuery = true)]
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public FieldsEnum Fields { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRepositoryMergeRequestsStatisticRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  iids: ").Append(Iids).Append("\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRepositoryMergeRequestsStatisticRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRepositoryMergeRequestsStatisticRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.Iids != input.Iids || (this.Iids != null && !this.Iids.Equals(input.Iids))) return false;
            if (this.Fields != input.Fields) return false;

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
                if (this.Iids != null) hashCode = hashCode * 59 + this.Iids.GetHashCode();
                hashCode = hashCode * 59 + this.Fields.GetHashCode();
                return hashCode;
            }
        }
    }
}
